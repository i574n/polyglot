pub mod Networking {
    use super::*;
    type Async<T> = T;
    use fable_library_rust::Choice_::Choice_2;
    type DateTime = ();
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::Native_::getZero;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Arc;
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
    use fable_library_rust::System::Exception;
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
        pub l0: MutCell<Networking::US0>,
    }
    impl core::fmt::Display for Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US1 {
        US1_0(Networking::US0),
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
        US4_0(Networking::US3),
        US4_1(Networking::US3),
        US4_2(Networking::US3),
        US4_3(Networking::US3),
        US4_4(Networking::US3),
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
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US6 {
        US6_0(bool),
        US6_1,
    }
    impl core::fmt::Display for US6 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US7 {
        US7_0(bool),
        US7_1(LrcPtr<Exception>),
    }
    impl core::fmt::Display for US7 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub enum US8 {
        US8_0(bool),
        US8_1(LrcPtr<Exception>),
    }
    impl core::fmt::Display for US8 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US9 {
        US9_0(i32),
        US9_1,
    }
    impl core::fmt::Display for US9 {
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
    pub fn closure1(unitVar: (), v0_1: string) -> Networking::US5 {
        Networking::US5::US5_0(v0_1)
    }
    pub fn method5() -> Func1<string, Networking::US5> {
        Func1::new(move |v: string| Networking::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "env.get_environment_variable / target: {} / var: {}",
                Networking::US4::US4_2(Networking::US3::US3_2),
                v0_1
            ),
        )
    }
    pub fn method1() -> (Networking::US1, Networking::US2) {
        let v1_1: string = Networking::method2(string("TRACE_LEVEL"));
        let v6: Networking::US1 = if string("Verbose") == (v1_1.clone()) {
            Networking::US1::US1_0(Networking::US0::US0_0)
        } else {
            Networking::US1::US1_1
        };
        (
            match &v6 {
                Networking::US1::US1_0(v6_0_0) => Networking::US1::US1_0(
                    match &v6 {
                        Networking::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => {
                    let v13: Networking::US1 = if string("Debug") == (v1_1.clone()) {
                        Networking::US1::US1_0(Networking::US0::US0_1)
                    } else {
                        Networking::US1::US1_1
                    };
                    match &v13 {
                        Networking::US1::US1_0(v13_0_0) => Networking::US1::US1_0(
                            match &v13 {
                                Networking::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        ),
                        _ => {
                            let v20: Networking::US1 = if string("Info") == (v1_1.clone()) {
                                Networking::US1::US1_0(Networking::US0::US0_2)
                            } else {
                                Networking::US1::US1_1
                            };
                            match &v20 {
                                Networking::US1::US1_0(v20_0_0) => Networking::US1::US1_0(
                                    match &v20 {
                                        Networking::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ),
                                _ => {
                                    let v27: Networking::US1 =
                                        if string("Warning") == (v1_1.clone()) {
                                            Networking::US1::US1_0(Networking::US0::US0_3)
                                        } else {
                                            Networking::US1::US1_1
                                        };
                                    match &v27 {
                                        Networking::US1::US1_0(v27_0_0) => Networking::US1::US1_0(
                                            match &v27 {
                                                Networking::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        ),
                                        _ => {
                                            let v34: Networking::US1 =
                                                if string("Critical") == (v1_1.clone()) {
                                                    Networking::US1::US1_0(Networking::US0::US0_4)
                                                } else {
                                                    Networking::US1::US1_1
                                                };
                                            match &v34 {
                                                Networking::US1::US1_0(v34_0_0) => {
                                                    Networking::US1::US1_0(
                                                        match &v34 {
                                                            Networking::US1::US1_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                    )
                                                }
                                                _ => Networking::US1::US1_1,
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            },
            if (Networking::method2(string("AUTOMATION"))) != string("True") {
                Networking::US2::US2_1
            } else {
                let v58: DateTime = unbox::<DateTime>(&getZero());
                Networking::US2::US2_0(unbox::<i64>(&getZero()))
            },
        )
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
        let v64: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
        let v65: &str = option_env!("AUTOMATION").unwrap_or("");
        let v72: std::string::String = String::from(v65);
        let _run_target_args__v1: (Networking::US1, Networking::US2) = (
            Networking::US1::US1_1,
            if (fable_library_rust::String_::fromString(v72)) != string("True") {
                Networking::US2::US2_1
            } else {
                Networking::US2::US2_0(near_sdk::env::block_timestamp() as i64)
            },
        );
        let v132: Networking::US2 = _run_target_args__v1.1.clone();
        let v131: Networking::US1 = _run_target_args__v1.0.clone();
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
                l0: MutCell::new(match &v131 {
                    Networking::US1::US1_0(v131_0_0) => match &v131 {
                        Networking::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v0_1.clone(),
                }),
            }),
            match &v132 {
                Networking::US2::US2_0(v132_0_0) => Some(match &v132 {
                    Networking::US2::US2_0(x) => x.clone(),
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
    pub fn method8(v0_1: Networking::US0) -> bool {
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
        ) = Networking::TraceState::trace_state().get().clone().unwrap();
        let v35: Networking::US0 = (patternInput.4.clone()).l0.get().clone();
        if ((patternInput.2.clone()).l0.get().clone()) == false {
            false
        } else {
            (find(
                v0_1,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                    LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                    LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                    LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                    LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                ])))),
            )) >= (find(
                v35,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                    LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                    LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                    LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                    LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                ])))),
            ))
        }
    }
    pub fn closure6(unitVar: (), v0_1: i64) -> Networking::US2 {
        Networking::US2::US2_0(v0_1)
    }
    pub fn method10() -> Func1<i64, Networking::US2> {
        Func1::new(move |v: i64| Networking::closure6((), v))
    }
    pub fn method11() -> string {
        string("hh:mm:ss")
    }
    pub fn method12() -> string {
        string("HH:mm:ss")
    }
    pub fn method9(
        v0_1: LrcPtr<Networking::Mut0>,
        v1_1: LrcPtr<Networking::Mut1>,
        v2_1: LrcPtr<Networking::Mut2>,
        v3: LrcPtr<Networking::Mut3>,
        v4: LrcPtr<Networking::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v272: u64 = near_sdk::env::block_timestamp();
        let v286: Networking::US2 =
            defaultValue(Networking::US2::US2_1, map(Networking::method10(), v5));
        let v298: u64 = (match &v286 {
            Networking::US2::US2_0(v286_0_0) => {
                (v272)
                    - (match &v286 {
                        Networking::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64)
            }
            _ => v272,
        }) / 1000000000_u64;
        let v299: u64 = (v298) % 60_u64;
        let v301: u64 = ((v298) / 60_u64) % 60_u64;
        let v303: u64 = ((v298) / 3600_u64) % 24_u64;
        let v305: std::string::String = format!("{:02}:{:02}:{:02}", v303, v301, v299);
        fable_library_rust::String_::fromString(v305)
    }
    pub fn method15() -> string {
        string("")
    }
    pub fn closure7(v0_1: LrcPtr<Networking::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append((v0_1.l0.get().clone()), (v1_1));
        v0_1.l0.set(v3);
        ()
    }
    pub fn method14(v0_1: char) -> string {
        let v2_1: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method15()),
        });
        let v8: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method16() -> string {
        string("\u{001b}[0m")
    }
    pub fn method13() -> string {
        let v6: string = Networking::method14(getCharAt(toLower(string("Verbose")), 0_i32));
        let v73: &str = inline_colorization::color_bright_black;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
    }
    pub fn method18(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method15()),
        });
        let v10: () = {
            Networking::closure7(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            Networking::closure7(v3.clone(), string("port"), ());
            ()
        };
        let v28: () = {
            Networking::closure7(v3.clone(), string(" = "), ());
            ()
        };
        let v36: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Networking::closure7(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            Networking::closure7(v3.clone(), string("ex"), ());
            ()
        };
        let v62: () = {
            Networking::closure7(v3.clone(), string(" = "), ());
            ()
        };
        let v70: () = {
            Networking::closure7(v3.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            Networking::closure7(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method19(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method17(
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
        let v10: string = Networking::method18(v8, v9);
        Networking::method19(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("networking.test_port_open"),
            v10
        ))
    }
    pub fn closure8(v0_1: LrcPtr<Networking::Mut0>, unitVar: ()) {
        let v2_1: i64 = (v0_1.l0.get().clone()) + 1_i64;
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
    pub fn method20(v0_1: string) {
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
        ) = Networking::TraceState::trace_state().get().clone().unwrap();
        let v20: LrcPtr<Networking::Mut3> = patternInput.3.clone();
        let v37: () = {
            Networking::closure8(patternInput.0.clone(), ());
            ()
        };
        let v53: string = if (v20.l0.get().clone()) == string("") {
            v0_1.clone()
        } else {
            if (v0_1.clone()) == string("") {
                v20.l0.get().clone()
            } else {
                append(
                    (append((v20.l0.get().clone()), string("\n"))),
                    (v0_1.clone()),
                )
            }
        };
        let v60: &str = &*v53.clone();
        let v79 = v60.chars();
        let v81 = v79;
        let v83: Vec<char> = v81.collect::<Vec<_>>();
        let v85: Vec<Vec<char>> = v83
            .chunks(15000)
            .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
            .collect::<Vec<_>>();
        let v87: bool = true;
        let _vec_map: Vec<_> = v85
            .into_iter()
            .map(|x| {
                //;
                let v89: Vec<char> = x;
                let v91: std::string::String = String::from_iter(v89);
                let v93: bool = true;
                v91
            })
            .collect::<Vec<_>>();
        let v95: Vec<std::string::String> = _vec_map;
        if if (v0_1.clone()) != string("") {
            (v95.clone().len() as i32) <= 1_i32
        } else {
            false
        } {
            v20.l0.set(v53);
            ()
        } else {
            v20.l0.set(string(""));
            {
                let v112: bool = true;
                v95.into_iter().for_each(|x| {
                    //;
                    let v114: std::string::String = x;
                    let v116: bool = true;
                    near_sdk::log!("{}", v114);
                    let v118: bool = true;
                    let v120: bool = true;
                }); //;
                ()
            }
        }
        ((patternInput.1.clone()).l0.get().clone())(v0_1)
    }
    pub fn closure5(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
        if Networking::method8(Networking::US0::US0_0) {
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
            ) = Networking::TraceState::trace_state().get().clone().unwrap();
            let v25: Option<i64> = patternInput.5.clone();
            let v24: LrcPtr<Networking::Mut4> = patternInput.4.clone();
            let v23: LrcPtr<Networking::Mut3> = patternInput.3.clone();
            let v22: LrcPtr<Networking::Mut2> = patternInput.2.clone();
            let v21: LrcPtr<Networking::Mut1> = patternInput.1.clone();
            let v20: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            Networking::method20(Networking::method17(
                v20.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                Networking::method9(v20, v21, v22, v23, v24, v25),
                Networking::method13(),
                v0_1,
                sprintf!("{:?}", v1_1),
            ))
        };
    }
    pub fn method7(v0_1: string, v1_1: i32) -> Arc<Async<bool>> {
        getZero()
    }
    pub fn method6(v0_1: string, v1_1: i32) -> Arc<Async<bool>> {
        Networking::method7(v0_1, v1_1)
    }
    pub fn closure4(v0_1: string, v1_1: i32) -> Arc<Async<bool>> {
        Networking::method6(v0_1, v1_1)
    }
    pub fn closure3(unitVar: (), v0_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure4(v0_1.clone(), v)
        })
    }
    pub fn closure14(unitVar: (), v0_1: bool) -> Networking::US7 {
        Networking::US7::US7_0(v0_1)
    }
    pub fn method26() -> Func1<bool, Networking::US7> {
        Func1::new(move |v: bool| Networking::closure14((), v))
    }
    pub fn closure15(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US7 {
        Networking::US7::US7_1(v0_1)
    }
    pub fn method27() -> Func1<LrcPtr<Exception>, Networking::US7> {
        Func1::new(move |v: LrcPtr<Exception>| Networking::closure15((), v))
    }
    pub fn method25(
        v0_1: Arc<Async<LrcPtr<Choice_2<bool, LrcPtr<Exception>>>>>,
    ) -> Arc<Async<Networking::US7>> {
        getZero()
    }
    pub fn method28(v0_1: Arc<Async<Networking::US7>>) -> Arc<Async<Networking::US8>> {
        getZero()
    }
    pub fn method31(v0_1: i32) -> string {
        let v2_1: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method15()),
        });
        let v9: () = {
            Networking::closure7(v2_1.clone(), string("{ "), ());
            ()
        };
        let v18_1: () = {
            Networking::closure7(v2_1.clone(), string("timeout"), ());
            ()
        };
        let v27: () = {
            Networking::closure7(v2_1.clone(), string(" = "), ());
            ()
        };
        let v35: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v44: () = {
            Networking::closure7(v2_1.clone(), string(" }"), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn method30(
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
        let v9: string = Networking::method31(v8);
        Networking::method19(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("async.run_with_timeout_async"),
            v9
        ))
    }
    pub fn closure16(v0_1: i32, unitVar: ()) {
        if Networking::method8(Networking::US0::US0_0) {
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
            ) = Networking::TraceState::trace_state().get().clone().unwrap();
            let v24: Option<i64> = patternInput.5.clone();
            let v23: LrcPtr<Networking::Mut4> = patternInput.4.clone();
            let v22: LrcPtr<Networking::Mut3> = patternInput.3.clone();
            let v21: LrcPtr<Networking::Mut2> = patternInput.2.clone();
            let v20: LrcPtr<Networking::Mut1> = patternInput.1.clone();
            let v19_1: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            Networking::method20(Networking::method30(
                v19_1.clone(),
                v20.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                Networking::method9(v19_1, v20, v21, v22, v23, v24),
                Networking::method13(),
                v0_1,
            ))
        };
    }
    pub fn method32() -> string {
        let v6: string = Networking::method14(getCharAt(toLower(string("Critical")), 0_i32));
        let v73: &str = inline_colorization::color_bright_red;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
    }
    pub fn method34(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method15()),
        });
        let v10: () = {
            Networking::closure7(v3.clone(), string("{ "), ());
            ()
        };
        let v19_1: () = {
            Networking::closure7(v3.clone(), string("timeout"), ());
            ()
        };
        let v28: () = {
            Networking::closure7(v3.clone(), string(" = "), ());
            ()
        };
        let v36: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Networking::closure7(v3.clone(), string("; "), ());
            ()
        };
        let v54: () = {
            Networking::closure7(v3.clone(), string("ex"), ());
            ()
        };
        let v62: () = {
            Networking::closure7(v3.clone(), string(" = "), ());
            ()
        };
        let v70: () = {
            Networking::closure7(v3.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            Networking::closure7(v3.clone(), string(" }"), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method33(
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
        let v10: string = Networking::method34(v8, v9);
        Networking::method19(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("async.run_with_timeout_async**"),
            v10
        ))
    }
    pub fn closure17(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
        if Networking::method8(Networking::US0::US0_4) {
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
            ) = Networking::TraceState::trace_state().get().clone().unwrap();
            let v25: Option<i64> = patternInput.5.clone();
            let v24: LrcPtr<Networking::Mut4> = patternInput.4.clone();
            let v23: LrcPtr<Networking::Mut3> = patternInput.3.clone();
            let v22: LrcPtr<Networking::Mut2> = patternInput.2.clone();
            let v21: LrcPtr<Networking::Mut1> = patternInput.1.clone();
            let v20: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            Networking::method20(Networking::method33(
                v20.clone(),
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                Networking::method9(v20, v21, v22, v23, v24, v25),
                Networking::method32(),
                v0_1,
                sprintf!("{:?}", v1_1),
            ))
        };
    }
    pub fn method29(v0_1: i32, v1_1: Arc<Async<Networking::US8>>) -> Arc<Async<Networking::US6>> {
        getZero()
    }
    pub fn method24(v0_1: Arc<Async<bool>>, v1_1: i32) -> Arc<Async<Networking::US6>> {
        getZero()
    }
    pub fn method23(v0_1: i32, v1_1: Arc<Async<bool>>) -> Arc<Async<Networking::US6>> {
        Networking::method24(v1_1, v0_1)
    }
    pub fn method22(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        getZero()
    }
    pub fn method21(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        Networking::method22(v0_1, v1_1, v2_1)
    }
    pub fn closure13(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        Networking::method21(v0_1, v1_1, v2_1)
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
    pub fn closure22(unitVar: (), v0_1: i32) -> Networking::US9 {
        Networking::US9::US9_0(v0_1)
    }
    pub fn method38() -> Func1<i32, Networking::US9> {
        Func1::new(move |v: i32| Networking::closure22((), v))
    }
    pub fn method40(v0_1: i32, v1_1: i64, v2_1: Option<i32>, v3: bool) -> string {
        let v5: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method15()),
        });
        let v12: () = {
            Networking::closure7(v5.clone(), string("{ "), ());
            ()
        };
        let v21: () = {
            Networking::closure7(v5.clone(), string("port"), ());
            ()
        };
        let v30: () = {
            Networking::closure7(v5.clone(), string(" = "), ());
            ()
        };
        let v38: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v47: () = {
            Networking::closure7(v5.clone(), string("; "), ());
            ()
        };
        let v56: () = {
            Networking::closure7(v5.clone(), string("retry"), ());
            ()
        };
        let v64: () = {
            Networking::closure7(v5.clone(), string(" = "), ());
            ()
        };
        let v72: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v80: () = {
            Networking::closure7(v5.clone(), string("; "), ());
            ()
        };
        let v89: () = {
            Networking::closure7(v5.clone(), string("timeout"), ());
            ()
        };
        let v97: () = {
            Networking::closure7(v5.clone(), string(" = "), ());
            ()
        };
        let v110: std::string::String = format!("{:#?}", v2_1);
        let v135: () = {
            Networking::closure7(
                v5.clone(),
                fable_library_rust::String_::fromString(v110),
                (),
            );
            ()
        };
        let v143: () = {
            Networking::closure7(v5.clone(), string("; "), ());
            ()
        };
        let v152: () = {
            Networking::closure7(v5.clone(), string("status"), ());
            ()
        };
        let v160: () = {
            Networking::closure7(v5.clone(), string(" = "), ());
            ()
        };
        let v171: () = {
            Networking::closure7(
                v5.clone(),
                if v3 { string("true") } else { string("false") },
                (),
            );
            ()
        };
        let v180: () = {
            Networking::closure7(v5.clone(), string(" }"), ());
            ()
        };
        v5.l0.get().clone()
    }
    pub fn method39(
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
        let v12: string = Networking::method40(v8, v9, v10, v11);
        Networking::method19(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("networking.wait_for_port_access"),
            v12
        ))
    }
    pub fn closure23(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3: i64, unitVar: ()) {
        if Networking::method8(Networking::US0::US0_0) {
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
            ) = Networking::TraceState::trace_state().get().clone().unwrap();
            let v27: Option<i64> = patternInput.5.clone();
            let v26: LrcPtr<Networking::Mut4> = patternInput.4.clone();
            let v25: LrcPtr<Networking::Mut3> = patternInput.3.clone();
            let v24: LrcPtr<Networking::Mut2> = patternInput.2.clone();
            let v23: LrcPtr<Networking::Mut1> = patternInput.1.clone();
            let v22: LrcPtr<Networking::Mut0> = patternInput.0.clone();
            Networking::method20(Networking::method39(
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                v26.clone(),
                v27.clone(),
                Networking::method9(v22, v23, v24, v25, v26, v27),
                Networking::method13(),
                v2_1,
                v3,
                v0_1,
                v1_1,
            ))
        };
    }
    pub fn method37(
        v0_1: Option<i32>,
        v1_1: bool,
        v2_1: string,
        v3: i32,
        v4: i64,
    ) -> Arc<Async<i64>> {
        getZero()
    }
    pub fn method36(
        v0_1: Option<i32>,
        v1_1: bool,
        v2_1: string,
        v3: i32,
        v4: i64,
    ) -> Arc<Async<i64>> {
        Networking::method37(v0_1, v1_1, v2_1, v3, v4)
    }
    pub fn method35(v0_1: Option<i32>, v1_1: bool, v2_1: string, v3: i32) -> Arc<Async<i64>> {
        Networking::method36(v0_1, v1_1, v2_1, v3, 1_i64)
    }
    pub fn closure21(v0_1: Option<i32>, v1_1: bool, v2_1: string, v3: i32) -> Arc<Async<i64>> {
        Networking::method35(v0_1, v1_1, v2_1, v3)
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
    pub fn method43(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        getZero()
    }
    pub fn method42(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method43(v0_1, v1_1, v2_1)
    }
    pub fn method41(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method42(v0_1, v1_1, v2_1)
    }
    pub fn closure26(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method41(v0_1, v1_1, v2_1)
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
