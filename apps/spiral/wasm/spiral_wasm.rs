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
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_fb49c4a9 {
    pub mod Spiral_wasm {
        use super::*;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::refCell;
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
        use fable_library_rust::String_::padLeft;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::split;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::startsWith;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        pub mod State {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Spiral_wasm::Mut0>,
                        LrcPtr<Spiral_wasm::Mut1>,
                        LrcPtr<Spiral_wasm::Mut2>,
                        LrcPtr<Spiral_wasm::Mut3>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Spiral_wasm::Mut0>,
                                LrcPtr<Spiral_wasm::Mut1>,
                                LrcPtr<Spiral_wasm::Mut2>,
                                LrcPtr<Spiral_wasm::Mut3>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Spiral_wasm::Mut0>,
                                LrcPtr<Spiral_wasm::Mut1>,
                                LrcPtr<Spiral_wasm::Mut2>,
                                LrcPtr<Spiral_wasm::Mut3>,
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
        #[derive(Clone, Debug)]
        pub enum US0 {
            US0_0(std::string::String),
            US0_1,
        }
        impl core::fmt::Display for Spiral_wasm::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
            US3_3,
            US3_4,
        }
        impl core::fmt::Display for Spiral_wasm::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Spiral_wasm::US3),
            US2_1,
        }
        impl core::fmt::Display for Spiral_wasm::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(Spiral_wasm::US2),
            US1_1,
        }
        impl core::fmt::Display for Spiral_wasm::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut3 {
            pub l0: MutCell<Spiral_wasm::US3>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(string),
            US4_1,
        }
        impl core::fmt::Display for Spiral_wasm::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0(i64),
            US5_1,
        }
        impl core::fmt::Display for Spiral_wasm::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(Spiral_wasm::US4),
            US6_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_wasm::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0(u8),
            US7_1(u8),
        }
        impl core::fmt::Display for Spiral_wasm::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: clap::Command = clap::Command::args_override_self(v4, true);
            let v8: string = string("r#\"trace_level\"#");
            let v9: &'static str = r#"trace_level"#;
            let v11: clap::Arg = clap::Arg::new(v9);
            let v13: clap::Arg = v11.short('t');
            let v14: string = string("r#\"trace_level\"#");
            let v15: &'static str = r#"trace_level"#;
            let v17: clap::Arg = v13.long(v15);
            let v40: Array<string> = toArray(ofArray(new_array(&[
                string("Verbose"),
                string("Debug"),
                string("Info"),
                string("Warning"),
                string("Critical"),
            ])));
            let v44: Vec<string> = v40.to_vec();
            let v46: bool = true;
            let _vec_map: Vec<_> = v44
                .into_iter()
                .map(|x| {
                    //;
                    let v48: string = x;
                    let v50: &str = &*v48;
                    let v52: std::string::String = String::from(v50);
                    let v54: Box<std::string::String> = Box::new(v52);
                    let v56: &'static mut std::string::String = Box::leak(v54);
                    let v58: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v56);
                    let v60: bool = true;
                    v58
                })
                .collect::<Vec<_>>();
            let v62: Vec<clap::builder::PossibleValue> = _vec_map;
            let v64: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v62),
            );
            let v66: clap::Arg = v17.value_parser(v64);
            let v68: clap::Command = clap::Command::arg(v6, v66);
            let v70: string = string("r#\"wasm\"#");
            let v71: &'static str = r#"wasm"#;
            let v73: clap::Arg = clap::Arg::new(v71);
            let v75: clap::Arg = v73.short('w');
            let v76: string = string("r#\"wasm\"#");
            let v77: &'static str = r#"wasm"#;
            let v79: clap::Arg = v75.long(v77);
            let v81: clap::Arg = v79.required(true);
            clap::Command::arg(v68, v81)
        }
        pub fn method1() -> string {
            string("trace_level")
        }
        pub fn closure1(
            v0_1: LrcPtr<MutCell<Option<Spiral_wasm::US0>>>,
            v1: Option<Spiral_wasm::US0>,
        ) -> LrcPtr<MutCell<Option<Spiral_wasm::US0>>> {
            v0_1.set(v1);
            v0_1
        }
        pub fn closure2(
            v0_1: Option<std::string::String>,
            v1: Func1<Option<Spiral_wasm::US0>, LrcPtr<MutCell<Option<Spiral_wasm::US0>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Spiral_wasm::US0>>> = v1(match &v0_1 {
                    None => None::<Spiral_wasm::US0>,
                    Some(v0_1_0_0) => {
                        let x: std::string::String = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Spiral_wasm::US0::US0_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method3() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure4(
            v0_1: LrcPtr<MutCell<Option<Spiral_wasm::US4>>>,
            v1: Option<Spiral_wasm::US4>,
        ) -> LrcPtr<MutCell<Option<Spiral_wasm::US4>>> {
            v0_1.set(v1);
            v0_1
        }
        pub fn closure5(
            v0_1: Option<string>,
            v1: Func1<Option<Spiral_wasm::US4>, LrcPtr<MutCell<Option<Spiral_wasm::US4>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Spiral_wasm::US4>>> = v1(match &v0_1 {
                    None => None::<Spiral_wasm::US4>,
                    Some(v0_1_0_0) => {
                        let x: string = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Spiral_wasm::US4::US4_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method4(v0_1: string) -> string {
            let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v5: bool = true;
            let _result_map_ = v3.map(|x| {
                //;
                let v7: std::string::String = x;
                let v9: string = fable_library_rust::String_::fromString(v7);
                let v11: bool = true;
                v9
            });
            let v13: Result<string, std::env::VarError> = _result_map_;
            let v14: string = Spiral_wasm::method5();
            v13.unwrap_or(v14)
        }
        pub fn method6() -> string {
            string("AUTOMATION")
        }
        pub fn closure6(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method2(
            v0_1: Spiral_wasm::US3,
        ) -> (
            LrcPtr<Spiral_wasm::Mut0>,
            LrcPtr<Spiral_wasm::Mut1>,
            LrcPtr<Spiral_wasm::Mut2>,
            LrcPtr<Spiral_wasm::Mut3>,
            Option<i64>,
        ) {
            let v3: string = Spiral_wasm::method4(Spiral_wasm::method3());
            let v8: Spiral_wasm::US2 = if string("Verbose") == v3.clone() {
                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
            } else {
                Spiral_wasm::US2::US2_1
            };
            let _v1: (Spiral_wasm::US2, Spiral_wasm::US5) = (
                match &v8 {
                    Spiral_wasm::US2::US2_0(v8_0_0) => Spiral_wasm::US2::US2_0(match &v8 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v15: Spiral_wasm::US2 = if string("Debug") == v3.clone() {
                            Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                        } else {
                            Spiral_wasm::US2::US2_1
                        };
                        match &v15 {
                            Spiral_wasm::US2::US2_0(v15_0_0) => {
                                Spiral_wasm::US2::US2_0(match &v15 {
                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v22: Spiral_wasm::US2 = if string("Info") == v3.clone() {
                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                } else {
                                    Spiral_wasm::US2::US2_1
                                };
                                match &v22 {
                                    Spiral_wasm::US2::US2_0(v22_0_0) => {
                                        Spiral_wasm::US2::US2_0(match &v22 {
                                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v29: Spiral_wasm::US2 =
                                            if string("Warning") == v3.clone() {
                                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                            } else {
                                                Spiral_wasm::US2::US2_1
                                            };
                                        match &v29 {
                                            Spiral_wasm::US2::US2_0(v29_0_0) => {
                                                Spiral_wasm::US2::US2_0(match &v29 {
                                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v36: Spiral_wasm::US2 = if string("Critical")
                                                    == v3.clone()
                                                {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_4)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                                match &v36 {
                                                    Spiral_wasm::US2::US2_0(v36_0_0) => {
                                                        Spiral_wasm::US2::US2_0(match &v36 {
                                                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => Spiral_wasm::US2::US2_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if Spiral_wasm::method4(Spiral_wasm::method6()) == string("True") {
                    Spiral_wasm::US5::US5_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Spiral_wasm::US5::US5_1
                },
            );
            let v295: Spiral_wasm::US5 = _v1.1.clone();
            let v294: Spiral_wasm::US2 = _v1.0.clone();
            (
                LrcPtr::new(Spiral_wasm::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Spiral_wasm::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Spiral_wasm::closure6((), v))),
                }),
                LrcPtr::new(Spiral_wasm::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Spiral_wasm::Mut3 {
                    l0: MutCell::new(match &v294 {
                        Spiral_wasm::US2::US2_0(v294_0_0) => match &v294 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v295 {
                    Spiral_wasm::US5::US5_0(v295_0_0) => Some(match &v295 {
                        Spiral_wasm::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure3(v0_1: Spiral_wasm::US3, unitVar: ()) {
            if Spiral_wasm::State::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = Spiral_wasm::method2(v0_1);
                Spiral_wasm::State::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                )));
                ()
            };
        }
        pub fn closure8(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::State::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = Spiral_wasm::method2(Spiral_wasm::US3::US3_0);
                Spiral_wasm::State::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                )));
                ()
            };
        }
        pub fn closure9(v0_1: LrcPtr<Spiral_wasm::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure10(
            v0_1: LrcPtr<MutCell<Option<Spiral_wasm::US5>>>,
            v1: Option<Spiral_wasm::US5>,
        ) -> LrcPtr<MutCell<Option<Spiral_wasm::US5>>> {
            v0_1.set(v1);
            v0_1
        }
        pub fn closure11(
            v0_1: Option<i64>,
            v1: Func1<Option<Spiral_wasm::US5>, LrcPtr<MutCell<Option<Spiral_wasm::US5>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> = v1(match &v0_1 {
                    None => None::<Spiral_wasm::US5>,
                    Some(v0_1_0_0) => {
                        let x: i64 = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Spiral_wasm::US5::US5_0(x)
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method7() -> string {
            string("hh:mm:ss")
        }
        pub fn method8() -> string {
            string("HH:mm:ss")
        }
        pub fn method9() -> string {
            string("\u{001b}[0m")
        }
        pub fn method10() -> string {
            string("")
        }
        pub fn closure12(v0_1: LrcPtr<Spiral_wasm::Mut4>, v1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn closure13(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.main")
        }
        pub fn closure15(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure14(unitVar: (), v0_1: string) {
            let v3: () = {
                Spiral_wasm::closure15(v0_1, ());
                ()
            };
            ()
        }
        pub fn closure7(v0_1: Array<string>, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_black;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v633: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("args")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v662: () = {
                    Spiral_wasm::closure12(
                        v626.clone(),
                        sprintf!("{}", sprintf!("{:?}", v0_1)),
                        (),
                    );
                    ()
                };
                let v671: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v674: string = v626.l0.get().clone();
                let v713: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Spiral_wasm::closure13((), ()),
                            v674
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v713.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v713)
            }
        }
        pub fn method12() -> string {
            string("wasm")
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure16(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_black;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v633: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("wasm_path")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v659: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v668: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v671: string = v626.l0.get().clone();
                let v710: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Spiral_wasm::closure17((), ()),
                            v671
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v710.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v710)
            }
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure18(
            v0_1: u8,
            v1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
            unitVar: (),
        ) {
            fn v3() {
                Spiral_wasm::closure8((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v61: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v107: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v102.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v122: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Spiral_wasm::US5::US5_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Spiral_wasm::method7();
                    v162.toString(provider)
                };
                let v559: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_black;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v627: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v634: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v643: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v652: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v660: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v669: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v678: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("worker")), ());
                    ()
                };
                let v686: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v691: std::string::String = format!("{:#?}", v1);
                let v721: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v691)),
                        (),
                    );
                    ()
                };
                let v730: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v733: string = v627.l0.get().clone();
                let v772: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v584,
                            v625,
                            Spiral_wasm::closure19((), ()),
                            v733
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v772.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v772)
            }
        }
        pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure20(v0_1: u8, v1: near_workspaces::Contract, unitVar: ()) {
            fn v3() {
                Spiral_wasm::closure8((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v61: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v107: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v102.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v122: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Spiral_wasm::US5::US5_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Spiral_wasm::method7();
                    v162.toString(provider)
                };
                let v559: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_black;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v627: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v634: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v643: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v652: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v660: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v669: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v678: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("contract")), ());
                    ()
                };
                let v686: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v691: std::string::String = format!("{:#?}", v1);
                let v721: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v691)),
                        (),
                    );
                    ()
                };
                let v730: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v733: string = v627.l0.get().clone();
                let v772: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v584,
                            v625,
                            Spiral_wasm::closure21((), ()),
                            v733
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v772.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v772)
            }
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure22(v0_1: u8, v1: near_workspaces::result::ExecutionFinalResult, unitVar: ()) {
            fn v3() {
                Spiral_wasm::closure8((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v61: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v107: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v102.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v122: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Spiral_wasm::US5::US5_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Spiral_wasm::method7();
                    v162.toString(provider)
                };
                let v559: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_black;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v627: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v634: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v643: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v652: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v660: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v669: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v678: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v686: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v691: std::string::String = format!("{:#?}", v1);
                let v721: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v691)),
                        (),
                    );
                    ()
                };
                let v730: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v733: string = v627.l0.get().clone();
                let v772: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v584,
                            v625,
                            Spiral_wasm::closure23((), ()),
                            v733
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v772.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v772)
            }
        }
        pub fn closure25(v0_1: std::string::String, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure24(unitVar: (), v0_1: std::string::String) {
            let v3: () = {
                Spiral_wasm::closure25(v0_1, ());
                ()
            };
            ()
        }
        pub fn method14() -> string {
            string("(")
        }
        pub fn method15() -> string {
            string(" ")
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.print_usd")
        }
        pub fn closure26(v0_1: u8, v1: u64, v2: f64, unitVar: ()) {
            fn v4() {
                Spiral_wasm::closure8((), ());
            }
            let v5: () = {
                v4();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v34: () = {
                v4();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v62: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v62,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v70: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v74: () = {
                    v4();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v103: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v108: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v103 = _v103.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v103.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v123: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v103.get().clone());
                let v163: DateTime = match &v123 {
                    Spiral_wasm::US5::US5_0(v123_0_0) => {
                        let v137: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v123 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v137.hours(),
                            v137.minutes(),
                            v137.seconds(),
                            v137.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v168: string = {
                    let provider: string = Spiral_wasm::method7();
                    v163.toString(provider)
                };
                let v556: string = Spiral_wasm::method14();
                let v568: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v579: () = {
                    Spiral_wasm::closure12(
                        v568.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v583: Array<string> = split(v568.l0.get().clone(), v556, -1_i32, 0_i32);
                let v586: string = v583[0_i32].clone();
                let v590: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v601: () = {
                    Spiral_wasm::closure12(
                        v590.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                        (),
                    );
                    ()
                };
                let v611: Spiral_wasm::US4 = if startsWith(v590.l0.get().clone(), v586, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v617: Spiral_wasm::US4 = match &v611 {
                    Spiral_wasm::US4::US4_0(v611_0_0) => Spiral_wasm::US4::US4_0(match &v611 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => Spiral_wasm::US4::US4_0(string("Debug")),
                };
                let v626: string = padLeft(
                    toLower(match &v617 {
                        Spiral_wasm::US4::US4_0(v617_0_0) => match &v617 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v642: &str = inline_colorization::color_bright_blue;
                let v644: &str = &*v626;
                let v646: &str = inline_colorization::color_reset;
                let v648: string = string("format!(\"{v642}{v644}{v646}\")");
                let v649: std::string::String = format!("{v642}{v644}{v646}");
                let v651: string = fable_library_rust::String_::fromString(v649);
                let v692: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v694: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v701: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v710: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v719: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v727: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v736: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v745: () = {
                    Spiral_wasm::closure12(
                        v694.clone(),
                        sprintf!("{}", string("total_gas_burnt_usd")),
                        (),
                    );
                    ()
                };
                let v753: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v761: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{:+.6}", v2), ());
                    ()
                };
                let v769: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v778: () = {
                    Spiral_wasm::closure12(
                        v694.clone(),
                        sprintf!("{}", string("total_gas_burnt")),
                        (),
                    );
                    ()
                };
                let v786: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v794: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", v1), ());
                    ()
                };
                let v803: () = {
                    Spiral_wasm::closure12(v694.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v806: string = v694.l0.get().clone();
                let v845: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v168,
                            v651,
                            v692,
                            Spiral_wasm::closure27((), ()),
                            v806
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v845.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v845)
            }
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.print_usd / outcome")
        }
        pub fn closure29(v0_1: bool, v1: u64, v2: f64, v3: u128, v4: f64, unitVar: ()) {
            fn v6() {
                Spiral_wasm::closure8((), ());
            }
            let v7: () = {
                v6();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v36: () = {
                v6();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v64: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v64,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v72: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v76: () = {
                    v6();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v105: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v110: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v105 = _v105.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v105.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v125: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v105.get().clone());
                let v165: DateTime = match &v125 {
                    Spiral_wasm::US5::US5_0(v125_0_0) => {
                        let v139: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v125 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v139.hours(),
                            v139.minutes(),
                            v139.seconds(),
                            v139.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v170: string = {
                    let provider: string = Spiral_wasm::method7();
                    v165.toString(provider)
                };
                let v558: string = Spiral_wasm::method14();
                let v570: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v581: () = {
                    Spiral_wasm::closure12(
                        v570.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v585: Array<string> = split(v570.l0.get().clone(), v558, -1_i32, 0_i32);
                let v588: string = v585[0_i32].clone();
                let v592: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v603: () = {
                    Spiral_wasm::closure12(
                        v592.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                        (),
                    );
                    ()
                };
                let v613: Spiral_wasm::US4 = if startsWith(v592.l0.get().clone(), v588, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v619: Spiral_wasm::US4 = match &v613 {
                    Spiral_wasm::US4::US4_0(v613_0_0) => Spiral_wasm::US4::US4_0(match &v613 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => Spiral_wasm::US4::US4_0(string("Debug")),
                };
                let v628: string = padLeft(
                    toLower(match &v619 {
                        Spiral_wasm::US4::US4_0(v619_0_0) => match &v619 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v644: &str = inline_colorization::color_bright_blue;
                let v646: &str = &*v628;
                let v648: &str = inline_colorization::color_reset;
                let v650: string = string("format!(\"{v644}{v646}{v648}\")");
                let v651: std::string::String = format!("{v644}{v646}{v648}");
                let v653: string = fable_library_rust::String_::fromString(v651);
                let v694: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v696: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v703: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v712: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string("is_success")), ());
                    ()
                };
                let v721: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v732: () = {
                    Spiral_wasm::closure12(
                        v696.clone(),
                        sprintf!(
                            "{}",
                            if v0_1 {
                                string("true")
                            } else {
                                string("false")
                            }
                        ),
                        (),
                    );
                    ()
                };
                let v741: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v750: () = {
                    Spiral_wasm::closure12(
                        v696.clone(),
                        sprintf!("{}", string("gas_burnt_usd")),
                        (),
                    );
                    ()
                };
                let v758: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v766: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{:+.6}", v2), ());
                    ()
                };
                let v774: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v783: () = {
                    Spiral_wasm::closure12(
                        v696.clone(),
                        sprintf!("{}", string("tokens_burnt_usd")),
                        (),
                    );
                    ()
                };
                let v791: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v799: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{:+.6}", v4), ());
                    ()
                };
                let v807: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v816: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string("gas_burnt")), ());
                    ()
                };
                let v824: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v832: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", v1), ());
                    ()
                };
                let v840: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v849: () = {
                    Spiral_wasm::closure12(
                        v696.clone(),
                        sprintf!("{}", string("tokens_burnt")),
                        (),
                    );
                    ()
                };
                let v857: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v862: std::string::String = format!("{:#?}", v3);
                let v892: () = {
                    Spiral_wasm::closure12(
                        v696.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v862)),
                        (),
                    );
                    ()
                };
                let v901: () = {
                    Spiral_wasm::closure12(v696.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v904: string = v696.l0.get().clone();
                let v943: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v170,
                            v653,
                            v694,
                            Spiral_wasm::closure30((), ()),
                            v904
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v943.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v943)
            }
        }
        pub fn closure28(unitVar: (), v0_1: near_workspaces::result::ExecutionOutcome) {
            let v2: bool = v0_1.clone().is_success();
            let v4: near_workspaces::types::Gas = v0_1.clone().gas_burnt;
            let v6: u64 = v4.as_gas();
            let v10: f64 = v6 as f64 / 10000000000000000.0_f64 * 6.68_f64;
            let v12: near_workspaces::types::NearToken = v0_1.tokens_burnt;
            let v14: u128 = v12.as_yoctonear();
            let v21: () = {
                Spiral_wasm::closure29(
                    v2,
                    v6,
                    v10,
                    v14.clone(),
                    v14 as f64 / 1E+24_f64 * 6.68_f64,
                    (),
                );
                ()
            };
            ()
        }
        pub fn closure32(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure31(
            v0_1: Result<
                near_workspaces::result::ExecutionSuccess,
                near_workspaces::result::ExecutionFailure,
            >,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_black;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v633: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("result2")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure12(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v698: string = v626.l0.get().clone();
                let v737: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Spiral_wasm::closure32((), ()),
                            v698
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v737.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v737)
            }
        }
        pub fn method16(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure33(
            v0_1: Vec<&near_workspaces::result::ExecutionOutcome>,
            v1: i32,
            unitVar: (),
        ) {
            fn v3() {
                Spiral_wasm::closure8((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v61: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v107: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v102.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v122: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Spiral_wasm::US5::US5_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Spiral_wasm::method7();
                    v162.toString(provider)
                };
                let v559: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_black;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v627: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v634: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v643: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", string("receipt_failures_len")),
                        (),
                    );
                    ()
                };
                let v652: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v660: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", v1), ());
                    ()
                };
                let v669: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v678: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", string("receipt_failures")),
                        (),
                    );
                    ()
                };
                let v686: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v691: std::string::String = format!("{:#?}", v0_1);
                let v721: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v691)),
                        (),
                    );
                    ()
                };
                let v730: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v733: string = v627.l0.get().clone();
                let v772: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v584,
                            v625,
                            Spiral_wasm::closure34((), ()),
                            v733
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v772.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v772)
            }
        }
        pub fn method17(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure35(
            v0_1: Vec<near_workspaces::result::ExecutionOutcome>,
            v1: i32,
            unitVar: (),
        ) {
            fn v3() {
                Spiral_wasm::closure8((), ());
            }
            let v4: () = {
                v3();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v33: () = {
                v3();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v61: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v61,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v69: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v73: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v102: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v107: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v102 = _v102.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v102.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v122: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v102.get().clone());
                let v162: DateTime = match &v122 {
                    Spiral_wasm::US5::US5_0(v122_0_0) => {
                        let v136: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v122 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v136.hours(),
                            v136.minutes(),
                            v136.seconds(),
                            v136.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v167: string = {
                    let provider: string = Spiral_wasm::method7();
                    v162.toString(provider)
                };
                let v559: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v575: &str = inline_colorization::color_bright_black;
                let v577: &str = &*v559;
                let v579: &str = inline_colorization::color_reset;
                let v581: string = string("format!(\"{v575}{v577}{v579}\")");
                let v582: std::string::String = format!("{v575}{v577}{v579}");
                let v584: string = fable_library_rust::String_::fromString(v582);
                let v625: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v627: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v634: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v643: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", string("receipt_outcomes_len")),
                        (),
                    );
                    ()
                };
                let v652: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v660: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", v1), ());
                    ()
                };
                let v669: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v678: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", string("receipt_outcomes")),
                        (),
                    );
                    ()
                };
                let v686: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v691: std::string::String = format!("{:#?}", v0_1);
                let v721: () = {
                    Spiral_wasm::closure12(
                        v627.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v691)),
                        (),
                    );
                    ()
                };
                let v730: () = {
                    Spiral_wasm::closure12(v627.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v733: string = v627.l0.get().clone();
                let v772: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v584,
                            v625,
                            Spiral_wasm::closure36((), ()),
                            v733
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v772.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v772)
            }
        }
        pub fn closure38(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure37(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_black;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v633: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("json")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure12(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v698: string = v626.l0.get().clone();
                let v737: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Spiral_wasm::closure38((), ()),
                            v698
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v737.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v737)
            }
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure39(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_black;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v633: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("borsh")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure12(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v698: string = v626.l0.get().clone();
                let v737: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Spiral_wasm::closure40((), ()),
                            v698
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v737.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v737)
            }
        }
        pub fn method18(
            v0_1: Result<Spiral_wasm::US4, anyhow::Error>,
        ) -> Result<Spiral_wasm::US4, anyhow::Error> {
            v0_1
        }
        pub fn method13(
            v0_1: Vec<u8>,
            v1: u8,
        ) -> std::pin::Pin<
            Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4, anyhow::Error>>>,
        > {
            let v3: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v5: Result<
                    near_workspaces::Worker<near_workspaces::network::Sandbox>,
                    near_workspaces::error::Error,
                > = near_workspaces::sandbox().await;
                let v7: near_workspaces::Worker<near_workspaces::network::Sandbox> = v5?;
                let v10: () = {
                    Spiral_wasm::closure18(v1, v7.clone(), ());
                    ()
                };
                let v806: std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<
                                near_workspaces::Contract,
                                near_workspaces::error::Error,
                            >,
                        >,
                    >,
                > = Box::pin(v7.dev_deploy(&v0_1));
                let v808: Result<near_workspaces::Contract, near_workspaces::error::Error> =
                    v806.await;
                let v810: near_workspaces::Contract = v808?;
                let v813: () = {
                    Spiral_wasm::closure20(v1, v810.clone(), ());
                    ()
                };
                let v1610: near_workspaces::operations::CallTransaction =
                    v810.call(&*string("state_main"));
                let v1612: std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<
                                near_workspaces::result::ExecutionFinalResult,
                                near_workspaces::error::Error,
                            >,
                        >,
                    >,
                > = Box::pin(v1610.transact());
                let v1614: Result<
                    near_workspaces::result::ExecutionFinalResult,
                    near_workspaces::error::Error,
                > = v1612.await;
                let v1616: near_workspaces::result::ExecutionFinalResult = v1614?;
                let v1619: () = {
                    Spiral_wasm::closure22(v1, v1616.clone(), ());
                    ()
                };
                let v2415: Vec<&str> = v1616.logs();
                let v2417: bool = true;
                let _vec_map: Vec<_> = v2415
                    .into_iter()
                    .map(|x| {
                        //;
                        let v2419: &str = x;
                        let v2421: std::string::String = String::from(v2419);
                        let v2423: bool = true;
                        v2421
                    })
                    .collect::<Vec<_>>();
                let v2425: Vec<std::string::String> = _vec_map;
                let v2428: bool = true;
                v2425.iter().for_each(|x| {
                    Func1::new(move |v: std::string::String| Spiral_wasm::closure24((), v))(
                        x.clone(),
                    );
                }); //;
                let v2430: near_workspaces::types::Gas = v1616.clone().total_gas_burnt;
                let v2432: u64 = v2430.as_gas();
                let v2439: () = {
                    Spiral_wasm::closure26(
                        v1,
                        v2432,
                        v2432 as f64 / 10000000000000000.0_f64 * 6.68_f64,
                        (),
                    );
                    ()
                };
                let v3307: near_workspaces::result::ExecutionFinalResult = v1616.clone();
                let v3309: Vec<&near_workspaces::result::ExecutionOutcome> = v3307.outcomes();
                let v3311 = v3309.into_iter();
                let v3313 = v3311.cloned();
                let v3316: bool = true;
                v3313.for_each(|x| {
                    Func1::new(move |v_1: near_workspaces::result::ExecutionOutcome| {
                        Spiral_wasm::closure28((), v_1)
                    })(x)
                });
                let v3321: () = {
                    Spiral_wasm::closure31(v1616.clone().into_result(), ());
                    ()
                };
                let v4082: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method16(v1616.clone());
                let v4084: Vec<&near_workspaces::result::ExecutionOutcome> =
                    v4082.receipt_failures();
                let v4088: i32 = v4084.clone().len() as i32;
                let v4091: () = {
                    Spiral_wasm::closure33(v4084.clone(), v4088, ());
                    ()
                };
                let v4886: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method17(v1616.clone());
                let v4888: &[near_workspaces::result::ExecutionOutcome] = v4886.receipt_outcomes();
                let v4890: Vec<near_workspaces::result::ExecutionOutcome> = v4888.into();
                let v4894: i32 = v4890.clone().len() as i32;
                let v4897: () = {
                    Spiral_wasm::closure35(v4890, v4894, ());
                    ()
                };
                let v5696: () = {
                    Spiral_wasm::closure37(v1616.clone().json(), ());
                    ()
                };
                let v6461: () = {
                    Spiral_wasm::closure39(v1616.borsh(), ());
                    ()
                };
                let v7223: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v7230: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v7239: () = {
                    Spiral_wasm::closure12(
                        v7223.clone(),
                        sprintf!("{}", string("receipt_failures")),
                        (),
                    );
                    ()
                };
                let v7248: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v7253: std::string::String = format!("{:#?}", v4084);
                let v7283: () = {
                    Spiral_wasm::closure12(
                        v7223.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v7253)),
                        (),
                    );
                    ()
                };
                let v7292: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v7301: () = {
                    Spiral_wasm::closure12(
                        v7223.clone(),
                        sprintf!("{}", string("receipt_outcomes_len")),
                        (),
                    );
                    ()
                };
                let v7309: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v7317: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", v4894), ());
                    ()
                };
                let v7325: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v7334: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v7342: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v7350: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", v1), ());
                    ()
                };
                let v7359: () = {
                    Spiral_wasm::closure12(v7223.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v7362: string = v7223.l0.get().clone();
                let v7375: Result<Spiral_wasm::US4, anyhow::Error> =
                    Spiral_wasm::method18(if v4088 > 0_i32 {
                        Ok::<Spiral_wasm::US4, anyhow::Error>(Spiral_wasm::US4::US4_0(
                            v7362.clone(),
                        ))
                    } else {
                        if v4894 > 1_i32 {
                            Ok::<Spiral_wasm::US4, anyhow::Error>(Spiral_wasm::US4::US4_1)
                        } else {
                            let v7370: anyhow::Error = anyhow::anyhow!(v7362);
                            Err(v7370)
                        }
                    });
                let v7379: string = string("true; v7375 });  // rust.fix_closure\'");
                let v7380: bool = true;
                v7375
            }); // rust.fix_closure';
            let v7382 = __future_init;
            v7382
        }
        pub fn closure41(unitVar: (), v0_1: anyhow::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method19() -> Func1<anyhow::Error, std::string::String> {
            Func1::new(move |v: anyhow::Error| Spiral_wasm::closure41((), v))
        }
        pub fn closure42(unitVar: (), v0_1: Spiral_wasm::US4) -> Spiral_wasm::US6 {
            Spiral_wasm::US6::US6_0(v0_1)
        }
        pub fn closure43(unitVar: (), v0_1: std::string::String) -> Spiral_wasm::US6 {
            Spiral_wasm::US6::US6_1(v0_1)
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run / Error error")
        }
        pub fn closure44(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 1_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure46(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 2_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure47(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 3_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure48(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 4_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure49(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 5_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure50(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 6_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure51(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 7_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure52(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 8_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure53(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 9_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure54(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 10_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure55(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 11_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure56(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 12_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure57(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 13_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn closure58(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v737: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_3)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_wasm::US4::US4_0(string("Warning")),
                                }
                            }
                        }
                    }
                };
                let v746: string = padLeft(
                    toLower(match &v737 {
                        Spiral_wasm::US4::US4_0(v737_0_0) => match &v737 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v762: &str = inline_colorization::color_yellow;
                let v764: &str = &*v746;
                let v766: &str = inline_colorization::color_reset;
                let v768: string = string("format!(\"{v762}{v764}{v766}\")");
                let v769: std::string::String = format!("{v762}{v764}{v766}");
                let v771: string = fable_library_rust::String_::fromString(v769);
                let v812: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v814: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v821: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v830: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v839: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v847: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", 14_u8), ());
                    ()
                };
                let v856: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v865: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v873: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v878: std::string::String = format!("{:#?}", v0_1);
                let v908: () = {
                    Spiral_wasm::closure12(
                        v814.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v878)),
                        (),
                    );
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v814.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v920: string = v814.l0.get().clone();
                let v959: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v771,
                            v812,
                            Spiral_wasm::closure45((), ()),
                            v920
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v959.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v959)
            }
        }
        pub fn method20() -> u8 {
            15_u8
        }
        pub fn method21(v0_1: u8) -> Spiral_wasm::US7 {
            Spiral_wasm::US7::US7_1(v0_1)
        }
        pub fn method22() -> u8 {
            14_u8
        }
        pub fn method23(v0_1: u8) -> Spiral_wasm::US7 {
            Spiral_wasm::US7::US7_0(v0_1)
        }
        pub fn closure60(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run / Ok (Some error)")
        }
        pub fn closure59(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 14_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method24() -> u8 {
            13_u8
        }
        pub fn closure61(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 13_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method25() -> u8 {
            12_u8
        }
        pub fn closure62(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 12_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method26() -> u8 {
            11_u8
        }
        pub fn closure63(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 11_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method27() -> u8 {
            10_u8
        }
        pub fn closure64(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 10_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method28() -> u8 {
            9_u8
        }
        pub fn closure65(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 9_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method29() -> u8 {
            8_u8
        }
        pub fn closure66(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 8_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method30() -> u8 {
            7_u8
        }
        pub fn closure67(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 7_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method31() -> u8 {
            6_u8
        }
        pub fn closure68(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 6_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method32() -> u8 {
            5_u8
        }
        pub fn closure69(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 5_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method33() -> u8 {
            4_u8
        }
        pub fn closure70(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 4_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method34() -> u8 {
            3_u8
        }
        pub fn closure71(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 3_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method35() -> u8 {
            2_u8
        }
        pub fn closure72(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 2_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn method36() -> u8 {
            1_u8
        }
        pub fn closure73(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v554: string = Spiral_wasm::method14();
                let v566: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v577: () = {
                    Spiral_wasm::closure12(
                        v566.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v581: Array<string> = split(v566.l0.get().clone(), v554, -1_i32, 0_i32);
                let v584: string = v581[0_i32].clone();
                let v588: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v599: () = {
                    Spiral_wasm::closure12(
                        v588.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                        (),
                    );
                    ()
                };
                let v609: Spiral_wasm::US4 = if startsWith(v588.l0.get().clone(), v584, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v798: Spiral_wasm::US4 = match &v609 {
                    Spiral_wasm::US4::US4_0(v609_0_0) => Spiral_wasm::US4::US4_0(match &v609 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v613: string = Spiral_wasm::method14();
                        let v625: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v636: () = {
                            Spiral_wasm::closure12(
                                v625.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                                (),
                            );
                            ()
                        };
                        let v640: Array<string> = split(v625.l0.get().clone(), v613, -1_i32, 0_i32);
                        let v643: string = v640[0_i32].clone();
                        let v647: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v658: () = {
                            Spiral_wasm::closure12(
                                v647.clone(),
                                sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                (),
                            );
                            ()
                        };
                        let v668: Spiral_wasm::US4 =
                            if startsWith(v647.l0.get().clone(), v643, false) {
                                Spiral_wasm::US4::US4_0(string("Debug"))
                            } else {
                                Spiral_wasm::US4::US4_1
                            };
                        match &v668 {
                            Spiral_wasm::US4::US4_0(v668_0_0) => {
                                Spiral_wasm::US4::US4_0(match &v668 {
                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v672: string = Spiral_wasm::method14();
                                let v684: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v695: () = {
                                    Spiral_wasm::closure12(
                                        v684.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_2)),
                                        (),
                                    );
                                    ()
                                };
                                let v699: Array<string> =
                                    split(v684.l0.get().clone(), v672, -1_i32, 0_i32);
                                let v702: string = v699[0_i32].clone();
                                let v706: LrcPtr<Spiral_wasm::Mut4> =
                                    LrcPtr::new(Spiral_wasm::Mut4 {
                                        l0: MutCell::new(Spiral_wasm::method10()),
                                    });
                                let v717: () = {
                                    Spiral_wasm::closure12(
                                        v706.clone(),
                                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_4)),
                                        (),
                                    );
                                    ()
                                };
                                let v727: Spiral_wasm::US4 =
                                    if startsWith(v706.l0.get().clone(), v702, false) {
                                        Spiral_wasm::US4::US4_0(string("Info"))
                                    } else {
                                        Spiral_wasm::US4::US4_1
                                    };
                                match &v727 {
                                    Spiral_wasm::US4::US4_0(v727_0_0) => {
                                        Spiral_wasm::US4::US4_0(match &v727 {
                                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v731: string = Spiral_wasm::method14();
                                        let v743: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v754: () = {
                                            Spiral_wasm::closure12(
                                                v743.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_3)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v758: Array<string> =
                                            split(v743.l0.get().clone(), v731, -1_i32, 0_i32);
                                        let v761: string = v758[0_i32].clone();
                                        let v765: LrcPtr<Spiral_wasm::Mut4> =
                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                l0: MutCell::new(Spiral_wasm::method10()),
                                            });
                                        let v776: () = {
                                            Spiral_wasm::closure12(
                                                v765.clone(),
                                                sprintf!(
                                                    "{}",
                                                    sprintf!("{:?}", Spiral_wasm::US3::US3_4)
                                                ),
                                                (),
                                            );
                                            ()
                                        };
                                        let v786: Spiral_wasm::US4 =
                                            if startsWith(v765.l0.get().clone(), v761, false) {
                                                Spiral_wasm::US4::US4_0(string("Warning"))
                                            } else {
                                                Spiral_wasm::US4::US4_1
                                            };
                                        match &v786 {
                                            Spiral_wasm::US4::US4_0(v786_0_0) => {
                                                Spiral_wasm::US4::US4_0(match &v786 {
                                                    Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_wasm::US4::US4_0(string("Critical")),
                                        }
                                    }
                                }
                            }
                        }
                    }
                };
                let v807: string = padLeft(
                    toLower(match &v798 {
                        Spiral_wasm::US4::US4_0(v798_0_0) => match &v798 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v823: &str = inline_colorization::color_bright_red;
                let v825: &str = &*v807;
                let v827: &str = inline_colorization::color_reset;
                let v829: string = string("format!(\"{v823}{v825}{v827}\")");
                let v830: std::string::String = format!("{v823}{v825}{v827}");
                let v832: string = fable_library_rust::String_::fromString(v830);
                let v873: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v875: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v882: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v891: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("retry")), ());
                    ()
                };
                let v900: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v908: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", 1_u8), ());
                    ()
                };
                let v917: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v926: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string("error")), ());
                    ()
                };
                let v934: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v942: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v951: () = {
                    Spiral_wasm::closure12(v875.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v954: string = v875.l0.get().clone();
                let v993: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v832,
                            v873,
                            Spiral_wasm::closure60((), ()),
                            v954
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v993.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v993)
            }
        }
        pub fn closure75(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure74(v0_1: Spiral_wasm::US7, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure8((), ());
            }
            let v3: () = {
                v2();
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v32: () = {
                v2();
                ()
            };
            let patternInput_1: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v60: Spiral_wasm::US3 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US3::US3_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US3::US3_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure9(patternInput.0.clone(), ());
                    ()
                };
                let v72: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US5>>> =
                    refCell(None::<Spiral_wasm::US5>);
                let v106: () = {
                    Spiral_wasm::closure11(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US5>| {
                                Spiral_wasm::closure10(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US5 =
                    defaultValue(Spiral_wasm::US5::US5_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US5::US5_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v135.hours(),
                            v135.minutes(),
                            v135.seconds(),
                            v135.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                let v166: string = {
                    let provider: string = Spiral_wasm::method7();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_black;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v633: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("retries")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v662: () = {
                    Spiral_wasm::closure12(
                        v626.clone(),
                        sprintf!("{}", sprintf!("{:?}", v0_1)),
                        (),
                    );
                    ()
                };
                let v671: () = {
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v674: string = v626.l0.get().clone();
                let v713: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v166,
                            v583,
                            v624,
                            Spiral_wasm::closure75((), ()),
                            v674
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v713.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v713)
            }
        }
        pub fn method37(v0_1: Result<(), anyhow::Error>) -> Result<(), anyhow::Error> {
            v0_1
        }
        pub fn method11(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), anyhow::Error>>>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v3: string = Spiral_wasm::method12();
                let v5: &str = &*v3;
                let v7: Option<std::string::String> = clap::ArgMatches::get_one(&v0_1, v5).cloned();
                let _v8: LrcPtr<MutCell<Option<Spiral_wasm::US0>>> =
                    refCell(None::<Spiral_wasm::US0>);
                let v13: () = {
                    Spiral_wasm::closure2(
                        v7,
                        Func1::new({
                            let _v8 = _v8.clone();
                            move |v: Option<Spiral_wasm::US0>| Spiral_wasm::closure1(_v8.clone(), v)
                        }),
                        (),
                    );
                    ()
                };
                let v28: Spiral_wasm::US0 =
                    defaultValue(Spiral_wasm::US0::US0_1, _v8.get().clone());
                let v35: std::string::String = match &v28 {
                    Spiral_wasm::US0::US0_0(v28_0_0) => match &v28 {
                        Spiral_wasm::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v37: string = fable_library_rust::String_::fromString(v35);
                let v40: () = {
                    Spiral_wasm::closure16(v37.clone(), ());
                    ()
                };
                let v775: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v37);
                let v777: Vec<u8> = v775?;
                let v779: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4, anyhow::Error>>>,
                > = Spiral_wasm::method13(v777.clone(), 1_u8);
                let v781: Result<Spiral_wasm::US4, anyhow::Error> = v779.await;
                let v782 = Spiral_wasm::method19();
                let v784: Result<Spiral_wasm::US4, std::string::String> = v781.map_err(|x| v782(x));
                fn v785(v_1: Spiral_wasm::US4) -> Spiral_wasm::US6 {
                    Spiral_wasm::closure42((), v_1)
                }
                fn v786(v_2: std::string::String) -> Spiral_wasm::US6 {
                    Spiral_wasm::closure43((), v_2)
                }
                let v787: Spiral_wasm::US6 = match &v784 {
                    Err(v784_1_0) => v786(v784_1_0.clone()),
                    Ok(v784_0_0) => v785(v784_0_0.clone()),
                };
                let v29741: std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_wasm::US7>>> =
                    match &v787 {
                        Spiral_wasm::US6::US6_0(v787_0_0) => {
                            let v788: Spiral_wasm::US4 = v787_0_0.clone();
                            match &v788 {
                                Spiral_wasm::US4::US4_0(v788_0_0) => {
                                    let v816: () = {
                                        Spiral_wasm::closure73(
                                            match &v788 {
                                                Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            (),
                                        );
                                        ()
                                    };
                                    let v1834: bool = true;
                                    let __future_init = Box::pin(async move {
                                        //;
                                        let v1836: bool = true;
                                        let __future_init = Box::pin(async move {
                                            //;
                                            let v1837: u8 = Spiral_wasm::method36();
                                            let v1841: string =
                                                string("true; v1837 });  // rust.fix_closure\'");
                                            let v1842: bool = true;
                                            v1837
                                        }); // rust.fix_closure';
                                        let v1844 = __future_init;
                                        let v1846: std::pin::Pin<
                                            Box<dyn std::future::Future<Output = u8>>,
                                        > = v1844;
                                        let v1849: Spiral_wasm::US7 =
                                            Spiral_wasm::method21(v1846.await);
                                        let v1851: string =
                                            string("true; v1849 });  // rust.fix_closure\'");
                                        let v1852: bool = true;
                                        v1849
                                    }); // rust.fix_closure';
                                    let v1854 = __future_init;
                                    v1854
                                }
                                _ => {
                                    let v790: bool = true;
                                    let __future_init = Box::pin(async move {
                                        //;
                                        let v792: bool = true;
                                        let __future_init = Box::pin(async move {
                                            //;
                                            let v793: u8 = Spiral_wasm::method36();
                                            let v797: string =
                                                string("true; v793 });  // rust.fix_closure\'");
                                            let v798: bool = true;
                                            v793
                                        }); // rust.fix_closure';
                                        let v800 = __future_init;
                                        let v802: std::pin::Pin<
                                            Box<dyn std::future::Future<Output = u8>>,
                                        > = v800;
                                        let v805: Spiral_wasm::US7 =
                                            Spiral_wasm::method23(v802.await);
                                        let v807: string =
                                            string("true; v805 });  // rust.fix_closure\'");
                                        let v808: bool = true;
                                        v805
                                    }); // rust.fix_closure';
                                    let v810 = __future_init;
                                    v810
                                }
                            }
                        }
                        Spiral_wasm::US6::US6_1(v787_1_0) => {
                            let v1862: () = {
                                Spiral_wasm::closure44(v787_1_0.clone(), ());
                                ()
                            };
                            let v2846: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                        Output = Result<Spiral_wasm::US4, anyhow::Error>,
                                    >,
                                >,
                            > = Spiral_wasm::method13(v777.clone(), 2_u8);
                            let v2848: Result<Spiral_wasm::US4, anyhow::Error> = v2846.await;
                            let v2849 = Spiral_wasm::method19();
                            let v2851: Result<Spiral_wasm::US4, std::string::String> =
                                v2848.map_err(|x| v2849(x));
                            let v2852: Spiral_wasm::US6 = match &v2851 {
                                Err(v2851_1_0) => v786(v2851_1_0.clone()),
                                Ok(v2851_0_0) => v785(v2851_0_0.clone()),
                            };
                            match &v2852 {
                                Spiral_wasm::US6::US6_0(v2852_0_0) => {
                                    let v2853: Spiral_wasm::US4 = v2852_0_0.clone();
                                    match &v2853 {
                                        Spiral_wasm::US4::US4_0(v2853_0_0) => {
                                            let v2881: () = {
                                                Spiral_wasm::closure72(
                                                    match &v2853 {
                                                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                    (),
                                                );
                                                ()
                                            };
                                            let v3899: bool = true;
                                            let __future_init = Box::pin(async move {
                                                //;
                                                let v3901: bool = true;
                                                let __future_init = Box::pin(async move {
                                                    //;
                                                    let v3902: u8 = Spiral_wasm::method35();
                                                    let v3906: string = string(
                                                        "true; v3902 });  // rust.fix_closure\'",
                                                    );
                                                    let v3907: bool = true;
                                                    v3902
                                                }); // rust.fix_closure';
                                                let v3909 = __future_init;
                                                let v3911: std::pin::Pin<
                                                    Box<dyn std::future::Future<Output = u8>>,
                                                > = v3909;
                                                let v3914: Spiral_wasm::US7 =
                                                    Spiral_wasm::method21(v3911.await);
                                                let v3916: string = string(
                                                    "true; v3914 });  // rust.fix_closure\'",
                                                );
                                                let v3917: bool = true;
                                                v3914
                                            }); // rust.fix_closure';
                                            let v3919 = __future_init;
                                            v3919
                                        }
                                        _ => {
                                            let v2855: bool = true;
                                            let __future_init = Box::pin(async move {
                                                //;
                                                let v2857: bool = true;
                                                let __future_init = Box::pin(async move {
                                                    //;
                                                    let v2858: u8 = Spiral_wasm::method35();
                                                    let v2862: string = string(
                                                        "true; v2858 });  // rust.fix_closure\'",
                                                    );
                                                    let v2863: bool = true;
                                                    v2858
                                                }); // rust.fix_closure';
                                                let v2865 = __future_init;
                                                let v2867: std::pin::Pin<
                                                    Box<dyn std::future::Future<Output = u8>>,
                                                > = v2865;
                                                let v2870: Spiral_wasm::US7 =
                                                    Spiral_wasm::method23(v2867.await);
                                                let v2872: string = string(
                                                    "true; v2870 });  // rust.fix_closure\'",
                                                );
                                                let v2873: bool = true;
                                                v2870
                                            }); // rust.fix_closure';
                                            let v2875 = __future_init;
                                            v2875
                                        }
                                    }
                                }
                                Spiral_wasm::US6::US6_1(v2852_1_0) => {
                                    let v3927: () = {
                                        Spiral_wasm::closure46(v2852_1_0.clone(), ());
                                        ()
                                    };
                                    let v4911: std::pin::Pin<
                                        Box<
                                            dyn std::future::Future<
                                                Output = Result<Spiral_wasm::US4, anyhow::Error>,
                                            >,
                                        >,
                                    > = Spiral_wasm::method13(v777.clone(), 3_u8);
                                    let v4913: Result<Spiral_wasm::US4, anyhow::Error> =
                                        v4911.await;
                                    let v4914 = Spiral_wasm::method19();
                                    let v4916: Result<Spiral_wasm::US4, std::string::String> =
                                        v4913.map_err(|x| v4914(x));
                                    let v4917: Spiral_wasm::US6 = match &v4916 {
                                        Err(v4916_1_0) => v786(v4916_1_0.clone()),
                                        Ok(v4916_0_0) => v785(v4916_0_0.clone()),
                                    };
                                    match &v4917 {
                                        Spiral_wasm::US6::US6_0(v4917_0_0) => {
                                            let v4918: Spiral_wasm::US4 = v4917_0_0.clone();
                                            match &v4918 {
                                                Spiral_wasm::US4::US4_0(v4918_0_0) => {
                                                    let v4946: () = {
                                                        Spiral_wasm::closure71(
                                                            match &v4918 {
                                                                Spiral_wasm::US4::US4_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v5964: bool = true;
                                                    let __future_init = Box::pin(async move {
                                                        //;
                                                        let v5966: bool = true;
                                                        let __future_init = Box::pin(async move {
                                                            //;
                                                            let v5967: u8 = Spiral_wasm::method34();
                                                            let v5971: string =
                                                    string("true; v5967 });  // rust.fix_closure\'");
                                                            let v5972: bool = true;
                                                            v5967
                                                        }); // rust.fix_closure';
                                                        let v5974 = __future_init;
                                                        let v5976: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = u8,
                                                                >,
                                                            >,
                                                        > = v5974;
                                                        let v5979: Spiral_wasm::US7 =
                                                            Spiral_wasm::method21(v5976.await);
                                                        let v5981: string =
                                                    string("true; v5979 });  // rust.fix_closure\'");
                                                        let v5982: bool = true;
                                                        v5979
                                                    }); // rust.fix_closure';
                                                    let v5984 = __future_init;
                                                    v5984
                                                }
                                                _ => {
                                                    let v4920: bool = true;
                                                    let __future_init = Box::pin(async move {
                                                        //;
                                                        let v4922: bool = true;
                                                        let __future_init = Box::pin(async move {
                                                            //;
                                                            let v4923: u8 = Spiral_wasm::method34();
                                                            let v4927: string =
                                                    string("true; v4923 });  // rust.fix_closure\'");
                                                            let v4928: bool = true;
                                                            v4923
                                                        }); // rust.fix_closure';
                                                        let v4930 = __future_init;
                                                        let v4932: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = u8,
                                                                >,
                                                            >,
                                                        > = v4930;
                                                        let v4935: Spiral_wasm::US7 =
                                                            Spiral_wasm::method23(v4932.await);
                                                        let v4937: string =
                                                    string("true; v4935 });  // rust.fix_closure\'");
                                                        let v4938: bool = true;
                                                        v4935
                                                    }); // rust.fix_closure';
                                                    let v4940 = __future_init;
                                                    v4940
                                                }
                                            }
                                        }
                                        Spiral_wasm::US6::US6_1(v4917_1_0) => {
                                            let v5992: () = {
                                                Spiral_wasm::closure47(v4917_1_0.clone(), ());
                                                ()
                                            };
                                            let v6976: std::pin::Pin<
                                                Box<
                                                    dyn std::future::Future<
                                                        Output = Result<
                                                            Spiral_wasm::US4,
                                                            anyhow::Error,
                                                        >,
                                                    >,
                                                >,
                                            > = Spiral_wasm::method13(v777.clone(), 4_u8);
                                            let v6978: Result<Spiral_wasm::US4, anyhow::Error> =
                                                v6976.await;
                                            let v6979 = Spiral_wasm::method19();
                                            let v6981: Result<
                                                Spiral_wasm::US4,
                                                std::string::String,
                                            > = v6978.map_err(|x| v6979(x));
                                            let v6982: Spiral_wasm::US6 = match &v6981 {
                                                Err(v6981_1_0) => v786(v6981_1_0.clone()),
                                                Ok(v6981_0_0) => v785(v6981_0_0.clone()),
                                            };
                                            match &v6982 {
                                                Spiral_wasm::US6::US6_0(v6982_0_0) => {
                                                    let v6983: Spiral_wasm::US4 = v6982_0_0.clone();
                                                    match &v6983 {
                                                        Spiral_wasm::US4::US4_0(v6983_0_0) => {
                                                            let v7011: () = {
                                                                Spiral_wasm::closure70(
                                                                    match &v6983 {
                                                                        Spiral_wasm::US4::US4_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    },
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            let v8029: bool = true;
                                                            let __future_init = Box::pin(
                                                                async move {
                                                                    //;
                                                                    let v8031: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v8032: u8 =
                                                            Spiral_wasm::method33();
                                                                            let v8036: string =
                                                            string("true; v8032 });  // rust.fix_closure\'");
                                                                            let v8037: bool = true;
                                                                            v8032
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v8039 = __future_init;
                                                                    let v8041: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = u8,
                                                                            >,
                                                                        >,
                                                                    > = v8039;
                                                                    let v8044: Spiral_wasm::US7 =
                                                                        Spiral_wasm::method21(
                                                                            v8041.await,
                                                                        );
                                                                    let v8046: string =
                                                            string("true; v8044 });  // rust.fix_closure\'");
                                                                    let v8047: bool = true;
                                                                    v8044
                                                                },
                                                            ); // rust.fix_closure';
                                                            let v8049 = __future_init;
                                                            v8049
                                                        }
                                                        _ => {
                                                            let v6985: bool = true;
                                                            let __future_init = Box::pin(
                                                                async move {
                                                                    //;
                                                                    let v6987: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v6988: u8 =
                                                            Spiral_wasm::method33();
                                                                            let v6992: string =
                                                            string("true; v6988 });  // rust.fix_closure\'");
                                                                            let v6993: bool = true;
                                                                            v6988
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v6995 = __future_init;
                                                                    let v6997: std::pin::Pin<
                                                                        Box<
                                                                            dyn std::future::Future<
                                                                                Output = u8,
                                                                            >,
                                                                        >,
                                                                    > = v6995;
                                                                    let v7000: Spiral_wasm::US7 =
                                                                        Spiral_wasm::method23(
                                                                            v6997.await,
                                                                        );
                                                                    let v7002: string =
                                                            string("true; v7000 });  // rust.fix_closure\'");
                                                                    let v7003: bool = true;
                                                                    v7000
                                                                },
                                                            ); // rust.fix_closure';
                                                            let v7005 = __future_init;
                                                            v7005
                                                        }
                                                    }
                                                }
                                                Spiral_wasm::US6::US6_1(v6982_1_0) => {
                                                    let v8057: () = {
                                                        Spiral_wasm::closure48(
                                                            v6982_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v9041: std::pin::Pin<
                                                        Box<
                                                            dyn std::future::Future<
                                                                Output = Result<
                                                                    Spiral_wasm::US4,
                                                                    anyhow::Error,
                                                                >,
                                                            >,
                                                        >,
                                                    > = Spiral_wasm::method13(v777.clone(), 5_u8);
                                                    let v9043: Result<
                                                        Spiral_wasm::US4,
                                                        anyhow::Error,
                                                    > = v9041.await;
                                                    let v9044 = Spiral_wasm::method19();
                                                    let v9046: Result<
                                                        Spiral_wasm::US4,
                                                        std::string::String,
                                                    > = v9043.map_err(|x| v9044(x));
                                                    let v9047: Spiral_wasm::US6 = match &v9046 {
                                                        Err(v9046_1_0) => v786(v9046_1_0.clone()),
                                                        Ok(v9046_0_0) => v785(v9046_0_0.clone()),
                                                    };
                                                    match &v9047 {
                                                        Spiral_wasm::US6::US6_0(v9047_0_0) => {
                                                            let v9048: Spiral_wasm::US4 =
                                                                v9047_0_0.clone();
                                                            match &v9048 {
                                                                Spiral_wasm::US4::US4_0(
                                                                    v9048_0_0,
                                                                ) => {
                                                                    let v9076: () = {
                                                                        Spiral_wasm::closure69(match &v9048
                                                                                                   {
                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                   =>
                                                                                                   x.clone(),
                                                                                                   _
                                                                                                   =>
                                                                                                   unreachable!(),
                                                                                               },
                                                                                               ());
                                                                        ()
                                                                    };
                                                                    let v10094: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v10096: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v10097:
                                                                        u8 =
                                                                    Spiral_wasm::method32();
                                                                                        let v10101:
                                                                        string =
                                                                    string("true; v10097 });  // rust.fix_closure\'");
                                                                                        let v10102:
                                                                        bool =
                                                                    true;
                                                                                        v10097
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v10104 =
                                                                                __future_init;
                                                                            let v10106:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                    v10104;
                                                                            let v10109:
                                                                        Spiral_wasm::US7 =
                                                                    Spiral_wasm::method21(v10106.await);
                                                                            let v10111:
                                                                        string =
                                                                    string("true; v10109 });  // rust.fix_closure\'");
                                                                            let v10112: bool = true;
                                                                            v10109
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v10114 = __future_init;
                                                                    v10114
                                                                }
                                                                _ => {
                                                                    let v9050: bool = true;
                                                                    let __future_init = Box::pin(
                                                                        async move {
                                                                            //;
                                                                            let v9052: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v9053:
                                                                        u8 =
                                                                    Spiral_wasm::method32();
                                                                                        let v9057:
                                                                        string =
                                                                    string("true; v9053 });  // rust.fix_closure\'");
                                                                                        let v9058:
                                                                        bool =
                                                                    true;
                                                                                        v9053
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v9060 =
                                                                                __future_init;
                                                                            let v9062:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                    v9060;
                                                                            let v9065:
                                                                        Spiral_wasm::US7 =
                                                                    Spiral_wasm::method23(v9062.await);
                                                                            let v9067:
                                                                        string =
                                                                    string("true; v9065 });  // rust.fix_closure\'");
                                                                            let v9068: bool = true;
                                                                            v9065
                                                                        },
                                                                    ); // rust.fix_closure';
                                                                    let v9070 = __future_init;
                                                                    v9070
                                                                }
                                                            }
                                                        }
                                                        Spiral_wasm::US6::US6_1(v9047_1_0) => {
                                                            let v10122: () = {
                                                                Spiral_wasm::closure49(
                                                                    v9047_1_0.clone(),
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            let v11106: std::pin::Pin<
                                                                Box<
                                                                    dyn std::future::Future<
                                                                        Output = Result<
                                                                            Spiral_wasm::US4,
                                                                            anyhow::Error,
                                                                        >,
                                                                    >,
                                                                >,
                                                            > = Spiral_wasm::method13(
                                                                v777.clone(),
                                                                6_u8,
                                                            );
                                                            let v11108: Result<
                                                                Spiral_wasm::US4,
                                                                anyhow::Error,
                                                            > = v11106.await;
                                                            let v11109 = Spiral_wasm::method19();
                                                            let v11111: Result<
                                                                Spiral_wasm::US4,
                                                                std::string::String,
                                                            > = v11108.map_err(|x| v11109(x));
                                                            let v11112: Spiral_wasm::US6 =
                                                                match &v11111 {
                                                                    Err(v11111_1_0) => {
                                                                        v786(v11111_1_0.clone())
                                                                    }
                                                                    Ok(v11111_0_0) => {
                                                                        v785(v11111_0_0.clone())
                                                                    }
                                                                };
                                                            match &v11112 {
                                                                Spiral_wasm::US6::US6_0(
                                                                    v11112_0_0,
                                                                ) => {
                                                                    let v11113: Spiral_wasm::US4 =
                                                                        v11112_0_0.clone();
                                                                    match &v11113 {
                                                                        Spiral_wasm::US4::US4_0(
                                                                            v11113_0_0,
                                                                        ) => {
                                                                            let v11141: () = {
                                                                                Spiral_wasm::closure68(match &v11113
                                                                                                           {
                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       },
                                                                                                       ());
                                                                                ()
                                                                            };
                                                                            let v12159: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v12161:
                                                                                bool =
                                                                            true;
                                                                                        let __future_init =
                                                                                            Box::pin(
                                                                                                async move {
                                                                                                    //;
                                                                                                    let v12162:
                                                                                u8 =
                                                                            Spiral_wasm::method31();
                                                                                                    let v12166:
                                                                                string =
                                                                            string("true; v12162 });  // rust.fix_closure\'");
                                                                                                    let v12167:
                                                                                bool =
                                                                            true;
                                                                                                    v12162
                                                                                                },
                                                                                            ); // rust.fix_closure';
                                                                                        let v12169 =
                                                                            __future_init;
                                                                                        let v12171:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                            v12169;
                                                                                        let v12174:
                                                                                Spiral_wasm::US7 =
                                                                            Spiral_wasm::method21(v12171.await);
                                                                                        let v12176:
                                                                                string =
                                                                            string("true; v12174 });  // rust.fix_closure\'");
                                                                                        let v12177:
                                                                                bool =
                                                                            true;
                                                                                        v12174
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v12179 =
                                                                                __future_init;
                                                                            v12179
                                                                        }
                                                                        _ => {
                                                                            let v11115: bool = true;
                                                                            let __future_init =
                                                                                Box::pin(
                                                                                    async move {
                                                                                        //;
                                                                                        let v11117:
                                                                                bool =
                                                                            true;
                                                                                        let __future_init =
                                                                                            Box::pin(
                                                                                                async move {
                                                                                                    //;
                                                                                                    let v11118:
                                                                                u8 =
                                                                            Spiral_wasm::method31();
                                                                                                    let v11122:
                                                                                string =
                                                                            string("true; v11118 });  // rust.fix_closure\'");
                                                                                                    let v11123:
                                                                                bool =
                                                                            true;
                                                                                                    v11118
                                                                                                },
                                                                                            ); // rust.fix_closure';
                                                                                        let v11125 =
                                                                            __future_init;
                                                                                        let v11127:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                            v11125;
                                                                                        let v11130:
                                                                                Spiral_wasm::US7 =
                                                                            Spiral_wasm::method23(v11127.await);
                                                                                        let v11132:
                                                                                string =
                                                                            string("true; v11130 });  // rust.fix_closure\'");
                                                                                        let v11133:
                                                                                bool =
                                                                            true;
                                                                                        v11130
                                                                                    },
                                                                                ); // rust.fix_closure';
                                                                            let v11135 =
                                                                                __future_init;
                                                                            v11135
                                                                        }
                                                                    }
                                                                }
                                                                Spiral_wasm::US6::US6_1(
                                                                    v11112_1_0,
                                                                ) => {
                                                                    let v12187: () = {
                                                                        Spiral_wasm::closure50(
                                                                            v11112_1_0.clone(),
                                                                            (),
                                                                        );
                                                                        ()
                                                                    };
                                                                    let v13171:
                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                  anyhow::Error>>>> =
                                                                    Spiral_wasm::method13(v777.clone(),
                                                                                          7_u8);
                                                                    let v13173: Result<
                                                                        Spiral_wasm::US4,
                                                                        anyhow::Error,
                                                                    > = v13171.await;
                                                                    let v13174 =
                                                                        Spiral_wasm::method19();
                                                                    let v13176: Result<
                                                                        Spiral_wasm::US4,
                                                                        std::string::String,
                                                                    > = v13173
                                                                        .map_err(|x| v13174(x));
                                                                    let v13177: Spiral_wasm::US6 =
                                                                        match &v13176 {
                                                                            Err(v13176_1_0) => {
                                                                                v786(
                                                                                    v13176_1_0
                                                                                        .clone(),
                                                                                )
                                                                            }
                                                                            Ok(v13176_0_0) => v785(
                                                                                v13176_0_0.clone(),
                                                                            ),
                                                                        };
                                                                    match &v13177 {
                                                                        Spiral_wasm::US6::US6_0(
                                                                            v13177_0_0,
                                                                        ) => {
                                                                            let v13178:
                                                                                Spiral_wasm::US4 =
                                                                            v13177_0_0.clone();
                                                                            match &v13178
                                                                            {
                                                                            Spiral_wasm::US4::US4_0(v13178_0_0)
                                                                            =>
                                                                            {
                                                                                let v13206:
                                                                                        () =
                                                                                    {
                                                                                        Spiral_wasm::closure67(match &v13178
                                                                                                                   {
                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                   =>
                                                                                                                   x.clone(),
                                                                                                                   _
                                                                                                                   =>
                                                                                                                   unreachable!(),
                                                                                                               },
                                                                                                               ());
                                                                                        ()
                                                                                    };
                                                                                let v14224:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v14226:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v14227:
                                                                                        u8 =
                                                                                    Spiral_wasm::method30();
                                                                                let v14231:
                                                                                        string =
                                                                                    string("true; v14227 });  // rust.fix_closure\'");
                                                                                let v14232:
                                                                                        bool =
                                                                                    true; v14227 });  // rust.fix_closure';
                                                                                let v14234 =
                                                                                    __future_init;
                                                                                let v14236:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                    v14234;
                                                                                let v14239:
                                                                                        Spiral_wasm::US7 =
                                                                                    Spiral_wasm::method21(v14236.await);
                                                                                let v14241:
                                                                                        string =
                                                                                    string("true; v14239 });  // rust.fix_closure\'");
                                                                                let v14242:
                                                                                        bool =
                                                                                    true; v14239 });  // rust.fix_closure';
                                                                                let v14244 =
                                                                                    __future_init;
                                                                                v14244
                                                                            }
                                                                            _
                                                                            =>
                                                                            {
                                                                                let v13180:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v13182:
                                                                                        bool =
                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                let v13183:
                                                                                        u8 =
                                                                                    Spiral_wasm::method30();
                                                                                let v13187:
                                                                                        string =
                                                                                    string("true; v13183 });  // rust.fix_closure\'");
                                                                                let v13188:
                                                                                        bool =
                                                                                    true; v13183 });  // rust.fix_closure';
                                                                                let v13190 =
                                                                                    __future_init;
                                                                                let v13192:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                    v13190;
                                                                                let v13195:
                                                                                        Spiral_wasm::US7 =
                                                                                    Spiral_wasm::method23(v13192.await);
                                                                                let v13197:
                                                                                        string =
                                                                                    string("true; v13195 });  // rust.fix_closure\'");
                                                                                let v13198:
                                                                                        bool =
                                                                                    true; v13195 });  // rust.fix_closure';
                                                                                let v13200 =
                                                                                    __future_init;
                                                                                v13200
                                                                            }
                                                                        }
                                                                        }
                                                                        Spiral_wasm::US6::US6_1(
                                                                            v13177_1_0,
                                                                        ) => {
                                                                            let v14252: () = {
                                                                                Spiral_wasm::closure51(v13177_1_0.clone(),
                                                                                                       ());
                                                                                ()
                                                                            };
                                                                            let v15236:
                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                          anyhow::Error>>>> =
                                                                            Spiral_wasm::method13(v777.clone(),
                                                                                                  8_u8);
                                                                            let v15238: Result<
                                                                                Spiral_wasm::US4,
                                                                                anyhow::Error,
                                                                            > = v15236.await;
                                                                            let v15239 =
                                                                            Spiral_wasm::method19();
                                                                            let v15241: Result<
                                                                                Spiral_wasm::US4,
                                                                                std::string::String,
                                                                            > = v15238.map_err(
                                                                                |x| v15239(x),
                                                                            );
                                                                            let v15242:
                                                                                Spiral_wasm::US6 =
                                                                            match &v15241
                                                                                {
                                                                                Err(v15241_1_0)
                                                                                =>
                                                                                v786(v15241_1_0.clone()),
                                                                                Ok(v15241_0_0)
                                                                                =>
                                                                                v785(v15241_0_0.clone()),
                                                                            };
                                                                            match &v15242
                                                                            {
                                                                            Spiral_wasm::US6::US6_0(v15242_0_0)
                                                                            =>
                                                                            {
                                                                                let v15243:
                                                                                        Spiral_wasm::US4 =
                                                                                    v15242_0_0.clone();
                                                                                match &v15243
                                                                                    {
                                                                                    Spiral_wasm::US4::US4_0(v15243_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v15271:
                                                                                                () =
                                                                                            {
                                                                                                Spiral_wasm::closure66(match &v15243
                                                                                                                           {
                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                           =>
                                                                                                                           x.clone(),
                                                                                                                           _
                                                                                                                           =>
                                                                                                                           unreachable!(),
                                                                                                                       },
                                                                                                                       ());
                                                                                                ()
                                                                                            };
                                                                                        let v16289:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v16291:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v16292:
                                                                                                u8 =
                                                                                            Spiral_wasm::method29();
                                                                                        let v16296:
                                                                                                string =
                                                                                            string("true; v16292 });  // rust.fix_closure\'");
                                                                                        let v16297:
                                                                                                bool =
                                                                                            true; v16292 });  // rust.fix_closure';
                                                                                        let v16299 =
                                                                                            __future_init;
                                                                                        let v16301:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                            v16299;
                                                                                        let v16304:
                                                                                                Spiral_wasm::US7 =
                                                                                            Spiral_wasm::method21(v16301.await);
                                                                                        let v16306:
                                                                                                string =
                                                                                            string("true; v16304 });  // rust.fix_closure\'");
                                                                                        let v16307:
                                                                                                bool =
                                                                                            true; v16304 });  // rust.fix_closure';
                                                                                        let v16309 =
                                                                                            __future_init;
                                                                                        v16309
                                                                                    }
                                                                                    _
                                                                                    =>
                                                                                    {
                                                                                        let v15245:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v15247:
                                                                                                bool =
                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                        let v15248:
                                                                                                u8 =
                                                                                            Spiral_wasm::method29();
                                                                                        let v15252:
                                                                                                string =
                                                                                            string("true; v15248 });  // rust.fix_closure\'");
                                                                                        let v15253:
                                                                                                bool =
                                                                                            true; v15248 });  // rust.fix_closure';
                                                                                        let v15255 =
                                                                                            __future_init;
                                                                                        let v15257:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                            v15255;
                                                                                        let v15260:
                                                                                                Spiral_wasm::US7 =
                                                                                            Spiral_wasm::method23(v15257.await);
                                                                                        let v15262:
                                                                                                string =
                                                                                            string("true; v15260 });  // rust.fix_closure\'");
                                                                                        let v15263:
                                                                                                bool =
                                                                                            true; v15260 });  // rust.fix_closure';
                                                                                        let v15265 =
                                                                                            __future_init;
                                                                                        v15265
                                                                                    }
                                                                                }
                                                                            }
                                                                            Spiral_wasm::US6::US6_1(v15242_1_0)
                                                                            =>
                                                                            {
                                                                                let v16317:
                                                                                        () =
                                                                                    {
                                                                                        Spiral_wasm::closure52(v15242_1_0.clone(),
                                                                                                               ());
                                                                                        ()
                                                                                    };
                                                                                let v17301:
                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                  anyhow::Error>>>> =
                                                                                    Spiral_wasm::method13(v777.clone(),
                                                                                                          9_u8);
                                                                                let v17303:
                                                                                        Result<Spiral_wasm::US4,
                                                                                               anyhow::Error> =
                                                                                    v17301.await;
                                                                                let v17304 =
                                                                                    Spiral_wasm::method19();
                                                                                let v17306:
                                                                                        Result<Spiral_wasm::US4,
                                                                                               std::string::String> =
                                                                                    v17303.map_err(|x| v17304(x));
                                                                                let v17307:
                                                                                        Spiral_wasm::US6 =
                                                                                    match &v17306
                                                                                        {
                                                                                        Err(v17306_1_0)
                                                                                        =>
                                                                                        v786(v17306_1_0.clone()),
                                                                                        Ok(v17306_0_0)
                                                                                        =>
                                                                                        v785(v17306_0_0.clone()),
                                                                                    };
                                                                                match &v17307
                                                                                    {
                                                                                    Spiral_wasm::US6::US6_0(v17307_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v17308:
                                                                                                Spiral_wasm::US4 =
                                                                                            v17307_0_0.clone();
                                                                                        match &v17308
                                                                                            {
                                                                                            Spiral_wasm::US4::US4_0(v17308_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v17336:
                                                                                                        () =
                                                                                                    {
                                                                                                        Spiral_wasm::closure65(match &v17308
                                                                                                                                   {
                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                   =>
                                                                                                                                   x.clone(),
                                                                                                                                   _
                                                                                                                                   =>
                                                                                                                                   unreachable!(),
                                                                                                                               },
                                                                                                                               ());
                                                                                                        ()
                                                                                                    };
                                                                                                let v18354:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v18356:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v18357:
                                                                                                        u8 =
                                                                                                    Spiral_wasm::method28();
                                                                                                let v18361:
                                                                                                        string =
                                                                                                    string("true; v18357 });  // rust.fix_closure\'");
                                                                                                let v18362:
                                                                                                        bool =
                                                                                                    true; v18357 });  // rust.fix_closure';
                                                                                                let v18364 =
                                                                                                    __future_init;
                                                                                                let v18366:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                    v18364;
                                                                                                let v18369:
                                                                                                        Spiral_wasm::US7 =
                                                                                                    Spiral_wasm::method21(v18366.await);
                                                                                                let v18371:
                                                                                                        string =
                                                                                                    string("true; v18369 });  // rust.fix_closure\'");
                                                                                                let v18372:
                                                                                                        bool =
                                                                                                    true; v18369 });  // rust.fix_closure';
                                                                                                let v18374 =
                                                                                                    __future_init;
                                                                                                v18374
                                                                                            }
                                                                                            _
                                                                                            =>
                                                                                            {
                                                                                                let v17310:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v17312:
                                                                                                        bool =
                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                let v17313:
                                                                                                        u8 =
                                                                                                    Spiral_wasm::method28();
                                                                                                let v17317:
                                                                                                        string =
                                                                                                    string("true; v17313 });  // rust.fix_closure\'");
                                                                                                let v17318:
                                                                                                        bool =
                                                                                                    true; v17313 });  // rust.fix_closure';
                                                                                                let v17320 =
                                                                                                    __future_init;
                                                                                                let v17322:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                    v17320;
                                                                                                let v17325:
                                                                                                        Spiral_wasm::US7 =
                                                                                                    Spiral_wasm::method23(v17322.await);
                                                                                                let v17327:
                                                                                                        string =
                                                                                                    string("true; v17325 });  // rust.fix_closure\'");
                                                                                                let v17328:
                                                                                                        bool =
                                                                                                    true; v17325 });  // rust.fix_closure';
                                                                                                let v17330 =
                                                                                                    __future_init;
                                                                                                v17330
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    Spiral_wasm::US6::US6_1(v17307_1_0)
                                                                                    =>
                                                                                    {
                                                                                        let v18382:
                                                                                                () =
                                                                                            {
                                                                                                Spiral_wasm::closure53(v17307_1_0.clone(),
                                                                                                                       ());
                                                                                                ()
                                                                                            };
                                                                                        let v19366:
                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                          anyhow::Error>>>> =
                                                                                            Spiral_wasm::method13(v777.clone(),
                                                                                                                  10_u8);
                                                                                        let v19368:
                                                                                                Result<Spiral_wasm::US4,
                                                                                                       anyhow::Error> =
                                                                                            v19366.await;
                                                                                        let v19369 =
                                                                                            Spiral_wasm::method19();
                                                                                        let v19371:
                                                                                                Result<Spiral_wasm::US4,
                                                                                                       std::string::String> =
                                                                                            v19368.map_err(|x| v19369(x));
                                                                                        let v19372:
                                                                                                Spiral_wasm::US6 =
                                                                                            match &v19371
                                                                                                {
                                                                                                Err(v19371_1_0)
                                                                                                =>
                                                                                                v786(v19371_1_0.clone()),
                                                                                                Ok(v19371_0_0)
                                                                                                =>
                                                                                                v785(v19371_0_0.clone()),
                                                                                            };
                                                                                        match &v19372
                                                                                            {
                                                                                            Spiral_wasm::US6::US6_0(v19372_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v19373:
                                                                                                        Spiral_wasm::US4 =
                                                                                                    v19372_0_0.clone();
                                                                                                match &v19373
                                                                                                    {
                                                                                                    Spiral_wasm::US4::US4_0(v19373_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v19401:
                                                                                                                () =
                                                                                                            {
                                                                                                                Spiral_wasm::closure64(match &v19373
                                                                                                                                           {
                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                           =>
                                                                                                                                           x.clone(),
                                                                                                                                           _
                                                                                                                                           =>
                                                                                                                                           unreachable!(),
                                                                                                                                       },
                                                                                                                                       ());
                                                                                                                ()
                                                                                                            };
                                                                                                        let v20419:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v20421:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v20422:
                                                                                                                u8 =
                                                                                                            Spiral_wasm::method27();
                                                                                                        let v20426:
                                                                                                                string =
                                                                                                            string("true; v20422 });  // rust.fix_closure\'");
                                                                                                        let v20427:
                                                                                                                bool =
                                                                                                            true; v20422 });  // rust.fix_closure';
                                                                                                        let v20429 =
                                                                                                            __future_init;
                                                                                                        let v20431:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                            v20429;
                                                                                                        let v20434:
                                                                                                                Spiral_wasm::US7 =
                                                                                                            Spiral_wasm::method21(v20431.await);
                                                                                                        let v20436:
                                                                                                                string =
                                                                                                            string("true; v20434 });  // rust.fix_closure\'");
                                                                                                        let v20437:
                                                                                                                bool =
                                                                                                            true; v20434 });  // rust.fix_closure';
                                                                                                        let v20439 =
                                                                                                            __future_init;
                                                                                                        v20439
                                                                                                    }
                                                                                                    _
                                                                                                    =>
                                                                                                    {
                                                                                                        let v19375:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v19377:
                                                                                                                bool =
                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                        let v19378:
                                                                                                                u8 =
                                                                                                            Spiral_wasm::method27();
                                                                                                        let v19382:
                                                                                                                string =
                                                                                                            string("true; v19378 });  // rust.fix_closure\'");
                                                                                                        let v19383:
                                                                                                                bool =
                                                                                                            true; v19378 });  // rust.fix_closure';
                                                                                                        let v19385 =
                                                                                                            __future_init;
                                                                                                        let v19387:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                            v19385;
                                                                                                        let v19390:
                                                                                                                Spiral_wasm::US7 =
                                                                                                            Spiral_wasm::method23(v19387.await);
                                                                                                        let v19392:
                                                                                                                string =
                                                                                                            string("true; v19390 });  // rust.fix_closure\'");
                                                                                                        let v19393:
                                                                                                                bool =
                                                                                                            true; v19390 });  // rust.fix_closure';
                                                                                                        let v19395 =
                                                                                                            __future_init;
                                                                                                        v19395
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                            Spiral_wasm::US6::US6_1(v19372_1_0)
                                                                                            =>
                                                                                            {
                                                                                                let v20447:
                                                                                                        () =
                                                                                                    {
                                                                                                        Spiral_wasm::closure54(v19372_1_0.clone(),
                                                                                                                               ());
                                                                                                        ()
                                                                                                    };
                                                                                                let v21431:
                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                    Spiral_wasm::method13(v777.clone(),
                                                                                                                          11_u8);
                                                                                                let v21433:
                                                                                                        Result<Spiral_wasm::US4,
                                                                                                               anyhow::Error> =
                                                                                                    v21431.await;
                                                                                                let v21434 =
                                                                                                    Spiral_wasm::method19();
                                                                                                let v21436:
                                                                                                        Result<Spiral_wasm::US4,
                                                                                                               std::string::String> =
                                                                                                    v21433.map_err(|x| v21434(x));
                                                                                                let v21437:
                                                                                                        Spiral_wasm::US6 =
                                                                                                    match &v21436
                                                                                                        {
                                                                                                        Err(v21436_1_0)
                                                                                                        =>
                                                                                                        v786(v21436_1_0.clone()),
                                                                                                        Ok(v21436_0_0)
                                                                                                        =>
                                                                                                        v785(v21436_0_0.clone()),
                                                                                                    };
                                                                                                match &v21437
                                                                                                    {
                                                                                                    Spiral_wasm::US6::US6_0(v21437_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v21438:
                                                                                                                Spiral_wasm::US4 =
                                                                                                            v21437_0_0.clone();
                                                                                                        match &v21438
                                                                                                            {
                                                                                                            Spiral_wasm::US4::US4_0(v21438_0_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v21466:
                                                                                                                        () =
                                                                                                                    {
                                                                                                                        Spiral_wasm::closure63(match &v21438
                                                                                                                                                   {
                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                   =>
                                                                                                                                                   x.clone(),
                                                                                                                                                   _
                                                                                                                                                   =>
                                                                                                                                                   unreachable!(),
                                                                                                                                               },
                                                                                                                                               ());
                                                                                                                        ()
                                                                                                                    };
                                                                                                                let v22484:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v22486:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v22487:
                                                                                                                        u8 =
                                                                                                                    Spiral_wasm::method26();
                                                                                                                let v22491:
                                                                                                                        string =
                                                                                                                    string("true; v22487 });  // rust.fix_closure\'");
                                                                                                                let v22492:
                                                                                                                        bool =
                                                                                                                    true; v22487 });  // rust.fix_closure';
                                                                                                                let v22494 =
                                                                                                                    __future_init;
                                                                                                                let v22496:
                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                    v22494;
                                                                                                                let v22499:
                                                                                                                        Spiral_wasm::US7 =
                                                                                                                    Spiral_wasm::method21(v22496.await);
                                                                                                                let v22501:
                                                                                                                        string =
                                                                                                                    string("true; v22499 });  // rust.fix_closure\'");
                                                                                                                let v22502:
                                                                                                                        bool =
                                                                                                                    true; v22499 });  // rust.fix_closure';
                                                                                                                let v22504 =
                                                                                                                    __future_init;
                                                                                                                v22504
                                                                                                            }
                                                                                                            _
                                                                                                            =>
                                                                                                            {
                                                                                                                let v21440:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v21442:
                                                                                                                        bool =
                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                let v21443:
                                                                                                                        u8 =
                                                                                                                    Spiral_wasm::method26();
                                                                                                                let v21447:
                                                                                                                        string =
                                                                                                                    string("true; v21443 });  // rust.fix_closure\'");
                                                                                                                let v21448:
                                                                                                                        bool =
                                                                                                                    true; v21443 });  // rust.fix_closure';
                                                                                                                let v21450 =
                                                                                                                    __future_init;
                                                                                                                let v21452:
                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                    v21450;
                                                                                                                let v21455:
                                                                                                                        Spiral_wasm::US7 =
                                                                                                                    Spiral_wasm::method23(v21452.await);
                                                                                                                let v21457:
                                                                                                                        string =
                                                                                                                    string("true; v21455 });  // rust.fix_closure\'");
                                                                                                                let v21458:
                                                                                                                        bool =
                                                                                                                    true; v21455 });  // rust.fix_closure';
                                                                                                                let v21460 =
                                                                                                                    __future_init;
                                                                                                                v21460
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                    Spiral_wasm::US6::US6_1(v21437_1_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v22512:
                                                                                                                () =
                                                                                                            {
                                                                                                                Spiral_wasm::closure55(v21437_1_0.clone(),
                                                                                                                                       ());
                                                                                                                ()
                                                                                                            };
                                                                                                        let v23496:
                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                            Spiral_wasm::method13(v777.clone(),
                                                                                                                                  12_u8);
                                                                                                        let v23498:
                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                       anyhow::Error> =
                                                                                                            v23496.await;
                                                                                                        let v23499 =
                                                                                                            Spiral_wasm::method19();
                                                                                                        let v23501:
                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                       std::string::String> =
                                                                                                            v23498.map_err(|x| v23499(x));
                                                                                                        let v23502:
                                                                                                                Spiral_wasm::US6 =
                                                                                                            match &v23501
                                                                                                                {
                                                                                                                Err(v23501_1_0)
                                                                                                                =>
                                                                                                                v786(v23501_1_0.clone()),
                                                                                                                Ok(v23501_0_0)
                                                                                                                =>
                                                                                                                v785(v23501_0_0.clone()),
                                                                                                            };
                                                                                                        match &v23502
                                                                                                            {
                                                                                                            Spiral_wasm::US6::US6_0(v23502_0_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v23503:
                                                                                                                        Spiral_wasm::US4 =
                                                                                                                    v23502_0_0.clone();
                                                                                                                match &v23503
                                                                                                                    {
                                                                                                                    Spiral_wasm::US4::US4_0(v23503_0_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v23531:
                                                                                                                                () =
                                                                                                                            {
                                                                                                                                Spiral_wasm::closure62(match &v23503
                                                                                                                                                           {
                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                           =>
                                                                                                                                                           x.clone(),
                                                                                                                                                           _
                                                                                                                                                           =>
                                                                                                                                                           unreachable!(),
                                                                                                                                                       },
                                                                                                                                                       ());
                                                                                                                                ()
                                                                                                                            };
                                                                                                                        let v24549:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v24551:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v24552:
                                                                                                                                u8 =
                                                                                                                            Spiral_wasm::method25();
                                                                                                                        let v24556:
                                                                                                                                string =
                                                                                                                            string("true; v24552 });  // rust.fix_closure\'");
                                                                                                                        let v24557:
                                                                                                                                bool =
                                                                                                                            true; v24552 });  // rust.fix_closure';
                                                                                                                        let v24559 =
                                                                                                                            __future_init;
                                                                                                                        let v24561:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                            v24559;
                                                                                                                        let v24564:
                                                                                                                                Spiral_wasm::US7 =
                                                                                                                            Spiral_wasm::method21(v24561.await);
                                                                                                                        let v24566:
                                                                                                                                string =
                                                                                                                            string("true; v24564 });  // rust.fix_closure\'");
                                                                                                                        let v24567:
                                                                                                                                bool =
                                                                                                                            true; v24564 });  // rust.fix_closure';
                                                                                                                        let v24569 =
                                                                                                                            __future_init;
                                                                                                                        v24569
                                                                                                                    }
                                                                                                                    _
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v23505:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v23507:
                                                                                                                                bool =
                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                        let v23508:
                                                                                                                                u8 =
                                                                                                                            Spiral_wasm::method25();
                                                                                                                        let v23512:
                                                                                                                                string =
                                                                                                                            string("true; v23508 });  // rust.fix_closure\'");
                                                                                                                        let v23513:
                                                                                                                                bool =
                                                                                                                            true; v23508 });  // rust.fix_closure';
                                                                                                                        let v23515 =
                                                                                                                            __future_init;
                                                                                                                        let v23517:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                            v23515;
                                                                                                                        let v23520:
                                                                                                                                Spiral_wasm::US7 =
                                                                                                                            Spiral_wasm::method23(v23517.await);
                                                                                                                        let v23522:
                                                                                                                                string =
                                                                                                                            string("true; v23520 });  // rust.fix_closure\'");
                                                                                                                        let v23523:
                                                                                                                                bool =
                                                                                                                            true; v23520 });  // rust.fix_closure';
                                                                                                                        let v23525 =
                                                                                                                            __future_init;
                                                                                                                        v23525
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                            Spiral_wasm::US6::US6_1(v23502_1_0)
                                                                                                            =>
                                                                                                            {
                                                                                                                let v24577:
                                                                                                                        () =
                                                                                                                    {
                                                                                                                        Spiral_wasm::closure56(v23502_1_0.clone(),
                                                                                                                                               ());
                                                                                                                        ()
                                                                                                                    };
                                                                                                                let v25561:
                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                  anyhow::Error>>>> =
                                                                                                                    Spiral_wasm::method13(v777.clone(),
                                                                                                                                          13_u8);
                                                                                                                let v25563:
                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                               anyhow::Error> =
                                                                                                                    v25561.await;
                                                                                                                let v25564 =
                                                                                                                    Spiral_wasm::method19();
                                                                                                                let v25566:
                                                                                                                        Result<Spiral_wasm::US4,
                                                                                                                               std::string::String> =
                                                                                                                    v25563.map_err(|x| v25564(x));
                                                                                                                let v25567:
                                                                                                                        Spiral_wasm::US6 =
                                                                                                                    match &v25566
                                                                                                                        {
                                                                                                                        Err(v25566_1_0)
                                                                                                                        =>
                                                                                                                        v786(v25566_1_0.clone()),
                                                                                                                        Ok(v25566_0_0)
                                                                                                                        =>
                                                                                                                        v785(v25566_0_0.clone()),
                                                                                                                    };
                                                                                                                match &v25567
                                                                                                                    {
                                                                                                                    Spiral_wasm::US6::US6_0(v25567_0_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v25568:
                                                                                                                                Spiral_wasm::US4 =
                                                                                                                            v25567_0_0.clone();
                                                                                                                        match &v25568
                                                                                                                            {
                                                                                                                            Spiral_wasm::US4::US4_0(v25568_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v25596:
                                                                                                                                        () =
                                                                                                                                    {
                                                                                                                                        Spiral_wasm::closure61(match &v25568
                                                                                                                                                                   {
                                                                                                                                                                   Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                   =>
                                                                                                                                                                   x.clone(),
                                                                                                                                                                   _
                                                                                                                                                                   =>
                                                                                                                                                                   unreachable!(),
                                                                                                                                                               },
                                                                                                                                                               ());
                                                                                                                                        ()
                                                                                                                                    };
                                                                                                                                let v26614:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v26616:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v26617:
                                                                                                                                        u8 =
                                                                                                                                    Spiral_wasm::method24();
                                                                                                                                let v26621:
                                                                                                                                        string =
                                                                                                                                    string("true; v26617 });  // rust.fix_closure\'");
                                                                                                                                let v26622:
                                                                                                                                        bool =
                                                                                                                                    true; v26617 });  // rust.fix_closure';
                                                                                                                                let v26624 =
                                                                                                                                    __future_init;
                                                                                                                                let v26626:
                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                    v26624;
                                                                                                                                let v26629:
                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                    Spiral_wasm::method21(v26626.await);
                                                                                                                                let v26631:
                                                                                                                                        string =
                                                                                                                                    string("true; v26629 });  // rust.fix_closure\'");
                                                                                                                                let v26632:
                                                                                                                                        bool =
                                                                                                                                    true; v26629 });  // rust.fix_closure';
                                                                                                                                let v26634 =
                                                                                                                                    __future_init;
                                                                                                                                v26634
                                                                                                                            }
                                                                                                                            _
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v25570:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v25572:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v25573:
                                                                                                                                        u8 =
                                                                                                                                    Spiral_wasm::method24();
                                                                                                                                let v25577:
                                                                                                                                        string =
                                                                                                                                    string("true; v25573 });  // rust.fix_closure\'");
                                                                                                                                let v25578:
                                                                                                                                        bool =
                                                                                                                                    true; v25573 });  // rust.fix_closure';
                                                                                                                                let v25580 =
                                                                                                                                    __future_init;
                                                                                                                                let v25582:
                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                    v25580;
                                                                                                                                let v25585:
                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                    Spiral_wasm::method23(v25582.await);
                                                                                                                                let v25587:
                                                                                                                                        string =
                                                                                                                                    string("true; v25585 });  // rust.fix_closure\'");
                                                                                                                                let v25588:
                                                                                                                                        bool =
                                                                                                                                    true; v25585 });  // rust.fix_closure';
                                                                                                                                let v25590 =
                                                                                                                                    __future_init;
                                                                                                                                v25590
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                    Spiral_wasm::US6::US6_1(v25567_1_0)
                                                                                                                    =>
                                                                                                                    {
                                                                                                                        let v26642:
                                                                                                                                () =
                                                                                                                            {
                                                                                                                                Spiral_wasm::closure57(v25567_1_0.clone(),
                                                                                                                                                       ());
                                                                                                                                ()
                                                                                                                            };
                                                                                                                        let v27626:
                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<Spiral_wasm::US4,
                                                                                                                                                                                          anyhow::Error>>>> =
                                                                                                                            Spiral_wasm::method13(v777.clone(),
                                                                                                                                                  14_u8);
                                                                                                                        let v27628:
                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                       anyhow::Error> =
                                                                                                                            v27626.await;
                                                                                                                        let v27629 =
                                                                                                                            Spiral_wasm::method19();
                                                                                                                        let v27631:
                                                                                                                                Result<Spiral_wasm::US4,
                                                                                                                                       std::string::String> =
                                                                                                                            v27628.map_err(|x| v27629(x));
                                                                                                                        let v27632:
                                                                                                                                Spiral_wasm::US6 =
                                                                                                                            match &v27631
                                                                                                                                {
                                                                                                                                Err(v27631_1_0)
                                                                                                                                =>
                                                                                                                                v786(v27631_1_0.clone()),
                                                                                                                                Ok(v27631_0_0)
                                                                                                                                =>
                                                                                                                                v785(v27631_0_0.clone()),
                                                                                                                            };
                                                                                                                        match &v27632
                                                                                                                            {
                                                                                                                            Spiral_wasm::US6::US6_0(v27632_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v27633:
                                                                                                                                        Spiral_wasm::US4 =
                                                                                                                                    v27632_0_0.clone();
                                                                                                                                match &v27633
                                                                                                                                    {
                                                                                                                                    Spiral_wasm::US4::US4_0(v27633_0_0)
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v27661:
                                                                                                                                                () =
                                                                                                                                            {
                                                                                                                                                Spiral_wasm::closure59(match &v27633
                                                                                                                                                                           {
                                                                                                                                                                           Spiral_wasm::US4::US4_0(x)
                                                                                                                                                                           =>
                                                                                                                                                                           x.clone(),
                                                                                                                                                                           _
                                                                                                                                                                           =>
                                                                                                                                                                           unreachable!(),
                                                                                                                                                                       },
                                                                                                                                                                       ());
                                                                                                                                                ()
                                                                                                                                            };
                                                                                                                                        let v28679:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v28681:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v28682:
                                                                                                                                                u8 =
                                                                                                                                            Spiral_wasm::method22();
                                                                                                                                        let v28686:
                                                                                                                                                string =
                                                                                                                                            string("true; v28682 });  // rust.fix_closure\'");
                                                                                                                                        let v28687:
                                                                                                                                                bool =
                                                                                                                                            true; v28682 });  // rust.fix_closure';
                                                                                                                                        let v28689 =
                                                                                                                                            __future_init;
                                                                                                                                        let v28691:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                            v28689;
                                                                                                                                        let v28694:
                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                            Spiral_wasm::method21(v28691.await);
                                                                                                                                        let v28696:
                                                                                                                                                string =
                                                                                                                                            string("true; v28694 });  // rust.fix_closure\'");
                                                                                                                                        let v28697:
                                                                                                                                                bool =
                                                                                                                                            true; v28694 });  // rust.fix_closure';
                                                                                                                                        let v28699 =
                                                                                                                                            __future_init;
                                                                                                                                        v28699
                                                                                                                                    }
                                                                                                                                    _
                                                                                                                                    =>
                                                                                                                                    {
                                                                                                                                        let v27635:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v27637:
                                                                                                                                                bool =
                                                                                                                                            true; let __future_init = Box::pin(async move { //;
                                                                                                                                        let v27638:
                                                                                                                                                u8 =
                                                                                                                                            Spiral_wasm::method22();
                                                                                                                                        let v27642:
                                                                                                                                                string =
                                                                                                                                            string("true; v27638 });  // rust.fix_closure\'");
                                                                                                                                        let v27643:
                                                                                                                                                bool =
                                                                                                                                            true; v27638 });  // rust.fix_closure';
                                                                                                                                        let v27645 =
                                                                                                                                            __future_init;
                                                                                                                                        let v27647:
                                                                                                                                                std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                            v27645;
                                                                                                                                        let v27650:
                                                                                                                                                Spiral_wasm::US7 =
                                                                                                                                            Spiral_wasm::method23(v27647.await);
                                                                                                                                        let v27652:
                                                                                                                                                string =
                                                                                                                                            string("true; v27650 });  // rust.fix_closure\'");
                                                                                                                                        let v27653:
                                                                                                                                                bool =
                                                                                                                                            true; v27650 });  // rust.fix_closure';
                                                                                                                                        let v27655 =
                                                                                                                                            __future_init;
                                                                                                                                        v27655
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                            Spiral_wasm::US6::US6_1(v27632_1_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v28707:
                                                                                                                                        () =
                                                                                                                                    {
                                                                                                                                        Spiral_wasm::closure58(v27632_1_0.clone(),
                                                                                                                                                               ());
                                                                                                                                        ()
                                                                                                                                    };
                                                                                                                                let v29691:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v29693:
                                                                                                                                        bool =
                                                                                                                                    true; let __future_init = Box::pin(async move { //;
                                                                                                                                let v29694:
                                                                                                                                        u8 =
                                                                                                                                    Spiral_wasm::method20();
                                                                                                                                let v29698:
                                                                                                                                        string =
                                                                                                                                    string("true; v29694 });  // rust.fix_closure\'");
                                                                                                                                let v29699:
                                                                                                                                        bool =
                                                                                                                                    true; v29694 });  // rust.fix_closure';
                                                                                                                                let v29701 =
                                                                                                                                    __future_init;
                                                                                                                                let v29703:
                                                                                                                                        std::pin::Pin<Box<dyn std::future::Future<Output = u8>>> =
                                                                                                                                    v29701;
                                                                                                                                let v29706:
                                                                                                                                        Spiral_wasm::US7 =
                                                                                                                                    Spiral_wasm::method21(v29703.await);
                                                                                                                                let v29708:
                                                                                                                                        string =
                                                                                                                                    string("true; v29706 });  // rust.fix_closure\'");
                                                                                                                                let v29709:
                                                                                                                                        bool =
                                                                                                                                    true; v29706 });  // rust.fix_closure';
                                                                                                                                let v29711 =
                                                                                                                                    __future_init;
                                                                                                                                v29711
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
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                let v29743: Spiral_wasm::US7 = v29741.await;
                let v29746: () = {
                    Spiral_wasm::closure74(v29743.clone(), ());
                    ()
                };
                let v30539: Result<(), anyhow::Error> = Spiral_wasm::method37(match &v29743 {
                    Spiral_wasm::US7::US7_0(v29743_0_0) => Ok::<(), anyhow::Error>(()),
                    Spiral_wasm::US7::US7_1(v29743_1_0) => {
                        let v30487: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                            l0: MutCell::new(Spiral_wasm::method10()),
                        });
                        let v30494: () = {
                            Spiral_wasm::closure12(
                                v30487.clone(),
                                sprintf!("{}", string("{ ")),
                                (),
                            );
                            ()
                        };
                        let v30503: () = {
                            Spiral_wasm::closure12(
                                v30487.clone(),
                                sprintf!("{}", string("retries")),
                                (),
                            );
                            ()
                        };
                        let v30512: () = {
                            Spiral_wasm::closure12(
                                v30487.clone(),
                                sprintf!("{}", string(" = ")),
                                (),
                            );
                            ()
                        };
                        let v30520: () = {
                            Spiral_wasm::closure12(
                                v30487.clone(),
                                sprintf!("{}", v29743_1_0.clone()),
                                (),
                            );
                            ()
                        };
                        let v30529: () = {
                            Spiral_wasm::closure12(
                                v30487.clone(),
                                sprintf!("{}", string(" }")),
                                (),
                            );
                            ()
                        };
                        let v30532: string = v30487.l0.get().clone();
                        let v30534: anyhow::Error = anyhow::anyhow!(v30532);
                        Err(v30534)
                    }
                });
                let v30543: string = string("true; v30539 });  // rust.fix_closure\'");
                let v30544: bool = true;
                v30539
            }); // rust.fix_closure';
            let v30546 = __future_init;
            v30546
        }
        pub fn closure0(unitVar: (), v0_1: Array<string>) -> i32 {
            let v1: clap::Command = Spiral_wasm::method0();
            let v3: clap::ArgMatches = clap::Command::get_matches(v1);
            let v4: string = Spiral_wasm::method1();
            let v6: &str = &*v4;
            let v8: Option<std::string::String> =
                clap::ArgMatches::get_one(&v3.clone(), v6).cloned();
            let _v9: LrcPtr<MutCell<Option<Spiral_wasm::US0>>> = refCell(None::<Spiral_wasm::US0>);
            let v14: () = {
                Spiral_wasm::closure2(
                    v8,
                    Func1::new({
                        let _v9 = _v9.clone();
                        move |v: Option<Spiral_wasm::US0>| Spiral_wasm::closure1(_v9.clone(), v)
                    }),
                    (),
                );
                ()
            };
            let v29: Spiral_wasm::US0 = defaultValue(Spiral_wasm::US0::US0_1, _v9.get().clone());
            let v85: Spiral_wasm::US1 = match &v29 {
                Spiral_wasm::US0::US0_0(v29_0_0) => {
                    let v35: string = fable_library_rust::String_::fromString(match &v29 {
                        Spiral_wasm::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    });
                    let v40: Spiral_wasm::US2 = if string("Verbose") == v35.clone() {
                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_0)
                    } else {
                        Spiral_wasm::US2::US2_1
                    };
                    Spiral_wasm::US1::US1_0(match &v40 {
                        Spiral_wasm::US2::US2_0(v40_0_0) => Spiral_wasm::US2::US2_0(match &v40 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => {
                            let v47: Spiral_wasm::US2 = if string("Debug") == v35.clone() {
                                Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_1)
                            } else {
                                Spiral_wasm::US2::US2_1
                            };
                            match &v47 {
                                Spiral_wasm::US2::US2_0(v47_0_0) => {
                                    Spiral_wasm::US2::US2_0(match &v47 {
                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v54: Spiral_wasm::US2 = if string("Info") == v35.clone() {
                                        Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_2)
                                    } else {
                                        Spiral_wasm::US2::US2_1
                                    };
                                    match &v54 {
                                        Spiral_wasm::US2::US2_0(v54_0_0) => {
                                            Spiral_wasm::US2::US2_0(match &v54 {
                                                Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v61: Spiral_wasm::US2 =
                                                if string("Warning") == v35.clone() {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US3::US3_3)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                            match &v61 {
                                                Spiral_wasm::US2::US2_0(v61_0_0) => {
                                                    Spiral_wasm::US2::US2_0(match &v61 {
                                                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v68: Spiral_wasm::US2 =
                                                        if string("Critical") == v35.clone() {
                                                            Spiral_wasm::US2::US2_0(
                                                                Spiral_wasm::US3::US3_4,
                                                            )
                                                        } else {
                                                            Spiral_wasm::US2::US2_1
                                                        };
                                                    match &v68 {
                                                        Spiral_wasm::US2::US2_0(v68_0_0) => {
                                                            Spiral_wasm::US2::US2_0(match &v68 {
                                                                Spiral_wasm::US2::US2_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            })
                                                        }
                                                        _ => Spiral_wasm::US2::US2_1,
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    })
                }
                _ => Spiral_wasm::US1::US1_1,
            };
            let v92: Spiral_wasm::US2 = if let Spiral_wasm::US1::US1_0(v85_0_0) = &v85 {
                let v86: Spiral_wasm::US2 = match &v85 {
                    Spiral_wasm::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                };
                if let Spiral_wasm::US2::US2_0(v86_0_0) = &v86 {
                    Spiral_wasm::US2::US2_0(match &v86 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    })
                } else {
                    Spiral_wasm::US2::US2_1
                }
            } else {
                Spiral_wasm::US2::US2_1
            };
            let v99: () = {
                Spiral_wasm::closure3(
                    match &v92 {
                        Spiral_wasm::US2::US2_0(v92_0_0) => match &v92 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => Spiral_wasm::US3::US3_0,
                    },
                    (),
                );
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
            let v127: () = {
                Spiral_wasm::closure7(v0_1, ());
                ()
            };
            let v864: std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<(), anyhow::Error>>>,
            > = Spiral_wasm::method11(v3);
            let v866 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v868: Result<(), anyhow::Error> = v866.handle().block_on(v864);
            v868.unwrap();
            0_i32
        }
        pub fn v0() -> Func1<Array<string>, i32> {
            static v0: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v0.get_or_init(|| Func1::new(move |v: Array<string>| Spiral_wasm::closure0((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Spiral_wasm::v0())(args)
        }
    }
}
pub use module_fb49c4a9::*;
#[path = "../../../lib/fsharp/Common.rs"]
mod module_ad43931;
pub use module_ad43931::*;
#[path = "../../../lib/spiral/async_.rs"]
mod module_67c461a2;
pub use module_67c461a2::*;
#[path = "../../../lib/spiral/common.rs"]
mod module_181b15d6;
pub use module_181b15d6::*;
#[path = "../../../lib/spiral/crypto.rs"]
mod module_90d9c778;
pub use module_90d9c778::*;
#[path = "../../../lib/spiral/date_time.rs"]
mod module_e43a8385;
pub use module_e43a8385::*;
#[path = "../../../lib/spiral/file_system.rs"]
mod module_a7db9b47;
pub use module_a7db9b47::*;
#[path = "../../../lib/spiral/lib.rs"]
mod module_98e448fc;
pub use module_98e448fc::*;
#[path = "../../../lib/spiral/networking.rs"]
mod module_268024e5;
pub use module_268024e5::*;
#[path = "../../../lib/spiral/platform.rs"]
mod module_7d8ad484;
pub use module_7d8ad484::*;
#[path = "../../../lib/spiral/runtime.rs"]
mod module_485aae07;
pub use module_485aae07::*;
#[path = "../../../lib/spiral/sm.rs"]
mod module_582b4305;
pub use module_582b4305::*;
#[path = "../../../lib/spiral/threading.rs"]
mod module_d5afb6f5;
pub use module_d5afb6f5::*;
#[path = "../../../lib/spiral/trace.rs"]
mod module_9e77af3a;
pub use module_9e77af3a::*;
pub mod Polyglot {
    pub use crate::module_ad43931::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Spiral_wasm::main(array_from(args));
}
