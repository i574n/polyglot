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
mod module_7e2cd9e0 {
    pub mod Spiral_builder {
        use super::*;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::padLeft;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::split;
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
                        LrcPtr<Spiral_builder::Mut0>,
                        LrcPtr<Spiral_builder::Mut1>,
                        LrcPtr<Spiral_builder::Mut2>,
                        Option<i64>,
                        LrcPtr<Spiral_builder::Mut3>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Spiral_builder::Mut0>,
                                LrcPtr<Spiral_builder::Mut1>,
                                LrcPtr<Spiral_builder::Mut2>,
                                Option<i64>,
                                LrcPtr<Spiral_builder::Mut3>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Spiral_builder::Mut0>,
                                LrcPtr<Spiral_builder::Mut1>,
                                LrcPtr<Spiral_builder::Mut2>,
                                Option<i64>,
                                LrcPtr<Spiral_builder::Mut3>,
                            )>,
                        ))
                    })
                    .clone()
            }
        }
        pub trait IPathJoin {
            fn join(&self, paths: Array<string>) -> string;
        }
        impl<V: IPathJoin + Clone + 'static> IPathJoin for LrcPtr<V> {
            #[inline]
            fn join(&self, paths: Array<string>) -> string {
                (**self).join(paths)
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Spiral_builder::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut1 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Spiral_builder::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
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
        impl Spiral_builder::US0 {
            pub fn get_IsUS0_0(this_: &MutCell<Spiral_builder::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_1(this_: &MutCell<Spiral_builder::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_2(this_: &MutCell<Spiral_builder::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_3(this_: &MutCell<Spiral_builder::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_4(this_: &MutCell<Spiral_builder::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<Spiral_builder::US0>,
        }
        impl core::fmt::Display for Spiral_builder::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut3 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Spiral_builder::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(i64),
            US1_1,
        }
        impl Spiral_builder::US1 {
            pub fn get_IsUS1_0(this_: &MutCell<Spiral_builder::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_1(this_: &MutCell<Spiral_builder::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl Spiral_builder::US2 {
            pub fn get_IsUS2_0(this_: &MutCell<Spiral_builder::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS2_1(this_: &MutCell<Spiral_builder::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US3 {
            US3_0(std::string::String),
            US3_1,
        }
        impl Spiral_builder::US3 {
            pub fn get_IsUS3_0(this_: &MutCell<Spiral_builder::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS3_1(this_: &MutCell<Spiral_builder::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(string),
            US4_1,
        }
        impl Spiral_builder::US4 {
            pub fn get_IsUS4_0(this_: &MutCell<Spiral_builder::US4>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS4_1(this_: &MutCell<Spiral_builder::US4>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Spiral_builder::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Spiral_builder::Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH0 {
            UH0_0,
            UH0_1(string, LrcPtr<Spiral_builder::UH0>),
        }
        impl Spiral_builder::UH0 {
            pub fn get_IsUH0_0(this_: LrcPtr<Spiral_builder::UH0>, unitArg: ()) -> bool {
                if let Spiral_builder::UH0::UH0_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH0_1(this_: LrcPtr<Spiral_builder::UH0>, unitArg: ()) -> bool {
                if let Spiral_builder::UH0::UH0_1(this__1_0, this__1_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH1 {
            UH1_0,
            UH1_1(char, LrcPtr<Spiral_builder::UH1>),
        }
        impl Spiral_builder::UH1 {
            pub fn get_IsUH1_0(this_: LrcPtr<Spiral_builder::UH1>, unitArg: ()) -> bool {
                if let Spiral_builder::UH1::UH1_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH1_1(this_: LrcPtr<Spiral_builder::UH1>, unitArg: ()) -> bool {
                if let Spiral_builder::UH1::UH1_1(this__1_0, this__1_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0,
            US5_1(char),
            US5_2(u8),
        }
        impl Spiral_builder::US5 {
            pub fn get_IsUS5_0(this_: &MutCell<Spiral_builder::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS5_1(this_: &MutCell<Spiral_builder::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS5_2(this_: &MutCell<Spiral_builder::US5>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(std::string::String, clap::ArgMatches),
            US6_1,
        }
        impl Spiral_builder::US6 {
            pub fn get_IsUS6_0(this_: &MutCell<Spiral_builder::US6>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS6_1(this_: &MutCell<Spiral_builder::US6>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"file\"#");
            let v7: &'static str = r#"file"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.short('f');
            let v12: string = string("r#\"file\"#");
            let v13: &'static str = r#"file"#;
            let v15: clap::Arg = v11.long(v13);
            let v17: clap::Arg = v15.required(true);
            let v19: clap::Command = clap::Command::arg(v4, v17);
            let v21: string = string("r#\"out-dir\"#");
            let v22: &'static str = r#"out-dir"#;
            let v24: clap::Arg = clap::Arg::new(v22);
            let v26: clap::Arg = v24.short('o');
            let v27: string = string("r#\"out-dir\"#");
            let v28: &'static str = r#"out-dir"#;
            let v30: clap::Arg = v26.long(v28);
            let v32: clap::Arg = v30.required(true);
            let v34: clap::Command = clap::Command::arg(v19, v32);
            let v36: string = string("r#\"hash\"#");
            let v37: &'static str = r#"hash"#;
            let v39: clap::Arg = clap::Arg::new(v37);
            let v41: clap::Arg = v39.short('h');
            let v42: string = string("r#\"hash\"#");
            let v43: &'static str = r#"hash"#;
            let v45: clap::Arg = v41.long(v43);
            let v47: clap::Arg = v45.required(true);
            let v49: clap::Command = clap::Command::arg(v34, v47);
            let v51: string = string("r#\"args\"#");
            let v52: &'static str = r#"args"#;
            let v54: clap::Arg = clap::Arg::new(v52);
            let v56: clap::Arg = v54.short('a');
            let v57: string = string("r#\"args\"#");
            let v58: &'static str = r#"args"#;
            let v60: clap::Arg = v56.long(v58);
            clap::Command::arg(v49, v60)
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {
            let v1_1: bool = true;
            () //;
        } /* /*;
          {
              let v4: string = string("*/ #[test] fn verify_app() { //");
              let v5: bool = */
        #[test]
        fn verify_app() {
            //;
            let v6: clap::Command = Spiral_builder::method0();
            clap::Command::debug_assert(v6);
            {
                //;
                ()
            }
        }
        pub fn closure3(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn method2(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn closure2(
            unitVar: (),
            unitVar_1: (),
        ) -> (
            LrcPtr<Spiral_builder::Mut0>,
            LrcPtr<Spiral_builder::Mut1>,
            LrcPtr<Spiral_builder::Mut2>,
            Option<i64>,
            LrcPtr<Spiral_builder::Mut3>,
        ) {
            let v0_1: LrcPtr<Spiral_builder::Mut1> = LrcPtr::new(Spiral_builder::Mut1 {
                l0: MutCell::new(true),
            });
            let v1_1: LrcPtr<Spiral_builder::Mut0> = LrcPtr::new(Spiral_builder::Mut0 {
                l0: MutCell::new(0_i64),
            });
            let v3: LrcPtr<Spiral_builder::Mut2> = LrcPtr::new(Spiral_builder::Mut2 {
                l0: MutCell::new(Spiral_builder::US0::US0_0),
            });
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Spiral_builder::closure3((), v))),
            });
            let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
            {
                let x: Option<i64> = Spiral_builder::method2(None::<i64>);
                _v6.set(Some(x))
            }
            (v1_1, v0_1, v3, getValue(_v6.get().clone()), v5)
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.main")
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) -> string {
            sprintf!("args: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn closure8(unitVar: (), v0_1: i64) -> Spiral_builder::US2 {
            Spiral_builder::US2::US2_0(v0_1)
        }
        pub fn method4() -> Func1<i64, Spiral_builder::US2> {
            Func1::new(move |v: i64| Spiral_builder::closure8((), v))
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure7(
            v0_1: Spiral_builder::US0,
            v1_1: Func0<string>,
            v2: Func0<string>,
            unitVar: (),
        ) -> string {
            if Spiral_builder::State::trace_state().get().clone().is_none() {
                Spiral_builder::State::trace_state().set(Some(Spiral_builder::closure2((), ())));
            }
            {
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    Option<i64>,
                    LrcPtr<Spiral_builder::Mut3>,
                ) = getValue(Spiral_builder::State::trace_state().get().clone());
                let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v13: Spiral_builder::US2 = defaultValue(
                    Spiral_builder::US2::US2_1,
                    map(Spiral_builder::method4(), patternInput.3.clone()),
                );
                let v31: DateTime = match &v13 {
                    Spiral_builder::US2::US2_0(v13_0_0) => {
                        let v19: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v13 {
                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v19.hours(),
                            v19.minutes(),
                            v19.seconds(),
                            v19.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x: string = v31.toString(string("hh:mm:ss"));
                    _v9.set(Some(x))
                }
                {
                    let v61: string = getValue(_v9.get().clone());
                    let v62: i64 = (patternInput.0.clone()).l0.get().clone();
                    let v74: string = padLeft(
                        toLower(match &v0_1 {
                            Spiral_builder::US0::US0_1 => string("Debug"),
                            Spiral_builder::US0::US0_2 => string("Info"),
                            Spiral_builder::US0::US0_0 => string("Verbose"),
                            Spiral_builder::US0::US0_3 => string("Warning"),
                            _ => string("Critical"),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v91: &str = match &v0_1 {
                        Spiral_builder::US0::US0_1 => inline_colorization::color_bright_blue,
                        Spiral_builder::US0::US0_2 => inline_colorization::color_bright_green,
                        Spiral_builder::US0::US0_0 => inline_colorization::color_bright_black,
                        Spiral_builder::US0::US0_3 => inline_colorization::color_bright_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v93: &str = fable_library_rust::String_::LrcStr::as_str(&v74);
                    let v95: &str = inline_colorization::color_reset;
                    let v97: string = string("format!(\"{v91}{v93}{v95}\")");
                    let v98: std::string::String = format!("{v91}{v93}{v95}");
                    {
                        let x_1: string = fable_library_rust::String_::fromString(v98);
                        _v75.set(Some(x_1))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v61,
                                getValue(_v75.get().clone()),
                                v62,
                                v1_1(),
                                v2()
                            ),
                            new_empty::<char>(),
                        ),
                        new_array(&[' ', '/']),
                    )
                }
            }
        }
        pub fn method6(v0_1: Spiral_builder::US0, v1_1: Func0<string>) {
            fn v2() -> (
                LrcPtr<Spiral_builder::Mut0>,
                LrcPtr<Spiral_builder::Mut1>,
                LrcPtr<Spiral_builder::Mut2>,
                Option<i64>,
                LrcPtr<Spiral_builder::Mut3>,
            ) {
                Spiral_builder::closure2((), ())
            }
            if Spiral_builder::State::trace_state().get().clone().is_none() {
                Spiral_builder::State::trace_state().set(Some(v2()));
            }
            {
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    Option<i64>,
                    LrcPtr<Spiral_builder::Mut3>,
                ) = getValue(Spiral_builder::State::trace_state().get().clone());
                let v3: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                if Spiral_builder::State::trace_state().get().clone().is_none() {
                    Spiral_builder::State::trace_state().set(Some(v2()));
                }
                {
                    let patternInput_1: (
                        LrcPtr<Spiral_builder::Mut0>,
                        LrcPtr<Spiral_builder::Mut1>,
                        LrcPtr<Spiral_builder::Mut2>,
                        Option<i64>,
                        LrcPtr<Spiral_builder::Mut3>,
                    ) = getValue(Spiral_builder::State::trace_state().get().clone());
                    let v13: Spiral_builder::US0 = (patternInput_1.2.clone()).l0.get().clone();
                    if if (patternInput_1.1.clone()).l0.get().clone() == false {
                        false
                    } else {
                        find(
                            v0_1,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                            ])))),
                        ) >= find(
                            v13,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                            ])))),
                        )
                    } {
                        let v21: i64 = v3.l0.get().clone() + 1_i64;
                        v3.l0.set(v21);
                        {
                            let v22: string = sprintf!("{}", v1_1());
                            let _v23: MutCell<Option<()>> = MutCell::new(None::<()>);
                            println!("{}", v22.clone());
                            _v23.set(Some(()));
                            getValue(_v23.get().clone());
                            ((patternInput.4.clone()).l0.get().clone())(v22)
                        }
                    }
                }
            }
        }
        pub fn method3(v0_1: Spiral_builder::US0, v1_1: Func0<string>, v2: Func0<string>) {
            Spiral_builder::method6(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Spiral_builder::closure7(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method7() -> string {
            string("file")
        }
        pub fn closure9(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US3 {
            Spiral_builder::US3::US3_0(v0_1)
        }
        pub fn method8() -> Func1<std::string::String, Spiral_builder::US3> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure9((), v))
        }
        pub fn method9() -> string {
            string("out-dir")
        }
        pub fn method10() -> string {
            string("hash")
        }
        pub fn method11() -> string {
            string("args")
        }
        pub fn method13(v0_1: string) -> string {
            v0_1
        }
        pub fn method14(v0_1: string) -> string {
            v0_1
        }
        pub fn method16(v0_1: string) -> string {
            v0_1
        }
        pub fn method17(v0_1: string) -> string {
            v0_1
        }
        pub fn method15(v0_1: string, v1_1: string) -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Spiral_builder::method14(v0_1);
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            let v11: string = Spiral_builder::method14(v1_1);
            let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
            let v15: std::string::String = String::from(v13);
            let v17: std::path::PathBuf = v10.join(v15);
            let v19: std::path::Display = v17.display();
            let _v20: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v19);
                _v20.set(Some(x))
            }
            {
                let v31: std::string::String = getValue(_v20.get().clone());
                {
                    let x_1: string = fable_library_rust::String_::fromString(v31);
                    _v2.set(Some(x_1))
                }
                getValue(_v2.get().clone())
            }
        }
        pub fn method18() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method19(v0_1: string) -> string {
            v0_1
        }
        pub fn method20() -> string {
            string("")
        }
        pub fn method21(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method22(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method23(v0_1: string) -> string {
            v0_1
        }
        pub fn method24(v0_1: string) -> string {
            v0_1
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run")
        }
        pub fn closure11(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            unitVar: (),
        ) -> string {
            sprintf!(
                "file: {} / out_dir: {} / hash: {} / args: {} / {}",
                v2,
                v3,
                v1_1,
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method26() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: clap::Command = clap::Command::subcommand_required(v4, true);
            let v8: string = string("r#\"rust\"#");
            let v9: &'static str = r#"rust"#;
            let v11: clap::Command = clap::Command::new(v9);
            clap::Command::subcommand(v6, v11)
        }
        pub fn closure12(unitVar: (), v0_1: string) -> Spiral_builder::US4 {
            Spiral_builder::US4::US4_0(v0_1)
        }
        pub fn method28() -> Func1<string, Spiral_builder::US4> {
            Func1::new(move |v: string| Spiral_builder::closure12((), v))
        }
        pub fn closure14(
            v0_1: char,
            v1_1: LrcPtr<Spiral_builder::UH1>,
        ) -> LrcPtr<Spiral_builder::UH1> {
            LrcPtr::new(Spiral_builder::UH1::UH1_1(v0_1, v1_1))
        }
        pub fn closure13(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Spiral_builder::UH1>, LrcPtr<Spiral_builder::UH1>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Spiral_builder::UH1>| Spiral_builder::closure14(v0_1, v)
            })
        }
        pub fn method29(
        ) -> Func1<char, Func1<LrcPtr<Spiral_builder::UH1>, LrcPtr<Spiral_builder::UH1>>> {
            Func1::new(move |v: char| Spiral_builder::closure13((), v))
        }
        pub fn method32(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: LrcPtr<Spiral_builder::UH0>,
        ) -> LrcPtr<Spiral_builder::UH0> {
            match v0_1.as_ref() {
                Spiral_builder::UH0::UH0_0 => v1_1.clone(),
                Spiral_builder::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                    LrcPtr::new(Spiral_builder::UH0::UH0_1(
                        match v0_1.as_ref() {
                            Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        Spiral_builder::method32(
                            match v0_1.as_ref() {
                                Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            },
                            v1_1.clone(),
                        ),
                    ))
                }
            }
        }
        pub fn method31(
            v0_1: string,
            v1_1: LrcPtr<Spiral_builder::UH0>,
            v2: LrcPtr<Spiral_builder::UH1>,
            v3: Spiral_builder::US5,
        ) -> (LrcPtr<Spiral_builder::UH0>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US5> = MutCell::new(v3.clone());
            '_method31: loop {
                break '_method31 (match &v3.get().clone() {
                    Spiral_builder::US5::US5_1(v3_1_0) => {
                        let v105: char = v3_1_0.clone();
                        if '\"' == v105 {
                            if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                v2.get().clone().as_ref()
                            {
                                let v108: LrcPtr<Spiral_builder::UH1> =
                                    match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                let v107: char = match v2.get().clone().as_ref() {
                                    Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\"' == v107 {
                                    if v3.get().clone() == Spiral_builder::US5::US5_1('\\') {
                                        Spiral_builder::method30(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v108.clone(),
                                            v3.get().clone(),
                                            Spiral_builder::US5::US5_0,
                                        )
                                    } else {
                                        if '\\' == v105 {
                                            if !(v3.get().clone()
                                                == Spiral_builder::US5::US5_2(0_u8))
                                            {
                                                Spiral_builder::method30(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_1('\"'),
                                                )
                                            } else {
                                                if v3.get().clone()
                                                    == Spiral_builder::US5::US5_1('\\')
                                                {
                                                    Spiral_builder::method30(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_1('\"'),
                                                    )
                                                } else {
                                                    Spiral_builder::method30(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_0,
                                                    )
                                                }
                                            }
                                        } else {
                                            if '\\' == v107 {
                                                Spiral_builder::method30(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_2(1_u8),
                                                )
                                            } else {
                                                if v3.get().clone()
                                                    == Spiral_builder::US5::US5_2(0_u8)
                                                {
                                                    Spiral_builder::method30(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_1('\"'),
                                                    )
                                                } else {
                                                    Spiral_builder::method30(
                                                        string(""),
                                                        Spiral_builder::method32(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        ),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_0,
                                                    )
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    if '\\' == v105 {
                                        if '\\' == v107 {
                                            Spiral_builder::method30(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v107 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v108.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v107);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v108.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            }
                                        }
                                    } else {
                                        if '\\' == v107 {
                                            Spiral_builder::method30(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108,
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v107 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v108.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v107);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v108.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            }
                                        }
                                    }
                                }
                            } else {
                                if '\\' == v105 {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method32(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method32(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            }
                        } else {
                            if '\\' == v105 {
                                if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v220: LrcPtr<Spiral_builder::UH1> =
                                        match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v219: char = match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v219 {
                                        if !(v3.get().clone() == Spiral_builder::US5::US5_2(0_u8)) {
                                            Spiral_builder::method30(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_1('\"'),
                                            )
                                        } else {
                                            if v3.get().clone() == Spiral_builder::US5::US5_1('\\')
                                            {
                                                Spiral_builder::method30(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_1('\"'),
                                                )
                                            } else {
                                                Spiral_builder::method30(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_0,
                                                )
                                            }
                                        }
                                    } else {
                                        if '\\' == v219 {
                                            Spiral_builder::method30(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v219 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v220;
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v219);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v220.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method32(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            } else {
                                if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v270: LrcPtr<Spiral_builder::UH1> =
                                        match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v269: char = match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\\' == v269 {
                                        Spiral_builder::method30(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v270.clone(),
                                            v3.get().clone(),
                                            Spiral_builder::US5::US5_2(1_u8),
                                        )
                                    } else {
                                        if '\"' == v269 {
                                            if v3.get().clone() == Spiral_builder::US5::US5_2(0_u8)
                                            {
                                                Spiral_builder::method30(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_1('\"'),
                                                )
                                            } else {
                                                Spiral_builder::method30(
                                                    string(""),
                                                    Spiral_builder::method32(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                        )),
                                                    ),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_0,
                                                )
                                            }
                                        } else {
                                            if ' ' == v269 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v270;
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v269);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v270.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method32(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            }
                        }
                    }
                    Spiral_builder::US5::US5_0 => {
                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                            v2.get().clone().as_ref()
                        {
                            let v5: LrcPtr<Spiral_builder::UH1> = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v4: char = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\"' == v4 {
                                Spiral_builder::method30(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Spiral_builder::US5::US5_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Spiral_builder::method30(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v5.clone(),
                                        v3.get().clone(),
                                        Spiral_builder::US5::US5_2(0_u8),
                                    )
                                } else {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = string("");
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method32(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                    )),
                                                )
                                            };
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5;
                                        let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method31;
                                    } else {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method31;
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Spiral_builder::method32(
                                        v1_1.get().clone(),
                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        )),
                                    )
                                },
                                v0_1.get().clone(),
                            )
                        }
                    }
                    Spiral_builder::US5::US5_2(v3_2_0) => {
                        let v44: u8 = match &v3.get().clone() {
                            Spiral_builder::US5::US5_2(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                            v2.get().clone().as_ref()
                        {
                            let v46: LrcPtr<Spiral_builder::UH1> = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v45: char = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\\' == v45 {
                                Spiral_builder::method30(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v46.clone(),
                                    v3.get().clone(),
                                    Spiral_builder::US5::US5_1('\\'),
                                )
                            } else {
                                if '\"' == v45 {
                                    if if let Spiral_builder::US5::US5_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v46.clone();
                                        let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method31;
                                    } else {
                                        Spiral_builder::method30(
                                            sprintf!("{}\"", v0_1.get().clone()),
                                            v1_1.get().clone(),
                                            v46.clone(),
                                            v3.get().clone(),
                                            Spiral_builder::US5::US5_2(v44),
                                        )
                                    }
                                } else {
                                    if ' ' == v45 {
                                        let v0_1_temp: string = sprintf!("{} ", v0_1.get().clone());
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v46.clone();
                                        let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method31;
                                    } else {
                                        if 1_u8 == v44 {
                                            if !(v3.get().clone() == v3.get().clone()) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\\{}", v0_1.get().clone(), v45);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v46.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v45);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v46.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method31;
                                            }
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v45);
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v46.clone();
                                            let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method31;
                                        }
                                    }
                                }
                            }
                        } else {
                            if 1_u8 == v44 {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Spiral_builder::method32(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Spiral_builder::method32(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        }
                    }
                });
            }
        }
        pub fn method30(
            v0_1: string,
            v1_1: LrcPtr<Spiral_builder::UH0>,
            v2: LrcPtr<Spiral_builder::UH1>,
            v3: Spiral_builder::US5,
            v4: Spiral_builder::US5,
        ) -> (LrcPtr<Spiral_builder::UH0>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US5> = MutCell::new(v3.clone());
            let v4: MutCell<Spiral_builder::US5> = MutCell::new(v4.clone());
            '_method30: loop {
                break '_method30 (match &v4.get().clone() {
                    Spiral_builder::US5::US5_1(v4_1_0) => {
                        let v106: char = v4_1_0.clone();
                        if '\"' == v106 {
                            if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                v2.get().clone().as_ref()
                            {
                                let v109: LrcPtr<Spiral_builder::UH1> =
                                    match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                let v108: char = match v2.get().clone().as_ref() {
                                    Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\"' == v108 {
                                    if v3.get().clone() == Spiral_builder::US5::US5_1('\\') {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v109.clone();
                                        let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                        let v4_temp: Spiral_builder::US5 =
                                            Spiral_builder::US5::US5_0;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method30;
                                    } else {
                                        if '\\' == v106 {
                                            if !(v3.get().clone()
                                                == Spiral_builder::US5::US5_2(0_u8))
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v109.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method30;
                                            } else {
                                                if v3.get().clone()
                                                    == Spiral_builder::US5::US5_1('\\')
                                                {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}\"", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v109.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method30;
                                                } else {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v109.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method30;
                                                }
                                            }
                                        } else {
                                            if '\\' == v108 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v109.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(1_u8);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method30;
                                            } else {
                                                if v3.get().clone()
                                                    == Spiral_builder::US5::US5_2(0_u8)
                                                {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}\"", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v109.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method30;
                                                } else {
                                                    let v0_1_temp: string = string("");
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        Spiral_builder::method32(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        );
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v109.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method30;
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    if '\\' == v106 {
                                        if '\\' == v108 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v109.clone();
                                            let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US5 =
                                                Spiral_builder::US5::US5_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method30;
                                        } else {
                                            if ' ' == v108 {
                                                Spiral_builder::method31(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Spiral_builder::method31(
                                                    sprintf!("{}{}", v0_1.get().clone(), v108),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        }
                                    } else {
                                        if '\\' == v108 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v109.clone();
                                            let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US5 =
                                                Spiral_builder::US5::US5_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method30;
                                        } else {
                                            if ' ' == v108 {
                                                Spiral_builder::method31(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Spiral_builder::method31(
                                                    sprintf!("{}{}", v0_1.get().clone(), v108),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                }
                            } else {
                                if '\\' == v106 {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method32(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method32(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            }
                        } else {
                            if '\\' == v106 {
                                if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v221: LrcPtr<Spiral_builder::UH1> =
                                        match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v220: char = match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v220 {
                                        if !(v3.get().clone() == Spiral_builder::US5::US5_2(0_u8)) {
                                            let v0_1_temp: string =
                                                sprintf!("{}\"", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v221.clone();
                                            let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US5 =
                                                Spiral_builder::US5::US5_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method30;
                                        } else {
                                            if v3.get().clone() == Spiral_builder::US5::US5_1('\\')
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v221.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method30;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v221;
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method30;
                                            }
                                        }
                                    } else {
                                        if '\\' == v220 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v221.clone();
                                            let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US5 =
                                                Spiral_builder::US5::US5_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method30;
                                        } else {
                                            if ' ' == v220 {
                                                Spiral_builder::method31(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Spiral_builder::method31(
                                                    sprintf!("{}{}", v0_1.get().clone(), v220),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method32(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            } else {
                                if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v271: LrcPtr<Spiral_builder::UH1> =
                                        match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v270: char = match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\\' == v270 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v271.clone();
                                        let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                        let v4_temp: Spiral_builder::US5 =
                                            Spiral_builder::US5::US5_2(1_u8);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method30;
                                    } else {
                                        if '\"' == v270 {
                                            if v3.get().clone() == Spiral_builder::US5::US5_2(0_u8)
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v271.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method30;
                                            } else {
                                                let v0_1_temp: string = string("");
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    Spiral_builder::method32(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                        )),
                                                    );
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v271.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method30;
                                            }
                                        } else {
                                            if ' ' == v270 {
                                                Spiral_builder::method31(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Spiral_builder::method31(
                                                    sprintf!("{}{}", v0_1.get().clone(), v270),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method32(
                                                v1_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                )),
                                            )
                                        },
                                        v0_1.get().clone(),
                                    )
                                }
                            }
                        }
                    }
                    Spiral_builder::US5::US5_0 => {
                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                            v2.get().clone().as_ref()
                        {
                            let v6: LrcPtr<Spiral_builder::UH1> = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v5: char = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\"' == v5 {
                                let v0_1_temp: string = string("");
                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v6.clone();
                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                let v4_temp: Spiral_builder::US5 = Spiral_builder::US5::US5_1('\"');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method30;
                            } else {
                                if '\\' == v5 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v6;
                                    let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                    let v4_temp: Spiral_builder::US5 =
                                        Spiral_builder::US5::US5_2(0_u8);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method30;
                                } else {
                                    if ' ' == v5 {
                                        Spiral_builder::method31(
                                            string(""),
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method32(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                    )),
                                                )
                                            },
                                            v6.clone(),
                                            v4.get().clone(),
                                        )
                                    } else {
                                        Spiral_builder::method31(
                                            sprintf!("{}{}", v0_1.get().clone(), v5),
                                            v1_1.get().clone(),
                                            v6.clone(),
                                            v4.get().clone(),
                                        )
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Spiral_builder::method32(
                                        v1_1.get().clone(),
                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        )),
                                    )
                                },
                                v0_1.get().clone(),
                            )
                        }
                    }
                    Spiral_builder::US5::US5_2(v4_2_0) => {
                        let v45: u8 = match &v4.get().clone() {
                            Spiral_builder::US5::US5_2(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                            v2.get().clone().as_ref()
                        {
                            let v47: LrcPtr<Spiral_builder::UH1> = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v46: char = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\\' == v46 {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v47.clone();
                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                let v4_temp: Spiral_builder::US5 = Spiral_builder::US5::US5_1('\\');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method30;
                            } else {
                                if '\"' == v46 {
                                    if if let Spiral_builder::US5::US5_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        Spiral_builder::method31(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v47.clone(),
                                            v4.get().clone(),
                                        )
                                    } else {
                                        let v0_1_temp: string =
                                            sprintf!("{}\"", v0_1.get().clone());
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v47.clone();
                                        let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                        let v4_temp: Spiral_builder::US5 =
                                            Spiral_builder::US5::US5_2(v45);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method30;
                                    }
                                } else {
                                    if ' ' == v46 {
                                        Spiral_builder::method31(
                                            sprintf!("{} ", v0_1.get().clone()),
                                            v1_1.get().clone(),
                                            v47.clone(),
                                            v4.get().clone(),
                                        )
                                    } else {
                                        if 1_u8 == v45 {
                                            if !(v3.get().clone() == v4.get().clone()) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\\{}", v0_1.get().clone(), v46);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v47.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method30;
                                            } else {
                                                Spiral_builder::method31(
                                                    sprintf!("{}{}", v0_1.get().clone(), v46),
                                                    v1_1.get().clone(),
                                                    v47.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        } else {
                                            Spiral_builder::method31(
                                                sprintf!("{}{}", v0_1.get().clone(), v46),
                                                v1_1.get().clone(),
                                                v47.clone(),
                                                v4.get().clone(),
                                            )
                                        }
                                    }
                                }
                            }
                        } else {
                            if 1_u8 == v45 {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Spiral_builder::method32(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            } else {
                                (
                                    if v0_1.get().clone() == string("") {
                                        v1_1.get().clone()
                                    } else {
                                        Spiral_builder::method32(
                                            v1_1.get().clone(),
                                            LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                v0_1.get().clone(),
                                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                            )),
                                        )
                                    },
                                    v0_1.get().clone(),
                                )
                            }
                        }
                    }
                });
            }
        }
        pub fn method33(v0_1: LrcPtr<Spiral_builder::UH0>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Spiral_builder::UH0::UH0_0 => v1_1.clone(),
                Spiral_builder::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Spiral_builder::method33(
                        match v0_1.as_ref() {
                            Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method27(v0_1: string) -> Array<string> {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v6: Option<string> = getValue(_v0.get().clone());
                let v9: Spiral_builder::US4 = defaultValue(
                    Spiral_builder::US4::US4_1,
                    map(Spiral_builder::method28(), v6),
                );
                let v12: string = match &v9 {
                    Spiral_builder::US4::US4_0(v9_0_0) => match &v9 {
                        Spiral_builder::US4::US4_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => string(""),
                };
                let v13: i32 = length(v12.clone());
                let v14: Array<char> = new_init(&'\u{0000}', v13);
                let v15: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                    l0: MutCell::new(0_i32),
                });
                while Spiral_builder::method22(v13, v15.clone()) {
                    let v17: i32 = v15.l0.get().clone();
                    let v18: char = getCharAt(v12.clone(), v17);
                    v14.get_mut()[v17 as usize] = v18;
                    {
                        let v19: i32 = v17 + 1_i32;
                        v15.l0.set(v19);
                        ()
                    }
                }
                {
                    let v21: List<char> = ofArray(v14.clone());
                    toArray(Spiral_builder::method33(
                        (Spiral_builder::method30(
                            string(""),
                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                            foldBack(
                                Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                    (Spiral_builder::method29())(b0)(b1)
                                }),
                                v21,
                                LrcPtr::new(Spiral_builder::UH1::UH1_0),
                            ),
                            Spiral_builder::US5::US5_0,
                            Spiral_builder::US5::US5_0,
                        ))
                        .0
                        .clone(),
                        empty::<string>(),
                    ))
                }
            }
        }
        pub fn closure15(unitVar: (), v0_1: string) -> std::string::String {
            let v1_1: string = Spiral_builder::method14(v0_1);
            let v3: &str = fable_library_rust::String_::LrcStr::as_str(&v1_1);
            String::from(v3)
        }
        pub fn closure16(unitVar: (), v0_1: &str) -> std::string::String {
            String::from(v0_1)
        }
        pub fn closure17(
            unitVar: (),
            _arg: (std::string::String, clap::ArgMatches),
        ) -> Spiral_builder::US6 {
            Spiral_builder::US6::US6_0(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method34() -> Func1<(std::string::String, clap::ArgMatches), Spiral_builder::US6> {
            Func1::new(move |arg10_0040: (std::string::String, clap::ArgMatches)| {
                Spiral_builder::closure17((), arg10_0040)
            })
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run")
        }
        pub fn closure19(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "subcommand: {} / {}",
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure20(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run")
        }
        pub fn closure21(v0_1: string, unitVar: ()) -> string {
            sprintf!("result: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn method35(
            v0_1: Result<string, std::string::String>,
        ) -> Result<string, std::string::String> {
            v0_1
        }
        pub fn method25(
            v0_1: string,
            v1_1: string,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, std::string::String>>>>
        {
            let __result = Box::pin(async move {
                //;
                {
                    let v3: clap::Command = Spiral_builder::method26();
                    let v5: Array<string> =
                        Spiral_builder::method27(sprintf!("spiral_builder {}", v0_1));
                    let v7: Vec<string> = v5.to_vec();
                    let v10: Vec<std::string::String> = v7
                        .iter()
                        .map(|x| {
                            Func1::new(move |v: string| Spiral_builder::closure15((), v))(x.clone())
                        })
                        .collect();
                    let v12: clap::ArgMatches = clap::Command::get_matches_from(v3, v10);
                    let v14: clap::ArgMatches = v12.clone();
                    let v17: Option<(std::string::String, clap::ArgMatches)> =
                        clap::ArgMatches::subcommand(Box::leak(Box::new(v14))).map(|(a, b)| {
                            (
                                Func1::new(move |v_1: &str| Spiral_builder::closure16((), v_1))(a),
                                b.clone(),
                            )
                        });
                    let v20: Spiral_builder::US6 = defaultValue(
                        Spiral_builder::US6::US6_1,
                        map(Spiral_builder::method34(), v17),
                    );
                    let v28: string = if let Spiral_builder::US6::US6_0(v20_0_0, v20_0_1) = &v20 {
                        Spiral_builder::method3(
                            Spiral_builder::US0::US0_1,
                            Func0::new(move || Spiral_builder::closure18((), ())),
                            Func0::new({
                                let v20 = v20.clone();
                                move || {
                                    Spiral_builder::closure19(
                                        match &v20 {
                                            Spiral_builder::US6::US6_0(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        (),
                                    )
                                }
                            }),
                        );
                        sprintf!("[package]\nname = \"{}\"\nversion = \"0.0.1\"\nedition = \"2021\"\n\n[workspace]\n\n[dependencies]\nfable_library_rust = {{ path = \"fable_modules/fable-library-rust\", default-features = false, features = [\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"] }}\nclap = \"~4.5\"\ninline_colorization = \"~0.1\"\nregex = \"~1.10\"\nchrono = \"~0.4\"\nnum-complex = \"~0.4\"\npyo3 = \"~0.21\"\nasync-std = \"~1.12\"\nfutures = \"~0.3\"\nfutures-lite = \"~2.3\"\nasync-walkdir = \"~1.0\"\nrayon = \"~1.10\"\n\n[[bin]]\nname = \"{}\"\npath = \"{}.rs\" ",
                                 v1_1.clone(), v1_1.clone(), v1_1)
                    } else {
                        string("")
                    };
                    Spiral_builder::method3(
                        Spiral_builder::US0::US0_1,
                        Func0::new(move || Spiral_builder::closure20((), ())),
                        Func0::new({
                            let v28 = v28.clone();
                            move || Spiral_builder::closure21(v28.clone(), ())
                        }),
                    );
                    {
                        let v33: Result<string, std::string::String> = Spiral_builder::method35(
                            Ok::<string, std::string::String>(v28.clone()),
                        );
                        v33
                    }
                }
            });
            {
                {
                    //;
                    __result
                }
            }
        }
        pub fn method12(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, std::string::String>>>>
        {
            let _v4: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v6: string = Spiral_builder::method13(v3);
            let v7: string = Spiral_builder::method14(v6.clone());
            let v9: &str = fable_library_rust::String_::LrcStr::as_str(&v7);
            let v11: std::string::String = String::from(v9);
            let v13: std::path::PathBuf = std::path::PathBuf::from(v11);
            {
                let x_5: string = if v13.exists() == false {
                    let _v17: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v20: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v22: std::path::PathBuf = v20.unwrap();
                    let v24: std::path::Display = v22.display();
                    let _v25: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v24);
                        _v25.set(Some(x))
                    }
                    {
                        let v36: std::string::String = getValue(_v25.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v36);
                            _v17.set(Some(x_1))
                        }
                        {
                            let v45: string = getValue(_v17.get().clone());
                            let v46: string = Spiral_builder::method15(v45.clone(), v6.clone());
                            let _v47: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v49: string = Spiral_builder::method18();
                            let v50: string = Spiral_builder::method19(v46);
                            let v51: string = Spiral_builder::method20();
                            let v53: std::borrow::Cow<str> =
                                regex::Regex::new(&v49).unwrap().replace_all(&v50, &*v51);
                            let v55: std::string::String = String::from(v53);
                            {
                                let x_2: string = fable_library_rust::String_::fromString(v55);
                                _v47.set(Some(x_2))
                            }
                            {
                                let v65: string = getValue(_v47.get().clone());
                                let v70: Array<string> = split(
                                    replace(
                                        sprintf!(
                                            "{}{}",
                                            toLower(ofChar(getCharAt(v65.clone(), 0_i32))),
                                            getSlice(v65, Some(1_i32), None::<i32>)
                                        ),
                                        string("\\"),
                                        string("/"),
                                    ),
                                    string("/"),
                                    -1_i32,
                                    0_i32,
                                );
                                let v72: i32 = count(v70.clone());
                                let v73: LrcPtr<Spiral_builder::Mut4> =
                                    LrcPtr::new(Spiral_builder::Mut4 {
                                        l0: MutCell::new(0_i32),
                                        l1: MutCell::new(0_i32),
                                        l2: MutCell::new(new_empty::<string>()),
                                    });
                                while Spiral_builder::method21(v72, v73.clone()) {
                                    let v75: i32 = v73.l0.get().clone();
                                    let v78: i32 = v75.wrapping_neg() + v72 - 1_i32;
                                    let matchValue: i32 = v73.l1.get().clone();
                                    let v80: Array<string> = v73.l2.get().clone();
                                    let v79: i32 = matchValue;
                                    let v81: string = v70[v78].clone();
                                    let patternInput_1: (i32, Array<string>) = if string("..")
                                        == v81.clone()
                                    {
                                        (v79 + 1_i32, v80.clone())
                                    } else {
                                        if 0_i32 == v79 {
                                            if endsWith(v81.clone(), string(":"), false) {
                                                let v88: Array<string> = new_array(&[sprintf!(
                                                    "{}:",
                                                    getCharAt(v45.clone(), 0_i32)
                                                )]);
                                                let v89: i32 = count(v88.clone());
                                                let v91: i32 = v89 + count(v80.clone());
                                                let v92: Array<string> = new_init(&string(""), v91);
                                                let v93: LrcPtr<Spiral_builder::Mut5> =
                                                    LrcPtr::new(Spiral_builder::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Spiral_builder::method22(v91, v93.clone()) {
                                                    let v95: i32 = v93.l0.get().clone();
                                                    let v100: string = if v95 < v89 {
                                                        v88[v95].clone()
                                                    } else {
                                                        let v98: i32 = v95 - v89;
                                                        v80[v98].clone()
                                                    };
                                                    v92.get_mut()[v95 as usize] = v100;
                                                    {
                                                        let v101: i32 = v95 + 1_i32;
                                                        v93.l0.set(v101);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v92.clone())
                                            } else {
                                                let v102: Array<string> = new_array(&[v81]);
                                                let v103: i32 = count(v102.clone());
                                                let v105: i32 = v103 + count(v80.clone());
                                                let v106: Array<string> =
                                                    new_init(&string(""), v105);
                                                let v107: LrcPtr<Spiral_builder::Mut5> =
                                                    LrcPtr::new(Spiral_builder::Mut5 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Spiral_builder::method22(v105, v107.clone()) {
                                                    let v109: i32 = v107.l0.get().clone();
                                                    let v114: string = if v109 < v103 {
                                                        v102[v109].clone()
                                                    } else {
                                                        let v112: i32 = v109 - v103;
                                                        v80[v112].clone()
                                                    };
                                                    v106.get_mut()[v109 as usize] = v114;
                                                    {
                                                        let v115: i32 = v109 + 1_i32;
                                                        v107.l0.set(v115);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v106.clone())
                                            }
                                        } else {
                                            (v79 - 1_i32, v80.clone())
                                        }
                                    };
                                    let v123: i32 = v75 + 1_i32;
                                    v73.l0.set(v123);
                                    v73.l1.set(patternInput_1.0.clone());
                                    v73.l2.set(patternInput_1.1.clone());
                                    ()
                                }
                                {
                                    let matchValue_2: i32 = v73.l1.get().clone();
                                    let v125: Array<string> = v73.l2.get().clone();
                                    let v126: LrcPtr<dyn IEnumerable_1<string>> =
                                        delay(Func0::new({
                                            let v125 = v125.clone();
                                            move || {
                                                map_1(
                                                    Func1::new({
                                                        let v125 = v125.clone();
                                                        move |i: i32| v125[i].clone()
                                                    }),
                                                    rangeNumeric(
                                                        0_i32,
                                                        1_i32,
                                                        count(v125.clone()) - 1_i32,
                                                    ),
                                                )
                                            }
                                        }));
                                    let _v127: MutCell<Option<char>> = MutCell::new(None::<char>);
                                    {
                                        let x_3: char = std::path::MAIN_SEPARATOR;
                                        _v127.set(Some(x_3))
                                    }
                                    join(
                                        Spiral_builder::method23(ofChar(getValue(
                                            _v127.get().clone(),
                                        ))),
                                        toArray_1(v126),
                                    )
                                }
                            }
                        }
                    }
                } else {
                    let v144: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v6);
                    let v146: std::path::PathBuf = v144.unwrap();
                    let v148: std::path::Display = v146.display();
                    let _v149: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_4: std::string::String = format!("{}", v148);
                        _v149.set(Some(x_4))
                    }
                    {
                        let v160: std::string::String = getValue(_v149.get().clone());
                        fable_library_rust::String_::fromString(v160)
                    }
                };
                _v4.set(Some(x_5))
            }
            {
                let v171: string = getValue(_v4.get().clone());
                let _v172: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v174: string = Spiral_builder::method13(v2);
                let v175: string = Spiral_builder::method14(v174.clone());
                let v177: &str = fable_library_rust::String_::LrcStr::as_str(&v175);
                let v179: std::string::String = String::from(v177);
                let v181: std::path::PathBuf = std::path::PathBuf::from(v179);
                {
                    let x_11: string = if v181.exists() == false {
                        let _v185: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v188: Result<std::path::PathBuf, std::io::Error> =
                            std::env::current_dir();
                        let v190: std::path::PathBuf = v188.unwrap();
                        let v192: std::path::Display = v190.display();
                        let _v193: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_6: std::string::String = format!("{}", v192);
                            _v193.set(Some(x_6))
                        }
                        {
                            let v204: std::string::String = getValue(_v193.get().clone());
                            {
                                let x_7: string = fable_library_rust::String_::fromString(v204);
                                _v185.set(Some(x_7))
                            }
                            {
                                let v213: string = getValue(_v185.get().clone());
                                let v214: string =
                                    Spiral_builder::method15(v213.clone(), v174.clone());
                                let _v215: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v217: string = Spiral_builder::method18();
                                let v218: string = Spiral_builder::method19(v214);
                                let v219: string = Spiral_builder::method20();
                                let v221: std::borrow::Cow<str> =
                                    regex::Regex::new(&v217).unwrap().replace_all(&v218, &*v219);
                                let v223: std::string::String = String::from(v221);
                                {
                                    let x_8: string = fable_library_rust::String_::fromString(v223);
                                    _v215.set(Some(x_8))
                                }
                                {
                                    let v233: string = getValue(_v215.get().clone());
                                    let v238: Array<string> = split(
                                        replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v233.clone(), 0_i32))),
                                                getSlice(v233, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        ),
                                        string("/"),
                                        -1_i32,
                                        0_i32,
                                    );
                                    let v240: i32 = count(v238.clone());
                                    let v241: LrcPtr<Spiral_builder::Mut4> =
                                        LrcPtr::new(Spiral_builder::Mut4 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(0_i32),
                                            l2: MutCell::new(new_empty::<string>()),
                                        });
                                    while Spiral_builder::method21(v240, v241.clone()) {
                                        let v243: i32 = v241.l0.get().clone();
                                        let v246: i32 = v243.wrapping_neg() + v240 - 1_i32;
                                        let matchValue_4: i32 = v241.l1.get().clone();
                                        let v248: Array<string> = v241.l2.get().clone();
                                        let v247: i32 = matchValue_4;
                                        let v249: string = v238[v246].clone();
                                        let patternInput_4: (i32, Array<string>) = if string("..")
                                            == v249.clone()
                                        {
                                            (v247 + 1_i32, v248.clone())
                                        } else {
                                            if 0_i32 == v247 {
                                                if endsWith(v249.clone(), string(":"), false) {
                                                    let v256: Array<string> =
                                                        new_array(&[sprintf!(
                                                            "{}:",
                                                            getCharAt(v213.clone(), 0_i32)
                                                        )]);
                                                    let v257: i32 = count(v256.clone());
                                                    let v259: i32 = v257 + count(v248.clone());
                                                    let v260: Array<string> =
                                                        new_init(&string(""), v259);
                                                    let v261: LrcPtr<Spiral_builder::Mut5> =
                                                        LrcPtr::new(Spiral_builder::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Spiral_builder::method22(
                                                        v259,
                                                        v261.clone(),
                                                    ) {
                                                        let v263: i32 = v261.l0.get().clone();
                                                        let v268: string = if v263 < v257 {
                                                            v256[v263].clone()
                                                        } else {
                                                            let v266: i32 = v263 - v257;
                                                            v248[v266].clone()
                                                        };
                                                        v260.get_mut()[v263 as usize] = v268;
                                                        {
                                                            let v269: i32 = v263 + 1_i32;
                                                            v261.l0.set(v269);
                                                            ()
                                                        }
                                                    }
                                                    (0_i32, v260.clone())
                                                } else {
                                                    let v270: Array<string> = new_array(&[v249]);
                                                    let v271: i32 = count(v270.clone());
                                                    let v273: i32 = v271 + count(v248.clone());
                                                    let v274: Array<string> =
                                                        new_init(&string(""), v273);
                                                    let v275: LrcPtr<Spiral_builder::Mut5> =
                                                        LrcPtr::new(Spiral_builder::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Spiral_builder::method22(
                                                        v273,
                                                        v275.clone(),
                                                    ) {
                                                        let v277: i32 = v275.l0.get().clone();
                                                        let v282: string = if v277 < v271 {
                                                            v270[v277].clone()
                                                        } else {
                                                            let v280: i32 = v277 - v271;
                                                            v248[v280].clone()
                                                        };
                                                        v274.get_mut()[v277 as usize] = v282;
                                                        {
                                                            let v283: i32 = v277 + 1_i32;
                                                            v275.l0.set(v283);
                                                            ()
                                                        }
                                                    }
                                                    (0_i32, v274.clone())
                                                }
                                            } else {
                                                (v247 - 1_i32, v248.clone())
                                            }
                                        };
                                        let v291: i32 = v243 + 1_i32;
                                        v241.l0.set(v291);
                                        v241.l1.set(patternInput_4.0.clone());
                                        v241.l2.set(patternInput_4.1.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_6: i32 = v241.l1.get().clone();
                                        let v293: Array<string> = v241.l2.get().clone();
                                        let v294: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v293 = v293.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v293 = v293.clone();
                                                            move |i_1: i32| v293[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count(v293.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let _v295: MutCell<Option<char>> =
                                            MutCell::new(None::<char>);
                                        {
                                            let x_9: char = std::path::MAIN_SEPARATOR;
                                            _v295.set(Some(x_9))
                                        }
                                        join(
                                            Spiral_builder::method23(ofChar(getValue(
                                                _v295.get().clone(),
                                            ))),
                                            toArray_1(v294),
                                        )
                                    }
                                }
                            }
                        }
                    } else {
                        let v312: Result<std::path::PathBuf, std::io::Error> =
                            std::fs::canonicalize(&*v174);
                        let v314: std::path::PathBuf = v312.unwrap();
                        let v316: std::path::Display = v314.display();
                        let _v317: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_10: std::string::String = format!("{}", v316);
                            _v317.set(Some(x_10))
                        }
                        {
                            let v328: std::string::String = getValue(_v317.get().clone());
                            fable_library_rust::String_::fromString(v328)
                        }
                    };
                    _v172.set(Some(x_11))
                }
                {
                    let v339: string = getValue(_v172.get().clone());
                    Spiral_builder::method3(
                        Spiral_builder::US0::US0_1,
                        Func0::new(move || Spiral_builder::closure10((), ())),
                        Func0::new({
                            let v0_1 = v0_1.clone();
                            let v171 = v171.clone();
                            let v1_1 = v1_1.clone();
                            let v339 = v339.clone();
                            move || {
                                Spiral_builder::closure11(
                                    v0_1.clone(),
                                    v1_1.clone(),
                                    v171.clone(),
                                    v339.clone(),
                                    (),
                                )
                            }
                        }),
                    );
                    Spiral_builder::method25(v0_1.clone(), v1_1.clone())
                }
            }
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            if Spiral_builder::State::trace_state().get().clone().is_none() {
                Spiral_builder::State::trace_state().set(Some(Spiral_builder::closure2((), ())));
            }
            {
                let v4: LrcPtr<Spiral_builder::Mut2> =
                    (getValue(Spiral_builder::State::trace_state().get().clone()))
                        .2
                        .clone();
                v4.l0.set(Spiral_builder::US0::US0_2);
                Spiral_builder::method3(
                    Spiral_builder::US0::US0_1,
                    Func0::new(move || Spiral_builder::closure4((), ())),
                    Func0::new({
                        let v0_1 = v0_1.clone();
                        move || Spiral_builder::closure5(v0_1.clone(), ())
                    }),
                );
                {
                    let v11: clap::Command = Spiral_builder::method0();
                    let v13: clap::ArgMatches = clap::Command::get_matches(v11);
                    let v14: string = Spiral_builder::method7();
                    let v16: &str = fable_library_rust::String_::LrcStr::as_str(&v14);
                    let v18: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v16).cloned();
                    let v21: Spiral_builder::US3 = defaultValue(
                        Spiral_builder::US3::US3_1,
                        map(Spiral_builder::method8(), v18),
                    );
                    let v25: std::string::String = match &v21 {
                        Spiral_builder::US3::US3_0(v21_0_0) => match &v21 {
                            Spiral_builder::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v27: string = fable_library_rust::String_::fromString(v25);
                    let v28: string = Spiral_builder::method9();
                    let v30: &str = fable_library_rust::String_::LrcStr::as_str(&v28);
                    let v32: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v30).cloned();
                    let v35: Spiral_builder::US3 = defaultValue(
                        Spiral_builder::US3::US3_1,
                        map(Spiral_builder::method8(), v32),
                    );
                    let v39: std::string::String = match &v35 {
                        Spiral_builder::US3::US3_0(v35_0_0) => match &v35 {
                            Spiral_builder::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v41: string = fable_library_rust::String_::fromString(v39);
                    let v42: string = Spiral_builder::method10();
                    let v44: &str = fable_library_rust::String_::LrcStr::as_str(&v42);
                    let v46: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v44).cloned();
                    let v49: Spiral_builder::US3 = defaultValue(
                        Spiral_builder::US3::US3_1,
                        map(Spiral_builder::method8(), v46),
                    );
                    let v53: std::string::String = match &v49 {
                        Spiral_builder::US3::US3_0(v49_0_0) => match &v49 {
                            Spiral_builder::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v55: string = fable_library_rust::String_::fromString(v53);
                    let v56: string = Spiral_builder::method11();
                    let v58: &str = fable_library_rust::String_::LrcStr::as_str(&v56);
                    let v60: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v58).cloned();
                    let v63: Spiral_builder::US3 = defaultValue(
                        Spiral_builder::US3::US3_1,
                        map(Spiral_builder::method8(), v60),
                    );
                    let v70: Spiral_builder::US4 = match &v63 {
                        Spiral_builder::US3::US3_0(v63_0_0) => Spiral_builder::US4::US4_0(
                            fable_library_rust::String_::fromString(match &v63 {
                                Spiral_builder::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Spiral_builder::US4::US4_1,
                    };
                    let v75: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Result<string, std::string::String>>>,
                    > = Spiral_builder::method12(
                        match &v70 {
                            Spiral_builder::US4::US4_0(v70_0_0) => match &v70 {
                                Spiral_builder::US4::US4_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => string(""),
                        },
                        v55,
                        v41,
                        v27,
                    );
                    let v77: Result<string, std::string::String> =
                        futures_lite::future::block_on(v75);
                    let v79: string = v77.unwrap();
                    if if let Spiral_builder::US0::US0_2 = &v4.l0.get().clone() {
                        true
                    } else {
                        false
                    } {
                        printfn!("{0}", v79);
                        ()
                    }
                    0_i32
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Spiral_builder::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Spiral_builder::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Spiral_builder::closure1((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Spiral_builder::v1())(args)
        }
    }
}
pub use module_7e2cd9e0::*;
#[path = "../../../lib/fsharp/Common.rs"]
mod module_8cb3e09e;
pub use module_8cb3e09e::*;
#[path = "../../../lib/spiral/async_.rs"]
mod module_62d8b4ed;
pub use module_62d8b4ed::*;
#[path = "../../../lib/spiral/common.rs"]
mod module_e7e93d99;
pub use module_e7e93d99::*;
#[path = "../../../lib/spiral/crypto.rs"]
mod module_981523f7;
pub use module_981523f7::*;
#[path = "../../../lib/spiral/date_time.rs"]
mod module_d18105aa;
pub use module_d18105aa::*;
#[path = "../../../lib/spiral/file_system.rs"]
mod module_c5eb79e8;
pub use module_c5eb79e8::*;
#[path = "../../../lib/spiral/lib.rs"]
mod module_8d8b0653;
pub use module_8d8b0653::*;
#[path = "../../../lib/spiral/networking.rs"]
mod module_2612ff6a;
pub use module_2612ff6a::*;
#[path = "../../../lib/spiral/runtime.rs"]
mod module_3a43928;
pub use module_3a43928::*;
#[path = "../../../lib/spiral/sm.rs"]
mod module_2aeb754a;
pub use module_2aeb754a::*;
#[path = "../../../lib/spiral/threading.rs"]
mod module_444ab8da;
pub use module_444ab8da::*;
#[path = "../../../lib/spiral/trace.rs"]
mod module_e61b6515;
pub use module_e61b6515::*;
pub mod Polyglot {
    pub use crate::module_8cb3e09e::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Spiral_builder::main(array_from(args));
}
