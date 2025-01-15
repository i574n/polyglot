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
#![allow(unused_assignments)]
mod module_31a2fc18 {
    pub mod Chat_contract {
        use super::*;
        type DateTime = ();
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::Native_::getZero;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::referenceEquals;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::endsWith3;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::startsWith3;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
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
            pub l0: MutCell<Chat_contract::US0>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Chat_contract::US0),
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
            US4_0(Chat_contract::US3),
            US4_1(Chat_contract::US3),
            US4_2(Chat_contract::US3),
            US4_3(Chat_contract::US3),
            US4_4(Chat_contract::US3),
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
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(std::string::String),
            US6_1,
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure1(unitVar: (), v0_1: char) -> bool {
            if v0_1.is_alphanumeric() {
                true
            } else {
                (v0_1) == '-'
            }
        }
        pub fn method4(v0_1: string) -> string {
            v0_1
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure4(unitVar: (), v0_1: string) -> Chat_contract::US5 {
            Chat_contract::US5::US5_0(v0_1)
        }
        pub fn method6() -> Func1<string, Chat_contract::US5> {
            Func1::new(move |v: string| Chat_contract::closure4((), v))
        }
        pub fn method3(v0_1: string) -> string {
            panic!(
                "{}",
                sprintf!(
                    "env.get_environment_variable / target: {} / var: {}",
                    Chat_contract::US4::US4_2(Chat_contract::US3::US3_2),
                    v0_1
                ),
            )
        }
        pub fn method2() -> (Chat_contract::US1, Chat_contract::US2) {
            let v1: string = Chat_contract::method3(string("TRACE_LEVEL"));
            let v6: Chat_contract::US1 = if string("Verbose") == (v1.clone()) {
                Chat_contract::US1::US1_0(Chat_contract::US0::US0_0)
            } else {
                Chat_contract::US1::US1_1
            };
            (
                match &v6 {
                    Chat_contract::US1::US1_0(v6_0_0) => Chat_contract::US1::US1_0(
                        match &v6 {
                            Chat_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v13: Chat_contract::US1 = if string("Debug") == (v1.clone()) {
                            Chat_contract::US1::US1_0(Chat_contract::US0::US0_1)
                        } else {
                            Chat_contract::US1::US1_1
                        };
                        match &v13 {
                            Chat_contract::US1::US1_0(v13_0_0) => Chat_contract::US1::US1_0(
                                match &v13 {
                                    Chat_contract::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v20: Chat_contract::US1 = if string("Info") == (v1.clone()) {
                                    Chat_contract::US1::US1_0(Chat_contract::US0::US0_2)
                                } else {
                                    Chat_contract::US1::US1_1
                                };
                                match &v20 {
                                    Chat_contract::US1::US1_0(v20_0_0) => {
                                        Chat_contract::US1::US1_0(
                                            match &v20 {
                                                Chat_contract::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => {
                                        let v27: Chat_contract::US1 =
                                            if string("Warning") == (v1.clone()) {
                                                Chat_contract::US1::US1_0(Chat_contract::US0::US0_3)
                                            } else {
                                                Chat_contract::US1::US1_1
                                            };
                                        match &v27 {
                                            Chat_contract::US1::US1_0(v27_0_0) => {
                                                Chat_contract::US1::US1_0(
                                                    match &v27 {
                                                        Chat_contract::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v34: Chat_contract::US1 =
                                                    if string("Critical") == (v1.clone()) {
                                                        Chat_contract::US1::US1_0(
                                                            Chat_contract::US0::US0_4,
                                                        )
                                                    } else {
                                                        Chat_contract::US1::US1_1
                                                    };
                                                match &v34 {
                                                    Chat_contract::US1::US1_0(v34_0_0) => {
                                                        Chat_contract::US1::US1_0(
                                                            match &v34 {
                                                                Chat_contract::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => Chat_contract::US1::US1_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if (Chat_contract::method3(string("AUTOMATION"))) != string("True") {
                    Chat_contract::US2::US2_1
                } else {
                    let v58: DateTime = unbox::<DateTime>(&getZero());
                    Chat_contract::US2::US2_0(unbox::<i64>(&getZero()))
                },
            )
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
            let v64: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v65: &str = option_env!("AUTOMATION").unwrap_or("");
            let v72: std::string::String = String::from(v65);
            let _run_target_args__v1: (Chat_contract::US1, Chat_contract::US2) = (
                Chat_contract::US1::US1_1,
                if (fable_library_rust::String_::fromString(v72)) != string("True") {
                    Chat_contract::US2::US2_1
                } else {
                    Chat_contract::US2::US2_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v132: Chat_contract::US2 = _run_target_args__v1.1.clone();
            let v131: Chat_contract::US1 = _run_target_args__v1.0.clone();
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
                    l0: MutCell::new(match &v131 {
                        Chat_contract::US1::US1_0(v131_0_0) => match &v131 {
                            Chat_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v132 {
                    Chat_contract::US2::US2_0(v132_0_0) => Some(match &v132 {
                        Chat_contract::US2::US2_0(x) => x.clone(),
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
            ) = Chat_contract::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v35: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
            if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                (find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                    ])))),
                )) >= (find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                        LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                    ])))),
                ))
            }
        }
        pub fn closure6(unitVar: (), v0_1: i64) -> Chat_contract::US2 {
            Chat_contract::US2::US2_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Chat_contract::US2> {
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
            let v272: u64 = near_sdk::env::block_timestamp();
            let v286: Chat_contract::US2 =
                defaultValue(Chat_contract::US2::US2_1, map(Chat_contract::method8(), v5));
            let v298: u64 = (match &v286 {
                Chat_contract::US2::US2_0(v286_0_0) => {
                    (v272)
                        - (match &v286 {
                            Chat_contract::US2::US2_0(x) => x.clone(),
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
        pub fn method13() -> string {
            string("")
        }
        pub fn closure7(v0_1: LrcPtr<Chat_contract::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append((v0_1.l0.get().clone()), (v1));
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
            let v73: &str = inline_colorization::color_bright_blue;
            let v80: &str = &*v6;
            let v99: &str = inline_colorization::color_reset;
            let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
            fable_library_rust::String_::fromString(v101)
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
                Chat_contract::closure7(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Chat_contract::closure7(v5.clone(), string("alias"), ());
                ()
            };
            let v30: () = {
                Chat_contract::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v43: std::string::String = format!("{:#?}", v0_1);
            let v68: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v43),
                    (),
                );
                ()
            };
            let v77: () = {
                Chat_contract::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v86: () = {
                Chat_contract::closure7(v5.clone(), string("block_timestamp"), ());
                ()
            };
            let v94: () = {
                Chat_contract::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v102: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v110: () = {
                Chat_contract::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v119: () = {
                Chat_contract::closure7(v5.clone(), string("signer_account_id"), ());
                ()
            };
            let v127: () = {
                Chat_contract::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v140: std::string::String = format!("{:#?}", v2);
            let v165: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v140),
                    (),
                );
                ()
            };
            let v173: () = {
                Chat_contract::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v182: () = {
                Chat_contract::closure7(v5.clone(), string("predecessor_account_id"), ());
                ()
            };
            let v190: () = {
                Chat_contract::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v203: std::string::String = format!("{:#?}", v3);
            let v228: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v203),
                    (),
                );
                ()
            };
            let v237: () = {
                Chat_contract::closure7(v5.clone(), string(" }"), ());
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
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
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
            ) = Chat_contract::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v20: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v37: () = {
                Chat_contract::closure8(patternInput.0.clone(), ());
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
                ) = Chat_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
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
        pub fn closure11(unitVar: (), v0_1: std::string::String) -> Chat_contract::US6 {
            Chat_contract::US6::US6_0(v0_1)
        }
        pub fn method19() -> Func1<std::string::String, Chat_contract::US6> {
            Func1::new(move |v: std::string::String| Chat_contract::closure11((), v))
        }
        pub fn method20() -> string {
            let v6: string = Chat_contract::method12(getCharAt(toLower(string("Warning")), 0_i32));
            let v73: &str = inline_colorization::color_yellow;
            let v80: &str = &*v6;
            let v99: &str = inline_colorization::color_reset;
            let v101: std::string::String = format!("{}{}{}", v73, v80, v99);
            fable_library_rust::String_::fromString(v101)
        }
        pub fn method22(v0_1: string) -> string {
            let v2: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v9: () = {
                Chat_contract::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Chat_contract::closure7(v2.clone(), string("account_alias"), ());
                ()
            };
            let v27: () = {
                Chat_contract::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v35: () = {
                Chat_contract::closure7(v2.clone(), v0_1, ());
                ()
            };
            let v44: () = {
                Chat_contract::closure7(v2.clone(), string(" }"), ());
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
                ) = Chat_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
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
                ) = Chat_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
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
            ) = Chat_contract::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v19: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v36: () = {
                Chat_contract::closure8(patternInput.0.clone(), ());
                ()
            };
            let v53: string = if (v19.l0.get().clone()) == string("") {
                string("")
            } else {
                v19.l0.get().clone()
            };
            let v60: &str = &*v53;
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
            v19.l0.set(string(""));
            {
                let v111: bool = true;
                v95.into_iter().for_each(|x| {
                    //;
                    let v113: std::string::String = x;
                    let v115: bool = true;
                    near_sdk::log!("{}", v113);
                    let v117: bool = true;
                    let v119: bool = true;
                }); //;
                ()
            }
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
                ) = Chat_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
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
                Chat_contract::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Chat_contract::closure7(v3.clone(), string("account_id"), ());
                ()
            };
            let v28: () = {
                Chat_contract::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v41: std::string::String = format!("{:#?}", v0_1);
            let v66: () = {
                Chat_contract::closure7(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v41),
                    (),
                );
                ()
            };
            let v75: () = {
                Chat_contract::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v84: () = {
                Chat_contract::closure7(v3.clone(), string("result"), ());
                ()
            };
            let v92: () = {
                Chat_contract::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v105: std::string::String = format!("{:#?}", v1);
            let v130: () = {
                Chat_contract::closure7(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v105),
                    (),
                );
                ()
            };
            let v139: () = {
                Chat_contract::closure7(v3.clone(), string(" }"), ());
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
                ) = Chat_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
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
                ) = Chat_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
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
                Chat_contract::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Chat_contract::closure7(v2.clone(), string("alias"), ());
                ()
            };
            let v27: () = {
                Chat_contract::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v40: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Chat_contract::closure7(
                    v2.clone(),
                    fable_library_rust::String_::fromString(v40),
                    (),
                );
                ()
            };
            let v74: () = {
                Chat_contract::closure7(v2.clone(), string(" }"), ());
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
            v8: std::string::String,
        ) -> string {
            let v9: string = Chat_contract::method29(v8);
            Chat_contract::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("chat_contract.get_alias_map"),
                v9
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
                ) = Chat_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
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
                ) = Chat_contract::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
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
                   getZero::<()>();
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
                    () /* = getZero();
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
                        let x_1: bool = if (v58) > 0_i32 {
                            if (v58) < 64_i32 {
                                if (startsWith3(v57.clone(), string("-"), false)) == false {
                                    if (endsWith3(v57.clone(), string("-"), false)) == false {
                                        let v76: &str = &*v57;
                                        let v95 = v76.chars();
                                        let v97: bool = true; // 1;
                                        let mut v95 = v95;
                                        v95.all(|x| {
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
              let v109: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy;
              let v111: bool =
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
                    let v119: Vec<u8> = content;
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
                    let hash_result = sha256_hash(&v119); //;
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
              let v144: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy;
              let v146: bool =
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
              let v158: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy;
              let v160: bool =
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
                    let v168: &mut (
                        u32,
                        near_sdk::store::IterableSet<near_sdk::AccountId>,
                        near_sdk::store::IterableSet<std::string::String>,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                    ) = &mut self.0;
                    let v170: std::string::String = alias;
                    let v172: &mut near_sdk::store::IterableSet<near_sdk::AccountId> = &mut v168.1;
                    let v174: &mut near_sdk::store::IterableSet<std::string::String> = &mut v168.2;
                    let v176: &mut near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &mut v168.3;
                    let v178: &mut near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &mut v168.4;
                    let v180: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v182: near_sdk::AccountId = near_sdk::env::predecessor_account_id();
                    let v184: u64 = near_sdk::env::block_timestamp();
                    let v187: () = {
                        Chat_contract::closure2(v170.clone(), v180.clone(), v182, v184, ());
                        ()
                    };
                    let v232: string = fable_library_rust::String_::fromString(v170.clone());
                    let v233: i32 = length(v232.clone());
                    let v285: bool = if (if (v233) > 0_i32 {
                        if (v233) < 64_i32 {
                            if (startsWith3(v232.clone(), string("-"), false)) == false {
                                if (endsWith3(v232.clone(), string("-"), false)) == false {
                                    let v251: &str = &*v232;
                                    let v270 = v251.chars();
                                    let v272: bool = true; // 1;
                                    let mut v270 = v270;
                                    v270.all(|x| {
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
                        let v284: bool = true;
                        near_sdk::env::panic_str(&*string(
                            "chat_contract.claim_alias / invalid alias",
                        )); //;
                        true
                    } else {
                        false
                    };
                    let v287: Option<&std::string::String> = v176.get(&v180.clone());
                    let v289: Option<std::string::String> = v287.cloned();
                    let v303: Chat_contract::US6 = defaultValue(
                        Chat_contract::US6::US6_1,
                        map(Chat_contract::method19(), v289.clone()),
                    );
                    if let Chat_contract::US6::US6_0(v303_0_0) = &v303 {
                        let v307: std::string::String = v303_0_0.clone();
                        if referenceEquals(&v307, &v170) {
                            let v313: () = {
                                Chat_contract::closure12(v307, ());
                                ()
                            };
                            ()
                        } else {
                            let v358: () = {
                                Chat_contract::closure13(v289.clone(), ());
                                ()
                            };
                            v178 //;
                                .get_mut(&v307) //;
                                .unwrap() //;
                                .remove(&v180.clone()); //;
                            v176.insert(v180.clone().clone(), v170.clone().clone()); //;
                            {
                                let v407: bool = v172.insert(v180.clone());
                                let v409: bool = v174.insert(v170.clone());
                                let new_alias_account_map = match v178.get(&v170.clone()) {
                                    //;
                                    None => {
                                        //;
                                        let mut new_map = std::collections::HashMap::new(); //;
                                        new_map.insert(v180.clone(), (v184, 0u32)); //;
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
                                            v180.clone(),
                                            (v184, accounts_vec.len() as u32),
                                        ); //;
                                        new_map //;
                                    } //;
                                }; //;
                                v178.insert(v170.clone(), new_alias_account_map); //;
                                ()
                            }
                        }
                    } else {
                        let v433: () = {
                            Chat_contract::closure13(v289, ());
                            ()
                        };
                        if let Chat_contract::US6::US6_1 = &v303 {
                            ()
                        } else {
                            panic!("{}", string("Match failure"),)
                        }
                        v176.insert(v180.clone().clone(), v170.clone().clone()); //;
                        {
                            let v478: bool = v172.insert(v180.clone());
                            let v480: bool = v174.insert(v170.clone());
                            let new_alias_account_map = match v178.get(&v170.clone()) {
                                //;
                                None => {
                                    //;
                                    let mut new_map = std::collections::HashMap::new(); //;
                                    new_map.insert(v180.clone(), (v184, 0u32)); //;
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
                                    new_map.insert(v180, (v184, accounts_vec.len() as u32)); //;
                                    new_map //;
                                } //;
                            }; //;
                            v178.insert(v170, new_alias_account_map); //;
                            ()
                        }
                    }
                    {
                        let v505: () = {
                            Chat_contract::closure15(Chat_contract::method24(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v549: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy;
              let v551: bool =
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
                    let v559: &(
                        u32,
                        near_sdk::store::IterableSet<near_sdk::AccountId>,
                        near_sdk::store::IterableSet<std::string::String>,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                    ) = &self.0;
                    let v561: near_sdk::AccountId = account_id;
                    let v563: &near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &v559.3;
                    let v565: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &v559.4;
                    let result = v563.get(&v561.clone()).and_then(|alias| {
                        //;
                        v565 //;
                            .get(alias) //;
                            .map(|accounts| {
                                //;
                                let result = (alias.clone(), *accounts.get(&v561).unwrap()); //;
                                (result.0, result.1 .0, result.1 .1) //;
                            }) //;
                    }); //;
                    {
                        let v575: Option<(std::string::String, u64, u32)> = result;
                        let v578: () = {
                            Chat_contract::closure16(v561, v575.clone(), ());
                            ()
                        };
                        let v620: () = {
                            Chat_contract::closure17((), ());
                            ()
                        };
                        v575
                    } // 4;
                } // 2;
            } // 1;
        } /* c;
          {
              let v663:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy;
              let v665:
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
                    let v673: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0 .4;
                    let v675: std::string::String = alias;
                    let v678: () = {
                        Chat_contract::closure18(v675.clone(), ());
                        ()
                    };
                    let v721: () = {
                        Chat_contract::closure19(Chat_contract::method30(), ());
                        ()
                    };
                    v673.get(&v675).cloned() //;
                } //;
            } //;
        } /* c;
          {
              let v765:
                      bool =
                  true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy;
              let v767:
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
              let v779:
                      bool =
                  true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy;
              let v781:
                      bool =
                  true; */
 // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy;
        fn _main() //;
        {
            {
                //;
                {
                    let v785: bool = true;
                    {
                        (); // ?? / i': 1uy / n: 14uy;
                        let v787: bool = true;
                        {
                            (); // ?? / i': 2uy / n: 14uy;
                            let v789: bool = true;
                            {
                                (); // ?? / i': 3uy / n: 14uy;
                                let v791: bool = true;
                                {
                                    (); // ?? / i': 4uy / n: 14uy;
                                    let v793: bool = true;
                                    {
                                        (); // ?? / i': 5uy / n: 14uy;
                                        let v795: bool = true;
                                        {
                                            (); // ?? / i': 6uy / n: 14uy;
                                            let v797: bool = true;
                                            {
                                                (); // ?? / i': 7uy / n: 14uy;
                                                let v799: bool = true;
                                                {
                                                    (); // ?? / i': 8uy / n: 14uy;
                                                    let v801: bool = true;
                                                    {
                                                        (); // ?? / i': 9uy / n: 14uy;
                                                        let v803: bool = true;
                                                        {
                                                            (); // ?? / i': 10uy / n: 14uy;
                                                            let v805: bool = true;
                                                            {
                                                                (); // ?? / i': 11uy / n: 14uy;
                                                                let v807: bool = true;
                                                                {
                                                                    (); // ?? / i': 12uy / n: 14uy;
                                                                    let v809: bool = true;
                                                                    {
                                                                        (); // ?? / i': 13uy / n: 14uy;
                                                                        let v811: bool = true;
                                                                        {
                                                                            (); // ?? / i': 14uy / n: 14uy;
                                                                            let v813: bool = true;
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
#[path = "../../../deps/spiral/lib/spiral/async__contract.rs"]
mod module_2335f2f5;
pub use module_2335f2f5::*;
#[path = "../../../deps/spiral/lib/spiral/common_contract.rs"]
mod module_652e6d81;
pub use module_652e6d81::*;
#[path = "../../../deps/spiral/lib/spiral/crypto_contract.rs"]
mod module_dd5f95ef;
pub use module_dd5f95ef::*;
#[path = "../../../deps/spiral/lib/spiral/date_time_contract.rs"]
mod module_ca5e6cb2;
pub use module_ca5e6cb2::*;
#[path = "../../../deps/spiral/lib/spiral/file_system_contract.rs"]
mod module_5ab1faf0;
pub use module_5ab1faf0::*;
#[path = "../../../deps/spiral/lib/spiral/lib_contract.rs"]
mod module_b386774b;
pub use module_b386774b::*;
#[path = "../../../deps/spiral/lib/spiral/networking_contract.rs"]
mod module_ce497f72;
pub use module_ce497f72::*;
#[path = "../../../deps/spiral/lib/spiral/platform_contract.rs"]
mod module_9a61edd3;
pub use module_9a61edd3::*;
#[path = "../../../deps/spiral/lib/spiral/runtime_contract.rs"]
mod module_502d7e30;
pub use module_502d7e30::*;
#[path = "../../../deps/spiral/lib/spiral/sm_contract.rs"]
mod module_34f67952;
pub use module_34f67952::*;
#[path = "../../../deps/spiral/lib/spiral/threading_contract.rs"]
mod module_11c0c5c2;
pub use module_11c0c5c2::*;
#[path = "../../../deps/spiral/lib/spiral/trace_contract.rs"]
mod module_28ecba0d;
pub use module_28ecba0d::*;
#[path = "../../../lib/fsharp/Common_contract.rs"]
mod module_ad43931;
pub use module_ad43931::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
