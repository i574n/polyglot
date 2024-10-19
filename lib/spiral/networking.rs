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
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Arc;
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
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Exception;
    use fable_library_rust::TimeSpan_::TimeSpan;
    pub mod TraceState {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    LrcPtr<Networking::Mut3>,
                    LrcPtr<Networking::Mut4>,
                    Option<i64>,
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
                            LrcPtr<Networking::Mut3>,
                            LrcPtr<Networking::Mut4>,
                            Option<i64>,
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
                            LrcPtr<Networking::Mut3>,
                            LrcPtr<Networking::Mut4>,
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
    #[derive(Clone, Debug)]
    pub struct Mut1 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Networking::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Networking::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Networking::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<Networking::US0>,
    }
    impl core::fmt::Display for Networking::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(string),
        US1_1,
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
    impl core::fmt::Display for Networking::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(i64),
        US3_1,
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
    impl core::fmt::Display for Networking::US7 {
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
    pub fn closure1(unitVar: (), v0_1: string) -> Networking::US1 {
        Networking::US1::US1_0(v0_1)
    }
    pub fn method4() -> Func1<string, Networking::US1> {
        Func1::new(move |v: string| Networking::closure1((), v))
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
        let v14: string = Networking::method3();
        v13.unwrap_or(v14)
    }
    pub fn method5() -> string {
        string("AUTOMATION")
    }
    pub fn closure2(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: Networking::US0,
    ) -> (
        LrcPtr<Networking::Mut0>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut2>,
        LrcPtr<Networking::Mut3>,
        LrcPtr<Networking::Mut4>,
        Option<i64>,
    ) {
        let v3: string = Networking::method2(Networking::method1());
        let v8: Networking::US2 = if string("Verbose") == v3.clone() {
            Networking::US2::US2_0(Networking::US0::US0_0)
        } else {
            Networking::US2::US2_1
        };
        let _v1: (Networking::US2, Networking::US3) = (
            match &v8 {
                Networking::US2::US2_0(v8_0_0) => Networking::US2::US2_0(match &v8 {
                    Networking::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v15: Networking::US2 = if string("Debug") == v3.clone() {
                        Networking::US2::US2_0(Networking::US0::US0_1)
                    } else {
                        Networking::US2::US2_1
                    };
                    match &v15 {
                        Networking::US2::US2_0(v15_0_0) => Networking::US2::US2_0(match &v15 {
                            Networking::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v22: Networking::US2 = if string("Info") == v3.clone() {
                                Networking::US2::US2_0(Networking::US0::US0_2)
                            } else {
                                Networking::US2::US2_1
                            };
                            match &v22 {
                                Networking::US2::US2_0(v22_0_0) => {
                                    Networking::US2::US2_0(match &v22 {
                                        Networking::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v29: Networking::US2 = if string("Warning") == v3.clone() {
                                        Networking::US2::US2_0(Networking::US0::US0_3)
                                    } else {
                                        Networking::US2::US2_1
                                    };
                                    match &v29 {
                                        Networking::US2::US2_0(v29_0_0) => {
                                            Networking::US2::US2_0(match &v29 {
                                                Networking::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v36: Networking::US2 =
                                                if string("Critical") == v3.clone() {
                                                    Networking::US2::US2_0(Networking::US0::US0_4)
                                                } else {
                                                    Networking::US2::US2_1
                                                };
                                            match &v36 {
                                                Networking::US2::US2_0(v36_0_0) => {
                                                    Networking::US2::US2_0(match &v36 {
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
            },
            if Networking::method2(Networking::method5()) == string("True") {
                Networking::US3::US3_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                Networking::US3::US3_1
            },
        );
        let v352: Networking::US3 = _v1.1.clone();
        let v351: Networking::US2 = _v1.0.clone();
        (
            LrcPtr::new(Networking::Mut0 {
                l0: MutCell::new(1_i64),
            }),
            LrcPtr::new(Networking::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Networking::closure2((), v))),
            }),
            LrcPtr::new(Networking::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Networking::Mut3 {
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(match &v351 {
                    Networking::US2::US2_0(v351_0_0) => match &v351 {
                        Networking::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v352 {
                Networking::US3::US3_0(v352_0_0) => Some(match &v352 {
                    Networking::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if Networking::TraceState::trace_state()
            .get()
            .clone()
            .is_none()
        {
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = Networking::method0(Networking::US0::US0_0);
            Networking::TraceState::trace_state().set(Some((
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
    pub fn method6(v0_1: Networking::US0) -> bool {
        let v3: () = {
            Networking::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v35: Networking::US0 = (patternInput.4.clone()).l0.get().clone();
        if (patternInput.2.clone()).l0.get().clone() == false {
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
                v35,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                    LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                    LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                    LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                    LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                ])))),
            )
        }
    }
    pub fn closure6(unitVar: (), v0_1: i64) -> Networking::US3 {
        Networking::US3::US3_0(v0_1)
    }
    pub fn method8() -> Func1<i64, Networking::US3> {
        Func1::new(move |v: i64| Networking::closure6((), v))
    }
    pub fn method9() -> string {
        string("hh:mm:ss")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn method7(
        v0_1: LrcPtr<Networking::Mut0>,
        v1_1: LrcPtr<Networking::Mut1>,
        v2_1: LrcPtr<Networking::Mut2>,
        v3: LrcPtr<Networking::Mut3>,
        v4: LrcPtr<Networking::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v20: Networking::US3 =
            defaultValue(Networking::US3::US3_1, map(Networking::method8(), v5));
        let v60: DateTime = match &v20 {
            Networking::US3::US3_0(v20_0_0) => {
                let v34: TimeSpan = TimeSpan::new_ticks(
                    {
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    } - match &v20 {
                        Networking::US3::US3_0(x) => x.clone(),
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
        let provider: string = Networking::method9();
        v60.toString(provider)
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure7(v0_1: LrcPtr<Networking::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method12(v0_1: char) -> string {
        let v2_1: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v8: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method14() -> string {
        string("\u{001b}[0m")
    }
    pub fn method11() -> string {
        let v6: string = Networking::method12(getCharAt(toLower(string("Verbose")), 0_i32));
        let v9: &str = inline_colorization::color_bright_black;
        let v12: &str = &*v6;
        let v32: &str = inline_colorization::color_reset;
        let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
        fable_library_rust::String_::fromString(v34)
    }
    pub fn method16(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v10: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("port")), ());
            ()
        };
        let v28: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v62: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method17(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method15(
        v0_1: LrcPtr<Networking::Mut0>,
        v1_1: LrcPtr<Networking::Mut1>,
        v2_1: LrcPtr<Networking::Mut2>,
        v3: LrcPtr<Networking::Mut3>,
        v4: LrcPtr<Networking::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: i32,
        v9: string,
    ) -> string {
        let v10: string = Networking::method16(v8, v9);
        Networking::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("networking.test_port_open"),
            v10
        ))
    }
    pub fn closure8(v0_1: LrcPtr<Networking::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure10(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure9(unitVar: (), v0_1: string) {
        let v3: () = {
            Networking::closure10(v0_1, ());
            ()
        };
        ()
    }
    pub fn method18(v0_1: string) {
        let v3: () = {
            Networking::closure0((), ());
            ()
        };
        let patternInput: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v37: () = {
            Networking::closure8(patternInput.0.clone(), ());
            ()
        };
        println!("{}", v0_1.clone());
        ();
        ((patternInput.1.clone()).l0.get().clone())(v0_1)
    }
    pub fn closure5(v0_1: i32, v1_1: string, unitVar: ()) {
        if Networking::method6(Networking::US0::US0_0) {
            let v6: () = {
                Networking::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let v25: Option<i64> = patternInput.5.clone();
            let v24: LrcPtr<Networking::Mut4> = patternInput.4.clone();
            let v23: LrcPtr<Networking::Mut3> = patternInput.3.clone();
            let v22: LrcPtr<Networking::Mut2> = patternInput.2.clone();
            let v21: LrcPtr<Networking::Mut1> = patternInput.1.clone();
            let v20: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            Networking::method18(Networking::method15(
                v20.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                Networking::method7(v20, v21, v22, v23, v24, v25),
                Networking::method11(),
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn closure4(v0_1: string, v1_1: i32) -> Arc<Async<bool>> {
        defaultOf()
    }
    pub fn closure3(unitVar: (), v0_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure4(v0_1.clone(), v)
        })
    }
    pub fn closure14(unitVar: (), v0_1: bool) -> Networking::US5 {
        Networking::US5::US5_0(v0_1)
    }
    pub fn closure15(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US5 {
        Networking::US5::US5_1(v0_1)
    }
    pub fn method20(v0_1: i32) -> string {
        let v2_1: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v9: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v18_1: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", string("timeout")), ());
            ()
        };
        let v27: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v35: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v44: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method19(
        v0_1: LrcPtr<Networking::Mut0>,
        v1_1: LrcPtr<Networking::Mut1>,
        v2_1: LrcPtr<Networking::Mut2>,
        v3: LrcPtr<Networking::Mut3>,
        v4: LrcPtr<Networking::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: i32,
    ) -> string {
        let v9: string = Networking::method20(v8);
        Networking::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("async.run_with_timeout_async"),
            v9
        ))
    }
    pub fn closure16(v0_1: i32, unitVar: ()) {
        if Networking::method6(Networking::US0::US0_0) {
            let v5: () = {
                Networking::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let v24: Option<i64> = patternInput.5.clone();
            let v23: LrcPtr<Networking::Mut4> = patternInput.4.clone();
            let v22: LrcPtr<Networking::Mut3> = patternInput.3.clone();
            let v21: LrcPtr<Networking::Mut2> = patternInput.2.clone();
            let v20: LrcPtr<Networking::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            Networking::method18(Networking::method19(
                v19_1.clone(),
                v20.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                Networking::method7(v19_1, v20, v21, v22, v23, v24),
                Networking::method11(),
                v0_1,
            ))
        };
    }
    pub fn method21() -> string {
        let v6: string = Networking::method12(getCharAt(toLower(string("Critical")), 0_i32));
        let v9: &str = inline_colorization::color_bright_red;
        let v12: &str = &*v6;
        let v32: &str = inline_colorization::color_reset;
        let v34: std::string::String = format!("{}{}{}", v9, v12, v32);
        fable_library_rust::String_::fromString(v34)
    }
    pub fn method23(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v10: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("timeout")), ());
            ()
        };
        let v28: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v62: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method22(
        v0_1: LrcPtr<Networking::Mut0>,
        v1_1: LrcPtr<Networking::Mut1>,
        v2_1: LrcPtr<Networking::Mut2>,
        v3: LrcPtr<Networking::Mut3>,
        v4: LrcPtr<Networking::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: i32,
        v9: string,
    ) -> string {
        let v10: string = Networking::method23(v8, v9);
        Networking::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("async.run_with_timeout_async**"),
            v10
        ))
    }
    pub fn closure17(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
        if Networking::method6(Networking::US0::US0_4) {
            let v6: () = {
                Networking::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let v25: Option<i64> = patternInput.5.clone();
            let v24: LrcPtr<Networking::Mut4> = patternInput.4.clone();
            let v23: LrcPtr<Networking::Mut3> = patternInput.3.clone();
            let v22: LrcPtr<Networking::Mut2> = patternInput.2.clone();
            let v21: LrcPtr<Networking::Mut1> = patternInput.1.clone();
            let v20: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            Networking::method18(Networking::method22(
                v20.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                Networking::method7(v20, v21, v22, v23, v24, v25),
                Networking::method21(),
                v0_1,
                sprintf!("{:?}", v1_1),
            ))
        };
    }
    pub fn closure13(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        defaultOf()
    }
    pub fn closure12(v0_1: i32, v1_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure13(v0_1, v1_1.clone(), v)
        })
    }
    pub fn closure11(unitVar: (), v0_1: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure12(v0_1, v)
        })
    }
    pub fn closure22(unitVar: (), v0_1: i32) -> Networking::US7 {
        Networking::US7::US7_0(v0_1)
    }
    pub fn method25() -> Func1<i32, Networking::US7> {
        Func1::new(move |v: i32| Networking::closure22((), v))
    }
    pub fn method27(v0_1: i32, v1_1: i64, v2_1: Option<i32>, v3: bool) -> string {
        let v5: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v12: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v21: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("port")), ());
            ()
        };
        let v30: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v38: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v47: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v56: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("retry")), ());
            ()
        };
        let v64: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v72: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v80: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v89: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("timeout")), ());
            ()
        };
        let v97: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v102: std::string::String = format!("{:#?}", v2_1);
        let v132: () = {
            Networking::closure7(
                v5.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v102)),
                (),
            );
            ()
        };
        let v140: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v149: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("status")), ());
            ()
        };
        let v157: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v168: () = {
            Networking::closure7(
                v5.clone(),
                sprintf!("{}", if v3 { string("true") } else { string("false") }),
                (),
            );
            ()
        };
        let v177: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v5.l0.get().clone()
    }
    pub fn method26(
        v0_1: LrcPtr<Networking::Mut0>,
        v1_1: LrcPtr<Networking::Mut1>,
        v2_1: LrcPtr<Networking::Mut2>,
        v3: LrcPtr<Networking::Mut3>,
        v4: LrcPtr<Networking::Mut4>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: i32,
        v9: i64,
        v10: Option<i32>,
        v11: bool,
    ) -> string {
        let v12: string = Networking::method27(v8, v9, v10, v11);
        Networking::method17(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("networking.wait_for_port_access"),
            v12
        ))
    }
    pub fn closure23(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3: i64, unitVar: ()) {
        if Networking::method6(Networking::US0::US0_0) {
            let v8: () = {
                Networking::closure0((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let v27: Option<i64> = patternInput.5.clone();
            let v26: LrcPtr<Networking::Mut4> = patternInput.4.clone();
            let v25: LrcPtr<Networking::Mut3> = patternInput.3.clone();
            let v24: LrcPtr<Networking::Mut2> = patternInput.2.clone();
            let v23: LrcPtr<Networking::Mut1> = patternInput.1.clone();
            let v22: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            Networking::method18(Networking::method26(
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                v26.clone(),
                v27.clone(),
                Networking::method7(v22, v23, v24, v25, v26, v27),
                Networking::method11(),
                v2_1,
                v3,
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn method24(
        v0_1: Option<i32>,
        v1_1: bool,
        v2_1: string,
        v3: i32,
        v4: i64,
    ) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure21(v0_1: Option<i32>, v1_1: bool, v2_1: string, v3: i32) -> Arc<Async<i64>> {
        Networking::method24(v0_1, v1_1, v2_1, v3, 1_i64)
    }
    pub fn closure20(v0_1: Option<i32>, v1_1: bool, v2_1: string) -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            let v2_1 = v2_1.clone();
            move |v: i32| Networking::closure21(v0_1.clone(), v1_1, v2_1.clone(), v)
        })
    }
    pub fn closure19(v0_1: Option<i32>, v1_1: bool) -> Func1<string, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Networking::closure20(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure18(
        unitVar: (),
        v0_1: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| Networking::closure19(v0_1.clone(), v)
        })
    }
    pub fn method28(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        defaultOf()
    }
    pub fn closure26(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method28(v0_1, v1_1, v2_1)
    }
    pub fn closure25(v0_1: Option<i32>, v1_1: string) -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure26(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure24(unitVar: (), v0_1: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure25(v0_1.clone(), v)
        })
    }
    pub fn v0() -> () {
        static v0: OnceInit<()> = OnceInit::new();
        v0.get_or_init(|| ()).clone()
    }
    pub fn v1() -> Func0<()> {
        static v1: OnceInit<Func0<()>> = OnceInit::new();
        v1.get_or_init(|| Func0::new(move || Networking::closure0((), ())))
            .clone()
    }
    pub fn v2() -> () {
        static v2: OnceInit<()> = OnceInit::new();
        v2.get_or_init(|| {
            (Networking::v1())();
            Networking::v0()
        })
        .clone()
    }
    pub fn v16() -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        static v16: OnceInit<Func1<string, Func1<i32, Arc<Async<bool>>>>> = OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: string| Networking::closure3((), v)))
            .clone()
    }
    pub fn test_port_open(x: string) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v16())(x)
    }
    pub fn v17() -> Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>> {
        static v17: OnceInit<Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>>> =
            OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: i32| Networking::closure11((), v)))
            .clone()
    }
    pub fn test_port_open_timeout(x: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        (Networking::v17())(x)
    }
    pub fn v18() -> Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>> {
        static v18: OnceInit<
            Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>>,
        > = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure18((), v)))
            .clone()
    }
    pub fn wait_for_port_access(
        x: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        (Networking::v18())(x)
    }
    pub fn v19() -> Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>> {
        static v19: OnceInit<Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>>> =
            OnceInit::new();
        v19.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure24((), v)))
            .clone()
    }
    pub fn get_available_port(x: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        (Networking::v19())(x)
    }
    on_startup!(());
}
