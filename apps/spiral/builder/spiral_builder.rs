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
        use fable_library_rust::Async_::Async;
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
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::refCell;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map as map_1;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map;
        use fable_library_rust::Seq_::ofArray as ofArray_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::append;
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
        type ConcurrentStack_1<T> = T;
        type CancellationToken = ();
        type TaskCanceledException = ();
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
        #[derive(Clone, Debug)]
        pub enum US4 {
            US4_0(std::string::String, clap::ArgMatches),
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
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Spiral_builder::Mut4 {
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
            US5_2(u8, char),
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
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Spiral_builder::Mut5 {
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0,
            US8_1,
        }
        impl Spiral_builder::US8 {
            pub fn get_IsUS8_0(this_: &MutCell<Spiral_builder::US8>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS8_1(this_: &MutCell<Spiral_builder::US8>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0,
            US7_1(Spiral_builder::US8),
            US7_2,
        }
        impl Spiral_builder::US7 {
            pub fn get_IsUS7_0(this_: &MutCell<Spiral_builder::US7>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS7_1(this_: &MutCell<Spiral_builder::US7>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS7_2(this_: &MutCell<Spiral_builder::US7>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US9_1(std::string::String),
        }
        impl Spiral_builder::US9 {
            pub fn get_IsUS9_0(this_: &MutCell<Spiral_builder::US9>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS9_1(this_: &MutCell<Spiral_builder::US9>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US10_1,
        }
        impl Spiral_builder::US10 {
            pub fn get_IsUS10_0(this_: &MutCell<Spiral_builder::US10>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS10_1(this_: &MutCell<Spiral_builder::US10>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(std::string::String),
            US11_1(std::string::String),
        }
        impl Spiral_builder::US11 {
            pub fn get_IsUS11_0(this_: &MutCell<Spiral_builder::US11>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS11_1(this_: &MutCell<Spiral_builder::US11>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US12_1,
        }
        impl Spiral_builder::US12 {
            pub fn get_IsUS12_0(this_: &MutCell<Spiral_builder::US12>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS12_1(this_: &MutCell<Spiral_builder::US12>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US13_1,
        }
        impl Spiral_builder::US13 {
            pub fn get_IsUS13_0(this_: &MutCell<Spiral_builder::US13>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS13_1(this_: &MutCell<Spiral_builder::US13>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0(std::process::Output),
            US14_1(std::string::String),
        }
        impl Spiral_builder::US14 {
            pub fn get_IsUS14_0(this_: &MutCell<Spiral_builder::US14>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS14_1(this_: &MutCell<Spiral_builder::US14>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(Func1<(bool, string, i32), Arc<Async<()>>>),
            US15_1,
        }
        impl Spiral_builder::US15 {
            pub fn get_IsUS15_0(this_: &MutCell<Spiral_builder::US15>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS15_1(this_: &MutCell<Spiral_builder::US15>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US16 {
            US16_0(CancellationToken),
            US16_1,
        }
        impl Spiral_builder::US16 {
            pub fn get_IsUS16_0(this_: &MutCell<Spiral_builder::US16>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS16_1(this_: &MutCell<Spiral_builder::US16>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"trace-level\"#");
            let v7: &'static str = r#"trace-level"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.short('t');
            let v12: string = string("r#\"trace-level\"#");
            let v13: &'static str = r#"trace-level"#;
            let v15: clap::Arg = v11.long(v13);
            let v28: Array<string> = toArray(ofArray(new_array(&[
                string("Verbose"),
                string("Debug"),
                string("Info"),
                string("Warning"),
                string("Critical"),
            ])));
            let v30: Vec<string> = v28.to_vec();
            let v32: bool = true;
            let _result = v30
                .into_iter()
                .map(|x| {
                    //;
                    let v34: string = x;
                    let v36: &str = &*v34;
                    let v38: std::string::String = String::from(v36);
                    let v40: Box<std::string::String> = Box::new(v38);
                    let v42: &'static mut std::string::String = Box::leak(v40);
                    let v44: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v42);
                    let v46: bool = true;
                    v44
                })
                .collect::<Vec<_>>();
            let v48: Vec<clap::builder::PossibleValue> = _result;
            let v50: clap::builder::ValueParser =
                clap::builder::PossibleValuesParser::new(v48).into();
            let v52: clap::Arg = v15.value_parser(v50);
            let v54: clap::Command = clap::Command::arg(v4, v52);
            let v56: clap::Command = clap::Command::subcommand_required(v54, true);
            let v58: string = string("r#\"fsharp\"#");
            let v59: &'static str = r#"fsharp"#;
            let v61: clap::Command = clap::Command::new(v59);
            let v63: string = string("r#\"path\"#");
            let v64: &'static str = r#"path"#;
            let v66: clap::Arg = clap::Arg::new(v64);
            let v68: clap::Arg = v66.short('p');
            let v69: string = string("r#\"path\"#");
            let v70: &'static str = r#"path"#;
            let v72: clap::Arg = v68.long(v70);
            let v74: clap::Arg = v72.required(true);
            let v76: clap::Command = clap::Command::arg(v61, v74);
            let v78: string = string("r#\"package-dir\"#");
            let v79: &'static str = r#"package-dir"#;
            let v81: clap::Arg = clap::Arg::new(v79);
            let v83: clap::Arg = v81.short('d');
            let v84: string = string("r#\"package-dir\"#");
            let v85: &'static str = r#"package-dir"#;
            let v87: clap::Arg = v83.long(v85);
            let v89: clap::Arg = v87.required(true);
            let v91: clap::Command = clap::Command::arg(v76, v89);
            let v93: string = string("r#\"args\"#");
            let v94: &'static str = r#"args"#;
            let v96: clap::Arg = clap::Arg::new(v94);
            let v98: clap::Arg = v96.short('a');
            let v99: string = string("r#\"args\"#");
            let v100: &'static str = r#"args"#;
            let v102: clap::Arg = v98.long(v100);
            let v104: clap::Command = clap::Command::arg(v91, v102);
            let v106: clap::Command = clap::Command::subcommand(v56, v104);
            let v108: string = string("r#\"rust\"#");
            let v109: &'static str = r#"rust"#;
            let v111: clap::Command = clap::Command::new(v109);
            let v113: string = string("r#\"NAME\"#");
            let v116: string = string("r#\"VERSION\"#");
            let v118: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v119: usize = 1_i32 as usize;
            let v120: usize = 0_i32 as usize;
            let v126: clap::builder::ValueRange = if v120 == v120 {
                clap::builder::ValueRange::new(v119..)
            } else {
                clap::builder::ValueRange::new(v119..v120)
            };
            let v128: string = string("r#\"deps\"#");
            let v129: &'static str = r#"deps"#;
            let v131: clap::Arg = clap::Arg::new(v129);
            let v133: clap::Arg = v131.short('d');
            let v134: string = string("r#\"deps\"#");
            let v135: &'static str = r#"deps"#;
            let v137: clap::Arg = v133.long(v135);
            let v139: Vec<&'static str> = v118.to_vec();
            let v141: clap::Arg = v137.value_names(v139);
            let v143: clap::Arg = v141.num_args(v126);
            let v145: clap::ArgAction = clap::ArgAction::Append;
            let v147: clap::Arg = v143.action(v145);
            let v149: clap::Command = clap::Command::arg(v111, v147);
            let v151: clap::Command = clap::Command::subcommand(v106, v149);
            let v153: string = string("r#\"dib\"#");
            let v154: &'static str = r#"dib"#;
            let v156: clap::Command = clap::Command::new(v154);
            let v157: string = string("r#\"path\"#");
            let v158: &'static str = r#"path"#;
            let v160: clap::Arg = clap::Arg::new(v158);
            let v162: clap::Arg = v160.short('p');
            let v163: string = string("r#\"path\"#");
            let v164: &'static str = r#"path"#;
            let v166: clap::Arg = v162.long(v164);
            let v168: clap::Arg = v166.required(true);
            let v170: clap::Command = clap::Command::arg(v156, v168);
            let v172: string = string("clap::value_parser!(u8).into()");
            let v173: clap::builder::ValueParser = clap::value_parser!(u8).into();
            let v175: string = string("r#\"retries\"#");
            let v176: &'static str = r#"retries"#;
            let v178: clap::Arg = clap::Arg::new(v176);
            let v180: clap::Arg = v178.short('r');
            let v181: string = string("r#\"retries\"#");
            let v182: &'static str = r#"retries"#;
            let v184: clap::Arg = v180.long(v182);
            let v186: clap::Arg = v184.value_parser(v173);
            let v188: clap::Command = clap::Command::arg(v170, v186);
            let v190: string = string("r#\"working_directory\"#");
            let v191: &'static str = r#"working_directory"#;
            let v193: clap::Arg = clap::Arg::new(v191);
            let v195: clap::Arg = v193.short('w');
            let v196: string = string("r#\"working_directory\"#");
            let v197: &'static str = r#"working_directory"#;
            let v199: clap::Arg = v195.long(v197);
            let v201: clap::Command = clap::Command::arg(v188, v199);
            clap::Command::subcommand(v151, v201)
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
        pub fn method1() -> string {
            string("")
        }
        pub fn method2() -> string {
            string("AUTOMATION")
        }
        pub fn closure2(
            unitVar: (),
            v0_1: Spiral_builder::US0,
        ) -> (
            LrcPtr<Spiral_builder::Mut0>,
            LrcPtr<Spiral_builder::Mut1>,
            LrcPtr<Spiral_builder::Mut2>,
            Option<i64>,
            LrcPtr<Spiral_builder::Mut3>,
        ) {
            let v1_1: LrcPtr<Spiral_builder::Mut1> = LrcPtr::new(Spiral_builder::Mut1 {
                l0: MutCell::new(true),
            });
            let v2: LrcPtr<Spiral_builder::Mut0> = LrcPtr::new(Spiral_builder::Mut0 {
                l0: MutCell::new(0_i64),
            });
            let v3: LrcPtr<Spiral_builder::Mut2> = LrcPtr::new(Spiral_builder::Mut2 {
                l0: MutCell::new(v0_1),
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
            let v21: string = Spiral_builder::method1();
            {
                let x: string = v20.unwrap_or(v21);
                _v7.set(Some(x))
            }
            {
                let v39: Spiral_builder::US1 = if getValue(_v7.get().clone()) == string("True") {
                    Spiral_builder::US1::US1_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Spiral_builder::US1::US1_1
                };
                {
                    let x_1: Option<i64> = match &v39 {
                        Spiral_builder::US1::US1_0(v39_0_0) => Some(match &v39 {
                            Spiral_builder::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<i64>,
                    };
                    _v6.set(Some(x_1))
                }
                (v2, v1_1, v3, getValue(_v6.get().clone()), v5)
            }
        }
        pub fn method3() -> string {
            string("trace-level")
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
                Spiral_builder::State::trace_state().set(Some(Spiral_builder::closure2(
                    (),
                    Spiral_builder::US0::US0_0,
                )));
            }
            {
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    Option<i64>,
                    LrcPtr<Spiral_builder::Mut3>,
                ) = getValue(Spiral_builder::State::trace_state().get().clone());
                let v8: Option<i64> = patternInput.3.clone();
                let _v10: MutCell<Option<string>> = MutCell::new(None::<string>);
                let _v11: LrcPtr<MutCell<Option<Spiral_builder::US1>>> =
                    refCell(None::<Spiral_builder::US1>);
                {
                    let x_2: Option<Spiral_builder::US1> = match &v8 {
                        None => None::<Spiral_builder::US1>,
                        Some(v8_0_0) => {
                            let x: i64 = v8_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Spiral_builder::US1::US1_0(x)
                            }))())
                        }
                    };
                    _v11.set(x_2)
                }
                {
                    let v16: Spiral_builder::US1 =
                        defaultValue(Spiral_builder::US1::US1_1, _v11.get().clone());
                    let v34: DateTime = match &v16 {
                        Spiral_builder::US1::US1_0(v16_0_0) => {
                            let v22: TimeSpan = TimeSpan::new_ticks(
                                {
                                    let _arg: DateTime = DateTime::now();
                                    _arg.ticks()
                                } - match &v16 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                            );
                            DateTime::new_ymdhms_milli(
                                1_i32,
                                1_i32,
                                1_i32,
                                v22.hours(),
                                v22.minutes(),
                                v22.seconds(),
                                v22.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    {
                        let x_3: string = v34.toString(string("hh:mm:ss"));
                        _v10.set(Some(x_3))
                    }
                    {
                        let v67: string = getValue(_v10.get().clone());
                        let v68: i64 = (patternInput.0.clone()).l0.get().clone();
                        let v80: string = padLeft(
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
                        let _v81: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v96: &str = match &v0_1 {
                            Spiral_builder::US0::US0_1 => inline_colorization::color_bright_blue,
                            Spiral_builder::US0::US0_2 => inline_colorization::color_bright_green,
                            Spiral_builder::US0::US0_0 => inline_colorization::color_bright_black,
                            Spiral_builder::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v98: &str = &*v80;
                        let v100: &str = inline_colorization::color_reset;
                        let v102: string = string("format!(\"{v96}{v98}{v100}\")");
                        let v103: std::string::String = format!("{v96}{v98}{v100}");
                        {
                            let x_4: string = fable_library_rust::String_::fromString(v103);
                            _v81.set(Some(x_4))
                        }
                        trimEndChars(
                            trimStartChars(
                                sprintf!(
                                    "{} {} #{} {} / {}",
                                    v67,
                                    getValue(_v81.get().clone()),
                                    v68,
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
        pub fn method6(v0_1: Spiral_builder::US0, v1_1: Func0<string>) {
            fn v2(
                v: Spiral_builder::US0,
            ) -> (
                LrcPtr<Spiral_builder::Mut0>,
                LrcPtr<Spiral_builder::Mut1>,
                LrcPtr<Spiral_builder::Mut2>,
                Option<i64>,
                LrcPtr<Spiral_builder::Mut3>,
            ) {
                Spiral_builder::closure2((), v)
            }
            if Spiral_builder::State::trace_state().get().clone().is_none() {
                Spiral_builder::State::trace_state().set(Some(v2(Spiral_builder::US0::US0_0)));
            }
            {
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    Option<i64>,
                    LrcPtr<Spiral_builder::Mut3>,
                ) = getValue(Spiral_builder::State::trace_state().get().clone());
                let v4: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                if Spiral_builder::State::trace_state().get().clone().is_none() {
                    Spiral_builder::State::trace_state().set(Some(v2(Spiral_builder::US0::US0_0)));
                }
                {
                    let patternInput_1: (
                        LrcPtr<Spiral_builder::Mut0>,
                        LrcPtr<Spiral_builder::Mut1>,
                        LrcPtr<Spiral_builder::Mut2>,
                        Option<i64>,
                        LrcPtr<Spiral_builder::Mut3>,
                    ) = getValue(Spiral_builder::State::trace_state().get().clone());
                    let v15: Spiral_builder::US0 = (patternInput_1.2.clone()).l0.get().clone();
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
                            v15,
                            ofSeq(ofList(ofArray(new_array(&[
                                LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                                LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                            ])))),
                        )
                    } {
                        let v23: i64 = v4.l0.get().clone() + 1_i64;
                        v4.l0.set(v23);
                        {
                            let v24: string = sprintf!("{}", v1_1());
                            let _v25: MutCell<Option<()>> = MutCell::new(None::<()>);
                            println!("{}", v24.clone());
                            _v25.set(Some(()));
                            getValue(_v25.get().clone());
                            ((patternInput.4.clone()).l0.get().clone())(v24)
                        }
                    }
                }
            }
        }
        pub fn method4(v0_1: Spiral_builder::US0, v1_1: Func0<string>, v2: Func0<string>) {
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
        pub fn closure8(unitVar: (), v0_1: &str) -> std::string::String {
            String::from(v0_1)
        }
        pub fn method8() -> string {
            string("path")
        }
        pub fn method9() -> string {
            string("package-dir")
        }
        pub fn method10() -> string {
            string("args")
        }
        pub fn method12(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn closure10(
            v0_1: char,
            v1_1: LrcPtr<Spiral_builder::UH1>,
        ) -> LrcPtr<Spiral_builder::UH1> {
            LrcPtr::new(Spiral_builder::UH1::UH1_1(v0_1, v1_1))
        }
        pub fn closure9(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Spiral_builder::UH1>, LrcPtr<Spiral_builder::UH1>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Spiral_builder::UH1>| Spiral_builder::closure10(v0_1, v)
            })
        }
        pub fn method13(
        ) -> Func1<char, Func1<LrcPtr<Spiral_builder::UH1>, LrcPtr<Spiral_builder::UH1>>> {
            Func1::new(move |v: char| Spiral_builder::closure9((), v))
        }
        pub fn method16(
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
                        Spiral_builder::method16(
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
        pub fn method15(
            v0_1: string,
            v1_1: LrcPtr<Spiral_builder::UH0>,
            v2: LrcPtr<Spiral_builder::UH1>,
            v3: Spiral_builder::US5,
        ) -> (LrcPtr<Spiral_builder::UH0>, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US5> = MutCell::new(v3.clone());
            '_method15: loop {
                break '_method15 (match &v3.get().clone() {
                    Spiral_builder::US5::US5_1(v3_1_0) => {
                        let v259: char = v3_1_0.clone();
                        if '\"' == v259 {
                            if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                v2.get().clone().as_ref()
                            {
                                let v262: LrcPtr<Spiral_builder::UH1> =
                                    match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                let v261: char = match v2.get().clone().as_ref() {
                                    Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if '\"' == v261 {
                                    Spiral_builder::method14(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v262.clone(),
                                        v3.get().clone(),
                                        Spiral_builder::US5::US5_0,
                                    )
                                } else {
                                    if '\\' == v259 {
                                        if '\\' == v261 {
                                            Spiral_builder::method14(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v262.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_2(0_u8, v261),
                                            )
                                        } else {
                                            if '`' == v261 {
                                                Spiral_builder::method14(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v262.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_2(0_u8, v261),
                                                )
                                            } else {
                                                if ' ' == v261 {
                                                    let v0_1_temp: string =
                                                        sprintf!("{} ", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v262.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method15;
                                                } else {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}{}", v0_1.get().clone(), v261);
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v262.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method15;
                                                }
                                            }
                                        }
                                    } else {
                                        if '`' == v259 {
                                            if '\\' == v261 {
                                                Spiral_builder::method14(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v262.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_2(0_u8, v261),
                                                )
                                            } else {
                                                if '`' == v261 {
                                                    Spiral_builder::method14(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v262.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_2(0_u8, v261),
                                                    )
                                                } else {
                                                    if ' ' == v261 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v262.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v261
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v262;
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    }
                                                }
                                            }
                                        } else {
                                            if '\\' == v261 {
                                                Spiral_builder::method14(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v262.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_2(0_u8, v261),
                                                )
                                            } else {
                                                if '`' == v261 {
                                                    Spiral_builder::method14(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v262.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_2(0_u8, v261),
                                                    )
                                                } else {
                                                    if ' ' == v261 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v262.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v261
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v262.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            } else {
                                if '\\' == v259 {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method16(
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
                                    if '`' == v259 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
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
                                                Spiral_builder::method16(
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
                        } else {
                            if '\\' == v259 {
                                if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v372: LrcPtr<Spiral_builder::UH1> =
                                        match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v371: char = match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v371 {
                                        if if !(v3.get().clone()
                                            == Spiral_builder::US5::US5_2(0_u8, '\\'))
                                        {
                                            !(v3.get().clone()
                                                == Spiral_builder::US5::US5_2(0_u8, '`'))
                                        } else {
                                            false
                                        } {
                                            Spiral_builder::method14(
                                                sprintf!("{}{}\"", v0_1.get().clone(), v259),
                                                v1_1.get().clone(),
                                                v372.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_1('\"'),
                                            )
                                        } else {
                                            Spiral_builder::method14(
                                                sprintf!("{}{}\"", v0_1.get().clone(), v259),
                                                v1_1.get().clone(),
                                                v372.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_1('\"'),
                                            )
                                        }
                                    } else {
                                        if '\\' == v371 {
                                            Spiral_builder::method14(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v372.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_2(0_u8, v371),
                                            )
                                        } else {
                                            if '`' == v371 {
                                                Spiral_builder::method14(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v372.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_2(0_u8, v371),
                                                )
                                            } else {
                                                if ' ' == v371 {
                                                    let v0_1_temp: string =
                                                        sprintf!("{} ", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v372;
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method15;
                                                } else {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}{}", v0_1.get().clone(), v371);
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v372.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method15;
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method16(
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
                                if '`' == v259 {
                                    if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                        v2.get().clone().as_ref()
                                    {
                                        let v426: LrcPtr<Spiral_builder::UH1> =
                                            match v2.get().clone().as_ref() {
                                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                        let v425: char = match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if '\"' == v425 {
                                            if if !(v3.get().clone()
                                                == Spiral_builder::US5::US5_2(0_u8, '\\'))
                                            {
                                                !(v3.get().clone()
                                                    == Spiral_builder::US5::US5_2(0_u8, '`'))
                                            } else {
                                                false
                                            } {
                                                Spiral_builder::method14(
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v259),
                                                    v1_1.get().clone(),
                                                    v426.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_1('\"'),
                                                )
                                            } else {
                                                Spiral_builder::method14(
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v259),
                                                    v1_1.get().clone(),
                                                    v426.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_1('\"'),
                                                )
                                            }
                                        } else {
                                            if '\\' == v425 {
                                                Spiral_builder::method14(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v426.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_2(0_u8, v425),
                                                )
                                            } else {
                                                if '`' == v425 {
                                                    Spiral_builder::method14(
                                                        v0_1.get().clone(),
                                                        v1_1.get().clone(),
                                                        v426.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_2(0_u8, v425),
                                                    )
                                                } else {
                                                    if ' ' == v425 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v426;
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v425
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v426.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
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
                                        let v479: LrcPtr<Spiral_builder::UH1> =
                                            match v2.get().clone().as_ref() {
                                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                        let v478: char = match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if '\\' == v478 {
                                            Spiral_builder::method14(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v479.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_2(0_u8, v478),
                                            )
                                        } else {
                                            if '`' == v478 {
                                                Spiral_builder::method14(
                                                    v0_1.get().clone(),
                                                    v1_1.get().clone(),
                                                    v479.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_2(0_u8, v478),
                                                )
                                            } else {
                                                if '\"' == v478 {
                                                    Spiral_builder::method14(
                                                        string(""),
                                                        Spiral_builder::method16(
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
                                                        v479.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_0,
                                                    )
                                                } else {
                                                    if ' ' == v478 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v479;
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v478
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v479.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
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
                                Spiral_builder::method14(
                                    string(""),
                                    v1_1.get().clone(),
                                    v5.clone(),
                                    v3.get().clone(),
                                    Spiral_builder::US5::US5_1('\"'),
                                )
                            } else {
                                if '\\' == v4 {
                                    Spiral_builder::method14(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v5.clone(),
                                        v3.get().clone(),
                                        Spiral_builder::US5::US5_2(0_u8, v4),
                                    )
                                } else {
                                    if '`' == v4 {
                                        Spiral_builder::method14(
                                            v0_1.get().clone(),
                                            v1_1.get().clone(),
                                            v5.clone(),
                                            v3.get().clone(),
                                            Spiral_builder::US5::US5_2(0_u8, v4),
                                        )
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = string("");
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
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
                                            continue '_method15;
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
                                            continue '_method15;
                                        }
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Spiral_builder::method16(
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
                    Spiral_builder::US5::US5_2(v3_2_0, v3_2_1) => {
                        let v52: char = match &v3.get().clone() {
                            Spiral_builder::US5::US5_2(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v51: u8 = match &v3.get().clone() {
                            Spiral_builder::US5::US5_2(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                            v2.get().clone().as_ref()
                        {
                            let v54: LrcPtr<Spiral_builder::UH1> = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v53: char = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\\' == v53 {
                                Spiral_builder::method14(
                                    v0_1.get().clone(),
                                    v1_1.get().clone(),
                                    v54.clone(),
                                    v3.get().clone(),
                                    Spiral_builder::US5::US5_1(v53),
                                )
                            } else {
                                if '`' == v53 {
                                    Spiral_builder::method14(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v54.clone(),
                                        v3.get().clone(),
                                        Spiral_builder::US5::US5_1(v53),
                                    )
                                } else {
                                    if 0_u8 == v51 {
                                        if '\\' == v52 {
                                            if '\"' == v53 {
                                                Spiral_builder::method14(
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v52),
                                                    v1_1.get().clone(),
                                                    v54.clone(),
                                                    v3.get().clone(),
                                                    Spiral_builder::US5::US5_2(v51, v52),
                                                )
                                            } else {
                                                if ' ' == v53 {
                                                    let v0_1_temp: string =
                                                        sprintf!("{} ", v0_1.get().clone());
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v54.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method15;
                                                } else {
                                                    if 1_u8 == v51 {
                                                        if !(v3.get().clone() == v3.get().clone()) {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}\\{}",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v54.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            continue '_method15;
                                                        } else {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v54.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            continue '_method15;
                                                        }
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v54.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    }
                                                }
                                            }
                                        } else {
                                            if '`' == v52 {
                                                if '\"' == v53 {
                                                    Spiral_builder::method14(
                                                        sprintf!("{}{}\"", v0_1.get().clone(), v52),
                                                        v1_1.get().clone(),
                                                        v54.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_2(v51, v52),
                                                    )
                                                } else {
                                                    if ' ' == v53 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v54.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    } else {
                                                        if 1_u8 == v51 {
                                                            if !(v3.get().clone()
                                                                == v3.get().clone())
                                                            {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}\\{}",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Spiral_builder::UH0,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v54.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                continue '_method15;
                                                            } else {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Spiral_builder::UH0,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v54.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                continue '_method15;
                                                            }
                                                        } else {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v54.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            continue '_method15;
                                                        }
                                                    }
                                                }
                                            } else {
                                                if '\"' == v53 {
                                                    Spiral_builder::method14(
                                                        sprintf!("{}{}\"", v0_1.get().clone(), v52),
                                                        v1_1.get().clone(),
                                                        v54.clone(),
                                                        v3.get().clone(),
                                                        Spiral_builder::US5::US5_2(v51, v52),
                                                    )
                                                } else {
                                                    if ' ' == v53 {
                                                        let v0_1_temp: string =
                                                            sprintf!("{} ", v0_1.get().clone());
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v54.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    } else {
                                                        if 1_u8 == v51 {
                                                            if !(v3.get().clone()
                                                                == v3.get().clone())
                                                            {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}\\{}",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Spiral_builder::UH0,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v54.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                continue '_method15;
                                                            } else {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Spiral_builder::UH0,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v54.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                continue '_method15;
                                                            }
                                                        } else {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v54.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            continue '_method15;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        if '\"' == v53 {
                                            Spiral_builder::method14(
                                                sprintf!("{}{}\"", v0_1.get().clone(), v52),
                                                v1_1.get().clone(),
                                                v54.clone(),
                                                v3.get().clone(),
                                                Spiral_builder::US5::US5_2(v51, v52),
                                            )
                                        } else {
                                            if ' ' == v53 {
                                                let v0_1_temp: string =
                                                    sprintf!("{} ", v0_1.get().clone());
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v54.clone();
                                                let v3_temp: Spiral_builder::US5 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method15;
                                            } else {
                                                if 1_u8 == v51 {
                                                    if !(v3.get().clone() == v3.get().clone()) {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}\\{}",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v54.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    } else {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v54.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v3.get().clone();
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        continue '_method15;
                                                    }
                                                } else {
                                                    let v0_1_temp: string =
                                                        sprintf!("{}{}", v0_1.get().clone(), v53);
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v54.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v3.get().clone();
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    continue '_method15;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if 0_u8 == v51 {
                                if '\\' == v52 {
                                    if 1_u8 == v51 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
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
                                                Spiral_builder::method16(
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
                                    if '`' == v52 {
                                        if 1_u8 == v51 {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
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
                                                    Spiral_builder::method16(
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
                                        if 1_u8 == v51 {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
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
                                                    Spiral_builder::method16(
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
                            } else {
                                if 1_u8 == v51 {
                                    (
                                        if v0_1.get().clone() == string("") {
                                            v1_1.get().clone()
                                        } else {
                                            Spiral_builder::method16(
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
                                            Spiral_builder::method16(
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
                });
            }
        }
        pub fn method14(
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
            '_method14: loop {
                break '_method14 (match &v4.get().clone() {
                    Spiral_builder::US5::US5_1(v4_1_0) => {
                        let v581: char = v4_1_0.clone();
                        if '\"' == v581 {
                            if let Spiral_builder::US5::US5_1(v3_1_0) = &v3.get().clone() {
                                if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v585: LrcPtr<Spiral_builder::UH1> =
                                        match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v584: char = match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v584 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v585.clone();
                                        let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                        let v4_temp: Spiral_builder::US5 =
                                            Spiral_builder::US5::US5_0;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method14;
                                    } else {
                                        if '\\' == v581 {
                                            if '\\' == v584 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v585.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(0_u8, v584);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if '`' == v584 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v585.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(0_u8, v584);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if ' ' == v584 {
                                                        Spiral_builder::method15(
                                                            sprintf!("{} ", v0_1.get().clone()),
                                                            v1_1.get().clone(),
                                                            v585.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    } else {
                                                        Spiral_builder::method15(
                                                            sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v584
                                                            ),
                                                            v1_1.get().clone(),
                                                            v585.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    }
                                                }
                                            }
                                        } else {
                                            if '`' == v581 {
                                                if '\\' == v584 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v585.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(0_u8, v584);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if '`' == v584 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v585.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_2(0_u8, v584);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if ' ' == v584 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v585,
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v584
                                                                ),
                                                                v1_1.get().clone(),
                                                                v585.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            } else {
                                                if '\\' == v584 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v585.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(0_u8, v584);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if '`' == v584 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v585.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_2(0_u8, v584);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if ' ' == v584 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v585.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v584
                                                                ),
                                                                v1_1.get().clone(),
                                                                v585.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    if '\\' == v581 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
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
                                        if '`' == v581 {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
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
                                                    Spiral_builder::method16(
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
                            } else {
                                if '\\' == v581 {
                                    if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                        v2.get().clone().as_ref()
                                    {
                                        let v695: LrcPtr<Spiral_builder::UH1> =
                                            match v2.get().clone().as_ref() {
                                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                        let v694: char = match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if '\"' == v694 {
                                            if if !(v3.get().clone()
                                                == Spiral_builder::US5::US5_2(0_u8, '\\'))
                                            {
                                                !(v3.get().clone()
                                                    == Spiral_builder::US5::US5_2(0_u8, '`'))
                                            } else {
                                                false
                                            } {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v581);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v695.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v695.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            }
                                        } else {
                                            if '\\' == v694 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v695.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(1_u8, v694);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if '`' == v694 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v695.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(1_u8, v694);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if let Spiral_builder::US5::US5_2(
                                                        v3_2_0,
                                                        v3_2_1,
                                                    ) = &v3.get().clone()
                                                    {
                                                        if 0_u8
                                                            == match &v3.get().clone() {
                                                                Spiral_builder::US5::US5_2(
                                                                    x,
                                                                    _,
                                                                ) => x.clone(),
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            if ' ' == v694 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v695.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v694
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v695,
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        } else {
                                                            if ' ' == v694 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v695.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v694
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v695.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    } else {
                                                        if ' ' == v694 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v695.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v694
                                                                ),
                                                                v1_1.get().clone(),
                                                                v695.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        if let Spiral_builder::US5::US5_2(v3_2_0, v3_2_1) =
                                            &v3.get().clone()
                                        {
                                            if 0_u8
                                                == match &v3.get().clone() {
                                                    Spiral_builder::US5::US5_2(x, _) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                            {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        } else {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
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
                                    if '`' == v581 {
                                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                            v2.get().clone().as_ref()
                                        {
                                            let v791: LrcPtr<Spiral_builder::UH1> =
                                                match v2.get().clone().as_ref() {
                                                    Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            let v790: char = match v2.get().clone().as_ref() {
                                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if '\"' == v790 {
                                                if if !(v3.get().clone()
                                                    == Spiral_builder::US5::US5_2(0_u8, '\\'))
                                                {
                                                    !(v3.get().clone()
                                                        == Spiral_builder::US5::US5_2(0_u8, '`'))
                                                } else {
                                                    false
                                                } {
                                                    let v0_1_temp: string = sprintf!(
                                                        "{}{}\"",
                                                        v0_1.get().clone(),
                                                        v581
                                                    );
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v791.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v791.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                }
                                            } else {
                                                if '\\' == v790 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v791.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(1_u8, v790);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if '`' == v790 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v791.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_2(1_u8, v790);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if let Spiral_builder::US5::US5_2(
                                                            v3_2_0,
                                                            v3_2_1,
                                                        ) = &v3.get().clone()
                                                        {
                                                            if 0_u8
                                                                == match &v3.get().clone() {
                                                                    Spiral_builder::US5::US5_2(
                                                                        x,
                                                                        _,
                                                                    ) => x.clone(),
                                                                    _ => unreachable!(),
                                                                }
                                                            {
                                                                if ' ' == v790 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v791.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v790
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v791,
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                if ' ' == v790 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v791.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v790
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v791.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        } else {
                                                            if ' ' == v790 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v791.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v790
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v791.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if let Spiral_builder::US5::US5_2(v3_2_0, v3_2_1) =
                                                &v3.get().clone()
                                            {
                                                if 0_u8
                                                    == match &v3.get().clone() {
                                                        Spiral_builder::US5::US5_2(x, _) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                } else {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        }
                                    } else {
                                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                            v2.get().clone().as_ref()
                                        {
                                            let v886: LrcPtr<Spiral_builder::UH1> =
                                                match v2.get().clone().as_ref() {
                                                    Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            let v885: char = match v2.get().clone().as_ref() {
                                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if '\\' == v885 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v886.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(1_u8, v885);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if '`' == v885 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v886.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(1_u8, v885);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if let Spiral_builder::US5::US5_2(
                                                        v3_2_0,
                                                        v3_2_1,
                                                    ) = &v3.get().clone()
                                                    {
                                                        if 0_u8
                                                            == match &v3.get().clone() {
                                                                Spiral_builder::US5::US5_2(
                                                                    x,
                                                                    _,
                                                                ) => x.clone(),
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            if '\"' == v885 {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}",
                                                                    v0_1.get().clone()
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Spiral_builder::UH0,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v886.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v4.get().clone();
                                                                let v4_temp: Spiral_builder::US5 =
                                                                    Spiral_builder::US5::US5_1(
                                                                        '\"',
                                                                    );
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method14;
                                                            } else {
                                                                if ' ' == v885 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v886.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v885
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v886.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        } else {
                                                            if '\"' == v885 {
                                                                let v0_1_temp: string = string("");
                                                                let v1_1_temp:
                                                                                 LrcPtr<Spiral_builder::UH0> =
                                                                             Spiral_builder::method16(v1_1.get().clone(),
                                                                                                      LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                             LrcPtr::new(Spiral_builder::UH0::UH0_0))));
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v886.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v4.get().clone();
                                                                let v4_temp: Spiral_builder::US5 =
                                                                    Spiral_builder::US5::US5_0;
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method14;
                                                            } else {
                                                                if ' ' == v885 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v886,
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v885
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v886.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        if '\"' == v885 {
                                                            let v0_1_temp: string = string("");
                                                            let v1_1_temp:
                                                                             LrcPtr<Spiral_builder::UH0> =
                                                                         Spiral_builder::method16(v1_1.get().clone(),
                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                         LrcPtr::new(Spiral_builder::UH0::UH0_0))));
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v886.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v4.get().clone();
                                                            let v4_temp: Spiral_builder::US5 =
                                                                Spiral_builder::US5::US5_0;
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method14;
                                                        } else {
                                                            if ' ' == v885 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v886.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v885
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v886.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if let Spiral_builder::US5::US5_2(v3_2_0, v3_2_1) =
                                                &v3.get().clone()
                                            {
                                                if 0_u8
                                                    == match &v3.get().clone() {
                                                        Spiral_builder::US5::US5_2(x, _) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                } else {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if '\\' == v581 {
                                if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                    v2.get().clone().as_ref()
                                {
                                    let v998: LrcPtr<Spiral_builder::UH1> =
                                        match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                    let v997: char = match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if '\"' == v997 {
                                        if if !(v3.get().clone()
                                            == Spiral_builder::US5::US5_2(0_u8, '\\'))
                                        {
                                            !(v3.get().clone()
                                                == Spiral_builder::US5::US5_2(0_u8, '`'))
                                        } else {
                                            false
                                        } {
                                            let v0_1_temp: string =
                                                sprintf!("{}{}\"", v0_1.get().clone(), v581);
                                            let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v998.clone();
                                            let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                            let v4_temp: Spiral_builder::US5 =
                                                Spiral_builder::US5::US5_1('\"');
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            v4.set(v4_temp);
                                            continue '_method14;
                                        } else {
                                            if let Spiral_builder::US5::US5_1(v3_1_0) =
                                                &v3.get().clone()
                                            {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v581);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v998.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v998.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_0;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            }
                                        }
                                    } else {
                                        if let Spiral_builder::US5::US5_1(v3_1_0) =
                                            &v3.get().clone()
                                        {
                                            if '\\' == v997 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v998.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(0_u8, v997);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if '`' == v997 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v998.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(0_u8, v997);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if ' ' == v997 {
                                                        Spiral_builder::method15(
                                                            sprintf!("{} ", v0_1.get().clone()),
                                                            v1_1.get().clone(),
                                                            v998.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    } else {
                                                        Spiral_builder::method15(
                                                            sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v997
                                                            ),
                                                            v1_1.get().clone(),
                                                            v998.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    }
                                                }
                                            }
                                        } else {
                                            if '\\' == v997 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v998.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(1_u8, v997);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if '`' == v997 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v998.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(1_u8, v997);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if let Spiral_builder::US5::US5_2(
                                                        v3_2_0,
                                                        v3_2_1,
                                                    ) = &v3.get().clone()
                                                    {
                                                        if 0_u8
                                                            == match &v3.get().clone() {
                                                                Spiral_builder::US5::US5_2(
                                                                    x,
                                                                    _,
                                                                ) => x.clone(),
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            if ' ' == v997 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v998.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v997
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v998.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        } else {
                                                            if ' ' == v997 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v998.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v997
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v998.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    } else {
                                                        if ' ' == v997 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v998.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v997
                                                                ),
                                                                v1_1.get().clone(),
                                                                v998.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    match &v3.get().clone() {
                                        Spiral_builder::US5::US5_2(v3_2_0, v3_2_1) => {
                                            if 0_u8
                                                == match &v3.get().clone() {
                                                    Spiral_builder::US5::US5_2(x, _) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                            {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        }
                                        Spiral_builder::US5::US5_1(v3_1_0) => (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                    )),
                                                )
                                            },
                                            v0_1.get().clone(),
                                        ),
                                        _ => (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
                                                    v1_1.get().clone(),
                                                    LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                        v0_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                    )),
                                                )
                                            },
                                            v0_1.get().clone(),
                                        ),
                                    }
                                }
                            } else {
                                if '`' == v581 {
                                    if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                        v2.get().clone().as_ref()
                                    {
                                        let v1137: LrcPtr<Spiral_builder::UH1> =
                                            match v2.get().clone().as_ref() {
                                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                        let v1136: char = match v2.get().clone().as_ref() {
                                            Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                            _ => unreachable!(),
                                        };
                                        if '\"' == v1136 {
                                            if if !(v3.get().clone()
                                                == Spiral_builder::US5::US5_2(0_u8, '\\'))
                                            {
                                                !(v3.get().clone()
                                                    == Spiral_builder::US5::US5_2(0_u8, '`'))
                                            } else {
                                                false
                                            } {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v581);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v1137.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_1('\"');
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if let Spiral_builder::US5::US5_1(v3_1_0) =
                                                    &v3.get().clone()
                                                {
                                                    let v0_1_temp: string = sprintf!(
                                                        "{}{}\"",
                                                        v0_1.get().clone(),
                                                        v581
                                                    );
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v1137.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_1('\"');
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v1137.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_0;
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                }
                                            }
                                        } else {
                                            if let Spiral_builder::US5::US5_1(v3_1_0) =
                                                &v3.get().clone()
                                            {
                                                if '\\' == v1136 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v1137.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(0_u8, v1136);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if '`' == v1136 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v1137.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_2(0_u8, v1136);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if ' ' == v1136 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v1137.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v1136
                                                                ),
                                                                v1_1.get().clone(),
                                                                v1137.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            } else {
                                                if '\\' == v1136 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v1137.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(1_u8, v1136);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if '`' == v1136 {
                                                        let v0_1_temp: string = v0_1.get().clone();
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v1137.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_2(1_u8, v1136);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if let Spiral_builder::US5::US5_2(
                                                            v3_2_0,
                                                            v3_2_1,
                                                        ) = &v3.get().clone()
                                                        {
                                                            if 0_u8
                                                                == match &v3.get().clone() {
                                                                    Spiral_builder::US5::US5_2(
                                                                        x,
                                                                        _,
                                                                    ) => x.clone(),
                                                                    _ => unreachable!(),
                                                                }
                                                            {
                                                                if ' ' == v1136 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1137.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v1136
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1137.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                if ' ' == v1136 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1137.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v1136
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1137.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        } else {
                                                            if ' ' == v1136 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v1137.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v1136
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v1137.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        match &v3.get().clone() {
                                            Spiral_builder::US5::US5_2(v3_2_0, v3_2_1) => {
                                                if 0_u8
                                                    == match &v3.get().clone() {
                                                        Spiral_builder::US5::US5_2(x, _) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                       LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                              LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                } else {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                       LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                              LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            }
                                            Spiral_builder::US5::US5_1(v3_1_0) => (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                        )),
                                                    )
                                                },
                                                v0_1.get().clone(),
                                            ),
                                            _ => (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
                                                        v1_1.get().clone(),
                                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                                            v0_1.get().clone(),
                                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                                        )),
                                                    )
                                                },
                                                v0_1.get().clone(),
                                            ),
                                        }
                                    }
                                } else {
                                    if let Spiral_builder::US5::US5_1(v3_1_0) = &v3.get().clone() {
                                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                                            v2.get().clone().as_ref()
                                        {
                                            let v1276: LrcPtr<Spiral_builder::UH1> =
                                                match v2.get().clone().as_ref() {
                                                    Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            let v1275: char = match v2.get().clone().as_ref() {
                                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if '\\' == v1275 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v1276.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(0_u8, v1275);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if '`' == v1275 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v1276.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(0_u8, v1275);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if '\"' == v1275 {
                                                        let v0_1_temp: string = string("");
                                                        let v1_1_temp:
                                                                         LrcPtr<Spiral_builder::UH0> =
                                                                     Spiral_builder::method16(v1_1.get().clone(),
                                                                                              LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                     LrcPtr::new(Spiral_builder::UH0::UH0_0))));
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v1276.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_0;
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if ' ' == v1275 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v1276.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v1275
                                                                ),
                                                                v1_1.get().clone(),
                                                                v1276.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
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
                                            let v1319: LrcPtr<Spiral_builder::UH1> =
                                                match v2.get().clone().as_ref() {
                                                    Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                            let v1318: char = match v2.get().clone().as_ref() {
                                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                                _ => unreachable!(),
                                            };
                                            if '\\' == v1318 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v1319.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(1_u8, v1318);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if '`' == v1318 {
                                                    let v0_1_temp: string = v0_1.get().clone();
                                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                        v1_1.get().clone();
                                                    let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                        v1319.clone();
                                                    let v3_temp: Spiral_builder::US5 =
                                                        v4.get().clone();
                                                    let v4_temp: Spiral_builder::US5 =
                                                        Spiral_builder::US5::US5_2(1_u8, v1318);
                                                    v0_1.set(v0_1_temp);
                                                    v1_1.set(v1_1_temp);
                                                    v2.set(v2_temp);
                                                    v3.set(v3_temp);
                                                    v4.set(v4_temp);
                                                    continue '_method14;
                                                } else {
                                                    if let Spiral_builder::US5::US5_2(
                                                        v3_2_0,
                                                        v3_2_1,
                                                    ) = &v3.get().clone()
                                                    {
                                                        if 0_u8
                                                            == match &v3.get().clone() {
                                                                Spiral_builder::US5::US5_2(
                                                                    x,
                                                                    _,
                                                                ) => x.clone(),
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            if '\"' == v1318 {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}",
                                                                    v0_1.get().clone()
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Spiral_builder::UH0,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v1319.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v4.get().clone();
                                                                let v4_temp: Spiral_builder::US5 =
                                                                    Spiral_builder::US5::US5_1(
                                                                        '\"',
                                                                    );
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method14;
                                                            } else {
                                                                if ' ' == v1318 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1319.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v1318
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1319.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        } else {
                                                            if '\"' == v1318 {
                                                                let v0_1_temp: string = string("");
                                                                let v1_1_temp:
                                                                                 LrcPtr<Spiral_builder::UH0> =
                                                                             Spiral_builder::method16(v1_1.get().clone(),
                                                                                                      LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                             LrcPtr::new(Spiral_builder::UH0::UH0_0))));
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v1319.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v4.get().clone();
                                                                let v4_temp: Spiral_builder::US5 =
                                                                    Spiral_builder::US5::US5_0;
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method14;
                                                            } else {
                                                                if ' ' == v1318 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1319,
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v1318
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v1319.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        if '\"' == v1318 {
                                                            let v0_1_temp: string = string("");
                                                            let v1_1_temp:
                                                                             LrcPtr<Spiral_builder::UH0> =
                                                                         Spiral_builder::method16(v1_1.get().clone(),
                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                         LrcPtr::new(Spiral_builder::UH0::UH0_0))));
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v1319.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v4.get().clone();
                                                            let v4_temp: Spiral_builder::US5 =
                                                                Spiral_builder::US5::US5_0;
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method14;
                                                        } else {
                                                            if ' ' == v1318 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v1319.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v1318
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v1319.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if let Spiral_builder::US5::US5_2(v3_2_0, v3_2_1) =
                                                &v3.get().clone()
                                            {
                                                if 0_u8
                                                    == match &v3.get().clone() {
                                                        Spiral_builder::US5::US5_2(x, _) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                } else {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        }
                                    }
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
                                continue '_method14;
                            } else {
                                if '\\' == v5 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v6.clone();
                                    let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                    let v4_temp: Spiral_builder::US5 =
                                        Spiral_builder::US5::US5_2(0_u8, v5);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method14;
                                } else {
                                    if '`' == v5 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                            v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v6.clone();
                                        let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                        let v4_temp: Spiral_builder::US5 =
                                            Spiral_builder::US5::US5_2(0_u8, v5);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        continue '_method14;
                                    } else {
                                        if ' ' == v5 {
                                            Spiral_builder::method15(
                                                string(""),
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
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
                                            Spiral_builder::method15(
                                                sprintf!("{}{}", v0_1.get().clone(), v5),
                                                v1_1.get().clone(),
                                                v6.clone(),
                                                v4.get().clone(),
                                            )
                                        }
                                    }
                                }
                            }
                        } else {
                            (
                                if v0_1.get().clone() == string("") {
                                    v1_1.get().clone()
                                } else {
                                    Spiral_builder::method16(
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
                    Spiral_builder::US5::US5_2(v4_2_0, v4_2_1) => {
                        let v53: char = match &v4.get().clone() {
                            Spiral_builder::US5::US5_2(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v52: u8 = match &v4.get().clone() {
                            Spiral_builder::US5::US5_2(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
                            v2.get().clone().as_ref()
                        {
                            let v55: LrcPtr<Spiral_builder::UH1> = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v54: char = match v2.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if '\\' == v54 {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v55.clone();
                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                let v4_temp: Spiral_builder::US5 = Spiral_builder::US5::US5_1(v54);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method14;
                            } else {
                                if '`' == v54 {
                                    let v0_1_temp: string = v0_1.get().clone();
                                    let v1_1_temp: LrcPtr<Spiral_builder::UH0> = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v55.clone();
                                    let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                    let v4_temp: Spiral_builder::US5 =
                                        Spiral_builder::US5::US5_1(v54);
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method14;
                                } else {
                                    if let Spiral_builder::US5::US5_0 = &v3.get().clone() {
                                        if '\"' == v54 {
                                            Spiral_builder::method15(
                                                v0_1.get().clone(),
                                                v1_1.get().clone(),
                                                v55.clone(),
                                                v4.get().clone(),
                                            )
                                        } else {
                                            if 0_u8 == v52 {
                                                if '\\' == v53 {
                                                    if ' ' == v54 {
                                                        Spiral_builder::method15(
                                                            sprintf!("{} ", v0_1.get().clone()),
                                                            v1_1.get().clone(),
                                                            v55.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    } else {
                                                        if 1_u8 == v52 {
                                                            if !(v3.get().clone()
                                                                == v4.get().clone())
                                                            {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}\\{}",
                                                                    v0_1.get().clone(),
                                                                    v54
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Spiral_builder::UH0,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v55.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v4.get().clone();
                                                                let v4_temp: Spiral_builder::US5 =
                                                                    v3.get().clone();
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method14;
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v54
                                                                ),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    }
                                                } else {
                                                    if '`' == v53 {
                                                        if ' ' == v54 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            if 1_u8 == v52 {
                                                                if !(v3.get().clone()
                                                                    == v4.get().clone())
                                                                {
                                                                    let v0_1_temp: string = sprintf!(
                                                                        "{}\\{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    );
                                                                    let v1_1_temp: LrcPtr<
                                                                        Spiral_builder::UH0,
                                                                    > = v1_1.get().clone();
                                                                    let v2_temp: LrcPtr<
                                                                        Spiral_builder::UH1,
                                                                    > = v55.clone();
                                                                    let v3_temp:
                                                                                     Spiral_builder::US5 =
                                                                                 v4.get().clone();
                                                                    let v4_temp:
                                                                                     Spiral_builder::US5 =
                                                                                 v3.get().clone();
                                                                    v0_1.set(v0_1_temp);
                                                                    v1_1.set(v1_1_temp);
                                                                    v2.set(v2_temp);
                                                                    v3.set(v3_temp);
                                                                    v4.set(v4_temp);
                                                                    continue '_method14;
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    } else {
                                                        if ' ' == v54 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            if 1_u8 == v52 {
                                                                if !(v3.get().clone()
                                                                    == v4.get().clone())
                                                                {
                                                                    let v0_1_temp: string = sprintf!(
                                                                        "{}\\{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    );
                                                                    let v1_1_temp: LrcPtr<
                                                                        Spiral_builder::UH0,
                                                                    > = v1_1.get().clone();
                                                                    let v2_temp: LrcPtr<
                                                                        Spiral_builder::UH1,
                                                                    > = v55.clone();
                                                                    let v3_temp:
                                                                                     Spiral_builder::US5 =
                                                                                 v4.get().clone();
                                                                    let v4_temp:
                                                                                     Spiral_builder::US5 =
                                                                                 v3.get().clone();
                                                                    v0_1.set(v0_1_temp);
                                                                    v1_1.set(v1_1_temp);
                                                                    v2.set(v2_temp);
                                                                    v3.set(v3_temp);
                                                                    v4.set(v4_temp);
                                                                    continue '_method14;
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            } else {
                                                if ' ' == v54 {
                                                    Spiral_builder::method15(
                                                        sprintf!("{} ", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v55.clone(),
                                                        v4.get().clone(),
                                                    )
                                                } else {
                                                    if 1_u8 == v52 {
                                                        if !(v3.get().clone() == v4.get().clone()) {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}\\{}",
                                                                v0_1.get().clone(),
                                                                v54
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v55.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v4.get().clone();
                                                            let v4_temp: Spiral_builder::US5 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method14;
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v54
                                                                ),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    } else {
                                                        Spiral_builder::method15(
                                                            sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v54
                                                            ),
                                                            v1_1.get().clone(),
                                                            v55.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    }
                                                }
                                            }
                                        }
                                    } else {
                                        if 0_u8 == v52 {
                                            if '\\' == v53 {
                                                if let Spiral_builder::US5::US5_1(v3_1_0) =
                                                    &v3.get().clone()
                                                {
                                                    if '\"'
                                                        == match &v3.get().clone() {
                                                            Spiral_builder::US5::US5_1(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        }
                                                    {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}{}",
                                                            v0_1.get().clone(),
                                                            v53,
                                                            v54
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v55.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_1('\"');
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if '\"' == v54 {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}\"",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v55.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v4.get().clone();
                                                            let v4_temp: Spiral_builder::US5 =
                                                                Spiral_builder::US5::US5_2(
                                                                    v52, v53,
                                                                );
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method14;
                                                        } else {
                                                            if ' ' == v54 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                if 1_u8 == v52 {
                                                                    if !(v3.get().clone()
                                                                        == v4.get().clone())
                                                                    {
                                                                        let v0_1_temp: string = sprintf!(
                                                                            "{}\\{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        );
                                                                        let v1_1_temp: LrcPtr<
                                                                            Spiral_builder::UH0,
                                                                        > = v1_1.get().clone();
                                                                        let v2_temp: LrcPtr<
                                                                            Spiral_builder::UH1,
                                                                        > = v55.clone();
                                                                        let v3_temp:
                                                                                         Spiral_builder::US5 =
                                                                                     v4.get().clone();
                                                                        let v4_temp:
                                                                                         Spiral_builder::US5 =
                                                                                     v3.get().clone();
                                                                        v0_1.set(v0_1_temp);
                                                                        v1_1.set(v1_1_temp);
                                                                        v2.set(v2_temp);
                                                                        v3.set(v3_temp);
                                                                        v4.set(v4_temp);
                                                                        continue '_method14;
                                                                    } else {
                                                                        Spiral_builder::method15(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                v0_1.get().clone(),
                                                                                v54
                                                                            ),
                                                                            v1_1.get().clone(),
                                                                            v55.clone(),
                                                                            v4.get().clone(),
                                                                        )
                                                                    }
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                } else {
                                                    if '\"' == v54 {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}\"",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v55.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_2(v52, v53);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if ' ' == v54 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            if 1_u8 == v52 {
                                                                if !(v3.get().clone()
                                                                    == v4.get().clone())
                                                                {
                                                                    let v0_1_temp: string = sprintf!(
                                                                        "{}\\{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    );
                                                                    let v1_1_temp: LrcPtr<
                                                                        Spiral_builder::UH0,
                                                                    > = v1_1.get().clone();
                                                                    let v2_temp: LrcPtr<
                                                                        Spiral_builder::UH1,
                                                                    > = v55.clone();
                                                                    let v3_temp:
                                                                                     Spiral_builder::US5 =
                                                                                 v4.get().clone();
                                                                    let v4_temp:
                                                                                     Spiral_builder::US5 =
                                                                                 v3.get().clone();
                                                                    v0_1.set(v0_1_temp);
                                                                    v1_1.set(v1_1_temp);
                                                                    v2.set(v2_temp);
                                                                    v3.set(v3_temp);
                                                                    v4.set(v4_temp);
                                                                    continue '_method14;
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            } else {
                                                if '`' == v53 {
                                                    if let Spiral_builder::US5::US5_1(v3_1_0) =
                                                        &v3.get().clone()
                                                    {
                                                        if '\"'
                                                            == match &v3.get().clone() {
                                                                Spiral_builder::US5::US5_1(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                        {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}{}",
                                                                v0_1.get().clone(),
                                                                v53,
                                                                v54
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v55.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v4.get().clone();
                                                            let v4_temp: Spiral_builder::US5 =
                                                                Spiral_builder::US5::US5_1('\"');
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method14;
                                                        } else {
                                                            if '\"' == v54 {
                                                                let v0_1_temp: string = sprintf!(
                                                                    "{}{}\"",
                                                                    v0_1.get().clone(),
                                                                    v53
                                                                );
                                                                let v1_1_temp: LrcPtr<
                                                                    Spiral_builder::UH0,
                                                                > = v1_1.get().clone();
                                                                let v2_temp: LrcPtr<
                                                                    Spiral_builder::UH1,
                                                                > = v55.clone();
                                                                let v3_temp: Spiral_builder::US5 =
                                                                    v4.get().clone();
                                                                let v4_temp: Spiral_builder::US5 =
                                                                    Spiral_builder::US5::US5_2(
                                                                        v52, v53,
                                                                    );
                                                                v0_1.set(v0_1_temp);
                                                                v1_1.set(v1_1_temp);
                                                                v2.set(v2_temp);
                                                                v3.set(v3_temp);
                                                                v4.set(v4_temp);
                                                                continue '_method14;
                                                            } else {
                                                                if ' ' == v54 {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{} ",
                                                                            v0_1.get().clone()
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                } else {
                                                                    if 1_u8 == v52 {
                                                                        if !(v3.get().clone()
                                                                            == v4.get().clone())
                                                                        {
                                                                            let v0_1_temp: string = sprintf!(
                                                                                "{}\\{}",
                                                                                v0_1.get().clone(),
                                                                                v54
                                                                            );
                                                                            let v1_1_temp: LrcPtr<
                                                                                Spiral_builder::UH0,
                                                                            > = v1_1.get().clone();
                                                                            let v2_temp: LrcPtr<
                                                                                Spiral_builder::UH1,
                                                                            > = v55.clone();
                                                                            let v3_temp:
                                                                                             Spiral_builder::US5 =
                                                                                         v4.get().clone();
                                                                            let v4_temp:
                                                                                             Spiral_builder::US5 =
                                                                                         v3.get().clone();
                                                                            v0_1.set(v0_1_temp);
                                                                            v1_1.set(v1_1_temp);
                                                                            v2.set(v2_temp);
                                                                            v3.set(v3_temp);
                                                                            v4.set(v4_temp);
                                                                            continue '_method14;
                                                                        } else {
                                                                            Spiral_builder::method15(
                                                                                sprintf!(
                                                                                    "{}{}",
                                                                                    v0_1.get()
                                                                                        .clone(),
                                                                                    v54
                                                                                ),
                                                                                v1_1.get().clone(),
                                                                                v55.clone(),
                                                                                v4.get().clone(),
                                                                            )
                                                                        }
                                                                    } else {
                                                                        Spiral_builder::method15(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                v0_1.get().clone(),
                                                                                v54
                                                                            ),
                                                                            v1_1.get().clone(),
                                                                            v55.clone(),
                                                                            v4.get().clone(),
                                                                        )
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        if '\"' == v54 {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}{}\"",
                                                                v0_1.get().clone(),
                                                                v53
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v55.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v4.get().clone();
                                                            let v4_temp: Spiral_builder::US5 =
                                                                Spiral_builder::US5::US5_2(
                                                                    v52, v53,
                                                                );
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method14;
                                                        } else {
                                                            if ' ' == v54 {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{} ",
                                                                        v0_1.get().clone()
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            } else {
                                                                if 1_u8 == v52 {
                                                                    if !(v3.get().clone()
                                                                        == v4.get().clone())
                                                                    {
                                                                        let v0_1_temp: string = sprintf!(
                                                                            "{}\\{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        );
                                                                        let v1_1_temp: LrcPtr<
                                                                            Spiral_builder::UH0,
                                                                        > = v1_1.get().clone();
                                                                        let v2_temp: LrcPtr<
                                                                            Spiral_builder::UH1,
                                                                        > = v55.clone();
                                                                        let v3_temp:
                                                                                         Spiral_builder::US5 =
                                                                                     v4.get().clone();
                                                                        let v4_temp:
                                                                                         Spiral_builder::US5 =
                                                                                     v3.get().clone();
                                                                        v0_1.set(v0_1_temp);
                                                                        v1_1.set(v1_1_temp);
                                                                        v2.set(v2_temp);
                                                                        v3.set(v3_temp);
                                                                        v4.set(v4_temp);
                                                                        continue '_method14;
                                                                    } else {
                                                                        Spiral_builder::method15(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                v0_1.get().clone(),
                                                                                v54
                                                                            ),
                                                                            v1_1.get().clone(),
                                                                            v55.clone(),
                                                                            v4.get().clone(),
                                                                        )
                                                                    }
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                } else {
                                                    if '\"' == v54 {
                                                        let v0_1_temp: string = sprintf!(
                                                            "{}{}\"",
                                                            v0_1.get().clone(),
                                                            v53
                                                        );
                                                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                            v1_1.get().clone();
                                                        let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                            v55.clone();
                                                        let v3_temp: Spiral_builder::US5 =
                                                            v4.get().clone();
                                                        let v4_temp: Spiral_builder::US5 =
                                                            Spiral_builder::US5::US5_2(v52, v53);
                                                        v0_1.set(v0_1_temp);
                                                        v1_1.set(v1_1_temp);
                                                        v2.set(v2_temp);
                                                        v3.set(v3_temp);
                                                        v4.set(v4_temp);
                                                        continue '_method14;
                                                    } else {
                                                        if ' ' == v54 {
                                                            Spiral_builder::method15(
                                                                sprintf!("{} ", v0_1.get().clone()),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        } else {
                                                            if 1_u8 == v52 {
                                                                if !(v3.get().clone()
                                                                    == v4.get().clone())
                                                                {
                                                                    let v0_1_temp: string = sprintf!(
                                                                        "{}\\{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    );
                                                                    let v1_1_temp: LrcPtr<
                                                                        Spiral_builder::UH0,
                                                                    > = v1_1.get().clone();
                                                                    let v2_temp: LrcPtr<
                                                                        Spiral_builder::UH1,
                                                                    > = v55.clone();
                                                                    let v3_temp:
                                                                                     Spiral_builder::US5 =
                                                                                 v4.get().clone();
                                                                    let v4_temp:
                                                                                     Spiral_builder::US5 =
                                                                                 v3.get().clone();
                                                                    v0_1.set(v0_1_temp);
                                                                    v1_1.set(v1_1_temp);
                                                                    v2.set(v2_temp);
                                                                    v3.set(v3_temp);
                                                                    v4.set(v4_temp);
                                                                    continue '_method14;
                                                                } else {
                                                                    Spiral_builder::method15(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            v0_1.get().clone(),
                                                                            v54
                                                                        ),
                                                                        v1_1.get().clone(),
                                                                        v55.clone(),
                                                                        v4.get().clone(),
                                                                    )
                                                                }
                                                            } else {
                                                                Spiral_builder::method15(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        v0_1.get().clone(),
                                                                        v54
                                                                    ),
                                                                    v1_1.get().clone(),
                                                                    v55.clone(),
                                                                    v4.get().clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if '\"' == v54 {
                                                let v0_1_temp: string =
                                                    sprintf!("{}{}\"", v0_1.get().clone(), v53);
                                                let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v55.clone();
                                                let v3_temp: Spiral_builder::US5 = v4.get().clone();
                                                let v4_temp: Spiral_builder::US5 =
                                                    Spiral_builder::US5::US5_2(v52, v53);
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                v4.set(v4_temp);
                                                continue '_method14;
                                            } else {
                                                if ' ' == v54 {
                                                    Spiral_builder::method15(
                                                        sprintf!("{} ", v0_1.get().clone()),
                                                        v1_1.get().clone(),
                                                        v55.clone(),
                                                        v4.get().clone(),
                                                    )
                                                } else {
                                                    if 1_u8 == v52 {
                                                        if !(v3.get().clone() == v4.get().clone()) {
                                                            let v0_1_temp: string = sprintf!(
                                                                "{}\\{}",
                                                                v0_1.get().clone(),
                                                                v54
                                                            );
                                                            let v1_1_temp: LrcPtr<
                                                                Spiral_builder::UH0,
                                                            > = v1_1.get().clone();
                                                            let v2_temp: LrcPtr<
                                                                Spiral_builder::UH1,
                                                            > = v55.clone();
                                                            let v3_temp: Spiral_builder::US5 =
                                                                v4.get().clone();
                                                            let v4_temp: Spiral_builder::US5 =
                                                                v3.get().clone();
                                                            v0_1.set(v0_1_temp);
                                                            v1_1.set(v1_1_temp);
                                                            v2.set(v2_temp);
                                                            v3.set(v3_temp);
                                                            v4.set(v4_temp);
                                                            continue '_method14;
                                                        } else {
                                                            Spiral_builder::method15(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    v0_1.get().clone(),
                                                                    v54
                                                                ),
                                                                v1_1.get().clone(),
                                                                v55.clone(),
                                                                v4.get().clone(),
                                                            )
                                                        }
                                                    } else {
                                                        Spiral_builder::method15(
                                                            sprintf!(
                                                                "{}{}",
                                                                v0_1.get().clone(),
                                                                v54
                                                            ),
                                                            v1_1.get().clone(),
                                                            v55.clone(),
                                                            v4.get().clone(),
                                                        )
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } else {
                            if let Spiral_builder::US5::US5_0 = &v3.get().clone() {
                                if 0_u8 == v52 {
                                    if '\\' == v53 {
                                        if 1_u8 == v52 {
                                            (
                                                if v0_1.get().clone() == string("") {
                                                    v1_1.get().clone()
                                                } else {
                                                    Spiral_builder::method16(
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
                                                    Spiral_builder::method16(
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
                                        if '`' == v53 {
                                            if 1_u8 == v52 {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        } else {
                                            if 1_u8 == v52 {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                } else {
                                    if 1_u8 == v52 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
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
                                                Spiral_builder::method16(
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
                                if 0_u8 == v52 {
                                    if '\\' == v53 {
                                        if let Spiral_builder::US5::US5_1(v3_1_0) =
                                            &v3.get().clone()
                                        {
                                            if '\"'
                                                == match &v3.get().clone() {
                                                    Spiral_builder::US5::US5_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                            {
                                                if 1_u8 == v52 {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                } else {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            } else {
                                                if 1_u8 == v52 {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                } else {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            }
                                        } else {
                                            if 1_u8 == v52 {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        }
                                    } else {
                                        if '`' == v53 {
                                            if let Spiral_builder::US5::US5_1(v3_1_0) =
                                                &v3.get().clone()
                                            {
                                                if '\"'
                                                    == match &v3.get().clone() {
                                                        Spiral_builder::US5::US5_1(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                {
                                                    if 1_u8 == v52 {
                                                        (
                                                            if v0_1.get().clone() == string("") {
                                                                v1_1.get().clone()
                                                            } else {
                                                                Spiral_builder::method16(v1_1.get().clone(),
                                                                                               LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                      LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                            },
                                                            v0_1.get().clone(),
                                                        )
                                                    } else {
                                                        (
                                                            if v0_1.get().clone() == string("") {
                                                                v1_1.get().clone()
                                                            } else {
                                                                Spiral_builder::method16(v1_1.get().clone(),
                                                                                               LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                      LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                            },
                                                            v0_1.get().clone(),
                                                        )
                                                    }
                                                } else {
                                                    if 1_u8 == v52 {
                                                        (
                                                            if v0_1.get().clone() == string("") {
                                                                v1_1.get().clone()
                                                            } else {
                                                                Spiral_builder::method16(v1_1.get().clone(),
                                                                                               LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                      LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                            },
                                                            v0_1.get().clone(),
                                                        )
                                                    } else {
                                                        (
                                                            if v0_1.get().clone() == string("") {
                                                                v1_1.get().clone()
                                                            } else {
                                                                Spiral_builder::method16(v1_1.get().clone(),
                                                                                               LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                      LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                            },
                                                            v0_1.get().clone(),
                                                        )
                                                    }
                                                }
                                            } else {
                                                if 1_u8 == v52 {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                } else {
                                                    (
                                                        if v0_1.get().clone() == string("") {
                                                            v1_1.get().clone()
                                                        } else {
                                                            Spiral_builder::method16(v1_1.get().clone(),
                                                                                           LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1.get().clone(),
                                                                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0))))
                                                        },
                                                        v0_1.get().clone(),
                                                    )
                                                }
                                            }
                                        } else {
                                            if 1_u8 == v52 {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            } else {
                                                (
                                                    if v0_1.get().clone() == string("") {
                                                        v1_1.get().clone()
                                                    } else {
                                                        Spiral_builder::method16(
                                                            v1_1.get().clone(),
                                                            LrcPtr::new(
                                                                Spiral_builder::UH0::UH0_1(
                                                                    v0_1.get().clone(),
                                                                    LrcPtr::new(
                                                                        Spiral_builder::UH0::UH0_0,
                                                                    ),
                                                                ),
                                                            ),
                                                        )
                                                    },
                                                    v0_1.get().clone(),
                                                )
                                            }
                                        }
                                    }
                                } else {
                                    if 1_u8 == v52 {
                                        (
                                            if v0_1.get().clone() == string("") {
                                                v1_1.get().clone()
                                            } else {
                                                Spiral_builder::method16(
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
                                                Spiral_builder::method16(
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
                    }
                });
            }
        }
        pub fn method17(v0_1: LrcPtr<Spiral_builder::UH0>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Spiral_builder::UH0::UH0_0 => v1_1.clone(),
                Spiral_builder::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Spiral_builder::method17(
                        match v0_1.as_ref() {
                            Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method11(v0_1: string) -> Array<string> {
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
                    let v17: LrcPtr<Spiral_builder::Mut4> = LrcPtr::new(Spiral_builder::Mut4 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method12(v15, v17.clone()) {
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
                        toArray(Spiral_builder::method17(
                            (Spiral_builder::method14(
                                string(""),
                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                        (Spiral_builder::method13())(b0)(b1)
                                    }),
                                    v23,
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
        }
        pub fn method18(v0_1: string) -> string {
            v0_1
        }
        pub fn closure11(unitVar: (), v0_1: serde_json::Error) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            getValue(_v1.get().clone())
        }
        pub fn method19() -> Func1<serde_json::Error, std::string::String> {
            Func1::new(move |v: serde_json::Error| Spiral_builder::closure11((), v))
        }
        pub fn method20(v0_1: std::string::String) -> std::string::String {
            v0_1
        }
        pub fn method21(v0_1: string) -> string {
            v0_1
        }
        pub fn method23(v0_1: string) -> string {
            v0_1
        }
        pub fn method24(v0_1: string) -> string {
            v0_1
        }
        pub fn method22(v0_1: string, v1_1: string) -> string {
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
        pub fn method25(v0_1: string) -> string {
            v0_1
        }
        pub fn method26() -> string {
            string("")
        }
        pub fn method27() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method28() -> string {
            string("")
        }
        pub fn method29(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method30(v0_1: string) -> string {
            v0_1
        }
        pub fn method31(v0_1: string) -> string {
            v0_1
        }
        pub fn method32() -> string {
            string("\n")
        }
        pub fn method33() -> string {
            string("deps")
        }
        pub fn method35(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: string = Spiral_builder::method21(v0_1);
            let v4: &str = &*v2.clone();
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            {
                let x_6: string = if v8.exists() == false {
                    let _v12: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v14: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
                    let v16: std::path::PathBuf = v14.unwrap();
                    let v18: std::path::Display = v16.display();
                    let _v19: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v18);
                        _v19.set(Some(x))
                    }
                    {
                        let v29: std::string::String = getValue(_v19.get().clone());
                        {
                            let x_1: string = fable_library_rust::String_::fromString(v29);
                            _v12.set(Some(x_1))
                        }
                        {
                            let v38: string = getValue(_v12.get().clone());
                            let _v40: MutCell<Option<string>> = MutCell::new(None::<string>);
                            let v41: string = Spiral_builder::method25(Spiral_builder::method22(
                                v38.clone(),
                                v2.clone(),
                            ));
                            let v42: string = Spiral_builder::method26();
                            let _v43: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                                MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                            let v44: string = Spiral_builder::method27();
                            {
                                let x_2: Result<regex::Regex, regex::Error> =
                                    regex::Regex::new(&v44);
                                _v43.set(Some(x_2))
                            }
                            {
                                let v52: Result<regex::Regex, regex::Error> =
                                    getValue(_v43.get().clone());
                                let v54: regex::Regex = v52.unwrap();
                                let v56: std::borrow::Cow<str> = v54.replace_all(&v41, &*v42);
                                let v58: std::string::String = String::from(v56);
                                {
                                    let x_3: string = fable_library_rust::String_::fromString(v58);
                                    _v40.set(Some(x_3))
                                }
                                {
                                    let v68: string = getValue(_v40.get().clone());
                                    let v73: Array<string> = split(
                                        replace(
                                            sprintf!(
                                                "{}{}",
                                                toLower(ofChar(getCharAt(v68.clone(), 0_i32))),
                                                getSlice(v68, Some(1_i32), None::<i32>)
                                            ),
                                            string("\\"),
                                            string("/"),
                                        ),
                                        string("/"),
                                        -1_i32,
                                        0_i32,
                                    );
                                    let v75: i32 = count(v73.clone());
                                    let v76: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                            l1: MutCell::new(0_i32),
                                            l2: MutCell::new(new_empty::<string>()),
                                        });
                                    while Spiral_builder::method29(v75, v76.clone()) {
                                        let v78: i32 = v76.l0.get().clone();
                                        let v81: i32 = v78.wrapping_neg() + v75 - 1_i32;
                                        let matchValue: i32 = v76.l1.get().clone();
                                        let v83: Array<string> = v76.l2.get().clone();
                                        let v82: i32 = matchValue;
                                        let v84: string = v73[v81].clone();
                                        let patternInput_1: (i32, Array<string>) = if string("..")
                                            == v84.clone()
                                        {
                                            (v82 + 1_i32, v83.clone())
                                        } else {
                                            if string(".") == v84.clone() {
                                                (v82, v83.clone())
                                            } else {
                                                if 0_i32 == v82 {
                                                    if endsWith(v84.clone(), string(":"), false) {
                                                        let v92: Array<string> =
                                                            new_array(&[sprintf!(
                                                                "{}:",
                                                                getCharAt(v38.clone(), 0_i32)
                                                            )]);
                                                        let v93: i32 = count(v92.clone());
                                                        let v95: i32 = v93 + count(v83.clone());
                                                        let v96: Array<string> =
                                                            new_init(&string(""), v95);
                                                        let v97: LrcPtr<Spiral_builder::Mut4> =
                                                            LrcPtr::new(Spiral_builder::Mut4 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Spiral_builder::method12(
                                                            v95,
                                                            v97.clone(),
                                                        ) {
                                                            let v99: i32 = v97.l0.get().clone();
                                                            let v104: string = if v99 < v93 {
                                                                v92[v99].clone()
                                                            } else {
                                                                let v102: i32 = v99 - v93;
                                                                v83[v102].clone()
                                                            };
                                                            v96.get_mut()[v99 as usize] = v104;
                                                            {
                                                                let v105: i32 = v99 + 1_i32;
                                                                v97.l0.set(v105);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v96.clone())
                                                    } else {
                                                        let v106: Array<string> = new_array(&[v84]);
                                                        let v107: i32 = count(v106.clone());
                                                        let v109: i32 = v107 + count(v83.clone());
                                                        let v110: Array<string> =
                                                            new_init(&string(""), v109);
                                                        let v111: LrcPtr<Spiral_builder::Mut4> =
                                                            LrcPtr::new(Spiral_builder::Mut4 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Spiral_builder::method12(
                                                            v109,
                                                            v111.clone(),
                                                        ) {
                                                            let v113: i32 = v111.l0.get().clone();
                                                            let v118: string = if v113 < v107 {
                                                                v106[v113].clone()
                                                            } else {
                                                                let v116: i32 = v113 - v107;
                                                                v83[v116].clone()
                                                            };
                                                            v110.get_mut()[v113 as usize] = v118;
                                                            {
                                                                let v119: i32 = v113 + 1_i32;
                                                                v111.l0.set(v119);
                                                                ()
                                                            }
                                                        }
                                                        (0_i32, v110.clone())
                                                    }
                                                } else {
                                                    (v82 - 1_i32, v83.clone())
                                                }
                                            }
                                        };
                                        let v129: i32 = v78 + 1_i32;
                                        v76.l0.set(v129);
                                        v76.l1.set(patternInput_1.0.clone());
                                        v76.l2.set(patternInput_1.1.clone());
                                        ()
                                    }
                                    {
                                        let matchValue_2: i32 = v76.l1.get().clone();
                                        let v131: Array<string> = v76.l2.get().clone();
                                        let v132: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v131 = v131.clone();
                                                move || {
                                                    map(
                                                        Func1::new({
                                                            let v131 = v131.clone();
                                                            move |i: i32| v131[i].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            count(v131.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let _v133: MutCell<Option<char>> =
                                            MutCell::new(None::<char>);
                                        {
                                            let x_4: char = std::path::MAIN_SEPARATOR;
                                            _v133.set(Some(x_4))
                                        }
                                        join(
                                            Spiral_builder::method30(ofChar(getValue(
                                                _v133.get().clone(),
                                            ))),
                                            toArray_1(v132),
                                        )
                                    }
                                }
                            }
                        }
                    }
                } else {
                    let v149: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v2);
                    let v151: std::path::PathBuf = v149.unwrap();
                    let v153: std::path::Display = v151.display();
                    let _v154: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_5: std::string::String = format!("{}", v153);
                        _v154.set(Some(x_5))
                    }
                    {
                        let v164: std::string::String = getValue(_v154.get().clone());
                        fable_library_rust::String_::fromString(v164)
                    }
                };
                _v1.set(Some(x_6))
            }
            {
                let _v176: MutCell<Option<string>> = MutCell::new(None::<string>);
                let v177: string = Spiral_builder::method25(getValue(_v1.get().clone()));
                let v178: string = Spiral_builder::method26();
                let _v179: MutCell<Option<Result<regex::Regex, regex::Error>>> =
                    MutCell::new(None::<Result<regex::Regex, regex::Error>>);
                let v180: string = Spiral_builder::method27();
                {
                    let x_7: Result<regex::Regex, regex::Error> = regex::Regex::new(&v180);
                    _v179.set(Some(x_7))
                }
                {
                    let v188: Result<regex::Regex, regex::Error> = getValue(_v179.get().clone());
                    let v190: regex::Regex = v188.unwrap();
                    let v192: std::borrow::Cow<str> = v190.replace_all(&v177, &*v178);
                    let v194: std::string::String = String::from(v192);
                    {
                        let x_8: string = fable_library_rust::String_::fromString(v194);
                        _v176.set(Some(x_8))
                    }
                    {
                        let v204: string = getValue(_v176.get().clone());
                        replace(
                            sprintf!(
                                "{}{}",
                                toLower(ofChar(getCharAt(v204.clone(), 0_i32))),
                                getSlice(v204, Some(1_i32), None::<i32>)
                            ),
                            string("\\"),
                            string("/"),
                        )
                    }
                }
            }
        }
        pub fn method34(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v5: std::path::PathBuf = v3.unwrap();
            let v7: std::path::Display = v5.display();
            let _v8: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v7);
                _v8.set(Some(x))
            }
            {
                let v18: std::string::String = getValue(_v8.get().clone());
                {
                    let x_1: string = fable_library_rust::String_::fromString(v18);
                    _v1.set(Some(x_1))
                }
                Spiral_builder::method35(Spiral_builder::method22(
                    getValue(_v1.get().clone()),
                    v0_1,
                ))
            }
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> string {
            Spiral_builder::method34(fable_library_rust::String_::fromString(v0_1))
        }
        pub fn method36() -> string {
            string("retries")
        }
        pub fn method37() -> string {
            string("working_directory")
        }
        pub fn method40(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> string {
            v1_1
        }
        pub fn method41() -> (string, string) {
            (string(""), string(""))
        }
        pub fn method42(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Spiral_builder::UH1>,
            v3: Spiral_builder::US7,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US7> = MutCell::new(v3.clone());
            '_method42: loop {
                break '_method42 (if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
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
                        if v1_1.get().clone() == string("") {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                            let v3_temp: Spiral_builder::US7 =
                                Spiral_builder::US7::US7_1(Spiral_builder::US8::US8_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method42;
                        } else {
                            match &v3.get().clone() {
                                Spiral_builder::US7::US7_1(v3_1_0) => {
                                    if let Spiral_builder::US8::US8_0 = v3_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US7 =
                                            Spiral_builder::US7::US7_1(Spiral_builder::US8::US8_1);
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method42;
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 =
                                                Spiral_builder::US7::US7_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        }
                                    }
                                }
                                Spiral_builder::US7::US7_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US7 =
                                            Spiral_builder::US7::US7_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method42;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US7 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method42;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                    let v3_temp: Spiral_builder::US7 = Spiral_builder::US7::US7_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method42;
                                }
                            }
                        }
                    } else {
                        if '\'' == v4 {
                            if v1_1.get().clone() == string("") {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                let v3_temp: Spiral_builder::US7 =
                                    Spiral_builder::US7::US7_1(Spiral_builder::US8::US8_0);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                continue '_method42;
                            } else {
                                match &v3.get().clone() {
                                    Spiral_builder::US7::US7_1(v3_1_0) => {
                                        if let Spiral_builder::US8::US8_0 = v3_1_0 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 =
                                                Spiral_builder::US7::US7_1(
                                                    Spiral_builder::US8::US8_1,
                                                );
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        } else {
                                            if ' ' == v4 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string = v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v5.clone();
                                                let v3_temp: Spiral_builder::US7 =
                                                    Spiral_builder::US7::US7_2;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method42;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string =
                                                    sprintf!("{}{}", v1_1.get().clone(), v4);
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v5.clone();
                                                let v3_temp: Spiral_builder::US7 = v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method42;
                                            }
                                        }
                                    }
                                    Spiral_builder::US7::US7_0 => {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 =
                                                Spiral_builder::US7::US7_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        }
                                    }
                                    _ => {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US7 =
                                            Spiral_builder::US7::US7_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method42;
                                    }
                                }
                            }
                        } else {
                            match &v3.get().clone() {
                                Spiral_builder::US7::US7_1(v3_1_0) => {
                                    if let Spiral_builder::US8::US8_0 = v3_1_0 {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{} ", v1_1.get().clone());
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 =
                                                Spiral_builder::US7::US7_1(
                                                    Spiral_builder::US8::US8_0,
                                                );
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        }
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 =
                                                Spiral_builder::US7::US7_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US7 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method42;
                                        }
                                    }
                                }
                                Spiral_builder::US7::US7_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US7 =
                                            Spiral_builder::US7::US7_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method42;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5;
                                        let v3_temp: Spiral_builder::US7 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method42;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                    let v3_temp: Spiral_builder::US7 = Spiral_builder::US7::US7_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method42;
                                }
                            }
                        }
                    }
                } else {
                    match &v3.get().clone() {
                        Spiral_builder::US7::US7_1(v3_1_0) => {
                            if let Spiral_builder::US8::US8_0 = v3_1_0 {
                                (
                                    replace(v1_1.get().clone(), string("\\"), string("/")),
                                    v0_1.get().clone(),
                                )
                            } else {
                                (
                                    replace(v1_1.get().clone(), string("\\"), string("/")),
                                    v0_1.get().clone(),
                                )
                            }
                        }
                        Spiral_builder::US7::US7_0 => (
                            replace(v1_1.get().clone(), string("\\"), string("/")),
                            v0_1.get().clone(),
                        ),
                        _ => (
                            replace(v1_1.get().clone(), string("\\"), string("/")),
                            v0_1.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure13(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options")
        }
        pub fn closure14(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "file_name: {} / arguments: {:?} / options: {:?} / {}",
                v7,
                v8,
                (v0_1, v1_1, v2, v3, v4, v5, v6),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure15(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            getValue(_v1.get().clone())
        }
        pub fn method43() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Spiral_builder::closure15((), v))
        }
        pub fn closure16(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Spiral_builder::US9 {
            Spiral_builder::US9::US9_0(v0_1)
        }
        pub fn method44(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Spiral_builder::US9>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Spiral_builder::closure16((), v)
                },
            )
        }
        pub fn closure17(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US9 {
            Spiral_builder::US9::US9_1(v0_1)
        }
        pub fn method45() -> Func1<std::string::String, Spiral_builder::US9> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure17((), v))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure19(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn closure20(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US11 {
            Spiral_builder::US11::US11_0(v0_1)
        }
        pub fn method46() -> Func1<std::string::String, Spiral_builder::US11> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure20((), v))
        }
        pub fn closure21(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US11 {
            Spiral_builder::US11::US11_1(v0_1)
        }
        pub fn method47() -> Func1<std::string::String, Spiral_builder::US11> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure21((), v))
        }
        pub fn closure22(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.stdio_line")
        }
        pub fn closure23(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("e: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn closure24(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure25(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            getValue(_v1.get().clone())
        }
        pub fn method48(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Spiral_builder::closure25((), v)
            })
        }
        pub fn method49(v0_1: Result<(), std::string::String>) -> Result<(), std::string::String> {
            v0_1
        }
        pub fn method50(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method51(
            v0_1: std::thread::JoinHandle<Result<(), std::string::String>>,
        ) -> std::thread::JoinHandle<Result<(), std::string::String>> {
            v0_1
        }
        pub fn closure26(unitVar: (), v0_1: std::process::Output) -> Spiral_builder::US14 {
            Spiral_builder::US14::US14_0(v0_1)
        }
        pub fn closure27(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US14 {
            Spiral_builder::US14::US14_1(v0_1)
        }
        pub fn closure28(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / output error")
        }
        pub fn closure29(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn closure30(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / result")
        }
        pub fn closure31(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / std_trace.Length: {} / {}",
                v0_1,
                length(v1_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method52(v0_: i32, v0__1: string) -> LrcPtr<(i32, string)> {
            LrcPtr::new((v0_, v0__1))
        }
        pub fn closure32(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "execute_with_options_async / options: {:?}",
                (v0_1, v1_1, v2, v3, v4, v5, v6)
            )
        }
        pub fn method54() -> Func0<string> {
            Func0::new(move || Spiral_builder::closure6((), ()))
        }
        pub fn closure34(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure33(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: (),
        ) {
            let _v10: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v10.set(Some(x))
            }
            {
                let v38: Arc<Async<()>> = getValue(_v10.get().clone());
                let _v39: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v39.set(Some(()));
                getValue(_v39.get().clone());
                ()
            }
        }
        pub fn closure35(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: (),
        ) {
            let _v10: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
            {
                let x: Arc<Async<()>> = defaultOf();
                _v10.set(Some(x))
            }
            {
                let v39: Arc<Async<()>> = getValue(_v10.get().clone());
                let _v40: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v40.set(Some(()));
                getValue(_v40.get().clone());
                ()
            }
        }
        pub fn closure36(v0_1: (), unitVar: ()) {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x: bool = unbox::<bool>(&defaultOf());
                _v1.set(Some(x))
            }
            if getValue(_v1.get().clone()) == false {
                let _v10: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v10.set(Some(()));
                getValue(_v10.get().clone());
                ()
            }
        }
        pub fn closure37(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn closure38(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method53(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            let _v7: MutCell<Option<Arc<Async<(i32, string)>>>> =
                MutCell::new(None::<Arc<Async<(i32, string)>>>);
            {
                let x: Arc<Async<(i32, string)>> = defaultOf();
                _v7.set(Some(x))
            }
            getValue(_v7.get().clone())
        }
        pub fn method39(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let _v7: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
            let v8: string = Spiral_builder::method40(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            );
            let patternInput: (string, string) = Spiral_builder::method41();
            let v11: i32 = length(v8.clone());
            let v12: Array<char> = new_init(&'\u{0000}', v11);
            let v13: LrcPtr<Spiral_builder::Mut4> = LrcPtr::new(Spiral_builder::Mut4 {
                l0: MutCell::new(0_i32),
            });
            while Spiral_builder::method12(v11, v13.clone()) {
                let v15: i32 = v13.l0.get().clone();
                let v16: char = getCharAt(v8.clone(), v15);
                v12.get_mut()[v15 as usize] = v16;
                {
                    let v17: i32 = v15 + 1_i32;
                    v13.l0.set(v17);
                    ()
                }
            }
            {
                let v19: List<char> = ofArray(v12.clone());
                let patternInput_1: (string, string) = Spiral_builder::method42(
                    patternInput.1.clone(),
                    patternInput.0.clone(),
                    foldBack(
                        Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                            (Spiral_builder::method13())(b0)(b1)
                        }),
                        v19,
                        LrcPtr::new(Spiral_builder::UH1::UH1_0),
                    ),
                    Spiral_builder::US7::US7_0,
                );
                let v27: string = patternInput_1.0.clone();
                let v29: Array<string> = Spiral_builder::method11(patternInput_1.1.clone());
                let v31: Vec<string> = v29.to_vec();
                let v33: bool = true;
                let _result = v31
                    .into_iter()
                    .map(|x| {
                        //;
                        let v35: string = x;
                        let v37: &str = &*v35;
                        let v39: std::string::String = String::from(v37);
                        let v41: bool = true;
                        v39
                    })
                    .collect::<Vec<_>>();
                let v43: Vec<std::string::String> = _result;
                Spiral_builder::method4(
                    Spiral_builder::US0::US0_1,
                    Func0::new(move || Spiral_builder::closure13((), ())),
                    Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v27 = v27.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        let v43 = v43.clone();
                        let v5 = v5.clone();
                        let v6 = v6.clone();
                        move || {
                            Spiral_builder::closure14(
                                v0_1.clone(),
                                v1_1.clone(),
                                v2.clone(),
                                v3.clone(),
                                v4.clone(),
                                v5,
                                v6.clone(),
                                v27.clone(),
                                v43.clone(),
                                (),
                            )
                        }
                    }),
                );
                let __result = Box::pin(async move {
                    //;
                    {
                        let _v48: MutCell<Option<LrcPtr<(i32, string)>>> =
                            MutCell::new(None::<LrcPtr<(i32, string)>>);
                        {
                            let x_12: LrcPtr<(i32, string)> = (Func0::new({
                                let v2 = v2.clone();
                                let v27 = v27.clone();
                                let v4 = v4.clone();
                                let v43 = v43.clone();
                                let v5 = v5.clone();
                                let v6 = v6.clone();
                                move || {
                                    let v50: std::process::Command =
                                        std::process::Command::new(&*v27.clone());
                                    let v52: bool = true;
                                    let mut v50 = v50;
                                    let v54: &mut std::process::Command =
                                        std::process::Command::args(&mut v50, &*v43.clone());
                                    let v56: std::process::Stdio = std::process::Stdio::piped();
                                    let v58: &mut std::process::Command =
                                        std::process::Command::stdout(
                                            v54,
                                            std::process::Stdio::piped(),
                                        );
                                    let v60: std::process::Stdio = std::process::Stdio::piped();
                                    let v62: &mut std::process::Command =
                                        std::process::Command::stderr(
                                            v58,
                                            std::process::Stdio::piped(),
                                        );
                                    let v64: std::process::Stdio = std::process::Stdio::piped();
                                    let v66: &mut std::process::Command =
                                        std::process::Command::stdin(
                                            v62,
                                            std::process::Stdio::piped(),
                                        );
                                    let _v67: LrcPtr<MutCell<Option<Spiral_builder::US3>>> =
                                        refCell(None::<Spiral_builder::US3>);
                                    {
                                        let x_2: Option<Spiral_builder::US3> = match &v6 {
                                            None => None::<Spiral_builder::US3>,
                                            Some(v6_0_0) => {
                                                let x: string = v6_0_0.clone();
                                                Some((Func0::new({
                                                    let x = x.clone();
                                                    move || Spiral_builder::US3::US3_0(x.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v67.set(x_2)
                                    }
                                    {
                                        let v72: Spiral_builder::US3 = defaultValue(
                                            Spiral_builder::US3::US3_1,
                                            _v67.get().clone(),
                                        );
                                        let v77: &mut std::process::Command = match &v72 {
                                            Spiral_builder::US3::US3_0(v72_0_0) => {
                                                std::process::Command::current_dir(
                                                    v66,
                                                    &*match &v72 {
                                                        Spiral_builder::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                )
                                            }
                                            _ => v66,
                                        };
                                        let v95: &mut std::process::Command = if count(v2.clone())
                                            as u64
                                            == 0_u64
                                        {
                                            v77
                                        } else {
                                            let v81: Vec<(string, string)> = v2.clone().to_vec();
                                            let v83: bool = true;
                                            let _result = v81.into_iter().fold(v77, |acc, x| {
                                                //;
                                                let v85: &mut std::process::Command = acc;
                                                let patternInput_2: (string, string) = x;
                                                let v90: &mut std::process::Command =
                                                    std::process::Command::env(
                                                        v85,
                                                        &*patternInput_2.0.clone(),
                                                        &*patternInput_2.1.clone(),
                                                    );
                                                let v92: bool = true;
                                                v90
                                            });
                                            _result
                                        };
                                        let v97: Result<std::process::Child, std::io::Error> =
                                            std::process::Command::spawn(v95);
                                        let v98 = Spiral_builder::method43();
                                        let v100: Result<std::process::Child, std::string::String> =
                                            v97.map_err(|x| v98(x));
                                        let v102: bool = true;
                                        let _result = v100.map(|x| {
                                            //;
                                            let v104: std::process::Child = x;
                                            let v107: std::sync::Mutex<
                                                Option<std::process::Child>,
                                            > = std::sync::Mutex::new(Some(v104));
                                            let v109: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = std::sync::Arc::new(v107);
                                            let v111: bool = true;
                                            v109
                                        });
                                        let v113: Result<
                                            std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            >,
                                            std::string::String,
                                        > = _result;
                                        let v114 = Spiral_builder::method44();
                                        let v115 = Spiral_builder::method45();
                                        let v117: Spiral_builder::US9 = match v113 {
                                            Ok(x) => v114(x),
                                            Err(e) => v115(e),
                                        };
                                        let patternInput_4: (
                                            i32,
                                            Spiral_builder::US2,
                                            Spiral_builder::US10,
                                        ) = match &v117 {
                                            Spiral_builder::US9::US9_0(v117_0_0) => {
                                                let v118: std::sync::Arc<
                                                    std::sync::Mutex<Option<std::process::Child>>,
                                                > = v117_0_0.clone();
                                                let v120: std::process::ChildStdout = v118
                                                    .clone()
                                                    .lock()
                                                    .unwrap()
                                                    .as_mut()
                                                    .unwrap()
                                                    .stdout
                                                    .take()
                                                    .unwrap();
                                                let v122: std::process::ChildStderr = v118
                                                    .clone()
                                                    .lock()
                                                    .unwrap()
                                                    .as_mut()
                                                    .unwrap()
                                                    .stderr
                                                    .take()
                                                    .unwrap();
                                                let v124: std::process::ChildStdin = v118
                                                    .clone()
                                                    .lock()
                                                    .unwrap()
                                                    .as_mut()
                                                    .unwrap()
                                                    .stdin
                                                    .take()
                                                    .unwrap();
                                                let v126: std::sync::Mutex<
                                                    std::process::ChildStdout,
                                                > = std::sync::Mutex::new(v120);
                                                let v128: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdout>,
                                                > = std::sync::Arc::new(v126);
                                                let v130: std::sync::Mutex<
                                                    std::process::ChildStderr,
                                                > = std::sync::Mutex::new(v122);
                                                let v132: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStderr>,
                                                > = std::sync::Arc::new(v130);
                                                let v135: std::sync::Mutex<
                                                    Option<std::process::ChildStdin>,
                                                > = std::sync::Mutex::new(Some(v124));
                                                let v137: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        Option<std::process::ChildStdin>,
                                                    >,
                                                > = std::sync::Arc::new(v135);
                                                let patternInput_3: (
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                ) = {
                                                    let (sender, receiver) =
                                                        std::sync::mpsc::channel();
                                                    (sender, std::sync::Arc::new(receiver))
                                                };
                                                let v139: std::sync::mpsc::Sender<
                                                    std::string::String,
                                                > = patternInput_3.0.clone();
                                                let v142: std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                > = std::sync::Mutex::new(v139.clone());
                                                let v144: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                > = std::sync::Arc::new(v142);
                                                let v146: std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                > = std::sync::Mutex::new(v139);
                                                let v148: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                > = std::sync::Arc::new(v146);
                                                let v150: std::sync::Mutex<
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                > = std::sync::Mutex::new(patternInput_3.1.clone());
                                                let v152: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        std::sync::Arc<
                                                            std::sync::mpsc::Receiver<
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    >,
                                                > = std::sync::Arc::new(v150);
                                                let v154: bool = true;
                                                let __result = std::thread::spawn(move || {
                                                    //;
                                                    let v156: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdout,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdout,
                                                            >,
                                                        >,
                                                    > = v128.lock();
                                                    let v158: std::sync::MutexGuard<
                                                        std::process::ChildStdout,
                                                    > = v156.unwrap();
                                                    let v160: bool = true;
                                                    let mut v158 = v158;
                                                    let v162: &mut std::process::ChildStdout =
                                                        &mut v158;
                                                    let v164:
                                                                            encoding_rs_io::DecodeReaderBytes<&mut std::process::ChildStdout, Vec<u8>> =
                                                                        encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(v162);
                                                    let v166: std::io::BufReader<
                                                        encoding_rs_io::DecodeReaderBytes<
                                                            &mut std::process::ChildStdout,
                                                            Vec<u8>,
                                                        >,
                                                    > = std::io::BufReader::new(v164);
                                                    let v168: std::io::Lines<
                                                        std::io::BufReader<
                                                            encoding_rs_io::DecodeReaderBytes<
                                                                &mut std::process::ChildStdout,
                                                                Vec<u8>,
                                                            >,
                                                        >,
                                                    > = std::io::BufRead::lines(v166);
                                                    let v170: bool = true;
                                                    let mut v168 = v168;
                                                    let _result = v168.try_for_each(|x| { //;
                                                                    let v172:
                                                                            Result<std::string::String,
                                                                                   std::io::Error> =
                                                                        x;
                                                                    let v174:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        v144.clone();
                                                                    let v175 =
                                                                        Spiral_builder::method43();
                                                                    let v177:
                                                                            Result<std::string::String,
                                                                                   std::string::String> =
                                                                        v172.map_err(|x| v175(x));
                                                                    let v178 =
                                                                        Spiral_builder::method46();
                                                                    let v179 =
                                                                        Spiral_builder::method47();
                                                                    let v181:
                                                                            Spiral_builder::US11 =
                                                                        match v177 { Ok(x) => v178(x), Err(e) => v179(e) };
                                                                    let v213:
                                                                            std::string::String =
                                                                        match &v181
                                                                            {
                                                                            Spiral_builder::US11::US11_0(v181_0_0)
                                                                            =>
                                                                            {
                                                                                let v184:
                                                                                        string =
                                                                                    fable_library_rust::String_::fromString(v181_0_0.clone());
                                                                                let v186:
                                                                                        &encoding_rs::Encoding =
                                                                                    encoding_rs::UTF_8;
                                                                                let v188:
                                                                                        std::borrow::Cow<[u8]> =
                                                                                    v186.encode(&*v184).0;
                                                                                let v190:
                                                                                        &[u8] =
                                                                                    v188.as_ref();
                                                                                let v192:
                                                                                        Result<&str,
                                                                                               std::str::Utf8Error> =
                                                                                    std::str::from_utf8(v190);
                                                                                let v194:
                                                                                        &str =
                                                                                    v192.unwrap();
                                                                                let v196:
                                                                                        std::string::String =
                                                                                    String::from(v194);
                                                                                let v199:
                                                                                        string =
                                                                                    sprintf!("> {}",
                                                                                             fable_library_rust::String_::fromString(v196.clone()));
                                                                                if v5
                                                                                   {
                                                                                    Spiral_builder::method4(Spiral_builder::US0::US0_0,
                                                                                                            Func0::new({
                                                                                                                           let v199
                                                                                                                               =
                                                                                                                               v199.clone();
                                                                                                                           move
                                                                                                                               ||
                                                                                                                               Spiral_builder::closure24(v199.clone(),
                                                                                                                                                         ())
                                                                                                                       }),
                                                                                                            Func0::new(move
                                                                                                                           ||
                                                                                                                           Spiral_builder::closure6((),
                                                                                                                                                    ())))
                                                                                } else {
                                                                                    printfn!("{0}",
                                                                                             v199.clone());
                                                                                    ()
                                                                                }
                                                                                v196
                                                                            }
                                                                            Spiral_builder::US11::US11_1(v181_1_0)
                                                                            =>
                                                                            {
                                                                                let v203:
                                                                                        std::string::String =
                                                                                    v181_1_0.clone();
                                                                                Spiral_builder::method4(Spiral_builder::US0::US0_4,
                                                                                                        Func0::new(move
                                                                                                                       ||
                                                                                                                       Spiral_builder::closure22((),
                                                                                                                                                 ())),
                                                                                                        Func0::new({
                                                                                                                       let v203
                                                                                                                           =
                                                                                                                           v203.clone();
                                                                                                                       move
                                                                                                                           ||
                                                                                                                           Spiral_builder::closure23(v203.clone(),
                                                                                                                                                     ())
                                                                                                                   }));
                                                                                {
                                                                                    let v207:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v203.clone());
                                                                                    let v209:
                                                                                            &str =
                                                                                        &*v207;
                                                                                    String::from(v209)
                                                                                }
                                                                            }
                                                                        };
                                                                    let v215:
                                                                            Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                        v174.lock();
                                                                    let v217:
                                                                            std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                        v215.unwrap();
                                                                    let v219:
                                                                            &std::sync::mpsc::Sender<std::string::String> =
                                                                        &v217;
                                                                    let v221:
                                                                            Result<(),
                                                                                   std::sync::mpsc::SendError<std::string::String>> =
                                                                        v219.send(v213);
                                                                    let v222 =
                                                                        Spiral_builder::method48();
                                                                    let v224:
                                                                            Result<(),
                                                                                   std::string::String> =
                                                                        v221.map_err(|x| v222(x));
                                                                    let v226:
                                                                            _ =
                                                                        v224;
                                                                    let v228:
                                                                            bool =
                                                                        true; v226 }); //;
                                                    let v231: Result<(), std::string::String> =
                                                        Spiral_builder::method49(_result);
                                                    let v235: string = string("v231 });  //");
                                                    v231
                                                }); //;
                                                {
                                                    let v237: std::thread::JoinHandle<
                                                        Result<(), std::string::String>,
                                                    > = __result;
                                                    let v239: bool = true;
                                                    let __result = std::thread::spawn(move || {
                                                        //;
                                                        let v241: Result<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStderr,
                                                            >,
                                                            std::sync::PoisonError<
                                                                std::sync::MutexGuard<
                                                                    std::process::ChildStderr,
                                                                >,
                                                            >,
                                                        > = v132.lock();
                                                        let v243: std::sync::MutexGuard<
                                                            std::process::ChildStderr,
                                                        > = v241.unwrap();
                                                        let v245: bool = true;
                                                        let mut v243 = v243;
                                                        let v247: &mut std::process::ChildStderr =
                                                            &mut v243;
                                                        let v249:
                                                                                encoding_rs_io::DecodeReaderBytes<&mut std::process::ChildStderr, Vec<u8>> =
                                                                            encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(v247);
                                                        let v251: std::io::BufReader<
                                                            encoding_rs_io::DecodeReaderBytes<
                                                                &mut std::process::ChildStderr,
                                                                Vec<u8>,
                                                            >,
                                                        > = std::io::BufReader::new(v249);
                                                        let v253: std::io::Lines<
                                                            std::io::BufReader<
                                                                encoding_rs_io::DecodeReaderBytes<
                                                                    &mut std::process::ChildStderr,
                                                                    Vec<u8>,
                                                                >,
                                                            >,
                                                        > = std::io::BufRead::lines(v251);
                                                        let v255: bool = true;
                                                        let mut v253 = v253;
                                                        let _result = v253.try_for_each(|x| { //;
                                                                        let v257:
                                                                                Result<std::string::String,
                                                                                       std::io::Error> =
                                                                            x;
                                                                        let v259:
                                                                                std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                            v148.clone();
                                                                        let v260 =
                                                                            Spiral_builder::method43();
                                                                        let v262:
                                                                                Result<std::string::String,
                                                                                       std::string::String> =
                                                                            v257.map_err(|x| v260(x));
                                                                        let v263 =
                                                                            Spiral_builder::method46();
                                                                        let v264 =
                                                                            Spiral_builder::method47();
                                                                        let v266:
                                                                                Spiral_builder::US11 =
                                                                            match v262 { Ok(x) => v263(x), Err(e) => v264(e) };
                                                                        let v303:
                                                                                std::string::String =
                                                                            match &v266
                                                                                {
                                                                                Spiral_builder::US11::US11_0(v266_0_0)
                                                                                =>
                                                                                {
                                                                                    let v269:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromString(v266_0_0.clone());
                                                                                    let v271:
                                                                                            &encoding_rs::Encoding =
                                                                                        encoding_rs::UTF_8;
                                                                                    let v273:
                                                                                            std::borrow::Cow<[u8]> =
                                                                                        v271.encode(&*v269).0;
                                                                                    let v275:
                                                                                            &[u8] =
                                                                                        v273.as_ref();
                                                                                    let v277:
                                                                                            Result<&str,
                                                                                                   std::str::Utf8Error> =
                                                                                        std::str::from_utf8(v275);
                                                                                    let v279:
                                                                                            &str =
                                                                                        v277.unwrap();
                                                                                    let v281:
                                                                                            std::string::String =
                                                                                        String::from(v279);
                                                                                    let v284:
                                                                                            string =
                                                                                        sprintf!("! {}",
                                                                                                 fable_library_rust::String_::fromString(v281.clone()));
                                                                                    if v5
                                                                                       {
                                                                                        Spiral_builder::method4(Spiral_builder::US0::US0_0,
                                                                                                                Func0::new({
                                                                                                                               let v284
                                                                                                                                   =
                                                                                                                                   v284.clone();
                                                                                                                               move
                                                                                                                                   ||
                                                                                                                                   Spiral_builder::closure24(v284.clone(),
                                                                                                                                                             ())
                                                                                                                           }),
                                                                                                                Func0::new(move
                                                                                                                               ||
                                                                                                                               Spiral_builder::closure6((),
                                                                                                                                                        ())))
                                                                                    } else {
                                                                                        printfn!("{0}",
                                                                                                 v284.clone());
                                                                                        ()
                                                                                    }
                                                                                    {
                                                                                        let v288:
                                                                                                string =
                                                                                            sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                     v281);
                                                                                        let v290:
                                                                                                &str =
                                                                                            &*v288;
                                                                                        String::from(v290)
                                                                                    }
                                                                                }
                                                                                Spiral_builder::US11::US11_1(v266_1_0)
                                                                                =>
                                                                                {
                                                                                    let v293:
                                                                                            std::string::String =
                                                                                        v266_1_0.clone();
                                                                                    Spiral_builder::method4(Spiral_builder::US0::US0_4,
                                                                                                            Func0::new(move
                                                                                                                           ||
                                                                                                                           Spiral_builder::closure22((),
                                                                                                                                                     ())),
                                                                                                            Func0::new({
                                                                                                                           let v293
                                                                                                                               =
                                                                                                                               v293.clone();
                                                                                                                           move
                                                                                                                               ||
                                                                                                                               Spiral_builder::closure23(v293.clone(),
                                                                                                                                                         ())
                                                                                                                       }));
                                                                                    {
                                                                                        let v297:
                                                                                                string =
                                                                                            sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                     v293.clone());
                                                                                        let v299:
                                                                                                &str =
                                                                                            &*v297;
                                                                                        String::from(v299)
                                                                                    }
                                                                                }
                                                                            };
                                                                        let v305:
                                                                                Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                                       std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                            v259.lock();
                                                                        let v307:
                                                                                std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                            v305.unwrap();
                                                                        let v309:
                                                                                &std::sync::mpsc::Sender<std::string::String> =
                                                                            &v307;
                                                                        let v311:
                                                                                Result<(),
                                                                                       std::sync::mpsc::SendError<std::string::String>> =
                                                                            v309.send(v303);
                                                                        let v312 =
                                                                            Spiral_builder::method48();
                                                                        let v314:
                                                                                Result<(),
                                                                                       std::string::String> =
                                                                            v311.map_err(|x| v312(x));
                                                                        let v316:
                                                                                _ =
                                                                            v314;
                                                                        let v318:
                                                                                bool =
                                                                            true; v316 }); //;
                                                        let v321: Result<(), std::string::String> =
                                                            Spiral_builder::method49(_result);
                                                        let v323: string = string("v321 });  //");
                                                        v321
                                                    }); //;
                                                    {
                                                        let v325: std::thread::JoinHandle<
                                                            Result<(), std::string::String>,
                                                        > = __result;
                                                        let _v326: LrcPtr<
                                                            MutCell<Option<Spiral_builder::US12>>,
                                                        > = refCell(None::<Spiral_builder::US12>);
                                                        {
                                                            let x_5: Option<Spiral_builder::US12> =
                                                                match &v4 {
                                                                    None => {
                                                                        None::<Spiral_builder::US12>
                                                                    }
                                                                    Some(v4_0_0) => {
                                                                        let x_3 = v4_0_0.clone();
                                                                        Some((Func0::new({
                                                                            let x_3 = x_3.clone();
                                                                            move || {
                                                                                Spiral_builder::US12::US12_0(x_3.clone())
                                                                            }
                                                                        }))(
                                                                        ))
                                                                    }
                                                                };
                                                            _v326.set(x_5)
                                                        }
                                                        {
                                                            let v331: Spiral_builder::US12 =
                                                                defaultValue(
                                                                    Spiral_builder::US12::US12_1,
                                                                    _v326.get().clone(),
                                                                );
                                                            match &v331 {
                                                                Spiral_builder::US12::US12_0(
                                                                    v331_0_0,
                                                                ) => {
                                                                    let v334:
                                                                                                Result<std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                                                                                       std::sync::PoisonError<std::sync::MutexGuard<Option<std::process::ChildStdin>>>> =
                                                                                            v137.lock();
                                                                    let v336:
                                                                                                std::sync::MutexGuard<Option<std::process::ChildStdin>> =
                                                                                            v334.unwrap();
                                                                    let v338: bool = true;
                                                                    let mut v336 = v336;
                                                                    let v340: &mut Option<
                                                                        std::process::ChildStdin,
                                                                    > = &mut v336;
                                                                    let v342: Option<
                                                                        std::process::ChildStdin,
                                                                    > = Option::take(v340);
                                                                    let v344: bool = true;
                                                                    let _result = v342.map(|x| { //;
                                                                                        let v346:
                                                                                                std::process::ChildStdin =
                                                                                            x;
                                                                                        let v348:
                                                                                                std::sync::Mutex<std::process::ChildStdin> =
                                                                                            std::sync::Mutex::new(v346);
                                                                                        let v350:
                                                                                                std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                            std::sync::Arc::new(v348);
                                                                                        let v352:
                                                                                                bool =
                                                                                            true; v350 });
                                                                    let v354:
                                                                                                Option<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>> =
                                                                                            _result;
                                                                    let _v355:
                                                                                                LrcPtr<MutCell<Option<Spiral_builder::US13>>> =
                                                                                            refCell(None::<Spiral_builder::US13>);
                                                                    {
                                                                        let x_8:
                                                                                                    Option<Spiral_builder::US13> =
                                                                                                match &v354
                                                                                                    {
                                                                                                    None
                                                                                                    =>
                                                                                                    None::<Spiral_builder::US13>,
                                                                                                    Some(v354_0_0)
                                                                                                    =>
                                                                                                    {
                                                                                                        let x_6:
                                                                                                                std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                            v354_0_0.clone();
                                                                                                        Some((Func0::new({
                                                                                                                             let x_6
                                                                                                                                 =
                                                                                                                                 x_6.clone();
                                                                                                                             move
                                                                                                                                 ||
                                                                                                                                 Spiral_builder::US13::US13_0(x_6.clone())
                                                                                                                         }))())
                                                                                                    }
                                                                                                };
                                                                        _v355.set(x_8)
                                                                    }
                                                                    {
                                                                        let v360:
                                                                                                    Spiral_builder::US13 =
                                                                                                defaultValue(Spiral_builder::US13::US13_1,
                                                                                                             _v355.get().clone());
                                                                        match &v360
                                                                                                {
                                                                                                Spiral_builder::US13::US13_0(v360_0_0)
                                                                                                =>
                                                                                                {
                                                                                                    let v361:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        match &v360
                                                                                                            {
                                                                                                            Spiral_builder::US13::US13_0(x)
                                                                                                            =>
                                                                                                            x.clone(),
                                                                                                            _
                                                                                                            =>
                                                                                                            unreachable!(),
                                                                                                        };
                                                                                                    (match &v331
                                                                                                         {
                                                                                                         Spiral_builder::US12::US12_0(x)
                                                                                                         =>
                                                                                                         x.clone(),
                                                                                                         _
                                                                                                         =>
                                                                                                         unreachable!(),
                                                                                                     })(v361.clone());
                                                                                                    {
                                                                                                        let v363:
                                                                                                                Result<std::sync::MutexGuard<std::process::ChildStdin>,
                                                                                                                       std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> =
                                                                                                            v361.lock();
                                                                                                        let v366:
                                                                                                                std::sync::MutexGuard<std::process::ChildStdin> =
                                                                                                            Spiral_builder::method50(v363.unwrap());
                                                                                                        let v368:
                                                                                                                bool =
                                                                                                            true; let mut v366 = v366;
                                                                                                        let v370:
                                                                                                                bool =
                                                                                                            true; std::io::Write::flush(&mut *v366).unwrap();
                                                                                                        ()
                                                                                                    }
                                                                                                }
                                                                                                _
                                                                                                =>
                                                                                                (),
                                                                                            }
                                                                    }
                                                                }
                                                                _ => (),
                                                            }
                                                            {
                                                                let v372: Result<
                                                                    std::sync::MutexGuard<
                                                                        Option<std::process::Child>,
                                                                    >,
                                                                    std::sync::PoisonError<
                                                                        std::sync::MutexGuard<
                                                                            Option<
                                                                                std::process::Child,
                                                                            >,
                                                                        >,
                                                                    >,
                                                                > = v118.lock();
                                                                let v374: std::sync::MutexGuard<
                                                                    Option<std::process::Child>,
                                                                > = v372.unwrap();
                                                                let v376: bool = true;
                                                                let mut v374 = v374;
                                                                let v378: &mut Option<
                                                                    std::process::Child,
                                                                > = &mut v374;
                                                                let v380: Option<
                                                                    std::process::Child,
                                                                > = Option::take(v378);
                                                                let v382: std::process::Child =
                                                                    v380.unwrap();
                                                                let v384: Result<
                                                                    std::process::Output,
                                                                    std::io::Error,
                                                                > = v382.wait_with_output();
                                                                let v385 =
                                                                    Spiral_builder::method43();
                                                                let v387: Result<
                                                                    std::process::Output,
                                                                    std::string::String,
                                                                > = v384.map_err(|x| v385(x));
                                                                let v388: std::thread::JoinHandle<
                                                                    Result<(), std::string::String>,
                                                                > = Spiral_builder::method51(v325);
                                                                let v391: string = string("v388");
                                                                let v392: std::thread::JoinHandle<
                                                                    Result<(), std::string::String>,
                                                                > = Spiral_builder::method51(v237);
                                                                let v397: string = append(
                                                                    append(
                                                                        string("vec!["),
                                                                        append(
                                                                            string("v392,"),
                                                                            v391,
                                                                        ),
                                                                    ),
                                                                    string("]"),
                                                                );
                                                                let v398: Vec<
                                                                    std::thread::JoinHandle<
                                                                        Result<
                                                                            (),
                                                                            std::string::String,
                                                                        >,
                                                                    >,
                                                                > = vec![v392, v388];
                                                                let v400: bool = true;
                                                                v398.into_iter().for_each(|x| { //;
                                                                                    let v402:
                                                                                            std::thread::JoinHandle<Result<(),
                                                                                                                           std::string::String>> =
                                                                                        x;
                                                                                    let v404:
                                                                                            Result<Result<(),
                                                                                                          std::string::String>,
                                                                                                   Box<dyn core::any::Any + 'static + Send>> =
                                                                                        std::thread::JoinHandle::join(v402);
                                                                                    let v406:
                                                                                            Result<(),
                                                                                                   std::string::String> =
                                                                                        v404.unwrap();
                                                                                    v406.unwrap();
                                                                                    {
                                                                                        let v409:
                                                                                                bool =
                                                                                            true; () }});
                                                                {
                                                                    //;
                                                                    let v412:
                                                                                                Spiral_builder::US14 =
                                                                                            match &v387
                                                                                                {
                                                                                                Err(v387_1_0)
                                                                                                =>
                                                                                                Spiral_builder::closure27((),
                                                                                                                          v387_1_0.clone()),
                                                                                                Ok(v387_0_0)
                                                                                                =>
                                                                                                Spiral_builder::closure26((),
                                                                                                                          v387_0_0.clone()),
                                                                                            };
                                                                    match &v412
                                                                                            {
                                                                                            Spiral_builder::US14::US14_0(v412_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v415:
                                                                                                        std::process::ExitStatus =
                                                                                                    v412_0_0.clone().status;
                                                                                                let v417:
                                                                                                        Option<i32> =
                                                                                                    v415.code();
                                                                                                (v417.unwrap(),
                                                                                                 Spiral_builder::US2::US2_1,
                                                                                                 Spiral_builder::US10::US10_0(v152))
                                                                                            }
                                                                                            Spiral_builder::US14::US14_1(v412_1_0)
                                                                                            =>
                                                                                            {
                                                                                                let v422:
                                                                                                        std::string::String =
                                                                                                    v412_1_0.clone();
                                                                                                Spiral_builder::method4(Spiral_builder::US0::US0_4,
                                                                                                                        Func0::new(move
                                                                                                                                       ||
                                                                                                                                       Spiral_builder::closure28((),
                                                                                                                                                                 ())),
                                                                                                                        Func0::new({
                                                                                                                                       let v422
                                                                                                                                           =
                                                                                                                                           v422.clone();
                                                                                                                                       move
                                                                                                                                           ||
                                                                                                                                           Spiral_builder::closure29(v422.clone(),
                                                                                                                                                                     ())
                                                                                                                                   }));
                                                                                                (-2_i32,
                                                                                                 Spiral_builder::US2::US2_0(v422.clone()),
                                                                                                 Spiral_builder::US10::US10_1)
                                                                                            }
                                                                                        }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            Spiral_builder::US9::US9_1(v117_1_0) => {
                                                let v434: std::string::String = v117_1_0.clone();
                                                Spiral_builder::method4(
                                                    Spiral_builder::US0::US0_4,
                                                    Func0::new(move || {
                                                        Spiral_builder::closure18((), ())
                                                    }),
                                                    Func0::new({
                                                        let v434 = v434.clone();
                                                        move || {
                                                            Spiral_builder::closure19(
                                                                v434.clone(),
                                                                (),
                                                            )
                                                        }
                                                    }),
                                                );
                                                (
                                                    -1_i32,
                                                    Spiral_builder::US2::US2_0(v434.clone()),
                                                    Spiral_builder::US10::US10_1,
                                                )
                                            }
                                        };
                                        let v445: Spiral_builder::US10 = patternInput_4.2.clone();
                                        let v444: Spiral_builder::US2 = patternInput_4.1.clone();
                                        let v443: i32 = patternInput_4.0.clone();
                                        let v450: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            >,
                                        > = match &v445 {
                                            Spiral_builder::US10::US10_0(v445_0_0) => {
                                                Some(match &v445 {
                                                    Spiral_builder::US10::US10_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                None::<
                                                    std::sync::Arc<
                                                        std::sync::Mutex<
                                                            std::sync::Arc<
                                                                std::sync::mpsc::Receiver<
                                                                    std::string::String,
                                                                >,
                                                            >,
                                                        >,
                                                    >,
                                                >
                                            }
                                        };
                                        let v452: bool = true;
                                        let _result = v450.map(|x| {
                                            //;
                                            let v454: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            > = x;
                                            let v456: Result<
                                                std::sync::MutexGuard<
                                                    std::sync::Arc<
                                                        std::sync::mpsc::Receiver<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        std::sync::Arc<
                                                            std::sync::mpsc::Receiver<
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    >,
                                                >,
                                            > = v454.lock();
                                            let v458: std::sync::MutexGuard<
                                                std::sync::Arc<
                                                    std::sync::mpsc::Receiver<std::string::String>,
                                                >,
                                            > = v456.unwrap();
                                            let v460 = v458.iter();
                                            let v462: Vec<std::string::String> =
                                                v460.collect::<Vec<_>>();
                                            let v464: bool = true;
                                            let _result = v462
                                                .into_iter()
                                                .map(|x| {
                                                    //;
                                                    let v466: std::string::String = x;
                                                    let v468: string =
                                                        fable_library_rust::String_::fromString(
                                                            v466,
                                                        );
                                                    let v470: bool = true;
                                                    v468
                                                })
                                                .collect::<Vec<_>>();
                                            let v472: Vec<string> = _result;
                                            let v476: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                                fable_library_rust::NativeArray_::array_from(v472),
                                            );
                                            let v480: string =
                                                join(Spiral_builder::method32(), toArray_1(v476));
                                            let v482: bool = true;
                                            v480
                                        });
                                        let v484: Option<string> = _result;
                                        let v491: Spiral_builder::US3 = match &v444 {
                                            Spiral_builder::US2::US2_0(v444_0_0) => {
                                                Spiral_builder::US3::US3_0(
                                                    fable_library_rust::String_::fromString(
                                                        match &v444 {
                                                            Spiral_builder::US2::US2_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        },
                                                    ),
                                                )
                                            }
                                            _ => Spiral_builder::US3::US3_1,
                                        };
                                        let v496: string = defaultValue(
                                            match &v491 {
                                                Spiral_builder::US3::US3_0(v491_0_0) => match &v491
                                                {
                                                    Spiral_builder::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                _ => string(""),
                                            },
                                            v484,
                                        );
                                        Spiral_builder::method4(
                                            Spiral_builder::US0::US0_0,
                                            Func0::new(move || Spiral_builder::closure30((), ())),
                                            Func0::new({
                                                let v443 = v443.clone();
                                                let v496 = v496.clone();
                                                move || {
                                                    Spiral_builder::closure31(
                                                        v443,
                                                        v496.clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        LrcPtr::new((v443, v496.clone()))
                                    }
                                }
                            }))();
                            _v48.set(Some(x_12))
                        }
                        {
                            let v501: LrcPtr<(i32, string)> = getValue(_v48.get().clone());
                            let v502: LrcPtr<(i32, string)> =
                                Spiral_builder::method52(v501.0.clone(), v501.1.clone());
                            let v511: string = string("v502 }}}); {{ //");
                            v502
                        }
                    }
                });
                {
                    {
                        //;
                        {
                            let v513: std::pin::Pin<
                                Box<dyn std::future::Future<Output = LrcPtr<(i32, string)>>>,
                            > = __result;
                            let v515: LrcPtr<(i32, string)> = futures_lite::future::block_on(v513);
                            _v7.set(Some((v515.0.clone(), v515.1.clone())));
                            {
                                let patternInput_5: (i32, string) = getValue(_v7.get().clone());
                                (patternInput_5.0.clone(), patternInput_5.1.clone())
                            }
                        }
                    }
                }
            }
        }
        pub fn closure39(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / repl error")
        }
        pub fn closure40(v0_1: u8, v1_1: u8, v2: string, v3: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / retry: {}/{} / repl_result: {} / {}",
                v3,
                v1_1,
                v0_1,
                v2,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method38(v0_1: Option<string>, v1_1: u8, v2: string, v3: u8) -> (i32, string) {
            let v0_1: MutCell<Option<string>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<u8> = MutCell::new(v1_1);
            let v2: MutCell<string> = MutCell::new(v2.clone());
            let v3: MutCell<u8> = MutCell::new(v3);
            '_method38: loop {
                break '_method38 ({
                    let patternInput: (i32, string) = Spiral_builder::method39(
                        None::<CancellationToken>,
                        sprintf!(
                            "dotnet repl --exit-after-run --run \"{}\" --output-path \"{}.ipynb\"",
                            v2.get().clone(),
                            v2.get().clone()
                        ),
                        new_array(&[(string("AUTOMATION"), string("True"))]),
                        None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                        false,
                        v0_1.get().clone(),
                    );
                    let v15: string = patternInput.1.clone();
                    let v14: i32 = patternInput.0.clone();
                    if if v14 == 0_i32 {
                        true
                    } else {
                        v3.get().clone() >= v1_1.get().clone()
                    } {
                        (v14, v15.clone())
                    } else {
                        Spiral_builder::method4(
                            Spiral_builder::US0::US0_1,
                            Func0::new(move || Spiral_builder::closure39((), ())),
                            Func0::new({
                                let v14 = v14.clone();
                                let v15 = v15.clone();
                                let v1_1 = v1_1.clone();
                                let v3 = v3.clone();
                                move || {
                                    Spiral_builder::closure40(
                                        v1_1.get().clone(),
                                        v3.get().clone(),
                                        v15.clone(),
                                        v14,
                                        (),
                                    )
                                }
                            }),
                        );
                        {
                            let v0_1_temp: Option<string> = v0_1.get().clone();
                            let v1_1_temp: u8 = v1_1.get().clone();
                            let v2_temp: string = v2.get().clone();
                            let v3_temp: u8 = v3.get().clone() + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method38;
                        }
                    }
                });
            }
        }
        pub fn closure41(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib / jupyter nbconvert")
        }
        pub fn closure42(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / jupyter_result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure43(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib / html cell ids")
        }
        pub fn closure44(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / pwsh_replace_html_result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method55(v0_1: string) -> string {
            v0_1
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib")
        }
        pub fn closure46(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure47(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run")
        }
        pub fn closure48(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "subcommand: {} / {}",
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure49(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v3: &str = &*_arg.0.clone();
            let v5: std::string::String = String::from(v3);
            let v7: &str = &*_arg.1.clone();
            LrcPtr::new((v5, String::from(v7)))
        }
        pub fn closure50(unitVar: (), v0_1: serde_json::Error) -> string {
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
        pub fn method56() -> Func1<serde_json::Error, string> {
            Func1::new(move |v: serde_json::Error| Spiral_builder::closure50((), v))
        }
        pub fn method57(v0_1: Result<string, string>) -> Result<string, string> {
            v0_1
        }
        pub fn method7(
            v0_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, string>>>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v4: Option<(std::string::String, clap::ArgMatches)> =
                        clap::ArgMatches::subcommand(Box::leak(Box::new(v0_1))).map(|(a, b)| {
                            (
                                Func1::new(move |v: &str| Spiral_builder::closure8((), v))(a),
                                b.clone(),
                            )
                        });
                    let _v5: LrcPtr<MutCell<Option<Spiral_builder::US4>>> =
                        refCell(None::<Spiral_builder::US4>);
                    {
                        let x_2: Option<Spiral_builder::US4> = match &v4 {
                            None => None::<Spiral_builder::US4>,
                            Some(v4_0_0) => {
                                let x: (std::string::String, clap::ArgMatches) = v4_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Spiral_builder::US4::US4_0(x.0.clone(), x.1.clone())
                                }))())
                            }
                        };
                        _v5.set(x_2)
                    }
                    {
                        let v11: Spiral_builder::US4 =
                            defaultValue(Spiral_builder::US4::US4_1, _v5.get().clone());
                        let v705: Array<(string, string)> = if let Spiral_builder::US4::US4_0(
                            v11_0_0,
                            v11_0_1,
                        ) = &v11
                        {
                            let v13: clap::ArgMatches = match &v11 {
                                Spiral_builder::US4::US4_0(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v12: std::string::String = match &v11 {
                                Spiral_builder::US4::US4_0(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if fable_library_rust::String_::fromString(v12.clone())
                                == string("fsharp")
                            {
                                let v18: string = Spiral_builder::method8();
                                let v20: &str = &*v18;
                                let v22: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v13.clone(), v20).cloned();
                                let _v23: LrcPtr<MutCell<Option<Spiral_builder::US2>>> =
                                    refCell(None::<Spiral_builder::US2>);
                                {
                                    let x_5: Option<Spiral_builder::US2> = match &v22 {
                                        None => None::<Spiral_builder::US2>,
                                        Some(v22_0_0) => {
                                            let x_3: std::string::String = v22_0_0.clone();
                                            Some((Func0::new({
                                                let x_3 = x_3.clone();
                                                move || Spiral_builder::US2::US2_0(x_3.clone())
                                            }))())
                                        }
                                    };
                                    _v23.set(x_5)
                                }
                                {
                                    let v28: Spiral_builder::US2 = defaultValue(
                                        Spiral_builder::US2::US2_1,
                                        _v23.get().clone(),
                                    );
                                    let v32: std::string::String = match &v28 {
                                        Spiral_builder::US2::US2_0(v28_0_0) => match &v28 {
                                            Spiral_builder::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                    let v34: string = fable_library_rust::String_::fromString(v32);
                                    let v35: string = Spiral_builder::method9();
                                    let v37: &str = &*v35;
                                    let v39: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v13.clone(), v37).cloned();
                                    let _v40: LrcPtr<MutCell<Option<Spiral_builder::US2>>> =
                                        refCell(None::<Spiral_builder::US2>);
                                    {
                                        let x_8: Option<Spiral_builder::US2> = match &v39 {
                                            None => None::<Spiral_builder::US2>,
                                            Some(v39_0_0) => {
                                                let x_6: std::string::String = v39_0_0.clone();
                                                Some((Func0::new({
                                                    let x_6 = x_6.clone();
                                                    move || Spiral_builder::US2::US2_0(x_6.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v40.set(x_8)
                                    }
                                    {
                                        let v45: Spiral_builder::US2 = defaultValue(
                                            Spiral_builder::US2::US2_1,
                                            _v40.get().clone(),
                                        );
                                        let v49: std::string::String = match &v45 {
                                            Spiral_builder::US2::US2_0(v45_0_0) => match &v45 {
                                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        };
                                        let v51: string =
                                            fable_library_rust::String_::fromString(v49);
                                        let v52: string = Spiral_builder::method10();
                                        let v54: &str = &*v52;
                                        let v56: Option<std::string::String> =
                                            clap::ArgMatches::get_one(&v13.clone(), v54).cloned();
                                        let _v57: LrcPtr<MutCell<Option<Spiral_builder::US2>>> =
                                            refCell(None::<Spiral_builder::US2>);
                                        {
                                            let x_11: Option<Spiral_builder::US2> = match &v56 {
                                                None => None::<Spiral_builder::US2>,
                                                Some(v56_0_0) => {
                                                    let x_9: std::string::String = v56_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_9 = x_9.clone();
                                                        move || {
                                                            Spiral_builder::US2::US2_0(x_9.clone())
                                                        }
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v57.set(x_11)
                                        }
                                        {
                                            let v62: Spiral_builder::US2 = defaultValue(
                                                Spiral_builder::US2::US2_1,
                                                _v57.get().clone(),
                                            );
                                            let v69: Spiral_builder::US3 = match &v62 {
                                                Spiral_builder::US2::US2_0(v62_0_0) => {
                                                    Spiral_builder::US3::US3_0(
                                                        fable_library_rust::String_::fromString(
                                                            match &v62 {
                                                                Spiral_builder::US2::US2_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                        ),
                                                    )
                                                }
                                                _ => Spiral_builder::US3::US3_1,
                                            };
                                            let v98: string =
                                                Spiral_builder::method18(match &v69 {
                                                    Spiral_builder::US3::US3_0(v69_0_0) => {
                                                        let v71: clap::Command =
                                                            Spiral_builder::method0();
                                                        let v73: Array<string> =
                                                            Spiral_builder::method11(sprintf!(
                                                                "_ {}",
                                                                match &v69 {
                                                                    Spiral_builder::US3::US3_0(
                                                                        x,
                                                                    ) => x.clone(),
                                                                    _ => unreachable!(),
                                                                }
                                                            ));
                                                        let v75: Vec<string> = v73.to_vec();
                                                        let v77: bool = true;
                                                        let _result = v75
                                                            .into_iter()
                                                            .map(|x| {
                                                                //;
                                                                let v79: string = x;
                                                                let v81: &str = &*v79;
                                                                let v83: std::string::String =
                                                                    String::from(v81);
                                                                let v85: bool = true;
                                                                v83
                                                            })
                                                            .collect::<Vec<_>>();
                                                        let v87: Vec<std::string::String> = _result;
                                                        let v90: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = Result<string, string>,
                                                                >,
                                                            >,
                                                        > = Spiral_builder::method7(
                                                            clap::Command::get_matches_from(
                                                                v71, v87,
                                                            ),
                                                        );
                                                        let v92: Result<string, string> =
                                                            futures_lite::future::block_on(v90);
                                                        v92.unwrap()
                                                    }
                                                    _ => string("{}"),
                                                });
                                            let v100: &str = &*v98;
                                            let v102: Result<
                                                std::collections::HashMap<
                                                    std::string::String,
                                                    std::string::String,
                                                >,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v100);
                                            let v103 = Spiral_builder::method19();
                                            let v105: Result<
                                                std::collections::HashMap<
                                                    std::string::String,
                                                    std::string::String,
                                                >,
                                                std::string::String,
                                            > = v102.map_err(|x| v103(x));
                                            let v107: std::collections::HashMap<
                                                std::string::String,
                                                std::string::String,
                                            > = v105.unwrap();
                                            let v110: &str = &*string("deps");
                                            let v113: std::string::String =
                                                Spiral_builder::method20(String::from(v110));
                                            let v115: Option<std::string::String> =
                                                std::collections::HashMap::get(&v107, &v113)
                                                    .map(|x| x)
                                                    .cloned();
                                            let v117: std::string::String = v115.unwrap();
                                            let v120: string = Spiral_builder::method18(
                                                fable_library_rust::String_::fromString(v117),
                                            );
                                            let v122: &str = &*v120;
                                            let v124: Result<
                                                Vec<std::string::String>,
                                                serde_json::Error,
                                            > = serde_json::from_str(&v122);
                                            let v125 = Spiral_builder::method19();
                                            let v127: Result<
                                                Vec<std::string::String>,
                                                std::string::String,
                                            > = v124.map_err(|x| v125(x));
                                            let v129: Vec<std::string::String> = v127.unwrap();
                                            let _v130: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let v131: string = Spiral_builder::method21(v34);
                                            let v133: &str = &*v131.clone();
                                            let v135: std::string::String = String::from(v133);
                                            let v137: std::path::PathBuf =
                                                std::path::PathBuf::from(v135);
                                            {
                                                let x_18: string = if v137.exists() == false {
                                                    let _v141: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let v143: Result<
                                                        std::path::PathBuf,
                                                        std::io::Error,
                                                    > = std::env::current_dir();
                                                    let v145: std::path::PathBuf = v143.unwrap();
                                                    let v147: std::path::Display = v145.display();
                                                    let _v148: MutCell<
                                                        Option<std::string::String>,
                                                    > = MutCell::new(None::<std::string::String>);
                                                    {
                                                        let x_12: std::string::String =
                                                            format!("{}", v147);
                                                        _v148.set(Some(x_12))
                                                    }
                                                    {
                                                        let v158: std::string::String =
                                                            getValue(_v148.get().clone());
                                                        {
                                                            let x_13:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v158);
                                                            _v141.set(Some(x_13))
                                                        }
                                                        {
                                                            let v167: string =
                                                                getValue(_v141.get().clone());
                                                            let _v169: MutCell<Option<string>> =
                                                                MutCell::new(None::<string>);
                                                            let v170: string =
                                                                Spiral_builder::method25(
                                                                    Spiral_builder::method22(
                                                                        v167.clone(),
                                                                        v131.clone(),
                                                                    ),
                                                                );
                                                            let v171: string =
                                                                Spiral_builder::method26();
                                                            let _v172: MutCell<
                                                                Option<
                                                                    Result<
                                                                        regex::Regex,
                                                                        regex::Error,
                                                                    >,
                                                                >,
                                                            > = MutCell::new(
                                                                None::<
                                                                    Result<
                                                                        regex::Regex,
                                                                        regex::Error,
                                                                    >,
                                                                >,
                                                            );
                                                            let v173: string =
                                                                Spiral_builder::method27();
                                                            {
                                                                let x_14: Result<
                                                                    regex::Regex,
                                                                    regex::Error,
                                                                > = regex::Regex::new(&v173);
                                                                _v172.set(Some(x_14))
                                                            }
                                                            {
                                                                let v181: Result<
                                                                    regex::Regex,
                                                                    regex::Error,
                                                                > = getValue(_v172.get().clone());
                                                                let v183: regex::Regex =
                                                                    v181.unwrap();
                                                                let v185: std::borrow::Cow<str> =
                                                                    v183.replace_all(&v170, &*v171);
                                                                let v187: std::string::String =
                                                                    String::from(v185);
                                                                {
                                                                    let x_15:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v187);
                                                                    _v169.set(Some(x_15))
                                                                }
                                                                {
                                                                    let v197: string = getValue(
                                                                        _v169.get().clone(),
                                                                    );
                                                                    let v202: Array<string> = split(
                                                                        replace(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                toLower(ofChar(
                                                                                    getCharAt(
                                                                                        v197.clone(
                                                                                        ),
                                                                                        0_i32
                                                                                    )
                                                                                )),
                                                                                getSlice(
                                                                                    v197,
                                                                                    Some(1_i32),
                                                                                    None::<i32>
                                                                                )
                                                                            ),
                                                                            string("\\"),
                                                                            string("/"),
                                                                        ),
                                                                        string("/"),
                                                                        -1_i32,
                                                                        0_i32,
                                                                    );
                                                                    let v204: i32 =
                                                                        count(v202.clone());
                                                                    let v205: LrcPtr<
                                                                        Spiral_builder::Mut5,
                                                                    > = LrcPtr::new(
                                                                        Spiral_builder::Mut5 {
                                                                            l0: MutCell::new(0_i32),
                                                                            l1: MutCell::new(0_i32),
                                                                            l2: MutCell::new(
                                                                                new_empty::<string>(
                                                                                ),
                                                                            ),
                                                                        },
                                                                    );
                                                                    while Spiral_builder::method29(
                                                                        v204,
                                                                        v205.clone(),
                                                                    ) {
                                                                        let v207: i32 =
                                                                            v205.l0.get().clone();
                                                                        let v210: i32 = v207
                                                                            .wrapping_neg()
                                                                            + v204
                                                                            - 1_i32;
                                                                        let matchValue: i32 =
                                                                            v205.l1.get().clone();
                                                                        let v212: Array<string> =
                                                                            v205.l2.get().clone();
                                                                        let v211: i32 = matchValue;
                                                                        let v213: string =
                                                                            v202[v210].clone();
                                                                        let patternInput_1: (
                                                                            i32,
                                                                            Array<string>,
                                                                        ) = if string("..")
                                                                            == v213.clone()
                                                                        {
                                                                            (
                                                                                v211 + 1_i32,
                                                                                v212.clone(),
                                                                            )
                                                                        } else {
                                                                            if string(".")
                                                                                == v213.clone()
                                                                            {
                                                                                (v211, v212.clone())
                                                                            } else {
                                                                                if 0_i32 == v211 {
                                                                                    if endsWith(
                                                                                        v213.clone(
                                                                                        ),
                                                                                        string(":"),
                                                                                        false,
                                                                                    ) {
                                                                                        let v221:
                                                                                                        Array<string> =
                                                                                                    new_array(&[sprintf!("{}:",
                                                                                                                         getCharAt(v167.clone(),
                                                                                                                                   0_i32))]);
                                                                                        let v222:
                                                                                                        i32 =
                                                                                                    count(v221.clone());
                                                                                        let v224:
                                                                                                        i32 =
                                                                                                    v222
                                                                                                        +
                                                                                                        count(v212.clone());
                                                                                        let v225:
                                                                                                        Array<string> =
                                                                                                    new_init(&string(""),
                                                                                                             v224);
                                                                                        let v226:
                                                                                                        LrcPtr<Spiral_builder::Mut4> =
                                                                                                    LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                         MutCell::new(0_i32),});
                                                                                        while Spiral_builder::method12(v224,
                                                                                                                               v226.clone())
                                                                                                      {
                                                                                                    let v228:
                                                                                                            i32 =
                                                                                                        v226.l0.get().clone();
                                                                                                    let v233:
                                                                                                            string =
                                                                                                        if v228
                                                                                                               <
                                                                                                               v222
                                                                                                           {
                                                                                                            v221[v228].clone()
                                                                                                        } else {
                                                                                                            let v231:
                                                                                                                    i32 =
                                                                                                                v228
                                                                                                                    -
                                                                                                                    v222;
                                                                                                            v212[v231].clone()
                                                                                                        };
                                                                                                    v225.get_mut()[v228
                                                                                                                       as
                                                                                                                       usize]
                                                                                                        =
                                                                                                        v233;
                                                                                                    {
                                                                                                        let v234:
                                                                                                                i32 =
                                                                                                            v228
                                                                                                                +
                                                                                                                1_i32;
                                                                                                        v226.l0.set(v234);
                                                                                                        ()
                                                                                                    }
                                                                                                }
                                                                                        (0_i32,
                                                                                                 v225.clone())
                                                                                    } else {
                                                                                        let v235:
                                                                                                        Array<string> =
                                                                                                    new_array(&[v213]);
                                                                                        let v236:
                                                                                                        i32 =
                                                                                                    count(v235.clone());
                                                                                        let v238:
                                                                                                        i32 =
                                                                                                    v236
                                                                                                        +
                                                                                                        count(v212.clone());
                                                                                        let v239:
                                                                                                        Array<string> =
                                                                                                    new_init(&string(""),
                                                                                                             v238);
                                                                                        let v240:
                                                                                                        LrcPtr<Spiral_builder::Mut4> =
                                                                                                    LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                         MutCell::new(0_i32),});
                                                                                        while Spiral_builder::method12(v238,
                                                                                                                               v240.clone())
                                                                                                      {
                                                                                                    let v242:
                                                                                                            i32 =
                                                                                                        v240.l0.get().clone();
                                                                                                    let v247:
                                                                                                            string =
                                                                                                        if v242
                                                                                                               <
                                                                                                               v236
                                                                                                           {
                                                                                                            v235[v242].clone()
                                                                                                        } else {
                                                                                                            let v245:
                                                                                                                    i32 =
                                                                                                                v242
                                                                                                                    -
                                                                                                                    v236;
                                                                                                            v212[v245].clone()
                                                                                                        };
                                                                                                    v239.get_mut()[v242
                                                                                                                       as
                                                                                                                       usize]
                                                                                                        =
                                                                                                        v247;
                                                                                                    {
                                                                                                        let v248:
                                                                                                                i32 =
                                                                                                            v242
                                                                                                                +
                                                                                                                1_i32;
                                                                                                        v240.l0.set(v248);
                                                                                                        ()
                                                                                                    }
                                                                                                }
                                                                                        (0_i32,
                                                                                                 v239.clone())
                                                                                    }
                                                                                } else {
                                                                                    (
                                                                                        v211
                                                                                            - 1_i32,
                                                                                        v212.clone(
                                                                                        ),
                                                                                    )
                                                                                }
                                                                            }
                                                                        };
                                                                        let v258: i32 =
                                                                            v207 + 1_i32;
                                                                        v205.l0.set(v258);
                                                                        v205.l1.set(
                                                                            patternInput_1
                                                                                .0
                                                                                .clone(),
                                                                        );
                                                                        v205.l2.set(
                                                                            patternInput_1
                                                                                .1
                                                                                .clone(),
                                                                        );
                                                                        ()
                                                                    }
                                                                    {
                                                                        let matchValue_2: i32 =
                                                                            v205.l1.get().clone();
                                                                        let v260: Array<string> =
                                                                            v205.l2.get().clone();
                                                                        let v261: LrcPtr<
                                                                            dyn IEnumerable_1<
                                                                                string,
                                                                            >,
                                                                        > = delay(Func0::new({
                                                                            let v260 = v260.clone();
                                                                            move || {
                                                                                map(Func1::new({
                                                                                                                            let v260
                                                                                                                                =
                                                                                                                                v260.clone();
                                                                                                                            move
                                                                                                                                |i:
                                                                                                                                     i32|
                                                                                                                                v260[i].clone()
                                                                                                                        }),
                                                                                                             rangeNumeric(0_i32,
                                                                                                                          1_i32,
                                                                                                                          count(v260.clone())
                                                                                                                              -
                                                                                                                              1_i32))
                                                                            }
                                                                        }));
                                                                        let _v262: MutCell<
                                                                            Option<char>,
                                                                        > = MutCell::new(
                                                                            None::<char>,
                                                                        );
                                                                        {
                                                                            let x_16:
                                                                                        char =
                                                                                    std::path::MAIN_SEPARATOR;
                                                                            _v262.set(Some(x_16))
                                                                        }
                                                                        join(Spiral_builder::method30(ofChar(getValue(_v262.get().clone()))),
                                                                                 toArray_1(v261))
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                } else {
                                                    let v278: Result<
                                                        std::path::PathBuf,
                                                        std::io::Error,
                                                    > = std::fs::canonicalize(&*v131);
                                                    let v280: std::path::PathBuf = v278.unwrap();
                                                    let v282: std::path::Display = v280.display();
                                                    let _v283: MutCell<
                                                        Option<std::string::String>,
                                                    > = MutCell::new(None::<std::string::String>);
                                                    {
                                                        let x_17: std::string::String =
                                                            format!("{}", v282);
                                                        _v283.set(Some(x_17))
                                                    }
                                                    {
                                                        let v293: std::string::String =
                                                            getValue(_v283.get().clone());
                                                        fable_library_rust::String_::fromString(
                                                            v293,
                                                        )
                                                    }
                                                };
                                                _v130.set(Some(x_18))
                                            }
                                            {
                                                let v304: string = getValue(_v130.get().clone());
                                                let _v305: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let v306: string = Spiral_builder::method21(v51);
                                                let v308: &str = &*v306.clone();
                                                let v310: std::string::String = String::from(v308);
                                                let v312: std::path::PathBuf =
                                                    std::path::PathBuf::from(v310);
                                                {
                                                    let x_25: string = if v312.exists() == false {
                                                        let _v316: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let v318: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::env::current_dir();
                                                        let v320: std::path::PathBuf =
                                                            v318.unwrap();
                                                        let v322: std::path::Display =
                                                            v320.display();
                                                        let _v323: MutCell<
                                                            Option<std::string::String>,
                                                        > = MutCell::new(
                                                            None::<std::string::String>,
                                                        );
                                                        {
                                                            let x_19: std::string::String =
                                                                format!("{}", v322);
                                                            _v323.set(Some(x_19))
                                                        }
                                                        {
                                                            let v333: std::string::String =
                                                                getValue(_v323.get().clone());
                                                            {
                                                                let x_20:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v333);
                                                                _v316.set(Some(x_20))
                                                            }
                                                            {
                                                                let v342: string =
                                                                    getValue(_v316.get().clone());
                                                                let _v344: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let v345: string =
                                                                    Spiral_builder::method25(
                                                                        Spiral_builder::method22(
                                                                            v342.clone(),
                                                                            v306.clone(),
                                                                        ),
                                                                    );
                                                                let v346: string =
                                                                    Spiral_builder::method26();
                                                                let _v347: MutCell<
                                                                    Option<
                                                                        Result<
                                                                            regex::Regex,
                                                                            regex::Error,
                                                                        >,
                                                                    >,
                                                                > = MutCell::new(
                                                                    None::<
                                                                        Result<
                                                                            regex::Regex,
                                                                            regex::Error,
                                                                        >,
                                                                    >,
                                                                );
                                                                let v348: string =
                                                                    Spiral_builder::method27();
                                                                {
                                                                    let x_21: Result<
                                                                        regex::Regex,
                                                                        regex::Error,
                                                                    > = regex::Regex::new(&v348);
                                                                    _v347.set(Some(x_21))
                                                                }
                                                                {
                                                                    let v356: Result<
                                                                        regex::Regex,
                                                                        regex::Error,
                                                                    > = getValue(
                                                                        _v347.get().clone(),
                                                                    );
                                                                    let v358: regex::Regex =
                                                                        v356.unwrap();
                                                                    let v360: std::borrow::Cow<
                                                                        str,
                                                                    > = v358
                                                                        .replace_all(&v345, &*v346);
                                                                    let v362: std::string::String =
                                                                        String::from(v360);
                                                                    {
                                                                        let x_22:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v362);
                                                                        _v344.set(Some(x_22))
                                                                    }
                                                                    {
                                                                        let v372: string = getValue(
                                                                            _v344.get().clone(),
                                                                        );
                                                                        let v377:
                                                                                    Array<string> =
                                                                                split(replace(sprintf!("{}{}",
                                                                                                       toLower(ofChar(getCharAt(v372.clone(),
                                                                                                                                0_i32))),
                                                                                                       getSlice(v372,
                                                                                                                Some(1_i32),
                                                                                                                None::<i32>)),
                                                                                              string("\\"),
                                                                                              string("/")),
                                                                                      string("/"),
                                                                                      -1_i32,
                                                                                      0_i32);
                                                                        let v379: i32 =
                                                                            count(v377.clone());
                                                                        let v380: LrcPtr<
                                                                            Spiral_builder::Mut5,
                                                                        > = LrcPtr::new(
                                                                            Spiral_builder::Mut5 {
                                                                                l0: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                                l1: MutCell::new(
                                                                                    0_i32,
                                                                                ),
                                                                                l2: MutCell::new(
                                                                                    new_empty::<
                                                                                        string,
                                                                                    >(
                                                                                    ),
                                                                                ),
                                                                            },
                                                                        );
                                                                        while
                                                                            Spiral_builder::method29(
                                                                                v379,
                                                                                v380.clone(),
                                                                            )
                                                                        {
                                                                            let v382: i32 = v380
                                                                                .l0
                                                                                .get()
                                                                                .clone();
                                                                            let v385: i32 = v382
                                                                                .wrapping_neg()
                                                                                + v379
                                                                                - 1_i32;
                                                                            let matchValue_4: i32 =
                                                                                v380.l1
                                                                                    .get()
                                                                                    .clone();
                                                                            let v387: Array<
                                                                                string,
                                                                            > = v380
                                                                                .l2
                                                                                .get()
                                                                                .clone();
                                                                            let v386: i32 =
                                                                                matchValue_4;
                                                                            let v388: string =
                                                                                v377[v385].clone();
                                                                            let patternInput_4: (
                                                                                i32,
                                                                                Array<string>,
                                                                            ) = if string("..")
                                                                                == v388.clone()
                                                                            {
                                                                                (
                                                                                    v386 + 1_i32,
                                                                                    v387.clone(),
                                                                                )
                                                                            } else {
                                                                                if string(".")
                                                                                    == v388.clone()
                                                                                {
                                                                                    (
                                                                                        v386,
                                                                                        v387.clone(
                                                                                        ),
                                                                                    )
                                                                                } else {
                                                                                    if 0_i32 == v386
                                                                                    {
                                                                                        if endsWith(v388.clone(),
                                                                                                            string(":"),
                                                                                                            false)
                                                                                                   {
                                                                                                    let v396:
                                                                                                            Array<string> =
                                                                                                        new_array(&[sprintf!("{}:",
                                                                                                                             getCharAt(v342.clone(),
                                                                                                                                       0_i32))]);
                                                                                                    let v397:
                                                                                                            i32 =
                                                                                                        count(v396.clone());
                                                                                                    let v399:
                                                                                                            i32 =
                                                                                                        v397
                                                                                                            +
                                                                                                            count(v387.clone());
                                                                                                    let v400:
                                                                                                            Array<string> =
                                                                                                        new_init(&string(""),
                                                                                                                 v399);
                                                                                                    let v401:
                                                                                                            LrcPtr<Spiral_builder::Mut4> =
                                                                                                        LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                             MutCell::new(0_i32),});
                                                                                                    while Spiral_builder::method12(v399,
                                                                                                                                   v401.clone())
                                                                                                          {
                                                                                                        let v403:
                                                                                                                i32 =
                                                                                                            v401.l0.get().clone();
                                                                                                        let v408:
                                                                                                                string =
                                                                                                            if v403
                                                                                                                   <
                                                                                                                   v397
                                                                                                               {
                                                                                                                v396[v403].clone()
                                                                                                            } else {
                                                                                                                let v406:
                                                                                                                        i32 =
                                                                                                                    v403
                                                                                                                        -
                                                                                                                        v397;
                                                                                                                v387[v406].clone()
                                                                                                            };
                                                                                                        v400.get_mut()[v403
                                                                                                                           as
                                                                                                                           usize]
                                                                                                            =
                                                                                                            v408;
                                                                                                        {
                                                                                                            let v409:
                                                                                                                    i32 =
                                                                                                                v403
                                                                                                                    +
                                                                                                                    1_i32;
                                                                                                            v401.l0.set(v409);
                                                                                                            ()
                                                                                                        }
                                                                                                    }
                                                                                                    (0_i32,
                                                                                                     v400.clone())
                                                                                                } else {
                                                                                                    let v410:
                                                                                                            Array<string> =
                                                                                                        new_array(&[v388]);
                                                                                                    let v411:
                                                                                                            i32 =
                                                                                                        count(v410.clone());
                                                                                                    let v413:
                                                                                                            i32 =
                                                                                                        v411
                                                                                                            +
                                                                                                            count(v387.clone());
                                                                                                    let v414:
                                                                                                            Array<string> =
                                                                                                        new_init(&string(""),
                                                                                                                 v413);
                                                                                                    let v415:
                                                                                                            LrcPtr<Spiral_builder::Mut4> =
                                                                                                        LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                             MutCell::new(0_i32),});
                                                                                                    while Spiral_builder::method12(v413,
                                                                                                                                   v415.clone())
                                                                                                          {
                                                                                                        let v417:
                                                                                                                i32 =
                                                                                                            v415.l0.get().clone();
                                                                                                        let v422:
                                                                                                                string =
                                                                                                            if v417
                                                                                                                   <
                                                                                                                   v411
                                                                                                               {
                                                                                                                v410[v417].clone()
                                                                                                            } else {
                                                                                                                let v420:
                                                                                                                        i32 =
                                                                                                                    v417
                                                                                                                        -
                                                                                                                        v411;
                                                                                                                v387[v420].clone()
                                                                                                            };
                                                                                                        v414.get_mut()[v417
                                                                                                                           as
                                                                                                                           usize]
                                                                                                            =
                                                                                                            v422;
                                                                                                        {
                                                                                                            let v423:
                                                                                                                    i32 =
                                                                                                                v417
                                                                                                                    +
                                                                                                                    1_i32;
                                                                                                            v415.l0.set(v423);
                                                                                                            ()
                                                                                                        }
                                                                                                    }
                                                                                                    (0_i32,
                                                                                                     v414.clone())
                                                                                                }
                                                                                    } else {
                                                                                        (v386
                                                                                                     -
                                                                                                     1_i32,
                                                                                                 v387.clone())
                                                                                    }
                                                                                }
                                                                            };
                                                                            let v433: i32 =
                                                                                v382 + 1_i32;
                                                                            v380.l0.set(v433);
                                                                            v380.l1.set(
                                                                                patternInput_4
                                                                                    .0
                                                                                    .clone(),
                                                                            );
                                                                            v380.l2.set(
                                                                                patternInput_4
                                                                                    .1
                                                                                    .clone(),
                                                                            );
                                                                            ()
                                                                        }
                                                                        {
                                                                            let matchValue_6: i32 =
                                                                                v380.l1
                                                                                    .get()
                                                                                    .clone();
                                                                            let v435: Array<
                                                                                string,
                                                                            > = v380
                                                                                .l2
                                                                                .get()
                                                                                .clone();
                                                                            let v436: LrcPtr<
                                                                                dyn IEnumerable_1<
                                                                                    string,
                                                                                >,
                                                                            > = delay(Func0::new(
                                                                                {
                                                                                    let v435 = v435
                                                                                        .clone();
                                                                                    move || {
                                                                                        map(Func1::new({
                                                                                                                                let v435
                                                                                                                                    =
                                                                                                                                    v435.clone();
                                                                                                                                move
                                                                                                                                    |i_1:
                                                                                                                                         i32|
                                                                                                                                    v435[i_1].clone()
                                                                                                                            }),
                                                                                                                 rangeNumeric(0_i32,
                                                                                                                              1_i32,
                                                                                                                              count(v435.clone())
                                                                                                                                  -
                                                                                                                                  1_i32))
                                                                                    }
                                                                                },
                                                                            ));
                                                                            let _v437: MutCell<
                                                                                Option<char>,
                                                                            > = MutCell::new(
                                                                                None::<char>,
                                                                            );
                                                                            {
                                                                                let x_23:
                                                                                            char =
                                                                                        std::path::MAIN_SEPARATOR;
                                                                                _v437
                                                                                    .set(Some(x_23))
                                                                            }
                                                                            join(Spiral_builder::method30(ofChar(getValue(_v437.get().clone()))),
                                                                                     toArray_1(v436))
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    } else {
                                                        let v453: Result<
                                                            std::path::PathBuf,
                                                            std::io::Error,
                                                        > = std::fs::canonicalize(&*v306);
                                                        let v455: std::path::PathBuf =
                                                            v453.unwrap();
                                                        let v457: std::path::Display =
                                                            v455.display();
                                                        let _v458: MutCell<
                                                            Option<std::string::String>,
                                                        > = MutCell::new(
                                                            None::<std::string::String>,
                                                        );
                                                        {
                                                            let x_24: std::string::String =
                                                                format!("{}", v457);
                                                            _v458.set(Some(x_24))
                                                        }
                                                        {
                                                            let v468: std::string::String =
                                                                getValue(_v458.get().clone());
                                                            fable_library_rust::String_::fromString(
                                                                v468,
                                                            )
                                                        }
                                                    };
                                                    _v305.set(Some(x_25))
                                                }
                                                {
                                                    let v479: string =
                                                        getValue(_v305.get().clone());
                                                    let _v480: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let v482: &str = &*v479;
                                                    let v484: std::string::String =
                                                        String::from(v482);
                                                    let v486: std::path::PathBuf =
                                                        std::path::PathBuf::from(v484);
                                                    let v488: Option<&std::ffi::OsStr> =
                                                        v486.file_name();
                                                    let v490: &std::ffi::OsStr = v488.unwrap();
                                                    let v492: std::ffi::OsString =
                                                        v490.to_os_string();
                                                    let v494: Option<&str> = v492.to_str();
                                                    let v496: &str = v494.unwrap();
                                                    let v498: std::string::String =
                                                        String::from(v496);
                                                    {
                                                        let x_26: string =
                                                            fable_library_rust::String_::fromString(
                                                                v498,
                                                            );
                                                        _v480.set(Some(x_26))
                                                    }
                                                    {
                                                        let v507: string =
                                                            getValue(_v480.get().clone());
                                                        let v509: bool = true;
                                                        let _result = v129.into_iter().map(|x| { //;
                                                        let v511:
                                                                std::string::String =
                                                            x;
                                                        let v513: string =
                                                            fable_library_rust::String_::fromString(v511);
                                                        let v517: string =
                                                            if contains(v513.clone(),
                                                                        string("="))
                                                               {
                                                                v513.clone()
                                                            } else {
                                                                sprintf!("{}=\"*\"",
                                                                         v513)
                                                            };
                                                        let v519: bool =
                                                            true; v517 }).collect::<Vec<_>>();
                                                        let v521: Vec<string> = _result;
                                                        let v523:
                                                                Array<string> =
                                                            fable_library_rust::NativeArray_::array_from(v521);
                                                        let v524: LrcPtr<
                                                            dyn IEnumerable_1<string>,
                                                        > = delay(Func0::new({
                                                            let v523 = v523.clone();
                                                            move || {
                                                                map(
                                                                    Func1::new({
                                                                        let v523 = v523.clone();
                                                                        move |i_2: i32| {
                                                                            v523[i_2].clone()
                                                                        }
                                                                    }),
                                                                    rangeNumeric(
                                                                        0_i32,
                                                                        1_i32,
                                                                        count(v523.clone()) - 1_i32,
                                                                    ),
                                                                )
                                                            }
                                                        }));
                                                        let v531: string =
                                                            string("[workspace]\nresolver = \"2\"\nmembers = [\"packages/*\"]\n\n[workspace.dependencies]\nfable_library_rust = { path = \"../../../../lib/rust/fable/fable_modules/fable-library-rust\", default-features = false, features = [\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"] }\ninline_colorization = \"~0.1\"\n\n");
                                                        new_array(&[(string("cargo_toml_content"),
                                                                     sprintf!("[package]\nname = \"spiral_builder_{}\"\nversion = \"0.0.1\"\nedition = \"2021\"\n\n[dependencies]\nfable_library_rust = {{ workspace = true }}\ninline_colorization = {{ workspace = true }}\n{}\n\n[[bin]]\nname = \"spiral_builder_{}\"\npath = \"spiral_eval.rs\" ",
                                                                              v507.clone(),
                                                                              join(Spiral_builder::method32(),
                                                                                   toArray_1(v524)),
                                                                              v507)),
                                                                    (string("workspace_cargo_toml_content"),
                                                                     v531)])
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            } else {
                                if fable_library_rust::String_::fromString(v12.clone())
                                    == string("rust")
                                {
                                    let v538: string = Spiral_builder::method33();
                                    let v540: &str = &*v538;
                                    let v542: Option<Vec<std::string::String>> =
                                        clap::ArgMatches::get_many(&v13.clone(), v540)
                                            .map(|x| x.cloned().into_iter().collect());
                                    let _v543: LrcPtr<MutCell<Option<Spiral_builder::US6>>> =
                                        refCell(None::<Spiral_builder::US6>);
                                    {
                                        let x_29: Option<Spiral_builder::US6> = match &v542 {
                                            None => None::<Spiral_builder::US6>,
                                            Some(v542_0_0) => {
                                                let x_27: Vec<std::string::String> =
                                                    v542_0_0.clone();
                                                Some((Func0::new({
                                                    let x_27 = x_27.clone();
                                                    move || Spiral_builder::US6::US6_0(x_27.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v543.set(x_29)
                                    }
                                    {
                                        let v548: Spiral_builder::US6 = defaultValue(
                                            Spiral_builder::US6::US6_1,
                                            _v543.get().clone(),
                                        );
                                        let v551: Vec<std::string::String> =
                                            new_empty::<std::string::String>().to_vec();
                                        let v554: Vec<std::string::String> = match &v548 {
                                            Spiral_builder::US6::US6_0(v548_0_0) => match &v548 {
                                                Spiral_builder::US6::US6_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => v551,
                                        };
                                        let v556: Result<std::string::String, serde_json::Error> =
                                            serde_json::to_string(&v554);
                                        let v558: std::string::String = v556.unwrap();
                                        new_array(&[(
                                            string("deps"),
                                            fable_library_rust::String_::fromString(v558),
                                        )])
                                    }
                                } else {
                                    if fable_library_rust::String_::fromString(v12.clone())
                                        == string("dib")
                                    {
                                        let v567: string = Spiral_builder::method8();
                                        let v569: &str = &*v567;
                                        let v573: Option<string> = map_1(
                                            Func1::new(move |v_1: std::string::String| {
                                                Spiral_builder::closure12((), v_1)
                                            }),
                                            clap::ArgMatches::get_one(&v13.clone(), v569).cloned(),
                                        );
                                        let v575: string = v573.unwrap();
                                        let v576: string = Spiral_builder::method36();
                                        let v578: &str = &*v576;
                                        let v581: u8 = defaultValue(
                                            1_u8,
                                            clap::ArgMatches::get_one(&v13.clone(), v578).cloned(),
                                        );
                                        let v582: string = Spiral_builder::method37();
                                        let v584: &str = &*v582;
                                        let patternInput_6: (i32, string) =
                                            Spiral_builder::method38(
                                                clap::ArgMatches::get_one(&v13, v584).cloned(),
                                                v581,
                                                v575.clone(),
                                                1_u8,
                                            );
                                        let v589: string = patternInput_6.1.clone();
                                        let v588: i32 = patternInput_6.0.clone();
                                        let patternInput_9: (i32, string) = if v588 != 0_i32 {
                                            (v588, v589.clone())
                                        } else {
                                            let patternInput_7:
                                                        (i32, string) =
                                                    Spiral_builder::method39(None::<CancellationToken>,
                                                                             sprintf!("jupyter nbconvert \"{}.ipynb\" --to html --HTMLExporter.theme=dark",
                                                                                      v575.clone()),
                                                                             new_empty::<(string,
                                                                                          string)>(),
                                                                             None::<Func1<(bool,
                                                                                           string,
                                                                                           i32),
                                                                                          Arc<Async<()>>>>,
                                                                             None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                          ()>>,
                                                                             true,
                                                                             None::<string>);
                                            let v599: string = patternInput_7.1.clone();
                                            let v598: i32 = patternInput_7.0.clone();
                                            Spiral_builder::method4(
                                                Spiral_builder::US0::US0_1,
                                                Func0::new(move || {
                                                    Spiral_builder::closure41((), ())
                                                }),
                                                Func0::new({
                                                    let v598 = v598.clone();
                                                    let v599 = v599.clone();
                                                    move || {
                                                        Spiral_builder::closure42(
                                                            v599.clone(),
                                                            v598,
                                                            (),
                                                        )
                                                    }
                                                }),
                                            );
                                            if v598 != 0_i32 {
                                                (
                                                    v598,
                                                    sprintf!(
                                                        "repl_result: {}\n\njupyter_result: {}",
                                                        v589.clone(),
                                                        v599.clone()
                                                    ),
                                                )
                                            } else {
                                                let patternInput_8:
                                                            (i32, string) =
                                                        Spiral_builder::method39(None::<CancellationToken>,
                                                                                 sprintf!("pwsh -c \"$counter = 1; $path = \'{}.html\'; (Get-Content $path -Raw) -replace \'(id=\\\"cell-id=)[a-fA-F0-9]{{8}}\', {{ $_.Groups[1].Value + $counter++ }} | Set-Content $path\"",
                                                                                          replace(v575.clone(),
                                                                                                  string("\'"),
                                                                                                  string("\'\'"))),
                                                                                 new_empty::<(string,
                                                                                              string)>(),
                                                                                 None::<Func1<(bool,
                                                                                               string,
                                                                                               i32),
                                                                                              Arc<Async<()>>>>,
                                                                                 None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                              ()>>,
                                                                                 true,
                                                                                 None::<string>);
                                                let v616: string = patternInput_8.1.clone();
                                                let v615: i32 = patternInput_8.0.clone();
                                                Spiral_builder::method4(
                                                    Spiral_builder::US0::US0_1,
                                                    Func0::new(move || {
                                                        Spiral_builder::closure43((), ())
                                                    }),
                                                    Func0::new({
                                                        let v615 = v615.clone();
                                                        let v616 = v616.clone();
                                                        move || {
                                                            Spiral_builder::closure44(
                                                                v616.clone(),
                                                                v615,
                                                                (),
                                                            )
                                                        }
                                                    }),
                                                );
                                                {
                                                    let v620: string =
                                                        sprintf!("{}.html", v575.clone());
                                                    let _v621: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let _v622: MutCell<Option<Vec<u8>>> =
                                                        MutCell::new(None::<Vec<u8>>);
                                                    {
                                                        let x_30: Vec<u8> =
                                                            std::fs::read(&*v620).unwrap();
                                                        _v622.set(Some(x_30))
                                                    }
                                                    {
                                                        let v632: Vec<u8> =
                                                            getValue(_v622.get().clone());
                                                        let v634: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v632);
                                                        let v636: std::string::String =
                                                            v634.unwrap();
                                                        {
                                                            let x_31:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v636);
                                                            _v621.set(Some(x_31))
                                                        }
                                                        {
                                                            let v647: string = replace(
                                                                getValue(_v621.get().clone()),
                                                                string("\r\n"),
                                                                string("\n"),
                                                            );
                                                            let v648: string =
                                                                sprintf!("{}.html", v575.clone());
                                                            let _v649: MutCell<Option<()>> =
                                                                MutCell::new(None::<()>);
                                                            std::fs::write(&*v648, &*v647).unwrap();
                                                            _v649.set(Some(()));
                                                            getValue(_v649.get().clone());
                                                            {
                                                                let v652: string = sprintf!(
                                                                    "{}.ipynb",
                                                                    v575.clone()
                                                                );
                                                                let _v653: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let _v654: MutCell<
                                                                    Option<Vec<u8>>,
                                                                > = MutCell::new(None::<Vec<u8>>);
                                                                {
                                                                    let x_33: Vec<u8> =
                                                                        std::fs::read(&*v652)
                                                                            .unwrap();
                                                                    _v654.set(Some(x_33))
                                                                }
                                                                {
                                                                    let v664: Vec<u8> = getValue(
                                                                        _v654.get().clone(),
                                                                    );
                                                                    let v666:
                                                                                Result<std::string::String,
                                                                                       std::string::FromUtf8Error> =
                                                                            std::string::String::from_utf8(v664);
                                                                    let v668: std::string::String =
                                                                        v666.unwrap();
                                                                    {
                                                                        let x_34:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v668);
                                                                        _v653.set(Some(x_34))
                                                                    }
                                                                    {
                                                                        let v679: string = replace(
                                                                            getValue(
                                                                                _v653.get().clone(),
                                                                            ),
                                                                            string("\\r\\n"),
                                                                            string("\\n"),
                                                                        );
                                                                        let v680: string = sprintf!(
                                                                            "{}.ipynb", v575
                                                                        );
                                                                        let _v681: MutCell<
                                                                            Option<()>,
                                                                        > = MutCell::new(
                                                                            None::<()>,
                                                                        );
                                                                        std::fs::write(
                                                                            &*v680, &*v679,
                                                                        )
                                                                        .unwrap();
                                                                        _v681.set(Some(()));
                                                                        getValue(
                                                                            _v681.get().clone(),
                                                                        );
                                                                        (v615,
                                                                             sprintf!("repl_result: {}\n\njupyter_result: {}\n\npwsh_replace_html_result: {}",
                                                                                      v589,
                                                                                      v599.clone(),
                                                                                      v616.clone()))
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        };
                                        let v688: string = patternInput_9.1.clone();
                                        let v687: i32 = patternInput_9.0.clone();
                                        Spiral_builder::method4(
                                            Spiral_builder::US0::US0_1,
                                            Func0::new(move || Spiral_builder::closure45((), ())),
                                            Func0::new({
                                                let v687 = v687.clone();
                                                let v688 = v688.clone();
                                                move || {
                                                    Spiral_builder::closure46(
                                                        v688.clone(),
                                                        v687,
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        if v687 != 0_i32 {
                                            panic!("{}",
                                                   sprintf!("spiral_builder.run / dib / exit_code: {} / result: {} / {}", v687,
         v688.clone(), Spiral_builder::closure6((), ())),);
                                        }
                                        new_array(&[(string("stdio"), v688.clone())])
                                    } else {
                                        Spiral_builder::method4(
                                            Spiral_builder::US0::US0_1,
                                            Func0::new(move || Spiral_builder::closure47((), ())),
                                            Func0::new({
                                                let v12 = v12.clone();
                                                move || Spiral_builder::closure48(v12.clone(), ())
                                            }),
                                        );
                                        new_empty::<(string, string)>()
                                    }
                                }
                            }
                        } else {
                            new_empty::<(string, string)>()
                        };
                        let v707: Vec<(string, string)> = v705.to_vec();
                        let v710: Vec<LrcPtr<(std::string::String, std::string::String)>> = v707
                            .into_iter()
                            .map(|x| {
                                Func1::new(move |arg10_0040_9: (string, string)| {
                                    Spiral_builder::closure49((), arg10_0040_9)
                                })(x.clone())
                            })
                            .collect::<Vec<_>>();
                        let v711: string =
                        string("std::collections::BTreeMap::from_iter(v710.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                        let v712: std::collections::BTreeMap<
                            std::string::String,
                            std::string::String,
                        > = std::collections::BTreeMap::from_iter(
                            v710.iter()
                                .map(|x| x.as_ref())
                                .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                        );
                        let v714: Result<std::string::String, serde_json::Error> =
                            serde_json::to_string(&v712);
                        let v715 = Spiral_builder::method56();
                        let v717: Result<std::string::String, string> = v714.map_err(|x| v715(x));
                        let v719: bool = true;
                        let _result = v717.map(|x| {
                            //;
                            let v721: std::string::String = x;
                            let v723: string = fable_library_rust::String_::fromString(v721);
                            let v725: bool = true;
                            v723
                        });
                        let v728: Result<string, string> = Spiral_builder::method57(_result);
                        let v737: string = string("v728 }}}); {{ //");
                        v728
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
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            if Spiral_builder::State::trace_state().get().clone().is_none() {
                Spiral_builder::State::trace_state().set(Some(Spiral_builder::closure2(
                    (),
                    Spiral_builder::US0::US0_0,
                )));
            }
            {
                let v5: LrcPtr<Spiral_builder::Mut2> =
                    (getValue(Spiral_builder::State::trace_state().get().clone()))
                        .2
                        .clone();
                let v8: clap::Command = Spiral_builder::method0();
                let v10: clap::ArgMatches = clap::Command::get_matches(v8);
                let v11: string = Spiral_builder::method3();
                let v13: &str = &*v11;
                let v15: Option<std::string::String> =
                    clap::ArgMatches::get_one(&v10.clone(), v13).cloned();
                let _v16: LrcPtr<MutCell<Option<Spiral_builder::US2>>> =
                    refCell(None::<Spiral_builder::US2>);
                {
                    let x_2: Option<Spiral_builder::US2> = match &v15 {
                        None => None::<Spiral_builder::US2>,
                        Some(v15_0_0) => {
                            let x: std::string::String = v15_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Spiral_builder::US2::US2_0(x.clone())
                            }))())
                        }
                    };
                    _v16.set(x_2)
                }
                {
                    let v21: Spiral_builder::US2 =
                        defaultValue(Spiral_builder::US2::US2_1, _v16.get().clone());
                    let v28: Spiral_builder::US3 = match &v21 {
                        Spiral_builder::US2::US2_0(v21_0_0) => Spiral_builder::US3::US3_0(
                            fable_library_rust::String_::fromString(match &v21 {
                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                        ),
                        _ => Spiral_builder::US3::US3_1,
                    };
                    match &v28 {
                        Spiral_builder::US3::US3_0(v28_0_0) => {
                            let v29: string = match &v28 {
                                Spiral_builder::US3::US3_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v46: Spiral_builder::US0 = if string("Verbose") == v29.clone() {
                                Spiral_builder::US0::US0_0
                            } else {
                                if string("Debug") == v29.clone() {
                                    Spiral_builder::US0::US0_1
                                } else {
                                    if string("Info") == v29.clone() {
                                        Spiral_builder::US0::US0_2
                                    } else {
                                        if string("Warning") == v29.clone() {
                                            Spiral_builder::US0::US0_3
                                        } else {
                                            if string("Critical") == v29.clone() {
                                                Spiral_builder::US0::US0_4
                                            } else {
                                                panic!(
                                                    "{}",
                                                    sprintf!("of_string trace_level / x: {}", v29),
                                                )
                                            }
                                        }
                                    }
                                }
                            };
                            v5.l0.set(v46);
                            ()
                        }
                        _ => (),
                    }
                    Spiral_builder::method4(
                        Spiral_builder::US0::US0_1,
                        Func0::new(move || Spiral_builder::closure4((), ())),
                        Func0::new({
                            let v0_1 = v0_1.clone();
                            move || Spiral_builder::closure5(v0_1.clone(), ())
                        }),
                    );
                    {
                        let v50: std::pin::Pin<
                            Box<dyn std::future::Future<Output = Result<string, string>>>,
                        > = Spiral_builder::method7(v10);
                        let v52: Result<string, string> = futures_lite::future::block_on(v50);
                        let v54: string = v52.unwrap();
                        if if let Spiral_builder::US0::US0_2 = &v5.l0.get().clone() {
                            true
                        } else {
                            false
                        } {
                            printfn!("{0}", v54);
                            ()
                        }
                        0_i32
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
