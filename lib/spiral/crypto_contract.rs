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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut5 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Crypto::Mut5 {
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
    pub fn method6(v0_1: string) -> string {
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
        let v44: string = Crypto::method7();
        v43.unwrap_or(v44)
    }
    pub fn method8() -> string {
        string("AUTOMATION")
    }
    pub fn closure2(unitVar: (), v0_1: string) {
        ();
    }
    pub fn method4(
        v0_1: Crypto::US0,
    ) -> (
        LrcPtr<Crypto::Mut1>,
        LrcPtr<Crypto::Mut2>,
        LrcPtr<Crypto::Mut3>,
        LrcPtr<Crypto::Mut4>,
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
                l0: MutCell::new(Func1::new(move |v: string| Crypto::closure2((), v))),
            }),
            LrcPtr::new(Crypto::Mut3 {
                l0: MutCell::new(true),
            }),
            LrcPtr::new(Crypto::Mut4 {
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
    pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
        string("crypto.hash_to_port")
    }
    pub fn closure1(unitVar: (), v0_1: string) -> u16 {
        let v3: i32 = getCharAt(v0_1.clone(), 0_i32) as u32 as i32;
        let v4: string = getSlice(v0_1, Some(0_i32), Some(7_i32));
        let v8: u16 = (toInt32_radix(v4.clone(), 16_i32) + v3) as u16;
        if Crypto::State::trace_state().get().clone().is_none() {
            let patternInput: (
                LrcPtr<Crypto::Mut1>,
                LrcPtr<Crypto::Mut2>,
                LrcPtr<Crypto::Mut3>,
                LrcPtr<Crypto::Mut4>,
                Option<i64>,
            ) = Crypto::method4(Crypto::US0::US0_0);
            Crypto::State::trace_state().set(Some((
                patternInput.0.clone(),
                patternInput.1.clone(),
                patternInput.2.clone(),
                patternInput.3.clone(),
                patternInput.4.clone(),
            )));
            ()
        }
        {
            let patternInput_1: (
                LrcPtr<Crypto::Mut1>,
                LrcPtr<Crypto::Mut2>,
                LrcPtr<Crypto::Mut3>,
                LrcPtr<Crypto::Mut4>,
                Option<i64>,
            ) = getValue(Crypto::State::trace_state().get().clone());
            let v21: LrcPtr<Crypto::Mut1> = patternInput_1.0.clone();
            if Crypto::State::trace_state().get().clone().is_none() {
                let patternInput_2: (
                    LrcPtr<Crypto::Mut1>,
                    LrcPtr<Crypto::Mut2>,
                    LrcPtr<Crypto::Mut3>,
                    LrcPtr<Crypto::Mut4>,
                    Option<i64>,
                ) = Crypto::method4(Crypto::US0::US0_0);
                Crypto::State::trace_state().set(Some((
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                )));
                ()
            }
            {
                let patternInput_3: (
                    LrcPtr<Crypto::Mut1>,
                    LrcPtr<Crypto::Mut2>,
                    LrcPtr<Crypto::Mut3>,
                    LrcPtr<Crypto::Mut4>,
                    Option<i64>,
                ) = getValue(Crypto::State::trace_state().get().clone());
                let v63: Crypto::US0 = (patternInput_3.3.clone()).l0.get().clone();
                if if (patternInput_3.2.clone()).l0.get().clone() == false {
                    false
                } else {
                    0_i32
                        >= find(
                            v63,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Crypto::US0::US0_0, 0_i32)),
                                LrcPtr::new((Crypto::US0::US0_1, 1_i32)),
                                LrcPtr::new((Crypto::US0::US0_2, 2_i32)),
                                LrcPtr::new((Crypto::US0::US0_3, 3_i32)),
                                LrcPtr::new((Crypto::US0::US0_4, 4_i32)),
                            ])))),
                        )
                } {
                    let v70: i64 = v21.l0.get().clone() + 1_i64;
                    v21.l0.set(v70);
                    if Crypto::State::trace_state().get().clone().is_none() {
                        let patternInput_4: (
                            LrcPtr<Crypto::Mut1>,
                            LrcPtr<Crypto::Mut2>,
                            LrcPtr<Crypto::Mut3>,
                            LrcPtr<Crypto::Mut4>,
                            Option<i64>,
                        ) = Crypto::method4(Crypto::US0::US0_0);
                        Crypto::State::trace_state().set(Some((
                            patternInput_4.0.clone(),
                            patternInput_4.1.clone(),
                            patternInput_4.2.clone(),
                            patternInput_4.3.clone(),
                            patternInput_4.4.clone(),
                        )));
                        ()
                    }
                    {
                        let patternInput_5: (
                            LrcPtr<Crypto::Mut1>,
                            LrcPtr<Crypto::Mut2>,
                            LrcPtr<Crypto::Mut3>,
                            LrcPtr<Crypto::Mut4>,
                            Option<i64>,
                        ) = getValue(Crypto::State::trace_state().get().clone());
                        let v87: Option<i64> = patternInput_5.4.clone();
                        let v226: u64 = near_sdk::env::block_timestamp();
                        let _v227: LrcPtr<MutCell<Option<Crypto::US3>>> =
                            refCell(None::<Crypto::US3>);
                        {
                            let x_2: Option<Crypto::US3> = match &v87 {
                                None => None::<Crypto::US3>,
                                Some(v87_0_0) => {
                                    let x: i64 = v87_0_0.clone();
                                    Some((Func0::new({
                                        let x = x.clone();
                                        move || Crypto::US3::US3_0(x)
                                    }))())
                                }
                            };
                            _v227.set(x_2)
                        }
                        {
                            let v242: Crypto::US3 =
                                defaultValue(Crypto::US3::US3_1, _v227.get().clone());
                            let v252: u64 = match &v242 {
                                Crypto::US3::US3_0(v242_0_0) => {
                                    v226 - match &v242 {
                                        Crypto::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    } as u64
                                }
                                _ => v226,
                            } / 1000000000_u64;
                            let v253: u64 = v252 % 60_u64;
                            let v255: u64 = v252 / 60_u64 % 60_u64;
                            let v257: u64 = v252 / 3600_u64 % 24_u64;
                            let v259: std::string::String =
                                format!("{:02}:{:02}:{:02}", v257, v255, v253);
                            let v261: string = fable_library_rust::String_::fromString(v259);
                            let v521: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                            let v559: &str = inline_colorization::color_bright_black;
                            let v561: &str = &*v521;
                            let v563: &str = inline_colorization::color_reset;
                            let v565: string = string("format!(\"{v559}{v561}{v563}\")");
                            let v566: std::string::String = format!("{v559}{v561}{v563}");
                            let v568: string = fable_library_rust::String_::fromString(v566);
                            let v587: i64 = (patternInput_5.0.clone()).l0.get().clone();
                            let v589: LrcPtr<Crypto::Mut5> = LrcPtr::new(Crypto::Mut5 {
                                l0: MutCell::new(Crypto::method12()),
                            });
                            let v591: string = sprintf!("{}", string("{ "));
                            let v595: string = append(v589.l0.get().clone(), v591);
                            v589.l0.set(v595);
                            {
                                let v597: string = sprintf!("{}", string("first_letter_code"));
                                let v601: string = append(v589.l0.get().clone(), v597);
                                v589.l0.set(v601);
                                {
                                    let v603: string = sprintf!("{}", string(" = "));
                                    let v607: string = append(v589.l0.get().clone(), v603);
                                    v589.l0.set(v607);
                                    {
                                        let v608: string = sprintf!("{}", v3);
                                        let v612: string = append(v589.l0.get().clone(), v608);
                                        v589.l0.set(v612);
                                        {
                                            let v614: string = sprintf!("{}", string("; "));
                                            let v618: string = append(v589.l0.get().clone(), v614);
                                            v589.l0.set(v618);
                                            {
                                                let v620: string =
                                                    sprintf!("{}", string("hash_part"));
                                                let v624: string =
                                                    append(v589.l0.get().clone(), v620);
                                                v589.l0.set(v624);
                                                {
                                                    let v625: string =
                                                        sprintf!("{}", string(" = "));
                                                    let v629: string =
                                                        append(v589.l0.get().clone(), v625);
                                                    v589.l0.set(v629);
                                                    {
                                                        let v630: string = sprintf!("{}", v4);
                                                        let v634: string =
                                                            append(v589.l0.get().clone(), v630);
                                                        v589.l0.set(v634);
                                                        {
                                                            let v635: string =
                                                                sprintf!("{}", string("; "));
                                                            let v639: string =
                                                                append(v589.l0.get().clone(), v635);
                                                            v589.l0.set(v639);
                                                            {
                                                                let v641: string = sprintf!(
                                                                    "{}",
                                                                    string("combined_value")
                                                                );
                                                                let v645: string = append(
                                                                    v589.l0.get().clone(),
                                                                    v641,
                                                                );
                                                                v589.l0.set(v645);
                                                                {
                                                                    let v646: string = sprintf!(
                                                                        "{}",
                                                                        string(" = ")
                                                                    );
                                                                    let v650: string = append(
                                                                        v589.l0.get().clone(),
                                                                        v646,
                                                                    );
                                                                    v589.l0.set(v650);
                                                                    {
                                                                        let v651: string =
                                                                            sprintf!("{}", v8);
                                                                        let v655: string = append(
                                                                            v589.l0.get().clone(),
                                                                            v651,
                                                                        );
                                                                        v589.l0.set(v655);
                                                                        {
                                                                            let v657: string = sprintf!(
                                                                                "{}",
                                                                                string(" }")
                                                                            );
                                                                            let v661: string =
                                                                                append(
                                                                                    v589.l0
                                                                                        .get()
                                                                                        .clone(),
                                                                                    v657,
                                                                                );
                                                                            v589.l0.set(v661);
                                                                            {
                                                                                let v662: string =
                                                                                    v589.l0
                                                                                        .get()
                                                                                        .clone();
                                                                                let v701:
                                                                                        string =
                                                                                    trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                         v261,
                                                                                                                         v568,
                                                                                                                         v587,
                                                                                                                         Crypto::closure3((),
                                                                                                                                          ()),
                                                                                                                         v662),
                                                                                                                toArray(empty::<char>())),
                                                                                                 toArray(ofArray(new_array(&[' ',
                                                                                                                             '/']))));
                                                                                near_sdk::log!(
                                                                                    "{}",
                                                                                    v701.clone()
                                                                                );
                                                                                ();
                                                                                ((patternInput_1
                                                                                    .1
                                                                                    .clone())
                                                                                .l0
                                                                                .get()
                                                                                .clone())(
                                                                                    v701
                                                                                )
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                v8 % 48128_u16 + 1024_u16
            }
        }
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
