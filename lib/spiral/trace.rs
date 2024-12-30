pub mod Trace {
    use super::*;
    use fable_library_rust::DateTime_::DateTime;
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
    use fable_library_rust::Option_::map;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
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
    pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
        fn environ(&self) -> LrcPtr<dyn Any>;
    }
    impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
        #[inline]
        fn environ(&self) -> LrcPtr<dyn Any> {
            (**self).environ()
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US0 {
        US0_0,
        US0_1,
        US0_2,
        US0_3,
        US0_4,
    }
    impl core::fmt::Display for US0 {
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
        pub l0: MutCell<Trace::US0>,
    }
    impl core::fmt::Display for Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US1 {
        US1_0(Trace::US0),
        US1_1,
    }
    impl core::fmt::Display for US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
    }
    impl core::fmt::Display for US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US3 {
        US3_0,
        US3_1,
        US3_2,
    }
    impl core::fmt::Display for US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US4 {
        US4_0(Trace::US3),
        US4_1(Trace::US3),
        US4_2(Trace::US3),
        US4_3(Trace::US3),
        US4_4(Trace::US3),
    }
    impl core::fmt::Display for US4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US5 {
        US5_0(string),
        US5_1,
    }
    impl core::fmt::Display for US5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method3(v0_1: string) -> string {
        v0_1
    }
    pub fn method4() -> string {
        string("")
    }
    pub fn closure1(unitVar: (), v0_1: string) -> Trace::US5 {
        Trace::US5::US5_0(v0_1)
    }
    pub fn method5() -> Func1<string, Trace::US5> {
        Func1::new(move |v: string| Trace::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        let v2_1: string = Trace::method3(v0_1);
        let v4: Result<std::string::String, std::env::VarError> = std::env::var(&*v2_1);
        let v6: bool = true;
        let _result_map_ = v4.map(|x| {
            //;
            let v8: std::string::String = x;
            let v10: string = fable_library_rust::String_::fromString(v8);
            let v12: bool = true;
            v10
        });
        let v14: Result<string, std::env::VarError> = _result_map_;
        let v15: string = Trace::method4();
        v14.unwrap_or(v15)
    }
    pub fn method1() -> (Trace::US1, Trace::US2) {
        let v1_1: string = Trace::method2(string("TRACE_LEVEL"));
        let v6: Trace::US1 = if string("Verbose") == (v1_1.clone()) {
            Trace::US1::US1_0(Trace::US0::US0_0)
        } else {
            Trace::US1::US1_1
        };
        (
            match &v6 {
                Trace::US1::US1_0(v6_0_0) => Trace::US1::US1_0(
                    match &v6 {
                        Trace::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => {
                    let v13: Trace::US1 = if string("Debug") == (v1_1.clone()) {
                        Trace::US1::US1_0(Trace::US0::US0_1)
                    } else {
                        Trace::US1::US1_1
                    };
                    match &v13 {
                        Trace::US1::US1_0(v13_0_0) => Trace::US1::US1_0(
                            match &v13 {
                                Trace::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        ),
                        _ => {
                            let v20: Trace::US1 = if string("Info") == (v1_1.clone()) {
                                Trace::US1::US1_0(Trace::US0::US0_2)
                            } else {
                                Trace::US1::US1_1
                            };
                            match &v20 {
                                Trace::US1::US1_0(v20_0_0) => Trace::US1::US1_0(
                                    match &v20 {
                                        Trace::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ),
                                _ => {
                                    let v27: Trace::US1 = if string("Warning") == (v1_1.clone()) {
                                        Trace::US1::US1_0(Trace::US0::US0_3)
                                    } else {
                                        Trace::US1::US1_1
                                    };
                                    match &v27 {
                                        Trace::US1::US1_0(v27_0_0) => Trace::US1::US1_0(
                                            match &v27 {
                                                Trace::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        ),
                                        _ => {
                                            let v34: Trace::US1 =
                                                if string("Critical") == (v1_1.clone()) {
                                                    Trace::US1::US1_0(Trace::US0::US0_4)
                                                } else {
                                                    Trace::US1::US1_1
                                                };
                                            match &v34 {
                                                Trace::US1::US1_0(v34_0_0) => Trace::US1::US1_0(
                                                    match &v34 {
                                                        Trace::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                ),
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
            if (Trace::method2(string("AUTOMATION"))) != string("True") {
                Trace::US2::US2_1
            } else {
                Trace::US2::US2_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            },
        )
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
        let patternInput: (Trace::US1, Trace::US2) = Trace::method1();
        let _run_target_args__v1: (Trace::US1, Trace::US2) =
            (patternInput.0.clone(), patternInput.1.clone());
        let v132: Trace::US2 = _run_target_args__v1.1.clone();
        let v131: Trace::US1 = _run_target_args__v1.0.clone();
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
                l0: MutCell::new(match &v131 {
                    Trace::US1::US1_0(v131_0_0) => match &v131 {
                        Trace::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v0_1.clone(),
                }),
            }),
            match &v132 {
                Trace::US2::US2_0(v132_0_0) => Some(match &v132 {
                    Trace::US2::US2_0(x) => x.clone(),
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
    pub fn method6(v0_1: Trace::US0) -> bool {
        let v3: () = {
            Trace::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            LrcPtr<Trace::Mut3>,
            LrcPtr<Trace::Mut4>,
            Option<i64>,
        ) = Trace::TraceState::trace_state().get().clone().unwrap();
        let v35: Trace::US0 = (patternInput.4.clone()).l0.get().clone();
        if ((patternInput.2.clone()).l0.get().clone()) == false {
            false
        } else {
            (find(
                v0_1,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                    LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                    LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                    LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                    LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                ])))),
            )) >= (find(
                v35,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                    LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                    LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                    LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                    LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                ])))),
            ))
        }
    }
    pub fn closure7(unitVar: (), v0_1: i64) -> Trace::US2 {
        Trace::US2::US2_0(v0_1)
    }
    pub fn method8() -> Func1<i64, Trace::US2> {
        Func1::new(move |v: i64| Trace::closure7((), v))
    }
    pub fn method9() -> string {
        string("hh:mm:ss")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn method7(
        v0_1: LrcPtr<Trace::Mut0>,
        v1_1: LrcPtr<Trace::Mut1>,
        v2_1: LrcPtr<Trace::Mut2>,
        v3: LrcPtr<Trace::Mut3>,
        v4: LrcPtr<Trace::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v20: Trace::US2 = defaultValue(Trace::US2::US2_1, map(Trace::method8(), v5));
        let v117: DateTime = match &v20 {
            Trace::US2::US2_0(v20_0_0) => {
                let v77: TimeSpan = TimeSpan::new_ticks(
                    ({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    }) - (match &v20 {
                        Trace::US2::US2_0(x) => x.clone(),
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
        let v118: string = Trace::method9();
        let provider: string = if (v118.clone()) == string("") {
            string("M-d-y hh:mm:ss tt")
        } else {
            v118
        };
        v117.toString(provider)
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure8(v0_1: LrcPtr<Trace::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append((v0_1.l0.get().clone()), (v1_1));
        v0_1.l0.set(v3);
        ()
    }
    pub fn method12(v0_1: char) -> string {
        let v2_1: LrcPtr<Trace::Mut3> = LrcPtr::new(Trace::Mut3 {
            l0: MutCell::new(Trace::method13()),
        });
        let v8: () = {
            Trace::closure8(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method14() -> string {
        string("\u{001b}[0m")
    }
    pub fn method11(v0_1: Trace::US0) -> string {
        let v5: Trace::US5 = if if let Trace::US0::US0_0 = &v0_1 {
            true
        } else {
            false
        } {
            Trace::US5::US5_0(string("Verbose"))
        } else {
            Trace::US5::US5_1
        };
        let v46: Trace::US5 = match &v5 {
            Trace::US5::US5_0(v5_0_0) => Trace::US5::US5_0(
                match &v5 {
                    Trace::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
            ),
            _ => {
                let v12: Trace::US5 = if if let Trace::US0::US0_1 = &v0_1 {
                    true
                } else {
                    false
                } {
                    Trace::US5::US5_0(string("Debug"))
                } else {
                    Trace::US5::US5_1
                };
                match &v12 {
                    Trace::US5::US5_0(v12_0_0) => Trace::US5::US5_0(
                        match &v12 {
                            Trace::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v19: Trace::US5 = if if let Trace::US0::US0_2 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Trace::US5::US5_0(string("Info"))
                        } else {
                            Trace::US5::US5_1
                        };
                        match &v19 {
                            Trace::US5::US5_0(v19_0_0) => Trace::US5::US5_0(
                                match &v19 {
                                    Trace::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v26: Trace::US5 = if if let Trace::US0::US0_3 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Trace::US5::US5_0(string("Warning"))
                                } else {
                                    Trace::US5::US5_1
                                };
                                match &v26 {
                                    Trace::US5::US5_0(v26_0_0) => Trace::US5::US5_0(
                                        match &v26 {
                                            Trace::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v33: Trace::US5 = if if let Trace::US0::US0_4 = &v0_1 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Trace::US5::US5_0(string("Critical"))
                                        } else {
                                            Trace::US5::US5_1
                                        };
                                        match &v33 {
                                            Trace::US5::US5_0(v33_0_0) => Trace::US5::US5_0(
                                                match &v33 {
                                                    Trace::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            ),
                                            _ => Trace::US5::US5_1,
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
        let v56: string = Trace::method12(getCharAt(
            toLower(match &v46 {
                Trace::US5::US5_0(v46_0_0) => match &v46 {
                    Trace::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            }),
            0_i32,
        ));
        let v72: &str = match &v0_1 {
            Trace::US0::US0_1 => inline_colorization::color_bright_blue,
            Trace::US0::US0_2 => inline_colorization::color_bright_green,
            Trace::US0::US0_0 => inline_colorization::color_bright_black,
            Trace::US0::US0_3 => inline_colorization::color_yellow,
            _ => inline_colorization::color_bright_red,
        };
        let v75: &str = &*v56;
        let v98: &str = inline_colorization::color_reset;
        let v100: std::string::String = format!("{}{}{}", v72, v75, v98);
        fable_library_rust::String_::fromString(v100)
    }
    pub fn method16(v0_1: string) -> string {
        let v2_1: LrcPtr<Trace::Mut3> = LrcPtr::new(Trace::Mut3 {
            l0: MutCell::new(Trace::method13()),
        });
        let v8: () = {
            Trace::closure8(v2_1.clone(), v0_1, ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method17(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method15(
        v0_1: LrcPtr<Trace::Mut0>,
        v1_1: LrcPtr<Trace::Mut1>,
        v2_1: LrcPtr<Trace::Mut2>,
        v3: LrcPtr<Trace::Mut3>,
        v4: LrcPtr<Trace::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: string,
        v9: string,
    ) -> string {
        let v10: string = Trace::method16(v9);
        Trace::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            v8,
            v10
        ))
    }
    pub fn closure9(v0_1: LrcPtr<Trace::Mut0>, unitVar: ()) {
        let v2_1: i64 = (v0_1.l0.get().clone()) + 1_i64;
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
    pub fn method18(v0_1: string) {
        let v3: () = {
            Trace::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            LrcPtr<Trace::Mut3>,
            LrcPtr<Trace::Mut4>,
            Option<i64>,
        ) = Trace::TraceState::trace_state().get().clone().unwrap();
        let v37: () = {
            Trace::closure9(patternInput.0.clone(), ());
            ()
        };
        println!("{}", v0_1.clone());
        ((patternInput.1.clone()).l0.get().clone())(v0_1)
    }
    pub fn closure6(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>, unitVar: ()) {
        if Trace::method6(v0_1.clone()) {
            let v6: () = {
                Trace::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                LrcPtr<Trace::Mut3>,
                LrcPtr<Trace::Mut4>,
                Option<i64>,
            ) = Trace::TraceState::trace_state().get().clone().unwrap();
            let v25: Option<i64> = patternInput.5.clone();
            let v24: LrcPtr<Trace::Mut4> = patternInput.4.clone();
            let v23: LrcPtr<Trace::Mut3> = patternInput.3.clone();
            let v22: LrcPtr<Trace::Mut2> = patternInput.2.clone();
            let v21: LrcPtr<Trace::Mut1> = patternInput.1.clone();
            let v20: LrcPtr<Trace::Mut0> = patternInput.0.clone();
            let v38: string = Trace::method7(
                v20.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
            );
            let v39: string = Trace::method11(v0_1);
            let v40: string = v1_1();
            Trace::method18(if (v40.clone()) == string("") {
                string("")
            } else {
                Trace::method15(v20, v21, v22, v23, v24, v25, v38, v39, v40, v2_1())
            })
        };
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
