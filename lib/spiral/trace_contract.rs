pub mod Trace {
    use super::*;
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
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    Option<i64>,
                    LrcPtr<Trace::Mut3>,
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
                            Option<i64>,
                            LrcPtr<Trace::Mut3>,
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
                            Option<i64>,
                            LrcPtr<Trace::Mut3>,
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
    impl Trace::US0 {
        pub fn get_IsUS0_0(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_1(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_2(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_3(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS0_4(this_: &MutCell<Trace::US0>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Trace::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut2 {
        pub l0: MutCell<Trace::US0>,
    }
    impl core::fmt::Display for Trace::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut3 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Trace::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(i64),
        US1_1,
    }
    impl Trace::US1 {
        pub fn get_IsUS1_0(this_: &MutCell<Trace::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS1_1(this_: &MutCell<Trace::US1>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl Trace::US2 {
        pub fn get_IsUS2_0(this_: &MutCell<Trace::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS2_1(this_: &MutCell<Trace::US2>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
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
    impl Trace::US3 {
        pub fn get_IsUS3_0(this_: &MutCell<Trace::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
        pub fn get_IsUS3_1(this_: &MutCell<Trace::US3>, unitArg: ()) -> bool {
            if unreachable!() {
                true
            } else {
                false
            }
        }
    }
    impl core::fmt::Display for Trace::US3 {
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
        let v33: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v35: bool = true;
        let _result = v33.map(|x| {
            //;
            let v37: std::string::String = x;
            let v39: string = fable_library_rust::String_::fromString(v37);
            let v41: bool = true;
            v39
        });
        let v43: Result<string, std::env::VarError> = _result;
        let v44: string = Trace::method2();
        {
            let x: string = v43.unwrap_or(v44);
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
        v0_1: Trace::US0,
    ) -> (
        LrcPtr<Trace::Mut0>,
        LrcPtr<Trace::Mut1>,
        LrcPtr<Trace::Mut2>,
        Option<i64>,
        LrcPtr<Trace::Mut3>,
    ) {
        let _v1: MutCell<Option<(Trace::US1, Trace::US2)>> =
            MutCell::new(None::<(Trace::US1, Trace::US2)>);
        _v1.set(Some((Trace::US1::US1_1, Trace::US2::US2_1)));
        {
            let patternInput: (Trace::US1, Trace::US2) = match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            };
            let v259: Trace::US2 = patternInput.1.clone();
            let v258: Trace::US1 = patternInput.0.clone();
            let v267: LrcPtr<Trace::Mut3> = LrcPtr::new(Trace::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Trace::closure1((), v))),
            });
            (
                LrcPtr::new(Trace::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Trace::Mut1 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Trace::Mut2 {
                    l0: MutCell::new(match &v259 {
                        Trace::US2::US2_0(v259_0_0) => match &v259 {
                            Trace::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v258 {
                    Trace::US1::US1_0(v258_0_0) => Some(match &v258 {
                        Trace::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
                v267,
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
    pub fn closure5(
        v0_1: Trace::US0,
        v1_1: Func0<string>,
        v2_1: Func0<string>,
        unitVar: (),
    ) -> string {
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(Trace::closure0((), Trace::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                Option<i64>,
                LrcPtr<Trace::Mut3>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Trace::method6();
                _v10.set(Some(x))
            }
            {
                let v152: string = match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                };
                let v159: Trace::US3 = if if let Trace::US0::US0_0 = &v0_1 {
                    true
                } else {
                    false
                } {
                    Trace::US3::US3_0(string("Verbose"))
                } else {
                    Trace::US3::US3_1
                };
                let v208: Trace::US3 = match &v159 {
                    Trace::US3::US3_0(v159_0_0) => Trace::US3::US3_0(match &v159 {
                        Trace::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v168: Trace::US3 = if if let Trace::US0::US0_1 = &v0_1 {
                            true
                        } else {
                            false
                        } {
                            Trace::US3::US3_0(string("Debug"))
                        } else {
                            Trace::US3::US3_1
                        };
                        match &v168 {
                            Trace::US3::US3_0(v168_0_0) => Trace::US3::US3_0(match &v168 {
                                Trace::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v177: Trace::US3 = if if let Trace::US0::US0_2 = &v0_1 {
                                    true
                                } else {
                                    false
                                } {
                                    Trace::US3::US3_0(string("Info"))
                                } else {
                                    Trace::US3::US3_1
                                };
                                match &v177 {
                                    Trace::US3::US3_0(v177_0_0) => Trace::US3::US3_0(match &v177 {
                                        Trace::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                    _ => {
                                        let v186: Trace::US3 = if if let Trace::US0::US0_3 = &v0_1 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Trace::US3::US3_0(string("Warning"))
                                        } else {
                                            Trace::US3::US3_1
                                        };
                                        match &v186 {
                                            Trace::US3::US3_0(v186_0_0) => {
                                                Trace::US3::US3_0(match &v186 {
                                                    Trace::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v195: Trace::US3 =
                                                    if if let Trace::US0::US0_4 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Trace::US3::US3_0(string("Critical"))
                                                    } else {
                                                        Trace::US3::US3_1
                                                    };
                                                match &v195 {
                                                    Trace::US3::US3_0(v195_0_0) => {
                                                        Trace::US3::US3_0(match &v195 {
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
                let v215: string = padLeft(
                    toLower(match &v208 {
                        Trace::US3::US3_0(v208_0_0) => match &v208 {
                            Trace::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let _v216: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v279: &str = match &v0_1 {
                    Trace::US0::US0_1 => inline_colorization::color_bright_blue,
                    Trace::US0::US0_2 => inline_colorization::color_bright_green,
                    Trace::US0::US0_0 => inline_colorization::color_bright_black,
                    Trace::US0::US0_3 => inline_colorization::color_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v281: &str = &*v215;
                let v283: &str = inline_colorization::color_reset;
                let v285: string = string("format!(\"{v279}{v281}{v283}\")");
                let v286: std::string::String = format!("{v279}{v281}{v283}");
                {
                    let x_2: string = fable_library_rust::String_::fromString(v286);
                    _v216.set(Some(x_2))
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
    pub fn method9(v0_1: Trace::US0, v1_1: Func0<string>) {
        fn v2_1(
            v: Trace::US0,
        ) -> (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            Option<i64>,
            LrcPtr<Trace::Mut3>,
        ) {
            Trace::closure0((), v)
        }
        if Trace::State::trace_state().get().clone().is_none() {
            Trace::State::trace_state().set(Some(v2_1(Trace::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Trace::Mut0>,
                LrcPtr<Trace::Mut1>,
                LrcPtr<Trace::Mut2>,
                Option<i64>,
                LrcPtr<Trace::Mut3>,
            ) = getValue(Trace::State::trace_state().get().clone());
            let v4: LrcPtr<Trace::Mut0> = patternInput.0.clone();
            if Trace::State::trace_state().get().clone().is_none() {
                Trace::State::trace_state().set(Some(v2_1(Trace::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    Option<i64>,
                    LrcPtr<Trace::Mut3>,
                ) = getValue(Trace::State::trace_state().get().clone());
                let v15: Trace::US0 = (patternInput_1.2.clone()).l0.get().clone();
                if if (patternInput_1.1.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0_1,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v15,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Trace::US0::US0_0, 0_i32)),
                            LrcPtr::new((Trace::US0::US0_1, 1_i32)),
                            LrcPtr::new((Trace::US0::US0_2, 2_i32)),
                            LrcPtr::new((Trace::US0::US0_3, 3_i32)),
                            LrcPtr::new((Trace::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v23: i64 = v4.l0.get().clone() + 1_i64;
                    v4.l0.set(v23);
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
    pub fn method4(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Trace::method9(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2_1 = v2_1.clone();
                move || Trace::closure5(v0_1.clone(), v1_1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure4(v0_1: Trace::US0, v1_1: Func0<string>, v2_1: Func0<string>) {
        Trace::method4(v0_1, v1_1, v2_1);
    }
    pub fn closure3(v0_1: Trace::US0, v1_1: Func0<string>) -> Func1<Func0<string>, ()> {
        Func1::new({
            let v0_1 = v0_1.clone();
            let v1_1 = v1_1.clone();
            move |v: Func0<string>| Trace::closure4(v0_1.clone(), v1_1.clone(), v)
        })
    }
    pub fn closure2(
        unitVar: (),
        v0_1: Trace::US0,
    ) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: Func0<string>| Trace::closure3(v0_1.clone(), v)
        })
    }
    pub fn v0() -> Func1<
        Trace::US0,
        (
            LrcPtr<Trace::Mut0>,
            LrcPtr<Trace::Mut1>,
            LrcPtr<Trace::Mut2>,
            Option<i64>,
            LrcPtr<Trace::Mut3>,
        ),
    > {
        static v0: OnceInit<
            Func1<
                Trace::US0,
                (
                    LrcPtr<Trace::Mut0>,
                    LrcPtr<Trace::Mut1>,
                    LrcPtr<Trace::Mut2>,
                    Option<i64>,
                    LrcPtr<Trace::Mut3>,
                ),
            >,
        > = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure0((), v)))
            .clone()
    }
    pub fn v1() -> Trace::US0 {
        static v1: OnceInit<Trace::US0> = OnceInit::new();
        v1.get_or_init(|| Trace::US0::US0_0).clone()
    }
    on_startup!(if Trace::State::trace_state().get().clone().is_none() {
        Trace::State::trace_state().set(Some((Trace::v0())(Trace::v1())));
    });
    pub fn v2() -> Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>> {
        static v2: OnceInit<Func1<Trace::US0, Func1<Func0<string>, Func1<Func0<string>, ()>>>> =
            OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: Trace::US0| Trace::closure2((), v)))
            .clone()
    }
    pub fn trace(x: Trace::US0) -> Func1<Func0<string>, Func1<Func0<string>, ()>> {
        (Trace::v2())(x)
    }
    on_startup!(());
}
