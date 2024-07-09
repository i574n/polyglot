pub mod Crypto {
    use super::*;
    use fable_library_rust::Convert_::toInt32_radix;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::Native_::defaultOf;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    pub trait ICryptoCreateHash {
        fn createHash(&self, x: string) -> LrcPtr<dyn Any>;
    }
    impl<V: ICryptoCreateHash + Clone + 'static> ICryptoCreateHash for LrcPtr<V> {
        #[inline]
        fn createHash(&self, x: string) -> LrcPtr<dyn Any> {
            (**self).createHash(x)
        }
    }
    pub trait IHashlibSha256 {
        fn sha256(&self) -> LrcPtr<dyn Any>;
    }
    impl<V: IHashlibSha256 + Clone + 'static> IHashlibSha256 for LrcPtr<V> {
        #[inline]
        fn sha256(&self) -> LrcPtr<dyn Any> {
            (**self).sha256()
        }
    }
    pub mod State {
        use super::*;
        pub fn trace_state() -> LrcPtr<
            MutCell<
                Option<(
                    LrcPtr<Crypto::Mut1>,
                    LrcPtr<Crypto::Mut2>,
                    LrcPtr<Crypto::Mut3>,
                    LrcPtr<Crypto::Mut4>,
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut0 {
        pub l0: MutCell<i32>,
    }
    impl core::fmt::Display for Crypto::Mut0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
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
    impl core::fmt::Display for Crypto::US0 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut1 {
        pub l0: MutCell<i64>,
    }
    impl core::fmt::Display for Crypto::Mut1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug)]
    pub struct Mut2 {
        pub l0: MutCell<Func1<string, ()>>,
    }
    impl core::fmt::Display for Crypto::Mut2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<bool>,
    }
    impl core::fmt::Display for Crypto::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<Crypto::US0>,
    }
    impl core::fmt::Display for Crypto::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(Crypto::US0),
        US1_1,
    }
    impl core::fmt::Display for Crypto::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(i64),
        US2_1,
    }
    impl core::fmt::Display for Crypto::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(string),
        US3_1,
    }
    impl core::fmt::Display for Crypto::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut5 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Crypto::Mut5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method1(v0: i32, v1: LrcPtr<Crypto::Mut0>) -> bool {
        v1.l0.get().clone() < v0
    }
    pub fn method2() -> string {
        string("")
    }
    pub fn method0(v0: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        {
            let x: string = unbox::<string>(&defaultOf());
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn closure0(unitVar: (), v0: string) -> string {
        Crypto::method0(v0)
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> string {
        string("crypto.hash_to_port")
    }
    pub fn closure3(v0: i32, v1: string, v2: u16, unitVar: ()) -> (i32, string, u16) {
        (v0, v1, v2)
    }
    pub fn method4() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method6() -> string {
        string("")
    }
    pub fn method5(v0: string) -> string {
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
        let v46: string = Crypto::method6();
        {
            let x: string = v45.unwrap_or(v46);
            _v3.set(Some(x))
        }
        match &_v3.get().clone() {
            None => panic!("{}", string("base.run_target / _v3=None"),),
            Some(_v3_0_0) => _v3_0_0.clone(),
        }
    }
    pub fn method7() -> string {
        string("AUTOMATION")
    }
    pub fn closure6(unitVar: (), v0: string) {
        ();
    }
    pub fn closure5(
        unitVar: (),
        v0: Crypto::US0,
    ) -> (
        LrcPtr<Crypto::Mut1>,
        LrcPtr<Crypto::Mut2>,
        LrcPtr<Crypto::Mut3>,
        LrcPtr<Crypto::Mut4>,
        Option<i64>,
    ) {
        let _v3: MutCell<Option<(Crypto::US1, Crypto::US2)>> =
            MutCell::new(None::<(Crypto::US1, Crypto::US2)>);
        _v3.set(Some((Crypto::US1::US1_1, Crypto::US2::US2_1)));
        {
            let patternInput: (Crypto::US1, Crypto::US2) = match &_v3.get().clone() {
                None => panic!("{}", string("base.run_target / _v3=None"),),
                Some(_v3_0_0) => _v3_0_0.clone(),
            };
            let v325: Crypto::US2 = patternInput.1.clone();
            let v324: Crypto::US1 = patternInput.0.clone();
            (
                LrcPtr::new(Crypto::Mut1 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Crypto::Mut2 {
                    l0: MutCell::new(Func1::new(move |v: string| Crypto::closure6((), v))),
                }),
                LrcPtr::new(Crypto::Mut3 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Crypto::Mut4 {
                    l0: MutCell::new(match &v324 {
                        Crypto::US1::US1_0(v324_0_0) => match &v324 {
                            Crypto::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0,
                    }),
                }),
                match &v325 {
                    Crypto::US2::US2_0(v325_0_0) => Some(match &v325 {
                        Crypto::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
    }
    pub fn method8() -> string {
        string("hh:mm:ss")
    }
    pub fn method9() -> string {
        string("")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn method11() -> string {
        string("\u{001b}[0m")
    }
    pub fn method13(v0: LrcPtr<Crypto::Mut5>, v1: string) {
        let v4: string = sprintf!("{}", v1);
        let v12: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12);
        ()
    }
    pub fn method14(v0: LrcPtr<Crypto::Mut5>) {
        ();
    }
    pub fn method15(v0: LrcPtr<Crypto::Mut5>, v1: i32) {
        let v4: string = sprintf!("{}", v1);
        let v12: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12);
        ()
    }
    pub fn method16(v0: LrcPtr<Crypto::Mut5>, v1: u16) {
        let v4: string = sprintf!("{}", v1);
        let v12: string = append(v0.l0.get().clone(), v4);
        v0.l0.set(v12);
        ()
    }
    pub fn method12(v0: LrcPtr<Crypto::Mut5>, v1: i32, v2: string, v3: u16) {
        Crypto::method13(v0.clone(), string("{ "));
        Crypto::method14(v0.clone());
        Crypto::method13(v0.clone(), string("first_letter_code"));
        Crypto::method13(v0.clone(), string(" = "));
        Crypto::method15(v0.clone(), v1);
        Crypto::method13(v0.clone(), string("; "));
        Crypto::method13(v0.clone(), string("hash_part"));
        Crypto::method13(v0.clone(), string(" = "));
        Crypto::method13(v0.clone(), v2);
        Crypto::method13(v0.clone(), string("; "));
        Crypto::method13(v0.clone(), string("combined_value"));
        Crypto::method13(v0.clone(), string(" = "));
        Crypto::method16(v0.clone(), v3);
        Crypto::method13(v0, string(" }"))
    }
    pub fn closure4(
        v0: Crypto::US0,
        v1: Func0<string>,
        v2: Func0<(i32, string, u16)>,
        unitVar: (),
    ) -> string {
        if Crypto::State::trace_state().get().clone().is_none() {
            Crypto::State::trace_state().set(Some(Crypto::closure5((), Crypto::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Crypto::Mut1>,
                LrcPtr<Crypto::Mut2>,
                LrcPtr<Crypto::Mut3>,
                LrcPtr<Crypto::Mut4>,
                Option<i64>,
            ) = getValue(Crypto::State::trace_state().get().clone());
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            {
                let x: string = Crypto::method9();
                _v35.set(Some(x))
            }
            {
                let v772: string = match &_v35.get().clone() {
                    None => panic!("{}", string("base.run_target / _v35=None"),),
                    Some(_v35_0_0) => _v35_0_0.clone(),
                };
                let v931: Crypto::US3 = if if let Crypto::US0::US0_0 = &v0 {
                    true
                } else {
                    false
                } {
                    Crypto::US3::US3_0(string("Verbose"))
                } else {
                    Crypto::US3::US3_1
                };
                let v980: Crypto::US3 = match &v931 {
                    Crypto::US3::US3_0(v931_0_0) => Crypto::US3::US3_0(match &v931 {
                        Crypto::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v940: Crypto::US3 = if if let Crypto::US0::US0_1 = &v0 {
                            true
                        } else {
                            false
                        } {
                            Crypto::US3::US3_0(string("Debug"))
                        } else {
                            Crypto::US3::US3_1
                        };
                        match &v940 {
                            Crypto::US3::US3_0(v940_0_0) => Crypto::US3::US3_0(match &v940 {
                                Crypto::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v949: Crypto::US3 = if if let Crypto::US0::US0_2 = &v0 {
                                    true
                                } else {
                                    false
                                } {
                                    Crypto::US3::US3_0(string("Info"))
                                } else {
                                    Crypto::US3::US3_1
                                };
                                match &v949 {
                                    Crypto::US3::US3_0(v949_0_0) => {
                                        Crypto::US3::US3_0(match &v949 {
                                            Crypto::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v958: Crypto::US3 = if if let Crypto::US0::US0_3 = &v0 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Crypto::US3::US3_0(string("Warning"))
                                        } else {
                                            Crypto::US3::US3_1
                                        };
                                        match &v958 {
                                            Crypto::US3::US3_0(v958_0_0) => {
                                                Crypto::US3::US3_0(match &v958 {
                                                    Crypto::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v967: Crypto::US3 =
                                                    if if let Crypto::US0::US0_4 = &v0 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Crypto::US3::US3_0(string("Critical"))
                                                    } else {
                                                        Crypto::US3::US3_1
                                                    };
                                                match &v967 {
                                                    Crypto::US3::US3_0(v967_0_0) => {
                                                        Crypto::US3::US3_0(match &v967 {
                                                            Crypto::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => Crypto::US3::US3_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v997: string = padLeft(
                    toLower(match &v980 {
                        Crypto::US3::US3_0(v980_0_0) => match &v980 {
                            Crypto::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let _v1029: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v1092: &str = match &v0 {
                    Crypto::US0::US0_1 => inline_colorization::color_bright_blue,
                    Crypto::US0::US0_2 => inline_colorization::color_bright_green,
                    Crypto::US0::US0_0 => inline_colorization::color_bright_black,
                    Crypto::US0::US0_3 => inline_colorization::color_yellow,
                    _ => inline_colorization::color_bright_red,
                };
                let v1094: &str = &*v997;
                let v1096: &str = inline_colorization::color_reset;
                let v1098: string = string("format!(\"{v1092}{v1094}{v1096}\")");
                let v1099: std::string::String = format!("{v1092}{v1094}{v1096}");
                {
                    let x_2: string = fable_library_rust::String_::fromString(v1099);
                    _v1029.set(Some(x_2))
                }
                {
                    let v1141: string = match &_v1029.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1029=None"),),
                        Some(_v1029_0_0) => _v1029_0_0.clone(),
                    };
                    let v1160: i64 = (patternInput.0.clone()).l0.get().clone();
                    let patternInput_1: (i32, string, u16) = v2();
                    let v1165: LrcPtr<Crypto::Mut5> = LrcPtr::new(Crypto::Mut5 {
                        l0: MutCell::new(string("")),
                    });
                    Crypto::method12(
                        v1165.clone(),
                        patternInput_1.0.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                    );
                    {
                        let v1166: string = v1165.l0.get().clone();
                        trimEndChars(
                            trimStartChars(
                                sprintf!("{} {} #{} {} / {}", v772, v1141, v1160, v1(), v1166),
                                toArray(empty::<char>()),
                            ),
                            toArray(ofArray(new_array(&[' ', '/']))),
                        )
                    }
                }
            }
        }
    }
    pub fn method17(v0: Crypto::US0, v1: Func0<string>) {
        fn v4(
            v: Crypto::US0,
        ) -> (
            LrcPtr<Crypto::Mut1>,
            LrcPtr<Crypto::Mut2>,
            LrcPtr<Crypto::Mut3>,
            LrcPtr<Crypto::Mut4>,
            Option<i64>,
        ) {
            Crypto::closure5((), v)
        }
        if Crypto::State::trace_state().get().clone().is_none() {
            Crypto::State::trace_state().set(Some(v4(Crypto::US0::US0_0)));
        }
        {
            let patternInput: (
                LrcPtr<Crypto::Mut1>,
                LrcPtr<Crypto::Mut2>,
                LrcPtr<Crypto::Mut3>,
                LrcPtr<Crypto::Mut4>,
                Option<i64>,
            ) = getValue(Crypto::State::trace_state().get().clone());
            let v13: LrcPtr<Crypto::Mut1> = patternInput.0.clone();
            if Crypto::State::trace_state().get().clone().is_none() {
                Crypto::State::trace_state().set(Some(v4(Crypto::US0::US0_0)));
            }
            {
                let patternInput_1: (
                    LrcPtr<Crypto::Mut1>,
                    LrcPtr<Crypto::Mut2>,
                    LrcPtr<Crypto::Mut3>,
                    LrcPtr<Crypto::Mut4>,
                    Option<i64>,
                ) = getValue(Crypto::State::trace_state().get().clone());
                let v61: Crypto::US0 = (patternInput_1.3.clone()).l0.get().clone();
                if if (patternInput_1.2.clone()).l0.get().clone() == false {
                    false
                } else {
                    find(
                        v0,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Crypto::US0::US0_0, 0_i32)),
                            LrcPtr::new((Crypto::US0::US0_1, 1_i32)),
                            LrcPtr::new((Crypto::US0::US0_2, 2_i32)),
                            LrcPtr::new((Crypto::US0::US0_3, 3_i32)),
                            LrcPtr::new((Crypto::US0::US0_4, 4_i32)),
                        ])))),
                    ) >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Crypto::US0::US0_0, 0_i32)),
                            LrcPtr::new((Crypto::US0::US0_1, 1_i32)),
                            LrcPtr::new((Crypto::US0::US0_2, 2_i32)),
                            LrcPtr::new((Crypto::US0::US0_3, 3_i32)),
                            LrcPtr::new((Crypto::US0::US0_4, 4_i32)),
                        ])))),
                    )
                } {
                    let v69: i64 = v13.l0.get().clone() + 1_i64;
                    v13.l0.set(v69);
                    {
                        let v72: string = sprintf!("{}", v1());
                        let _v81: MutCell<Option<()>> = MutCell::new(None::<()>);
                        println!("{}", v72.clone());
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
    pub fn method3(v0: Crypto::US0, v1: Func0<string>, v2: Func0<(i32, string, u16)>) {
        Crypto::method17(
            v0.clone(),
            Func0::new({
                let v0 = v0.clone();
                let v1 = v1.clone();
                let v2 = v2.clone();
                move || Crypto::closure4(v0.clone(), v1.clone(), v2.clone(), ())
            }),
        );
    }
    pub fn closure1(unitVar: (), v0: string) -> u16 {
        let v3: i32 = getCharAt(v0.clone(), 0_i32) as u32 as i32;
        let v4: string = getSlice(v0, Some(0_i32), Some(7_i32));
        let v8: u16 = (toInt32_radix(v4.clone(), 16_i32) + v3) as u16;
        Crypto::method3(
            Crypto::US0::US0_0,
            Func0::new(move || Crypto::closure2((), ())),
            Func0::new({
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v8 = v8.clone();
                move || Crypto::closure3(v3, v4.clone(), v8, ())
            }),
        );
        v8 % 48128_u16 + 1024_u16
    }
    pub fn v234() -> Func1<string, string> {
        static v234: OnceInit<Func1<string, string>> = OnceInit::new();
        v234.get_or_init(|| Func1::new(move |v: string| Crypto::closure0((), v)))
            .clone()
    }
    pub fn hash_text(x: string) -> string {
        (Crypto::v234())(x)
    }
    pub fn v235() -> Func1<string, u16> {
        static v235: OnceInit<Func1<string, u16>> = OnceInit::new();
        v235.get_or_init(|| Func1::new(move |v: string| Crypto::closure1((), v)))
            .clone()
    }
    pub fn hash_to_port(x: string) -> u16 {
        (Crypto::v235())(x)
    }
    on_startup!(());
}
