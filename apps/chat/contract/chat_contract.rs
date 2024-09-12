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
        use fable_library_rust::Native_::refCell;
        use fable_library_rust::Native_::referenceEquals;
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
        pub fn closure4(
            v0_1: LrcPtr<MutCell<Option<Chat_contract::US1>>>,
            v1: Option<Chat_contract::US1>,
        ) -> LrcPtr<MutCell<Option<Chat_contract::US1>>> {
            v0_1.set(v1);
            v0_1
        }
        pub fn closure5(
            v0_1: Option<string>,
            v1: Func1<Option<Chat_contract::US1>, LrcPtr<MutCell<Option<Chat_contract::US1>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Chat_contract::US1>>> = v1(match &v0_1 {
                    None => None::<Chat_contract::US1>,
                    Some(v0_1_0_0) => {
                        let x: string = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Chat_contract::US1::US1_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
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
        pub fn method4() -> string {
            string("AUTOMATION")
        }
        pub fn closure6(unitVar: (), v0_1: string) {
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
            let v79: string = string("env!(\"AUTOMATION\")");
            let v80: &str = env!("AUTOMATION");
            let v82: std::string::String = String::from(v80);
            let _v1: (Chat_contract::US2, Chat_contract::US3) = (
                Chat_contract::US2::US2_1,
                if fable_library_rust::String_::fromString(v82) != string("True") {
                    Chat_contract::US3::US3_1
                } else {
                    Chat_contract::US3::US3_0(near_sdk::env::block_timestamp() as i64)
                },
            );
            let v295: Chat_contract::US3 = _v1.1.clone();
            let v294: Chat_contract::US2 = _v1.0.clone();
            (
                LrcPtr::new(Chat_contract::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Chat_contract::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Chat_contract::closure6((), v))),
                }),
                LrcPtr::new(Chat_contract::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Chat_contract::Mut4 {
                    l0: MutCell::new(match &v294 {
                        Chat_contract::US2::US2_0(v294_0_0) => match &v294 {
                            Chat_contract::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v295 {
                    Chat_contract::US3::US3_0(v295_0_0) => Some(match &v295 {
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
        pub fn closure7(v0_1: LrcPtr<Chat_contract::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure8(
            v0_1: LrcPtr<MutCell<Option<Chat_contract::US3>>>,
            v1: Option<Chat_contract::US3>,
        ) -> LrcPtr<MutCell<Option<Chat_contract::US3>>> {
            v0_1.set(v1);
            v0_1
        }
        pub fn closure9(
            v0_1: Option<i64>,
            v1: Func1<Option<Chat_contract::US3>, LrcPtr<MutCell<Option<Chat_contract::US3>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Chat_contract::US3>>> = v1(match &v0_1 {
                    None => None::<Chat_contract::US3>,
                    Some(v0_1_0_0) => {
                        let x: i64 = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Chat_contract::US3::US3_0(x)
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method5() -> string {
            string("hh:mm:ss")
        }
        pub fn method6() -> string {
            string("HH:mm:ss")
        }
        pub fn method7() -> string {
            string("\u{001b}[0m")
        }
        pub fn method8() -> string {
            string("")
        }
        pub fn closure10(v0_1: LrcPtr<Chat_contract::Mut3>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn closure12(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure11(unitVar: (), v0_1: string) {
            let v3: () = {
                Chat_contract::closure12(v0_1, ());
                ()
            };
            ()
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
            let v22: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v38: () = {
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
            let v70: Chat_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v70,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v78: () = {
                    Chat_contract::closure7(patternInput.0.clone(), ());
                    ()
                };
                let v82: () = {
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
                let v252: u64 = near_sdk::env::block_timestamp();
                let _v253: LrcPtr<MutCell<Option<Chat_contract::US3>>> =
                    refCell(None::<Chat_contract::US3>);
                let v258: () = {
                    Chat_contract::closure9(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v253 = _v253.clone();
                            move |v: Option<Chat_contract::US3>| {
                                Chat_contract::closure8(_v253.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v273: Chat_contract::US3 =
                    defaultValue(Chat_contract::US3::US3_1, _v253.get().clone());
                let v283: u64 = match &v273 {
                    Chat_contract::US3::US3_0(v273_0_0) => {
                        v252 - match &v273 {
                            Chat_contract::US3::US3_0(x) => x.clone(),
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
                let v572: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v610: &str = inline_colorization::color_bright_blue;
                let v612: &str = &*v572;
                let v614: &str = inline_colorization::color_reset;
                let v616: string = string("format!(\"{v610}{v612}{v614}\")");
                let v617: std::string::String = format!("{v610}{v612}{v614}");
                let v619: string = fable_library_rust::String_::fromString(v617);
                let v638: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v640: std::string::String = v1.to_string();
                let v642: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(Chat_contract::method8()),
                });
                let v649: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v658: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", string("alias")), ());
                    ()
                };
                let v667: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v680: std::string::String = format!("{:#?}", v0_1);
                let v702: () = {
                    Chat_contract::closure10(
                        v642.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v680)),
                        (),
                    );
                    ()
                };
                let v711: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v720: () = {
                    Chat_contract::closure10(
                        v642.clone(),
                        sprintf!("{}", string("block_timestamp")),
                        (),
                    );
                    ()
                };
                let v728: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v736: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", v2), ());
                    ()
                };
                let v744: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v753: () = {
                    Chat_contract::closure10(
                        v642.clone(),
                        sprintf!("{}", string("account_id")),
                        (),
                    );
                    ()
                };
                let v761: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v774: std::string::String = format!("{:#?}", v640);
                let v796: () = {
                    Chat_contract::closure10(
                        v642.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v774)),
                        (),
                    );
                    ()
                };
                let v805: () = {
                    Chat_contract::closure10(v642.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v867: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v292,
                            v619,
                            v638,
                            string("chat_contract.claim_alias"),
                            v642.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v881: string = if v22.l0.get().clone() == string("") {
                    v867.clone()
                } else {
                    if v867.clone() == string("") {
                        v22.l0.get().clone()
                    } else {
                        append(append(v22.l0.get().clone(), string("\n")), v867.clone())
                    }
                };
                let v883: &str = &*v881.clone();
                let v885 = v883.chars();
                let v887 = v885;
                let v889: Vec<char> = v887.collect::<Vec<_>>();
                let v891: Vec<Vec<char>> = v889
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v893: bool = true;
                let _vec_map: Vec<_> = v891
                    .into_iter()
                    .map(|x| {
                        //;
                        let v895: Vec<char> = x;
                        let v897: std::string::String = String::from_iter(v895);
                        let v899: bool = true;
                        v897
                    })
                    .collect::<Vec<_>>();
                let v901: Vec<std::string::String> = _vec_map;
                if if v867.clone() != string("") {
                    v901.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v22.l0.set(v881);
                    ()
                } else {
                    v22.l0.set(string(""));
                    {
                        let v913: bool = true;
                        v901.into_iter().for_each(|x| {
                            //;
                            let v915: std::string::String = x;
                            near_sdk::log!("{}", v915);
                            {
                                let v918: bool = true;
                                let v920: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v867)
            }
        }
        pub fn closure13(
            v0_1: LrcPtr<MutCell<Option<Chat_contract::US4>>>,
            v1: Option<Chat_contract::US4>,
        ) -> LrcPtr<MutCell<Option<Chat_contract::US4>>> {
            v0_1.set(v1);
            v0_1
        }
        pub fn closure14(
            v0_1: Option<std::string::String>,
            v1: Func1<Option<Chat_contract::US4>, LrcPtr<MutCell<Option<Chat_contract::US4>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Chat_contract::US4>>> = v1(match &v0_1 {
                    None => None::<Chat_contract::US4>,
                    Some(v0_1_0_0) => {
                        let x: std::string::String = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Chat_contract::US4::US4_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn closure15(v0_1: std::string::String, unitVar: ()) {
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
            let v20: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v36: () = {
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
            let v68: Chat_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Chat_contract::closure7(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
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
                let v250: u64 = near_sdk::env::block_timestamp();
                let _v251: LrcPtr<MutCell<Option<Chat_contract::US3>>> =
                    refCell(None::<Chat_contract::US3>);
                let v256: () = {
                    Chat_contract::closure9(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v251 = _v251.clone();
                            move |v: Option<Chat_contract::US3>| {
                                Chat_contract::closure8(_v251.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v271: Chat_contract::US3 =
                    defaultValue(Chat_contract::US3::US3_1, _v251.get().clone());
                let v281: u64 = match &v271 {
                    Chat_contract::US3::US3_0(v271_0_0) => {
                        v250 - match &v271 {
                            Chat_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v250,
                } / 1000000000_u64;
                let v282: u64 = v281 % 60_u64;
                let v284: u64 = v281 / 60_u64 % 60_u64;
                let v286: u64 = v281 / 3600_u64 % 24_u64;
                let v288: std::string::String = format!("{:02}:{:02}:{:02}", v286, v284, v282);
                let v290: string = fable_library_rust::String_::fromString(v288);
                let v570: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
                let v608: &str = inline_colorization::color_yellow;
                let v610: &str = &*v570;
                let v612: &str = inline_colorization::color_reset;
                let v614: string = string("format!(\"{v608}{v610}{v612}\")");
                let v615: std::string::String = format!("{v608}{v610}{v612}");
                let v617: string = fable_library_rust::String_::fromString(v615);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: string = sprintf!("{:?}", v0_1);
                let v641: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(Chat_contract::method8()),
                });
                let v648: () = {
                    Chat_contract::closure10(v641.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v657: () = {
                    Chat_contract::closure10(
                        v641.clone(),
                        sprintf!("{}", string("account_alias")),
                        (),
                    );
                    ()
                };
                let v666: () = {
                    Chat_contract::closure10(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Chat_contract::closure10(v641.clone(), sprintf!("{}", v637), ());
                    ()
                };
                let v683: () = {
                    Chat_contract::closure10(v641.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v745: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v290,
                            v617,
                            v636,
                            string("chat_contract.claim_alias / alias already claimed"),
                            v641.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v759: string = if v20.l0.get().clone() == string("") {
                    v745.clone()
                } else {
                    if v745.clone() == string("") {
                        v20.l0.get().clone()
                    } else {
                        append(append(v20.l0.get().clone(), string("\n")), v745.clone())
                    }
                };
                let v761: &str = &*v759.clone();
                let v763 = v761.chars();
                let v765 = v763;
                let v767: Vec<char> = v765.collect::<Vec<_>>();
                let v769: Vec<Vec<char>> = v767
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v771: bool = true;
                let _vec_map: Vec<_> = v769
                    .into_iter()
                    .map(|x| {
                        //;
                        let v773: Vec<char> = x;
                        let v775: std::string::String = String::from_iter(v773);
                        let v777: bool = true;
                        v775
                    })
                    .collect::<Vec<_>>();
                let v779: Vec<std::string::String> = _vec_map;
                if if v745.clone() != string("") {
                    v779.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v20.l0.set(v759);
                    ()
                } else {
                    v20.l0.set(string(""));
                    {
                        let v791: bool = true;
                        v779.into_iter().for_each(|x| {
                            //;
                            let v793: std::string::String = x;
                            near_sdk::log!("{}", v793);
                            {
                                let v796: bool = true;
                                let v798: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v745)
            }
        }
        pub fn closure16(v0_1: Option<std::string::String>, unitVar: ()) {
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
            let v20: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v36: () = {
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
            let v68: Chat_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Chat_contract::closure7(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
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
                let v250: u64 = near_sdk::env::block_timestamp();
                let _v251: LrcPtr<MutCell<Option<Chat_contract::US3>>> =
                    refCell(None::<Chat_contract::US3>);
                let v256: () = {
                    Chat_contract::closure9(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v251 = _v251.clone();
                            move |v: Option<Chat_contract::US3>| {
                                Chat_contract::closure8(_v251.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v271: Chat_contract::US3 =
                    defaultValue(Chat_contract::US3::US3_1, _v251.get().clone());
                let v281: u64 = match &v271 {
                    Chat_contract::US3::US3_0(v271_0_0) => {
                        v250 - match &v271 {
                            Chat_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v250,
                } / 1000000000_u64;
                let v282: u64 = v281 % 60_u64;
                let v284: u64 = v281 / 60_u64 % 60_u64;
                let v286: u64 = v281 / 3600_u64 % 24_u64;
                let v288: std::string::String = format!("{:02}:{:02}:{:02}", v286, v284, v282);
                let v290: string = fable_library_rust::String_::fromString(v288);
                let v570: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v608: &str = inline_colorization::color_bright_blue;
                let v610: &str = &*v570;
                let v612: &str = inline_colorization::color_reset;
                let v614: string = string("format!(\"{v608}{v610}{v612}\")");
                let v615: std::string::String = format!("{v608}{v610}{v612}");
                let v617: string = fable_library_rust::String_::fromString(v615);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: string = sprintf!("{:?}", v0_1);
                let v641: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(Chat_contract::method8()),
                });
                let v648: () = {
                    Chat_contract::closure10(v641.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v657: () = {
                    Chat_contract::closure10(
                        v641.clone(),
                        sprintf!("{}", string("account_alias")),
                        (),
                    );
                    ()
                };
                let v666: () = {
                    Chat_contract::closure10(v641.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v674: () = {
                    Chat_contract::closure10(v641.clone(), sprintf!("{}", v637), ());
                    ()
                };
                let v683: () = {
                    Chat_contract::closure10(v641.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v745: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v290,
                            v617,
                            v636,
                            string("chat_contract.claim_alias"),
                            v641.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v759: string = if v20.l0.get().clone() == string("") {
                    v745.clone()
                } else {
                    if v745.clone() == string("") {
                        v20.l0.get().clone()
                    } else {
                        append(append(v20.l0.get().clone(), string("\n")), v745.clone())
                    }
                };
                let v761: &str = &*v759.clone();
                let v763 = v761.chars();
                let v765 = v763;
                let v767: Vec<char> = v765.collect::<Vec<_>>();
                let v769: Vec<Vec<char>> = v767
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v771: bool = true;
                let _vec_map: Vec<_> = v769
                    .into_iter()
                    .map(|x| {
                        //;
                        let v773: Vec<char> = x;
                        let v775: std::string::String = String::from_iter(v773);
                        let v777: bool = true;
                        v775
                    })
                    .collect::<Vec<_>>();
                let v779: Vec<std::string::String> = _vec_map;
                if if v745.clone() != string("") {
                    v779.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v20.l0.set(v759);
                    ()
                } else {
                    v20.l0.set(string(""));
                    {
                        let v791: bool = true;
                        v779.into_iter().for_each(|x| {
                            //;
                            let v793: std::string::String = x;
                            near_sdk::log!("{}", v793);
                            {
                                let v796: bool = true;
                                let v798: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v745)
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
            let v19: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v35: () = {
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
            let v67: Chat_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v75: () = {
                    Chat_contract::closure7(patternInput.0.clone(), ());
                    ()
                };
                let v79: () = {
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
                let v249: u64 = near_sdk::env::block_timestamp();
                let _v250: LrcPtr<MutCell<Option<Chat_contract::US3>>> =
                    refCell(None::<Chat_contract::US3>);
                let v255: () = {
                    Chat_contract::closure9(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v250 = _v250.clone();
                            move |v: Option<Chat_contract::US3>| {
                                Chat_contract::closure8(_v250.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v270: Chat_contract::US3 =
                    defaultValue(Chat_contract::US3::US3_1, _v250.get().clone());
                let v280: u64 = match &v270 {
                    Chat_contract::US3::US3_0(v270_0_0) => {
                        v249 - match &v270 {
                            Chat_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v249,
                } / 1000000000_u64;
                let v281: u64 = v280 % 60_u64;
                let v283: u64 = v280 / 60_u64 % 60_u64;
                let v285: u64 = v280 / 3600_u64 % 24_u64;
                let v287: std::string::String = format!("{:02}:{:02}:{:02}", v285, v283, v281);
                let v289: string = fable_library_rust::String_::fromString(v287);
                let v569: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v607: &str = inline_colorization::color_bright_blue;
                let v609: &str = &*v569;
                let v611: &str = inline_colorization::color_reset;
                let v613: string = string("format!(\"{v607}{v609}{v611}\")");
                let v614: std::string::String = format!("{v607}{v609}{v611}");
                let v616: string = fable_library_rust::String_::fromString(v614);
                let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(Chat_contract::method8()),
                });
                let v638: string = v637.l0.get().clone();
                let v653: string = if v19.l0.get().clone() == string("") {
                    string("")
                } else {
                    v19.l0.get().clone()
                };
                let v655: &str = &*v653;
                let v657 = v655.chars();
                let v659 = v657;
                let v661: Vec<char> = v659.collect::<Vec<_>>();
                let v663: Vec<Vec<char>> = v661
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v665: bool = true;
                let _vec_map: Vec<_> = v663
                    .into_iter()
                    .map(|x| {
                        //;
                        let v667: Vec<char> = x;
                        let v669: std::string::String = String::from_iter(v667);
                        let v671: bool = true;
                        v669
                    })
                    .collect::<Vec<_>>();
                let v673: Vec<std::string::String> = _vec_map;
                v19.l0.set(string(""));
                {
                    let v684: bool = true;
                    v673.into_iter().for_each(|x| {
                        //;
                        let v686: std::string::String = x;
                        near_sdk::log!("{}", v686);
                        {
                            let v689: bool = true;
                            let v691: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(string(""))
            }
        }
        pub fn closure18(v0_1: near_sdk::AccountId, unitVar: ()) {
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
            let v20: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v36: () = {
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
            let v68: Chat_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Chat_contract::closure7(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
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
                let v250: u64 = near_sdk::env::block_timestamp();
                let _v251: LrcPtr<MutCell<Option<Chat_contract::US3>>> =
                    refCell(None::<Chat_contract::US3>);
                let v256: () = {
                    Chat_contract::closure9(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v251 = _v251.clone();
                            move |v: Option<Chat_contract::US3>| {
                                Chat_contract::closure8(_v251.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v271: Chat_contract::US3 =
                    defaultValue(Chat_contract::US3::US3_1, _v251.get().clone());
                let v281: u64 = match &v271 {
                    Chat_contract::US3::US3_0(v271_0_0) => {
                        v250 - match &v271 {
                            Chat_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v250,
                } / 1000000000_u64;
                let v282: u64 = v281 % 60_u64;
                let v284: u64 = v281 / 60_u64 % 60_u64;
                let v286: u64 = v281 / 3600_u64 % 24_u64;
                let v288: std::string::String = format!("{:02}:{:02}:{:02}", v286, v284, v282);
                let v290: string = fable_library_rust::String_::fromString(v288);
                let v570: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v608: &str = inline_colorization::color_bright_blue;
                let v610: &str = &*v570;
                let v612: &str = inline_colorization::color_reset;
                let v614: string = string("format!(\"{v608}{v610}{v612}\")");
                let v615: std::string::String = format!("{v608}{v610}{v612}");
                let v617: string = fable_library_rust::String_::fromString(v615);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(Chat_contract::method8()),
                });
                let v645: () = {
                    Chat_contract::closure10(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Chat_contract::closure10(
                        v638.clone(),
                        sprintf!("{}", string("account_id")),
                        (),
                    );
                    ()
                };
                let v663: () = {
                    Chat_contract::closure10(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v676: std::string::String = format!("{:#?}", v0_1);
                let v698: () = {
                    Chat_contract::closure10(
                        v638.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v676)),
                        (),
                    );
                    ()
                };
                let v707: () = {
                    Chat_contract::closure10(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v769: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v290,
                            v617,
                            v636,
                            string("chat_contract.get_account_info"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v783: string = if v20.l0.get().clone() == string("") {
                    v769.clone()
                } else {
                    if v769.clone() == string("") {
                        v20.l0.get().clone()
                    } else {
                        append(append(v20.l0.get().clone(), string("\n")), v769.clone())
                    }
                };
                let v785: &str = &*v783.clone();
                let v787 = v785.chars();
                let v789 = v787;
                let v791: Vec<char> = v789.collect::<Vec<_>>();
                let v793: Vec<Vec<char>> = v791
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v795: bool = true;
                let _vec_map: Vec<_> = v793
                    .into_iter()
                    .map(|x| {
                        //;
                        let v797: Vec<char> = x;
                        let v799: std::string::String = String::from_iter(v797);
                        let v801: bool = true;
                        v799
                    })
                    .collect::<Vec<_>>();
                let v803: Vec<std::string::String> = _vec_map;
                if if v769.clone() != string("") {
                    v803.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v20.l0.set(v783);
                    ()
                } else {
                    v20.l0.set(string(""));
                    {
                        let v815: bool = true;
                        v803.into_iter().for_each(|x| {
                            //;
                            let v817: std::string::String = x;
                            near_sdk::log!("{}", v817);
                            {
                                let v820: bool = true;
                                let v822: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v769)
            }
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) {
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
            let v19: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v35: () = {
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
            let v67: Chat_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v75: () = {
                    Chat_contract::closure7(patternInput.0.clone(), ());
                    ()
                };
                let v79: () = {
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
                let v249: u64 = near_sdk::env::block_timestamp();
                let _v250: LrcPtr<MutCell<Option<Chat_contract::US3>>> =
                    refCell(None::<Chat_contract::US3>);
                let v255: () = {
                    Chat_contract::closure9(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v250 = _v250.clone();
                            move |v: Option<Chat_contract::US3>| {
                                Chat_contract::closure8(_v250.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v270: Chat_contract::US3 =
                    defaultValue(Chat_contract::US3::US3_1, _v250.get().clone());
                let v280: u64 = match &v270 {
                    Chat_contract::US3::US3_0(v270_0_0) => {
                        v249 - match &v270 {
                            Chat_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v249,
                } / 1000000000_u64;
                let v281: u64 = v280 % 60_u64;
                let v283: u64 = v280 / 60_u64 % 60_u64;
                let v285: u64 = v280 / 3600_u64 % 24_u64;
                let v287: std::string::String = format!("{:02}:{:02}:{:02}", v285, v283, v281);
                let v289: string = fable_library_rust::String_::fromString(v287);
                let v569: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v607: &str = inline_colorization::color_bright_blue;
                let v609: &str = &*v569;
                let v611: &str = inline_colorization::color_reset;
                let v613: string = string("format!(\"{v607}{v609}{v611}\")");
                let v614: std::string::String = format!("{v607}{v609}{v611}");
                let v616: string = fable_library_rust::String_::fromString(v614);
                let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(Chat_contract::method8()),
                });
                let v638: string = v637.l0.get().clone();
                let v653: string = if v19.l0.get().clone() == string("") {
                    string("")
                } else {
                    v19.l0.get().clone()
                };
                let v655: &str = &*v653;
                let v657 = v655.chars();
                let v659 = v657;
                let v661: Vec<char> = v659.collect::<Vec<_>>();
                let v663: Vec<Vec<char>> = v661
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v665: bool = true;
                let _vec_map: Vec<_> = v663
                    .into_iter()
                    .map(|x| {
                        //;
                        let v667: Vec<char> = x;
                        let v669: std::string::String = String::from_iter(v667);
                        let v671: bool = true;
                        v669
                    })
                    .collect::<Vec<_>>();
                let v673: Vec<std::string::String> = _vec_map;
                v19.l0.set(string(""));
                {
                    let v684: bool = true;
                    v673.into_iter().for_each(|x| {
                        //;
                        let v686: std::string::String = x;
                        near_sdk::log!("{}", v686);
                        {
                            let v689: bool = true;
                            let v691: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(string(""))
            }
        }
        pub fn closure20(v0_1: std::string::String, unitVar: ()) {
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
            let v20: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v36: () = {
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
            let v68: Chat_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v68,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v76: () = {
                    Chat_contract::closure7(patternInput.0.clone(), ());
                    ()
                };
                let v80: () = {
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
                let v250: u64 = near_sdk::env::block_timestamp();
                let _v251: LrcPtr<MutCell<Option<Chat_contract::US3>>> =
                    refCell(None::<Chat_contract::US3>);
                let v256: () = {
                    Chat_contract::closure9(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v251 = _v251.clone();
                            move |v: Option<Chat_contract::US3>| {
                                Chat_contract::closure8(_v251.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v271: Chat_contract::US3 =
                    defaultValue(Chat_contract::US3::US3_1, _v251.get().clone());
                let v281: u64 = match &v271 {
                    Chat_contract::US3::US3_0(v271_0_0) => {
                        v250 - match &v271 {
                            Chat_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v250,
                } / 1000000000_u64;
                let v282: u64 = v281 % 60_u64;
                let v284: u64 = v281 / 60_u64 % 60_u64;
                let v286: u64 = v281 / 3600_u64 % 24_u64;
                let v288: std::string::String = format!("{:02}:{:02}:{:02}", v286, v284, v282);
                let v290: string = fable_library_rust::String_::fromString(v288);
                let v570: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v608: &str = inline_colorization::color_bright_blue;
                let v610: &str = &*v570;
                let v612: &str = inline_colorization::color_reset;
                let v614: string = string("format!(\"{v608}{v610}{v612}\")");
                let v615: std::string::String = format!("{v608}{v610}{v612}");
                let v617: string = fable_library_rust::String_::fromString(v615);
                let v636: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v638: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(Chat_contract::method8()),
                });
                let v645: () = {
                    Chat_contract::closure10(v638.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v654: () = {
                    Chat_contract::closure10(v638.clone(), sprintf!("{}", string("alias")), ());
                    ()
                };
                let v663: () = {
                    Chat_contract::closure10(v638.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v676: std::string::String = format!("{:#?}", v0_1);
                let v698: () = {
                    Chat_contract::closure10(
                        v638.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v676)),
                        (),
                    );
                    ()
                };
                let v707: () = {
                    Chat_contract::closure10(v638.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v769: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v290,
                            v617,
                            v636,
                            string("chat_contract.get_alias_map"),
                            v638.l0.get().clone()
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                let v783: string = if v20.l0.get().clone() == string("") {
                    v769.clone()
                } else {
                    if v769.clone() == string("") {
                        v20.l0.get().clone()
                    } else {
                        append(append(v20.l0.get().clone(), string("\n")), v769.clone())
                    }
                };
                let v785: &str = &*v783.clone();
                let v787 = v785.chars();
                let v789 = v787;
                let v791: Vec<char> = v789.collect::<Vec<_>>();
                let v793: Vec<Vec<char>> = v791
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v795: bool = true;
                let _vec_map: Vec<_> = v793
                    .into_iter()
                    .map(|x| {
                        //;
                        let v797: Vec<char> = x;
                        let v799: std::string::String = String::from_iter(v797);
                        let v801: bool = true;
                        v799
                    })
                    .collect::<Vec<_>>();
                let v803: Vec<std::string::String> = _vec_map;
                if if v769.clone() != string("") {
                    v803.clone().len() as i32 <= 1_i32
                } else {
                    false
                } {
                    v20.l0.set(v783);
                    ()
                } else {
                    v20.l0.set(string(""));
                    {
                        let v815: bool = true;
                        v803.into_iter().for_each(|x| {
                            //;
                            let v817: std::string::String = x;
                            near_sdk::log!("{}", v817);
                            {
                                let v820: bool = true;
                                let v822: bool = true;
                            }
                        });
                        {
                            //;
                            ()
                        }
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(v769)
            }
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) {
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
            let v19: LrcPtr<Chat_contract::Mut3> = patternInput.3.clone();
            let v35: () = {
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
            let v67: Chat_contract::US0 = (patternInput_1.4.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v67,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Chat_contract::US0::US0_0, 0_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_1, 1_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_2, 2_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_3, 3_i32)),
                            LrcPtr::new((Chat_contract::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v75: () = {
                    Chat_contract::closure7(patternInput.0.clone(), ());
                    ()
                };
                let v79: () = {
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
                let v249: u64 = near_sdk::env::block_timestamp();
                let _v250: LrcPtr<MutCell<Option<Chat_contract::US3>>> =
                    refCell(None::<Chat_contract::US3>);
                let v255: () = {
                    Chat_contract::closure9(
                        patternInput_2.5.clone(),
                        Func1::new({
                            let _v250 = _v250.clone();
                            move |v: Option<Chat_contract::US3>| {
                                Chat_contract::closure8(_v250.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v270: Chat_contract::US3 =
                    defaultValue(Chat_contract::US3::US3_1, _v250.get().clone());
                let v280: u64 = match &v270 {
                    Chat_contract::US3::US3_0(v270_0_0) => {
                        v249 - match &v270 {
                            Chat_contract::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        } as u64
                    }
                    _ => v249,
                } / 1000000000_u64;
                let v281: u64 = v280 % 60_u64;
                let v283: u64 = v280 / 60_u64 % 60_u64;
                let v285: u64 = v280 / 3600_u64 % 24_u64;
                let v287: std::string::String = format!("{:02}:{:02}:{:02}", v285, v283, v281);
                let v289: string = fable_library_rust::String_::fromString(v287);
                let v569: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v607: &str = inline_colorization::color_bright_blue;
                let v609: &str = &*v569;
                let v611: &str = inline_colorization::color_reset;
                let v613: string = string("format!(\"{v607}{v609}{v611}\")");
                let v614: std::string::String = format!("{v607}{v609}{v611}");
                let v616: string = fable_library_rust::String_::fromString(v614);
                let v635: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v637: LrcPtr<Chat_contract::Mut3> = LrcPtr::new(Chat_contract::Mut3 {
                    l0: MutCell::new(Chat_contract::method8()),
                });
                let v638: string = v637.l0.get().clone();
                let v653: string = if v19.l0.get().clone() == string("") {
                    string("")
                } else {
                    v19.l0.get().clone()
                };
                let v655: &str = &*v653;
                let v657 = v655.chars();
                let v659 = v657;
                let v661: Vec<char> = v659.collect::<Vec<_>>();
                let v663: Vec<Vec<char>> = v661
                    .chunks(15000)
                    .map(|x| x.into_iter().map(|x| x.clone()).collect::<Vec<_>>())
                    .collect::<Vec<_>>();
                let v665: bool = true;
                let _vec_map: Vec<_> = v663
                    .into_iter()
                    .map(|x| {
                        //;
                        let v667: Vec<char> = x;
                        let v669: std::string::String = String::from_iter(v667);
                        let v671: bool = true;
                        v669
                    })
                    .collect::<Vec<_>>();
                let v673: Vec<std::string::String> = _vec_map;
                v19.l0.set(string(""));
                {
                    let v684: bool = true;
                    v673.into_iter().for_each(|x| {
                        //;
                        let v686: std::string::String = x;
                        near_sdk::log!("{}", v686);
                        {
                            let v689: bool = true;
                            let v691: bool = true;
                        }
                    });
                    {
                        //;
                        ()
                    }
                }
                ();
                ((patternInput.1.clone()).l0.get().clone())(string(""))
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
                                        let v59: &str = &*v47;
                                        let v61 = v59.chars();
                                        let v63: bool = true; // 1;
                                        let mut v61 = v61;
                                        v61.all(|x| {
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
              let v75: bool =
                  true; // ??? / i: 2uy / i': 1uy / acc: 2uy / n: 1uy;
              let v77: bool =
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
                    let v85: Vec<u8> = content;
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
                    let hash_result = sha256_hash(&v85); //;
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
              let v110: bool =
                  true; // ??? / i: 3uy / i': 1uy / acc: 3uy / n: 2uy;
              let v112: bool =
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
              let v124: bool =
                  true; // ??? / i: 4uy / i': 1uy / acc: 5uy / n: 1uy;
              let v126: bool =
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
                    let v134: &mut (
                        u32,
                        near_sdk::store::LookupMap<
                            std::string::String,
                            std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                        >,
                        near_sdk::store::LookupMap<near_sdk::AccountId, std::string::String>,
                    ) = &mut self.0;
                    let v136: std::string::String = alias;
                    let v138: &mut near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &mut v134.2;
                    let v140: &mut near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &mut v134.1;
                    let v142: near_sdk::AccountId = near_sdk::env::signer_account_id();
                    let v144: u64 = near_sdk::env::block_timestamp();
                    let v147: () = {
                        Chat_contract::closure2(v136.clone(), v142.clone(), v144, ());
                        ()
                    };
                    let v1068: string = fable_library_rust::String_::fromString(v136.clone());
                    let v1069: i32 = length(v1068.clone());
                    let v1097: bool = if (if v1069 > 0_i32 {
                        if v1069 < 64_i32 {
                            if startsWith(v1068.clone(), string("-"), false) == false {
                                if endsWith(v1068.clone(), string("-"), false) == false {
                                    let v1080: &str = &*v1068;
                                    let v1082 = v1080.chars();
                                    let v1084: bool = true; // 1;
                                    let mut v1082 = v1082;
                                    v1082.all(|x| {
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
                        let v1096: bool = true;
                        near_sdk::env::panic_str(&*string(
                            "chat_contract.claim_alias / invalid alias",
                        )); //;
                        true
                    } else {
                        false
                    };
                    let v1099: Option<&std::string::String> = v138.get(&v142.clone());
                    let v1101: Option<std::string::String> = v1099.cloned();
                    let _v1102: LrcPtr<MutCell<Option<Chat_contract::US4>>> =
                        refCell(None::<Chat_contract::US4>);
                    let v1107: () = {
                        Chat_contract::closure14(
                            v1101.clone(),
                            Func1::new({
                                let _v1102 = _v1102.clone();
                                move |v_2: Option<Chat_contract::US4>| {
                                    Chat_contract::closure13(_v1102.clone(), v_2)
                                }
                            }),
                            (),
                        );
                        ()
                    };
                    let v1122: Chat_contract::US4 =
                        defaultValue(Chat_contract::US4::US4_1, _v1102.get().clone());
                    if let Chat_contract::US4::US4_0(v1122_0_0) = &v1122 {
                        let v1126: std::string::String = match &v1122 {
                            Chat_contract::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if referenceEquals(&v1126, &v136) {
                            let v1132: () = {
                                Chat_contract::closure15(v1126, ());
                                ()
                            };
                            ()
                        } else {
                            let v1934: () = {
                                Chat_contract::closure16(v1101.clone(), ());
                                ()
                            };
                            v140 //;
                                .get_mut(&v1126) //;
                                .unwrap() //;
                                .remove(&v142.clone()); //;
                            v138.insert(v142.clone().clone(), v136.clone()); //;
                            let new_alias_account_map = match v140.get(&v136) {
                                //;
                                None => {
                                    //;
                                    let mut new_map = std::collections::HashMap::new(); //;
                                    new_map.insert(v142.clone(), (v144, 0u32)); //;
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
                                    new_map.insert(v142, (v144, accounts_vec.len() as u32)); //;
                                    new_map //;
                                } //;
                            }; //;
                            v140.insert(v136, new_alias_account_map); //;
                            ()
                        }
                    } else {
                        let v2762: () = {
                            Chat_contract::closure16(v1101, ());
                            ()
                        };
                        if let Chat_contract::US4::US4_1 = &v1122 {
                            ()
                        } else {
                            panic!("{}", string("Match failure"),)
                        }
                        v138.insert(v142.clone().clone(), v136.clone()); //;
                        let new_alias_account_map = match v140.get(&v136) {
                            //;
                            None => {
                                //;
                                let mut new_map = std::collections::HashMap::new(); //;
                                new_map.insert(v142, (v144, 0u32)); //;
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
                                new_map.insert(v142, (v144, accounts_vec.len() as u32)); //;
                                new_map //;
                            } //;
                        }; //;
                        v140.insert(v136, new_alias_account_map); //;
                        ()
                    }
                    {
                        let v3586: () = {
                            Chat_contract::closure17((), ());
                            ()
                        };
                    } //;
                } //;
            } //;
        } /* c;
          {
              let v4285: bool =
                  true; // ??? / i: 5uy / i': 1uy / acc: 6uy / n: 3uy;
              let v4287: bool =
                  true; */
 // ???? / i: 5uy / i': 2uy / acc: 6uy / n: 3uy;
        #[near_sdk::near_bindgen] //;
        impl State {
            //;
            pub fn get_account_info(
                //;
                &self,                           //;
                account_id: near_sdk::AccountId, //;
            ) -> Option<(String, (u64, u32))> {
                //;
                {
                    let v4295: &near_sdk::store::LookupMap<
                        near_sdk::AccountId,
                        std::string::String,
                    > = &self.0 .2;
                    let v4297: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0 .1;
                    let v4299: near_sdk::AccountId = account_id;
                    let v4302: () = {
                        Chat_contract::closure18(v4299.clone(), ());
                        ()
                    };
                    let v5128: () = {
                        Chat_contract::closure19((), ());
                        ()
                    };
                    v4295.get(&v4299).and_then(|alias| { //;
                                                                v4297 //;
                                                                  .get(alias) //;
                                                                  .map(|accounts| (alias.clone(), *accounts.get(&v4299).unwrap())) //;
                                                              }) //;
                } //;
            } //;
        } /* c;
          {
              let v5831:
                      bool =
                  true; // ??? / i: 6uy / i': 1uy / acc: 9uy / n: 2uy;
              let v5833:
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
                    let v5841: &near_sdk::store::LookupMap<
                        std::string::String,
                        std::collections::HashMap<near_sdk::AccountId, (u64, u32)>,
                    > = &self.0 .1;
                    let v5843: std::string::String = alias;
                    let v5846: () = {
                        Chat_contract::closure20(v5843.clone(), ());
                        ()
                    };
                    let v6672: () = {
                        Chat_contract::closure21((), ());
                        ()
                    };
                    v5841.get(&v5843).cloned() //;
                } //;
            } //;
        } /* c;
          {
              let v7371:
                      bool =
                  true; // ??? / i: 7uy / i': 1uy / acc: 11uy / n: 2uy;
              let v7373:
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
              let v7385:
                      bool =
                  true; // ??? / i: 8uy / i': 1uy / acc: 13uy / n: 1uy;
              let v7387:
                      bool =
                  true; */
 // ???? / i: 8uy / i': 2uy / acc: 13uy / n: 1uy;
        fn _main() //;
        {
            //;
            {
                let v7391: bool = true;
                {
                    (); // ?? / i': 1uy / n: 14uy;
                    let v7393: bool = true;
                    {
                        (); // ?? / i': 2uy / n: 14uy;
                        let v7395: bool = true;
                        {
                            (); // ?? / i': 3uy / n: 14uy;
                            let v7397: bool = true;
                            {
                                (); // ?? / i': 4uy / n: 14uy;
                                let v7399: bool = true;
                                {
                                    (); // ?? / i': 5uy / n: 14uy;
                                    let v7401: bool = true;
                                    {
                                        (); // ?? / i': 6uy / n: 14uy;
                                        let v7403: bool = true;
                                        {
                                            (); // ?? / i': 7uy / n: 14uy;
                                            let v7405: bool = true;
                                            {
                                                (); // ?? / i': 8uy / n: 14uy;
                                                let v7407: bool = true;
                                                {
                                                    (); // ?? / i': 9uy / n: 14uy;
                                                    let v7409: bool = true;
                                                    {
                                                        (); // ?? / i': 10uy / n: 14uy;
                                                        let v7411: bool = true;
                                                        {
                                                            (); // ?? / i': 11uy / n: 14uy;
                                                            let v7413: bool = true;
                                                            {
                                                                (); // ?? / i': 12uy / n: 14uy;
                                                                let v7415: bool = true;
                                                                {
                                                                    (); // ?? / i': 13uy / n: 14uy;
                                                                    let v7417: bool = true;
                                                                    {
                                                                        (); // ?? / i': 14uy / n: 14uy;
                                                                        let v7419: bool = true;
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
