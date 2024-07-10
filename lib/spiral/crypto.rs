pub mod Crypto {
    use super::*;
    use fable_library_rust::Convert_::toInt32_radix;
    use fable_library_rust::DateTime_::DateTime;
    use fable_library_rust::Encoding_::get_UTF8;
    use fable_library_rust::Encoding_::Encoding;
    use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
    use fable_library_rust::List_::empty;
    use fable_library_rust::List_::ofArray;
    use fable_library_rust::List_::toArray as toArray_1;
    use fable_library_rust::Map_::find;
    use fable_library_rust::Map_::ofSeq;
    use fable_library_rust::NativeArray_::count;
    use fable_library_rust::NativeArray_::new_array;
    use fable_library_rust::NativeArray_::Array;
    use fable_library_rust::Native_::on_startup;
    use fable_library_rust::Native_::refCell;
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Range_::rangeNumeric;
    use fable_library_rust::Seq_::delay;
    use fable_library_rust::Seq_::map;
    use fable_library_rust::Seq_::ofList;
    use fable_library_rust::Seq_::toArray;
    use fable_library_rust::String_::append;
    use fable_library_rust::String_::getCharAt;
    use fable_library_rust::String_::getSlice;
    use fable_library_rust::String_::join;
    use fable_library_rust::String_::padLeft;
    use fable_library_rust::String_::sprintf;
    use fable_library_rust::String_::string;
    use fable_library_rust::String_::toLower;
    use fable_library_rust::String_::trimEndChars;
    use fable_library_rust::String_::trimStartChars;
    use fable_library_rust::TimeSpan_::TimeSpan;
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
    pub fn method1(v0_1: i32, v1_1: LrcPtr<Crypto::Mut0>) -> bool {
        v1_1.l0.get().clone() < v0_1
    }
    pub fn method2() -> string {
        string("")
    }
    pub fn method0(v0_1: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v7: Array<u8> = {
            let _arg: LrcPtr<dyn Encoding> = get_UTF8();
            _arg.getBytes(v0_1)
        };
        let v9: Vec<u8> = v7.to_vec();
        let v11: std::io::Cursor<Vec<u8>> = std::io::Cursor::new(v9);
        let v13: std::io::BufReader<std::io::Cursor<Vec<u8>>> = std::io::BufReader::new(v11);
        let v15: bool = true;
        let mut v13 = v13;
        let result: sha2::Sha256 = sha2::Digest::new();
        {
            let v18: sha2::Sha256 = result;
            let v20: bool = true;
            let mut v18 = v18;
            let v23: usize = 0_i32 as usize;
            let v31: _ = [0_u8; 1024];
            let v33: bool = true;
            loop {
                // rust.loop;
                let v35: bool = true;
                let mut v31 = v31;
                let v37: Result<usize, std::io::Error> = std::io::Read::read(&mut v13, &mut v31);
                let v39: usize = v37.unwrap();
                if v39 == v23 {
                    let v50: bool = true;
                    break;
                    ()
                }
                {
                    let v52: usize = v31.len();
                    let v55: u8 = v52 as u8;
                    let v64: usize = v39;
                    let v93: &_ = if v64 == v52 {
                        &v31[v23..]
                    } else {
                        &v31[v23..v64]
                    };
                    sha2::Digest::update(&mut v18, v93);
                    {
                        let v96: bool = true;
                    } // rust.loop;
                    let v98: bool = true;
                } // rust.loop;
                let v100: bool = true;
            } // rust.loop;
            let v102: bool = true;
            {
                // rust.loop;
                let v104: bool = true;
                {
                    // rust.loop;
                    let v106: &[u8] = &sha2::Digest::finalize(v18);
                    let v108: Vec<u8> = v106.iter().map(|x| *x).collect::<Vec<_>>();
                    let v110: bool = true;
                    let _result: Vec<_> = v108
                        .into_iter()
                        .map(|x| {
                            //;
                            let v112: u8 = x;
                            let v114: std::string::String = format!("{:02x}", v112);
                            let v116: string = fable_library_rust::String_::fromString(v114);
                            let v118: bool = true;
                            v116
                        })
                        .collect::<Vec<_>>();
                    let v120: Vec<string> = _result;
                    let v122: Array<string> = fable_library_rust::NativeArray_::array_from(v120);
                    let v137: string = join(
                        string(""),
                        toArray(delay(Func0::new({
                            let v122 = v122.clone();
                            move || {
                                map(
                                    Func1::new({
                                        let v122 = v122.clone();
                                        move |i: i32| v122[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, count(v122.clone()) - 1_i32),
                                )
                            }
                        }))),
                    );
                    {
                        let x: string = Ok::<string, std::io::Error>(v137).unwrap();
                        _v3.set(Some(x))
                    }
                    match &_v3.get().clone() {
                        None => panic!("{}", string("base.run_target / _v3=None"),),
                        Some(_v3_0_0) => _v3_0_0.clone(),
                    }
                }
            }
        }
    }
    pub fn closure0(unitVar: (), v0_1: string) -> string {
        Crypto::method0(v0_1)
    }
    pub fn closure2(unitVar: (), unitVar_1: ()) -> string {
        string("crypto.hash_to_port")
    }
    pub fn closure3(v0_1: i32, v1_1: string, v2: u16, unitVar: ()) -> (i32, string, u16) {
        (v0_1, v1_1, v2)
    }
    pub fn method4() -> string {
        string("TRACE_LEVEL")
    }
    pub fn method6() -> string {
        string("")
    }
    pub fn method5(v0_1: string) -> string {
        let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
        let v5: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
        let v7: bool = true;
        let _result = v5.map(|x| {
            //;
            let v9: std::string::String = x;
            let v11: string = fable_library_rust::String_::fromString(v9);
            let v13: bool = true;
            v11
        });
        let v15: Result<string, std::env::VarError> = _result;
        let v16: string = Crypto::method6();
        {
            let x: string = v15.unwrap_or(v16);
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
    pub fn closure6(unitVar: (), v0_1: string) {
        ();
    }
    pub fn closure5(
        unitVar: (),
        v0_1: Crypto::US0,
    ) -> (
        LrcPtr<Crypto::Mut1>,
        LrcPtr<Crypto::Mut2>,
        LrcPtr<Crypto::Mut3>,
        LrcPtr<Crypto::Mut4>,
        Option<i64>,
    ) {
        let _v3: MutCell<Option<(Crypto::US1, Crypto::US2)>> =
            MutCell::new(None::<(Crypto::US1, Crypto::US2)>);
        let v5: string = Crypto::method5(Crypto::method4());
        let v11: Crypto::US1 = if string("Verbose") == v5.clone() {
            Crypto::US1::US1_0(Crypto::US0::US0_0)
        } else {
            Crypto::US1::US1_1
        };
        {
            let x: (Crypto::US1, Crypto::US2) = (
                match &v11 {
                    Crypto::US1::US1_0(v11_0_0) => Crypto::US1::US1_0(match &v11 {
                        Crypto::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v19: Crypto::US1 = if string("Debug") == v5.clone() {
                            Crypto::US1::US1_0(Crypto::US0::US0_1)
                        } else {
                            Crypto::US1::US1_1
                        };
                        match &v19 {
                            Crypto::US1::US1_0(v19_0_0) => Crypto::US1::US1_0(match &v19 {
                                Crypto::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                let v27: Crypto::US1 = if string("Info") == v5.clone() {
                                    Crypto::US1::US1_0(Crypto::US0::US0_2)
                                } else {
                                    Crypto::US1::US1_1
                                };
                                match &v27 {
                                    Crypto::US1::US1_0(v27_0_0) => Crypto::US1::US1_0(match &v27 {
                                        Crypto::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                    _ => {
                                        let v35: Crypto::US1 = if string("Warning") == v5.clone() {
                                            Crypto::US1::US1_0(Crypto::US0::US0_3)
                                        } else {
                                            Crypto::US1::US1_1
                                        };
                                        match &v35 {
                                            Crypto::US1::US1_0(v35_0_0) => {
                                                Crypto::US1::US1_0(match &v35 {
                                                    Crypto::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v43: Crypto::US1 =
                                                    if string("Critical") == v5.clone() {
                                                        Crypto::US1::US1_0(Crypto::US0::US0_4)
                                                    } else {
                                                        Crypto::US1::US1_1
                                                    };
                                                match &v43 {
                                                    Crypto::US1::US1_0(v43_0_0) => {
                                                        Crypto::US1::US1_0(match &v43 {
                                                            Crypto::US1::US1_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
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
                if Crypto::method5(Crypto::method7()) == string("True") {
                    Crypto::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Crypto::US2::US2_1
                },
            );
            _v3.set(Some(x))
        }
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
                        _ => v0_1,
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
    pub fn method13(v0_1: LrcPtr<Crypto::Mut5>, v1_1: string) {
        let v4: string = sprintf!("{}", v1_1);
        let v12: string = append(v0_1.l0.get().clone(), v4);
        v0_1.l0.set(v12);
        ()
    }
    pub fn method14(v0_1: LrcPtr<Crypto::Mut5>) {
        ();
    }
    pub fn method15(v0_1: LrcPtr<Crypto::Mut5>, v1_1: i32) {
        let v4: string = sprintf!("{}", v1_1);
        let v12: string = append(v0_1.l0.get().clone(), v4);
        v0_1.l0.set(v12);
        ()
    }
    pub fn method16(v0_1: LrcPtr<Crypto::Mut5>, v1_1: u16) {
        let v4: string = sprintf!("{}", v1_1);
        let v12: string = append(v0_1.l0.get().clone(), v4);
        v0_1.l0.set(v12);
        ()
    }
    pub fn method12(v0_1: LrcPtr<Crypto::Mut5>, v1_1: i32, v2: string, v3: u16) {
        Crypto::method13(v0_1.clone(), string("{ "));
        Crypto::method14(v0_1.clone());
        Crypto::method13(v0_1.clone(), string("first_letter_code"));
        Crypto::method13(v0_1.clone(), string(" = "));
        Crypto::method15(v0_1.clone(), v1_1);
        Crypto::method13(v0_1.clone(), string("; "));
        Crypto::method13(v0_1.clone(), string("hash_part"));
        Crypto::method13(v0_1.clone(), string(" = "));
        Crypto::method13(v0_1.clone(), v2);
        Crypto::method13(v0_1.clone(), string("; "));
        Crypto::method13(v0_1.clone(), string("combined_value"));
        Crypto::method13(v0_1.clone(), string(" = "));
        Crypto::method16(v0_1.clone(), v3);
        Crypto::method13(v0_1, string(" }"))
    }
    pub fn closure4(
        v0_1: Crypto::US0,
        v1_1: Func0<string>,
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
            let v18: Option<i64> = patternInput.4.clone();
            let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
            let _v38: LrcPtr<MutCell<Option<Crypto::US2>>> = refCell(None::<Crypto::US2>);
            {
                let x_2: Option<Crypto::US2> = match &v18 {
                    None => None::<Crypto::US2>,
                    Some(v18_0_0) => {
                        let x: i64 = v18_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Crypto::US2::US2_0(x)
                        }))())
                    }
                };
                _v38.set(x_2)
            }
            {
                let v65: Crypto::US2 = defaultValue(Crypto::US2::US2_1, _v38.get().clone());
                let v163: DateTime = match &v65 {
                    Crypto::US2::US2_0(v65_0_0) => {
                        let v97: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v65 {
                                Crypto::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v97.hours(),
                            v97.minutes(),
                            v97.seconds(),
                            v97.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x_3: string = {
                        let provider: string = Crypto::method8();
                        v163.toString(provider)
                    };
                    _v35.set(Some(x_3))
                }
                {
                    let v772: string = match &_v35.get().clone() {
                        None => panic!("{}", string("base.run_target / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    let v931: Crypto::US3 = if if let Crypto::US0::US0_0 = &v0_1 {
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
                            let v940: Crypto::US3 = if if let Crypto::US0::US0_1 = &v0_1 {
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
                                    let v949: Crypto::US3 = if if let Crypto::US0::US0_2 = &v0_1 {
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
                                            let v958: Crypto::US3 =
                                                if if let Crypto::US0::US0_3 = &v0_1 {
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
                                                        if if let Crypto::US0::US0_4 = &v0_1 {
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
                    let v1044: &str = match &v0_1 {
                        Crypto::US0::US0_1 => inline_colorization::color_bright_blue,
                        Crypto::US0::US0_2 => inline_colorization::color_bright_green,
                        Crypto::US0::US0_0 => inline_colorization::color_bright_black,
                        Crypto::US0::US0_3 => inline_colorization::color_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v1046: &str = &*v997;
                    let v1048: &str = inline_colorization::color_reset;
                    let v1050: string = string("format!(\"{v1044}{v1046}{v1048}\")");
                    let v1051: std::string::String = format!("{v1044}{v1046}{v1048}");
                    {
                        let x_5: string = fable_library_rust::String_::fromString(v1051);
                        _v1029.set(Some(x_5))
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
                                    sprintf!(
                                        "{} {} #{} {} / {}",
                                        v772,
                                        v1141,
                                        v1160,
                                        v1_1(),
                                        v1166
                                    ),
                                    toArray_1(empty::<char>()),
                                ),
                                toArray_1(ofArray(new_array(&[' ', '/']))),
                            )
                        }
                    }
                }
            }
        }
    }
    pub fn method17(v0_1: Crypto::US0, v1_1: Func0<string>) {
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
                        v0_1,
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
                        let v72: string = sprintf!("{}", v1_1());
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
    pub fn method3(v0_1: Crypto::US0, v1_1: Func0<string>, v2: Func0<(i32, string, u16)>) {
        Crypto::method17(
            v0_1.clone(),
            Func0::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                move || Crypto::closure4(v0_1.clone(), v1_1.clone(), v2.clone(), ())
            }),
        );
    }
    pub fn closure1(unitVar: (), v0_1: string) -> u16 {
        let v3: i32 = getCharAt(v0_1.clone(), 0_i32) as u32 as i32;
        let v4: string = getSlice(v0_1, Some(0_i32), Some(7_i32));
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
