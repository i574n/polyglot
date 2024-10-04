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
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::length;
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
        pub fn method2() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method4() -> string {
            string("")
        }
        pub fn closure4(unitVar: (), v0_1: string) -> Chat_contract::US1 {
            Chat_contract::US1::US1_0(v0_1)
        }
        pub fn method5() -> Func1<string, Chat_contract::US1> {
            Func1::new(move |v: string| Chat_contract::closure4((), v))
        }
        pub fn method3(v0_1: string) -> string {
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
            let v44: string = Chat_contract::method4();
            v43.unwrap_or(v44)
        }
        pub fn method6() -> string {
            string("AUTOMATION")
        }
        pub fn closure5(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(
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
                ) = Chat_contract::method1(Chat_contract::US0::US0_0);
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
        pub fn method0(v0_1: Chat_contract::US0) -> bool {
            let v3: () = {
                Chat_contract::closure3((), ());
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
            if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                    ])))),
                ) >= find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                    ])))),
                )
            }
        }
        pub fn closure6(unitVar: (), v0_1: i64) -> Chat_contract::US3 {
            Chat_contract::US3::US3_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Chat_contract::US3> {
            Func1::new(move |v: i64| Chat_contract::closure6((), v))
        }
        pub fn method9() -> string {
            string("hh:mm:ss")
        }
        pub fn method10() -> string {
            string("HH:mm:ss")
        }
        pub fn method7(
            v0_1: LrcPtr<Chat_contract::Mut0>,
            v1: LrcPtr<Chat_contract::Mut1>,
            v2: LrcPtr<Chat_contract::Mut2>,
            v3: LrcPtr<Chat_contract::Mut3>,
            v4: LrcPtr<Chat_contract::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v130: u64 = near_sdk::env::block_timestamp();
            let v144: Chat_contract::US3 =
                defaultValue(Chat_contract::US3::US3_1, map(Chat_contract::method8(), v5));
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
        pub fn method13() -> string {
            string("")
        }
        pub fn closure7(v0_1: LrcPtr<Chat_contract::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method12(v0_1: char) -> string {
            let v2: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v8: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v6: string = Chat_contract::method12(getCharAt(toLower(string("Debug")), 0_i32));
            let v67: &str = inline_colorization::color_bright_blue;
            let v74: &str = &*v6;
            let v90: &str = inline_colorization::color_reset;
            let v92: std::string::String = format!("{}{}{}", v67, v74, v90);
            fable_library_rust::String_::fromString(v92)
        }
        pub fn method16(
            v0_1: std::string::String,
            v1: u64,
            v2: std::string::String,
            v3: std::string::String,
        ) -> string {
            let v5: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v12: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string("alias")), ());
                ()
            };
            let v30: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v43: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v43)),
                    (),
                );
                ()
            };
            let v74: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v83: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string("block_timestamp")), ());
                ()
            };
            let v91: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v99: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v107: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v116: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    sprintf!("{}", string("signer_account_id")),
                    (),
                );
                ()
            };
            let v124: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v137: std::string::String = format!("{:#?}", v2);
            let v159: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v137)),
                    (),
                );
                ()
            };
            let v167: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v176: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    sprintf!("{}", string("predecessor_account_id")),
                    (),
                );
                ()
            };
            let v184: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v197: std::string::String = format!("{:#?}", v3);
            let v219: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v197)),
                    (),
                );
                ()
            };
            let v228: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method17(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method15(
            v0_1: LrcPtr<Chat_contract::Mut0>,
            v1: LrcPtr<Chat_contract::Mut1>,
            v2: LrcPtr<Chat_contract::Mut2>,
            v3: LrcPtr<Chat_contract::Mut3>,
            v4: LrcPtr<Chat_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
            v9: u64,
            v10: std::string::String,
            v11: std::string::String,
        ) -> string {
            let v12: string = Chat_contract::method16(v8, v9, v10, v11);
            Chat_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("chat_contract.claim_alias"),
                v12
            ))
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
        pub fn method18(v0_1: string) {
            let v3: () = {
                Chat_contract::closure3((), ());
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
            let v20: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v37: () = {
                Chat_contract::closure8(patternInput.0.clone(), ());
                ()
            };
            let v53: string = if v20.l0.get().clone() == string("") {
                v0_1.clone()
            } else {
                if v0_1.clone() == string("") {
                    v20.l0.get().clone()
                } else {
                    append(append(v20.l0.get().clone(), string("\n")), v0_1.clone())
                }
            };
            let v60: &str = &*v53.clone();
            let v76 = v60.chars();
            let v78 = v76;
            let v80: Vec<char> = v78.collect::<Vec<_>>();
            let v82: Vec<Vec<char>> = v80
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v84: bool = true;
            let _vec_map: Vec<_> = v82
                .into_iter()
                .map(|x| {
                    //;
                    let v86: Vec<char> = x;
                    let v88: std::string::String = String::from_iter(v86);
                    let v90: bool = true;
                    v88
                })
                .collect::<Vec<_>>();
            let v92: Vec<std::string::String> = _vec_map;
            if if v0_1.clone() != string("") {
                v92.clone().len() as i32 <= 1_i32
            } else {
                false
            } {
                v20.l0.set(v53);
                ()
            } else {
                v20.l0.set(string(""));
                {
                    let v104: bool = true;
                    v92.into_iter().for_each(|x| {
                        //;
                        let v106: std::string::String = x;
                        let v108: bool = true;
                        near_sdk::log!("{}", v106);
                        let v110: bool = true;
                        let v112: bool = true;
                    }); //;
                    ()
                }
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure2(
            v0_1: std::string::String,
            v1: near_sdk::AccountId,
            v2: near_sdk::AccountId,
            v3: u64,
            unitVar: (),
        ) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v8: () = {
                    Chat_contract::closure3((), ());
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
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method15(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Chat_contract::method7(v22, v23, v24, v25, v26, v27),
                    Chat_contract::method11(),
                    v0_1,
                    v3,
                    v1.to_string(),
                    v2.to_string(),
                ))
            };
        }
        pub fn closure11(unitVar: (), v0_1: std::string::String) -> Chat_contract::US4 {
            Chat_contract::US4::US4_0(v0_1)
        }
        pub fn method19() -> Func1<std::string::String, Chat_contract::US4> {
            Func1::new(move |v: std::string::String| Chat_contract::closure11((), v))
        }
        pub fn method20() -> string {
            let v6: string = Chat_contract::method12(getCharAt(toLower(string("Warning")), 0_i32));
            let v67: &str = inline_colorization::color_yellow;
            let v74: &str = &*v6;
            let v90: &str = inline_colorization::color_reset;
            let v92: std::string::String = format!("{}{}{}", v67, v74, v90);
            fable_library_rust::String_::fromString(v92)
        }
        pub fn method22(v0_1: string) -> string {
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
        pub fn method21(
            v0_1: LrcPtr<Chat_contract::Mut0>,
            v1: LrcPtr<Chat_contract::Mut1>,
            v2: LrcPtr<Chat_contract::Mut2>,
            v3: LrcPtr<Chat_contract::Mut3>,
            v4: LrcPtr<Chat_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Chat_contract::method22(v8);
            Chat_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("chat_contract.claim_alias / alias already claimed"),
                v9
            ))
        }
        pub fn closure12(v0_1: std::string::String, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_3) {
                let v5: () = {
                    Chat_contract::closure3((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method21(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Chat_contract::method7(v19, v20, v21, v22, v23, v24),
                    Chat_contract::method20(),
                    sprintf!("{:?}", v0_1),
                ))
            };
        }
        pub fn method23(
            v0_1: LrcPtr<Chat_contract::Mut0>,
            v1: LrcPtr<Chat_contract::Mut1>,
            v2: LrcPtr<Chat_contract::Mut2>,
            v3: LrcPtr<Chat_contract::Mut3>,
            v4: LrcPtr<Chat_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Chat_contract::method22(v8);
            Chat_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("chat_contract.claim_alias"),
                v9
            ))
        }
        pub fn closure13(v0_1: Option<std::string::String>, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v5: () = {
                    Chat_contract::closure3((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method23(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Chat_contract::method7(v19, v20, v21, v22, v23, v24),
                    Chat_contract::method11(),
                    sprintf!("{:?}", v0_1),
                ))
            };
        }
        pub fn closure14(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method24() -> Func0<()> {
            Func0::new(move || Chat_contract::closure14((), ()))
        }
        pub fn method25() {
            let v2: () = {
                Chat_contract::closure3((), ());
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
            let v19: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v36: () = {
                Chat_contract::closure8(patternInput.0.clone(), ());
                ()
            };
            let v53: string = if v19.l0.get().clone() == string("") {
                string("")
            } else {
                v19.l0.get().clone()
            };
            let v60: &str = &*v53;
            let v76 = v60.chars();
            let v78 = v76;
            let v80: Vec<char> = v78.collect::<Vec<_>>();
            let v82: Vec<Vec<char>> = v80
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v84: bool = true;
            let _vec_map: Vec<_> = v82
                .into_iter()
                .map(|x| {
                    //;
                    let v86: Vec<char> = x;
                    let v88: std::string::String = String::from_iter(v86);
                    let v90: bool = true;
                    v88
                })
                .collect::<Vec<_>>();
            let v92: Vec<std::string::String> = _vec_map;
            v19.l0.set(string(""));
            {
                let v103: bool = true;
                v92.into_iter().for_each(|x| {
                    //;
                    let v105: std::string::String = x;
                    let v107: bool = true;
                    near_sdk::log!("{}", v105);
                    let v109: bool = true;
                    let v111: bool = true;
                }); //;
                ()
            }
            ();
            ((patternInput.1.clone()).l0.get().clone())(string(""))
        }
        pub fn closure15(v0_1: Func0<()>, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v5: () = {
                    Chat_contract::closure3((), ());
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
                let v37: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v38: string = Chat_contract::method11();
                Chat_contract::method25()
            };
        }
        pub fn method27(
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
        pub fn method26(
            v0_1: LrcPtr<Chat_contract::Mut0>,
            v1: LrcPtr<Chat_contract::Mut1>,
            v2: LrcPtr<Chat_contract::Mut2>,
            v3: LrcPtr<Chat_contract::Mut3>,
            v4: LrcPtr<Chat_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: near_sdk::AccountId,
            v9: Option<(std::string::String, u64, u32)>,
        ) -> string {
            let v10: string = Chat_contract::method27(v8, v9);
            Chat_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("chat_contract.get_account_info"),
                v10
            ))
        }
        pub fn closure16(
            v0_1: near_sdk::AccountId,
            v1: Option<(std::string::String, u64, u32)>,
            unitVar: (),
        ) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v6: () = {
                    Chat_contract::closure3((), ());
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
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method26(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Chat_contract::method7(v20, v21, v22, v23, v24, v25),
                    Chat_contract::method11(),
                    v0_1,
                    v1,
                ))
            };
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v4: () = {
                    Chat_contract::closure3((), ());
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
                let v36: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v37: string = Chat_contract::method11();
                Chat_contract::method25()
            };
        }
        pub fn method29(v0_1: std::string::String) -> string {
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
        pub fn method28(
            v0_1: LrcPtr<Chat_contract::Mut0>,
            v1: LrcPtr<Chat_contract::Mut1>,
            v2: LrcPtr<Chat_contract::Mut2>,
            v3: LrcPtr<Chat_contract::Mut3>,
            v4: LrcPtr<Chat_contract::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: std::string::String,
        ) -> string {
            let v10: string = Chat_contract::method29(v9);
            Chat_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v10
            ))
        }
        pub fn closure18(v0_1: std::string::String, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v5: () = {
                    Chat_contract::closure3((), ());
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
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method28(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Chat_contract::method7(v19, v20, v21, v22, v23, v24),
                    Chat_contract::method11(),
                    string("chat_contract.get_alias_map"),
                    v0_1,
                ))
            };
        }
        pub fn method30() -> Func0<()> {
            Func0::new(move || Chat_contract::closure14((), ()))
        }
        pub fn closure19(v0_1: Func0<()>, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v5: () = {
                    Chat_contract::closure3((), ());
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
                let v37: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v38: string = Chat_contract::method11();
                Chat_contract::method25()
            };
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
                near_sdk::store::IterableSet<near_sdk::AccountId>,
                near_sdk::store::IterableSet<std::string::String>,
                near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                near_sdk::store::LookupMap<
                    std::string::String,
                    std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                >,
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
                    let v25: string = string("b\"account_set\"");
                    let v26: &[u8] = b"account_set";
                    let v28: near_sdk::store::IterableSet<near_sdk::AccountId> =
                        near_sdk::store::IterableSet::new(v26);
                    let v30: string = string("b\"alias_set\"");
                    let v31: &[u8] = b"alias_set";
                    let v33: near_sdk::store::IterableSet<std::string::String> =
                        near_sdk::store::IterableSet::new(v31);
                    let v35: string = string("b\"account_map\"");
                    let v36: &[u8] = b"account_map";
                    let v38: near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String> =
                        near_sdk::store::LookupMap::new(v36);
                    let v40: string = string("b\"alias_map\"");
                    let v41: &[u8] = b"alias_map";
                    {
                        let x: (
                            u32,
                            near_sdk::store::IterableSet<near_sdk::AccountId>,
                            near_sdk::store::IterableSet<std::string::String>,
                            near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                            near_sdk::store::LookupMap<
                                std::string::String,
                                std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                            >,
                        ) = (2_u32, v28, v33, v38, near_sdk::store::LookupMap::new(v41));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
          {
              let v48: bool =
                  true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
              let v50: bool =
                  true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            fn is_valid_alias(alias: String) -> bool {
                //;
                {
                    let v55: std::string::String = alias;
                    let v57: string = fable_library_rust::String_::fromString(v55);
                    let v58: i32 = length(v57.clone());
                    {
                        let x_1: bool = if v58 > 0_i32 {
                            if v58 < 64_i32 {
                                if startsWith(v57.clone(), string("-"), false) == false {
                                    if endsWith(v57.clone(), string("-"), false) == false {
                                        let v74: &str = &*v57;
                                        let v90 = v74.chars();
                                        let v92: bool = true; // 1;
                                        let mut v90 = v90;
                                        v90.all(|x| {
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
              let v104: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy;
              let v106: bool =
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
                    let v114: Vec<u8> = content;
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
                    let hash_result = sha256_hash(&v114); //;
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
              let v139: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy;
              let v141: bool =
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
              let v153: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy;
              let v155: bool =
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
                    let v163: &mut (
                        u32,
                        near_sdk::store::IterableSet<near_sdk::AccountId>,
                        near_sdk::store::IterableSet<std::string::String>,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                    ) = &mut self.0;
                    let v165: std::string::String = alias;
                    let v167: &mut near_sdk::store::IterableSet<near_sdk::AccountId> = &mut v163.1;
                    let v169: &mut near_sdk::store::IterableSet<std::string::String> = &mut v163.2;
                    let v171: &mut near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &mut v163.3;
                    let v173: &mut near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &mut v163.4;
                    let v175: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v177: near_sdk::AccountId = near_sdk::env::predecessor_account_id();
                    let v179: u64 = near_sdk::env::block_timestamp();
                    let v182: () = {
                        Chat_contract::closure2(v165.clone(), v175.clone(), v177, v179, ());
                        ()
                    };
                    let v227: string = fable_library_rust::String_::fromString(v165.clone());
                    let v228: i32 = length(v227.clone());
                    let v275: bool = if (if v228 > 0_i32 {
                        if v228 < 64_i32 {
                            if startsWith(v227.clone(), string("-"), false) == false {
                                if endsWith(v227.clone(), string("-"), false) == false {
                                    let v244: &str = &*v227;
                                    let v260 = v244.chars();
                                    let v262: bool = true; // 1;
                                    let mut v260 = v260;
                                    v260.all(|x| {
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
                        let v274: bool = true;
                        near_sdk::env::panic_str(&*string(
                            "chat_contract.claim_alias / invalid alias",
                        )); //;
                        true
                    } else {
                        false
                    };
                    let v277: Option<&std::string::String> = v171.get(&v175.clone());
                    let v279: Option<std::string::String> = v277.cloned();
                    let v293: Chat_contract::US4 = defaultValue(
                        Chat_contract::US4::US4_1,
                        map(Chat_contract::method19(), v279.clone()),
                    );
                    if let Chat_contract::US4::US4_0(v293_0_0) = &v293 {
                        let v297: std::string::String = match &v293 {
                            Chat_contract::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if referenceEquals(&v297, &v165) {
                            let v303: () = {
                                Chat_contract::closure12(v297, ());
                                ()
                            };
                            ()
                        } else {
                            let v348: () = {
                                Chat_contract::closure13(v279.clone(), ());
                                ()
                            };
                            v173 //;
                                .get_mut(&v297) //;
                                .unwrap() //;
                                .remove(&v175.clone()); //;
                            v171.insert(v175.clone().clone(), v165.clone().clone()); //;
                            {
                                let v397: bool = v167.insert(v175.clone());
                                let v399: bool = v169.insert(v165.clone());
                                let new_alias_account_map = match v173.get(&v165.clone()) {
                                    //;
                                    None => {
                                        //;
                                        let mut new_map = std::collections::HashMap::new(); //;
                                        new_map.insert(v175.clone(), (v179, 0u32)); //;
                                        new_map //;
                                    } //;
                                    Some(accounts) => {
                                        //;
                                        let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //;
                                        accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //;
                                        let mut new_map = accounts_vec //;
                                                                    .iter() //;
                                                                    .enumerate() //;
                                                                    .map(|(i, (signer_account_id, (timestamp, _)))| { //;
                                                                      ((*signer_account_id).clone(), (*timestamp, i as u32)) //;
                                                                    }) //;
                                                                    .collect::<std::collections::HashMap<_, _>>(); //;
                                        new_map.insert(
                                            v175.clone(),
                                            (v179, accounts_vec.len() as u32),
                                        ); //;
                                        new_map //;
                                    } //;
                                }; //;
                                v173.insert(v165.clone(), new_alias_account_map); //;
                                ()
                            }
                        }
                    } else {
                        let v423: () = {
                            Chat_contract::closure13(v279, ());
                            ()
                        };
                        if let Chat_contract::US4::US4_1 = &v293 {
                            ()
                        } else {
                            panic!("{}", string("Match failure"),)
                        }
                        v171.insert(v175.clone().clone(), v165.clone().clone()); //;
                        {
                            let v468: bool = v167.insert(v175.clone());
                            let v470: bool = v169.insert(v165.clone());
                            let new_alias_account_map = match v173.get(&v165.clone()) {
                                //;
                                None => {
                                    //;
                                    let mut new_map = std::collections::HashMap::new(); //;
                                    new_map.insert(v175.clone(), (v179, 0u32)); //;
                                    new_map //;
                                } //;
                                Some(accounts) => {
                                    //;
                                    let mut accounts_vec = accounts.iter().collect::<Vec<_>>(); //;
                                    accounts_vec.sort_unstable_by_key(|(_, (_, index))| index); //;
                                    let mut new_map = accounts_vec //;
                                                                .iter() //;
                                                                .enumerate() //;
                                                                .map(|(i, (signer_account_id, (timestamp, _)))| { //;
                                                                  ((*signer_account_id).clone(), (*timestamp, i as u32)) //;
                                                                }) //;
                                                                .collect::<std::collections::HashMap<_, _>>(); //;
                                    new_map.insert(v175, (v179, accounts_vec.len() as u32)); //;
                                    new_map //;
                                } //;
                            }; //;
                            v173.insert(v165, new_alias_account_map); //;
                            ()
                        }
                    }
                    {
                        let v495: () = {
                            Chat_contract::closure15(Chat_contract::method24(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v539: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy;
              let v541: bool =
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
                    let v549: &(
                        u32,
                        near_sdk::store::IterableSet<near_sdk::AccountId>,
                        near_sdk::store::IterableSet<std::string::String>,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                    ) = &self.0;
                    let v551: near_sdk::AccountId = account_id;
                    let v553: &near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &v549.3;
                    let v555: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &v549.4;
                    let result = v553.get(&v551.clone()).and_then(|alias| {
                        //;
                        v555 //;
                            .get(alias) //;
                            .map(|accounts| {
                                //;
                                let result = (alias.clone(), *accounts.get(&v551).unwrap()); //;
                                (result.0, result.1 .0, result.1 .1) //;
                            }) //;
                    }); //;
                    {
                        let v565: Option<(std::string::String, u64, u32)> = result;
                        let v568: () = {
                            Chat_contract::closure16(v551, v565.clone(), ());
                            ()
                        };
                        let v610: () = {
                            Chat_contract::closure17((), ());
                            ()
                        };
                        v565
                    } // 4;
                } // 2;
            } // 1;
        } /* c;
          {
              let v653:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy;
              let v655:
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
                    let v663: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0 .4;
                    let v665: std::string::String = alias;
                    let v668: () = {
                        Chat_contract::closure18(v665.clone(), ());
                        ()
                    };
                    let v715: () = {
                        Chat_contract::closure19(Chat_contract::method30(), ());
                        ()
                    };
                    v663.get(&v665).cloned() //;
                } //;
            } //;
        } /* c;
          {
              let v759:
                      bool =
                  true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy;
              let v761:
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
              let v773:
                      bool =
                  true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy;
              let v775:
                      bool =
                  true; */
 // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy;
        fn _main() //;
        {
            {
                //;
                {
                    let v779: bool = true;
                    {
                        (); // ?? / i': 1uy / n: 14uy;
                        let v781: bool = true;
                        {
                            (); // ?? / i': 2uy / n: 14uy;
                            let v783: bool = true;
                            {
                                (); // ?? / i': 3uy / n: 14uy;
                                let v785: bool = true;
                                {
                                    (); // ?? / i': 4uy / n: 14uy;
                                    let v787: bool = true;
                                    {
                                        (); // ?? / i': 5uy / n: 14uy;
                                        let v789: bool = true;
                                        {
                                            (); // ?? / i': 6uy / n: 14uy;
                                            let v791: bool = true;
                                            {
                                                (); // ?? / i': 7uy / n: 14uy;
                                                let v793: bool = true;
                                                {
                                                    (); // ?? / i': 8uy / n: 14uy;
                                                    let v795: bool = true;
                                                    {
                                                        (); // ?? / i': 9uy / n: 14uy;
                                                        let v797: bool = true;
                                                        {
                                                            (); // ?? / i': 10uy / n: 14uy;
                                                            let v799: bool = true;
                                                            {
                                                                (); // ?? / i': 11uy / n: 14uy;
                                                                let v801: bool = true;
                                                                {
                                                                    (); // ?? / i': 12uy / n: 14uy;
                                                                    let v803: bool = true;
                                                                    {
                                                                        (); // ?? / i': 13uy / n: 14uy;
                                                                        let v805: bool = true;
                                                                        {
                                                                            (); // ?? / i': 14uy / n: 14uy;
                                                                            let v807: bool = true;
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
