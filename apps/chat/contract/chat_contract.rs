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
mod module_2e7a6383 {
    pub mod Chat_contract {
        use super::*;
        type DateTime = ();
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::getNull;
        use fable_library_rust::Native_::on_startup;
        use fable_library_rust::Native_::referenceEquals;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::NativeArray_::new_array;
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
        use fable_library_rust::String_::toString;
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
                    let v147: DateTime = unbox::<DateTime>(fable_library_rust::Native_::getZero());
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
            let v17: () = {
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
            let v56: Chat_contract::US0 = (patternInput.4.clone()).l0.get().clone();
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
                    v56,
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
            let v551: u64 = near_sdk::env::block_timestamp();
            let v576: Chat_contract::US2 =
                defaultValue(Chat_contract::US2::US2_1, map(Chat_contract::method8(), v5));
            let v589: u64 = (match &v576 {
                Chat_contract::US2::US2_0(v576_0_0) => {
                    (v551)
                        - (match &v576 {
                            Chat_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64)
                }
                _ => v551,
            }) / 1000000000_u64;
            let v590: u64 = (v589) % 60_u64;
            let v592: u64 = ((v589) / 60_u64) % 60_u64;
            let v594: u64 = ((v589) / 3600_u64) % 24_u64;
            let v596: std::string::String = format!("{:02}:{:02}:{:02}", v594, v592, v590);
            fable_library_rust::String_::fromString(v596)
        }
        pub fn method12() -> string {
            string("")
        }
        pub fn closure7(v0_1: LrcPtr<Chat_contract::Mut3>, v1: string, unitVar: ()) {
            let v4: string = append((v0_1.l0.get().clone()), (v1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method13() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v7: char = getCharAt(toLower(string("Debug")), 0_i32);
            let v9: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method12()),
            });
            let v24: () = {
                Chat_contract::closure7(v9.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v30: string = v9.l0.get().clone();
            let v131: &str = inline_colorization::color_bright_blue;
            let v142: &str = &*v30;
            let v166: &str = inline_colorization::color_reset;
            let v168: std::string::String = format!("{}{}{}", v131, v142, v166);
            fable_library_rust::String_::fromString(v168)
        }
        pub fn method15(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method14(
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
            let v13: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method12()),
            });
            let v27: () = {
                Chat_contract::closure7(v13.clone(), string("{ "), ());
                ()
            };
            let v46: () = {
                Chat_contract::closure7(v13.clone(), string("alias"), ());
                ()
            };
            let v65: () = {
                Chat_contract::closure7(v13.clone(), string(" = "), ());
                ()
            };
            let v85: std::string::String = format!("{:#?}", v8);
            let v121: () = {
                Chat_contract::closure7(
                    v13.clone(),
                    fable_library_rust::String_::fromString(v85),
                    (),
                );
                ()
            };
            let v140: () = {
                Chat_contract::closure7(v13.clone(), string("; "), ());
                ()
            };
            let v159: () = {
                Chat_contract::closure7(v13.clone(), string("block_timestamp"), ());
                ()
            };
            let v176: () = {
                Chat_contract::closure7(v13.clone(), string(" = "), ());
                ()
            };
            let v196: () = {
                Chat_contract::closure7(v13.clone(), sprintf!("{}", v9), ());
                ()
            };
            let v213: () = {
                Chat_contract::closure7(v13.clone(), string("; "), ());
                ()
            };
            let v232: () = {
                Chat_contract::closure7(v13.clone(), string("signer_account_id"), ());
                ()
            };
            let v249: () = {
                Chat_contract::closure7(v13.clone(), string(" = "), ());
                ()
            };
            let v269: std::string::String = format!("{:#?}", v10);
            let v305: () = {
                Chat_contract::closure7(
                    v13.clone(),
                    fable_library_rust::String_::fromString(v269),
                    (),
                );
                ()
            };
            let v322: () = {
                Chat_contract::closure7(v13.clone(), string("; "), ());
                ()
            };
            let v341: () = {
                Chat_contract::closure7(v13.clone(), string("predecessor_account_id"), ());
                ()
            };
            let v358: () = {
                Chat_contract::closure7(v13.clone(), string(" = "), ());
                ()
            };
            let v378: std::string::String = format!("{:#?}", v11);
            let v414: () = {
                Chat_contract::closure7(
                    v13.clone(),
                    fable_library_rust::String_::fromString(v378),
                    (),
                );
                ()
            };
            let v433: () = {
                Chat_contract::closure7(v13.clone(), string(" }"), ());
                ()
            };
            let v439: string = v13.l0.get().clone();
            Chat_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("chat_contract.claim_alias"),
                    )),
                    string(" / "),
                )),
                (v439),
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
            let v4: () = {
                Chat_contract::closure10(v0_1, ());
                ()
            };
            ()
        }
        pub fn method16(v0_1: string) {
            let v17: () = {
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
            let v41: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v60: () = {
                Chat_contract::closure8(patternInput.0.clone(), ());
                ()
            };
            let v83: string = if (v41.l0.get().clone()) == string("") {
                v0_1.clone()
            } else {
                if (v0_1.clone()) == string("") {
                    v41.l0.get().clone()
                } else {
                    append(
                        (append((v41.l0.get().clone()), string("\n"))),
                        (v0_1.clone()),
                    )
                }
            };
            let v94: &str = &*v83.clone();
            let v118 = v94.chars();
            let v120 = v118;
            let v122: Vec<char> = v120.collect::<Vec<_>>();
            let v124: Vec<Vec<char>> = v122
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v126: bool = true;
            let _vec_map: Vec<_> = v124
                .into_iter()
                .map(|x| {
                    //;
                    let v128: Vec<char> = x;
                    let v130: std::string::String = String::from_iter(v128);
                    let v132: bool = true;
                    v130
                })
                .collect::<Vec<_>>();
            let v134: Vec<std::string::String> = _vec_map;
            if if (v0_1.clone()) != string("") {
                (v134.clone().len() as i32) <= 1_i32
            } else {
                false
            } {
                v41.l0.set(v83);
                ()
            } else {
                v41.l0.set(string(""));
                {
                    let v159: bool = true;
                    v134.into_iter().for_each(|x| {
                        //;
                        let v161: std::string::String = x;
                        let v163: bool = true;
                        near_sdk::log!("{}", v161);
                        let v165: bool = true;
                        let v167: bool = true;
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
                let v22: () = {
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
                let v48: Option<i64> = patternInput.5.clone();
                let v47: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v46: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v45: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v44: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v43: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method16(Chat_contract::method14(
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    v47.clone(),
                    v48.clone(),
                    Chat_contract::method7(v43, v44, v45, v46, v47, v48),
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
        pub fn method17() -> Func1<std::string::String, Chat_contract::US6> {
            Func1::new(move |v: std::string::String| Chat_contract::closure11((), v))
        }
        pub fn method18() -> string {
            let v7: char = getCharAt(toLower(string("Warning")), 0_i32);
            let v9: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method12()),
            });
            let v24: () = {
                Chat_contract::closure7(v9.clone(), sprintf!("{}", v7), ());
                ()
            };
            let v30: string = v9.l0.get().clone();
            let v131: &str = inline_colorization::color_yellow;
            let v142: &str = &*v30;
            let v166: &str = inline_colorization::color_reset;
            let v168: std::string::String = format!("{}{}{}", v131, v142, v166);
            fable_library_rust::String_::fromString(v168)
        }
        pub fn method19(
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
            let v10: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method12()),
            });
            let v24: () = {
                Chat_contract::closure7(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Chat_contract::closure7(v10.clone(), string("account_alias"), ());
                ()
            };
            let v62: () = {
                Chat_contract::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Chat_contract::closure7(v10.clone(), v8, ());
                ()
            };
            let v98: () = {
                Chat_contract::closure7(v10.clone(), string(" }"), ());
                ()
            };
            let v104: string = v10.l0.get().clone();
            Chat_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("chat_contract.claim_alias / alias already claimed"),
                    )),
                    string(" / "),
                )),
                (v104),
            ))
        }
        pub fn closure12(v0_1: std::string::String, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_3) {
                let v19: () = {
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
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method16(Chat_contract::method19(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Chat_contract::method7(v40, v41, v42, v43, v44, v45),
                    Chat_contract::method18(),
                    sprintf!("{:?}", v0_1),
                ))
            };
        }
        pub fn method20(
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
            let v10: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method12()),
            });
            let v24: () = {
                Chat_contract::closure7(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Chat_contract::closure7(v10.clone(), string("account_alias"), ());
                ()
            };
            let v62: () = {
                Chat_contract::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Chat_contract::closure7(v10.clone(), v8, ());
                ()
            };
            let v98: () = {
                Chat_contract::closure7(v10.clone(), string(" }"), ());
                ()
            };
            let v104: string = v10.l0.get().clone();
            Chat_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("chat_contract.claim_alias"),
                    )),
                    string(" / "),
                )),
                (v104),
            ))
        }
        pub fn closure13(v0_1: Option<std::string::String>, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v19: () = {
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
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method16(Chat_contract::method20(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Chat_contract::method7(v40, v41, v42, v43, v44, v45),
                    Chat_contract::method11(),
                    sprintf!("{:?}", v0_1),
                ))
            };
        }
        pub fn closure14(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method21() -> Func0<()> {
            Func0::new(move || Chat_contract::closure14((), ()))
        }
        pub fn method22() {
            let v16: () = {
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
            let v40: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v59: () = {
                Chat_contract::closure8(patternInput.0.clone(), ());
                ()
            };
            let v83: string = if (v40.l0.get().clone()) == string("") {
                string("")
            } else {
                v40.l0.get().clone()
            };
            let v94: &str = &*v83;
            let v118 = v94.chars();
            let v120 = v118;
            let v122: Vec<char> = v120.collect::<Vec<_>>();
            let v124: Vec<Vec<char>> = v122
                .chunks(15000)
                .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                .collect::<Vec<_>>();
            let v126: bool = true;
            let _vec_map: Vec<_> = v124
                .into_iter()
                .map(|x| {
                    //;
                    let v128: Vec<char> = x;
                    let v130: std::string::String = String::from_iter(v128);
                    let v132: bool = true;
                    v130
                })
                .collect::<Vec<_>>();
            let v134: Vec<std::string::String> = _vec_map;
            v40.l0.set(string(""));
            {
                let v157: bool = true;
                v134.into_iter().for_each(|x| {
                    //;
                    let v159: std::string::String = x;
                    let v161: bool = true;
                    near_sdk::log!("{}", v159);
                    let v163: bool = true;
                    let v165: bool = true;
                }); //;
                ()
            }
            ((patternInput.1.clone()).l0.get().clone())(string(""))
        }
        pub fn closure15(v0_1: Func0<()>, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v19: () = {
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
                let v58: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v59: string = Chat_contract::method11();
                Chat_contract::method22()
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
            v8: near_sdk::AccountId,
            v9: Option<(std::string::String, u64, u32)>,
        ) -> string {
            let v11: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method12()),
            });
            let v25: () = {
                Chat_contract::closure7(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Chat_contract::closure7(v11.clone(), string("account_id"), ());
                ()
            };
            let v63: () = {
                Chat_contract::closure7(v11.clone(), string(" = "), ());
                ()
            };
            let v83: std::string::String = format!("{:#?}", v8);
            let v119: () = {
                Chat_contract::closure7(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v83),
                    (),
                );
                ()
            };
            let v138: () = {
                Chat_contract::closure7(v11.clone(), string("; "), ());
                ()
            };
            let v157: () = {
                Chat_contract::closure7(v11.clone(), string("result"), ());
                ()
            };
            let v174: () = {
                Chat_contract::closure7(v11.clone(), string(" = "), ());
                ()
            };
            let v194: std::string::String = format!("{:#?}", v9);
            let v230: () = {
                Chat_contract::closure7(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v194),
                    (),
                );
                ()
            };
            let v249: () = {
                Chat_contract::closure7(v11.clone(), string(" }"), ());
                ()
            };
            let v255: string = v11.l0.get().clone();
            Chat_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("chat_contract.get_account_info"),
                    )),
                    string(" / "),
                )),
                (v255),
            ))
        }
        pub fn closure16(
            v0_1: near_sdk::AccountId,
            v1: Option<(std::string::String, u64, u32)>,
            unitVar: (),
        ) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v20: () = {
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
                let v46: Option<i64> = patternInput.5.clone();
                let v45: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v44: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v43: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v42: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v41: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method16(Chat_contract::method23(
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    v46.clone(),
                    Chat_contract::method7(v41, v42, v43, v44, v45, v46),
                    Chat_contract::method11(),
                    v0_1,
                    v1,
                ))
            };
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v18: () = {
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
                let v57: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v58: string = Chat_contract::method11();
                Chat_contract::method22()
            };
        }
        pub fn method24(
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
            let v10: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                l0: MutCell::new(Chat_contract::method12()),
            });
            let v24: () = {
                Chat_contract::closure7(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Chat_contract::closure7(v10.clone(), string("alias"), ());
                ()
            };
            let v62: () = {
                Chat_contract::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v82: std::string::String = format!("{:#?}", v8);
            let v118: () = {
                Chat_contract::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v82),
                    (),
                );
                ()
            };
            let v137: () = {
                Chat_contract::closure7(v10.clone(), string(" }"), ());
                ()
            };
            let v143: string = v10.l0.get().clone();
            Chat_contract::method15(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("chat_contract.get_alias_map"),
                    )),
                    string(" / "),
                )),
                (v143),
            ))
        }
        pub fn closure18(v0_1: std::string::String, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v19: () = {
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
                let v45: Option<i64> = patternInput.5.clone();
                let v44: LrcPtr<Chat_contract::Mut4> = patternInput.4.clone();
                let v43: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
                let v42: LrcPtr<Chat_contract::Mut2> = patternInput.2.clone();
                let v41: LrcPtr<Chat_contract::Mut1> = patternInput.1.clone();
                let v40: LrcPtr<Chat_contract::Mut0> = patternInput.0.clone();
                Chat_contract::method16(Chat_contract::method24(
                    v40.clone(),
                    v41.clone(),
                    v42.clone(),
                    v43.clone(),
                    v44.clone(),
                    v45.clone(),
                    Chat_contract::method7(v40, v41, v42, v43, v44, v45),
                    Chat_contract::method11(),
                    v0_1,
                ))
            };
        }
        pub fn method25() -> Func0<()> {
            Func0::new(move || Chat_contract::closure14((), ()))
        }
        pub fn closure19(v0_1: Func0<()>, unitVar: ()) {
            if Chat_contract::method0(Chat_contract::US0::US0_1) {
                let v19: () = {
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
                let v58: string = Chat_contract::method7(
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                );
                let v59: string = Chat_contract::method11();
                Chat_contract::method22()
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
                        unsigned_varint::encode::u64(value, &mut buffer).to_vec() //;
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
                    let v265: () = {
                        Chat_contract::closure2(v184.clone(), v194.clone(), v196, v198, ());
                        ()
                    };
                    let v331: string = fable_library_rust::String_::fromString(v184.clone());
                    let v332: i32 = length(v331.clone());
                    let v396: bool = if (if (v332) > 0_i32 {
                        if (v332) < 64_i32 {
                            if (startsWith3(v331.clone(), string("-"), false)) == false {
                                if (endsWith3(v331.clone(), string("-"), false)) == false {
                                    let v357: &str = &*v331;
                                    let v381 = v357.chars();
                                    let v383: bool = true; // 1;
                                    let mut v381 = v381;
                                    v381.all(|x| {
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
                        let v395: bool = true;
                        near_sdk::env::panic_str(&*string(
                            "chat_contract.claim_alias / invalid alias",
                        )); //;
                        true
                    } else {
                        false
                    };
                    let v398: Option<&std::string::String> = v190.get(&v194.clone());
                    let v400: Option<std::string::String> = v398.cloned();
                    let v425: Chat_contract::US6 = defaultValue(
                        Chat_contract::US6::US6_1,
                        map(Chat_contract::method17(), v400.clone()),
                    );
                    if let Chat_contract::US6::US6_0(v425_0_0) = &v425 {
                        let v429: std::string::String = v425_0_0.clone();
                        if referenceEquals(&v429, &v184) {
                            let v500: () = {
                                Chat_contract::closure12(v429, ());
                                ()
                            };
                            ()
                        } else {
                            let v631: () = {
                                Chat_contract::closure13(v400.clone(), ());
                                ()
                            };
                            v192 //;
                                .get_mut(&v429) //;
                                .unwrap() //;
                                .remove(&v194.clone()); //;
                            v190.insert(v194.clone().clone(), v184.clone().clone()); //;
                            {
                                let v702: bool = v186.insert(v194.clone());
                                let v704: bool = v188.insert(v184.clone());
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
                        let v792: () = {
                            Chat_contract::closure13(v400, ());
                            ()
                        };
                        if let Chat_contract::US6::US6_1 = &v425 {
                            ()
                        } else {
                            panic!("{}", string("Match failure"),)
                        }
                        v190.insert(v194.clone().clone(), v184.clone().clone()); //;
                        {
                            let v859: bool = v186.insert(v194.clone());
                            let v861: bool = v188.insert(v184.clone());
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
                        let v945: () = {
                            Chat_contract::closure15(Chat_contract::method21(), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
        {
        let v1010: bool =
        true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy;
        let v1012: bool =
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
                    let v1020: &(
                        u32,
                        near_sdk::store::IterableSet<near_sdk::AccountId>,
                        near_sdk::store::IterableSet<std::string::String>,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                    ) = &self.0;
                    let v1022: near_sdk::AccountId = account_id;
                    let v1024: &near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &v1020.3;
                    let v1026: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &v1020.4;
                    let v1028: bool = true;
                    let result = v1024.get(&v1022.clone()).and_then(|alias| {
                        //;
                        let v1030: bool = true;
                        v1026.get(alias).map(|accounts| {
                            //;
                            let v1032: bool = true;
                            let result = (alias.clone(), *accounts.get(&v1022).unwrap()); //;
                            let v1034: bool = true;
                            (result.0, result.1.0, result.1.1)
                        })
                    }); //;
                    let v1036: Option<(std::string::String, u64, u32)> = result;
                    let v1099: () = {
                        Chat_contract::closure16(v1022, v1036.clone(), ());
                        ()
                    };
                    let v1221: () = {
                        Chat_contract::closure17((), ());
                        ()
                    };
                    v1036
                } // 4;
            } // 1;
        } /* c;
        {
        let v1284:
        bool =
        true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 1uy;
        let v1286:
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
                    let v1294: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0.4;
                    let v1296: std::string::String = alias;
                    let v1359: () = {
                        Chat_contract::closure18(v1296.clone(), ());
                        ()
                    };
                    let v1482: () = {
                        Chat_contract::closure19(Chat_contract::method25(), ());
                        ()
                    };
                    v1294.get(&v1296).cloned() //;
                } //;
            } //;
        } /* c;
        {
        let v1547:
        bool =
        true; // ??? / i: 7uy / i': 1uy / acc: 10uy / n: 2uy;
        let v1549:
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
        let v1561:
        bool =
        true; // ??? / i: 8uy / i': 1uy / acc: 12uy / n: 1uy;
        let v1563:
        bool =
        true; */
 // ???? / i: 8uy / i': 2uy / acc: 12uy / n: 1uy;
        fn _main() //;
        {
            {
                //;
                {
                    let v1567: bool = true;
                    {
                        (); // ?? / i': 1uy / n: 13uy;
                        let v1569: bool = true;
                        {
                            (); // ?? / i': 2uy / n: 13uy;
                            let v1571: bool = true;
                            {
                                (); // ?? / i': 3uy / n: 13uy;
                                let v1573: bool = true;
                                {
                                    (); // ?? / i': 4uy / n: 13uy;
                                    let v1575: bool = true;
                                    {
                                        (); // ?? / i': 5uy / n: 13uy;
                                        let v1577: bool = true;
                                        {
                                            (); // ?? / i': 6uy / n: 13uy;
                                            let v1579: bool = true;
                                            {
                                                (); // ?? / i': 7uy / n: 13uy;
                                                let v1581: bool = true;
                                                {
                                                    (); // ?? / i': 8uy / n: 13uy;
                                                    let v1583: bool = true;
                                                    {
                                                        (); // ?? / i': 9uy / n: 13uy;
                                                        let v1585: bool = true;
                                                        {
                                                            (); // ?? / i': 10uy / n: 13uy;
                                                            let v1587: bool = true;
                                                            {
                                                                (); // ?? / i': 11uy / n: 13uy;
                                                                let v1589: bool = true;
                                                                {
                                                                    (); // ?? / i': 12uy / n: 13uy;
                                                                    let v1591: bool = true;
                                                                    {
                                                                        (); // ?? / i': 13uy / n: 13uy;
                                                                        let v1593: bool = true;
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
pub use module_2e7a6383::*;
#[path = "../../../deps/spiral/lib/spiral/async__contract.rs"]
mod module_763b9e6c;
pub use module_763b9e6c::*;
#[path = "../../../deps/spiral/lib/spiral/common_contract.rs"]
mod module_18f1c018;
pub use module_18f1c018::*;
#[path = "../../../deps/spiral/lib/spiral/crypto_contract.rs"]
mod module_c0301e36;
pub use module_c0301e36::*;
#[path = "../../../deps/spiral/lib/spiral/date_time_contract.rs"]
mod module_e5abed0b;
pub use module_e5abed0b::*;
#[path = "../../../deps/spiral/lib/spiral/file_system_contract.rs"]
mod module_336d1dc9;
pub use module_336d1dc9::*;
#[path = "../../../deps/spiral/lib/spiral/lib_contract.rs"]
mod module_12dde172;
pub use module_12dde172::*;
#[path = "../../../deps/spiral/lib/spiral/networking_contract.rs"]
mod module_7e35832b;
pub use module_7e35832b::*;
#[path = "../../../deps/spiral/lib/spiral/platform_contract.rs"]
mod module_afd02cca;
pub use module_afd02cca::*;
#[path = "../../../deps/spiral/lib/spiral/runtime_contract.rs"]
mod module_a3c64389;
pub use module_a3c64389::*;
#[path = "../../../deps/spiral/lib/spiral/sm_contract.rs"]
mod module_8f227ecb;
pub use module_8f227ecb::*;
#[path = "../../../deps/spiral/lib/spiral/threading_contract.rs"]
mod module_e08c16fb;
pub use module_e08c16fb::*;
#[path = "../../../deps/spiral/lib/spiral/trace_contract.rs"]
mod module_702ddcb4;
pub use module_702ddcb4::*;
#[path = "../../../lib/fsharp/Common_contract.rs"]
mod module_eb7e4788;
pub use module_eb7e4788::*;
pub mod Polyglot {
    pub use crate::module_eb7e4788::Polyglot::*;
}
