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
    use fable_library_rust::Native_::Any;
    use fable_library_rust::Native_::Arc;
    use fable_library_rust::Native_::Func0;
    use fable_library_rust::Native_::Func1;
    use fable_library_rust::Native_::LrcPtr;
    use fable_library_rust::Native_::MutCell;
    use fable_library_rust::Native_::OnceInit;
    use fable_library_rust::Option_::defaultValue;
    use fable_library_rust::Option_::getValue;
    use fable_library_rust::Option_::map;
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
    #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut3 {
        pub l0: MutCell<string>,
    }
    impl core::fmt::Display for Networking::Mut3 {
        fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
            write!(f, "{}", core::any::type_name::<Self>())
        }
    }
    #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
    pub struct Mut4 {
        pub l0: MutCell<Networking::US0>,
    }
    impl core::fmt::Display for Networking::Mut4 {
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
    pub fn closure1(unitVar: (), v0_1: string) -> Networking::US1 {
        Networking::US1::US1_0(v0_1)
    }
    pub fn method4() -> Func1<string, Networking::US1> {
        Func1::new(move |v: string| Networking::closure1((), v))
    }
    pub fn method2(v0_1: string) -> string {
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
        let v44: string = Networking::method3();
        v43.unwrap_or(v44)
    }
    pub fn method5() -> string {
        string("AUTOMATION")
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
        let v117: string = string("env!(\"AUTOMATION\")");
        let v118: &str = env!("AUTOMATION");
        let v125: std::string::String = String::from(v118);
        let _v1: (Networking::US2, Networking::US3) = (
            Networking::US2::US2_1,
            if fable_library_rust::String_::fromString(v125) != string("True") {
                Networking::US3::US3_1
            } else {
                Networking::US3::US3_0(near_sdk::env::block_timestamp() as i64)
            },
        );
        let v352: Networking::US3 = _v1.1.clone();
        let v351: Networking::US2 = _v1.0.clone();
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
                l0: MutCell::new(match &v351 {
                    Networking::US2::US2_0(v351_0_0) => match &v351 {
                        Networking::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => v0_1,
                }),
            }),
            match &v352 {
                Networking::US3::US3_0(v352_0_0) => Some(match &v352 {
                    Networking::US3::US3_0(x) => x.clone(),
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
    pub fn closure6(unitVar: (), v0_1: i64) -> Networking::US3 {
        Networking::US3::US3_0(v0_1)
    }
    pub fn method7() -> Func1<i64, Networking::US3> {
        Func1::new(move |v: i64| Networking::closure6((), v))
    }
    pub fn method8() -> string {
        string("hh:mm:ss")
    }
    pub fn method9() -> string {
        string("HH:mm:ss")
    }
    pub fn method6(
        v0_1: LrcPtr<Networking::Mut0>,
        v1_1: LrcPtr<Networking::Mut1>,
        v2_1: LrcPtr<Networking::Mut2>,
        v3: LrcPtr<Networking::Mut3>,
        v4: LrcPtr<Networking::Mut4>,
        v5: Option<i64>,
    ) -> string {
        let v130: u64 = near_sdk::env::block_timestamp();
        let v144: Networking::US3 =
            defaultValue(Networking::US3::US3_1, map(Networking::method7(), v5));
        let v154: u64 = match &v144 {
            Networking::US3::US3_0(v144_0_0) => {
                v130 - match &v144 {
                    Networking::US3::US3_0(x) => x.clone(),
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
    pub fn method11() -> string {
        string("\u{001b}[0m")
    }
    pub fn method10() -> string {
        let v5: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
        let v79: &str = inline_colorization::color_bright_black;
        let v86: &str = &*v5;
        let v102: &str = inline_colorization::color_reset;
        let v104: std::string::String = format!("{}{}{}", v79, v86, v102);
        fable_library_rust::String_::fromString(v104)
    }
    pub fn method13() -> string {
        string("")
    }
    pub fn closure7(v0_1: LrcPtr<Networking::Mut3>, v1_1: string, unitVar: ()) {
        let v3: string = append(v0_1.l0.get().clone(), v1_1);
        v0_1.l0.set(v3);
        ()
    }
    pub fn method12(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v10: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("port")), ());
            ()
        };
        let v28: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v62: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn method14(v0_1: string, v1_1: string, v2_1: string, v3: i64, v4: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!("{} {} #{} {} / {}", v0_1, v1_1, v3, v2_1, v4),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure8(v0_1: LrcPtr<Networking::Mut0>, unitVar: ()) {
        let v2_1: i64 = v0_1.l0.get().clone() + 1_i64;
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
    pub fn method15(
        v0_1: string,
        v1_1: LrcPtr<Networking::Mut0>,
        v2_1: LrcPtr<Networking::Mut1>,
        v3: LrcPtr<Networking::Mut2>,
        v4: LrcPtr<Networking::Mut3>,
        v5: LrcPtr<Networking::Mut4>,
        v6: Option<i64>,
    ) {
        let v9: () = {
            Networking::closure8(v1_1, ());
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
        (v2_1.l0.get().clone())(v0_1)
    }
    pub fn closure5(v0_1: i32, v1_1: string, unitVar: ()) {
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
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v36: Networking::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v36,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v43: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let v57: LrcPtr<Networking::Mut0> = patternInput_1.0.clone();
            let v83: string = Networking::method14(
                Networking::method6(
                    v57.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                Networking::method10(),
                string("networking.test_port_open"),
                v57.l0.get().clone(),
                Networking::method12(v0_1, v1_1),
            );
            let v85: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            Networking::method15(
                v83,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn closure4(v0_1: string, v1_1: i32) -> Arc<Async<bool>> {
        defaultOf()
    }
    pub fn closure3(unitVar: (), v0_1: string) -> Func1<i32, Arc<Async<bool>>> {
        Func1::new({
            let v0_1 = v0_1.clone();
            move |v: i32| Networking::closure4(v0_1.clone(), v)
        })
    }
    pub fn closure14(unitVar: (), v0_1: bool) -> Networking::US5 {
        Networking::US5::US5_0(v0_1)
    }
    pub fn closure15(unitVar: (), v0_1: LrcPtr<Exception>) -> Networking::US5 {
        Networking::US5::US5_1(v0_1)
    }
    pub fn method16(v0_1: i32) -> string {
        let v2_1: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v9: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v18_1: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", string("timeout")), ());
            ()
        };
        let v27: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v35: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v44: () = {
            Networking::closure7(v2_1.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v2_1.l0.get().clone()
    }
    pub fn closure16(v0_1: i32, unitVar: ()) {
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
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v35: Networking::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v42: () = {
                v2_1();
                ()
            };
            let patternInput_1: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let v56: LrcPtr<Networking::Mut0> = patternInput_1.0.clone();
            let v82: string = Networking::method14(
                Networking::method6(
                    v56.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                Networking::method10(),
                string("async.run_with_timeout_async"),
                v56.l0.get().clone(),
                Networking::method16(v0_1),
            );
            let v84: () = {
                v2_1();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            Networking::method15(
                v82,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method17() -> string {
        let v5: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
        let v79: &str = inline_colorization::color_bright_red;
        let v86: &str = &*v5;
        let v102: &str = inline_colorization::color_reset;
        let v104: std::string::String = format!("{}{}{}", v79, v86, v102);
        fable_library_rust::String_::fromString(v104)
    }
    pub fn method18(v0_1: i32, v1_1: string) -> string {
        let v3: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v10: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v19_1: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("timeout")), ());
            ()
        };
        let v28: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v36: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v45: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v54: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string("ex")), ());
            ()
        };
        let v62: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v70: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v79: () = {
            Networking::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v3.l0.get().clone()
    }
    pub fn closure17(v0_1: i32, v1_1: LrcPtr<Exception>, unitVar: ()) {
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
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v36: Networking::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            4_i32
                >= find(
                    v36,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v43: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let v57: LrcPtr<Networking::Mut0> = patternInput_1.0.clone();
            let v105: string = Networking::method14(
                Networking::method6(
                    v57.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                Networking::method17(),
                string("async.run_with_timeout_async**"),
                v57.l0.get().clone(),
                Networking::method18(v0_1, sprintf!("{:?}", v1_1)),
            );
            let v107: () = {
                v3();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            Networking::method15(
                v105,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn closure13(v0_1: i32, v1_1: string, v2_1: i32) -> Arc<Async<bool>> {
        defaultOf()
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
    pub fn closure22(unitVar: (), v0_1: i32) -> Networking::US7 {
        Networking::US7::US7_0(v0_1)
    }
    pub fn method20() -> Func1<i32, Networking::US7> {
        Func1::new(move |v: i32| Networking::closure22((), v))
    }
    pub fn method21(v0_1: i32, v1_1: i64, v2_1: Option<i32>, v3: bool) -> string {
        let v5: LrcPtr<Networking::Mut3> = LrcPtr::new(Networking::Mut3 {
            l0: MutCell::new(Networking::method13()),
        });
        let v12: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
            ()
        };
        let v21: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("port")), ());
            ()
        };
        let v30: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v38: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", v0_1), ());
            ()
        };
        let v47: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v56: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("retry")), ());
            ()
        };
        let v64: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v72: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", v1_1), ());
            ()
        };
        let v80: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v89: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("timeout")), ());
            ()
        };
        let v97: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v110: std::string::String = format!("{:#?}", v2_1);
        let v132: () = {
            Networking::closure7(
                v5.clone(),
                sprintf!("{}", fable_library_rust::String_::fromString(v110)),
                (),
            );
            ()
        };
        let v140: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
            ()
        };
        let v149: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string("status")), ());
            ()
        };
        let v157: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
            ()
        };
        let v168: () = {
            Networking::closure7(
                v5.clone(),
                sprintf!("{}", if v3 { string("true") } else { string("false") }),
                (),
            );
            ()
        };
        let v177: () = {
            Networking::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
            ()
        };
        v5.l0.get().clone()
    }
    pub fn method22(v0_1: string, v1_1: string, v2_1: i64, v3: string) -> string {
        trimEndChars(
            trimStartChars(
                sprintf!(
                    "{} {} #{} {} / {}",
                    v0_1,
                    v1_1,
                    v2_1,
                    string("networking.wait_for_port_access"),
                    v3
                ),
                toArray(empty::<char>()),
            ),
            toArray(ofArray(new_array(&[' ', '/']))),
        )
    }
    pub fn closure23(v0_1: Option<i32>, v1_1: bool, v2_1: i32, v3: i64, unitVar: ()) {
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
            LrcPtr<Networking::Mut4>,
            Option<i64>,
        ) = getValue(Networking::TraceState::trace_state().get().clone());
        let v38: Networking::US0 = (patternInput.4.clone()).l0.get().clone();
        if if (patternInput.2.clone()).l0.get().clone() == false {
            false
        } else {
            0_i32
                >= find(
                    v38,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Networking::US0::US0_0, 0_i32)),
                        LrcPtr::new((Networking::US0::US0_1, 1_i32)),
                        LrcPtr::new((Networking::US0::US0_2, 2_i32)),
                        LrcPtr::new((Networking::US0::US0_3, 3_i32)),
                        LrcPtr::new((Networking::US0::US0_4, 4_i32)),
                    ])))),
                )
        } {
            let v45: () = {
                v5();
                ()
            };
            let patternInput_1: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            let v59: LrcPtr<Networking::Mut0> = patternInput_1.0.clone();
            let v81: string = Networking::method22(
                Networking::method6(
                    v59.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                ),
                Networking::method10(),
                v59.l0.get().clone(),
                Networking::method21(v2_1, v3, v0_1, v1_1),
            );
            let v83: () = {
                v5();
                ()
            };
            let patternInput_2: (
                LrcPtr<Networking::Mut0>,
                LrcPtr<Networking::Mut1>,
                LrcPtr<Networking::Mut2>,
                LrcPtr<Networking::Mut3>,
                LrcPtr<Networking::Mut4>,
                Option<i64>,
            ) = getValue(Networking::TraceState::trace_state().get().clone());
            Networking::method15(
                v81,
                patternInput_2.0.clone(),
                patternInput_2.1.clone(),
                patternInput_2.2.clone(),
                patternInput_2.3.clone(),
                patternInput_2.4.clone(),
                patternInput_2.5.clone(),
            )
        }
    }
    pub fn method19(
        v0_1: Option<i32>,
        v1_1: bool,
        v2_1: string,
        v3: i32,
        v4: i64,
    ) -> Arc<Async<i64>> {
        defaultOf()
    }
    pub fn closure21(v0_1: Option<i32>, v1_1: bool, v2_1: string, v3: i32) -> Arc<Async<i64>> {
        Networking::method19(v0_1, v1_1, v2_1, v3, 0_i64)
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
    pub fn method23(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        defaultOf()
    }
    pub fn closure26(v0_1: Option<i32>, v1_1: string, v2_1: i32) -> Arc<Async<i32>> {
        Networking::method23(v0_1, v1_1, v2_1)
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
