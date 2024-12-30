pub mod Crypto {
    use super::*;
    use fable_library_rust::Convert_::toInt32_radix;
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
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::map;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::printfn;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::System::Collections::Generic::IEnumerable_1;
    pub trait ICryptoCreateHash: core::fmt::Debug + core::fmt::Display {
        fn createHash(&self, x: string) -> LrcPtr<dyn Any>;
    }
    impl<V: ICryptoCreateHash + core::fmt::Debug + core::fmt::Display> ICryptoCreateHash for LrcPtr<V> {
        #[inline]
        fn createHash(&self, x: string) -> LrcPtr<dyn Any> {
            (**self).createHash(x)
        }
    }
    pub trait IHashlibSha256: core::fmt::Debug + core::fmt::Display {
        fn sha256(&self) -> LrcPtr<dyn Any>;
    }
    impl<V: IHashlibSha256 + core::fmt::Debug + core::fmt::Display> IHashlibSha256 for LrcPtr<V> {
        #[inline]
        fn sha256(&self) -> LrcPtr<dyn Any> {
            (**self).sha256()
        }
    }
    pub mod TraceState {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Crypto::Mut1>,
                    LrcPtr<Crypto::Mut2>,
                    LrcPtr<Crypto::Mut3>,
                    LrcPtr<Crypto::Mut4>,
                    LrcPtr<Crypto::Mut5>,
                    Option<i64>,
                )>,
            >,
        > {
            static trace_state: OnceInit<
                LrcPtr<
                    MutCell<
                        Option<(
                            LrcPtr<Crypto::Mut1>,
                            LrcPtr<Crypto::Mut2>,
                            LrcPtr<Crypto::Mut3>,
                            LrcPtr<Crypto::Mut4>,
                            LrcPtr<Crypto::Mut5>,
                            Option<i64>,
                        )>,
                    >,
                >,
            > = OnceInit::new();
            trace_state
                .get_or_init(|| {
                    LrcPtr::new(MutCell::new(
                        None::<(
                            LrcPtr<Crypto::Mut1>,
                            LrcPtr<Crypto::Mut2>,
                            LrcPtr<Crypto::Mut3>,
                            LrcPtr<Crypto::Mut4>,
                            LrcPtr<Crypto::Mut5>,
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
    pub struct Mut0 {
        pub l0: MutCell<i32>,
    }
    impl core::fmt::Display for Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
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
    pub struct Mut1 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut2 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub struct Mut3 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub struct Mut5 {
        pub l0: MutCell<Crypto::US0>,
    }
    impl core::fmt::Display for Mut5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
    pub enum US1 {
        US1_0(Crypto::US0),
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
        US4_0(Crypto::US3),
        US4_1(Crypto::US3),
        US4_2(Crypto::US3),
        US4_3(Crypto::US3),
        US4_4(Crypto::US3),
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
    pub fn method1() -> string {
        string("")
    }
    pub fn method2(v0_1: string) -> string {
        v0_1
    }
    pub fn method3(v0_1: i32, v1_1: LrcPtr<Crypto::Mut0>) -> bool {
        (v1_1.l0.get().clone()) < (v0_1)
    }
    pub fn method4() -> string {
        string("")
    }
    pub fn method0(v0_1: string) -> string {
        unbox::<string>(&getZero())
    }
    pub fn closure0(unitVar: (), v0_1: string) -> string {
        Crypto::method0(v0_1)
    }
    pub fn method9(v0_1: string) -> string {
        v0_1
    }
    pub fn method10() -> string {
        string("")
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Crypto::US5 {
        Crypto::US5::US5_0(v0_1)
    }
    pub fn method11() -> Func1<string, Crypto::US5> {
        Func1::new(move |v: string| Crypto::closure4((), v))
    }
    pub fn method8(v0_1: string) -> string {
        panic!(
            "{}",
            sprintf!(
                "env.get_environment_variable / target: {} / var: {}",
                Crypto::US4::US4_2(Crypto::US3::US3_2),
                v0_1
            ),
        )
    }
    pub fn method7() -> (Crypto::US1, Crypto::US2) {
        let v1_1: string = Crypto::method8(string("TRACE_LEVEL"));
        let v6: Crypto::US1 = if string("Verbose") == (v1_1.clone()) {
            Crypto::US1::US1_0(Crypto::US0::US0_0)
        } else {
            Crypto::US1::US1_1
        };
        (
            match &v6 {
                Crypto::US1::US1_0(v6_0_0) => Crypto::US1::US1_0(
                    match &v6 {
                        Crypto::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => {
                    let v13: Crypto::US1 = if string("Debug") == (v1_1.clone()) {
                        Crypto::US1::US1_0(Crypto::US0::US0_1)
                    } else {
                        Crypto::US1::US1_1
                    };
                    match &v13 {
                        Crypto::US1::US1_0(v13_0_0) => Crypto::US1::US1_0(
                            match &v13 {
                                Crypto::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        ),
                        _ => {
                            let v20: Crypto::US1 = if string("Info") == (v1_1.clone()) {
                                Crypto::US1::US1_0(Crypto::US0::US0_2)
                            } else {
                                Crypto::US1::US1_1
                            };
                            match &v20 {
                                Crypto::US1::US1_0(v20_0_0) => Crypto::US1::US1_0(
                                    match &v20 {
                                        Crypto::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ),
                                _ => {
                                    let v27: Crypto::US1 = if string("Warning") == (v1_1.clone()) {
                                        Crypto::US1::US1_0(Crypto::US0::US0_3)
                                    } else {
                                        Crypto::US1::US1_1
                                    };
                                    match &v27 {
                                        Crypto::US1::US1_0(v27_0_0) => Crypto::US1::US1_0(
                                            match &v27 {
                                                Crypto::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        ),
                                        _ => {
                                            let v34: Crypto::US1 =
                                                if string("Critical") == (v1_1.clone()) {
                                                    Crypto::US1::US1_0(Crypto::US0::US0_4)
                                                } else {
                                                    Crypto::US1::US1_1
                                                };
                                            match &v34 {
                                                Crypto::US1::US1_0(v34_0_0) => Crypto::US1::US1_0(
                                                    match &v34 {
                                                        Crypto::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                ),
                                                _ => Crypto::US1::US1_1,
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            },
            if (Crypto::method8(string("AUTOMATION"))) != string("True") {
                Crypto::US2::US2_1
            } else {
                let v58: DateTime = unbox::<DateTime>(&getZero());
                Crypto::US2::US2_0(unbox::<i64>(&getZero()))
            },
        )
    }
    pub fn closure5(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method6(
        v0_1: Crypto::US0,
    ) -> (
        LrcPtr<Crypto::Mut1>,
        LrcPtr<Crypto::Mut2>,
        LrcPtr<Crypto::Mut3>,
        LrcPtr<Crypto::Mut4>,
        LrcPtr<Crypto::Mut5>,
        Option<i64>,
    ) {
        let v64: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
        let v65: &str = option_env!("AUTOMATION").unwrap_or("");
        let v72: std::string::String = String::from(v65);
        let _run_target_args__v1: (Crypto::US1, Crypto::US2) = (
            Crypto::US1::US1_1,
            if (fable_library_rust::String_::fromString(v72)) != string("True") {
                Crypto::US2::US2_1
            } else {
                Crypto::US2::US2_0(near_sdk::env::block_timestamp() as i64)
            },
        );
        let v132: Crypto::US2 = _run_target_args__v1.1.clone();
        let v131: Crypto::US1 = _run_target_args__v1.0.clone();
        (
            LrcPtr::new(Crypto::Mut1 {
                l0: MutCell::new(1_i64),
            }),
            LrcPtr::new(Crypto::Mut2 {
                l0: MutCell::new(Func1::new(move |v: string| Crypto::closure5((), v))),
            }),
            LrcPtr::new(Crypto::Mut3 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Crypto::Mut4 {
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Crypto::Mut5 {
                l0: MutCell::new(match &v131 {
                    Crypto::US1::US1_0(v131_0_0) => match &v131 {
                        Crypto::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    _ => v0_1.clone(),
                }),
            }),
            match &v132 {
                Crypto::US2::US2_0(v132_0_0) => Some(match &v132 {
                    Crypto::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<i64>,
            },
        )
    }
    pub fn closure3(unitVar: (), unitVar_1: ()) {
        if Crypto::TraceState::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Crypto::Mut1>,
                LrcPtr<Crypto::Mut2>,
                LrcPtr<Crypto::Mut3>,
                LrcPtr<Crypto::Mut4>,
                LrcPtr<Crypto::Mut5>,
                Option<i64>,
            ) = Crypto::method6(Crypto::US0::US0_0);
            Crypto::TraceState::trace_state().set(Some((
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
    pub fn method5(v0_1: Crypto::US0) -> bool {
        let v3: () = {
            Crypto::closure3((), ());
            ()
        };
        let patternInput: (
            LrcPtr<Crypto::Mut1>,
            LrcPtr<Crypto::Mut2>,
            LrcPtr<Crypto::Mut3>,
            LrcPtr<Crypto::Mut4>,
            LrcPtr<Crypto::Mut5>,
            Option<i64>,
        ) = Crypto::TraceState::trace_state().get().clone().unwrap();
        let v35: Crypto::US0 = (patternInput.4.clone()).l0.get().clone();
        if ((patternInput.2.clone()).l0.get().clone()) == false {
            false
        } else {
            (find(
                v0_1,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Crypto::US0::US0_0, 0_i32)),
                    LrcPtr::new((Crypto::US0::US0_1, 1_i32)),
                    LrcPtr::new((Crypto::US0::US0_2, 2_i32)),
                    LrcPtr::new((Crypto::US0::US0_3, 3_i32)),
                    LrcPtr::new((Crypto::US0::US0_4, 4_i32)),
                ])))),
            )) >= (find(
                v35,
                ofSeq(ofList(ofArray(new_array(&[
                    LrcPtr::new((Crypto::US0::US0_0, 0_i32)),
                    LrcPtr::new((Crypto::US0::US0_1, 1_i32)),
                    LrcPtr::new((Crypto::US0::US0_2, 2_i32)),
                    LrcPtr::new((Crypto::US0::US0_3, 3_i32)),
                    LrcPtr::new((Crypto::US0::US0_4, 4_i32)),
                ])))),
            ))
        }
    }
    pub fn closure6(unitVar: (), v0_1: i64) -> Crypto::US2 {
        Crypto::US2::US2_0(v0_1)
    }
    pub fn method13() -> Func1<i64, Crypto::US2> {
        Func1::new(move |v: i64| Crypto::closure6((), v))
    }
    pub fn method14() -> string {
        string("hh:mm:ss")
    }
    pub fn method15() -> string {
        string("HH:mm:ss")
    }
    pub fn method12(
        v0_1: LrcPtr<Crypto::Mut1>,
        v1_1: LrcPtr<Crypto::Mut2>,
        v2: LrcPtr<Crypto::Mut3>,
        v3: LrcPtr<Crypto::Mut4>,
        v4: LrcPtr<Crypto::Mut5>,
        v5: Option<i64>,
    ) -> string {
        let v272: u64 = near_sdk::env::block_timestamp();
        let v286: Crypto::US2 = defaultValue(Crypto::US2::US2_1, map(Crypto::method13(), v5));
        let v298: u64 = (match &v286 {
            Crypto::US2::US2_0(v286_0_0) => {
                (v272)
                    - (match &v286 {
                        Crypto::US2::US2_0(x) => x.clone(),
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
    pub fn method18() -> string {
        string("")
    }
    pub fn closure7(v0_1: LrcPtr<Crypto::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append((v0_1.l0.get().clone()), (v1_1));
        v0_1.l0.set(v3);
        ()
    }
    pub fn method17(v0_1: char) -> string {
        let v2: LrcPtr<Crypto::Mut4> = LrcPtr::new(Crypto::Mut4 {
            l0: MutCell::new(Crypto::method18()),
        });
        let v8: () = {
            Crypto::closure7(v2.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        v2.l0.get().clone()
    }
    pub fn method19() -> string {
        string("\u{001b}[0m")
    }
    pub fn method16() -> string {
        let v6: string = Crypto::method17(getCharAt(toLower(string("Verbose")), 0_i32));
        let v73: &str = inline_colorization::color_bright_black;
        let v80: &str = &*v6;
        let v99: &str = inline_colorization::color_reset;
        let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
        fable_library_rust::String_::fromString(v101)
    }
    pub fn method21(v0_1: i32, v1_1: string, v2: u16) -> string {
        let v4: LrcPtr<Crypto::Mut4> = LrcPtr::new(Crypto::Mut4 {
            l0: MutCell::new(Crypto::method18()),
        });
        let v11: () = {
            Crypto::closure7(v4.clone(), string("{ "), ());
            ()
        };
        let v20: () = {
            Crypto::closure7(v4.clone(), string("first_letter_code"), ());
            ()
        };
        let v29: () = {
            Crypto::closure7(v4.clone(), string(" = "), ());
            ()
        };
        let v37: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v46: () = {
            Crypto::closure7(v4.clone(), string("; "), ());
            ()
        };
        let v55: () = {
            Crypto::closure7(v4.clone(), string("hash_part"), ());
            ()
        };
        let v63: () = {
            Crypto::closure7(v4.clone(), string(" = "), ());
            ()
        };
        let v71: () = {
            Crypto::closure7(v4.clone(), v1_1, ());
            ()
        };
        let v79: () = {
            Crypto::closure7(v4.clone(), string("; "), ());
            ()
        };
        let v88: () = {
            Crypto::closure7(v4.clone(), string("combined_value"), ());
            ()
        };
        let v96: () = {
            Crypto::closure7(v4.clone(), string(" = "), ());
            ()
        };
        let v104: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", v2), ());
            ()
        };
        let v113: () = {
            Crypto::closure7(v4.clone(), string(" }"), ());
            ()
        };
        v4.l0.get().clone()
    }
    pub fn method22(v0_1: string) -> string {
        trimEndChars(
            trimStartChars(v0_1, toArray(empty::<char>())),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn method20(
        v0_1: LrcPtr<Crypto::Mut1>,
        v1_1: LrcPtr<Crypto::Mut2>,
        v2: LrcPtr<Crypto::Mut3>,
        v3: LrcPtr<Crypto::Mut4>,
        v4: LrcPtr<Crypto::Mut5>,
        v5: Option<i64>,
        v6: string,
        v7: string,
        v8: i32,
        v9: string,
        v10: u16,
    ) -> string {
        let v11: string = Crypto::method21(v8, v9, v10);
        Crypto::method22(sprintf!(
            "{} {} #{} {} / {}",
            v6,
            v7,
            v0_1.l0.get().clone(),
            string("crypto.hash_to_port"),
            v11
        ))
    }
    pub fn closure8(v0_1: LrcPtr<Crypto::Mut1>, unitVar: ()) {
        let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
        v0_1.l0.set(v2);
        ()
    }
    pub fn closure10(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure9(unitVar: (), v0_1: string) {
        let v3: () = {
            Crypto::closure10(v0_1, ());
            ()
        };
        ()
    }
    pub fn method23(v0_1: string) {
        let v3: () = {
            Crypto::closure3((), ());
            ()
        };
        let patternInput: (
            LrcPtr<Crypto::Mut1>,
            LrcPtr<Crypto::Mut2>,
            LrcPtr<Crypto::Mut3>,
            LrcPtr<Crypto::Mut4>,
            LrcPtr<Crypto::Mut5>,
            Option<i64>,
        ) = Crypto::TraceState::trace_state().get().clone().unwrap();
        let v20: LrcPtr<Crypto::Mut4> = patternInput.3.clone();
        let v37: () = {
            Crypto::closure8(patternInput.0.clone(), ());
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
    pub fn closure2(v0_1: i32, v1_1: string, v2: u16, unitVar: ()) {
        if Crypto::method5(Crypto::US0::US0_0) {
            let v7: () = {
                Crypto::closure3((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Crypto::Mut1>,
                LrcPtr<Crypto::Mut2>,
                LrcPtr<Crypto::Mut3>,
                LrcPtr<Crypto::Mut4>,
                LrcPtr<Crypto::Mut5>,
                Option<i64>,
            ) = Crypto::TraceState::trace_state().get().clone().unwrap();
            let v26: Option<i64> = patternInput.5.clone();
            let v25: LrcPtr<Crypto::Mut5> = patternInput.4.clone();
            let v24: LrcPtr<Crypto::Mut4> = patternInput.3.clone();
            let v23: LrcPtr<Crypto::Mut3> = patternInput.2.clone();
            let v22: LrcPtr<Crypto::Mut2> = patternInput.1.clone();
            let v21: LrcPtr<Crypto::Mut1> = patternInput.0.clone();
            Crypto::method23(Crypto::method20(
                v21.clone(),
                v22.clone(),
                v23.clone(),
                v24.clone(),
                v25.clone(),
                v26.clone(),
                Crypto::method12(v21, v22, v23, v24, v25, v26),
                Crypto::method16(),
                v0_1,
                v1_1,
                v2,
            ))
        };
    }
    pub fn closure1(unitVar: (), v0_1: string) -> u16 {
        let v46: i32 = getCharAt(v0_1.clone(), 0_i32) as u32 as i32;
        let v57: string = getSlice(v0_1, Some(0_i32), Some(7_i32));
        let v65: u16 = ((toInt32_radix(v57.clone(), 16_i32)) + (v46)) as u16;
        let v70: () = {
            Crypto::closure2(v46, v57, v65, ());
            ()
        };
        ((v65) % 48128_u16) + 1024_u16
    }
    pub fn v0() -> Func1<string, string> {
        static v0: OnceInit<Func1<string, string>> = OnceInit::new();
        v0.get_or_init(|| Func1::new(move |v: string| Crypto::closure0((), v)))
            .clone()
    }
    pub fn hash_text(x: string) -> string {
        (Crypto::v0())(x)
    }
    pub fn v1() -> Func1<string, u16> {
        static v1: OnceInit<Func1<string, u16>> = OnceInit::new();
        v1.get_or_init(|| Func1::new(move |v: string| Crypto::closure1((), v)))
            .clone()
    }
    pub fn hash_to_port(x: string) -> u16 {
        (Crypto::v1())(x)
    }
    on_startup!(());
}
