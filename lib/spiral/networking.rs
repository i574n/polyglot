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
    use fable_library_rust::String_::append;
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
                    LrcPtr<Networking::Mut3>,
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
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<Networking::US0>,
    }
    impl core::fmt::Display for Networking::Mut3 {
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Networking::Mut4 {
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
    pub fn closure1(
        v0_1: LrcPtr<MutCell<Option<Networking::US1>>>,
        v1_1: Option<Networking::US1>,
    ) -> LrcPtr<MutCell<Option<Networking::US1>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure2(
        v0_1: Option<string>,
        v1_1: Func1<Option<Networking::US1>, LrcPtr<MutCell<Option<Networking::US1>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Networking::US1>>> = v1_1(match &v0_1 {
                None => None::<Networking::US1>,
                Some(v0_1_0_0) => {
                    let x: string = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Networking::US1::US1_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method2(v0_1: string) -> string {
        let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v5_1: bool = true;
        let _result = v3.map(|x| {
            //;
            let v7_1: std::string::String = x;
            let v9: string = fable_library_rust::String_::fromString(v7_1);
            let v11: bool = true;
            v9
        });
        let v13: Result<string, std::env::VarError> = _result;
        let v14: string = Networking::method3();
        v13.unwrap_or(v14)
    }
    pub fn method4() -> string {
        string("AUTOMATION")
    }
    pub fn closure3(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method0(
        v0_1: Networking::US0,
    ) -> (
        LrcPtr<Networking::Mut0>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut2>,
        LrcPtr<Networking::Mut3>,
        Option<i64>,
    ) {
        let v3: string = Networking::method2(Networking::method1());
        let v8_1: Networking::US2 = if string("Verbose") == v3.clone() {
            Networking::US2::US2_0(Networking::US0::US0_0)
        } else {
            Networking::US2::US2_1
        };
        let _v1: (Networking::US2, Networking::US3) = (
            match &v8_1 {
                Networking::US2::US2_0(v8_1_0_0) => Networking::US2::US2_0(match &v8_1 {
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
            if Networking::method2(Networking::method4()) == string("True") {
                Networking::US3::US3_0({
                    let _arg: DateTime = DateTime::now();
                    _arg.ticks()
                })
            } else {
                Networking::US3::US3_1
            },
        );
        let v295: Networking::US3 = _v1.1.clone();
        let v294: Networking::US2 = _v1.0.clone();
        (
            LrcPtr::new(Networking::Mut0 {
                l0: MutCell::new(0_i64),
            }),
            LrcPtr::new(Networking::Mut1 {
                l0: MutCell::new(Func1::new(move |v: string| Networking::closure3((), v))),
            }),
            LrcPtr::new(Networking::Mut2 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Networking::Mut3 {
                l0: MutCell::new(match &v294 {
                    Networking::US2::US2_0(v294_0_0) => match &v294 {
                        Networking::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v295 {
                Networking::US3::US3_0(v295_0_0) => Some(match &v295 {
                    Networking::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure0(unitVar: (), unitVar_1: ()) {
        if Networking::State::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = Networking::method0(Networking::US0::US0_0);
            Networking::State::trace_state().set(Some((
                patternInput.0.clone(),
                patternInput.1.clone(),
                patternInput.2.clone(),
                patternInput.3.clone(),
                patternInput.4.clone(),
            )));
            ()
        };
    }
    pub fn closure7(v0_1: LrcPtr<Networking::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2_1);
        ()
    }
    pub fn closure8(
        v0_1: LrcPtr<MutCell<Option<Networking::US3>>>,
        v1_1: Option<Networking::US3>,
    ) -> LrcPtr<MutCell<Option<Networking::US3>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure9(
        v0_1: Option<i64>,
        v1_1: Func1<Option<Networking::US3>, LrcPtr<MutCell<Option<Networking::US3>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Networking::US3>>> = v1_1(match &v0_1 {
                None => None::<Networking::US3>,
                Some(v0_1_0_0) => {
                    let x: i64 = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Networking::US3::US3_0(x)
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
    pub fn closure10(v0_1: LrcPtr<Networking::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure11(unitVar: (), unitVar_1: ()) -> string {
        string("networking.test_port_open")
    }
    pub fn closure6(v0_1: i32, v1_1: string, unitVar: ()) {
        fn v3() {
            Networking::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v23: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v41: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let _v70: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v75: () = {
                Networking::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v70 = _v70.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v70.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v88: Networking::US3 = defaultValue(Networking::US3::US3_1, _v70.get().clone());
            let v128: DateTime = match &v88 {
                Networking::US3::US3_0(v88_0_0) => {
                    let v102: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v88 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v102.hours(),
                        v102.minutes(),
                        v102.seconds(),
                        v102.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v133: string = {
                let provider: string = Networking::method5();
                v128.toString(provider)
            };
            let v513: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v529: &str = inline_colorization::color_bright_black;
            let v531: &str = &*v513;
            let v533: &str = inline_colorization::color_reset;
            let v535: string = string("format!(\"{v529}{v531}{v533}\")");
            let v536: std::string::String = format!("{v529}{v531}{v533}");
            let v538: string = fable_library_rust::String_::fromString(v536);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(Networking::method8()),
            });
            let v588: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v595: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", string("port")), ());
                ()
            };
            let v602: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v608: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v615: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v622: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v628: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v634: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v641: () = {
                Networking::closure10(v581.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v642: string = v581.l0.get().clone();
            let v681: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v133,
                        v538,
                        v579,
                        Networking::closure11((), ()),
                        v642
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v681.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v681)
        }
    }
    pub fn closure5(v0_1: string, v1_1: i32) -> Arc<Async<bool>> {
        defaultOf()
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure5(v0_1.clone(), v)
        })
    }
    pub fn closure15(unitVar: (), v0_1: bool) -> Networking::US5 {
        Networking::US5::US5_0(v0_1)
    }
    pub fn closure16(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US5 {
        Networking::US5::US5_1(v0_1)
    }
    pub fn closure18(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure17(v0_1: i32, unitVar: ()) {
        fn v2_1() {
            Networking::closure0((), ());
        }
        let v3: () = {
            v2_1();
            ()
        };
        let patternInput: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v22: () = {
            v2_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v40: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v40,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v48: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v50: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let _v69: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v74: () = {
                Networking::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v69 = _v69.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v69.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v87: Networking::US3 = defaultValue(Networking::US3::US3_1, _v69.get().clone());
            let v127: DateTime = match &v87 {
                Networking::US3::US3_0(v87_0_0) => {
                    let v101: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v87 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v101.hours(),
                        v101.minutes(),
                        v101.seconds(),
                        v101.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v132: string = {
                let provider: string = Networking::method5();
                v127.toString(provider)
            };
            let v512: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v528: &str = inline_colorization::color_bright_black;
            let v530: &str = &*v512;
            let v532: &str = inline_colorization::color_reset;
            let v534: string = string("format!(\"{v528}{v530}{v532}\")");
            let v535: std::string::String = format!("{v528}{v530}{v532}");
            let v537: string = fable_library_rust::String_::fromString(v535);
            let v578: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v580: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(Networking::method8()),
            });
            let v587: () = {
                Networking::closure10(v580.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v594: () = {
                Networking::closure10(v580.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v601: () = {
                Networking::closure10(v580.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v607: () = {
                Networking::closure10(v580.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v614: () = {
                Networking::closure10(v580.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v615: string = v580.l0.get().clone();
            let v654: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v132,
                        v537,
                        v578,
                        Networking::closure18((), ()),
                        v615
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v654.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v654)
        }
    }
    pub fn closure20(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure19(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
        fn v3() {
            Networking::closure0((), ());
        }
        let v4: () = {
            v3();
            ()
        };
        let patternInput: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v23: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v41: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v41,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v49: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v51: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let _v70: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v75: () = {
                Networking::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v70 = _v70.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v70.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v88: Networking::US3 = defaultValue(Networking::US3::US3_1, _v70.get().clone());
            let v128: DateTime = match &v88 {
                Networking::US3::US3_0(v88_0_0) => {
                    let v102: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v88 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v102.hours(),
                        v102.minutes(),
                        v102.seconds(),
                        v102.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v133: string = {
                let provider: string = Networking::method5();
                v128.toString(provider)
            };
            let v513: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v529: &str = inline_colorization::color_bright_red;
            let v531: &str = &*v513;
            let v533: &str = inline_colorization::color_reset;
            let v535: string = string("format!(\"{v529}{v531}{v533}\")");
            let v536: std::string::String = format!("{v529}{v531}{v533}");
            let v538: string = fable_library_rust::String_::fromString(v536);
            let v579: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v581: string = sprintf!("{:?}", v1_1);
            let v603: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(Networking::method8()),
            });
            let v610: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v617: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v624: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v630: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v637: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v644: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v650: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v656: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", v581), ());
                ()
            };
            let v663: () = {
                Networking::closure10(v603.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v664: string = v603.l0.get().clone();
            let v703: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v133,
                        v538,
                        v579,
                        Networking::closure20((), ()),
                        v664
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v703.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v703)
        }
    }
    pub fn closure14(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        defaultOf()
    }
    pub fn closure13(v0_1: i32, v1_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure14(v0_1, v1_1.clone(), v)
        })
    }
    pub fn closure12(unitVar: (), v0_1: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure13(v0_1, v)
        })
    }
    pub fn closure25(
        v0_1: LrcPtr<MutCell<Option<Networking::US7>>>,
        v1_1: Option<Networking::US7>,
    ) -> LrcPtr<MutCell<Option<Networking::US7>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure26(
        v0_1: Option<i32>,
        v1_1: Func1<Option<Networking::US7>, LrcPtr<MutCell<Option<Networking::US7>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Networking::US7>>> = v1_1(match &v0_1 {
                None => None::<Networking::US7>,
                Some(v0_1_0_0) => {
                    let x: i32 = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Networking::US7::US7_0(x)
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn closure28(unitVar: (), unitVar_1: ()) -> string {
        string("networking.wait_for_port_access")
    }
    pub fn closure27(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3: i64, unitVar: ()) {
        fn v5_1() {
            Networking::closure0((), ());
        }
        let v6_1: () = {
            v5_1();
            ()
        };
        let patternInput: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v25: () = {
            v5_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v43: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v43,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v51: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v53: () = {
                v5_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let _v72: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v77: () = {
                Networking::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v72 = _v72.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v72.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v90: Networking::US3 = defaultValue(Networking::US3::US3_1, _v72.get().clone());
            let v130: DateTime = match &v90 {
                Networking::US3::US3_0(v90_0_0) => {
                    let v104: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v90 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v104.hours(),
                        v104.minutes(),
                        v104.seconds(),
                        v104.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v135: string = {
                let provider: string = Networking::method5();
                v130.toString(provider)
            };
            let v515: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v531: &str = inline_colorization::color_bright_black;
            let v533: &str = &*v515;
            let v535: &str = inline_colorization::color_reset;
            let v537: string = string("format!(\"{v531}{v533}{v535}\")");
            let v538: std::string::String = format!("{v531}{v533}{v535}");
            let v540: string = fable_library_rust::String_::fromString(v538);
            let v581: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v583: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(Networking::method8()),
            });
            let v590: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v597: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string("port")), ());
                ()
            };
            let v604: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v610: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v617: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v624: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v630: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v636: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v642: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v649: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v655: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v658: std::string::String = format!("{:#?}", v0_1);
            let v688: () = {
                Networking::closure10(
                    v583.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v658)),
                    (),
                );
                ()
            };
            let v694: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v701: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string("status")), ());
                ()
            };
            let v707: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v716: () = {
                Networking::closure10(
                    v583.clone(),
                    sprintf!(
                        "{}",
                        if v1_1 {
                            string("true")
                        } else {
                            string("false")
                        }
                    ),
                    (),
                );
                ()
            };
            let v723: () = {
                Networking::closure10(v583.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v724: string = v583.l0.get().clone();
            let v763: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v135,
                        v540,
                        v581,
                        Networking::closure28((), ()),
                        v724
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v763.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v763)
        }
    }
    pub fn method9(
        v0_1: Option<i32>,
        v1_1: bool,
        v2_1: string,
        v3: i32,
        v4: i64,
    ) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure24(v0_1: Option<i32>, v1_1: bool, v2_1: string, v3: i32) -> Arc<Async<i64>> {
        Networking::method9(v0_1, v1_1, v2_1, v3, 0_i64)
    }
    pub fn closure23(v0_1: Option<i32>, v1_1: bool, v2_1: string) -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            let v2_1 = v2_1.clone();
            move |v: i32| Networking::closure24(v0_1.clone(), v1_1, v2_1.clone(), v)
        })
    }
    pub fn closure22(v0_1: Option<i32>, v1_1: bool) -> Func1<string, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Networking::closure23(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure21(
        unitVar: (),
        v0_1: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| Networking::closure22(v0_1.clone(), v)
        })
    }
    pub fn method10(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        defaultOf()
    }
    pub fn closure31(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method10(v0_1, v1_1, v2_1)
    }
    pub fn closure30(v0_1: Option<i32>, v1_1: string) -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure31(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure29(unitVar: (), v0_1: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure30(v0_1.clone(), v)
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
    pub fn v5() -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        static v5: OnceInit<Func1<string, Func1<i32, Arc<Async<bool>>>>> = OnceInit::new();
        v5.get_or_init(|| Func1::new(move |v: string| Networking::closure4((), v)))
            .clone()
    }
    pub fn test_port_open(x: string) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v5())(x)
    }
    pub fn v6() -> Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>> {
        static v6: OnceInit<Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>>> =
            OnceInit::new();
        v6.get_or_init(|| Func1::new(move |v: i32| Networking::closure12((), v)))
            .clone()
    }
    pub fn test_port_open_timeout(x: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        (Networking::v6())(x)
    }
    pub fn v7() -> Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>> {
        static v7: OnceInit<
            Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>>,
        > = OnceInit::new();
        v7.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure21((), v)))
            .clone()
    }
    pub fn wait_for_port_access(
        x: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        (Networking::v7())(x)
    }
    pub fn v8() -> Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>> {
        static v8: OnceInit<Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>>> =
            OnceInit::new();
        v8.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure29((), v)))
            .clone()
    }
    pub fn get_available_port(x: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        (Networking::v8())(x)
    }
    on_startup!(());
}
