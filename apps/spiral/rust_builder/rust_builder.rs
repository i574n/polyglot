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
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::String_::padRight;
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
                        LrcPtr<Rust_builder::Mut2>,
                        Option<i64>,
                        LrcPtr<Rust_builder::Mut3>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Rust_builder::Mut0>,
                                LrcPtr<Rust_builder::Mut1>,
                                LrcPtr<Rust_builder::Mut2>,
                                Option<i64>,
                                LrcPtr<Rust_builder::Mut3>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Rust_builder::Mut0>,
                                LrcPtr<Rust_builder::Mut1>,
                                LrcPtr<Rust_builder::Mut2>,
                                Option<i64>,
                                LrcPtr<Rust_builder::Mut3>,
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
        #[derive(Clone, Debug)]
        pub struct Mut3 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Rust_builder::Mut3 {
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
            let v6: clap::Command = Rust_builder::method0();
            clap::Command::debug_assert(v6);
            {
                //;
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
            let v3: string = Rust_builder::method6(v0_1);
            let v5: &str = fable_library_rust::String_::LrcStr::as_str(&v3);
            let v7: std::string::String = String::from(v5);
            let v9: std::path::PathBuf = std::path::PathBuf::from(v7);
            let v11: Option<std::path::PathBuf> = v9.parent().map(std::path::PathBuf::from);
            let v13: std::path::PathBuf = v11?;
            let v15: std::path::Display = v13.display();
            let _v16: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v15);
                _v16.set(Some(x))
            }
            {
                let v27: std::string::String = getValue(_v16.get().clone());
                {
                    let x_1: Rust_builder::US0 =
                        Rust_builder::US0::US0_0(fable_library_rust::String_::fromString(v27));
                    _v1.set(Some(x_1))
                }
                {
                    let v55: Rust_builder::US0 = getValue(_v1.get().clone());
                    match &v55 {
                        Rust_builder::US0::US0_0(v55_0_0) => Some(match &v55 {
                            Rust_builder::US0::US0_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<string>,
                    }
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
                    let v5: string = Rust_builder::method6(v2.get().clone());
                    let v7: &str = fable_library_rust::String_::LrcStr::as_str(&v5);
                    let v9: std::string::String = String::from(v7);
                    let v11: std::path::PathBuf = std::path::PathBuf::from(v9);
                    let v12: string = Rust_builder::method6(v0_1.get().clone());
                    let v14: &str = fable_library_rust::String_::LrcStr::as_str(&v12);
                    let v16: std::string::String = String::from(v14);
                    let v18: std::path::PathBuf = v11.join(v16);
                    let v20: std::path::Display = v18.display();
                    let _v21: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v20);
                        _v21.set(Some(x))
                    }
                    {
                        let v32: std::string::String = getValue(_v21.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v32);
                            _v3.set(Some(x_1))
                        }
                        {
                            let _v46: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                            let v48: string = Rust_builder::method6(getValue(_v3.get().clone()));
                            let v50: &str = fable_library_rust::String_::LrcStr::as_str(&v48);
                            let v52: std::string::String = String::from(v50);
                            let v54: std::path::PathBuf = std::path::PathBuf::from(v52);
                            {
                                let x_2: bool = if v54.clone().exists() {
                                    v54.is_dir()
                                } else {
                                    false
                                };
                                _v46.set(Some(x_2))
                            }
                            if getValue(_v46.get().clone()) {
                                v2.get().clone()
                            } else {
                                let v71: Option<string> =
                                    (Rust_builder::method9())(v2.get().clone());
                                let v74: Rust_builder::US0 = defaultValue(
                                    Rust_builder::US0::US0_1,
                                    map(Rust_builder::method10(), v71),
                                );
                                match &v74 {
                                    Rust_builder::US0::US0_0(v74_0_0) => {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: string = match &v74 {
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
                    }
                });
            }
        }
        pub fn method5(v0_1: string, v1_1: string) -> string {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Rust_builder::method6(v1_1.clone());
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            let v11: string = Rust_builder::method6(v0_1.clone());
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
                {
                    let _v45: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    let v47: string = Rust_builder::method6(getValue(_v2.get().clone()));
                    let v49: &str = fable_library_rust::String_::LrcStr::as_str(&v47);
                    let v51: std::string::String = String::from(v49);
                    let v53: std::path::PathBuf = std::path::PathBuf::from(v51);
                    {
                        let x_2: bool = if v53.clone().exists() {
                            v53.is_dir()
                        } else {
                            false
                        };
                        _v45.set(Some(x_2))
                    }
                    if getValue(_v45.get().clone()) {
                        v1_1.clone()
                    } else {
                        let v70: Option<string> = (Rust_builder::method9())(v1_1.clone());
                        let v73: Rust_builder::US0 = defaultValue(
                            Rust_builder::US0::US0_1,
                            map(Rust_builder::method10(), v70),
                        );
                        match &v73 {
                            Rust_builder::US0::US0_0(v73_0_0) => Rust_builder::method11(
                                v0_1.clone(),
                                v1_1.clone(),
                                match &v73 {
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
        pub fn closure9(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method14(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn method15(v0_1: Option<i64>) -> Option<i64> {
            v0_1
        }
        pub fn closure8(
            unitVar: (),
            unitVar_1: (),
        ) -> (
            LrcPtr<Rust_builder::Mut0>,
            LrcPtr<Rust_builder::Mut1>,
            LrcPtr<Rust_builder::Mut2>,
            Option<i64>,
            LrcPtr<Rust_builder::Mut3>,
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
            let v5: LrcPtr<Rust_builder::Mut3> = LrcPtr::new(Rust_builder::Mut3 {
                l0: MutCell::new(Func1::new(move |v: string| Rust_builder::closure9((), v))),
            });
            let _v6: MutCell<Option<Option<i64>>> = MutCell::new(None::<Option<i64>>);
            {
                let x: Option<i64> = Rust_builder::method15(None::<i64>);
                _v6.set(Some(x))
            }
            (v1_1, v0_1, v3, getValue(_v6.get().clone()), v5)
        }
        pub fn closure10(unitVar: (), v0_1: i64) -> Rust_builder::US3 {
            Rust_builder::US3::US3_0(v0_1)
        }
        pub fn method16() -> Func1<i64, Rust_builder::US3> {
            Func1::new(move |v: i64| Rust_builder::closure10((), v))
        }
        pub fn method17() -> string {
            string("")
        }
        pub fn closure7(
            v0_1: Rust_builder::US1,
            v1_1: Func0<string>,
            v2: Func0<string>,
            unitVar: (),
        ) -> string {
            if Rust_builder::State::trace_state().get().clone().is_none() {
                Rust_builder::State::trace_state().set(Some(Rust_builder::closure8((), ())));
            }
            {
                let patternInput: (
                    LrcPtr<Rust_builder::Mut0>,
                    LrcPtr<Rust_builder::Mut1>,
                    LrcPtr<Rust_builder::Mut2>,
                    Option<i64>,
                    LrcPtr<Rust_builder::Mut3>,
                ) = getValue(Rust_builder::State::trace_state().get().clone());
                let _v9: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v13: Rust_builder::US3 = defaultValue(
                    Rust_builder::US3::US3_1,
                    map(Rust_builder::method16(), patternInput.3.clone()),
                );
                let v31: DateTime = match &v13 {
                    Rust_builder::US3::US3_0(v13_0_0) => {
                        let v19: TimeSpan = TimeSpan::new_ticks(
                            {
                                let _arg: DateTime = DateTime::now();
                                _arg.ticks()
                            } - match &v13 {
                                Rust_builder::US3::US3_0(x) => x.clone(),
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
                    let v74: string = padRight(
                        toLower(match &v0_1 {
                            Rust_builder::US1::US1_1 => string("Debug"),
                            Rust_builder::US1::US1_2 => string("Info"),
                            Rust_builder::US1::US1_0 => string("Verbose"),
                            Rust_builder::US1::US1_3 => string("Warning"),
                            _ => string("Critical"),
                        }),
                        7_i32,
                        ' ',
                    );
                    let _v75: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v91: &str = match &v0_1 {
                        Rust_builder::US1::US1_1 => inline_colorization::color_bright_blue,
                        Rust_builder::US1::US1_2 => inline_colorization::color_bright_green,
                        Rust_builder::US1::US1_0 => inline_colorization::color_bright_black,
                        Rust_builder::US1::US1_3 => inline_colorization::color_bright_yellow,
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
        pub fn method18(v0_1: Rust_builder::US1, v1_1: Func0<string>) {
            let v2 = Func0::new(move || Rust_builder::closure8((), ()));
            if Rust_builder::State::trace_state().get().clone().is_none() {
                Rust_builder::State::trace_state().set(Some(v2()));
            }
            {
                let patternInput: (
                    LrcPtr<Rust_builder::Mut0>,
                    LrcPtr<Rust_builder::Mut1>,
                    LrcPtr<Rust_builder::Mut2>,
                    Option<i64>,
                    LrcPtr<Rust_builder::Mut3>,
                ) = getValue(Rust_builder::State::trace_state().get().clone());
                let v3: LrcPtr<Rust_builder::Mut0> = patternInput.0.clone();
                if Rust_builder::State::trace_state().get().clone().is_none() {
                    Rust_builder::State::trace_state().set(Some(v2()));
                }
                {
                    let patternInput_1: (
                        LrcPtr<Rust_builder::Mut0>,
                        LrcPtr<Rust_builder::Mut1>,
                        LrcPtr<Rust_builder::Mut2>,
                        Option<i64>,
                        LrcPtr<Rust_builder::Mut3>,
                    ) = getValue(Rust_builder::State::trace_state().get().clone());
                    let v13: Rust_builder::US1 = (patternInput_1.2.clone()).l0.get().clone();
                    if if (patternInput_1.1.clone()).l0.get().clone() == false {
                        false
                    } else {
                        find(
                            v0_1,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Rust_builder::US1::US1_0, 0_i32)),
                                LrcPtr::new((Rust_builder::US1::US1_1, 1_i32)),
                                LrcPtr::new((Rust_builder::US1::US1_2, 2_i32)),
                                LrcPtr::new((Rust_builder::US1::US1_3, 3_i32)),
                                LrcPtr::new((Rust_builder::US1::US1_4, 4_i32)),
                            ])))),
                        ) >= find(
                            v13,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Rust_builder::US1::US1_0, 0_i32)),
                                LrcPtr::new((Rust_builder::US1::US1_1, 1_i32)),
                                LrcPtr::new((Rust_builder::US1::US1_2, 2_i32)),
                                LrcPtr::new((Rust_builder::US1::US1_3, 3_i32)),
                                LrcPtr::new((Rust_builder::US1::US1_4, 4_i32)),
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
        pub fn method13(v0_1: Rust_builder::US1, v1_1: Func0<string>, v2: Func0<string>) {
            Rust_builder::method18(
                v0_1.clone(),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    move || Rust_builder::closure7(v0_1.clone(), v1_1.clone(), v2.clone(), ())
                }),
            );
        }
        pub fn closure11(unitVar: (), unitVar_1: ()) -> string {
            string("rust_builder")
        }
        pub fn closure12(v0_1: clap::Command, v1_1: clap::ArgMatches, unitVar: ()) -> string {
            sprintf!(
                "command: {} / matches: {} / {}",
                format!("{:#?}", v0_1),
                format!("{:#?}", v1_1),
                Rust_builder::closure6((), ())
            )
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Rust_builder::method1();
            let v6: &str = fable_library_rust::String_::LrcStr::as_str(&v4);
            let v8: std::string::String = String::from(v6);
            let v10: std::path::PathBuf = std::path::PathBuf::from(v8);
            let v11: string = Rust_builder::method2();
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
                {
                    let _v48: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v50: string = Rust_builder::method6(Rust_builder::method5(
                        getValue(_v2.get().clone()),
                        string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\rust_builder"),
                    ));
                    let v52: &str = fable_library_rust::String_::LrcStr::as_str(&v50);
                    let v54: std::string::String = String::from(v52);
                    let v56: std::path::PathBuf = std::path::PathBuf::from(v54);
                    let v57: string = Rust_builder::method1();
                    let v59: &str = fable_library_rust::String_::LrcStr::as_str(&v57);
                    let v61: std::string::String = String::from(v59);
                    let v63: std::path::PathBuf = v56.join(v61);
                    let v65: std::path::Display = v63.display();
                    let _v66: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_2: std::string::String = format!("{}", v65);
                        _v66.set(Some(x_2))
                    }
                    {
                        let v77: std::string::String = getValue(_v66.get().clone());
                        {
                            let x_3: string = fable_library_rust::String_::fromString(v77);
                            _v48.set(Some(x_3))
                        }
                        {
                            let v89: string = getValue(_v48.get().clone());
                            Rust_builder::method13(
                                Rust_builder::US1::US1_1,
                                Func0::new(move || Rust_builder::closure4((), ())),
                                Func0::new({
                                    let v0_1 = v0_1.clone();
                                    let v89 = v89.clone();
                                    move || Rust_builder::closure5(v0_1.clone(), v89.clone(), ())
                                }),
                            );
                            {
                                let v93: clap::Command = Rust_builder::method0();
                                let v95: clap::ArgMatches = clap::Command::get_matches(v93.clone());
                                Rust_builder::method13(
                                    Rust_builder::US1::US1_1,
                                    Func0::new(move || Rust_builder::closure11((), ())),
                                    Func0::new({
                                        let v93 = v93.clone();
                                        let v95 = v95.clone();
                                        move || {
                                            Rust_builder::closure12(v93.clone(), v95.clone(), ())
                                        }
                                    }),
                                );
                                0_i32
                            }
                        }
                    }
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Rust_builder::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Rust_builder::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Rust_builder::closure1((), v)))
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
