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
mod module_4da4c295 {
    pub mod Rust_builder {
        use super::*;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::compare;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        pub trait IPathJoin {
            fn join(&self, paths: Array<string>) -> string;
        }
        impl<V: IPathJoin + Clone + 'static> IPathJoin for LrcPtr<V> {
            #[inline]
            fn join(&self, paths: Array<string>) -> string {
                (**self).join(paths)
            }
        }
        pub trait IFsExistsSync {
            fn existsSync(&self, path: string) -> bool;
        }
        impl<V: IFsExistsSync + Clone + 'static> IFsExistsSync for LrcPtr<V> {
            #[inline]
            fn existsSync(&self, path: string) -> bool {
                (**self).existsSync(path)
            }
        }
        pub trait IPathDirname {
            fn dirname(&self, path: string) -> string;
        }
        impl<V: IPathDirname + Clone + 'static> IPathDirname for LrcPtr<V> {
            #[inline]
            fn dirname(&self, path: string) -> string {
                (**self).dirname(path)
            }
        }
        pub mod State {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Rust_builder::Mut0>,
                        LrcPtr<Rust_builder::Mut1>,
                        LrcPtr<Rust_builder::Mut1>,
                        LrcPtr<Rust_builder::Mut2>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Rust_builder::Mut0>,
                                LrcPtr<Rust_builder::Mut1>,
                                LrcPtr<Rust_builder::Mut1>,
                                LrcPtr<Rust_builder::Mut2>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_insert_with(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Rust_builder::Mut0>,
                                LrcPtr<Rust_builder::Mut1>,
                                LrcPtr<Rust_builder::Mut1>,
                                LrcPtr<Rust_builder::Mut2>,
                                Option<i64>,
                            )>,
                        ))
                    })
                    .clone()
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US0 {
            US0_0(string),
            US0_1,
        }
        impl Rust_builder::US0 {
            pub fn get_IsUS0_0(this_: &MutCell<Rust_builder::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS0_1(this_: &MutCell<Rust_builder::US0>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Rust_builder::US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0,
            US1_1,
            US1_2,
            US1_3,
            US1_4,
        }
        impl Rust_builder::US1 {
            pub fn get_IsUS1_0(this_: &MutCell<Rust_builder::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_1(this_: &MutCell<Rust_builder::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_2(this_: &MutCell<Rust_builder::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_3(this_: &MutCell<Rust_builder::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS1_4(this_: &MutCell<Rust_builder::US1>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Rust_builder::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Rust_builder::Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut1 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Rust_builder::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<Rust_builder::US1>,
        }
        impl core::fmt::Display for Rust_builder::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl Rust_builder::US2 {
            pub fn get_IsUS2_0(this_: &MutCell<Rust_builder::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS2_1(this_: &MutCell<Rust_builder::US2>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Rust_builder::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(i64),
            US3_1,
        }
        impl Rust_builder::US3 {
            pub fn get_IsUS3_0(this_: &MutCell<Rust_builder::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS3_1(this_: &MutCell<Rust_builder::US3>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Rust_builder::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"path\"#");
            let v7: &'static str = r#"path"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.required(true);
            let v13: clap::Command = clap::Command::arg(v4, v11);
            let v15: string = string("r#\"out_dir\"#");
            let v16: &'static str = r#"out_dir"#;
            let v18: clap::Arg = clap::Arg::new(v16);
            let v20: clap::Arg = v18.required(true);
            clap::Command::arg(v13, v20)
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {} //;
        #[test]
        fn verify_app() {
            //;
            {
                let v2: clap::Command = Rust_builder::method0();
                clap::Command::debug_assert(v2);
                ()
            }
        }
        pub fn method1() -> string {
            string("polyglot")
        }
        pub fn method2() -> string {
            string(".paket")
        }
        pub fn method3() -> string {
            string("polyglot")
        }
        pub fn method4() -> string {
            string(".paket")
        }
        pub fn method6(v0_1: string) -> string {
            v0_1
        }
        pub fn method7(v0_1: string) -> string {
            v0_1
        }
        pub fn method8(v0_1: string) -> string {
            v0_1
        }
        pub fn closure2(unitVar: (), v0_1: string) -> Option<string> {
            let _v1: MutCell<Option<Rust_builder::US0>> = MutCell::new(None::<Rust_builder::US0>);
            let v2: string = Rust_builder::method6(v0_1);
            let v4: &str = fable_library_rust::String_::LrcStr::as_str(&v2);
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            let v10: Option<std::path::PathBuf> = v8.parent().map(std::path::PathBuf::from);
            let v12: std::path::PathBuf = v10?;
            let v14: std::string::String = v12.display().to_string();
            {
                let x: Rust_builder::US0 =
                    Rust_builder::US0::US0_0(fable_library_rust::String_::fromString(v14));
                _v1.set(Some(x))
            }
            {
                let v41: Rust_builder::US0 = getValue(_v1.get().clone());
                match &v41 {
                    Rust_builder::US0::US0_0(v41_0_0) => Some(match &v41 {
                        Rust_builder::US0::US0_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<string>,
                }
            }
        }
        pub fn method9() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Rust_builder::closure2((), v))
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Rust_builder::US0 {
            Rust_builder::US0::US0_0(v0_1)
        }
        pub fn method10() -> Func1<string, Rust_builder::US0> {
            Func1::new(move |v: string| Rust_builder::closure3((), v))
        }
        pub fn method11(v0_1: string, v1_1: string, v2: string) -> string {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method11: loop {
                break '_method11 ({
                    let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v4: string = Rust_builder::method6(v2.get().clone());
                    let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
                    let v8: std::string::String = String::from(v6);
                    let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
                    let v11: string = Rust_builder::method6(v0_1.get().clone());
                    let v13: &str = fable_library_rust::String_::LrcStr::as_str(&v11);
                    let v15: std::string::String = String::from(v13);
                    let v17: std::path::PathBuf = v10.join(v15);
                    let v19: std::string::String = v17.display().to_string();
                    {
                        let x: string = fable_library_rust::String_::fromString(v19);
                        _v3.set(Some(x))
                    }
                    {
                        let _v33: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                        let v34: string = Rust_builder::method6(getValue(_v3.get().clone()));
                        let v36: &str = fable_library_rust::String_::LrcStr::as_str(&v34);
                        let v38: std::string::String = String::from(v36);
                        let v40: std::path::PathBuf = std::path::PathBuf::from(v38);
                        {
                            let x_1: bool = if v40.clone().exists() {
                                v40.is_dir()
                            } else {
                                false
                            };
                            _v33.set(Some(x_1))
                        }
                        if getValue(_v33.get().clone()) {
                            v2.get().clone()
                        } else {
                            let v57: Option<string> = (Rust_builder::method9())(v2.get().clone());
                            let v60: Rust_builder::US0 = defaultValue(
                                Rust_builder::US0::US0_1,
                                map(Rust_builder::method10(), v57),
                            );
                            match &v60 {
                                Rust_builder::US0::US0_0(v60_0_0) => {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: string = match &v60 {
                                        Rust_builder::US0::US0_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    continue '_method11;
                                }
                                _ => panic!(
                                    "{}",
                                    sprintf!(
                                        "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                                        string("dir"),
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v2.get().clone()
                                    ),
                                ),
                            }
                        }
                    }
                });
            }
        }
        pub fn method5(v0_1: string, v1_1: string) -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: string = Rust_builder::method6(v1_1.clone());
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            let v10: string = Rust_builder::method6(v0_1.clone());
            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
            let v14: std::string::String = String::from(v12);
            let v16: std::path::PathBuf = v9.join(v14);
            let v18: std::string::String = v16.display().to_string();
            {
                let x: string = fable_library_rust::String_::fromString(v18);
                _v2.set(Some(x))
            }
            {
                let _v32: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                let v33: string = Rust_builder::method6(getValue(_v2.get().clone()));
                let v35: &str = fable_library_rust::String_::LrcStr::as_str(&v33);
                let v37: std::string::String = String::from(v35);
                let v39: std::path::PathBuf = std::path::PathBuf::from(v37);
                {
                    let x_1: bool = if v39.clone().exists() {
                        v39.is_dir()
                    } else {
                        false
                    };
                    _v32.set(Some(x_1))
                }
                if getValue(_v32.get().clone()) {
                    v1_1.clone()
                } else {
                    let v56: Option<string> = (Rust_builder::method9())(v1_1.clone());
                    let v59: Rust_builder::US0 =
                        defaultValue(Rust_builder::US0::US0_1, map(Rust_builder::method10(), v56));
                    match &v59 {
                        Rust_builder::US0::US0_0(v59_0_0) => Rust_builder::method11(
                            v0_1.clone(),
                            v1_1.clone(),
                            match &v59 {
                                Rust_builder::US0::US0_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        ),
                        _ => panic!(
                            "{}",
                            sprintf!(
                                "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                                string("dir"),
                                v0_1.clone(),
                                v1_1.clone(),
                                v1_1.clone()
                            ),
                        ),
                    }
                }
            }
        }
        pub fn method12() -> string {
            string("polyglot")
        }
        pub fn closure4(unitVar: (), unitVar_1: ()) -> string {
            string("rust_builder.main")
        }
        pub fn closure6(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure5(v0_1: Array<string>, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "args: {} / repository_root: {} / {}",
                v0_1,
                v1_1,
                Rust_builder::closure6((), ())
            )
        }
        pub fn method14(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn method15(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn closure7(
            unitVar: (),
            unitVar_1: (),
        ) -> (
            LrcPtr<Rust_builder::Mut0>,
            LrcPtr<Rust_builder::Mut1>,
            LrcPtr<Rust_builder::Mut1>,
            LrcPtr<Rust_builder::Mut2>,
            Option<i64>,
        ) {
            let v0_1: LrcPtr<Rust_builder::Mut1> = LrcPtr::new(Rust_builder::Mut1 {
                l0: MutCell::new(true),
            });
            let v1_1: LrcPtr<Rust_builder::Mut0> = LrcPtr::new(Rust_builder::Mut0 {
                l0: MutCell::new(0_i64),
            });
            let v3: LrcPtr<Rust_builder::Mut2> = LrcPtr::new(Rust_builder::Mut2 {
                l0: MutCell::new(Rust_builder::US1::US1_0),
            });
            let v4: LrcPtr<Rust_builder::Mut1> = LrcPtr::new(Rust_builder::Mut1 {
                l0: MutCell::new(false),
            });
            let _v5: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
            {
                let x: Option<i64> = Rust_builder::method15(None::<i64>);
                _v5.set(Some(x))
            }
            (v1_1, v4, v0_1, v3, getValue(_v5.get().clone()))
        }
        pub fn closure9(unitVar: (), v0_1: i64) -> Rust_builder::US3 {
            Rust_builder::US3::US3_0(v0_1)
        }
        pub fn method16() -> Func1<i64, Rust_builder::US3> {
            Func1::new(move |v: i64| Rust_builder::closure9((), v))
        }
        pub fn method17() -> string {
            string("")
        }
        pub fn closure8(
            v0_1: Rust_builder::US1,
            v1_1: Func0<string>,
            v2: Func0<string>,
            unitVar: (),
        ) -> string {
            if Rust_builder::State::trace_state().get().clone()
                == None::<(
                    LrcPtr<Rust_builder::Mut0>,
                    LrcPtr<Rust_builder::Mut1>,
                    LrcPtr<Rust_builder::Mut1>,
                    LrcPtr<Rust_builder::Mut2>,
                    Option<i64>,
                )>
            {
                Rust_builder::State::trace_state().set(Some(Rust_builder::closure7((), ())));
            }
            {
                let patternInput: (
                    LrcPtr<Rust_builder::Mut0>,
                    LrcPtr<Rust_builder::Mut1>,
                    LrcPtr<Rust_builder::Mut1>,
                    LrcPtr<Rust_builder::Mut2>,
                    Option<i64>,
                ) = getValue(Rust_builder::State::trace_state().get().clone());
                let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v12: Rust_builder::US3 = defaultValue(
                    Rust_builder::US3::US3_1,
                    map(Rust_builder::method16(), patternInput.4.clone()),
                );
                let v30: DateTime = match &v12 {
                    Rust_builder::US3::US3_0(v12_0_0) => {
                        let v18: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v12 {
                                Rust_builder::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        DateTime::new_ymdhms_milli(
                            1_i32,
                            1_i32,
                            1_i32,
                            v18.hours(),
                            v18.minutes(),
                            v18.seconds(),
                            v18.milliseconds(),
                        )
                    }
                    _ => DateTime::now(),
                };
                {
                    let x: string = v30.toString(string("hh:mm:ss"));
                    _v9.set(Some(x))
                }
                {
                    let v60: string = getValue(_v9.get().clone());
                    let v61: i64 = (patternInput.0.clone()).l0.get().clone();
                    let v72: string = toLower(match &v0_1 {
                        Rust_builder::US1::US1_1 => string("Debug"),
                        Rust_builder::US1::US1_2 => string("Info"),
                        Rust_builder::US1::US1_0 => string("Verbose"),
                        Rust_builder::US1::US1_3 => string("Warning"),
                        _ => string("Critical"),
                    });
                    let _v73: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v88: &str = match &v0_1 {
                        Rust_builder::US1::US1_1 => inline_colorization::color_bright_blue,
                        Rust_builder::US1::US1_2 => inline_colorization::color_bright_green,
                        Rust_builder::US1::US1_0 => inline_colorization::color_bright_black,
                        Rust_builder::US1::US1_3 => inline_colorization::color_bright_yellow,
                        _ => inline_colorization::color_bright_red,
                    };
                    let v90: &str = fable_library_rust::String_::LrcStr::as_str(&v72);
                    let v92: &str = inline_colorization::color_reset;
                    let v94: string = string("format!(\"{v88}{v90}{v92}\")");
                    let v95: std::string::String = format!("{v88}{v90}{v92}");
                    {
                        let x_1: string = fable_library_rust::String_::fromString(v95);
                        _v73.set(Some(x_1))
                    }
                    trimEndChars(
                        trimStartChars(
                            sprintf!(
                                "{} {} #{} {} / {}",
                                v60,
                                getValue(_v73.get().clone()),
                                v61,
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
        pub fn method13(v0_1: Rust_builder::US1, v1_1: Func0<string>, v2: Func0<string>) {
            let v3 = Func0::new(move || Rust_builder::closure7((), ()));
            if Rust_builder::State::trace_state().get().clone()
                == None::<(
                    LrcPtr<Rust_builder::Mut0>,
                    LrcPtr<Rust_builder::Mut1>,
                    LrcPtr<Rust_builder::Mut1>,
                    LrcPtr<Rust_builder::Mut2>,
                    Option<i64>,
                )>
            {
                Rust_builder::State::trace_state().set(Some(v3()));
            }
            {
                let v4: LrcPtr<Rust_builder::Mut0> =
                    (getValue(Rust_builder::State::trace_state().get().clone()))
                        .0
                        .clone();
                if Rust_builder::State::trace_state().get().clone()
                    == None::<(
                        LrcPtr<Rust_builder::Mut0>,
                        LrcPtr<Rust_builder::Mut1>,
                        LrcPtr<Rust_builder::Mut1>,
                        LrcPtr<Rust_builder::Mut2>,
                        Option<i64>,
                    )>
                {
                    Rust_builder::State::trace_state().set(Some(v3()));
                }
                {
                    let patternInput_1: (
                        LrcPtr<Rust_builder::Mut0>,
                        LrcPtr<Rust_builder::Mut1>,
                        LrcPtr<Rust_builder::Mut1>,
                        LrcPtr<Rust_builder::Mut2>,
                        Option<i64>,
                    ) = getValue(Rust_builder::State::trace_state().get().clone());
                    let v14: Rust_builder::US1 = (patternInput_1.3.clone()).l0.get().clone();
                    if if (patternInput_1.2.clone()).l0.get().clone() {
                        compare(v0_1.clone(), v14) >= 0_i32
                    } else {
                        false
                    } {
                        let v19: i64 = v4.l0.get().clone() + 1_i64;
                        v4.l0.set(v19);
                        {
                            let v21: string =
                                sprintf!("{}", Rust_builder::closure8(v0_1, v1_1, v2, ()));
                            let _v22: MutCell<Option<()>> = MutCell::new(None::<()>);
                            println!("{}", v21);
                            _v22.set(Some(()));
                            getValue(_v22.get().clone());
                            ()
                        }
                    }
                }
            }
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) -> string {
            string("rust_builder")
        }
        pub fn closure11(v0_1: clap::Command, v1_1: clap::ArgMatches, unitVar: ()) -> string {
            sprintf!(
                "command: {} / matches: {} / {}",
                format!("{:#?}", v0_1),
                format!("{:#?}", v1_1),
                Rust_builder::closure6((), ())
            )
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: string = Rust_builder::method1();
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            let v10: string = Rust_builder::method2();
            let v12: &str = fable_library_rust::String_::LrcStr::as_str(&v10);
            let v14: std::string::String = String::from(v12);
            let v16: std::path::PathBuf = v9.join(v14);
            let v18: std::string::String = v16.display().to_string();
            {
                let x: string = fable_library_rust::String_::fromString(v18);
                _v2.set(Some(x))
            }
            {
                let _v35: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v36: string = Rust_builder::method6(Rust_builder::method5(
                    getValue(_v2.get().clone()),
                    string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\rust_builder"),
                ));
                let v38: &str = fable_library_rust::String_::LrcStr::as_str(&v36);
                let v40: std::string::String = String::from(v38);
                let v42: std::path::PathBuf = std::path::PathBuf::from(v40);
                let v43: string = Rust_builder::method1();
                let v45: &str = fable_library_rust::String_::LrcStr::as_str(&v43);
                let v47: std::string::String = String::from(v45);
                let v49: std::path::PathBuf = v42.join(v47);
                let v51: std::string::String = v49.display().to_string();
                {
                    let x_1: string = fable_library_rust::String_::fromString(v51);
                    _v35.set(Some(x_1))
                }
                {
                    let v63: string = getValue(_v35.get().clone());
                    Rust_builder::method13(
                        Rust_builder::US1::US1_1,
                        Func0::new(move || Rust_builder::closure4((), ())),
                        Func0::new({
                            let v0_1 = v0_1.clone();
                            let v63 = v63.clone();
                            move || Rust_builder::closure5(v0_1.clone(), v63.clone(), ())
                        }),
                    );
                    {
                        let v67: clap::Command = Rust_builder::method0();
                        let v69: clap::ArgMatches = clap::Command::get_matches(v67.clone());
                        Rust_builder::method13(
                            Rust_builder::US1::US1_1,
                            Func0::new(move || Rust_builder::closure10((), ())),
                            Func0::new({
                                let v67 = v67.clone();
                                let v69 = v69.clone();
                                move || Rust_builder::closure11(v67.clone(), v69.clone(), ())
                            }),
                        );
                        0_i32
                    }
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_insert_with(|| Func0::new(move || Rust_builder::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Rust_builder::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_insert_with(|| {
                Func1::new(move |v: Array<string>| Rust_builder::closure1((), v))
            })
            .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Rust_builder::v1())(args)
        }
    }
}
pub use module_4da4c295::*;
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
    Rust_builder::main(array_from(args));
}
