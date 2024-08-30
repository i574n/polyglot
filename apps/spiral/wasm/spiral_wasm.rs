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
            v0_1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
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
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("worker")), ());
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
                            Spiral_wasm::closure19((), ()),
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
        pub fn closure21(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure20(v0_1: near_workspaces::Contract, unitVar: ()) {
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
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("contract")), ());
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
                            Spiral_wasm::closure21((), ()),
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
        pub fn closure23(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure22(v0_1: near_workspaces::result::ExecutionFinalResult, unitVar: ()) {
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
                    Spiral_wasm::closure12(v626.clone(), sprintf!("{}", string("result")), ());
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
                            Spiral_wasm::closure23((), ()),
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
        pub fn method13() -> string {
            string("(")
        }
        pub fn method14() -> string {
            string(" ")
        }
        pub fn closure27(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.print_usd")
        }
        pub fn closure26(v0_1: u64, v1: f64, unitVar: ()) {
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
                1_i32
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
                let v555: string = Spiral_wasm::method13();
                let v567: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v578: () = {
                    Spiral_wasm::closure12(
                        v567.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_0)),
                        (),
                    );
                    ()
                };
                let v582: Array<string> = split(v567.l0.get().clone(), v555, -1_i32, 0_i32);
                let v585: string = v582[0_i32].clone();
                let v589: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v600: () = {
                    Spiral_wasm::closure12(
                        v589.clone(),
                        sprintf!("{}", sprintf!("{:?}", Spiral_wasm::US3::US3_1)),
                        (),
                    );
                    ()
                };
                let v610: Spiral_wasm::US4 = if startsWith(v589.l0.get().clone(), v585, false) {
                    Spiral_wasm::US4::US4_0(string("Verbose"))
                } else {
                    Spiral_wasm::US4::US4_1
                };
                let v616: Spiral_wasm::US4 = match &v610 {
                    Spiral_wasm::US4::US4_0(v610_0_0) => Spiral_wasm::US4::US4_0(match &v610 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => Spiral_wasm::US4::US4_0(string("Debug")),
                };
                let v625: string = padLeft(
                    toLower(match &v616 {
                        Spiral_wasm::US4::US4_0(v616_0_0) => match &v616 {
                            Spiral_wasm::US4::US4_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    }),
                    7_i32,
                    ' ',
                );
                let v641: &str = inline_colorization::color_bright_blue;
                let v643: &str = &*v625;
                let v645: &str = inline_colorization::color_reset;
                let v647: string = string("format!(\"{v641}{v643}{v645}\")");
                let v648: std::string::String = format!("{v641}{v643}{v645}");
                let v650: string = fable_library_rust::String_::fromString(v648);
                let v691: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v693: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method10()),
                });
                let v700: () = {
                    Spiral_wasm::closure12(v693.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v709: () = {
                    Spiral_wasm::closure12(
                        v693.clone(),
                        sprintf!("{}", string("total_gas_burnt_usd")),
                        (),
                    );
                    ()
                };
                let v718: () = {
                    Spiral_wasm::closure12(v693.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v726: () = {
                    Spiral_wasm::closure12(v693.clone(), sprintf!("{:+.6}", v1), ());
                    ()
                };
                let v735: () = {
                    Spiral_wasm::closure12(v693.clone(), sprintf!("{}", string("; ")), ());
                    ()
                };
                let v744: () = {
                    Spiral_wasm::closure12(
                        v693.clone(),
                        sprintf!("{}", string("total_gas_burnt")),
                        (),
                    );
                    ()
                };
                let v752: () = {
                    Spiral_wasm::closure12(v693.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v760: () = {
                    Spiral_wasm::closure12(v693.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v769: () = {
                    Spiral_wasm::closure12(v693.clone(), sprintf!("{}", string(" }")), ());
                    ()
                };
                let v772: string = v693.l0.get().clone();
                let v811: string = trimEndChars(
                    trimStartChars(
                        sprintf!(
                            "{} {} #{} {} / {}",
                            v167,
                            v650,
                            v691,
                            Spiral_wasm::closure27((), ()),
                            v772
                        ),
                        toArray(empty::<char>()),
                    ),
                    toArray(ofArray(new_array(&[' ', '/']))),
                );
                println!("{}", v811.clone());
                ();
                ((patternInput.1.clone()).l0.get().clone())(v811)
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
                let v558: string = Spiral_wasm::method13();
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
        pub fn method15(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure34(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure33(v0_1: Vec<&near_workspaces::result::ExecutionOutcome>, unitVar: ()) {
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
                    Spiral_wasm::closure12(
                        v626.clone(),
                        sprintf!("{}", string("receipt_failures")),
                        (),
                    );
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
                            Spiral_wasm::closure34((), ()),
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
        pub fn closure36(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.run")
        }
        pub fn closure35(v0_1: &[near_workspaces::result::ExecutionOutcome], unitVar: ()) {
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
                    Spiral_wasm::closure12(
                        v626.clone(),
                        sprintf!("{}", string("receipt_outcomes")),
                        (),
                    );
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
                            Spiral_wasm::closure36((), ()),
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
        pub fn method17(v0_1: Result<(), anyhow::Error>) -> Result<(), anyhow::Error> {
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
                let v779: Result<
                    near_workspaces::Worker<near_workspaces::network::Sandbox>,
                    near_workspaces::error::Error,
                > = near_workspaces::sandbox().await;
                let v781: near_workspaces::Worker<near_workspaces::network::Sandbox> = v779?;
                let v784: () = {
                    Spiral_wasm::closure18(v781.clone(), ());
                    ()
                };
                let v1546: std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<
                                near_workspaces::Contract,
                                near_workspaces::error::Error,
                            >,
                        >,
                    >,
                > = Box::pin(v781.dev_deploy(&v777));
                let v1548: Result<near_workspaces::Contract, near_workspaces::error::Error> =
                    v1546.await;
                let v1550: near_workspaces::Contract = v1548?;
                let v1553: () = {
                    Spiral_wasm::closure20(v1550.clone(), ());
                    ()
                };
                let v2316: near_workspaces::operations::CallTransaction =
                    v1550.call(&*string("state_main"));
                let v2318: std::pin::Pin<
                    Box<
                        dyn std::future::Future<
                            Output = Result<
                                near_workspaces::result::ExecutionFinalResult,
                                near_workspaces::error::Error,
                            >,
                        >,
                    >,
                > = Box::pin(v2316.transact());
                let v2320: Result<
                    near_workspaces::result::ExecutionFinalResult,
                    near_workspaces::error::Error,
                > = v2318.await;
                let v2322: near_workspaces::result::ExecutionFinalResult = v2320?;
                let v2325: () = {
                    Spiral_wasm::closure22(v2322.clone(), ());
                    ()
                };
                let v3087: Vec<&str> = v2322.logs();
                let v3089: bool = true;
                let _vec_map: Vec<_> = v3087
                    .into_iter()
                    .map(|x| {
                        //;
                        let v3091: &str = x;
                        let v3093: std::string::String = String::from(v3091);
                        let v3095: bool = true;
                        v3093
                    })
                    .collect::<Vec<_>>();
                let v3097: Vec<std::string::String> = _vec_map;
                let v3100: bool = true;
                v3097.iter().for_each(|x| {
                    Func1::new(move |v_1: std::string::String| Spiral_wasm::closure24((), v_1))(
                        x.clone(),
                    );
                }); //;
                let v3102: near_workspaces::types::Gas = v2322.clone().total_gas_burnt;
                let v3104: u64 = v3102.as_gas();
                let v3111: () = {
                    Spiral_wasm::closure26(
                        v3104,
                        v3104 as f64 / 10000000000000000.0_f64 * 6.68_f64,
                        (),
                    );
                    ()
                };
                let v3946: near_workspaces::result::ExecutionFinalResult = v2322.clone();
                let v3948: Vec<&near_workspaces::result::ExecutionOutcome> = v3946.outcomes();
                let v3950 = v3948.into_iter();
                let v3952 = v3950.cloned();
                let v3955: bool = true;
                v3952.for_each(|x| {
                    Func1::new(move |v_2: near_workspaces::result::ExecutionOutcome| {
                        Spiral_wasm::closure28((), v_2)
                    })(x)
                });
                let v3960: () = {
                    Spiral_wasm::closure31(v2322.clone().into_result(), ());
                    ()
                };
                let v4721: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method15(v2322.clone());
                let v4723: Vec<&near_workspaces::result::ExecutionOutcome> =
                    v4721.receipt_failures();
                let v4726: () = {
                    Spiral_wasm::closure33(v4723.clone(), ());
                    ()
                };
                let v5487: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method16(v2322.clone());
                let v5492: () = {
                    Spiral_wasm::closure35(v5487.receipt_outcomes(), ());
                    ()
                };
                let v6257: () = {
                    Spiral_wasm::closure37(v2322.clone().json(), ());
                    ()
                };
                let v7022: () = {
                    Spiral_wasm::closure39(v2322.borsh(), ());
                    ()
                };
                let v7795: Result<(), anyhow::Error> =
                    Spiral_wasm::method17(if v4723.len() as i32 == 0_i32 {
                        Ok::<(), anyhow::Error>(())
                    } else {
                        let v7791: anyhow::Error = anyhow::anyhow!(string("<error>"));
                        Err(v7791)
                    });
                let v7799: string = string("true; v7795 });  // rust.fix_closure\'");
                let v7800: bool = true;
                v7795
            }); // rust.fix_closure';
            let v7802 = __future_init;
            v7802
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
