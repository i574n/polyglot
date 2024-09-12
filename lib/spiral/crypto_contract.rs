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
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::unbox;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
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
    pub fn closure4(
        v0_1: LrcPtr<MutCell<Option<Crypto::US1>>>,
        v1_1: Option<Crypto::US1>,
    ) -> LrcPtr<MutCell<Option<Crypto::US1>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure5(
        v0_1: Option<string>,
        v1_1: Func1<Option<Crypto::US1>, LrcPtr<MutCell<Option<Crypto::US1>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Crypto::US1>>> = v1_1(match &v0_1 {
                None => None::<Crypto::US1>,
                Some(v0_1_0_0) => {
                    let x: string = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Crypto::US1::US1_0(x.clone())
                    }))())
                }
            });
            ()
        }
        ()
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
    pub fn method8() -> string {
        string("AUTOMATION")
    }
    pub fn closure6(unitVar: (), v0_1: string) {
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
        let v79: string = string("env!(\"AUTOMATION\")");
        let v80: &str = env!("AUTOMATION");
        let v82: std::string::String = String::from(v80);
        let _v1: (Crypto::US2, Crypto::US3) = (
            Crypto::US2::US2_1,
            if fable_library_rust::String_::fromString(v82) != string("True") {
                Crypto::US3::US3_1
            } else {
                Crypto::US3::US3_0(near_sdk::env::block_timestamp() as i64)
            },
        );
        let v295: Crypto::US3 = _v1.1.clone();
        let v294: Crypto::US2 = _v1.0.clone();
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
                l0: MutCell::new(string("")),
            }),
            LrcPtr::new(Crypto::Mut5 {
                l0: MutCell::new(match &v294 {
                    Crypto::US2::US2_0(v294_0_0) => match &v294 {
                        Crypto::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v295 {
                Crypto::US3::US3_0(v295_0_0) => Some(match &v295 {
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
    pub fn closure7(v0_1: LrcPtr<Crypto::Mut1>, unitVar: ()) {
        let v2: i64 = v0_1.l0.get().clone() + 1_i64;
        v0_1.l0.set(v2);
        ()
    }
    pub fn closure8(
        v0_1: LrcPtr<MutCell<Option<Crypto::US3>>>,
        v1_1: Option<Crypto::US3>,
    ) -> LrcPtr<MutCell<Option<Crypto::US3>>> {
        v0_1.set(v1_1);
        v0_1
    }
    pub fn closure9(
        v0_1: Option<i64>,
        v1_1: Func1<Option<Crypto::US3>, LrcPtr<MutCell<Option<Crypto::US3>>>>,
        unitVar: (),
    ) {
        {
            let value: LrcPtr<MutCell<Option<Crypto::US3>>> = v1_1(match &v0_1 {
                None => None::<Crypto::US3>,
                Some(v0_1_0_0) => {
                    let x: i64 = v0_1_0_0.clone();
                    Some((Func0::new({
                        let x = x.clone();
                        move || Crypto::US3::US3_0(x)
                    }))())
                }
            });
            ()
        }
        ()
    }
    pub fn method9() -> string {
        string("hh:mm:ss")
    }
    pub fn method10() -> string {
        string("HH:mm:ss")
    }
    pub fn method11() -> string {
        string("\u{001b}[0m")
    }
    pub fn method12() -> string {
        string("")
    }
    pub fn closure10(v0_1: LrcPtr<Crypto::Mut4>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn closure12(v0_1: string, unitVar: ()) {
        printfn!("{0}", v0_1);
    }
    pub fn closure11(unitVar: (), v0_1: string) {
        let v3: () = {
            Crypto::closure12(v0_1, ());
            ()
        };
        ()
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
        let v22: LrcPtr<Crypto::Mut4> = patternInput.3.clone();
        let v38: () = {
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
        let v70: Crypto::US0 = (patternInput_1.4.clone()).l0.get().clone();
        if if (patternInput_1.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v70,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Crypto::US0::US0_0, 0_i32)),
                        LrcPtr::new((Crypto::US0::US0_1, 1_i32)),
                        LrcPtr::new((Crypto::US0::US0_2, 2_i32)),
                        LrcPtr::new((Crypto::US0::US0_3, 3_i32)),
                        LrcPtr::new((Crypto::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v78: () = {
                Crypto::closure7(patternInput.0.clone(), ());
                ()
            };
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
            let v252: u64 = near_sdk::env::block_timestamp();
            let _v253: LrcPtr<MutCell<Option<Crypto::US3>>> = refCell(None::<Crypto::US3>);
            let v258: () = {
                Crypto::closure9(
                    patternInput_2.5.clone(),
                    Func1::new({
                        let _v253 = _v253.clone();
                        move |v: Option<Crypto::US3>| Crypto::closure8(_v253.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v273: Crypto::US3 = defaultValue(Crypto::US3::US3_1, _v253.get().clone());
            let v283: u64 = match &v273 {
                Crypto::US3::US3_0(v273_0_0) => {
                    v252 - match &v273 {
                        Crypto::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    } as u64
                }
                _ => v252,
            } / 1000000000_u64;
            let v284: u64 = v283 % 60_u64;
            let v286: u64 = v283 / 60_u64 % 60_u64;
            let v288: u64 = v283 / 3600_u64 % 24_u64;
            let v290: std::string::String = format!("{:02}:{:02}:{:02}", v288, v286, v284);
            let v292: string = fable_library_rust::String_::fromString(v290);
            let v572: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v610: &str = inline_colorization::color_bright_black;
            let v612: &str = &*v572;
            let v614: &str = inline_colorization::color_reset;
            let v616: string = string("format!(\"{v610}{v612}{v614}\")");
            let v617: std::string::String = format!("{v610}{v612}{v614}");
            let v619: string = fable_library_rust::String_::fromString(v617);
            let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
            let v640: LrcPtr<Crypto::Mut4> = LrcPtr::new(Crypto::Mut4 {
                l0: MutCell::new(Crypto::method12()),
            });
            let v647: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v656: () = {
                Crypto::closure10(
                    v640.clone(),
                    sprintf!("{}", string("first_letter_code")),
                    (),
                );
                ()
            };
            let v665: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v673: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v682: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v691: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string("hash_part")), ());
                ()
            };
            let v699: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v707: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v715: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v724: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string("combined_value")), ());
                ()
            };
            let v732: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v740: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v749: () = {
                Crypto::closure10(v640.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v791: string = trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v292,
                        v619,
                        v638,
                        string("crypto.hash_to_port"),
                        v640.l0.get().clone()
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            );
            let v822: string = if v22.l0.get().clone() == string("") {
                v791.clone()
            } else {
                if v791.clone() == string("") {
                    v22.l0.get().clone()
                } else {
                    append(append(v22.l0.get().clone(), string("\n")), v791.clone())
                }
            };
            let v824: &str = &*v822.clone();
            let v826 = v824.chars();
            let v828 = v826;
            let v830: Vec<char> = v828.collect::<Vec<_>>();
            let v832: Vec<Vec<char>> = v830
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v834: bool = true;
            let _vec_map: Vec<_> = v832
                .into_iter()
                .map(|x| {
                    //;
                    let v836: Vec<char> = x;
                    let v838: std::string::String = String::from_iter(v836);
                    let v840: bool = true;
                    v838
                })
                .collect::<Vec<_>>();
            let v842: Vec<std::string::String> = _vec_map;
            if if v791.clone() != string("") {
                v842.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v22.l0.set(v822);
                ()
            } else {
                v22.l0.set(string(""));
                {
                    let v854: bool = true;
                    v842.into_iter().for_each(|x| {
                        //;
                        let v856: std::string::String = x;
                        near_sdk::log!("{}", v856);
                        {
                            let v859: bool = true;
                            let v861: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v791)
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
