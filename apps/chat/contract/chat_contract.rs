#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
mod module_31a2fc18 {
    pub mod Chat_contract {
        use super::*;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::referenceEquals;
        use fable_library_rust::Native_::Any;
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
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::padLeft;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::startsWith;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        pub mod TraceState {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Chat_contract::Mut0>,
                        LrcPtr<Chat_contract::Mut1>,
                        LrcPtr<Chat_contract::Mut2>,
                        LrcPtr<Chat_contract::Mut3>,
                        LrcPtr<Chat_contract::Mut4>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Chat_contract::Mut0>,
                                LrcPtr<Chat_contract::Mut1>,
                                LrcPtr<Chat_contract::Mut2>,
                                LrcPtr<Chat_contract::Mut3>,
                                LrcPtr<Chat_contract::Mut4>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Chat_contract::Mut0>,
                                LrcPtr<Chat_contract::Mut1>,
                                LrcPtr<Chat_contract::Mut2>,
                                LrcPtr<Chat_contract::Mut3>,
                                LrcPtr<Chat_contract::Mut4>,
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
        impl core::fmt::Display for Chat_contract::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Chat_contract::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Chat_contract::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Chat_contract::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Chat_contract::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<Chat_contract::US0>,
        }
        impl core::fmt::Display for Chat_contract::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(string),
            US1_1,
        }
        impl core::fmt::Display for Chat_contract::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Chat_contract::US0),
            US2_1,
        }
        impl core::fmt::Display for Chat_contract::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(i64),
            US3_1,
        }
        impl core::fmt::Display for Chat_contract::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0(std::string::String),
            US4_1,
        }
        impl core::fmt::Display for Chat_contract::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure1(unitVar: (), v0_1: char) -> bool {
            if v0_1.is_alphanumeric() {
                true
            } else {
                v0_1 == '-'
            }
        }
        pub fn method1() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method3() -> string {
            string("")
        }
        pub fn closure4(unitVar: (), v0_1: string) -> Chat_contract::US1 {
            Chat_contract::US1::US1_0(v0_1)
        }
        pub fn method4() -> Func1<string, Chat_contract::US1> {
            Func1::new(move |v: string| Chat_contract::closure4((), v))
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
            let v44: string = Chat_contract::method3();
            v43.unwrap_or(v44)
        }
        pub fn method5() -> string {
            string("AUTOMATION")
        }
        pub fn closure5(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method0(
            v0_1: Chat_contract::US0,
        ) -> (
            LrcPtr<Chat_contract::Mut0>,
            LrcPtr<Chat_contract::Mut1>,
            LrcPtr<Chat_contract::Mut2>,
            LrcPtr<Chat_contract::Mut3>,
            LrcPtr<Chat_contract::Mut4>,
            Option<i64>,
        ) {
            let v117: string = string("env!(\"AUTOMATION\")");
            let v118: &str = env!("AUTOMATION");
            let v125: std::string::String = String::from(v118);
            let _v1: (Chat_contract::US2, Chat_contract::US3) = (
                Chat_contract::US2::US2_1,
                if fable_library_rust::String_::fromString(v125) != string("True") {
                    Chat_contract::US3::US3_1
                } else {
                    Chat_contract::US3::US3_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v352: Chat_contract::US3 = _v1.1.clone();
            let v351: Chat_contract::US2 = _v1.0.clone();
            (
                LrcPtr::new(Chat_contract::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Chat_contract::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Chat_contract::closure5((), v))),
                }),
                LrcPtr::new(Chat_contract::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Chat_contract::Mut4 {
                    l0: MutCell::new(match &v351 {
                        Chat_contract::US2::US2_0(v351_0_0) => match &v351 {
                            Chat_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v352 {
                    Chat_contract::US3::US3_0(v352_0_0) => Some(match &v352 {
                        Chat_contract::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure3(unitVar: (), unitVar_1: ()) {
            if Chat_contract::TraceState::trace_state()
                .get()
                .clone()
                .is_none()
            {
                let patternInput: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = Chat_contract::method0(Chat_contract::US0::US0_0);
                Chat_contract::TraceState::trace_state().set(Some((
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
        pub fn closure6(unitVar: (), v0_1: i64) -> Chat_contract::US3 {
            Chat_contract::US3::US3_0(v0_1)
        }
        pub fn method7() -> Func1<i64, Chat_contract::US3> {
            Func1::new(move |v: i64| Chat_contract::closure6((), v))
        }
        pub fn method8() -> string {
            string("hh:mm:ss")
        }
        pub fn method9() -> string {
            string("HH:mm:ss")
        }
        pub fn method6(
            v0_1: LrcPtr<Chat_contract::Mut0>,
            v1: LrcPtr<Chat_contract::Mut1>,
            v2: LrcPtr<Chat_contract::Mut2>,
            v3: LrcPtr<Chat_contract::Mut3>,
            v4: LrcPtr<Chat_contract::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v130: u64 = near_sdk::env::block_timestamp();
            let v144: Chat_contract::US3 =
                defaultValue(Chat_contract::US3::US3_1, map(Chat_contract::method7(), v5));
            let v154: u64 = match &v144 {
                Chat_contract::US3::US3_0(v144_0_0) => {
                    v130 - match &v144 {
                        Chat_contract::US3::US3_0(x) => x.clone(),
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
            let v5: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v79: &str = inline_colorization::color_bright_blue;
            let v86: &str = &*v5;
            let v102: &str = inline_colorization::color_reset;
            let v104: std::string::String = format!("{}{}{}", v79, v86, v102);
            fable_library_rust::String_::fromString(v104)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure7(v0_1: LrcPtr<Chat_contract::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method12(v0_1: std::string::String, v1: u64, v2: std::string::String) -> string {
            let v4: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v11: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string("alias")), ());
                ()
            };
            let v29: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v42: std::string::String = format!("{:#?}", v0_1);
            let v64: () = {
                Chat_contract::closure7(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v42)),
                    (),
                );
                ()
            };
            let v73: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v82: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string("block_timestamp")), ());
                ()
            };
            let v90: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v98: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v106: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v115: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string("account_id")), ());
                ()
            };
            let v123: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v136: std::string::String = format!("{:#?}", v2);
            let v158: () = {
                Chat_contract::closure7(
                    v4.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v136)),
                    (),
                );
                ()
            };
            let v167: () = {
                Chat_contract::closure7(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method14(v0_1: string, v1: string, v2: string, v3: i64, v4: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!("{} {} #{} {} / {}", v0_1, v1, v3, v2, v4),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure8(v0_1: LrcPtr<Chat_contract::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure10(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure9(unitVar: (), v0_1: string) {
            let v3: () = {
                Chat_contract::closure10(v0_1, ());
                ()
            };
            ()
        }
        pub fn method15(
            v0_1: string,
            v1: LrcPtr<Chat_contract::Mut0>,
            v2: LrcPtr<Chat_contract::Mut1>,
            v3: LrcPtr<Chat_contract::Mut2>,
            v4: LrcPtr<Chat_contract::Mut3>,
            v5: LrcPtr<Chat_contract::Mut4>,
            v6: Option<i64>,
        ) {
            let v9: () = {
                Chat_contract::closure8(v1, ());
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
        pub fn closure2(v0_1: std::string::String, v1: near_sdk::AccountId, v2: u64, unitVar: ()) {
            fn v4() {
                Chat_contract::closure3((), ());
            }
            let v5: () = {
                v4();
                ()
            };
            let patternInput: (
                LrcPtr<Chat_contract::Mut0>,
                LrcPtr<Chat_contract::Mut1>,
                LrcPtr<Chat_contract::Mut2>,
                LrcPtr<Chat_contract::Mut3>,
                LrcPtr<Chat_contract::Mut4>,
                Option<i64>,
            ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
            let v37: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v37,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v44: () = {
                    v4();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                let v58: LrcPtr<Chat_contract::Mut0> = patternInput_1.0.clone();
                let v86: string = Chat_contract::method14(
                    Chat_contract::method6(
                        v58.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Chat_contract::method10(),
                    string("chat_contract.claim_alias"),
                    v58.l0.get().clone(),
                    Chat_contract::method12(v0_1, v2, v1.to_string()),
                );
                let v88: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                Chat_contract::method15(
                    v86,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure11(unitVar: (), v0_1: std::string::String) -> Chat_contract::US4 {
            Chat_contract::US4::US4_0(v0_1)
        }
        pub fn method16() -> Func1<std::string::String, Chat_contract::US4> {
            Func1::new(move |v: std::string::String| Chat_contract::closure11((), v))
        }
        pub fn method17() -> string {
            let v5: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v79: &str = inline_colorization::color_yellow;
            let v86: &str = &*v5;
            let v102: &str = inline_colorization::color_reset;
            let v104: std::string::String = format!("{}{}{}", v79, v86, v102);
            fable_library_rust::String_::fromString(v104)
        }
        pub fn method18(v0_1: string) -> string {
            let v2: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v9: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", string("account_alias")), ());
                ()
            };
            let v27: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure12(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Chat_contract::closure3((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Chat_contract::Mut0>,
                LrcPtr<Chat_contract::Mut1>,
                LrcPtr<Chat_contract::Mut2>,
                LrcPtr<Chat_contract::Mut3>,
                LrcPtr<Chat_contract::Mut4>,
                Option<i64>,
            ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
            let v35: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Chat_contract::Mut0> = patternInput_1.0.clone();
                let v85: string = Chat_contract::method14(
                    Chat_contract::method6(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Chat_contract::method17(),
                    string("chat_contract.claim_alias / alias already claimed"),
                    v56.l0.get().clone(),
                    Chat_contract::method18(sprintf!("{:?}", v0_1)),
                );
                let v87: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                Chat_contract::method15(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure13(v0_1: Option<std::string::String>, unitVar: ()) {
            fn v2() {
                Chat_contract::closure3((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Chat_contract::Mut0>,
                LrcPtr<Chat_contract::Mut1>,
                LrcPtr<Chat_contract::Mut2>,
                LrcPtr<Chat_contract::Mut3>,
                LrcPtr<Chat_contract::Mut4>,
                Option<i64>,
            ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
            let v35: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Chat_contract::Mut0> = patternInput_1.0.clone();
                let v85: string = Chat_contract::method14(
                    Chat_contract::method6(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Chat_contract::method10(),
                    string("chat_contract.claim_alias"),
                    v56.l0.get().clone(),
                    Chat_contract::method18(sprintf!("{:?}", v0_1)),
                );
                let v87: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                Chat_contract::method15(
                    v85,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure14(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method19() -> Func0<()> {
            Func0::new(move || Chat_contract::closure14((), ()))
        }
        pub fn method20(
            v0_1: LrcPtr<Chat_contract::Mut0>,
            v1: LrcPtr<Chat_contract::Mut1>,
            v2: LrcPtr<Chat_contract::Mut2>,
            v3: LrcPtr<Chat_contract::Mut3>,
            v4: LrcPtr<Chat_contract::Mut4>,
            v5: Option<i64>,
        ) {
            let v8: () = {
                Chat_contract::closure8(v0_1, ());
                ()
            };
            let v25: string = if v3.l0.get().clone() == string("") {
                string("")
            } else {
                v3.l0.get().clone()
            };
            let v32: &str = &*v25;
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
            v3.l0.set(string(""));
            {
                let v75: bool = true;
                v64.into_iter().for_each(|x| {
                    //;
                    let v77: std::string::String = x;
                    let v79: bool = true;
                    near_sdk::log!("{}", v77);
                    let v81: bool = true;
                    let v83: bool = true;
                }); //;
                ()
            }
            ();
            (v1.l0.get().clone())(string(""))
        }
        pub fn closure15(v0_1: Func0<()>, unitVar: ()) {
            fn v2() {
                Chat_contract::closure3((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Chat_contract::Mut0>,
                LrcPtr<Chat_contract::Mut1>,
                LrcPtr<Chat_contract::Mut2>,
                LrcPtr<Chat_contract::Mut3>,
                LrcPtr<Chat_contract::Mut4>,
                Option<i64>,
            ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
            let v35: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                let v74: string = Chat_contract::method6(
                    patternInput_1.0.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                );
                let v75: string = Chat_contract::method10();
                let v77: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                Chat_contract::method20(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method21(
            v0_1: near_sdk::AccountId,
            v1: Option<(std::string::String, u64, u32)>,
        ) -> string {
            let v3: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v10: () = {
                Chat_contract::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Chat_contract::closure7(v3.clone(), sprintf!("{}", string("account_id")), ());
                ()
            };
            let v28: () = {
                Chat_contract::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v41: std::string::String = format!("{:#?}", v0_1);
            let v63: () = {
                Chat_contract::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v41)),
                    (),
                );
                ()
            };
            let v72: () = {
                Chat_contract::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v81: () = {
                Chat_contract::closure7(v3.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v89: () = {
                Chat_contract::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v102: std::string::String = format!("{:#?}", v1);
            let v124: () = {
                Chat_contract::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v102)),
                    (),
                );
                ()
            };
            let v133: () = {
                Chat_contract::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn closure16(
            v0_1: near_sdk::AccountId,
            v1: Option<(std::string::String, u64, u32)>,
            unitVar: (),
        ) {
            fn v3() {
                Chat_contract::closure3((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Chat_contract::Mut0>,
                LrcPtr<Chat_contract::Mut1>,
                LrcPtr<Chat_contract::Mut2>,
                LrcPtr<Chat_contract::Mut3>,
                LrcPtr<Chat_contract::Mut4>,
                Option<i64>,
            ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
            let v36: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Chat_contract::Mut0> = patternInput_1.0.clone();
                let v83: string = Chat_contract::method14(
                    Chat_contract::method6(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Chat_contract::method10(),
                    string("chat_contract.get_account_info"),
                    v57.l0.get().clone(),
                    Chat_contract::method21(v0_1, v1),
                );
                let v85: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                Chat_contract::method15(
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
        pub fn closure17(unitVar: (), unitVar_1: ()) {
            fn v1() {
                Chat_contract::closure3((), ());
            }
            let v2: () = {
                v1();
                ()
            };
            let patternInput: (
                LrcPtr<Chat_contract::Mut0>,
                LrcPtr<Chat_contract::Mut1>,
                LrcPtr<Chat_contract::Mut2>,
                LrcPtr<Chat_contract::Mut3>,
                LrcPtr<Chat_contract::Mut4>,
                Option<i64>,
            ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
            let v34: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v34,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v41: () = {
                    v1();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                let v73: string = Chat_contract::method6(
                    patternInput_1.0.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                );
                let v74: string = Chat_contract::method10();
                let v76: () = {
                    v1();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                Chat_contract::method20(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method22(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v9: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", string("alias")), ());
                ()
            };
            let v27: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v40: std::string::String = format!("{:#?}", v0_1);
            let v62: () = {
                Chat_contract::closure7(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v40)),
                    (),
                );
                ()
            };
            let v71: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure18(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Chat_contract::closure3((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Chat_contract::Mut0>,
                LrcPtr<Chat_contract::Mut1>,
                LrcPtr<Chat_contract::Mut2>,
                LrcPtr<Chat_contract::Mut3>,
                LrcPtr<Chat_contract::Mut4>,
                Option<i64>,
            ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
            let v35: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Chat_contract::Mut0> = patternInput_1.0.clone();
                let v82: string = Chat_contract::method14(
                    Chat_contract::method6(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Chat_contract::method10(),
                    string("chat_contract.get_alias_map"),
                    v56.l0.get().clone(),
                    Chat_contract::method22(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                Chat_contract::method15(
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
        pub fn method23() -> Func0<()> {
            Func0::new(move || Chat_contract::closure14((), ()))
        }
        pub fn closure19(v0_1: Func0<()>, unitVar: ()) {
            fn v2() {
                Chat_contract::closure3((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Chat_contract::Mut0>,
                LrcPtr<Chat_contract::Mut1>,
                LrcPtr<Chat_contract::Mut2>,
                LrcPtr<Chat_contract::Mut3>,
                LrcPtr<Chat_contract::Mut4>,
                Option<i64>,
            ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
            let v35: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                let v74: string = Chat_contract::method6(
                    patternInput_1.0.clone(),
                    patternInput_1.1.clone(),
                    patternInput_1.2.clone(),
                    patternInput_1.3.clone(),
                    patternInput_1.4.clone(),
                    patternInput_1.5.clone(),
                );
                let v75: string = Chat_contract::method10();
                let v77: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Chat_contract::Mut0>,
                    LrcPtr<Chat_contract::Mut1>,
                    LrcPtr<Chat_contract::Mut2>,
                    LrcPtr<Chat_contract::Mut3>,
                    LrcPtr<Chat_contract::Mut4>,
                    Option<i64>,
                ) = getValue(Chat_contract::TraceState::trace_state().get().clone());
                Chat_contract::method20(
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        #[near_sdk::near_bindgen] //;
        #[derive(
            //;
            near_sdk::PanicOnDefault, //;
            borsh::BorshDeserialize,  //;
            borsh::BorshSerialize,    //;
        )] //;
        pub struct State(
            //;
            /*;
            {
                let v9:
                        */
            (
                u32,
                near_sdk::store::LookupMap<
                    std::string::String,
                    std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                >,
                near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
            ), /* =
                  defaultOf::<()>();
               */
        );
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[init] //;
            pub fn new() -> Self {
                // 1;
                {
                    let v18: bool = true; /*;
                                          let v19: */
                    () /* = defaultOf();
                    let v23: bool = true; */;
                    let v25: string = string("b\"alias_map\"");
                    let v26: &[u8] = b"alias_map";
                    let v28: near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = near_sdk::store::LookupMap::new(v26);
                    let v30: string = string("b\"account_map\"");
                    let v31: &[u8] = b"account_map";
                    {
                        let x: (
                            u32,
                            near_sdk::store::LookupMap<
                                std::string::String,
                                std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                            >,
                            near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        ) = (1_u32, v28, near_sdk::store::LookupMap::new(v31));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
          {
              let v38: bool =
                  true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
              let v40: bool =
                  true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            fn is_valid_alias(alias: String) -> bool {
                //;
                {
                    let v45: std::string::String = alias;
                    let v47: string = fable_library_rust::String_::fromString(v45);
                    let v48: i32 = length(v47.clone());
                    {
                        let x_1: bool = if v48 > 0_i32 {
                            if v48 < 64_i32 {
                                if startsWith(v47.clone(), string("-"), false) == false {
                                    if endsWith(v47.clone(), string("-"), false) == false {
                                        let v64: &str = &*v47;
                                        let v80 = v64.chars();
                                        let v82: bool = true; // 1;
                                        let mut v80 = v80;
                                        v80.all(|x| {
                                            Func1::new(move |v: char| {
                                                Chat_contract::closure1((), v)
                                            })(x)
                                        })
                                    } else {
                                        false
                                    }
                                } else {
                                    false
                                }
                            } else {
                                false
                            }
                        } else {
                            false
                        };
                        x_1
                    }
                }
            } //;
        } /* c;
          {
              let v94: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy;
              let v96: bool =
                  true; */
 // ???? / i: 2uy / i': 2uy / acc: 2uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn generate_cid(
                //;
                &self,            //;
                content: Vec<u8>, //;
            ) -> String {
                //;
                {
                    let v104: Vec<u8> = content;
                    fn encode_u64(value: u64) -> Vec<u8> {
                        //;
                        let mut buffer = unsigned_varint::encode::u64_buffer(); //;
                        unsigned_varint::encode::u64(value, &mut buffer).to_vec()
                        //;
                    } //;
                    fn sha256_hash(content: &[u8]) -> Vec<u8> {
                        //;
                        let mut hasher: sha2::Sha256 = sha2::Digest::new(); //;
                        sha2::Digest::update(&mut hasher, content); //;
                        sha2::Digest::finalize(hasher).to_vec() //;
                    } //;
                    let version: u8 = 1; //;
                    let codec_raw: u64 = 0x55; //;
                    let codec_bytes = encode_u64(codec_raw); //;
                    let hash_result = sha256_hash(&v104); //;
                    let multihash = std::iter::once(0x12) //;
                        .chain(std::iter::once(32)) //;
                        .chain(hash_result.into_iter()) //;
                        .collect(); //;
                    let cid_bytes = [vec![version], codec_bytes, multihash].concat(); //;
                    let result = multibase::encode(multibase::Base::Base32Lower, &cid_bytes); //;
                    {
                        let x_2: std::string::String = result;
                        x_2
                    }
                }
            } //;
        } /* c;
          {
              let v129: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy;
              let v131: bool =
                  true; */
 // ???? / i: 3uy / i': 2uy / acc: 3uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[result_serializer(borsh)] //;
            pub fn generate_cid_borsh(
                //;
                &self,                                 //;
                #[serializer(borsh)] content: Vec<u8>, //;
            ) -> String {
                //;
                self.generate_cid(content) //;
            } //;
        } /* c;
          {
              let v143: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy;
              let v145: bool =
                  true; */
 // ???? / i: 4uy / i': 2uy / acc: 5uy / n: 1uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn claim_alias(
                //;
                &mut self,     //;
                alias: String, //;
            ) {
                //;
                {
                    let v153: &mut (
                        u32,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                    ) = &mut self.0;
                    let v155: std::string::String = alias;
                    let v157: &mut near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &mut v153.2;
                    let v159: &mut near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &mut v153.1;
                    let v161: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v163: u64 = near_sdk::env::block_timestamp();
                    let v166: () = {
                        Chat_contract::closure2(v155.clone(), v161.clone(), v163, ());
                        ()
                    };
                    let v285: string = fable_library_rust::String_::fromString(v155.clone());
                    let v286: i32 = length(v285.clone());
                    let v333: bool = if (if v286 > 0_i32 {
                        if v286 < 64_i32 {
                            if startsWith(v285.clone(), string("-"), false) == false {
                                if endsWith(v285.clone(), string("-"), false) == false {
                                    let v302: &str = &*v285;
                                    let v318 = v302.chars();
                                    let v320: bool = true; // 1;
                                    let mut v318 = v318;
                                    v318.all(|x| {
                                        Func1::new(move |v_1: char| {
                                            Chat_contract::closure1((), v_1)
                                        })(x)
                                    })
                                } else {
                                    false
                                }
                            } else {
                                false
                            }
                        } else {
                            false
                        }
                    } else {
                        false
                    }) == false
                    {
                        let v332: bool = true;
                        near_sdk::env::panic_str(&*string(
                            "chat_contract.claim_alias / invalid alias",
                        )); //;
                        true
                    } else {
                        false
                    };
                    let v335: Option<&std::string::String> = v157.get(&v161.clone());
                    let v337: Option<std::string::String> = v335.cloned();
                    let v351: Chat_contract::US4 = defaultValue(
                        Chat_contract::US4::US4_1,
                        map(Chat_contract::method16(), v337.clone()),
                    );
                    if let Chat_contract::US4::US4_0(v351_0_0) = &v351 {
                        let v355: std::string::String = match &v351 {
                            Chat_contract::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if referenceEquals(&v355, &v155) {
                            let v361: () = {
                                Chat_contract::closure12(v355, ());
                                ()
                            };
                            ()
                        } else {
                            let v482: () = {
                                Chat_contract::closure13(v337.clone(), ());
                                ()
                            };
                            v159 //;
                                .get_mut(&v355) //;
                                .unwrap() //;
                                .remove(&v161.clone()); //;
                            v157.insert(v161.clone().clone(), v155.clone()); //;
                            let new_alias_account_map = match v159.get(&v155) {
                                //;
                                None => {
                                    //;
                                    let mut new_map = std::collections::HashMap::new(); //;
                                    new_map.insert(v161.clone(), (v163, 0u32)); //;
                                    new_map //;
                                } //;
                                Some(accounts) => {
                                    //;
                                    let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //;
                                    accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //;
                                    let mut new_map = accounts_vec //;
                                                                .iter() //;
                                                                .enumerate() //;
                                                                .map(|(i, (account_id, (timestamp, _)))| { //;
                                                                  ((*account_id).clone(), (*timestamp, i as u32)) //;
                                                                }) //;
                                                                .collect::<std::collections::HashMap<_, _>>(); //;
                                    new_map.insert(v161, (v163, accounts_vec.len() as u32)); //;
                                    new_map //;
                                } //;
                            }; //;
                            v159.insert(v155, new_alias_account_map); //;
                            ()
                        }
                    } else {
                        let v629: () = {
                            Chat_contract::closure13(v337, ());
                            ()
                        };
                        if let Chat_contract::US4::US4_1 = &v351 {
                            ()
                        } else {
                            panic!("{}", string("Match failure"),)
                        }
                        v157.insert(v161.clone().clone(), v155.clone()); //;
                        let new_alias_account_map = match v159.get(&v155) {
                            //;
                            None => {
                                //;
                                let mut new_map = std::collections::HashMap::new(); //;
                                new_map.insert(v161, (v163, 0u32)); //;
                                new_map //;
                            } //;
                            Some(accounts) => {
                                //;
                                let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //;
                                accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //;
                                let mut new_map = accounts_vec //;
                                                            .iter() //;
                                                            .enumerate() //;
                                                            .map(|(i, (account_id, (timestamp, _)))| { //;
                                                              ((*account_id).clone(), (*timestamp, i as u32)) //;
                                                            }) //;
                                                            .collect::<std::collections::HashMap<_, _>>(); //;
                                new_map.insert(v161, (v163, accounts_vec.len() as u32)); //;
                                new_map //;
                            } //;
                        }; //;
                        v159.insert(v155, new_alias_account_map); //;
                        ()
                    }
                    {
                        let v773: () = {
                            Chat_contract::closure15(Chat_contract::method19(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v887: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy;
              let v889: bool =
                  true; */
 // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn get_account_info(
                //;
                &self,                           //;
                account_id: near_sdk::AccountId, //;
            ) -> Option<(String, u64, u32)> {
                //;
                {
                    let v897: &(
                        u32,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                    ) = &self.0;
                    let v899: near_sdk::AccountId = account_id;
                    let v901: &near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &v897.2;
                    let v903: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &v897.1;
                    let result = v901.get(&v899.clone()).and_then(|alias| {
                        //;
                        v903 //;
                            .get(alias) //;
                            .map(|accounts| {
                                //;
                                let result = (alias.clone(), *accounts.get(&v899).unwrap()); //;
                                (result.0, result.1 .0, result.1 .1) //;
                            }) //;
                    }); //;
                    {
                        let v913: Option<(std::string::String, u64, u32)> = result;
                        let v916: () = {
                            Chat_contract::closure16(v899, v913.clone(), ());
                            ()
                        };
                        let v1034: () = {
                            Chat_contract::closure17((), ());
                            ()
                        };
                        v913
                    } // 4;
                } // 2;
            } // 1;
        } /* c;
          {
              let v1147:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy;
              let v1149:
                      bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn get_alias_map(
                //;
                &self,         //;
                alias: String, //;
            ) -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> {
                //;
                {
                    let v1157: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0 .1;
                    let v1159: std::string::String = alias;
                    let v1162: () = {
                        Chat_contract::closure18(v1159.clone(), ());
                        ()
                    };
                    let v1281: () = {
                        Chat_contract::closure19(Chat_contract::method23(), ());
                        ()
                    };
                    v1157.get(&v1159).cloned() //;
                } //;
            } //;
        } /* c;
          {
              let v1395:
                      bool =
                  true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy;
              let v1397:
                      bool =
                  true; */
 // ???? / i: 7uy / i': 2uy / acc: 11uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[result_serializer(borsh)] //;
            pub fn get_alias_map_borsh(
                //;
                &self,                              //;
                #[serializer(borsh)] alias: String, //;
            ) -> Option<std::collections::HashMap<near_sdk::AccountId, (u64, u32)>> {
                //;
                self.get_alias_map(alias) //;
            } //;
        } /* c;
          {
              let v1409:
                      bool =
                  true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy;
              let v1411:
                      bool =
                  true; */
 // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy;
        fn _main() //;
        {
            {
                //;
                {
                    let v1415: bool = true;
                    {
                        (); // ?? / i': 1uy / n: 14uy;
                        let v1417: bool = true;
                        {
                            (); // ?? / i': 2uy / n: 14uy;
                            let v1419: bool = true;
                            {
                                (); // ?? / i': 3uy / n: 14uy;
                                let v1421: bool = true;
                                {
                                    (); // ?? / i': 4uy / n: 14uy;
                                    let v1423: bool = true;
                                    {
                                        (); // ?? / i': 5uy / n: 14uy;
                                        let v1425: bool = true;
                                        {
                                            (); // ?? / i': 6uy / n: 14uy;
                                            let v1427: bool = true;
                                            {
                                                (); // ?? / i': 7uy / n: 14uy;
                                                let v1429: bool = true;
                                                {
                                                    (); // ?? / i': 8uy / n: 14uy;
                                                    let v1431: bool = true;
                                                    {
                                                        (); // ?? / i': 9uy / n: 14uy;
                                                        let v1433: bool = true;
                                                        {
                                                            (); // ?? / i': 10uy / n: 14uy;
                                                            let v1435: bool = true;
                                                            {
                                                                (); // ?? / i': 11uy / n: 14uy;
                                                                let v1437: bool = true;
                                                                {
                                                                    (); // ?? / i': 12uy / n: 14uy;
                                                                    let v1439: bool = true;
                                                                    {
                                                                        (); // ?? / i': 13uy / n: 14uy;
                                                                        let v1441: bool = true;
                                                                        {
                                                                            (); // ?? / i': 14uy / n: 14uy;
                                                                            let v1443: bool = true;
                                                                            {
                                                                                {
                                                                                    (); // ? / i': 15uy / n: 14uy;
                                                                                    ()
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
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Chat_contract::closure0((), ())))
                .clone()
        }
        on_startup!(());
    }
}
pub use module_31a2fc18::*;
#[path = "../../../lib/fsharp/Common_contract.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../../lib/spiral/async__contract.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../../lib/spiral/common_contract.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../../lib/spiral/crypto_contract.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../../lib/spiral/date_time_contract.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../../lib/spiral/file_system_contract.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../../lib/spiral/lib_contract.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../../lib/spiral/networking_contract.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../../lib/spiral/platform_contract.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../../lib/spiral/runtime_contract.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../../lib/spiral/sm_contract.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../../lib/spiral/threading_contract.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../../lib/spiral/trace_contract.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
