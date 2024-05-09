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
        use fable_library_rust::Native_::refCell;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::contains;
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
        #[derive(Clone, Debug)]
        pub enum US2 {
            US2_0(std::string::String),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(string),
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
        pub enum US4 {
            US4_0,
            US4_1(char),
            US4_2(u8),
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
            pub fn get_IsUS4_2(this_: &MutCell<Spiral_builder::US4>, unitArg: ()) -> bool {
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
        #[derive(Clone, Debug)]
        pub enum US5 {
            US5_0(std::string::String, clap::ArgMatches),
            US5_1,
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
        }
        impl core::fmt::Display for Spiral_builder::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(Vec<std::string::String>),
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
        pub fn method1(v0_1: std::string::String) -> std::string::String {
            v0_1
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
            let v21: string = string("r#\"package-dir\"#");
            let v22: &'static str = r#"package-dir"#;
            let v24: clap::Arg = clap::Arg::new(v22);
            let v26: clap::Arg = v24.short('p');
            let v27: string = string("r#\"package-dir\"#");
            let v28: &'static str = r#"package-dir"#;
            let v30: clap::Arg = v26.long(v28);
            let v32: clap::Arg = v30.required(true);
            let v34: clap::Command = clap::Command::arg(v19, v32);
            let v36: string = string("r#\"args\"#");
            let v37: &'static str = r#"args"#;
            let v39: clap::Arg = clap::Arg::new(v37);
            let v41: clap::Arg = v39.short('a');
            let v42: string = string("r#\"args\"#");
            let v43: &'static str = r#"args"#;
            let v45: clap::Arg = v41.long(v43);
            let v47: clap::Command = clap::Command::arg(v34, v45);
            let v49: string = string("r#\"trace-level\"#");
            let v50: &'static str = r#"trace-level"#;
            let v52: clap::Arg = clap::Arg::new(v50);
            let v54: clap::Arg = v52.short('t');
            let v55: string = string("r#\"trace-level\"#");
            let v56: &'static str = r#"trace-level"#;
            let v58: clap::Arg = v54.long(v56);
            let v71: Array<string> = toArray(ofArray(new_array(&[
                string("Verbose"),
                string("Debug"),
                string("Info"),
                string("Warning"),
                string("Critical"),
            ])));
            let v73: Vec<string> = v71.to_vec();
            let v75: bool = true;
            let _result = v73
                .into_iter()
                .map(|x| {
                    //;
                    let v77: string = x;
                    let v79: &str = &*v77;
                    let v82: std::string::String = Spiral_builder::method1(String::from(v79));
                    let v84: Box<std::string::String> = Box::new(v82);
                    let v86: &'static mut std::string::String = Box::leak(v84);
                    let v88: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v86);
                    let v90: bool = true;
                    v88
                })
                .collect();
            let v92: Vec<clap::builder::PossibleValue> = _result;
            let v94: clap::builder::ValueParser =
                clap::builder::PossibleValuesParser::new(v92).into();
            let v96: clap::Arg = v58.value_parser(v94);
            clap::Command::arg(v47, v96)
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
        pub fn method2() -> string {
            string("")
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
            let _v7: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v10: Result<std::string::String, std::env::VarError> =
                std::env::var(&*string("AUTOMATION"));
            let v12: bool = true;
            let _result = v10.map(|x| {
                //;
                let v14: std::string::String = x;
                let v16: string = fable_library_rust::String_::fromString(v14);
                let v18: bool = true;
                v16
            });
            let v20: Result<string, std::env::VarError> = _result;
            let v21: string = Spiral_builder::method2();
            {
                let x: string = v20.unwrap_or(v21);
                _v7.set(Some(x))
            }
            {
                let v38: Spiral_builder::US1 = if getValue(_v7.get().clone()) == string("True") {
                    Spiral_builder::US1::US1_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Spiral_builder::US1::US1_1
                };
                {
                    let x_1: Option<i64> = match &v38 {
                        Spiral_builder::US1::US1_0(v38_0_0) => Some(match &v38 {
                            Spiral_builder::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<i64>,
                    };
                    _v6.set(Some(x_1))
                }
                (v1_1, v0_1, v3, getValue(_v6.get().clone()), v5)
            }
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
        pub fn method4() -> string {
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
                let v7: Option<i64> = patternInput.3.clone();
                let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v10: LrcPtr<MutCell<Option<Spiral_builder::US1>>> =
                    refCell(None::<Spiral_builder::US1>);
                {
                    let x_2: Option<Spiral_builder::US1> = match &v7 {
                        None => None::<Spiral_builder::US1>,
                        Some(v7_0_0) => {
                            let x: i64 = v7_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Spiral_builder::US1::US1_0(x)
                            }))())
                        }
                    };
                    _v10.set(x_2)
                }
                {
                    let v15: Spiral_builder::US1 =
                        defaultValue(Spiral_builder::US1::US1_1, _v10.get().clone());
                    let v33: DateTime = match &v15 {
                        Spiral_builder::US1::US1_0(v15_0_0) => {
                            let v21: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v15 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v21.hours(),
                                v21.minutes(),
                                v21.seconds(),
                                v21.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = v33.toString(string("hh:mm:ss"));
                        _v9.set(Some(x_3))
                    }
                    {
                        let v66: string = getValue(_v9.get().clone());
                        let v67: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v79: string = padLeft(
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
                        let _v80: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v95: &str = match &v0_1 {
                            Spiral_builder::US0::US0_1 => inline_colorization::color_bright_blue,
                            Spiral_builder::US0::US0_2 => inline_colorization::color_bright_green,
                            Spiral_builder::US0::US0_0 => inline_colorization::color_bright_black,
                            Spiral_builder::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v97: &str = &*v79;
                        let v99: &str = inline_colorization::color_reset;
                        let v101: string = string("format!(\"{v95}{v97}{v99}\")");
                        let v102: std::string::String = format!("{v95}{v97}{v99}");
                        {
                            let x_4: string = fable_library_rust::String_::fromString(v102);
                            _v80.set(Some(x_4))
                        }
                        trimEndChars(
                            trimStartChars(
                                sprintf!(
                                    "{} {} #{} {} / {}",
                                    v66,
                                    getValue(_v80.get().clone()),
                                    v67,
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
        }
        pub fn method5(v0_1: Spiral_builder::US0, v1_1: Func0<string>) {
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
            Spiral_builder::method5(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Spiral_builder::closure7(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn method6() -> string {
            string("file")
        }
        pub fn method7() -> string {
            string("package-dir")
        }
        pub fn method8() -> string {
            string("args")
        }
        pub fn method9() -> string {
            string("trace-level")
        }
        pub fn method11(v0_1: string) -> string {
            v0_1
        }
        pub fn method13(v0_1: string) -> string {
            v0_1
        }
        pub fn method14(v0_1: string) -> string {
            v0_1
        }
        pub fn method12(v0_1: string, v1_1: string) -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: &str = &*v0_1;
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            let v10: &str = &*v1_1;
            let v12: std::string::String = String::from(v10);
            let v14: std::path::PathBuf = v8.join(v12);
            let v16: std::path::Display = v14.display();
            let _v17: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v16);
                _v17.set(Some(x))
            }
            {
                let v27: std::string::String = getValue(_v17.get().clone());
                {
                    let x_1: string = fable_library_rust::String_::fromString(v27);
                    _v2.set(Some(x_1))
                }
                getValue(_v2.get().clone())
            }
        }
        pub fn method15(v0_1: string) -> string {
            v0_1
        }
        pub fn method16() -> string {
            string("")
        }
        pub fn method17() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method18() -> string {
            string("")
        }
        pub fn method19(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method20(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method21(v0_1: string) -> string {
            v0_1
        }
        pub fn method22(v0_1: string) -> string {
            v0_1
        }
        pub fn closure8(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run")
        }
        pub fn closure9(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) -> string {
            sprintf!(
                "file: {} / package_dir: {} / hash: {} / args: {} / {}",
                v1_1,
                v2,
                v3,
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method23() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: clap::Command = clap::Command::subcommand_required(v4, true);
            let v8: string = string("r#\"rust\"#");
            let v9: &'static str = r#"rust"#;
            let v11: clap::Command = clap::Command::new(v9);
            let v13: string = string("r#\"deps\"#");
            let v14: &'static str = r#"deps"#;
            let v16: clap::Arg = clap::Arg::new(v14);
            let v18: clap::Arg = v16.short('d');
            let v19: string = string("r#\"deps\"#");
            let v20: &'static str = r#"deps"#;
            let v22: clap::Arg = v18.long(v20);
            let v24: string = string("r#\"NAME\"#");
            let v27: string = string("r#\"VERSION\"#");
            let v29: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v31: Vec<&'static str> = v29.to_vec();
            let v33: clap::Arg = v22.value_names(v31);
            let v34: usize = 1_i32 as usize;
            let v35: usize = 0_i32 as usize;
            let v41: clap::builder::ValueRange = if v35 == v35 {
                clap::builder::ValueRange::new(v34..)
            } else {
                clap::builder::ValueRange::new(v34..v35)
            };
            let v43: clap::Arg = v33.num_args(v41);
            let v45: clap::ArgAction = clap::ArgAction::Append;
            let v47: clap::Arg = v43.action(v45);
            let v49: clap::Command = clap::Command::arg(v11, v47);
            clap::Command::subcommand(v6, v49)
        }
        pub fn closure11(
            v0_1: char,
            v1_1: LrcPtr<Spiral_builder::UH1>,
        ) -> LrcPtr<Spiral_builder::UH1> {
            LrcPtr::new(Spiral_builder::UH1::UH1_1(v0_1, v1_1))
        }
        pub fn closure10(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Spiral_builder::UH1>, LrcPtr<Spiral_builder::UH1>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Spiral_builder::UH1>| Spiral_builder::closure11(v0_1, v)
            })
        }
        pub fn method25(
        ) -> Func1<char, Func1<LrcPtr<Spiral_builder::UH1>, LrcPtr<Spiral_builder::UH1>>> {
            Func1::new(move |v: char| Spiral_builder::closure10((), v))
        }
        pub fn method28(
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
                        Spiral_builder::method28(
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
        pub fn method27(
            v0_1: string,
            v1_1: LrcPtr<Spiral_builder::UH0>,
            v2: LrcPtr<Spiral_builder::UH1>,
            v3: Spiral_builder::US4,
        ) -> (LrcPtr<Spiral_builder::UH0>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US4> = MutCell::new(v3.clone());
            '_method27: loop {
                break '_method27 (match &v3.get().clone() {
                    Spiral_builder::US4::US4_1(v3_1_0) => {
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
                                    if v3.get().clone() == Spiral_builder::US4::US4_1('\\') {
                                        Spiral_builder::method26(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v108.clone(),
                                            v3.get().clone(),
                                            Spiral_builder::US4::US4_0,
                                        )
                                    } else {
                                        if '\\' == v105 {
                                            if !(v3.get().clone()
                                                == Spiral_builder::US4::US4_2(0_u8))
                                            {
                                                Spiral_builder::method26(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US4::US4_1('\"'),
                                                )
                                            } else {
                                                if v3.get().clone()
                                                    == Spiral_builder::US4::US4_1('\\')
                                                {
                                                    Spiral_builder::method26(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US4::US4_1('\"'),
                                                    )
                                                } else {
                                                    Spiral_builder::method26(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US4::US4_0,
                                                    )
                                                }
                                            }
                                        } else {
                                            if '\\' == v107 {
                                                Spiral_builder::method26(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v108.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US4::US4_2(1_u8),
                                                )
                                            } else {
                                                if v3.get().clone()
                                                    == Spiral_builder::US4::US4_2(0_u8)
                                                {
                                                    Spiral_builder::method26(
                                                        sprintf!("{}\"", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v108.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US4::US4_1('\"'),
                                                    )
                                                } else {
                                                    Spiral_builder::method26(
                                                        string(""),
                                                        Spiral_builder::method28(
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
                                                        Spiral_builder::US4::US4_0,
                                                    )
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    if '\\' == v105 {
                                        if '\\' == v107 {
                                            Spiral_builder::method26(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US4::US4_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v107 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v108.clone();
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v107);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v108.clone();
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            }
                                        }
                                    } else {
                                        if '\\' == v107 {
                                            Spiral_builder::method26(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v108,
                                                v3.get().clone(),
                                                Spiral_builder::US4::US4_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v107 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v108.clone();
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v107);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v108.clone();
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
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
                                            Spiral_builder::method28(
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
                                            Spiral_builder::method28(
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
                                        if !(v3.get().clone() == Spiral_builder::US4::US4_2(0_u8)) {
                                            Spiral_builder::method26(
                                                sprintf!("{}\"", v0_1.get().clone()),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US4::US4_1('\"'),
                                            )
                                        } else {
                                            if v3.get().clone() == Spiral_builder::US4::US4_1('\\')
                                            {
                                                Spiral_builder::method26(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US4::US4_1('\"'),
                                                )
                                            } else {
                                                Spiral_builder::method26(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v220.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US4::US4_0,
                                                )
                                            }
                                        }
                                    } else {
                                        if '\\' == v219 {
                                            Spiral_builder::method26(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v220.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US4::US4_2(1_u8),
                                            )
                                        } else {
                                            if ' ' == v219 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v220;
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v219);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v220.clone();
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method28(
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
                                        Spiral_builder::method26(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v270.clone(),
                                            v3.get().clone(),
                                            Spiral_builder::US4::US4_2(1_u8),
                                        )
                                    } else {
                                        if '\"' == v269 {
                                            if v3.get().clone() == Spiral_builder::US4::US4_2(0_u8)
                                            {
                                                Spiral_builder::method26(
                                                    sprintf!("{}\"", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US4::US4_1('\"'),
                                                )
                                            } else {
                                                Spiral_builder::method26(
                                                    string(""),
                                                    Spiral_builder::method28(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                        )),
                                                    ),
                                                    v270.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US4::US4_0,
                                                )
                                            }
                                        } else {
                                            if ' ' == v269 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v270;
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v269);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v270.clone();
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method28(
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
                    Spiral_builder::US4::US4_0 => {
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
                                Spiral_builder::method26(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Spiral_builder::US4::US4_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Spiral_builder::method26(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v5.clone(),
                                        v3.get().clone(),
                                        Spiral_builder::US4::US4_2(0_u8),
                                    )
                                } else {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = string("");
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method28(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                    )),
                                                )
                                            };
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5;
                                        let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method27;
                                    } else {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method27;
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Spiral_builder::method28(
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
                    Spiral_builder::US4::US4_2(v3_2_0) => {
                        let v44: u8 = match &v3.get().clone() {
                            Spiral_builder::US4::US4_2(x) => x.clone(),
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
                                Spiral_builder::method26(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v46.clone(),
                                    v3.get().clone(),
                                    Spiral_builder::US4::US4_1('\\'),
                                )
                            } else {
                                if '\"' == v45 {
                                    if if let Spiral_builder::US4::US4_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v46.clone();
                                        let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method27;
                                    } else {
                                        Spiral_builder::method26(
                                            sprintf!("{}\"", v0_1.get().clone()),
                                            v1_1.get().clone(),
                                            v46.clone(),
                                            v3.get().clone(),
                                            Spiral_builder::US4::US4_2(v44),
                                        )
                                    }
                                } else {
                                    if ' ' == v45 {
                                        let v0_1_temp: string = sprintf!("{} ", v0_1.get().clone());
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v46.clone();
                                        let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method27;
                                    } else {
                                        if 1_u8 == v44 {
                                            if !(v3.get().clone() == v3.get().clone()) {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\\{}", v0_1.get().clone(), v45);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v46.clone();
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            } else {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}", v0_1.get().clone(), v45);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v46.clone();
                                                let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method27;
                                            }
                                        } else {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}", v0_1.get().clone(), v45);
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v46.clone();
                                            let v3_temp: Spiral_builder::US4 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method27;
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
                                        Spiral_builder::method28(
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
                                        Spiral_builder::method28(
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
        pub fn method26(
            v0_1: string,
            v1_1: LrcPtr<Spiral_builder::UH0>,
            v2: LrcPtr<Spiral_builder::UH1>,
            v3: Spiral_builder::US4,
            v4: Spiral_builder::US4,
        ) -> (LrcPtr<Spiral_builder::UH0>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US4> = MutCell::new(v3.clone());
            let v4: MutCell<Spiral_builder::US4> = MutCell::new(v4.clone());
            '_method26: loop {
                break '_method26 (match &v4.get().clone() {
                    Spiral_builder::US4::US4_1(v4_1_0) => {
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
                                    if v3.get().clone() == Spiral_builder::US4::US4_1('\\') {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v109.clone();
                                        let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                        let v4_temp: Spiral_builder::US4 =
                                            Spiral_builder::US4::US4_0;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method26;
                                    } else {
                                        if '\\' == v106 {
                                            if !(v3.get().clone()
                                                == Spiral_builder::US4::US4_2(0_u8))
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v109.clone();
                                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US4 =
                                                    Spiral_builder::US4::US4_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method26;
                                            } else {
                                                if v3.get().clone()
                                                    == Spiral_builder::US4::US4_1('\\')
                                                {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}\"", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v109.clone();
                                                    let v3_temp: Spiral_builder::US4 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US4 =
                                                        Spiral_builder::US4::US4_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method26;
                                                } else {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v109.clone();
                                                    let v3_temp: Spiral_builder::US4 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US4 =
                                                        Spiral_builder::US4::US4_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method26;
                                                }
                                            }
                                        } else {
                                            if '\\' == v108 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v109.clone();
                                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US4 =
                                                    Spiral_builder::US4::US4_2(1_u8);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method26;
                                            } else {
                                                if v3.get().clone()
                                                    == Spiral_builder::US4::US4_2(0_u8)
                                                {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}\"", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v109.clone();
                                                    let v3_temp: Spiral_builder::US4 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US4 =
                                                        Spiral_builder::US4::US4_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method26;
                                                } else {
                                                    let v0_1_temp: string = string("");
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        Spiral_builder::method28(
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
                                                    let v3_temp: Spiral_builder::US4 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US4 =
                                                        Spiral_builder::US4::US4_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method26;
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
                                            let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US4 =
                                                Spiral_builder::US4::US4_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method26;
                                        } else {
                                            if ' ' == v108 {
                                                Spiral_builder::method27(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Spiral_builder::method27(
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
                                            let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US4 =
                                                Spiral_builder::US4::US4_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method26;
                                        } else {
                                            if ' ' == v108 {
                                                Spiral_builder::method27(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v109.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Spiral_builder::method27(
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
                                            Spiral_builder::method28(
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
                                            Spiral_builder::method28(
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
                                        if !(v3.get().clone() == Spiral_builder::US4::US4_2(0_u8)) {
                                            let v0_1_temp: string =
                                                sprintf!("{}\"", v0_1.get().clone());
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v221.clone();
                                            let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US4 =
                                                Spiral_builder::US4::US4_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method26;
                                        } else {
                                            if v3.get().clone() == Spiral_builder::US4::US4_1('\\')
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v221.clone();
                                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US4 =
                                                    Spiral_builder::US4::US4_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method26;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v221;
                                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US4 =
                                                    Spiral_builder::US4::US4_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method26;
                                            }
                                        }
                                    } else {
                                        if '\\' == v220 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v221.clone();
                                            let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US4 =
                                                Spiral_builder::US4::US4_2(1_u8);
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method26;
                                        } else {
                                            if ' ' == v220 {
                                                Spiral_builder::method27(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v221.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Spiral_builder::method27(
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
                                            Spiral_builder::method28(
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
                                        let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                        let v4_temp: Spiral_builder::US4 =
                                            Spiral_builder::US4::US4_2(1_u8);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method26;
                                    } else {
                                        if '\"' == v270 {
                                            if v3.get().clone() == Spiral_builder::US4::US4_2(0_u8)
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}\"", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v271.clone();
                                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US4 =
                                                    Spiral_builder::US4::US4_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method26;
                                            } else {
                                                let v0_1_temp: string = string("");
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    Spiral_builder::method28(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                        )),
                                                    );
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v271.clone();
                                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US4 =
                                                    Spiral_builder::US4::US4_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method26;
                                            }
                                        } else {
                                            if ' ' == v270 {
                                                Spiral_builder::method27(
                                                    sprintf!("{} ", v0_1.get().clone()),
                                                    v1_1.get().clone(),
                                                    v271.clone(),
                                                    v4.get().clone(),
                                                )
                                            } else {
                                                Spiral_builder::method27(
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
                                            Spiral_builder::method28(
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
                    Spiral_builder::US4::US4_0 => {
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
                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                let v4_temp: Spiral_builder::US4 = Spiral_builder::US4::US4_1('\"');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method26;
                            } else {
                                if '\\' == v5 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v6;
                                    let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                    let v4_temp: Spiral_builder::US4 =
                                        Spiral_builder::US4::US4_2(0_u8);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method26;
                                } else {
                                    if ' ' == v5 {
                                        Spiral_builder::method27(
                                            string(""),
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method28(
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
                                        Spiral_builder::method27(
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
                                    Spiral_builder::method28(
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
                    Spiral_builder::US4::US4_2(v4_2_0) => {
                        let v45: u8 = match &v4.get().clone() {
                            Spiral_builder::US4::US4_2(x) => x.clone(),
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
                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                let v4_temp: Spiral_builder::US4 = Spiral_builder::US4::US4_1('\\');
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method26;
                            } else {
                                if '\"' == v46 {
                                    if if let Spiral_builder::US4::US4_0 = &v3.get().clone() {
                                        true
                                    } else {
                                        false
                                    } {
                                        Spiral_builder::method27(
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
                                        let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                        let v4_temp: Spiral_builder::US4 =
                                            Spiral_builder::US4::US4_2(v45);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method26;
                                    }
                                } else {
                                    if ' ' == v46 {
                                        Spiral_builder::method27(
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
                                                let v3_temp: Spiral_builder::US4 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US4 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method26;
                                            } else {
                                                Spiral_builder::method27(
                                                    sprintf!("{}{}", v0_1.get().clone(), v46),
                                                    v1_1.get().clone(),
                                                    v47.clone(),
                                                    v4.get().clone(),
                                                )
                                            }
                                        } else {
                                            Spiral_builder::method27(
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
                                        Spiral_builder::method28(
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
                                        Spiral_builder::method28(
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
        pub fn method29(v0_1: LrcPtr<Spiral_builder::UH0>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Spiral_builder::UH0::UH0_0 => v1_1.clone(),
                Spiral_builder::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Spiral_builder::method29(
                        match v0_1.as_ref() {
                            Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method24(v0_1: string) -> Array<string> {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v5: Option<string> = getValue(_v0.get().clone());
                let _v6: LrcPtr<MutCell<Option<Spiral_builder::US3>>> =
                    refCell(None::<Spiral_builder::US3>);
                {
                    let x_3: Option<Spiral_builder::US3> = match &v5 {
                        None => None::<Spiral_builder::US3>,
                        Some(v5_0_0) => {
                            let x_1: string = v5_0_0.clone();
                            Some((Func0::new({
                                let x_1 = x_1.clone();
                                move || Spiral_builder::US3::US3_0(x_1.clone())
                            }))())
                        }
                    };
                    _v6.set(x_3)
                }
                {
                    let v11: Spiral_builder::US3 =
                        defaultValue(Spiral_builder::US3::US3_1, _v6.get().clone());
                    let v14: string = match &v11 {
                        Spiral_builder::US3::US3_0(v11_0_0) => match &v11 {
                            Spiral_builder::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => string(""),
                    };
                    let v15: i32 = length(v14.clone());
                    let v16: Array<char> = new_init(&'\u{0000}', v15);
                    let v17: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method20(v15, v17.clone()) {
                        let v19: i32 = v17.l0.get().clone();
                        let v20: char = getCharAt(v14.clone(), v19);
                        v16.get_mut()[v19 as usize] = v20;
                        {
                            let v21: i32 = v19 + 1_i32;
                            v17.l0.set(v21);
                            ()
                        }
                    }
                    {
                        let v23: List<char> = ofArray(v16.clone());
                        toArray(Spiral_builder::method29(
                            (Spiral_builder::method26(
                                string(""),
                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                        (Spiral_builder::method25())(b0)(b1)
                                    }),
                                    v23,
                                    LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                ),
                                Spiral_builder::US4::US4_0,
                                Spiral_builder::US4::US4_0,
                            ))
                            .0
                            .clone(),
                            empty::<string>(),
                        ))
                    }
                }
            }
        }
        pub fn closure12(unitVar: (), v0_1: &str) -> std::string::String {
            String::from(v0_1)
        }
        pub fn method30() -> string {
            string("deps")
        }
        pub fn method31() -> string {
            string("\n")
        }
        pub fn closure13(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run")
        }
        pub fn closure14(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "subcommand: {} / {}",
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure15(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v3: &str = &*_arg.0.clone();
            let v5: std::string::String = String::from(v3);
            let v7: &str = &*_arg.1.clone();
            LrcPtr::new((v5, String::from(v7)))
        }
        pub fn closure16(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run")
        }
        pub fn closure17(
            v0_1: std::collections::BTreeMap<std::string::String, std::string::String>,
            unitVar: (),
        ) -> string {
            sprintf!("result: {:?} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn closure18(unitVar: (), v0_1: serde_json::Error) -> string {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            {
                let v11: std::string::String = getValue(_v1.get().clone());
                fable_library_rust::String_::fromString(v11)
            }
        }
        pub fn method32() -> Func1<serde_json::Error, string> {
            Func1::new(move |v: serde_json::Error| Spiral_builder::closure18((), v))
        }
        pub fn method33(v0_1: Result<string, string>) -> Result<string, string> {
            v0_1
        }
        pub fn method10(
            v0_1: string,
            v1_1: string,
            v2: string,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, string>>>> {
            let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Spiral_builder::method11(v2);
            let v6: &str = &*v4.clone();
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            {
                let x_6: string = if v10.exists() == false {
                    let _v14: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v16: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v18: std::path::PathBuf = v16.unwrap();
                    let v20: std::path::Display = v18.display();
                    let _v21: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v20);
                        _v21.set(Some(x))
                    }
                    {
                        let v31: std::string::String = getValue(_v21.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v31);
                            _v14.set(Some(x_1))
                        }
                        {
                            let v40: string = getValue(_v14.get().clone());
                            let _v42: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v43: string = Spiral_builder::method15(Spiral_builder::method12(
                                v40.clone(),
                                v4.clone(),
                            ));
                            let v44: string = Spiral_builder::method16();
                            let _v45: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                            let v46: string = Spiral_builder::method17();
                            {
                                let x_2: Result<regex::Regex, regex::Error> =
                                    regex::Regex::new(&v46);
                                _v45.set(Some(x_2))
                            }
                            {
                                let v54: Result<regex::Regex, regex::Error> =
                                    getValue(_v45.get().clone());
                                let v56: regex::Regex = v54.unwrap();
                                let v58: std::borrow::Cow<str> = v56.replace_all(&v43, &*v44);
                                let v60: std::string::String = String::from(v58);
                                {
                                    let x_3: string = fable_library_rust::String_::fromString(v60);
                                    _v42.set(Some(x_3))
                                }
                                {
                                    let v70: string = getValue(_v42.get().clone());
                                    let v75: Array<string> = split(
                                        replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v70.clone(), 0_i32))),
                                                getSlice(v70, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        ),
                                        string("/"),
                                        -1_i32,
                                        0_i32,
                                    );
                                    let v77: i32 = count(v75.clone());
                                    let v78: LrcPtr<Spiral_builder::Mut4> =
                                        LrcPtr::new(Spiral_builder::Mut4 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(0_i32),
                                            l2: MutCell::new(new_empty::<string>()),
                                        });
                                    while Spiral_builder::method19(v77, v78.clone()) {
                                        let v80: i32 = v78.l0.get().clone();
                                        let v83: i32 = v80.wrapping_neg() + v77 - 1_i32;
                                        let matchValue: i32 = v78.l1.get().clone();
                                        let v85: Array<string> = v78.l2.get().clone();
                                        let v84: i32 = matchValue;
                                        let v86: string = v75[v83].clone();
                                        let patternInput_1: (i32, Array<string>) = if string("..")
                                            == v86.clone()
                                        {
                                            (v84 + 1_i32, v85.clone())
                                        } else {
                                            if string(".") == v86.clone() {
                                                (v84, v85.clone())
                                            } else {
                                                if 0_i32 == v84 {
                                                    if endsWith(v86.clone(), string(":"), false) {
                                                        let v94: Array<string> =
                                                            new_array(&[sprintf!(
                                                                "{}:",
                                                                getCharAt(v40.clone(), 0_i32)
                                                            )]);
                                                        let v95: i32 = count(v94.clone());
                                                        let v97: i32 = v95 + count(v85.clone());
                                                        let v98: Array<string> =
                                                            new_init(&string(""), v97);
                                                        let v99: LrcPtr<Spiral_builder::Mut5> =
                                                            LrcPtr::new(Spiral_builder::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Spiral_builder::method20(
                                                            v97,
                                                            v99.clone(),
                                                        ) {
                                                            let v101: i32 = v99.l0.get().clone();
                                                            let v106: string = if v101 < v95 {
                                                                v94[v101].clone()
                                                            } else {
                                                                let v104: i32 = v101 - v95;
                                                                v85[v104].clone()
                                                            };
                                                            v98.get_mut()[v101 as usize] = v106;
                                                            {
                                                                let v107: i32 = v101 + 1_i32;
                                                                v99.l0.set(v107);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v98.clone())
                                                    } else {
                                                        let v108: Array<string> = new_array(&[v86]);
                                                        let v109: i32 = count(v108.clone());
                                                        let v111: i32 = v109 + count(v85.clone());
                                                        let v112: Array<string> =
                                                            new_init(&string(""), v111);
                                                        let v113: LrcPtr<Spiral_builder::Mut5> =
                                                            LrcPtr::new(Spiral_builder::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Spiral_builder::method20(
                                                            v111,
                                                            v113.clone(),
                                                        ) {
                                                            let v115: i32 = v113.l0.get().clone();
                                                            let v120: string = if v115 < v109 {
                                                                v108[v115].clone()
                                                            } else {
                                                                let v118: i32 = v115 - v109;
                                                                v85[v118].clone()
                                                            };
                                                            v112.get_mut()[v115 as usize] = v120;
                                                            {
                                                                let v121: i32 = v115 + 1_i32;
                                                                v113.l0.set(v121);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v112.clone())
                                                    }
                                                } else {
                                                    (v84 - 1_i32, v85.clone())
                                                }
                                            }
                                        };
                                        let v131: i32 = v80 + 1_i32;
                                        v78.l0.set(v131);
                                        v78.l1.set(patternInput_1.0.clone());
                                        v78.l2.set(patternInput_1.1.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_2: i32 = v78.l1.get().clone();
                                        let v133: Array<string> = v78.l2.get().clone();
                                        let v134: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v133 = v133.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v133 = v133.clone();
                                                            move |i: i32| v133[i].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count(v133.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let _v135: MutCell<Option<char>> =
                                            MutCell::new(None::<char>);
                                        {
                                            let x_4: char = std::path::MAIN_SEPARATOR;
                                            _v135.set(Some(x_4))
                                        }
                                        join(
                                            Spiral_builder::method21(ofChar(getValue(
                                                _v135.get().clone(),
                                            ))),
                                            toArray_1(v134),
                                        )
                                    }
                                }
                            }
                        }
                    }
                } else {
                    let v151: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v4);
                    let v153: std::path::PathBuf = v151.unwrap();
                    let v155: std::path::Display = v153.display();
                    let _v156: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_5: std::string::String = format!("{}", v155);
                        _v156.set(Some(x_5))
                    }
                    {
                        let v166: std::string::String = getValue(_v156.get().clone());
                        fable_library_rust::String_::fromString(v166)
                    }
                };
                _v3.set(Some(x_6))
            }
            {
                let v177: string = getValue(_v3.get().clone());
                let _v178: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v179: string = Spiral_builder::method11(v1_1);
                let v181: &str = &*v179.clone();
                let v183: std::string::String = String::from(v181);
                let v185: std::path::PathBuf = std::path::PathBuf::from(v183);
                {
                    let x_13: string = if v185.exists() == false {
                        let _v189: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v191: Result<std::path::PathBuf, std::io::Error> =
                            std::env::current_dir();
                        let v193: std::path::PathBuf = v191.unwrap();
                        let v195: std::path::Display = v193.display();
                        let _v196: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_7: std::string::String = format!("{}", v195);
                            _v196.set(Some(x_7))
                        }
                        {
                            let v206: std::string::String = getValue(_v196.get().clone());
                            {
                                let x_8: string = fable_library_rust::String_::fromString(v206);
                                _v189.set(Some(x_8))
                            }
                            {
                                let v215: string = getValue(_v189.get().clone());
                                let _v217: MutCell<Option<string>> = MutCell::new(None::<string>);
                                let v218: string = Spiral_builder::method15(
                                    Spiral_builder::method12(v215.clone(), v179.clone()),
                                );
                                let v219: string = Spiral_builder::method16();
                                let _v220: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                                let v221: string = Spiral_builder::method17();
                                {
                                    let x_9: Result<regex::Regex, regex::Error> =
                                        regex::Regex::new(&v221);
                                    _v220.set(Some(x_9))
                                }
                                {
                                    let v229: Result<regex::Regex, regex::Error> =
                                        getValue(_v220.get().clone());
                                    let v231: regex::Regex = v229.unwrap();
                                    let v233: std::borrow::Cow<str> =
                                        v231.replace_all(&v218, &*v219);
                                    let v235: std::string::String = String::from(v233);
                                    {
                                        let x_10: string =
                                            fable_library_rust::String_::fromString(v235);
                                        _v217.set(Some(x_10))
                                    }
                                    {
                                        let v245: string = getValue(_v217.get().clone());
                                        let v250: Array<string> = split(
                                            replace(
                                                sprintf!(
                                                    "{}{}",
                                                    toLower(ofChar(getCharAt(v245.clone(), 0_i32))),
                                                    getSlice(v245, Some(1_i32), None::<i32>)
                                                ),
                                                string("\\"),
                                                string("/"),
                                            ),
                                            string("/"),
                                            -1_i32,
                                            0_i32,
                                        );
                                        let v252: i32 = count(v250.clone());
                                        let v253: LrcPtr<Spiral_builder::Mut4> =
                                            LrcPtr::new(Spiral_builder::Mut4 {
                                                l0: MutCell::new(0_i32),
                                                l1: MutCell::new(0_i32),
                                                l2: MutCell::new(new_empty::<string>()),
                                            });
                                        while Spiral_builder::method19(v252, v253.clone()) {
                                            let v255: i32 = v253.l0.get().clone();
                                            let v258: i32 = v255.wrapping_neg() + v252 - 1_i32;
                                            let matchValue_4: i32 = v253.l1.get().clone();
                                            let v260: Array<string> = v253.l2.get().clone();
                                            let v259: i32 = matchValue_4;
                                            let v261: string = v250[v258].clone();
                                            let patternInput_4: (i32, Array<string>) =
                                                if string("..") == v261.clone() {
                                                    (v259 + 1_i32, v260.clone())
                                                } else {
                                                    if string(".") == v261.clone() {
                                                        (v259, v260.clone())
                                                    } else {
                                                        if 0_i32 == v259 {
                                                            if endsWith(
                                                                v261.clone(),
                                                                string(":"),
                                                                false,
                                                            ) {
                                                                let v269: Array<string> =
                                                                    new_array(&[sprintf!(
                                                                        "{}:",
                                                                        getCharAt(
                                                                            v215.clone(),
                                                                            0_i32
                                                                        )
                                                                    )]);
                                                                let v270: i32 = count(v269.clone());
                                                                let v272: i32 =
                                                                    v270 + count(v260.clone());
                                                                let v273: Array<string> =
                                                                    new_init(&string(""), v272);
                                                                let v274: LrcPtr<
                                                                    Spiral_builder::Mut5,
                                                                > = LrcPtr::new(
                                                                    Spiral_builder::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    },
                                                                );
                                                                while Spiral_builder::method20(
                                                                    v272,
                                                                    v274.clone(),
                                                                ) {
                                                                    let v276: i32 =
                                                                        v274.l0.get().clone();
                                                                    let v281: string = if v276
                                                                        < v270
                                                                    {
                                                                        v269[v276].clone()
                                                                    } else {
                                                                        let v279: i32 = v276 - v270;
                                                                        v260[v279].clone()
                                                                    };
                                                                    v273.get_mut()[v276 as usize] =
                                                                        v281;
                                                                    {
                                                                        let v282: i32 =
                                                                            v276 + 1_i32;
                                                                        v274.l0.set(v282);
                                                                        ()
                                                                    }
                                                                }
                                                                (0_i32, v273.clone())
                                                            } else {
                                                                let v283: Array<string> =
                                                                    new_array(&[v261]);
                                                                let v284: i32 = count(v283.clone());
                                                                let v286: i32 =
                                                                    v284 + count(v260.clone());
                                                                let v287: Array<string> =
                                                                    new_init(&string(""), v286);
                                                                let v288: LrcPtr<
                                                                    Spiral_builder::Mut5,
                                                                > = LrcPtr::new(
                                                                    Spiral_builder::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    },
                                                                );
                                                                while Spiral_builder::method20(
                                                                    v286,
                                                                    v288.clone(),
                                                                ) {
                                                                    let v290: i32 =
                                                                        v288.l0.get().clone();
                                                                    let v295: string = if v290
                                                                        < v284
                                                                    {
                                                                        v283[v290].clone()
                                                                    } else {
                                                                        let v293: i32 = v290 - v284;
                                                                        v260[v293].clone()
                                                                    };
                                                                    v287.get_mut()[v290 as usize] =
                                                                        v295;
                                                                    {
                                                                        let v296: i32 =
                                                                            v290 + 1_i32;
                                                                        v288.l0.set(v296);
                                                                        ()
                                                                    }
                                                                }
                                                                (0_i32, v287.clone())
                                                            }
                                                        } else {
                                                            (v259 - 1_i32, v260.clone())
                                                        }
                                                    }
                                                };
                                            let v306: i32 = v255 + 1_i32;
                                            v253.l0.set(v306);
                                            v253.l1.set(patternInput_4.0.clone());
                                            v253.l2.set(patternInput_4.1.clone());
                                            ()
                                        }
                                        {
                                            let matchValue_6: i32 = v253.l1.get().clone();
                                            let v308: Array<string> = v253.l2.get().clone();
                                            let v309: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v308 = v308.clone();
                                                    move || {
                                                        map(
                                                            Func1::new({
                                                                let v308 = v308.clone();
                                                                move |i_1: i32| v308[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                count(v308.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let _v310: MutCell<Option<char>> =
                                                MutCell::new(None::<char>);
                                            {
                                                let x_11: char = std::path::MAIN_SEPARATOR;
                                                _v310.set(Some(x_11))
                                            }
                                            join(
                                                Spiral_builder::method21(ofChar(getValue(
                                                    _v310.get().clone(),
                                                ))),
                                                toArray_1(v309),
                                            )
                                        }
                                    }
                                }
                            }
                        }
                    } else {
                        let v326: Result<std::path::PathBuf, std::io::Error> =
                            std::fs::canonicalize(&*v179);
                        let v328: std::path::PathBuf = v326.unwrap();
                        let v330: std::path::Display = v328.display();
                        let _v331: MutCell<Option<std::string::String>> =
                            MutCell::new(None::<std::string::String>);
                        {
                            let x_12: std::string::String = format!("{}", v330);
                            _v331.set(Some(x_12))
                        }
                        {
                            let v341: std::string::String = getValue(_v331.get().clone());
                            fable_library_rust::String_::fromString(v341)
                        }
                    };
                    _v178.set(Some(x_13))
                }
                {
                    let v352: string = getValue(_v178.get().clone());
                    let _v353: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v355: &str = &*v352.clone();
                    let v357: std::string::String = String::from(v355);
                    let v359: std::path::PathBuf = std::path::PathBuf::from(v357);
                    let v361: Option<&std::ffi::OsStr> = v359.file_name();
                    let v363: &std::ffi::OsStr = v361.unwrap();
                    let v365: std::ffi::OsString = v363.to_os_string();
                    let v367: Option<&str> = v365.to_str();
                    let v369: &str = v367.unwrap();
                    let v371: std::string::String = String::from(v369);
                    {
                        let x_14: string = fable_library_rust::String_::fromString(v371);
                        _v353.set(Some(x_14))
                    }
                    {
                        let v380: string = getValue(_v353.get().clone());
                        Spiral_builder::method3(
                            Spiral_builder::US0::US0_1,
                            Func0::new(move || Spiral_builder::closure8((), ())),
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v177 = v177.clone();
                                let v352 = v352.clone();
                                let v380 = v380.clone();
                                move || {
                                    Spiral_builder::closure9(
                                        v0_1.clone(),
                                        v177.clone(),
                                        v352.clone(),
                                        v380.clone(),
                                        (),
                                    )
                                }
                            }),
                        );
                        let __result = Box::pin(async move {
                            //;
                            {
                                let v385: clap::Command = Spiral_builder::method23();
                                let v387: Array<string> = Spiral_builder::method24(sprintf!(
                                    "spiral_builder {}",
                                    v0_1.clone()
                                ));
                                let v389: Vec<string> = v387.to_vec();
                                let v391: bool = true;
                                let _result = v389
                                    .into_iter()
                                    .map(|x| {
                                        //;
                                        let v393: string = x;
                                        let v395: &str = &*v393;
                                        let v397: std::string::String = String::from(v395);
                                        let v399: bool = true;
                                        v397
                                    })
                                    .collect();
                                let v401: Vec<std::string::String> = _result;
                                let v403: clap::ArgMatches =
                                    clap::Command::get_matches_from(v385, v401);
                                let v405: clap::ArgMatches = v403.clone();
                                let v408: Option<(std::string::String, clap::ArgMatches)> =
                                    clap::ArgMatches::subcommand(Box::leak(Box::new(v405))).map(
                                        |(a, b)| {
                                            (
                                                Func1::new(move |v: &str| {
                                                    Spiral_builder::closure12((), v)
                                                })(
                                                    a
                                                ),
                                                b.clone(),
                                            )
                                        },
                                    );
                                let _v409: LrcPtr<MutCell<Option<Spiral_builder::US5>>> =
                                    refCell(None::<Spiral_builder::US5>);
                                {
                                    let x_17: Option<Spiral_builder::US5> = match &v408 {
                                        None => None::<Spiral_builder::US5>,
                                        Some(v408_0_0) => {
                                            let x_15: (std::string::String, clap::ArgMatches) =
                                                v408_0_0.clone();
                                            Some((Func0::new({
                                                let x_15 = x_15.clone();
                                                move || {
                                                    Spiral_builder::US5::US5_0(
                                                        x_15.0.clone(),
                                                        x_15.1.clone(),
                                                    )
                                                }
                                            }))())
                                        }
                                    };
                                    _v409.set(x_17)
                                }
                                {
                                    let v415: Spiral_builder::US5 = defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        _v409.get().clone(),
                                    );
                                    let v472: string =
                                    string("[workspace]\nresolver = \"2\"\nmembers = [\"packages/*\"]\n\n[workspace.dependencies]\nfable_library_rust = { path = \"../../../../lib/rust/fable/fable_modules/fable-library-rust\", default-features = false, features = [\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"] }\ninline_colorization = \"~0.1\"\n\n");
                                    let v475: Array<(string, string)> = new_array(&[
                                        (
                                            string("cargo_toml_content"),
                                            if let Spiral_builder::US5::US5_0(v415_0_0, v415_0_1) =
                                                &v415
                                            {
                                                let v416: std::string::String = match &v415 {
                                                    Spiral_builder::US5::US5_0(x, _) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                                if fable_library_rust::String_::fromString(
                                                    v416.clone(),
                                                ) == string("rust")
                                                {
                                                    let v422: string = Spiral_builder::method30();
                                                    let v424: &str = &*v422;
                                                    let v426: Option<Vec<std::string::String>> =
                                                        clap::ArgMatches::get_many(
                                                            &match &v415 {
                                                                Spiral_builder::US5::US5_0(
                                                                    _,
                                                                    x,
                                                                ) => x.clone(),
                                                                _ => unreachable!(),
                                                            },
                                                            v424,
                                                        )
                                                        .map(|x| x.cloned().into_iter().collect());
                                                    let _v427: LrcPtr<
                                                        MutCell<Option<Spiral_builder::US6>>,
                                                    > = refCell(None::<Spiral_builder::US6>);
                                                    {
                                                        let x_20: Option<Spiral_builder::US6> =
                                                            match &v426 {
                                                                None => None::<Spiral_builder::US6>,
                                                                Some(v426_0_0) => {
                                                                    let x_18: Vec<
                                                                        std::string::String,
                                                                    > = v426_0_0.clone();
                                                                    Some((Func0::new({
                                                                        let x_18 = x_18.clone();
                                                                        move || {
                                                                            Spiral_builder::US6::US6_0(x_18.clone())
                                                                        }
                                                                    }))(
                                                                    ))
                                                                }
                                                            };
                                                        _v427.set(x_20)
                                                    }
                                                    {
                                                        let v432: Spiral_builder::US6 =
                                                            defaultValue(
                                                                Spiral_builder::US6::US6_1,
                                                                _v427.get().clone(),
                                                            );
                                                        let v435: Vec<std::string::String> =
                                                            new_empty::<std::string::String>()
                                                                .to_vec();
                                                        let v438: Vec<std::string::String> =
                                                            match &v432 {
                                                                Spiral_builder::US6::US6_0(
                                                                    v432_0_0,
                                                                ) => match &v432 {
                                                                    Spiral_builder::US6::US6_0(
                                                                        x,
                                                                    ) => x.clone(),
                                                                    _ => unreachable!(),
                                                                },
                                                                _ => v435,
                                                            };
                                                        let v441: i32 = v438.len() as i32;
                                                        let v443: bool = true;
                                                        let _result = v438.into_iter().map(|x| { //;
                                                             let v445:
                                                                     std::string::String =
                                                                 x;
                                                             let v447:
                                                                     string =
                                                                 fable_library_rust::String_::fromString(v445);
                                                             let v451:
                                                                     string =
                                                                 if contains(v447.clone(),
                                                                             string("="))
                                                                    {
                                                                     v447.clone()
                                                                 } else {
                                                                     sprintf!("{}=\"*\"",
                                                                              v447)
                                                                 };
                                                             let v453: bool =
                                                                 true; v451 }).collect();
                                                        let v455: Vec<string> = _result;
                                                        let v457:
                                                                     Array<string> =
                                                                 fable_library_rust::NativeArray_::array_from(v455);
                                                        let v458: LrcPtr<
                                                            dyn IEnumerable_1<string>,
                                                        > = delay(Func0::new({
                                                            let v457 = v457.clone();
                                                            move || {
                                                                map(
                                                                    Func1::new({
                                                                        let v457 = v457.clone();
                                                                        move |i_2: i32| {
                                                                            v457[i_2].clone()
                                                                        }
                                                                    }),
                                                                    rangeNumeric(
                                                                        0_i32,
                                                                        1_i32,
                                                                        count(v457.clone()) - 1_i32,
                                                                    ),
                                                                )
                                                            }
                                                        }));
                                                        sprintf!("[package]\nname = \"spiral_builder_{}\"\nversion = \"0.0.1\"\nedition = \"2021\"\n\n[dependencies]\nfable_library_rust = {{ workspace = true }}\ninline_colorization = {{ workspace = true }}\n{}\n\n[[bin]]\nname = \"spiral_builder_{}\"\npath = \"spiral_eval.rs\" ",
                                                                      v380.clone(),
                                                                      join(Spiral_builder::method31(),
                                                                           toArray_1(v458)),
                                                                      v380.clone())
                                                    }
                                                } else {
                                                    Spiral_builder::method3(
                                                        Spiral_builder::US0::US0_1,
                                                        Func0::new(move || {
                                                            Spiral_builder::closure13((), ())
                                                        }),
                                                        Func0::new({
                                                            let v416 = v416.clone();
                                                            move || {
                                                                Spiral_builder::closure14(
                                                                    v416.clone(),
                                                                    (),
                                                                )
                                                            }
                                                        }),
                                                    );
                                                    sprintf!("[package]\nname = \"spiral_builder_{}\"\nversion = \"0.0.1\"\nedition = \"2021\"\n\n[dependencies]\nfable_library_rust = {{ workspace = true }}\ninline_colorization = {{ workspace = true }}\n{}\n\n[[bin]]\nname = \"spiral_builder_{}\"\npath = \"spiral_eval.rs\" ",
                                                                  v380.clone(),
                                                                  string(""),
                                                                  v380.clone())
                                                }
                                            } else {
                                                string("")
                                            },
                                        ),
                                        (string("workspace_cargo_toml_content"), v472),
                                    ]);
                                    let v477: Vec<(string, string)> = v475.to_vec();
                                    let v480: Vec<
                                        LrcPtr<(std::string::String, std::string::String)>,
                                    > = v477
                                        .into_iter()
                                        .map(|x| {
                                            Func1::new(move |arg10_0040_4: (string, string)| {
                                                Spiral_builder::closure15((), arg10_0040_4)
                                            })(x.clone())
                                        })
                                        .collect();
                                    let v481: string =
                                    string("std::collections::BTreeMap::from_iter(v480.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                                    let v482: std::collections::BTreeMap<
                                        std::string::String,
                                        std::string::String,
                                    > = std::collections::BTreeMap::from_iter(
                                        v480.iter()
                                            .map(|x| x.as_ref())
                                            .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                                    );
                                    Spiral_builder::method3(
                                        Spiral_builder::US0::US0_1,
                                        Func0::new(move || Spiral_builder::closure16((), ())),
                                        Func0::new({
                                            let v482 = v482.clone();
                                            move || Spiral_builder::closure17(v482.clone(), ())
                                        }),
                                    );
                                    {
                                        let v487: Result<std::string::String, serde_json::Error> =
                                            serde_json::to_string(&v482);
                                        let v488 = Spiral_builder::method32();
                                        let v490: Result<std::string::String, string> =
                                            v487.map_err(|x| v488(x));
                                        let v492: bool = true;
                                        let _result = v490.map(|x| {
                                            //;
                                            let v494: std::string::String = x;
                                            let v496: string =
                                                fable_library_rust::String_::fromString(v494);
                                            let v498: bool = true;
                                            v496
                                        });
                                        let v501: Result<string, string> =
                                            Spiral_builder::method33(_result);
                                        v501
                                    }
                                }
                            }
                        });
                        {
                            {
                                {
                                    //;
                                    __result
                                }
                            }
                        }
                    }
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
                    let v14: string = Spiral_builder::method6();
                    let v16: &str = &*v14;
                    let v18: Option<std::string::String> =
                        clap::ArgMatches::get_one(&v13, v16).cloned();
                    let _v19: LrcPtr<MutCell<Option<Spiral_builder::US2>>> =
                        refCell(None::<Spiral_builder::US2>);
                    {
                        let x_2: Option<Spiral_builder::US2> = match &v18 {
                            None => None::<Spiral_builder::US2>,
                            Some(v18_0_0) => {
                                let x: std::string::String = v18_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Spiral_builder::US2::US2_0(x.clone())
                                }))())
                            }
                        };
                        _v19.set(x_2)
                    }
                    {
                        let v24: Spiral_builder::US2 =
                            defaultValue(Spiral_builder::US2::US2_1, _v19.get().clone());
                        let v28: std::string::String = match &v24 {
                            Spiral_builder::US2::US2_0(v24_0_0) => match &v24 {
                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v30: string = fable_library_rust::String_::fromString(v28);
                        let v31: string = Spiral_builder::method7();
                        let v33: &str = &*v31;
                        let v35: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v13, v33).cloned();
                        let _v36: LrcPtr<MutCell<Option<Spiral_builder::US2>>> =
                            refCell(None::<Spiral_builder::US2>);
                        {
                            let x_5: Option<Spiral_builder::US2> = match &v35 {
                                None => None::<Spiral_builder::US2>,
                                Some(v35_0_0) => {
                                    let x_3: std::string::String = v35_0_0.clone();
                                    Some((Func0::new({
                                        let x_3 = x_3.clone();
                                        move || Spiral_builder::US2::US2_0(x_3.clone())
                                    }))())
                                }
                            };
                            _v36.set(x_5)
                        }
                        {
                            let v41: Spiral_builder::US2 =
                                defaultValue(Spiral_builder::US2::US2_1, _v36.get().clone());
                            let v45: std::string::String = match &v41 {
                                Spiral_builder::US2::US2_0(v41_0_0) => match &v41 {
                                    Spiral_builder::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v47: string = fable_library_rust::String_::fromString(v45);
                            let v48: string = Spiral_builder::method8();
                            let v50: &str = &*v48;
                            let v52: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v13, v50).cloned();
                            let _v53: LrcPtr<MutCell<Option<Spiral_builder::US2>>> =
                                refCell(None::<Spiral_builder::US2>);
                            {
                                let x_8: Option<Spiral_builder::US2> = match &v52 {
                                    None => None::<Spiral_builder::US2>,
                                    Some(v52_0_0) => {
                                        let x_6: std::string::String = v52_0_0.clone();
                                        Some((Func0::new({
                                            let x_6 = x_6.clone();
                                            move || Spiral_builder::US2::US2_0(x_6.clone())
                                        }))())
                                    }
                                };
                                _v53.set(x_8)
                            }
                            {
                                let v58: Spiral_builder::US2 =
                                    defaultValue(Spiral_builder::US2::US2_1, _v53.get().clone());
                                let v65: Spiral_builder::US3 = match &v58 {
                                    Spiral_builder::US2::US2_0(v58_0_0) => {
                                        Spiral_builder::US3::US3_0(
                                            fable_library_rust::String_::fromString(match &v58 {
                                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }),
                                        )
                                    }
                                    _ => Spiral_builder::US3::US3_1,
                                };
                                let v69: string = match &v65 {
                                    Spiral_builder::US3::US3_0(v65_0_0) => match &v65 {
                                        Spiral_builder::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => string(""),
                                };
                                let v70: string = Spiral_builder::method9();
                                let v72: &str = &*v70;
                                let v74: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v13, v72).cloned();
                                let _v75: LrcPtr<MutCell<Option<Spiral_builder::US2>>> =
                                    refCell(None::<Spiral_builder::US2>);
                                {
                                    let x_11: Option<Spiral_builder::US2> = match &v74 {
                                        None => None::<Spiral_builder::US2>,
                                        Some(v74_0_0) => {
                                            let x_9: std::string::String = v74_0_0.clone();
                                            Some((Func0::new({
                                                let x_9 = x_9.clone();
                                                move || Spiral_builder::US2::US2_0(x_9.clone())
                                            }))())
                                        }
                                    };
                                    _v75.set(x_11)
                                }
                                {
                                    let v80: Spiral_builder::US2 = defaultValue(
                                        Spiral_builder::US2::US2_1,
                                        _v75.get().clone(),
                                    );
                                    let v87: Spiral_builder::US3 = match &v80 {
                                        Spiral_builder::US2::US2_0(v80_0_0) => {
                                            Spiral_builder::US3::US3_0(
                                                fable_library_rust::String_::fromString(
                                                    match &v80 {
                                                        Spiral_builder::US2::US2_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                ),
                                            )
                                        }
                                        _ => Spiral_builder::US3::US3_1,
                                    };
                                    match &v87 {
                                        Spiral_builder::US3::US3_0(v87_0_0) => {
                                            let v88: string = match &v87 {
                                                Spiral_builder::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            let v105: Spiral_builder::US0 = if string("Verbose")
                                                == v88.clone()
                                            {
                                                Spiral_builder::US0::US0_0
                                            } else {
                                                if string("Debug") == v88.clone() {
                                                    Spiral_builder::US0::US0_1
                                                } else {
                                                    if string("Info") == v88.clone() {
                                                        Spiral_builder::US0::US0_2
                                                    } else {
                                                        if string("Warning") == v88.clone() {
                                                            Spiral_builder::US0::US0_3
                                                        } else {
                                                            if string("Critical") == v88.clone() {
                                                                Spiral_builder::US0::US0_4
                                                            } else {
                                                                panic!("{}",
                                                                           sprintf!("of_string trace_level / x: {}", v88),)
                                                            }
                                                        }
                                                    }
                                                }
                                            };
                                            v4.l0.set(v105);
                                            ()
                                        }
                                        _ => (),
                                    }
                                    {
                                        let v106: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<string, string>,
                                                >,
                                            >,
                                        > = Spiral_builder::method10(v69, v47, v30);
                                        let v108: Result<string, string> =
                                            futures_lite::future::block_on(v106);
                                        let v110: string = v108.unwrap();
                                        if if let Spiral_builder::US0::US0_2 = &v4.l0.get().clone()
                                        {
                                            true
                                        } else {
                                            false
                                        } {
                                            printfn!("{0}", v110);
                                            ()
                                        }
                                        0_i32
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
