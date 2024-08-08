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
        pub fn method0() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method2() -> string {
            string("")
        }
        pub fn method1(v0_1: string) -> string {
            let v4: Result<std::string::String, std::env::VarError> = std::env::var(&*v0_1);
            let v6: bool = true;
            let _result = v4.map(|x| {
                //;
                let v8: std::string::String = x;
                let v10: string = fable_library_rust::String_::fromString(v8);
                let v12: bool = true;
                v10
            });
            let v14: Result<string, std::env::VarError> = _result;
            let v15: string = Spiral_wasm::method2();
            v14.unwrap_or(v15)
        }
        pub fn method3() -> string {
            string("AUTOMATION")
        }
        pub fn closure3(unitVar: (), v0_1: string) {
            ();
        }
        pub fn closure2(
            unitVar: (),
            v0_1: Spiral_wasm::US0,
        ) -> (
            LrcPtr<Spiral_wasm::Mut0>,
            LrcPtr<Spiral_wasm::Mut1>,
            LrcPtr<Spiral_wasm::Mut2>,
            LrcPtr<Spiral_wasm::Mut3>,
            Option<i64>,
        ) {
            let v4: string = Spiral_wasm::method1(Spiral_wasm::method0());
            let v10: Spiral_wasm::US2 = if string("Verbose") == v4.clone() {
                Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_0)
            } else {
                Spiral_wasm::US2::US2_1
            };
            let result: (Spiral_wasm::US2, Spiral_wasm::US3) = (
                match &v10 {
                    Spiral_wasm::US2::US2_0(v10_0_0) => Spiral_wasm::US2::US2_0(match &v10 {
                        Spiral_wasm::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v18: Spiral_wasm::US2 = if string("Debug") == v4.clone() {
                            Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_1)
                        } else {
                            Spiral_wasm::US2::US2_1
                        };
                        match &v18 {
                            Spiral_wasm::US2::US2_0(v18_0_0) => {
                                Spiral_wasm::US2::US2_0(match &v18 {
                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v26: Spiral_wasm::US2 = if string("Info") == v4.clone() {
                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_2)
                                } else {
                                    Spiral_wasm::US2::US2_1
                                };
                                match &v26 {
                                    Spiral_wasm::US2::US2_0(v26_0_0) => {
                                        Spiral_wasm::US2::US2_0(match &v26 {
                                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v34: Spiral_wasm::US2 =
                                            if string("Warning") == v4.clone() {
                                                Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_3)
                                            } else {
                                                Spiral_wasm::US2::US2_1
                                            };
                                        match &v34 {
                                            Spiral_wasm::US2::US2_0(v34_0_0) => {
                                                Spiral_wasm::US2::US2_0(match &v34 {
                                                    Spiral_wasm::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v42: Spiral_wasm::US2 = if string("Critical")
                                                    == v4.clone()
                                                {
                                                    Spiral_wasm::US2::US2_0(Spiral_wasm::US0::US0_4)
                                                } else {
                                                    Spiral_wasm::US2::US2_1
                                                };
                                                match &v42 {
                                                    Spiral_wasm::US2::US2_0(v42_0_0) => {
                                                        Spiral_wasm::US2::US2_0(match &v42 {
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
                if Spiral_wasm::method1(Spiral_wasm::method3()) == string("True") {
                    Spiral_wasm::US3::US3_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Spiral_wasm::US3::US3_1
                },
            );
            let v400: Spiral_wasm::US3 = result.1.clone();
            let v399: Spiral_wasm::US2 = result.0.clone();
            (
                LrcPtr::new(Spiral_wasm::Mut0 {
                    l0: MutCell::new(0_i64),
                }),
                LrcPtr::new(Spiral_wasm::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Spiral_wasm::closure3((), v))),
                }),
                LrcPtr::new(Spiral_wasm::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Spiral_wasm::Mut3 {
                    l0: MutCell::new(match &v399 {
                        Spiral_wasm::US2::US2_0(v399_0_0) => match &v399 {
                            Spiral_wasm::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v400 {
                    Spiral_wasm::US3::US3_0(v400_0_0) => Some(match &v400 {
                        Spiral_wasm::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn method4() -> string {
            string("hh:mm:ss")
        }
        pub fn method5() -> string {
            string("HH:mm:ss")
        }
        pub fn method6() -> string {
            string("\u{001b}[0m")
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_wasm.main")
        }
        pub fn method7() -> clap::Command {
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
        pub fn method9() -> string {
            string("wasm")
        }
        pub fn closure5(unitVar: (), unitVar_1: ()) -> string {
            string("run")
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure7(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure9(unitVar: (), v0_1: std::string::String) {
            printfn!("{0}", v0_1);
            ()
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method10(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure11(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method11(
            v0_1: near_workspaces::result::ExecutionFinalResult,
        ) -> near_workspaces::result::ExecutionFinalResult {
            v0_1
        }
        pub fn closure12(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure13(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure14(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method12(v0_1: Result<(), anyhow::Error>) -> Result<(), anyhow::Error> {
            v0_1
        }
        pub fn method8(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<(), anyhow::Error>>>>
        {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: string = Spiral_wasm::method9();
                    let v4: &str = &*v2;
                    let v6: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v0_1, v4).cloned();
                    let _v9: LrcPtr<MutCell<Option<Spiral_wasm::US4>>> =
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
                        _v9.set(x_2)
                    }
                    {
                        let v37: Spiral_wasm::US4 =
                            defaultValue(Spiral_wasm::US4::US4_1, _v9.get().clone());
                        let v48: std::string::String = match &v37 {
                            Spiral_wasm::US4::US4_0(v37_0_0) => match &v37 {
                                Spiral_wasm::US4::US4_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v50: string = fable_library_rust::String_::fromString(v48);
                        fn v53(
                            v: Spiral_wasm::US0,
                        ) -> (
                            LrcPtr<Spiral_wasm::Mut0>,
                            LrcPtr<Spiral_wasm::Mut1>,
                            LrcPtr<Spiral_wasm::Mut2>,
                            LrcPtr<Spiral_wasm::Mut3>,
                            Option<i64>,
                        ) {
                            Spiral_wasm::closure2((), v)
                        }
                        if Spiral_wasm::State::trace_state().get().clone().is_none() {
                            Spiral_wasm::State::trace_state()
                                .set(Some(v53(Spiral_wasm::US0::US0_0)));
                        }
                        {
                            let patternInput: (
                                LrcPtr<Spiral_wasm::Mut0>,
                                LrcPtr<Spiral_wasm::Mut1>,
                                LrcPtr<Spiral_wasm::Mut2>,
                                LrcPtr<Spiral_wasm::Mut3>,
                                Option<i64>,
                            ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                            let v62: LrcPtr<Spiral_wasm::Mut0> = patternInput.0.clone();
                            if Spiral_wasm::State::trace_state().get().clone().is_none() {
                                Spiral_wasm::State::trace_state()
                                    .set(Some(v53(Spiral_wasm::US0::US0_0)));
                            }
                            {
                                let patternInput_1: (
                                    LrcPtr<Spiral_wasm::Mut0>,
                                    LrcPtr<Spiral_wasm::Mut1>,
                                    LrcPtr<Spiral_wasm::Mut2>,
                                    LrcPtr<Spiral_wasm::Mut3>,
                                    Option<i64>,
                                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                                let v110: Spiral_wasm::US0 =
                                    (patternInput_1.3.clone()).l0.get().clone();
                                if if (patternInput_1.2.clone()).l0.get().clone() == false {
                                    false
                                } else {
                                    1_i32
                                        >= find(
                                            v110,
                                            ofSeq(ofList(ofArray(new_array(&[
                                                LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                                                LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                                                LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                                                LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                                                LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                                            ])))),
                                        )
                                } {
                                    let v117: i64 = v62.l0.get().clone() + 1_i64;
                                    v62.l0.set(v117);
                                    if Spiral_wasm::State::trace_state().get().clone().is_none() {
                                        Spiral_wasm::State::trace_state()
                                            .set(Some(v53(Spiral_wasm::US0::US0_0)));
                                    }
                                    {
                                        let patternInput_2: (
                                            LrcPtr<Spiral_wasm::Mut0>,
                                            LrcPtr<Spiral_wasm::Mut1>,
                                            LrcPtr<Spiral_wasm::Mut2>,
                                            LrcPtr<Spiral_wasm::Mut3>,
                                            Option<i64>,
                                        ) = getValue(
                                            Spiral_wasm::State::trace_state().get().clone(),
                                        );
                                        let v132: Option<i64> = patternInput_2.4.clone();
                                        let _v151: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                            refCell(None::<Spiral_wasm::US3>);
                                        {
                                            let x_5: Option<Spiral_wasm::US3> = match &v132 {
                                                None => None::<Spiral_wasm::US3>,
                                                Some(v132_0_0) => {
                                                    let x_3: i64 = v132_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_3 = x_3.clone();
                                                        move || Spiral_wasm::US3::US3_0(x_3)
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v151.set(x_5)
                                        }
                                        {
                                            let v179: Spiral_wasm::US3 = defaultValue(
                                                Spiral_wasm::US3::US3_1,
                                                _v151.get().clone(),
                                            );
                                            let v277: DateTime = match &v179 {
                                                Spiral_wasm::US3::US3_0(v179_0_0) => {
                                                    let v211: TimeSpan = TimeSpan::new_ticks(
                                                        {
                                                            let _arg: DateTime = DateTime::now();
                                                            _arg.ticks()
                                                        } - match &v179 {
                                                            Spiral_wasm::US3::US3_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                    );
                                                    DateTime::new_ymdhms_milli(
                                                        1_i32,
                                                        1_i32,
                                                        1_i32,
                                                        v211.hours(),
                                                        v211.minutes(),
                                                        v211.seconds(),
                                                        v211.milliseconds(),
                                                    )
                                                }
                                                _ => DateTime::now(),
                                            };
                                            let v290: string = {
                                                let provider: string = Spiral_wasm::method4();
                                                v277.toString(provider)
                                            };
                                            let v1118: string =
                                                padLeft(toLower(string("Debug")), 7_i32, ' ');
                                            let v1151: &str =
                                                inline_colorization::color_bright_blue;
                                            let v1153: &str = &*v1118;
                                            let v1155: &str = inline_colorization::color_reset;
                                            let v1157: string =
                                                string("format!(\"{v1151}{v1153}{v1155}\")");
                                            let v1158: std::string::String =
                                                format!("{v1151}{v1153}{v1155}");
                                            let v1160: string =
                                                fable_library_rust::String_::fromString(v1158);
                                            let v1205: i64 =
                                                (patternInput_2.0.clone()).l0.get().clone();
                                            let v1207: LrcPtr<Spiral_wasm::Mut4> =
                                                LrcPtr::new(Spiral_wasm::Mut4 {
                                                    l0: MutCell::new(string("")),
                                                });
                                            let v1211: string = sprintf!("{}", string("{ "));
                                            let v1219: string =
                                                append(v1207.l0.get().clone(), v1211);
                                            v1207.l0.set(v1219);
                                            {
                                                let v1223: string =
                                                    sprintf!("{}", string("wasm_path"));
                                                let v1231: string =
                                                    append(v1207.l0.get().clone(), v1223);
                                                v1207.l0.set(v1231);
                                                {
                                                    let v1235: string =
                                                        sprintf!("{}", string(" = "));
                                                    let v1243: string =
                                                        append(v1207.l0.get().clone(), v1235);
                                                    v1207.l0.set(v1243);
                                                    {
                                                        let v1246: string =
                                                            sprintf!("{}", v50.clone());
                                                        let v1254: string =
                                                            append(v1207.l0.get().clone(), v1246);
                                                        v1207.l0.set(v1254);
                                                        {
                                                            let v1258: string =
                                                                sprintf!("{}", string(" }"));
                                                            let v1266: string = append(
                                                                v1207.l0.get().clone(),
                                                                v1258,
                                                            );
                                                            v1207.l0.set(v1266);
                                                            {
                                                                let v1267: string =
                                                                    v1207.l0.get().clone();
                                                                let v1361: string = trimEndChars(
                                                                    trimStartChars(
                                                                        sprintf!(
                                                                            "{} {} #{} {} / {}",
                                                                            v290,
                                                                            v1160,
                                                                            v1205,
                                                                            Spiral_wasm::closure5(
                                                                                (),
                                                                                ()
                                                                            ),
                                                                            v1267
                                                                        ),
                                                                        toArray(empty::<char>()),
                                                                    ),
                                                                    toArray(ofArray(new_array(&[
                                                                        ' ', '/',
                                                                    ]))),
                                                                );
                                                                println!("{}", v1361.clone());
                                                                ();
                                                                ((patternInput.1.clone())
                                                                    .l0
                                                                    .get()
                                                                    .clone())(
                                                                    v1361
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
                                    let v1435: Result<Vec<u8>, std::io::Error> =
                                        std::fs::read(&*v50);
                                    let v1437: Vec<u8> = v1435?;
                                    let v1439: Result<
                                        near_workspaces::Worker<near_workspaces::network::Sandbox>,
                                        near_workspaces::error::Error,
                                    > = near_workspaces::sandbox().await;
                                    let v1441: near_workspaces::Worker<
                                        near_workspaces::network::Sandbox,
                                    > = v1439?;
                                    if Spiral_wasm::State::trace_state().get().clone().is_none() {
                                        Spiral_wasm::State::trace_state()
                                            .set(Some(v53(Spiral_wasm::US0::US0_0)));
                                    }
                                    {
                                        let patternInput_3: (
                                            LrcPtr<Spiral_wasm::Mut0>,
                                            LrcPtr<Spiral_wasm::Mut1>,
                                            LrcPtr<Spiral_wasm::Mut2>,
                                            LrcPtr<Spiral_wasm::Mut3>,
                                            Option<i64>,
                                        ) = getValue(
                                            Spiral_wasm::State::trace_state().get().clone(),
                                        );
                                        let v1452: LrcPtr<Spiral_wasm::Mut0> =
                                            patternInput_3.0.clone();
                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                        {
                                            Spiral_wasm::State::trace_state()
                                                .set(Some(v53(Spiral_wasm::US0::US0_0)));
                                        }
                                        {
                                            let patternInput_4: (
                                                LrcPtr<Spiral_wasm::Mut0>,
                                                LrcPtr<Spiral_wasm::Mut1>,
                                                LrcPtr<Spiral_wasm::Mut2>,
                                                LrcPtr<Spiral_wasm::Mut3>,
                                                Option<i64>,
                                            ) = getValue(
                                                Spiral_wasm::State::trace_state().get().clone(),
                                            );
                                            let v1500: Spiral_wasm::US0 =
                                                (patternInput_4.3.clone()).l0.get().clone();
                                            if if (patternInput_4.2.clone()).l0.get().clone()
                                                == false
                                            {
                                                false
                                            } else {
                                                1_i32
                                                    >= find(
                                                        v1500,
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
                                                let v1507: i64 = v1452.l0.get().clone() + 1_i64;
                                                v1452.l0.set(v1507);
                                                if Spiral_wasm::State::trace_state()
                                                    .get()
                                                    .clone()
                                                    .is_none()
                                                {
                                                    Spiral_wasm::State::trace_state()
                                                        .set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                }
                                                {
                                                    let patternInput_5: (
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
                                                    let v1522: Option<i64> =
                                                        patternInput_5.4.clone();
                                                    let _v1541: LrcPtr<
                                                        MutCell<Option<Spiral_wasm::US3>>,
                                                    > = refCell(None::<Spiral_wasm::US3>);
                                                    {
                                                        let x_8: Option<Spiral_wasm::US3> =
                                                            match &v1522 {
                                                                None => None::<Spiral_wasm::US3>,
                                                                Some(v1522_0_0) => {
                                                                    let x_6: i64 =
                                                                        v1522_0_0.clone();
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
                                                        _v1541.set(x_8)
                                                    }
                                                    {
                                                        let v1569: Spiral_wasm::US3 = defaultValue(
                                                            Spiral_wasm::US3::US3_1,
                                                            _v1541.get().clone(),
                                                        );
                                                        let v1667: DateTime = match &v1569 {
                                                            Spiral_wasm::US3::US3_0(v1569_0_0) => {
                                                                let v1601:
                                                                        TimeSpan =
                                                                    TimeSpan::new_ticks({
                                                                                            let _arg_5:
                                                                                                    DateTime =
                                                                                                DateTime::now();
                                                                                            _arg_5.ticks()
                                                                                        }
                                                                                            -
                                                                                            match &v1569
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
                                                                    v1601.hours(),
                                                                    v1601.minutes(),
                                                                    v1601.seconds(),
                                                                    v1601.milliseconds(),
                                                                )
                                                            }
                                                            _ => DateTime::now(),
                                                        };
                                                        let v1680: string = {
                                                            let provider_1: string =
                                                                Spiral_wasm::method4();
                                                            v1667.toString(provider_1)
                                                        };
                                                        let v2508: string = padLeft(
                                                            toLower(string("Debug")),
                                                            7_i32,
                                                            ' ',
                                                        );
                                                        let v2541: &str =
                                                            inline_colorization::color_bright_blue;
                                                        let v2543: &str = &*v2508;
                                                        let v2545: &str =
                                                            inline_colorization::color_reset;
                                                        let v2547: string = string(
                                                            "format!(\"{v2541}{v2543}{v2545}\")",
                                                        );
                                                        let v2548: std::string::String =
                                                            format!("{v2541}{v2543}{v2545}");
                                                        let v2550: string =
                                                            fable_library_rust::String_::fromString(
                                                                v2548,
                                                            );
                                                        let v2595: i64 = (patternInput_5.0.clone())
                                                            .l0
                                                            .get()
                                                            .clone();
                                                        let v2597: LrcPtr<Spiral_wasm::Mut4> =
                                                            LrcPtr::new(Spiral_wasm::Mut4 {
                                                                l0: MutCell::new(string("")),
                                                            });
                                                        let v2601: string =
                                                            sprintf!("{}", string("{ "));
                                                        let v2609: string =
                                                            append(v2597.l0.get().clone(), v2601);
                                                        v2597.l0.set(v2609);
                                                        {
                                                            let v2613: string =
                                                                sprintf!("{}", string("worker"));
                                                            let v2621: string = append(
                                                                v2597.l0.get().clone(),
                                                                v2613,
                                                            );
                                                            v2597.l0.set(v2621);
                                                            {
                                                                let v2625: string =
                                                                    sprintf!("{}", string(" = "));
                                                                let v2633: string = append(
                                                                    v2597.l0.get().clone(),
                                                                    v2625,
                                                                );
                                                                v2597.l0.set(v2633);
                                                                {
                                                                    let v2637: std::string::String =
                                                                        format!("{:#?}", v1441);
                                                                    let v2692:
                                                                        string =
                                                                    sprintf!("{}",
                                                                             fable_library_rust::String_::fromString(v2637));
                                                                    let v2700: string = append(
                                                                        v2597.l0.get().clone(),
                                                                        v2692,
                                                                    );
                                                                    v2597.l0.set(v2700);
                                                                    {
                                                                        let v2704: string = sprintf!(
                                                                            "{}",
                                                                            string(" }")
                                                                        );
                                                                        let v2712: string = append(
                                                                            v2597.l0.get().clone(),
                                                                            v2704,
                                                                        );
                                                                        v2597.l0.set(v2712);
                                                                        {
                                                                            let v2713: string =
                                                                                v2597
                                                                                    .l0
                                                                                    .get()
                                                                                    .clone();
                                                                            let v2807:
                                                                                string =
                                                                            trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                 v1680,
                                                                                                                 v2550,
                                                                                                                 v2595,
                                                                                                                 Spiral_wasm::closure6((),
                                                                                                                                       ()),
                                                                                                                 v2713),
                                                                                                        toArray(empty::<char>())),
                                                                                         toArray(ofArray(new_array(&[' ',
                                                                                                                     '/']))));
                                                                            println!(
                                                                                "{}",
                                                                                v2807.clone()
                                                                            );
                                                                            ();
                                                                            ((patternInput_3
                                                                                .1
                                                                                .clone())
                                                                            .l0
                                                                            .get()
                                                                            .clone())(
                                                                                v2807
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
                                                let v2881: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Result<
                                                                near_workspaces::Contract,
                                                                near_workspaces::error::Error,
                                                            >,
                                                        >,
                                                    >,
                                                > = Box::pin(v1441.dev_deploy(&v1437));
                                                let v2883: Result<
                                                    near_workspaces::Contract,
                                                    near_workspaces::error::Error,
                                                > = v2881.await;
                                                let v2885: near_workspaces::Contract = v2883?;
                                                if Spiral_wasm::State::trace_state()
                                                    .get()
                                                    .clone()
                                                    .is_none()
                                                {
                                                    Spiral_wasm::State::trace_state()
                                                        .set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                }
                                                {
                                                    let patternInput_6: (
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
                                                    let v2896: LrcPtr<Spiral_wasm::Mut0> =
                                                        patternInput_6.0.clone();
                                                    if Spiral_wasm::State::trace_state()
                                                        .get()
                                                        .clone()
                                                        .is_none()
                                                    {
                                                        Spiral_wasm::State::trace_state().set(
                                                            Some(v53(Spiral_wasm::US0::US0_0)),
                                                        );
                                                    }
                                                    {
                                                        let patternInput_7: (
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
                                                        let v2944: Spiral_wasm::US0 =
                                                            (patternInput_7.3.clone())
                                                                .l0
                                                                .get()
                                                                .clone();
                                                        if if (patternInput_7.2.clone())
                                                            .l0
                                                            .get()
                                                            .clone()
                                                            == false
                                                        {
                                                            false
                                                        } else {
                                                            1_i32 >=
                                                               find(v2944,
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
                                                            let v2951: i64 =
                                                                v2896.l0.get().clone() + 1_i64;
                                                            v2896.l0.set(v2951);
                                                            if Spiral_wasm::State::trace_state()
                                                                .get()
                                                                .clone()
                                                                .is_none()
                                                            {
                                                                Spiral_wasm::State::trace_state()
                                                                    .set(Some(v53(
                                                                        Spiral_wasm::US0::US0_0,
                                                                    )));
                                                            }
                                                            {
                                                                let patternInput_8:
                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                     Option<i64>) =
                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                let v2966: Option<i64> =
                                                                    patternInput_8.4.clone();
                                                                let _v2985: LrcPtr<
                                                                    MutCell<
                                                                        Option<Spiral_wasm::US3>,
                                                                    >,
                                                                > = refCell(
                                                                    None::<Spiral_wasm::US3>,
                                                                );
                                                                {
                                                                    let x_11: Option<
                                                                        Spiral_wasm::US3,
                                                                    > = match &v2966 {
                                                                        None => {
                                                                            None::<Spiral_wasm::US3>
                                                                        }
                                                                        Some(v2966_0_0) => {
                                                                            let x_9: i64 =
                                                                                v2966_0_0.clone();
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
                                                                    _v2985.set(x_11)
                                                                }
                                                                {
                                                                    let v3013: Spiral_wasm::US3 =
                                                                        defaultValue(
                                                                            Spiral_wasm::US3::US3_1,
                                                                            _v2985.get().clone(),
                                                                        );
                                                                    let v3111:
                                                                        DateTime =
                                                                    match &v3013
                                                                        {
                                                                        Spiral_wasm::US3::US3_0(v3013_0_0)
                                                                        => {
                                                                            let v3045:
                                                                                    TimeSpan =
                                                                                TimeSpan::new_ticks({
                                                                                                        let _arg_10:
                                                                                                                DateTime =
                                                                                                            DateTime::now();
                                                                                                        _arg_10.ticks()
                                                                                                    }
                                                                                                        -
                                                                                                        match &v3013
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
                                                                                                       v3045.hours(),
                                                                                                       v3045.minutes(),
                                                                                                       v3045.seconds(),
                                                                                                       v3045.milliseconds())
                                                                        }
                                                                        _ =>
                                                                        DateTime::now(),
                                                                    };
                                                                    let v3124: string = {
                                                                        let provider_2: string =
                                                                            Spiral_wasm::method4();
                                                                        v3111.toString(provider_2)
                                                                    };
                                                                    let v3952: string = padLeft(
                                                                        toLower(string("Debug")),
                                                                        7_i32,
                                                                        ' ',
                                                                    );
                                                                    let v3985:
                                                                        &str =
                                                                    inline_colorization::color_bright_blue;
                                                                    let v3987: &str = &*v3952;
                                                                    let v3989:
                                                                        &str =
                                                                    inline_colorization::color_reset;
                                                                    let v3991:
                                                                        string =
                                                                    string("format!(\"{v3985}{v3987}{v3989}\")");
                                                                    let v3992: std::string::String = format!(
                                                                        "{v3985}{v3987}{v3989}"
                                                                    );
                                                                    let v3994:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v3992);
                                                                    let v4039: i64 =
                                                                        (patternInput_8.0.clone())
                                                                            .l0
                                                                            .get()
                                                                            .clone();
                                                                    let v4041: LrcPtr<
                                                                        Spiral_wasm::Mut4,
                                                                    > = LrcPtr::new(
                                                                        Spiral_wasm::Mut4 {
                                                                            l0: MutCell::new(
                                                                                string(""),
                                                                            ),
                                                                        },
                                                                    );
                                                                    let v4045: string = sprintf!(
                                                                        "{}",
                                                                        string("{ ")
                                                                    );
                                                                    let v4053: string = append(
                                                                        v4041.l0.get().clone(),
                                                                        v4045,
                                                                    );
                                                                    v4041.l0.set(v4053);
                                                                    {
                                                                        let v4057: string = sprintf!(
                                                                            "{}",
                                                                            string("contract")
                                                                        );
                                                                        let v4065: string = append(
                                                                            v4041.l0.get().clone(),
                                                                            v4057,
                                                                        );
                                                                        v4041.l0.set(v4065);
                                                                        {
                                                                            let v4069: string = sprintf!(
                                                                                "{}",
                                                                                string(" = ")
                                                                            );
                                                                            let v4077: string =
                                                                                append(
                                                                                    v4041
                                                                                        .l0
                                                                                        .get()
                                                                                        .clone(),
                                                                                    v4069,
                                                                                );
                                                                            v4041.l0.set(v4077);
                                                                            {
                                                                                let v4081:
                                                                                    std::string::String =
                                                                                format!("{:#?}", v2885);
                                                                                let v4136:
                                                                                    string =
                                                                                sprintf!("{}",
                                                                                         fable_library_rust::String_::fromString(v4081));
                                                                                let v4144: string =
                                                                                    append(
                                                                                        v4041
                                                                                            .l0
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                        v4136,
                                                                                    );
                                                                                v4041.l0.set(v4144);
                                                                                {
                                                                                    let v4148:
                                                                                        string =
                                                                                    sprintf!("{}",
                                                                                             string(" }"));
                                                                                    let v4156:
                                                                                        string =
                                                                                    append(v4041.l0.get().clone(),
                                                                                           v4148);
                                                                                    v4041
                                                                                        .l0
                                                                                        .set(v4156);
                                                                                    {
                                                                                        let v4157:
                                                                                            string =
                                                                                        v4041.l0.get().clone();
                                                                                        let v4251:
                                                                                            string =
                                                                                        trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                             v3124,
                                                                                                                             v3994,
                                                                                                                             v4039,
                                                                                                                             Spiral_wasm::closure7((),
                                                                                                                                                   ()),
                                                                                                                             v4157),
                                                                                                                    toArray(empty::<char>())),
                                                                                                     toArray(ofArray(new_array(&[' ',
                                                                                                                                 '/']))));
                                                                                        println!("{}", v4251.clone());
                                                                                        ();
                                                                                        ((patternInput_6.1.clone()).l0.get().clone())(v4251)
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        {
                                                            let v4326:
                                                                near_workspaces::operations::CallTransaction =
                                                            v2885.call(&*string("state_main"));
                                                            let v4328:
                                                                std::pin::Pin<Box<dyn std::future::Future<Output = Result<near_workspaces::result::ExecutionFinalResult,
                                                                                                                          near_workspaces::error::Error>>>> =
                                                            Box::pin(v4326.transact());
                                                            let v4330:
                                                                Result<near_workspaces::result::ExecutionFinalResult,
                                                                       near_workspaces::error::Error> =
                                                            v4328.await;
                                                            let v4332:
                                                                near_workspaces::result::ExecutionFinalResult =
                                                            v4330?;
                                                            if Spiral_wasm::State::trace_state()
                                                                .get()
                                                                .clone()
                                                                .is_none()
                                                            {
                                                                Spiral_wasm::State::trace_state()
                                                                    .set(Some(v53(
                                                                        Spiral_wasm::US0::US0_0,
                                                                    )));
                                                            }
                                                            {
                                                                let patternInput_9:
                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                     Option<i64>) =
                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                let v4343: LrcPtr<
                                                                    Spiral_wasm::Mut0,
                                                                > = patternInput_9.0.clone();
                                                                if Spiral_wasm::State::trace_state()
                                                                    .get()
                                                                    .clone()
                                                                    .is_none()
                                                                {
                                                                    Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                }
                                                                {
                                                                    let patternInput_10:
                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                         Option<i64>) =
                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                    let v4391: Spiral_wasm::US0 =
                                                                        (patternInput_10.3.clone())
                                                                            .l0
                                                                            .get()
                                                                            .clone();
                                                                    if if (patternInput_10
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
                                                                           find(v4391,
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
                                                                        let v4398: i64 =
                                                                            v4343.l0.get().clone()
                                                                                + 1_i64;
                                                                        v4343.l0.set(v4398);
                                                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                       {
                                                                        Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                    }
                                                                        {
                                                                            let patternInput_11:
                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                 Option<i64>) =
                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                            let v4413: Option<i64> =
                                                                                patternInput_11
                                                                                    .4
                                                                                    .clone();
                                                                            let _v4432:
                                                                                LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                            refCell(None::<Spiral_wasm::US3>);
                                                                            {
                                                                                let x_14:
                                                                                    Option<Spiral_wasm::US3> =
                                                                                match &v4413
                                                                                    {
                                                                                    None
                                                                                    =>
                                                                                    None::<Spiral_wasm::US3>,
                                                                                    Some(v4413_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let x_12:
                                                                                                i64 =
                                                                                            v4413_0_0.clone();
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
                                                                                _v4432.set(x_14)
                                                                            }
                                                                            {
                                                                                let v4460:
                                                                                    Spiral_wasm::US3 =
                                                                                defaultValue(Spiral_wasm::US3::US3_1,
                                                                                             _v4432.get().clone());
                                                                                let v4558:
                                                                                    DateTime =
                                                                                match &v4460
                                                                                    {
                                                                                    Spiral_wasm::US3::US3_0(v4460_0_0)
                                                                                    =>
                                                                                    {
                                                                                        let v4492:
                                                                                                TimeSpan =
                                                                                            TimeSpan::new_ticks({
                                                                                                                    let _arg_15:
                                                                                                                            DateTime =
                                                                                                                        DateTime::now();
                                                                                                                    _arg_15.ticks()
                                                                                                                }
                                                                                                                    -
                                                                                                                    match &v4460
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
                                                                                                                   v4492.hours(),
                                                                                                                   v4492.minutes(),
                                                                                                                   v4492.seconds(),
                                                                                                                   v4492.milliseconds())
                                                                                    }
                                                                                    _
                                                                                    =>
                                                                                    DateTime::now(),
                                                                                };
                                                                                let v4571: string = {
                                                                                    let provider_3:
                                                                                            string =
                                                                                        Spiral_wasm::method4();
                                                                                    v4558.toString(
                                                                                        provider_3,
                                                                                    )
                                                                                };
                                                                                let v5399:
                                                                                    string =
                                                                                padLeft(toLower(string("Debug")),
                                                                                        7_i32,
                                                                                        ' ');
                                                                                let v5432:
                                                                                    &str =
                                                                                inline_colorization::color_bright_blue;
                                                                                let v5434: &str =
                                                                                    &*v5399;
                                                                                let v5436:
                                                                                    &str =
                                                                                inline_colorization::color_reset;
                                                                                let v5438:
                                                                                    string =
                                                                                string("format!(\"{v5432}{v5434}{v5436}\")");
                                                                                let v5439:
                                                                                    std::string::String =
                                                                                format!("{v5432}{v5434}{v5436}");
                                                                                let v5441:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v5439);
                                                                                let v5486:
                                                                                    i64 =
                                                                                (patternInput_11.0.clone()).l0.get().clone();
                                                                                let v5488:
                                                                                    LrcPtr<Spiral_wasm::Mut4> =
                                                                                LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                  MutCell::new(string("")),});
                                                                                let v5492: string = sprintf!(
                                                                                    "{}",
                                                                                    string("{ ")
                                                                                );
                                                                                let v5500: string =
                                                                                    append(
                                                                                        v5488
                                                                                            .l0
                                                                                            .get()
                                                                                            .clone(
                                                                                            ),
                                                                                        v5492,
                                                                                    );
                                                                                v5488.l0.set(v5500);
                                                                                {
                                                                                    let v5504:
                                                                                        string =
                                                                                    sprintf!("{}",
                                                                                             string("result"));
                                                                                    let v5512:
                                                                                        string =
                                                                                    append(v5488.l0.get().clone(),
                                                                                           v5504);
                                                                                    v5488
                                                                                        .l0
                                                                                        .set(v5512);
                                                                                    {
                                                                                        let v5516:
                                                                                            string =
                                                                                        sprintf!("{}",
                                                                                                 string(" = "));
                                                                                        let v5524:
                                                                                            string =
                                                                                        append(v5488.l0.get().clone(),
                                                                                               v5516);
                                                                                        v5488
                                                                                            .l0
                                                                                            .set(
                                                                                            v5524,
                                                                                        );
                                                                                        {
                                                                                            let v5528:
                                                                                                std::string::String =
                                                                                            format!("{:#?}", v4332.clone());
                                                                                            let v5583:
                                                                                                string =
                                                                                            sprintf!("{}",
                                                                                                     fable_library_rust::String_::fromString(v5528));
                                                                                            let v5591:
                                                                                                string =
                                                                                            append(v5488.l0.get().clone(),
                                                                                                   v5583);
                                                                                            v5488.l0.set(v5591);
                                                                                            {
                                                                                                let v5595:
                                                                                                    string =
                                                                                                sprintf!("{}",
                                                                                                         string(" }"));
                                                                                                let v5603:
                                                                                                    string =
                                                                                                append(v5488.l0.get().clone(),
                                                                                                       v5595);
                                                                                                v5488.l0.set(v5603);
                                                                                                {
                                                                                                    let v5604:
                                                                                                        string =
                                                                                                    v5488.l0.get().clone();
                                                                                                    let v5698:
                                                                                                        string =
                                                                                                    trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                         v4571,
                                                                                                                                         v5441,
                                                                                                                                         v5486,
                                                                                                                                         Spiral_wasm::closure8((),
                                                                                                                                                               ()),
                                                                                                                                         v5604),
                                                                                                                                toArray(empty::<char>())),
                                                                                                                 toArray(ofArray(new_array(&[' ',
                                                                                                                                             '/']))));
                                                                                                    println!("{}", v5698.clone());
                                                                                                    ();
                                                                                                    ((patternInput_9.1.clone()).l0.get().clone())(v5698)
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                    {
                                                                        let v5772: Vec<&str> =
                                                                            v4332.logs();
                                                                        let v5774: bool = true;
                                                                        let _result: Vec<_> = v5772
                                                                            .into_iter()
                                                                            .map(|x| {
                                                                                //;
                                                                                let v5776: &str = x;
                                                                                let v5778:
                                                                            std::string::String =
                                                                        String::from(v5776);
                                                                                let v5780: bool =
                                                                                    true;
                                                                                v5778
                                                                            })
                                                                            .collect::<Vec<_>>();
                                                                        let v5782: Vec<
                                                                            std::string::String,
                                                                        > = _result;
                                                                        v5782.iter().for_each(|x| { Func1::new(move
                                                                                                               |v_1:
                                                                                                                    std::string::String|
                                                                                                               Spiral_wasm::closure9((),
                                                                                                                                     v_1))(x.clone()); });
                                                                        println!("\n\n state_main transact result: {:#?}", v4332.clone()); //;
                                                                        println!("\n\n print_usd:"); //;
                                                                        print_usd(v4332.clone()); //;
                                                                        {
                                                                            let v5789:
                                                                                Result<near_workspaces::result::ExecutionResult<near_workspaces::result::Value>,
                                                                                       near_workspaces::result::ExecutionResult<near_primitives::errors::TxExecutionError>> =
                                                                            v4332.clone().into_result();
                                                                            if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                           {
                                                                            Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                        }
                                                                            {
                                                                                let patternInput_12:
                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                     Option<i64>) =
                                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                let v5800:
                                                                                    LrcPtr<Spiral_wasm::Mut0> =
                                                                                patternInput_12.0.clone();
                                                                                if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                               {
                                                                                Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                            }
                                                                                {
                                                                                    let patternInput_13:
                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                         Option<i64>) =
                                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                    let v5848:
                                                                                        Spiral_wasm::US0 =
                                                                                    (patternInput_13.3.clone()).l0.get().clone();
                                                                                    if if (patternInput_13.2.clone()).l0.get().clone()
                                                                                          ==
                                                                                          false
                                                                                      {
                                                                                       false
                                                                                   } else {
                                                                                       1_i32
                                                                                           >=
                                                                                           find(v5848,
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
                                                                                    let v5855:
                                                                                            i64 =
                                                                                        v5800.l0.get().clone()
                                                                                            +
                                                                                            1_i64;
                                                                                    v5800.l0.set(v5855);
                                                                                    if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                       {
                                                                                        Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                    }
                                                                                    {
                                                                                        let patternInput_14:
                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                 Option<i64>) =
                                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                        let v5870:
                                                                                                Option<i64> =
                                                                                            patternInput_14.4.clone();
                                                                                        let _v5889:
                                                                                                LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                            refCell(None::<Spiral_wasm::US3>);
                                                                                        {
                                                                                            let x_17:
                                                                                                    Option<Spiral_wasm::US3> =
                                                                                                match &v5870
                                                                                                    {
                                                                                                    None
                                                                                                    =>
                                                                                                    None::<Spiral_wasm::US3>,
                                                                                                    Some(v5870_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let x_15:
                                                                                                                i64 =
                                                                                                            v5870_0_0.clone();
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
                                                                                            _v5889.set(x_17)
                                                                                        }
                                                                                        {
                                                                                            let v5917:
                                                                                                    Spiral_wasm::US3 =
                                                                                                defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                             _v5889.get().clone());
                                                                                            let v6015:
                                                                                                    DateTime =
                                                                                                match &v5917
                                                                                                    {
                                                                                                    Spiral_wasm::US3::US3_0(v5917_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let v5949:
                                                                                                                TimeSpan =
                                                                                                            TimeSpan::new_ticks({
                                                                                                                                    let _arg_20:
                                                                                                                                            DateTime =
                                                                                                                                        DateTime::now();
                                                                                                                                    _arg_20.ticks()
                                                                                                                                }
                                                                                                                                    -
                                                                                                                                    match &v5917
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
                                                                                                                                   v5949.hours(),
                                                                                                                                   v5949.minutes(),
                                                                                                                                   v5949.seconds(),
                                                                                                                                   v5949.milliseconds())
                                                                                                    }
                                                                                                    _
                                                                                                    =>
                                                                                                    DateTime::now(),
                                                                                                };
                                                                                            let v6028:
                                                                                                    string =
                                                                                                {
                                                                                                    let provider_4:
                                                                                                            string =
                                                                                                        Spiral_wasm::method4();
                                                                                                    v6015.toString(provider_4)
                                                                                                };
                                                                                            let v6856:
                                                                                                    string =
                                                                                                padLeft(toLower(string("Debug")),
                                                                                                        7_i32,
                                                                                                        ' ');
                                                                                            let v6889:
                                                                                                    &str =
                                                                                                inline_colorization::color_bright_blue;
                                                                                            let v6891:
                                                                                                    &str =
                                                                                                &*v6856;
                                                                                            let v6893:
                                                                                                    &str =
                                                                                                inline_colorization::color_reset;
                                                                                            let v6895:
                                                                                                    string =
                                                                                                string("format!(\"{v6889}{v6891}{v6893}\")");
                                                                                            let v6896:
                                                                                                    std::string::String =
                                                                                                format!("{v6889}{v6891}{v6893}");
                                                                                            let v6898:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromString(v6896);
                                                                                            let v6943:
                                                                                                    i64 =
                                                                                                (patternInput_14.0.clone()).l0.get().clone();
                                                                                            let v6945:
                                                                                                    LrcPtr<Spiral_wasm::Mut4> =
                                                                                                LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                  MutCell::new(string("")),});
                                                                                            let v6949:
                                                                                                    string =
                                                                                                sprintf!("{}",
                                                                                                         string("{ "));
                                                                                            let v6957:
                                                                                                    string =
                                                                                                append(v6945.l0.get().clone(),
                                                                                                       v6949);
                                                                                            v6945.l0.set(v6957);
                                                                                            {
                                                                                                let v6961:
                                                                                                        string =
                                                                                                    sprintf!("{}",
                                                                                                             string("result2"));
                                                                                                let v6969:
                                                                                                        string =
                                                                                                    append(v6945.l0.get().clone(),
                                                                                                           v6961);
                                                                                                v6945.l0.set(v6969);
                                                                                                {
                                                                                                    let v6973:
                                                                                                            string =
                                                                                                        sprintf!("{}",
                                                                                                                 string(" = "));
                                                                                                    let v6981:
                                                                                                            string =
                                                                                                        append(v6945.l0.get().clone(),
                                                                                                               v6973);
                                                                                                    v6945.l0.set(v6981);
                                                                                                    {
                                                                                                        let v6985:
                                                                                                                std::string::String =
                                                                                                            format!("{:#?}", v5789);
                                                                                                        let v7040:
                                                                                                                string =
                                                                                                            sprintf!("{}",
                                                                                                                     fable_library_rust::String_::fromString(v6985));
                                                                                                        let v7048:
                                                                                                                string =
                                                                                                            append(v6945.l0.get().clone(),
                                                                                                                   v7040);
                                                                                                        v6945.l0.set(v7048);
                                                                                                        {
                                                                                                            let v7052:
                                                                                                                    string =
                                                                                                                sprintf!("{}",
                                                                                                                         string(" }"));
                                                                                                            let v7060:
                                                                                                                    string =
                                                                                                                append(v6945.l0.get().clone(),
                                                                                                                       v7052);
                                                                                                            v6945.l0.set(v7060);
                                                                                                            {
                                                                                                                let v7061:
                                                                                                                        string =
                                                                                                                    v6945.l0.get().clone();
                                                                                                                let v7155:
                                                                                                                        string =
                                                                                                                    trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                         v6028,
                                                                                                                                                         v6898,
                                                                                                                                                         v6943,
                                                                                                                                                         Spiral_wasm::closure10((),
                                                                                                                                                                                ()),
                                                                                                                                                         v7061),
                                                                                                                                                toArray(empty::<char>())),
                                                                                                                                 toArray(ofArray(new_array(&[' ',
                                                                                                                                                             '/']))));
                                                                                                                println!("{}", v7155.clone());
                                                                                                                ();
                                                                                                                ((patternInput_12.1.clone()).l0.get().clone())(v7155)
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                                    {
                                                                                        let v7228:
                                                                                            near_workspaces::result::ExecutionFinalResult =
                                                                                        Spiral_wasm::method10(v4332.clone());
                                                                                        let v7230:
                                                                                            Vec<&near_workspaces::result::ExecutionOutcome> =
                                                                                        v7228.receipt_failures();
                                                                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                       {
                                                                                        Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                    }
                                                                                        {
                                                                                            let patternInput_15:
                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                 Option<i64>) =
                                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                            let v7241:
                                                                                                LrcPtr<Spiral_wasm::Mut0> =
                                                                                            patternInput_15.0.clone();
                                                                                            if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                           {
                                                                                            Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                        }
                                                                                            {
                                                                                                let patternInput_16:
                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                     Option<i64>) =
                                                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                let v7289:
                                                                                                    Spiral_wasm::US0 =
                                                                                                (patternInput_16.3.clone()).l0.get().clone();
                                                                                                if if (patternInput_16.2.clone()).l0.get().clone()
                                                                                                      ==
                                                                                                      false
                                                                                                  {
                                                                                                   false
                                                                                               } else {
                                                                                                   1_i32
                                                                                                       >=
                                                                                                       find(v7289,
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
                                                                                                let v7296:
                                                                                                        i64 =
                                                                                                    v7241.l0.get().clone()
                                                                                                        +
                                                                                                        1_i64;
                                                                                                v7241.l0.set(v7296);
                                                                                                if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                   {
                                                                                                    Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                }
                                                                                                {
                                                                                                    let patternInput_17:
                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                             Option<i64>) =
                                                                                                        getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                    let v7311:
                                                                                                            Option<i64> =
                                                                                                        patternInput_17.4.clone();
                                                                                                    let _v7330:
                                                                                                            LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                                        refCell(None::<Spiral_wasm::US3>);
                                                                                                    {
                                                                                                        let x_20:
                                                                                                                Option<Spiral_wasm::US3> =
                                                                                                            match &v7311
                                                                                                                {
                                                                                                                None
                                                                                                                =>
                                                                                                                None::<Spiral_wasm::US3>,
                                                                                                                Some(v7311_0_0)
                                                                                                                =>
                                                                                                                {
                                                                                                                    let x_18:
                                                                                                                            i64 =
                                                                                                                        v7311_0_0.clone();
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
                                                                                                        _v7330.set(x_20)
                                                                                                    }
                                                                                                    {
                                                                                                        let v7358:
                                                                                                                Spiral_wasm::US3 =
                                                                                                            defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                                         _v7330.get().clone());
                                                                                                        let v7456:
                                                                                                                DateTime =
                                                                                                            match &v7358
                                                                                                                {
                                                                                                                Spiral_wasm::US3::US3_0(v7358_0_0)
                                                                                                                =>
                                                                                                                {
                                                                                                                    let v7390:
                                                                                                                            TimeSpan =
                                                                                                                        TimeSpan::new_ticks({
                                                                                                                                                let _arg_25:
                                                                                                                                                        DateTime =
                                                                                                                                                    DateTime::now();
                                                                                                                                                _arg_25.ticks()
                                                                                                                                            }
                                                                                                                                                -
                                                                                                                                                match &v7358
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
                                                                                                                                               v7390.hours(),
                                                                                                                                               v7390.minutes(),
                                                                                                                                               v7390.seconds(),
                                                                                                                                               v7390.milliseconds())
                                                                                                                }
                                                                                                                _
                                                                                                                =>
                                                                                                                DateTime::now(),
                                                                                                            };
                                                                                                        let v7469:
                                                                                                                string =
                                                                                                            {
                                                                                                                let provider_5:
                                                                                                                        string =
                                                                                                                    Spiral_wasm::method4();
                                                                                                                v7456.toString(provider_5)
                                                                                                            };
                                                                                                        let v8297:
                                                                                                                string =
                                                                                                            padLeft(toLower(string("Debug")),
                                                                                                                    7_i32,
                                                                                                                    ' ');
                                                                                                        let v8330:
                                                                                                                &str =
                                                                                                            inline_colorization::color_bright_blue;
                                                                                                        let v8332:
                                                                                                                &str =
                                                                                                            &*v8297;
                                                                                                        let v8334:
                                                                                                                &str =
                                                                                                            inline_colorization::color_reset;
                                                                                                        let v8336:
                                                                                                                string =
                                                                                                            string("format!(\"{v8330}{v8332}{v8334}\")");
                                                                                                        let v8337:
                                                                                                                std::string::String =
                                                                                                            format!("{v8330}{v8332}{v8334}");
                                                                                                        let v8339:
                                                                                                                string =
                                                                                                            fable_library_rust::String_::fromString(v8337);
                                                                                                        let v8384:
                                                                                                                i64 =
                                                                                                            (patternInput_17.0.clone()).l0.get().clone();
                                                                                                        let v8386:
                                                                                                                LrcPtr<Spiral_wasm::Mut4> =
                                                                                                            LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                              MutCell::new(string("")),});
                                                                                                        let v8390:
                                                                                                                string =
                                                                                                            sprintf!("{}",
                                                                                                                     string("{ "));
                                                                                                        let v8398:
                                                                                                                string =
                                                                                                            append(v8386.l0.get().clone(),
                                                                                                                   v8390);
                                                                                                        v8386.l0.set(v8398);
                                                                                                        {
                                                                                                            let v8402:
                                                                                                                    string =
                                                                                                                sprintf!("{}",
                                                                                                                         string("receipt_failures"));
                                                                                                            let v8410:
                                                                                                                    string =
                                                                                                                append(v8386.l0.get().clone(),
                                                                                                                       v8402);
                                                                                                            v8386.l0.set(v8410);
                                                                                                            {
                                                                                                                let v8414:
                                                                                                                        string =
                                                                                                                    sprintf!("{}",
                                                                                                                             string(" = "));
                                                                                                                let v8422:
                                                                                                                        string =
                                                                                                                    append(v8386.l0.get().clone(),
                                                                                                                           v8414);
                                                                                                                v8386.l0.set(v8422);
                                                                                                                {
                                                                                                                    let v8426:
                                                                                                                            std::string::String =
                                                                                                                        format!("{:#?}", v7230.clone());
                                                                                                                    let v8481:
                                                                                                                            string =
                                                                                                                        sprintf!("{}",
                                                                                                                                 fable_library_rust::String_::fromString(v8426));
                                                                                                                    let v8489:
                                                                                                                            string =
                                                                                                                        append(v8386.l0.get().clone(),
                                                                                                                               v8481);
                                                                                                                    v8386.l0.set(v8489);
                                                                                                                    {
                                                                                                                        let v8493:
                                                                                                                                string =
                                                                                                                            sprintf!("{}",
                                                                                                                                     string(" }"));
                                                                                                                        let v8501:
                                                                                                                                string =
                                                                                                                            append(v8386.l0.get().clone(),
                                                                                                                                   v8493);
                                                                                                                        v8386.l0.set(v8501);
                                                                                                                        {
                                                                                                                            let v8502:
                                                                                                                                    string =
                                                                                                                                v8386.l0.get().clone();
                                                                                                                            let v8596:
                                                                                                                                    string =
                                                                                                                                trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                                     v7469,
                                                                                                                                                                     v8339,
                                                                                                                                                                     v8384,
                                                                                                                                                                     Spiral_wasm::closure11((),
                                                                                                                                                                                            ()),
                                                                                                                                                                     v8502),
                                                                                                                                                            toArray(empty::<char>())),
                                                                                                                                             toArray(ofArray(new_array(&[' ',
                                                                                                                                                                         '/']))));
                                                                                                                            println!("{}", v8596.clone());
                                                                                                                            ();
                                                                                                                            ((patternInput_15.1.clone()).l0.get().clone())(v8596)
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                                {
                                                                                                    let v8669:
                                                                                                        near_workspaces::result::ExecutionFinalResult =
                                                                                                    Spiral_wasm::method11(v4332.clone());
                                                                                                    let v8671:
                                                                                                        &[near_workspaces::result::ExecutionOutcome] =
                                                                                                    v8669.receipt_outcomes();
                                                                                                    if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                   {
                                                                                                    Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                }
                                                                                                    {
                                                                                                        let patternInput_18:
                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                             Option<i64>) =
                                                                                                        getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                        let v8682:
                                                                                                            LrcPtr<Spiral_wasm::Mut0> =
                                                                                                        patternInput_18.0.clone();
                                                                                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                       {
                                                                                                        Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                    }
                                                                                                        {
                                                                                                            let patternInput_19:
                                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                 Option<i64>) =
                                                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                            let v8730:
                                                                                                                Spiral_wasm::US0 =
                                                                                                            (patternInput_19.3.clone()).l0.get().clone();
                                                                                                            if if (patternInput_19.2.clone()).l0.get().clone()
                                                                                                                  ==
                                                                                                                  false
                                                                                                              {
                                                                                                               false
                                                                                                           } else {
                                                                                                               1_i32
                                                                                                                   >=
                                                                                                                   find(v8730,
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
                                                                                                            let v8737:
                                                                                                                    i64 =
                                                                                                                v8682.l0.get().clone()
                                                                                                                    +
                                                                                                                    1_i64;
                                                                                                            v8682.l0.set(v8737);
                                                                                                            if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                               {
                                                                                                                Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                            }
                                                                                                            {
                                                                                                                let patternInput_20:
                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                         Option<i64>) =
                                                                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                let v8752:
                                                                                                                        Option<i64> =
                                                                                                                    patternInput_20.4.clone();
                                                                                                                let _v8771:
                                                                                                                        LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                                                    refCell(None::<Spiral_wasm::US3>);
                                                                                                                {
                                                                                                                    let x_23:
                                                                                                                            Option<Spiral_wasm::US3> =
                                                                                                                        match &v8752
                                                                                                                            {
                                                                                                                            None
                                                                                                                            =>
                                                                                                                            None::<Spiral_wasm::US3>,
                                                                                                                            Some(v8752_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let x_21:
                                                                                                                                        i64 =
                                                                                                                                    v8752_0_0.clone();
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
                                                                                                                    _v8771.set(x_23)
                                                                                                                }
                                                                                                                {
                                                                                                                    let v8799:
                                                                                                                            Spiral_wasm::US3 =
                                                                                                                        defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                                                     _v8771.get().clone());
                                                                                                                    let v8897:
                                                                                                                            DateTime =
                                                                                                                        match &v8799
                                                                                                                            {
                                                                                                                            Spiral_wasm::US3::US3_0(v8799_0_0)
                                                                                                                            =>
                                                                                                                            {
                                                                                                                                let v8831:
                                                                                                                                        TimeSpan =
                                                                                                                                    TimeSpan::new_ticks({
                                                                                                                                                            let _arg_30:
                                                                                                                                                                    DateTime =
                                                                                                                                                                DateTime::now();
                                                                                                                                                            _arg_30.ticks()
                                                                                                                                                        }
                                                                                                                                                            -
                                                                                                                                                            match &v8799
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
                                                                                                                                                           v8831.hours(),
                                                                                                                                                           v8831.minutes(),
                                                                                                                                                           v8831.seconds(),
                                                                                                                                                           v8831.milliseconds())
                                                                                                                            }
                                                                                                                            _
                                                                                                                            =>
                                                                                                                            DateTime::now(),
                                                                                                                        };
                                                                                                                    let v8910:
                                                                                                                            string =
                                                                                                                        {
                                                                                                                            let provider_6:
                                                                                                                                    string =
                                                                                                                                Spiral_wasm::method4();
                                                                                                                            v8897.toString(provider_6)
                                                                                                                        };
                                                                                                                    let v9738:
                                                                                                                            string =
                                                                                                                        padLeft(toLower(string("Debug")),
                                                                                                                                7_i32,
                                                                                                                                ' ');
                                                                                                                    let v9771:
                                                                                                                            &str =
                                                                                                                        inline_colorization::color_bright_blue;
                                                                                                                    let v9773:
                                                                                                                            &str =
                                                                                                                        &*v9738;
                                                                                                                    let v9775:
                                                                                                                            &str =
                                                                                                                        inline_colorization::color_reset;
                                                                                                                    let v9777:
                                                                                                                            string =
                                                                                                                        string("format!(\"{v9771}{v9773}{v9775}\")");
                                                                                                                    let v9778:
                                                                                                                            std::string::String =
                                                                                                                        format!("{v9771}{v9773}{v9775}");
                                                                                                                    let v9780:
                                                                                                                            string =
                                                                                                                        fable_library_rust::String_::fromString(v9778);
                                                                                                                    let v9825:
                                                                                                                            i64 =
                                                                                                                        (patternInput_20.0.clone()).l0.get().clone();
                                                                                                                    let v9827:
                                                                                                                            LrcPtr<Spiral_wasm::Mut4> =
                                                                                                                        LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                                          MutCell::new(string("")),});
                                                                                                                    let v9831:
                                                                                                                            string =
                                                                                                                        sprintf!("{}",
                                                                                                                                 string("{ "));
                                                                                                                    let v9839:
                                                                                                                            string =
                                                                                                                        append(v9827.l0.get().clone(),
                                                                                                                               v9831);
                                                                                                                    v9827.l0.set(v9839);
                                                                                                                    {
                                                                                                                        let v9843:
                                                                                                                                string =
                                                                                                                            sprintf!("{}",
                                                                                                                                     string("receipt_outcomes"));
                                                                                                                        let v9851:
                                                                                                                                string =
                                                                                                                            append(v9827.l0.get().clone(),
                                                                                                                                   v9843);
                                                                                                                        v9827.l0.set(v9851);
                                                                                                                        {
                                                                                                                            let v9855:
                                                                                                                                    string =
                                                                                                                                sprintf!("{}",
                                                                                                                                         string(" = "));
                                                                                                                            let v9863:
                                                                                                                                    string =
                                                                                                                                append(v9827.l0.get().clone(),
                                                                                                                                       v9855);
                                                                                                                            v9827.l0.set(v9863);
                                                                                                                            {
                                                                                                                                let v9867:
                                                                                                                                        std::string::String =
                                                                                                                                    format!("{:#?}", v8671);
                                                                                                                                let v9922:
                                                                                                                                        string =
                                                                                                                                    sprintf!("{}",
                                                                                                                                             fable_library_rust::String_::fromString(v9867));
                                                                                                                                let v9930:
                                                                                                                                        string =
                                                                                                                                    append(v9827.l0.get().clone(),
                                                                                                                                           v9922);
                                                                                                                                v9827.l0.set(v9930);
                                                                                                                                {
                                                                                                                                    let v9934:
                                                                                                                                            string =
                                                                                                                                        sprintf!("{}",
                                                                                                                                                 string(" }"));
                                                                                                                                    let v9942:
                                                                                                                                            string =
                                                                                                                                        append(v9827.l0.get().clone(),
                                                                                                                                               v9934);
                                                                                                                                    v9827.l0.set(v9942);
                                                                                                                                    {
                                                                                                                                        let v9943:
                                                                                                                                                string =
                                                                                                                                            v9827.l0.get().clone();
                                                                                                                                        let v10037:
                                                                                                                                                string =
                                                                                                                                            trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                                                 v8910,
                                                                                                                                                                                 v9780,
                                                                                                                                                                                 v9825,
                                                                                                                                                                                 Spiral_wasm::closure12((),
                                                                                                                                                                                                        ()),
                                                                                                                                                                                 v9943),
                                                                                                                                                                        toArray(empty::<char>())),
                                                                                                                                                         toArray(ofArray(new_array(&[' ',
                                                                                                                                                                                     '/']))));
                                                                                                                                        println!("{}", v10037.clone());
                                                                                                                                        ();
                                                                                                                                        ((patternInput_18.1.clone()).l0.get().clone())(v10037)
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                            {
                                                                                                                let v10111:
                                                                                                                    Result<std::string::String,
                                                                                                                           near_workspaces::error::Error> =
                                                                                                                v4332.clone().json();
                                                                                                                if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                               {
                                                                                                                Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                            }
                                                                                                                {
                                                                                                                    let patternInput_21:
                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                         Option<i64>) =
                                                                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                    let v10122:
                                                                                                                        LrcPtr<Spiral_wasm::Mut0> =
                                                                                                                    patternInput_21.0.clone();
                                                                                                                    if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                   {
                                                                                                                    Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                                }
                                                                                                                    {
                                                                                                                        let patternInput_22:
                                                                                                                            (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                             LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                             Option<i64>) =
                                                                                                                        getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                        let v10170:
                                                                                                                            Spiral_wasm::US0 =
                                                                                                                        (patternInput_22.3.clone()).l0.get().clone();
                                                                                                                        if if (patternInput_22.2.clone()).l0.get().clone()
                                                                                                                              ==
                                                                                                                              false
                                                                                                                          {
                                                                                                                           false
                                                                                                                       } else {
                                                                                                                           1_i32
                                                                                                                               >=
                                                                                                                               find(v10170,
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
                                                                                                                        let v10177:
                                                                                                                                i64 =
                                                                                                                            v10122.l0.get().clone()
                                                                                                                                +
                                                                                                                                1_i64;
                                                                                                                        v10122.l0.set(v10177);
                                                                                                                        if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                           {
                                                                                                                            Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                                        }
                                                                                                                        {
                                                                                                                            let patternInput_23:
                                                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                     Option<i64>) =
                                                                                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                            let v10192:
                                                                                                                                    Option<i64> =
                                                                                                                                patternInput_23.4.clone();
                                                                                                                            let _v10211:
                                                                                                                                    LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                                                                refCell(None::<Spiral_wasm::US3>);
                                                                                                                            {
                                                                                                                                let x_26:
                                                                                                                                        Option<Spiral_wasm::US3> =
                                                                                                                                    match &v10192
                                                                                                                                        {
                                                                                                                                        None
                                                                                                                                        =>
                                                                                                                                        None::<Spiral_wasm::US3>,
                                                                                                                                        Some(v10192_0_0)
                                                                                                                                        =>
                                                                                                                                        {
                                                                                                                                            let x_24:
                                                                                                                                                    i64 =
                                                                                                                                                v10192_0_0.clone();
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
                                                                                                                                _v10211.set(x_26)
                                                                                                                            }
                                                                                                                            {
                                                                                                                                let v10239:
                                                                                                                                        Spiral_wasm::US3 =
                                                                                                                                    defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                                                                 _v10211.get().clone());
                                                                                                                                let v10337:
                                                                                                                                        DateTime =
                                                                                                                                    match &v10239
                                                                                                                                        {
                                                                                                                                        Spiral_wasm::US3::US3_0(v10239_0_0)
                                                                                                                                        =>
                                                                                                                                        {
                                                                                                                                            let v10271:
                                                                                                                                                    TimeSpan =
                                                                                                                                                TimeSpan::new_ticks({
                                                                                                                                                                        let _arg_35:
                                                                                                                                                                                DateTime =
                                                                                                                                                                            DateTime::now();
                                                                                                                                                                        _arg_35.ticks()
                                                                                                                                                                    }
                                                                                                                                                                        -
                                                                                                                                                                        match &v10239
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
                                                                                                                                                                       v10271.hours(),
                                                                                                                                                                       v10271.minutes(),
                                                                                                                                                                       v10271.seconds(),
                                                                                                                                                                       v10271.milliseconds())
                                                                                                                                        }
                                                                                                                                        _
                                                                                                                                        =>
                                                                                                                                        DateTime::now(),
                                                                                                                                    };
                                                                                                                                let v10350:
                                                                                                                                        string =
                                                                                                                                    {
                                                                                                                                        let provider_7:
                                                                                                                                                string =
                                                                                                                                            Spiral_wasm::method4();
                                                                                                                                        v10337.toString(provider_7)
                                                                                                                                    };
                                                                                                                                let v11178:
                                                                                                                                        string =
                                                                                                                                    padLeft(toLower(string("Debug")),
                                                                                                                                            7_i32,
                                                                                                                                            ' ');
                                                                                                                                let v11211:
                                                                                                                                        &str =
                                                                                                                                    inline_colorization::color_bright_blue;
                                                                                                                                let v11213:
                                                                                                                                        &str =
                                                                                                                                    &*v11178;
                                                                                                                                let v11215:
                                                                                                                                        &str =
                                                                                                                                    inline_colorization::color_reset;
                                                                                                                                let v11217:
                                                                                                                                        string =
                                                                                                                                    string("format!(\"{v11211}{v11213}{v11215}\")");
                                                                                                                                let v11218:
                                                                                                                                        std::string::String =
                                                                                                                                    format!("{v11211}{v11213}{v11215}");
                                                                                                                                let v11220:
                                                                                                                                        string =
                                                                                                                                    fable_library_rust::String_::fromString(v11218);
                                                                                                                                let v11265:
                                                                                                                                        i64 =
                                                                                                                                    (patternInput_23.0.clone()).l0.get().clone();
                                                                                                                                let v11267:
                                                                                                                                        LrcPtr<Spiral_wasm::Mut4> =
                                                                                                                                    LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                                                      MutCell::new(string("")),});
                                                                                                                                let v11271:
                                                                                                                                        string =
                                                                                                                                    sprintf!("{}",
                                                                                                                                             string("{ "));
                                                                                                                                let v11279:
                                                                                                                                        string =
                                                                                                                                    append(v11267.l0.get().clone(),
                                                                                                                                           v11271);
                                                                                                                                v11267.l0.set(v11279);
                                                                                                                                {
                                                                                                                                    let v11283:
                                                                                                                                            string =
                                                                                                                                        sprintf!("{}",
                                                                                                                                                 string("json"));
                                                                                                                                    let v11291:
                                                                                                                                            string =
                                                                                                                                        append(v11267.l0.get().clone(),
                                                                                                                                               v11283);
                                                                                                                                    v11267.l0.set(v11291);
                                                                                                                                    {
                                                                                                                                        let v11295:
                                                                                                                                                string =
                                                                                                                                            sprintf!("{}",
                                                                                                                                                     string(" = "));
                                                                                                                                        let v11303:
                                                                                                                                                string =
                                                                                                                                            append(v11267.l0.get().clone(),
                                                                                                                                                   v11295);
                                                                                                                                        v11267.l0.set(v11303);
                                                                                                                                        {
                                                                                                                                            let v11307:
                                                                                                                                                    std::string::String =
                                                                                                                                                format!("{:#?}", v10111);
                                                                                                                                            let v11362:
                                                                                                                                                    string =
                                                                                                                                                sprintf!("{}",
                                                                                                                                                         fable_library_rust::String_::fromString(v11307));
                                                                                                                                            let v11370:
                                                                                                                                                    string =
                                                                                                                                                append(v11267.l0.get().clone(),
                                                                                                                                                       v11362);
                                                                                                                                            v11267.l0.set(v11370);
                                                                                                                                            {
                                                                                                                                                let v11374:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("{}",
                                                                                                                                                             string(" }"));
                                                                                                                                                let v11382:
                                                                                                                                                        string =
                                                                                                                                                    append(v11267.l0.get().clone(),
                                                                                                                                                           v11374);
                                                                                                                                                v11267.l0.set(v11382);
                                                                                                                                                {
                                                                                                                                                    let v11383:
                                                                                                                                                            string =
                                                                                                                                                        v11267.l0.get().clone();
                                                                                                                                                    let v11477:
                                                                                                                                                            string =
                                                                                                                                                        trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                                                             v10350,
                                                                                                                                                                                             v11220,
                                                                                                                                                                                             v11265,
                                                                                                                                                                                             Spiral_wasm::closure13((),
                                                                                                                                                                                                                    ()),
                                                                                                                                                                                             v11383),
                                                                                                                                                                                    toArray(empty::<char>())),
                                                                                                                                                                     toArray(ofArray(new_array(&[' ',
                                                                                                                                                                                                 '/']))));
                                                                                                                                                    println!("{}", v11477.clone());
                                                                                                                                                    ();
                                                                                                                                                    ((patternInput_21.1.clone()).l0.get().clone())(v11477)
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                        {
                                                                                                                            let v11551:
                                                                                                                                Result<std::string::String,
                                                                                                                                       near_workspaces::error::Error> =
                                                                                                                            v4332.borsh();
                                                                                                                            if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                           {
                                                                                                                            Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                                        }
                                                                                                                            {
                                                                                                                                let patternInput_24:
                                                                                                                                    (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                     LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                     Option<i64>) =
                                                                                                                                getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                                let v11562:
                                                                                                                                    LrcPtr<Spiral_wasm::Mut0> =
                                                                                                                                patternInput_24.0.clone();
                                                                                                                                if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                               {
                                                                                                                                Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                                            }
                                                                                                                                {
                                                                                                                                    let patternInput_25:
                                                                                                                                        (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                         LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                         Option<i64>) =
                                                                                                                                    getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                                    let v11610:
                                                                                                                                        Spiral_wasm::US0 =
                                                                                                                                    (patternInput_25.3.clone()).l0.get().clone();
                                                                                                                                    if if (patternInput_25.2.clone()).l0.get().clone()
                                                                                                                                          ==
                                                                                                                                          false
                                                                                                                                      {
                                                                                                                                       false
                                                                                                                                   } else {
                                                                                                                                       1_i32
                                                                                                                                           >=
                                                                                                                                           find(v11610,
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
                                                                                                                                    let v11617:
                                                                                                                                            i64 =
                                                                                                                                        v11562.l0.get().clone()
                                                                                                                                            +
                                                                                                                                            1_i64;
                                                                                                                                    v11562.l0.set(v11617);
                                                                                                                                    if Spiral_wasm::State::trace_state().get().clone().is_none()
                                                                                                                                       {
                                                                                                                                        Spiral_wasm::State::trace_state().set(Some(v53(Spiral_wasm::US0::US0_0)));
                                                                                                                                    }
                                                                                                                                    {
                                                                                                                                        let patternInput_26:
                                                                                                                                                (LrcPtr<Spiral_wasm::Mut0>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut1>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut2>,
                                                                                                                                                 LrcPtr<Spiral_wasm::Mut3>,
                                                                                                                                                 Option<i64>) =
                                                                                                                                            getValue(Spiral_wasm::State::trace_state().get().clone());
                                                                                                                                        let v11632:
                                                                                                                                                Option<i64> =
                                                                                                                                            patternInput_26.4.clone();
                                                                                                                                        let _v11651:
                                                                                                                                                LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                                                                                                                            refCell(None::<Spiral_wasm::US3>);
                                                                                                                                        {
                                                                                                                                            let x_29:
                                                                                                                                                    Option<Spiral_wasm::US3> =
                                                                                                                                                match &v11632
                                                                                                                                                    {
                                                                                                                                                    None
                                                                                                                                                    =>
                                                                                                                                                    None::<Spiral_wasm::US3>,
                                                                                                                                                    Some(v11632_0_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let x_27:
                                                                                                                                                                i64 =
                                                                                                                                                            v11632_0_0.clone();
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
                                                                                                                                            _v11651.set(x_29)
                                                                                                                                        }
                                                                                                                                        {
                                                                                                                                            let v11679:
                                                                                                                                                    Spiral_wasm::US3 =
                                                                                                                                                defaultValue(Spiral_wasm::US3::US3_1,
                                                                                                                                                             _v11651.get().clone());
                                                                                                                                            let v11777:
                                                                                                                                                    DateTime =
                                                                                                                                                match &v11679
                                                                                                                                                    {
                                                                                                                                                    Spiral_wasm::US3::US3_0(v11679_0_0)
                                                                                                                                                    =>
                                                                                                                                                    {
                                                                                                                                                        let v11711:
                                                                                                                                                                TimeSpan =
                                                                                                                                                            TimeSpan::new_ticks({
                                                                                                                                                                                    let _arg_40:
                                                                                                                                                                                            DateTime =
                                                                                                                                                                                        DateTime::now();
                                                                                                                                                                                    _arg_40.ticks()
                                                                                                                                                                                }
                                                                                                                                                                                    -
                                                                                                                                                                                    match &v11679
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
                                                                                                                                                                                   v11711.hours(),
                                                                                                                                                                                   v11711.minutes(),
                                                                                                                                                                                   v11711.seconds(),
                                                                                                                                                                                   v11711.milliseconds())
                                                                                                                                                    }
                                                                                                                                                    _
                                                                                                                                                    =>
                                                                                                                                                    DateTime::now(),
                                                                                                                                                };
                                                                                                                                            let v11790:
                                                                                                                                                    string =
                                                                                                                                                {
                                                                                                                                                    let provider_8:
                                                                                                                                                            string =
                                                                                                                                                        Spiral_wasm::method4();
                                                                                                                                                    v11777.toString(provider_8)
                                                                                                                                                };
                                                                                                                                            let v12618:
                                                                                                                                                    string =
                                                                                                                                                padLeft(toLower(string("Debug")),
                                                                                                                                                        7_i32,
                                                                                                                                                        ' ');
                                                                                                                                            let v12651:
                                                                                                                                                    &str =
                                                                                                                                                inline_colorization::color_bright_blue;
                                                                                                                                            let v12653:
                                                                                                                                                    &str =
                                                                                                                                                &*v12618;
                                                                                                                                            let v12655:
                                                                                                                                                    &str =
                                                                                                                                                inline_colorization::color_reset;
                                                                                                                                            let v12657:
                                                                                                                                                    string =
                                                                                                                                                string("format!(\"{v12651}{v12653}{v12655}\")");
                                                                                                                                            let v12658:
                                                                                                                                                    std::string::String =
                                                                                                                                                format!("{v12651}{v12653}{v12655}");
                                                                                                                                            let v12660:
                                                                                                                                                    string =
                                                                                                                                                fable_library_rust::String_::fromString(v12658);
                                                                                                                                            let v12705:
                                                                                                                                                    i64 =
                                                                                                                                                (patternInput_26.0.clone()).l0.get().clone();
                                                                                                                                            let v12707:
                                                                                                                                                    LrcPtr<Spiral_wasm::Mut4> =
                                                                                                                                                LrcPtr::new(Spiral_wasm::Mut4{l0:
                                                                                                                                                                                  MutCell::new(string("")),});
                                                                                                                                            let v12711:
                                                                                                                                                    string =
                                                                                                                                                sprintf!("{}",
                                                                                                                                                         string("{ "));
                                                                                                                                            let v12719:
                                                                                                                                                    string =
                                                                                                                                                append(v12707.l0.get().clone(),
                                                                                                                                                       v12711);
                                                                                                                                            v12707.l0.set(v12719);
                                                                                                                                            {
                                                                                                                                                let v12723:
                                                                                                                                                        string =
                                                                                                                                                    sprintf!("{}",
                                                                                                                                                             string("borsh"));
                                                                                                                                                let v12731:
                                                                                                                                                        string =
                                                                                                                                                    append(v12707.l0.get().clone(),
                                                                                                                                                           v12723);
                                                                                                                                                v12707.l0.set(v12731);
                                                                                                                                                {
                                                                                                                                                    let v12735:
                                                                                                                                                            string =
                                                                                                                                                        sprintf!("{}",
                                                                                                                                                                 string(" = "));
                                                                                                                                                    let v12743:
                                                                                                                                                            string =
                                                                                                                                                        append(v12707.l0.get().clone(),
                                                                                                                                                               v12735);
                                                                                                                                                    v12707.l0.set(v12743);
                                                                                                                                                    {
                                                                                                                                                        let v12747:
                                                                                                                                                                std::string::String =
                                                                                                                                                            format!("{:#?}", v11551);
                                                                                                                                                        let v12802:
                                                                                                                                                                string =
                                                                                                                                                            sprintf!("{}",
                                                                                                                                                                     fable_library_rust::String_::fromString(v12747));
                                                                                                                                                        let v12810:
                                                                                                                                                                string =
                                                                                                                                                            append(v12707.l0.get().clone(),
                                                                                                                                                                   v12802);
                                                                                                                                                        v12707.l0.set(v12810);
                                                                                                                                                        {
                                                                                                                                                            let v12814:
                                                                                                                                                                    string =
                                                                                                                                                                sprintf!("{}",
                                                                                                                                                                         string(" }"));
                                                                                                                                                            let v12822:
                                                                                                                                                                    string =
                                                                                                                                                                append(v12707.l0.get().clone(),
                                                                                                                                                                       v12814);
                                                                                                                                                            v12707.l0.set(v12822);
                                                                                                                                                            {
                                                                                                                                                                let v12823:
                                                                                                                                                                        string =
                                                                                                                                                                    v12707.l0.get().clone();
                                                                                                                                                                let v12917:
                                                                                                                                                                        string =
                                                                                                                                                                    trimEndChars(trimStartChars(sprintf!("{} {} #{} {} / {}",
                                                                                                                                                                                                         v11790,
                                                                                                                                                                                                         v12660,
                                                                                                                                                                                                         v12705,
                                                                                                                                                                                                         Spiral_wasm::closure14((),
                                                                                                                                                                                                                                ()),
                                                                                                                                                                                                         v12823),
                                                                                                                                                                                                toArray(empty::<char>())),
                                                                                                                                                                                 toArray(ofArray(new_array(&[' ',
                                                                                                                                                                                                             '/']))));
                                                                                                                                                                println!("{}", v12917.clone());
                                                                                                                                                                ();
                                                                                                                                                                ((patternInput_24.1.clone()).l0.get().clone())(v12917)
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                    println!("\n\n worker: {:#?}", v1441); //;
                                                                                                                                    println!("\n\n contract: {:#?}", v2885); //;
                                                                                                                                    {
                                                                                                                                        let v13004:
                                                                                                                                            Result<(),
                                                                                                                                                   anyhow::Error> =
                                                                                                                                        Spiral_wasm::method12(if v7230.len()
                                                                                                                                                                     as
                                                                                                                                                                     i32
                                                                                                                                                                     ==
                                                                                                                                                                     0_i32
                                                                                                                                                                 {
                                                                                                                                                                  Ok::<(),
                                                                                                                                                                       anyhow::Error>(())
                                                                                                                                                              } else {
                                                                                                                                                                  let v13000:
                                                                                                                                                                          anyhow::Error =
                                                                                                                                                                      anyhow::anyhow!(string("<error>"));
                                                                                                                                                                  Err(v13000)
                                                                                                                                                              });
                                                                                                                                        let v13069:
                                                                                                                                            string =
                                                                                                                                        string("v13004 }}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}); {{{{{{{{{{{{{{{{{{{{{{{{{{{{{{ // rust.fix_closure\'");
                                                                                                                                        v13004
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
            fn v3(
                v: Spiral_wasm::US0,
            ) -> (
                LrcPtr<Spiral_wasm::Mut0>,
                LrcPtr<Spiral_wasm::Mut1>,
                LrcPtr<Spiral_wasm::Mut2>,
                LrcPtr<Spiral_wasm::Mut3>,
                Option<i64>,
            ) {
                Spiral_wasm::closure2((), v)
            }
            if Spiral_wasm::State::trace_state().get().clone().is_none() {
                Spiral_wasm::State::trace_state().set(Some(v3(Spiral_wasm::US0::US0_0)));
            }
            {
                let patternInput: (
                    LrcPtr<Spiral_wasm::Mut0>,
                    LrcPtr<Spiral_wasm::Mut1>,
                    LrcPtr<Spiral_wasm::Mut2>,
                    LrcPtr<Spiral_wasm::Mut3>,
                    Option<i64>,
                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                if Spiral_wasm::State::trace_state().get().clone().is_none() {
                    Spiral_wasm::State::trace_state().set(Some(v3(Spiral_wasm::US0::US0_0)));
                }
                {
                    let patternInput_1: (
                        LrcPtr<Spiral_wasm::Mut0>,
                        LrcPtr<Spiral_wasm::Mut1>,
                        LrcPtr<Spiral_wasm::Mut2>,
                        LrcPtr<Spiral_wasm::Mut3>,
                        Option<i64>,
                    ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                    let v41: LrcPtr<Spiral_wasm::Mut0> = patternInput_1.0.clone();
                    if Spiral_wasm::State::trace_state().get().clone().is_none() {
                        Spiral_wasm::State::trace_state().set(Some(v3(Spiral_wasm::US0::US0_0)));
                    }
                    {
                        let patternInput_2: (
                            LrcPtr<Spiral_wasm::Mut0>,
                            LrcPtr<Spiral_wasm::Mut1>,
                            LrcPtr<Spiral_wasm::Mut2>,
                            LrcPtr<Spiral_wasm::Mut3>,
                            Option<i64>,
                        ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                        let v89: Spiral_wasm::US0 = (patternInput_2.3.clone()).l0.get().clone();
                        if if (patternInput_2.2.clone()).l0.get().clone() == false {
                            false
                        } else {
                            1_i32
                                >= find(
                                    v89,
                                    ofSeq(ofList(ofArray(new_array(&[
                                        LrcPtr::new((Spiral_wasm::US0::US0_0, 0_i32)),
                                        LrcPtr::new((Spiral_wasm::US0::US0_1, 1_i32)),
                                        LrcPtr::new((Spiral_wasm::US0::US0_2, 2_i32)),
                                        LrcPtr::new((Spiral_wasm::US0::US0_3, 3_i32)),
                                        LrcPtr::new((Spiral_wasm::US0::US0_4, 4_i32)),
                                    ])))),
                                )
                        } {
                            let v96: i64 = v41.l0.get().clone() + 1_i64;
                            v41.l0.set(v96);
                            if Spiral_wasm::State::trace_state().get().clone().is_none() {
                                Spiral_wasm::State::trace_state()
                                    .set(Some(v3(Spiral_wasm::US0::US0_0)));
                            }
                            {
                                let patternInput_3: (
                                    LrcPtr<Spiral_wasm::Mut0>,
                                    LrcPtr<Spiral_wasm::Mut1>,
                                    LrcPtr<Spiral_wasm::Mut2>,
                                    LrcPtr<Spiral_wasm::Mut3>,
                                    Option<i64>,
                                ) = getValue(Spiral_wasm::State::trace_state().get().clone());
                                let v111: Option<i64> = patternInput_3.4.clone();
                                let _v130: LrcPtr<MutCell<Option<Spiral_wasm::US3>>> =
                                    refCell(None::<Spiral_wasm::US3>);
                                {
                                    let x_2: Option<Spiral_wasm::US3> = match &v111 {
                                        None => None::<Spiral_wasm::US3>,
                                        Some(v111_0_0) => {
                                            let x: i64 = v111_0_0.clone();
                                            Some((Func0::new({
                                                let x = x.clone();
                                                move || Spiral_wasm::US3::US3_0(x)
                                            }))())
                                        }
                                    };
                                    _v130.set(x_2)
                                }
                                {
                                    let v158: Spiral_wasm::US3 =
                                        defaultValue(Spiral_wasm::US3::US3_1, _v130.get().clone());
                                    let v256: DateTime = match &v158 {
                                        Spiral_wasm::US3::US3_0(v158_0_0) => {
                                            let v190: TimeSpan = TimeSpan::new_ticks(
                                                {
                                                    let _arg: DateTime = DateTime::now();
                                                    _arg.ticks()
                                                } - match &v158 {
                                                    Spiral_wasm::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                            );
                                            DateTime::new_ymdhms_milli(
                                                1_i32,
                                                1_i32,
                                                1_i32,
                                                v190.hours(),
                                                v190.minutes(),
                                                v190.seconds(),
                                                v190.milliseconds(),
                                            )
                                        }
                                        _ => DateTime::now(),
                                    };
                                    let v269: string = {
                                        let provider: string = Spiral_wasm::method4();
                                        v256.toString(provider)
                                    };
                                    let v1097: string =
                                        padLeft(toLower(string("Debug")), 7_i32, ' ');
                                    let v1130: &str = inline_colorization::color_bright_blue;
                                    let v1132: &str = &*v1097;
                                    let v1134: &str = inline_colorization::color_reset;
                                    let v1136: string =
                                        string("format!(\"{v1130}{v1132}{v1134}\")");
                                    let v1137: std::string::String =
                                        format!("{v1130}{v1132}{v1134}");
                                    let v1139: string =
                                        fable_library_rust::String_::fromString(v1137);
                                    let v1184: i64 = (patternInput_3.0.clone()).l0.get().clone();
                                    let v1186: LrcPtr<Spiral_wasm::Mut4> =
                                        LrcPtr::new(Spiral_wasm::Mut4 {
                                            l0: MutCell::new(string("")),
                                        });
                                    let v1190: string = sprintf!("{}", string("{ "));
                                    let v1198: string = append(v1186.l0.get().clone(), v1190);
                                    v1186.l0.set(v1198);
                                    {
                                        let v1202: string = sprintf!("{}", string("args"));
                                        let v1210: string = append(v1186.l0.get().clone(), v1202);
                                        v1186.l0.set(v1210);
                                        {
                                            let v1214: string = sprintf!("{}", string(" = "));
                                            let v1222: string =
                                                append(v1186.l0.get().clone(), v1214);
                                            v1186.l0.set(v1222);
                                            {
                                                let v1234: string =
                                                    sprintf!("{}", sprintf!("{:?}", v0_1));
                                                let v1242: string =
                                                    append(v1186.l0.get().clone(), v1234);
                                                v1186.l0.set(v1242);
                                                {
                                                    let v1246: string =
                                                        sprintf!("{}", string(" }"));
                                                    let v1254: string =
                                                        append(v1186.l0.get().clone(), v1246);
                                                    v1186.l0.set(v1254);
                                                    {
                                                        let v1255: string = v1186.l0.get().clone();
                                                        let v1349: string = trimEndChars(
                                                            trimStartChars(
                                                                sprintf!(
                                                                    "{} {} #{} {} / {}",
                                                                    v269,
                                                                    v1139,
                                                                    v1184,
                                                                    Spiral_wasm::closure4((), ()),
                                                                    v1255
                                                                ),
                                                                toArray(empty::<char>()),
                                                            ),
                                                            toArray(ofArray(new_array(&[
                                                                ' ', '/',
                                                            ]))),
                                                        );
                                                        println!("{}", v1349.clone());
                                                        ();
                                                        ((patternInput_1.1.clone())
                                                            .l0
                                                            .get()
                                                            .clone())(
                                                            v1349
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
                            let v1422: clap::Command = Spiral_wasm::method7();
                            let v1425: std::pin::Pin<
                                Box<dyn std::future::Future<Output = Result<(), anyhow::Error>>>,
                            > = Spiral_wasm::method8(clap::Command::get_matches(v1422));
                            let v1427 = tokio::runtime::Builder::new_multi_thread()
                                .enable_all()
                                .build()
                                .unwrap();
                            let v1429: Result<(), anyhow::Error> = v1427.handle().block_on(v1425);
                            v1429.unwrap();
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
