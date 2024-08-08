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
        pub fn closure2(unitVar: (), v0_1: string) {
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
                    l0: MutCell::new(Func1::new(move |v: string| Spiral_wasm::closure2((), v))),
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
        pub fn closure3(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.main")
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
        pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
            string("run")
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure7(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure8(unitVar: (), v0_1: std::string::String) {
            printfn!("{0}", v0_1);
            ()
        }
        pub fn closure9(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method12(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method13(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure11(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure13(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method14(v0_1: Result<(), anyhow::Error>) -> Result<(), anyhow::Error> {
            v0_1
        }
        pub fn method10(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), anyhow::Error>>>>
        {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: string = Spiral_wasm::method11();
                    let v4: &str = &*v2;
                    let v6: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v0_1, v4).cloned();
                    let _v7: LrcPtr<MutCell<Option<Spiral_wasm::US4>>> =
                        refCell(None::<Spiral_wasm::US4>);
                    {
                        let x_2: Option<Spiral_wasm::US4> = match &v6 {
                            None => None::<Spiral_wasm::US4>,
                            Some(v6_0_0) => {
                                let x: std::string::String = v6_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Spiral_wasm::US4::US4_0(x.clone())
                                }))())
                            }
                        };
                        _v7.set(x_2)
                    }
                    {
                        let v22: Spiral_wasm::US4 =
                            defaultValue(Spiral_wasm::US4::US4_1, _v7.get().clone());
                        let v29: std::string::String = match &v22 {
                            Spiral_wasm::US4::US4_0(v22_0_0) => match &v22 {
                                Spiral_wasm::US4::US4_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v31: string = fable_library_rust::String_::fromString(v29);
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
                        }
                        {
                            let patternInput_1: (
                                LrcPtr<Spiral_wasm::Mut0>,
                                LrcPtr<Spiral_wasm::Mut1>,
                                LrcPtr<Spiral_wasm::Mut2>,
                                LrcPtr<Spiral_wasm::Mut3>,
                                Option<i64>,
                            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                            let v44: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                            if Spiral_wasm::State::trace_state().get().clone().is_none() {
                                let patternInput_2: (
                                    LrcPtr<Spiral_wasm::Mut0>,
                                    LrcPtr<Spiral_wasm::Mut1>,
                                    LrcPtr<Spiral_wasm::Mut2>,
                                    LrcPtr<Spiral_wasm::Mut3>,
                                    Option<i64>,
                                ) = Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                Spiral_wasm::State::trace_state().set(Some((
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone(),
                                    patternInput_2.2.clone(),
                                    patternInput_2.3.clone(),
                                    patternInput_2.4.clone(),
                                )));
                                ()
                            }
                            {
                                let patternInput_3: (
                                    LrcPtr<Spiral_wasm::Mut0>,
                                    LrcPtr<Spiral_wasm::Mut1>,
                                    LrcPtr<Spiral_wasm::Mut2>,
                                    LrcPtr<Spiral_wasm::Mut3>,
                                    Option<i64>,
                                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                                let v86: Spiral_wasm::US0 =
                                    (patternInput_3.3.clone()).l0.get().clone();
                                if if (patternInput_3.2.clone()).l0.get().clone() == false {
                                    false
                                } else {
                                    1_i32
                                        >= find(
                                            v86,
                                            ofSeq(ofList(ofArray(new_array(&[
                                                LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                                                LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                                                LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                                                LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                                                LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                                            ])))),
                                        )
                                } {
                                    let v93: i64 = v44.l0.get().clone() + 1_i64;
                                    v44.l0.set(v93);
                                    if Spiral_wasm::State::trace_state().get().clone().is_none() {
                                        let patternInput_4: (
                                            LrcPtr<Spiral_wasm::Mut0>,
                                            LrcPtr<Spiral_wasm::Mut1>,
                                            LrcPtr<Spiral_wasm::Mut2>,
                                            LrcPtr<Spiral_wasm::Mut3>,
                                            Option<i64>,
                                        ) = Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                        Spiral_wasm::State::trace_state().set(Some((
                                            patternInput_4.0.clone(),
                                            patternInput_4.1.clone(),
                                            patternInput_4.2.clone(),
                                            patternInput_4.3.clone(),
                                            patternInput_4.4.clone(),
                                        )));
                                        ()
                                    }
                                    {
                                        let patternInput_5: (
                                            LrcPtr<Spiral_wasm::Mut0>,
                                            LrcPtr<Spiral_wasm::Mut1>,
                                            LrcPtr<Spiral_wasm::Mut2>,
                                            LrcPtr<Spiral_wasm::Mut3>,
                                            Option<i64>,
                                        ) = getValue(
                                            Spiral_wasm::State::trace_state().get().clone(),
                                        );
                                        let v110: Option<i64> = patternInput_5.4.clone();
                                        let _v122: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                            refCell(None::<Spiral_wasm::US3>);
                                        {
                                            let x_5: Option<Spiral_wasm::US3> = match &v110 {
                                                None => None::<Spiral_wasm::US3>,
                                                Some(v110_0_0) => {
                                                    let x_3: i64 = v110_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_3 = x_3.clone();
                                                        move || Spiral_wasm::US3::US3_0(x_3)
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v122.set(x_5)
                                        }
                                        {
                                            let v137: Spiral_wasm::US3 = defaultValue(
                                                Spiral_wasm::US3::US3_1,
                                                _v122.get().clone(),
                                            );
                                            let v177: DateTime = match &v137 {
                                                Spiral_wasm::US3::US3_0(v137_0_0) => {
                                                    let v151: TimeSpan = TimeSpan::new_ticks(
                                                        {
                                                            let _arg: DateTime = DateTime::now();
                                                            _arg.ticks()
                                                        } - match &v137 {
                                                            Spiral_wasm::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                    );
                                                    DateTime::new_ymdhms_milli(
                                                        1_i32,
                                                        1_i32,
                                                        1_i32,
                                                        v151.hours(),
                                                        v151.minutes(),
                                                        v151.seconds(),
                                                        v151.milliseconds(),
                                                    )
                                                }
                                                _ => DateTime::now(),
                                            };
                                            let v182: string = {
                                                let provider: string = Spiral_wasm::method5();
                                                v177.toString(provider)
                                            };
                                            let v544: string =
                                                padLeft(toLower(string("Debug")), 7_i32, ' ');
                                            let v560: &str = inline_colorization::color_bright_blue;
                                            let v562: &str = &*v544;
                                            let v564: &str = inline_colorization::color_reset;
                                            let v566: string =
                                                string("format!(\"{v560}{v562}{v564}\")");
                                            let v567: std::string::String =
                                                format!("{v560}{v562}{v564}");
                                            let v569: string =
                                                fable_library_rust::String_::fromString(v567);
                                            let v610: i64 =
                                                (patternInput_5.0.clone()).l0.get().clone();
                                            let v612: LrcPtr<Spiral_wasm::Mut4> =
                                                LrcPtr::new(Spiral_wasm::Mut4 {
                                                    l0: MutCell::new(Spiral_wasm::method8()),
                                                });
                                            let v614: string = sprintf!("{}", string("{ "));
                                            let v618: string = append(v612.l0.get().clone(), v614);
                                            v612.l0.set(v618);
                                            {
                                                let v620: string =
                                                    sprintf!("{}", string("wasm_path"));
                                                let v624: string =
                                                    append(v612.l0.get().clone(), v620);
                                                v612.l0.set(v624);
                                                {
                                                    let v626: string =
                                                        sprintf!("{}", string(" = "));
                                                    let v630: string =
                                                        append(v612.l0.get().clone(), v626);
                                                    v612.l0.set(v630);
                                                    {
                                                        let v631: string =
                                                            sprintf!("{}", v31.clone());
                                                        let v635: string =
                                                            append(v612.l0.get().clone(), v631);
                                                        v612.l0.set(v635);
                                                        {
                                                            let v637: string =
                                                                sprintf!("{}", string(" }"));
                                                            let v641: string =
                                                                append(v612.l0.get().clone(), v637);
                                                            v612.l0.set(v641);
                                                            {
                                                                let v642: string =
                                                                    v612.l0.get().clone();
                                                                let v681: string = trimEndChars(
                                                                    trimStartChars(
                                                                        sprintf!(
                                                                            "{} {} #{} {} / {}",
                                                                            v182,
                                                                            v569,
                                                                            v610,
                                                                            Spiral_wasm::closure4(
                                                                                (),
                                                                                ()
                                                                            ),
                                                                            v642
                                                                        ),
                                                                        toArray(empty::<char>()),
                                                                    ),
                                                                    toArray(ofArray(new_array(&[
                                                                        ' ', '/',
                                                                    ]))),
                                                                );
                                                                println!("{}", v681.clone());
                                                                ();
                                                                ((patternInput_1.1.clone())
                                                                    .l0
                                                                    .get()
                                                                    .clone())(
                                                                    v681
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                {
                                    let v705: Result<Vec<u8>, std::io::Error> =
                                        std::fs::read(&*v31);
                                    let v707: Vec<u8> = v705?;
                                    let v709: Result<
                                        near_workspaces::Worker<near_workspaces::network::Sandbox>,
                                        near_workspaces::error::Error,
                                    > = near_workspaces::sandbox().await;
                                    let v711: near_workspaces::Worker<
                                        near_workspaces::network::Sandbox,
                                    > = v709?;
                                    if Spiral_wasm::State::trace_state().get().clone().is_none() {
                                        let patternInput_6: (
                                            LrcPtr<Spiral_wasm::Mut0>,
                                            LrcPtr<Spiral_wasm::Mut1>,
                                            LrcPtr<Spiral_wasm::Mut2>,
                                            LrcPtr<Spiral_wasm::Mut3>,
                                            Option<i64>,
                                        ) = Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                        Spiral_wasm::State::trace_state().set(Some((
                                            patternInput_6.0.clone(),
                                            patternInput_6.1.clone(),
                                            patternInput_6.2.clone(),
                                            patternInput_6.3.clone(),
                                            patternInput_6.4.clone(),
                                        )));
                                        ()
                                    }
                                    {
                                        let patternInput_7: (
                                            LrcPtr<Spiral_wasm::Mut0>,
                                            LrcPtr<Spiral_wasm::Mut1>,
                                            LrcPtr<Spiral_wasm::Mut2>,
                                            LrcPtr<Spiral_wasm::Mut3>,
                                            Option<i64>,
                                        ) = getValue(
                                            Spiral_wasm::State::trace_state().get().clone(),
                                        );
                                        let v724: LrcPtr<Spiral_wasm::Mut0> =
                                            patternInput_7.0.clone();
                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                        {
                                            let patternInput_8: (
                                                LrcPtr<Spiral_wasm::Mut0>,
                                                LrcPtr<Spiral_wasm::Mut1>,
                                                LrcPtr<Spiral_wasm::Mut2>,
                                                LrcPtr<Spiral_wasm::Mut3>,
                                                Option<i64>,
                                            ) = Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                            Spiral_wasm::State::trace_state().set(Some((
                                                patternInput_8.0.clone(),
                                                patternInput_8.1.clone(),
                                                patternInput_8.2.clone(),
                                                patternInput_8.3.clone(),
                                                patternInput_8.4.clone(),
                                            )));
                                            ()
                                        }
                                        {
                                            let patternInput_9: (
                                                LrcPtr<Spiral_wasm::Mut0>,
                                                LrcPtr<Spiral_wasm::Mut1>,
                                                LrcPtr<Spiral_wasm::Mut2>,
                                                LrcPtr<Spiral_wasm::Mut3>,
                                                Option<i64>,
                                            ) = getValue(
                                                Spiral_wasm::State::trace_state().get().clone(),
                                            );
                                            let v766: Spiral_wasm::US0 =
                                                (patternInput_9.3.clone()).l0.get().clone();
                                            if if (patternInput_9.2.clone()).l0.get().clone()
                                                == false
                                            {
                                                false
                                            } else {
                                                1_i32
                                                    >= find(
                                                        v766,
                                                        ofSeq(ofList(ofArray(new_array(&[
                                                            LrcPtr::new((
                                                                Spiral_wasm::US0::US0_0,
                                                                0_i32,
                                                            )),
                                                            LrcPtr::new((
                                                                Spiral_wasm::US0::US0_1,
                                                                1_i32,
                                                            )),
                                                            LrcPtr::new((
                                                                Spiral_wasm::US0::US0_2,
                                                                2_i32,
                                                            )),
                                                            LrcPtr::new((
                                                                Spiral_wasm::US0::US0_3,
                                                                3_i32,
                                                            )),
                                                            LrcPtr::new((
                                                                Spiral_wasm::US0::US0_4,
                                                                4_i32,
                                                            )),
                                                        ])))),
                                                    )
                                            } {
                                                let v773: i64 = v724.l0.get().clone() + 1_i64;
                                                v724.l0.set(v773);
                                                if Spiral_wasm::State::trace_state()
                                                    .get()
                                                    .clone()
                                                    .is_none()
                                                {
                                                    let patternInput_10: (
                                                        LrcPtr<Spiral_wasm::Mut0>,
                                                        LrcPtr<Spiral_wasm::Mut1>,
                                                        LrcPtr<Spiral_wasm::Mut2>,
                                                        LrcPtr<Spiral_wasm::Mut3>,
                                                        Option<i64>,
                                                    ) = Spiral_wasm::method0(
                                                        Spiral_wasm::US0::US0_0,
                                                    );
                                                    Spiral_wasm::State::trace_state().set(Some((
                                                        patternInput_10.0.clone(),
                                                        patternInput_10.1.clone(),
                                                        patternInput_10.2.clone(),
                                                        patternInput_10.3.clone(),
                                                        patternInput_10.4.clone(),
                                                    )));
                                                    ()
                                                }
                                                {
                                                    let patternInput_11: (
                                                        LrcPtr<Spiral_wasm::Mut0>,
                                                        LrcPtr<Spiral_wasm::Mut1>,
                                                        LrcPtr<Spiral_wasm::Mut2>,
                                                        LrcPtr<Spiral_wasm::Mut3>,
                                                        Option<i64>,
                                                    ) = getValue(
                                                        Spiral_wasm::State::trace_state()
                                                            .get()
                                                            .clone(),
                                                    );
                                                    let v790: Option<i64> =
                                                        patternInput_11.4.clone();
                                                    let _v802: LrcPtr<
                                                        MutCell<Option<Spiral_wasm::US3>>,
                                                    > = refCell(None::<Spiral_wasm::US3>);
                                                    {
                                                        let x_8: Option<Spiral_wasm::US3> =
                                                            match &v790 {
                                                                None => None::<Spiral_wasm::US3>,
                                                                Some(v790_0_0) => {
                                                                    let x_6: i64 = v790_0_0.clone();
                                                                    Some((Func0::new({
                                                                        let x_6 = x_6.clone();
                                                                        move || {
                                                                            Spiral_wasm::US3::US3_0(
                                                                                x_6,
                                                                            )
                                                                        }
                                                                    }))(
                                                                    ))
                                                                }
                                                            };
                                                        _v802.set(x_8)
                                                    }
                                                    {
                                                        let v817: Spiral_wasm::US3 = defaultValue(
                                                            Spiral_wasm::US3::US3_1,
                                                            _v802.get().clone(),
                                                        );
                                                        let v857: DateTime = match &v817 {
                                                            Spiral_wasm::US3::US3_0(v817_0_0) => {
                                                                let v831:
                                                                        TimeSpan =
                                                                    TimeSpan::new_ticks({
                                                                                            let _arg_5:
                                                                                                    DateTime =
                                                                                                DateTime::now();
                                                                                            _arg_5.ticks()
                                                                                        }
                                                                                            -
                                                                                            match &v817
                                                                                                {
                                                                                                Spiral_wasm::US3::US3_0(x)
                                                                                                =>
                                                                                                x.clone(),
                                                                                                _
                                                                                                =>
                                                                                                unreachable!(),
                                                                                            });
                                                                DateTime::new_ymdhms_milli(
                                                                    1_i32,
                                                                    1_i32,
                                                                    1_i32,
                                                                    v831.hours(),
                                                                    v831.minutes(),
                                                                    v831.seconds(),
                                                                    v831.milliseconds(),
                                                                )
                                                            }
                                                            _ => DateTime::now(),
                                                        };
                                                        let v862: string = {
                                                            let provider_1: string =
                                                                Spiral_wasm::method5();
                                                            v857.toString(provider_1)
                                                        };
                                                        let v1224: string = padLeft(
                                                            toLower(string("Debug")),
                                                            7_i32,
                                                            ' ',
                                                        );
                                                        let v1240: &str =
                                                            inline_colorization::color_bright_blue;
                                                        let v1242: &str = &*v1224;
                                                        let v1244: &str =
                                                            inline_colorization::color_reset;
                                                        let v1246: string = string(
                                                            "format!(\"{v1240}{v1242}{v1244}\")",
                                                        );
                                                        let v1247: std::string::String =
                                                            format!("{v1240}{v1242}{v1244}");
                                                        let v1249: string =
                                                            fable_library_rust::String_::fromString(
                                                                v1247,
                                                            );
                                                        let v1290: i64 =
                                                            (patternInput_11.0.clone())
                                                                .l0
                                                                .get()
                                                                .clone();
                                                        let v1292: LrcPtr<Spiral_wasm::Mut4> =
                                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                                l0: MutCell::new(
                                                                    Spiral_wasm::method8(),
                                                                ),
                                                            });
                                                        let v1294: string =
                                                            sprintf!("{}", string("{ "));
                                                        let v1298: string =
                                                            append(v1292.l0.get().clone(), v1294);
                                                        v1292.l0.set(v1298);
                                                        {
                                                            let v1300: string =
                                                                sprintf!("{}", string("worker"));
                                                            let v1304: string = append(
                                                                v1292.l0.get().clone(),
                                                                v1300,
                                                            );
                                                            v1292.l0.set(v1304);
                                                            {
                                                                let v1306: string =
                                                                    sprintf!("{}", string(" = "));
                                                                let v1310: string = append(
                                                                    v1292.l0.get().clone(),
                                                                    v1306,
                                                                );
                                                                v1292.l0.set(v1310);
                                                                {
                                                                    let v1313: std::string::String =
                                                                        format!("{:#?}", v711);
                                                                    let v1338:
                                                                        string =
                                                                    sprintf!("{}",
                                                                             fable_library_rust::String_::fromString(v1313));
                                                                    let v1342: string = append(
                                                                        v1292.l0.get().clone(),
                                                                        v1338,
                                                                    );
                                                                    v1292.l0.set(v1342);
                                                                    {
                                                                        let v1344: string = sprintf!(
                                                                            "{}",
                                                                            string(" }")
                                                                        );
                                                                        let v1348: string = append(
                                                                            v1292.l0.get().clone(),
                                                                            v1344,
                                                                        );
                                                                        v1292.l0.set(v1348);
                                                                        {
                                                                            let v1349: string =
                                                                                v1292
                                                                                    .l0
                                                                                    .get()
                                                                                    .clone();
                                                                            let v1388:
                                                                                string =
                                                                            trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                 v862,
                                                                                                                 v1249,
                                                                                                                 v1290,
                                                                                                                 Spiral_wasm::closure5((),
                                                                                                                                       ()),
                                                                                                                 v1349),
                                                                                                        toArray(empty::<char>())),
                                                                                         toArray(ofArray(new_array(&[' ',
                                                                                                                     '/']))));
                                                                            println!(
                                                                                "{}",
                                                                                v1388.clone()
                                                                            );
                                                                            ();
                                                                            ((patternInput_7
                                                                                .1
                                                                                .clone())
                                                                            .l0
                                                                            .get()
                                                                            .clone())(
                                                                                v1388
                                                                            )
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            {
                                                let v1412: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<
                                                                near_workspaces::Contract,
                                                                near_workspaces::error::Error,
                                                            >,
                                                        >,
                                                    >,
                                                > = Box::pin(v711.dev_deploy(&v707));
                                                let v1414: Result<
                                                    near_workspaces::Contract,
                                                    near_workspaces::error::Error,
                                                > = v1412.await;
                                                let v1416: near_workspaces::Contract = v1414?;
                                                if Spiral_wasm::State::trace_state()
                                                    .get()
                                                    .clone()
                                                    .is_none()
                                                {
                                                    let patternInput_12: (
                                                        LrcPtr<Spiral_wasm::Mut0>,
                                                        LrcPtr<Spiral_wasm::Mut1>,
                                                        LrcPtr<Spiral_wasm::Mut2>,
                                                        LrcPtr<Spiral_wasm::Mut3>,
                                                        Option<i64>,
                                                    ) = Spiral_wasm::method0(
                                                        Spiral_wasm::US0::US0_0,
                                                    );
                                                    Spiral_wasm::State::trace_state().set(Some((
                                                        patternInput_12.0.clone(),
                                                        patternInput_12.1.clone(),
                                                        patternInput_12.2.clone(),
                                                        patternInput_12.3.clone(),
                                                        patternInput_12.4.clone(),
                                                    )));
                                                    ()
                                                }
                                                {
                                                    let patternInput_13: (
                                                        LrcPtr<Spiral_wasm::Mut0>,
                                                        LrcPtr<Spiral_wasm::Mut1>,
                                                        LrcPtr<Spiral_wasm::Mut2>,
                                                        LrcPtr<Spiral_wasm::Mut3>,
                                                        Option<i64>,
                                                    ) = getValue(
                                                        Spiral_wasm::State::trace_state()
                                                            .get()
                                                            .clone(),
                                                    );
                                                    let v1429: LrcPtr<Spiral_wasm::Mut0> =
                                                        patternInput_13.0.clone();
                                                    if Spiral_wasm::State::trace_state()
                                                        .get()
                                                        .clone()
                                                        .is_none()
                                                    {
                                                        let patternInput_14: (
                                                            LrcPtr<Spiral_wasm::Mut0>,
                                                            LrcPtr<Spiral_wasm::Mut1>,
                                                            LrcPtr<Spiral_wasm::Mut2>,
                                                            LrcPtr<Spiral_wasm::Mut3>,
                                                            Option<i64>,
                                                        ) = Spiral_wasm::method0(
                                                            Spiral_wasm::US0::US0_0,
                                                        );
                                                        Spiral_wasm::State::trace_state().set(
                                                            Some((
                                                                patternInput_14.0.clone(),
                                                                patternInput_14.1.clone(),
                                                                patternInput_14.2.clone(),
                                                                patternInput_14.3.clone(),
                                                                patternInput_14.4.clone(),
                                                            )),
                                                        );
                                                        ()
                                                    }
                                                    {
                                                        let patternInput_15: (
                                                            LrcPtr<Spiral_wasm::Mut0>,
                                                            LrcPtr<Spiral_wasm::Mut1>,
                                                            LrcPtr<Spiral_wasm::Mut2>,
                                                            LrcPtr<Spiral_wasm::Mut3>,
                                                            Option<i64>,
                                                        ) = getValue(
                                                            Spiral_wasm::State::trace_state()
                                                                .get()
                                                                .clone(),
                                                        );
                                                        let v1471: Spiral_wasm::US0 =
                                                            (patternInput_15.3.clone())
                                                                .l0
                                                                .get()
                                                                .clone();
                                                        if if (patternInput_15.2.clone())
                                                            .l0
                                                            .get()
                                                            .clone()
                                                            == false
                                                        {
                                                            false
                                                        } else {
                                                            1_i32 >=
                                                               find(v1471,
                                                                    ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Spiral_wasm::US0::US0_0,
                                                                                                                  0_i32)),
                                                                                                     LrcPtr::new((Spiral_wasm::US0::US0_1,
                                                                                                                  1_i32)),
                                                                                                     LrcPtr::new((Spiral_wasm::US0::US0_2,
                                                                                                                  2_i32)),
                                                                                                     LrcPtr::new((Spiral_wasm::US0::US0_3,
                                                                                                                  3_i32)),
                                                                                                     LrcPtr::new((Spiral_wasm::US0::US0_4,
                                                                                                                  4_i32))])))))
                                                        } {
                                                            let v1478: i64 =
                                                                v1429.l0.get().clone() + 1_i64;
                                                            v1429.l0.set(v1478);
                                                            if Spiral_wasm::State::trace_state()
                                                                .get()
                                                                .clone()
                                                                .is_none()
                                                            {
                                                                let patternInput_16: (
                                                                    LrcPtr<Spiral_wasm::Mut0>,
                                                                    LrcPtr<Spiral_wasm::Mut1>,
                                                                    LrcPtr<Spiral_wasm::Mut2>,
                                                                    LrcPtr<Spiral_wasm::Mut3>,
                                                                    Option<i64>,
                                                                ) = Spiral_wasm::method0(
                                                                    Spiral_wasm::US0::US0_0,
                                                                );
                                                                Spiral_wasm::State::trace_state()
                                                                    .set(Some((
                                                                        patternInput_16.0.clone(),
                                                                        patternInput_16.1.clone(),
                                                                        patternInput_16.2.clone(),
                                                                        patternInput_16.3.clone(),
                                                                        patternInput_16.4.clone(),
                                                                    )));
                                                                ()
                                                            }
                                                            {
                                                                let patternInput_17:
                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                     Option<i64>) =
                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                let v1495: Option<i64> =
                                                                    patternInput_17.4.clone();
                                                                let _v1507: LrcPtr<
                                                                    MutCell<
                                                                        Option<Spiral_wasm::US3>,
                                                                    >,
                                                                > = refCell(
                                                                    None::<Spiral_wasm::US3>,
                                                                );
                                                                {
                                                                    let x_11: Option<
                                                                        Spiral_wasm::US3,
                                                                    > = match &v1495 {
                                                                        None => {
                                                                            None::<Spiral_wasm::US3>
                                                                        }
                                                                        Some(v1495_0_0) => {
                                                                            let x_9: i64 =
                                                                                v1495_0_0.clone();
                                                                            Some((Func0::new({
                                                                                let x_9 =
                                                                                    x_9.clone();
                                                                                move || {
                                                                                    Spiral_wasm::US3::US3_0(x_9)
                                                                                }
                                                                            }))(
                                                                            ))
                                                                        }
                                                                    };
                                                                    _v1507.set(x_11)
                                                                }
                                                                {
                                                                    let v1522: Spiral_wasm::US3 =
                                                                        defaultValue(
                                                                            Spiral_wasm::US3::US3_1,
                                                                            _v1507.get().clone(),
                                                                        );
                                                                    let v1562:
                                                                        DateTime =
                                                                    match &v1522
                                                                        {
                                                                        Spiral_wasm::US3::US3_0(v1522_0_0)
                                                                        => {
                                                                            let v1536:
                                                                                    TimeSpan =
                                                                                TimeSpan::new_ticks({
                                                                                                        let _arg_10:
                                                                                                                DateTime =
                                                                                                            DateTime::now();
                                                                                                        _arg_10.ticks()
                                                                                                    }
                                                                                                        -
                                                                                                        match &v1522
                                                                                                            {
                                                                                                            Spiral_wasm::US3::US3_0(x)
                                                                                                            =>
                                                                                                            x.clone(),
                                                                                                            _
                                                                                                            =>
                                                                                                            unreachable!(),
                                                                                                        });
                                                                            DateTime::new_ymdhms_milli(1_i32,
                                                                                                       1_i32,
                                                                                                       1_i32,
                                                                                                       v1536.hours(),
                                                                                                       v1536.minutes(),
                                                                                                       v1536.seconds(),
                                                                                                       v1536.milliseconds())
                                                                        }
                                                                        _ =>
                                                                        DateTime::now(),
                                                                    };
                                                                    let v1567: string = {
                                                                        let provider_2: string =
                                                                            Spiral_wasm::method5();
                                                                        v1562.toString(provider_2)
                                                                    };
                                                                    let v1929: string = padLeft(
                                                                        toLower(string("Debug")),
                                                                        7_i32,
                                                                        ' ',
                                                                    );
                                                                    let v1945:
                                                                        &str =
                                                                    inline_colorization::color_bright_blue;
                                                                    let v1947: &str = &*v1929;
                                                                    let v1949:
                                                                        &str =
                                                                    inline_colorization::color_reset;
                                                                    let v1951:
                                                                        string =
                                                                    string("format!(\"{v1945}{v1947}{v1949}\")");
                                                                    let v1952: std::string::String = format!(
                                                                        "{v1945}{v1947}{v1949}"
                                                                    );
                                                                    let v1954:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v1952);
                                                                    let v1995: i64 =
                                                                        (patternInput_17.0.clone())
                                                                            .l0
                                                                            .get()
                                                                            .clone();
                                                                    let v1997:
                                                                        LrcPtr<Spiral_wasm::Mut4> =
                                                                    LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                      MutCell::new(Spiral_wasm::method8()),});
                                                                    let v1999: string = sprintf!(
                                                                        "{}",
                                                                        string("{ ")
                                                                    );
                                                                    let v2003: string = append(
                                                                        v1997.l0.get().clone(),
                                                                        v1999,
                                                                    );
                                                                    v1997.l0.set(v2003);
                                                                    {
                                                                        let v2005: string = sprintf!(
                                                                            "{}",
                                                                            string("contract")
                                                                        );
                                                                        let v2009: string = append(
                                                                            v1997.l0.get().clone(),
                                                                            v2005,
                                                                        );
                                                                        v1997.l0.set(v2009);
                                                                        {
                                                                            let v2011: string = sprintf!(
                                                                                "{}",
                                                                                string(" = ")
                                                                            );
                                                                            let v2015: string =
                                                                                append(
                                                                                    v1997
                                                                                        .l0
                                                                                        .get()
                                                                                        .clone(),
                                                                                    v2011,
                                                                                );
                                                                            v1997.l0.set(v2015);
                                                                            {
                                                                                let v2018:
                                                                                    std::string::String =
                                                                                format!("{:#?}", v1416);
                                                                                let v2043:
                                                                                    string =
                                                                                sprintf!("{}",
                                                                                         fable_library_rust::String_::fromString(v2018));
                                                                                let v2047: string =
                                                                                    append(
                                                                                        v1997
                                                                                            .l0
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                        v2043,
                                                                                    );
                                                                                v1997.l0.set(v2047);
                                                                                {
                                                                                    let v2049:
                                                                                        string =
                                                                                    sprintf!("{}",
                                                                                             string(" }"));
                                                                                    let v2053:
                                                                                        string =
                                                                                    append(v1997.l0.get().clone(),
                                                                                           v2049);
                                                                                    v1997
                                                                                        .l0
                                                                                        .set(v2053);
                                                                                    {
                                                                                        let v2054:
                                                                                            string =
                                                                                        v1997.l0.get().clone();
                                                                                        let v2093:
                                                                                            string =
                                                                                        trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                             v1567,
                                                                                                                             v1954,
                                                                                                                             v1995,
                                                                                                                             Spiral_wasm::closure6((),
                                                                                                                                                   ()),
                                                                                                                             v2054),
                                                                                                                    toArray(empty::<char>())),
                                                                                                     toArray(ofArray(new_array(&[' ',
                                                                                                                                 '/']))));
                                                                                        println!("{}", v2093.clone());
                                                                                        ();
                                                                                        ((patternInput_13.1.clone()).l0.get().clone())(v2093)
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        {
                                                            let v2118:
                                                                near_workspaces::operations::CallTransaction =
                                                            v1416.call(&*string("state_main"));
                                                            let v2120:
                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<near_workspaces::result::ExecutionFinalResult,
                                                                                                                          near_workspaces::error::Error>>>> =
                                                            Box::pin(v2118.transact());
                                                            let v2122:
                                                                Result<near_workspaces::result::ExecutionFinalResult,
                                                                       near_workspaces::error::Error> =
                                                            v2120.await;
                                                            let v2124:
                                                                near_workspaces::result::ExecutionFinalResult =
                                                            v2122?;
                                                            if Spiral_wasm::State::trace_state()
                                                                .get()
                                                                .clone()
                                                                .is_none()
                                                            {
                                                                let patternInput_18: (
                                                                    LrcPtr<Spiral_wasm::Mut0>,
                                                                    LrcPtr<Spiral_wasm::Mut1>,
                                                                    LrcPtr<Spiral_wasm::Mut2>,
                                                                    LrcPtr<Spiral_wasm::Mut3>,
                                                                    Option<i64>,
                                                                ) = Spiral_wasm::method0(
                                                                    Spiral_wasm::US0::US0_0,
                                                                );
                                                                Spiral_wasm::State::trace_state()
                                                                    .set(Some((
                                                                        patternInput_18.0.clone(),
                                                                        patternInput_18.1.clone(),
                                                                        patternInput_18.2.clone(),
                                                                        patternInput_18.3.clone(),
                                                                        patternInput_18.4.clone(),
                                                                    )));
                                                                ()
                                                            }
                                                            {
                                                                let patternInput_19:
                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                     Option<i64>) =
                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                let v2137: LrcPtr<
                                                                    Spiral_wasm::Mut0,
                                                                > = patternInput_19.0.clone();
                                                                if Spiral_wasm::State::trace_state()
                                                                    .get()
                                                                    .clone()
                                                                    .is_none()
                                                                {
                                                                    let patternInput_20: (
                                                                        LrcPtr<Spiral_wasm::Mut0>,
                                                                        LrcPtr<Spiral_wasm::Mut1>,
                                                                        LrcPtr<Spiral_wasm::Mut2>,
                                                                        LrcPtr<Spiral_wasm::Mut3>,
                                                                        Option<i64>,
                                                                    ) = Spiral_wasm::method0(
                                                                        Spiral_wasm::US0::US0_0,
                                                                    );
                                                                    Spiral_wasm::State::trace_state().set(Some((patternInput_20.0.clone(),
                                                                                                            patternInput_20.1.clone(),
                                                                                                            patternInput_20.2.clone(),
                                                                                                            patternInput_20.3.clone(),
                                                                                                            patternInput_20.4.clone())));
                                                                    ()
                                                                }
                                                                {
                                                                    let patternInput_21:
                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                         Option<i64>) =
                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                    let v2179: Spiral_wasm::US0 =
                                                                        (patternInput_21.3.clone())
                                                                            .l0
                                                                            .get()
                                                                            .clone();
                                                                    if if (patternInput_21
                                                                        .2
                                                                        .clone())
                                                                    .l0
                                                                    .get()
                                                                    .clone()
                                                                        == false
                                                                    {
                                                                        false
                                                                    } else {
                                                                        1_i32
                                                                           >=
                                                                           find(v2179,
                                                                                ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Spiral_wasm::US0::US0_0,
                                                                                                                              0_i32)),
                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_1,
                                                                                                                              1_i32)),
                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_2,
                                                                                                                              2_i32)),
                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_3,
                                                                                                                              3_i32)),
                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_4,
                                                                                                                              4_i32))])))))
                                                                    } {
                                                                        let v2186: i64 =
                                                                            v2137.l0.get().clone()
                                                                                + 1_i64;
                                                                        v2137.l0.set(v2186);
                                                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                       {
                                                                        let patternInput_22:
                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                 Option<i64>) =
                                                                            Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                        Spiral_wasm::State::trace_state().set(Some((patternInput_22.0.clone(),
                                                                                                                    patternInput_22.1.clone(),
                                                                                                                    patternInput_22.2.clone(),
                                                                                                                    patternInput_22.3.clone(),
                                                                                                                    patternInput_22.4.clone())));
                                                                        ()
                                                                    }
                                                                        {
                                                                            let patternInput_23:
                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                 Option<i64>) =
                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                            let v2203: Option<i64> =
                                                                                patternInput_23
                                                                                    .4
                                                                                    .clone();
                                                                            let _v2215:
                                                                                LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                            refCell(None::<Spiral_wasm::US3>);
                                                                            {
                                                                                let x_14:
                                                                                    Option<Spiral_wasm::US3> =
                                                                                match &v2203
                                                                                    {
                                                                                    None
                                                                                    =>
                                                                                    None::<Spiral_wasm::US3>,
                                                                                    Some(v2203_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let x_12:
                                                                                                i64 =
                                                                                            v2203_0_0.clone();
                                                                                        Some((Func0::new({
                                                                                                             let x_12
                                                                                                                 =
                                                                                                                 x_12.clone();
                                                                                                             move
                                                                                                                 ||
                                                                                                                 Spiral_wasm::US3::US3_0(x_12)
                                                                                                         }))())
                                                                                    }
                                                                                };
                                                                                _v2215.set(x_14)
                                                                            }
                                                                            {
                                                                                let v2230:
                                                                                    Spiral_wasm::US3 =
                                                                                defaultValue(Spiral_wasm::US3::US3_1,
                                                                                             _v2215.get().clone());
                                                                                let v2270:
                                                                                    DateTime =
                                                                                match &v2230
                                                                                    {
                                                                                    Spiral_wasm::US3::US3_0(v2230_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v2244:
                                                                                                TimeSpan =
                                                                                            TimeSpan::new_ticks({
                                                                                                                    let _arg_15:
                                                                                                                            DateTime =
                                                                                                                        DateTime::now();
                                                                                                                    _arg_15.ticks()
                                                                                                                }
                                                                                                                    -
                                                                                                                    match &v2230
                                                                                                                        {
                                                                                                                        Spiral_wasm::US3::US3_0(x)
                                                                                                                        =>
                                                                                                                        x.clone(),
                                                                                                                        _
                                                                                                                        =>
                                                                                                                        unreachable!(),
                                                                                                                    });
                                                                                        DateTime::new_ymdhms_milli(1_i32,
                                                                                                                   1_i32,
                                                                                                                   1_i32,
                                                                                                                   v2244.hours(),
                                                                                                                   v2244.minutes(),
                                                                                                                   v2244.seconds(),
                                                                                                                   v2244.milliseconds())
                                                                                    }
                                                                                    _
                                                                                    =>
                                                                                    DateTime::now(),
                                                                                };
                                                                                let v2275: string = {
                                                                                    let provider_3:
                                                                                            string =
                                                                                        Spiral_wasm::method5();
                                                                                    v2270.toString(
                                                                                        provider_3,
                                                                                    )
                                                                                };
                                                                                let v2637:
                                                                                    string =
                                                                                padLeft(toLower(string("Debug")),
                                                                                        7_i32,
                                                                                        ' ');
                                                                                let v2653:
                                                                                    &str =
                                                                                inline_colorization::color_bright_blue;
                                                                                let v2655: &str =
                                                                                    &*v2637;
                                                                                let v2657:
                                                                                    &str =
                                                                                inline_colorization::color_reset;
                                                                                let v2659:
                                                                                    string =
                                                                                string("format!(\"{v2653}{v2655}{v2657}\")");
                                                                                let v2660:
                                                                                    std::string::String =
                                                                                format!("{v2653}{v2655}{v2657}");
                                                                                let v2662:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v2660);
                                                                                let v2703:
                                                                                    i64 =
                                                                                (patternInput_23.0.clone()).l0.get().clone();
                                                                                let v2705:
                                                                                    LrcPtr<Spiral_wasm::Mut4> =
                                                                                LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                  MutCell::new(Spiral_wasm::method8()),});
                                                                                let v2707: string = sprintf!(
                                                                                    "{}",
                                                                                    string("{ ")
                                                                                );
                                                                                let v2711: string =
                                                                                    append(
                                                                                        v2705
                                                                                            .l0
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                        v2707,
                                                                                    );
                                                                                v2705.l0.set(v2711);
                                                                                {
                                                                                    let v2713:
                                                                                        string =
                                                                                    sprintf!("{}",
                                                                                             string("result"));
                                                                                    let v2717:
                                                                                        string =
                                                                                    append(v2705.l0.get().clone(),
                                                                                           v2713);
                                                                                    v2705
                                                                                        .l0
                                                                                        .set(v2717);
                                                                                    {
                                                                                        let v2719:
                                                                                            string =
                                                                                        sprintf!("{}",
                                                                                                 string(" = "));
                                                                                        let v2723:
                                                                                            string =
                                                                                        append(v2705.l0.get().clone(),
                                                                                               v2719);
                                                                                        v2705
                                                                                            .l0
                                                                                            .set(
                                                                                            v2723,
                                                                                        );
                                                                                        {
                                                                                            let v2726:
                                                                                                std::string::String =
                                                                                            format!("{:#?}", v2124.clone());
                                                                                            let v2751:
                                                                                                string =
                                                                                            sprintf!("{}",
                                                                                                     fable_library_rust::String_::fromString(v2726));
                                                                                            let v2755:
                                                                                                string =
                                                                                            append(v2705.l0.get().clone(),
                                                                                                   v2751);
                                                                                            v2705.l0.set(v2755);
                                                                                            {
                                                                                                let v2757:
                                                                                                    string =
                                                                                                sprintf!("{}",
                                                                                                         string(" }"));
                                                                                                let v2761:
                                                                                                    string =
                                                                                                append(v2705.l0.get().clone(),
                                                                                                       v2757);
                                                                                                v2705.l0.set(v2761);
                                                                                                {
                                                                                                    let v2762:
                                                                                                        string =
                                                                                                    v2705.l0.get().clone();
                                                                                                    let v2801:
                                                                                                        string =
                                                                                                    trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                         v2275,
                                                                                                                                         v2662,
                                                                                                                                         v2703,
                                                                                                                                         Spiral_wasm::closure7((),
                                                                                                                                                               ()),
                                                                                                                                         v2762),
                                                                                                                                toArray(empty::<char>())),
                                                                                                                 toArray(ofArray(new_array(&[' ',
                                                                                                                                             '/']))));
                                                                                                    println!("{}", v2801.clone());
                                                                                                    ();
                                                                                                    ((patternInput_19.1.clone()).l0.get().clone())(v2801)
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    {
                                                                        let v2825: Vec<&str> =
                                                                            v2124.logs();
                                                                        let v2827: bool = true;
                                                                        let _result: Vec<_> = v2825
                                                                            .into_iter()
                                                                            .map(|x| {
                                                                                //;
                                                                                let v2829: &str = x;
                                                                                let v2831:
                                                                            std::string::String =
                                                                        String::from(v2829);
                                                                                let v2833: bool =
                                                                                    true;
                                                                                v2831
                                                                            })
                                                                            .collect::<Vec<_>>();
                                                                        let v2835: Vec<
                                                                            std::string::String,
                                                                        > = _result;
                                                                        v2835.iter().for_each(|x| { Func1::new(move
                                                                                                               |v:
                                                                                                                    std::string::String|
                                                                                                               Spiral_wasm::closure8((),
                                                                                                                                     v))(x.clone()); });
                                                                        println!("\n\n state_main transact result: {:#?}", v2124.clone()); //;
                                                                        println!("\n\n print_usd:"); //;
                                                                        print_usd(v2124.clone()); //;
                                                                        {
                                                                            let v2842:
                                                                                Result<near_workspaces::result::ExecutionResult<near_workspaces::result::Value>,
                                                                                       near_workspaces::result::ExecutionResult<near_primitives::errors::TxExecutionError>> =
                                                                            v2124.clone().into_result();
                                                                            if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                           {
                                                                            let patternInput_24:
                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                     Option<i64>) =
                                                                                Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                            Spiral_wasm::State::trace_state().set(Some((patternInput_24.0.clone(),
                                                                                                                        patternInput_24.1.clone(),
                                                                                                                        patternInput_24.2.clone(),
                                                                                                                        patternInput_24.3.clone(),
                                                                                                                        patternInput_24.4.clone())));
                                                                            ()
                                                                        }
                                                                            {
                                                                                let patternInput_25:
                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                     Option<i64>) =
                                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                let v2855:
                                                                                    LrcPtr<Spiral_wasm::Mut0> =
                                                                                patternInput_25.0.clone();
                                                                                if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                               {
                                                                                let patternInput_26:
                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                         Option<i64>) =
                                                                                    Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                Spiral_wasm::State::trace_state().set(Some((patternInput_26.0.clone(),
                                                                                                                            patternInput_26.1.clone(),
                                                                                                                            patternInput_26.2.clone(),
                                                                                                                            patternInput_26.3.clone(),
                                                                                                                            patternInput_26.4.clone())));
                                                                                ()
                                                                            }
                                                                                {
                                                                                    let patternInput_27:
                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                         Option<i64>) =
                                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                    let v2897:
                                                                                        Spiral_wasm::US0 =
                                                                                    (patternInput_27.3.clone()).l0.get().clone();
                                                                                    if if (patternInput_27.2.clone()).l0.get().clone()
                                                                                          ==
                                                                                          false
                                                                                      {
                                                                                       false
                                                                                   } else {
                                                                                       1_i32
                                                                                           >=
                                                                                           find(v2897,
                                                                                                ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Spiral_wasm::US0::US0_0,
                                                                                                                                              0_i32)),
                                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_1,
                                                                                                                                              1_i32)),
                                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_2,
                                                                                                                                              2_i32)),
                                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_3,
                                                                                                                                              3_i32)),
                                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_4,
                                                                                                                                              4_i32))])))))
                                                                                   }
                                                                                   {
                                                                                    let v2904:
                                                                                            i64 =
                                                                                        v2855.l0.get().clone()
                                                                                            +
                                                                                            1_i64;
                                                                                    v2855.l0.set(v2904);
                                                                                    if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                       {
                                                                                        let patternInput_28:
                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                 Option<i64>) =
                                                                                            Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                        Spiral_wasm::State::trace_state().set(Some((patternInput_28.0.clone(),
                                                                                                                                    patternInput_28.1.clone(),
                                                                                                                                    patternInput_28.2.clone(),
                                                                                                                                    patternInput_28.3.clone(),
                                                                                                                                    patternInput_28.4.clone())));
                                                                                        ()
                                                                                    }
                                                                                    {
                                                                                        let patternInput_29:
                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                 Option<i64>) =
                                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                        let v2921:
                                                                                                Option<i64> =
                                                                                            patternInput_29.4.clone();
                                                                                        let _v2933:
                                                                                                LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                            refCell(None::<Spiral_wasm::US3>);
                                                                                        {
                                                                                            let x_17:
                                                                                                    Option<Spiral_wasm::US3> =
                                                                                                match &v2921
                                                                                                    {
                                                                                                    None
                                                                                                    =>
                                                                                                    None::<Spiral_wasm::US3>,
                                                                                                    Some(v2921_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let x_15:
                                                                                                                i64 =
                                                                                                            v2921_0_0.clone();
                                                                                                        Some((Func0::new({
                                                                                                                             let x_15
                                                                                                                                 =
                                                                                                                                 x_15.clone();
                                                                                                                             move
                                                                                                                                 ||
                                                                                                                                 Spiral_wasm::US3::US3_0(x_15)
                                                                                                                         }))())
                                                                                                    }
                                                                                                };
                                                                                            _v2933.set(x_17)
                                                                                        }
                                                                                        {
                                                                                            let v2948:
                                                                                                    Spiral_wasm::US3 =
                                                                                                defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                             _v2933.get().clone());
                                                                                            let v2988:
                                                                                                    DateTime =
                                                                                                match &v2948
                                                                                                    {
                                                                                                    Spiral_wasm::US3::US3_0(v2948_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v2962:
                                                                                                                TimeSpan =
                                                                                                            TimeSpan::new_ticks({
                                                                                                                                    let _arg_20:
                                                                                                                                            DateTime =
                                                                                                                                        DateTime::now();
                                                                                                                                    _arg_20.ticks()
                                                                                                                                }
                                                                                                                                    -
                                                                                                                                    match &v2948
                                                                                                                                        {
                                                                                                                                        Spiral_wasm::US3::US3_0(x)
                                                                                                                                        =>
                                                                                                                                        x.clone(),
                                                                                                                                        _
                                                                                                                                        =>
                                                                                                                                        unreachable!(),
                                                                                                                                    });
                                                                                                        DateTime::new_ymdhms_milli(1_i32,
                                                                                                                                   1_i32,
                                                                                                                                   1_i32,
                                                                                                                                   v2962.hours(),
                                                                                                                                   v2962.minutes(),
                                                                                                                                   v2962.seconds(),
                                                                                                                                   v2962.milliseconds())
                                                                                                    }
                                                                                                    _
                                                                                                    =>
                                                                                                    DateTime::now(),
                                                                                                };
                                                                                            let v2993:
                                                                                                    string =
                                                                                                {
                                                                                                    let provider_4:
                                                                                                            string =
                                                                                                        Spiral_wasm::method5();
                                                                                                    v2988.toString(provider_4)
                                                                                                };
                                                                                            let v3355:
                                                                                                    string =
                                                                                                padLeft(toLower(string("Debug")),
                                                                                                        7_i32,
                                                                                                        ' ');
                                                                                            let v3371:
                                                                                                    &str =
                                                                                                inline_colorization::color_bright_blue;
                                                                                            let v3373:
                                                                                                    &str =
                                                                                                &*v3355;
                                                                                            let v3375:
                                                                                                    &str =
                                                                                                inline_colorization::color_reset;
                                                                                            let v3377:
                                                                                                    string =
                                                                                                string("format!(\"{v3371}{v3373}{v3375}\")");
                                                                                            let v3378:
                                                                                                    std::string::String =
                                                                                                format!("{v3371}{v3373}{v3375}");
                                                                                            let v3380:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromString(v3378);
                                                                                            let v3421:
                                                                                                    i64 =
                                                                                                (patternInput_29.0.clone()).l0.get().clone();
                                                                                            let v3423:
                                                                                                    LrcPtr<Spiral_wasm::Mut4> =
                                                                                                LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                  MutCell::new(Spiral_wasm::method8()),});
                                                                                            let v3425:
                                                                                                    string =
                                                                                                sprintf!("{}",
                                                                                                         string("{ "));
                                                                                            let v3429:
                                                                                                    string =
                                                                                                append(v3423.l0.get().clone(),
                                                                                                       v3425);
                                                                                            v3423.l0.set(v3429);
                                                                                            {
                                                                                                let v3431:
                                                                                                        string =
                                                                                                    sprintf!("{}",
                                                                                                             string("result2"));
                                                                                                let v3435:
                                                                                                        string =
                                                                                                    append(v3423.l0.get().clone(),
                                                                                                           v3431);
                                                                                                v3423.l0.set(v3435);
                                                                                                {
                                                                                                    let v3437:
                                                                                                            string =
                                                                                                        sprintf!("{}",
                                                                                                                 string(" = "));
                                                                                                    let v3441:
                                                                                                            string =
                                                                                                        append(v3423.l0.get().clone(),
                                                                                                               v3437);
                                                                                                    v3423.l0.set(v3441);
                                                                                                    {
                                                                                                        let v3444:
                                                                                                                std::string::String =
                                                                                                            format!("{:#?}", v2842);
                                                                                                        let v3469:
                                                                                                                string =
                                                                                                            sprintf!("{}",
                                                                                                                     fable_library_rust::String_::fromString(v3444));
                                                                                                        let v3473:
                                                                                                                string =
                                                                                                            append(v3423.l0.get().clone(),
                                                                                                                   v3469);
                                                                                                        v3423.l0.set(v3473);
                                                                                                        {
                                                                                                            let v3475:
                                                                                                                    string =
                                                                                                                sprintf!("{}",
                                                                                                                         string(" }"));
                                                                                                            let v3479:
                                                                                                                    string =
                                                                                                                append(v3423.l0.get().clone(),
                                                                                                                       v3475);
                                                                                                            v3423.l0.set(v3479);
                                                                                                            {
                                                                                                                let v3480:
                                                                                                                        string =
                                                                                                                    v3423.l0.get().clone();
                                                                                                                let v3519:
                                                                                                                        string =
                                                                                                                    trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                         v2993,
                                                                                                                                                         v3380,
                                                                                                                                                         v3421,
                                                                                                                                                         Spiral_wasm::closure9((),
                                                                                                                                                                               ()),
                                                                                                                                                         v3480),
                                                                                                                                                toArray(empty::<char>())),
                                                                                                                                 toArray(ofArray(new_array(&[' ',
                                                                                                                                                             '/']))));
                                                                                                                println!("{}", v3519.clone());
                                                                                                                ();
                                                                                                                ((patternInput_25.1.clone()).l0.get().clone())(v3519)
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                                    {
                                                                                        let v3542:
                                                                                            near_workspaces::result::ExecutionFinalResult =
                                                                                        Spiral_wasm::method12(v2124.clone());
                                                                                        let v3544:
                                                                                            Vec<&near_workspaces::result::ExecutionOutcome> =
                                                                                        v3542.receipt_failures();
                                                                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                       {
                                                                                        let patternInput_30:
                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                 Option<i64>) =
                                                                                            Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                        Spiral_wasm::State::trace_state().set(Some((patternInput_30.0.clone(),
                                                                                                                                    patternInput_30.1.clone(),
                                                                                                                                    patternInput_30.2.clone(),
                                                                                                                                    patternInput_30.3.clone(),
                                                                                                                                    patternInput_30.4.clone())));
                                                                                        ()
                                                                                    }
                                                                                        {
                                                                                            let patternInput_31:
                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                 Option<i64>) =
                                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                            let v3557:
                                                                                                LrcPtr<Spiral_wasm::Mut0> =
                                                                                            patternInput_31.0.clone();
                                                                                            if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                           {
                                                                                            let patternInput_32:
                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                     Option<i64>) =
                                                                                                Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                            Spiral_wasm::State::trace_state().set(Some((patternInput_32.0.clone(),
                                                                                                                                        patternInput_32.1.clone(),
                                                                                                                                        patternInput_32.2.clone(),
                                                                                                                                        patternInput_32.3.clone(),
                                                                                                                                        patternInput_32.4.clone())));
                                                                                            ()
                                                                                        }
                                                                                            {
                                                                                                let patternInput_33:
                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                     Option<i64>) =
                                                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                let v3599:
                                                                                                    Spiral_wasm::US0 =
                                                                                                (patternInput_33.3.clone()).l0.get().clone();
                                                                                                if if (patternInput_33.2.clone()).l0.get().clone()
                                                                                                      ==
                                                                                                      false
                                                                                                  {
                                                                                                   false
                                                                                               } else {
                                                                                                   1_i32
                                                                                                       >=
                                                                                                       find(v3599,
                                                                                                            ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Spiral_wasm::US0::US0_0,
                                                                                                                                                          0_i32)),
                                                                                                                                             LrcPtr::new((Spiral_wasm::US0::US0_1,
                                                                                                                                                          1_i32)),
                                                                                                                                             LrcPtr::new((Spiral_wasm::US0::US0_2,
                                                                                                                                                          2_i32)),
                                                                                                                                             LrcPtr::new((Spiral_wasm::US0::US0_3,
                                                                                                                                                          3_i32)),
                                                                                                                                             LrcPtr::new((Spiral_wasm::US0::US0_4,
                                                                                                                                                          4_i32))])))))
                                                                                               }
                                                                                               {
                                                                                                let v3606:
                                                                                                        i64 =
                                                                                                    v3557.l0.get().clone()
                                                                                                        +
                                                                                                        1_i64;
                                                                                                v3557.l0.set(v3606);
                                                                                                if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                   {
                                                                                                    let patternInput_34:
                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                             Option<i64>) =
                                                                                                        Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                    Spiral_wasm::State::trace_state().set(Some((patternInput_34.0.clone(),
                                                                                                                                                patternInput_34.1.clone(),
                                                                                                                                                patternInput_34.2.clone(),
                                                                                                                                                patternInput_34.3.clone(),
                                                                                                                                                patternInput_34.4.clone())));
                                                                                                    ()
                                                                                                }
                                                                                                {
                                                                                                    let patternInput_35:
                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                             Option<i64>) =
                                                                                                        getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                    let v3623:
                                                                                                            Option<i64> =
                                                                                                        patternInput_35.4.clone();
                                                                                                    let _v3635:
                                                                                                            LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                                        refCell(None::<Spiral_wasm::US3>);
                                                                                                    {
                                                                                                        let x_20:
                                                                                                                Option<Spiral_wasm::US3> =
                                                                                                            match &v3623
                                                                                                                {
                                                                                                                None
                                                                                                                =>
                                                                                                                None::<Spiral_wasm::US3>,
                                                                                                                Some(v3623_0_0)
                                                                                                                =>
                                                                                                                {
                                                                                                                    let x_18:
                                                                                                                            i64 =
                                                                                                                        v3623_0_0.clone();
                                                                                                                    Some((Func0::new({
                                                                                                                                         let x_18
                                                                                                                                             =
                                                                                                                                             x_18.clone();
                                                                                                                                         move
                                                                                                                                             ||
                                                                                                                                             Spiral_wasm::US3::US3_0(x_18)
                                                                                                                                     }))())
                                                                                                                }
                                                                                                            };
                                                                                                        _v3635.set(x_20)
                                                                                                    }
                                                                                                    {
                                                                                                        let v3650:
                                                                                                                Spiral_wasm::US3 =
                                                                                                            defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                                         _v3635.get().clone());
                                                                                                        let v3690:
                                                                                                                DateTime =
                                                                                                            match &v3650
                                                                                                                {
                                                                                                                Spiral_wasm::US3::US3_0(v3650_0_0)
                                                                                                                =>
                                                                                                                {
                                                                                                                    let v3664:
                                                                                                                            TimeSpan =
                                                                                                                        TimeSpan::new_ticks({
                                                                                                                                                let _arg_25:
                                                                                                                                                        DateTime =
                                                                                                                                                    DateTime::now();
                                                                                                                                                _arg_25.ticks()
                                                                                                                                            }
                                                                                                                                                -
                                                                                                                                                match &v3650
                                                                                                                                                    {
                                                                                                                                                    Spiral_wasm::US3::US3_0(x)
                                                                                                                                                    =>
                                                                                                                                                    x.clone(),
                                                                                                                                                    _
                                                                                                                                                    =>
                                                                                                                                                    unreachable!(),
                                                                                                                                                });
                                                                                                                    DateTime::new_ymdhms_milli(1_i32,
                                                                                                                                               1_i32,
                                                                                                                                               1_i32,
                                                                                                                                               v3664.hours(),
                                                                                                                                               v3664.minutes(),
                                                                                                                                               v3664.seconds(),
                                                                                                                                               v3664.milliseconds())
                                                                                                                }
                                                                                                                _
                                                                                                                =>
                                                                                                                DateTime::now(),
                                                                                                            };
                                                                                                        let v3695:
                                                                                                                string =
                                                                                                            {
                                                                                                                let provider_5:
                                                                                                                        string =
                                                                                                                    Spiral_wasm::method5();
                                                                                                                v3690.toString(provider_5)
                                                                                                            };
                                                                                                        let v4057:
                                                                                                                string =
                                                                                                            padLeft(toLower(string("Debug")),
                                                                                                                    7_i32,
                                                                                                                    ' ');
                                                                                                        let v4073:
                                                                                                                &str =
                                                                                                            inline_colorization::color_bright_blue;
                                                                                                        let v4075:
                                                                                                                &str =
                                                                                                            &*v4057;
                                                                                                        let v4077:
                                                                                                                &str =
                                                                                                            inline_colorization::color_reset;
                                                                                                        let v4079:
                                                                                                                string =
                                                                                                            string("format!(\"{v4073}{v4075}{v4077}\")");
                                                                                                        let v4080:
                                                                                                                std::string::String =
                                                                                                            format!("{v4073}{v4075}{v4077}");
                                                                                                        let v4082:
                                                                                                                string =
                                                                                                            fable_library_rust::String_::fromString(v4080);
                                                                                                        let v4123:
                                                                                                                i64 =
                                                                                                            (patternInput_35.0.clone()).l0.get().clone();
                                                                                                        let v4125:
                                                                                                                LrcPtr<Spiral_wasm::Mut4> =
                                                                                                            LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                              MutCell::new(Spiral_wasm::method8()),});
                                                                                                        let v4127:
                                                                                                                string =
                                                                                                            sprintf!("{}",
                                                                                                                     string("{ "));
                                                                                                        let v4131:
                                                                                                                string =
                                                                                                            append(v4125.l0.get().clone(),
                                                                                                                   v4127);
                                                                                                        v4125.l0.set(v4131);
                                                                                                        {
                                                                                                            let v4133:
                                                                                                                    string =
                                                                                                                sprintf!("{}",
                                                                                                                         string("receipt_failures"));
                                                                                                            let v4137:
                                                                                                                    string =
                                                                                                                append(v4125.l0.get().clone(),
                                                                                                                       v4133);
                                                                                                            v4125.l0.set(v4137);
                                                                                                            {
                                                                                                                let v4139:
                                                                                                                        string =
                                                                                                                    sprintf!("{}",
                                                                                                                             string(" = "));
                                                                                                                let v4143:
                                                                                                                        string =
                                                                                                                    append(v4125.l0.get().clone(),
                                                                                                                           v4139);
                                                                                                                v4125.l0.set(v4143);
                                                                                                                {
                                                                                                                    let v4146:
                                                                                                                            std::string::String =
                                                                                                                        format!("{:#?}", v3544.clone());
                                                                                                                    let v4171:
                                                                                                                            string =
                                                                                                                        sprintf!("{}",
                                                                                                                                 fable_library_rust::String_::fromString(v4146));
                                                                                                                    let v4175:
                                                                                                                            string =
                                                                                                                        append(v4125.l0.get().clone(),
                                                                                                                               v4171);
                                                                                                                    v4125.l0.set(v4175);
                                                                                                                    {
                                                                                                                        let v4177:
                                                                                                                                string =
                                                                                                                            sprintf!("{}",
                                                                                                                                     string(" }"));
                                                                                                                        let v4181:
                                                                                                                                string =
                                                                                                                            append(v4125.l0.get().clone(),
                                                                                                                                   v4177);
                                                                                                                        v4125.l0.set(v4181);
                                                                                                                        {
                                                                                                                            let v4182:
                                                                                                                                    string =
                                                                                                                                v4125.l0.get().clone();
                                                                                                                            let v4221:
                                                                                                                                    string =
                                                                                                                                trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                                     v3695,
                                                                                                                                                                     v4082,
                                                                                                                                                                     v4123,
                                                                                                                                                                     Spiral_wasm::closure10((),
                                                                                                                                                                                            ()),
                                                                                                                                                                     v4182),
                                                                                                                                                            toArray(empty::<char>())),
                                                                                                                                             toArray(ofArray(new_array(&[' ',
                                                                                                                                                                         '/']))));
                                                                                                                            println!("{}", v4221.clone());
                                                                                                                            ();
                                                                                                                            ((patternInput_31.1.clone()).l0.get().clone())(v4221)
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                                {
                                                                                                    let v4244:
                                                                                                        near_workspaces::result::ExecutionFinalResult =
                                                                                                    Spiral_wasm::method13(v2124.clone());
                                                                                                    let v4246:
                                                                                                        &[near_workspaces::result::ExecutionOutcome] =
                                                                                                    v4244.receipt_outcomes();
                                                                                                    if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                   {
                                                                                                    let patternInput_36:
                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                             Option<i64>) =
                                                                                                        Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                    Spiral_wasm::State::trace_state().set(Some((patternInput_36.0.clone(),
                                                                                                                                                patternInput_36.1.clone(),
                                                                                                                                                patternInput_36.2.clone(),
                                                                                                                                                patternInput_36.3.clone(),
                                                                                                                                                patternInput_36.4.clone())));
                                                                                                    ()
                                                                                                }
                                                                                                    {
                                                                                                        let patternInput_37:
                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                             Option<i64>) =
                                                                                                        getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                        let v4259:
                                                                                                            LrcPtr<Spiral_wasm::Mut0> =
                                                                                                        patternInput_37.0.clone();
                                                                                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                       {
                                                                                                        let patternInput_38:
                                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                 Option<i64>) =
                                                                                                            Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                        Spiral_wasm::State::trace_state().set(Some((patternInput_38.0.clone(),
                                                                                                                                                    patternInput_38.1.clone(),
                                                                                                                                                    patternInput_38.2.clone(),
                                                                                                                                                    patternInput_38.3.clone(),
                                                                                                                                                    patternInput_38.4.clone())));
                                                                                                        ()
                                                                                                    }
                                                                                                        {
                                                                                                            let patternInput_39:
                                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                 Option<i64>) =
                                                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                            let v4301:
                                                                                                                Spiral_wasm::US0 =
                                                                                                            (patternInput_39.3.clone()).l0.get().clone();
                                                                                                            if if (patternInput_39.2.clone()).l0.get().clone()
                                                                                                                  ==
                                                                                                                  false
                                                                                                              {
                                                                                                               false
                                                                                                           } else {
                                                                                                               1_i32
                                                                                                                   >=
                                                                                                                   find(v4301,
                                                                                                                        ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Spiral_wasm::US0::US0_0,
                                                                                                                                                                      0_i32)),
                                                                                                                                                         LrcPtr::new((Spiral_wasm::US0::US0_1,
                                                                                                                                                                      1_i32)),
                                                                                                                                                         LrcPtr::new((Spiral_wasm::US0::US0_2,
                                                                                                                                                                      2_i32)),
                                                                                                                                                         LrcPtr::new((Spiral_wasm::US0::US0_3,
                                                                                                                                                                      3_i32)),
                                                                                                                                                         LrcPtr::new((Spiral_wasm::US0::US0_4,
                                                                                                                                                                      4_i32))])))))
                                                                                                           }
                                                                                                           {
                                                                                                            let v4308:
                                                                                                                    i64 =
                                                                                                                v4259.l0.get().clone()
                                                                                                                    +
                                                                                                                    1_i64;
                                                                                                            v4259.l0.set(v4308);
                                                                                                            if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                               {
                                                                                                                let patternInput_40:
                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                         Option<i64>) =
                                                                                                                    Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                                Spiral_wasm::State::trace_state().set(Some((patternInput_40.0.clone(),
                                                                                                                                                            patternInput_40.1.clone(),
                                                                                                                                                            patternInput_40.2.clone(),
                                                                                                                                                            patternInput_40.3.clone(),
                                                                                                                                                            patternInput_40.4.clone())));
                                                                                                                ()
                                                                                                            }
                                                                                                            {
                                                                                                                let patternInput_41:
                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                         Option<i64>) =
                                                                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                let v4325:
                                                                                                                        Option<i64> =
                                                                                                                    patternInput_41.4.clone();
                                                                                                                let _v4337:
                                                                                                                        LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                                                    refCell(None::<Spiral_wasm::US3>);
                                                                                                                {
                                                                                                                    let x_23:
                                                                                                                            Option<Spiral_wasm::US3> =
                                                                                                                        match &v4325
                                                                                                                            {
                                                                                                                            None
                                                                                                                            =>
                                                                                                                            None::<Spiral_wasm::US3>,
                                                                                                                            Some(v4325_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let x_21:
                                                                                                                                        i64 =
                                                                                                                                    v4325_0_0.clone();
                                                                                                                                Some((Func0::new({
                                                                                                                                                     let x_21
                                                                                                                                                         =
                                                                                                                                                         x_21.clone();
                                                                                                                                                     move
                                                                                                                                                         ||
                                                                                                                                                         Spiral_wasm::US3::US3_0(x_21)
                                                                                                                                                 }))())
                                                                                                                            }
                                                                                                                        };
                                                                                                                    _v4337.set(x_23)
                                                                                                                }
                                                                                                                {
                                                                                                                    let v4352:
                                                                                                                            Spiral_wasm::US3 =
                                                                                                                        defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                                                     _v4337.get().clone());
                                                                                                                    let v4392:
                                                                                                                            DateTime =
                                                                                                                        match &v4352
                                                                                                                            {
                                                                                                                            Spiral_wasm::US3::US3_0(v4352_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v4366:
                                                                                                                                        TimeSpan =
                                                                                                                                    TimeSpan::new_ticks({
                                                                                                                                                            let _arg_30:
                                                                                                                                                                    DateTime =
                                                                                                                                                                DateTime::now();
                                                                                                                                                            _arg_30.ticks()
                                                                                                                                                        }
                                                                                                                                                            -
                                                                                                                                                            match &v4352
                                                                                                                                                                {
                                                                                                                                                                Spiral_wasm::US3::US3_0(x)
                                                                                                                                                                =>
                                                                                                                                                                x.clone(),
                                                                                                                                                                _
                                                                                                                                                                =>
                                                                                                                                                                unreachable!(),
                                                                                                                                                            });
                                                                                                                                DateTime::new_ymdhms_milli(1_i32,
                                                                                                                                                           1_i32,
                                                                                                                                                           1_i32,
                                                                                                                                                           v4366.hours(),
                                                                                                                                                           v4366.minutes(),
                                                                                                                                                           v4366.seconds(),
                                                                                                                                                           v4366.milliseconds())
                                                                                                                            }
                                                                                                                            _
                                                                                                                            =>
                                                                                                                            DateTime::now(),
                                                                                                                        };
                                                                                                                    let v4397:
                                                                                                                            string =
                                                                                                                        {
                                                                                                                            let provider_6:
                                                                                                                                    string =
                                                                                                                                Spiral_wasm::method5();
                                                                                                                            v4392.toString(provider_6)
                                                                                                                        };
                                                                                                                    let v4759:
                                                                                                                            string =
                                                                                                                        padLeft(toLower(string("Debug")),
                                                                                                                                7_i32,
                                                                                                                                ' ');
                                                                                                                    let v4775:
                                                                                                                            &str =
                                                                                                                        inline_colorization::color_bright_blue;
                                                                                                                    let v4777:
                                                                                                                            &str =
                                                                                                                        &*v4759;
                                                                                                                    let v4779:
                                                                                                                            &str =
                                                                                                                        inline_colorization::color_reset;
                                                                                                                    let v4781:
                                                                                                                            string =
                                                                                                                        string("format!(\"{v4775}{v4777}{v4779}\")");
                                                                                                                    let v4782:
                                                                                                                            std::string::String =
                                                                                                                        format!("{v4775}{v4777}{v4779}");
                                                                                                                    let v4784:
                                                                                                                            string =
                                                                                                                        fable_library_rust::String_::fromString(v4782);
                                                                                                                    let v4825:
                                                                                                                            i64 =
                                                                                                                        (patternInput_41.0.clone()).l0.get().clone();
                                                                                                                    let v4827:
                                                                                                                            LrcPtr<Spiral_wasm::Mut4> =
                                                                                                                        LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                                          MutCell::new(Spiral_wasm::method8()),});
                                                                                                                    let v4829:
                                                                                                                            string =
                                                                                                                        sprintf!("{}",
                                                                                                                                 string("{ "));
                                                                                                                    let v4833:
                                                                                                                            string =
                                                                                                                        append(v4827.l0.get().clone(),
                                                                                                                               v4829);
                                                                                                                    v4827.l0.set(v4833);
                                                                                                                    {
                                                                                                                        let v4835:
                                                                                                                                string =
                                                                                                                            sprintf!("{}",
                                                                                                                                     string("receipt_outcomes"));
                                                                                                                        let v4839:
                                                                                                                                string =
                                                                                                                            append(v4827.l0.get().clone(),
                                                                                                                                   v4835);
                                                                                                                        v4827.l0.set(v4839);
                                                                                                                        {
                                                                                                                            let v4841:
                                                                                                                                    string =
                                                                                                                                sprintf!("{}",
                                                                                                                                         string(" = "));
                                                                                                                            let v4845:
                                                                                                                                    string =
                                                                                                                                append(v4827.l0.get().clone(),
                                                                                                                                       v4841);
                                                                                                                            v4827.l0.set(v4845);
                                                                                                                            {
                                                                                                                                let v4848:
                                                                                                                                        std::string::String =
                                                                                                                                    format!("{:#?}", v4246);
                                                                                                                                let v4873:
                                                                                                                                        string =
                                                                                                                                    sprintf!("{}",
                                                                                                                                             fable_library_rust::String_::fromString(v4848));
                                                                                                                                let v4877:
                                                                                                                                        string =
                                                                                                                                    append(v4827.l0.get().clone(),
                                                                                                                                           v4873);
                                                                                                                                v4827.l0.set(v4877);
                                                                                                                                {
                                                                                                                                    let v4879:
                                                                                                                                            string =
                                                                                                                                        sprintf!("{}",
                                                                                                                                                 string(" }"));
                                                                                                                                    let v4883:
                                                                                                                                            string =
                                                                                                                                        append(v4827.l0.get().clone(),
                                                                                                                                               v4879);
                                                                                                                                    v4827.l0.set(v4883);
                                                                                                                                    {
                                                                                                                                        let v4884:
                                                                                                                                                string =
                                                                                                                                            v4827.l0.get().clone();
                                                                                                                                        let v4923:
                                                                                                                                                string =
                                                                                                                                            trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                                                 v4397,
                                                                                                                                                                                 v4784,
                                                                                                                                                                                 v4825,
                                                                                                                                                                                 Spiral_wasm::closure11((),
                                                                                                                                                                                                        ()),
                                                                                                                                                                                 v4884),
                                                                                                                                                                        toArray(empty::<char>())),
                                                                                                                                                         toArray(ofArray(new_array(&[' ',
                                                                                                                                                                                     '/']))));
                                                                                                                                        println!("{}", v4923.clone());
                                                                                                                                        ();
                                                                                                                                        ((patternInput_37.1.clone()).l0.get().clone())(v4923)
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                            {
                                                                                                                let v4947:
                                                                                                                    Result<std::string::String,
                                                                                                                           near_workspaces::error::Error> =
                                                                                                                v2124.clone().json();
                                                                                                                if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                               {
                                                                                                                let patternInput_42:
                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                         Option<i64>) =
                                                                                                                    Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                                Spiral_wasm::State::trace_state().set(Some((patternInput_42.0.clone(),
                                                                                                                                                            patternInput_42.1.clone(),
                                                                                                                                                            patternInput_42.2.clone(),
                                                                                                                                                            patternInput_42.3.clone(),
                                                                                                                                                            patternInput_42.4.clone())));
                                                                                                                ()
                                                                                                            }
                                                                                                                {
                                                                                                                    let patternInput_43:
                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                         Option<i64>) =
                                                                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                    let v4960:
                                                                                                                        LrcPtr<Spiral_wasm::Mut0> =
                                                                                                                    patternInput_43.0.clone();
                                                                                                                    if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                   {
                                                                                                                    let patternInput_44:
                                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                             Option<i64>) =
                                                                                                                        Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                                    Spiral_wasm::State::trace_state().set(Some((patternInput_44.0.clone(),
                                                                                                                                                                patternInput_44.1.clone(),
                                                                                                                                                                patternInput_44.2.clone(),
                                                                                                                                                                patternInput_44.3.clone(),
                                                                                                                                                                patternInput_44.4.clone())));
                                                                                                                    ()
                                                                                                                }
                                                                                                                    {
                                                                                                                        let patternInput_45:
                                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                             Option<i64>) =
                                                                                                                        getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                        let v5002:
                                                                                                                            Spiral_wasm::US0 =
                                                                                                                        (patternInput_45.3.clone()).l0.get().clone();
                                                                                                                        if if (patternInput_45.2.clone()).l0.get().clone()
                                                                                                                              ==
                                                                                                                              false
                                                                                                                          {
                                                                                                                           false
                                                                                                                       } else {
                                                                                                                           1_i32
                                                                                                                               >=
                                                                                                                               find(v5002,
                                                                                                                                    ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Spiral_wasm::US0::US0_0,
                                                                                                                                                                                  0_i32)),
                                                                                                                                                                     LrcPtr::new((Spiral_wasm::US0::US0_1,
                                                                                                                                                                                  1_i32)),
                                                                                                                                                                     LrcPtr::new((Spiral_wasm::US0::US0_2,
                                                                                                                                                                                  2_i32)),
                                                                                                                                                                     LrcPtr::new((Spiral_wasm::US0::US0_3,
                                                                                                                                                                                  3_i32)),
                                                                                                                                                                     LrcPtr::new((Spiral_wasm::US0::US0_4,
                                                                                                                                                                                  4_i32))])))))
                                                                                                                       }
                                                                                                                       {
                                                                                                                        let v5009:
                                                                                                                                i64 =
                                                                                                                            v4960.l0.get().clone()
                                                                                                                                +
                                                                                                                                1_i64;
                                                                                                                        v4960.l0.set(v5009);
                                                                                                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                           {
                                                                                                                            let patternInput_46:
                                                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                     Option<i64>) =
                                                                                                                                Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                                            Spiral_wasm::State::trace_state().set(Some((patternInput_46.0.clone(),
                                                                                                                                                                        patternInput_46.1.clone(),
                                                                                                                                                                        patternInput_46.2.clone(),
                                                                                                                                                                        patternInput_46.3.clone(),
                                                                                                                                                                        patternInput_46.4.clone())));
                                                                                                                            ()
                                                                                                                        }
                                                                                                                        {
                                                                                                                            let patternInput_47:
                                                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                     Option<i64>) =
                                                                                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                            let v5026:
                                                                                                                                    Option<i64> =
                                                                                                                                patternInput_47.4.clone();
                                                                                                                            let _v5038:
                                                                                                                                    LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                                                                refCell(None::<Spiral_wasm::US3>);
                                                                                                                            {
                                                                                                                                let x_26:
                                                                                                                                        Option<Spiral_wasm::US3> =
                                                                                                                                    match &v5026
                                                                                                                                        {
                                                                                                                                        None
                                                                                                                                        =>
                                                                                                                                        None::<Spiral_wasm::US3>,
                                                                                                                                        Some(v5026_0_0)
                                                                                                                                        =>
                                                                                                                                        {
                                                                                                                                            let x_24:
                                                                                                                                                    i64 =
                                                                                                                                                v5026_0_0.clone();
                                                                                                                                            Some((Func0::new({
                                                                                                                                                                 let x_24
                                                                                                                                                                     =
                                                                                                                                                                     x_24.clone();
                                                                                                                                                                 move
                                                                                                                                                                     ||
                                                                                                                                                                     Spiral_wasm::US3::US3_0(x_24)
                                                                                                                                                             }))())
                                                                                                                                        }
                                                                                                                                    };
                                                                                                                                _v5038.set(x_26)
                                                                                                                            }
                                                                                                                            {
                                                                                                                                let v5053:
                                                                                                                                        Spiral_wasm::US3 =
                                                                                                                                    defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                                                                 _v5038.get().clone());
                                                                                                                                let v5093:
                                                                                                                                        DateTime =
                                                                                                                                    match &v5053
                                                                                                                                        {
                                                                                                                                        Spiral_wasm::US3::US3_0(v5053_0_0)
                                                                                                                                        =>
                                                                                                                                        {
                                                                                                                                            let v5067:
                                                                                                                                                    TimeSpan =
                                                                                                                                                TimeSpan::new_ticks({
                                                                                                                                                                        let _arg_35:
                                                                                                                                                                                DateTime =
                                                                                                                                                                            DateTime::now();
                                                                                                                                                                        _arg_35.ticks()
                                                                                                                                                                    }
                                                                                                                                                                        -
                                                                                                                                                                        match &v5053
                                                                                                                                                                            {
                                                                                                                                                                            Spiral_wasm::US3::US3_0(x)
                                                                                                                                                                            =>
                                                                                                                                                                            x.clone(),
                                                                                                                                                                            _
                                                                                                                                                                            =>
                                                                                                                                                                            unreachable!(),
                                                                                                                                                                        });
                                                                                                                                            DateTime::new_ymdhms_milli(1_i32,
                                                                                                                                                                       1_i32,
                                                                                                                                                                       1_i32,
                                                                                                                                                                       v5067.hours(),
                                                                                                                                                                       v5067.minutes(),
                                                                                                                                                                       v5067.seconds(),
                                                                                                                                                                       v5067.milliseconds())
                                                                                                                                        }
                                                                                                                                        _
                                                                                                                                        =>
                                                                                                                                        DateTime::now(),
                                                                                                                                    };
                                                                                                                                let v5098:
                                                                                                                                        string =
                                                                                                                                    {
                                                                                                                                        let provider_7:
                                                                                                                                                string =
                                                                                                                                            Spiral_wasm::method5();
                                                                                                                                        v5093.toString(provider_7)
                                                                                                                                    };
                                                                                                                                let v5460:
                                                                                                                                        string =
                                                                                                                                    padLeft(toLower(string("Debug")),
                                                                                                                                            7_i32,
                                                                                                                                            ' ');
                                                                                                                                let v5476:
                                                                                                                                        &str =
                                                                                                                                    inline_colorization::color_bright_blue;
                                                                                                                                let v5478:
                                                                                                                                        &str =
                                                                                                                                    &*v5460;
                                                                                                                                let v5480:
                                                                                                                                        &str =
                                                                                                                                    inline_colorization::color_reset;
                                                                                                                                let v5482:
                                                                                                                                        string =
                                                                                                                                    string("format!(\"{v5476}{v5478}{v5480}\")");
                                                                                                                                let v5483:
                                                                                                                                        std::string::String =
                                                                                                                                    format!("{v5476}{v5478}{v5480}");
                                                                                                                                let v5485:
                                                                                                                                        string =
                                                                                                                                    fable_library_rust::String_::fromString(v5483);
                                                                                                                                let v5526:
                                                                                                                                        i64 =
                                                                                                                                    (patternInput_47.0.clone()).l0.get().clone();
                                                                                                                                let v5528:
                                                                                                                                        LrcPtr<Spiral_wasm::Mut4> =
                                                                                                                                    LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                                                      MutCell::new(Spiral_wasm::method8()),});
                                                                                                                                let v5530:
                                                                                                                                        string =
                                                                                                                                    sprintf!("{}",
                                                                                                                                             string("{ "));
                                                                                                                                let v5534:
                                                                                                                                        string =
                                                                                                                                    append(v5528.l0.get().clone(),
                                                                                                                                           v5530);
                                                                                                                                v5528.l0.set(v5534);
                                                                                                                                {
                                                                                                                                    let v5536:
                                                                                                                                            string =
                                                                                                                                        sprintf!("{}",
                                                                                                                                                 string("json"));
                                                                                                                                    let v5540:
                                                                                                                                            string =
                                                                                                                                        append(v5528.l0.get().clone(),
                                                                                                                                               v5536);
                                                                                                                                    v5528.l0.set(v5540);
                                                                                                                                    {
                                                                                                                                        let v5542:
                                                                                                                                                string =
                                                                                                                                            sprintf!("{}",
                                                                                                                                                     string(" = "));
                                                                                                                                        let v5546:
                                                                                                                                                string =
                                                                                                                                            append(v5528.l0.get().clone(),
                                                                                                                                                   v5542);
                                                                                                                                        v5528.l0.set(v5546);
                                                                                                                                        {
                                                                                                                                            let v5549:
                                                                                                                                                    std::string::String =
                                                                                                                                                format!("{:#?}", v4947);
                                                                                                                                            let v5574:
                                                                                                                                                    string =
                                                                                                                                                sprintf!("{}",
                                                                                                                                                         fable_library_rust::String_::fromString(v5549));
                                                                                                                                            let v5578:
                                                                                                                                                    string =
                                                                                                                                                append(v5528.l0.get().clone(),
                                                                                                                                                       v5574);
                                                                                                                                            v5528.l0.set(v5578);
                                                                                                                                            {
                                                                                                                                                let v5580:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("{}",
                                                                                                                                                             string(" }"));
                                                                                                                                                let v5584:
                                                                                                                                                        string =
                                                                                                                                                    append(v5528.l0.get().clone(),
                                                                                                                                                           v5580);
                                                                                                                                                v5528.l0.set(v5584);
                                                                                                                                                {
                                                                                                                                                    let v5585:
                                                                                                                                                            string =
                                                                                                                                                        v5528.l0.get().clone();
                                                                                                                                                    let v5624:
                                                                                                                                                            string =
                                                                                                                                                        trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                                                             v5098,
                                                                                                                                                                                             v5485,
                                                                                                                                                                                             v5526,
                                                                                                                                                                                             Spiral_wasm::closure12((),
                                                                                                                                                                                                                    ()),
                                                                                                                                                                                             v5585),
                                                                                                                                                                                    toArray(empty::<char>())),
                                                                                                                                                                     toArray(ofArray(new_array(&[' ',
                                                                                                                                                                                                 '/']))));
                                                                                                                                                    println!("{}", v5624.clone());
                                                                                                                                                    ();
                                                                                                                                                    ((patternInput_43.1.clone()).l0.get().clone())(v5624)
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                        {
                                                                                                                            let v5648:
                                                                                                                                Result<std::string::String,
                                                                                                                                       near_workspaces::error::Error> =
                                                                                                                            v2124.borsh();
                                                                                                                            if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                           {
                                                                                                                            let patternInput_48:
                                                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                     Option<i64>) =
                                                                                                                                Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                                            Spiral_wasm::State::trace_state().set(Some((patternInput_48.0.clone(),
                                                                                                                                                                        patternInput_48.1.clone(),
                                                                                                                                                                        patternInput_48.2.clone(),
                                                                                                                                                                        patternInput_48.3.clone(),
                                                                                                                                                                        patternInput_48.4.clone())));
                                                                                                                            ()
                                                                                                                        }
                                                                                                                            {
                                                                                                                                let patternInput_49:
                                                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                     Option<i64>) =
                                                                                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                                let v5661:
                                                                                                                                    LrcPtr<Spiral_wasm::Mut0> =
                                                                                                                                patternInput_49.0.clone();
                                                                                                                                if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                               {
                                                                                                                                let patternInput_50:
                                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                         Option<i64>) =
                                                                                                                                    Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                                                Spiral_wasm::State::trace_state().set(Some((patternInput_50.0.clone(),
                                                                                                                                                                            patternInput_50.1.clone(),
                                                                                                                                                                            patternInput_50.2.clone(),
                                                                                                                                                                            patternInput_50.3.clone(),
                                                                                                                                                                            patternInput_50.4.clone())));
                                                                                                                                ()
                                                                                                                            }
                                                                                                                                {
                                                                                                                                    let patternInput_51:
                                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                         Option<i64>) =
                                                                                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                                    let v5703:
                                                                                                                                        Spiral_wasm::US0 =
                                                                                                                                    (patternInput_51.3.clone()).l0.get().clone();
                                                                                                                                    if if (patternInput_51.2.clone()).l0.get().clone()
                                                                                                                                          ==
                                                                                                                                          false
                                                                                                                                      {
                                                                                                                                       false
                                                                                                                                   } else {
                                                                                                                                       1_i32
                                                                                                                                           >=
                                                                                                                                           find(v5703,
                                                                                                                                                ofSeq(ofList(ofArray(new_array(&[LrcPtr::new((Spiral_wasm::US0::US0_0,
                                                                                                                                                                                              0_i32)),
                                                                                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_1,
                                                                                                                                                                                              1_i32)),
                                                                                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_2,
                                                                                                                                                                                              2_i32)),
                                                                                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_3,
                                                                                                                                                                                              3_i32)),
                                                                                                                                                                                 LrcPtr::new((Spiral_wasm::US0::US0_4,
                                                                                                                                                                                              4_i32))])))))
                                                                                                                                   }
                                                                                                                                   {
                                                                                                                                    let v5710:
                                                                                                                                            i64 =
                                                                                                                                        v5661.l0.get().clone()
                                                                                                                                            +
                                                                                                                                            1_i64;
                                                                                                                                    v5661.l0.set(v5710);
                                                                                                                                    if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                                       {
                                                                                                                                        let patternInput_52:
                                                                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                                 Option<i64>) =
                                                                                                                                            Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                                                                                                                        Spiral_wasm::State::trace_state().set(Some((patternInput_52.0.clone(),
                                                                                                                                                                                    patternInput_52.1.clone(),
                                                                                                                                                                                    patternInput_52.2.clone(),
                                                                                                                                                                                    patternInput_52.3.clone(),
                                                                                                                                                                                    patternInput_52.4.clone())));
                                                                                                                                        ()
                                                                                                                                    }
                                                                                                                                    {
                                                                                                                                        let patternInput_53:
                                                                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                                 Option<i64>) =
                                                                                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                                        let v5727:
                                                                                                                                                Option<i64> =
                                                                                                                                            patternInput_53.4.clone();
                                                                                                                                        let _v5739:
                                                                                                                                                LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                                                                            refCell(None::<Spiral_wasm::US3>);
                                                                                                                                        {
                                                                                                                                            let x_29:
                                                                                                                                                    Option<Spiral_wasm::US3> =
                                                                                                                                                match &v5727
                                                                                                                                                    {
                                                                                                                                                    None
                                                                                                                                                    =>
                                                                                                                                                    None::<Spiral_wasm::US3>,
                                                                                                                                                    Some(v5727_0_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let x_27:
                                                                                                                                                                i64 =
                                                                                                                                                            v5727_0_0.clone();
                                                                                                                                                        Some((Func0::new({
                                                                                                                                                                             let x_27
                                                                                                                                                                                 =
                                                                                                                                                                                 x_27.clone();
                                                                                                                                                                             move
                                                                                                                                                                                 ||
                                                                                                                                                                                 Spiral_wasm::US3::US3_0(x_27)
                                                                                                                                                                         }))())
                                                                                                                                                    }
                                                                                                                                                };
                                                                                                                                            _v5739.set(x_29)
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v5754:
                                                                                                                                                    Spiral_wasm::US3 =
                                                                                                                                                defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                                                                             _v5739.get().clone());
                                                                                                                                            let v5794:
                                                                                                                                                    DateTime =
                                                                                                                                                match &v5754
                                                                                                                                                    {
                                                                                                                                                    Spiral_wasm::US3::US3_0(v5754_0_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v5768:
                                                                                                                                                                TimeSpan =
                                                                                                                                                            TimeSpan::new_ticks({
                                                                                                                                                                                    let _arg_40:
                                                                                                                                                                                            DateTime =
                                                                                                                                                                                        DateTime::now();
                                                                                                                                                                                    _arg_40.ticks()
                                                                                                                                                                                }
                                                                                                                                                                                    -
                                                                                                                                                                                    match &v5754
                                                                                                                                                                                        {
                                                                                                                                                                                        Spiral_wasm::US3::US3_0(x)
                                                                                                                                                                                        =>
                                                                                                                                                                                        x.clone(),
                                                                                                                                                                                        _
                                                                                                                                                                                        =>
                                                                                                                                                                                        unreachable!(),
                                                                                                                                                                                    });
                                                                                                                                                        DateTime::new_ymdhms_milli(1_i32,
                                                                                                                                                                                   1_i32,
                                                                                                                                                                                   1_i32,
                                                                                                                                                                                   v5768.hours(),
                                                                                                                                                                                   v5768.minutes(),
                                                                                                                                                                                   v5768.seconds(),
                                                                                                                                                                                   v5768.milliseconds())
                                                                                                                                                    }
                                                                                                                                                    _
                                                                                                                                                    =>
                                                                                                                                                    DateTime::now(),
                                                                                                                                                };
                                                                                                                                            let v5799:
                                                                                                                                                    string =
                                                                                                                                                {
                                                                                                                                                    let provider_8:
                                                                                                                                                            string =
                                                                                                                                                        Spiral_wasm::method5();
                                                                                                                                                    v5794.toString(provider_8)
                                                                                                                                                };
                                                                                                                                            let v6161:
                                                                                                                                                    string =
                                                                                                                                                padLeft(toLower(string("Debug")),
                                                                                                                                                        7_i32,
                                                                                                                                                        ' ');
                                                                                                                                            let v6177:
                                                                                                                                                    &str =
                                                                                                                                                inline_colorization::color_bright_blue;
                                                                                                                                            let v6179:
                                                                                                                                                    &str =
                                                                                                                                                &*v6161;
                                                                                                                                            let v6181:
                                                                                                                                                    &str =
                                                                                                                                                inline_colorization::color_reset;
                                                                                                                                            let v6183:
                                                                                                                                                    string =
                                                                                                                                                string("format!(\"{v6177}{v6179}{v6181}\")");
                                                                                                                                            let v6184:
                                                                                                                                                    std::string::String =
                                                                                                                                                format!("{v6177}{v6179}{v6181}");
                                                                                                                                            let v6186:
                                                                                                                                                    string =
                                                                                                                                                fable_library_rust::String_::fromString(v6184);
                                                                                                                                            let v6227:
                                                                                                                                                    i64 =
                                                                                                                                                (patternInput_53.0.clone()).l0.get().clone();
                                                                                                                                            let v6229:
                                                                                                                                                    LrcPtr<Spiral_wasm::Mut4> =
                                                                                                                                                LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                                                                  MutCell::new(Spiral_wasm::method8()),});
                                                                                                                                            let v6231:
                                                                                                                                                    string =
                                                                                                                                                sprintf!("{}",
                                                                                                                                                         string("{ "));
                                                                                                                                            let v6235:
                                                                                                                                                    string =
                                                                                                                                                append(v6229.l0.get().clone(),
                                                                                                                                                       v6231);
                                                                                                                                            v6229.l0.set(v6235);
                                                                                                                                            {
                                                                                                                                                let v6237:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("{}",
                                                                                                                                                             string("borsh"));
                                                                                                                                                let v6241:
                                                                                                                                                        string =
                                                                                                                                                    append(v6229.l0.get().clone(),
                                                                                                                                                           v6237);
                                                                                                                                                v6229.l0.set(v6241);
                                                                                                                                                {
                                                                                                                                                    let v6243:
                                                                                                                                                            string =
                                                                                                                                                        sprintf!("{}",
                                                                                                                                                                 string(" = "));
                                                                                                                                                    let v6247:
                                                                                                                                                            string =
                                                                                                                                                        append(v6229.l0.get().clone(),
                                                                                                                                                               v6243);
                                                                                                                                                    v6229.l0.set(v6247);
                                                                                                                                                    {
                                                                                                                                                        let v6250:
                                                                                                                                                                std::string::String =
                                                                                                                                                            format!("{:#?}", v5648);
                                                                                                                                                        let v6275:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("{}",
                                                                                                                                                                     fable_library_rust::String_::fromString(v6250));
                                                                                                                                                        let v6279:
                                                                                                                                                                string =
                                                                                                                                                            append(v6229.l0.get().clone(),
                                                                                                                                                                   v6275);
                                                                                                                                                        v6229.l0.set(v6279);
                                                                                                                                                        {
                                                                                                                                                            let v6281:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("{}",
                                                                                                                                                                         string(" }"));
                                                                                                                                                            let v6285:
                                                                                                                                                                    string =
                                                                                                                                                                append(v6229.l0.get().clone(),
                                                                                                                                                                       v6281);
                                                                                                                                                            v6229.l0.set(v6285);
                                                                                                                                                            {
                                                                                                                                                                let v6286:
                                                                                                                                                                        string =
                                                                                                                                                                    v6229.l0.get().clone();
                                                                                                                                                                let v6325:
                                                                                                                                                                        string =
                                                                                                                                                                    trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                                                                         v5799,
                                                                                                                                                                                                         v6186,
                                                                                                                                                                                                         v6227,
                                                                                                                                                                                                         Spiral_wasm::closure13((),
                                                                                                                                                                                                                                ()),
                                                                                                                                                                                                         v6286),
                                                                                                                                                                                                toArray(empty::<char>())),
                                                                                                                                                                                 toArray(ofArray(new_array(&[' ',
                                                                                                                                                                                                             '/']))));
                                                                                                                                                                println!("{}", v6325.clone());
                                                                                                                                                                ();
                                                                                                                                                                ((patternInput_49.1.clone()).l0.get().clone())(v6325)
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                    println!("\n\n worker: {:#?}", v711); //;
                                                                                                                                    println!("\n\n contract: {:#?}", v1416); //;
                                                                                                                                    {
                                                                                                                                        let v6362:
                                                                                                                                            Result<(),
                                                                                                                                                   anyhow::Error> =
                                                                                                                                        Spiral_wasm::method14(if v3544.len()
                                                                                                                                                                     as
                                                                                                                                                                     i32
                                                                                                                                                                     ==
                                                                                                                                                                     0_i32
                                                                                                                                                                 {
                                                                                                                                                                  Ok::<(),
                                                                                                                                                                       anyhow::Error>(())
                                                                                                                                                              } else {
                                                                                                                                                                  let v6358:
                                                                                                                                                                          anyhow::Error =
                                                                                                                                                                      anyhow::anyhow!(string("<error>"));
                                                                                                                                                                  Err(v6358)
                                                                                                                                                              });
                                                                                                                                        let v6427:
                                                                                                                                            string =
                                                                                                                                        string("v6362 }}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}); {{{{{{{{{{{{{{{{{{{{{{{{{{{{{{ // rust.fix_closure\'");
                                                                                                                                        v6362
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
                        }
                    }
                }
            });
            {
                {
                    {
                        {
                            {
                                {
                                    {
                                        {
                                            {
                                                {
                                                    {
                                                        {
                                                            {
                                                                {
                                                                    {
                                                                        {
                                                                            {
                                                                                {
                                                                                    {
                                                                                        {
                                                                                            {
                                                                                                {
                                                                                                    {
                                                                                                        {
                                                                                                            {
                                                                                                                {
                                                                                                                    {
                                                                                                                        {
                                                                                                                            {
                                                                                                                                {
                                                                                                                                    // rust.fix_closure';
                                                                                                                                    __result
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
                    }
                }
            }
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
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
            }
            {
                let patternInput_1: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                if Spiral_wasm::State::trace_state().get().clone().is_none() {
                    let patternInput_2: (
                        LrcPtr<Spiral_wasm::Mut0>,
                        LrcPtr<Spiral_wasm::Mut1>,
                        LrcPtr<Spiral_wasm::Mut2>,
                        LrcPtr<Spiral_wasm::Mut3>,
                        Option<i64>,
                    ) = Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                    Spiral_wasm::State::trace_state().set(Some((
                        patternInput_2.0.clone(),
                        patternInput_2.1.clone(),
                        patternInput_2.2.clone(),
                        patternInput_2.3.clone(),
                        patternInput_2.4.clone(),
                    )));
                    ()
                }
                {
                    let patternInput_3: (
                        LrcPtr<Spiral_wasm::Mut0>,
                        LrcPtr<Spiral_wasm::Mut1>,
                        LrcPtr<Spiral_wasm::Mut2>,
                        LrcPtr<Spiral_wasm::Mut3>,
                        Option<i64>,
                    ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                    let v40: LrcPtr<Spiral_wasm::Mut0> = patternInput_3.0.clone();
                    if Spiral_wasm::State::trace_state().get().clone().is_none() {
                        let patternInput_4: (
                            LrcPtr<Spiral_wasm::Mut0>,
                            LrcPtr<Spiral_wasm::Mut1>,
                            LrcPtr<Spiral_wasm::Mut2>,
                            LrcPtr<Spiral_wasm::Mut3>,
                            Option<i64>,
                        ) = Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                        Spiral_wasm::State::trace_state().set(Some((
                            patternInput_4.0.clone(),
                            patternInput_4.1.clone(),
                            patternInput_4.2.clone(),
                            patternInput_4.3.clone(),
                            patternInput_4.4.clone(),
                        )));
                        ()
                    }
                    {
                        let patternInput_5: (
                            LrcPtr<Spiral_wasm::Mut0>,
                            LrcPtr<Spiral_wasm::Mut1>,
                            LrcPtr<Spiral_wasm::Mut2>,
                            LrcPtr<Spiral_wasm::Mut3>,
                            Option<i64>,
                        ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                        let v82: Spiral_wasm::US0 = (patternInput_5.3.clone()).l0.get().clone();
                        if if (patternInput_5.2.clone()).l0.get().clone() == false {
                            false
                        } else {
                            1_i32
                                >= find(
                                    v82,
                                    ofSeq(ofList(ofArray(new_array(&[
                                        LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                                        LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                                        LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                                        LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                                        LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                                    ])))),
                                )
                        } {
                            let v89: i64 = v40.l0.get().clone() + 1_i64;
                            v40.l0.set(v89);
                            if Spiral_wasm::State::trace_state().get().clone().is_none() {
                                let patternInput_6: (
                                    LrcPtr<Spiral_wasm::Mut0>,
                                    LrcPtr<Spiral_wasm::Mut1>,
                                    LrcPtr<Spiral_wasm::Mut2>,
                                    LrcPtr<Spiral_wasm::Mut3>,
                                    Option<i64>,
                                ) = Spiral_wasm::method0(Spiral_wasm::US0::US0_0);
                                Spiral_wasm::State::trace_state().set(Some((
                                    patternInput_6.0.clone(),
                                    patternInput_6.1.clone(),
                                    patternInput_6.2.clone(),
                                    patternInput_6.3.clone(),
                                    patternInput_6.4.clone(),
                                )));
                                ()
                            }
                            {
                                let patternInput_7: (
                                    LrcPtr<Spiral_wasm::Mut0>,
                                    LrcPtr<Spiral_wasm::Mut1>,
                                    LrcPtr<Spiral_wasm::Mut2>,
                                    LrcPtr<Spiral_wasm::Mut3>,
                                    Option<i64>,
                                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                                let v106: Option<i64> = patternInput_7.4.clone();
                                let _v118: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                    refCell(None::<Spiral_wasm::US3>);
                                {
                                    let x_2: Option<Spiral_wasm::US3> = match &v106 {
                                        None => None::<Spiral_wasm::US3>,
                                        Some(v106_0_0) => {
                                            let x: i64 = v106_0_0.clone();
                                            Some((Func0::new({
                                                let x = x.clone();
                                                move || Spiral_wasm::US3::US3_0(x)
                                            }))())
                                        }
                                    };
                                    _v118.set(x_2)
                                }
                                {
                                    let v133: Spiral_wasm::US3 =
                                        defaultValue(Spiral_wasm::US3::US3_1, _v118.get().clone());
                                    let v173: DateTime = match &v133 {
                                        Spiral_wasm::US3::US3_0(v133_0_0) => {
                                            let v147: TimeSpan = TimeSpan::new_ticks(
                                                {
                                                    let _arg: DateTime = DateTime::now();
                                                    _arg.ticks()
                                                } - match &v133 {
                                                    Spiral_wasm::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                            );
                                            DateTime::new_ymdhms_milli(
                                                1_i32,
                                                1_i32,
                                                1_i32,
                                                v147.hours(),
                                                v147.minutes(),
                                                v147.seconds(),
                                                v147.milliseconds(),
                                            )
                                        }
                                        _ => DateTime::now(),
                                    };
                                    let v178: string = {
                                        let provider: string = Spiral_wasm::method5();
                                        v173.toString(provider)
                                    };
                                    let v540: string =
                                        padLeft(toLower(string("Debug")), 7_i32, ' ');
                                    let v556: &str = inline_colorization::color_bright_blue;
                                    let v558: &str = &*v540;
                                    let v560: &str = inline_colorization::color_reset;
                                    let v562: string = string("format!(\"{v556}{v558}{v560}\")");
                                    let v563: std::string::String = format!("{v556}{v558}{v560}");
                                    let v565: string =
                                        fable_library_rust::String_::fromString(v563);
                                    let v606: i64 = (patternInput_7.0.clone()).l0.get().clone();
                                    let v608: LrcPtr<Spiral_wasm::Mut4> =
                                        LrcPtr::new(Spiral_wasm::Mut4 {
                                            l0: MutCell::new(Spiral_wasm::method8()),
                                        });
                                    let v610: string = sprintf!("{}", string("{ "));
                                    let v614: string = append(v608.l0.get().clone(), v610);
                                    v608.l0.set(v614);
                                    {
                                        let v616: string = sprintf!("{}", string("args"));
                                        let v620: string = append(v608.l0.get().clone(), v616);
                                        v608.l0.set(v620);
                                        {
                                            let v622: string = sprintf!("{}", string(" = "));
                                            let v626: string = append(v608.l0.get().clone(), v622);
                                            v608.l0.set(v626);
                                            {
                                                let v630: string =
                                                    sprintf!("{}", sprintf!("{:?}", v0_1));
                                                let v634: string =
                                                    append(v608.l0.get().clone(), v630);
                                                v608.l0.set(v634);
                                                {
                                                    let v636: string = sprintf!("{}", string(" }"));
                                                    let v640: string =
                                                        append(v608.l0.get().clone(), v636);
                                                    v608.l0.set(v640);
                                                    {
                                                        let v641: string = v608.l0.get().clone();
                                                        let v680: string = trimEndChars(
                                                            trimStartChars(
                                                                sprintf!(
                                                                    "{} {} #{} {} / {}",
                                                                    v178,
                                                                    v565,
                                                                    v606,
                                                                    Spiral_wasm::closure3((), ()),
                                                                    v641
                                                                ),
                                                                toArray(empty::<char>()),
                                                            ),
                                                            toArray(ofArray(new_array(&[
                                                                ' ', '/',
                                                            ]))),
                                                        );
                                                        println!("{}", v680.clone());
                                                        ();
                                                        ((patternInput_3.1.clone())
                                                            .l0
                                                            .get()
                                                            .clone())(
                                                            v680
                                                        )
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        {
                            let v703: clap::Command = Spiral_wasm::method9();
                            let v706: std::pin::Pin<
                                Box<dyn std::future::Future<Output = Result<(), anyhow::Error>>>,
                            > = Spiral_wasm::method10(clap::Command::get_matches(v703));
                            let v708 = tokio::runtime::Builder::new_multi_thread()
                                .enable_all()
                                .build()
                                .unwrap();
                            let v710: Result<(), anyhow::Error> = v708.handle().block_on(v706);
                            v710.unwrap();
                            0_i32
                        }
                    }
                }
            }
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
