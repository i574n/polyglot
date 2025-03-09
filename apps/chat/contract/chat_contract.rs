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
        use fable_library_rust::Native_::getNull;
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
            US4_5(Chat_contract::US3),
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
                    Chat_contract::US4::US4_3(Chat_contract::US3::US3_2),
                    v0_1
                ),
            )
        }
        pub fn method2() -> (Chat_contract::US1, Chat_contract::US2) {
            let v1: string = Chat_contract::method3(string("TRACE_LEVEL"));
            let v6: string = toLower(string("Critical"));
            let v13: string = toLower(string("Warning"));
            let v20: string = toLower(string("Info"));
            let v27: string = toLower(string("Debug"));
            let v34: string = toLower(string("Verbose"));
            let v41: Chat_contract::US1 = if string("Verbose") == (v1.clone()) {
                Chat_contract::US1::US1_0(Chat_contract::US0::US0_0)
            } else {
                Chat_contract::US1::US1_1
            };
            (
                match &v41 {
                    Chat_contract::US1::US1_0(v41_0_0) => Chat_contract::US1::US1_0(
                        match &v41 {
                            Chat_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v48: Chat_contract::US1 = if string("Debug") == (v1.clone()) {
                            Chat_contract::US1::US1_0(Chat_contract::US0::US0_1)
                        } else {
                            Chat_contract::US1::US1_1
                        };
                        match &v48 {
                            Chat_contract::US1::US1_0(v48_0_0) => Chat_contract::US1::US1_0(
                                match &v48 {
                                    Chat_contract::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v55: Chat_contract::US1 = if string("Info") == (v1.clone()) {
                                    Chat_contract::US1::US1_0(Chat_contract::US0::US0_2)
                                } else {
                                    Chat_contract::US1::US1_1
                                };
                                match &v55 {
                                    Chat_contract::US1::US1_0(v55_0_0) => {
                                        Chat_contract::US1::US1_0(
                                            match &v55 {
                                                Chat_contract::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => {
                                        let v62: Chat_contract::US1 =
                                            if string("Warning") == (v1.clone()) {
                                                Chat_contract::US1::US1_0(Chat_contract::US0::US0_3)
                                            } else {
                                                Chat_contract::US1::US1_1
                                            };
                                        match &v62 {
                                            Chat_contract::US1::US1_0(v62_0_0) => {
                                                Chat_contract::US1::US1_0(
                                                    match &v62 {
                                                        Chat_contract::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v69: Chat_contract::US1 =
                                                    if string("Critical") == (v1.clone()) {
                                                        Chat_contract::US1::US1_0(
                                                            Chat_contract::US0::US0_4,
                                                        )
                                                    } else {
                                                        Chat_contract::US1::US1_1
                                                    };
                                                match &v69 {
                                                    Chat_contract::US1::US1_0(v69_0_0) => {
                                                        Chat_contract::US1::US1_0(
                                                            match &v69 {
                                                                Chat_contract::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v76: Chat_contract::US1 =
                                                            if (v34.clone()) == (v1.clone()) {
                                                                Chat_contract::US1::US1_0(
                                                                    Chat_contract::US0::US0_0,
                                                                )
                                                            } else {
                                                                Chat_contract::US1::US1_1
                                                            };
                                                        match &v76 {
                                                         Chat_contract::US1::US1_0(v76_0_0)
                                                         =>
                                                         Chat_contract::US1::US1_0(match &v76
                                                                                       {
                                                                                       Chat_contract::US1::US1_0(x)
                                                                                       =>
                                                                                       x.clone(),
                                                                                       _
                                                                                       =>
                                                                                       unreachable!(),
                                                                                   }.clone()),
                                                         _ => {
                                                             let v83:
                                                                     Chat_contract::US1 =
                                                                 if (v27.clone())
                                                                        ==
                                                                        (v1.clone())
                                                                    {
                                                                     Chat_contract::US1::US1_0(Chat_contract::US0::US0_1)
                                                                 } else {
                                                                     Chat_contract::US1::US1_1
                                                                 };
                                                             match &v83 {
                                                                 Chat_contract::US1::US1_0(v83_0_0)
                                                                 =>
                                                                 Chat_contract::US1::US1_0(match &v83
                                                                                               {
                                                                                               Chat_contract::US1::US1_0(x)
                                                                                               =>
                                                                                               x.clone(),
                                                                                               _
                                                                                               =>
                                                                                               unreachable!(),
                                                                                           }.clone()),
                                                                 _ => {
                                                                     let v90:
                                                                             Chat_contract::US1 =
                                                                         if (v20.clone())
                                                                                ==
                                                                                (v1.clone())
                                                                            {
                                                                             Chat_contract::US1::US1_0(Chat_contract::US0::US0_2)
                                                                         } else {
                                                                             Chat_contract::US1::US1_1
                                                                         };
                                                                     match &v90
                                                                         {
                                                                         Chat_contract::US1::US1_0(v90_0_0)
                                                                         =>
                                                                         Chat_contract::US1::US1_0(match &v90
                                                                                                       {
                                                                                                       Chat_contract::US1::US1_0(x)
                                                                                                       =>
                                                                                                       x.clone(),
                                                                                                       _
                                                                                                       =>
                                                                                                       unreachable!(),
                                                                                                   }.clone()),
                                                                         _ =>
                                                                         {
                                                                             let v97:
                                                                                     Chat_contract::US1 =
                                                                                 if (v13.clone())
                                                                                        ==
                                                                                        (v1.clone())
                                                                                    {
                                                                                     Chat_contract::US1::US1_0(Chat_contract::US0::US0_3)
                                                                                 } else {
                                                                                     Chat_contract::US1::US1_1
                                                                                 };
                                                                             match &v97
                                                                                 {
                                                                                 Chat_contract::US1::US1_0(v97_0_0)
                                                                                 =>
                                                                                 Chat_contract::US1::US1_0(match &v97
                                                                                                               {
                                                                                                               Chat_contract::US1::US1_0(x)
                                                                                                               =>
                                                                                                               x.clone(),
                                                                                                               _
                                                                                                               =>
                                                                                                               unreachable!(),
                                                                                                           }.clone()),
                                                                                 _
                                                                                 =>
                                                                                 {
                                                                                     let v104:
                                                                                             Chat_contract::US1 =
                                                                                         if (v6.clone())
                                                                                                ==
                                                                                                (v1.clone())
                                                                                            {
                                                                                             Chat_contract::US1::US1_0(Chat_contract::US0::US0_4)
                                                                                         } else {
                                                                                             Chat_contract::US1::US1_1
                                                                                         };
                                                                                     match &v104
                                                                                         {
                                                                                         Chat_contract::US1::US1_0(v104_0_0)
                                                                                         =>
                                                                                         Chat_contract::US1::US1_0(match &v104
                                                                                                                       {
                                                                                                                       Chat_contract::US1::US1_0(x)
                                                                                                                       =>
                                                                                                                       x.clone(),
                                                                                                                       _
                                                                                                                       =>
                                                                                                                       unreachable!(),
                                                                                                                   }.clone()),
                                                                                         _
                                                                                         =>
                                                                                         Chat_contract::US1::US1_1,
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
                },
                if (Chat_contract::method3(string("AUTOMATION"))) != string("True") {
                    Chat_contract::US2::US2_1
                } else {
                    let v143: DateTime = unbox::<DateTime>(fable_library_rust::Native_::getZero());
                    Chat_contract::US2::US2_0(unbox::<i64>(fable_library_rust::Native_::getZero()))
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
            let v88: string = string("option_env!(\"AUTOMATION\").unwrap_or(\"\")");
            let v89: &str = option_env!("AUTOMATION").unwrap_or("");
            let v100: std::string::String = String::from(v89);
            let _run_target_args__v3: (Chat_contract::US1, Chat_contract::US2) = (
                Chat_contract::US1::US1_1,
                if (fable_library_rust::String_::fromString(v100)) != string("True") {
                    Chat_contract::US2::US2_1
                } else {
                    Chat_contract::US2::US2_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v173: Chat_contract::US2 = _run_target_args__v3.1.clone();
            let v172: Chat_contract::US1 = _run_target_args__v3.0.clone();
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
                    l0: MutCell::new(match &v172 {
                        Chat_contract::US1::US1_0(v172_0_0) => match &v172 {
                            Chat_contract::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v173 {
                    Chat_contract::US2::US2_0(v173_0_0) => Some(match &v173 {
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
            let v42: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
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
                    v42,
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
            let v491: u64 = near_sdk::env::block_timestamp();
            let v510: Chat_contract::US2 =
                defaultValue(Chat_contract::US2::US2_1, map(Chat_contract::method8(), v5));
            let v523: u64 = (match &v510 {
                Chat_contract::US2::US2_0(v510_0_0) => {
                    (v491)
                        - (match &v510 {
                            Chat_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64)
                }
                _ => v491,
            }) / 1000000000_u64;
            let v524: u64 = (v523) % 60_u64;
            let v526: u64 = ((v523) / 60_u64) % 60_u64;
            let v528: u64 = ((v523) / 3600_u64) % 24_u64;
            let v530: std::string::String = format!("{:02}:{:02}:{:02}", v528, v526, v524);
            fable_library_rust::String_::fromString(v530)
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
            let v9: () = {
                Chat_contract::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v8: string = Chat_contract::method12(getCharAt(toLower(string("Debug")), 0_i32));
            let v97: &str = inline_colorization::color_bright_blue;
            let v108: &str = &*v8;
            let v132: &str = inline_colorization::color_reset;
            let v134: std::string::String = format!("{}{}{}", v97, v108, v132);
            fable_library_rust::String_::fromString(v134)
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
            let v14: () = {
                Chat_contract::closure7(v5.clone(), string("{ "), ());
                ()
            };
            let v25: () = {
                Chat_contract::closure7(v5.clone(), string("alias"), ());
                ()
            };
            let v36: () = {
                Chat_contract::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v53: std::string::String = format!("{:#?}", v0_1);
            let v84: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v53),
                    (),
                );
                ()
            };
            let v95: () = {
                Chat_contract::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v106: () = {
                Chat_contract::closure7(v5.clone(), string("block_timestamp"), ());
                ()
            };
            let v115: () = {
                Chat_contract::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v124: () = {
                Chat_contract::closure7(v5.clone(), sprintf!("{}", v1), ());
                ()
            };
            let v133: () = {
                Chat_contract::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v144: () = {
                Chat_contract::closure7(v5.clone(), string("signer_account_id"), ());
                ()
            };
            let v153: () = {
                Chat_contract::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v170: std::string::String = format!("{:#?}", v2);
            let v201: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v170),
                    (),
                );
                ()
            };
            let v210: () = {
                Chat_contract::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v221: () = {
                Chat_contract::closure7(v5.clone(), string("predecessor_account_id"), ());
                ()
            };
            let v230: () = {
                Chat_contract::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v247: std::string::String = format!("{:#?}", v3);
            let v278: () = {
                Chat_contract::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v247),
                    (),
                );
                ()
            };
            let v289: () = {
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
            let v27: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v44: () = {
                Chat_contract::closure8(patternInput.0.clone(), ());
                ()
            };
            let v60: string = if (v27.l0.get().clone()) == string("") {
                v0_1.clone()
            } else {
                if (v0_1.clone()) == string("") {
                    v27.l0.get().clone()
                } else {
                    append(
                        (append((v27.l0.get().clone()), string("\n"))),
                        (v0_1.clone()),
                    )
                }
            };
            let v71: &str = &*v60.clone();
            let v95 = v71.chars();
            let v97 = v95;
            let v99: Vec<char> = v97.collect::<Vec<_>>();
            let v101: Vec<Vec<char>> = v99
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v103: bool = true;
            let _vec_map: Vec<_> = v101
                .into_iter()
                .map(|x| {
                    //;
                    let v105: Vec<char> = x;
                    let v107: std::string::String = String::from_iter(v105);
                    let v109: bool = true;
                    v107
                })
                .collect::<Vec<_>>();
            let v111: Vec<std::string::String> = _vec_map;
            if if (v0_1.clone()) != string("") {
                (v111.clone().len() as i32) <= 1_i32
            } else {
                false
            } {
                v27.l0.set(v60);
                ()
            } else {
                v27.l0.set(string(""));
                {
                    let v136: bool = true;
                    v111.into_iter().for_each(|x| {
                        //;
                        let v138: std::string::String = x;
                        let v140: bool = true;
                        near_sdk::log!("{}", v138);
                        let v142: bool = true;
                        let v144: bool = true;
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
                let v34: Option<i64> = patternInput.5.clone();
                let v33: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v32: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v31: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v30: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v29: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method15(
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    v34.clone(),
                    Chat_contract::method7(v29, v30, v31, v32, v33, v34),
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
            let v8: string = Chat_contract::method12(getCharAt(toLower(string("Warning")), 0_i32));
            let v97: &str = inline_colorization::color_yellow;
            let v108: &str = &*v8;
            let v132: &str = inline_colorization::color_reset;
            let v134: std::string::String = format!("{}{}{}", v97, v108, v132);
            fable_library_rust::String_::fromString(v134)
        }
        pub fn method22(v0_1: string) -> string {
            let v2: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v11: () = {
                Chat_contract::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Chat_contract::closure7(v2.clone(), string("account_alias"), ());
                ()
            };
            let v33: () = {
                Chat_contract::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v42: () = {
                Chat_contract::closure7(v2.clone(), v0_1, ());
                ()
            };
            let v53: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method21(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Chat_contract::method7(v26, v27, v28, v29, v30, v31),
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method23(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Chat_contract::method7(v26, v27, v28, v29, v30, v31),
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
            let v26: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v43: () = {
                Chat_contract::closure8(patternInput.0.clone(), ());
                ()
            };
            let v60: string = if (v26.l0.get().clone()) == string("") {
                string("")
            } else {
                v26.l0.get().clone()
            };
            let v71: &str = &*v60;
            let v95 = v71.chars();
            let v97 = v95;
            let v99: Vec<char> = v97.collect::<Vec<_>>();
            let v101: Vec<Vec<char>> = v99
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v103: bool = true;
            let _vec_map: Vec<_> = v101
                .into_iter()
                .map(|x| {
                    //;
                    let v105: Vec<char> = x;
                    let v107: std::string::String = String::from_iter(v105);
                    let v109: bool = true;
                    v107
                })
                .collect::<Vec<_>>();
            let v111: Vec<std::string::String> = _vec_map;
            v26.l0.set(string(""));
            {
                let v134: bool = true;
                v111.into_iter().for_each(|x| {
                    //;
                    let v136: std::string::String = x;
                    let v138: bool = true;
                    near_sdk::log!("{}", v136);
                    let v140: bool = true;
                    let v142: bool = true;
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
                let v44: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v45: string = Chat_contract::method11();
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
            let v12: () = {
                Chat_contract::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v23: () = {
                Chat_contract::closure7(v3.clone(), string("account_id"), ());
                ()
            };
            let v34: () = {
                Chat_contract::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v51: std::string::String = format!("{:#?}", v0_1);
            let v82: () = {
                Chat_contract::closure7(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v51),
                    (),
                );
                ()
            };
            let v93: () = {
                Chat_contract::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v104: () = {
                Chat_contract::closure7(v3.clone(), string("result"), ());
                ()
            };
            let v113: () = {
                Chat_contract::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v130: std::string::String = format!("{:#?}", v1);
            let v161: () = {
                Chat_contract::closure7(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v130),
                    (),
                );
                ()
            };
            let v172: () = {
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
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method26(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Chat_contract::method7(v27, v28, v29, v30, v31, v32),
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
                let v43: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v44: string = Chat_contract::method11();
                Chat_contract::method25()
            };
        }
        pub fn method29(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method13()),
            });
            let v11: () = {
                Chat_contract::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Chat_contract::closure7(v2.clone(), string("alias"), ());
                ()
            };
            let v33: () = {
                Chat_contract::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v50: std::string::String = format!("{:#?}", v0_1);
            let v81: () = {
                Chat_contract::closure7(
                    v2.clone(),
                    fable_library_rust::String_::fromString(v50),
                    (),
                );
                ()
            };
            let v92: () = {
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
                let v31: Option<i64> = patternInput.5.clone();
                let v30: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v29: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v28: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v27: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v26: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method18(Chat_contract::method28(
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    Chat_contract::method7(v26, v27, v28, v29, v30, v31),
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
                let v44: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v45: string = Chat_contract::method11();
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
                let v10:
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
                   fable_library_rust::Native_::getZero::<()>();
               */
        );
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            #[init] //;
            pub fn new() -> Self {
                // 1;
                {
                    let v19: bool = true; /*;
                                          let v21: */
                    () /* = fable_library_rust::Native_::getZero();
                    let v25: bool = true; */;
                    let v27: string = string("b\"account_set\"");
                    let v28: &[u8] = b"account_set";
                    let v30: near_sdk::store::IterableSet<near_sdk::AccountId> =
                        near_sdk::store::IterableSet::new(v28);
                    let v32: string = string("b\"alias_set\"");
                    let v33: &[u8] = b"alias_set";
                    let v35: near_sdk::store::IterableSet<std::string::String> =
                        near_sdk::store::IterableSet::new(v33);
                    let v37: string = string("b\"account_map\"");
                    let v38: &[u8] = b"account_map";
                    let v40: near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String> =
                        near_sdk::store::LookupMap::new(v38);
                    let v42: string = string("b\"alias_map\"");
                    let v43: &[u8] = b"alias_map";
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
                        ) = (2_u32, v30, v35, v40, near_sdk::store::LookupMap::new(v43));
                        Self(x) // x
                    }
                } // 2.;
            } // 1.;
        } /* c;
          {
              let v50: bool =
                  true; // ??? / i: 1uy / i': 1uy / acc: 0uy / n: 2uy;
              let v52: bool =
                  true; */
 // ???? / i: 1uy / i': 2uy / acc: 0uy / n: 2uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            fn is_valid_alias(alias: String) -> bool {
                //;
                {
                    let v57: std::string::String = alias;
                    let v59: string = fable_library_rust::String_::fromString(v57);
                    let v60: i32 = length(v59.clone());
                    {
                        let x_1: bool = if (v60) > 0_i32 {
                            if (v60) < 64_i32 {
                                if (startsWith3(v59.clone(), string("-"), false)) == false {
                                    if (endsWith3(v59.clone(), string("-"), false)) == false {
                                        let v85: &str = &*v59;
                                        let v109 = v85.chars();
                                        let v111: bool = true; // 1;
                                        let mut v109 = v109;
                                        v109.all(|x| {
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
              let v123: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy;
              let v125: bool =
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
                    let v133: Vec<u8> = content;
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
                    let hash_result = sha256_hash(&v133); //;
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
              let v158: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy;
              let v160: bool =
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
              let v172: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy;
              let v174: bool =
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
                    let v182: &mut (
                        u32,
                        near_sdk::store::IterableSet<near_sdk::AccountId>,
                        near_sdk::store::IterableSet<std::string::String>,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                    ) = &mut self.0;
                    let v184: std::string::String = alias;
                    let v186: &mut near_sdk::store::IterableSet<near_sdk::AccountId> = &mut v182.1;
                    let v188: &mut near_sdk::store::IterableSet<std::string::String> = &mut v182.2;
                    let v190: &mut near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &mut v182.3;
                    let v192: &mut near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &mut v182.4;
                    let v194: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v196: near_sdk::AccountId = near_sdk::env::predecessor_account_id();
                    let v198: u64 = near_sdk::env::block_timestamp();
                    let v201: () = {
                        Chat_contract::closure2(v184.clone(), v194.clone(), v196, v198, ());
                        ()
                    };
                    let v253: string = fable_library_rust::String_::fromString(v184.clone());
                    let v254: i32 = length(v253.clone());
                    let v318: bool = if (if (v254) > 0_i32 {
                        if (v254) < 64_i32 {
                            if (startsWith3(v253.clone(), string("-"), false)) == false {
                                if (endsWith3(v253.clone(), string("-"), false)) == false {
                                    let v279: &str = &*v253;
                                    let v303 = v279.chars();
                                    let v305: bool = true; // 1;
                                    let mut v303 = v303;
                                    v303.all(|x| {
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
                        let v317: bool = true;
                        near_sdk::env::panic_str(&*string(
                            "chat_contract.claim_alias / invalid alias",
                        )); //;
                        true
                    } else {
                        false
                    };
                    let v320: Option<&std::string::String> = v190.get(&v194.clone());
                    let v322: Option<std::string::String> = v320.cloned();
                    let v341: Chat_contract::US6 = defaultValue(
                        Chat_contract::US6::US6_1,
                        map(Chat_contract::method19(), v322.clone()),
                    );
                    if let Chat_contract::US6::US6_0(v341_0_0) = &v341 {
                        let v345: std::string::String = v341_0_0.clone();
                        if referenceEquals(&v345, &v184) {
                            let v352: () = {
                                Chat_contract::closure12(v345, ());
                                ()
                            };
                            ()
                        } else {
                            let v405: () = {
                                Chat_contract::closure13(v322.clone(), ());
                                ()
                            };
                            v192 //;
                                .get_mut(&v345) //;
                                .unwrap() //;
                                .remove(&v194.clone()); //;
                            v190.insert(v194.clone().clone(), v184.clone().clone()); //;
                            {
                                let v462: bool = v186.insert(v194.clone());
                                let v464: bool = v188.insert(v184.clone());
                                let new_alias_account_map = match v192.get(&v184.clone()) {
                                    //;
                                    None => {
                                        //;
                                        let mut new_map = std::collections::HashMap::new(); //;
                                        new_map.insert(v194.clone(), (v198, 0u32)); //;
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
                                            v194.clone(),
                                            (v198, accounts_vec.len() as u32),
                                        ); //;
                                        new_map //;
                                    } //;
                                }; //;
                                v192.insert(v184.clone(), new_alias_account_map); //;
                                ()
                            }
                        }
                    } else {
                        let v488: () = {
                            Chat_contract::closure13(v322, ());
                            ()
                        };
                        if let Chat_contract::US6::US6_1 = &v341 {
                            ()
                        } else {
                            panic!("{}", string("Match failure"),)
                        }
                        v190.insert(v194.clone().clone(), v184.clone().clone()); //;
                        {
                            let v541: bool = v186.insert(v194.clone());
                            let v543: bool = v188.insert(v184.clone());
                            let new_alias_account_map = match v192.get(&v184.clone()) {
                                //;
                                None => {
                                    //;
                                    let mut new_map = std::collections::HashMap::new(); //;
                                    new_map.insert(v194.clone(), (v198, 0u32)); //;
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
                                    new_map.insert(v194, (v198, accounts_vec.len() as u32)); //;
                                    new_map //;
                                } //;
                            }; //;
                            v192.insert(v184, new_alias_account_map); //;
                            ()
                        }
                    }
                    {
                        let v568: () = {
                            Chat_contract::closure15(Chat_contract::method24(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v619: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy;
              let v621: bool =
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
                    let v629: &(
                        u32,
                        near_sdk::store::IterableSet<near_sdk::AccountId>,
                        near_sdk::store::IterableSet<std::string::String>,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                    ) = &self.0;
                    let v631: near_sdk::AccountId = account_id;
                    let v633: &near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &v629.3;
                    let v635: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &v629.4;
                    let v637: bool = true;
                    let result = v633.get(&v631.clone()).and_then(|alias| {
                        //;
                        let v639: bool = true;
                        v635.get(alias).map(|accounts| {
                            //;
                            let v641: bool = true;
                            let result = (alias.clone(), *accounts.get(&v631).unwrap()); //;
                            let v643: bool = true;
                            (result.0, result.1 .0, result.1 .1)
                        })
                    }); //;
                    let v645: Option<(std::string::String, u64, u32)> = result;
                    let v648: () = {
                        Chat_contract::closure16(v631, v645.clone(), ());
                        ()
                    };
                    let v697: () = {
                        Chat_contract::closure17((), ());
                        ()
                    };
                    v645
                } // 4;
            } // 1;
        } /* c;
          {
              let v746:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 1uy;
              let v748:
                      bool =
                  true; */
 // ???? / i: 6uy / i': 2uy / acc: 9uy / n: 1uy;
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
                    let v756: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0 .4;
                    let v758: std::string::String = alias;
                    let v761: () = {
                        Chat_contract::closure18(v758.clone(), ());
                        ()
                    };
                    let v811: () = {
                        Chat_contract::closure19(Chat_contract::method30(), ());
                        ()
                    };
                    v756.get(&v758).cloned() //;
                } //;
            } //;
        } /* c;
          {
              let v862:
                      bool =
                  true; // ??? / i: 7uy / i': 1uy / acc: 10uy / n: 2uy;
              let v864:
                      bool =
                  true; */
 // ???? / i: 7uy / i': 2uy / acc: 10uy / n: 2uy;
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
              let v876:
                      bool =
                  true; // ??? / i: 8uy / i': 1uy / acc: 12uy / n: 1uy;
              let v878:
                      bool =
                  true; */
 // ???? / i: 8uy / i': 2uy / acc: 12uy / n: 1uy;
        fn _main() //;
        {
            {
                //;
                {
                    let v882: bool = true;
                    {
                        (); // ?? / i': 1uy / n: 13uy;
                        let v884: bool = true;
                        {
                            (); // ?? / i': 2uy / n: 13uy;
                            let v886: bool = true;
                            {
                                (); // ?? / i': 3uy / n: 13uy;
                                let v888: bool = true;
                                {
                                    (); // ?? / i': 4uy / n: 13uy;
                                    let v890: bool = true;
                                    {
                                        (); // ?? / i': 5uy / n: 13uy;
                                        let v892: bool = true;
                                        {
                                            (); // ?? / i': 6uy / n: 13uy;
                                            let v894: bool = true;
                                            {
                                                (); // ?? / i': 7uy / n: 13uy;
                                                let v896: bool = true;
                                                {
                                                    (); // ?? / i': 8uy / n: 13uy;
                                                    let v898: bool = true;
                                                    {
                                                        (); // ?? / i': 9uy / n: 13uy;
                                                        let v900: bool = true;
                                                        {
                                                            (); // ?? / i': 10uy / n: 13uy;
                                                            let v902: bool = true;
                                                            {
                                                                (); // ?? / i': 11uy / n: 13uy;
                                                                let v904: bool = true;
                                                                {
                                                                    (); // ?? / i': 12uy / n: 13uy;
                                                                    let v906: bool = true;
                                                                    {
                                                                        (); // ?? / i': 13uy / n: 13uy;
                                                                        let v908: bool = true;
                                                                        {
                                                                            {
                                                                                (); // ? / i': 14uy / n: 13uy;
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
