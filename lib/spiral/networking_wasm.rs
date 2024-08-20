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
        let v18_1: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v20: bool = true;
        let _result = v18_1.map(|x| {
            //;
            let v22: std::string::String = x;
            let v24: string = fable_library_rust::String_::fromString(v22);
            let v26: bool = true;
            v24
        });
        let v28: Result<string, std::env::VarError> = _result;
        let v29: string = Networking::method3();
        v28.unwrap_or(v29)
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
        let _v1: (Networking::US2, Networking::US3) =
            (Networking::US2::US2_1, Networking::US3::US3_1);
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
    pub fn closure13(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure12(unitVar: (), v0_1: string) {
        let v3: () = {
            Networking::closure13(v0_1, ());
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
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v33: () = {
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
        let v61: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v61,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v69: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v73: () = {
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
            let _v170: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v175: () = {
                Networking::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v170 = _v170.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v170.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v190: Networking::US3 = defaultValue(Networking::US3::US3_1, _v170.get().clone());
            let v230: DateTime = match &v190 {
                Networking::US3::US3_0(v190_0_0) => {
                    let v204: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v190 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v204.hours(),
                        v204.minutes(),
                        v204.seconds(),
                        v204.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v235: string = {
                let provider: string = Networking::method5();
                v230.toString(provider)
            };
            let v559: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v586: &str = inline_colorization::color_bright_black;
            let v588: &str = &*v559;
            let v590: &str = inline_colorization::color_reset;
            let v592: string = string("format!(\"{v586}{v588}{v590}\")");
            let v593: std::string::String = format!("{v586}{v588}{v590}");
            let v595: string = fable_library_rust::String_::fromString(v593);
            let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v627: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(Networking::method8()),
            });
            let v634: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v643: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", string("port")), ());
                ()
            };
            let v652: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v660: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v669: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v678: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v686: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v694: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v703: () = {
                Networking::closure10(v627.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v706: string = v627.l0.get().clone();
            let v745: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v235,
                        v595,
                        v625,
                        Networking::closure11((), ()),
                        v706
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v745.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v745)
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
    pub fn closure17(unitVar: (), v0_1: bool) -> Networking::US5 {
        Networking::US5::US5_0(v0_1)
    }
    pub fn closure18(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US5 {
        Networking::US5::US5_1(v0_1)
    }
    pub fn closure20(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure19(v0_1: i32, unitVar: ()) {
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
        let v32: () = {
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
        let v60: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v60,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v68: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v72: () = {
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
            let _v169: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v174: () = {
                Networking::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v169 = _v169.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v169.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v189: Networking::US3 = defaultValue(Networking::US3::US3_1, _v169.get().clone());
            let v229: DateTime = match &v189 {
                Networking::US3::US3_0(v189_0_0) => {
                    let v203: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v189 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v203.hours(),
                        v203.minutes(),
                        v203.seconds(),
                        v203.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v234: string = {
                let provider: string = Networking::method5();
                v229.toString(provider)
            };
            let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v585: &str = inline_colorization::color_bright_black;
            let v587: &str = &*v558;
            let v589: &str = inline_colorization::color_reset;
            let v591: string = string("format!(\"{v585}{v587}{v589}\")");
            let v592: std::string::String = format!("{v585}{v587}{v589}");
            let v594: string = fable_library_rust::String_::fromString(v592);
            let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v626: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(Networking::method8()),
            });
            let v633: () = {
                Networking::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v642: () = {
                Networking::closure10(v626.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v651: () = {
                Networking::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v659: () = {
                Networking::closure10(v626.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v668: () = {
                Networking::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v671: string = v626.l0.get().clone();
            let v710: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v234,
                        v594,
                        v624,
                        Networking::closure20((), ()),
                        v671
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v710.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v710)
        }
    }
    pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure21(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
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
        let v33: () = {
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
        let v61: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v61,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v69: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v73: () = {
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
            let _v170: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v175: () = {
                Networking::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v170 = _v170.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v170.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v190: Networking::US3 = defaultValue(Networking::US3::US3_1, _v170.get().clone());
            let v230: DateTime = match &v190 {
                Networking::US3::US3_0(v190_0_0) => {
                    let v204: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v190 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v204.hours(),
                        v204.minutes(),
                        v204.seconds(),
                        v204.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v235: string = {
                let provider: string = Networking::method5();
                v230.toString(provider)
            };
            let v559: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v586: &str = inline_colorization::color_bright_red;
            let v588: &str = &*v559;
            let v590: &str = inline_colorization::color_reset;
            let v592: string = string("format!(\"{v586}{v588}{v590}\")");
            let v593: std::string::String = format!("{v586}{v588}{v590}");
            let v595: string = fable_library_rust::String_::fromString(v593);
            let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v630: string = sprintf!("{:?}", v1_1);
            let v649: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(Networking::method8()),
            });
            let v656: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v665: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v674: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v682: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v691: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v700: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v708: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v716: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", v630), ());
                ()
            };
            let v725: () = {
                Networking::closure10(v649.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v728: string = v649.l0.get().clone();
            let v767: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v235,
                        v595,
                        v625,
                        Networking::closure22((), ()),
                        v728
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v767.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v767)
        }
    }
    pub fn closure16(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        defaultOf()
    }
    pub fn closure15(v0_1: i32, v1_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure16(v0_1, v1_1.clone(), v)
        })
    }
    pub fn closure14(unitVar: (), v0_1: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure15(v0_1, v)
        })
    }
    pub fn closure27(
        v0_1: LrcPtr<MutCell<Option<Networking::US7>>>,
        v1_1: Option<Networking::US7>,
    ) -> LrcPtr<MutCell<Option<Networking::US7>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure28(
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
    pub fn closure30(unitVar: (), unitVar_1: ()) -> string {
        string("networking.wait_for_port_access")
    }
    pub fn closure29(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3: i64, unitVar: ()) {
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
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v35: () = {
            v5();
            ()
        };
        let patternInput_1: (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) = getValue(Networking::State::trace_state().get().clone());
        let v63: Networking::US0 = (patternInput_1.3.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v63,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v71: () = {
                Networking::closure7(patternInput.0.clone(), ());
                ()
            };
            let v75: () = {
                v5();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let _v172: LrcPtr<MutCell<Option<Networking::US3>>> = refCell(None::<Networking::US3>);
            let v177: () = {
                Networking::closure9(
                    patternInput_2.4.clone(),
                    Func1::new({
                        let _v172 = _v172.clone();
                        move |v: Option<Networking::US3>| Networking::closure8(_v172.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v192: Networking::US3 = defaultValue(Networking::US3::US3_1, _v172.get().clone());
            let v232: DateTime = match &v192 {
                Networking::US3::US3_0(v192_0_0) => {
                    let v206: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v192 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v206.hours(),
                        v206.minutes(),
                        v206.seconds(),
                        v206.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v237: string = {
                let provider: string = Networking::method5();
                v232.toString(provider)
            };
            let v561: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v588: &str = inline_colorization::color_bright_black;
            let v590: &str = &*v561;
            let v592: &str = inline_colorization::color_reset;
            let v594: string = string("format!(\"{v588}{v590}{v592}\")");
            let v595: std::string::String = format!("{v588}{v590}{v592}");
            let v597: string = fable_library_rust::String_::fromString(v595);
            let v627: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v629: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                l0: MutCell::new(Networking::method8()),
            });
            let v636: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v645: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string("port")), ());
                ()
            };
            let v654: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v662: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", v2_1), ());
                ()
            };
            let v671: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v680: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v688: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v696: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v704: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v713: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string("timeout")), ());
                ()
            };
            let v721: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v730: std::string::String = format!("{:#?}", v0_1);
            let v756: () = {
                Networking::closure10(
                    v629.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v730)),
                    (),
                );
                ()
            };
            let v764: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v773: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string("status")), ());
                ()
            };
            let v781: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v792: () = {
                Networking::closure10(
                    v629.clone(),
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
            let v801: () = {
                Networking::closure10(v629.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v804: string = v629.l0.get().clone();
            let v843: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v237,
                        v597,
                        v627,
                        Networking::closure30((), ()),
                        v804
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            println!("{}", v843.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v843)
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
    pub fn closure26(v0_1: Option<i32>, v1_1: bool, v2_1: string, v3: i32) -> Arc<Async<i64>> {
        Networking::method9(v0_1, v1_1, v2_1, v3, 0_i64)
    }
    pub fn closure25(v0_1: Option<i32>, v1_1: bool, v2_1: string) -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            let v2_1 = v2_1.clone();
            move |v: i32| Networking::closure26(v0_1.clone(), v1_1, v2_1.clone(), v)
        })
    }
    pub fn closure24(v0_1: Option<i32>, v1_1: bool) -> Func1<string, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: string| Networking::closure25(v0_1.clone(), v1_1, v)
        })
    }
    pub fn closure23(
        unitVar: (),
        v0_1: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: bool| Networking::closure24(v0_1.clone(), v)
        })
    }
    pub fn method10(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        defaultOf()
    }
    pub fn closure33(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method10(v0_1, v1_1, v2_1)
    }
    pub fn closure32(v0_1: Option<i32>, v1_1: string) -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: i32| Networking::closure33(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure31(unitVar: (), v0_1: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: string| Networking::closure32(v0_1.clone(), v)
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
    pub fn v15() -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        static v15: OnceInit<Func1<string, Func1<i32, Arc<Async<bool>>>>> = OnceInit::new();
        v15.get_or_init(|| Func1::new(move |v: string| Networking::closure4((), v)))
            .clone()
    }
    pub fn test_port_open(x: string) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v15())(x)
    }
    pub fn v16() -> Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>> {
        static v16: OnceInit<Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>>> =
            OnceInit::new();
        v16.get_or_init(|| Func1::new(move |v: i32| Networking::closure14((), v)))
            .clone()
    }
    pub fn test_port_open_timeout(x: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        (Networking::v16())(x)
    }
    pub fn v17() -> Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>> {
        static v17: OnceInit<
            Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>>,
        > = OnceInit::new();
        v17.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure23((), v)))
            .clone()
    }
    pub fn wait_for_port_access(
        x: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        (Networking::v17())(x)
    }
    pub fn v18() -> Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>> {
        static v18: OnceInit<Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>>> =
            OnceInit::new();
        v18.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure31((), v)))
            .clone()
    }
    pub fn get_available_port(x: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        (Networking::v18())(x)
    }
    on_startup!(());
}
