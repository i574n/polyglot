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
        let v14: string = Trace::method3();
        v13.unwrap_or(v14)
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
        LrcPtr<Trace::Mut4>,
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
                l0: MutCell::new(Func1::new(move |v: string| Trace::closure3((), v))),
            }),
            LrcPtr::new(Trace::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Trace::Mut3 {
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Trace::Mut4 {
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
    pub fn closure11(v0_1: LrcPtr<Trace::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure13(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure12(unitVar: (), v0_1: string) {
        let v3: () = {
            Trace::closure13(v0_1, ());
            ()
        };
        ()
    }
    pub fn closure7(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>, unitVar: ()) {
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
        let v38: () = {
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
        let v70: Trace::US0 = (patternInput_1.4.clone()).l0.get().clone();
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
                v70,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                    LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                    LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                    LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                    LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                ])))),
            )
        } {
            let v79: () = {
                Trace::closure8(patternInput.0.clone(), ());
                ()
            };
            let v83: () = {
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
            let _v116: LrcPtr<MutCell<Option<Trace::US3>>> = refCell(None::<Trace::US3>);
            let v121: () = {
                Trace::closure10(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v116 = _v116.clone();
                        move |v: Option<Trace::US3>| Trace::closure9(_v116.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v136: Trace::US3 = defaultValue(Trace::US3::US3_1, _v116.get().clone());
            let v176: DateTime = match &v136 {
                Trace::US3::US3_0(v136_0_0) => {
                    let v150: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v136 {
                            Trace::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v150.hours(),
                        v150.minutes(),
                        v150.seconds(),
                        v150.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v181: string = {
                let provider: string = Trace::method5();
                v176.toString(provider)
            };
            let v572: Trace::US1 = if if let Trace::US0::US0_0 = &v0_1 {
                true
            } else {
                false
            } {
                Trace::US1::US1_0(string("Verbose"))
            } else {
                Trace::US1::US1_1
            };
            let v613: Trace::US1 = match &v572 {
                Trace::US1::US1_0(v572_0_0) => Trace::US1::US1_0(match &v572 {
                    Trace::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v579: Trace::US1 = if if let Trace::US0::US0_1 = &v0_1 {
                        true
                    } else {
                        false
                    } {
                        Trace::US1::US1_0(string("Debug"))
                    } else {
                        Trace::US1::US1_1
                    };
                    match &v579 {
                        Trace::US1::US1_0(v579_0_0) => Trace::US1::US1_0(match &v579 {
                            Trace::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v586: Trace::US1 = if if let Trace::US0::US0_2 = &v0_1 {
                                true
                            } else {
                                false
                            } {
                                Trace::US1::US1_0(string("Info"))
                            } else {
                                Trace::US1::US1_1
                            };
                            match &v586 {
                                Trace::US1::US1_0(v586_0_0) => Trace::US1::US1_0(match &v586 {
                                    Trace::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                                _ => {
                                    let v593: Trace::US1 = if if let Trace::US0::US0_3 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Trace::US1::US1_0(string("Warning"))
                                    } else {
                                        Trace::US1::US1_1
                                    };
                                    match &v593 {
                                        Trace::US1::US1_0(v593_0_0) => {
                                            Trace::US1::US1_0(match &v593 {
                                                Trace::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v600: Trace::US1 =
                                                if if let Trace::US0::US0_4 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Trace::US1::US1_0(string("Critical"))
                                                } else {
                                                    Trace::US1::US1_1
                                                };
                                            match &v600 {
                                                Trace::US1::US1_0(v600_0_0) => {
                                                    Trace::US1::US1_0(match &v600 {
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
            let v622: string = padLeft(
                toLower(match &v613 {
                    Trace::US1::US1_0(v613_0_0) => match &v613 {
                        Trace::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                }),
                7_i32,
                ' ',
            );
            let v651: &str = match &v0_1 {
                Trace::US0::US0_1 => inline_colorization::color_bright_blue,
                Trace::US0::US0_2 => inline_colorization::color_bright_green,
                Trace::US0::US0_0 => inline_colorization::color_bright_black,
                Trace::US0::US0_3 => inline_colorization::color_yellow,
                _ => inline_colorization::color_bright_red,
            };
            let v653: &str = &*v622;
            let v655: &str = inline_colorization::color_reset;
            let v657: string = string("format!(\"{v651}{v653}{v655}\")");
            let v658: std::string::String = format!("{v651}{v653}{v655}");
            let v660: string = fable_library_rust::String_::fromString(v658);
            let v763: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v764: string = v2_1();
            let v766: LrcPtr<Trace::Mut3> = LrcPtr::new(Trace::Mut3 {
                l0: MutCell::new(Trace::method8()),
            });
            let v772: () = {
                Trace::closure11(v766.clone(), sprintf!("{}", v764), ());
                ()
            };
            let v775: string = v766.l0.get().clone();
            let v776: string = v1_1();
            let v834: string = if v776.clone() == string("") {
                string("")
            } else {
                trimEndChars(
                    trimStartChars(
                        sprintf!("{} {} #{} {} / {}", v181, v660, v763, v776, v775),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                )
            };
            println!("{}", v834.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v834)
        }
    }
    pub fn closure6(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        let v5: () = {
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
    pub fn v16() -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v16: OnceInit<Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure4((), v)))
            .clone()
    }
    pub fn trace(x: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v16())(x)
    }
    on_startup!(());
}
