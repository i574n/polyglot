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
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Networking::Mut4 {
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
    pub fn closure10(v0_1: LrcPtr<Networking::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure12(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure11(unitVar: (), v0_1: string) {
        let v3: () = {
            Networking::closure12(v0_1, ());
            ()
        };
        ()
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
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v37: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v69: Networking::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v69,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v77: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v81: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let _v114: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v119: () = {
                Networking::closure9(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v114 = _v114.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v114.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v134: Networking::US3 = defaultValue(Networking::US3::US3_1, _v114.get().clone());
            let v174: DateTime = match &v134 {
                Networking::US3::US3_0(v134_0_0) => {
                    let v148: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v134 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v148.hours(),
                        v148.minutes(),
                        v148.seconds(),
                        v148.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v179: string = {
                let provider: string = Networking::method5();
                v174.toString(provider)
            };
            let v571: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v587: &str = inline_colorization::color_bright_black;
            let v589: &str = &*v571;
            let v591: &str = inline_colorization::color_reset;
            let v593: string = string("format!(\"{v587}{v589}{v591}\")");
            let v594: std::string::String = format!("{v587}{v589}{v591}");
            let v596: string = fable_library_rust::String_::fromString(v594);
            let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v639: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
                l0: MutCell::new(Networking::method8()),
            });
            let v646: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v655: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", string("port")), ());
                ()
            };
            let v664: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v672: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v681: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v690: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v698: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v706: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v715: () = {
                Networking::closure10(v639.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v777: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v179,
                        v596,
                        v637,
                        string("networking.test_port_open"),
                        v639.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v777.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v777)
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
    pub fn closure16(unitVar: (), v0_1: bool) -> Networking::US5 {
        Networking::US5::US5_0(v0_1)
    }
    pub fn closure17(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US5 {
        Networking::US5::US5_1(v0_1)
    }
    pub fn closure18(v0_1: i32, unitVar: ()) {
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
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v36: () = {
            v2_1();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v68: Networking::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v68,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v76: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v80: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let _v113: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v118: () = {
                Networking::closure9(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v113 = _v113.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v113.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v133: Networking::US3 = defaultValue(Networking::US3::US3_1, _v113.get().clone());
            let v173: DateTime = match &v133 {
                Networking::US3::US3_0(v133_0_0) => {
                    let v147: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v133 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v147.hours(),
                        v147.minutes(),
                        v147.seconds(),
                        v147.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v178: string = {
                let provider: string = Networking::method5();
                v173.toString(provider)
            };
            let v570: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v586: &str = inline_colorization::color_bright_black;
            let v588: &str = &*v570;
            let v590: &str = inline_colorization::color_reset;
            let v592: string = string("format!(\"{v586}{v588}{v590}\")");
            let v593: std::string::String = format!("{v586}{v588}{v590}");
            let v595: string = fable_library_rust::String_::fromString(v593);
            let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v638: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
                l0: MutCell::new(Networking::method8()),
            });
            let v645: () = {
                Networking::closure10(v638.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v654: () = {
                Networking::closure10(v638.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v663: () = {
                Networking::closure10(v638.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v671: () = {
                Networking::closure10(v638.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v680: () = {
                Networking::closure10(v638.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v742: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v178,
                        v595,
                        v636,
                        string("async.run_with_timeout_async"),
                        v638.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v742.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v742)
        }
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
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v37: () = {
            v3();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v69: Networking::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v69,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v77: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v81: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let _v114: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v119: () = {
                Networking::closure9(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v114 = _v114.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v114.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v134: Networking::US3 = defaultValue(Networking::US3::US3_1, _v114.get().clone());
            let v174: DateTime = match &v134 {
                Networking::US3::US3_0(v134_0_0) => {
                    let v148: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v134 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v148.hours(),
                        v148.minutes(),
                        v148.seconds(),
                        v148.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v179: string = {
                let provider: string = Networking::method5();
                v174.toString(provider)
            };
            let v571: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v587: &str = inline_colorization::color_bright_red;
            let v589: &str = &*v571;
            let v591: &str = inline_colorization::color_reset;
            let v593: string = string("format!(\"{v587}{v589}{v591}\")");
            let v594: std::string::String = format!("{v587}{v589}{v591}");
            let v596: string = fable_library_rust::String_::fromString(v594);
            let v637: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v639: string = sprintf!("{:?}", v1_1);
            let v661: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
                l0: MutCell::new(Networking::method8()),
            });
            let v668: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v677: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v686: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v694: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v703: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v712: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v720: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v728: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", v639), ());
                ()
            };
            let v737: () = {
                Networking::closure10(v661.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v799: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v179,
                        v596,
                        v637,
                        string("async.run_with_timeout_async**"),
                        v661.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v799.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v799)
        }
    }
    pub fn closure15(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        defaultOf()
    }
    pub fn closure14(v0_1: i32, v1_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure15(v0_1, v1_1.clone(), v)
        })
    }
    pub fn closure13(unitVar: (), v0_1: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure14(v0_1, v)
        })
    }
    pub fn closure24(
        v0_1: LrcPtr<MutCell<Option<Networking::US7>>>,
        v1_1: Option<Networking::US7>,
    ) -> LrcPtr<MutCell<Option<Networking::US7>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure25(
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
    pub fn closure26(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3: i64, unitVar: ()) {
        fn v5() {
            Networking::closure0((), ());
        }
        let v6: () = {
            v5();
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
        let v39: () = {
            v5();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v71: Networking::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v71,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v79: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v83: () = {
                v5();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let _v116: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v121: () = {
                Networking::closure9(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v116 = _v116.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v116.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v136: Networking::US3 = defaultValue(Networking::US3::US3_1, _v116.get().clone());
            let v176: DateTime = match &v136 {
                Networking::US3::US3_0(v136_0_0) => {
                    let v150: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v136 {
                            Networking::US3::US3_0(x) => x.clone(),
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
                let provider: string = Networking::method5();
                v176.toString(provider)
            };
            let v573: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v589: &str = inline_colorization::color_bright_black;
            let v591: &str = &*v573;
            let v593: &str = inline_colorization::color_reset;
            let v595: string = string("format!(\"{v589}{v591}{v593}\")");
            let v596: std::string::String = format!("{v589}{v591}{v593}");
            let v598: string = fable_library_rust::String_::fromString(v596);
            let v639: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v641: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
                l0: MutCell::new(Networking::method8()),
            });
            let v648: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v657: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string("port")), ());
                ()
            };
            let v666: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v674: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v683: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v692: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v700: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v708: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v716: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v725: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v733: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v738: std::string::String = format!("{:#?}", v0_1);
            let v768: () = {
                Networking::closure10(
                    v641.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v738)),
                    (),
                );
                ()
            };
            let v776: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v785: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string("status")), ());
                ()
            };
            let v793: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v804: () = {
                Networking::closure10(
                    v641.clone(),
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
            let v813: () = {
                Networking::closure10(v641.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v855: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v181,
                        v598,
                        v639,
                        string("networking.wait_for_port_access"),
                        v641.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v855.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v855)
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
    pub fn closure23(v0_1: Option<i32>, v1_1: bool, v2_1: string, v3: i32) -> Arc<Async<i64>> {
        Networking::method9(v0_1, v1_1, v2_1, v3, 0_i64)
    }
    pub fn closure22(v0_1: Option<i32>, v1_1: bool, v2_1: string) -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            let v2_1 = v2_1.clone();
            move |v: i32| Networking::closure23(v0_1.clone(), v1_1, v2_1.clone(), v)
        })
    }
    pub fn closure21(v0_1: Option<i32>, v1_1: bool) -> Func1<string, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Networking::closure22(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure20(
        unitVar: (),
        v0_1: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| Networking::closure21(v0_1.clone(), v)
        })
    }
    pub fn method10(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        defaultOf()
    }
    pub fn closure29(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method10(v0_1, v1_1, v2_1)
    }
    pub fn closure28(v0_1: Option<i32>, v1_1: string) -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure29(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure27(unitVar: (), v0_1: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure28(v0_1.clone(), v)
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
        v16.get_or_init(|| Func1::new(move |v: string| Networking::closure4((), v)))
            .clone()
    }
    pub fn test_port_open(x: string) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v16())(x)
    }
    pub fn v17() -> Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>> {
        static v17: OnceInit<Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>>> =
            OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: i32| Networking::closure13((), v)))
            .clone()
    }
    pub fn test_port_open_timeout(x: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        (Networking::v17())(x)
    }
    pub fn v18() -> Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>> {
        static v18: OnceInit<
            Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>>,
        > = OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure20((), v)))
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
        v19.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure27((), v)))
            .clone()
    }
    pub fn get_available_port(x: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        (Networking::v19())(x)
    }
    on_startup!(());
}
