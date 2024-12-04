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
        use fable_library_rust::Array_::skip;
        use fable_library_rust::Array_::skipWhile;
        use fable_library_rust::Array_::tryItem;
        use fable_library_rust::Async_::Async;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::Encoding_::get_UTF8;
        use fable_library_rust::Encoding_::Encoding;
        use fable_library_rust::Exception_::try_catch;
        use fable_library_rust::Guid_::new_guid;
        use fable_library_rust::Guid_::parse;
        use fable_library_rust::Guid_::Guid;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::item;
        use fable_library_rust::List_::length as length_1;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
        use fable_library_rust::List_::List;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::NativeArray_::count as count_2;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::defaultOf;
        use fable_library_rust::Native_::interface_cast;
        use fable_library_rust::Native_::refCell;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::Lrc;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::getValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
        use fable_library_rust::Seq_::ofArray as ofArray_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::indexOf;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::replicate;
        use fable_library_rust::String_::split;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::startsWith;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::toString;
        use fable_library_rust::String_::toUpper;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::Interfaces_::System::IDisposable;
        use fable_library_rust::System::Exception;
        use fable_library_rust::System::Text::StringBuilder;
        type CancellationToken = ();
        type TaskCanceledException = ();
        type TimeZoneInfo = i64;
        pub mod TraceState {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Spiral_builder::Mut0>,
                        LrcPtr<Spiral_builder::Mut1>,
                        LrcPtr<Spiral_builder::Mut2>,
                        LrcPtr<Spiral_builder::Mut3>,
                        LrcPtr<Spiral_builder::Mut4>,
                        Option<i64>,
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
                                LrcPtr<Spiral_builder::Mut3>,
                                LrcPtr<Spiral_builder::Mut4>,
                                Option<i64>,
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
                                LrcPtr<Spiral_builder::Mut3>,
                                LrcPtr<Spiral_builder::Mut4>,
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
        #[derive(Clone, Debug)]
        pub struct Disposable {
            f: Func0<()>,
        }
        impl Spiral_builder::Disposable {
            pub fn _ctor__3A5B6456(f: Func0<()>) -> LrcPtr<Spiral_builder::Disposable> {
                let f_1;
                ();
                f_1 = f;
                ();
                LrcPtr::new(Spiral_builder::Disposable { f: f_1 })
            }
        }
        impl core::fmt::Display for Spiral_builder::Disposable {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        impl IDisposable for Disposable {
            fn Dispose(&self) {
                (self.f)();
            }
        }
        pub trait ICryptoCreateHash {
            fn createHash(&self, x: string) -> LrcPtr<dyn Any>;
        }
        impl<V: ICryptoCreateHash + Clone + 'static> ICryptoCreateHash for LrcPtr<V> {
            #[inline]
            fn createHash(&self, x: string) -> LrcPtr<dyn Any> {
                (**self).createHash(x)
            }
        }
        pub trait IHashlibSha256 {
            fn sha256(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IHashlibSha256 + Clone + 'static> IHashlibSha256 for LrcPtr<V> {
            #[inline]
            fn sha256(&self) -> LrcPtr<dyn Any> {
                (**self).sha256()
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
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Spiral_builder::Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Spiral_builder::Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Spiral_builder::Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut4 {
            pub l0: MutCell<Spiral_builder::US0>,
        }
        impl core::fmt::Display for Spiral_builder::Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(Spiral_builder::US0),
            US1_1,
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
        impl core::fmt::Display for Spiral_builder::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
        }
        impl core::fmt::Display for Spiral_builder::US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US4 {
            US4_0(Spiral_builder::US3),
            US4_1(Spiral_builder::US3),
            US4_2(Spiral_builder::US3),
            US4_3(Spiral_builder::US3),
            US4_4(Spiral_builder::US3),
        }
        impl core::fmt::Display for Spiral_builder::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US5 {
            US5_0(string),
            US5_1,
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
        impl core::fmt::Display for Spiral_builder::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(std::string::String),
            US7_1,
        }
        impl core::fmt::Display for Spiral_builder::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US10 {
            US10_0,
            US10_1,
        }
        impl core::fmt::Display for Spiral_builder::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US9 {
            US9_0(Spiral_builder::US10),
            US9_1,
        }
        impl core::fmt::Display for Spiral_builder::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0(Spiral_builder::US9),
            US8_1,
        }
        impl core::fmt::Display for Spiral_builder::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(Vec<std::string::String>),
            US11_1,
        }
        impl core::fmt::Display for Spiral_builder::US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US12 {
            US12_0(string),
            US12_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0,
            US13_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_builder::US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US14 {
            US14_0(string, Spiral_builder::US5),
            US14_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US15_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US15 {
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
            UH0_1(char, LrcPtr<Spiral_builder::UH0>),
        }
        impl core::fmt::Display for Spiral_builder::UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Spiral_builder::US15>,
                LrcPtr<Spiral_builder::UH1>,
            ),
        }
        impl core::fmt::Display for Spiral_builder::UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US16_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US17 {
            US17_0(char),
            US17_1,
        }
        impl core::fmt::Display for Spiral_builder::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0(string, LrcPtr<StringBuilder>, i32, i32),
            US18_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(
                string,
                Spiral_builder::US5,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US19_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(
                Spiral_builder::US17,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US20_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(Spiral_builder::US5, string, LrcPtr<StringBuilder>, i32, i32),
            US21_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US22 {
            US22_0(Array<string>),
            US22_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH2 {
            UH2_0,
            UH2_1(string, LrcPtr<Spiral_builder::UH2>),
        }
        impl core::fmt::Display for Spiral_builder::UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(
                LrcPtr<Spiral_builder::UH2>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US23_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Spiral_builder::US16>,
                LrcPtr<Spiral_builder::UH3>,
            ),
        }
        impl core::fmt::Display for Spiral_builder::UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US24_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_builder::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US25_1,
        }
        impl core::fmt::Display for Spiral_builder::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(std::string::String),
            US26_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_builder::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US27_1,
        }
        impl core::fmt::Display for Spiral_builder::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US28_1,
        }
        impl core::fmt::Display for Spiral_builder::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(std::process::Output),
            US29_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_builder::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US30 {
            US30_0(i32),
            US30_1,
        }
        impl core::fmt::Display for Spiral_builder::US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US31_1,
        }
        impl core::fmt::Display for Spiral_builder::US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US32 {
            US32_0(CancellationToken),
            US32_1,
        }
        impl core::fmt::Display for Spiral_builder::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0(std::path::PathBuf),
            US33_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(std::path::PathBuf),
            US34_1,
        }
        impl core::fmt::Display for Spiral_builder::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Default, PartialEq, PartialOrd, Hash, Eq)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Spiral_builder::Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US36 {
            US36_0(string),
            US36_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US35 {
            US35_0(Spiral_builder::US36),
            US35_1,
        }
        impl core::fmt::Display for Spiral_builder::US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US37 {
            US37_0,
            US37_1,
            US37_2,
        }
        impl core::fmt::Display for Spiral_builder::US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US38 {
            US38_0(Spiral_builder::US37),
            US38_1,
        }
        impl core::fmt::Display for Spiral_builder::US38 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US39 {
            US39_0(chrono::DateTime<chrono::Utc>),
            US39_1,
        }
        impl core::fmt::Display for Spiral_builder::US39 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US40 {
            US40_0(i32, string),
            US40_1(i32, string),
        }
        impl core::fmt::Display for Spiral_builder::US40 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US41 {
            US41_0(std::collections::HashMap<string, string>),
            US41_1,
        }
        impl core::fmt::Display for Spiral_builder::US41 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US42 {
            US42_0(Spiral_builder::US5),
            US42_1,
        }
        impl core::fmt::Display for Spiral_builder::US42 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH4 {
            UH4_0,
            UH4_1(string, bool, LrcPtr<Spiral_builder::UH4>),
        }
        impl core::fmt::Display for Spiral_builder::UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US43 {
            US43_0(std::fs::FileType),
            US43_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_builder::US43 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US44 {
            US44_0,
            US44_1,
            US44_2,
        }
        impl core::fmt::Display for Spiral_builder::US44 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US45 {
            US45_0(async_walkdir::DirEntry),
            US45_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_builder::US45 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US46 {
            US46_0(string, string),
            US46_1,
        }
        impl core::fmt::Display for Spiral_builder::US46 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH5 {
            UH5_0,
            UH5_1(string, string, LrcPtr<Spiral_builder::UH5>),
        }
        impl core::fmt::Display for Spiral_builder::UH5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: clap::Command = clap::Command::subcommand_required(v4, true);
            let v8: string = string("r#\"fsharp\"#");
            let v9: &'static str = r#"fsharp"#;
            let v11: clap::Command = clap::Command::new(v9);
            let v13: string = string("r#\"spi-path\"#");
            let v14: &'static str = r#"spi-path"#;
            let v16: clap::Arg = clap::Arg::new(v14);
            let v18: clap::Arg = v16.short('s');
            let v19: string = string("r#\"spi-path\"#");
            let v20: &'static str = r#"spi-path"#;
            let v22: clap::Arg = v18.long(v20);
            let v24: clap::Arg = v22.required(true);
            let v26: clap::Command = clap::Command::arg(v11, v24);
            let v28: clap::Command = clap::Command::subcommand(v6, v26);
            let v30: string = string("r#\"cuda\"#");
            let v31: &'static str = r#"cuda"#;
            let v33: clap::Command = clap::Command::new(v31);
            let v35: string = string("r#\"py-path\"#");
            let v36: &'static str = r#"py-path"#;
            let v38: clap::Arg = clap::Arg::new(v36);
            let v40: clap::Arg = v38.short('p');
            let v41: string = string("r#\"py-path\"#");
            let v42: &'static str = r#"py-path"#;
            let v44: clap::Arg = v40.long(v42);
            let v46: clap::Arg = v44.required(true);
            let v48: clap::Command = clap::Command::arg(v33, v46);
            let v50: string = string("r#\"env\"#");
            let v51: &'static str = r#"env"#;
            let v53: clap::Arg = clap::Arg::new(v51);
            let v55: clap::Arg = v53.short('e');
            let v56: string = string("r#\"env\"#");
            let v57: &'static str = r#"env"#;
            let v59: clap::Arg = v55.long(v57);
            let v70: Array<string> =
                toArray(ofArray(new_array(&[string("Pip"), string("Poetry")])));
            let v74: Vec<string> = v70.to_vec();
            let v76: bool = true;
            let _vec_map: Vec<_> = v74
                .into_iter()
                .map(|x| {
                    //;
                    let v78: string = x;
                    let v81: &str = &*v78;
                    let v105: std::string::String = String::from(v81);
                    let v128: Box<std::string::String> = Box::new(v105);
                    let v130: &'static mut std::string::String = Box::leak(v128);
                    let v132: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v130);
                    let v134: bool = true;
                    v132
                })
                .collect::<Vec<_>>();
            let v136: Vec<clap::builder::PossibleValue> = _vec_map;
            let v138: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v136),
            );
            let v140: clap::Arg = v59.value_parser(v138);
            let v142: clap::Command = clap::Command::arg(v48, v140);
            let v144: string = string("r#\"NAME\"#");
            let v147: string = string("r#\"VERSION\"#");
            let v149: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v150: usize = 1_i32 as usize;
            let v153: usize = 0_i32 as usize;
            let v167: clap::builder::ValueRange = if v153 == 0_i32 as usize {
                clap::builder::ValueRange::new(v150..)
            } else {
                let v165: string = string("clap::builder::ValueRange::new($0..$1)");
                clap::builder::ValueRange::new(v150..v153)
            };
            let v169: string = string("r#\"deps\"#");
            let v170: &'static str = r#"deps"#;
            let v172: clap::Arg = clap::Arg::new(v170);
            let v174: clap::Arg = v172.short('d');
            let v175: string = string("r#\"deps\"#");
            let v176: &'static str = r#"deps"#;
            let v178: clap::Arg = v174.long(v176);
            let v180: Vec<&'static str> = v149.to_vec();
            let v182: clap::Arg = v178.value_names(v180);
            let v184: clap::Arg = v182.num_args(v167);
            let v186: clap::ArgAction = clap::ArgAction::Append;
            let v188: clap::Arg = v184.action(v186);
            let v190: clap::Command = clap::Command::arg(v142, v188);
            let v192: clap::Command = clap::Command::subcommand(v28, v190);
            let v194: string = string("r#\"fable\"#");
            let v195: &'static str = r#"fable"#;
            let v197: clap::Command = clap::Command::new(v195);
            let v199: string = string("r#\"fs-path\"#");
            let v200: &'static str = r#"fs-path"#;
            let v202: clap::Arg = clap::Arg::new(v200);
            let v204: clap::Arg = v202.short('f');
            let v205: string = string("r#\"fs-path\"#");
            let v206: &'static str = r#"fs-path"#;
            let v208: clap::Arg = v204.long(v206);
            let v210: clap::Arg = v208.required(true);
            let v212: clap::Command = clap::Command::arg(v197, v210);
            let v213: string = string("r#\"command\"#");
            let v214: &'static str = r#"command"#;
            let v216: clap::Arg = clap::Arg::new(v214);
            let v218: clap::Arg = v216.short('c');
            let v219: string = string("r#\"command\"#");
            let v220: &'static str = r#"command"#;
            let v222: clap::Arg = v218.long(v220);
            let v224: clap::Command = clap::Command::arg(v212, v222);
            let v226: clap::Command = clap::Command::subcommand(v192, v224);
            let v228: string = string("r#\"rust\"#");
            let v229: &'static str = r#"rust"#;
            let v231: clap::Command = clap::Command::new(v229);
            let v232: string = string("r#\"fs-path\"#");
            let v233: &'static str = r#"fs-path"#;
            let v235: clap::Arg = clap::Arg::new(v233);
            let v237: clap::Arg = v235.short('f');
            let v238: string = string("r#\"fs-path\"#");
            let v239: &'static str = r#"fs-path"#;
            let v241: clap::Arg = v237.long(v239);
            let v243: clap::Arg = v241.required(true);
            let v245: clap::Command = clap::Command::arg(v231, v243);
            let v246: string = string("r#\"NAME\"#");
            let v248: string = string("r#\"VERSION\"#");
            let v250: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v251: usize = 1_i32 as usize;
            let v254: usize = 0_i32 as usize;
            let v268: clap::builder::ValueRange = if v254 == 0_i32 as usize {
                clap::builder::ValueRange::new(v251..)
            } else {
                let v266: string = string("clap::builder::ValueRange::new($0..$1)");
                clap::builder::ValueRange::new(v251..v254)
            };
            let v269: string = string("r#\"deps\"#");
            let v270: &'static str = r#"deps"#;
            let v272: clap::Arg = clap::Arg::new(v270);
            let v274: clap::Arg = v272.short('d');
            let v275: string = string("r#\"deps\"#");
            let v276: &'static str = r#"deps"#;
            let v278: clap::Arg = v274.long(v276);
            let v280: Vec<&'static str> = v250.to_vec();
            let v282: clap::Arg = v278.value_names(v280);
            let v284: clap::Arg = v282.num_args(v268);
            let v286: clap::ArgAction = clap::ArgAction::Append;
            let v288: clap::Arg = v284.action(v286);
            let v290: clap::Command = clap::Command::arg(v245, v288);
            let v291: usize = 0_i32 as usize;
            let v294: usize = 1_i32 as usize;
            let v308: clap::builder::ValueRange = if v294 == 0_i32 as usize {
                clap::builder::ValueRange::new(v291..)
            } else {
                let v306: string = string("clap::builder::ValueRange::new($0..=$1)");
                clap::builder::ValueRange::new(v291..=v294)
            };
            let v310: string = string("r#\"wasm\"#");
            let v311: &'static str = r#"wasm"#;
            let v313: clap::Arg = clap::Arg::new(v311);
            let v315: clap::Arg = v313.short('w');
            let v316: string = string("r#\"wasm\"#");
            let v317: &'static str = r#"wasm"#;
            let v319: clap::Arg = v315.long(v317);
            let v321: clap::Arg = v319.num_args(v308);
            let v323: clap::Arg = v321.require_equals(true);
            let v325: string = string("r#\"\"#");
            let v326: &str = r#""#;
            let v328: clap::Arg = v323.default_missing_value(v326);
            let v330: clap::Command = clap::Command::arg(v290, v328);
            let v331: usize = 0_i32 as usize;
            let v334: usize = 1_i32 as usize;
            let v348: clap::builder::ValueRange = if v334 == 0_i32 as usize {
                clap::builder::ValueRange::new(v331..)
            } else {
                let v346: string = string("clap::builder::ValueRange::new($0..=$1)");
                clap::builder::ValueRange::new(v331..=v334)
            };
            let v350: string = string("r#\"contract\"#");
            let v351: &'static str = r#"contract"#;
            let v353: clap::Arg = clap::Arg::new(v351);
            let v355: clap::Arg = v353.short('c');
            let v356: string = string("r#\"contract\"#");
            let v357: &'static str = r#"contract"#;
            let v359: clap::Arg = v355.long(v357);
            let v361: clap::Arg = v359.num_args(v348);
            let v363: clap::Arg = v361.require_equals(true);
            let v364: string = string("r#\"\"#");
            let v365: &str = r#""#;
            let v367: clap::Arg = v363.default_missing_value(v365);
            let v369: clap::Command = clap::Command::arg(v330, v367);
            let v371: string = string("r#\"cleanup\"#");
            let v372: &'static str = r#"cleanup"#;
            let v374: clap::Arg = clap::Arg::new(v372);
            let v376: clap::Arg = v374.short('l');
            let v377: string = string("r#\"cleanup\"#");
            let v378: &'static str = r#"cleanup"#;
            let v380: clap::Arg = v376.long(v378);
            let v382: string = string("r#\"true\"#");
            let v383: &str = r#"true"#;
            let v385: clap::Arg = v380.default_value(v383);
            let v387: clap::ArgAction = clap::ArgAction::SetFalse;
            let v389: clap::Arg = v385.action(v387);
            let v391: clap::Command = clap::Command::arg(v369, v389);
            let v393: clap::Command = clap::Command::subcommand(v226, v391);
            let v395: string = string("r#\"typescript\"#");
            let v396: &'static str = r#"typescript"#;
            let v398: clap::Command = clap::Command::new(v396);
            let v399: string = string("r#\"fs-path\"#");
            let v400: &'static str = r#"fs-path"#;
            let v402: clap::Arg = clap::Arg::new(v400);
            let v404: clap::Arg = v402.short('f');
            let v405: string = string("r#\"fs-path\"#");
            let v406: &'static str = r#"fs-path"#;
            let v408: clap::Arg = v404.long(v406);
            let v410: clap::Arg = v408.required(true);
            let v412: clap::Command = clap::Command::arg(v398, v410);
            let v413: string = string("r#\"NAME\"#");
            let v415: string = string("r#\"VERSION\"#");
            let v417: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v418: usize = 1_i32 as usize;
            let v421: usize = 0_i32 as usize;
            let v434: clap::builder::ValueRange = if v421 == 0_i32 as usize {
                clap::builder::ValueRange::new(v418..)
            } else {
                let v432: string = string("clap::builder::ValueRange::new($0..$1)");
                clap::builder::ValueRange::new(v418..v421)
            };
            let v435: string = string("r#\"deps\"#");
            let v436: &'static str = r#"deps"#;
            let v438: clap::Arg = clap::Arg::new(v436);
            let v440: clap::Arg = v438.short('d');
            let v441: string = string("r#\"deps\"#");
            let v442: &'static str = r#"deps"#;
            let v444: clap::Arg = v440.long(v442);
            let v446: Vec<&'static str> = v417.to_vec();
            let v448: clap::Arg = v444.value_names(v446);
            let v450: clap::Arg = v448.num_args(v434);
            let v452: clap::ArgAction = clap::ArgAction::Append;
            let v454: clap::Arg = v450.action(v452);
            let v456: clap::Command = clap::Command::arg(v412, v454);
            let v458: clap::Command = clap::Command::subcommand(v393, v456);
            let v460: string = string("r#\"python\"#");
            let v461: &'static str = r#"python"#;
            let v463: clap::Command = clap::Command::new(v461);
            let v464: string = string("r#\"fs-path\"#");
            let v465: &'static str = r#"fs-path"#;
            let v467: clap::Arg = clap::Arg::new(v465);
            let v469: clap::Arg = v467.short('f');
            let v470: string = string("r#\"fs-path\"#");
            let v471: &'static str = r#"fs-path"#;
            let v473: clap::Arg = v469.long(v471);
            let v475: clap::Arg = v473.required(true);
            let v477: clap::Command = clap::Command::arg(v463, v475);
            let v478: string = string("r#\"NAME\"#");
            let v480: string = string("r#\"VERSION\"#");
            let v482: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v483: usize = 1_i32 as usize;
            let v486: usize = 0_i32 as usize;
            let v499: clap::builder::ValueRange = if v486 == 0_i32 as usize {
                clap::builder::ValueRange::new(v483..)
            } else {
                let v497: string = string("clap::builder::ValueRange::new($0..$1)");
                clap::builder::ValueRange::new(v483..v486)
            };
            let v500: string = string("r#\"deps\"#");
            let v501: &'static str = r#"deps"#;
            let v503: clap::Arg = clap::Arg::new(v501);
            let v505: clap::Arg = v503.short('d');
            let v506: string = string("r#\"deps\"#");
            let v507: &'static str = r#"deps"#;
            let v509: clap::Arg = v505.long(v507);
            let v511: Vec<&'static str> = v482.to_vec();
            let v513: clap::Arg = v509.value_names(v511);
            let v515: clap::Arg = v513.num_args(v499);
            let v517: clap::ArgAction = clap::ArgAction::Append;
            let v519: clap::Arg = v515.action(v517);
            let v521: clap::Command = clap::Command::arg(v477, v519);
            let v523: clap::Command = clap::Command::subcommand(v458, v521);
            let v525: string = string("r#\"dib\"#");
            let v526: &'static str = r#"dib"#;
            let v528: clap::Command = clap::Command::new(v526);
            let v530: string = string("r#\"path\"#");
            let v531: &'static str = r#"path"#;
            let v533: clap::Arg = clap::Arg::new(v531);
            let v535: clap::Arg = v533.short('p');
            let v536: string = string("r#\"path\"#");
            let v537: &'static str = r#"path"#;
            let v539: clap::Arg = v535.long(v537);
            let v541: clap::Arg = v539.required(true);
            let v543: clap::Command = clap::Command::arg(v528, v541);
            let v545: string = string("clap::value_parser!(u8).into()");
            let v546: clap::builder::ValueParser = clap::value_parser!(u8).into();
            let v548: string = string("r#\"retries\"#");
            let v549: &'static str = r#"retries"#;
            let v551: clap::Arg = clap::Arg::new(v549);
            let v553: clap::Arg = v551.short('r');
            let v554: string = string("r#\"retries\"#");
            let v555: &'static str = r#"retries"#;
            let v557: clap::Arg = v553.long(v555);
            let v559: clap::Arg = v557.value_parser(v546);
            let v561: clap::Command = clap::Command::arg(v543, v559);
            let v563: string = string("r#\"working-directory\"#");
            let v564: &'static str = r#"working-directory"#;
            let v566: clap::Arg = clap::Arg::new(v564);
            let v568: clap::Arg = v566.short('w');
            let v569: string = string("r#\"working-directory\"#");
            let v570: &'static str = r#"working-directory"#;
            let v572: clap::Arg = v568.long(v570);
            let v574: clap::Command = clap::Command::arg(v561, v572);
            clap::Command::subcommand(v523, v574)
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
        pub fn method4() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Spiral_builder::US5 {
            Spiral_builder::US5::US5_0(v0_1)
        }
        pub fn method5() -> Func1<string, Spiral_builder::US5> {
            Func1::new(move |v: string| Spiral_builder::closure3((), v))
        }
        pub fn method3(v0_1: string) -> string {
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
            let v14: string = Spiral_builder::method4();
            v13.unwrap_or(v14)
        }
        pub fn method2() -> (Spiral_builder::US1, Spiral_builder::US2) {
            let v1_1: string = Spiral_builder::method3(string("TRACE_LEVEL"));
            let v6: Spiral_builder::US1 = if string("Verbose") == v1_1.clone() {
                Spiral_builder::US1::US1_0(Spiral_builder::US0::US0_0)
            } else {
                Spiral_builder::US1::US1_1
            };
            (
                match &v6 {
                    Spiral_builder::US1::US1_0(v6_0_0) => Spiral_builder::US1::US1_0(match &v6 {
                        Spiral_builder::US1::US1_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v13: Spiral_builder::US1 = if string("Debug") == v1_1.clone() {
                            Spiral_builder::US1::US1_0(Spiral_builder::US0::US0_1)
                        } else {
                            Spiral_builder::US1::US1_1
                        };
                        match &v13 {
                            Spiral_builder::US1::US1_0(v13_0_0) => {
                                Spiral_builder::US1::US1_0(match &v13 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v20: Spiral_builder::US1 = if string("Info") == v1_1.clone() {
                                    Spiral_builder::US1::US1_0(Spiral_builder::US0::US0_2)
                                } else {
                                    Spiral_builder::US1::US1_1
                                };
                                match &v20 {
                                    Spiral_builder::US1::US1_0(v20_0_0) => {
                                        Spiral_builder::US1::US1_0(match &v20 {
                                            Spiral_builder::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v27: Spiral_builder::US1 = if string("Warning")
                                            == v1_1.clone()
                                        {
                                            Spiral_builder::US1::US1_0(Spiral_builder::US0::US0_3)
                                        } else {
                                            Spiral_builder::US1::US1_1
                                        };
                                        match &v27 {
                                            Spiral_builder::US1::US1_0(v27_0_0) => {
                                                Spiral_builder::US1::US1_0(match &v27 {
                                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v34: Spiral_builder::US1 =
                                                    if string("Critical") == v1_1.clone() {
                                                        Spiral_builder::US1::US1_0(
                                                            Spiral_builder::US0::US0_4,
                                                        )
                                                    } else {
                                                        Spiral_builder::US1::US1_1
                                                    };
                                                match &v34 {
                                                    Spiral_builder::US1::US1_0(v34_0_0) => {
                                                        Spiral_builder::US1::US1_0(match &v34 {
                                                            Spiral_builder::US1::US1_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => Spiral_builder::US1::US1_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if Spiral_builder::method3(string("AUTOMATION")) != string("True") {
                    Spiral_builder::US2::US2_1
                } else {
                    Spiral_builder::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                },
            )
        }
        pub fn closure4(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(
            v0_1: Spiral_builder::US0,
        ) -> (
            LrcPtr<Spiral_builder::Mut0>,
            LrcPtr<Spiral_builder::Mut1>,
            LrcPtr<Spiral_builder::Mut2>,
            LrcPtr<Spiral_builder::Mut3>,
            LrcPtr<Spiral_builder::Mut4>,
            Option<i64>,
        ) {
            let patternInput: (Spiral_builder::US1, Spiral_builder::US2) =
                Spiral_builder::method2();
            let _v1: (Spiral_builder::US1, Spiral_builder::US2) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v132: Spiral_builder::US2 = _v1.1.clone();
            let v131: Spiral_builder::US1 = _v1.0.clone();
            (
                LrcPtr::new(Spiral_builder::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Spiral_builder::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Spiral_builder::closure4((), v))),
                }),
                LrcPtr::new(Spiral_builder::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Spiral_builder::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Spiral_builder::Mut4 {
                    l0: MutCell::new(match &v131 {
                        Spiral_builder::US1::US1_0(v131_0_0) => match &v131 {
                            Spiral_builder::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v132 {
                    Spiral_builder::US2::US2_0(v132_0_0) => Some(match &v132 {
                        Spiral_builder::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) {
            if Spiral_builder::TraceState::trace_state()
                .get()
                .clone()
                .is_none()
            {
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = Spiral_builder::method1(Spiral_builder::US0::US0_0);
                Spiral_builder::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn method6(v0_1: Spiral_builder::US0) -> bool {
            let v3: () = {
                Spiral_builder::closure2((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_builder::Mut0>,
                LrcPtr<Spiral_builder::Mut1>,
                LrcPtr<Spiral_builder::Mut2>,
                LrcPtr<Spiral_builder::Mut3>,
                LrcPtr<Spiral_builder::Mut4>,
                Option<i64>,
            ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
            let v35: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if (patternInput.2.clone()).l0.get().clone() == false {
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
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                    ])))),
                )
            }
        }
        pub fn closure6(unitVar: (), v0_1: i64) -> Spiral_builder::US2 {
            Spiral_builder::US2::US2_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Spiral_builder::US2> {
            Func1::new(move |v: i64| Spiral_builder::closure6((), v))
        }
        pub fn method9() -> string {
            string("hh:mm:ss")
        }
        pub fn method10() -> string {
            string("HH:mm:ss")
        }
        pub fn method7(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v20: Spiral_builder::US2 = defaultValue(
                Spiral_builder::US2::US2_1,
                map(Spiral_builder::method8(), v5),
            );
            let v117: DateTime = match &v20 {
                Spiral_builder::US2::US2_0(v20_0_0) => {
                    let v77: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v20 {
                            Spiral_builder::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v77.hours(),
                        v77.minutes(),
                        v77.seconds(),
                        v77.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v118: string = Spiral_builder::method9();
            let provider: string = if v118.clone() == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v118
            };
            v117.toString(provider)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure7(v0_1: LrcPtr<Spiral_builder::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method12(v0_1: char) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v8: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v6: string = Spiral_builder::method12(getCharAt(toLower(string("Debug")), 0_i32));
            let v9: &str = inline_colorization::color_bright_blue;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method16(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("args")), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            let v47: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method17(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method15(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Array<string>,
        ) -> string {
            let v9: string = Spiral_builder::method16(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.main"),
                v9
            ))
        }
        pub fn closure8(v0_1: LrcPtr<Spiral_builder::Mut0>, unitVar: ()) {
            let v2: i64 = v0_1.l0.get().clone() + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure10(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure9(unitVar: (), v0_1: string) {
            let v3: () = {
                Spiral_builder::closure10(v0_1, ());
                ()
            };
            ()
        }
        pub fn method18(v0_1: string) {
            let v3: () = {
                Spiral_builder::closure2((), ());
                ()
            };
            let patternInput: (
                LrcPtr<Spiral_builder::Mut0>,
                LrcPtr<Spiral_builder::Mut1>,
                LrcPtr<Spiral_builder::Mut2>,
                LrcPtr<Spiral_builder::Mut3>,
                LrcPtr<Spiral_builder::Mut4>,
                Option<i64>,
            ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
            let v37: () = {
                Spiral_builder::closure8(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method15(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method11(),
                    v0_1,
                ))
            };
        }
        pub fn closure11(unitVar: (), v0_1: &str) -> std::string::String {
            String::from(v0_1)
        }
        pub fn closure12(
            unitVar: (),
            _arg: (std::string::String, clap::ArgMatches),
        ) -> Spiral_builder::US6 {
            Spiral_builder::US6::US6_0(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method20() -> Func1<(std::string::String, clap::ArgMatches), Spiral_builder::US6> {
            Func1::new(move |arg10_0040: (std::string::String, clap::ArgMatches)| {
                Spiral_builder::closure12((), arg10_0040)
            })
        }
        pub fn method21() -> string {
            string("py-path")
        }
        pub fn closure13(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US7 {
            Spiral_builder::US7::US7_0(v0_1)
        }
        pub fn method22() -> Func1<std::string::String, Spiral_builder::US7> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure13((), v))
        }
        pub fn method23() -> string {
            string("env")
        }
        pub fn method24() -> string {
            string("deps")
        }
        pub fn closure14(unitVar: (), v0_1: Vec<std::string::String>) -> Spiral_builder::US11 {
            Spiral_builder::US11::US11_0(v0_1)
        }
        pub fn method25() -> Func1<Vec<std::string::String>, Spiral_builder::US11> {
            Func1::new(move |v: Vec<std::string::String>| Spiral_builder::closure14((), v))
        }
        pub fn method26(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method29(v0_1: string) -> string {
            v0_1
        }
        pub fn method28(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Spiral_builder::method29(v0_1))
        }
        pub fn method27(v0_1: string, v1_1: string) -> string {
            let v5: &str = &*v0_1;
            let v29: std::string::String = String::from(v5);
            let v53: std::path::PathBuf = std::path::PathBuf::from(v29);
            let v77: &str = &*v1_1;
            let v101: std::string::String = String::from(v77);
            let v124: std::path::PathBuf = v53.join(v101);
            let v127: std::path::Display = v124.display();
            let v151: std::string::String = format!("{}", v127);
            fable_library_rust::String_::fromString(v151)
        }
        pub fn method31(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v69: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v69.clone().exists() {
                v69.is_dir()
            } else {
                false
            }
        }
        pub fn method33(v0_1: string) -> Option<string> {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            let v75: Option<std::path::PathBuf> = v52.parent().map(std::path::PathBuf::from);
            let v77: bool = true;
            let _optionm_map_ = v75.map(|x| {
                //;
                let v79: std::path::PathBuf = x;
                let v82: std::path::Display = v79.display();
                let v106: std::string::String = format!("{}", v82);
                let v129: string = fable_library_rust::String_::fromString(v106);
                let v131: bool = true;
                v129
            });
            _optionm_map_
        }
        pub fn closure15(unitVar: (), v0_1: string) -> Option<string> {
            Spiral_builder::method33(v0_1)
        }
        pub fn method32() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Spiral_builder::closure15((), v))
        }
        pub fn method34(v0_1: string, v1_1: string, v2: string) -> Spiral_builder::US12 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method34: loop {
                break '_method34 (if Spiral_builder::method31(Spiral_builder::method27(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Spiral_builder::US12::US12_0(v2.get().clone())
                } else {
                    let v7: Option<string> = (Spiral_builder::method32())(v2.get().clone());
                    let v21: Spiral_builder::US5 = defaultValue(
                        Spiral_builder::US5::US5_1,
                        map(Spiral_builder::method5(), v7),
                    );
                    match &v21 {
                        Spiral_builder::US5::US5_0(v21_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: string = match &v21 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method34;
                        }
                        _ => Spiral_builder::US12::US12_1(sprintf!(
                            "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                            string("dir"),
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone()
                        )),
                    }
                });
            }
        }
        pub fn method30(v0_1: string, v1_1: string) -> Spiral_builder::US12 {
            if Spiral_builder::method31(Spiral_builder::method27(v1_1.clone(), v0_1.clone())) {
                Spiral_builder::US12::US12_0(v1_1.clone())
            } else {
                let v6: Option<string> = (Spiral_builder::method32())(v1_1.clone());
                let v20: Spiral_builder::US5 = defaultValue(
                    Spiral_builder::US5::US5_1,
                    map(Spiral_builder::method5(), v6),
                );
                match &v20 {
                    Spiral_builder::US5::US5_0(v20_0_0) => Spiral_builder::method34(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v20 {
                            Spiral_builder::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    ),
                    _ => Spiral_builder::US12::US12_1(sprintf!(
                        "No parent for {} \'{}\' at \'{}\' (until \'{}\')",
                        string("dir"),
                        v0_1.clone(),
                        v1_1.clone(),
                        v1_1.clone()
                    )),
                }
            }
        }
        pub fn method35() -> string {
            let v6: string = Spiral_builder::method12(getCharAt(toLower(string("Warning")), 0_i32));
            let v9: &str = inline_colorization::color_yellow;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method37(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method36(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Spiral_builder::method37(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.get_workspace_root"),
                v9
            ))
        }
        pub fn closure16(v0_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_3) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method36(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method35(),
                    v0_1,
                ))
            };
        }
        pub fn method38() -> string {
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v5: std::path::PathBuf = v2.unwrap();
            let v19: std::path::Display = v5.display();
            let v43: std::string::String = format!("{}", v19);
            fable_library_rust::String_::fromString(v43)
        }
        pub fn method39() -> string {
            string("\n")
        }
        pub fn method42(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v69: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v69.clone().exists() {
                v69.is_file()
            } else {
                false
            }
        }
        pub fn method41(v0_1: string, v1_1: string) -> bool {
            if Spiral_builder::method42(v0_1.clone()) == false {
                false
            } else {
                let v8: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v0_1);
                let v46: Vec<u8> = Spiral_builder::method26(v8.unwrap());
                let v48: Result<std::string::String, std::string::FromUtf8Error> =
                    std::string::String::from_utf8(v46);
                let v51: std::string::String = v48.unwrap();
                v1_1 == fable_library_rust::String_::fromString(v51)
            }
        }
        pub fn method44(v0_1: string) -> string {
            v0_1
        }
        pub fn closure17(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method45() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Spiral_builder::closure17((), v))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> Spiral_builder::US13 {
            Spiral_builder::US13::US13_0
        }
        pub fn method46() -> Func0<Spiral_builder::US13> {
            Func0::new(move || Spiral_builder::closure18((), ()))
        }
        pub fn closure19(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US13 {
            Spiral_builder::US13::US13_1(v0_1)
        }
        pub fn method47() -> Func1<std::string::String, Spiral_builder::US13> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure19((), v))
        }
        pub fn method48() -> string {
            let v6: string =
                Spiral_builder::method12(getCharAt(toLower(string("Critical")), 0_i32));
            let v9: &str = inline_colorization::color_bright_red;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method50(v0_1: string, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1_1);
            let v100: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v109: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method49(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: std::string::String,
        ) -> string {
            let v10: string = Spiral_builder::method50(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.create_dir"),
                v10
            ))
        }
        pub fn closure20(v0_1: string, v1_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method49(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method48(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method51() -> string {
            let v6: string = Spiral_builder::method12(getCharAt(toLower(string("Verbose")), 0_i32));
            let v9: &str = inline_colorization::color_bright_black;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method53(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method52(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Spiral_builder::method53(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.create_dir"),
                v9
            ))
        }
        pub fn closure21(v0_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_0) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method52(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method51(),
                    v0_1,
                ))
            };
        }
        pub fn method56(v0_1: string) -> string {
            v0_1
        }
        pub fn method55(v0_1: bool, v1_1: string) {
            let v3: string = Spiral_builder::method56(v1_1);
            if Spiral_builder::method31(v3.clone()) {
                if v0_1 {
                    std::fs::remove_dir_all(&*v3.clone()).unwrap();
                    ()
                } else {
                    std::fs::remove_dir(&*v3).unwrap();
                    ()
                };
            }
            ();
            ()
        }
        pub fn closure22(v0_1: string, unitVar: ()) {
            Spiral_builder::method55(true, v0_1);
        }
        pub fn method54(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure22(v0_1.clone(), ())
            })
        }
        pub fn method57(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure22(v0_1.clone(), ())
            })
        }
        pub fn method59(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("dir")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method58(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v10: string = Spiral_builder::method59(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.create_dir"),
                v10
            ))
        }
        pub fn closure23(v0_1: string, v1_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method58(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method11(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method62(v0_1: string) -> string {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            let v75: Option<&std::ffi::OsStr> = v52.file_name();
            let v77: bool = true;
            let _optionm_map_ = v75.map(|x| {
                //;
                let v79: &std::ffi::OsStr = x;
                let v81: std::ffi::OsString = v79.to_os_string();
                let v83: Option<&str> = v81.to_str();
                let v85: &str = v83.unwrap();
                let v88: std::string::String = String::from(v85);
                let v111: string = fable_library_rust::String_::fromString(v88);
                let v113: bool = true;
                v111
            });
            let v115: Option<string> = _optionm_map_;
            let v129: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method5(), v115),
            );
            match &v129 {
                Spiral_builder::US5::US5_0(v129_0_0) => match &v129 {
                    Spiral_builder::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            }
        }
        pub fn method64(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("path")), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method63(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v10: string = Spiral_builder::method64(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.delete_directory_async"),
                v10
            ))
        }
        pub fn closure25(v0_1: string, v1_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method63(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method11(),
                    v1_1,
                    Spiral_builder::method62(v0_1),
                ))
            };
        }
        pub fn method61(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
            defaultOf()
        }
        pub fn closure24(v0_1: string, unitVar: ()) {
            let v2: Arc<Async<i64>> = defaultOf();
            let v28: Arc<Async<()>> = defaultOf();
            defaultOf::<()>();
            ();
            ()
        }
        pub fn method60(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure24(v0_1.clone(), ())
            })
        }
        pub fn method65(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure24(v0_1.clone(), ())
            })
        }
        pub fn method43(v0_1: string) -> LrcPtr<dyn IDisposable> {
            let v2: string = Spiral_builder::method44(v0_1);
            let v4: Result<(), std::io::Error> = std::fs::create_dir_all(&*v2.clone());
            let v5 = Spiral_builder::method45();
            let v17: Result<(), std::string::String> = v4.map_err(|x| v5(x));
            let v20 = Spiral_builder::method46();
            let v21 = Spiral_builder::method47();
            let v22: Spiral_builder::US13 = match &v17 {
                Err(v17_1_0) => v21(v17_1_0.clone()),
                _ => v20(),
            };
            match &v22 {
                Spiral_builder::US13::US13_0 => {
                    let v25: () = {
                        Spiral_builder::closure21(v2.clone(), ());
                        ()
                    };
                    ()
                }
                Spiral_builder::US13::US13_1(v22_1_0) => {
                    let v68: () = {
                        Spiral_builder::closure20(
                            v2.clone(),
                            match &v22 {
                                Spiral_builder::US13::US13_1(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            (),
                        );
                        ()
                    };
                    ()
                }
            }
            {
                let v109 = Spiral_builder::method54(v2.clone());
                interface_cast!(
                    Spiral_builder::Disposable::_ctor__3A5B6456(Func0::new({
                        let v109 = v109.clone();
                        move || v109.clone()()
                    })),
                    Lrc<dyn IDisposable>,
                )
            }
        }
        pub fn method66(v0_1: string) -> string {
            v0_1
        }
        pub fn method40(v0_1: string, v1_1: string) {
            if Spiral_builder::method41(v0_1.clone(), v1_1.clone()) == false {
                let v6: string = defaultValue(string(""), Spiral_builder::method33(v0_1.clone()));
                if Spiral_builder::method31(v6.clone()) == false {
                    let v11: LrcPtr<dyn IDisposable> = Spiral_builder::method43(v6);
                    ()
                }
                std::fs::write(&*v0_1, &*v1_1).unwrap();
                ();
                ()
            };
        }
        pub fn method68(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> string {
            v0_1
        }
        pub fn method70() -> string {
            string("")
        }
        pub fn method71(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn closure28(
            v0_1: char,
            v1_1: LrcPtr<Spiral_builder::UH0>,
        ) -> LrcPtr<Spiral_builder::UH0> {
            LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure27(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Spiral_builder::UH0>, LrcPtr<Spiral_builder::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Spiral_builder::UH0>| Spiral_builder::closure28(v0_1, v)
            })
        }
        pub fn method72(
        ) -> Func1<char, Func1<LrcPtr<Spiral_builder::UH0>, LrcPtr<Spiral_builder::UH0>>> {
            Func1::new(move |v: char| Spiral_builder::closure27((), v))
        }
        pub fn method73(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method73: loop {
                break '_method73 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH0::UH0_0 => {
                        (v1_1.get().clone(), v2.get().clone(), v3.get().clone())
                    }
                    Spiral_builder::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v4: char = match v0_1.get().clone().as_ref() {
                            Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: bool = '\n' == v4;
                        let patternInput: (i32, i32) = if v6 {
                            (v2.get().clone() + 1_i32, 1_i32)
                        } else {
                            (v2.get().clone(), v3.get().clone() + 1_i32)
                        };
                        {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH0> =
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                            let v1_1_temp: LrcPtr<StringBuilder> = if v6 {
                                let v12: LrcPtr<StringBuilder> = v1_1.get().clone().Clear();
                                v1_1.get().clone()
                            } else {
                                let v21: LrcPtr<StringBuilder> = {
                                    let value: string = ofChar(v4);
                                    v1_1.get().clone().Append_Z721C83C5(value)
                                };
                                v1_1.get().clone()
                            };
                            let v2_temp: i32 = patternInput.0.clone();
                            let v3_temp: i32 = patternInput.1.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method73;
                        }
                    }
                });
            }
        }
        pub fn closure26(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == v0_1.clone() {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\"',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if v9 == '\"' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some(length(v0_1.clone()) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method71(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = v42 + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method73(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method72())(b0)(b1)
                                    }),
                                    v45,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US15::US15_0(
                            v9,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v83: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US15::US15_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\"',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    if -2_i32 == v83 {
                                        length(v0_1) + 1_i32
                                    } else {
                                        v83 + 1_i32
                                    } - 1_i32
                                )
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn closure29(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == v0_1.clone() {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\'',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if v9 == '\'' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some(length(v0_1.clone()) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method71(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = v42 + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method73(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method72())(b0)(b1)
                                    }),
                                    v45,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US15::US15_0(
                            v9,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v83: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US15::US15_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\'',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    if -2_i32 == v83 {
                                        length(v0_1) + 1_i32
                                    } else {
                                        v83 + 1_i32
                                    } - 1_i32
                                )
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn method74(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Spiral_builder::UH1>,
        ) -> Spiral_builder::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            '_method74: loop {
                break '_method74 (match v2.get().clone().as_ref() {
                    Spiral_builder::UH1::UH1_0 => Spiral_builder::US15::US15_1(string(
                        "parsing.choice / no parsers succeeded",
                    )),
                    Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) => {
                        let v7: Spiral_builder::US15 = (match v2.get().clone().as_ref() {
                            Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            1_i32,
                            1_i32,
                        ));
                        match &v7 {
                            Spiral_builder::US15::US15_0(
                                v7_0_0,
                                v7_0_1,
                                v7_0_2,
                                v7_0_3,
                                v7_0_4,
                            ) => v7.clone(),
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                    match v2.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method74;
                            }
                        }
                    }
                });
            }
        }
        pub fn method75(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method75: loop {
                break '_method75 (if v1_1.get().clone() >= 2_i64 {
                    false
                } else {
                    let v11: Spiral_builder::US17 = if v1_1.get().clone() == 0_i64 {
                        Spiral_builder::US17::US17_0('\"')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Spiral_builder::US17::US17_0('\'')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            Spiral_builder::US17::US17_1
                        }
                    };
                    if v0_1.get().clone()
                        == match &v11 {
                            Spiral_builder::US17::US17_0(v11_0_0) => match &v11 {
                                Spiral_builder::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = v1_1.get().clone() + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method75;
                    }
                });
            }
        }
        pub fn method76(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method76: loop {
                break '_method76 ({
                    let v109: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v21: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Spiral_builder::method75(v21, 0_i64) == false {
                            let v44: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v49: string = ofChar(v21);
                            let v52: i32 = length(v49.clone());
                            let v53: Array<char> = new_init(&'\u{0000}', v52);
                            let v54: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method71(v52, v54.clone()) {
                                let v56: i32 = v54.l0.get().clone();
                                let v57: char = getCharAt(v49.clone(), v56);
                                v53.get_mut()[v56 as usize] = v57;
                                {
                                    let v58: i32 = v56 + 1_i32;
                                    v54.l0.set(v58);
                                    ()
                                }
                            }
                            {
                                let v59: List<char> = ofArray(v53.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method73(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method72())(b0)(b1)
                                                },
                                            ),
                                            v59,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v21,
                                    v44,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v21,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v121: Spiral_builder::US15 = match &v109 {
                        Spiral_builder::US15::US15_0(
                            v109_0_0,
                            v109_0_1,
                            v109_0_2,
                            v109_0_3,
                            v109_0_4,
                        ) => {
                            let v110: char = v109_0_0.clone();
                            Spiral_builder::US15::US15_0(
                                if '\\' == v110 { '/' } else { v110 },
                                v109_0_1.clone(),
                                v109_0_2.clone(),
                                v109_0_3.clone(),
                                v109_0_4.clone(),
                            )
                        }
                        Spiral_builder::US15::US15_1(v109_1_0) => {
                            Spiral_builder::US15::US15_1(v109_1_0.clone())
                        }
                    };
                    match &v121 {
                        Spiral_builder::US15::US15_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v121_0_0.clone()));
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method76;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method77(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Spiral_builder::UH1>,
        ) -> Spiral_builder::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v4.clone());
            '_method77: loop {
                break '_method77 (match v4.get().clone().as_ref() {
                    Spiral_builder::UH1::UH1_0 => Spiral_builder::US15::US15_1(string(
                        "parsing.choice / no parsers succeeded",
                    )),
                    Spiral_builder::UH1::UH1_1(v4_1_0, v4_1_1) => {
                        let v9: Spiral_builder::US15 = (match v4.get().clone().as_ref() {
                            Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Spiral_builder::US15::US15_0(
                                v9_0_0,
                                v9_0_1,
                                v9_0_2,
                                v9_0_3,
                                v9_0_4,
                            ) => v9.clone(),
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Spiral_builder::UH1> =
                                    match v4.get().clone().as_ref() {
                                        Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method77;
                            }
                        }
                    }
                });
            }
        }
        pub fn method78(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method78: loop {
                break '_method78 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Spiral_builder::US17 = if v1_1.get().clone() == 0_i64 {
                        Spiral_builder::US17::US17_0('\"')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Spiral_builder::US17::US17_0('\'')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Spiral_builder::US17::US17_0(' ')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Spiral_builder::US17::US17_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Spiral_builder::US17::US17_0(v15_0_0) => match &v15 {
                                Spiral_builder::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = v1_1.get().clone() + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method78;
                    }
                });
            }
        }
        pub fn method79(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method79: loop {
                break '_method79 ({
                    let v115: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Spiral_builder::method78(v24, 0_i64) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method71(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = v59 + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method73(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method72())(b0)(b1)
                                                },
                                            ),
                                            v62,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v24,
                                    v47,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v24,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v127: Spiral_builder::US15 = match &v115 {
                        Spiral_builder::US15::US15_0(
                            v115_0_0,
                            v115_0_1,
                            v115_0_2,
                            v115_0_3,
                            v115_0_4,
                        ) => {
                            let v116: char = v115_0_0.clone();
                            Spiral_builder::US15::US15_0(
                                if '\\' == v116 { '/' } else { v116 },
                                v115_0_1.clone(),
                                v115_0_2.clone(),
                                v115_0_3.clone(),
                                v115_0_4.clone(),
                            )
                        }
                        Spiral_builder::US15::US15_1(v115_1_0) => {
                            Spiral_builder::US15::US15_1(v115_1_0.clone())
                        }
                    };
                    match &v127 {
                        Spiral_builder::US15::US15_0(
                            v127_0_0,
                            v127_0_1,
                            v127_0_2,
                            v127_0_3,
                            v127_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v127_0_0.clone()));
                            let v1_1_temp: string = v127_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v127_0_2.clone();
                            let v3_temp: i32 = v127_0_3.clone();
                            let v4_temp: i32 = v127_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method79;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method80(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method80: loop {
                break '_method80 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if ' ' == getCharAt(v0_1.get().clone(), v1_1.get().clone()) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method80;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method81(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method81: loop {
                break '_method81 ({
                    let v79: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v10: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v30: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone()) - 1_i32),
                        );
                        let v35: string = ofChar(v10);
                        let v38: i32 = length(v35.clone());
                        let v39: Array<char> = new_init(&'\u{0000}', v38);
                        let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Spiral_builder::method71(v38, v40.clone()) {
                            let v42: i32 = v40.l0.get().clone();
                            let v43: char = getCharAt(v35.clone(), v42);
                            v39.get_mut()[v42 as usize] = v43;
                            {
                                let v44: i32 = v42 + 1_i32;
                                v40.l0.set(v44);
                                ()
                            }
                        }
                        {
                            let v45: List<char> = ofArray(v39.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method73(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method72())(b0)(b1)
                                            },
                                        ),
                                        v45,
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                    ),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Spiral_builder::US15::US15_0(
                                v10,
                                v30,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    };
                    match &v79 {
                        Spiral_builder::US15::US15_0(
                            v79_0_0,
                            v79_0_1,
                            v79_0_2,
                            v79_0_3,
                            v79_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v79_0_0.clone()));
                            let v1_1_temp: string = v79_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v79_0_2.clone();
                            let v3_temp: i32 = v79_0_3.clone();
                            let v4_temp: i32 = v79_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method81;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method69(v0_1: string) -> Spiral_builder::US14 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v7: string = defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                );
                let v12: LrcPtr<StringBuilder> =
                    StringBuilder::_ctor__Z721C83C5(Spiral_builder::method70());
                fn v15(
                    arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32),
                ) -> Spiral_builder::US15 {
                    Spiral_builder::closure26((), arg10_0040)
                }
                fn v16(
                    arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32),
                ) -> Spiral_builder::US15 {
                    Spiral_builder::closure29((), arg10_0040_1)
                }
                let v20: Spiral_builder::US15 = Spiral_builder::method74(
                    v7.clone(),
                    v12.clone(),
                    LrcPtr::new(Spiral_builder::UH1::UH1_1(
                        Func1::from(v15),
                        LrcPtr::new(Spiral_builder::UH1::UH1_1(
                            Func1::from(v16),
                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                        )),
                    )),
                );
                let v202: Spiral_builder::US16 = match &v20 {
                    Spiral_builder::US15::US15_0(v20_0_0, v20_0_1, v20_0_2, v20_0_3, v20_0_4) => {
                        let v25: i32 = v20_0_4.clone();
                        let v24: i32 = v20_0_3.clone();
                        let v23: LrcPtr<StringBuilder> = v20_0_2.clone();
                        let v22: string = v20_0_1.clone();
                        let v130: Spiral_builder::US15 = if string("") == v22.clone() {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v23.clone(), v24, v25)
                            ))
                        } else {
                            let v42: char = getCharAt(v22.clone(), 0_i32);
                            if Spiral_builder::method75(v42, 0_i64) == false {
                                let v65: string = getSlice(
                                    v22.clone(),
                                    Some(1_i32),
                                    Some(length(v22.clone()) - 1_i32),
                                );
                                let v70: string = ofChar(v42);
                                let v73: i32 = length(v70.clone());
                                let v74: Array<char> = new_init(&'\u{0000}', v73);
                                let v75: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method71(v73, v75.clone()) {
                                    let v77: i32 = v75.l0.get().clone();
                                    let v78: char = getCharAt(v70.clone(), v77);
                                    v74.get_mut()[v77 as usize] = v78;
                                    {
                                        let v79: i32 = v77 + 1_i32;
                                        v75.l0.set(v79);
                                        ()
                                    }
                                }
                                {
                                    let v80: List<char> = ofArray(v74.clone());
                                    let patternInput:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method73(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method72())(b0)(b1)),
                                                                                  v80,
                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                         v23.clone(),
                                                                         v24,
                                                                         v25);
                                    Spiral_builder::US15::US15_0(
                                        v42,
                                        v65,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                    )
                                }
                            } else {
                                Spiral_builder::US15::US15_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                              v42,
                                                                              toArray(ofArray(new_array(&['\"',
                                                                                                          '\'']))),
                                                                              (v23.clone(),
                                                                               v24,
                                                                               v25)))
                            }
                        };
                        let v142: Spiral_builder::US15 = match &v130 {
                            Spiral_builder::US15::US15_0(
                                v130_0_0,
                                v130_0_1,
                                v130_0_2,
                                v130_0_3,
                                v130_0_4,
                            ) => {
                                let v131: char = v130_0_0.clone();
                                Spiral_builder::US15::US15_0(
                                    if '\\' == v131 { '/' } else { v131 },
                                    v130_0_1.clone(),
                                    v130_0_2.clone(),
                                    v130_0_3.clone(),
                                    v130_0_4.clone(),
                                )
                            }
                            Spiral_builder::US15::US15_1(v130_1_0) => {
                                Spiral_builder::US15::US15_1(v130_1_0.clone())
                            }
                        };
                        let v161: Spiral_builder::US16 = match &v142 {
                            Spiral_builder::US15::US15_0(
                                v142_0_0,
                                v142_0_1,
                                v142_0_2,
                                v142_0_3,
                                v142_0_4,
                            ) => {
                                let patternInput_1: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Spiral_builder::method76(
                                    ofChar(v142_0_0.clone()),
                                    v142_0_1.clone(),
                                    v142_0_2.clone(),
                                    v142_0_3.clone(),
                                    v142_0_4.clone(),
                                );
                                Spiral_builder::US16::US16_0(
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                    patternInput_1.3.clone(),
                                    patternInput_1.4.clone(),
                                )
                            }
                            Spiral_builder::US15::US15_1(v142_1_0) => {
                                Spiral_builder::US16::US16_1(v142_1_0.clone())
                            }
                        };
                        let v171: Spiral_builder::US16 = match &v161 {
                            Spiral_builder::US16::US16_0(
                                v161_0_0,
                                v161_0_1,
                                v161_0_2,
                                v161_0_3,
                                v161_0_4,
                            ) => Spiral_builder::US16::US16_0(
                                v161_0_0.clone(),
                                v161_0_1.clone(),
                                v161_0_2.clone(),
                                v161_0_3.clone(),
                                v161_0_4.clone(),
                            ),
                            _ => Spiral_builder::US16::US16_0(
                                string(""),
                                v22.clone(),
                                v23.clone(),
                                v24,
                                v25,
                            ),
                        };
                        match &v171 {
                            Spiral_builder::US16::US16_0(
                                v171_0_0,
                                v171_0_1,
                                v171_0_2,
                                v171_0_3,
                                v171_0_4,
                            ) => {
                                let v176: i32 = v171_0_4.clone();
                                let v175: i32 = v171_0_3.clone();
                                let v174: LrcPtr<StringBuilder> = v171_0_2.clone();
                                let v173: string = v171_0_1.clone();
                                let v180: Spiral_builder::US15 = Spiral_builder::method77(
                                    v173.clone(),
                                    v174.clone(),
                                    v175,
                                    v176,
                                    LrcPtr::new(Spiral_builder::UH1::UH1_1(
                                        Func1::from(v15),
                                        LrcPtr::new(Spiral_builder::UH1::UH1_1(
                                            Func1::from(v16),
                                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v180 {
                                        Spiral_builder::US15::US15_0(v180_0_0,
                                                                     v180_0_1,
                                                                     v180_0_2,
                                                                     v180_0_3,
                                                                     v180_0_4)
                                        =>
                                        Spiral_builder::US16::US16_0(v171_0_0.clone(),
                                                                     v180_0_1.clone(),
                                                                     v180_0_2.clone(),
                                                                     v180_0_3.clone(),
                                                                     v180_0_4.clone()),
                                        Spiral_builder::US15::US15_1(v180_1_0)
                                        =>
                                        Spiral_builder::US16::US16_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                              v180_1_0.clone(),
                                                                              (v7.clone(),
                                                                               v12.clone(),
                                                                               1_i32,
                                                                               1_i32),
                                                                              (v22,
                                                                               v23,
                                                                               v24,
                                                                               v25),
                                                                              (v173,
                                                                               v174,
                                                                               v175,
                                                                               v176))),
                                    }
                            }
                            _ => Spiral_builder::US16::US16_1(string(
                                "parsing.between / expected content",
                            )),
                        }
                    }
                    Spiral_builder::US15::US15_1(v20_1_0) => {
                        Spiral_builder::US16::US16_1(v20_1_0.clone())
                    }
                };
                let v414: Spiral_builder::US16 = match &v202 {
                    Spiral_builder::US16::US16_0(
                        v202_0_0,
                        v202_0_1,
                        v202_0_2,
                        v202_0_3,
                        v202_0_4,
                    ) => v202.clone(),
                    _ => {
                        let v321: Spiral_builder::US15 = if string("") == v7.clone() {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v12.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v228: char = getCharAt(v7.clone(), 0_i32);
                            if Spiral_builder::method78(v228, 0_i64) == false {
                                let v251: string = getSlice(
                                    v7.clone(),
                                    Some(1_i32),
                                    Some(length(v7.clone()) - 1_i32),
                                );
                                let v256: string = ofChar(v228);
                                let v259: i32 = length(v256.clone());
                                let v260: Array<char> = new_init(&'\u{0000}', v259);
                                let v261: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method71(v259, v261.clone()) {
                                    let v263: i32 = v261.l0.get().clone();
                                    let v264: char = getCharAt(v256.clone(), v263);
                                    v260.get_mut()[v263 as usize] = v264;
                                    {
                                        let v265: i32 = v263 + 1_i32;
                                        v261.l0.set(v265);
                                        ()
                                    }
                                }
                                {
                                    let v266: List<char> = ofArray(v260.clone());
                                    let patternInput_2:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method73(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method72())(b0)(b1)),
                                                                                  v266,
                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                         v12.clone(),
                                                                         1_i32,
                                                                         1_i32);
                                    Spiral_builder::US15::US15_0(
                                        v228,
                                        v251,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                }
                            } else {
                                Spiral_builder::US15::US15_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                              v228,
                                                                              toArray(ofArray(new_array(&['\"',
                                                                                                          '\'',
                                                                                                          ' ']))),
                                                                              (v12.clone(),
                                                                               1_i32,
                                                                               1_i32)))
                            }
                        };
                        let v333: Spiral_builder::US15 = match &v321 {
                            Spiral_builder::US15::US15_0(
                                v321_0_0,
                                v321_0_1,
                                v321_0_2,
                                v321_0_3,
                                v321_0_4,
                            ) => {
                                let v322: char = v321_0_0.clone();
                                Spiral_builder::US15::US15_0(
                                    if '\\' == v322 { '/' } else { v322 },
                                    v321_0_1.clone(),
                                    v321_0_2.clone(),
                                    v321_0_3.clone(),
                                    v321_0_4.clone(),
                                )
                            }
                            Spiral_builder::US15::US15_1(v321_1_0) => {
                                Spiral_builder::US15::US15_1(v321_1_0.clone())
                            }
                        };
                        let v352: Spiral_builder::US16 = match &v333 {
                            Spiral_builder::US15::US15_0(
                                v333_0_0,
                                v333_0_1,
                                v333_0_2,
                                v333_0_3,
                                v333_0_4,
                            ) => {
                                let patternInput_3: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Spiral_builder::method79(
                                    ofChar(v333_0_0.clone()),
                                    v333_0_1.clone(),
                                    v333_0_2.clone(),
                                    v333_0_3.clone(),
                                    v333_0_4.clone(),
                                );
                                Spiral_builder::US16::US16_0(
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                    patternInput_3.2.clone(),
                                    patternInput_3.3.clone(),
                                    patternInput_3.4.clone(),
                                )
                            }
                            Spiral_builder::US15::US15_1(v333_1_0) => {
                                Spiral_builder::US16::US16_1(v333_1_0.clone())
                            }
                        };
                        match &v352 {
                            Spiral_builder::US16::US16_0(
                                v352_0_0,
                                v352_0_1,
                                v352_0_2,
                                v352_0_3,
                                v352_0_4,
                            ) => v352.clone(),
                            _ => {
                                let v366: Spiral_builder::US18 = if length(v7.clone()) == 0_i32 {
                                    Spiral_builder::US18::US18_0(
                                        v7.clone(),
                                        v12.clone(),
                                        1_i32,
                                        1_i32,
                                    )
                                } else {
                                    Spiral_builder::US18::US18_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v7.clone()
                                    ))
                                };
                                let v375: Spiral_builder::US16 = match &v366 {
                                    Spiral_builder::US18::US18_0(
                                        v366_0_0,
                                        v366_0_1,
                                        v366_0_2,
                                        v366_0_3,
                                    ) => Spiral_builder::US16::US16_0(
                                        string(""),
                                        v366_0_0.clone(),
                                        v366_0_1.clone(),
                                        v366_0_2.clone(),
                                        v366_0_3.clone(),
                                    ),
                                    Spiral_builder::US18::US18_1(v366_1_0) => {
                                        Spiral_builder::US16::US16_1(v366_1_0.clone())
                                    }
                                };
                                match &v375 {
                                    Spiral_builder::US16::US16_0(
                                        v375_0_0,
                                        v375_0_1,
                                        v375_0_2,
                                        v375_0_3,
                                        v375_0_4,
                                    ) => {
                                        let v377: string = v375_0_1.clone();
                                        Spiral_builder::US16::US16_0(
                                            v375_0_0.clone(),
                                            getSlice(
                                                v377.clone(),
                                                Some(Spiral_builder::method80(v377.clone(), 0_i32)),
                                                Some(length(v377) - 1_i32),
                                            ),
                                            v375_0_2.clone(),
                                            v375_0_3.clone(),
                                            v375_0_4.clone(),
                                        )
                                    }
                                    Spiral_builder::US16::US16_1(v375_1_0) => {
                                        Spiral_builder::US16::US16_1(v375_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v685: Spiral_builder::US19 = match &v414 {
                    Spiral_builder::US16::US16_0(
                        v414_0_0,
                        v414_0_1,
                        v414_0_2,
                        v414_0_3,
                        v414_0_4,
                    ) => {
                        let v419: i32 = v414_0_4.clone();
                        let v418: i32 = v414_0_3.clone();
                        let v417: LrcPtr<StringBuilder> = v414_0_2.clone();
                        let v416: string = v414_0_1.clone();
                        let v544: Spiral_builder::US15 = if string("") == v416.clone() {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                ' ',
                                (v417.clone(), v418, v419)
                            ))
                        } else {
                            let v425: char = getCharAt(v416.clone(), 0_i32);
                            if v425 == ' ' {
                                let v446: string = getSlice(
                                    v416.clone(),
                                    Some(1_i32),
                                    Some(length(v416.clone()) - 1_i32),
                                );
                                let v451: string = ofChar(v425);
                                let v454: i32 = length(v451.clone());
                                let v455: Array<char> = new_init(&'\u{0000}', v454);
                                let v456: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method71(v454, v456.clone()) {
                                    let v458: i32 = v456.l0.get().clone();
                                    let v459: char = getCharAt(v451.clone(), v458);
                                    v455.get_mut()[v458 as usize] = v459;
                                    {
                                        let v460: i32 = v458 + 1_i32;
                                        v456.l0.set(v460);
                                        ()
                                    }
                                }
                                {
                                    let v461: List<char> = ofArray(v455.clone());
                                    let patternInput_4:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method73(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method72())(b0)(b1)),
                                                                                  v461,
                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                         v417.clone(),
                                                                         v418,
                                                                         v419);
                                    Spiral_builder::US15::US15_0(
                                        v425,
                                        v446,
                                        patternInput_4.0.clone(),
                                        patternInput_4.1.clone(),
                                        patternInput_4.2.clone(),
                                    )
                                }
                            } else {
                                let v499: i32 = indexOf(v416.clone(), string("\n")) - 1_i32;
                                Spiral_builder::US15::US15_1(sprintf!("{}\n{}\n",
                                                                              sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                       ' ',
                                                                                       v418,
                                                                                       v419,
                                                                                       v417.clone(),
                                                                                       getSlice(v416.clone(),
                                                                                                Some(0_i32),
                                                                                                Some(if -2_i32
                                                                                                            ==
                                                                                                            v499
                                                                                                        {
                                                                                                         length(v416.clone())
                                                                                                             +
                                                                                                             1_i32
                                                                                                     } else {
                                                                                                         v499
                                                                                                             +
                                                                                                             1_i32
                                                                                                     }
                                                                                                         -
                                                                                                         1_i32))),
                                                                              append(replicate(v419
                                                                                                   -
                                                                                                   1_i32,
                                                                                               string(" ")),
                                                                                     string("^"))))
                            }
                        };
                        let v556: Spiral_builder::US20 = match &v544 {
                            Spiral_builder::US15::US15_0(
                                v544_0_0,
                                v544_0_1,
                                v544_0_2,
                                v544_0_3,
                                v544_0_4,
                            ) => Spiral_builder::US20::US20_0(
                                Spiral_builder::US17::US17_0(v544_0_0.clone()),
                                v544_0_1.clone(),
                                v544_0_2.clone(),
                                v544_0_3.clone(),
                                v544_0_4.clone(),
                            ),
                            _ => Spiral_builder::US20::US20_0(
                                Spiral_builder::US17::US17_1,
                                v416.clone(),
                                v417.clone(),
                                v418,
                                v419,
                            ),
                        };
                        let v659: Spiral_builder::US16 = match &v556 {
                            Spiral_builder::US20::US20_0(
                                v556_0_0,
                                v556_0_1,
                                v556_0_2,
                                v556_0_3,
                                v556_0_4,
                            ) => {
                                let v561: i32 = v556_0_4.clone();
                                let v560: i32 = v556_0_3.clone();
                                let v559: LrcPtr<StringBuilder> = v556_0_2.clone();
                                let v558: string = v556_0_1.clone();
                                let v636: Spiral_builder::US15 = if string("") == v558.clone() {
                                    Spiral_builder::US15::US15_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v559.clone(), v560, v561)
                                    ))
                                } else {
                                    let v567: char = getCharAt(v558.clone(), 0_i32);
                                    let v587: string = getSlice(
                                        v558.clone(),
                                        Some(1_i32),
                                        Some(length(v558) - 1_i32),
                                    );
                                    let v592: string = ofChar(v567);
                                    let v595: i32 = length(v592.clone());
                                    let v596: Array<char> = new_init(&'\u{0000}', v595);
                                    let v597: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method71(v595, v597.clone()) {
                                        let v599: i32 = v597.l0.get().clone();
                                        let v600: char = getCharAt(v592.clone(), v599);
                                        v596.get_mut()[v599 as usize] = v600;
                                        {
                                            let v601: i32 = v599 + 1_i32;
                                            v597.l0.set(v601);
                                            ()
                                        }
                                    }
                                    {
                                        let v602: List<char> = ofArray(v596.clone());
                                        let patternInput_5:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Spiral_builder::method73(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Spiral_builder::UH0>|
                                                                                                         (Spiral_builder::method72())(b0)(b1)),
                                                                                          v602,
                                                                                          LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                 v559,
                                                                                 v560,
                                                                                 v561);
                                        Spiral_builder::US15::US15_0(
                                            v567,
                                            v587,
                                            patternInput_5.0.clone(),
                                            patternInput_5.1.clone(),
                                            patternInput_5.2.clone(),
                                        )
                                    }
                                };
                                match &v636 {
                                    Spiral_builder::US15::US15_0(
                                        v636_0_0,
                                        v636_0_1,
                                        v636_0_2,
                                        v636_0_3,
                                        v636_0_4,
                                    ) => {
                                        let patternInput_6: (
                                            string,
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        ) = Spiral_builder::method81(
                                            ofChar(v636_0_0.clone()),
                                            v636_0_1.clone(),
                                            v636_0_2.clone(),
                                            v636_0_3.clone(),
                                            v636_0_4.clone(),
                                        );
                                        Spiral_builder::US16::US16_0(
                                            patternInput_6.0.clone(),
                                            patternInput_6.1.clone(),
                                            patternInput_6.2.clone(),
                                            patternInput_6.3.clone(),
                                            patternInput_6.4.clone(),
                                        )
                                    }
                                    Spiral_builder::US15::US15_1(v636_1_0) => {
                                        Spiral_builder::US16::US16_1(v636_1_0.clone())
                                    }
                                }
                            }
                            Spiral_builder::US20::US20_1(v556_1_0) => {
                                Spiral_builder::US16::US16_1(v556_1_0.clone())
                            }
                        };
                        let v671: Spiral_builder::US21 = match &v659 {
                            Spiral_builder::US16::US16_0(
                                v659_0_0,
                                v659_0_1,
                                v659_0_2,
                                v659_0_3,
                                v659_0_4,
                            ) => Spiral_builder::US21::US21_0(
                                Spiral_builder::US5::US5_0(v659_0_0.clone()),
                                v659_0_1.clone(),
                                v659_0_2.clone(),
                                v659_0_3.clone(),
                                v659_0_4.clone(),
                            ),
                            _ => Spiral_builder::US21::US21_0(
                                Spiral_builder::US5::US5_1,
                                v416,
                                v417,
                                v418,
                                v419,
                            ),
                        };
                        match &v671 {
                            Spiral_builder::US21::US21_0(
                                v671_0_0,
                                v671_0_1,
                                v671_0_2,
                                v671_0_3,
                                v671_0_4,
                            ) => Spiral_builder::US19::US19_0(
                                v414_0_0.clone(),
                                v671_0_0.clone(),
                                v671_0_1.clone(),
                                v671_0_2.clone(),
                                v671_0_3.clone(),
                                v671_0_4.clone(),
                            ),
                            Spiral_builder::US21::US21_1(v671_1_0) => {
                                Spiral_builder::US19::US19_1(v671_1_0.clone())
                            }
                        }
                    }
                    Spiral_builder::US16::US16_1(v414_1_0) => {
                        Spiral_builder::US19::US19_1(v414_1_0.clone())
                    }
                };
                match &v685 {
                    Spiral_builder::US19::US19_0(
                        v685_0_0,
                        v685_0_1,
                        v685_0_2,
                        v685_0_3,
                        v685_0_4,
                        v685_0_5,
                    ) => Spiral_builder::US14::US14_0(v685_0_0.clone(), v685_0_1.clone()),
                    Spiral_builder::US19::US19_1(v685_1_0) => {
                        Spiral_builder::US14::US14_1(v685_1_0.clone())
                    }
                }
            }
        }
        pub fn method84(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method84: loop {
                break '_method84 (if v1_1.get().clone() >= 4_i64 {
                    false
                } else {
                    let v19: Spiral_builder::US17 = if v1_1.get().clone() == 0_i64 {
                        Spiral_builder::US17::US17_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Spiral_builder::US17::US17_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Spiral_builder::US17::US17_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                if v11 == 0_i64 {
                                    Spiral_builder::US17::US17_0(' ')
                                } else {
                                    let v14: i64 = v11 - 1_i64;
                                    Spiral_builder::US17::US17_1
                                }
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v19 {
                            Spiral_builder::US17::US17_0(v19_0_0) => match &v19 {
                                Spiral_builder::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = v1_1.get().clone() + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method84;
                    }
                });
            }
        }
        pub fn method85(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method85: loop {
                break '_method85 ({
                    let v121: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Spiral_builder::method84(v27, 0_i64) == false {
                            let v50: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v55: string = ofChar(v27);
                            let v58: i32 = length(v55.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method71(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v55.clone(), v62);
                                v59.get_mut()[v62 as usize] = v63;
                                {
                                    let v64: i32 = v62 + 1_i32;
                                    v60.l0.set(v64);
                                    ()
                                }
                            }
                            {
                                let v65: List<char> = ofArray(v59.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method73(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method72())(b0)(b1)
                                                },
                                            ),
                                            v65,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v27,
                                    v50,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v27,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v121 {
                        Spiral_builder::US15::US15_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v121_0_0.clone()));
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method85;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method87(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method87: loop {
                break '_method87 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Spiral_builder::US17 = if v1_1.get().clone() == 0_i64 {
                        Spiral_builder::US17::US17_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Spiral_builder::US17::US17_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Spiral_builder::US17::US17_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Spiral_builder::US17::US17_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Spiral_builder::US17::US17_0(v15_0_0) => match &v15 {
                                Spiral_builder::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = v1_1.get().clone() + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method87;
                    }
                });
            }
        }
        pub fn closure30(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v128: Spiral_builder::US15 = if string("") == v0_1.clone() {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\\',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if v9 == '\\' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some(length(v0_1.clone()) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method71(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = v42 + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method73(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method72())(b0)(b1)
                                    }),
                                    v45,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US15::US15_0(
                            v9,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v83: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US15::US15_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    if -2_i32 == v83 {
                                        length(v0_1) + 1_i32
                                    } else {
                                        v83 + 1_i32
                                    } - 1_i32
                                )
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v212: Spiral_builder::US15 = match &v128 {
                Spiral_builder::US15::US15_0(v128_0_0, v128_0_1, v128_0_2, v128_0_3, v128_0_4) => {
                    let v133: i32 = v128_0_4.clone();
                    let v132: i32 = v128_0_3.clone();
                    let v131: LrcPtr<StringBuilder> = v128_0_2.clone();
                    let v130: string = v128_0_1.clone();
                    if string("") == v130.clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v131.clone(), v132, v133)
                        ))
                    } else {
                        let v139: char = getCharAt(v130.clone(), 0_i32);
                        let v159: string =
                            getSlice(v130.clone(), Some(1_i32), Some(length(v130) - 1_i32));
                        let v164: string = ofChar(v139);
                        let v167: i32 = length(v164.clone());
                        let v168: Array<char> = new_init(&'\u{0000}', v167);
                        let v169: LrcPtr<Spiral_builder::Mut5> =
                            LrcPtr::new(Spiral_builder::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                        while Spiral_builder::method71(v167, v169.clone()) {
                            let v171: i32 = v169.l0.get().clone();
                            let v172: char = getCharAt(v164.clone(), v171);
                            v168.get_mut()[v171 as usize] = v172;
                            {
                                let v173: i32 = v171 + 1_i32;
                                v169.l0.set(v173);
                                ()
                            }
                        }
                        {
                            let v174: List<char> = ofArray(v168.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method73(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method72())(b0)(b1)
                                            },
                                        ),
                                        v174,
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                    ),
                                    v131,
                                    v132,
                                    v133,
                                );
                            Spiral_builder::US15::US15_0(
                                v139,
                                v159,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Spiral_builder::US15::US15_1(v128_1_0) => {
                    Spiral_builder::US15::US15_1(v128_1_0.clone())
                }
            };
            match &v212 {
                Spiral_builder::US15::US15_0(v212_0_0, v212_0_1, v212_0_2, v212_0_3, v212_0_4) => {
                    Spiral_builder::US16::US16_0(
                        append(ofChar('\\'), ofChar(v212_0_0.clone())),
                        v212_0_1.clone(),
                        v212_0_2.clone(),
                        v212_0_3.clone(),
                        v212_0_4.clone(),
                    )
                }
                Spiral_builder::US15::US15_1(v212_1_0) => {
                    Spiral_builder::US16::US16_1(v212_1_0.clone())
                }
            }
        }
        pub fn closure31(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v128: Spiral_builder::US15 = if string("") == v0_1.clone() {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '`',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if v9 == '`' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some(length(v0_1.clone()) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method71(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = v42 + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method73(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method72())(b0)(b1)
                                    }),
                                    v45,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US15::US15_0(
                            v9,
                            v30,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v83: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US15::US15_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    if -2_i32 == v83 {
                                        length(v0_1) + 1_i32
                                    } else {
                                        v83 + 1_i32
                                    } - 1_i32
                                )
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v212: Spiral_builder::US15 = match &v128 {
                Spiral_builder::US15::US15_0(v128_0_0, v128_0_1, v128_0_2, v128_0_3, v128_0_4) => {
                    let v133: i32 = v128_0_4.clone();
                    let v132: i32 = v128_0_3.clone();
                    let v131: LrcPtr<StringBuilder> = v128_0_2.clone();
                    let v130: string = v128_0_1.clone();
                    if string("") == v130.clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v131.clone(), v132, v133)
                        ))
                    } else {
                        let v139: char = getCharAt(v130.clone(), 0_i32);
                        let v159: string =
                            getSlice(v130.clone(), Some(1_i32), Some(length(v130) - 1_i32));
                        let v164: string = ofChar(v139);
                        let v167: i32 = length(v164.clone());
                        let v168: Array<char> = new_init(&'\u{0000}', v167);
                        let v169: LrcPtr<Spiral_builder::Mut5> =
                            LrcPtr::new(Spiral_builder::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                        while Spiral_builder::method71(v167, v169.clone()) {
                            let v171: i32 = v169.l0.get().clone();
                            let v172: char = getCharAt(v164.clone(), v171);
                            v168.get_mut()[v171 as usize] = v172;
                            {
                                let v173: i32 = v171 + 1_i32;
                                v169.l0.set(v173);
                                ()
                            }
                        }
                        {
                            let v174: List<char> = ofArray(v168.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method73(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method72())(b0)(b1)
                                            },
                                        ),
                                        v174,
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                    ),
                                    v131,
                                    v132,
                                    v133,
                                );
                            Spiral_builder::US15::US15_0(
                                v139,
                                v159,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Spiral_builder::US15::US15_1(v128_1_0) => {
                    Spiral_builder::US15::US15_1(v128_1_0.clone())
                }
            };
            match &v212 {
                Spiral_builder::US15::US15_0(v212_0_0, v212_0_1, v212_0_2, v212_0_3, v212_0_4) => {
                    Spiral_builder::US16::US16_0(
                        append(ofChar('`'), ofChar(v212_0_0.clone())),
                        v212_0_1.clone(),
                        v212_0_2.clone(),
                        v212_0_3.clone(),
                        v212_0_4.clone(),
                    )
                }
                Spiral_builder::US15::US15_1(v212_1_0) => {
                    Spiral_builder::US16::US16_1(v212_1_0.clone())
                }
            }
        }
        pub fn method88(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Spiral_builder::UH3>,
        ) -> Spiral_builder::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Spiral_builder::UH3>> = MutCell::new(v4.clone());
            '_method88: loop {
                break '_method88 (match v4.get().clone().as_ref() {
                    Spiral_builder::UH3::UH3_0 => Spiral_builder::US16::US16_1(string(
                        "parsing.choice / no parsers succeeded",
                    )),
                    Spiral_builder::UH3::UH3_1(v4_1_0, v4_1_1) => {
                        let v9: Spiral_builder::US16 = (match v4.get().clone().as_ref() {
                            Spiral_builder::UH3::UH3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Spiral_builder::US16::US16_0(
                                v9_0_0,
                                v9_0_1,
                                v9_0_2,
                                v9_0_3,
                                v9_0_4,
                            ) => v9.clone(),
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Spiral_builder::UH3> =
                                    match v4.get().clone().as_ref() {
                                        Spiral_builder::UH3::UH3_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method88;
                            }
                        }
                    }
                });
            }
        }
        pub fn method89(
            v0_1: LrcPtr<Spiral_builder::UH2>,
            v1_1: LrcPtr<Spiral_builder::UH2>,
        ) -> LrcPtr<Spiral_builder::UH2> {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v1_1.clone());
            '_method89: loop {
                break '_method89 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH2::UH2_0 => v1_1.get().clone(),
                    Spiral_builder::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Spiral_builder::UH2> =
                            match v0_1.get().clone().as_ref() {
                                Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                        let v1_1_temp: LrcPtr<Spiral_builder::UH2> =
                            LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                },
                                v1_1.get().clone(),
                            ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method89;
                    }
                });
            }
        }
        pub fn method86(
            v0_1: LrcPtr<Spiral_builder::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US23 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method86: loop {
                break '_method86 ({
                    let v115: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Spiral_builder::method87(v24, 0_i64) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method71(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = v59 + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method73(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method72())(b0)(b1)
                                                },
                                            ),
                                            v62,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v24,
                                    v47,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v24,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v129: Spiral_builder::US16 = match &v115 {
                        Spiral_builder::US15::US15_0(
                            v115_0_0,
                            v115_0_1,
                            v115_0_2,
                            v115_0_3,
                            v115_0_4,
                        ) => Spiral_builder::US16::US16_0(
                            ofChar(v115_0_0.clone()),
                            v115_0_1.clone(),
                            v115_0_2.clone(),
                            v115_0_3.clone(),
                            v115_0_4.clone(),
                        ),
                        Spiral_builder::US15::US15_1(v115_1_0) => {
                            Spiral_builder::US16::US16_1(v115_1_0.clone())
                        }
                    };
                    let v143: Spiral_builder::US16 = match &v129 {
                        Spiral_builder::US16::US16_0(
                            v129_0_0,
                            v129_0_1,
                            v129_0_2,
                            v129_0_3,
                            v129_0_4,
                        ) => v129.clone(),
                        _ => Spiral_builder::method88(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Spiral_builder::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Spiral_builder::closure30((), arg10_0040)
                                    },
                                ),
                                LrcPtr::new(Spiral_builder::UH3::UH3_1(
                                    Func1::new(
                                        move |arg10_0040_1: (
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        )| {
                                            Spiral_builder::closure31((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Spiral_builder::UH3::UH3_0),
                                )),
                            )),
                        ),
                    };
                    match &v143 {
                        Spiral_builder::US16::US16_0(
                            v143_0_0,
                            v143_0_1,
                            v143_0_2,
                            v143_0_3,
                            v143_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH2> = LrcPtr::new(
                                Spiral_builder::UH2::UH2_1(v143_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v143_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v143_0_2.clone();
                            let v3_temp: i32 = v143_0_3.clone();
                            let v4_temp: i32 = v143_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method86;
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method89(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method90(v0_1: LrcPtr<Spiral_builder::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Spiral_builder::UH2::UH2_0 => v1_1.clone(),
                Spiral_builder::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Spiral_builder::method90(
                        match v0_1.as_ref() {
                            Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method91(
            v0_1: LrcPtr<Spiral_builder::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US23 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method91: loop {
                break '_method91 ({
                    let v115: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Spiral_builder::method87(v24, 0_i64) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method71(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = v59 + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method73(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method72())(b0)(b1)
                                                },
                                            ),
                                            v62,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v24,
                                    v47,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v24,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v129: Spiral_builder::US16 = match &v115 {
                        Spiral_builder::US15::US15_0(
                            v115_0_0,
                            v115_0_1,
                            v115_0_2,
                            v115_0_3,
                            v115_0_4,
                        ) => Spiral_builder::US16::US16_0(
                            ofChar(v115_0_0.clone()),
                            v115_0_1.clone(),
                            v115_0_2.clone(),
                            v115_0_3.clone(),
                            v115_0_4.clone(),
                        ),
                        Spiral_builder::US15::US15_1(v115_1_0) => {
                            Spiral_builder::US16::US16_1(v115_1_0.clone())
                        }
                    };
                    match &v129 {
                        Spiral_builder::US16::US16_0(
                            v129_0_0,
                            v129_0_1,
                            v129_0_2,
                            v129_0_3,
                            v129_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH2> = LrcPtr::new(
                                Spiral_builder::UH2::UH2_1(v129_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v129_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v129_0_2.clone();
                            let v3_temp: i32 = v129_0_3.clone();
                            let v4_temp: i32 = v129_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method91;
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method89(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method83(
            v0_1: LrcPtr<Spiral_builder::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US23 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method83: loop {
                break '_method83 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v121: Spiral_builder::US15 = if v5 {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if Spiral_builder::method84(v27, 0_i64) == false {
                            let v50: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some(length(v1_1.get().clone()) - 1_i32),
                            );
                            let v55: string = ofChar(v27);
                            let v58: i32 = length(v55.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method71(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v55.clone(), v62);
                                v59.get_mut()[v62 as usize] = v63;
                                {
                                    let v64: i32 = v62 + 1_i32;
                                    v60.l0.set(v64);
                                    ()
                                }
                            }
                            {
                                let v65: List<char> = ofArray(v59.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method73(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method72())(b0)(b1)
                                                },
                                            ),
                                            v65,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v27,
                                    v50,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v27,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v140: Spiral_builder::US16 = match &v121 {
                        Spiral_builder::US15::US15_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => {
                            let patternInput_1: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method85(
                                    ofChar(v121_0_0.clone()),
                                    v121_0_1.clone(),
                                    v121_0_2.clone(),
                                    v121_0_3.clone(),
                                    v121_0_4.clone(),
                                );
                            Spiral_builder::US16::US16_0(
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                            )
                        }
                        Spiral_builder::US15::US15_1(v121_1_0) => {
                            Spiral_builder::US16::US16_1(v121_1_0.clone())
                        }
                    };
                    let v517: Spiral_builder::US16 = match &v140 {
                        Spiral_builder::US16::US16_0(
                            v140_0_0,
                            v140_0_1,
                            v140_0_2,
                            v140_0_3,
                            v140_0_4,
                        ) => v140.clone(),
                        _ => {
                            let v270: Spiral_builder::US15 = if v5 {
                                Spiral_builder::US15::US15_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                       '\"',
                                                                                       (v2.get().clone(),
                                                                                        v3.get().clone(),
                                                                                        v4.get().clone())))
                            } else {
                                let v151: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if v151 == '\"' {
                                    let v172: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some(length(v1_1.get().clone()) - 1_i32),
                                    );
                                    let v177: string = ofChar(v151);
                                    let v180: i32 = length(v177.clone());
                                    let v181: Array<char> = new_init(&'\u{0000}', v180);
                                    let v182: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method71(v180, v182.clone()) {
                                        let v184: i32 = v182.l0.get().clone();
                                        let v185: char = getCharAt(v177.clone(), v184);
                                        v181.get_mut()[v184 as usize] = v185;
                                        {
                                            let v186: i32 = v184 + 1_i32;
                                            v182.l0.set(v186);
                                            ()
                                        }
                                    }
                                    {
                                        let v187: List<char> = ofArray(v181.clone());
                                        let patternInput_2:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Spiral_builder::method73(foldBack(Func2::new(move
                                                                                                              |b0:
                                                                                                                   char,
                                                                                                               b1:
                                                                                                                   LrcPtr<Spiral_builder::UH0>|
                                                                                                              (Spiral_builder::method72())(b0)(b1)),
                                                                                               v187,
                                                                                               LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                      v2.get().clone(),
                                                                                      v3.get().clone(),
                                                                                      v4.get().clone());
                                        Spiral_builder::US15::US15_0(
                                            v151,
                                            v172,
                                            patternInput_2.0.clone(),
                                            patternInput_2.1.clone(),
                                            patternInput_2.2.clone(),
                                        )
                                    }
                                } else {
                                    let v225: i32 =
                                        indexOf(v1_1.get().clone(), string("\n")) - 1_i32;
                                    Spiral_builder::US15::US15_1(sprintf!("{}\n{}\n",
                                                                                           sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                    '\"',
                                                                                                    v3.get().clone(),
                                                                                                    v4.get().clone(),
                                                                                                    v2.get().clone(),
                                                                                                    getSlice(v1_1.get().clone(),
                                                                                                             Some(0_i32),
                                                                                                             Some(if -2_i32
                                                                                                                         ==
                                                                                                                         v225
                                                                                                                     {
                                                                                                                      length(v1_1.get().clone())
                                                                                                                          +
                                                                                                                          1_i32
                                                                                                                  } else {
                                                                                                                      v225
                                                                                                                          +
                                                                                                                          1_i32
                                                                                                                  }
                                                                                                                      -
                                                                                                                      1_i32))),
                                                                                           append(replicate(v4.get().clone()
                                                                                                                -
                                                                                                                1_i32,
                                                                                                            string(" ")),
                                                                                                  string("^"))))
                                }
                            };
                            let v454: Spiral_builder::US16 = match &v270 {
                                Spiral_builder::US15::US15_0(
                                    v270_0_0,
                                    v270_0_1,
                                    v270_0_2,
                                    v270_0_3,
                                    v270_0_4,
                                ) => {
                                    let v275: i32 = v270_0_4.clone();
                                    let v274: i32 = v270_0_3.clone();
                                    let v273: LrcPtr<StringBuilder> = v270_0_2.clone();
                                    let v272: string = v270_0_1.clone();
                                    let v277: Spiral_builder::US23 = Spiral_builder::method86(
                                        LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        v272.clone(),
                                        v273.clone(),
                                        v274,
                                        v275,
                                    );
                                    let v302: Spiral_builder::US16 = match &v277 {
                                        Spiral_builder::US23::US23_0(
                                            v277_0_0,
                                            v277_0_1,
                                            v277_0_2,
                                            v277_0_3,
                                            v277_0_4,
                                        ) => {
                                            let v284: List<string> = Spiral_builder::method90(
                                                v277_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v284 = v284.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v284 = v284.clone();
                                                                    move |i: i32| {
                                                                        item(i, v284.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v284.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v277_0_1.clone(),
                                                v277_0_2.clone(),
                                                v277_0_3.clone(),
                                                v277_0_4.clone(),
                                            )
                                        }
                                        Spiral_builder::US23::US23_1(v277_1_0) => {
                                            Spiral_builder::US16::US16_1(v277_1_0.clone())
                                        }
                                    };
                                    match &v302 {
                                        Spiral_builder::US16::US16_0(
                                            v302_0_0,
                                            v302_0_1,
                                            v302_0_2,
                                            v302_0_3,
                                            v302_0_4,
                                        ) => {
                                            let v307: i32 = v302_0_4.clone();
                                            let v306: i32 = v302_0_3.clone();
                                            let v305: LrcPtr<StringBuilder> = v302_0_2.clone();
                                            let v304: string = v302_0_1.clone();
                                            let v432: Spiral_builder::US15 = if string("")
                                                == v304.clone()
                                            {
                                                Spiral_builder::US15::US15_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                                           '\"',
                                                                                                           (v305.clone(),
                                                                                                            v306,
                                                                                                            v307)))
                                            } else {
                                                let v313: char = getCharAt(v304.clone(), 0_i32);
                                                if v313 == '\"' {
                                                    let v334: string = getSlice(
                                                        v304.clone(),
                                                        Some(1_i32),
                                                        Some(length(v304.clone()) - 1_i32),
                                                    );
                                                    let v339: string = ofChar(v313);
                                                    let v342: i32 = length(v339.clone());
                                                    let v343: Array<char> =
                                                        new_init(&'\u{0000}', v342);
                                                    let v344: LrcPtr<Spiral_builder::Mut5> =
                                                        LrcPtr::new(Spiral_builder::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Spiral_builder::method71(
                                                        v342,
                                                        v344.clone(),
                                                    ) {
                                                        let v346: i32 = v344.l0.get().clone();
                                                        let v347: char =
                                                            getCharAt(v339.clone(), v346);
                                                        v343.get_mut()[v346 as usize] = v347;
                                                        {
                                                            let v348: i32 = v346 + 1_i32;
                                                            v344.l0.set(v348);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v349: List<char> =
                                                            ofArray(v343.clone());
                                                        let patternInput_3:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Spiral_builder::method73(foldBack(Func2::new(move
                                                                                                                                  |b0:
                                                                                                                                       char,
                                                                                                                                   b1:
                                                                                                                                       LrcPtr<Spiral_builder::UH0>|
                                                                                                                                  (Spiral_builder::method72())(b0)(b1)),
                                                                                                                   v349,
                                                                                                                   LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                                          v305.clone(),
                                                                                                          v306,
                                                                                                          v307);
                                                        Spiral_builder::US15::US15_0(
                                                            v313,
                                                            v334,
                                                            patternInput_3.0.clone(),
                                                            patternInput_3.1.clone(),
                                                            patternInput_3.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v387: i32 =
                                                        indexOf(v304.clone(), string("\n")) - 1_i32;
                                                    Spiral_builder::US15::US15_1(sprintf!("{}\n{}\n",
                                                                                                               sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                        '\"',
                                                                                                                        v306,
                                                                                                                        v307,
                                                                                                                        v305.clone(),
                                                                                                                        getSlice(v304.clone(),
                                                                                                                                 Some(0_i32),
                                                                                                                                 Some(if -2_i32
                                                                                                                                             ==
                                                                                                                                             v387
                                                                                                                                         {
                                                                                                                                          length(v304.clone())
                                                                                                                                              +
                                                                                                                                              1_i32
                                                                                                                                      } else {
                                                                                                                                          v387
                                                                                                                                              +
                                                                                                                                              1_i32
                                                                                                                                      }
                                                                                                                                          -
                                                                                                                                          1_i32))),
                                                                                                               append(replicate(v307
                                                                                                                                    -
                                                                                                                                    1_i32,
                                                                                                                                string(" ")),
                                                                                                                      string("^"))))
                                                }
                                            };
                                            match &v432 {
                                                                 Spiral_builder::US15::US15_0(v432_0_0,
                                                                                              v432_0_1,
                                                                                              v432_0_2,
                                                                                              v432_0_3,
                                                                                              v432_0_4)
                                                                 =>
                                                                 Spiral_builder::US16::US16_0(v302_0_0.clone(),
                                                                                              v432_0_1.clone(),
                                                                                              v432_0_2.clone(),
                                                                                              v432_0_3.clone(),
                                                                                              v432_0_4.clone()),
                                                                 Spiral_builder::US15::US15_1(v432_1_0)
                                                                 =>
                                                                 Spiral_builder::US16::US16_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                       v432_1_0.clone(),
                                                                                                       (v1_1.get().clone(),
                                                                                                        v2.get().clone(),
                                                                                                        v3.get().clone(),
                                                                                                        v4.get().clone()),
                                                                                                       (v272,
                                                                                                        v273,
                                                                                                        v274,
                                                                                                        v275),
                                                                                                       (v304,
                                                                                                        v305,
                                                                                                        v306,
                                                                                                        v307))),
                                                             }
                                        }
                                        _ => Spiral_builder::US16::US16_1(string(
                                            "parsing.between / expected content",
                                        )),
                                    }
                                }
                                Spiral_builder::US15::US15_1(v270_1_0) => {
                                    Spiral_builder::US16::US16_1(v270_1_0.clone())
                                }
                            };
                            match &v454 {
                                Spiral_builder::US16::US16_0(
                                    v454_0_0,
                                    v454_0_1,
                                    v454_0_2,
                                    v454_0_3,
                                    v454_0_4,
                                ) => v454.clone(),
                                _ => {
                                    let v466:
                                                         Spiral_builder::US16 =
                                                     Spiral_builder::method88(v1_1.get().clone(),
                                                                              v2.get().clone(),
                                                                              v3.get().clone(),
                                                                              v4.get().clone(),
                                                                              LrcPtr::new(Spiral_builder::UH3::UH3_1(Func1::new(move
                                                                                                                                    |arg10_0040:
                                                                                                                                         (string,
                                                                                                                                          LrcPtr<StringBuilder>,
                                                                                                                                          i32,
                                                                                                                                          i32)|
                                                                                                                                    Spiral_builder::closure30((),
                                                                                                                                                              arg10_0040)),
                                                                                                                     LrcPtr::new(Spiral_builder::UH3::UH3_1(Func1::new(move
                                                                                                                                                                           |arg10_0040_1:
                                                                                                                                                                                (string,
                                                                                                                                                                                 LrcPtr<StringBuilder>,
                                                                                                                                                                                 i32,
                                                                                                                                                                                 i32)|
                                                                                                                                                                           Spiral_builder::closure31((),
                                                                                                                                                                                                     arg10_0040_1)),
                                                                                                                                                            LrcPtr::new(Spiral_builder::UH3::UH3_0))))));
                                    let v477: Spiral_builder::US16 = match &v466 {
                                        Spiral_builder::US16::US16_0(
                                            v466_0_0,
                                            v466_0_1,
                                            v466_0_2,
                                            v466_0_3,
                                            v466_0_4,
                                        ) => Spiral_builder::US16::US16_0(
                                            string(""),
                                            v466_0_1.clone(),
                                            v466_0_2.clone(),
                                            v466_0_3.clone(),
                                            v466_0_4.clone(),
                                        ),
                                        Spiral_builder::US16::US16_1(v466_1_0) => {
                                            Spiral_builder::US16::US16_1(v466_1_0.clone())
                                        }
                                    };
                                    let v488: Spiral_builder::US23 = match &v477 {
                                        Spiral_builder::US16::US16_0(
                                            v477_0_0,
                                            v477_0_1,
                                            v477_0_2,
                                            v477_0_3,
                                            v477_0_4,
                                        ) => Spiral_builder::method91(
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                            v477_0_1.clone(),
                                            v477_0_2.clone(),
                                            v477_0_3.clone(),
                                            v477_0_4.clone(),
                                        ),
                                        Spiral_builder::US16::US16_1(v477_1_0) => {
                                            Spiral_builder::US23::US23_1(v477_1_0.clone())
                                        }
                                    };
                                    match &v488 {
                                        Spiral_builder::US23::US23_0(
                                            v488_0_0,
                                            v488_0_1,
                                            v488_0_2,
                                            v488_0_3,
                                            v488_0_4,
                                        ) => {
                                            let v495: List<string> = Spiral_builder::method90(
                                                v488_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v495 = v495.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v495 = v495.clone();
                                                                    move |i_1: i32| {
                                                                        item(i_1, v495.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v495.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v488_0_1.clone(),
                                                v488_0_2.clone(),
                                                v488_0_3.clone(),
                                                v488_0_4.clone(),
                                            )
                                        }
                                        Spiral_builder::US23::US23_1(v488_1_0) => {
                                            Spiral_builder::US16::US16_1(v488_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v517 {
                        Spiral_builder::US16::US16_0(
                            v517_0_0,
                            v517_0_1,
                            v517_0_2,
                            v517_0_3,
                            v517_0_4,
                        ) => {
                            let v522: i32 = v517_0_4.clone();
                            let v521: i32 = v517_0_3.clone();
                            let v520: LrcPtr<StringBuilder> = v517_0_2.clone();
                            let v519: string = v517_0_1.clone();
                            let v518: string = v517_0_0.clone();
                            let v524: i32 = Spiral_builder::method80(v519.clone(), 0_i32);
                            let v552: Spiral_builder::US18 = if 0_i32 == v524 {
                                Spiral_builder::US18::US18_1(string(
                                    "parsing.spaces1 / expected at least one space",
                                ))
                            } else {
                                Spiral_builder::US18::US18_0(
                                    getSlice(
                                        v519.clone(),
                                        Some(v524),
                                        Some(length(v519.clone()) - 1_i32),
                                    ),
                                    v520.clone(),
                                    v521,
                                    v522,
                                )
                            };
                            match &v552 {
                                Spiral_builder::US18::US18_0(
                                    v552_0_0,
                                    v552_0_1,
                                    v552_0_2,
                                    v552_0_3,
                                ) => {
                                    let v0_1_temp: LrcPtr<Spiral_builder::UH2> =
                                        LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                            v518.clone(),
                                            v0_1.get().clone(),
                                        ));
                                    let v1_1_temp: string = v552_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v552_0_1.clone();
                                    let v3_temp: i32 = v552_0_2.clone();
                                    let v4_temp: i32 = v552_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method83;
                                }
                                _ => Spiral_builder::US23::US23_0(
                                    Spiral_builder::method89(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                            v518.clone(),
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        )),
                                    ),
                                    v519,
                                    v520,
                                    v521,
                                    v522,
                                ),
                            }
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method89(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method82(v0_1: string) -> Spiral_builder::US22 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v18: Spiral_builder::US23 = Spiral_builder::method83(
                    LrcPtr::new(Spiral_builder::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Spiral_builder::method70()),
                    1_i32,
                    1_i32,
                );
                match &v18 {
                    Spiral_builder::US23::US23_0(v18_0_0, v18_0_1, v18_0_2, v18_0_3, v18_0_4) => {
                        Spiral_builder::US22::US22_0(toArray(Spiral_builder::method90(
                            v18_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Spiral_builder::US23::US23_1(v18_1_0) => {
                        Spiral_builder::US22::US22_1(v18_1_0.clone())
                    }
                }
            }
        }
        pub fn method93(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v17: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v26: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("file_name")), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v43: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v52: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v61: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("arguments")), ());
                ()
            };
            let v69: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v77: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v85: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v94: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("options")), ());
                ()
            };
            let v102: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v110: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v119: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("command")), ());
                ()
            };
            let v127: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v143: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("cancellation_token")),
                    (),
                );
                ()
            };
            let v160: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v165: std::string::String = format!("{:#?}", v3);
            let v198: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v165)),
                    (),
                );
                ()
            };
            let v206: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v215: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("environment_variables")),
                    (),
                );
                ()
            };
            let v223: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v234: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", sprintf!("{:?}", v4)), ());
                ()
            };
            let v242: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v251: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("on_line")), ());
                ()
            };
            let v259: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v264: std::string::String = format!("{:#?}", v5);
            let v297: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v264)),
                    (),
                );
                ()
            };
            let v305: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v314: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v322: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v327: std::string::String = format!("{:#?}", v6);
            let v360: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v327)),
                    (),
                );
                ()
            };
            let v368: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v377: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v385: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v396: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", if v7 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v404: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v413: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("working_directory")),
                    (),
                );
                ()
            };
            let v421: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v426: std::string::String = format!("{:#?}", v8);
            let v459: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v426)),
                    (),
                );
                ()
            };
            let v468: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v476: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method92(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Spiral_builder::method93(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options"),
                v17
            ))
        }
        pub fn closure32(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v13: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method92(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Spiral_builder::method7(v27, v28, v29, v30, v31, v32),
                    Spiral_builder::method11(),
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn closure33(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method94() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Spiral_builder::closure33((), v))
        }
        pub fn closure34(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Spiral_builder::US24 {
            Spiral_builder::US24::US24_0(v0_1)
        }
        pub fn method95() -> Func1<
            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
            Spiral_builder::US24,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Spiral_builder::closure34((), v)
                },
            )
        }
        pub fn closure35(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US24 {
            Spiral_builder::US24::US24_1(v0_1)
        }
        pub fn method96() -> Func1<std::string::String, Spiral_builder::US24> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure35((), v))
        }
        pub fn method98(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("error")), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method97(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Spiral_builder::method98(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / child error"),
                v9
            ))
        }
        pub fn closure36(v0_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method97(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method48(),
                    v0_1,
                ))
            };
        }
        pub fn method99(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure37(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method100(
        ) -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Spiral_builder::closure37((), v))
        }
        pub fn closure38(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method101() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Spiral_builder::closure38((), v)
            })
        }
        pub fn method102() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Spiral_builder::closure38((), v)
            })
        }
        pub fn closure39(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method103() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Spiral_builder::closure39((), v)
                },
            )
        }
        pub fn closure40(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US26 {
            Spiral_builder::US26::US26_0(v0_1)
        }
        pub fn method104() -> Func1<std::string::String, Spiral_builder::US26> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure40((), v))
        }
        pub fn closure41(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US26 {
            Spiral_builder::US26::US26_1(v0_1)
        }
        pub fn method105() -> Func1<std::string::String, Spiral_builder::US26> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure41((), v))
        }
        pub fn method107(v0_1: bool, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("trace\'")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v39: () = {
                Spiral_builder::closure7(
                    v3.clone(),
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
            let v48: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v57: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("e")), ());
                ()
            };
            let v65: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: std::string::String = format!("{:#?}", v1_1);
            let v103: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v70)),
                    (),
                );
                ()
            };
            let v112: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method106(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: bool,
            v9: std::string::String,
        ) -> string {
            let v10: string = Spiral_builder::method107(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.stdio_line"),
                v10
            ))
        }
        pub fn closure42(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method106(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method48(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method109() -> string {
            let v1_1: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method108(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Spiral_builder::method109();
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v9
            ))
        }
        pub fn closure43(v0_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_0) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(if v0_1.clone() == string("") {
                    string("")
                } else {
                    Spiral_builder::method108(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                        Spiral_builder::method51(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure44(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method110(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Spiral_builder::closure44((), v)
            })
        }
        pub fn method111(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure45(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Spiral_builder::US27 {
            Spiral_builder::US27::US27_0(v0_1)
        }
        pub fn method112() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Spiral_builder::US27,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Spiral_builder::closure45((), v)
                },
            )
        }
        pub fn method113(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure46(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Spiral_builder::US28 {
            Spiral_builder::US28::US28_0(v0_1)
        }
        pub fn method114(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Spiral_builder::US28>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Spiral_builder::closure46((), v)
                },
            )
        }
        pub fn method115(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method116(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure47(unitVar: (), v0_1: std::process::Output) -> Spiral_builder::US29 {
            Spiral_builder::US29::US29_0(v0_1)
        }
        pub fn method117() -> Func1<std::process::Output, Spiral_builder::US29> {
            Func1::new(move |v: std::process::Output| Spiral_builder::closure47((), v))
        }
        pub fn closure48(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US29 {
            Spiral_builder::US29::US29_1(v0_1)
        }
        pub fn method118() -> Func1<std::string::String, Spiral_builder::US29> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure48((), v))
        }
        pub fn method119(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Spiral_builder::method98(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / output error"),
                v9
            ))
        }
        pub fn closure49(v0_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method119(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method48(),
                    v0_1,
                ))
            };
        }
        pub fn closure50(unitVar: (), v0_1: i32) -> Spiral_builder::US30 {
            Spiral_builder::US30::US30_0(v0_1)
        }
        pub fn method120() -> Func1<i32, Spiral_builder::US30> {
            Func1::new(move |v: i32| Spiral_builder::closure50((), v))
        }
        pub fn method122(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", string("std_trace_length")),
                    (),
                );
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method121(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Spiral_builder::method122(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / result"),
                v10
            ))
        }
        pub fn closure51(v0_1: i32, v1_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_0) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method121(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method51(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method125(
            v0_1: string,
            v1_1: Spiral_builder::US5,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v17: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v26: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("file_name")), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v43: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v52: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v61: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("arguments")), ());
                ()
            };
            let v69: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v80: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", sprintf!("{:?}", v1_1)), ());
                ()
            };
            let v88: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v97: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("options")), ());
                ()
            };
            let v105: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v113: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v122: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("command")), ());
                ()
            };
            let v130: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v146: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v155: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("cancellation_token")),
                    (),
                );
                ()
            };
            let v163: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v168: std::string::String = format!("{:#?}", v3);
            let v201: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v168)),
                    (),
                );
                ()
            };
            let v209: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v218: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("environment_variables")),
                    (),
                );
                ()
            };
            let v226: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v237: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", sprintf!("{:?}", v4)), ());
                ()
            };
            let v245: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v254: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("on_line")), ());
                ()
            };
            let v262: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v267: std::string::String = format!("{:#?}", v5);
            let v300: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v267)),
                    (),
                );
                ()
            };
            let v308: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v317: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v325: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v330: std::string::String = format!("{:#?}", v6);
            let v363: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v330)),
                    (),
                );
                ()
            };
            let v371: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v380: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v388: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v399: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", if v7 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v407: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v416: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("working_directory")),
                    (),
                );
                ()
            };
            let v424: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v429: std::string::String = format!("{:#?}", v8);
            let v462: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v429)),
                    (),
                );
                ()
            };
            let v471: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v479: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method124(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: Spiral_builder::US5,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Spiral_builder::method125(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v17
            ))
        }
        pub fn closure52(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: Spiral_builder::US5,
            v8: string,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v13: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method124(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Spiral_builder::method7(v27, v28, v29, v30, v31, v32),
                    Spiral_builder::method11(),
                    v8,
                    v7,
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                ))
            };
        }
        pub fn method126(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Array<(string, string)> {
            v2
        }
        pub fn closure54(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Spiral_builder::US31 {
            Spiral_builder::US31::US31_0(v0_1)
        }
        pub fn method127() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Spiral_builder::US31>
        {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Spiral_builder::closure54((), v)
            })
        }
        pub fn closure55(v0_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_0) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(if v0_1.clone() == string("") {
                    string("")
                } else {
                    Spiral_builder::method108(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                        Spiral_builder::method51(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure53(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: (),
        ) {
            let v11: Arc<Async<()>> = defaultOf();
            defaultOf::<()>();
            ();
            ()
        }
        pub fn closure56(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: (),
        ) {
            let v11: Arc<Async<()>> = defaultOf();
            defaultOf::<()>();
            ();
            ()
        }
        pub fn closure57(unitVar: (), v0_1: CancellationToken) -> Spiral_builder::US32 {
            Spiral_builder::US32::US32_0(v0_1)
        }
        pub fn method128() -> Func1<CancellationToken, Spiral_builder::US32> {
            Func1::new(move |v: CancellationToken| Spiral_builder::closure57((), v))
        }
        pub fn closure58(v0_1: (), unitVar: ()) {
            if unbox::<bool>(&defaultOf()) == false {
                ();
                ()
            };
        }
        pub fn method130(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method129(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<TaskCanceledException>,
        ) -> string {
            let v9: string = Spiral_builder::method130(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async / WaitForExitAsync"),
                v9
            ))
        }
        pub fn closure59(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_3) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method129(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method35(),
                    v0_1,
                ))
            };
        }
        pub fn method132(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("output_length")), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method131(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Spiral_builder::method132(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v10
            ))
        }
        pub fn closure60(v0_1: i32, v1_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method131(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method11(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method123(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            defaultOf()
        }
        pub fn method67(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v9: Spiral_builder::US14 = Spiral_builder::method69(Spiral_builder::method68(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Spiral_builder::US5) = match &v9 {
                Spiral_builder::US14::US14_0(v9_0_0, v9_0_1) => (v9_0_0.clone(), v9_0_1.clone()),
                Spiral_builder::US14::US14_1(v9_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v9_1_0.clone()),
                ),
            };
            let v21: Spiral_builder::US5 = patternInput.1.clone();
            let v20: string = patternInput.0.clone();
            let v26: Spiral_builder::US22 = Spiral_builder::method82(match &v21 {
                Spiral_builder::US5::US5_0(v21_0_0) => match &v21 {
                    Spiral_builder::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            });
            let v34: Array<string> = match &v26 {
                Spiral_builder::US22::US22_0(v26_0_0) => v26_0_0.clone(),
                Spiral_builder::US22::US22_1(v26_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v26_1_0.clone()),
                ),
            };
            let v36: Vec<string> = v34.to_vec();
            let v38: bool = true;
            let _vec_map: Vec<_> = v36
                .into_iter()
                .map(|x| {
                    //;
                    let v40: string = x;
                    let v43: &str = &*v40;
                    let v67: std::string::String = String::from(v43);
                    let v90: bool = true;
                    v67
                })
                .collect::<Vec<_>>();
            let v92: Vec<std::string::String> = _vec_map;
            let v95: () = {
                Spiral_builder::closure32(
                    v0_1,
                    v1_1,
                    v2.clone(),
                    v3,
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v20.clone(),
                    v92.clone(),
                    (),
                );
                ()
            };
            let _v138: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_3: LrcPtr<(i32, string)> = (Func0::new({
                    let v2 = v2.clone();
                    let v20 = v20.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    let v92 = v92.clone();
                    move || {
                        let v140: std::process::Command = std::process::Command::new(&*v20.clone());
                        let v142: bool = true;
                        let mut v140 = v140;
                        let v144: &mut std::process::Command =
                            std::process::Command::args(&mut v140, &*v92.clone());
                        let v146: std::process::Stdio = std::process::Stdio::piped();
                        let v148: &mut std::process::Command =
                            std::process::Command::stdout(v144, std::process::Stdio::piped());
                        let v150: std::process::Stdio = std::process::Stdio::piped();
                        let v152: &mut std::process::Command =
                            std::process::Command::stderr(v148, std::process::Stdio::piped());
                        let v154: std::process::Stdio = std::process::Stdio::piped();
                        let v156: &mut std::process::Command =
                            std::process::Command::stdin(v152, std::process::Stdio::piped());
                        let v170: Spiral_builder::US5 = defaultValue(
                            Spiral_builder::US5::US5_1,
                            map(Spiral_builder::method5(), v6.clone()),
                        );
                        let v178: &mut std::process::Command = match &v170 {
                            Spiral_builder::US5::US5_0(v170_0_0) => {
                                std::process::Command::current_dir(
                                    v156,
                                    &*match &v170 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                )
                            }
                            _ => v156,
                        };
                        let v196: &mut std::process::Command = if count_2(v2.clone()) as u64
                            == 0_u64
                        {
                            v178
                        } else {
                            let v182: Vec<(string, string)> = v2.clone().to_vec();
                            let v184: bool = true;
                            let _vec_fold_ = v182.into_iter().fold(v178, |acc, x| {
                                //;
                                let v186: &mut std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v191: &mut std::process::Command = std::process::Command::env(
                                    v186,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v193: bool = true;
                                v191
                            });
                            _vec_fold_
                        };
                        let v198: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(v196);
                        let v199 = Spiral_builder::method45();
                        let v202: Result<std::process::Child, std::string::String> =
                            v198.map_err(|x| v199(x));
                        let v214 = Spiral_builder::method94();
                        let v216: bool = true;
                        let _result_map_ = v202.map(|x| {
                            //;
                            let v222: Option<std::process::Child> = v214(Some(x));
                            let v224: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v222);
                            let v226: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v224);
                            let v228: bool = true;
                            v226
                        });
                        let v230: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v231 = Spiral_builder::method95();
                        let v232 = Spiral_builder::method96();
                        let v234: Spiral_builder::US24 = match v230 {
                            Ok(x) => v231(x),
                            Err(e) => v232(e),
                        };
                        let patternInput_3: (i32, Spiral_builder::US7, Spiral_builder::US25) =
                            match &v234 {
                                Spiral_builder::US24::US24_0(v234_0_0) => {
                                    let v235: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v234_0_0.clone();
                                    let v237: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v239: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v235.clone();
                                        let v241: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v239.lock();
                                        let v256: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = Spiral_builder::method99(v241.unwrap());
                                        let v258: bool = true;
                                        let mut v256 = v256;
                                        let v260: &mut Option<std::process::Child> = &mut v256;
                                        let v262: Option<&mut std::process::Child> = v260.as_mut();
                                        let v264: &mut std::process::Child = v262.unwrap();
                                        let v266: &mut Option<std::process::ChildStdout> =
                                            &mut v264.stdout;
                                        let v268: Option<std::process::ChildStdout> =
                                            Option::take(v266);
                                        let v270: std::process::ChildStdout = v268.unwrap();
                                        let v272: bool = true;
                                        v270
                                    })();
                                    let v274: std::process::ChildStdout = _capture;
                                    let v276: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v278: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v235.clone();
                                        let v280: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v278.lock();
                                        let v295: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = Spiral_builder::method99(v280.unwrap());
                                        let v297: bool = true;
                                        let mut v295 = v295;
                                        let v299: &mut Option<std::process::Child> = &mut v295;
                                        let v301: Option<&mut std::process::Child> = v299.as_mut();
                                        let v303: &mut std::process::Child = v301.unwrap();
                                        let v305: &mut Option<std::process::ChildStderr> =
                                            &mut v303.stderr;
                                        let v307: Option<std::process::ChildStderr> =
                                            Option::take(v305);
                                        let v309: std::process::ChildStderr = v307.unwrap();
                                        let v311: bool = true;
                                        v309
                                    })();
                                    let v313: std::process::ChildStderr = _capture;
                                    let v315: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v317: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v235.clone();
                                        let v319: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v317.lock();
                                        let v334: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = Spiral_builder::method99(v319.unwrap());
                                        let v336: bool = true;
                                        let mut v334 = v334;
                                        let v338: &mut Option<std::process::Child> = &mut v334;
                                        let v340: Option<&mut std::process::Child> = v338.as_mut();
                                        let v342: &mut std::process::Child = v340.unwrap();
                                        let v344: &mut Option<std::process::ChildStdin> =
                                            &mut v342.stdin;
                                        let v346: Option<std::process::ChildStdin> =
                                            Option::take(v344);
                                        let v348: std::process::ChildStdin = v346.unwrap();
                                        let v353: Option<std::process::ChildStdin> =
                                            (Spiral_builder::method100())(Some(v348));
                                        let v355: std::sync::Mutex<
                                            Option<std::process::ChildStdin>,
                                        > = std::sync::Mutex::new(v353);
                                        let v357: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = std::sync::Arc::new(v355);
                                        let v359: bool = true;
                                        v357
                                    })();
                                    let v361: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = _capture;
                                    let patternInput_2: (
                                        std::sync::mpsc::Sender<std::string::String>,
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    ) = {
                                        let (sender, receiver) = std::sync::mpsc::channel();
                                        (sender, std::sync::Arc::new(receiver))
                                    };
                                    let v363: std::sync::mpsc::Sender<std::string::String> =
                                        patternInput_2.0.clone();
                                    let v366: std::sync::mpsc::Sender<std::string::String> =
                                        (Spiral_builder::method101())(v363.clone());
                                    let v368: std::sync::Mutex<
                                        std::sync::mpsc::Sender<std::string::String>,
                                    > = std::sync::Mutex::new(v366);
                                    let v370: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        >,
                                    > = std::sync::Arc::new(v368);
                                    let v372: std::sync::mpsc::Sender<std::string::String> =
                                        (Spiral_builder::method102())(v363);
                                    let v374: std::sync::Mutex<
                                        std::sync::mpsc::Sender<std::string::String>,
                                    > = std::sync::Mutex::new(v372);
                                    let v376: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        >,
                                    > = std::sync::Arc::new(v374);
                                    let v378: std::sync::Arc<
                                        std::sync::mpsc::Receiver<std::string::String>,
                                    > = (Spiral_builder::method103())(patternInput_2.1.clone());
                                    let v380: std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = std::sync::Mutex::new(v378);
                                    let v382: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = std::sync::Arc::new(v380);
                                    let v384: bool = true;
                                    let __spawn = std::thread::spawn(move || {
                                        //;
                                        let v386: encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                            .utf8_passthru(true)
                                            .build(v274);
                                        let v388: std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        > = std::io::BufReader::new(v386);
                                        let v390: std::io::Lines<
                                            std::io::BufReader<
                                                encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStdout,
                                                    Vec<u8>,
                                                >,
                                            >,
                                        > = std::io::BufRead::lines(v388);
                                        let v392: bool = true;
                                        let mut v390 = v390;
                                        let _iter_try_for_each = v390.try_for_each(|x| {
                                            //;
                                            let v394: Result<std::string::String, std::io::Error> =
                                                x;
                                            let v396: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v370.clone();
                                            let v397 = Spiral_builder::method45();
                                            let v400: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v394.map_err(|x| v397(x));
                                            let v412 = Spiral_builder::method104();
                                            let v413 = Spiral_builder::method105();
                                            let v415: Spiral_builder::US26 = match v400 {
                                                Ok(x) => v412(x),
                                                Err(e) => v413(e),
                                            };
                                            let v610: std::string::String = match &v415 {
                                                Spiral_builder::US26::US26_0(v415_0_0) => {
                                                    let v418: string =
                                                        fable_library_rust::String_::fromString(
                                                            v415_0_0.clone(),
                                                        );
                                                    let v420: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v422: std::borrow::Cow<[u8]> =
                                                        v420.encode(&*v418).0;
                                                    let v424: &[u8] = v422.as_ref();
                                                    let v426: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v424);
                                                    let v429: &str = v426.unwrap();
                                                    let v460: std::string::String =
                                                        String::from(v429);
                                                    let v467: string = sprintf!(
                                                        "> {}",
                                                        fable_library_rust::String_::fromString(
                                                            v460.clone()
                                                        )
                                                    );
                                                    if v5 {
                                                        let v470: () = {
                                                            Spiral_builder::closure43(
                                                                v467.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v515: () = {
                                                            Spiral_builder::closure10(v467, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    v460
                                                }
                                                Spiral_builder::US26::US26_1(v415_1_0) => {
                                                    let v517: std::string::String =
                                                        v415_1_0.clone();
                                                    let v520: () = {
                                                        Spiral_builder::closure42(
                                                            v5,
                                                            v517.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v560: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v517
                                                    );
                                                    let v563: &str = &*v560;
                                                    String::from(v563)
                                                }
                                            };
                                            let v612: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v396;
                                            let v614: Result<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            > = v612.lock();
                                            let v617: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v614.unwrap();
                                            let v630: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v617;
                                            let v632: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v630.send(v610);
                                            let v633 = Spiral_builder::method110();
                                            let v636: Result<(), std::string::String> =
                                                v632.map_err(|x| v633(x));
                                            let v649: _ = v636;
                                            let v651: bool = true;
                                            v649
                                        }); //;
                                        let v654: Result<(), string> = Spiral_builder::method111(
                                            _iter_try_for_each.map_err(|x| x.into()),
                                        );
                                        let v657: string = string("}");
                                        let v661: bool = true;
                                        let v658 = v654;
                                        let v673: string = append(
                                            append(
                                                append(
                                                    append(string("true; v658 "), v657),
                                                    string("); "),
                                                ),
                                                string(""),
                                            ),
                                            string(" // rust.fix_closure\'"),
                                        );
                                        let v674: bool = true;
                                        v658
                                    }); // rust.fix_closure';
                                    let v676: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                    let v678: bool = true;
                                    let __spawn = std::thread::spawn(move || {
                                        //;
                                        let v680: encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                            .utf8_passthru(true)
                                            .build(v313);
                                        let v682: std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        > = std::io::BufReader::new(v680);
                                        let v684: std::io::Lines<
                                            std::io::BufReader<
                                                encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStderr,
                                                    Vec<u8>,
                                                >,
                                            >,
                                        > = std::io::BufRead::lines(v682);
                                        let v686: bool = true;
                                        let mut v684 = v684;
                                        let _iter_try_for_each = v684.try_for_each(|x| {
                                            //;
                                            let v688: Result<std::string::String, std::io::Error> =
                                                x;
                                            let v690: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v376.clone();
                                            let v691 = Spiral_builder::method45();
                                            let v694: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v688.map_err(|x| v691(x));
                                            let v706 = Spiral_builder::method104();
                                            let v707 = Spiral_builder::method105();
                                            let v709: Spiral_builder::US26 = match v694 {
                                                Ok(x) => v706(x),
                                                Err(e) => v707(e),
                                            };
                                            let v952: std::string::String = match &v709 {
                                                Spiral_builder::US26::US26_0(v709_0_0) => {
                                                    let v712: string =
                                                        fable_library_rust::String_::fromString(
                                                            v709_0_0.clone(),
                                                        );
                                                    let v714: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v716: std::borrow::Cow<[u8]> =
                                                        v714.encode(&*v712).0;
                                                    let v718: &[u8] = v716.as_ref();
                                                    let v720: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v718);
                                                    let v723: &str = v720.unwrap();
                                                    let v754: std::string::String =
                                                        String::from(v723);
                                                    let v761: string = sprintf!(
                                                        "! {}",
                                                        fable_library_rust::String_::fromString(
                                                            v754.clone()
                                                        )
                                                    );
                                                    if v5 {
                                                        let v764: () = {
                                                            Spiral_builder::closure43(
                                                                v761.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v808: () = {
                                                            Spiral_builder::closure10(v761, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    {
                                                        let v810: string = sprintf!(
                                                            "\u{001b}[4;7m{}\u{001b}[0m",
                                                            v754
                                                        );
                                                        let v813: &str = &*v810;
                                                        String::from(v813)
                                                    }
                                                }
                                                Spiral_builder::US26::US26_1(v709_1_0) => {
                                                    let v859: std::string::String =
                                                        v709_1_0.clone();
                                                    let v862: () = {
                                                        Spiral_builder::closure42(
                                                            v5,
                                                            v859.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v902: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v859
                                                    );
                                                    let v905: &str = &*v902;
                                                    String::from(v905)
                                                }
                                            };
                                            let v954: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v690;
                                            let v956: Result<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            > = v954.lock();
                                            let v959: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v956.unwrap();
                                            let v972: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v959;
                                            let v974: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v972.send(v952);
                                            let v975 = Spiral_builder::method110();
                                            let v978: Result<(), std::string::String> =
                                                v974.map_err(|x| v975(x));
                                            let v991: _ = v978;
                                            let v993: bool = true;
                                            v991
                                        }); //;
                                        let v996: Result<(), string> = Spiral_builder::method111(
                                            _iter_try_for_each.map_err(|x| x.into()),
                                        );
                                        let v997: string = string("}");
                                        let v1001: bool = true;
                                        let v998 = v996;
                                        let v1013: string = append(
                                            append(
                                                append(
                                                    append(string("true; v998 "), v997),
                                                    string("); "),
                                                ),
                                                string(""),
                                            ),
                                            string(" // rust.fix_closure\'"),
                                        );
                                        let v1014: bool = true;
                                        v998
                                    }); // rust.fix_closure';
                                    let v1016: std::thread::JoinHandle<Result<(), string>> =
                                        __spawn;
                                    let v1030: Spiral_builder::US27 = defaultValue(
                                        Spiral_builder::US27::US27_1,
                                        map(Spiral_builder::method112(), v4.clone()),
                                    );
                                    match &v1030 {
                                        Spiral_builder::US27::US27_0(v1030_0_0) => {
                                            let v1036: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::ChildStdin>>,
                                            > = v361;
                                            let v1038: Result<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::ChildStdin>,
                                                    >,
                                                >,
                                            > = v1036.lock();
                                            let v1053: std::sync::MutexGuard<
                                                Option<std::process::ChildStdin>,
                                            > = Spiral_builder::method113(v1038.unwrap());
                                            let v1055: bool = true;
                                            let mut v1053 = v1053;
                                            let v1057: &mut Option<std::process::ChildStdin> =
                                                &mut v1053;
                                            let v1059: Option<std::process::ChildStdin> =
                                                Option::take(v1057);
                                            let v1061: bool = true;
                                            let _optionm_map_ = v1059.map(|x| {
                                                //;
                                                let v1063: std::process::ChildStdin = x;
                                                let v1065: std::sync::Mutex<
                                                    std::process::ChildStdin,
                                                > = std::sync::Mutex::new(v1063);
                                                let v1067: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = std::sync::Arc::new(v1065);
                                                let v1069: bool = true;
                                                v1067
                                            });
                                            let v1071: Option<
                                                std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                >,
                                            > = _optionm_map_;
                                            let v1085: Spiral_builder::US28 = defaultValue(
                                                Spiral_builder::US28::US28_1,
                                                map(Spiral_builder::method114(), v1071),
                                            );
                                            match &v1085 {
                                                Spiral_builder::US28::US28_0(v1085_0_0) => {
                                                    let v1089: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = match &v1085 {
                                                        Spiral_builder::US28::US28_0(x) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    };
                                                    (match &v1030 {
                                                        Spiral_builder::US27::US27_0(x) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    })(
                                                        v1089.clone()
                                                    );
                                                    {
                                                        let v1091: std::sync::Arc<
                                                            std::sync::Mutex<
                                                                std::process::ChildStdin,
                                                            >,
                                                        > = v1089;
                                                        let v1093: Result<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                            std::sync::PoisonError<
                                                                std::sync::MutexGuard<
                                                                    std::process::ChildStdin,
                                                                >,
                                                            >,
                                                        > = v1091.lock();
                                                        let v1108: std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        > = Spiral_builder::method115(
                                                            v1093.unwrap(),
                                                        );
                                                        let v1110: bool = true;
                                                        let mut v1108 = v1108;
                                                        let v1112: bool = true;
                                                        std::io::Write::flush(&mut *v1108).unwrap();
                                                        ()
                                                    }
                                                }
                                                _ => (),
                                            }
                                        }
                                        _ => (),
                                    }
                                    {
                                        let v1114: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v235;
                                        let v1116: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v1114.lock();
                                        let v1131: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = Spiral_builder::method99(v1116.unwrap());
                                        let v1133: bool = true;
                                        let mut v1131 = v1131;
                                        let v1135: &mut Option<std::process::Child> = &mut v1131;
                                        let v1137: Option<std::process::Child> =
                                            Option::take(v1135);
                                        let v1139: std::process::Child = v1137.unwrap();
                                        let v1141: Result<std::process::Output, std::io::Error> =
                                            v1139.wait_with_output();
                                        let v1142 = Spiral_builder::method45();
                                        let v1154: Result<
                                            std::process::Output,
                                            std::string::String,
                                        > = v1141.map_err(|x| v1142(x));
                                        let v1157: std::thread::JoinHandle<Result<(), string>> =
                                            Spiral_builder::method116(v1016);
                                        let v1160: string = string("v1157");
                                        let v1161: std::thread::JoinHandle<Result<(), string>> =
                                            Spiral_builder::method116(v676);
                                        let v1166: string = append(
                                            append(
                                                string("vec!["),
                                                append(string("v1161, "), v1160),
                                            ),
                                            string("]"),
                                        );
                                        let v1167: Vec<
                                            std::thread::JoinHandle<Result<(), string>>,
                                        > = vec![v1161, v1157];
                                        let v1169: bool = true;
                                        v1167.into_iter().for_each(|x| {
                                            //;
                                            let v1171: std::thread::JoinHandle<Result<(), string>> =
                                                x;
                                            let v1173: Result<
                                                Result<(), string>,
                                                Box<dyn core::any::Any + 'static + Send>,
                                            > = std::thread::JoinHandle::join(v1171);
                                            let v1176: Result<(), string> = v1173.unwrap();
                                            v1176.unwrap();
                                            ();
                                            {
                                                let v1193: bool = true;
                                                let v1195: bool = true;
                                            }
                                        });
                                        {
                                            //;
                                            let v1196 = Spiral_builder::method117();
                                            let v1197 = Spiral_builder::method118();
                                            let v1198: Spiral_builder::US29 = match &v1154 {
                                                Err(v1154_1_0) => v1197(v1154_1_0.clone()),
                                                Ok(v1154_0_0) => v1196(v1154_0_0.clone()),
                                            };
                                            match &v1198 {
                                                Spiral_builder::US29::US29_0(v1198_0_0) => {
                                                    let v1201: std::process::ExitStatus =
                                                        v1198_0_0.clone().status;
                                                    let v1203: Option<i32> = v1201.code();
                                                    let v1217: Spiral_builder::US30 = defaultValue(
                                                        Spiral_builder::US30::US30_1,
                                                        map(Spiral_builder::method120(), v1203),
                                                    );
                                                    match &v1217 {
                                                        Spiral_builder::US30::US30_0(v1217_0_0) => (
                                                            match &v1217 {
                                                                Spiral_builder::US30::US30_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            Spiral_builder::US7::US7_1,
                                                            Spiral_builder::US25::US25_0(
                                                                v382.clone(),
                                                            ),
                                                        ),
                                                        _ => {
                                                            let v1227:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                            (
                                                                -1_i32,
                                                                Spiral_builder::US7::US7_0(
                                                                    String::from(v1227),
                                                                ),
                                                                Spiral_builder::US25::US25_0(
                                                                    v382.clone(),
                                                                ),
                                                            )
                                                        }
                                                    }
                                                }
                                                Spiral_builder::US29::US29_1(v1198_1_0) => {
                                                    let v1281: std::string::String =
                                                        v1198_1_0.clone();
                                                    let v1284: () = {
                                                        Spiral_builder::closure49(
                                                            v1281.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    (
                                                        -2_i32,
                                                        Spiral_builder::US7::US7_0(v1281),
                                                        Spiral_builder::US25::US25_1,
                                                    )
                                                }
                                            }
                                        }
                                    }
                                }
                                Spiral_builder::US24::US24_1(v234_1_0) => {
                                    let v1332: std::string::String = v234_1_0.clone();
                                    let v1335: () = {
                                        Spiral_builder::closure36(v1332.clone(), ());
                                        ()
                                    };
                                    (
                                        -1_i32,
                                        Spiral_builder::US7::US7_0(v1332),
                                        Spiral_builder::US25::US25_1,
                                    )
                                }
                            };
                        let v1382: Spiral_builder::US25 = patternInput_3.2.clone();
                        let v1381: Spiral_builder::US7 = patternInput_3.1.clone();
                        let v1380: i32 = patternInput_3.0.clone();
                        let v1389: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v1382 {
                            Spiral_builder::US25::US25_0(v1382_0_0) => Some(match &v1382 {
                                Spiral_builder::US25::US25_0(x) => x.clone(),
                                _ => unreachable!(),
                            }),
                            _ => {
                                None::<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                >
                            }
                        };
                        let v1391: bool = true;
                        let _optionm_map_ = v1389.map(|x| {
                            //;
                            let v1393: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v1395: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v1393;
                            let v1397: Result<
                                std::sync::MutexGuard<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                                std::sync::PoisonError<
                                    std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                >,
                            > = v1395.lock();
                            let v1400: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v1397.unwrap();
                            let v1413 = v1400.iter();
                            let v1415: Vec<std::string::String> = v1413.collect::<Vec<_>>();
                            let v1417: bool = true;
                            let _vec_map: Vec<_> = v1415
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v1419: std::string::String = x;
                                    let v1421: string =
                                        fable_library_rust::String_::fromString(v1419);
                                    let v1423: bool = true;
                                    v1421
                                })
                                .collect::<Vec<_>>();
                            let v1425: Vec<string> = _vec_map;
                            let v1428: LrcPtr<dyn IEnumerable_1<string>> =
                                ofArray_1(fable_library_rust::NativeArray_::array_from(v1425));
                            let v1434: string = join(Spiral_builder::method39(), toArray_1(v1428));
                            let v1439: bool = true;
                            v1434
                        });
                        let v1441: Option<string> = _optionm_map_;
                        let v1448: Spiral_builder::US5 = match &v1381 {
                            Spiral_builder::US7::US7_0(v1381_0_0) => Spiral_builder::US5::US5_0(
                                fable_library_rust::String_::fromString(match &v1381 {
                                    Spiral_builder::US7::US7_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                            ),
                            _ => Spiral_builder::US5::US5_1,
                        };
                        let v1453: string = defaultValue(
                            match &v1448 {
                                Spiral_builder::US5::US5_0(v1448_0_0) => match &v1448 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => string(""),
                            },
                            v1441,
                        );
                        let v1458: () = {
                            Spiral_builder::closure51(v1380, v1453.clone(), ());
                            ()
                        };
                        LrcPtr::new((v1380, v1453))
                    }
                }))();
                _v138.set(Some(x_3))
            }
            {
                let v1500: LrcPtr<(i32, string)> = match &_v138.get().clone() {
                    None => panic!("{}", string("base.capture / _v138=None"),),
                    Some(_v138_0_0) => _v138_0_0.clone(),
                };
                let _v7: (i32, string) = (v1500.0.clone(), v1500.1.clone());
                (_v7.0.clone(), _v7.1.clone())
            }
        }
        pub fn method134(v0_1: Spiral_builder::US10, v1_1: i32, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("env")), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v41: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            let v50: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v59: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v67: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v75: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v83: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v92: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("run_result")), ());
                ()
            };
            let v100: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v108: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v116: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v125: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v133: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v141: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v150: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method133(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Spiral_builder::US10,
            v9: i32,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method134(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_cuda / env install error"),
                v12
            ))
        }
        pub fn closure61(
            v0_1: Spiral_builder::US10,
            v1_1: string,
            v2: string,
            v3: i32,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method133(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method48(),
                    v0_1,
                    v3,
                    v2,
                    v1_1,
                ))
            };
        }
        pub fn closure62(unitVar: (), v0_1: string) -> Spiral_builder::US5 {
            Spiral_builder::US5::US5_0(v0_1)
        }
        pub fn closure63(v0_1: string, unitVar: ()) -> string {
            let v5: LrcPtr<dyn IEnumerable_1<string>> =
                ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32));
            join(Spiral_builder::method39(), toArray_1(v5))
        }
        pub fn method136(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: std::string::String = format!("{:#?}", v0_1);
            let v68: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v35)),
                    (),
                );
                ()
            };
            let v77: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v86: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("run_result")), ());
                ()
            };
            let v94: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v102: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v110: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v119: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v127: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v143: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", string("external_command")),
                    (),
                );
                ()
            };
            let v160: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v168: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v177: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method135(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<Exception>,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method136(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_cuda / Exception"),
                v12
            ))
        }
        pub fn closure65(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method135(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method48(),
                    v3,
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn closure64(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US5 {
            let v6: () = {
                Spiral_builder::closure65(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US5::US5_1
        }
        pub fn method138(v0_1: i32, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v56: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("run_result")), ());
                ()
            };
            let v64: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v72: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v80: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v89: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v97: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v105: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v122: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", string("external_command")),
                    (),
                );
                ()
            };
            let v130: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v138: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v147: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method137(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method138(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_cuda / error"),
                v12
            ))
        }
        pub fn closure66(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method137(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method48(),
                    v2,
                    v1_1,
                    v0_1,
                    v3,
                ))
            };
        }
        pub fn closure67(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v4: &str = &*_arg.0.clone();
            let v28: std::string::String = String::from(v4);
            let v52: &str = &*_arg.1.clone();
            LrcPtr::new((v28, String::from(v52)))
        }
        pub fn method139() -> string {
            string("fs-path")
        }
        pub fn method140() -> string {
            string("command")
        }
        pub fn method141() -> string {
            string("path")
        }
        pub fn method150(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v5: std::string::String = format!("{:#?}", v0_1);
            let v38: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v5)),
                    (),
                );
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure69(unitVar: (), v0_1: std::io::Error) -> string {
            Spiral_builder::method150(v0_1)
        }
        pub fn method149() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Spiral_builder::closure69((), v))
        }
        pub fn closure70(unitVar: (), v0_1: std::path::PathBuf) -> Spiral_builder::US33 {
            Spiral_builder::US33::US33_0(v0_1)
        }
        pub fn method151() -> Func1<std::path::PathBuf, Spiral_builder::US33> {
            Func1::new(move |v: std::path::PathBuf| Spiral_builder::closure70((), v))
        }
        pub fn closure71(unitVar: (), v0_1: string) -> Spiral_builder::US33 {
            Spiral_builder::US33::US33_1(v0_1)
        }
        pub fn method152() -> Func1<string, Spiral_builder::US33> {
            Func1::new(move |v: string| Spiral_builder::closure71((), v))
        }
        pub fn method155(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v8: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method154(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Spiral_builder::method62(v4.clone());
            let v6: Option<string> = Spiral_builder::method33(v4.clone());
            let v20: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method5(), v6),
            );
            let v24: string = Spiral_builder::method155(v3);
            if v2 >= 11_u8 {
                let v26: string = sprintf!(
                    "file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2,
                    v4.clone(),
                    v5.clone()
                );
                let v29: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v26);
                Err(v29)
            } else {
                if let Spiral_builder::US5::US5_0(v20_0_0) = &v20 {
                    if v4.clone() != string("") {
                        let v72: Result<std::path::PathBuf, std::io::Error> = v1_1(
                            v2 + 1_u8,
                            match &v20 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v73 = Spiral_builder::method149();
                        let v85: Result<std::path::PathBuf, string> = v72.map_err(|x| v73(x));
                        let v88 = Spiral_builder::method151();
                        let v89 = Spiral_builder::method152();
                        let v90: Spiral_builder::US33 = match &v85 {
                            Err(v85_1_0) => v89(v85_1_0.clone()),
                            Ok(v85_0_0) => v88(v85_0_0.clone()),
                        };
                        match &v90 {
                            Spiral_builder::US33::US33_0(v90_0_0) => {
                                let v119: string = Spiral_builder::method27(
                                    toString(v90_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v122: &str = &*v119;
                                let v146: std::string::String = String::from(v122);
                                let v170: std::path::PathBuf = std::path::PathBuf::from(v146);
                                Ok(v170)
                            }
                            Spiral_builder::US33::US33_1(v90_1_0) => {
                                let v207: string = sprintf!(
                                    "file_system.read_link / error\': {} / error: {} / name: {}",
                                    v90_1_0.clone(),
                                    v24.clone(),
                                    v5.clone()
                                );
                                let v210: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v207);
                                Err(v210)
                            }
                        }
                    } else {
                        let v248: string =
                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                     v0_1.clone(), v24.clone(), v4.clone(),
                                     v5.clone());
                        let v251: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v248);
                        Err(v251)
                    }
                } else {
                    let v288: string =
                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                 v0_1, v24, v4, v5.clone());
                    let v291: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v288);
                    Err(v291)
                }
            }
        }
        pub fn method153(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v6 = Spiral_builder::method149();
            let v18: Result<std::path::PathBuf, string> = v5.map_err(|x| v6(x));
            let v21 = Spiral_builder::method151();
            let v22 = Spiral_builder::method152();
            let v23: Spiral_builder::US33 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v23 {
                Spiral_builder::US33::US33_0(v23_0_0) => Ok(v23_0_0.clone()),
                Spiral_builder::US33::US33_1(v23_1_0) => Spiral_builder::method154(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Spiral_builder::closure72(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v23_1_0.clone(),
                    v2,
                ),
            }
        }
        pub fn closure73(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Spiral_builder::method153(v0_1, v1_1, v2)
        }
        pub fn closure72(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Spiral_builder::closure73(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method156(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Spiral_builder::method62(v0_1.clone());
            let v5: Option<string> = Spiral_builder::method33(v0_1.clone());
            let v19: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method5(), v5),
            );
            let v23: string = Spiral_builder::method155(v3);
            if v2 >= 11_u8 {
                let v25: string = sprintf!(
                    "file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2,
                    v0_1.clone(),
                    v4.clone()
                );
                let v28: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v25);
                Err(v28)
            } else {
                if let Spiral_builder::US5::US5_0(v19_0_0) = &v19 {
                    if v0_1.clone() != string("") {
                        let v71: Result<std::path::PathBuf, std::io::Error> = v1_1(
                            v2 + 1_u8,
                            match &v19 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v72 = Spiral_builder::method149();
                        let v84: Result<std::path::PathBuf, string> = v71.map_err(|x| v72(x));
                        let v87 = Spiral_builder::method151();
                        let v88 = Spiral_builder::method152();
                        let v89: Spiral_builder::US33 = match &v84 {
                            Err(v84_1_0) => v88(v84_1_0.clone()),
                            Ok(v84_0_0) => v87(v84_0_0.clone()),
                        };
                        match &v89 {
                            Spiral_builder::US33::US33_0(v89_0_0) => {
                                let v118: string = Spiral_builder::method27(
                                    toString(v89_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v121: &str = &*v118;
                                let v145: std::string::String = String::from(v121);
                                let v169: std::path::PathBuf = std::path::PathBuf::from(v145);
                                Ok(v169)
                            }
                            Spiral_builder::US33::US33_1(v89_1_0) => {
                                let v206: string = sprintf!(
                                    "file_system.read_link / error\': {} / error: {} / name: {}",
                                    v89_1_0.clone(),
                                    v23.clone(),
                                    v4.clone()
                                );
                                let v209: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v206);
                                Err(v209)
                            }
                        }
                    } else {
                        let v247: string =
                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                     v0_1.clone(), v23.clone(), v0_1.clone(),
                                     v4.clone());
                        let v250: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v247);
                        Err(v250)
                    }
                } else {
                    let v287: string =
                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                 v0_1.clone(), v23, v0_1, v4.clone());
                    let v290: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v287);
                    Err(v290)
                }
            }
        }
        pub fn method148(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v5 = Spiral_builder::method149();
            let v17: Result<std::path::PathBuf, string> = v4.map_err(|x| v5(x));
            let v20 = Spiral_builder::method151();
            let v21 = Spiral_builder::method152();
            let v22: Spiral_builder::US33 = match &v17 {
                Err(v17_1_0) => v21(v17_1_0.clone()),
                Ok(v17_0_0) => v20(v17_0_0.clone()),
            };
            match &v22 {
                Spiral_builder::US33::US33_0(v22_0_0) => Ok(v22_0_0.clone()),
                Spiral_builder::US33::US33_1(v22_1_0) => Spiral_builder::method156(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Spiral_builder::closure72(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v22_1_0.clone(),
                ),
            }
        }
        pub fn method159(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Spiral_builder::method62(v4.clone());
            let v6: Option<string> = Spiral_builder::method33(v4.clone());
            let v20: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method5(), v6),
            );
            let v24: string = Spiral_builder::method150(v3);
            if v2 >= 11_u8 {
                let v26: string = sprintf!(
                    "file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2,
                    v4.clone(),
                    v5.clone()
                );
                let v29: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v26);
                Err(v29)
            } else {
                if let Spiral_builder::US5::US5_0(v20_0_0) = &v20 {
                    if v4.clone() != string("") {
                        let v72: Result<std::path::PathBuf, std::io::Error> = v1_1(
                            v2 + 1_u8,
                            match &v20 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v73 = Spiral_builder::method149();
                        let v85: Result<std::path::PathBuf, string> = v72.map_err(|x| v73(x));
                        let v88 = Spiral_builder::method151();
                        let v89 = Spiral_builder::method152();
                        let v90: Spiral_builder::US33 = match &v85 {
                            Err(v85_1_0) => v89(v85_1_0.clone()),
                            Ok(v85_0_0) => v88(v85_0_0.clone()),
                        };
                        match &v90 {
                            Spiral_builder::US33::US33_0(v90_0_0) => {
                                let v119: string = Spiral_builder::method27(
                                    toString(v90_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v122: &str = &*v119;
                                let v146: std::string::String = String::from(v122);
                                let v170: std::path::PathBuf = std::path::PathBuf::from(v146);
                                Ok(v170)
                            }
                            Spiral_builder::US33::US33_1(v90_1_0) => {
                                let v207: string = sprintf!(
                                    "file_system.read_link / error\': {} / error: {} / name: {}",
                                    v90_1_0.clone(),
                                    v24.clone(),
                                    v5.clone()
                                );
                                let v210: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v207);
                                Err(v210)
                            }
                        }
                    } else {
                        let v248: string =
                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                     v0_1.clone(), v24.clone(), v4.clone(),
                                     v5.clone());
                        let v251: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v248);
                        Err(v251)
                    }
                } else {
                    let v288: string =
                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                 v0_1, v24, v4, v5.clone());
                    let v291: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v288);
                    Err(v291)
                }
            }
        }
        pub fn method158(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: () = defaultOf();
            let v30: i32 = unbox::<i32>(&defaultOf());
            let v55: i32 = unbox::<i32>(&defaultOf());
            let v99: bool = unbox::<bool>(&defaultOf());
            if v99 {
                let v105: () = defaultOf();
                let v155: std::path::PathBuf = defaultOf();
                Ok(v155)
            } else {
                let v172: string =
                    sprintf!("file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {} / result: {} / path\': {} / n: {}",
                             v0_1.clone(), v99, v2.clone(), v1_1);
                Spiral_builder::method159(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Spiral_builder::closure74(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v172),
                    v2,
                )
            }
        }
        pub fn closure75(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Spiral_builder::method158(v0_1, v1_1, v2)
        }
        pub fn closure74(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Spiral_builder::closure75(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method160(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Spiral_builder::method62(v0_1.clone());
            let v5: Option<string> = Spiral_builder::method33(v0_1.clone());
            let v19: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method5(), v5),
            );
            let v23: string = Spiral_builder::method150(v3);
            if v2 >= 11_u8 {
                let v25: string = sprintf!(
                    "file_system.read_link / path: {} / n: {} / path\': {} / name: {}",
                    v0_1.clone(),
                    v2,
                    v0_1.clone(),
                    v4.clone()
                );
                let v28: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v25);
                Err(v28)
            } else {
                if let Spiral_builder::US5::US5_0(v19_0_0) = &v19 {
                    if v0_1.clone() != string("") {
                        let v71: Result<std::path::PathBuf, std::io::Error> = v1_1(
                            v2 + 1_u8,
                            match &v19 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        );
                        let v72 = Spiral_builder::method149();
                        let v84: Result<std::path::PathBuf, string> = v71.map_err(|x| v72(x));
                        let v87 = Spiral_builder::method151();
                        let v88 = Spiral_builder::method152();
                        let v89: Spiral_builder::US33 = match &v84 {
                            Err(v84_1_0) => v88(v84_1_0.clone()),
                            Ok(v84_0_0) => v87(v84_0_0.clone()),
                        };
                        match &v89 {
                            Spiral_builder::US33::US33_0(v89_0_0) => {
                                let v118: string = Spiral_builder::method27(
                                    toString(v89_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v121: &str = &*v118;
                                let v145: std::string::String = String::from(v121);
                                let v169: std::path::PathBuf = std::path::PathBuf::from(v145);
                                Ok(v169)
                            }
                            Spiral_builder::US33::US33_1(v89_1_0) => {
                                let v206: string = sprintf!(
                                    "file_system.read_link / error\': {} / error: {} / name: {}",
                                    v89_1_0.clone(),
                                    v23.clone(),
                                    v4.clone()
                                );
                                let v209: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v206);
                                Err(v209)
                            }
                        }
                    } else {
                        let v247: string =
                            sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                     v0_1.clone(), v23.clone(), v0_1.clone(),
                                     v4.clone());
                        let v250: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v247);
                        Err(v250)
                    }
                } else {
                    let v287: string =
                        sprintf!("file_system.read_link / run / The file or directory is not a reparse point. / path: {} / error: {} / path\': {} / name: {}",
                                 v0_1.clone(), v23, v0_1, v4.clone());
                    let v290: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v287);
                    Err(v290)
                }
            }
        }
        pub fn method157(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v3: () = defaultOf();
            let v29: i32 = unbox::<i32>(&defaultOf());
            let v54: i32 = unbox::<i32>(&defaultOf());
            let v98: bool = unbox::<bool>(&defaultOf());
            if v98 {
                let v104: () = defaultOf();
                let v154: std::path::PathBuf = defaultOf();
                Ok(v154)
            } else {
                let v171: string =
                    sprintf!("file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {} / result: {} / path\': {} / n: {}",
                             v0_1.clone(), v98, v0_1.clone(), v1_1);
                Spiral_builder::method160(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Spiral_builder::closure74(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v171),
                )
            }
        }
        pub fn method147(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Spiral_builder::method31(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Spiral_builder::method148(v0_1, 0_u8)
            }
        }
        pub fn closure76(unitVar: (), v0_1: std::path::PathBuf) -> Spiral_builder::US34 {
            Spiral_builder::US34::US34_0(v0_1)
        }
        pub fn method161() -> Func1<std::path::PathBuf, Spiral_builder::US34> {
            Func1::new(move |v: std::path::PathBuf| Spiral_builder::closure76((), v))
        }
        pub fn method163(v0_1: string) -> string {
            v0_1
        }
        pub fn method162(v0_1: string, v1_1: string, v2: string) -> string {
            let v5: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v8: regex::Regex = v5.unwrap();
            let v20: string = Spiral_builder::method163(v2);
            let v22: std::borrow::Cow<str> = v8.replace_all(&*v20, &*v1_1);
            let v24: std::string::String = String::from(v22);
            fable_library_rust::String_::fromString(v24)
        }
        pub fn method146(v0_1: string) -> string {
            if v0_1.clone() == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Spiral_builder::method147(v0_1.clone());
                let v6: Option<std::path::PathBuf> = v3.ok();
                let v31: Spiral_builder::US34 = defaultValue(
                    Spiral_builder::US34::US34_1,
                    map(Spiral_builder::method161(), v6),
                );
                let v66: string = match &v31 {
                    Spiral_builder::US34::US34_0(v31_0_0) => {
                        let v60: string = toString(
                            match &v31 {
                                Spiral_builder::US34::US34_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .display(),
                        );
                        if v60.clone() == string("") {
                            v0_1.clone()
                        } else {
                            v60
                        }
                    }
                    _ => v0_1.clone(),
                };
                if v66.clone() == string("") {
                    string("")
                } else {
                    let v71: string =
                        Spiral_builder::method162(string("^\\\\\\\\\\?\\\\"), string(""), v66);
                    replace(
                        sprintf!(
                            "{}{}",
                            toLower(ofChar(getCharAt(v71.clone(), 0_i32))),
                            getSlice(v71, Some(1_i32), None::<i32>)
                        ),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method164(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method165() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method166(v0_1: string) -> string {
            v0_1
        }
        pub fn method145(v0_1: string) -> string {
            let v4: &str = &*v0_1.clone();
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v52.exists() == false {
                let v77: string = Spiral_builder::method38();
                let v81: Array<string> = split(
                    Spiral_builder::method146(Spiral_builder::method27(v77.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v85: i32 = count_2(v81.clone());
                let v86: LrcPtr<Spiral_builder::Mut6> = LrcPtr::new(Spiral_builder::Mut6 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Spiral_builder::method164(v85, v86.clone()) {
                    let v88: i32 = v86.l0.get().clone();
                    let v91: i32 = v88.wrapping_neg() + v85 - 1_i32;
                    let matchValue: i32 = v86.l1.get().clone();
                    let v93: Array<string> = v86.l2.get().clone();
                    let v92: i32 = matchValue;
                    let v94: string = v81[v91].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == v94.clone() {
                        (v92 + 1_i32, v93.clone())
                    } else {
                        if string(".") == v94.clone() {
                            (v92, v93.clone())
                        } else {
                            if 0_i32 == v92 {
                                if endsWith(v94.clone(), string(":"), false) {
                                    let v102: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v77.clone(), 0_i32)
                                    )]);
                                    let v103: i32 = count_2(v102.clone());
                                    let v105: i32 = v103 + count_2(v93.clone());
                                    let v106: Array<string> = new_init(&string(""), v105);
                                    let v107: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method71(v105, v107.clone()) {
                                        let v109: i32 = v107.l0.get().clone();
                                        let v114: string = if v109 < v103 {
                                            v102[v109].clone()
                                        } else {
                                            let v112: i32 = v109 - v103;
                                            v93[v112].clone()
                                        };
                                        v106.get_mut()[v109 as usize] = v114;
                                        {
                                            let v115: i32 = v109 + 1_i32;
                                            v107.l0.set(v115);
                                            ()
                                        }
                                    }
                                    (0_i32, v106.clone())
                                } else {
                                    let v116: Array<string> = new_array(&[v94]);
                                    let v117: i32 = count_2(v116.clone());
                                    let v119: i32 = v117 + count_2(v93.clone());
                                    let v120: Array<string> = new_init(&string(""), v119);
                                    let v121: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method71(v119, v121.clone()) {
                                        let v123: i32 = v121.l0.get().clone();
                                        let v128: string = if v123 < v117 {
                                            v116[v123].clone()
                                        } else {
                                            let v126: i32 = v123 - v117;
                                            v93[v126].clone()
                                        };
                                        v120.get_mut()[v123 as usize] = v128;
                                        {
                                            let v129: i32 = v123 + 1_i32;
                                            v121.l0.set(v129);
                                            ()
                                        }
                                    }
                                    (0_i32, v120.clone())
                                }
                            } else {
                                (v92 - 1_i32, v93.clone())
                            }
                        }
                    };
                    let v139: i32 = v88 + 1_i32;
                    v86.l0.set(v139);
                    v86.l1.set(patternInput_1.0.clone());
                    v86.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v86.l1.get().clone();
                    let v141: Array<string> = v86.l2.get().clone();
                    let _v142: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v141 = v141.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v141 = v141.clone();
                                    move |i: i32| v141[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, count_2(v141.clone()) - 1_i32),
                            )
                        }
                    }));
                    let v151: string = ofChar(Spiral_builder::method165());
                    join(
                        if v151.clone() == string("\n") {
                            Spiral_builder::method166(v151.clone())
                        } else {
                            v151
                        },
                        toArray_1(_v142),
                    )
                }
            } else {
                let v163: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v166: std::path::PathBuf = v163.unwrap();
                let v180: std::path::Display = v166.display();
                let v204: std::string::String = format!("{}", v180);
                fable_library_rust::String_::fromString(v204)
            }
        }
        pub fn method144(v0_1: string) -> string {
            Spiral_builder::method146(Spiral_builder::method145(v0_1))
        }
        pub fn method143(v0_1: string) -> string {
            Spiral_builder::method144(Spiral_builder::method27(Spiral_builder::method38(), v0_1))
        }
        pub fn closure68(unitVar: (), v0_1: std::string::String) -> string {
            Spiral_builder::method143(fable_library_rust::String_::fromString(v0_1))
        }
        pub fn method142() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure68((), v))
        }
        pub fn method167() -> string {
            string("retries")
        }
        pub fn method168() -> string {
            string("working-directory")
        }
        pub fn method171(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v11: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v29: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("repl_result")), ());
                ()
            };
            let v63: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v96: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v104: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v113: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method170(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
        ) -> string {
            let v11: string = Spiral_builder::method171(v8, v9, v10);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / repl error"),
                v11
            ))
        }
        pub fn closure77(v0_1: u8, v1_1: u8, v2: string, v3: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method170(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method11(),
                    v3,
                    v2,
                    sprintf!("{}/{}", v1_1, v0_1),
                ))
            };
        }
        pub fn method169(v0_1: Spiral_builder::US5, v1_1: u8, v2: string, v3: u8) -> (i32, string) {
            let v0_1: MutCell<Spiral_builder::US5> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<u8> = MutCell::new(v1_1);
            let v2: MutCell<string> = MutCell::new(v2.clone());
            let v3: MutCell<u8> = MutCell::new(v3);
            '_method169: loop {
                break '_method169 ({
                    let patternInput: (i32, string) = Spiral_builder::method67(
                        sprintf!(
                            "dotnet repl --exit-after-run --run \"{}\" --output-path \"{}.ipynb\"",
                            v2.get().clone(),
                            v2.get().clone()
                        ),
                        None::<CancellationToken>,
                        new_array(&[
                            (string("TRACE_LEVEL"), string("Verbose")),
                            (string("AUTOMATION"), string("True")),
                        ]),
                        None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                        false,
                        match &v0_1.get().clone() {
                            Spiral_builder::US5::US5_0(v0_1_0_0) => {
                                Some(match &v0_1.get().clone() {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => None::<string>,
                        },
                    );
                    let v24: string = patternInput.1.clone();
                    let v23: i32 = patternInput.0.clone();
                    if if v23 == 0_i32 {
                        true
                    } else {
                        v3.get().clone() >= v1_1.get().clone()
                    } {
                        (v23, v24.clone())
                    } else {
                        let v30: () = {
                            Spiral_builder::closure77(
                                v1_1.get().clone(),
                                v3.get().clone(),
                                v24,
                                v23,
                                (),
                            );
                            ()
                        };
                        {
                            let v0_1_temp: Spiral_builder::US5 = v0_1.get().clone();
                            let v1_1_temp: u8 = v1_1.get().clone();
                            let v2_temp: string = v2.get().clone();
                            let v3_temp: u8 = v3.get().clone() + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method169;
                        }
                    }
                });
            }
        }
        pub fn method173(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", string("jupyter_result_length")),
                    (),
                );
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method172(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Spiral_builder::method173(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / dib / jupyter nbconvert"),
                v10
            ))
        }
        pub fn closure78(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method172(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method11(),
                    v1_1,
                    length(v0_1),
                ))
            };
        }
        pub fn method175(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", string("pwsh_replace_html_result_length")),
                    (),
                );
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method174(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Spiral_builder::method175(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / dib / html cell ids"),
                v10
            ))
        }
        pub fn closure79(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method174(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method11(),
                    v1_1,
                    length(v0_1),
                ))
            };
        }
        pub fn method177(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("result_length")), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method176(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Spiral_builder::method177(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / dib"),
                v10
            ))
        }
        pub fn closure80(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method176(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method11(),
                    v1_1,
                    length(v0_1),
                ))
            };
        }
        pub fn method178() -> string {
            string("cleanup")
        }
        pub fn method179() -> string {
            string("wasm")
        }
        pub fn method180() -> string {
            string("contract")
        }
        pub fn method181(v0_1: string, v1_1: string, v2: Spiral_builder::US35) -> string {
            let v4: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v11: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v20: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("extension")), ());
                ()
            };
            let v29: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v37: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v55: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("code")), ());
                ()
            };
            let v63: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v71: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v88: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string("runtime")), ());
                ()
            };
            let v96: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v107: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                ()
            };
            let v116: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method183() -> string {
            string("")
        }
        pub fn method184() -> string {
            string("")
        }
        pub fn method182(v0_1: string) -> string {
            let v5: Array<u8> = {
                let _arg: LrcPtr<dyn Encoding> = get_UTF8();
                _arg.getBytes(v0_1)
            };
            let v7: Vec<u8> = v5.to_vec();
            let v9: std::io::Cursor<Vec<u8>> = std::io::Cursor::new(v7);
            let v11: std::io::BufReader<std::io::Cursor<Vec<u8>>> = std::io::BufReader::new(v9);
            let v13: bool = true;
            let mut v11 = v11;
            let result: sha2::Sha256 = sha2::Digest::new();
            {
                let v16: sha2::Sha256 = result;
                let v18: bool = true;
                let mut v16 = v16;
                let v19: usize = 0_i32 as usize;
                let v23: _ = [0_u8; 1024];
                let v25: bool = true;
                loop {
                    // rust.loop;
                    let v27: bool = true;
                    let mut v23 = v23;
                    let v29: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v11, &mut v23);
                    let v41: usize = v29.unwrap();
                    if v41 == v19 {
                        let v48: bool = true;
                        break;
                        ()
                    }
                    {
                        let v49: usize = v41;
                        let v64: &_ = if v49 == v23.len() {
                            &v23[v19..]
                        } else {
                            &v23[v19..v49]
                        };
                        sha2::Digest::update(&mut v16, v64);
                        {
                            let v67: bool = true;
                        } // rust.loop;
                        let v69: bool = true;
                    } // rust.loop;
                    let v71: bool = true;
                } // rust.loop;
                let v73: bool = true;
                {
                    // rust.loop;
                    let v75: bool = true;
                    {
                        // rust.loop;
                        let v77: &[u8] = &sha2::Digest::finalize(v16);
                        let v79: Vec<u8> = v77.iter().map(|x| *x).collect::<Vec<_>>();
                        let v81: bool = true;
                        let _vec_map: Vec<_> = v79
                            .into_iter()
                            .map(|x| {
                                //;
                                let v83: u8 = x;
                                let v85: std::string::String = format!("{:02x}", v83);
                                let v87: string = fable_library_rust::String_::fromString(v85);
                                let v89: bool = true;
                                v87
                            })
                            .collect::<Vec<_>>();
                        let v91: Vec<string> = _vec_map;
                        let v93: Array<string> = fable_library_rust::NativeArray_::array_from(v91);
                        let _v94: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v93 = v93.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v93 = v93.clone();
                                        move |i: i32| v93[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, count_2(v93.clone()) - 1_i32),
                                )
                            }
                        }));
                        let v101: string = Spiral_builder::method183();
                        let v107: string = join(
                            if v101.clone() == string("\n") {
                                Spiral_builder::method166(v101.clone())
                            } else {
                                v101
                            },
                            toArray_1(_v94),
                        );
                        Ok::<string, std::io::Error>(v107).unwrap()
                    }
                }
            }
        }
        pub fn method185(
            v0_1: Spiral_builder::US5,
            v1_1: string,
            v2: Spiral_builder::US38,
            v3: string,
        ) -> string {
            let v6: string = Spiral_builder::method27(
                Spiral_builder::method27(v3, string("target/spiral_builder")),
                v1_1,
            );
            if let Spiral_builder::US5::US5_0(v0_1_0_0) = &v0_1 {
                if let Spiral_builder::US38::US38_0(v2_0_0) = &v2 {
                    let v8: Spiral_builder::US37 = match &v2 {
                        Spiral_builder::US38::US38_0(x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v10: string = Spiral_builder::method27(v6.clone(), string("packages"));
                    let v15: Spiral_builder::US5 = if if let Spiral_builder::US37::US37_0 = &v8 {
                        true
                    } else {
                        false
                    } {
                        Spiral_builder::US5::US5_0(string("Rust"))
                    } else {
                        Spiral_builder::US5::US5_1
                    };
                    let v38: Spiral_builder::US5 = match &v15 {
                        Spiral_builder::US5::US5_0(v15_0_0) => {
                            Spiral_builder::US5::US5_0(match &v15 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            })
                        }
                        _ => {
                            let v22: Spiral_builder::US5 =
                                if if let Spiral_builder::US37::US37_1 = &v8 {
                                    true
                                } else {
                                    false
                                } {
                                    Spiral_builder::US5::US5_0(string("TypeScript"))
                                } else {
                                    Spiral_builder::US5::US5_1
                                };
                            match &v22 {
                                Spiral_builder::US5::US5_0(v22_0_0) => {
                                    Spiral_builder::US5::US5_0(match &v22 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v29: Spiral_builder::US5 =
                                        if if let Spiral_builder::US37::US37_2 = &v8 {
                                            true
                                        } else {
                                            false
                                        } {
                                            Spiral_builder::US5::US5_0(string("Python"))
                                        } else {
                                            Spiral_builder::US5::US5_1
                                        };
                                    match &v29 {
                                        Spiral_builder::US5::US5_0(v29_0_0) => {
                                            Spiral_builder::US5::US5_0(match &v29 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => Spiral_builder::US5::US5_1,
                                    }
                                }
                            }
                        }
                    };
                    Spiral_builder::method27(
                        Spiral_builder::method27(
                            v10,
                            match &v38 {
                                Spiral_builder::US5::US5_0(v38_0_0) => match &v38 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            },
                        ),
                        match &v0_1 {
                            Spiral_builder::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    )
                } else {
                    v6.clone()
                }
            } else {
                v6
            }
        }
        pub fn method187(
            v0_1: string,
            v1_1: LrcPtr<Spiral_builder::UH2>,
            v2: LrcPtr<Spiral_builder::UH2>,
        ) -> LrcPtr<Spiral_builder::UH2> {
            match v1_1.as_ref() {
                Spiral_builder::UH2::UH2_0 => v2.clone(),
                Spiral_builder::UH2::UH2_1(v1_1_1_0, v1_1_1_1) => {
                    let v5: LrcPtr<Spiral_builder::UH2> = Spiral_builder::method187(
                        v0_1.clone(),
                        match v1_1.as_ref() {
                            Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v2.clone(),
                    );
                    LrcPtr::new(Spiral_builder::UH2::UH2_1(
                        sprintf!(
                            "<Compile Include=\"{}\" />",
                            Spiral_builder::method27(
                                v0_1.clone(),
                                match v1_1.as_ref() {
                                    Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                }
                            )
                        ),
                        v5,
                    ))
                }
            }
        }
        pub fn method188(
            v0_1: LrcPtr<Spiral_builder::UH2>,
            v1_1: LrcPtr<Spiral_builder::UH2>,
        ) -> LrcPtr<Spiral_builder::UH2> {
            match v0_1.as_ref() {
                Spiral_builder::UH2::UH2_0 => v1_1.clone(),
                Spiral_builder::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                    LrcPtr::new(Spiral_builder::UH2::UH2_1(
                        sprintf!(
                            "<PackageReference Include=\"{}\" Version=\"*\" />",
                            match v0_1.as_ref() {
                                Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                        ),
                        Spiral_builder::method188(
                            match v0_1.as_ref() {
                                Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            },
                            v1_1.clone(),
                        ),
                    ))
                }
            }
        }
        pub fn method186(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Spiral_builder::UH2>,
            v3: LrcPtr<Spiral_builder::UH2>,
            v4: string,
            v5: string,
        ) -> string {
            let v6: LrcPtr<dyn IDisposable> = Spiral_builder::method43(v4.clone());
            let v9: string = Spiral_builder::method146(Spiral_builder::method27(
                v4.clone(),
                sprintf!("{}.fs", v1_1.clone()),
            ));
            Spiral_builder::method40(v9.clone(), v0_1);
            {
                let v13: List<string> = Spiral_builder::method90(
                    Spiral_builder::method187(v5, v2, LrcPtr::new(Spiral_builder::UH2::UH2_0)),
                    empty::<string>(),
                );
                let v24: string = join(
                    string("\\n        "),
                    toArray_1(delay(Func0::new({
                        let v13 = v13.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v13 = v13.clone();
                                    move |i: i32| item(i, v13.clone())
                                }),
                                rangeNumeric(0_i32, 1_i32, length_1(v13.clone()) - 1_i32),
                            )
                        }
                    }))),
                );
                let v30: List<string> = Spiral_builder::method90(
                    Spiral_builder::method188(v3, LrcPtr::new(Spiral_builder::UH2::UH2_0)),
                    empty::<string>(),
                );
                let v40: string = join(
                    string("\\n        "),
                    toArray_1(delay(Func0::new({
                        let v30 = v30.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v30 = v30.clone();
                                    move |i_1: i32| item(i_1, v30.clone())
                                }),
                                rangeNumeric(0_i32, 1_i32, length_1(v30.clone()) - 1_i32),
                            )
                        }
                    }))),
                );
                let v45: string = Spiral_builder::method146(Spiral_builder::method27(
                    v4,
                    sprintf!("{}.fsproj", v1_1),
                ));
                Spiral_builder::method40(v45.clone(),
                                         append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                    sprintf!("    {}",
                                                                                                                                             v24)),
                                                                                                                             string("\n")),
                                                                                                                      sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                               v9)),
                                                                                                               string("\n")),
                                                                                                        string("</ItemGroup>")),
                                                                                                 string("\n")),
                                                                                          string("<ItemGroup>")),
                                                                                   string("\n")),
                                                                            sprintf!("    {}",
                                                                                     v40)),
                                                                     string("\n")),
                                                              string("</ItemGroup>")),
                                                       string("\n")),
                                                string("</Project>")));
                v45
            }
        }
        pub fn closure81(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> Spiral_builder::US39 {
            Spiral_builder::US39::US39_0(v0_1)
        }
        pub fn method190() -> Func1<chrono::DateTime<chrono::Utc>, Spiral_builder::US39> {
            Func1::new(move |v: chrono::DateTime<chrono::Utc>| Spiral_builder::closure81((), v))
        }
        pub fn method191() -> string {
            string("hh:mm")
        }
        pub fn method192() -> string {
            string("yyyyMMdd-HHmm-ssff-ffff-f")
        }
        pub fn method193() -> string {
            string("hhmm")
        }
        pub fn method189(v0_1: Guid, v1_1: DateTime) -> Guid {
            let v7: DateTime = {
                let _arg: DateTime = DateTime::unixEpoch();
                _arg.toUniversalTime()
            };
            let v15: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            let v91: i64 = (v15.ticks() - v7.ticks()) / 10_i64;
            let v93: Option<chrono::DateTime<chrono::Utc>> =
                chrono::DateTime::from_timestamp_micros(v91);
            let v107: Spiral_builder::US39 = defaultValue(
                Spiral_builder::US39::US39_1,
                map(Spiral_builder::method190(), v93),
            );
            let v127: Spiral_builder::US5 = match &v107 {
                Spiral_builder::US39::US39_0(v107_0_0) => {
                    let v113: chrono::NaiveDateTime = match &v107 {
                        Spiral_builder::US39::US39_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .naive_utc();
                    let v115: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v113);
                    let v117: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                    let v118: &str = r#"%Y%m%d-%H%M-%S%f"#;
                    let v120: std::string::String = v115.format(v118).to_string();
                    let v122: string = fable_library_rust::String_::fromString(v120);
                    Spiral_builder::US5::US5_0(sprintf!(
                        "{}-{}-{}",
                        getSlice(v122.clone(), Some(0_i32), Some(17_i32)),
                        getSlice(v122.clone(), Some(18_i32), Some(21_i32)),
                        getCharAt(v122, 22_i32)
                    ))
                }
                _ => Spiral_builder::US5::US5_1,
            };
            let v131: string = match &v127 {
                Spiral_builder::US5::US5_0(v127_0_0) => match &v127 {
                    Spiral_builder::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            };
            let v134: LrcPtr<TimeZoneInfo> = std::sync::Arc::new(
                chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64,
            );
            let v157: i64 = v15.ticks();
            let v189: i64 = v157;
            let v190: string =
                string("chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos(v189))))");
            let v337: TimeSpan = TimeSpan::new_ticks(chrono::FixedOffset::local_minus_utc(
                &chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(
                    &chrono::DateTime::from_timestamp_nanos(v189),
                )),
            ) as i64);
            let v350: u8 = if v337.hours() > 0_i32 { 1_u8 } else { 0_u8 };
            let v351: string = Spiral_builder::method191();
            let v370: string = v337.to_string(v351);
            let v375: string = sprintf!(
                "{}{}{}",
                v350,
                getSlice(v370.clone(), Some(0_i32), Some(1_i32)),
                getSlice(v370, Some(3_i32), Some(4_i32))
            );
            let v377: string = toString(v0_1);
            parse(sprintf!(
                "{}{}{}",
                v131.clone(),
                v375.clone(),
                getSlice(
                    v377.clone(),
                    Some(length(v131) + length(v375)),
                    Some(length(v377) - 1_i32)
                )
            ))
        }
        pub fn method194(v0_1: string, v1_1: string) {
            if Spiral_builder::method31(v0_1.clone()) == false {
                let v4: LrcPtr<dyn IDisposable> = Spiral_builder::method43(v0_1.clone());
                ()
            }
            {
                let v7: string = defaultValue(string(""), Spiral_builder::method33(v1_1.clone()));
                if Spiral_builder::method31(v7.clone()) == false {
                    let v12: LrcPtr<dyn IDisposable> = Spiral_builder::method43(v7);
                    ()
                }
                if if Spiral_builder::method31(v1_1.clone()) {
                    let v14: Result<std::path::PathBuf, std::io::Error> =
                        Spiral_builder::method147(v1_1.clone());
                    v14.is_err()
                } else {
                    false
                } {
                    Spiral_builder::method55(true, v1_1.clone());
                }
                if Spiral_builder::method31(v1_1.clone()) == false {
                    let v30: bool = true;
                    #[cfg(windows)]
                    std::os::windows::fs::symlink_dir(&*v0_1.clone(), &*v1_1.clone()).unwrap();
                    let v32: bool = true;
                    #[cfg(unix)]
                    std::os::unix::fs::symlink(&*v0_1, &*v1_1).unwrap();
                    ();
                    ()
                }
            }
        }
        pub fn method196() -> string {
            string("(")
        }
        pub fn method197() -> string {
            string(" ")
        }
        pub fn method198(v0_1: Spiral_builder::US36) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v11: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method202(v0_1: bool, v1_1: string, v2: i32, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("is_error")), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v41: () = {
                Spiral_builder::closure7(
                    v5.clone(),
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
            let v50: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v59: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("retry")), ());
                ()
            };
            let v67: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v75: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v83: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v92: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("result")), ());
                ()
            };
            let v100: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v108: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v117: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(", ")), ());
                ()
            };
            let v125: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v134: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method201(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: bool,
            v9: string,
            v10: i32,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method202(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("common.retry_fn\' / loop"),
                v12
            ))
        }
        pub fn closure82(v0_1: u8, v1_1: u8, v2: i32, v3: string, v4: bool, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v9: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v28: Option<i64> = patternInput.5.clone();
                let v27: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v26: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v25: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v24: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v23: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method201(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_builder::method7(v23, v24, v25, v26, v27, v28),
                    Spiral_builder::method11(),
                    v4,
                    sprintf!("{}/{}", v1_1, v0_1),
                    v2,
                    v3,
                ))
            };
        }
        pub fn method200(
            v0_1: u8,
            v1_1: string,
            v2: Option<CancellationToken>,
            v3: Array<(string, string)>,
            v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v6: bool,
            v7: Option<string>,
            v8: u8,
        ) -> (i32, string) {
            let v0_1: MutCell<u8> = MutCell::new(v0_1);
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<Option<CancellationToken>> = MutCell::new(v2.clone());
            let v3: MutCell<Array<(string, string)>> = MutCell::new(v3.clone());
            let v4 = MutCell::new(v4.clone());
            let v5 = MutCell::new(v5.clone());
            let v6: MutCell<bool> = MutCell::new(v6);
            let v7: MutCell<Option<string>> = MutCell::new(v7.clone());
            let v8: MutCell<u8> = MutCell::new(v8);
            '_method200: loop {
                break '_method200 ({
                    let patternInput: (i32, string) = Spiral_builder::method67(
                        v1_1.get().clone(),
                        v2.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                        v5.get().clone(),
                        v6.get().clone(),
                        v7.get().clone(),
                    );
                    let v9: i32 = patternInput.0.clone();
                    let v10: string = patternInput.1.clone();
                    let v14: Spiral_builder::US40 = if v9 == 0_i32 {
                        Spiral_builder::US40::US40_0(v9, v10.clone())
                    } else {
                        Spiral_builder::US40::US40_1(v9, v10)
                    };
                    let patternInput_1: (bool, i32, string) = match &v14 {
                        Spiral_builder::US40::US40_0(v14_0_0, v14_0_1) => {
                            (false, v14_0_0.clone(), v14_0_1.clone())
                        }
                        Spiral_builder::US40::US40_1(v14_1_0, v14_1_1) => {
                            (true, v14_1_0.clone(), v14_1_1.clone())
                        }
                    };
                    let v24: string = patternInput_1.2.clone();
                    let v23: i32 = patternInput_1.1.clone();
                    let v22: bool = patternInput_1.0.clone();
                    if if v22 == false {
                        true
                    } else {
                        v8.get().clone() >= v0_1.get().clone()
                    } {
                        (v23, v24.clone())
                    } else {
                        let v30: () = {
                            Spiral_builder::closure82(
                                v0_1.get().clone(),
                                v8.get().clone(),
                                v23,
                                v24,
                                v22,
                                (),
                            );
                            ()
                        };
                        {
                            let v0_1_temp: u8 = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: Option<CancellationToken> = v2.get().clone();
                            let v3_temp: Array<(string, string)> = v3.get().clone();
                            let v4_temp = v4.get().clone();
                            let v5_temp = v5.get().clone();
                            let v6_temp: bool = v6.get().clone();
                            let v7_temp: Option<string> = v7.get().clone();
                            let v8_temp: u8 = v8.get().clone() + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            v5.set(v5_temp);
                            v6.set(v6_temp);
                            v7.set(v7_temp);
                            v8.set(v8_temp);
                            continue '_method200;
                        }
                    }
                });
            }
        }
        pub fn method199(
            v0_1: u8,
            v1_1: string,
            v2: Option<CancellationToken>,
            v3: Array<(string, string)>,
            v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v6: bool,
            v7: Option<string>,
        ) -> (i32, string) {
            Spiral_builder::method200(v0_1, v1_1, v2, v3, v4, v5, v6, v7, 1_u8)
        }
        pub fn method195(
            v0_1: Spiral_builder::US35,
            v1_1: string,
            v2: string,
            v3: string,
            v4: Spiral_builder::US12,
        ) -> (i32, string) {
            let v137: string = sprintf!(
                "dotnet fable \"{}\" --optimize --lang {} --extension .{} --outDir \"{}\"{}{}",
                v3,
                v2.clone(),
                v2,
                v1_1,
                sprintf!(
                    " --define {}",
                    if cfg!(windows) {
                        string("_WINDOWS")
                    } else {
                        string("_LINUX")
                    }
                ),
                match &v0_1 {
                    Spiral_builder::US35::US35_0(v0_1_0_0) => {
                        let v41: Spiral_builder::US36 = match &v0_1 {
                            Spiral_builder::US35::US35_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v82: Spiral_builder::US5 =
                            if if let Spiral_builder::US36::US36_0(v41_0_0) = &v41 {
                                string("")
                                    == match &v41 {
                                        Spiral_builder::US36::US36_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                            } else {
                                false
                            } {
                                Spiral_builder::US5::US5_0(string("Wasm"))
                            } else {
                                let v54: string = Spiral_builder::method196();
                                let v68: Array<string> = split(
                                    Spiral_builder::method198(Spiral_builder::US36::US36_0(
                                        string(""),
                                    )),
                                    v54,
                                    -1_i32,
                                    0_i32,
                                );
                                let v71: string = v68[0_i32].clone();
                                if startsWith(Spiral_builder::method198(v41.clone()), v71, false) {
                                    Spiral_builder::US5::US5_0(string("Wasm"))
                                } else {
                                    Spiral_builder::US5::US5_1
                                }
                            };
                        let v126: Spiral_builder::US5 = match &v82 {
                            Spiral_builder::US5::US5_0(v82_0_0) => {
                                Spiral_builder::US5::US5_0(match &v82 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v119: Spiral_builder::US5 =
                                    if if let Spiral_builder::US36::US36_1(v41_1_0) = &v41 {
                                        string("")
                                            == match &v41 {
                                                Spiral_builder::US36::US36_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                    } else {
                                        false
                                    } {
                                        Spiral_builder::US5::US5_0(string("Contract"))
                                    } else {
                                        let v91: string = Spiral_builder::method196();
                                        let v105: Array<string> = split(
                                            Spiral_builder::method198(
                                                Spiral_builder::US36::US36_1(string("")),
                                            ),
                                            v91,
                                            -1_i32,
                                            0_i32,
                                        );
                                        let v108: string = v105[0_i32].clone();
                                        if startsWith(
                                            Spiral_builder::method198(v41.clone()),
                                            v108,
                                            false,
                                        ) {
                                            Spiral_builder::US5::US5_0(string("Contract"))
                                        } else {
                                            Spiral_builder::US5::US5_1
                                        }
                                    };
                                match &v119 {
                                    Spiral_builder::US5::US5_0(v119_0_0) => {
                                        Spiral_builder::US5::US5_0(match &v119 {
                                            Spiral_builder::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_builder::US5::US5_1,
                                }
                            }
                        };
                        sprintf!(
                            " --define {}",
                            toUpper(match &v126 {
                                Spiral_builder::US5::US5_0(v126_0_0) => match &v126 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            })
                        )
                    }
                    _ => string(""),
                }
            );
            let v143: Result<string, string> = match &v4 {
                Spiral_builder::US12::US12_0(v4_0_0) => Ok::<string, string>(v4_0_0.clone()),
                Spiral_builder::US12::US12_1(v4_1_0) => Err::<string, string>(v4_1_0.clone()),
            };
            Spiral_builder::method199(
                3_u8,
                v137,
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                v143.ok(),
            )
        }
        pub fn method204(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", string("dotnet_fable_result")),
                    (),
                );
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method203(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v10: string = Spiral_builder::method204(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / dotnet fable error"),
                v10
            ))
        }
        pub fn closure83(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method203(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method48(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn closure84(unitVar: (), v0_1: std::string::String) -> bool {
            contains(
                fable_library_rust::String_::fromString(v0_1),
                string("near-sdk"),
            )
        }
        pub fn method205() -> Func1<std::string::String, bool> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure84((), v))
        }
        pub fn method206(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method207(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method208(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method209() -> string {
            string("(")
        }
        pub fn method210() -> string {
            string("(")
        }
        pub fn method212(
            v0_1: string,
            v1_1: regex::Regex,
        ) -> Vec<std::collections::HashMap<string, string>> {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v51: bool = true;
            let _capture_move = (move || {
                //;
                let v53: Box<std::string::String> = Box::new(v28);
                let v55: &'static mut std::string::String = Box::leak(v53);
                let v57: regex::Regex = v1_1.clone();
                let v59: regex::CaptureMatches = v57.captures_iter(v55);
                let v61: bool = true;
                let _regex_captures: Vec<_> = v59
                    .map(|x| {
                        //;
                        let v63: regex::Captures<'static> = x;
                        let v65: Box<regex::Captures<'static>> = Box::new(v63);
                        let v67: &'static mut regex::Captures<'static> = Box::leak(v65);
                        let v69: regex::CaptureNames = v1_1.capture_names();
                        let v71: bool = true;
                        let _regex_captures: std::collections::HashMap<_, _> = v69
                            .map(|x| {
                                //;
                                let v73: string = x.unwrap_or("").to_string().into();
                                let v75: string = v73.clone().clone();
                                let v77: string = v67
                                    .name(&v73)
                                    .map(|x| x.as_str())
                                    .unwrap_or("")
                                    .to_string()
                                    .into();
                                let v80: bool = true;
                                LrcPtr::new((v75, v77))
                            })
                            .map(|x| std::sync::Arc::try_unwrap(x).unwrap_or_else(|x| (*x).clone()))
                            .collect();
                        let v82: std::collections::HashMap<string, string> = _regex_captures;
                        let v84: bool = true;
                        v82
                    })
                    .collect::<Vec<_>>();
                let v86: Vec<std::collections::HashMap<string, string>> = _regex_captures;
                let v88: bool = true;
                v86
            })();
            _capture_move
        }
        pub fn closure85(
            unitVar: (),
            v0_1: std::collections::HashMap<string, string>,
        ) -> Spiral_builder::US41 {
            Spiral_builder::US41::US41_0(v0_1)
        }
        pub fn method213() -> Func1<std::collections::HashMap<string, string>, Spiral_builder::US41>
        {
            Func1::new(move |v: std::collections::HashMap<string, string>| {
                Spiral_builder::closure85((), v)
            })
        }
        pub fn method214() -> string {
            string("a")
        }
        pub fn closure86(v0_1: u8, v1_1: i32, v2: string, v3: bool, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method201(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method11(),
                    v3,
                    sprintf!("{}/{}", v0_1, 3_u8),
                    v1_1,
                    v2,
                ))
            };
        }
        pub fn method211(v0_1: Spiral_builder::US12, v1_1: string, v2: u8) -> (i32, string) {
            let v0_1: MutCell<Spiral_builder::US12> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<u8> = MutCell::new(v2);
            '_method211: loop {
                break '_method211 ({
                    let v8: string =
                        sprintf!("cargo fmt --manifest-path \"{}\" --", v1_1.get().clone());
                    let v14: Result<string, string> = match &v0_1.get().clone() {
                        Spiral_builder::US12::US12_0(v0_1_0_0) => {
                            Ok::<string, string>(v0_1_0_0.clone())
                        }
                        Spiral_builder::US12::US12_1(v0_1_1_0) => {
                            Err::<string, string>(v0_1_1_0.clone())
                        }
                    };
                    let patternInput: (i32, string) = Spiral_builder::method67(
                        v8,
                        None::<CancellationToken>,
                        new_empty::<(string, string)>(),
                        None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                        true,
                        v14.ok(),
                    );
                    let v31: string = patternInput.1.clone();
                    let v30: i32 = patternInput.0.clone();
                    let v177: Spiral_builder::US40 = if contains(
                        v31.clone(),
                        string("failed to load manifest for workspace member"),
                    ) == false
                    {
                        if v30 == 0_i32 {
                            Spiral_builder::US40::US40_0(v30, v31.clone())
                        } else {
                            Spiral_builder::US40::US40_1(v30, v31.clone())
                        }
                    } else {
                        let v43: Result<regex::Regex, regex::Error> =
                            regex::Regex::new(&string("failed to read `(?<a>.*?Cargo.toml)`"));
                        let v58: Vec<std::collections::HashMap<string, string>> =
                            Spiral_builder::method212(v31.clone(), v43.unwrap());
                        let v61: Option<std::collections::HashMap<string, string>> =
                            tryItem(0_i32, fable_library_rust::NativeArray_::array_from(v58));
                        let v75: Spiral_builder::US41 = defaultValue(
                            Spiral_builder::US41::US41_1,
                            map(Spiral_builder::method213(), v61),
                        );
                        let v103: Spiral_builder::US42 = match &v75 {
                            Spiral_builder::US41::US41_0(v75_0_0) => {
                                let v80: string = Spiral_builder::method214();
                                let v82: Option<string> = std::collections::HashMap::get(
                                    &match &v75 {
                                        Spiral_builder::US41::US41_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    &v80,
                                )
                                .map(|x| x)
                                .cloned();
                                Spiral_builder::US42::US42_0(defaultValue(
                                    Spiral_builder::US5::US5_1,
                                    map(Spiral_builder::method5(), v82),
                                ))
                            }
                            _ => Spiral_builder::US42::US42_1,
                        };
                        let v110: Spiral_builder::US5 =
                            if let Spiral_builder::US42::US42_0(v103_0_0) = &v103 {
                                let v104: Spiral_builder::US5 = match &v103 {
                                    Spiral_builder::US42::US42_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Spiral_builder::US5::US5_0(v104_0_0) = &v104 {
                                    Spiral_builder::US5::US5_0(match &v104 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    Spiral_builder::US5::US5_1
                                }
                            } else {
                                Spiral_builder::US5::US5_1
                            };
                        match &v110 {
                            Spiral_builder::US5::US5_0(v110_0_0) => {
                                let v112: string = match &v110 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if Spiral_builder::method42(v112.clone()) == false {
                                    let v120: LrcPtr<dyn IDisposable> =
                                        Spiral_builder::method43(defaultValue(
                                            string(""),
                                            Spiral_builder::method33(v112.clone()),
                                        ));
                                    let v122: DateTime = DateTime::now();
                                    let v142: string =
                                        toString(Spiral_builder::method189(new_guid(), v122));
                                    let v167: string =
                                                     append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                         v142.clone())),
                                                                                                                                         string("\n")),
                                                                                                                                  string("version = \"0.0.1\"")),
                                                                                                                           string("\n")),
                                                                                                                    string("edition = \"2021\"")),
                                                                                                             string("\n")),
                                                                                                      string("")),
                                                                                               string("\n")),
                                                                                        string("[[bin]]")),
                                                                                 string("\n")),
                                                                          sprintf!("name = \"spiral_builder_{}\"",
                                                                                   v142)),
                                                                   string("\n")),
                                                            string("path = \"spiral_builder.rs\""));
                                    std::fs::write(&*v112, &*v167).unwrap();
                                    ();
                                    ()
                                }
                                if v30 == 0_i32 {
                                    Spiral_builder::US40::US40_0(v30, v31.clone())
                                } else {
                                    Spiral_builder::US40::US40_1(v30, v31.clone())
                                }
                            }
                            _ => Spiral_builder::US40::US40_1(v30, v31.clone()),
                        }
                    };
                    let patternInput_1: (bool, i32, string) = match &v177 {
                        Spiral_builder::US40::US40_0(v177_0_0, v177_0_1) => {
                            (false, v177_0_0.clone(), v177_0_1.clone())
                        }
                        Spiral_builder::US40::US40_1(v177_1_0, v177_1_1) => {
                            (true, v177_1_0.clone(), v177_1_1.clone())
                        }
                    };
                    let v187: string = patternInput_1.2.clone();
                    let v186: i32 = patternInput_1.1.clone();
                    let v185: bool = patternInput_1.0.clone();
                    if if v185 == false {
                        true
                    } else {
                        v2.get().clone() >= 3_u8
                    } {
                        (v186, v187.clone())
                    } else {
                        let v193: () = {
                            Spiral_builder::closure86(v2.get().clone(), v186, v187, v185, ());
                            ()
                        };
                        {
                            let v0_1_temp: Spiral_builder::US12 = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: u8 = v2.get().clone() + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method211;
                        }
                    }
                });
            }
        }
        pub fn method216(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", string("cargo_fmt_result")),
                    (),
                );
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method215(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v10: string = Spiral_builder::method216(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / cargo fmt error"),
                v10
            ))
        }
        pub fn closure87(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method215(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method48(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method217() -> string {
            string("{")
        }
        pub fn closure88(unitVar: (), v0_1: string) -> string {
            v0_1
        }
        pub fn closure89(v0_1: string, v1_1: string, v2: string) -> string {
            replace(v2, v0_1, v1_1)
        }
        pub fn closure90(v0_1: string, v1_1: string) -> string {
            replace(v1_1, v0_1, string("type DateTime = ();"))
        }
        pub fn method219(v0_1: i32, v1_1: string, v2: string, v3: bool, v4: string) -> string {
            let v6: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v13: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v22: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v31: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v39: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v48: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v57: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v65: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v73: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v81: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v90: () = {
                Spiral_builder::closure7(
                    v6.clone(),
                    sprintf!("{}", string("external_command")),
                    (),
                );
                ()
            };
            let v98: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v106: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v114: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v123: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("cleanup")), ());
                ()
            };
            let v131: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v142: () = {
                Spiral_builder::closure7(
                    v6.clone(),
                    sprintf!("{}", if v3 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v150: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v159: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("cargo_result")), ());
                ()
            };
            let v167: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v175: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v4), ());
                ()
            };
            let v184: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v6.l0.get().clone()
        }
        pub fn method218(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
            v11: bool,
            v12: string,
        ) -> string {
            let v13: string = Spiral_builder::method219(v8, v9, v10, v11, v12);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / error"),
                v13
            ))
        }
        pub fn closure91(v0_1: bool, v1_1: string, v2: string, v3: i32, v4: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v9: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v28: Option<i64> = patternInput.5.clone();
                let v27: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v26: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v25: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v24: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v23: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method218(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_builder::method7(v23, v24, v25, v26, v27, v28),
                    Spiral_builder::method48(),
                    v3,
                    v1_1,
                    v4,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn closure93(unitVar: (), v0_1: string) -> bool {
            if contains(v0_1.clone(), string("profile [optimized] target")) == false {
                if contains(v0_1.clone(), string("profile [unoptimized] target")) == false {
                    contains(v0_1, string("profile [unoptimized + debuginfo] target")) == false
                } else {
                    false
                }
            } else {
                false
            }
        }
        pub fn closure92(v0_1: string, unitVar: ()) -> string {
            let v8: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(skip(
                2_i32,
                skipWhile(
                    Func1::new(move |v: string| Spiral_builder::closure93((), v)),
                    split(v0_1, string("\n"), -1_i32, 0_i32),
                ),
            ));
            join(Spiral_builder::method39(), toArray_1(v8))
        }
        pub fn method221(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: std::string::String = format!("{:#?}", v0_1);
            let v68: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v35)),
                    (),
                );
                ()
            };
            let v77: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v86: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v94: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v102: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v110: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v119: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", string("external_command")),
                    (),
                );
                ()
            };
            let v127: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v143: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("cargo_result")), ());
                ()
            };
            let v160: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v168: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v177: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method220(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<Exception>,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method221(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / Exception"),
                v12
            ))
        }
        pub fn closure95(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method220(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method48(),
                    v3,
                    v0_1,
                    v2,
                    v1_1,
                ))
            };
        }
        pub fn closure94(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US5 {
            let v6: () = {
                Spiral_builder::closure95(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US5::US5_1
        }
        pub fn method223(v0_1: i32, v1_1: string, v2: string, v3: bool, v4: string) -> string {
            let v6: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v13: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v22: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v31: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v39: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v48: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v57: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v65: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v73: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v81: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v90: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("cargo_result")), ());
                ()
            };
            let v98: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v106: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v114: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v123: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("cleanup")), ());
                ()
            };
            let v131: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v142: () = {
                Spiral_builder::closure7(
                    v6.clone(),
                    sprintf!("{}", if v3 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v150: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v159: () = {
                Spiral_builder::closure7(
                    v6.clone(),
                    sprintf!("{}", string("spiral_wasm_result")),
                    (),
                );
                ()
            };
            let v167: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v175: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v4), ());
                ()
            };
            let v184: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v6.l0.get().clone()
        }
        pub fn method222(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
            v11: bool,
            v12: string,
        ) -> string {
            let v13: string = Spiral_builder::method223(v8, v9, v10, v11, v12);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / wasm error"),
                v13
            ))
        }
        pub fn closure96(v0_1: bool, v1_1: string, v2: string, v3: string, v4: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v9: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v28: Option<i64> = patternInput.5.clone();
                let v27: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v26: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v25: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v24: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v23: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method222(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_builder::method7(v23, v24, v25, v26, v27, v28),
                    Spiral_builder::method48(),
                    v4,
                    v1_1,
                    v2,
                    v0_1,
                    sprintf!("\n{}", v3),
                ))
            };
        }
        pub fn method225(
            v0_1: i32,
            v1_1: string,
            v2: string,
            v3: string,
            v4: bool,
            v5: string,
        ) -> string {
            let v7: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v14: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v23: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("exit_code")), ());
                ()
            };
            let v32: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v40: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v49: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v58: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v66: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v82: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v91: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("wasm_path")), ());
                ()
            };
            let v99: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v107: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v115: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v124: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("command")), ());
                ()
            };
            let v132: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v140: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v148: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v157: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("cleanup")), ());
                ()
            };
            let v165: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v176: () = {
                Spiral_builder::closure7(
                    v7.clone(),
                    sprintf!("{}", if v4 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v184: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v193: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string("cargo_result")), ());
                ()
            };
            let v201: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v209: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v218: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v7.l0.get().clone()
        }
        pub fn method224(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
            v11: string,
            v12: bool,
            v13: string,
        ) -> string {
            let v14: string = Spiral_builder::method225(v8, v9, v10, v11, v12, v13);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / cargo error"),
                v14
            ))
        }
        pub fn closure97(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: i32,
            v4: string,
            v5: string,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v10: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v29: Option<i64> = patternInput.5.clone();
                let v28: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v27: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v26: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v25: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v24: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method224(
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    Spiral_builder::method7(v24, v25, v26, v27, v28, v29),
                    Spiral_builder::method48(),
                    v3,
                    v1_1,
                    v4,
                    v5,
                    v0_1,
                    sprintf!("\n{}", v2),
                ))
            };
        }
        pub fn method227(v0_1: string, v1_1: LrcPtr<Spiral_builder::UH4>) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("cleanup")), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v73: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", sprintf!("{:?}", v1_1)), ());
                ()
            };
            let v82: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method226(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: bool,
            v11: string,
            v12: bool,
            v13: string,
            v14: bool,
            v15: string,
            v16: bool,
            v17: string,
            v18: bool,
        ) -> string {
            let v25: string = Spiral_builder::method227(
                v8,
                LrcPtr::new(Spiral_builder::UH4::UH4_1(
                    v9,
                    v10,
                    LrcPtr::new(Spiral_builder::UH4::UH4_1(
                        v11,
                        v12,
                        LrcPtr::new(Spiral_builder::UH4::UH4_1(
                            v13,
                            v14,
                            LrcPtr::new(Spiral_builder::UH4::UH4_1(
                                v15,
                                v16,
                                LrcPtr::new(Spiral_builder::UH4::UH4_1(
                                    v17,
                                    v18,
                                    LrcPtr::new(Spiral_builder::UH4::UH4_0),
                                )),
                            )),
                        )),
                    )),
                )),
            );
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / cleanup"),
                v25
            ))
        }
        pub fn closure98(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: bool,
            v5: string,
            v6: bool,
            v7: string,
            v8: bool,
            v9: string,
            v10: bool,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_0) {
                let v15: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v34: Option<i64> = patternInput.5.clone();
                let v33: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v32: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v31: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v30: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v29: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method226(
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    v34.clone(),
                    Spiral_builder::method7(v29, v30, v31, v32, v33, v34),
                    Spiral_builder::method51(),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                    v8,
                    v9,
                    v10,
                ))
            };
        }
        pub fn method228(v0_1: LrcPtr<Spiral_builder::UH4>) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH4>> = MutCell::new(v0_1.clone());
            '_method228: loop {
                break '_method228 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH4::UH4_0 => (),
                    Spiral_builder::UH4::UH4_1(v0_1_1_0, v0_1_1_1, v0_1_1_2) => {
                        std::fs::remove_file(&*match v0_1.get().clone().as_ref() {
                            Spiral_builder::UH4::UH4_1(x, _, _) => x.clone(),
                            _ => unreachable!(),
                        })
                        .unwrap();
                        ();
                        {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH4> =
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH4::UH4_1(_, _, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                            v0_1.set(v0_1_temp);
                            continue '_method228;
                        }
                    }
                });
            }
        }
        pub fn method229(v0_1: string) -> string {
            v0_1
        }
        pub fn method230(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure100(unitVar: (), v0_1: std::fs::FileType) -> Spiral_builder::US43 {
            Spiral_builder::US43::US43_0(v0_1)
        }
        pub fn method231() -> Func1<std::fs::FileType, Spiral_builder::US43> {
            Func1::new(move |v: std::fs::FileType| Spiral_builder::closure100((), v))
        }
        pub fn closure101(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US43 {
            Spiral_builder::US43::US43_1(v0_1)
        }
        pub fn method232() -> Func1<std::string::String, Spiral_builder::US43> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure101((), v))
        }
        pub fn method233(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method234(v0_1: string) -> string {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            let v75: Option<&std::ffi::OsStr> = v52.file_name();
            let v77: bool = true;
            let _optionm_map_ = v75.map(|x| {
                //;
                let v79: &std::ffi::OsStr = x;
                let v81: std::ffi::OsString = v79.to_os_string();
                let v83: Option<&str> = v81.to_str();
                let v85: &str = v83.unwrap();
                let v88: std::string::String = String::from(v85);
                let v111: string = fable_library_rust::String_::fromString(v88);
                let v113: bool = true;
                v111
            });
            let v115: Option<string> = _optionm_map_;
            let v129: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method5(), v115),
            );
            match &v129 {
                Spiral_builder::US5::US5_0(v129_0_0) => match &v129 {
                    Spiral_builder::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            }
        }
        pub fn method235(v0_1: Spiral_builder::US44) -> Spiral_builder::US44 {
            v0_1
        }
        pub fn method236(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn closure99(
            v0_1: string,
            v1_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v3: bool = true;
            let __future_init = Box::pin(async {
                //;
                let v5: bool = true;
                let __future_init = Box::pin(async move {
                    //;
                    let v6: async_walkdir::DirEntry = Spiral_builder::method230(v1_1.clone());
                    let v8: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v6));
                    let v10: Result<std::fs::FileType, std::io::Error> = v8.await;
                    let v11 = Spiral_builder::method45();
                    let v23: Result<std::fs::FileType, std::string::String> =
                        v10.map_err(|x| v11(x));
                    let v26 = Spiral_builder::method231();
                    let v27 = Spiral_builder::method232();
                    let v28: Spiral_builder::US43 = match &v23 {
                        Err(v23_1_0) => v27(v23_1_0.clone()),
                        Ok(v23_0_0) => v26(v23_0_0.clone()),
                    };
                    let v211: Spiral_builder::US44 = Spiral_builder::method235(
                        if let Spiral_builder::US43::US43_0(v28_0_0) = &v28 {
                            let v30: std::fs::FileType = Spiral_builder::method233(match &v28 {
                                Spiral_builder::US43::US43_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v30) == false {
                                Spiral_builder::US44::US44_0
                            } else {
                                let v36: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v1_1.clone());
                                let v39: std::path::Display = v36.display();
                                let v63: std::string::String = format!("{}", v39);
                                let v86: string = fable_library_rust::String_::fromString(v63);
                                if startsWith(
                                    Spiral_builder::method234(v86.clone()),
                                    v0_1.clone(),
                                    false,
                                ) == false
                                {
                                    Spiral_builder::US44::US44_1
                                } else {
                                    let v93: Option<string> = Spiral_builder::method33(v86);
                                    let v107: Spiral_builder::US5 = defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        map(Spiral_builder::method5(), v93),
                                    );
                                    if let Spiral_builder::US5::US5_0(v107_0_0) = &v107 {
                                        if contains(
                                            match &v107 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            v0_1.clone(),
                                        ) == false
                                        {
                                            Spiral_builder::US44::US44_2
                                        } else {
                                            Spiral_builder::US44::US44_1
                                        }
                                    } else {
                                        Spiral_builder::US44::US44_1
                                    }
                                }
                            }
                        } else {
                            let v124: std::path::PathBuf = async_walkdir::DirEntry::path(&v1_1);
                            let v127: std::path::Display = v124.display();
                            let v151: std::string::String = format!("{}", v127);
                            let v174: string = fable_library_rust::String_::fromString(v151);
                            if startsWith(
                                Spiral_builder::method234(v174.clone()),
                                v0_1.clone(),
                                false,
                            ) == false
                            {
                                Spiral_builder::US44::US44_1
                            } else {
                                let v181: Option<string> = Spiral_builder::method33(v174);
                                let v195: Spiral_builder::US5 = defaultValue(
                                    Spiral_builder::US5::US5_1,
                                    map(Spiral_builder::method5(), v181),
                                );
                                if let Spiral_builder::US5::US5_0(v195_0_0) = &v195 {
                                    if contains(
                                        match &v195 {
                                            Spiral_builder::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        v0_1,
                                    ) == false
                                    {
                                        Spiral_builder::US44::US44_2
                                    } else {
                                        Spiral_builder::US44::US44_1
                                    }
                                } else {
                                    Spiral_builder::US44::US44_1
                                }
                            }
                        },
                    );
                    let v214: string = string("}");
                    let v218: bool = true;
                    let v215 = v211;
                    let v230: string = append(
                        append(
                            append(append(string("true; v215 "), v214), string("); ")),
                            string(""),
                        ),
                        string(" // rust.fix_closure\'"),
                    );
                    let v231: bool = true;
                    v215
                }); // rust.fix_closure';
                let v233 = __future_init;
                let v235: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Spiral_builder::US44> + Send>,
                > = v233;
                let v237: Spiral_builder::US44 = v235.await;
                let v247: async_walkdir::Filtering = Spiral_builder::method236(match &v237 {
                    Spiral_builder::US44::US44_0 => async_walkdir::Filtering::Ignore,
                    Spiral_builder::US44::US44_1 => async_walkdir::Filtering::IgnoreDir,
                    _ => async_walkdir::Filtering::Continue,
                });
                let v248: string = string("}");
                let v252: bool = true;
                let v249 = v247;
                let v264: string = append(
                    append(
                        append(append(string("true; v249 "), v248), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v265: bool = true;
                v249
            }); // rust.fix_closure';
            let v267 = __future_init;
            v267
        }
        pub fn closure103(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method238() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Spiral_builder::closure103((), v))
        }
        pub fn closure104(unitVar: (), v0_1: async_walkdir::DirEntry) -> Spiral_builder::US45 {
            Spiral_builder::US45::US45_0(v0_1)
        }
        pub fn method239() -> Func1<async_walkdir::DirEntry, Spiral_builder::US45> {
            Func1::new(move |v: async_walkdir::DirEntry| Spiral_builder::closure104((), v))
        }
        pub fn closure105(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US45 {
            Spiral_builder::US45::US45_1(v0_1)
        }
        pub fn method240() -> Func1<std::string::String, Spiral_builder::US45> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure105((), v))
        }
        pub fn method241(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Spiral_builder::method98(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript / stream_filter_map"),
                v9
            ))
        }
        pub fn closure106(v0_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method241(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method48(),
                    v0_1,
                ))
            };
        }
        pub fn closure102(
            v0_1: string,
            v1_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<(string, string)> {
            let v2 = Spiral_builder::method238();
            let v14: Result<async_walkdir::DirEntry, std::string::String> = v1_1.map_err(|x| v2(x));
            let v17 = Spiral_builder::method239();
            let v18 = Spiral_builder::method240();
            let v19: Spiral_builder::US45 = match &v14 {
                Err(v14_1_0) => v18(v14_1_0.clone()),
                Ok(v14_0_0) => v17(v14_0_0.clone()),
            };
            let v193: Spiral_builder::US46 = match &v19 {
                Spiral_builder::US45::US45_0(v19_0_0) => {
                    let v22: std::path::PathBuf = async_walkdir::DirEntry::path(&v19_0_0.clone());
                    let v25: std::path::Display = v22.display();
                    let v49: std::string::String = format!("{}", v25);
                    let v72: string = fable_library_rust::String_::fromString(v49);
                    let v73: string = sprintf!("{}\\.(?<a>[\\d.]+)$", v0_1);
                    let v75: Result<regex::Regex, regex::Error> = regex::Regex::new(&v73);
                    let v90: Vec<std::collections::HashMap<string, string>> =
                        Spiral_builder::method212(v72.clone(), v75.unwrap());
                    let v93: Option<std::collections::HashMap<string, string>> =
                        tryItem(0_i32, fable_library_rust::NativeArray_::array_from(v90));
                    let v107: Spiral_builder::US41 = defaultValue(
                        Spiral_builder::US41::US41_1,
                        map(Spiral_builder::method213(), v93),
                    );
                    let v135: Spiral_builder::US42 = match &v107 {
                        Spiral_builder::US41::US41_0(v107_0_0) => {
                            let v112: string = Spiral_builder::method214();
                            let v114: Option<string> = std::collections::HashMap::get(
                                &match &v107 {
                                    Spiral_builder::US41::US41_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                &v112,
                            )
                            .map(|x| x)
                            .cloned();
                            Spiral_builder::US42::US42_0(defaultValue(
                                Spiral_builder::US5::US5_1,
                                map(Spiral_builder::method5(), v114),
                            ))
                        }
                        _ => Spiral_builder::US42::US42_1,
                    };
                    let v142: Spiral_builder::US5 =
                        if let Spiral_builder::US42::US42_0(v135_0_0) = &v135 {
                            let v136: Spiral_builder::US5 = match &v135 {
                                Spiral_builder::US42::US42_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Spiral_builder::US5::US5_0(v136_0_0) = &v136 {
                                Spiral_builder::US5::US5_0(match &v136 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            } else {
                                Spiral_builder::US5::US5_1
                            }
                        } else {
                            Spiral_builder::US5::US5_1
                        };
                    match &v142 {
                        Spiral_builder::US5::US5_0(v142_0_0) => Spiral_builder::US46::US46_0(
                            v72,
                            match &v142 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        ),
                        _ => Spiral_builder::US46::US46_1,
                    }
                }
                Spiral_builder::US45::US45_1(v19_1_0) => {
                    let v151: () = {
                        Spiral_builder::closure106(v19_1_0.clone(), ());
                        ()
                    };
                    Spiral_builder::US46::US46_1
                }
            };
            match &v193 {
                Spiral_builder::US46::US46_0(v193_0_0, v193_0_1) => Some((
                    match &v193 {
                        Spiral_builder::US46::US46_0(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    match &v193 {
                        Spiral_builder::US46::US46_0(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                )),
                _ => None::<(string, string)>,
            }
        }
        pub fn method237(
            v0_1: string,
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<(string, string)>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Spiral_builder::closure102(v0_1.clone(), v)
                }
            })
        }
        pub fn closure107(unitVar: (), _arg: (string, string)) -> (string, string) {
            (_arg.0.clone(), _arg.1.clone())
        }
        pub fn closure108(unitVar: (), _arg: (string, string)) -> Spiral_builder::US46 {
            Spiral_builder::US46::US46_0(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method242() -> Func1<(string, string), Spiral_builder::US46> {
            Func1::new(move |arg10_0040: (string, string)| {
                Spiral_builder::closure108((), arg10_0040)
            })
        }
        pub fn method244(v0_1: Spiral_builder::US46) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("version")), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v38: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            let v47: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method243(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Spiral_builder::US46,
        ) -> string {
            let v9: string = Spiral_builder::method244(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript"),
                v9
            ))
        }
        pub fn closure109(v0_1: Spiral_builder::US46, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method243(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method11(),
                    v0_1,
                ))
            };
        }
        pub fn method245(v0_1: string, v1_1: string, v2: Spiral_builder::US46) {
            match &v2 {
                Spiral_builder::US46::US46_0(v2_0_0, v2_0_1) => {
                    let v4: string =
                        match &v2 {
                            Spiral_builder::US46::US46_0(_, x) => x.clone(),
                            _ => unreachable!(),
                        };
                    Spiral_builder::method194(Spiral_builder::method27(v1_1.clone(),
                                                                       sprintf!("fable-library-{}.{}",
                                                                                string("ts"),
                                                                                v4.clone())),
                                              Spiral_builder::method27(v0_1,
                                                                       sprintf!("fable_modules/fable-library-{}.{}",
                                                                                string("ts"),
                                                                                v4)))
                }
                _ =>
                panic!("{}",
                       sprintf!("spiral_builder.process_typescript / fable library not found / lib_path: {}",
         v1_1.clone()),),
            };
        }
        pub fn method246(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v10: string = Spiral_builder::method204(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript"),
                v10
            ))
        }
        pub fn closure110(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method246(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method48(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method248(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v44: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method247(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Spiral_builder::method248(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript"),
                v9
            ))
        }
        pub fn closure111(v0_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method247(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method11(),
                    v0_1,
                ))
            };
        }
        pub fn method249(
            v0_1: LrcPtr<Spiral_builder::UH5>,
            v1_1: LrcPtr<Spiral_builder::UH5>,
        ) -> LrcPtr<Spiral_builder::UH5> {
            match v0_1.as_ref() {
                Spiral_builder::UH5::UH5_0 => v1_1.clone(),
                Spiral_builder::UH5::UH5_1(v0_1_1_0, v0_1_1_1, v0_1_1_2) => {
                    LrcPtr::new(Spiral_builder::UH5::UH5_1(
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(x, _, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(_, x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        Spiral_builder::method249(
                            match v0_1.as_ref() {
                                Spiral_builder::UH5::UH5_1(_, _, x) => x.clone(),
                                _ => unreachable!(),
                            },
                            v1_1.clone(),
                        ),
                    ))
                }
            }
        }
        pub fn method250(
            v0_1: LrcPtr<Spiral_builder::UH5>,
            v1_1: List<(string, string)>,
        ) -> List<(string, string)> {
            match v0_1.as_ref() {
                Spiral_builder::UH5::UH5_0 => v1_1.clone(),
                Spiral_builder::UH5::UH5_1(v0_1_1_0, v0_1_1_1, v0_1_1_2) => cons(
                    (
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(x, _, _) => x.clone(),
                            _ => unreachable!(),
                        },
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(_, x, _) => x.clone(),
                            _ => unreachable!(),
                        },
                    ),
                    Spiral_builder::method250(
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(_, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure112(v0_1: string, unitVar: ()) -> string {
            let v5: LrcPtr<dyn IEnumerable_1<string>> =
                ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32));
            join(Spiral_builder::method39(), toArray_1(v5))
        }
        pub fn method252(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("ex")), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v35: std::string::String = format!("{:#?}", v0_1);
            let v68: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v35)),
                    (),
                );
                ()
            };
            let v77: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v86: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v94: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v102: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v110: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v119: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", string("external_command")),
                    (),
                );
                ()
            };
            let v127: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v143: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("run_result")), ());
                ()
            };
            let v160: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v168: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v177: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method251(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<Exception>,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method252(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript / Exception"),
                v12
            ))
        }
        pub fn closure114(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method251(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method48(),
                    v3,
                    v0_1,
                    v2,
                    v1_1,
                ))
            };
        }
        pub fn closure113(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US5 {
            let v6: () = {
                Spiral_builder::closure114(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US5::US5_1
        }
        pub fn method253(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method138(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript / error"),
                v12
            ))
        }
        pub fn closure115(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method253(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method48(),
                    v2,
                    v1_1,
                    v0_1,
                    v3,
                ))
            };
        }
        pub fn method254(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v10: string = Spiral_builder::method204(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_python"),
                v10
            ))
        }
        pub fn closure116(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method254(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method48(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method255(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Spiral_builder::method248(v8);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_python"),
                v9
            ))
        }
        pub fn closure117(v0_1: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v5: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method255(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method7(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method11(),
                    v0_1,
                ))
            };
        }
        pub fn closure118(v0_1: string, unitVar: ()) -> string {
            let v5: LrcPtr<dyn IEnumerable_1<string>> =
                ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32));
            join(Spiral_builder::method39(), toArray_1(v5))
        }
        pub fn method256(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<Exception>,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method252(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_python / Exception"),
                v12
            ))
        }
        pub fn closure120(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method256(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method48(),
                    v3,
                    v0_1,
                    v2,
                    v1_1,
                ))
            };
        }
        pub fn closure119(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US5 {
            let v6: () = {
                Spiral_builder::closure120(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US5::US5_1
        }
        pub fn method257(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
            v11: string,
        ) -> string {
            let v12: string = Spiral_builder::method138(v8, v9, v10, v11);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_python / error"),
                v12
            ))
        }
        pub fn closure121(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_4) {
                let v8: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method257(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method7(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method48(),
                    v2,
                    v1_1,
                    v0_1,
                    v3,
                ))
            };
        }
        pub fn method259(v0_1: std::string::String, v1_1: clap::ArgMatches) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method13()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("subcommand")), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v33: std::string::String = format!("{:#?}", v0_1);
            let v66: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v33)),
                    (),
                );
                ()
            };
            let v75: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v84: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("arg_matches")), ());
                ()
            };
            let v92: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v97: std::string::String = format!("{:#?}", v1_1);
            let v130: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v97)),
                    (),
                );
                ()
            };
            let v139: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method258(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
            v9: clap::ArgMatches,
        ) -> string {
            let v10: string = Spiral_builder::method259(v8, v9);
            Spiral_builder::method17(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / invalid subcommand"),
                v10
            ))
        }
        pub fn closure122(v0_1: clap::ArgMatches, v1_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method6(Spiral_builder::US0::US0_1) {
                let v6: () = {
                    Spiral_builder::closure2((), ());
                    ()
                };
                let patternInput: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method18(Spiral_builder::method258(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method7(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method11(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn closure123(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v4: &str = &*_arg.0.clone();
            let v28: std::string::String = String::from(v4);
            let v52: &str = &*_arg.1.clone();
            LrcPtr::new((v28, String::from(v52)))
        }
        pub fn closure124(unitVar: (), v0_1: serde_json::Error) -> string {
            let v3: std::string::String = format!("{}", v0_1);
            fable_library_rust::String_::fromString(v3)
        }
        pub fn method260() -> Func1<serde_json::Error, string> {
            Func1::new(move |v: serde_json::Error| Spiral_builder::closure124((), v))
        }
        pub fn method261(v0_1: Result<string, string>) -> Result<string, string> {
            v0_1
        }
        pub fn method19(
            v0_1: Spiral_builder::US0,
            v1_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, string>>>> {
            let v3: bool = true;
            let __future_init = Box::pin(async move {
                //;
                let v6: Option<(std::string::String, clap::ArgMatches)> =
                    clap::ArgMatches::subcommand(Box::leak(Box::new(v1_1))).map(|(a, b)| {
                        (
                            Func1::new(move |v: &str| Spiral_builder::closure11((), v))(a),
                            b.clone(),
                        )
                    });
                let v21: Spiral_builder::US6 = defaultValue(
                    Spiral_builder::US6::US6_1,
                    map(Spiral_builder::method20(), v6),
                );
                let v4791: Array<(string, string)> = if let Spiral_builder::US6::US6_0(
                    v21_0_0,
                    v21_0_1,
                ) = &v21
                {
                    let v26: clap::ArgMatches = match &v21 {
                        Spiral_builder::US6::US6_0(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v25: std::string::String = match &v21 {
                        Spiral_builder::US6::US6_0(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if fable_library_rust::String_::fromString(v25.clone()) == string("cuda") {
                        let v30: string = Spiral_builder::method21();
                        let v33: &str = &*v30;
                        let v56: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v26.clone(), v33).cloned();
                        let v70: Spiral_builder::US7 = defaultValue(
                            Spiral_builder::US7::US7_1,
                            map(Spiral_builder::method22(), v56),
                        );
                        let v77: std::string::String = match &v70 {
                            Spiral_builder::US7::US7_0(v70_0_0) => match &v70 {
                                Spiral_builder::US7::US7_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v79: string = fable_library_rust::String_::fromString(v77);
                        let v80: string = Spiral_builder::method23();
                        let v83: &str = &*v80;
                        let v106: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v26.clone(), v83).cloned();
                        let v120: Spiral_builder::US7 = defaultValue(
                            Spiral_builder::US7::US7_1,
                            map(Spiral_builder::method22(), v106),
                        );
                        let v149: Spiral_builder::US8 = match &v120 {
                            Spiral_builder::US7::US7_0(v120_0_0) => {
                                let v126: string =
                                    fable_library_rust::String_::fromString(match &v120 {
                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    });
                                let v131: Spiral_builder::US9 = if string("Pip") == v126.clone() {
                                    Spiral_builder::US9::US9_0(Spiral_builder::US10::US10_0)
                                } else {
                                    Spiral_builder::US9::US9_1
                                };
                                Spiral_builder::US8::US8_0(match &v131 {
                                    Spiral_builder::US9::US9_0(v131_0_0) => {
                                        Spiral_builder::US9::US9_0(match &v131 {
                                            Spiral_builder::US9::US9_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v138: Spiral_builder::US9 = if string("Poetry") == v126
                                        {
                                            Spiral_builder::US9::US9_0(Spiral_builder::US10::US10_1)
                                        } else {
                                            Spiral_builder::US9::US9_1
                                        };
                                        match &v138 {
                                            Spiral_builder::US9::US9_0(v138_0_0) => {
                                                Spiral_builder::US9::US9_0(match &v138 {
                                                    Spiral_builder::US9::US9_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_builder::US9::US9_1,
                                        }
                                    }
                                })
                            }
                            _ => Spiral_builder::US8::US8_1,
                        };
                        let v156: Spiral_builder::US9 =
                            if let Spiral_builder::US8::US8_0(v149_0_0) = &v149 {
                                let v150: Spiral_builder::US9 = match &v149 {
                                    Spiral_builder::US8::US8_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Spiral_builder::US9::US9_0(v150_0_0) = &v150 {
                                    Spiral_builder::US9::US9_0(match &v150 {
                                        Spiral_builder::US9::US9_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    Spiral_builder::US9::US9_1
                                }
                            } else {
                                Spiral_builder::US9::US9_1
                            };
                        let v160: Spiral_builder::US10 = match &v156 {
                            Spiral_builder::US9::US9_0(v156_0_0) => match &v156 {
                                Spiral_builder::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => Spiral_builder::US10::US10_0,
                        };
                        let v161: string = Spiral_builder::method24();
                        let v164: &str = &*v161;
                        let v187: Option<Vec<std::string::String>> =
                            clap::ArgMatches::get_many(&v26.clone(), v164)
                                .map(|x| x.cloned().into_iter().collect());
                        let v201: Spiral_builder::US11 = defaultValue(
                            Spiral_builder::US11::US11_1,
                            map(Spiral_builder::method25(), v187),
                        );
                        let v207: Vec<std::string::String> =
                            new_empty::<std::string::String>().to_vec();
                        let v210: Vec<std::string::String> = match &v201 {
                            Spiral_builder::US11::US11_0(v201_0_0) => match &v201 {
                                Spiral_builder::US11::US11_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v207,
                        };
                        let v214: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v79.clone());
                        let v252: Vec<u8> = Spiral_builder::method26(v214.unwrap());
                        let v254: Result<std::string::String, std::string::FromUtf8Error> =
                            std::string::String::from_utf8(v252);
                        let v257: std::string::String = v254.unwrap();
                        let v270: string = fable_library_rust::String_::fromString(v257);
                        let v296: Spiral_builder::US12 = Spiral_builder::method30(
                            Spiral_builder::method27(string("polyglot"), string(".devcontainer")),
                            string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder"),
                        );
                        let v344: Spiral_builder::US5 = match &v296 {
                            Spiral_builder::US12::US12_0(v296_0_0) => {
                                Spiral_builder::US5::US5_0(v296_0_0.clone())
                            }
                            Spiral_builder::US12::US12_1(v296_1_0) => {
                                let v302: () = {
                                    Spiral_builder::closure16(v296_1_0.clone(), ());
                                    ()
                                };
                                Spiral_builder::US5::US5_1
                            }
                        };
                        let v399: Spiral_builder::US5 = match &v344 {
                            Spiral_builder::US5::US5_0(v344_0_0) => {
                                Spiral_builder::US5::US5_0(match &v344 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v347: string = Spiral_builder::method38();
                                let v349: Spiral_builder::US12 = Spiral_builder::method30(
                                    Spiral_builder::method27(
                                        string("polyglot"),
                                        string(".devcontainer"),
                                    ),
                                    v347,
                                );
                                match &v349 {
                                    Spiral_builder::US12::US12_0(v349_0_0) => {
                                        Spiral_builder::US5::US5_0(v349_0_0.clone())
                                    }
                                    Spiral_builder::US12::US12_1(v349_1_0) => {
                                        let v355: () = {
                                            Spiral_builder::closure16(v349_1_0.clone(), ());
                                            ()
                                        };
                                        Spiral_builder::US5::US5_1
                                    }
                                }
                            }
                        };
                        let v404: string = Spiral_builder::method27(
                            match &v399 {
                                Spiral_builder::US5::US5_0(v399_0_0) => match &v399 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            },
                            string("polyglot"),
                        );
                        let v407: string = toLower(Spiral_builder::method38());
                        let v411: string = toLower(v404);
                        let v419: Spiral_builder::US12 = if startsWith(v407, v411.clone(), false) {
                            Spiral_builder::US12::US12_1(v411.clone())
                        } else {
                            Spiral_builder::US12::US12_0(v411)
                        };
                        let v425: Result<string, string> = match &v419 {
                            Spiral_builder::US12::US12_0(v419_0_0) => {
                                Ok::<string, string>(v419_0_0.clone())
                            }
                            Spiral_builder::US12::US12_1(v419_1_0) => {
                                Err::<string, string>(v419_1_0.clone())
                            }
                        };
                        let v427: bool = true;
                        let _result_unwrap_or_else = v425.unwrap_or_else(|x| {
                            //;
                            let v429: string = x;
                            let v431: bool = true;
                            v429
                        });
                        let v433: string = _result_unwrap_or_else;
                        let v436: string =
                            defaultValue(string(""), Spiral_builder::method33(v79.clone()));
                        let v444: string = match &v160 {
                            Spiral_builder::US10::US10_1 => {
                                Spiral_builder::method27(v436.clone(), string("pyproject.toml"))
                            }
                            _ => Spiral_builder::method27(v436.clone(), string("requirements.txt")),
                        };
                        let v446: bool = true;
                        let _vec_map: Vec<_> = v210
                            .into_iter()
                            .map(|x| {
                                //;
                                let v448: std::string::String = x;
                                let v450: string = fable_library_rust::String_::fromString(v448);
                                let v463: string = if contains(v450.clone(), string("=")) {
                                    v450.clone()
                                } else {
                                    if endsWith(v450.clone(), string("]"), false) {
                                        sprintf!(
                                            "{}}}",
                                            replace(
                                                v450.clone(),
                                                string("["),
                                                string("={version=\'*\',features=[")
                                            )
                                        )
                                    } else {
                                        sprintf!("{}=\'*\'", v450)
                                    }
                                };
                                let v465: bool = true;
                                v463
                            })
                            .collect::<Vec<_>>();
                        let v467: Vec<string> = _vec_map;
                        let v469: Array<string> =
                            fable_library_rust::NativeArray_::array_from(v467);
                        let _v470: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v469 = v469.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v469 = v469.clone();
                                        move |i: i32| v469[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, count_2(v469.clone()) - 1_i32),
                                )
                            }
                        }));
                        let v480: string = join(Spiral_builder::method39(), toArray_1(_v470));
                        let patternInput: (i32, string) = if v480.clone() == string("") {
                            (0_i32, string(""))
                        } else {
                            Spiral_builder::method40(v444,
                                                         match &v160 {
                                                             Spiral_builder::US10::US10_1
                                                             =>
                                                             append(append(append(append(append(append(append(append(append(string("[tool.poetry]\nname = \"test\"\nversion = \"0.0.1\"\ndescription = \"\"\nauthors = []\n\n[tool.poetry.dependencies]\npython=\"~3.12\"\n"),
                                                                                                                            sprintf!("{}",
                                                                                                                                     v480.clone())),
                                                                                                                     string("\n")),
                                                                                                              string("")),
                                                                                                       string("\n")),
                                                                                                string("[build-system]")),
                                                                                         string("\n")),
                                                                                  string("requires = [\"poetry-core\"]")),
                                                                           string("\n")),
                                                                    string("build-backend = \"poetry.core.masonry.api\"")),
                                                             _ =>
                                                             v480.clone(),
                                                         });
                            Spiral_builder::method67(
                                match &v160 {
                                    Spiral_builder::US10::US10_1 => string("poetry install"),
                                    _ => string("pip install -r requirements.txt"),
                                },
                                None::<CancellationToken>,
                                new_empty::<(string, string)>(),
                                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                                None::<
                                    Func1<
                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                        (),
                                    >,
                                >,
                                true,
                                Some(v436.clone()),
                            )
                        };
                        let v540: i32 = patternInput.0.clone();
                        let patternInput_4: (
                            Spiral_builder::US5,
                            Spiral_builder::US5,
                            Spiral_builder::US5,
                            Spiral_builder::US5,
                        ) = if v540 != 0_i32 {
                            let v547: () = {
                                Spiral_builder::closure61(
                                    v160.clone(),
                                    v79.clone(),
                                    patternInput.1.clone(),
                                    v540,
                                    (),
                                );
                                ()
                            };
                            (
                                Spiral_builder::US5::US5_0(string("py")),
                                Spiral_builder::US5::US5_1,
                                Spiral_builder::US5::US5_1,
                                Spiral_builder::US5::US5_1,
                            )
                        } else {
                            let v595: string = match &v160 {
                                Spiral_builder::US10::US10_1 => {
                                    sprintf!("poetry run python \"{}\"", v79.clone())
                                }
                                _ => sprintf!("python \"{}\"", v79.clone()),
                            };
                            let v598: Array<(string, string)> =
                                new_array(&[(string("TRACE_LEVEL"), string("Verbose"))]);
                            let patternInput_1: (i32, string) = Spiral_builder::method67(
                                v595.clone(),
                                None::<CancellationToken>,
                                v598.clone(),
                                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                                None::<
                                    Func1<
                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                        (),
                                    >,
                                >,
                                true,
                                Some(v436.clone()),
                            );
                            let v609: string = patternInput_1.1.clone();
                            let v608: i32 = patternInput_1.0.clone();
                            let v610: i32 = count_2(v598.clone());
                            let v611: Array<string> = new_init(&string(""), v610);
                            let v612: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method71(v610, v612.clone()) {
                                let v614: i32 = v612.l0.get().clone();
                                let patternInput_2: (string, string) = v598[v614].clone();
                                let v617: string = sprintf!(
                                    "$env:{}=\'\'{}\'\'",
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone()
                                );
                                v611.get_mut()[v614 as usize] = v617;
                                {
                                    let v618: i32 = v614 + 1_i32;
                                    v612.l0.set(v618);
                                    ()
                                }
                            }
                            {
                                let v628: string = sprintf!(
                                    "pwsh -c \'{}; {}\'",
                                    join(string(";"), toArray_1(ofArray_1(v611.clone()))),
                                    v595
                                );
                                let patternInput_3: (
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                ) = if if v608 == 0_i32 {
                                    true
                                } else {
                                    contains(v609.clone(),
                                                        string("cupy_backends.cuda.api.runtime.CUDARuntimeError: cudaErrorInsufficientDriver"))
                                } {
                                    let result: LrcPtr<MutCell<Spiral_builder::US5>> =
                                        refCell(Spiral_builder::US5::US5_1);
                                    try_catch(
                                        || {
                                            result.set(Spiral_builder::closure62(
                                                (),
                                                Spiral_builder::closure63(v609.clone(), ()),
                                            ))
                                        },
                                        |ex: LrcPtr<Exception>| {
                                            result.set(Spiral_builder::closure64(
                                                v79.clone(),
                                                v609.clone(),
                                                v628.clone(),
                                                ex.clone(),
                                            ))
                                        },
                                    );
                                    {
                                        let v639: Spiral_builder::US5 = result.get().clone();
                                        let v649: Option<string> = match &v639 {
                                            Spiral_builder::US5::US5_0(v639_0_0) => {
                                                Some(match &v639 {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => None::<string>,
                                        };
                                        (
                                            Spiral_builder::US5::US5_0(string("py")),
                                            Spiral_builder::US5::US5_0(v270),
                                            Spiral_builder::US5::US5_0(v79.clone()),
                                            Spiral_builder::US5::US5_0(v649.unwrap()),
                                        )
                                    }
                                } else {
                                    let v659: () = {
                                        Spiral_builder::closure66(
                                            v79.clone(),
                                            v609,
                                            v608,
                                            v628,
                                            (),
                                        );
                                        ()
                                    };
                                    (
                                        Spiral_builder::US5::US5_0(string("py")),
                                        Spiral_builder::US5::US5_1,
                                        Spiral_builder::US5::US5_1,
                                        Spiral_builder::US5::US5_1,
                                    )
                                };
                                (
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                    patternInput_3.2.clone(),
                                    patternInput_3.3.clone(),
                                )
                            }
                        };
                        let v711: Spiral_builder::US5 = patternInput_4.3.clone();
                        let v709: Spiral_builder::US5 = patternInput_4.1.clone();
                        let v708: Spiral_builder::US5 = patternInput_4.0.clone();
                        let v724: Array<(string, string)> = new_array(&[
                            (
                                string("extension"),
                                match &v708 {
                                    Spiral_builder::US5::US5_0(v708_0_0) => match &v708 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => string(""),
                                },
                            ),
                            (
                                string("code"),
                                match &v709 {
                                    Spiral_builder::US5::US5_0(v709_0_0) => match &v709 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => string(""),
                                },
                            ),
                            (
                                string("output"),
                                match &v711 {
                                    Spiral_builder::US5::US5_0(v711_0_0) => match &v711 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => string(""),
                                },
                            ),
                        ]);
                        let v726: Vec<(string, string)> = v724.to_vec();
                        let v729: Vec<LrcPtr<(std::string::String, std::string::String)>> = v726
                            .into_iter()
                            .map(|x| {
                                Func1::new(move |arg10_0040_5: (string, string)| {
                                    Spiral_builder::closure67((), arg10_0040_5)
                                })(x.clone())
                            })
                            .collect::<Vec<_>>();
                        let v730: string =
                            string("std::collections::BTreeMap::from_iter(v729.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                        let v731: std::collections::BTreeMap<
                            std::string::String,
                            std::string::String,
                        > = std::collections::BTreeMap::from_iter(
                            v729.iter()
                                .map(|x| x.as_ref())
                                .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                        );
                        let v733: Result<std::string::String, serde_json::Error> =
                            serde_json::to_string(&v731);
                        let v736: std::string::String = v733.unwrap();
                        new_array(&[(
                            string("command_result"),
                            fable_library_rust::String_::fromString(v736),
                        )])
                    } else {
                        if fable_library_rust::String_::fromString(v25.clone()) == string("fable") {
                            let v755: string = Spiral_builder::method139();
                            let v758: &str = &*v755;
                            let v781: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v26.clone(), v758).cloned();
                            let v795: Spiral_builder::US7 = defaultValue(
                                Spiral_builder::US7::US7_1,
                                map(Spiral_builder::method22(), v781),
                            );
                            let v802: std::string::String = match &v795 {
                                Spiral_builder::US7::US7_0(v795_0_0) => match &v795 {
                                    Spiral_builder::US7::US7_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v804: string = fable_library_rust::String_::fromString(v802);
                            let v805: string = Spiral_builder::method140();
                            let v808: &str = &*v805;
                            let v831: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v26.clone(), v808).cloned();
                            let v845: Spiral_builder::US7 = defaultValue(
                                Spiral_builder::US7::US7_1,
                                map(Spiral_builder::method22(), v831),
                            );
                            let v855: Spiral_builder::US5 = match &v845 {
                                Spiral_builder::US7::US7_0(v845_0_0) => Spiral_builder::US5::US5_0(
                                    fable_library_rust::String_::fromString(match &v845 {
                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                ),
                                _ => Spiral_builder::US5::US5_1,
                            };
                            new_array(&[(
                                string("command_result"),
                                match &v855 {
                                    Spiral_builder::US5::US5_0(v855_0_0) => {
                                        let v857: clap::Command = Spiral_builder::method0();
                                        let v859: Spiral_builder::US22 =
                                            Spiral_builder::method82(sprintf!(
                                                "_ {} --fs-path \"{}\"",
                                                match &v855 {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                v804
                                            ));
                                        let v867: Array<string> = match &v859 {
                                            Spiral_builder::US22::US22_0(v859_0_0) => {
                                                v859_0_0.clone()
                                            }
                                            Spiral_builder::US22::US22_1(v859_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v859_1_0.clone()
                                                ),
                                            ),
                                        };
                                        let v869: Vec<string> = v867.to_vec();
                                        let v871: bool = true;
                                        let _vec_map: Vec<_> = v869
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v873: string = x;
                                                let v876: &str = &*v873;
                                                let v900: std::string::String = String::from(v876);
                                                let v923: bool = true;
                                                v900
                                            })
                                            .collect::<Vec<_>>();
                                        let v925: Vec<std::string::String> = _vec_map;
                                        let v928: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<string, string>,
                                                >,
                                            >,
                                        > = Spiral_builder::method19(
                                            v0_1.clone(),
                                            clap::Command::get_matches_from(v857, v925),
                                        );
                                        let v930: Result<string, string> = v928.await;
                                        v930.unwrap()
                                    }
                                    _ => string("{}"),
                                },
                            )])
                        } else {
                            if fable_library_rust::String_::fromString(v25.clone()) == string("dib")
                            {
                                let v953: string = Spiral_builder::method141();
                                let v956: &str = &*v953;
                                let v979: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v26.clone(), v956).cloned();
                                let v981: Option<string> = map(Spiral_builder::method142(), v979);
                                let v995: string = v981.unwrap();
                                let v996: string = Spiral_builder::method167();
                                let v999: &str = &*v996;
                                let v1023: u8 = defaultValue(
                                    1_u8,
                                    clap::ArgMatches::get_one(&v26.clone(), v999).cloned(),
                                );
                                let v1026: string = Spiral_builder::method168();
                                let v1029: &str = &*v1026;
                                let v1052: Option<string> =
                                    clap::ArgMatches::get_one(&v26.clone(), v1029).cloned();
                                let patternInput_5: (i32, string) = Spiral_builder::method169(
                                    defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        map(Spiral_builder::method5(), v1052),
                                    ),
                                    v1023,
                                    v995.clone(),
                                    1_u8,
                                );
                                let v1072: string = patternInput_5.1.clone();
                                let v1071: i32 = patternInput_5.0.clone();
                                let patternInput_8: (i32, string) = if v1071 != 0_i32 {
                                    (v1071, v1072.clone())
                                } else {
                                    let patternInput_6: (i32, string) =
                                            Spiral_builder::method67(sprintf!("jupyter nbconvert \"{}.ipynb\" --to html --HTMLExporter.theme=dark",
                                                                              v995.clone()),
                                                                     None::<CancellationToken>,
                                                                     new_empty::<(string,
                                                                                  string)>(),
                                                                     None::<Func1<(i32,
                                                                                   string,
                                                                                   bool),
                                                                                  Arc<Async<()>>>>,
                                                                     None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                  ()>>,
                                                                     true,
                                                                     None::<string>);
                                    let v1084: string = patternInput_6.1.clone();
                                    let v1083: i32 = patternInput_6.0.clone();
                                    let v1087: () = {
                                        Spiral_builder::closure78(v1084.clone(), v1083, ());
                                        ()
                                    };
                                    if v1083 != 0_i32 {
                                        (
                                            v1083,
                                            sprintf!(
                                                "repl_result: {}\n\njupyter_result: {}",
                                                v1072.clone(),
                                                v1084.clone()
                                            ),
                                        )
                                    } else {
                                        let patternInput_7:
                                                    (i32, string) =
                                                Spiral_builder::method67(sprintf!("pwsh -c \"$counter = 1; $path = \'{}.html\'; (Get-Content $path -Raw) -replace \'(id=\\\"cell-id=)[a-fA-F0-9]{{8}}\', {{ $_.Groups[1].Value + $counter++ }} | Set-Content $path\"",
                                                                                  replace(v995.clone(),
                                                                                          string("\'"),
                                                                                          string("\'\'"))),
                                                                         None::<CancellationToken>,
                                                                         new_empty::<(string,
                                                                                      string)>(),
                                                                         None::<Func1<(i32,
                                                                                       string,
                                                                                       bool),
                                                                                      Arc<Async<()>>>>,
                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                      ()>>,
                                                                         true,
                                                                         None::<string>);
                                        let v1143: string = patternInput_7.1.clone();
                                        let v1142: i32 = patternInput_7.0.clone();
                                        let v1146: () = {
                                            Spiral_builder::closure79(v1143.clone(), v1142, ());
                                            ()
                                        };
                                        let v1187: string = sprintf!("{}.html", v995.clone());
                                        let v1191: Result<Vec<u8>, std::io::Error> =
                                            std::fs::read(&*v1187);
                                        let v1229: Vec<u8> =
                                            Spiral_builder::method26(v1191.unwrap());
                                        let v1231: Result<
                                            std::string::String,
                                            std::string::FromUtf8Error,
                                        > = std::string::String::from_utf8(v1229);
                                        let v1234: std::string::String = v1231.unwrap();
                                        let v1271: string = replace(
                                            fable_library_rust::String_::fromString(v1234),
                                            string("\r\n"),
                                            string("\n"),
                                        );
                                        let v1272: string = sprintf!("{}.html", v995.clone());
                                        std::fs::write(&*v1272, &*v1271).unwrap();
                                        ();
                                        {
                                            let v1276: string = sprintf!("{}.ipynb", v995.clone());
                                            let v1280: Result<Vec<u8>, std::io::Error> =
                                                std::fs::read(&*v1276);
                                            let v1318: Vec<u8> =
                                                Spiral_builder::method26(v1280.unwrap());
                                            let v1320: Result<
                                                std::string::String,
                                                std::string::FromUtf8Error,
                                            > = std::string::String::from_utf8(v1318);
                                            let v1323: std::string::String = v1320.unwrap();
                                            let v1361: string = replace(
                                                replace(
                                                    fable_library_rust::String_::fromString(v1323),
                                                    string("\r\n"),
                                                    string("\n"),
                                                ),
                                                string("\\r\\n"),
                                                string("\\n"),
                                            );
                                            let v1362: string = sprintf!("{}.ipynb", v995);
                                            std::fs::write(&*v1362, &*v1361).unwrap();
                                            ();
                                            (v1142,
                                                 sprintf!("repl_result: {}\n\njupyter_result: {}\n\npwsh_replace_html_result: {}",
                                                          v1072, v1084,
                                                          v1143))
                                        }
                                    }
                                };
                                let v1370: string = patternInput_8.1.clone();
                                let v1369: i32 = patternInput_8.0.clone();
                                let v1373: () = {
                                    Spiral_builder::closure80(v1370.clone(), v1369, ());
                                    ()
                                };
                                if v1369 != 0_i32 {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "spiral_builder.run / dib / exit_code: {} / result: {}",
                                            v1369,
                                            v1370.clone()
                                        )
                                    );
                                }
                                new_array(&[(string("stdio"), v1370)])
                            } else {
                                let patternInput_31: (
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                ) = if fable_library_rust::String_::fromString(v25.clone())
                                    == string("rust")
                                {
                                    let v1423: string = Spiral_builder::method139();
                                    let v1426: &str = &*v1423;
                                    let v1449: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1426).cloned();
                                    let v1463: Spiral_builder::US7 = defaultValue(
                                        Spiral_builder::US7::US7_1,
                                        map(Spiral_builder::method22(), v1449),
                                    );
                                    let v1470: std::string::String = match &v1463 {
                                        Spiral_builder::US7::US7_0(v1463_0_0) => match &v1463 {
                                            Spiral_builder::US7::US7_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                    let v1472: string =
                                        fable_library_rust::String_::fromString(v1470);
                                    let v1473: string = Spiral_builder::method24();
                                    let v1476: &str = &*v1473;
                                    let v1499: Option<Vec<std::string::String>> =
                                        clap::ArgMatches::get_many(&v26.clone(), v1476)
                                            .map(|x| x.cloned().into_iter().collect());
                                    let v1513: Spiral_builder::US11 = defaultValue(
                                        Spiral_builder::US11::US11_1,
                                        map(Spiral_builder::method25(), v1499),
                                    );
                                    let v1519: Vec<std::string::String> =
                                        new_empty::<std::string::String>().to_vec();
                                    let v1522: Vec<std::string::String> = match &v1513 {
                                        Spiral_builder::US11::US11_0(v1513_0_0) => match &v1513 {
                                            Spiral_builder::US11::US11_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => v1519,
                                    };
                                    let v1523: string = Spiral_builder::method178();
                                    let v1526: &str = &*v1523;
                                    let v1549: bool =
                                        clap::ArgMatches::get_flag(&v26.clone(), v1526);
                                    let v1550: string = Spiral_builder::method179();
                                    let v1553: &str = &*v1550;
                                    let v1576: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1553).cloned();
                                    let v1590: Spiral_builder::US7 = defaultValue(
                                        Spiral_builder::US7::US7_1,
                                        map(Spiral_builder::method22(), v1576),
                                    );
                                    let v1600: Spiral_builder::US5 = match &v1590 {
                                        Spiral_builder::US7::US7_0(v1590_0_0) => {
                                            Spiral_builder::US5::US5_0(
                                                fable_library_rust::String_::fromString(
                                                    match &v1590 {
                                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                ),
                                            )
                                        }
                                        _ => Spiral_builder::US5::US5_1,
                                    };
                                    let v1601: string = Spiral_builder::method180();
                                    let v1604: &str = &*v1601;
                                    let v1627: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1604).cloned();
                                    let v1641: Spiral_builder::US7 = defaultValue(
                                        Spiral_builder::US7::US7_1,
                                        map(Spiral_builder::method22(), v1627),
                                    );
                                    let v1651: Spiral_builder::US5 = match &v1641 {
                                        Spiral_builder::US7::US7_0(v1641_0_0) => {
                                            Spiral_builder::US5::US5_0(
                                                fable_library_rust::String_::fromString(
                                                    match &v1641 {
                                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                ),
                                            )
                                        }
                                        _ => Spiral_builder::US5::US5_1,
                                    };
                                    let v1660: Spiral_builder::US35 =
                                        if let Spiral_builder::US5::US5_0(v1600_0_0) = &v1600 {
                                            Spiral_builder::US35::US35_0(
                                                Spiral_builder::US36::US36_0(match &v1600 {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }),
                                            )
                                        } else {
                                            if let Spiral_builder::US5::US5_0(v1651_0_0) = &v1651 {
                                                Spiral_builder::US35::US35_0(
                                                    Spiral_builder::US36::US36_1(match &v1651 {
                                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }),
                                                )
                                            } else {
                                                Spiral_builder::US35::US35_1
                                            }
                                        };
                                    let v1664: Result<Vec<u8>, std::io::Error> =
                                        std::fs::read(&*v1472);
                                    let v1702: Vec<u8> = Spiral_builder::method26(v1664.unwrap());
                                    let v1704: Result<
                                        std::string::String,
                                        std::string::FromUtf8Error,
                                    > = std::string::String::from_utf8(v1702);
                                    let v1707: std::string::String = v1704.unwrap();
                                    let v1737: string =
                                        fable_library_rust::String_::fromString(v1707);
                                    let v1744: string =
                                        Spiral_builder::method182(Spiral_builder::method181(
                                            string("rs"),
                                            v1737.clone(),
                                            v1660.clone(),
                                        ));
                                    let v1749: Spiral_builder::US12 =
                                            Spiral_builder::method30(Spiral_builder::method27(string("polyglot"),
                                                                                              string(".devcontainer")),
                                                                     string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder"));
                                    let v1797: Spiral_builder::US5 = match &v1749 {
                                        Spiral_builder::US12::US12_0(v1749_0_0) => {
                                            Spiral_builder::US5::US5_0(v1749_0_0.clone())
                                        }
                                        Spiral_builder::US12::US12_1(v1749_1_0) => {
                                            let v1755: () = {
                                                Spiral_builder::closure16(v1749_1_0.clone(), ());
                                                ()
                                            };
                                            Spiral_builder::US5::US5_1
                                        }
                                    };
                                    let v1852: Spiral_builder::US5 = match &v1797 {
                                        Spiral_builder::US5::US5_0(v1797_0_0) => {
                                            Spiral_builder::US5::US5_0(match &v1797 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v1800: string = Spiral_builder::method38();
                                            let v1802: Spiral_builder::US12 =
                                                Spiral_builder::method30(
                                                    Spiral_builder::method27(
                                                        string("polyglot"),
                                                        string(".devcontainer"),
                                                    ),
                                                    v1800,
                                                );
                                            match &v1802 {
                                                Spiral_builder::US12::US12_0(v1802_0_0) => {
                                                    Spiral_builder::US5::US5_0(v1802_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v1802_1_0) => {
                                                    let v1808: () = {
                                                        Spiral_builder::closure16(
                                                            v1802_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    Spiral_builder::US5::US5_1
                                                }
                                            }
                                        }
                                    };
                                    let v1857: string = Spiral_builder::method27(
                                        match &v1852 {
                                            Spiral_builder::US5::US5_0(v1852_0_0) => match &v1852 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        },
                                        string("polyglot"),
                                    );
                                    let v1860: string = toLower(Spiral_builder::method38());
                                    let v1864: string = toLower(v1857);
                                    let v1872: Spiral_builder::US12 =
                                        if startsWith(v1860, v1864.clone(), false) {
                                            Spiral_builder::US12::US12_1(v1864.clone())
                                        } else {
                                            Spiral_builder::US12::US12_0(v1864)
                                        };
                                    let v1878: Result<string, string> = match &v1872 {
                                        Spiral_builder::US12::US12_0(v1872_0_0) => {
                                            Ok::<string, string>(v1872_0_0.clone())
                                        }
                                        Spiral_builder::US12::US12_1(v1872_1_0) => {
                                            Err::<string, string>(v1872_1_0.clone())
                                        }
                                    };
                                    let v1880: bool = true;
                                    let _result_unwrap_or_else = v1878.unwrap_or_else(|x| {
                                        //;
                                        let v1882: string = x;
                                        let v1884: bool = true;
                                        v1882
                                    });
                                    let v1886: string = _result_unwrap_or_else;
                                    let v1891: string = Spiral_builder::method185(
                                        Spiral_builder::US5::US5_0(v1744.clone()),
                                        string("spiral_builder"),
                                        Spiral_builder::US38::US38_0(Spiral_builder::US37::US37_0),
                                        v1886.clone(),
                                    );
                                    let v1896: string = Spiral_builder::method186(
                                        v1737,
                                        string("spiral_builder"),
                                        LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                            string("Fable.Core"),
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        )),
                                        v1891.clone(),
                                        v1886.clone(),
                                    );
                                    let v1898: string =
                                        Spiral_builder::method27(v1891.clone(), string("../../.."));
                                    let v1900: string = Spiral_builder::method27(
                                        v1898.clone(),
                                        string("Cargo.toml"),
                                    );
                                    if Spiral_builder::method42(v1900.clone()) == false {
                                        let v1904: DateTime = DateTime::now();
                                        let v1924: string =
                                            toString(Spiral_builder::method189(new_guid(), v1904));
                                        let v1949: string =
                                                append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                           sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                    v1924.clone())),
                                                                                                                                    string("\n")),
                                                                                                                             string("version = \"0.0.1\"")),
                                                                                                                      string("\n")),
                                                                                                               string("edition = \"2021\"")),
                                                                                                        string("\n")),
                                                                                                 string("")),
                                                                                          string("\n")),
                                                                                   string("[[bin]]")),
                                                                            string("\n")),
                                                                     sprintf!("name = \"spiral_builder_{}\"",
                                                                              v1924)),
                                                              string("\n")),
                                                       string("path = \"spiral_builder.rs\""));
                                        std::fs::write(&*v1900.clone(), &*v1949).unwrap();
                                        ();
                                        ()
                                    }
                                    {
                                        let v1953: string = Spiral_builder::method27(
                                            v1891.clone(),
                                            string("Cargo.toml"),
                                        );
                                        if Spiral_builder::method42(v1953.clone()) == false {
                                            let v1957: DateTime = DateTime::now();
                                            let v1977: string = toString(
                                                Spiral_builder::method189(new_guid(), v1957),
                                            );
                                            let v2002: string =
                                                    append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                               sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                        v1977.clone())),
                                                                                                                                        string("\n")),
                                                                                                                                 string("version = \"0.0.1\"")),
                                                                                                                          string("\n")),
                                                                                                                   string("edition = \"2021\"")),
                                                                                                            string("\n")),
                                                                                                     string("")),
                                                                                              string("\n")),
                                                                                       string("[[bin]]")),
                                                                                string("\n")),
                                                                         sprintf!("name = \"spiral_builder_{}\"",
                                                                                  v1977)),
                                                                  string("\n")),
                                                           string("path = \"spiral_builder.rs\""));
                                            std::fs::write(&*v1953.clone(), &*v2002).unwrap();
                                            ();
                                            ()
                                        }
                                        {
                                            let v2007: string =
                                                    Spiral_builder::method27(v1886.clone(),
                                                                             string("lib/rust/fable/fable_modules/fable-library-rust"));
                                            let v2009: string = Spiral_builder::method27(
                                                v1891.clone(),
                                                string("fable_modules/fable-library-rust"),
                                            );
                                            Spiral_builder::method194(v2007, v2009.clone());
                                            {
                                                let patternInput_9: (i32, string) =
                                                    Spiral_builder::method195(
                                                        v1660.clone(),
                                                        v1891.clone(),
                                                        string("rs"),
                                                        v1896,
                                                        v1872.clone(),
                                                    );
                                                let v2011: string = patternInput_9.1.clone();
                                                let v2010: i32 = patternInput_9.0.clone();
                                                let patternInput_18: (
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                ) = if v2010 != 0_i32 {
                                                    let v2017: () = {
                                                        Spiral_builder::closure83(
                                                            v2011.clone(),
                                                            v2010,
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    (
                                                        Spiral_builder::US5::US5_0(string("rs")),
                                                        Spiral_builder::US5::US5_1,
                                                        Spiral_builder::US5::US5_1,
                                                        Spiral_builder::US5::US5_0(v2011),
                                                    )
                                                } else {
                                                    let v2137: Vec<std::string::String> =
                                                        if if let Spiral_builder::US35::US35_1 =
                                                            &v1660
                                                        {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            v1522.clone()
                                                        } else {
                                                            let v2062 = Spiral_builder::method205();
                                                            let v2063: Vec<std::string::String> =
                                                                Spiral_builder::method206(
                                                                    v1522.clone(),
                                                                );
                                                            let v2065: Vec<std::string::String> =
                                                                v2063
                                                                    .into_iter()
                                                                    .filter(|x| {
                                                                        v2062(x.clone().clone())
                                                                    })
                                                                    .collect::<Vec<_>>();
                                                            if v2065.len() as i32 > 0_i32 {
                                                                v1522.clone()
                                                            } else {
                                                                let v2079: &str =
                                                                    &*string("near-sdk");
                                                                let v2125: Array<
                                                                    std::string::String,
                                                                > = new_array(&[String::from(
                                                                    v2079,
                                                                )]);
                                                                let v2128: Vec<
                                                                    std::string::String,
                                                                > = Spiral_builder::method207(
                                                                    v2125.to_vec(),
                                                                );
                                                                let v2129: Vec<
                                                                    std::string::String,
                                                                > = Spiral_builder::method208(
                                                                    v1522,
                                                                );
                                                                let v2131: bool = true;
                                                                let mut v2129 = v2129;
                                                                let v2133: bool = true;
                                                                v2129.extend(v2128);
                                                                v2129
                                                            }
                                                        };
                                                    let v2139: bool = true;
                                                    let _vec_map : Vec<_> = v2137.into_iter().map(|x| { //;
                                                            let v2141:
                                                                    std::string::String =
                                                                x;
                                                            let v2143:
                                                                    string =
                                                                fable_library_rust::String_::fromString(v2141);
                                                            let v2156:
                                                                    string =
                                                                if contains(v2143.clone(),
                                                                            string("="))
                                                                   {
                                                                    v2143.clone()
                                                                } else {
                                                                    if endsWith(v2143.clone(),
                                                                                string("]"),
                                                                                false)
                                                                       {
                                                                        sprintf!("{}}}",
                                                                                 replace(v2143.clone(),
                                                                                         string("["),
                                                                                         string("={version=\'*\',features=[")))
                                                                    } else {
                                                                        sprintf!("{}=\'*\'",
                                                                                 v2143)
                                                                    }
                                                                };
                                                            let v2158: bool =
                                                                true; v2156 }).collect::<Vec<_>>();
                                                    let v2160: Vec<string> = _vec_map;
                                                    let v2162:
                                                                    Array<string> =
                                                                fable_library_rust::NativeArray_::array_from(v2160);
                                                    let _v2163: LrcPtr<dyn IEnumerable_1<string>> =
                                                        delay(Func0::new({
                                                            let v2162 = v2162.clone();
                                                            move || {
                                                                map_1(
                                                                    Func1::new({
                                                                        let v2162 = v2162.clone();
                                                                        move |i_1: i32| {
                                                                            v2162[i_1].clone()
                                                                        }
                                                                    }),
                                                                    rangeNumeric(
                                                                        0_i32,
                                                                        1_i32,
                                                                        count_2(v2162.clone())
                                                                            - 1_i32,
                                                                    ),
                                                                )
                                                            }
                                                        }));
                                                    let v2173: string = join(
                                                        Spiral_builder::method39(),
                                                        toArray_1(_v2163),
                                                    );
                                                    let v2178: string = Spiral_builder::method27(
                                                        v1891,
                                                        sprintf!(
                                                            "{}.{}",
                                                            string("spiral_builder"),
                                                            string("rs")
                                                        ),
                                                    );
                                                    let v2182: Result<Vec<u8>, std::io::Error> =
                                                        std::fs::read(&*v2178.clone());
                                                    let v2220: Vec<u8> =
                                                        Spiral_builder::method26(v2182.unwrap());
                                                    let v2222: Result<
                                                        std::string::String,
                                                        std::string::FromUtf8Error,
                                                    > = std::string::String::from_utf8(v2220);
                                                    let v2225: std::string::String = v2222.unwrap();
                                                    let v2255: string =
                                                        fable_library_rust::String_::fromString(
                                                            v2225,
                                                        );
                                                    let v2262: string = append(
                                                        string("on_startup!"),
                                                        Spiral_builder::method209(),
                                                    );
                                                    let v2265: string = append(
                                                        string(" method0"),
                                                        Spiral_builder::method210(),
                                                    );
                                                    let v2273: bool =
                                                        if contains(v2255.clone(), v2262.clone()) {
                                                            contains(v2255, v2265) == false
                                                        } else {
                                                            false
                                                        };
                                                    let v2336:
                                                                    string =
                                                                append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                                                                                   sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                                                                            v1744.clone())),
                                                                                                                                                                                                            string("\n")),
                                                                                                                                                                                                     string("version = \"0.0.1\"")),
                                                                                                                                                                                              string("\n")),
                                                                                                                                                                                       string("edition = \"2021\"")),
                                                                                                                                                                                string("\n")),
                                                                                                                                                                         string("")),
                                                                                                                                                                  string("\n")),
                                                                                                                                                           string("[dependencies]")),
                                                                                                                                                    string("\n")),
                                                                                                                                             (if !(v1660.clone()
                                                                                                                                                       ==
                                                                                                                                                       Spiral_builder::US35::US35_1)
                                                                                                                                                 {
                                                                                                                                                  string("fable_library_rust = { workspace = true }")
                                                                                                                                              } else {
                                                                                                                                                  append(append(append(string("fable_library_rust = { workspace = true, features = ["),
                                                                                                                                                                       (if v2273
                                                                                                                                                                           {
                                                                                                                                                                            string("\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"")
                                                                                                                                                                        } else {
                                                                                                                                                                            string("\"datetime\", \"guid\", \"threaded\"")
                                                                                                                                                                        })),
                                                                                                                                                                string("]")),
                                                                                                                                                         string("}"))
                                                                                                                                              })),
                                                                                                                                      string("\n")),
                                                                                                                               string("inline_colorization = { workspace = true }")),
                                                                                                                        string("\n")),
                                                                                                                 sprintf!("{}",
                                                                                                                          v2173)),
                                                                                                          string("\n")),
                                                                                                   string("")),
                                                                                            string("\n")),
                                                                                     (if if let Spiral_builder::US35::US35_1
                                                                                                =
                                                                                                &v1660
                                                                                            {
                                                                                             true
                                                                                         } else {
                                                                                             false
                                                                                         }
                                                                                         {
                                                                                          append(string("[[bin]]\n"),
                                                                                                 sprintf!("name = \"spiral_builder_{}\"",
                                                                                                          v1744.clone()))
                                                                                      } else {
                                                                                          string("[lib]\ncrate-type = [\"cdylib\"]")
                                                                                      })),
                                                                              string("\n")),
                                                                       string("path = \"spiral_builder.rs\""));
                                                    let v2401:
                                                                    string =
                                                                append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(string("cargo-features = [\"profile-rustflags\"]\n\n[workspace]\nresolver = \"2\"\nmembers = [\"packages/Rust/*\"]\n\n[workspace.dependencies.fable_library_rust]\n"),
                                                                                                                                                                                                                                                                           sprintf!("path = \"{}/lib/rust/fable/fable_modules/fable-library-rust\"",
                                                                                                                                                                                                                                                                                    Spiral_builder::method146(v1886.clone()))),
                                                                                                                                                                                                                                                                    string("\n")),
                                                                                                                                                                                                                                                             string("default-features = false")),
                                                                                                                                                                                                                                                      string("\n")),
                                                                                                                                                                                                                                               string("features = []")),
                                                                                                                                                                                                                                        string("\n")),
                                                                                                                                                                                                                                 string("")),
                                                                                                                                                                                                                          string("\n")),
                                                                                                                                                                                                                   string("[workspace.dependencies]")),
                                                                                                                                                                                                            string("\n")),
                                                                                                                                                                                                     string("inline_colorization = \"~0.1\"")),
                                                                                                                                                                                              string("\n")),
                                                                                                                                                                                       string("")),
                                                                                                                                                                                string("\n")),
                                                                                                                                                                         string("[profile.release]")),
                                                                                                                                                                  string("\n")),
                                                                                                                                                           string("codegen-units = 1")),
                                                                                                                                                    string("\n")),
                                                                                                                                             string("opt-level = \"z\"")),
                                                                                                                                      string("\n")),
                                                                                                                               string("lto = true")),
                                                                                                                        string("\n")),
                                                                                                                 string("debug = false")),
                                                                                                          string("\n")),
                                                                                                   string("panic = \"abort\"")),
                                                                                            string("\n")),
                                                                                     string("overflow-checks = true")),
                                                                              string("\n")),
                                                                       string("rustflags = [\"-C\", \"link-arg=-s\"]"));
                                                    Spiral_builder::method40(v1953.clone(), v2336);
                                                    Spiral_builder::method40(v1900, v2401);
                                                    {
                                                        let v2403: string =
                                                            Spiral_builder::method27(
                                                                v2009,
                                                                string("src/Range.rs"),
                                                            );
                                                        if Spiral_builder::method42(v2403.clone()) {
                                                            let v2408: Result<
                                                                Vec<u8>,
                                                                std::io::Error,
                                                            > = std::fs::read(&*v2403.clone());
                                                            let v2446: Vec<u8> =
                                                                Spiral_builder::method26(
                                                                    v2408.unwrap(),
                                                                );
                                                            let v2448: Result<
                                                                std::string::String,
                                                                std::string::FromUtf8Error,
                                                            > = std::string::String::from_utf8(
                                                                v2446,
                                                            );
                                                            let v2451: std::string::String =
                                                                v2448.unwrap();
                                                            Spiral_builder::method40(v2403,
                                                                                             replace(replace(fable_library_rust::String_::fromString(v2451),
                                                                                                             string("use crate::String_::fromCharCode;"),
                                                                                                             string("use crate::String_::fromChar;")),
                                                                                                     string("fromCharCode(c)"),
                                                                                                     string("std::char::from_u32(c).unwrap()")))
                                                        }
                                                        {
                                                            let patternInput_10: (i32, string) =
                                                                Spiral_builder::method211(
                                                                    v1872.clone(),
                                                                    v1953.clone(),
                                                                    1_u8,
                                                                );
                                                            let v2493: i32 =
                                                                patternInput_10.0.clone();
                                                            if v2493 != 0_i32 {
                                                                let v2500: () = {
                                                                    Spiral_builder::closure87(
                                                                        patternInput_10.1.clone(),
                                                                        v2493,
                                                                        (),
                                                                    );
                                                                    ()
                                                                };
                                                                ()
                                                            }
                                                            {
                                                                let v2543: Result<
                                                                    Vec<u8>,
                                                                    std::io::Error,
                                                                > = std::fs::read(&*v2178.clone());
                                                                let v2581: Vec<u8> =
                                                                    Spiral_builder::method26(
                                                                        v2543.unwrap(),
                                                                    );
                                                                let v2583: Result<
                                                                    std::string::String,
                                                                    std::string::FromUtf8Error,
                                                                > = std::string::String::from_utf8(
                                                                    v2581,
                                                                );
                                                                let v2586: std::string::String =
                                                                    v2583.unwrap();
                                                                let v2616:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v2586);
                                                                let v2623:
                                                                                string =
                                                                            append(string("pub fn main() -> Result<(), String> "),
                                                                                   Spiral_builder::method217());
                                                                let v2669:
                                                                                string =
                                                                            append(append((if if let Spiral_builder::US35::US35_1
                                                                                                     =
                                                                                                     &v1660
                                                                                                 {
                                                                                                  true
                                                                                              } else {
                                                                                                  false
                                                                                              }
                                                                                              {
                                                                                               string("")
                                                                                           } else {
                                                                                               string("#[near_sdk::near_bindgen]\n#[derive(near_sdk::PanicOnDefault)]\npub struct MainState {\n}\n\n#[near_sdk::near_bindgen]\nimpl MainState {\n    pub fn state_main() {\n        Spiral_builder::method0();\n    }\n}")
                                                                                           }),
                                                                                          string("\n")),
                                                                                   (if if if let Spiral_builder::US35::US35_1
                                                                                                 =
                                                                                                 &v1660
                                                                                             {
                                                                                              true
                                                                                          } else {
                                                                                              false
                                                                                          }
                                                                                          {
                                                                                           contains(v2616.clone(),
                                                                                                    append(v2262.clone(),
                                                                                                           string("Spiral_builder::method0()")))
                                                                                       } else {
                                                                                           false
                                                                                       }
                                                                                       {
                                                                                        sprintf!("{} Ok(Spiral_builder::method0()) }}",
                                                                                                 v2623.clone())
                                                                                    } else {
                                                                                        sprintf!("{} Ok(()) }}",
                                                                                                 v2623.clone())
                                                                                    }));
                                                                let v2670: bool =
                                                                    contains(v2616.clone(), v2623);
                                                                let v2767: string = if v2670 {
                                                                    v2616.clone()
                                                                } else {
                                                                    (if (if let Spiral_builder::US35::US35_0(v1660_0_0)
                                                                                            =
                                                                                            &v1660
                                                                                        {
                                                                                         if let Spiral_builder::US36::US36_1(_)
                                                                                                =
                                                                                                &match &v1660
                                                                                                     {
                                                                                                     Spiral_builder::US35::US35_0(x)
                                                                                                     =>
                                                                                                     x.clone(),
                                                                                                     _
                                                                                                     =>
                                                                                                     unreachable!(),
                                                                                                 }
                                                                                            {
                                                                                             true
                                                                                         } else {
                                                                                             false
                                                                                         }
                                                                                     } else {
                                                                                         false
                                                                                     })
                                                                                        ==
                                                                                        false
                                                                                    {
                                                                                     Func1::new(move
                                                                                                    |v_5:
                                                                                                         string|
                                                                                                    Spiral_builder::closure88((),
                                                                                                                              v_5))
                                                                                 } else {
                                                                                     let v2763:
                                                                                             string =
                                                                                         string("use fable_library_rust::DateTime_::DateTime;");
                                                                                     Func1::new({
                                                                                                    let v2763
                                                                                                        =
                                                                                                        v2763.clone();
                                                                                                    move
                                                                                                        |v_6:
                                                                                                             string|
                                                                                                        Spiral_builder::closure90(v2763.clone(),
                                                                                                                                  v_6)
                                                                                                })
                                                                                 })((if v2273
                                                                                        {
                                                                                         Func1::new(move
                                                                                                        |v_3:
                                                                                                             string|
                                                                                                        Spiral_builder::closure88((),
                                                                                                                                  v_3))
                                                                                     } else {
                                                                                         let v2755:
                                                                                                 string =
                                                                                             append(string("// "),
                                                                                                    v2262.clone());
                                                                                         Func1::new({
                                                                                                        let v2262
                                                                                                            =
                                                                                                            v2262.clone();
                                                                                                        let v2755
                                                                                                            =
                                                                                                            v2755.clone();
                                                                                                        move
                                                                                                            |v_4:
                                                                                                                 string|
                                                                                                            Spiral_builder::closure89(v2262.clone(),
                                                                                                                                      v2755.clone(),
                                                                                                                                      v_4)
                                                                                                    })
                                                                                     })(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(Spiral_builder::method162(string("\\s\\sdefaultOf\\(\\);"),
                                                                                                                                                                                                          string(" defaultOf::<()>();"),
                                                                                                                                                                                                          replace(replace(sprintf!("{}\n\n{}\n",
                                                                                                                                                                                                                                   v2616,
                                                                                                                                                                                                                                   v2669),
                                                                                                                                                                                                                          append(string("),)"),
                                                                                                                                                                                                                                 ";".into()),
                                                                                                                                                                                                                          string("));")),
                                                                                                                                                                                                                  append(string("},)"),
                                                                                                                                                                                                                         ";".into()),
                                                                                                                                                                                                                  string("});"))),
                                                                                                                                                                                string("::Slice\'_"),
                                                                                                                                                                                string("::Slice__")),
                                                                                                                                                                        string(" Slice\'_"),
                                                                                                                                                                        string(" Slice__")),
                                                                                                                                                                append(string("defaultOf()"),
                                                                                                                                                                       ",".into()),
                                                                                                                                                                string("defaultOf::<std::sync::Arc<dyn IDisposable>>(),")),
                                                                                                                                                        append(string("_self"),
                                                                                                                                                               "_.".into()),
                                                                                                                                                        string("self.")),
                                                                                                                                                append(string("get_or_insert_wit"),
                                                                                                                                                       "h".into()),
                                                                                                                                                string("get_or_init")),
                                                                                                                                        append(string("use fable_library_rust::System::Collections::Concurrent::ConcurrentStack_1"),
                                                                                                                                               ";".into()),
                                                                                                                                        string("type ConcurrentStack_1<T> = T;")),
                                                                                                                                append(string("use fable_library_rust::System::Collections::Generic"),
                                                                                                                                       "::".into()),
                                                                                                                                string("use fable_library_rust::Interfaces_::System::Collections::Generic::")),
                                                                                                                        append(string("use fable_library_rust::System::IDisposable"),
                                                                                                                               ";".into()),
                                                                                                                        string("use fable_library_rust::Interfaces_::System::IDisposable;")),
                                                                                                                append(string("use fable_library_rust::System::Threading::CancellationToken"),
                                                                                                                       ";".into()),
                                                                                                                string("type CancellationToken = ();")),
                                                                                                        append(string("use fable_library_rust::System::TimeZoneInfo"),
                                                                                                               ";".into()),
                                                                                                        string("type TimeZoneInfo = i64;")),
                                                                                                append(string("use fable_library_rust::System::Threading::Tasks::TaskCanceledException"),
                                                                                                       ";".into()),
                                                                                                string("type TaskCanceledException = ();"))))
                                                                };
                                                                if v2670 == false {
                                                                    Spiral_builder::method40(
                                                                        v2178.clone(),
                                                                        v2767.clone(),
                                                                    );
                                                                }
                                                                {
                                                                    let v2773:
                                                                                    string =
                                                                                if (if let Spiral_builder::US35::US35_1
                                                                                           =
                                                                                           &v1660
                                                                                       {
                                                                                        true
                                                                                    } else {
                                                                                        false
                                                                                    })
                                                                                       !=
                                                                                       true
                                                                                   {
                                                                                    sprintf!("cargo +nightly-2024-07-14 build --release --target wasm32-unknown-unknown --manifest-path \"{}\"",
                                                                                             v1953.clone())
                                                                                } else {
                                                                                    sprintf!("cargo run --manifest-path \"{}\"",
                                                                                             v1953)
                                                                                };
                                                                    let v2786:
                                                                                    Array<(string,
                                                                                           string)> =
                                                                                if (if let Spiral_builder::US35::US35_1
                                                                                           =
                                                                                           &v1660
                                                                                       {
                                                                                        true
                                                                                    } else {
                                                                                        false
                                                                                    })
                                                                                       !=
                                                                                       true
                                                                                   {
                                                                                    new_empty::<(string,
                                                                                                 string)>()
                                                                                } else {
                                                                                    new_array(&[(string("TRACE_LEVEL"),
                                                                                                 string("Verbose")),
                                                                                                (string("RUSTC_WRAPPER"),
                                                                                                 string("sccache")),
                                                                                                (string("RUST_BACKTRACE"),
                                                                                                 string("full")),
                                                                                                (string("RUSTFLAGS"),
                                                                                                 string("-C prefer-dynamic"))])
                                                                                };
                                                                    let v2797:
                                                                                    Result<string,
                                                                                           string> =
                                                                                match &v1872
                                                                                    {
                                                                                    Spiral_builder::US12::US12_0(v1872_0_0)
                                                                                    =>
                                                                                    Ok::<string,
                                                                                         string>(v1872_0_0.clone()),
                                                                                    Spiral_builder::US12::US12_1(v1872_1_0)
                                                                                    =>
                                                                                    Err::<string,
                                                                                          string>(v1872_1_0.clone()),
                                                                                };
                                                                    let patternInput_11:
                                                                                    (i32,
                                                                                     string) =
                                                                                Spiral_builder::method67(v2773.clone(),
                                                                                                         None::<CancellationToken>,
                                                                                                         v2786.clone(),
                                                                                                         None::<Func1<(i32,
                                                                                                                       string,
                                                                                                                       bool),
                                                                                                                      Arc<Async<()>>>>,
                                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                      ()>>,
                                                                                                         true,
                                                                                                         v2797.ok());
                                                                    let v2814: string =
                                                                        patternInput_11.1.clone();
                                                                    let v2813: i32 =
                                                                        patternInput_11.0.clone();
                                                                    let patternInput_17:
                                                                                    (Spiral_builder::US5,
                                                                                     Spiral_builder::US5,
                                                                                     Spiral_builder::US5,
                                                                                     Spiral_builder::US5) =
                                                                                if if let Spiral_builder::US35::US35_1
                                                                                          =
                                                                                          &v1660
                                                                                      {
                                                                                       true
                                                                                   } else {
                                                                                       false
                                                                                   }
                                                                                   {
                                                                                    let v2816:
                                                                                            i32 =
                                                                                        count_2(v2786.clone());
                                                                                    let v2817:
                                                                                            Array<string> =
                                                                                        new_init(&string(""),
                                                                                                 v2816);
                                                                                    let v2818:
                                                                                            LrcPtr<Spiral_builder::Mut5> =
                                                                                        LrcPtr::new(Spiral_builder::Mut5{l0:
                                                                                                                             MutCell::new(0_i32),});
                                                                                    while Spiral_builder::method71(v2816,
                                                                                                                   v2818.clone())
                                                                                          {
                                                                                        let v2820:
                                                                                                i32 =
                                                                                            v2818.l0.get().clone();
                                                                                        let patternInput_12:
                                                                                                (string,
                                                                                                 string) =
                                                                                            v2786[v2820].clone();
                                                                                        let v2823:
                                                                                                string =
                                                                                            sprintf!("$env:{}=\'\'{}\'\'",
                                                                                                     patternInput_12.0.clone(),
                                                                                                     patternInput_12.1.clone());
                                                                                        v2817.get_mut()[v2820
                                                                                                            as
                                                                                                            usize]
                                                                                            =
                                                                                            v2823;
                                                                                        {
                                                                                            let v2824:
                                                                                                    i32 =
                                                                                                v2820
                                                                                                    +
                                                                                                    1_i32;
                                                                                            v2818.l0.set(v2824);
                                                                                            ()
                                                                                        }
                                                                                    }
                                                                                    {
                                                                                        let v2843:
                                                                                                string =
                                                                                            sprintf!("pwsh -c \'{}\'",
                                                                                                     join(string(";"),
                                                                                                          toArray_1(ofArray_1(new_array(&[join(string(";"),
                                                                                                                                               toArray_1(ofArray_1(v2817.clone()))),
                                                                                                                                          v2773])))));
                                                                                        let patternInput_13:
                                                                                                (Spiral_builder::US5,
                                                                                                 Spiral_builder::US5,
                                                                                                 Spiral_builder::US5,
                                                                                                 Spiral_builder::US5) =
                                                                                            if v2813
                                                                                                   !=
                                                                                                   0_i32
                                                                                               {
                                                                                                let v2849:
                                                                                                        () =
                                                                                                    {
                                                                                                        Spiral_builder::closure91(v1549,
                                                                                                                                  v2178.clone(),
                                                                                                                                  v2814.clone(),
                                                                                                                                  v2813,
                                                                                                                                  v2843.clone(),
                                                                                                                                  ());
                                                                                                        ()
                                                                                                    };
                                                                                                (Spiral_builder::US5::US5_0(string("rs")),
                                                                                                 Spiral_builder::US5::US5_1,
                                                                                                 Spiral_builder::US5::US5_1,
                                                                                                 Spiral_builder::US5::US5_1)
                                                                                            } else {
                                                                                                let result_1:
                                                                                                        LrcPtr<MutCell<Spiral_builder::US5>> =
                                                                                                    refCell(Spiral_builder::US5::US5_1);
                                                                                                try_catch(||
                                                                                                              result_1.set(Spiral_builder::closure62((),
                                                                                                                                                     Spiral_builder::closure92(v2814.clone(),
                                                                                                                                                                               ()))),
                                                                                                          |ex_1:
                                                                                                               LrcPtr<Exception>|
                                                                                                              result_1.set(Spiral_builder::closure94(v2178.clone(),
                                                                                                                                                     v2814.clone(),
                                                                                                                                                     v2843,
                                                                                                                                                     ex_1.clone())));
                                                                                                {
                                                                                                    let v2897:
                                                                                                            Spiral_builder::US5 =
                                                                                                        result_1.get().clone();
                                                                                                    let v2907:
                                                                                                            Option<string> =
                                                                                                        match &v2897
                                                                                                            {
                                                                                                            Spiral_builder::US5::US5_0(v2897_0_0)
                                                                                                            =>
                                                                                                            Some(match &v2897
                                                                                                                     {
                                                                                                                     Spiral_builder::US5::US5_0(x)
                                                                                                                     =>
                                                                                                                     x.clone(),
                                                                                                                     _
                                                                                                                     =>
                                                                                                                     unreachable!(),
                                                                                                                 }),
                                                                                                            _
                                                                                                            =>
                                                                                                            None::<string>,
                                                                                                        };
                                                                                                    (Spiral_builder::US5::US5_0(string("rs")),
                                                                                                     Spiral_builder::US5::US5_0(v2767.clone()),
                                                                                                     Spiral_builder::US5::US5_0(v2178.clone()),
                                                                                                     Spiral_builder::US5::US5_0(v2907.unwrap()))
                                                                                                }
                                                                                            };
                                                                                        (patternInput_13.0.clone(),
                                                                                         patternInput_13.1.clone(),
                                                                                         patternInput_13.2.clone(),
                                                                                         patternInput_13.3.clone())
                                                                                    }
                                                                                } else {
                                                                                    let v2918:
                                                                                            string =
                                                                                        sprintf!("target/spiral_builder/{}/target/wasm32-unknown-unknown/release/spiral_builder_{}.wasm",
                                                                                                 string("spiral_builder"),
                                                                                                 v1744.clone());
                                                                                    let v2930:
                                                                                            string =
                                                                                        sprintf!("pwsh -c \"pwsh {} {} -Linux -EnvironmentVariables AUTOMATION={}`nNEAR_RPC_TIMEOUT_SECS=100\"",
                                                                                                 string("scripts/invoke-block.ps1"),
                                                                                                 sprintf!("\'workspace/target/release/spiral_wasm -w {} -t Debug {}\'",
                                                                                                          v2918.clone(),
                                                                                                          if let Spiral_builder::US35::US35_0(v1660_0_0)
                                                                                                                 =
                                                                                                                 &v1660
                                                                                                             {
                                                                                                              let v2919:
                                                                                                                      Spiral_builder::US36 =
                                                                                                                  match &v1660
                                                                                                                      {
                                                                                                                      Spiral_builder::US35::US35_0(x)
                                                                                                                      =>
                                                                                                                      x.clone(),
                                                                                                                      _
                                                                                                                      =>
                                                                                                                      unreachable!(),
                                                                                                                  };
                                                                                                              match &v2919
                                                                                                                  {
                                                                                                                  Spiral_builder::US36::US36_0(v2919_0_0)
                                                                                                                  =>
                                                                                                                  v2919_0_0.clone(),
                                                                                                                  Spiral_builder::US36::US36_1(v2919_1_0)
                                                                                                                  =>
                                                                                                                  v2919_1_0.clone(),
                                                                                                              }
                                                                                                          } else {
                                                                                                              string("")
                                                                                                          }),
                                                                                                 Spiral_builder::method3(string("AUTOMATION")));
                                                                                    let patternInput_16:
                                                                                            (Spiral_builder::US5,
                                                                                             Spiral_builder::US5,
                                                                                             Spiral_builder::US5,
                                                                                             Spiral_builder::US5) =
                                                                                        if v2813
                                                                                               ==
                                                                                               0_i32
                                                                                           {
                                                                                            let patternInput_14:
                                                                                                    (i32,
                                                                                                     string) =
                                                                                                Spiral_builder::method67(v2930.clone(),
                                                                                                                         None::<CancellationToken>,
                                                                                                                         new_empty::<(string,
                                                                                                                                      string)>(),
                                                                                                                         None::<Func1<(i32,
                                                                                                                                       string,
                                                                                                                                       bool),
                                                                                                                                      Arc<Async<()>>>>,
                                                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                      ()>>,
                                                                                                                         true,
                                                                                                                         Some(v1886));
                                                                                            let v2942:
                                                                                                    string =
                                                                                                patternInput_14.1.clone();
                                                                                            let v2941:
                                                                                                    i32 =
                                                                                                patternInput_14.0.clone();
                                                                                            let patternInput_15:
                                                                                                    (Spiral_builder::US5,
                                                                                                     Spiral_builder::US5,
                                                                                                     Spiral_builder::US5,
                                                                                                     Spiral_builder::US5) =
                                                                                                if v2941
                                                                                                       ==
                                                                                                       0_i32
                                                                                                   {
                                                                                                    (Spiral_builder::US5::US5_0(string("rs")),
                                                                                                     Spiral_builder::US5::US5_0(v2767),
                                                                                                     Spiral_builder::US5::US5_0(v2178.clone()),
                                                                                                     Spiral_builder::US5::US5_0(v2942.clone()))
                                                                                                } else {
                                                                                                    let v2950:
                                                                                                            () =
                                                                                                        {
                                                                                                            Spiral_builder::closure96(v1549,
                                                                                                                                      v2178.clone(),
                                                                                                                                      v2814.clone(),
                                                                                                                                      v2942,
                                                                                                                                      v2941,
                                                                                                                                      ());
                                                                                                            ()
                                                                                                        };
                                                                                                    (Spiral_builder::US5::US5_0(string("rs")),
                                                                                                     Spiral_builder::US5::US5_1,
                                                                                                     Spiral_builder::US5::US5_1,
                                                                                                     Spiral_builder::US5::US5_1)
                                                                                                };
                                                                                            (patternInput_15.0.clone(),
                                                                                             patternInput_15.1.clone(),
                                                                                             patternInput_15.2.clone(),
                                                                                             patternInput_15.3.clone())
                                                                                        } else {
                                                                                            let v3001:
                                                                                                    () =
                                                                                                {
                                                                                                    Spiral_builder::closure97(v1549,
                                                                                                                              v2178.clone(),
                                                                                                                              v2814,
                                                                                                                              v2813,
                                                                                                                              v2918,
                                                                                                                              v2930,
                                                                                                                              ());
                                                                                                    ()
                                                                                                };
                                                                                            (Spiral_builder::US5::US5_0(string("rs")),
                                                                                             Spiral_builder::US5::US5_1,
                                                                                             Spiral_builder::US5::US5_1,
                                                                                             Spiral_builder::US5::US5_1)
                                                                                        };
                                                                                    (patternInput_16.0.clone(),
                                                                                     patternInput_16.1.clone(),
                                                                                     patternInput_16.2.clone(),
                                                                                     patternInput_16.3.clone())
                                                                                };
                                                                    if v1549 {
                                                                        let v3058:
                                                                                        string =
                                                                                    if (if let Spiral_builder::US35::US35_1
                                                                                               =
                                                                                               &v1660
                                                                                           {
                                                                                            true
                                                                                        } else {
                                                                                            false
                                                                                        })
                                                                                           !=
                                                                                           true
                                                                                       {
                                                                                        string("wasm32-unknown-unknown/release")
                                                                                    } else {
                                                                                        string("debug")
                                                                                    };
                                                                        let v3061:
                                                                                        string =
                                                                                    Spiral_builder::method27(v1898.clone(),
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058.clone(),
                                                                                                                      v1744.clone(),
                                                                                                                      string("")));
                                                                        let v3064:
                                                                                        string =
                                                                                    Spiral_builder::method27(v1898.clone(),
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058.clone(),
                                                                                                                      v1744.clone(),
                                                                                                                      string(".wasm")));
                                                                        let v3067:
                                                                                        string =
                                                                                    Spiral_builder::method27(v1898.clone(),
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058.clone(),
                                                                                                                      v1744.clone(),
                                                                                                                      string(".pdb")));
                                                                        let v3070:
                                                                                        string =
                                                                                    Spiral_builder::method27(v1898.clone(),
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058.clone(),
                                                                                                                      v1744.clone(),
                                                                                                                      string(".exe")));
                                                                        let v3073:
                                                                                        string =
                                                                                    Spiral_builder::method27(v1898,
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058,
                                                                                                                      v1744,
                                                                                                                      string(".d")));
                                                                        let v3074:
                                                                                        bool =
                                                                                    Spiral_builder::method42(v3061.clone());
                                                                        let v3075:
                                                                                        bool =
                                                                                    Spiral_builder::method42(v3064.clone());
                                                                        let v3076:
                                                                                        bool =
                                                                                    Spiral_builder::method42(v3067.clone());
                                                                        let v3077:
                                                                                        bool =
                                                                                    Spiral_builder::method42(v3070.clone());
                                                                        let v3078:
                                                                                        bool =
                                                                                    Spiral_builder::method42(v3073.clone());
                                                                        let v3081: () = {
                                                                            Spiral_builder::closure98(v2178,
                                                                                                                  v3073.clone(),
                                                                                                                  v3078,
                                                                                                                  v3070.clone(),
                                                                                                                  v3077,
                                                                                                                  v3067.clone(),
                                                                                                                  v3076,
                                                                                                                  v3064.clone(),
                                                                                                                  v3075,
                                                                                                                  v3061.clone(),
                                                                                                                  v3074,
                                                                                                                  ());
                                                                            ()
                                                                        };
                                                                        let v3124: LrcPtr<
                                                                            Spiral_builder::UH4,
                                                                        > = if v3074 {
                                                                            LrcPtr::new(Spiral_builder::UH4::UH4_1(v3061,
                                                                                                                               v3074,
                                                                                                                               LrcPtr::new(Spiral_builder::UH4::UH4_0)))
                                                                        } else {
                                                                            LrcPtr::new(Spiral_builder::UH4::UH4_0)
                                                                        };
                                                                        let v3126: LrcPtr<
                                                                            Spiral_builder::UH4,
                                                                        > = if v3075 {
                                                                            LrcPtr::new(Spiral_builder::UH4::UH4_1(v3064,
                                                                                                                               v3075,
                                                                                                                               v3124.clone()))
                                                                        } else {
                                                                            v3124
                                                                        };
                                                                        let v3128: LrcPtr<
                                                                            Spiral_builder::UH4,
                                                                        > = if v3076 {
                                                                            LrcPtr::new(Spiral_builder::UH4::UH4_1(v3067,
                                                                                                                               v3076,
                                                                                                                               v3126.clone()))
                                                                        } else {
                                                                            v3126
                                                                        };
                                                                        let v3130: LrcPtr<
                                                                            Spiral_builder::UH4,
                                                                        > = if v3077 {
                                                                            LrcPtr::new(Spiral_builder::UH4::UH4_1(v3070,
                                                                                                                               v3077,
                                                                                                                               v3128.clone()))
                                                                        } else {
                                                                            v3128
                                                                        };
                                                                        Spiral_builder::method228(
                                                                            if v3078 {
                                                                                LrcPtr::new(Spiral_builder::UH4::UH4_1(v3073,
                                                                                                                                                     v3078,
                                                                                                                                                     v3130.clone()))
                                                                            } else {
                                                                                v3130
                                                                            },
                                                                        )
                                                                    }
                                                                    (
                                                                        patternInput_17.0.clone(),
                                                                        patternInput_17.1.clone(),
                                                                        patternInput_17.2.clone(),
                                                                        patternInput_17.3.clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    }
                                                };
                                                (
                                                    patternInput_18.0.clone(),
                                                    patternInput_18.1.clone(),
                                                    patternInput_18.2.clone(),
                                                    patternInput_18.3.clone(),
                                                )
                                            }
                                        }
                                    }
                                } else {
                                    let patternInput_30: (
                                        Spiral_builder::US5,
                                        Spiral_builder::US5,
                                        Spiral_builder::US5,
                                        Spiral_builder::US5,
                                    ) = if fable_library_rust::String_::fromString(v25.clone())
                                        == string("typescript")
                                    {
                                        let v3140: string = Spiral_builder::method139();
                                        let v3143: &str = &*v3140;
                                        let v3166: Option<std::string::String> =
                                            clap::ArgMatches::get_one(&v26.clone(), v3143).cloned();
                                        let v3180: Spiral_builder::US7 = defaultValue(
                                            Spiral_builder::US7::US7_1,
                                            map(Spiral_builder::method22(), v3166),
                                        );
                                        let v3187: std::string::String = match &v3180 {
                                            Spiral_builder::US7::US7_0(v3180_0_0) => match &v3180 {
                                                Spiral_builder::US7::US7_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        };
                                        let v3189: string =
                                            fable_library_rust::String_::fromString(v3187);
                                        let v3190: string = Spiral_builder::method24();
                                        let v3193: &str = &*v3190;
                                        let v3216: Option<Vec<std::string::String>> =
                                            clap::ArgMatches::get_many(&v26.clone(), v3193)
                                                .map(|x| x.cloned().into_iter().collect());
                                        let v3230: Spiral_builder::US11 = defaultValue(
                                            Spiral_builder::US11::US11_1,
                                            map(Spiral_builder::method25(), v3216),
                                        );
                                        let v3236: Vec<std::string::String> =
                                            new_empty::<std::string::String>().to_vec();
                                        let v3239: Vec<std::string::String> = match &v3230 {
                                            Spiral_builder::US11::US11_0(v3230_0_0) => match &v3230
                                            {
                                                Spiral_builder::US11::US11_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => v3236,
                                        };
                                        let v3243: Result<Vec<u8>, std::io::Error> =
                                            std::fs::read(&*v3189);
                                        let v3281: Vec<u8> =
                                            Spiral_builder::method26(v3243.unwrap());
                                        let v3283: Result<
                                            std::string::String,
                                            std::string::FromUtf8Error,
                                        > = std::string::String::from_utf8(v3281);
                                        let v3286: std::string::String = v3283.unwrap();
                                        let v3316: string =
                                            fable_library_rust::String_::fromString(v3286);
                                        let v3325: string = Spiral_builder::method182(sprintf!(
                                            "{:?}",
                                            (string("ts"), v3316.clone())
                                        ));
                                        let v3330:
                                                        Spiral_builder::US12 =
                                                    Spiral_builder::method30(Spiral_builder::method27(string("polyglot"),
                                                                                                      string(".devcontainer")),
                                                                             string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder"));
                                        let v3378: Spiral_builder::US5 = match &v3330 {
                                            Spiral_builder::US12::US12_0(v3330_0_0) => {
                                                Spiral_builder::US5::US5_0(v3330_0_0.clone())
                                            }
                                            Spiral_builder::US12::US12_1(v3330_1_0) => {
                                                let v3336: () = {
                                                    Spiral_builder::closure16(
                                                        v3330_1_0.clone(),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                Spiral_builder::US5::US5_1
                                            }
                                        };
                                        let v3433: Spiral_builder::US5 = match &v3378 {
                                            Spiral_builder::US5::US5_0(v3378_0_0) => {
                                                Spiral_builder::US5::US5_0(match &v3378 {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v3381: string = Spiral_builder::method38();
                                                let v3383: Spiral_builder::US12 =
                                                    Spiral_builder::method30(
                                                        Spiral_builder::method27(
                                                            string("polyglot"),
                                                            string(".devcontainer"),
                                                        ),
                                                        v3381,
                                                    );
                                                match &v3383 {
                                                    Spiral_builder::US12::US12_0(v3383_0_0) => {
                                                        Spiral_builder::US5::US5_0(
                                                            v3383_0_0.clone(),
                                                        )
                                                    }
                                                    Spiral_builder::US12::US12_1(v3383_1_0) => {
                                                        let v3389: () = {
                                                            Spiral_builder::closure16(
                                                                v3383_1_0.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        Spiral_builder::US5::US5_1
                                                    }
                                                }
                                            }
                                        };
                                        let v3438: string = Spiral_builder::method27(
                                            match &v3433 {
                                                Spiral_builder::US5::US5_0(v3433_0_0) => {
                                                    match &v3433 {
                                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                _ => panic!(
                                                    "{}",
                                                    string("Option does not have a value."),
                                                ),
                                            },
                                            string("polyglot"),
                                        );
                                        let v3441: string = toLower(Spiral_builder::method38());
                                        let v3445: string = toLower(v3438);
                                        let v3453: Spiral_builder::US12 =
                                            if startsWith(v3441, v3445.clone(), false) {
                                                Spiral_builder::US12::US12_1(v3445.clone())
                                            } else {
                                                Spiral_builder::US12::US12_0(v3445)
                                            };
                                        let v3459: Result<string, string> = match &v3453 {
                                            Spiral_builder::US12::US12_0(v3453_0_0) => {
                                                Ok::<string, string>(v3453_0_0.clone())
                                            }
                                            Spiral_builder::US12::US12_1(v3453_1_0) => {
                                                Err::<string, string>(v3453_1_0.clone())
                                            }
                                        };
                                        let v3461: bool = true;
                                        let _result_unwrap_or_else = v3459.unwrap_or_else(|x| {
                                            //;
                                            let v3463: string = x;
                                            let v3465: bool = true;
                                            v3463
                                        });
                                        let v3467: string = _result_unwrap_or_else;
                                        let v3472: string = Spiral_builder::method185(
                                            Spiral_builder::US5::US5_0(v3325.clone()),
                                            string("spiral_builder"),
                                            Spiral_builder::US38::US38_0(
                                                Spiral_builder::US37::US37_1,
                                            ),
                                            v3467.clone(),
                                        );
                                        let v3477: string = Spiral_builder::method186(
                                            v3316,
                                            string("spiral_builder"),
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                            LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                                string("Fable.Core"),
                                                LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                            )),
                                            v3472.clone(),
                                            v3467.clone(),
                                        );
                                        let v3479: string = Spiral_builder::method27(
                                            v3467.clone(),
                                            string("lib/typescript/fable/fable_modules"),
                                        );
                                        let v3480: string =
                                            sprintf!("fable-library-{}", string("ts"));
                                        let v3481: string =
                                            Spiral_builder::method229(v3480.clone());
                                        let v3483: async_walkdir::WalkDir =
                                            async_walkdir::WalkDir::new(&*v3479.clone());
                                        let v3486: async_walkdir::WalkDir =
                                            async_walkdir::WalkDir::filter(v3483, move |x| {
                                                Func1::new({
                                                    let v3480 = v3480.clone();
                                                    move |v_9: async_walkdir::DirEntry| {
                                                        Spiral_builder::closure99(
                                                            v3480.clone(),
                                                            v_9,
                                                        )
                                                    }
                                                })(x)
                                            });
                                        let v3487 = Spiral_builder::method237(v3481);
                                        let v3489 = futures::stream::StreamExt::filter_map(
                                            v3486,
                                            |x| async { v3487(x) },
                                        );
                                        let v3491: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Vec<(string, string)>,
                                                >,
                                            >,
                                        > = Box::pin(futures::stream::StreamExt::collect(v3489));
                                        let v3493: Vec<(string, string)> = v3491.await;
                                        let v3495: rayon::vec::IntoIter<(string, string)> =
                                            rayon::iter::IntoParallelIterator::into_par_iter(v3493);
                                        let v3498: rayon::iter::Map<
                                            rayon::vec::IntoIter<(string, string)>,
                                            _,
                                        > = rayon::iter::ParallelIterator::map(v3495, |x| {
                                            Func1::new(move |arg10_0040_20: (string, string)| {
                                                Spiral_builder::closure107((), arg10_0040_20)
                                            })(x)
                                        });
                                        let v3500: Vec<(string, string)> =
                                            rayon::iter::ParallelIterator::collect(v3498);
                                        let v3503: Option<(string, string)> = tryItem(
                                            0_i32,
                                            fable_library_rust::NativeArray_::array_from(v3500),
                                        );
                                        let v3518: Spiral_builder::US46 = defaultValue(
                                            Spiral_builder::US46::US46_1,
                                            map(Spiral_builder::method242(), v3503),
                                        );
                                        let v3524: () = {
                                            Spiral_builder::closure109(v3518.clone(), ());
                                            ()
                                        };
                                        Spiral_builder::method245(
                                            v3472.clone(),
                                            v3479.clone(),
                                            v3518.clone(),
                                        );
                                        {
                                            let patternInput_19: (i32, string) =
                                                Spiral_builder::method195(
                                                    Spiral_builder::US35::US35_1,
                                                    v3472.clone(),
                                                    string("ts"),
                                                    v3477,
                                                    v3453.clone(),
                                                );
                                            let v3566: string = patternInput_19.1.clone();
                                            let v3565: i32 = patternInput_19.0.clone();
                                            Spiral_builder::method245(
                                                v3472.clone(),
                                                v3479,
                                                v3518.clone(),
                                            );
                                            {
                                                let patternInput_23: (
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                ) = if v3565 != 0_i32 {
                                                    let v3572: () = {
                                                        Spiral_builder::closure110(
                                                            v3566.clone(),
                                                            v3565,
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    (
                                                        Spiral_builder::US5::US5_0(string("ts")),
                                                        Spiral_builder::US5::US5_1,
                                                        Spiral_builder::US5::US5_1,
                                                        Spiral_builder::US5::US5_0(v3566),
                                                    )
                                                } else {
                                                    let v3617: bool = true;
                                                    let _vec_map : Vec<_> = v3239.into_iter().map(|x| { //;
                                                                let v3619:
                                                                        std::string::String =
                                                                    x;
                                                                let v3621:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v3619);
                                                                let v3627:
                                                                        string =
                                                                    if contains(v3621.clone(),
                                                                                string("="))
                                                                       {
                                                                        v3621.clone()
                                                                    } else {
                                                                        sprintf!("\"{}\":\"*\"",
                                                                                 v3621)
                                                                    };
                                                                let v3629:
                                                                        bool =
                                                                    true; v3627 }).collect::<Vec<_>>();
                                                    let v3631: Vec<string> = _vec_map;
                                                    let v3633:
                                                                        Array<string> =
                                                                    fable_library_rust::NativeArray_::array_from(v3631);
                                                    let v3660:
                                                                        string =
                                                                    append(append(append(append(append(append(append(string("{"),
                                                                                                                     sprintf!("  \"name\": \"spiral_builder_{}\",",
                                                                                                                              v3325)),
                                                                                                              string("  \"dependencies\": {")),
                                                                                                       join(string(",\n"),
                                                                                                            toArray_1(delay(Func0::new({
                                                                                                                                           let v3633
                                                                                                                                               =
                                                                                                                                               v3633.clone();
                                                                                                                                           move
                                                                                                                                               ||
                                                                                                                                               map_1(Func1::new({
                                                                                                                                                                    let v3633
                                                                                                                                                                        =
                                                                                                                                                                        v3633.clone();
                                                                                                                                                                    move
                                                                                                                                                                        |i_2:
                                                                                                                                                                             i32|
                                                                                                                                                                        v3633[i_2].clone()
                                                                                                                                                                }),
                                                                                                                                                     rangeNumeric(0_i32,
                                                                                                                                                                  1_i32,
                                                                                                                                                                  count_2(v3633.clone())
                                                                                                                                                                      -
                                                                                                                                                                      1_i32))
                                                                                                                                       }))))),
                                                                                                string("  },")),
                                                                                         string("    \"devDependencies\": {")),
                                                                                  string("  },")),
                                                                           string("}"));
                                                    let v3662: string = Spiral_builder::method27(
                                                        v3472.clone(),
                                                        string("package.json"),
                                                    );
                                                    let v3665: string = Spiral_builder::method27(
                                                        Spiral_builder::method27(
                                                            v3472.clone(),
                                                            string("../.."),
                                                        ),
                                                        string("package.json"),
                                                    );
                                                    Spiral_builder::method40(v3662, v3660);
                                                    Spiral_builder::method40(v3665, string(""));
                                                    {
                                                        let v3668: string =
                                                            Spiral_builder::method27(
                                                                v3472,
                                                                sprintf!(
                                                                    "{}.{}",
                                                                    string("spiral_builder"),
                                                                    string("ts")
                                                                ),
                                                            );
                                                        let v3671: () = {
                                                            Spiral_builder::closure111(
                                                                v3668.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        let v3714: Result<Vec<u8>, std::io::Error> =
                                                            std::fs::read(&*v3668.clone());
                                                        let v3752: Vec<u8> =
                                                            Spiral_builder::method26(
                                                                v3714.unwrap(),
                                                            );
                                                        let v3754: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v3752);
                                                        let v3757: std::string::String =
                                                            v3754.unwrap();
                                                        let v3787: string =
                                                            fable_library_rust::String_::fromString(
                                                                v3757,
                                                            );
                                                        let v3793:
                                                                            bool =
                                                                        contains(v3787.clone(),
                                                                                 string("// spiral_builder.process_typescript"));
                                                        let v3802: string = if v3793 {
                                                            v3787.clone()
                                                        } else {
                                                            Spiral_builder::method162(string("\\s\\sdefaultOf\\(\\);"),
                                                                                                      string(" defaultOf::<()>();"),
                                                                                                      replace(v3787,
                                                                                                              sprintf!("\"./fable_modules/fable-library-ts.{}/",
                                                                                                                       v3518.clone()),
                                                                                                              sprintf!("\"{}/lib/typescript/fable/fable_modules/fable-library-ts.{}/",
                                                                                                                       v3467,
                                                                                                                       v3518)))
                                                        };
                                                        if v3793 == false {
                                                            Spiral_builder::method40(v3668.clone(),
                                                                                                 sprintf!("{}\n\n{}\n",
                                                                                                          v3802.clone(),
                                                                                                          string("// spiral_builder.process_typescript")));
                                                        }
                                                        {
                                                            let v3805: string = sprintf!(
                                                                "bun run \"{}\"",
                                                                v3668.clone()
                                                            );
                                                            let v3807: string =
                                                                Spiral_builder::method3(string(
                                                                    "PATH",
                                                                ));
                                                            let v3843: Spiral_builder::US5 =
                                                                if v3807.clone() == string("") {
                                                                    Spiral_builder::US5::US5_1
                                                                } else {
                                                                    Spiral_builder::US5::US5_0(
                                                                        sprintf!(
                                                                            "{}{}{}",
                                                                            string("~/.bun/bin"),
                                                                            if cfg!(windows) {
                                                                                string(";")
                                                                            } else {
                                                                                string(":")
                                                                            },
                                                                            v3807
                                                                        ),
                                                                    )
                                                                };
                                                            let v3858:
                                                                                Array<(string,
                                                                                       string)> =
                                                                            toArray(Spiral_builder::method250(Spiral_builder::method249(match &v3843
                                                                                                                                            {
                                                                                                                                            Spiral_builder::US5::US5_0(v3843_0_0)
                                                                                                                                            =>
                                                                                                                                            LrcPtr::new(Spiral_builder::UH5::UH5_1(string("PATH"),
                                                                                                                                                                                   match &v3843
                                                                                                                                                                                       {
                                                                                                                                                                                       Spiral_builder::US5::US5_0(x)
                                                                                                                                                                                       =>
                                                                                                                                                                                       x.clone(),
                                                                                                                                                                                       _
                                                                                                                                                                                       =>
                                                                                                                                                                                       unreachable!(),
                                                                                                                                                                                   },
                                                                                                                                                                                   LrcPtr::new(Spiral_builder::UH5::UH5_0))),
                                                                                                                                            _
                                                                                                                                            =>
                                                                                                                                            LrcPtr::new(Spiral_builder::UH5::UH5_0),
                                                                                                                                        },
                                                                                                                                        LrcPtr::new(Spiral_builder::UH5::UH5_1(string("TRACE_LEVEL"),
                                                                                                                                                                               string("Verbose"),
                                                                                                                                                                               LrcPtr::new(Spiral_builder::UH5::UH5_0)))),
                                                                                                              empty::<(string,
                                                                                                                       string)>()));
                                                            let v3871:
                                                                                Result<string,
                                                                                       string> =
                                                                            match &v3453
                                                                                {
                                                                                Spiral_builder::US12::US12_0(v3453_0_0)
                                                                                =>
                                                                                Ok::<string,
                                                                                     string>(v3453_0_0.clone()),
                                                                                Spiral_builder::US12::US12_1(v3453_1_0)
                                                                                =>
                                                                                Err::<string,
                                                                                      string>(v3453_1_0.clone()),
                                                                            };
                                                            let patternInput_20:
                                                                                (i32,
                                                                                 string) =
                                                                            Spiral_builder::method67(v3805.clone(),
                                                                                                     None::<CancellationToken>,
                                                                                                     v3858.clone(),
                                                                                                     None::<Func1<(i32,
                                                                                                                   string,
                                                                                                                   bool),
                                                                                                                  Arc<Async<()>>>>,
                                                                                                     None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                  ()>>,
                                                                                                     true,
                                                                                                     v3871.ok());
                                                            let v3888: string =
                                                                patternInput_20.1.clone();
                                                            let v3887: i32 =
                                                                patternInput_20.0.clone();
                                                            let v3889: i32 = count_2(v3858.clone());
                                                            let v3890: Array<string> =
                                                                new_init(&string(""), v3889);
                                                            let v3891: LrcPtr<
                                                                Spiral_builder::Mut5,
                                                            > = LrcPtr::new(Spiral_builder::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                            while Spiral_builder::method71(
                                                                v3889,
                                                                v3891.clone(),
                                                            ) {
                                                                let v3893: i32 =
                                                                    v3891.l0.get().clone();
                                                                let patternInput_21: (
                                                                    string,
                                                                    string,
                                                                ) = v3858[v3893].clone();
                                                                let v3896: string = sprintf!(
                                                                    "$env:{}=\'\'{}\'\'",
                                                                    patternInput_21.0.clone(),
                                                                    patternInput_21.1.clone()
                                                                );
                                                                v3890.get_mut()[v3893 as usize] =
                                                                    v3896;
                                                                {
                                                                    let v3897: i32 = v3893 + 1_i32;
                                                                    v3891.l0.set(v3897);
                                                                    ()
                                                                }
                                                            }
                                                            {
                                                                let v3907: string = sprintf!(
                                                                    "pwsh -c \'{}; {}\'",
                                                                    join(
                                                                        string(";"),
                                                                        toArray_1(ofArray_1(
                                                                            v3890.clone()
                                                                        ))
                                                                    ),
                                                                    v3805
                                                                );
                                                                let patternInput_22: (
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                ) = if v3887 == 0_i32 {
                                                                    let result_2: LrcPtr<
                                                                        MutCell<
                                                                            Spiral_builder::US5,
                                                                        >,
                                                                    > = refCell(
                                                                        Spiral_builder::US5::US5_1,
                                                                    );
                                                                    try_catch(||
                                                                                                  result_2.set(Spiral_builder::closure62((),
                                                                                                                                         Spiral_builder::closure112(v3888.clone(),
                                                                                                                                                                    ()))),
                                                                                              |ex_2:
                                                                                                   LrcPtr<Exception>|
                                                                                                  result_2.set(Spiral_builder::closure113(v3668.clone(),
                                                                                                                                          v3888.clone(),
                                                                                                                                          v3907.clone(),
                                                                                                                                          ex_2.clone())));
                                                                    {
                                                                        let v3913:
                                                                                                Spiral_builder::US5 =
                                                                                            result_2.get().clone();
                                                                        let v3923:
                                                                                                Option<string> =
                                                                                            match &v3913
                                                                                                {
                                                                                                Spiral_builder::US5::US5_0(v3913_0_0)
                                                                                                =>
                                                                                                Some(match &v3913
                                                                                                         {
                                                                                                         Spiral_builder::US5::US5_0(x)
                                                                                                         =>
                                                                                                         x.clone(),
                                                                                                         _
                                                                                                         =>
                                                                                                         unreachable!(),
                                                                                                     }),
                                                                                                _
                                                                                                =>
                                                                                                None::<string>,
                                                                                            };
                                                                        (Spiral_builder::US5::US5_0(string("ts")),
                                                                                         Spiral_builder::US5::US5_0(v3802),
                                                                                         Spiral_builder::US5::US5_0(v3668.clone()),
                                                                                         Spiral_builder::US5::US5_0(v3923.unwrap()))
                                                                    }
                                                                } else {
                                                                    let v3932: () = {
                                                                        Spiral_builder::closure115(
                                                                            v3668,
                                                                            v3888,
                                                                            v3887,
                                                                            v3907,
                                                                            (),
                                                                        );
                                                                        ()
                                                                    };
                                                                    (
                                                                        Spiral_builder::US5::US5_0(
                                                                            string("ts"),
                                                                        ),
                                                                        Spiral_builder::US5::US5_1,
                                                                        Spiral_builder::US5::US5_1,
                                                                        Spiral_builder::US5::US5_1,
                                                                    )
                                                                };
                                                                (
                                                                    patternInput_22.0.clone(),
                                                                    patternInput_22.1.clone(),
                                                                    patternInput_22.2.clone(),
                                                                    patternInput_22.3.clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                };
                                                (
                                                    patternInput_23.0.clone(),
                                                    patternInput_23.1.clone(),
                                                    patternInput_23.2.clone(),
                                                    patternInput_23.3.clone(),
                                                )
                                            }
                                        }
                                    } else {
                                        let patternInput_29: (
                                            Spiral_builder::US5,
                                            Spiral_builder::US5,
                                            Spiral_builder::US5,
                                            Spiral_builder::US5,
                                        ) = if fable_library_rust::String_::fromString(v25.clone())
                                            == string("python")
                                        {
                                            let v3987: string = Spiral_builder::method139();
                                            let v3990: &str = &*v3987;
                                            let v4013: Option<std::string::String> =
                                                clap::ArgMatches::get_one(&v26.clone(), v3990)
                                                    .cloned();
                                            let v4027: Spiral_builder::US7 = defaultValue(
                                                Spiral_builder::US7::US7_1,
                                                map(Spiral_builder::method22(), v4013),
                                            );
                                            let v4034: std::string::String = match &v4027 {
                                                Spiral_builder::US7::US7_0(v4027_0_0) => {
                                                    match &v4027 {
                                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                _ => panic!(
                                                    "{}",
                                                    string("Option does not have a value."),
                                                ),
                                            };
                                            let v4036: string =
                                                fable_library_rust::String_::fromString(v4034);
                                            let v4037: string = Spiral_builder::method24();
                                            let v4040: &str = &*v4037;
                                            let v4063: Option<Vec<std::string::String>> =
                                                clap::ArgMatches::get_many(&v26.clone(), v4040)
                                                    .map(|x| x.cloned().into_iter().collect());
                                            let v4077: Spiral_builder::US11 = defaultValue(
                                                Spiral_builder::US11::US11_1,
                                                map(Spiral_builder::method25(), v4063),
                                            );
                                            let v4083: Vec<std::string::String> =
                                                new_empty::<std::string::String>().to_vec();
                                            let v4086: Vec<std::string::String> = match &v4077 {
                                                Spiral_builder::US11::US11_0(v4077_0_0) => {
                                                    match &v4077 {
                                                        Spiral_builder::US11::US11_0(x) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                _ => v4083,
                                            };
                                            let v4087: bool =
                                                if let Spiral_builder::US0::US0_0 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                };
                                            let v4091: Result<Vec<u8>, std::io::Error> =
                                                std::fs::read(&*v4036);
                                            let v4129: Vec<u8> =
                                                Spiral_builder::method26(v4091.unwrap());
                                            let v4131: Result<
                                                std::string::String,
                                                std::string::FromUtf8Error,
                                            > = std::string::String::from_utf8(v4129);
                                            let v4134: std::string::String = v4131.unwrap();
                                            let v4164: string =
                                                fable_library_rust::String_::fromString(v4134);
                                            let v4173: string = Spiral_builder::method182(
                                                sprintf!("{:?}", (string("py"), v4164.clone())),
                                            );
                                            let v4178:
                                                                Spiral_builder::US12 =
                                                            Spiral_builder::method30(Spiral_builder::method27(string("polyglot"),
                                                                                                              string(".devcontainer")),
                                                                                     string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder"));
                                            let v4226: Spiral_builder::US5 = match &v4178 {
                                                Spiral_builder::US12::US12_0(v4178_0_0) => {
                                                    Spiral_builder::US5::US5_0(v4178_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v4178_1_0) => {
                                                    let v4184: () = {
                                                        Spiral_builder::closure16(
                                                            v4178_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    Spiral_builder::US5::US5_1
                                                }
                                            };
                                            let v4281: Spiral_builder::US5 = match &v4226 {
                                                Spiral_builder::US5::US5_0(v4226_0_0) => {
                                                    Spiral_builder::US5::US5_0(match &v4226 {
                                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v4229: string = Spiral_builder::method38();
                                                    let v4231: Spiral_builder::US12 =
                                                        Spiral_builder::method30(
                                                            Spiral_builder::method27(
                                                                string("polyglot"),
                                                                string(".devcontainer"),
                                                            ),
                                                            v4229,
                                                        );
                                                    match &v4231 {
                                                        Spiral_builder::US12::US12_0(v4231_0_0) => {
                                                            Spiral_builder::US5::US5_0(
                                                                v4231_0_0.clone(),
                                                            )
                                                        }
                                                        Spiral_builder::US12::US12_1(v4231_1_0) => {
                                                            let v4237: () = {
                                                                Spiral_builder::closure16(
                                                                    v4231_1_0.clone(),
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            Spiral_builder::US5::US5_1
                                                        }
                                                    }
                                                }
                                            };
                                            let v4286: string = Spiral_builder::method27(
                                                match &v4281 {
                                                    Spiral_builder::US5::US5_0(v4281_0_0) => {
                                                        match &v4281 {
                                                            Spiral_builder::US5::US5_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        }
                                                    }
                                                    _ => panic!(
                                                        "{}",
                                                        string("Option does not have a value."),
                                                    ),
                                                },
                                                string("polyglot"),
                                            );
                                            let v4289: string = toLower(Spiral_builder::method38());
                                            let v4293: string = toLower(v4286);
                                            let v4301: Spiral_builder::US12 =
                                                if startsWith(v4289, v4293.clone(), false) {
                                                    Spiral_builder::US12::US12_1(v4293.clone())
                                                } else {
                                                    Spiral_builder::US12::US12_0(v4293)
                                                };
                                            let v4307: Result<string, string> = match &v4301 {
                                                Spiral_builder::US12::US12_0(v4301_0_0) => {
                                                    Ok::<string, string>(v4301_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v4301_1_0) => {
                                                    Err::<string, string>(v4301_1_0.clone())
                                                }
                                            };
                                            let v4309: bool = true;
                                            let _result_unwrap_or_else =
                                                v4307.unwrap_or_else(|x| {
                                                    //;
                                                    let v4311: string = x;
                                                    let v4313: bool = true;
                                                    v4311
                                                });
                                            let v4315: string = _result_unwrap_or_else;
                                            let v4320: string = Spiral_builder::method185(
                                                Spiral_builder::US5::US5_0(v4173.clone()),
                                                string("spiral_builder"),
                                                Spiral_builder::US38::US38_0(
                                                    Spiral_builder::US37::US37_2,
                                                ),
                                                v4315.clone(),
                                            );
                                            let v4325: string = Spiral_builder::method186(
                                                v4164,
                                                string("spiral_builder"),
                                                LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                                LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                                    string("Fable.Core"),
                                                    LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                                )),
                                                v4320.clone(),
                                                v4315.clone(),
                                            );
                                            Spiral_builder::method194(
                                                Spiral_builder::method27(
                                                    Spiral_builder::method27(
                                                        v4315,
                                                        string("lib/python/fable/fable_modules"),
                                                    ),
                                                    string("fable_library"),
                                                ),
                                                Spiral_builder::method27(
                                                    v4320.clone(),
                                                    string("fable_modules/fable_library"),
                                                ),
                                            );
                                            {
                                                let patternInput_24: (i32, string) =
                                                    Spiral_builder::method195(
                                                        Spiral_builder::US35::US35_1,
                                                        v4320.clone(),
                                                        string("py"),
                                                        v4325,
                                                        v4301.clone(),
                                                    );
                                                let v4334: string = patternInput_24.1.clone();
                                                let v4333: i32 = patternInput_24.0.clone();
                                                let patternInput_28: (
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                ) = if v4333 != 0_i32 {
                                                    let v4340: () = {
                                                        Spiral_builder::closure116(
                                                            v4334.clone(),
                                                            v4333,
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    (
                                                        Spiral_builder::US5::US5_0(string("py")),
                                                        Spiral_builder::US5::US5_1,
                                                        Spiral_builder::US5::US5_1,
                                                        Spiral_builder::US5::US5_0(v4334),
                                                    )
                                                } else {
                                                    let v4385: bool = true;
                                                    let _vec_map : Vec<_> = v4086.into_iter().map(|x| { //;
                                                                    let v4387:
                                                                            std::string::String =
                                                                        x;
                                                                    let v4389:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v4387);
                                                                    let v4395:
                                                                            string =
                                                                        if contains(v4389.clone(),
                                                                                    string("="))
                                                                           {
                                                                            v4389.clone()
                                                                        } else {
                                                                            sprintf!("\"{}\":\"*\"",
                                                                                     v4389)
                                                                        };
                                                                    let v4397:
                                                                            bool =
                                                                        true; v4395 }).collect::<Vec<_>>();
                                                    let v4399: Vec<string> = _vec_map;
                                                    let v4401:
                                                                            Array<string> =
                                                                        fable_library_rust::NativeArray_::array_from(v4399);
                                                    let v4428:
                                                                            string =
                                                                        append(append(append(append(append(append(append(string("{"),
                                                                                                                         sprintf!("  \"name\": \"spiral_builder_{}\",",
                                                                                                                                  v4173)),
                                                                                                                  string("  \"dependencies\": {")),
                                                                                                           join(string(",\n"),
                                                                                                                toArray_1(delay(Func0::new({
                                                                                                                                               let v4401
                                                                                                                                                   =
                                                                                                                                                   v4401.clone();
                                                                                                                                               move
                                                                                                                                                   ||
                                                                                                                                                   map_1(Func1::new({
                                                                                                                                                                        let v4401
                                                                                                                                                                            =
                                                                                                                                                                            v4401.clone();
                                                                                                                                                                        move
                                                                                                                                                                            |i_3:
                                                                                                                                                                                 i32|
                                                                                                                                                                            v4401[i_3].clone()
                                                                                                                                                                    }),
                                                                                                                                                         rangeNumeric(0_i32,
                                                                                                                                                                      1_i32,
                                                                                                                                                                      count_2(v4401.clone())
                                                                                                                                                                          -
                                                                                                                                                                          1_i32))
                                                                                                                                           }))))),
                                                                                                    string("  },")),
                                                                                             string("    \"devDependencies\": {")),
                                                                                      string("  },")),
                                                                               string("}"));
                                                    let v4430: string = Spiral_builder::method27(
                                                        v4320.clone(),
                                                        string("package.json"),
                                                    );
                                                    let v4433: string = Spiral_builder::method27(
                                                        Spiral_builder::method27(
                                                            v4320.clone(),
                                                            string("../.."),
                                                        ),
                                                        string("package.json"),
                                                    );
                                                    Spiral_builder::method40(v4430, v4428);
                                                    Spiral_builder::method40(v4433, string(""));
                                                    {
                                                        let v4436: string =
                                                            Spiral_builder::method27(
                                                                v4320,
                                                                sprintf!(
                                                                    "{}.{}",
                                                                    string("spiral_builder"),
                                                                    string("py")
                                                                ),
                                                            );
                                                        let v4439: () = {
                                                            Spiral_builder::closure117(
                                                                v4436.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        let v4482: Result<Vec<u8>, std::io::Error> =
                                                            std::fs::read(&*v4436.clone());
                                                        let v4520: Vec<u8> =
                                                            Spiral_builder::method26(
                                                                v4482.unwrap(),
                                                            );
                                                        let v4522: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v4520);
                                                        let v4525: std::string::String =
                                                            v4522.unwrap();
                                                        let v4555: string =
                                                            fable_library_rust::String_::fromString(
                                                                v4525,
                                                            );
                                                        let v4561: bool = contains(
                                                            v4555.clone(),
                                                            string(
                                                                "# spiral_builder.process_python",
                                                            ),
                                                        );
                                                        let v4573: string = if v4561 {
                                                            v4555.clone()
                                                        } else {
                                                            Spiral_builder::method162(
                                                                string("\\s\\sdefaultOf\\(\\);"),
                                                                string(" defaultOf::<()>();"),
                                                                replace(
                                                                    v4555,
                                                                    append(
                                                                        string("),)"),
                                                                        ";".into(),
                                                                    ),
                                                                    string("));"),
                                                                ),
                                                            )
                                                        };
                                                        if v4561 == false {
                                                            Spiral_builder::method40(v4436.clone(),
                                                                                                     sprintf!("{}\n\n{}\n",
                                                                                                              v4573.clone(),
                                                                                                              string("# spiral_builder.process_python")));
                                                        }
                                                        {
                                                            let v4576: string = sprintf!(
                                                                "python \"{}\"",
                                                                v4436.clone()
                                                            );
                                                            let v4579: Array<(string, string)> =
                                                                new_array(&[(
                                                                    string("TRACE_LEVEL"),
                                                                    string("Verbose"),
                                                                )]);
                                                            let v4590:
                                                                                    Result<string,
                                                                                           string> =
                                                                                match &v4301
                                                                                    {
                                                                                    Spiral_builder::US12::US12_0(v4301_0_0)
                                                                                    =>
                                                                                    Ok::<string,
                                                                                         string>(v4301_0_0.clone()),
                                                                                    Spiral_builder::US12::US12_1(v4301_1_0)
                                                                                    =>
                                                                                    Err::<string,
                                                                                          string>(v4301_1_0.clone()),
                                                                                };
                                                            let patternInput_25:
                                                                                    (i32,
                                                                                     string) =
                                                                                Spiral_builder::method67(v4576.clone(),
                                                                                                         None::<CancellationToken>,
                                                                                                         v4579.clone(),
                                                                                                         None::<Func1<(i32,
                                                                                                                       string,
                                                                                                                       bool),
                                                                                                                      Arc<Async<()>>>>,
                                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                      ()>>,
                                                                                                         true,
                                                                                                         v4590.ok());
                                                            let v4607: string =
                                                                patternInput_25.1.clone();
                                                            let v4606: i32 =
                                                                patternInput_25.0.clone();
                                                            let v4608: i32 = count_2(v4579.clone());
                                                            let v4609: Array<string> =
                                                                new_init(&string(""), v4608);
                                                            let v4610: LrcPtr<
                                                                Spiral_builder::Mut5,
                                                            > = LrcPtr::new(Spiral_builder::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                            while Spiral_builder::method71(
                                                                v4608,
                                                                v4610.clone(),
                                                            ) {
                                                                let v4612: i32 =
                                                                    v4610.l0.get().clone();
                                                                let patternInput_26: (
                                                                    string,
                                                                    string,
                                                                ) = v4579[v4612].clone();
                                                                let v4615: string = sprintf!(
                                                                    "$env:{}=\'\'{}\'\'",
                                                                    patternInput_26.0.clone(),
                                                                    patternInput_26.1.clone()
                                                                );
                                                                v4609.get_mut()[v4612 as usize] =
                                                                    v4615;
                                                                {
                                                                    let v4616: i32 = v4612 + 1_i32;
                                                                    v4610.l0.set(v4616);
                                                                    ()
                                                                }
                                                            }
                                                            {
                                                                let v4626: string = sprintf!(
                                                                    "pwsh -c \'{}; {}\'",
                                                                    join(
                                                                        string(";"),
                                                                        toArray_1(ofArray_1(
                                                                            v4609.clone()
                                                                        ))
                                                                    ),
                                                                    v4576
                                                                );
                                                                let patternInput_27: (
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                ) = if v4606 == 0_i32 {
                                                                    let result_3: LrcPtr<
                                                                        MutCell<
                                                                            Spiral_builder::US5,
                                                                        >,
                                                                    > = refCell(
                                                                        Spiral_builder::US5::US5_1,
                                                                    );
                                                                    try_catch(||
                                                                                                      result_3.set(Spiral_builder::closure62((),
                                                                                                                                             Spiral_builder::closure118(v4607.clone(),
                                                                                                                                                                        ()))),
                                                                                                  |ex_3:
                                                                                                       LrcPtr<Exception>|
                                                                                                      result_3.set(Spiral_builder::closure119(v4436.clone(),
                                                                                                                                              v4607.clone(),
                                                                                                                                              v4626.clone(),
                                                                                                                                              ex_3.clone())));
                                                                    {
                                                                        let v4632:
                                                                                                    Spiral_builder::US5 =
                                                                                                result_3.get().clone();
                                                                        let v4642:
                                                                                                    Option<string> =
                                                                                                match &v4632
                                                                                                    {
                                                                                                    Spiral_builder::US5::US5_0(v4632_0_0)
                                                                                                    =>
                                                                                                    Some(match &v4632
                                                                                                             {
                                                                                                             Spiral_builder::US5::US5_0(x)
                                                                                                             =>
                                                                                                             x.clone(),
                                                                                                             _
                                                                                                             =>
                                                                                                             unreachable!(),
                                                                                                         }),
                                                                                                    _
                                                                                                    =>
                                                                                                    None::<string>,
                                                                                                };
                                                                        (Spiral_builder::US5::US5_0(string("py")),
                                                                                             Spiral_builder::US5::US5_0(v4573),
                                                                                             Spiral_builder::US5::US5_0(v4436.clone()),
                                                                                             Spiral_builder::US5::US5_0(v4642.unwrap()))
                                                                    }
                                                                } else {
                                                                    let v4651: () = {
                                                                        Spiral_builder::closure121(
                                                                            v4436,
                                                                            v4607,
                                                                            v4606,
                                                                            v4626,
                                                                            (),
                                                                        );
                                                                        ()
                                                                    };
                                                                    (
                                                                        Spiral_builder::US5::US5_0(
                                                                            string("py"),
                                                                        ),
                                                                        Spiral_builder::US5::US5_1,
                                                                        Spiral_builder::US5::US5_1,
                                                                        Spiral_builder::US5::US5_1,
                                                                    )
                                                                };
                                                                (
                                                                    patternInput_27.0.clone(),
                                                                    patternInput_27.1.clone(),
                                                                    patternInput_27.2.clone(),
                                                                    patternInput_27.3.clone(),
                                                                )
                                                            }
                                                        }
                                                    }
                                                };
                                                (
                                                    patternInput_28.0.clone(),
                                                    patternInput_28.1.clone(),
                                                    patternInput_28.2.clone(),
                                                    patternInput_28.3.clone(),
                                                )
                                            }
                                        } else {
                                            let v4705: () = {
                                                Spiral_builder::closure122(v26, v25, ());
                                                ()
                                            };
                                            (
                                                Spiral_builder::US5::US5_1,
                                                Spiral_builder::US5::US5_1,
                                                Spiral_builder::US5::US5_1,
                                                Spiral_builder::US5::US5_1,
                                            )
                                        };
                                        (
                                            patternInput_29.0.clone(),
                                            patternInput_29.1.clone(),
                                            patternInput_29.2.clone(),
                                            patternInput_29.3.clone(),
                                        )
                                    };
                                    (
                                        patternInput_30.0.clone(),
                                        patternInput_30.1.clone(),
                                        patternInput_30.2.clone(),
                                        patternInput_30.3.clone(),
                                    )
                                };
                                let v4760: Spiral_builder::US5 = patternInput_31.3.clone();
                                let v4759: Spiral_builder::US5 = patternInput_31.2.clone();
                                let v4758: Spiral_builder::US5 = patternInput_31.1.clone();
                                let v4757: Spiral_builder::US5 = patternInput_31.0.clone();
                                new_array(&[
                                    (
                                        string("extension"),
                                        match &v4757 {
                                            Spiral_builder::US5::US5_0(v4757_0_0) => match &v4757 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => string(""),
                                        },
                                    ),
                                    (
                                        string("code"),
                                        match &v4758 {
                                            Spiral_builder::US5::US5_0(v4758_0_0) => match &v4758 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => string(""),
                                        },
                                    ),
                                    (
                                        string("code_path"),
                                        match &v4759 {
                                            Spiral_builder::US5::US5_0(v4759_0_0) => match &v4759 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => string(""),
                                        },
                                    ),
                                    (
                                        string("output"),
                                        match &v4760 {
                                            Spiral_builder::US5::US5_0(v4760_0_0) => match &v4760 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => string(""),
                                        },
                                    ),
                                ])
                            }
                        }
                    }
                } else {
                    new_array(&[
                        (string("extension"), string("")),
                        (string("code"), string("")),
                        (string("code_path"), string("")),
                        (string("output"), string("")),
                    ])
                };
                let v4793: Vec<(string, string)> = v4791.to_vec();
                let v4796: Vec<LrcPtr<(std::string::String, std::string::String)>> = v4793
                    .into_iter()
                    .map(|x| {
                        Func1::new(move |arg10_0040_33: (string, string)| {
                            Spiral_builder::closure123((), arg10_0040_33)
                        })(x.clone())
                    })
                    .collect::<Vec<_>>();
                let v4797: string =
                string("std::collections::BTreeMap::from_iter(v4796.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                let v4798: std::collections::BTreeMap<std::string::String, std::string::String> =
                    std::collections::BTreeMap::from_iter(
                        v4796
                            .iter()
                            .map(|x| x.as_ref())
                            .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                    );
                let v4800: Result<std::string::String, serde_json::Error> =
                    serde_json::to_string(&v4798);
                let v4801 = Spiral_builder::method260();
                let v4804: Result<std::string::String, string> = v4800.map_err(|x| v4801(x));
                let v4817: bool = true;
                let _result_map_ = v4804.map(|x| {
                    //;
                    let v4819: std::string::String = x;
                    let v4821: string = fable_library_rust::String_::fromString(v4819);
                    let v4823: bool = true;
                    v4821
                });
                let v4826: Result<string, string> = Spiral_builder::method261(_result_map_);
                let v4829: string = string("}");
                let v4833: bool = true;
                let v4830 = v4826;
                let v4845: string = append(
                    append(
                        append(append(string("true; v4830 "), v4829), string("); ")),
                        string(""),
                    ),
                    string(" // rust.fix_closure\'"),
                );
                let v4846: bool = true;
                v4830
            }); // rust.fix_closure';
            let v4848 = __future_init;
            v4848
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Spiral_builder::closure2((), ());
                ()
            };
            let v21: LrcPtr<Spiral_builder::Mut4> =
                (getValue(Spiral_builder::TraceState::trace_state().get().clone()))
                    .4
                    .clone();
            let v37: () = {
                Spiral_builder::closure5(v0_1, ());
                ()
            };
            let v76: clap::Command = Spiral_builder::method0();
            let v78: clap::ArgMatches = clap::Command::get_matches(v76);
            let v80: std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, string>>>> =
                Spiral_builder::method19(v21.l0.get().clone(), v78);
            let v82: Result<string, string> = futures::executor::block_on(v80);
            let v85: string = v82.unwrap();
            if if let Spiral_builder::US0::US0_2 = &v21.l0.get().clone() {
                true
            } else {
                false
            } {
                let v101: () = {
                    Spiral_builder::closure10(v85, ());
                    ()
                };
                ()
            }
            0_i32
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
    Spiral_builder::main(array_from(args));
}
