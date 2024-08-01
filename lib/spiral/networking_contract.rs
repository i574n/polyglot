pub mod Networking {
    use super::*;
    type Async<T> = T;
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
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(Networking::US0),
        US1_1,
    }
    impl core::fmt::Display for Networking::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
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
    pub fn method0() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method2() -> string {
        string("")
    }
    pub fn method1(v0: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v35: Result<std::string::String, std::env::VarError> = std::env::var(&*v0);
        let v37: bool = true;
        let _result = v35.map(|x| {
            //;
            let v39: std::string::String = x;
            let v41: string = fable_library_rust::String_::fromString(v39);
            let v43: bool = true;
            v41
        });
        let v45: Result<string, std::env::VarError> = _result;
        let v46: string = Networking::method2();
        {
            let x: string = v45.unwrap_or(v46);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method3() -> string {
        string("AUTOMATION")
    }
    pub fn closure1(unitVar: (), v0: string) {
        ();
    }
    pub fn closure0(
        unitVar: (),
        v0: Networking::US0,
    ) -> (
        LrcPtr<Networking::Mut0>,
        LrcPtr<Networking::Mut1>,
        LrcPtr<Networking::Mut2>,
        LrcPtr<Networking::Mut3>,
        Option<i64>,
    ) {
        let _v3: MutCell<Option<(Networking::US1, Networking::US2)>> =
            MutCell::new(None::<(Networking::US1, Networking::US2)>);
        let _v88: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v101: string = string("env!(\"AUTOMATION\")");
        let v102: &str = env!("AUTOMATION");
        let v104: std::string::String = String::from(v102);
        {
            let x: string = fable_library_rust::String_::fromString(v104);
            _v88.set(Some(x))
        }
        {
            let x_2: (Networking::US1, Networking::US2) = (
                Networking::US1::US1_1,
                if match &_v88.get().clone() {
                    None => panic!("{}", string("base.run_target / _v88=None"),),
                    Some(_v88_0_0) => _v88_0_0.clone(),
                } != string("True")
                {
                    Networking::US2::US2_1
                } else {
                    Networking::US2::US2_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            _v3.set(Some(x_2))
        }
        {
            let patternInput: (Networking::US1, Networking::US2) = match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            };
            let v402: Networking::US2 = patternInput.1.clone();
            let v401: Networking::US1 = patternInput.0.clone();
            (
                LrcPtr::new(Networking::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Networking::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Networking::closure1((), v))),
                }),
                LrcPtr::new(Networking::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Networking::Mut3 {
                    l0: MutCell::new(match &v401 {
                        Networking::US1::US1_0(v401_0_0) => match &v401 {
                            Networking::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0,
                    }),
                }),
                match &v402 {
                    Networking::US2::US2_0(v402_0_0) => Some(match &v402 {
                        Networking::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
    }
    pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
        string("networking.test_port_open")
    }
    pub fn closure5(v0: i32, v1: string, unitVar: ()) -> (i32, string) {
        (v0, v1)
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
    pub fn method9(v0: LrcPtr<Networking::Mut4>, v1: string) {
        let v4: string = sprintf!("{}", v1);
        let v12_1: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12_1);
        ()
    }
    pub fn method10(v0: LrcPtr<Networking::Mut4>) {
        ();
    }
    pub fn method11(v0: LrcPtr<Networking::Mut4>, v1: i32) {
        let v4: string = sprintf!("{}", v1);
        let v12_1: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12_1);
        ()
    }
    pub fn method8(v0: LrcPtr<Networking::Mut4>, v1: i32, v2_1: string) {
        Networking::method9(v0.clone(), string("{ "));
        Networking::method10(v0.clone());
        Networking::method9(v0.clone(), string("port"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method11(v0.clone(), v1);
        Networking::method9(v0.clone(), string("; "));
        Networking::method9(v0.clone(), string("ex"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method9(v0.clone(), v2_1);
        Networking::method9(v0, string(" }"))
    }
    pub fn closure6(
        v0: Networking::US0,
        v1: Func0<string>,
        v2_1: Func0<(i32, string)>,
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
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let v18: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v331: u64 = near_sdk::env::block_timestamp();
            let _v334: LrcPtr<MutCell<Option<Networking::US2>>> = refCell(None::<Networking::US2>);
            {
                let x_2: Option<Networking::US2> = match &v18 {
                    None => None::<Networking::US2>,
                    Some(v18_0_0) => {
                        let x: i64 = v18_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Networking::US2::US2_0(x)
                        }))())
                    }
                };
                _v334.set(x_2)
            }
            {
                let v361: Networking::US2 =
                    defaultValue(Networking::US2::US2_1, _v334.get().clone());
                let v375: u64 = match &v361 {
                    Networking::US2::US2_0(v361_0_0) => {
                        v331 - match &v361 {
                            Networking::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v331,
                } / 1000000000_u64;
                let v376: u64 = v375 % 60_u64;
                let v378: u64 = v375 / 60_u64 % 60_u64;
                let v380: u64 = v375 / 3600_u64 % 24_u64;
                let v382: std::string::String = format!("{:02}:{:02}:{:02}", v380, v378, v376);
                {
                    let x_3: string = fable_library_rust::String_::fromString(v382);
                    _v35.set(Some(x_3))
                }
                {
                    let v826: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v985: Networking::US3 = if if let Networking::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        Networking::US3::US3_0(string("Verbose"))
                    } else {
                        Networking::US3::US3_1
                    };
                    let v1034: Networking::US3 = match &v985 {
                        Networking::US3::US3_0(v985_0_0) => Networking::US3::US3_0(match &v985 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v994: Networking::US3 = if if let Networking::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                Networking::US3::US3_0(string("Debug"))
                            } else {
                                Networking::US3::US3_1
                            };
                            match &v994 {
                                Networking::US3::US3_0(v994_0_0) => {
                                    Networking::US3::US3_0(match &v994 {
                                        Networking::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v1003: Networking::US3 =
                                        if if let Networking::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Networking::US3::US3_0(string("Info"))
                                        } else {
                                            Networking::US3::US3_1
                                        };
                                    match &v1003 {
                                        Networking::US3::US3_0(v1003_0_0) => {
                                            Networking::US3::US3_0(match &v1003 {
                                                Networking::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v1012: Networking::US3 =
                                                if if let Networking::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Networking::US3::US3_0(string("Warning"))
                                                } else {
                                                    Networking::US3::US3_1
                                                };
                                            match &v1012 {
                                                Networking::US3::US3_0(v1012_0_0) => {
                                                    Networking::US3::US3_0(match &v1012 {
                                                        Networking::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v1021: Networking::US3 =
                                                        if if let Networking::US0::US0_4 = &v0 {
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
                                                    match &v1021 {
                                                        Networking::US3::US3_0(v1021_0_0) => {
                                                            Networking::US3::US3_0(match &v1021 {
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
                    let v1051: string = padLeft(
                        toLower(match &v1034 {
                            Networking::US3::US3_0(v1034_0_0) => match &v1034 {
                                Networking::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1146: &str = match &v0 {
                        Networking::US0::US0_1 => inline_colorization::color_bright_blue,
                        Networking::US0::US0_2 => inline_colorization::color_bright_green,
                        Networking::US0::US0_0 => inline_colorization::color_bright_black,
                        Networking::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1148: &str = &*v1051;
                    let v1150: &str = inline_colorization::color_reset;
                    let v1152: string = string("format!(\"{v1146}{v1148}{v1150}\")");
                    let v1153: std::string::String = format!("{v1146}{v1148}{v1150}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1153);
                        _v1083.set(Some(x_5))
                    }
                    {
                        let v1195: string = match &_v1083.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1083=None"),),
                            Some(_v1083_0_0) => _v1083_0_0.clone(),
                        };
                        let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (i32, string) = v2_1();
                        let v1218: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Networking::method8(
                            v1218.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v1219: string = v1218.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v826, v1195, v1214, v1(), v1219),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method12(v0: Networking::US0, v1: Func0<string>) {
        fn v4(
            v: Networking::US0,
        ) -> (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ) {
            Networking::closure0((), v)
        }
        if Networking::State::trace_state().get().clone().is_none() {
            Networking::State::trace_state().set(Some(v4(Networking::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let v13: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            if Networking::State::trace_state().get().clone().is_none() {
                Networking::State::trace_state().set(Some(v4(Networking::US0::US0_0)));
            }
            {
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
                    find(
                        v0,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                            LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                            LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                            LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                            LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
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
                    let v69: i64 = v13.l0.get().clone() + 1_i64;
                    v13.l0.set(v69);
                    {
                        let v72: string = sprintf!("{}", v1());
                        let _v81: MutCell<Option<()>> = MutCell::new(None::<()>);
                        near_sdk::log!("{}", v72.clone());
                        _v81.set(Some(()));
                        match &_v81.get().clone() {
                            None => panic!("{}", string("base.run_target / _v81=None"),),
                            Some(_v81_0_0) => _v81_0_0.clone(),
                        }
                        ((patternInput.1.clone()).l0.get().clone())(v72)
                    }
                }
            }
        }
    }
    pub fn method4(v0: Networking::US0, v1: Func0<string>, v2_1: Func0<(i32, string)>) {
        Networking::method12(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || Networking::closure6(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure3(v0: string, v1: i32) -> Arc<Async<bool>> {
        let _v4: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v4.set(Some(x))
        }
        match &_v4.get().clone() {
            None => panic!("{}", string("base.run_target / _v4=None"),),
            Some(_v4_0_0) => _v4_0_0.clone(),
        }
    }
    pub fn closure2(unitVar: (), v0: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: i32| Networking::closure3(v0.clone(), v)
        })
    }
    pub fn closure10(unitVar: (), v0: bool) -> Networking::US5 {
        Networking::US5::US5_0(v0)
    }
    pub fn closure11(unitVar: (), v0: LrcPtr<Exception>) -> Networking::US5 {
        Networking::US5::US5_1(v0)
    }
    pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async")
    }
    pub fn closure13(v0: i32, unitVar: ()) -> i32 {
        v0
    }
    pub fn method14(v0: LrcPtr<Networking::Mut4>, v1: i32) {
        Networking::method9(v0.clone(), string("{ "));
        Networking::method10(v0.clone());
        Networking::method9(v0.clone(), string("timeout"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method11(v0.clone(), v1);
        Networking::method9(v0, string(" }"))
    }
    pub fn closure14(
        v0: Networking::US0,
        v1: Func0<string>,
        v2_1: Func0<i32>,
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
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let v18: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v331: u64 = near_sdk::env::block_timestamp();
            let _v334: LrcPtr<MutCell<Option<Networking::US2>>> = refCell(None::<Networking::US2>);
            {
                let x_2: Option<Networking::US2> = match &v18 {
                    None => None::<Networking::US2>,
                    Some(v18_0_0) => {
                        let x: i64 = v18_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Networking::US2::US2_0(x)
                        }))())
                    }
                };
                _v334.set(x_2)
            }
            {
                let v361: Networking::US2 =
                    defaultValue(Networking::US2::US2_1, _v334.get().clone());
                let v375: u64 = match &v361 {
                    Networking::US2::US2_0(v361_0_0) => {
                        v331 - match &v361 {
                            Networking::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v331,
                } / 1000000000_u64;
                let v376: u64 = v375 % 60_u64;
                let v378: u64 = v375 / 60_u64 % 60_u64;
                let v380: u64 = v375 / 3600_u64 % 24_u64;
                let v382: std::string::String = format!("{:02}:{:02}:{:02}", v380, v378, v376);
                {
                    let x_3: string = fable_library_rust::String_::fromString(v382);
                    _v35.set(Some(x_3))
                }
                {
                    let v826: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v985: Networking::US3 = if if let Networking::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        Networking::US3::US3_0(string("Verbose"))
                    } else {
                        Networking::US3::US3_1
                    };
                    let v1034: Networking::US3 = match &v985 {
                        Networking::US3::US3_0(v985_0_0) => Networking::US3::US3_0(match &v985 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v994: Networking::US3 = if if let Networking::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                Networking::US3::US3_0(string("Debug"))
                            } else {
                                Networking::US3::US3_1
                            };
                            match &v994 {
                                Networking::US3::US3_0(v994_0_0) => {
                                    Networking::US3::US3_0(match &v994 {
                                        Networking::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v1003: Networking::US3 =
                                        if if let Networking::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Networking::US3::US3_0(string("Info"))
                                        } else {
                                            Networking::US3::US3_1
                                        };
                                    match &v1003 {
                                        Networking::US3::US3_0(v1003_0_0) => {
                                            Networking::US3::US3_0(match &v1003 {
                                                Networking::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v1012: Networking::US3 =
                                                if if let Networking::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Networking::US3::US3_0(string("Warning"))
                                                } else {
                                                    Networking::US3::US3_1
                                                };
                                            match &v1012 {
                                                Networking::US3::US3_0(v1012_0_0) => {
                                                    Networking::US3::US3_0(match &v1012 {
                                                        Networking::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v1021: Networking::US3 =
                                                        if if let Networking::US0::US0_4 = &v0 {
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
                                                    match &v1021 {
                                                        Networking::US3::US3_0(v1021_0_0) => {
                                                            Networking::US3::US3_0(match &v1021 {
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
                    let v1051: string = padLeft(
                        toLower(match &v1034 {
                            Networking::US3::US3_0(v1034_0_0) => match &v1034 {
                                Networking::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1146: &str = match &v0 {
                        Networking::US0::US0_1 => inline_colorization::color_bright_blue,
                        Networking::US0::US0_2 => inline_colorization::color_bright_green,
                        Networking::US0::US0_0 => inline_colorization::color_bright_black,
                        Networking::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1148: &str = &*v1051;
                    let v1150: &str = inline_colorization::color_reset;
                    let v1152: string = string("format!(\"{v1146}{v1148}{v1150}\")");
                    let v1153: std::string::String = format!("{v1146}{v1148}{v1150}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1153);
                        _v1083.set(Some(x_5))
                    }
                    {
                        let v1195: string = match &_v1083.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1083=None"),),
                            Some(_v1083_0_0) => _v1083_0_0.clone(),
                        };
                        let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v1217: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Networking::method14(v1217.clone(), v2_1());
                        {
                            let v1218: string = v1217.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v826, v1195, v1214, v1(), v1218),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method13(v0: Networking::US0, v1: Func0<string>, v2_1: Func0<i32>) {
        Networking::method12(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || Networking::closure14(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure15(unitVar: (), unitVar_1: ()) -> string {
        string("async.run_with_timeout_async**")
    }
    pub fn closure16(v0: i32, v1: LrcPtr<Exception>, unitVar: ()) -> (i32, string) {
        let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = sprintf!("{:?}", v1);
            _v4.set(Some(x))
        }
        (
            v0,
            match &_v4.get().clone() {
                None => panic!("{}", string("base.run_target / _v4=None"),),
                Some(_v4_0_0) => _v4_0_0.clone(),
            },
        )
    }
    pub fn method16(v0: LrcPtr<Networking::Mut4>, v1: i32, v2_1: string) {
        Networking::method9(v0.clone(), string("{ "));
        Networking::method10(v0.clone());
        Networking::method9(v0.clone(), string("timeout"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method11(v0.clone(), v1);
        Networking::method9(v0.clone(), string("; "));
        Networking::method9(v0.clone(), string("ex"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method9(v0.clone(), v2_1);
        Networking::method9(v0, string(" }"))
    }
    pub fn closure17(
        v0: Networking::US0,
        v1: Func0<string>,
        v2_1: Func0<(i32, string)>,
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
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let v18: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v331: u64 = near_sdk::env::block_timestamp();
            let _v334: LrcPtr<MutCell<Option<Networking::US2>>> = refCell(None::<Networking::US2>);
            {
                let x_2: Option<Networking::US2> = match &v18 {
                    None => None::<Networking::US2>,
                    Some(v18_0_0) => {
                        let x: i64 = v18_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Networking::US2::US2_0(x)
                        }))())
                    }
                };
                _v334.set(x_2)
            }
            {
                let v361: Networking::US2 =
                    defaultValue(Networking::US2::US2_1, _v334.get().clone());
                let v375: u64 = match &v361 {
                    Networking::US2::US2_0(v361_0_0) => {
                        v331 - match &v361 {
                            Networking::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v331,
                } / 1000000000_u64;
                let v376: u64 = v375 % 60_u64;
                let v378: u64 = v375 / 60_u64 % 60_u64;
                let v380: u64 = v375 / 3600_u64 % 24_u64;
                let v382: std::string::String = format!("{:02}:{:02}:{:02}", v380, v378, v376);
                {
                    let x_3: string = fable_library_rust::String_::fromString(v382);
                    _v35.set(Some(x_3))
                }
                {
                    let v826: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v985: Networking::US3 = if if let Networking::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        Networking::US3::US3_0(string("Verbose"))
                    } else {
                        Networking::US3::US3_1
                    };
                    let v1034: Networking::US3 = match &v985 {
                        Networking::US3::US3_0(v985_0_0) => Networking::US3::US3_0(match &v985 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v994: Networking::US3 = if if let Networking::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                Networking::US3::US3_0(string("Debug"))
                            } else {
                                Networking::US3::US3_1
                            };
                            match &v994 {
                                Networking::US3::US3_0(v994_0_0) => {
                                    Networking::US3::US3_0(match &v994 {
                                        Networking::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v1003: Networking::US3 =
                                        if if let Networking::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Networking::US3::US3_0(string("Info"))
                                        } else {
                                            Networking::US3::US3_1
                                        };
                                    match &v1003 {
                                        Networking::US3::US3_0(v1003_0_0) => {
                                            Networking::US3::US3_0(match &v1003 {
                                                Networking::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v1012: Networking::US3 =
                                                if if let Networking::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Networking::US3::US3_0(string("Warning"))
                                                } else {
                                                    Networking::US3::US3_1
                                                };
                                            match &v1012 {
                                                Networking::US3::US3_0(v1012_0_0) => {
                                                    Networking::US3::US3_0(match &v1012 {
                                                        Networking::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v1021: Networking::US3 =
                                                        if if let Networking::US0::US0_4 = &v0 {
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
                                                    match &v1021 {
                                                        Networking::US3::US3_0(v1021_0_0) => {
                                                            Networking::US3::US3_0(match &v1021 {
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
                    let v1051: string = padLeft(
                        toLower(match &v1034 {
                            Networking::US3::US3_0(v1034_0_0) => match &v1034 {
                                Networking::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1146: &str = match &v0 {
                        Networking::US0::US0_1 => inline_colorization::color_bright_blue,
                        Networking::US0::US0_2 => inline_colorization::color_bright_green,
                        Networking::US0::US0_0 => inline_colorization::color_bright_black,
                        Networking::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1148: &str = &*v1051;
                    let v1150: &str = inline_colorization::color_reset;
                    let v1152: string = string("format!(\"{v1146}{v1148}{v1150}\")");
                    let v1153: std::string::String = format!("{v1146}{v1148}{v1150}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1153);
                        _v1083.set(Some(x_5))
                    }
                    {
                        let v1195: string = match &_v1083.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1083=None"),),
                            Some(_v1083_0_0) => _v1083_0_0.clone(),
                        };
                        let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (i32, string) = v2_1();
                        let v1218: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Networking::method16(
                            v1218.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                        );
                        {
                            let v1219: string = v1218.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v826, v1195, v1214, v1(), v1219),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method15(v0: Networking::US0, v1: Func0<string>, v2_1: Func0<(i32, string)>) {
        Networking::method12(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || Networking::closure17(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn closure9(v0: i32, v1: string, v2_1: i32) -> Arc<Async<bool>> {
        let _v5: MutCell<Option<Arc<Async<bool>>>> = MutCell::new(None::<Arc<Async<bool>>>);
        {
            let x: Arc<Async<bool>> = defaultOf();
            _v5.set(Some(x))
        }
        match &_v5.get().clone() {
            None => panic!("{}", string("base.run_target / _v5=None"),),
            Some(_v5_0_0) => _v5_0_0.clone(),
        }
    }
    pub fn closure8(v0: i32, v1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: i32| Networking::closure9(v0, v1.clone(), v)
        })
    }
    pub fn closure7(unitVar: (), v0: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Networking::closure8(v0, v)
        })
    }
    pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
        string("networking.wait_for_port_access")
    }
    pub fn closure23(
        v0: Option<i32>,
        v1: bool,
        v2_1: i32,
        v3_1: i64,
        unitVar: (),
    ) -> (i32, i64, Option<i32>, bool) {
        (v2_1, v3_1, v0, v1)
    }
    pub fn method20(v0: LrcPtr<Networking::Mut4>, v1: i64) {
        let v4: string = sprintf!("{}", v1);
        let v12_1: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12_1);
        ()
    }
    pub fn method21(v0: LrcPtr<Networking::Mut4>, v1: Option<i32>) {
        Networking::method9(v0, sprintf!("{:?}", v1));
    }
    pub fn method22(v0: LrcPtr<Networking::Mut4>, v1: bool) {
        let v7: string = sprintf!("{}", if v1 { string("true") } else { string("false") });
        let v15: string = append(v0.l0.get().clone(), v7);
        v0.l0.set(v15);
        ()
    }
    pub fn method19(v0: LrcPtr<Networking::Mut4>, v1: i32, v2_1: i64, v3_1: Option<i32>, v4: bool) {
        Networking::method9(v0.clone(), string("{ "));
        Networking::method10(v0.clone());
        Networking::method9(v0.clone(), string("port"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method11(v0.clone(), v1);
        Networking::method9(v0.clone(), string("; "));
        Networking::method9(v0.clone(), string("retry"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method20(v0.clone(), v2_1);
        Networking::method9(v0.clone(), string("; "));
        Networking::method9(v0.clone(), string("timeout"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method21(v0.clone(), v3_1);
        Networking::method9(v0.clone(), string("; "));
        Networking::method9(v0.clone(), string("status"));
        Networking::method9(v0.clone(), string(" = "));
        Networking::method22(v0.clone(), v4);
        Networking::method9(v0, string(" }"))
    }
    pub fn closure24(
        v0: Networking::US0,
        v1: Func0<string>,
        v2_1: Func0<(i32, i64, Option<i32>, bool)>,
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
                LrcPtr<Networking::Mut3>,
                Option<i64>,
            ) = getValue(Networking::State::trace_state().get().clone());
            let v18: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v331: u64 = near_sdk::env::block_timestamp();
            let _v334: LrcPtr<MutCell<Option<Networking::US2>>> = refCell(None::<Networking::US2>);
            {
                let x_2: Option<Networking::US2> = match &v18 {
                    None => None::<Networking::US2>,
                    Some(v18_0_0) => {
                        let x: i64 = v18_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Networking::US2::US2_0(x)
                        }))())
                    }
                };
                _v334.set(x_2)
            }
            {
                let v361: Networking::US2 =
                    defaultValue(Networking::US2::US2_1, _v334.get().clone());
                let v375: u64 = match &v361 {
                    Networking::US2::US2_0(v361_0_0) => {
                        v331 - match &v361 {
                            Networking::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v331,
                } / 1000000000_u64;
                let v376: u64 = v375 % 60_u64;
                let v378: u64 = v375 / 60_u64 % 60_u64;
                let v380: u64 = v375 / 3600_u64 % 24_u64;
                let v382: std::string::String = format!("{:02}:{:02}:{:02}", v380, v378, v376);
                {
                    let x_3: string = fable_library_rust::String_::fromString(v382);
                    _v35.set(Some(x_3))
                }
                {
                    let v826: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v985: Networking::US3 = if if let Networking::US0::US0_0 = &v0 {
                        true
                    } else {
                        false
                    } {
                        Networking::US3::US3_0(string("Verbose"))
                    } else {
                        Networking::US3::US3_1
                    };
                    let v1034: Networking::US3 = match &v985 {
                        Networking::US3::US3_0(v985_0_0) => Networking::US3::US3_0(match &v985 {
                            Networking::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v994: Networking::US3 = if if let Networking::US0::US0_1 = &v0 {
                                true
                            } else {
                                false
                            } {
                                Networking::US3::US3_0(string("Debug"))
                            } else {
                                Networking::US3::US3_1
                            };
                            match &v994 {
                                Networking::US3::US3_0(v994_0_0) => {
                                    Networking::US3::US3_0(match &v994 {
                                        Networking::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v1003: Networking::US3 =
                                        if if let Networking::US0::US0_2 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Networking::US3::US3_0(string("Info"))
                                        } else {
                                            Networking::US3::US3_1
                                        };
                                    match &v1003 {
                                        Networking::US3::US3_0(v1003_0_0) => {
                                            Networking::US3::US3_0(match &v1003 {
                                                Networking::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v1012: Networking::US3 =
                                                if if let Networking::US0::US0_3 = &v0 {
                                                    true
                                                } else {
                                                    false
                                                } {
                                                    Networking::US3::US3_0(string("Warning"))
                                                } else {
                                                    Networking::US3::US3_1
                                                };
                                            match &v1012 {
                                                Networking::US3::US3_0(v1012_0_0) => {
                                                    Networking::US3::US3_0(match &v1012 {
                                                        Networking::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v1021: Networking::US3 =
                                                        if if let Networking::US0::US0_4 = &v0 {
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
                                                    match &v1021 {
                                                        Networking::US3::US3_0(v1021_0_0) => {
                                                            Networking::US3::US3_0(match &v1021 {
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
                    let v1051: string = padLeft(
                        toLower(match &v1034 {
                            Networking::US3::US3_0(v1034_0_0) => match &v1034 {
                                Networking::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v1083: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v1146: &str = match &v0 {
                        Networking::US0::US0_1 => inline_colorization::color_bright_blue,
                        Networking::US0::US0_2 => inline_colorization::color_bright_green,
                        Networking::US0::US0_0 => inline_colorization::color_bright_black,
                        Networking::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1148: &str = &*v1051;
                    let v1150: &str = inline_colorization::color_reset;
                    let v1152: string = string("format!(\"{v1146}{v1148}{v1150}\")");
                    let v1153: std::string::String = format!("{v1146}{v1148}{v1150}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1153);
                        _v1083.set(Some(x_5))
                    }
                    {
                        let v1195: string = match &_v1083.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1083=None"),),
                            Some(_v1083_0_0) => _v1083_0_0.clone(),
                        };
                        let v1214: i64 = (patternInput.0.clone()).l0.get().clone();
                        let patternInput_1: (i32, i64, Option<i32>, bool) = v2_1();
                        let v1220: LrcPtr<Networking::Mut4> = LrcPtr::new(Networking::Mut4 {
                            l0: MutCell::new(string("")),
                        });
                        Networking::method19(
                            v1220.clone(),
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                            patternInput_1.3.clone(),
                        );
                        {
                            let v1221: string = v1220.l0.get().clone();
                            trimEndChars(
                                trimStartChars(
                                    sprintf!("{} {} #{} {} / {}", v826, v1195, v1214, v1(), v1221),
                                    toArray(empty::<char>()),
                                ),
                                toArray(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method18(
        v0: Networking::US0,
        v1: Func0<string>,
        v2_1: Func0<(i32, i64, Option<i32>, bool)>,
    ) {
        Networking::method12(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2_1 = v2_1.clone();
                move || Networking::closure24(v0.clone(), v1.clone(), v2_1.clone(), ())
            }),
        );
    }
    pub fn method17(
        v0: Option<i32>,
        v1: bool,
        v2_1: string,
        v3_1: i32,
        v4: i64,
    ) -> Arc<Async<i64>> {
        let _v7: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
        {
            let x: Arc<Async<i64>> = defaultOf();
            _v7.set(Some(x))
        }
        match &_v7.get().clone() {
            None => panic!("{}", string("base.run_target / _v7=None"),),
            Some(_v7_0_0) => _v7_0_0.clone(),
        }
    }
    pub fn closure21(v0: Option<i32>, v1: bool, v2_1: string, v3_1: i32) -> Arc<Async<i64>> {
        Networking::method17(v0, v1, v2_1, v3_1, 0_i64)
    }
    pub fn closure20(v0: Option<i32>, v1: bool, v2_1: string) -> Func1<i32, Arc<Async<i64>>> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            let v2_1 = v2_1.clone();
            move |v: i32| Networking::closure21(v0.clone(), v1, v2_1.clone(), v)
        })
    }
    pub fn closure19(v0: Option<i32>, v1: bool) -> Func1<string, Func1<i32, Arc<Async<i64>>>> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: string| Networking::closure20(v0.clone(), v1, v)
        })
    }
    pub fn closure18(
        unitVar: (),
        v0: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: bool| Networking::closure19(v0.clone(), v)
        })
    }
    pub fn method23(v0: Option<i32>, v1: string, v2_1: i32) -> Arc<Async<i32>> {
        let _v5: MutCell<Option<Arc<Async<i32>>>> = MutCell::new(None::<Arc<Async<i32>>>);
        {
            let x: Arc<Async<i32>> = defaultOf();
            _v5.set(Some(x))
        }
        match &_v5.get().clone() {
            None => panic!("{}", string("base.run_target / _v5=None"),),
            Some(_v5_0_0) => _v5_0_0.clone(),
        }
    }
    pub fn closure27(v0: Option<i32>, v1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method23(v0, v1, v2_1)
    }
    pub fn closure26(v0: Option<i32>, v1: string) -> Func1<i32, Arc<Async<i32>>> {
        Func1::new({
            let v0 = v0.clone();
            let v1 = v1.clone();
            move |v: i32| Networking::closure27(v0.clone(), v1.clone(), v)
        })
    }
    pub fn closure25(unitVar: (), v0: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        Func1::new({
            let v0 = v0.clone();
            move |v: string| Networking::closure26(v0.clone(), v)
        })
    }
    pub fn v2() -> Func1<
        Networking::US0,
        (
            LrcPtr<Networking::Mut0>,
            LrcPtr<Networking::Mut1>,
            LrcPtr<Networking::Mut2>,
            LrcPtr<Networking::Mut3>,
            Option<i64>,
        ),
    > {
        static v2: OnceInit<
            Func1<
                Networking::US0,
                (
                    LrcPtr<Networking::Mut0>,
                    LrcPtr<Networking::Mut1>,
                    LrcPtr<Networking::Mut2>,
                    LrcPtr<Networking::Mut3>,
                    Option<i64>,
                ),
            >,
        > = OnceInit::new();
        v2.get_or_init(|| Func1::new(move |v: Networking::US0| Networking::closure0((), v)))
            .clone()
    }
    pub fn v3() -> Networking::US0 {
        static v3: OnceInit<Networking::US0> = OnceInit::new();
        v3.get_or_init(|| Networking::US0::US0_0).clone()
    }
    on_startup!(
        if Networking::State::trace_state().get().clone().is_none() {
            Networking::State::trace_state().set(Some((Networking::v2())(Networking::v3())));
        }
    );
    pub fn v9() -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        static v9: OnceInit<Func1<string, Func1<i32, Arc<Async<bool>>>>> = OnceInit::new();
        v9.get_or_init(|| Func1::new(move |v: string| Networking::closure2((), v)))
            .clone()
    }
    pub fn test_port_open(x: string) -> Func1<i32, Arc<Async<bool>>> {
        (Networking::v9())(x)
    }
    pub fn v10() -> Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>> {
        static v10: OnceInit<Func1<i32, Func1<string, Func1<i32, Arc<Async<bool>>>>>> =
            OnceInit::new();
        v10.get_or_init(|| Func1::new(move |v: i32| Networking::closure7((), v)))
            .clone()
    }
    pub fn test_port_open_timeout(x: i32) -> Func1<string, Func1<i32, Arc<Async<bool>>>> {
        (Networking::v10())(x)
    }
    pub fn v11() -> Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>> {
        static v11: OnceInit<
            Func1<Option<i32>, Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>>>,
        > = OnceInit::new();
        v11.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure18((), v)))
            .clone()
    }
    pub fn wait_for_port_access(
        x: Option<i32>,
    ) -> Func1<bool, Func1<string, Func1<i32, Arc<Async<i64>>>>> {
        (Networking::v11())(x)
    }
    pub fn v12() -> Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>> {
        static v12: OnceInit<Func1<Option<i32>, Func1<string, Func1<i32, Arc<Async<i32>>>>>> =
            OnceInit::new();
        v12.get_or_init(|| Func1::new(move |v: Option<i32>| Networking::closure25((), v)))
            .clone()
    }
    pub fn get_available_port(x: Option<i32>) -> Func1<string, Func1<i32, Arc<Async<i32>>>> {
        (Networking::v12())(x)
    }
    on_startup!(());
}
