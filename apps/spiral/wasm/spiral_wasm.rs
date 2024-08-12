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
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::padLeft;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::sprintf;
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for Spiral_wasm::US0 {
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
            pub l0: MutCell<Spiral_wasm::US0>,
        }
        impl core::fmt::Display for Spiral_wasm::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(string),
            US1_1,
        }
        impl core::fmt::Display for Spiral_wasm::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Spiral_wasm::US0),
            US2_1,
        }
        impl core::fmt::Display for Spiral_wasm::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(i64),
            US3_1,
        }
        impl core::fmt::Display for Spiral_wasm::US3 {
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
        pub enum US4 {
            US4_0(std::string::String),
            US4_1,
        }
        impl core::fmt::Display for Spiral_wasm::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        fn print_usd(result: near_workspaces::result::ExecutionFinalResult) {
            //;
            const NEAR_PRICE_IN_USD: f64 = 6.68; //;
            fn gas_to_usd(gas: u64) -> f64 {
                //;
                (gas as f64) / 1e16 * NEAR_PRICE_IN_USD //;
            } //;
            fn tokens_to_usd(tokens: u128) -> f64 {
                //;
                (tokens as f64) / 1e24 * NEAR_PRICE_IN_USD //;
            } //;
            println!(
                "gas_to_usd(result.total_gas_burnt.as_gas()): {:.6} ({:#?})", //;
                gas_to_usd(result.total_gas_burnt.as_gas()),                  //;
                result.total_gas_burnt.as_gas()                               //;
            ); //;
            result.outcomes().iter().for_each(|outcome| {
                //;
                println!("outcome (success: {:#?}):", outcome.is_success()); //;
                println!(
                    //;
                    "  gas_to_usd(outcome.gas_burnt.as_gas()): {:.6} ({:#?})", //;
                    gas_to_usd(outcome.gas_burnt.as_gas()),                    //;
                    outcome.gas_burnt.as_gas()                                 //;
                ); //;
                println!(
                    //;
                    "  tokens_to_usd(outcome.tokens_burnt.as_yoctonear()): {:.6} ({:#?})", //;
                    tokens_to_usd(outcome.tokens_burnt.as_yoctonear()),                    //;
                    outcome.tokens_burnt.as_yoctonear()                                    //;
                ); //;
            }); //;
        } //;
        fn _main() {
            //;
            ()
        }
        pub fn method1() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method3() -> string {
            string("")
        }
        pub fn closure3(
            v0_1: LrcPtr<MutCell<Option<Spiral_wasm::US1>>>,
            v1_1: Option<Spiral_wasm::US1>,
        ) -> LrcPtr<MutCell<Option<Spiral_wasm::US1>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure4(
            v0_1: Option<string>,
            v1_1: Func1<Option<Spiral_wasm::US1>, LrcPtr<MutCell<Option<Spiral_wasm::US1>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Spiral_wasm::US1>>> = v1_1(match &v0_1 {
                    None => None::<Spiral_wasm::US1>,
                    Some(v0_1_0_0) => {
                        let x: string = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Spiral_wasm::US1::US1_0(x.clone())
                        }))())
                    }
                });
                ()
            }
            ()
        }
        pub fn method2(v0_1: string) -> string {
            let v3: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v5: bool = true;
            let _result = v3.map(|x| {
                //;
                let v7: std::string::String = x;
                let v9: string = fable_library_rust::String_::fromString(v7);
                let v11: bool = true;
                v9
            });
            let v13: Result<string, std::env::VarError> = _result;
            let v14: string = Spiral_wasm::method3();
            v13.unwrap_or(v14)
        }
        pub fn method4() -> string {
            string("AUTOMATION")
        }
        pub fn closure5(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method0(
            v0_1: Spiral_wasm::US0,
        ) -> (
            LrcPtr<Spiral_wasm::Mut0>,
            LrcPtr<Spiral_wasm::Mut1>,
            LrcPtr<Spiral_wasm::Mut2>,
            LrcPtr<Spiral_wasm::Mut3>,
            Option<i64>,
        ) {
            let v3: string = Spiral_wasm::method2(Spiral_wasm::method1());
            let v8: Spiral_wasm::US2 = if string("Verbose") == v3.clone() {
                Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_0)
            } else {
                Spiral_wasm::US2::US2_1
            };
            let _v1: (Spiral_wasm::US2, Spiral_wasm::US3) = (
                match &v8 {
                    Spiral_wasm::US2::US2_0(v8_0_0) => Spiral_wasm::US2::US2_0(match &v8 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v15: Spiral_wasm::US2 = if string("Debug") == v3.clone() {
                            Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_1)
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
                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_2)
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
                                                Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_3)
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
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_4)
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
                if Spiral_wasm::method2(Spiral_wasm::method4()) == string("True") {
                    Spiral_wasm::US3::US3_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Spiral_wasm::US3::US3_1
                },
            );
            let v295: Spiral_wasm::US3 = _v1.1.clone();
            let v294: Spiral_wasm::US2 = _v1.0.clone();
            (
                LrcPtr::new(Spiral_wasm::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Spiral_wasm::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Spiral_wasm::closure5((), v))),
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
                    Spiral_wasm::US3::US3_0(v295_0_0) => Some(match &v295 {
                        Spiral_wasm::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) {
            if Spiral_wasm::State::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
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
        pub fn closure7(v0_1: LrcPtr<Spiral_wasm::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure8(
            v0_1: LrcPtr<MutCell<Option<Spiral_wasm::US3>>>,
            v1_1: Option<Spiral_wasm::US3>,
        ) -> LrcPtr<MutCell<Option<Spiral_wasm::US3>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure9(
            v0_1: Option<i64>,
            v1_1: Func1<Option<Spiral_wasm::US3>, LrcPtr<MutCell<Option<Spiral_wasm::US3>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> = v1_1(match &v0_1 {
                    None => None::<Spiral_wasm::US3>,
                    Some(v0_1_0_0) => {
                        let x: i64 = v0_1_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Spiral_wasm::US3::US3_0(x)
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
        pub fn closure10(v0_1: LrcPtr<Spiral_wasm::Mut4>, v1_1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn closure11(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.main")
        }
        pub fn closure13(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure12(unitVar: (), v0_1: string) {
            let v3: () = {
                Spiral_wasm::closure13(v0_1, ());
                ()
            };
            ()
        }
        pub fn closure6(v0_1: Array<string>, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("args")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v662: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", sprintf!("{:?}", v0_1)),
                        (),
                    );
                    ()
                };
                let v671: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
                            Spiral_wasm::closure11((), ()),
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
        pub fn method9() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"wasm\"#");
            let v7: &'static str = r#"wasm"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.short('w');
            let v12: string = string("r#\"wasm\"#");
            let v13: &'static str = r#"wasm"#;
            let v15: clap::Arg = v11.long(v13);
            let v17: clap::Arg = v15.required(true);
            clap::Command::arg(v4, v17)
        }
        pub fn method11() -> string {
            string("wasm")
        }
        pub fn closure14(
            v0_1: LrcPtr<MutCell<Option<Spiral_wasm::US4>>>,
            v1_1: Option<Spiral_wasm::US4>,
        ) -> LrcPtr<MutCell<Option<Spiral_wasm::US4>>> {
            v0_1.set(v1_1);
            v0_1
        }
        pub fn closure15(
            v0_1: Option<std::string::String>,
            v1_1: Func1<Option<Spiral_wasm::US4>, LrcPtr<MutCell<Option<Spiral_wasm::US4>>>>,
            unitVar: (),
        ) {
            {
                let value: LrcPtr<MutCell<Option<Spiral_wasm::US4>>> = v1_1(match &v0_1 {
                    None => None::<Spiral_wasm::US4>,
                    Some(v0_1_0_0) => {
                        let x: std::string::String = v0_1_0_0.clone();
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
        pub fn closure17(unitVar: (), unitVar_1: ()) -> string {
            string("run")
        }
        pub fn closure16(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("wasm_path")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v659: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", v0_1), ());
                    ()
                };
                let v668: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
            string("")
        }
        pub fn closure18(
            v0_1: near_workspaces::Worker<near_workspaces::network::Sandbox>,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("worker")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
            string("")
        }
        pub fn closure20(v0_1: near_workspaces::Contract, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("contract")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
            string("")
        }
        pub fn closure22(v0_1: near_workspaces::result::ExecutionFinalResult, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("result")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
        pub fn closure27(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure26(
            v0_1: Result<
                near_workspaces::result::ExecutionResult<near_workspaces::result::Value>,
                near_workspaces::result::ExecutionResult<near_primitives::errors::TxExecutionError>,
            >,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("result2")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
                            Spiral_wasm::closure27((), ()),
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
        pub fn method12(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure28(v0_1: Vec<&near_workspaces::result::ExecutionOutcome>, unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", string("receipt_failures")),
                        (),
                    );
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
                            Spiral_wasm::closure29((), ()),
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
        pub fn method13(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure30(v0_1: &[near_workspaces::result::ExecutionOutcome], unitVar: ()) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", string("receipt_outcomes")),
                        (),
                    );
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
                            Spiral_wasm::closure31((), ()),
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
        pub fn closure33(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure32(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("json")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
                            Spiral_wasm::closure33((), ()),
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
        pub fn closure35(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure34(
            v0_1: Result<std::string::String, near_workspaces::error::Error>,
            unitVar: (),
        ) {
            fn v2() {
                Spiral_wasm::closure2((), ());
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
            let v60: Spiral_wasm::US0 = (patternInput_1.3.clone()).l0.get().clone();
            if if (patternInput_1.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v60,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v68: () = {
                    Spiral_wasm::closure7(patternInput.0.clone(), ());
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
                let _v101: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                    refCell(None::<Spiral_wasm::US3>);
                let v106: () = {
                    Spiral_wasm::closure9(
                        patternInput_2.4.clone(),
                        Func1::new({
                            let _v101 = _v101.clone();
                            move |v: Option<Spiral_wasm::US3>| {
                                Spiral_wasm::closure8(_v101.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v121: Spiral_wasm::US3 =
                    defaultValue(Spiral_wasm::US3::US3_1, _v101.get().clone());
                let v161: DateTime = match &v121 {
                    Spiral_wasm::US3::US3_0(v121_0_0) => {
                        let v135: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v121 {
                                Spiral_wasm::US3::US3_0(x) => x.clone(),
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
                    let provider: string = Spiral_wasm::method5();
                    v161.toString(provider)
                };
                let v558: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
                let v574: &str = inline_colorization::color_bright_blue;
                let v576: &str = &*v558;
                let v578: &str = inline_colorization::color_reset;
                let v580: string = string("format!(\"{v574}{v576}{v578}\")");
                let v581: std::string::String = format!("{v574}{v576}{v578}");
                let v583: string = fable_library_rust::String_::fromString(v581);
                let v624: i64 = (patternInput_2.0.clone()).l0.get().clone();
                let v626: LrcPtr<Spiral_wasm::Mut4> = LrcPtr::new(Spiral_wasm::Mut4 {
                    l0: MutCell::new(Spiral_wasm::method8()),
                });
                let v633: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("{ ")), ());
                    ()
                };
                let v642: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string("borsh")), ());
                    ()
                };
                let v651: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" = ")), ());
                    ()
                };
                let v656: std::string::String = format!("{:#?}", v0_1);
                let v686: () = {
                    Spiral_wasm::closure10(
                        v626.clone(),
                        sprintf!("{}", fable_library_rust::String_::fromString(v656)),
                        (),
                    );
                    ()
                };
                let v695: () = {
                    Spiral_wasm::closure10(v626.clone(), sprintf!("{}", string(" }")), ());
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
                            Spiral_wasm::closure35((), ()),
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
        pub fn method14(v0_1: Result<(), anyhow::Error>) -> Result<(), anyhow::Error> {
            v0_1
        }
        pub fn method10(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), anyhow::Error>>>>
        {
            let v2: bool = true;
            let __result = Box::pin(async move {
                //;
                let v3: string = Spiral_wasm::method11();
                let v5: &str = &*v3;
                let v7: Option<std::string::String> = clap::ArgMatches::get_one(&v0_1, v5).cloned();
                let _v8: LrcPtr<MutCell<Option<Spiral_wasm::US4>>> =
                    refCell(None::<Spiral_wasm::US4>);
                let v13: () = {
                    Spiral_wasm::closure15(
                        v7,
                        Func1::new({
                            let _v8 = _v8.clone();
                            move |v: Option<Spiral_wasm::US4>| {
                                Spiral_wasm::closure14(_v8.clone(), v)
                            }
                        }),
                        (),
                    );
                    ()
                };
                let v28: Spiral_wasm::US4 =
                    defaultValue(Spiral_wasm::US4::US4_1, _v8.get().clone());
                let v35: std::string::String = match &v28 {
                    Spiral_wasm::US4::US4_0(v28_0_0) => match &v28 {
                        Spiral_wasm::US4::US4_0(x) => x.clone(),
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
                let _result: Vec<_> = v3087
                    .into_iter()
                    .map(|x| {
                        //;
                        let v3091: &str = x;
                        let v3093: std::string::String = String::from(v3091);
                        let v3095: bool = true;
                        v3093
                    })
                    .collect::<Vec<_>>();
                let v3097: Vec<std::string::String> = _result;
                let v3100: bool = true;
                v3097.iter().for_each(|x| {
                    Func1::new(move |v_1: std::string::String| Spiral_wasm::closure24((), v_1))(
                        x.clone(),
                    );
                }); //;
                let v3102: bool = true;
                println!("\n\n state_main transact result: {:#?}", v2322.clone()); //;
                let v3104: bool = true;
                println!("\n\n print_usd:"); //;
                let v3106: bool = true;
                print_usd(v2322.clone()); //;
                let v3111: () = {
                    Spiral_wasm::closure26(v2322.clone().into_result(), ());
                    ()
                };
                let v3872: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method12(v2322.clone());
                let v3874: Vec<&near_workspaces::result::ExecutionOutcome> =
                    v3872.receipt_failures();
                let v3877: () = {
                    Spiral_wasm::closure28(v3874.clone(), ());
                    ()
                };
                let v4638: near_workspaces::result::ExecutionFinalResult =
                    Spiral_wasm::method13(v2322.clone());
                let v4643: () = {
                    Spiral_wasm::closure30(v4638.receipt_outcomes(), ());
                    ()
                };
                let v5408: () = {
                    Spiral_wasm::closure32(v2322.clone().json(), ());
                    ()
                };
                let v6173: () = {
                    Spiral_wasm::closure34(v2322.borsh(), ());
                    ()
                };
                let v6935: bool = true;
                println!("\n\n worker: {:#?}", v781); //;
                let v6937: bool = true;
                println!("\n\n contract: {:#?}", v1550); //;
                let v6950: Result<(), anyhow::Error> =
                    Spiral_wasm::method14(if v3874.len() as i32 == 0_i32 {
                        Ok::<(), anyhow::Error>(())
                    } else {
                        let v6946: anyhow::Error = anyhow::anyhow!(string("<error>"));
                        Err(v6946)
                    });
                let v6954: string = string("true; v6950 });  // rust.fix_closure\'");
                let v6955: bool = true;
                v6950
            }); // rust.fix_closure';
            let v6957 = __result;
            v6957
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Spiral_wasm::closure2((), ());
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
                Spiral_wasm::closure6(v0_1, ());
                ()
            };
            let v769: clap::Command = Spiral_wasm::method9();
            let v772: std::pin::Pin<
                Box<dyn std::future::Future<Output = Result<(), anyhow::Error>>>,
            > = Spiral_wasm::method10(clap::Command::get_matches(v769));
            let v774 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v776: Result<(), anyhow::Error> = v774.handle().block_on(v772);
            v776.unwrap();
            0_i32
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Spiral_wasm::closure0((), ())))
                .clone()
        }
        on_startup!(());
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Spiral_wasm::closure1((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Spiral_wasm::v1())(args)
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
