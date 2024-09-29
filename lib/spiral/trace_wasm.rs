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
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
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
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    LrcPtr<Trace::Mut3>,
                    LrcPtr<Trace::Mut4>,
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
                            LrcPtr<Trace::Mut4>,
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
                            LrcPtr<Trace::Mut4>,
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Trace::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<Trace::US0>,
    }
    impl core::fmt::Display for Trace::Mut4 {
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
    pub fn method1() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn closure1(unitVar: (), v0_1: string) -> Trace::US1 {
        Trace::US1::US1_0(v0_1)
    }
    pub fn method4() -> Func1<string, Trace::US1> {
        Func1::new(move |v: string| Trace::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        let v18: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v20: bool = true;
        let _result_map_ = v18.map(|x| {
            //;
            let v22: std::string::String = x;
            let v24: string = fable_library_rust::String_::fromString(v22);
            let v26: bool = true;
            v24
        });
        let v28: Result<string, std::env::VarError> = _result_map_;
        let v29: string = Trace::method3();
        v28.unwrap_or(v29)
    }
    pub fn method5() -> string {
        string("AUTOMATION")
    }
    pub fn closure2(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: Trace::US0,
    ) -> (
        LrcPtr<Trace::Mut0>,
        LrcPtr<Trace::Mut1>,
        LrcPtr<Trace::Mut2>,
        LrcPtr<Trace::Mut3>,
        LrcPtr<Trace::Mut4>,
        Option<i64>,
    ) {
        let _v1: (Trace::US2, Trace::US3) = (Trace::US2::US2_1, Trace::US3::US3_1);
        let v352: Trace::US3 = _v1.1.clone();
        let v351: Trace::US2 = _v1.0.clone();
        (
            LrcPtr::new(Trace::Mut0 {
                l0: MutCell::new(1_i64),
            }),
            LrcPtr::new(Trace::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Trace::closure2((), v))),
            }),
            LrcPtr::new(Trace::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Trace::Mut3 {
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Trace::Mut4 {
                l0: MutCell::new(match &v351 {
                    Trace::US2::US2_0(v351_0_0) => match &v351 {
                        Trace::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v352 {
                Trace::US3::US3_0(v352_0_0) => Some(match &v352 {
                    Trace::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if Trace::TraceState::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                LrcPtr<Trace::Mut4>,
                Option<i64>,
            ) = Trace::method0(Trace::US0::US0_0);
            Trace::TraceState::trace_state().set(Some((
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
    pub fn closure7(unitVar: (), v0_1: i64) -> Trace::US3 {
        Trace::US3::US3_0(v0_1)
    }
    pub fn method7() -> Func1<i64, Trace::US3> {
        Func1::new(move |v: i64| Trace::closure7((), v))
    }
    pub fn method8() -> string {
        string("hh:mm:ss")
    }
    pub fn method9() -> string {
        string("HH:mm:ss")
    }
    pub fn method6(
        v0_1: LrcPtr<Trace::Mut0>,
        v1_1: LrcPtr<Trace::Mut1>,
        v2_1: LrcPtr<Trace::Mut2>,
        v3: LrcPtr<Trace::Mut3>,
        v4: LrcPtr<Trace::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v81: Trace::US3 = defaultValue(Trace::US3::US3_1, map(Trace::method7(), v5));
        let v121: DateTime = match &v81 {
            Trace::US3::US3_0(v81_0_0) => {
                let v95: TimeSpan = TimeSpan::new_ticks(
                    {
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    } - match &v81 {
                        Trace::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                );
                DateTime::new_ymdhms_milli(
                    1_i32,
                    1_i32,
                    1_i32,
                    v95.hours(),
                    v95.minutes(),
                    v95.seconds(),
                    v95.milliseconds(),
                )
            }
            _ => DateTime::now(),
        };
        let provider: string = Trace::method8();
        v121.toString(provider)
    }
    pub fn method11() -> string {
        string("\u{001b}[0m")
    }
    pub fn method10(v0_1: Trace::US0) -> string {
        let v5: Trace::US1 = if if let Trace::US0::US0_0 = &v0_1 {
            true
        } else {
            false
        } {
            Trace::US1::US1_0(string("Verbose"))
        } else {
            Trace::US1::US1_1
        };
        let v46: Trace::US1 = match &v5 {
            Trace::US1::US1_0(v5_0_0) => Trace::US1::US1_0(match &v5 {
                Trace::US1::US1_0(x) => x.clone(),
                _ => unreachable!(),
            }),
            _ => {
                let v12: Trace::US1 = if if let Trace::US0::US0_1 = &v0_1 {
                    true
                } else {
                    false
                } {
                    Trace::US1::US1_0(string("Debug"))
                } else {
                    Trace::US1::US1_1
                };
                match &v12 {
                    Trace::US1::US1_0(v12_0_0) => Trace::US1::US1_0(match &v12 {
                        Trace::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v19: Trace::US1 = if if let Trace::US0::US0_2 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Trace::US1::US1_0(string("Info"))
                        } else {
                            Trace::US1::US1_1
                        };
                        match &v19 {
                            Trace::US1::US1_0(v19_0_0) => Trace::US1::US1_0(match &v19 {
                                Trace::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v26: Trace::US1 = if if let Trace::US0::US0_3 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Trace::US1::US1_0(string("Warning"))
                                } else {
                                    Trace::US1::US1_1
                                };
                                match &v26 {
                                    Trace::US1::US1_0(v26_0_0) => Trace::US1::US1_0(match &v26 {
                                        Trace::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                    _ => {
                                        let v33: Trace::US1 = if if let Trace::US0::US0_4 = &v0_1 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Trace::US1::US1_0(string("Critical"))
                                        } else {
                                            Trace::US1::US1_1
                                        };
                                        match &v33 {
                                            Trace::US1::US1_0(v33_0_0) => {
                                                Trace::US1::US1_0(match &v33 {
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
        let v55: string = padLeft(
            toLower(match &v46 {
                Trace::US1::US1_0(v46_0_0) => match &v46 {
                    Trace::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => panic!("{}", string("Option does not have a value."),),
            }),
            7_i32,
            ' ',
        );
        let v126: &str = match &v0_1 {
            Trace::US0::US0_1 => inline_colorization::color_bright_blue,
            Trace::US0::US0_2 => inline_colorization::color_bright_green,
            Trace::US0::US0_0 => inline_colorization::color_bright_black,
            Trace::US0::US0_3 => inline_colorization::color_yellow,
            _ => inline_colorization::color_bright_red,
        };
        let v131: &str = &*v55;
        let v149: &str = inline_colorization::color_reset;
        let v151: std::string::String = format!("{}{}{}", v126, v131, v149);
        fable_library_rust::String_::fromString(v151)
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure8(v0_1: LrcPtr<Trace::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method12(v0_1: string) -> string {
        let v2_1: LrcPtr<Trace::Mut3> = LrcPtr::new(Trace::Mut3 {
            l0: MutCell::new(Trace::method13()),
        });
        let v8: () = {
            Trace::closure8(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method14(v0_1: string, v1_1: string, v2_1: string, v3: i64, v4: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!("{} {} #{} {} / {}", v0_1, v1_1, v3, v2_1, v4),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure9(v0_1: LrcPtr<Trace::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure11(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure10(unitVar: (), v0_1: string) {
        let v3: () = {
            Trace::closure11(v0_1, ());
            ()
        };
        ()
    }
    pub fn method15(
        v0_1: string,
        v1_1: LrcPtr<Trace::Mut0>,
        v2_1: LrcPtr<Trace::Mut1>,
        v3: LrcPtr<Trace::Mut2>,
        v4: LrcPtr<Trace::Mut3>,
        v5: LrcPtr<Trace::Mut4>,
        v6: Option<i64>,
    ) {
        let v9: () = {
            Trace::closure9(v1_1, ());
            ()
        };
        println!("{}", v0_1.clone());
        ();
        (v2_1.l0.get().clone())(v0_1)
    }
    pub fn closure6(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>, unitVar: ()) {
        fn v4() {
            Trace::closure0((), ());
        }
        let v5: () = {
            v4();
            ()
        };
        let patternInput: (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            LrcPtr<Trace::Mut3>,
            LrcPtr<Trace::Mut4>,
            Option<i64>,
        ) = getValue(Trace::TraceState::trace_state().get().clone());
        let v37: Trace::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
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
                v37,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                    LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                    LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                    LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                    LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                ])))),
            )
        } {
            let v45: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                LrcPtr<Trace::Mut4>,
                Option<i64>,
            ) = getValue(Trace::TraceState::trace_state().get().clone());
            let v59: LrcPtr<Trace::Mut0> = patternInput_1.0.clone();
            let v77: string = Trace::method6(
                v59.clone(),
                patternInput_1.1.clone(),
                patternInput_1.2.clone(),
                patternInput_1.3.clone(),
                patternInput_1.4.clone(),
                patternInput_1.5.clone(),
            );
            let v78: string = Trace::method10(v0_1);
            let v79: string = v1_1();
            let v86: string = if v79.clone() == string("") {
                string("")
            } else {
                Trace::method14(v77, v78, v79, v59.l0.get().clone(), Trace::method12(v2_1()))
            };
            let v88: () = {
                v4();
                ()
            };
            let patternInput_2: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                LrcPtr<Trace::Mut4>,
                Option<i64>,
            ) = getValue(Trace::TraceState::trace_state().get().clone());
            Trace::method15(
                v86,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn closure5(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        let v5: () = {
            Trace::closure6(v0_1, v1_1, v2_1, ());
            ()
        };
        ()
    }
    pub fn closure4(v0_1: Trace::US0, v1_1: Func0<string>) -> Func1<Func0<string>, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: Func0<string>| Trace::closure5(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure3(
        unitVar: (),
        v0_1: Trace::US0,
    ) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<string>| Trace::closure4(v0_1.clone(), v)
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
    pub fn v16() -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v16: OnceInit<Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure3((), v)))
            .clone()
    }
    pub fn trace(x: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v16())(x)
    }
    on_startup!(());
}
