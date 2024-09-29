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
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::printfn;
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Crypto::Mut4 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut5 {
        pub l0: MutCell<Crypto::US0>,
    }
    impl core::fmt::Display for Crypto::Mut5 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US1 {
        US1_0(string),
        US1_1,
    }
    impl core::fmt::Display for Crypto::US1 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US2 {
        US2_0(Crypto::US0),
        US2_1,
    }
    impl core::fmt::Display for Crypto::US2 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub enum US3 {
        US3_0(i64),
        US3_1,
    }
    impl core::fmt::Display for Crypto::US3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    pub fn method1() -> string {
        string("")
    }
    pub fn method2(v0_1: i32, v1_1: LrcPtr<Crypto::Mut0>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn method3() -> string {
        string("")
    }
    pub fn method0(v0_1: string) -> string {
        unbox::<string>(&defaultOf())
    }
    pub fn closure0(unitVar: (), v0_1: string) -> string {
        Crypto::method0(v0_1)
    }
    pub fn method5() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method7() -> string {
        string("")
    }
    pub fn closure4(unitVar: (), v0_1: string) -> Crypto::US1 {
        Crypto::US1::US1_0(v0_1)
    }
    pub fn method8() -> Func1<string, Crypto::US1> {
        Func1::new(move |v: string| Crypto::closure4((), v))
    }
    pub fn method6(v0_1: string) -> string {
        let v33: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v35: bool = true;
        let _result_map_ = v33.map(|x| {
            //;
            let v37: std::string::String = x;
            let v39: string = fable_library_rust::String_::fromString(v37);
            let v41: bool = true;
            v39
        });
        let v43: Result<string, std::env::VarError> = _result_map_;
        let v44: string = Crypto::method7();
        v43.unwrap_or(v44)
    }
    pub fn method9() -> string {
        string("AUTOMATION")
    }
    pub fn closure5(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method4(
        v0_1: Crypto::US0,
    ) -> (
        LrcPtr<Crypto::Mut1>,
        LrcPtr<Crypto::Mut2>,
        LrcPtr<Crypto::Mut3>,
        LrcPtr<Crypto::Mut4>,
        LrcPtr<Crypto::Mut5>,
        Option<i64>,
    ) {
        let v117: string = string("env!(\"AUTOMATION\")");
        let v118: &str = env!("AUTOMATION");
        let v125: std::string::String = String::from(v118);
        let _v1: (Crypto::US2, Crypto::US3) = (
            Crypto::US2::US2_1,
            if fable_library_rust::String_::fromString(v125) != string("True") {
                Crypto::US3::US3_1
            } else {
                Crypto::US3::US3_0(near_sdk::env::block_timestamp() as i64)
            },
        );
        let v352: Crypto::US3 = _v1.1.clone();
        let v351: Crypto::US2 = _v1.0.clone();
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
                l0: MutCell::new(match &v351 {
                    Crypto::US2::US2_0(v351_0_0) => match &v351 {
                        Crypto::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v352 {
                Crypto::US3::US3_0(v352_0_0) => Some(match &v352 {
                    Crypto::US3::US3_0(x) => x.clone(),
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
            ) = Crypto::method4(Crypto::US0::US0_0);
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
    pub fn closure6(unitVar: (), v0_1: i64) -> Crypto::US3 {
        Crypto::US3::US3_0(v0_1)
    }
    pub fn method11() -> Func1<i64, Crypto::US3> {
        Func1::new(move |v: i64| Crypto::closure6((), v))
    }
    pub fn method12() -> string {
        string("hh:mm:ss")
    }
    pub fn method13() -> string {
        string("HH:mm:ss")
    }
    pub fn method10(
        v0_1: LrcPtr<Crypto::Mut1>,
        v1_1: LrcPtr<Crypto::Mut2>,
        v2: LrcPtr<Crypto::Mut3>,
        v3: LrcPtr<Crypto::Mut4>,
        v4: LrcPtr<Crypto::Mut5>,
        v5: Option<i64>,
    ) -> string {
        let v130: u64 = near_sdk::env::block_timestamp();
        let v144: Crypto::US3 = defaultValue(Crypto::US3::US3_1, map(Crypto::method11(), v5));
        let v154: u64 = match &v144 {
            Crypto::US3::US3_0(v144_0_0) => {
                v130 - match &v144 {
                    Crypto::US3::US3_0(x) => x.clone(),
                    _ => unreachable!(),
                } as u64
            }
            _ => v130,
        } / 1000000000_u64;
        let v155: u64 = v154 % 60_u64;
        let v157: u64 = v154 / 60_u64 % 60_u64;
        let v159: u64 = v154 / 3600_u64 % 24_u64;
        let v161: std::string::String = format!("{:02}:{:02}:{:02}", v159, v157, v155);
        fable_library_rust::String_::fromString(v161)
    }
    pub fn method15() -> string {
        string("\u{001b}[0m")
    }
    pub fn method14() -> string {
        let v5: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
        let v79: &str = inline_colorization::color_bright_black;
        let v86: &str = &*v5;
        let v102: &str = inline_colorization::color_reset;
        let v104: std::string::String = format!("{}{}{}", v79, v86, v102);
        fable_library_rust::String_::fromString(v104)
    }
    pub fn method17() -> string {
        string("")
    }
    pub fn closure7(v0_1: LrcPtr<Crypto::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method16(v0_1: i32, v1_1: string, v2: u16) -> string {
        let v4: LrcPtr<Crypto::Mut4> = LrcPtr::new(Crypto::Mut4 {
            l0: MutCell::new(Crypto::method17()),
        });
        let v11: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v20: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string("first_letter_code")), ());
            ()
        };
        let v29: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v37: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v46: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v55: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string("hash_part")), ());
            ()
        };
        let v63: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v71: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v88: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string("combined_value")), ());
            ()
        };
        let v96: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v104: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", v2), ());
            ()
        };
        let v113: () = {
            Crypto::closure7(v4.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v4.l0.get().clone()
    }
    pub fn method18(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2,
                    string("crypto.hash_to_port"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure8(v0_1: LrcPtr<Crypto::Mut1>, unitVar: ()) {
        let v2: i64 = v0_1.l0.get().clone() + 1_i64;
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
    pub fn method19(
        v0_1: string,
        v1_1: LrcPtr<Crypto::Mut1>,
        v2: LrcPtr<Crypto::Mut2>,
        v3: LrcPtr<Crypto::Mut3>,
        v4: LrcPtr<Crypto::Mut4>,
        v5: LrcPtr<Crypto::Mut5>,
        v6: Option<i64>,
    ) {
        let v9: () = {
            Crypto::closure8(v1_1, ());
            ()
        };
        let v25: string = if v4.l0.get().clone() == string("") {
            v0_1.clone()
        } else {
            if v0_1.clone() == string("") {
                v4.l0.get().clone()
            } else {
                append(append(v4.l0.get().clone(), string("\n")), v0_1.clone())
            }
        };
        let v32: &str = &*v25.clone();
        let v48 = v32.chars();
        let v50 = v48;
        let v52: Vec<char> = v50.collect::<Vec<_>>();
        let v54: Vec<Vec<char>> = v52
            .chunks(15000)
            .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
            .collect::<Vec<_>>();
        let v56: bool = true;
        let _vec_map: Vec<_> = v54
            .into_iter()
            .map(|x| {
                //;
                let v58: Vec<char> = x;
                let v60: std::string::String = String::from_iter(v58);
                let v62: bool = true;
                v60
            })
            .collect::<Vec<_>>();
        let v64: Vec<std::string::String> = _vec_map;
        if if v0_1.clone() != string("") {
            v64.clone().len() as i32 <= 1_i32
        } else {
            false
        } {
            v4.l0.set(v25);
            ()
        } else {
            v4.l0.set(string(""));
            {
                let v76: bool = true;
                v64.into_iter().for_each(|x| {
                    //;
                    let v78: std::string::String = x;
                    let v80: bool = true;
                    near_sdk::log!("{}", v78);
                    let v82: bool = true;
                    let v84: bool = true;
                }); //;
                ()
            }
        }
        ();
        (v2.l0.get().clone())(v0_1)
    }
    pub fn closure2(v0_1: i32, v1_1: string, v2: u16, unitVar: ()) {
        fn v4() {
            Crypto::closure3((), ());
        }
        let v5: () = {
            v4();
            ()
        };
        let patternInput: (
            LrcPtr<Crypto::Mut1>,
            LrcPtr<Crypto::Mut2>,
            LrcPtr<Crypto::Mut3>,
            LrcPtr<Crypto::Mut4>,
            LrcPtr<Crypto::Mut5>,
            Option<i64>,
        ) = getValue(Crypto::TraceState::trace_state().get().clone());
        let v37: Crypto::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v37,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Crypto::US0::US0_0, 0_i32)),
                        LrcPtr::new((Crypto::US0::US0_1, 1_i32)),
                        LrcPtr::new((Crypto::US0::US0_2, 2_i32)),
                        LrcPtr::new((Crypto::US0::US0_3, 3_i32)),
                        LrcPtr::new((Crypto::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v44: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<Crypto::Mut1>,
                LrcPtr<Crypto::Mut2>,
                LrcPtr<Crypto::Mut3>,
                LrcPtr<Crypto::Mut4>,
                LrcPtr<Crypto::Mut5>,
                Option<i64>,
            ) = getValue(Crypto::TraceState::trace_state().get().clone());
            let v58: LrcPtr<Crypto::Mut1> = patternInput_1.0.clone();
            let v80: string = Crypto::method18(
                Crypto::method10(
                    v58.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                Crypto::method14(),
                v58.l0.get().clone(),
                Crypto::method16(v0_1, v1_1, v2),
            );
            let v82: () = {
                v4();
                ()
            };
            let patternInput_2: (
                LrcPtr<Crypto::Mut1>,
                LrcPtr<Crypto::Mut2>,
                LrcPtr<Crypto::Mut3>,
                LrcPtr<Crypto::Mut4>,
                LrcPtr<Crypto::Mut5>,
                Option<i64>,
            ) = getValue(Crypto::TraceState::trace_state().get().clone());
            Crypto::method19(
                v80,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn closure1(unitVar: (), v0_1: string) -> u16 {
        let v3: i32 = getCharAt(v0_1.clone(), 0_i32) as u32 as i32;
        let v4: string = getSlice(v0_1, Some(0_i32), Some(7_i32));
        let v8: u16 = (toInt32_radix(v4.clone(), 16_i32) + v3) as u16;
        let v11: () = {
            Crypto::closure2(v3, v4, v8, ());
            ()
        };
        v8 % 48128_u16 + 1024_u16
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
