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
        use fable_library_rust::List_::singleton;
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
        use fable_library_rust::String_::padLeft;
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
        use fable_library_rust::TimeSpan_::zero;
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US1 {
            US1_0(string),
            US1_1,
        }
        impl core::fmt::Display for Spiral_builder::US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Spiral_builder::US0),
            US2_1,
        }
        impl core::fmt::Display for Spiral_builder::US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US3 {
            US3_0(i64),
            US3_1,
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
        impl core::fmt::Display for Spiral_builder::US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US5 {
            US5_0(std::string::String),
            US5_1,
        }
        impl core::fmt::Display for Spiral_builder::US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US8 {
            US8_0,
            US8_1,
        }
        impl core::fmt::Display for Spiral_builder::US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US7 {
            US7_0(Spiral_builder::US8),
            US7_1,
        }
        impl core::fmt::Display for Spiral_builder::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US6 {
            US6_0(Spiral_builder::US7),
            US6_1,
        }
        impl core::fmt::Display for Spiral_builder::US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(Vec<std::string::String>),
            US9_1,
        }
        impl core::fmt::Display for Spiral_builder::US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US10 {
            US10_0,
            US10_1,
            US10_2,
        }
        impl core::fmt::Display for Spiral_builder::US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US11 {
            US11_0(Spiral_builder::US10),
            US11_1(Spiral_builder::US10),
            US11_2(Spiral_builder::US10),
            US11_3(Spiral_builder::US10),
            US11_4(Spiral_builder::US10),
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
            US14_0(string, Spiral_builder::US1),
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
                Spiral_builder::US1,
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
            US21_0(Spiral_builder::US1, string, LrcPtr<StringBuilder>, i32, i32),
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
        pub enum US34 {
            US34_0(string),
            US34_1(string),
        }
        impl core::fmt::Display for Spiral_builder::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US33 {
            US33_0(Spiral_builder::US34),
            US33_1,
        }
        impl core::fmt::Display for Spiral_builder::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0(chrono::DateTime<chrono::Utc>),
            US35_1,
        }
        impl core::fmt::Display for Spiral_builder::US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US36 {
            US36_0(i32, string),
            US36_1(i32, string),
        }
        impl core::fmt::Display for Spiral_builder::US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0(std::collections::HashMap<string, string>),
            US37_1,
        }
        impl core::fmt::Display for Spiral_builder::US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US38 {
            US38_0(Spiral_builder::US1),
            US38_1,
        }
        impl core::fmt::Display for Spiral_builder::US38 {
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
        pub enum US39 {
            US39_0(std::fs::FileType),
            US39_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_builder::US39 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US40 {
            US40_0,
            US40_1,
            US40_2,
        }
        impl core::fmt::Display for Spiral_builder::US40 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US41 {
            US41_0(async_walkdir::DirEntry),
            US41_1(std::string::String),
        }
        impl core::fmt::Display for Spiral_builder::US41 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US42 {
            US42_0(string, string),
            US42_1,
        }
        impl core::fmt::Display for Spiral_builder::US42 {
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
                    let v80: &str = &*v78;
                    let v82: std::string::String = String::from(v80);
                    let v84: Box<std::string::String> = Box::new(v82);
                    let v86: &'static mut std::string::String = Box::leak(v84);
                    let v88: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v86);
                    let v90: bool = true;
                    v88
                })
                .collect::<Vec<_>>();
            let v92: Vec<clap::builder::PossibleValue> = _vec_map;
            let v94: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v92),
            );
            let v96: clap::Arg = v59.value_parser(v94);
            let v98: clap::Command = clap::Command::arg(v48, v96);
            let v100: string = string("r#\"NAME\"#");
            let v103: string = string("r#\"VERSION\"#");
            let v105: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v106: usize = 1_i32 as usize;
            let v109: usize = 0_i32 as usize;
            let v120: clap::builder::ValueRange = if v109 == v109 {
                clap::builder::ValueRange::new(v106..)
            } else {
                let v118: string = string("clap::builder::ValueRange::new($0..$1)");
                clap::builder::ValueRange::new(v106..v109)
            };
            let v122: string = string("r#\"deps\"#");
            let v123: &'static str = r#"deps"#;
            let v125: clap::Arg = clap::Arg::new(v123);
            let v127: clap::Arg = v125.short('d');
            let v128: string = string("r#\"deps\"#");
            let v129: &'static str = r#"deps"#;
            let v131: clap::Arg = v127.long(v129);
            let v133: Vec<&'static str> = v105.to_vec();
            let v135: clap::Arg = v131.value_names(v133);
            let v137: clap::Arg = v135.num_args(v120);
            let v139: clap::ArgAction = clap::ArgAction::Append;
            let v141: clap::Arg = v137.action(v139);
            let v143: clap::Command = clap::Command::arg(v98, v141);
            let v145: clap::Command = clap::Command::subcommand(v28, v143);
            let v147: string = string("r#\"fable\"#");
            let v148: &'static str = r#"fable"#;
            let v150: clap::Command = clap::Command::new(v148);
            let v152: string = string("r#\"fs-path\"#");
            let v153: &'static str = r#"fs-path"#;
            let v155: clap::Arg = clap::Arg::new(v153);
            let v157: clap::Arg = v155.short('f');
            let v158: string = string("r#\"fs-path\"#");
            let v159: &'static str = r#"fs-path"#;
            let v161: clap::Arg = v157.long(v159);
            let v163: clap::Arg = v161.required(true);
            let v165: clap::Command = clap::Command::arg(v150, v163);
            let v166: string = string("r#\"command\"#");
            let v167: &'static str = r#"command"#;
            let v169: clap::Arg = clap::Arg::new(v167);
            let v171: clap::Arg = v169.short('c');
            let v172: string = string("r#\"command\"#");
            let v173: &'static str = r#"command"#;
            let v175: clap::Arg = v171.long(v173);
            let v177: clap::Command = clap::Command::arg(v165, v175);
            let v179: clap::Command = clap::Command::subcommand(v145, v177);
            let v181: string = string("r#\"rust\"#");
            let v182: &'static str = r#"rust"#;
            let v184: clap::Command = clap::Command::new(v182);
            let v185: string = string("r#\"fs-path\"#");
            let v186: &'static str = r#"fs-path"#;
            let v188: clap::Arg = clap::Arg::new(v186);
            let v190: clap::Arg = v188.short('f');
            let v191: string = string("r#\"fs-path\"#");
            let v192: &'static str = r#"fs-path"#;
            let v194: clap::Arg = v190.long(v192);
            let v196: clap::Arg = v194.required(true);
            let v198: clap::Command = clap::Command::arg(v184, v196);
            let v199: string = string("r#\"NAME\"#");
            let v201: string = string("r#\"VERSION\"#");
            let v203: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v204: usize = 1_i32 as usize;
            let v207: usize = 0_i32 as usize;
            let v218: clap::builder::ValueRange = if v207 == v207 {
                clap::builder::ValueRange::new(v204..)
            } else {
                let v216: string = string("clap::builder::ValueRange::new($0..$1)");
                clap::builder::ValueRange::new(v204..v207)
            };
            let v219: string = string("r#\"deps\"#");
            let v220: &'static str = r#"deps"#;
            let v222: clap::Arg = clap::Arg::new(v220);
            let v224: clap::Arg = v222.short('d');
            let v225: string = string("r#\"deps\"#");
            let v226: &'static str = r#"deps"#;
            let v228: clap::Arg = v224.long(v226);
            let v230: Vec<&'static str> = v203.to_vec();
            let v232: clap::Arg = v228.value_names(v230);
            let v234: clap::Arg = v232.num_args(v218);
            let v236: clap::ArgAction = clap::ArgAction::Append;
            let v238: clap::Arg = v234.action(v236);
            let v240: clap::Command = clap::Command::arg(v198, v238);
            let v241: usize = 0_i32 as usize;
            let v244: usize = 1_i32 as usize;
            let v255: clap::builder::ValueRange = if v244 == v241 {
                clap::builder::ValueRange::new(v241..)
            } else {
                let v253: string = string("clap::builder::ValueRange::new($0..=$1)");
                clap::builder::ValueRange::new(v241..=v244)
            };
            let v257: string = string("r#\"wasm\"#");
            let v258: &'static str = r#"wasm"#;
            let v260: clap::Arg = clap::Arg::new(v258);
            let v262: clap::Arg = v260.short('w');
            let v263: string = string("r#\"wasm\"#");
            let v264: &'static str = r#"wasm"#;
            let v266: clap::Arg = v262.long(v264);
            let v268: clap::Arg = v266.num_args(v255);
            let v270: clap::Arg = v268.require_equals(true);
            let v272: string = string("r#\"\"#");
            let v273: &str = r#""#;
            let v275: clap::Arg = v270.default_missing_value(v273);
            let v277: clap::Command = clap::Command::arg(v240, v275);
            let v278: usize = 0_i32 as usize;
            let v281: usize = 1_i32 as usize;
            let v292: clap::builder::ValueRange = if v281 == v278 {
                clap::builder::ValueRange::new(v278..)
            } else {
                let v290: string = string("clap::builder::ValueRange::new($0..=$1)");
                clap::builder::ValueRange::new(v278..=v281)
            };
            let v294: string = string("r#\"contract\"#");
            let v295: &'static str = r#"contract"#;
            let v297: clap::Arg = clap::Arg::new(v295);
            let v299: clap::Arg = v297.short('c');
            let v300: string = string("r#\"contract\"#");
            let v301: &'static str = r#"contract"#;
            let v303: clap::Arg = v299.long(v301);
            let v305: clap::Arg = v303.num_args(v292);
            let v307: clap::Arg = v305.require_equals(true);
            let v308: string = string("r#\"\"#");
            let v309: &str = r#""#;
            let v311: clap::Arg = v307.default_missing_value(v309);
            let v313: clap::Command = clap::Command::arg(v277, v311);
            let v315: string = string("r#\"cleanup\"#");
            let v316: &'static str = r#"cleanup"#;
            let v318: clap::Arg = clap::Arg::new(v316);
            let v320: clap::Arg = v318.short('l');
            let v321: string = string("r#\"cleanup\"#");
            let v322: &'static str = r#"cleanup"#;
            let v324: clap::Arg = v320.long(v322);
            let v326: string = string("r#\"true\"#");
            let v327: &str = r#"true"#;
            let v329: clap::Arg = v324.default_value(v327);
            let v331: clap::ArgAction = clap::ArgAction::SetFalse;
            let v333: clap::Arg = v329.action(v331);
            let v335: clap::Command = clap::Command::arg(v313, v333);
            let v337: clap::Command = clap::Command::subcommand(v179, v335);
            let v339: string = string("r#\"typescript\"#");
            let v340: &'static str = r#"typescript"#;
            let v342: clap::Command = clap::Command::new(v340);
            let v343: string = string("r#\"fs-path\"#");
            let v344: &'static str = r#"fs-path"#;
            let v346: clap::Arg = clap::Arg::new(v344);
            let v348: clap::Arg = v346.short('f');
            let v349: string = string("r#\"fs-path\"#");
            let v350: &'static str = r#"fs-path"#;
            let v352: clap::Arg = v348.long(v350);
            let v354: clap::Arg = v352.required(true);
            let v356: clap::Command = clap::Command::arg(v342, v354);
            let v357: string = string("r#\"NAME\"#");
            let v359: string = string("r#\"VERSION\"#");
            let v361: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v362: usize = 1_i32 as usize;
            let v365: usize = 0_i32 as usize;
            let v375: clap::builder::ValueRange = if v365 == v365 {
                clap::builder::ValueRange::new(v362..)
            } else {
                let v373: string = string("clap::builder::ValueRange::new($0..$1)");
                clap::builder::ValueRange::new(v362..v365)
            };
            let v376: string = string("r#\"deps\"#");
            let v377: &'static str = r#"deps"#;
            let v379: clap::Arg = clap::Arg::new(v377);
            let v381: clap::Arg = v379.short('d');
            let v382: string = string("r#\"deps\"#");
            let v383: &'static str = r#"deps"#;
            let v385: clap::Arg = v381.long(v383);
            let v387: Vec<&'static str> = v361.to_vec();
            let v389: clap::Arg = v385.value_names(v387);
            let v391: clap::Arg = v389.num_args(v375);
            let v393: clap::ArgAction = clap::ArgAction::Append;
            let v395: clap::Arg = v391.action(v393);
            let v397: clap::Command = clap::Command::arg(v356, v395);
            let v399: clap::Command = clap::Command::subcommand(v337, v397);
            let v401: string = string("r#\"python\"#");
            let v402: &'static str = r#"python"#;
            let v404: clap::Command = clap::Command::new(v402);
            let v405: string = string("r#\"fs-path\"#");
            let v406: &'static str = r#"fs-path"#;
            let v408: clap::Arg = clap::Arg::new(v406);
            let v410: clap::Arg = v408.short('f');
            let v411: string = string("r#\"fs-path\"#");
            let v412: &'static str = r#"fs-path"#;
            let v414: clap::Arg = v410.long(v412);
            let v416: clap::Arg = v414.required(true);
            let v418: clap::Command = clap::Command::arg(v404, v416);
            let v419: string = string("r#\"NAME\"#");
            let v421: string = string("r#\"VERSION\"#");
            let v423: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v424: usize = 1_i32 as usize;
            let v427: usize = 0_i32 as usize;
            let v437: clap::builder::ValueRange = if v427 == v427 {
                clap::builder::ValueRange::new(v424..)
            } else {
                let v435: string = string("clap::builder::ValueRange::new($0..$1)");
                clap::builder::ValueRange::new(v424..v427)
            };
            let v438: string = string("r#\"deps\"#");
            let v439: &'static str = r#"deps"#;
            let v441: clap::Arg = clap::Arg::new(v439);
            let v443: clap::Arg = v441.short('d');
            let v444: string = string("r#\"deps\"#");
            let v445: &'static str = r#"deps"#;
            let v447: clap::Arg = v443.long(v445);
            let v449: Vec<&'static str> = v423.to_vec();
            let v451: clap::Arg = v447.value_names(v449);
            let v453: clap::Arg = v451.num_args(v437);
            let v455: clap::ArgAction = clap::ArgAction::Append;
            let v457: clap::Arg = v453.action(v455);
            let v459: clap::Command = clap::Command::arg(v418, v457);
            let v461: clap::Command = clap::Command::subcommand(v399, v459);
            let v463: string = string("r#\"dib\"#");
            let v464: &'static str = r#"dib"#;
            let v466: clap::Command = clap::Command::new(v464);
            let v468: string = string("r#\"path\"#");
            let v469: &'static str = r#"path"#;
            let v471: clap::Arg = clap::Arg::new(v469);
            let v473: clap::Arg = v471.short('p');
            let v474: string = string("r#\"path\"#");
            let v475: &'static str = r#"path"#;
            let v477: clap::Arg = v473.long(v475);
            let v479: clap::Arg = v477.required(true);
            let v481: clap::Command = clap::Command::arg(v466, v479);
            let v483: string = string("clap::value_parser!(u8).into()");
            let v484: clap::builder::ValueParser = clap::value_parser!(u8).into();
            let v486: string = string("r#\"retries\"#");
            let v487: &'static str = r#"retries"#;
            let v489: clap::Arg = clap::Arg::new(v487);
            let v491: clap::Arg = v489.short('r');
            let v492: string = string("r#\"retries\"#");
            let v493: &'static str = r#"retries"#;
            let v495: clap::Arg = v491.long(v493);
            let v497: clap::Arg = v495.value_parser(v484);
            let v499: clap::Command = clap::Command::arg(v481, v497);
            let v501: string = string("r#\"working-directory\"#");
            let v502: &'static str = r#"working-directory"#;
            let v504: clap::Arg = clap::Arg::new(v502);
            let v506: clap::Arg = v504.short('w');
            let v507: string = string("r#\"working-directory\"#");
            let v508: &'static str = r#"working-directory"#;
            let v510: clap::Arg = v506.long(v508);
            let v512: clap::Command = clap::Command::arg(v499, v510);
            clap::Command::subcommand(v461, v512)
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
        pub fn method2() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method4() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Spiral_builder::US1 {
            Spiral_builder::US1::US1_0(v0_1)
        }
        pub fn method5() -> Func1<string, Spiral_builder::US1> {
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
        pub fn method6() -> string {
            string("AUTOMATION")
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
            let v3: string = Spiral_builder::method3(Spiral_builder::method2());
            let v8: Spiral_builder::US2 = if string("Verbose") == v3.clone() {
                Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_0)
            } else {
                Spiral_builder::US2::US2_1
            };
            let _v1: (Spiral_builder::US2, Spiral_builder::US3) = (
                match &v8 {
                    Spiral_builder::US2::US2_0(v8_0_0) => Spiral_builder::US2::US2_0(match &v8 {
                        Spiral_builder::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => {
                        let v15: Spiral_builder::US2 = if string("Debug") == v3.clone() {
                            Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_1)
                        } else {
                            Spiral_builder::US2::US2_1
                        };
                        match &v15 {
                            Spiral_builder::US2::US2_0(v15_0_0) => {
                                Spiral_builder::US2::US2_0(match &v15 {
                                    Spiral_builder::US2::US2_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v22: Spiral_builder::US2 = if string("Info") == v3.clone() {
                                    Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_2)
                                } else {
                                    Spiral_builder::US2::US2_1
                                };
                                match &v22 {
                                    Spiral_builder::US2::US2_0(v22_0_0) => {
                                        Spiral_builder::US2::US2_0(match &v22 {
                                            Spiral_builder::US2::US2_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v29: Spiral_builder::US2 = if string("Warning")
                                            == v3.clone()
                                        {
                                            Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_3)
                                        } else {
                                            Spiral_builder::US2::US2_1
                                        };
                                        match &v29 {
                                            Spiral_builder::US2::US2_0(v29_0_0) => {
                                                Spiral_builder::US2::US2_0(match &v29 {
                                                    Spiral_builder::US2::US2_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v36: Spiral_builder::US2 =
                                                    if string("Critical") == v3.clone() {
                                                        Spiral_builder::US2::US2_0(
                                                            Spiral_builder::US0::US0_4,
                                                        )
                                                    } else {
                                                        Spiral_builder::US2::US2_1
                                                    };
                                                match &v36 {
                                                    Spiral_builder::US2::US2_0(v36_0_0) => {
                                                        Spiral_builder::US2::US2_0(match &v36 {
                                                            Spiral_builder::US2::US2_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => Spiral_builder::US2::US2_1,
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if Spiral_builder::method3(Spiral_builder::method6()) == string("True") {
                    Spiral_builder::US3::US3_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                } else {
                    Spiral_builder::US3::US3_1
                },
            );
            let v295: Spiral_builder::US3 = _v1.1.clone();
            let v294: Spiral_builder::US2 = _v1.0.clone();
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
                    l0: MutCell::new(match &v294 {
                        Spiral_builder::US2::US2_0(v294_0_0) => match &v294 {
                            Spiral_builder::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => v0_1,
                    }),
                }),
                match &v295 {
                    Spiral_builder::US3::US3_0(v295_0_0) => Some(match &v295 {
                        Spiral_builder::US3::US3_0(x) => x.clone(),
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
        pub fn closure6(unitVar: (), v0_1: i64) -> Spiral_builder::US3 {
            Spiral_builder::US3::US3_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Spiral_builder::US3> {
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
            let v20: Spiral_builder::US3 = defaultValue(
                Spiral_builder::US3::US3_1,
                map(Spiral_builder::method8(), v5),
            );
            let v60: DateTime = match &v20 {
                Spiral_builder::US3::US3_0(v20_0_0) => {
                    let v34: TimeSpan = TimeSpan::new_ticks(
                        {
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        } - match &v20 {
                            Spiral_builder::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v34.hours(),
                        v34.minutes(),
                        v34.seconds(),
                        v34.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let provider: string = Spiral_builder::method9();
            v60.toString(provider)
        }
        pub fn method12() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v5: string = padLeft(toLower(string("Debug")), 7_i32, ' ');
            let v21: &str = inline_colorization::color_bright_blue;
            let v23: &str = &*v5;
            let v25: &str = inline_colorization::color_reset;
            let v27: std::string::String = format!("{}{}{}", v21, v23, v25);
            fable_library_rust::String_::fromString(v27)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn closure7(v0_1: LrcPtr<Spiral_builder::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append(v0_1.l0.get().clone(), v1_1);
            v0_1.l0.set(v3);
            ()
        }
        pub fn method13(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method15(v0_1: string, v1_1: string, v2: string, v3: i64, v4: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!("{} {} #{} {} / {}", v0_1, v1_1, v3, v2, v4),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
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
        pub fn method16(
            v0_1: string,
            v1_1: LrcPtr<Spiral_builder::Mut0>,
            v2: LrcPtr<Spiral_builder::Mut1>,
            v3: LrcPtr<Spiral_builder::Mut2>,
            v4: LrcPtr<Spiral_builder::Mut3>,
            v5: LrcPtr<Spiral_builder::Mut4>,
            v6: Option<i64>,
        ) {
            let v9: () = {
                Spiral_builder::closure8(v1_1, ());
                ()
            };
            println!("{}", v0_1.clone());
            ();
            (v2.l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.main"),
                    v56.l0.get().clone(),
                    Spiral_builder::method13(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure11(unitVar: (), v0_1: &str) -> std::string::String {
            String::from(v0_1)
        }
        pub fn closure12(
            unitVar: (),
            _arg: (std::string::String, clap::ArgMatches),
        ) -> Spiral_builder::US4 {
            Spiral_builder::US4::US4_0(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method18() -> Func1<(std::string::String, clap::ArgMatches), Spiral_builder::US4> {
            Func1::new(move |arg10_0040: (std::string::String, clap::ArgMatches)| {
                Spiral_builder::closure12((), arg10_0040)
            })
        }
        pub fn method19() -> string {
            string("py-path")
        }
        pub fn closure13(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US5 {
            Spiral_builder::US5::US5_0(v0_1)
        }
        pub fn method20() -> Func1<std::string::String, Spiral_builder::US5> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure13((), v))
        }
        pub fn method21() -> string {
            string("env")
        }
        pub fn method22() -> string {
            string("deps")
        }
        pub fn closure14(unitVar: (), v0_1: Vec<std::string::String>) -> Spiral_builder::US9 {
            Spiral_builder::US9::US9_0(v0_1)
        }
        pub fn method23() -> Func1<Vec<std::string::String>, Spiral_builder::US9> {
            Func1::new(move |v: Vec<std::string::String>| Spiral_builder::closure14((), v))
        }
        pub fn method24(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method27(v0_1: string) -> string {
            v0_1
        }
        pub fn method26(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Spiral_builder::method27(v0_1))
        }
        pub fn method25(v0_1: string, v1_1: string) -> string {
            let v4: &str = &*v0_1;
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            let v10: &str = &*v1_1;
            let v12: std::string::String = String::from(v10);
            let v14: std::path::PathBuf = v8.join(v12);
            let v16: std::path::Display = v14.display();
            let v19: std::string::String = format!("{}", v16);
            fable_library_rust::String_::fromString(v19)
        }
        pub fn method29(v0_1: string) -> bool {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.clone().exists() {
                true
            } else {
                if v7.clone().is_dir() {
                    true
                } else {
                    v7.is_symlink()
                }
            }
        }
        pub fn method31(v0_1: string) -> Option<string> {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<std::path::PathBuf> = v7.parent().map(std::path::PathBuf::from);
            let v11: std::path::PathBuf = v9?;
            let v13: std::path::Display = v11.display();
            let v16: std::string::String = format!("{}", v13);
            let v85: Spiral_builder::US1 =
                Spiral_builder::US1::US1_0(fable_library_rust::String_::fromString(v16));
            match &v85 {
                Spiral_builder::US1::US1_0(v85_0_0) => Some(match &v85 {
                    Spiral_builder::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => None::<string>,
            }
        }
        pub fn closure15(unitVar: (), v0_1: string) -> Option<string> {
            Spiral_builder::method31(v0_1)
        }
        pub fn method30() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Spiral_builder::closure15((), v))
        }
        pub fn method32(v0_1: string, v1_1: string, v2: string) -> Spiral_builder::US12 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method32: loop {
                break '_method32 (if Spiral_builder::method29(Spiral_builder::method25(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Spiral_builder::US12::US12_0(v2.get().clone())
                } else {
                    let v7: Option<string> = (Spiral_builder::method30())(v2.get().clone());
                    let v21: Spiral_builder::US1 = defaultValue(
                        Spiral_builder::US1::US1_1,
                        map(Spiral_builder::method5(), v7),
                    );
                    match &v21 {
                        Spiral_builder::US1::US1_0(v21_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: string = match &v21 {
                                Spiral_builder::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method32;
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
        pub fn method28(v0_1: string, v1_1: string) -> Spiral_builder::US12 {
            if Spiral_builder::method29(Spiral_builder::method25(v1_1.clone(), v0_1.clone())) {
                Spiral_builder::US12::US12_0(v1_1.clone())
            } else {
                let v6: Option<string> = (Spiral_builder::method30())(v1_1.clone());
                let v20: Spiral_builder::US1 = defaultValue(
                    Spiral_builder::US1::US1_1,
                    map(Spiral_builder::method5(), v6),
                );
                match &v20 {
                    Spiral_builder::US1::US1_0(v20_0_0) => Spiral_builder::method32(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v20 {
                            Spiral_builder::US1::US1_0(x) => x.clone(),
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
        pub fn method33() -> string {
            let v5: string = padLeft(toLower(string("Warning")), 7_i32, ' ');
            let v21: &str = inline_colorization::color_yellow;
            let v23: &str = &*v5;
            let v25: &str = inline_colorization::color_reset;
            let v27: std::string::String = format!("{}{}{}", v21, v23, v25);
            fable_library_rust::String_::fromString(v27)
        }
        pub fn method34(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method35(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("file_system.get_workspace_root"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure16(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v78: string = Spiral_builder::method35(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method33(),
                    v56.l0.get().clone(),
                    Spiral_builder::method34(v0_1),
                );
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v78,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method36() -> string {
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v4: std::path::PathBuf = v2.unwrap();
            let v6: std::path::Display = v4.display();
            let v9: std::string::String = format!("{}", v6);
            fable_library_rust::String_::fromString(v9)
        }
        pub fn method37(v0_1: string) -> string {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<&std::path::Path> = v7.parent();
            let v11: &std::path::Path = v9.unwrap();
            let v13: std::path::Display = v11.display();
            let v16: std::string::String = format!("{}", v13);
            fable_library_rust::String_::fromString(v16)
        }
        pub fn method40(v0_1: string) -> bool {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.clone().exists() {
                v7.is_file()
            } else {
                false
            }
        }
        pub fn method39(v0_1: string, v1_1: string) -> bool {
            if Spiral_builder::method40(v0_1.clone()) == false {
                false
            } else {
                let v8: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v0_1);
                let v31: Vec<u8> = Spiral_builder::method24(v8.unwrap());
                let v33: Result<std::string::String, std::string::FromUtf8Error> =
                    std::string::String::from_utf8(v31);
                let v35: std::string::String = v33.unwrap();
                v1_1 == fable_library_rust::String_::fromString(v35)
            }
        }
        pub fn method42(v0_1: string) -> string {
            v0_1
        }
        pub fn closure17(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method43() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Spiral_builder::closure17((), v))
        }
        pub fn closure18(unitVar: (), unitVar_1: ()) -> Spiral_builder::US13 {
            Spiral_builder::US13::US13_0
        }
        pub fn closure19(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US13 {
            Spiral_builder::US13::US13_1(v0_1)
        }
        pub fn method44() -> string {
            let v5: string = padLeft(toLower(string("Critical")), 7_i32, ' ');
            let v21: &str = inline_colorization::color_bright_red;
            let v23: &str = &*v5;
            let v25: &str = inline_colorization::color_reset;
            let v27: std::string::String = format!("{}{}{}", v21, v23, v25);
            fable_library_rust::String_::fromString(v27)
        }
        pub fn method45(v0_1: string, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
            let v97: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v67)),
                    (),
                );
                ()
            };
            let v106: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method46(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("file_system.create_dir"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure20(v0_1: string, v1_1: std::string::String, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_builder::method46(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v57.l0.get().clone(),
                    Spiral_builder::method45(v0_1, v1_1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method47() -> string {
            let v5: string = padLeft(toLower(string("Verbose")), 7_i32, ' ');
            let v21: &str = inline_colorization::color_bright_black;
            let v23: &str = &*v5;
            let v25: &str = inline_colorization::color_reset;
            let v27: std::string::String = format!("{}{}{}", v21, v23, v25);
            fable_library_rust::String_::fromString(v27)
        }
        pub fn method48(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure21(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v78: string = Spiral_builder::method46(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method47(),
                    v56.l0.get().clone(),
                    Spiral_builder::method48(v0_1),
                );
                let v80: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v78,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method51(v0_1: string) -> string {
            v0_1
        }
        pub fn method50(v0_1: bool, v1_1: string) {
            let v3: string = Spiral_builder::method51(v1_1);
            if Spiral_builder::method29(v3.clone()) {
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
            Spiral_builder::method50(true, v0_1);
        }
        pub fn method49(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure22(v0_1.clone(), ())
            })
        }
        pub fn method52(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure22(v0_1.clone(), ())
            })
        }
        pub fn method53(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure23(v0_1: string, v1_1: string, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_builder::method46(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    v57.l0.get().clone(),
                    Spiral_builder::method53(v0_1, v1_1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method56(v0_1: string) -> string {
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<&std::ffi::OsStr> = v7.file_name();
            let v11: &std::ffi::OsStr = v9.unwrap();
            let v13: std::ffi::OsString = v11.to_os_string();
            let v15: Option<&str> = v13.to_str();
            let v17: &str = v15.unwrap();
            let v19: std::string::String = String::from(v17);
            fable_library_rust::String_::fromString(v19)
        }
        pub fn method57(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method58(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("file_system.delete_directory_async"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure25(v0_1: string, v1_1: string, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v80: string = Spiral_builder::method58(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    v57.l0.get().clone(),
                    Spiral_builder::method57(v1_1, Spiral_builder::method56(v0_1)),
                );
                let v82: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v80,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method55(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
            defaultOf()
        }
        pub fn closure24(v0_1: string, unitVar: ()) {
            let v2: Arc<Async<i64>> = defaultOf();
            let v25: Arc<Async<()>> = defaultOf();
            defaultOf::<()>();
            ();
            ()
        }
        pub fn method54(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure24(v0_1.clone(), ())
            })
        }
        pub fn method59(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure24(v0_1.clone(), ())
            })
        }
        pub fn method41(v0_1: string) -> LrcPtr<dyn IDisposable> {
            let v2: string = Spiral_builder::method42(v0_1);
            let v4: Result<(), std::io::Error> = std::fs::create_dir_all(&*v2.clone());
            let v5 = Spiral_builder::method43();
            let v7: Result<(), std::string::String> = v4.map_err(|x| v5(x));
            let v10: Spiral_builder::US13 = match &v7 {
                Err(v7_1_0) => Spiral_builder::closure19((), v7_1_0.clone()),
                _ => Spiral_builder::closure18((), ()),
            };
            match &v10 {
                Spiral_builder::US13::US13_0 => {
                    let v13: () = {
                        Spiral_builder::closure21(v2.clone(), ());
                        ()
                    };
                    ()
                }
                Spiral_builder::US13::US13_1(v10_1_0) => {
                    let v128: () = {
                        Spiral_builder::closure20(
                            v2.clone(),
                            match &v10 {
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
                let v241 = Spiral_builder::method49(v2.clone());
                interface_cast!(
                    Spiral_builder::Disposable::_ctor__3A5B6456(Func0::new({
                        let v241 = v241.clone();
                        move || v241.clone()()
                    })),
                    Lrc<dyn IDisposable>,
                )
            }
        }
        pub fn method60(v0_1: string) -> string {
            v0_1
        }
        pub fn method38(v0_1: string, v1_1: string) {
            if Spiral_builder::method39(v0_1.clone(), v1_1.clone()) == false {
                let v4: string = Spiral_builder::method37(v0_1.clone());
                if Spiral_builder::method29(v4.clone()) == false {
                    let v7: LrcPtr<dyn IDisposable> = Spiral_builder::method41(v4);
                    ()
                }
                std::fs::write(&*v0_1, &*v1_1).unwrap();
                ();
                ()
            };
        }
        pub fn method62(
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
        pub fn method64(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut5>) -> bool {
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
        pub fn method65(
        ) -> Func1<char, Func1<LrcPtr<Spiral_builder::UH0>, LrcPtr<Spiral_builder::UH0>>> {
            Func1::new(move |v: char| Spiral_builder::closure27((), v))
        }
        pub fn method66(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method66: loop {
                break '_method66 (match v0_1.get().clone().as_ref() {
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
                                let v18: LrcPtr<StringBuilder> = {
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
                            continue '_method66;
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
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\"' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method64(v20, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method66(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method65())(b0)(b1)
                                    }),
                                    v27,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US15::US15_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US15::US15_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\"',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v46 { v43 } else { v46 })
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
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\'' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method64(v20, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method66(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method65())(b0)(b1)
                                    }),
                                    v27,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US15::US15_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US15::US15_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\'',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            }
        }
        pub fn method67(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Spiral_builder::UH1>,
        ) -> Spiral_builder::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            '_method67: loop {
                break '_method67 (match v2.get().clone().as_ref() {
                    Spiral_builder::UH1::UH1_0 => {
                        Spiral_builder::US15::US15_1(string("choice / no parsers succeeded"))
                    }
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
                                continue '_method67;
                            }
                        }
                    }
                });
            }
        }
        pub fn method68(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method68: loop {
                break '_method68 (if v1_1.get().clone() >= 2_i64 {
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
                        continue '_method68;
                    }
                });
            }
        }
        pub fn method69(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method69: loop {
                break '_method69 ({
                    let v70: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v19: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v26: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method68(v19, 0_i64) == false {
                            let v31: string = ofChar(v19);
                            let v34: i32 = length(v31.clone());
                            let v35: Array<char> = new_init(&'\u{0000}', v34);
                            let v36: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method64(v34, v36.clone()) {
                                let v38: i32 = v36.l0.get().clone();
                                let v39: char = getCharAt(v31.clone(), v38);
                                v35.get_mut()[v38 as usize] = v39;
                                {
                                    let v40: i32 = v38 + 1_i32;
                                    v36.l0.set(v40);
                                    ()
                                }
                            }
                            {
                                let v41: List<char> = ofArray(v35.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method66(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method65())(b0)(b1)
                                                },
                                            ),
                                            v41,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v19,
                                    v26,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v19,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v82: Spiral_builder::US15 = match &v70 {
                        Spiral_builder::US15::US15_0(
                            v70_0_0,
                            v70_0_1,
                            v70_0_2,
                            v70_0_3,
                            v70_0_4,
                        ) => {
                            let v71: char = v70_0_0.clone();
                            Spiral_builder::US15::US15_0(
                                if '\\' == v71 { '/' } else { v71 },
                                v70_0_1.clone(),
                                v70_0_2.clone(),
                                v70_0_3.clone(),
                                v70_0_4.clone(),
                            )
                        }
                        Spiral_builder::US15::US15_1(v70_1_0) => {
                            Spiral_builder::US15::US15_1(v70_1_0.clone())
                        }
                    };
                    match &v82 {
                        Spiral_builder::US15::US15_0(
                            v82_0_0,
                            v82_0_1,
                            v82_0_2,
                            v82_0_3,
                            v82_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v82_0_0.clone()));
                            let v1_1_temp: string = v82_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v82_0_2.clone();
                            let v3_temp: i32 = v82_0_3.clone();
                            let v4_temp: i32 = v82_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method69;
                        }
                        _ => Spiral_builder::US16::US16_0(
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
        pub fn method70(
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
            '_method70: loop {
                break '_method70 (match v4.get().clone().as_ref() {
                    Spiral_builder::UH1::UH1_0 => {
                        Spiral_builder::US15::US15_1(string("choice / no parsers succeeded"))
                    }
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
                                continue '_method70;
                            }
                        }
                    }
                });
            }
        }
        pub fn method71(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method71: loop {
                break '_method71 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method71;
                    }
                });
            }
        }
        pub fn method72(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method72: loop {
                break '_method72 ({
                    let v76: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v29: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method71(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method64(v37, v39.clone()) {
                                let v41: i32 = v39.l0.get().clone();
                                let v42: char = getCharAt(v34.clone(), v41);
                                v38.get_mut()[v41 as usize] = v42;
                                {
                                    let v43: i32 = v41 + 1_i32;
                                    v39.l0.set(v43);
                                    ()
                                }
                            }
                            {
                                let v44: List<char> = ofArray(v38.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method66(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method65())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v88: Spiral_builder::US15 = match &v76 {
                        Spiral_builder::US15::US15_0(
                            v76_0_0,
                            v76_0_1,
                            v76_0_2,
                            v76_0_3,
                            v76_0_4,
                        ) => {
                            let v77: char = v76_0_0.clone();
                            Spiral_builder::US15::US15_0(
                                if '\\' == v77 { '/' } else { v77 },
                                v76_0_1.clone(),
                                v76_0_2.clone(),
                                v76_0_3.clone(),
                                v76_0_4.clone(),
                            )
                        }
                        Spiral_builder::US15::US15_1(v76_1_0) => {
                            Spiral_builder::US15::US15_1(v76_1_0.clone())
                        }
                    };
                    match &v88 {
                        Spiral_builder::US15::US15_0(
                            v88_0_0,
                            v88_0_1,
                            v88_0_2,
                            v88_0_3,
                            v88_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v88_0_0.clone()));
                            let v1_1_temp: string = v88_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v88_0_2.clone();
                            let v3_temp: i32 = v88_0_3.clone();
                            let v4_temp: i32 = v88_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method72;
                        }
                        _ => Spiral_builder::US16::US16_0(
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
        pub fn method73(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method73: loop {
                break '_method73 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method73;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method74(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method74: loop {
                break '_method74 ({
                    let v42: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v8: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v15: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        let v17: string = ofChar(v8);
                        let v20: i32 = length(v17.clone());
                        let v21: Array<char> = new_init(&'\u{0000}', v20);
                        let v22: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Spiral_builder::method64(v20, v22.clone()) {
                            let v24: i32 = v22.l0.get().clone();
                            let v25: char = getCharAt(v17.clone(), v24);
                            v21.get_mut()[v24 as usize] = v25;
                            {
                                let v26: i32 = v24 + 1_i32;
                                v22.l0.set(v26);
                                ()
                            }
                        }
                        {
                            let v27: List<char> = ofArray(v21.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method66(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method65())(b0)(b1)
                                            },
                                        ),
                                        v27,
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                    ),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Spiral_builder::US15::US15_0(
                                v8,
                                v15,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        }
                    };
                    match &v42 {
                        Spiral_builder::US15::US15_0(
                            v42_0_0,
                            v42_0_1,
                            v42_0_2,
                            v42_0_3,
                            v42_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v42_0_0.clone()));
                            let v1_1_temp: string = v42_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v42_0_2.clone();
                            let v3_temp: i32 = v42_0_3.clone();
                            let v4_temp: i32 = v42_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method74;
                        }
                        _ => Spiral_builder::US16::US16_0(
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
        pub fn method63(v0_1: string) -> Spiral_builder::US14 {
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
                let v11: LrcPtr<StringBuilder> = StringBuilder::_ctor__Z721C83C5(string(""));
                fn v12(
                    arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32),
                ) -> Spiral_builder::US15 {
                    Spiral_builder::closure26((), arg10_0040)
                }
                fn v13(
                    arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32),
                ) -> Spiral_builder::US15 {
                    Spiral_builder::closure29((), arg10_0040_1)
                }
                let v17: Spiral_builder::US15 = Spiral_builder::method67(
                    v7.clone(),
                    v11.clone(),
                    LrcPtr::new(Spiral_builder::UH1::UH1_1(
                        Func1::from(v12),
                        LrcPtr::new(Spiral_builder::UH1::UH1_1(
                            Func1::from(v13),
                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                        )),
                    )),
                );
                let v153: Spiral_builder::US16 = match &v17 {
                    Spiral_builder::US15::US15_0(v17_0_0, v17_0_1, v17_0_2, v17_0_3, v17_0_4) => {
                        let v22: i32 = v17_0_4.clone();
                        let v21: i32 = v17_0_3.clone();
                        let v20: LrcPtr<StringBuilder> = v17_0_2.clone();
                        let v19: string = v17_0_1.clone();
                        let v88: Spiral_builder::US15 = if string("") == v19.clone() {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v20.clone(), v21, v22)
                            ))
                        } else {
                            let v37: char = getCharAt(v19.clone(), 0_i32);
                            let v44: string =
                                getSlice(v19.clone(), Some(1_i32), Some(length(v19.clone())));
                            if Spiral_builder::method68(v37, 0_i64) == false {
                                let v49: string = ofChar(v37);
                                let v52: i32 = length(v49.clone());
                                let v53: Array<char> = new_init(&'\u{0000}', v52);
                                let v54: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method64(v52, v54.clone()) {
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
                                    let patternInput:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method66(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method65())(b0)(b1)),
                                                                                  v59,
                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                         v20.clone(),
                                                                         v21,
                                                                         v22);
                                    Spiral_builder::US15::US15_0(
                                        v37,
                                        v44,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                    )
                                }
                            } else {
                                Spiral_builder::US15::US15_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                              v37,
                                                                              toArray(ofArray(new_array(&['\"',
                                                                                                          '\'']))),
                                                                              (v20.clone(),
                                                                               v21,
                                                                               v22)))
                            }
                        };
                        let v100: Spiral_builder::US15 = match &v88 {
                            Spiral_builder::US15::US15_0(
                                v88_0_0,
                                v88_0_1,
                                v88_0_2,
                                v88_0_3,
                                v88_0_4,
                            ) => {
                                let v89: char = v88_0_0.clone();
                                Spiral_builder::US15::US15_0(
                                    if '\\' == v89 { '/' } else { v89 },
                                    v88_0_1.clone(),
                                    v88_0_2.clone(),
                                    v88_0_3.clone(),
                                    v88_0_4.clone(),
                                )
                            }
                            Spiral_builder::US15::US15_1(v88_1_0) => {
                                Spiral_builder::US15::US15_1(v88_1_0.clone())
                            }
                        };
                        let v114: Spiral_builder::US16 = match &v100 {
                            Spiral_builder::US15::US15_0(
                                v100_0_0,
                                v100_0_1,
                                v100_0_2,
                                v100_0_3,
                                v100_0_4,
                            ) => Spiral_builder::method69(
                                ofChar(v100_0_0.clone()),
                                v100_0_1.clone(),
                                v100_0_2.clone(),
                                v100_0_3.clone(),
                                v100_0_4.clone(),
                            ),
                            Spiral_builder::US15::US15_1(v100_1_0) => {
                                Spiral_builder::US16::US16_1(v100_1_0.clone())
                            }
                        };
                        let v124: Spiral_builder::US16 = match &v114 {
                            Spiral_builder::US16::US16_0(
                                v114_0_0,
                                v114_0_1,
                                v114_0_2,
                                v114_0_3,
                                v114_0_4,
                            ) => Spiral_builder::US16::US16_0(
                                v114_0_0.clone(),
                                v114_0_1.clone(),
                                v114_0_2.clone(),
                                v114_0_3.clone(),
                                v114_0_4.clone(),
                            ),
                            _ => Spiral_builder::US16::US16_0(
                                string(""),
                                v19.clone(),
                                v20.clone(),
                                v21,
                                v22,
                            ),
                        };
                        match &v124 {
                            Spiral_builder::US16::US16_0(
                                v124_0_0,
                                v124_0_1,
                                v124_0_2,
                                v124_0_3,
                                v124_0_4,
                            ) => {
                                let v129: i32 = v124_0_4.clone();
                                let v128: i32 = v124_0_3.clone();
                                let v127: LrcPtr<StringBuilder> = v124_0_2.clone();
                                let v126: string = v124_0_1.clone();
                                let v133: Spiral_builder::US15 = Spiral_builder::method70(
                                    v126.clone(),
                                    v127.clone(),
                                    v128,
                                    v129,
                                    LrcPtr::new(Spiral_builder::UH1::UH1_1(
                                        Func1::from(v12),
                                        LrcPtr::new(Spiral_builder::UH1::UH1_1(
                                            Func1::from(v13),
                                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v133 {
                                        Spiral_builder::US15::US15_0(v133_0_0,
                                                                     v133_0_1,
                                                                     v133_0_2,
                                                                     v133_0_3,
                                                                     v133_0_4)
                                        =>
                                        Spiral_builder::US16::US16_0(v124_0_0.clone(),
                                                                     v133_0_1.clone(),
                                                                     v133_0_2.clone(),
                                                                     v133_0_3.clone(),
                                                                     v133_0_4.clone()),
                                        Spiral_builder::US15::US15_1(v133_1_0)
                                        =>
                                        Spiral_builder::US16::US16_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                              v133_1_0.clone(),
                                                                              (v7.clone(),
                                                                               v11.clone(),
                                                                               1_i32,
                                                                               1_i32),
                                                                              (v19,
                                                                               v20,
                                                                               v21,
                                                                               v22),
                                                                              (v126,
                                                                               v127,
                                                                               v128,
                                                                               v129))),
                                    }
                            }
                            _ => Spiral_builder::US16::US16_1(string("between / expected content")),
                        }
                    }
                    Spiral_builder::US15::US15_1(v17_1_0) => {
                        Spiral_builder::US16::US16_1(v17_1_0.clone())
                    }
                };
                let v303: Spiral_builder::US16 = match &v153 {
                    Spiral_builder::US16::US16_0(
                        v153_0_0,
                        v153_0_1,
                        v153_0_2,
                        v153_0_3,
                        v153_0_4,
                    ) => v153.clone(),
                    _ => {
                        let v233: Spiral_builder::US15 = if string("") == v7.clone() {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v11.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v177: char = getCharAt(v7.clone(), 0_i32);
                            let v184: string =
                                getSlice(v7.clone(), Some(1_i32), Some(length(v7.clone())));
                            if Spiral_builder::method71(v177, 0_i64) == false {
                                let v189: string = ofChar(v177);
                                let v192: i32 = length(v189.clone());
                                let v193: Array<char> = new_init(&'\u{0000}', v192);
                                let v194: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method64(v192, v194.clone()) {
                                    let v196: i32 = v194.l0.get().clone();
                                    let v197: char = getCharAt(v189.clone(), v196);
                                    v193.get_mut()[v196 as usize] = v197;
                                    {
                                        let v198: i32 = v196 + 1_i32;
                                        v194.l0.set(v198);
                                        ()
                                    }
                                }
                                {
                                    let v199: List<char> = ofArray(v193.clone());
                                    let patternInput_1:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method66(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method65())(b0)(b1)),
                                                                                  v199,
                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                         v11.clone(),
                                                                         1_i32,
                                                                         1_i32);
                                    Spiral_builder::US15::US15_0(
                                        v177,
                                        v184,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                    )
                                }
                            } else {
                                Spiral_builder::US15::US15_1(sprintf!("parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                                                              v177,
                                                                              toArray(ofArray(new_array(&['\"',
                                                                                                          '\'',
                                                                                                          ' ']))),
                                                                              (v11.clone(),
                                                                               1_i32,
                                                                               1_i32)))
                            }
                        };
                        let v245: Spiral_builder::US15 = match &v233 {
                            Spiral_builder::US15::US15_0(
                                v233_0_0,
                                v233_0_1,
                                v233_0_2,
                                v233_0_3,
                                v233_0_4,
                            ) => {
                                let v234: char = v233_0_0.clone();
                                Spiral_builder::US15::US15_0(
                                    if '\\' == v234 { '/' } else { v234 },
                                    v233_0_1.clone(),
                                    v233_0_2.clone(),
                                    v233_0_3.clone(),
                                    v233_0_4.clone(),
                                )
                            }
                            Spiral_builder::US15::US15_1(v233_1_0) => {
                                Spiral_builder::US15::US15_1(v233_1_0.clone())
                            }
                        };
                        let v259: Spiral_builder::US16 = match &v245 {
                            Spiral_builder::US15::US15_0(
                                v245_0_0,
                                v245_0_1,
                                v245_0_2,
                                v245_0_3,
                                v245_0_4,
                            ) => Spiral_builder::method72(
                                ofChar(v245_0_0.clone()),
                                v245_0_1.clone(),
                                v245_0_2.clone(),
                                v245_0_3.clone(),
                                v245_0_4.clone(),
                            ),
                            Spiral_builder::US15::US15_1(v245_1_0) => {
                                Spiral_builder::US16::US16_1(v245_1_0.clone())
                            }
                        };
                        match &v259 {
                            Spiral_builder::US16::US16_0(
                                v259_0_0,
                                v259_0_1,
                                v259_0_2,
                                v259_0_3,
                                v259_0_4,
                            ) => v259.clone(),
                            _ => {
                                let v271: Spiral_builder::US18 = if length(v7.clone()) == 0_i32 {
                                    Spiral_builder::US18::US18_0(
                                        v7.clone(),
                                        v11.clone(),
                                        1_i32,
                                        1_i32,
                                    )
                                } else {
                                    Spiral_builder::US18::US18_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v7.clone()
                                    ))
                                };
                                let v280: Spiral_builder::US16 = match &v271 {
                                    Spiral_builder::US18::US18_0(
                                        v271_0_0,
                                        v271_0_1,
                                        v271_0_2,
                                        v271_0_3,
                                    ) => Spiral_builder::US16::US16_0(
                                        string(""),
                                        v271_0_0.clone(),
                                        v271_0_1.clone(),
                                        v271_0_2.clone(),
                                        v271_0_3.clone(),
                                    ),
                                    Spiral_builder::US18::US18_1(v271_1_0) => {
                                        Spiral_builder::US16::US16_1(v271_1_0.clone())
                                    }
                                };
                                match &v280 {
                                    Spiral_builder::US16::US16_0(
                                        v280_0_0,
                                        v280_0_1,
                                        v280_0_2,
                                        v280_0_3,
                                        v280_0_4,
                                    ) => {
                                        let v282: string = v280_0_1.clone();
                                        Spiral_builder::US16::US16_0(
                                            v280_0_0.clone(),
                                            getSlice(
                                                v282.clone(),
                                                Some(Spiral_builder::method73(v282.clone(), 0_i32)),
                                                Some(length(v282)),
                                            ),
                                            v280_0_2.clone(),
                                            v280_0_3.clone(),
                                            v280_0_4.clone(),
                                        )
                                    }
                                    Spiral_builder::US16::US16_1(v280_1_0) => {
                                        Spiral_builder::US16::US16_1(v280_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v471: Spiral_builder::US19 = match &v303 {
                    Spiral_builder::US16::US16_0(
                        v303_0_0,
                        v303_0_1,
                        v303_0_2,
                        v303_0_3,
                        v303_0_4,
                    ) => {
                        let v308: i32 = v303_0_4.clone();
                        let v307: i32 = v303_0_3.clone();
                        let v306: LrcPtr<StringBuilder> = v303_0_2.clone();
                        let v305: string = v303_0_1.clone();
                        let v372: Spiral_builder::US15 = if string("") == v305.clone() {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.p_char / unexpected end of input / s: {:?}",
                                (v306.clone(), v307, v308)
                            ))
                        } else {
                            let v312: char = getCharAt(v305.clone(), 0_i32);
                            if v312 == ' ' {
                                let v320: string =
                                    getSlice(v305.clone(), Some(1_i32), Some(length(v305.clone())));
                                let v322: string = ofChar(v312);
                                let v325: i32 = length(v322.clone());
                                let v326: Array<char> = new_init(&'\u{0000}', v325);
                                let v327: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method64(v325, v327.clone()) {
                                    let v329: i32 = v327.l0.get().clone();
                                    let v330: char = getCharAt(v322.clone(), v329);
                                    v326.get_mut()[v329 as usize] = v330;
                                    {
                                        let v331: i32 = v329 + 1_i32;
                                        v327.l0.set(v331);
                                        ()
                                    }
                                }
                                {
                                    let v332: List<char> = ofArray(v326.clone());
                                    let patternInput_2:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method66(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method65())(b0)(b1)),
                                                                                  v332,
                                                                                  LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                         v306.clone(),
                                                                         v307,
                                                                         v308);
                                    Spiral_builder::US15::US15_0(
                                        v312,
                                        v320,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                }
                            } else {
                                let v348: i32 = length(v305.clone());
                                let v351: i32 = indexOf(v305.clone(), string("\n")) - 1_i32;
                                Spiral_builder::US15::US15_1(sprintf!("{}\n{}\n",
                                                                              sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                       ' ',
                                                                                       v307,
                                                                                       v308,
                                                                                       v306.clone(),
                                                                                       getSlice(v305.clone(),
                                                                                                Some(0_i32),
                                                                                                Some(if -2_i32
                                                                                                            ==
                                                                                                            v351
                                                                                                        {
                                                                                                         v348
                                                                                                     } else {
                                                                                                         v351
                                                                                                     }))),
                                                                              append(replicate(v308
                                                                                                   -
                                                                                                   1_i32,
                                                                                               string(" ")),
                                                                                     string("^"))))
                            }
                        };
                        let v384: Spiral_builder::US20 = match &v372 {
                            Spiral_builder::US15::US15_0(
                                v372_0_0,
                                v372_0_1,
                                v372_0_2,
                                v372_0_3,
                                v372_0_4,
                            ) => Spiral_builder::US20::US20_0(
                                Spiral_builder::US17::US17_0(v372_0_0.clone()),
                                v372_0_1.clone(),
                                v372_0_2.clone(),
                                v372_0_3.clone(),
                                v372_0_4.clone(),
                            ),
                            _ => Spiral_builder::US20::US20_0(
                                Spiral_builder::US17::US17_1,
                                v305.clone(),
                                v306.clone(),
                                v307,
                                v308,
                            ),
                        };
                        let v445: Spiral_builder::US16 = match &v384 {
                            Spiral_builder::US20::US20_0(
                                v384_0_0,
                                v384_0_1,
                                v384_0_2,
                                v384_0_3,
                                v384_0_4,
                            ) => {
                                let v389: i32 = v384_0_4.clone();
                                let v388: i32 = v384_0_3.clone();
                                let v387: LrcPtr<StringBuilder> = v384_0_2.clone();
                                let v386: string = v384_0_1.clone();
                                let v427: Spiral_builder::US15 = if string("") == v386.clone() {
                                    Spiral_builder::US15::US15_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v387.clone(), v388, v389)
                                    ))
                                } else {
                                    let v393: char = getCharAt(v386.clone(), 0_i32);
                                    let v400: string =
                                        getSlice(v386.clone(), Some(1_i32), Some(length(v386)));
                                    let v402: string = ofChar(v393);
                                    let v405: i32 = length(v402.clone());
                                    let v406: Array<char> = new_init(&'\u{0000}', v405);
                                    let v407: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method64(v405, v407.clone()) {
                                        let v409: i32 = v407.l0.get().clone();
                                        let v410: char = getCharAt(v402.clone(), v409);
                                        v406.get_mut()[v409 as usize] = v410;
                                        {
                                            let v411: i32 = v409 + 1_i32;
                                            v407.l0.set(v411);
                                            ()
                                        }
                                    }
                                    {
                                        let v412: List<char> = ofArray(v406.clone());
                                        let patternInput_3:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Spiral_builder::method66(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Spiral_builder::UH0>|
                                                                                                         (Spiral_builder::method65())(b0)(b1)),
                                                                                          v412,
                                                                                          LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                 v387,
                                                                                 v388,
                                                                                 v389);
                                        Spiral_builder::US15::US15_0(
                                            v393,
                                            v400,
                                            patternInput_3.0.clone(),
                                            patternInput_3.1.clone(),
                                            patternInput_3.2.clone(),
                                        )
                                    }
                                };
                                match &v427 {
                                    Spiral_builder::US15::US15_0(
                                        v427_0_0,
                                        v427_0_1,
                                        v427_0_2,
                                        v427_0_3,
                                        v427_0_4,
                                    ) => Spiral_builder::method74(
                                        ofChar(v427_0_0.clone()),
                                        v427_0_1.clone(),
                                        v427_0_2.clone(),
                                        v427_0_3.clone(),
                                        v427_0_4.clone(),
                                    ),
                                    Spiral_builder::US15::US15_1(v427_1_0) => {
                                        Spiral_builder::US16::US16_1(v427_1_0.clone())
                                    }
                                }
                            }
                            Spiral_builder::US20::US20_1(v384_1_0) => {
                                Spiral_builder::US16::US16_1(v384_1_0.clone())
                            }
                        };
                        let v457: Spiral_builder::US21 = match &v445 {
                            Spiral_builder::US16::US16_0(
                                v445_0_0,
                                v445_0_1,
                                v445_0_2,
                                v445_0_3,
                                v445_0_4,
                            ) => Spiral_builder::US21::US21_0(
                                Spiral_builder::US1::US1_0(v445_0_0.clone()),
                                v445_0_1.clone(),
                                v445_0_2.clone(),
                                v445_0_3.clone(),
                                v445_0_4.clone(),
                            ),
                            _ => Spiral_builder::US21::US21_0(
                                Spiral_builder::US1::US1_1,
                                v305,
                                v306,
                                v307,
                                v308,
                            ),
                        };
                        match &v457 {
                            Spiral_builder::US21::US21_0(
                                v457_0_0,
                                v457_0_1,
                                v457_0_2,
                                v457_0_3,
                                v457_0_4,
                            ) => Spiral_builder::US19::US19_0(
                                v303_0_0.clone(),
                                v457_0_0.clone(),
                                v457_0_1.clone(),
                                v457_0_2.clone(),
                                v457_0_3.clone(),
                                v457_0_4.clone(),
                            ),
                            Spiral_builder::US21::US21_1(v457_1_0) => {
                                Spiral_builder::US19::US19_1(v457_1_0.clone())
                            }
                        }
                    }
                    Spiral_builder::US16::US16_1(v303_1_0) => {
                        Spiral_builder::US19::US19_1(v303_1_0.clone())
                    }
                };
                match &v471 {
                    Spiral_builder::US19::US19_0(
                        v471_0_0,
                        v471_0_1,
                        v471_0_2,
                        v471_0_3,
                        v471_0_4,
                        v471_0_5,
                    ) => Spiral_builder::US14::US14_0(v471_0_0.clone(), v471_0_1.clone()),
                    Spiral_builder::US19::US19_1(v471_1_0) => {
                        Spiral_builder::US14::US14_1(v471_1_0.clone())
                    }
                }
            }
        }
        pub fn method77(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method77: loop {
                break '_method77 (if v1_1.get().clone() >= 4_i64 {
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
                        continue '_method77;
                    }
                });
            }
        }
        pub fn method78(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method78: loop {
                break '_method78 ({
                    let v82: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v32: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method77(v25, 0_i64) == false {
                            let v37: string = ofChar(v25);
                            let v40: i32 = length(v37.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method64(v40, v42.clone()) {
                                let v44: i32 = v42.l0.get().clone();
                                let v45: char = getCharAt(v37.clone(), v44);
                                v41.get_mut()[v44 as usize] = v45;
                                {
                                    let v46: i32 = v44 + 1_i32;
                                    v42.l0.set(v46);
                                    ()
                                }
                            }
                            {
                                let v47: List<char> = ofArray(v41.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method66(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method65())(b0)(b1)
                                                },
                                            ),
                                            v47,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v25,
                                    v32,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v82 {
                        Spiral_builder::US15::US15_0(
                            v82_0_0,
                            v82_0_1,
                            v82_0_2,
                            v82_0_3,
                            v82_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v82_0_0.clone()));
                            let v1_1_temp: string = v82_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v82_0_2.clone();
                            let v3_temp: i32 = v82_0_3.clone();
                            let v4_temp: i32 = v82_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method78;
                        }
                        _ => Spiral_builder::US16::US16_0(
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
        pub fn method80(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method80: loop {
                break '_method80 (if v1_1.get().clone() >= 3_i64 {
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
                        continue '_method80;
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
            let v67: Spiral_builder::US15 = if string("") == v0_1.clone() {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\\' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method64(v20, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method66(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method65())(b0)(b1)
                                    }),
                                    v27,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US15::US15_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US15::US15_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v114: Spiral_builder::US15 = match &v67 {
                Spiral_builder::US15::US15_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                    let v72: i32 = v67_0_4.clone();
                    let v71: i32 = v67_0_3.clone();
                    let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                    let v69: string = v67_0_1.clone();
                    if string("") == v69.clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v70.clone(), v71, v72)
                        ))
                    } else {
                        let v76: char = getCharAt(v69.clone(), 0_i32);
                        let v83: string = getSlice(v69.clone(), Some(1_i32), Some(length(v69)));
                        let v85: string = ofChar(v76);
                        let v88: i32 = length(v85.clone());
                        let v89: Array<char> = new_init(&'\u{0000}', v88);
                        let v90: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Spiral_builder::method64(v88, v90.clone()) {
                            let v92: i32 = v90.l0.get().clone();
                            let v93: char = getCharAt(v85.clone(), v92);
                            v89.get_mut()[v92 as usize] = v93;
                            {
                                let v94: i32 = v92 + 1_i32;
                                v90.l0.set(v94);
                                ()
                            }
                        }
                        {
                            let v95: List<char> = ofArray(v89.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method66(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method65())(b0)(b1)
                                            },
                                        ),
                                        v95,
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                    ),
                                    v70,
                                    v71,
                                    v72,
                                );
                            Spiral_builder::US15::US15_0(
                                v76,
                                v83,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Spiral_builder::US15::US15_1(v67_1_0) => {
                    Spiral_builder::US15::US15_1(v67_1_0.clone())
                }
            };
            match &v114 {
                Spiral_builder::US15::US15_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                    Spiral_builder::US16::US16_0(
                        sprintf!("{}{}", '\\', v114_0_0.clone()),
                        v114_0_1.clone(),
                        v114_0_2.clone(),
                        v114_0_3.clone(),
                        v114_0_4.clone(),
                    )
                }
                Spiral_builder::US15::US15_1(v114_1_0) => {
                    Spiral_builder::US16::US16_1(v114_1_0.clone())
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
            let v67: Spiral_builder::US15 = if string("") == v0_1.clone() {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '`' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v20: i32 = length(v17.clone());
                    let v21: Array<char> = new_init(&'\u{0000}', v20);
                    let v22: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method64(v20, v22.clone()) {
                        let v24: i32 = v22.l0.get().clone();
                        let v25: char = getCharAt(v17.clone(), v24);
                        v21.get_mut()[v24 as usize] = v25;
                        {
                            let v26: i32 = v24 + 1_i32;
                            v22.l0.set(v26);
                            ()
                        }
                    }
                    {
                        let v27: List<char> = ofArray(v21.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method66(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method65())(b0)(b1)
                                    }),
                                    v27,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US15::US15_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v43: i32 = length(v0_1.clone());
                    let v46: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US15::US15_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v46 { v43 } else { v46 })
                            )
                        ),
                        append(replicate(v3 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v114: Spiral_builder::US15 = match &v67 {
                Spiral_builder::US15::US15_0(v67_0_0, v67_0_1, v67_0_2, v67_0_3, v67_0_4) => {
                    let v72: i32 = v67_0_4.clone();
                    let v71: i32 = v67_0_3.clone();
                    let v70: LrcPtr<StringBuilder> = v67_0_2.clone();
                    let v69: string = v67_0_1.clone();
                    if string("") == v69.clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v70.clone(), v71, v72)
                        ))
                    } else {
                        let v76: char = getCharAt(v69.clone(), 0_i32);
                        let v83: string = getSlice(v69.clone(), Some(1_i32), Some(length(v69)));
                        let v85: string = ofChar(v76);
                        let v88: i32 = length(v85.clone());
                        let v89: Array<char> = new_init(&'\u{0000}', v88);
                        let v90: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Spiral_builder::method64(v88, v90.clone()) {
                            let v92: i32 = v90.l0.get().clone();
                            let v93: char = getCharAt(v85.clone(), v92);
                            v89.get_mut()[v92 as usize] = v93;
                            {
                                let v94: i32 = v92 + 1_i32;
                                v90.l0.set(v94);
                                ()
                            }
                        }
                        {
                            let v95: List<char> = ofArray(v89.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method66(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method65())(b0)(b1)
                                            },
                                        ),
                                        v95,
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                    ),
                                    v70,
                                    v71,
                                    v72,
                                );
                            Spiral_builder::US15::US15_0(
                                v76,
                                v83,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Spiral_builder::US15::US15_1(v67_1_0) => {
                    Spiral_builder::US15::US15_1(v67_1_0.clone())
                }
            };
            match &v114 {
                Spiral_builder::US15::US15_0(v114_0_0, v114_0_1, v114_0_2, v114_0_3, v114_0_4) => {
                    Spiral_builder::US16::US16_0(
                        sprintf!("{}{}", '`', v114_0_0.clone()),
                        v114_0_1.clone(),
                        v114_0_2.clone(),
                        v114_0_3.clone(),
                        v114_0_4.clone(),
                    )
                }
                Spiral_builder::US15::US15_1(v114_1_0) => {
                    Spiral_builder::US16::US16_1(v114_1_0.clone())
                }
            }
        }
        pub fn method81(
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
            '_method81: loop {
                break '_method81 (match v4.get().clone().as_ref() {
                    Spiral_builder::UH3::UH3_0 => {
                        Spiral_builder::US16::US16_1(string("choice / no parsers succeeded"))
                    }
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
                                continue '_method81;
                            }
                        }
                    }
                });
            }
        }
        pub fn method82(
            v0_1: LrcPtr<Spiral_builder::UH2>,
            v1_1: LrcPtr<Spiral_builder::UH2>,
        ) -> LrcPtr<Spiral_builder::UH2> {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v1_1.clone());
            '_method82: loop {
                break '_method82 (match v0_1.get().clone().as_ref() {
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
                        continue '_method82;
                    }
                });
            }
        }
        pub fn method79(
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
            '_method79: loop {
                break '_method79 ({
                    let v76: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v29: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method80(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method64(v37, v39.clone()) {
                                let v41: i32 = v39.l0.get().clone();
                                let v42: char = getCharAt(v34.clone(), v41);
                                v38.get_mut()[v41 as usize] = v42;
                                {
                                    let v43: i32 = v41 + 1_i32;
                                    v39.l0.set(v43);
                                    ()
                                }
                            }
                            {
                                let v44: List<char> = ofArray(v38.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method66(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method65())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v90: Spiral_builder::US16 = match &v76 {
                        Spiral_builder::US15::US15_0(
                            v76_0_0,
                            v76_0_1,
                            v76_0_2,
                            v76_0_3,
                            v76_0_4,
                        ) => Spiral_builder::US16::US16_0(
                            ofChar(v76_0_0.clone()),
                            v76_0_1.clone(),
                            v76_0_2.clone(),
                            v76_0_3.clone(),
                            v76_0_4.clone(),
                        ),
                        Spiral_builder::US15::US15_1(v76_1_0) => {
                            Spiral_builder::US16::US16_1(v76_1_0.clone())
                        }
                    };
                    let v104: Spiral_builder::US16 = match &v90 {
                        Spiral_builder::US16::US16_0(
                            v90_0_0,
                            v90_0_1,
                            v90_0_2,
                            v90_0_3,
                            v90_0_4,
                        ) => v90.clone(),
                        _ => Spiral_builder::method81(
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
                    match &v104 {
                        Spiral_builder::US16::US16_0(
                            v104_0_0,
                            v104_0_1,
                            v104_0_2,
                            v104_0_3,
                            v104_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH2> = LrcPtr::new(
                                Spiral_builder::UH2::UH2_1(v104_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v104_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v104_0_2.clone();
                            let v3_temp: i32 = v104_0_3.clone();
                            let v4_temp: i32 = v104_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method79;
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method82(
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
        pub fn method83(v0_1: LrcPtr<Spiral_builder::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Spiral_builder::UH2::UH2_0 => v1_1.clone(),
                Spiral_builder::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Spiral_builder::method83(
                        match v0_1.as_ref() {
                            Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method84(
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
            '_method84: loop {
                break '_method84 ({
                    let v76: Spiral_builder::US15 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v22: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v29: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method80(v22, 0_i64) == false {
                            let v34: string = ofChar(v22);
                            let v37: i32 = length(v34.clone());
                            let v38: Array<char> = new_init(&'\u{0000}', v37);
                            let v39: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method64(v37, v39.clone()) {
                                let v41: i32 = v39.l0.get().clone();
                                let v42: char = getCharAt(v34.clone(), v41);
                                v38.get_mut()[v41 as usize] = v42;
                                {
                                    let v43: i32 = v41 + 1_i32;
                                    v39.l0.set(v43);
                                    ()
                                }
                            }
                            {
                                let v44: List<char> = ofArray(v38.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method66(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method65())(b0)(b1)
                                                },
                                            ),
                                            v44,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v22,
                                    v29,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v22,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v90: Spiral_builder::US16 = match &v76 {
                        Spiral_builder::US15::US15_0(
                            v76_0_0,
                            v76_0_1,
                            v76_0_2,
                            v76_0_3,
                            v76_0_4,
                        ) => Spiral_builder::US16::US16_0(
                            ofChar(v76_0_0.clone()),
                            v76_0_1.clone(),
                            v76_0_2.clone(),
                            v76_0_3.clone(),
                            v76_0_4.clone(),
                        ),
                        Spiral_builder::US15::US15_1(v76_1_0) => {
                            Spiral_builder::US16::US16_1(v76_1_0.clone())
                        }
                    };
                    match &v90 {
                        Spiral_builder::US16::US16_0(
                            v90_0_0,
                            v90_0_1,
                            v90_0_2,
                            v90_0_3,
                            v90_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH2> = LrcPtr::new(
                                Spiral_builder::UH2::UH2_1(v90_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v90_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v90_0_2.clone();
                            let v3_temp: i32 = v90_0_3.clone();
                            let v4_temp: i32 = v90_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method84;
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method82(
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
        pub fn method85(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method85: loop {
                break '_method85 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method85;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method76(
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
            '_method76: loop {
                break '_method76 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v82: Spiral_builder::US15 = if v5 {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v32: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method77(v25, 0_i64) == false {
                            let v37: string = ofChar(v25);
                            let v40: i32 = length(v37.clone());
                            let v41: Array<char> = new_init(&'\u{0000}', v40);
                            let v42: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method64(v40, v42.clone()) {
                                let v44: i32 = v42.l0.get().clone();
                                let v45: char = getCharAt(v37.clone(), v44);
                                v41.get_mut()[v44 as usize] = v45;
                                {
                                    let v46: i32 = v44 + 1_i32;
                                    v42.l0.set(v46);
                                    ()
                                }
                            }
                            {
                                let v47: List<char> = ofArray(v41.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method66(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method65())(b0)(b1)
                                                },
                                            ),
                                            v47,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US15::US15_0(
                                    v25,
                                    v32,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v96: Spiral_builder::US16 = match &v82 {
                        Spiral_builder::US15::US15_0(
                            v82_0_0,
                            v82_0_1,
                            v82_0_2,
                            v82_0_3,
                            v82_0_4,
                        ) => Spiral_builder::method78(
                            ofChar(v82_0_0.clone()),
                            v82_0_1.clone(),
                            v82_0_2.clone(),
                            v82_0_3.clone(),
                            v82_0_4.clone(),
                        ),
                        Spiral_builder::US15::US15_1(v82_1_0) => {
                            Spiral_builder::US16::US16_1(v82_1_0.clone())
                        }
                    };
                    let v341: Spiral_builder::US16 = match &v96 {
                        Spiral_builder::US16::US16_0(
                            v96_0_0,
                            v96_0_1,
                            v96_0_2,
                            v96_0_3,
                            v96_0_4,
                        ) => v96.clone(),
                        _ => {
                            let v165: Spiral_builder::US15 = if v5 {
                                Spiral_builder::US15::US15_1(sprintf!(
                                    "parsing.p_char / unexpected end of input / s: {:?}",
                                    (v2.get().clone(), v3.get().clone(), v4.get().clone())
                                ))
                            } else {
                                let v105: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if v105 == '\"' {
                                    let v113: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some(length(v1_1.get().clone())),
                                    );
                                    let v115: string = ofChar(v105);
                                    let v118: i32 = length(v115.clone());
                                    let v119: Array<char> = new_init(&'\u{0000}', v118);
                                    let v120: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method64(v118, v120.clone()) {
                                        let v122: i32 = v120.l0.get().clone();
                                        let v123: char = getCharAt(v115.clone(), v122);
                                        v119.get_mut()[v122 as usize] = v123;
                                        {
                                            let v124: i32 = v122 + 1_i32;
                                            v120.l0.set(v124);
                                            ()
                                        }
                                    }
                                    {
                                        let v125: List<char> = ofArray(v119.clone());
                                        let patternInput_1:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Spiral_builder::method66(foldBack(Func2::new(move
                                                                                                              |b0:
                                                                                                                   char,
                                                                                                               b1:
                                                                                                                   LrcPtr<Spiral_builder::UH0>|
                                                                                                              (Spiral_builder::method65())(b0)(b1)),
                                                                                               v125,
                                                                                               LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                      v2.get().clone(),
                                                                                      v3.get().clone(),
                                                                                      v4.get().clone());
                                        Spiral_builder::US15::US15_0(
                                            v105,
                                            v113,
                                            patternInput_1.0.clone(),
                                            patternInput_1.1.clone(),
                                            patternInput_1.2.clone(),
                                        )
                                    }
                                } else {
                                    let v141: i32 = length(v1_1.get().clone());
                                    let v144: i32 =
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
                                                                                                                         v144
                                                                                                                     {
                                                                                                                      v141
                                                                                                                  } else {
                                                                                                                      v144
                                                                                                                  }))),
                                                                                           append(replicate(v4.get().clone()
                                                                                                                -
                                                                                                                1_i32,
                                                                                                            string(" ")),
                                                                                                  string("^"))))
                                }
                            };
                            let v282: Spiral_builder::US16 = match &v165 {
                                Spiral_builder::US15::US15_0(
                                    v165_0_0,
                                    v165_0_1,
                                    v165_0_2,
                                    v165_0_3,
                                    v165_0_4,
                                ) => {
                                    let v170: i32 = v165_0_4.clone();
                                    let v169: i32 = v165_0_3.clone();
                                    let v168: LrcPtr<StringBuilder> = v165_0_2.clone();
                                    let v167: string = v165_0_1.clone();
                                    let v172: Spiral_builder::US23 = Spiral_builder::method79(
                                        LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        v167.clone(),
                                        v168.clone(),
                                        v169,
                                        v170,
                                    );
                                    let v193: Spiral_builder::US16 = match &v172 {
                                        Spiral_builder::US23::US23_0(
                                            v172_0_0,
                                            v172_0_1,
                                            v172_0_2,
                                            v172_0_3,
                                            v172_0_4,
                                        ) => {
                                            let v179: List<string> = Spiral_builder::method83(
                                                v172_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v179 = v179.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v179 = v179.clone();
                                                                    move |i: i32| {
                                                                        item(i, v179.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v179.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v172_0_1.clone(),
                                                v172_0_2.clone(),
                                                v172_0_3.clone(),
                                                v172_0_4.clone(),
                                            )
                                        }
                                        Spiral_builder::US23::US23_1(v172_1_0) => {
                                            Spiral_builder::US16::US16_1(v172_1_0.clone())
                                        }
                                    };
                                    match &v193 {
                                        Spiral_builder::US16::US16_0(
                                            v193_0_0,
                                            v193_0_1,
                                            v193_0_2,
                                            v193_0_3,
                                            v193_0_4,
                                        ) => {
                                            let v198: i32 = v193_0_4.clone();
                                            let v197: i32 = v193_0_3.clone();
                                            let v196: LrcPtr<StringBuilder> = v193_0_2.clone();
                                            let v195: string = v193_0_1.clone();
                                            let v262: Spiral_builder::US15 = if string("")
                                                == v195.clone()
                                            {
                                                Spiral_builder::US15::US15_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
                                                                                                           (v196.clone(),
                                                                                                            v197,
                                                                                                            v198)))
                                            } else {
                                                let v202: char = getCharAt(v195.clone(), 0_i32);
                                                if v202 == '\"' {
                                                    let v210: string = getSlice(
                                                        v195.clone(),
                                                        Some(1_i32),
                                                        Some(length(v195.clone())),
                                                    );
                                                    let v212: string = ofChar(v202);
                                                    let v215: i32 = length(v212.clone());
                                                    let v216: Array<char> =
                                                        new_init(&'\u{0000}', v215);
                                                    let v217: LrcPtr<Spiral_builder::Mut5> =
                                                        LrcPtr::new(Spiral_builder::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Spiral_builder::method64(
                                                        v215,
                                                        v217.clone(),
                                                    ) {
                                                        let v219: i32 = v217.l0.get().clone();
                                                        let v220: char =
                                                            getCharAt(v212.clone(), v219);
                                                        v216.get_mut()[v219 as usize] = v220;
                                                        {
                                                            let v221: i32 = v219 + 1_i32;
                                                            v217.l0.set(v221);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v222: List<char> =
                                                            ofArray(v216.clone());
                                                        let patternInput_2:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Spiral_builder::method66(foldBack(Func2::new(move
                                                                                                                                  |b0:
                                                                                                                                       char,
                                                                                                                                   b1:
                                                                                                                                       LrcPtr<Spiral_builder::UH0>|
                                                                                                                                  (Spiral_builder::method65())(b0)(b1)),
                                                                                                                   v222,
                                                                                                                   LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                                          v196.clone(),
                                                                                                          v197,
                                                                                                          v198);
                                                        Spiral_builder::US15::US15_0(
                                                            v202,
                                                            v210,
                                                            patternInput_2.0.clone(),
                                                            patternInput_2.1.clone(),
                                                            patternInput_2.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v238: i32 = length(v195.clone());
                                                    let v241: i32 =
                                                        indexOf(v195.clone(), string("\n")) - 1_i32;
                                                    Spiral_builder::US15::US15_1(sprintf!("{}\n{}\n",
                                                                                                               sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                        '\"',
                                                                                                                        v197,
                                                                                                                        v198,
                                                                                                                        v196.clone(),
                                                                                                                        getSlice(v195.clone(),
                                                                                                                                 Some(0_i32),
                                                                                                                                 Some(if -2_i32
                                                                                                                                             ==
                                                                                                                                             v241
                                                                                                                                         {
                                                                                                                                          v238
                                                                                                                                      } else {
                                                                                                                                          v241
                                                                                                                                      }))),
                                                                                                               append(replicate(v198
                                                                                                                                    -
                                                                                                                                    1_i32,
                                                                                                                                string(" ")),
                                                                                                                      string("^"))))
                                                }
                                            };
                                            match &v262 {
                                                                 Spiral_builder::US15::US15_0(v262_0_0,
                                                                                              v262_0_1,
                                                                                              v262_0_2,
                                                                                              v262_0_3,
                                                                                              v262_0_4)
                                                                 =>
                                                                 Spiral_builder::US16::US16_0(v193_0_0.clone(),
                                                                                              v262_0_1.clone(),
                                                                                              v262_0_2.clone(),
                                                                                              v262_0_3.clone(),
                                                                                              v262_0_4.clone()),
                                                                 Spiral_builder::US15::US15_1(v262_1_0)
                                                                 =>
                                                                 Spiral_builder::US16::US16_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                       v262_1_0.clone(),
                                                                                                       (v1_1.get().clone(),
                                                                                                        v2.get().clone(),
                                                                                                        v3.get().clone(),
                                                                                                        v4.get().clone()),
                                                                                                       (v167,
                                                                                                        v168,
                                                                                                        v169,
                                                                                                        v170),
                                                                                                       (v195,
                                                                                                        v196,
                                                                                                        v197,
                                                                                                        v198))),
                                                             }
                                        }
                                        _ => Spiral_builder::US16::US16_1(string(
                                            "between / expected content",
                                        )),
                                    }
                                }
                                Spiral_builder::US15::US15_1(v165_1_0) => {
                                    Spiral_builder::US16::US16_1(v165_1_0.clone())
                                }
                            };
                            match &v282 {
                                Spiral_builder::US16::US16_0(
                                    v282_0_0,
                                    v282_0_1,
                                    v282_0_2,
                                    v282_0_3,
                                    v282_0_4,
                                ) => v282.clone(),
                                _ => {
                                    let v294:
                                                         Spiral_builder::US16 =
                                                     Spiral_builder::method81(v1_1.get().clone(),
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
                                    let v305: Spiral_builder::US16 = match &v294 {
                                        Spiral_builder::US16::US16_0(
                                            v294_0_0,
                                            v294_0_1,
                                            v294_0_2,
                                            v294_0_3,
                                            v294_0_4,
                                        ) => Spiral_builder::US16::US16_0(
                                            string(""),
                                            v294_0_1.clone(),
                                            v294_0_2.clone(),
                                            v294_0_3.clone(),
                                            v294_0_4.clone(),
                                        ),
                                        Spiral_builder::US16::US16_1(v294_1_0) => {
                                            Spiral_builder::US16::US16_1(v294_1_0.clone())
                                        }
                                    };
                                    let v316: Spiral_builder::US23 = match &v305 {
                                        Spiral_builder::US16::US16_0(
                                            v305_0_0,
                                            v305_0_1,
                                            v305_0_2,
                                            v305_0_3,
                                            v305_0_4,
                                        ) => Spiral_builder::method84(
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                            v305_0_1.clone(),
                                            v305_0_2.clone(),
                                            v305_0_3.clone(),
                                            v305_0_4.clone(),
                                        ),
                                        Spiral_builder::US16::US16_1(v305_1_0) => {
                                            Spiral_builder::US23::US23_1(v305_1_0.clone())
                                        }
                                    };
                                    match &v316 {
                                        Spiral_builder::US23::US23_0(
                                            v316_0_0,
                                            v316_0_1,
                                            v316_0_2,
                                            v316_0_3,
                                            v316_0_4,
                                        ) => {
                                            let v323: List<string> = Spiral_builder::method83(
                                                v316_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v323 = v323.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v323 = v323.clone();
                                                                    move |i_1: i32| {
                                                                        item(i_1, v323.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v323.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v316_0_1.clone(),
                                                v316_0_2.clone(),
                                                v316_0_3.clone(),
                                                v316_0_4.clone(),
                                            )
                                        }
                                        Spiral_builder::US23::US23_1(v316_1_0) => {
                                            Spiral_builder::US16::US16_1(v316_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v341 {
                        Spiral_builder::US16::US16_0(
                            v341_0_0,
                            v341_0_1,
                            v341_0_2,
                            v341_0_3,
                            v341_0_4,
                        ) => {
                            let v350: i32 = v341_0_4.clone();
                            let v349: i32 = v341_0_3.clone();
                            let v348: LrcPtr<StringBuilder> = v341_0_2.clone();
                            let v347: string = v341_0_1.clone();
                            let v346: string = v341_0_0.clone();
                            let v352: i32 = Spiral_builder::method85(v347.clone(), 0_i32);
                            let v364: Spiral_builder::US18 = if 0_i32 == v352 {
                                Spiral_builder::US18::US18_1(string(
                                    "spaces1 / expected at least one space",
                                ))
                            } else {
                                Spiral_builder::US18::US18_0(
                                    getSlice(v347.clone(), Some(v352), Some(length(v347.clone()))),
                                    v348.clone(),
                                    v349,
                                    v350,
                                )
                            };
                            match &v364 {
                                Spiral_builder::US18::US18_0(
                                    v364_0_0,
                                    v364_0_1,
                                    v364_0_2,
                                    v364_0_3,
                                ) => {
                                    let v0_1_temp: LrcPtr<Spiral_builder::UH2> =
                                        LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                            v346.clone(),
                                            v0_1.get().clone(),
                                        ));
                                    let v1_1_temp: string = v364_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v364_0_1.clone();
                                    let v3_temp: i32 = v364_0_2.clone();
                                    let v4_temp: i32 = v364_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method76;
                                }
                                _ => Spiral_builder::US23::US23_0(
                                    Spiral_builder::method82(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                            v346.clone(),
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        )),
                                    ),
                                    v347,
                                    v348,
                                    v349,
                                    v350,
                                ),
                            }
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method82(
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
        pub fn method75(v0_1: string) -> Spiral_builder::US22 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v15: Spiral_builder::US23 = Spiral_builder::method76(
                    LrcPtr::new(Spiral_builder::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(string("")),
                    1_i32,
                    1_i32,
                );
                match &v15 {
                    Spiral_builder::US23::US23_0(v15_0_0, v15_0_1, v15_0_2, v15_0_3, v15_0_4) => {
                        Spiral_builder::US22::US22_0(toArray(Spiral_builder::method83(
                            v15_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Spiral_builder::US23::US23_1(v15_1_0) => {
                        Spiral_builder::US22::US22_1(v15_1_0.clone())
                    }
                }
            }
        }
        pub fn method86(
            v0_1: string,
            v1_1: Vec<std::string::String>,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
            let v74: std::string::String = format!("{:#?}", v1_1);
            let v104: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v74)),
                    (),
                );
                ()
            };
            let v112: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v121: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("options")), ());
                ()
            };
            let v129: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v137: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v146: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("command")), ());
                ()
            };
            let v154: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v162: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v170: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v179: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("cancellation_token")),
                    (),
                );
                ()
            };
            let v187: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v192: std::string::String = format!("{:#?}", v3);
            let v222: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v192)),
                    (),
                );
                ()
            };
            let v230: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v239: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("environment_variables")),
                    (),
                );
                ()
            };
            let v247: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v258: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", sprintf!("{:?}", v4)), ());
                ()
            };
            let v266: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v275: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("on_line")), ());
                ()
            };
            let v283: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v288: std::string::String = format!("{:#?}", v5);
            let v318: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v288)),
                    (),
                );
                ()
            };
            let v326: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v335: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v343: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v348: std::string::String = format!("{:#?}", v6);
            let v378: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v348)),
                    (),
                );
                ()
            };
            let v386: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v395: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v403: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v414: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", if v7 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v422: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v431: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", string("working_directory")),
                    (),
                );
                ()
            };
            let v439: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v444: std::string::String = format!("{:#?}", v8);
            let v474: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v444)),
                    (),
                );
                ()
            };
            let v483: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v491: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v10.l0.get().clone()
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
            fn v10() {
                Spiral_builder::closure2((), ());
            }
            let v11: () = {
                v10();
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
            let v43: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v43,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v50: () = {
                    v10();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v64: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v90: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v64.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("runtime.execute_with_options"),
                    v64.l0.get().clone(),
                    Spiral_builder::method86(v7, v8, v0_1, v1_1, v2, v3, v4, v5, v6),
                );
                let v92: () = {
                    v10();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v90,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure33(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Spiral_builder::US24 {
            Spiral_builder::US24::US24_0(v0_1)
        }
        pub fn method87() -> Func1<
            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
            Spiral_builder::US24,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Spiral_builder::closure33((), v)
                },
            )
        }
        pub fn closure34(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US24 {
            Spiral_builder::US24::US24_1(v0_1)
        }
        pub fn method88() -> Func1<std::string::String, Spiral_builder::US24> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure34((), v))
        }
        pub fn method89(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
            let v62: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure35(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    string("runtime.execute_with_options / child error"),
                    v56.l0.get().clone(),
                    Spiral_builder::method89(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure36(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US26 {
            Spiral_builder::US26::US26_0(v0_1)
        }
        pub fn method90() -> Func1<std::string::String, Spiral_builder::US26> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure36((), v))
        }
        pub fn closure37(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US26 {
            Spiral_builder::US26::US26_1(v0_1)
        }
        pub fn method91() -> Func1<std::string::String, Spiral_builder::US26> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure37((), v))
        }
        pub fn method92(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string("e")), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v62: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure38(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    string("runtime.stdio_line"),
                    v56.l0.get().clone(),
                    Spiral_builder::method92(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method93() -> string {
            let v1_1: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            v1_1.l0.get().clone()
        }
        pub fn closure39(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = if v0_1.clone() == string("") {
                    string("")
                } else {
                    Spiral_builder::method15(
                        Spiral_builder::method7(
                            v56.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                            patternInput_1.3.clone(),
                            patternInput_1.4.clone(),
                            patternInput_1.5.clone(),
                        ),
                        Spiral_builder::method47(),
                        v0_1,
                        v56.l0.get().clone(),
                        Spiral_builder::method93(),
                    )
                };
                let v83: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure40(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method94(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Spiral_builder::closure40((), v)
            })
        }
        pub fn method95(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure41(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Spiral_builder::US27 {
            Spiral_builder::US27::US27_0(v0_1)
        }
        pub fn method96() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Spiral_builder::US27,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Spiral_builder::closure41((), v)
                },
            )
        }
        pub fn closure42(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Spiral_builder::US28 {
            Spiral_builder::US28::US28_0(v0_1)
        }
        pub fn method97(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Spiral_builder::US28>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Spiral_builder::closure42((), v)
                },
            )
        }
        pub fn method98(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method99(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure43(unitVar: (), v0_1: std::process::Output) -> Spiral_builder::US29 {
            Spiral_builder::US29::US29_0(v0_1)
        }
        pub fn closure44(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US29 {
            Spiral_builder::US29::US29_1(v0_1)
        }
        pub fn closure45(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    string("runtime.execute_with_options / output error"),
                    v56.l0.get().clone(),
                    Spiral_builder::method89(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure46(unitVar: (), v0_1: i32) -> Spiral_builder::US30 {
            Spiral_builder::US30::US30_0(v0_1)
        }
        pub fn method100() -> Func1<i32, Spiral_builder::US30> {
            Func1::new(move |v: i32| Spiral_builder::closure46((), v))
        }
        pub fn method101(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure47(v0_1: i32, v1_1: string, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v84: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method47(),
                    string("runtime.execute_with_options / result"),
                    v57.l0.get().clone(),
                    Spiral_builder::method101(v0_1, length(v1_1)),
                );
                let v86: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method103(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> string {
            let v8: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v15: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v24: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("options")), ());
                ()
            };
            let v33: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v41: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("{ ")), ());
                ()
            };
            let v50: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("command")), ());
                ()
            };
            let v58: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v66: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v75: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v84: () = {
                Spiral_builder::closure7(
                    v8.clone(),
                    sprintf!("{}", string("cancellation_token")),
                    (),
                );
                ()
            };
            let v92: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v97: std::string::String = format!("{:#?}", v1_1);
            let v127: () = {
                Spiral_builder::closure7(
                    v8.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v97)),
                    (),
                );
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v144: () = {
                Spiral_builder::closure7(
                    v8.clone(),
                    sprintf!("{}", string("environment_variables")),
                    (),
                );
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v163: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", sprintf!("{:?}", v2)), ());
                ()
            };
            let v171: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v180: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("on_line")), ());
                ()
            };
            let v188: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v193: std::string::String = format!("{:#?}", v3);
            let v223: () = {
                Spiral_builder::closure7(
                    v8.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v193)),
                    (),
                );
                ()
            };
            let v231: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v240: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("stdin")), ());
                ()
            };
            let v248: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v253: std::string::String = format!("{:#?}", v4);
            let v283: () = {
                Spiral_builder::closure7(
                    v8.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v253)),
                    (),
                );
                ()
            };
            let v291: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v300: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("trace")), ());
                ()
            };
            let v308: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v319: () = {
                Spiral_builder::closure7(
                    v8.clone(),
                    sprintf!("{}", if v5 { string("true") } else { string("false") }),
                    (),
                );
                ()
            };
            let v327: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v336: () = {
                Spiral_builder::closure7(
                    v8.clone(),
                    sprintf!("{}", string("working_directory")),
                    (),
                );
                ()
            };
            let v344: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v349: std::string::String = format!("{:#?}", v6);
            let v379: () = {
                Spiral_builder::closure7(
                    v8.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v349)),
                    (),
                );
                ()
            };
            let v388: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            let v396: () = {
                Spiral_builder::closure7(v8.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v8.l0.get().clone()
        }
        pub fn closure48(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            unitVar: (),
        ) {
            fn v8() {
                Spiral_builder::closure2((), ());
            }
            let v9: () = {
                v8();
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
            let v41: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v41,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v48: () = {
                    v8();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v62: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v88: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v62.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("runtime.execute_with_options_async"),
                    v62.l0.get().clone(),
                    Spiral_builder::method103(v0_1, v1_1, v2, v3, v4, v5, v6),
                );
                let v90: () = {
                    v8();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v88,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure50(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Spiral_builder::US31 {
            Spiral_builder::US31::US31_0(v0_1)
        }
        pub fn method104() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Spiral_builder::US31>
        {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Spiral_builder::closure50((), v)
            })
        }
        pub fn closure51(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = if v0_1.clone() == string("") {
                    string("")
                } else {
                    Spiral_builder::method15(
                        Spiral_builder::method7(
                            v56.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                            patternInput_1.3.clone(),
                            patternInput_1.4.clone(),
                            patternInput_1.5.clone(),
                        ),
                        Spiral_builder::method47(),
                        v0_1,
                        v56.l0.get().clone(),
                        Spiral_builder::method93(),
                    )
                };
                let v83: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure49(
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
        pub fn closure52(
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
        pub fn closure53(unitVar: (), v0_1: CancellationToken) -> Spiral_builder::US32 {
            Spiral_builder::US32::US32_0(v0_1)
        }
        pub fn method105() -> Func1<CancellationToken, Spiral_builder::US32> {
            Func1::new(move |v: CancellationToken| Spiral_builder::closure53((), v))
        }
        pub fn closure54(v0_1: (), unitVar: ()) {
            if unbox::<bool>(&defaultOf()) == false {
                ();
                ()
            };
        }
        pub fn method106(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
            let v62: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v32)),
                    (),
                );
                ()
            };
            let v71: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure55(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                3_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method33(),
                    string("runtime.execute_with_options_async / WaitForExitAsync"),
                    v56.l0.get().clone(),
                    Spiral_builder::method106(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method107(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure56(v0_1: i32, v1_1: string, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v84: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("runtime.execute_with_options_async"),
                    v57.l0.get().clone(),
                    Spiral_builder::method107(v0_1, length(v1_1)),
                );
                let v86: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method102(
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
        pub fn method61(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v9: Spiral_builder::US14 = Spiral_builder::method63(Spiral_builder::method62(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Spiral_builder::US1) = match &v9 {
                Spiral_builder::US14::US14_0(v9_0_0, v9_0_1) => (v9_0_0.clone(), v9_0_1.clone()),
                Spiral_builder::US14::US14_1(v9_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v9_1_0.clone()),
                ),
            };
            let v19: Spiral_builder::US1 = patternInput.1.clone();
            let v18: string = patternInput.0.clone();
            let v24: Spiral_builder::US22 = Spiral_builder::method75(match &v19 {
                Spiral_builder::US1::US1_0(v19_0_0) => match &v19 {
                    Spiral_builder::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            });
            let v30: Array<string> = match &v24 {
                Spiral_builder::US22::US22_0(v24_0_0) => v24_0_0.clone(),
                Spiral_builder::US22::US22_1(v24_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v24_1_0.clone()),
                ),
            };
            let v32: Vec<string> = v30.to_vec();
            let v34: bool = true;
            let _vec_map: Vec<_> = v32
                .into_iter()
                .map(|x| {
                    //;
                    let v36: string = x;
                    let v38: &str = &*v36;
                    let v40: std::string::String = String::from(v38);
                    let v42: bool = true;
                    v40
                })
                .collect::<Vec<_>>();
            let v44: Vec<std::string::String> = _vec_map;
            let v47: () = {
                Spiral_builder::closure32(
                    v0_1,
                    v1_1,
                    v2.clone(),
                    v3,
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v18.clone(),
                    v44.clone(),
                    (),
                );
                ()
            };
            let _v163: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_3: LrcPtr<(i32, string)> = (Func0::new({
                    let v18 = v18.clone();
                    let v2 = v2.clone();
                    let v4 = v4.clone();
                    let v44 = v44.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    move || {
                        let v165: std::process::Command = std::process::Command::new(&*v18.clone());
                        let v167: bool = true;
                        let mut v165 = v165;
                        let v169: &mut std::process::Command =
                            std::process::Command::args(&mut v165, &*v44.clone());
                        let v171: std::process::Stdio = std::process::Stdio::piped();
                        let v173: &mut std::process::Command =
                            std::process::Command::stdout(v169, std::process::Stdio::piped());
                        let v175: std::process::Stdio = std::process::Stdio::piped();
                        let v177: &mut std::process::Command =
                            std::process::Command::stderr(v173, std::process::Stdio::piped());
                        let v179: std::process::Stdio = std::process::Stdio::piped();
                        let v181: &mut std::process::Command =
                            std::process::Command::stdin(v177, std::process::Stdio::piped());
                        let v195: Spiral_builder::US1 = defaultValue(
                            Spiral_builder::US1::US1_1,
                            map(Spiral_builder::method5(), v6.clone()),
                        );
                        let v203: &mut std::process::Command = match &v195 {
                            Spiral_builder::US1::US1_0(v195_0_0) => {
                                std::process::Command::current_dir(
                                    v181,
                                    &*match &v195 {
                                        Spiral_builder::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                )
                            }
                            _ => v181,
                        };
                        let v221: &mut std::process::Command = if count_2(v2.clone()) as u64
                            == 0_u64
                        {
                            v203
                        } else {
                            let v207: Vec<(string, string)> = v2.clone().to_vec();
                            let v209: bool = true;
                            let _vec_fold_ = v207.into_iter().fold(v203, |acc, x| {
                                //;
                                let v211: &mut std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v216: &mut std::process::Command = std::process::Command::env(
                                    v211,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v218: bool = true;
                                v216
                            });
                            _vec_fold_
                        };
                        let v223: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(v221);
                        let v224 = Spiral_builder::method43();
                        let v226: Result<std::process::Child, std::string::String> =
                            v223.map_err(|x| v224(x));
                        let v228: bool = true;
                        let _result_map_ = v226.map(|x| {
                            //;
                            let v230: std::process::Child = x;
                            let v235: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(Some(v230));
                            let v237: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v235);
                            let v239: bool = true;
                            v237
                        });
                        let v241: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v242 = Spiral_builder::method87();
                        let v243 = Spiral_builder::method88();
                        let v245: Spiral_builder::US24 = match v241 {
                            Ok(x) => v242(x),
                            Err(e) => v243(e),
                        };
                        let patternInput_3: (i32, Spiral_builder::US5, Spiral_builder::US25) =
                            match &v245 {
                                Spiral_builder::US24::US24_0(v245_0_0) => {
                                    let v246: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v245_0_0.clone();
                                    let v248: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v250: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v246.clone();
                                        let v252: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v250.lock();
                                        let v254: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = v252.unwrap();
                                        let v256: bool = true;
                                        let mut v254 = v254;
                                        let v258: &mut Option<std::process::Child> = &mut v254;
                                        let v260: Option<&mut std::process::Child> = v258.as_mut();
                                        let v262: &mut std::process::Child = v260.unwrap();
                                        let v264: &mut Option<std::process::ChildStdout> =
                                            &mut v262.stdout;
                                        let v266: Option<std::process::ChildStdout> =
                                            Option::take(v264);
                                        let v268: std::process::ChildStdout = v266.unwrap();
                                        let v270: bool = true;
                                        v268
                                    })();
                                    let v272: std::process::ChildStdout = _capture;
                                    let v274: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v276: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v246.clone();
                                        let v278: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v276.lock();
                                        let v280: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = v278.unwrap();
                                        let v282: bool = true;
                                        let mut v280 = v280;
                                        let v284: &mut Option<std::process::Child> = &mut v280;
                                        let v286: Option<&mut std::process::Child> = v284.as_mut();
                                        let v288: &mut std::process::Child = v286.unwrap();
                                        let v290: &mut Option<std::process::ChildStderr> =
                                            &mut v288.stderr;
                                        let v292: Option<std::process::ChildStderr> =
                                            Option::take(v290);
                                        let v294: std::process::ChildStderr = v292.unwrap();
                                        let v296: bool = true;
                                        v294
                                    })();
                                    let v298: std::process::ChildStderr = _capture;
                                    let v300: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v302: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v246.clone();
                                        let v304: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v302.lock();
                                        let v306: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = v304.unwrap();
                                        let v308: bool = true;
                                        let mut v306 = v306;
                                        let v310: &mut Option<std::process::Child> = &mut v306;
                                        let v312: Option<&mut std::process::Child> = v310.as_mut();
                                        let v314: &mut std::process::Child = v312.unwrap();
                                        let v316: &mut Option<std::process::ChildStdin> =
                                            &mut v314.stdin;
                                        let v318: Option<std::process::ChildStdin> =
                                            Option::take(v316);
                                        let v320: std::process::ChildStdin = v318.unwrap();
                                        let v325: std::sync::Mutex<
                                            Option<std::process::ChildStdin>,
                                        > = std::sync::Mutex::new(Some(v320));
                                        let v327: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = std::sync::Arc::new(v325);
                                        let v329: bool = true;
                                        v327
                                    })();
                                    let v331: std::sync::Arc<
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
                                    let v333: std::sync::mpsc::Sender<std::string::String> =
                                        patternInput_2.0.clone();
                                    let v336: std::sync::Mutex<
                                        std::sync::mpsc::Sender<std::string::String>,
                                    > = std::sync::Mutex::new(v333.clone());
                                    let v338: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        >,
                                    > = std::sync::Arc::new(v336);
                                    let v340: std::sync::Mutex<
                                        std::sync::mpsc::Sender<std::string::String>,
                                    > = std::sync::Mutex::new(v333);
                                    let v342: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        >,
                                    > = std::sync::Arc::new(v340);
                                    let v344: std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = std::sync::Mutex::new(patternInput_2.1.clone());
                                    let v346: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = std::sync::Arc::new(v344);
                                    let v348: bool = true;
                                    let __spawn = std::thread::spawn(move || {
                                        //;
                                        let v350: encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                            .utf8_passthru(true)
                                            .build(v272);
                                        let v352: std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        > = std::io::BufReader::new(v350);
                                        let v354: std::io::Lines<
                                            std::io::BufReader<
                                                encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStdout,
                                                    Vec<u8>,
                                                >,
                                            >,
                                        > = std::io::BufRead::lines(v352);
                                        let v356: bool = true;
                                        let mut v354 = v354;
                                        let _iter_try_for_each = v354.try_for_each(|x| {
                                            //;
                                            let v358: Result<std::string::String, std::io::Error> =
                                                x;
                                            let v360: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v338.clone();
                                            let v361 = Spiral_builder::method43();
                                            let v363: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v358.map_err(|x| v361(x));
                                            let v364 = Spiral_builder::method90();
                                            let v365 = Spiral_builder::method91();
                                            let v367: Spiral_builder::US26 = match v363 {
                                                Ok(x) => v364(x),
                                                Err(e) => v365(e),
                                            };
                                            let v632: std::string::String = match &v367 {
                                                Spiral_builder::US26::US26_0(v367_0_0) => {
                                                    let v370: string =
                                                        fable_library_rust::String_::fromString(
                                                            v367_0_0.clone(),
                                                        );
                                                    let v372: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v374: std::borrow::Cow<[u8]> =
                                                        v372.encode(&*v370).0;
                                                    let v376: &[u8] = v374.as_ref();
                                                    let v378: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v376);
                                                    let v380: &str = v378.unwrap();
                                                    let v382: std::string::String =
                                                        String::from(v380);
                                                    let v385: string = sprintf!(
                                                        "> {}",
                                                        fable_library_rust::String_::fromString(
                                                            v382.clone()
                                                        )
                                                    );
                                                    if v5 {
                                                        let v388: () = {
                                                            Spiral_builder::closure39(
                                                                v385.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v505: () = {
                                                            Spiral_builder::closure10(v385, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    v382
                                                }
                                                Spiral_builder::US26::US26_1(v367_1_0) => {
                                                    let v507: std::string::String =
                                                        v367_1_0.clone();
                                                    let v510: () = {
                                                        Spiral_builder::closure38(v507.clone(), ());
                                                        ()
                                                    };
                                                    let v626: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v507
                                                    );
                                                    let v628: &str = &*v626;
                                                    String::from(v628)
                                                }
                                            };
                                            let v634: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v360;
                                            let v636: Result<
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
                                            > = v634.lock();
                                            let v638: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v636.unwrap();
                                            let v640: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v638;
                                            let v642: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v640.send(v632);
                                            let v643 = Spiral_builder::method94();
                                            let v645: Result<(), std::string::String> =
                                                v642.map_err(|x| v643(x));
                                            let v647: _ = v645;
                                            let v649: bool = true;
                                            v647
                                        }); //;
                                        let v652: Result<(), string> = Spiral_builder::method95(
                                            _iter_try_for_each.map_err(|x| x.into()),
                                        );
                                        let v656: string =
                                            string("true; v652 });  // rust.fix_closure\'");
                                        let v657: bool = true;
                                        v652
                                    }); // rust.fix_closure';
                                    let v659: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                    let v661: bool = true;
                                    let __spawn = std::thread::spawn(move || {
                                        //;
                                        let v663: encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                            .utf8_passthru(true)
                                            .build(v298);
                                        let v665: std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        > = std::io::BufReader::new(v663);
                                        let v667: std::io::Lines<
                                            std::io::BufReader<
                                                encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStderr,
                                                    Vec<u8>,
                                                >,
                                            >,
                                        > = std::io::BufRead::lines(v665);
                                        let v669: bool = true;
                                        let mut v667 = v667;
                                        let _iter_try_for_each = v667.try_for_each(|x| {
                                            //;
                                            let v671: Result<std::string::String, std::io::Error> =
                                                x;
                                            let v673: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v342.clone();
                                            let v674 = Spiral_builder::method43();
                                            let v676: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v671.map_err(|x| v674(x));
                                            let v677 = Spiral_builder::method90();
                                            let v678 = Spiral_builder::method91();
                                            let v680: Spiral_builder::US26 = match v676 {
                                                Ok(x) => v677(x),
                                                Err(e) => v678(e),
                                            };
                                            let v948: std::string::String = match &v680 {
                                                Spiral_builder::US26::US26_0(v680_0_0) => {
                                                    let v683: string =
                                                        fable_library_rust::String_::fromString(
                                                            v680_0_0.clone(),
                                                        );
                                                    let v685: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v687: std::borrow::Cow<[u8]> =
                                                        v685.encode(&*v683).0;
                                                    let v689: &[u8] = v687.as_ref();
                                                    let v691: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v689);
                                                    let v693: &str = v691.unwrap();
                                                    let v695: std::string::String =
                                                        String::from(v693);
                                                    let v698: string = sprintf!(
                                                        "! {}",
                                                        fable_library_rust::String_::fromString(
                                                            v695.clone()
                                                        )
                                                    );
                                                    if v5 {
                                                        let v701: () = {
                                                            Spiral_builder::closure39(
                                                                v698.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v817: () = {
                                                            Spiral_builder::closure10(v698, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    {
                                                        let v819: string = sprintf!(
                                                            "\u{001b}[4;7m{}\u{001b}[0m",
                                                            v695
                                                        );
                                                        let v821: &str = &*v819;
                                                        String::from(v821)
                                                    }
                                                }
                                                Spiral_builder::US26::US26_1(v680_1_0) => {
                                                    let v824: std::string::String =
                                                        v680_1_0.clone();
                                                    let v827: () = {
                                                        Spiral_builder::closure38(v824.clone(), ());
                                                        ()
                                                    };
                                                    let v942: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v824
                                                    );
                                                    let v944: &str = &*v942;
                                                    String::from(v944)
                                                }
                                            };
                                            let v950: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v673;
                                            let v952: Result<
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
                                            > = v950.lock();
                                            let v954: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v952.unwrap();
                                            let v956: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v954;
                                            let v958: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v956.send(v948);
                                            let v959 = Spiral_builder::method94();
                                            let v961: Result<(), std::string::String> =
                                                v958.map_err(|x| v959(x));
                                            let v963: _ = v961;
                                            let v965: bool = true;
                                            v963
                                        }); //;
                                        let v968: Result<(), string> = Spiral_builder::method95(
                                            _iter_try_for_each.map_err(|x| x.into()),
                                        );
                                        let v970: string =
                                            string("true; v968 });  // rust.fix_closure\'");
                                        let v971: bool = true;
                                        v968
                                    }); // rust.fix_closure';
                                    let v973: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                    let v987: Spiral_builder::US27 = defaultValue(
                                        Spiral_builder::US27::US27_1,
                                        map(Spiral_builder::method96(), v4.clone()),
                                    );
                                    match &v987 {
                                        Spiral_builder::US27::US27_0(v987_0_0) => {
                                            let v993: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::ChildStdin>>,
                                            > = v331;
                                            let v995: Result<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::ChildStdin>,
                                                    >,
                                                >,
                                            > = v993.lock();
                                            let v997: std::sync::MutexGuard<
                                                Option<std::process::ChildStdin>,
                                            > = v995.unwrap();
                                            let v999: bool = true;
                                            let mut v997 = v997;
                                            let v1001: &mut Option<std::process::ChildStdin> =
                                                &mut v997;
                                            let v1003: Option<std::process::ChildStdin> =
                                                Option::take(v1001);
                                            let v1005: bool = true;
                                            let _optionm_map_ = v1003.map(|x| {
                                                //;
                                                let v1007: std::process::ChildStdin = x;
                                                let v1009: std::sync::Mutex<
                                                    std::process::ChildStdin,
                                                > = std::sync::Mutex::new(v1007);
                                                let v1011: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = std::sync::Arc::new(v1009);
                                                let v1013: bool = true;
                                                v1011
                                            });
                                            let v1015: Option<
                                                std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                >,
                                            > = _optionm_map_;
                                            let v1029: Spiral_builder::US28 = defaultValue(
                                                Spiral_builder::US28::US28_1,
                                                map(Spiral_builder::method97(), v1015),
                                            );
                                            match &v1029 {
                                                Spiral_builder::US28::US28_0(v1029_0_0) => {
                                                    let v1033: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = match &v1029 {
                                                        Spiral_builder::US28::US28_0(x) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    };
                                                    (match &v987 {
                                                        Spiral_builder::US27::US27_0(x) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    })(
                                                        v1033.clone()
                                                    );
                                                    {
                                                        let v1035: std::sync::Arc<
                                                            std::sync::Mutex<
                                                                std::process::ChildStdin,
                                                            >,
                                                        > = v1033;
                                                        let v1037: Result<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                            std::sync::PoisonError<
                                                                std::sync::MutexGuard<
                                                                    std::process::ChildStdin,
                                                                >,
                                                            >,
                                                        > = v1035.lock();
                                                        let v1040: std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        > = Spiral_builder::method98(
                                                            v1037.unwrap(),
                                                        );
                                                        let v1042: bool = true;
                                                        let mut v1040 = v1040;
                                                        let v1044: bool = true;
                                                        std::io::Write::flush(&mut *v1040).unwrap();
                                                        ()
                                                    }
                                                }
                                                _ => (),
                                            }
                                        }
                                        _ => (),
                                    }
                                    {
                                        let v1046: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v246;
                                        let v1048: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v1046.lock();
                                        let v1050: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = v1048.unwrap();
                                        let v1052: bool = true;
                                        let mut v1050 = v1050;
                                        let v1054: &mut Option<std::process::Child> = &mut v1050;
                                        let v1056: Option<std::process::Child> =
                                            Option::take(v1054);
                                        let v1058: std::process::Child = v1056.unwrap();
                                        let v1060: Result<std::process::Output, std::io::Error> =
                                            v1058.wait_with_output();
                                        let v1061 = Spiral_builder::method43();
                                        let v1063: Result<
                                            std::process::Output,
                                            std::string::String,
                                        > = v1060.map_err(|x| v1061(x));
                                        let v1064: std::thread::JoinHandle<Result<(), string>> =
                                            Spiral_builder::method99(v973);
                                        let v1067: string = string("v1064");
                                        let v1068: std::thread::JoinHandle<Result<(), string>> =
                                            Spiral_builder::method99(v659);
                                        let v1073: string = append(
                                            append(
                                                string("vec!["),
                                                append(string("v1068, "), v1067),
                                            ),
                                            string("]"),
                                        );
                                        let v1074: Vec<
                                            std::thread::JoinHandle<Result<(), string>>,
                                        > = vec![v1068, v1064];
                                        let v1076: bool = true;
                                        v1074.into_iter().for_each(|x| {
                                            //;
                                            let v1078: std::thread::JoinHandle<Result<(), string>> =
                                                x;
                                            let v1080: Result<
                                                Result<(), string>,
                                                Box<dyn core::any::Any + 'static + Send>,
                                            > = std::thread::JoinHandle::join(v1078);
                                            let v1082: Result<(), string> = v1080.unwrap();
                                            v1082.unwrap();
                                            {
                                                let v1085: bool = true;
                                                let v1087: bool = true;
                                            }
                                        });
                                        {
                                            //;
                                            let v1090: Spiral_builder::US29 = match &v1063 {
                                                Err(v1063_1_0) => {
                                                    Spiral_builder::closure44((), v1063_1_0.clone())
                                                }
                                                Ok(v1063_0_0) => {
                                                    Spiral_builder::closure43((), v1063_0_0.clone())
                                                }
                                            };
                                            match &v1090 {
                                                Spiral_builder::US29::US29_0(v1090_0_0) => {
                                                    let v1093: std::process::ExitStatus =
                                                        v1090_0_0.clone().status;
                                                    let v1095: Option<i32> = v1093.code();
                                                    let v1109: Spiral_builder::US30 = defaultValue(
                                                        Spiral_builder::US30::US30_1,
                                                        map(Spiral_builder::method100(), v1095),
                                                    );
                                                    match &v1109 {
                                                        Spiral_builder::US30::US30_0(v1109_0_0) => (
                                                            match &v1109 {
                                                                Spiral_builder::US30::US30_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            Spiral_builder::US5::US5_1,
                                                            Spiral_builder::US25::US25_0(
                                                                v346.clone(),
                                                            ),
                                                        ),
                                                        _ => {
                                                            let v1118:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                            (
                                                                -1_i32,
                                                                Spiral_builder::US5::US5_0(
                                                                    String::from(v1118),
                                                                ),
                                                                Spiral_builder::US25::US25_0(
                                                                    v346.clone(),
                                                                ),
                                                            )
                                                        }
                                                    }
                                                }
                                                Spiral_builder::US29::US29_1(v1090_1_0) => {
                                                    let v1129: std::string::String =
                                                        v1090_1_0.clone();
                                                    let v1132: () = {
                                                        Spiral_builder::closure45(
                                                            v1129.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    (
                                                        -2_i32,
                                                        Spiral_builder::US5::US5_0(v1129),
                                                        Spiral_builder::US25::US25_1,
                                                    )
                                                }
                                            }
                                        }
                                    }
                                }
                                Spiral_builder::US24::US24_1(v245_1_0) => {
                                    let v1255: std::string::String = v245_1_0.clone();
                                    let v1258: () = {
                                        Spiral_builder::closure35(v1255.clone(), ());
                                        ()
                                    };
                                    (
                                        -1_i32,
                                        Spiral_builder::US5::US5_0(v1255),
                                        Spiral_builder::US25::US25_1,
                                    )
                                }
                            };
                        let v1381: Spiral_builder::US25 = patternInput_3.2.clone();
                        let v1380: Spiral_builder::US5 = patternInput_3.1.clone();
                        let v1379: i32 = patternInput_3.0.clone();
                        let v1388: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v1381 {
                            Spiral_builder::US25::US25_0(v1381_0_0) => Some(match &v1381 {
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
                        let v1390: bool = true;
                        let _optionm_map_ = v1388.map(|x| {
                            //;
                            let v1392: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v1394: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v1392;
                            let v1396: Result<
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
                            > = v1394.lock();
                            let v1398: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v1396.unwrap();
                            let v1400 = v1398.iter();
                            let v1402: Vec<std::string::String> = v1400.collect::<Vec<_>>();
                            let v1404: bool = true;
                            let _vec_map: Vec<_> = v1402
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v1406: std::string::String = x;
                                    let v1408: string =
                                        fable_library_rust::String_::fromString(v1406);
                                    let v1410: bool = true;
                                    v1408
                                })
                                .collect::<Vec<_>>();
                            let v1412: Vec<string> = _vec_map;
                            let v1421: string = join(
                                string("\n"),
                                toArray_1(ofArray_1(fable_library_rust::NativeArray_::array_from(
                                    v1412,
                                ))),
                            );
                            let v1425: bool = true;
                            v1421
                        });
                        let v1427: Option<string> = _optionm_map_;
                        let v1434: Spiral_builder::US1 = match &v1380 {
                            Spiral_builder::US5::US5_0(v1380_0_0) => Spiral_builder::US1::US1_0(
                                fable_library_rust::String_::fromString(match &v1380 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }),
                            ),
                            _ => Spiral_builder::US1::US1_1,
                        };
                        let v1439: string = defaultValue(
                            match &v1434 {
                                Spiral_builder::US1::US1_0(v1434_0_0) => match &v1434 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => string(""),
                            },
                            v1427,
                        );
                        let v1444: () = {
                            Spiral_builder::closure47(v1379, v1439.clone(), ());
                            ()
                        };
                        LrcPtr::new((v1379, v1439))
                    }
                }))();
                _v163.set(Some(x_3))
            }
            {
                let v1562: LrcPtr<(i32, string)> = match &_v163.get().clone() {
                    None => panic!("{}", string("base.capture / _v163=None"),),
                    Some(_v163_0_0) => _v163_0_0.clone(),
                };
                let _v7: (i32, string) = (v1562.0.clone(), v1562.1.clone());
                (_v7.0.clone(), _v7.1.clone())
            }
        }
        pub fn method108(v0_1: Spiral_builder::US8, v1_1: i32, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method109(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_cuda / env install error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure57(
            v0_1: Spiral_builder::US8,
            v1_1: string,
            v2: string,
            v3: i32,
            unitVar: (),
        ) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = Spiral_builder::method109(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v59.l0.get().clone(),
                    Spiral_builder::method108(v0_1, v3, v2, v1_1),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure58(unitVar: (), v0_1: string) -> Spiral_builder::US1 {
            Spiral_builder::US1::US1_0(v0_1)
        }
        pub fn closure59(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32))),
            )
        }
        pub fn method110(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
            let v65: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v35)),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v83: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("run_result")), ());
                ()
            };
            let v91: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v99: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v107: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v116: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v124: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v132: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v140: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v149: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", string("external_command")),
                    (),
                );
                ()
            };
            let v157: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v165: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v174: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method111(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_cuda / Exception"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure61(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = Spiral_builder::method111(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v59.l0.get().clone(),
                    Spiral_builder::method110(v3, v1_1, v0_1, v2),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure60(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US1 {
            let v6: () = {
                Spiral_builder::closure61(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US1::US1_1
        }
        pub fn method112(v0_1: i32, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method113(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_cuda / error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure62(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = Spiral_builder::method113(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v59.l0.get().clone(),
                    Spiral_builder::method112(v2, v1_1, v0_1, v3),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure63(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v3: &str = &*_arg.0.clone();
            let v5: std::string::String = String::from(v3);
            let v7: &str = &*_arg.1.clone();
            LrcPtr::new((v5, String::from(v7)))
        }
        pub fn method114() -> string {
            string("fs-path")
        }
        pub fn method115() -> string {
            string("command")
        }
        pub fn method116() -> string {
            string("path")
        }
        pub fn method122(v0_1: string) -> string {
            v0_1
        }
        pub fn method121(v0_1: string) -> string {
            if v0_1.clone() == string("") {
                string("")
            } else {
                let v7: Result<regex::Regex, regex::Error> =
                    regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                let v9: regex::Regex = v7.unwrap();
                let v10: string = Spiral_builder::method122(v0_1);
                let v12: std::borrow::Cow<str> = v9.replace_all(&*v10, &*string(""));
                let v14: std::string::String = String::from(v12);
                let v30: string = fable_library_rust::String_::fromString(v14);
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v30.clone(), 0_i32))),
                        getSlice(v30, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
        pub fn method123(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut6>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method124() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method120(v0_1: string) -> string {
            let v3: &str = &*v0_1.clone();
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            if v7.exists() == false {
                let v11: string = Spiral_builder::method36();
                let v15: Array<string> = split(
                    Spiral_builder::method121(Spiral_builder::method25(v11.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v19: i32 = count_2(v15.clone());
                let v20: LrcPtr<Spiral_builder::Mut6> = LrcPtr::new(Spiral_builder::Mut6 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Spiral_builder::method123(v19, v20.clone()) {
                    let v22: i32 = v20.l0.get().clone();
                    let v25: i32 = v22.wrapping_neg() + v19 - 1_i32;
                    let matchValue: i32 = v20.l1.get().clone();
                    let v27: Array<string> = v20.l2.get().clone();
                    let v26: i32 = matchValue;
                    let v28: string = v15[v25].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == v28.clone() {
                        (v26 + 1_i32, v27.clone())
                    } else {
                        if string(".") == v28.clone() {
                            (v26, v27.clone())
                        } else {
                            if 0_i32 == v26 {
                                if endsWith(v28.clone(), string(":"), false) {
                                    let v36: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v11.clone(), 0_i32)
                                    )]);
                                    let v37: i32 = count_2(v36.clone());
                                    let v39: i32 = v37 + count_2(v27.clone());
                                    let v40: Array<string> = new_init(&string(""), v39);
                                    let v41: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method64(v39, v41.clone()) {
                                        let v43: i32 = v41.l0.get().clone();
                                        let v48: string = if v43 < v37 {
                                            v36[v43].clone()
                                        } else {
                                            let v46: i32 = v43 - v37;
                                            v27[v46].clone()
                                        };
                                        v40.get_mut()[v43 as usize] = v48;
                                        {
                                            let v49: i32 = v43 + 1_i32;
                                            v41.l0.set(v49);
                                            ()
                                        }
                                    }
                                    (0_i32, v40.clone())
                                } else {
                                    let v50: Array<string> = new_array(&[v28]);
                                    let v51: i32 = count_2(v50.clone());
                                    let v53: i32 = v51 + count_2(v27.clone());
                                    let v54: Array<string> = new_init(&string(""), v53);
                                    let v55: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method64(v53, v55.clone()) {
                                        let v57: i32 = v55.l0.get().clone();
                                        let v62: string = if v57 < v51 {
                                            v50[v57].clone()
                                        } else {
                                            let v60: i32 = v57 - v51;
                                            v27[v60].clone()
                                        };
                                        v54.get_mut()[v57 as usize] = v62;
                                        {
                                            let v63: i32 = v57 + 1_i32;
                                            v55.l0.set(v63);
                                            ()
                                        }
                                    }
                                    (0_i32, v54.clone())
                                }
                            } else {
                                (v26 - 1_i32, v27.clone())
                            }
                        }
                    };
                    let v73: i32 = v22 + 1_i32;
                    v20.l0.set(v73);
                    v20.l1.set(patternInput_1.0.clone());
                    v20.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v20.l1.get().clone();
                    let v75: Array<string> = v20.l2.get().clone();
                    let v76: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v75 = v75.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v75 = v75.clone();
                                    move |i: i32| v75[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, count_2(v75.clone()) - 1_i32),
                            )
                        }
                    }));
                    join(ofChar(Spiral_builder::method124()), toArray_1(v76))
                }
            } else {
                let v90: Result<std::path::PathBuf, std::io::Error> = std::fs::canonicalize(&*v0_1);
                let v92: std::path::PathBuf = v90.unwrap();
                let v94: std::path::Display = v92.display();
                let v97: std::string::String = format!("{}", v94);
                fable_library_rust::String_::fromString(v97)
            }
        }
        pub fn method119(v0_1: string) -> string {
            Spiral_builder::method121(Spiral_builder::method120(v0_1))
        }
        pub fn method118(v0_1: string) -> string {
            Spiral_builder::method119(Spiral_builder::method25(Spiral_builder::method36(), v0_1))
        }
        pub fn closure64(unitVar: (), v0_1: std::string::String) -> string {
            Spiral_builder::method118(fable_library_rust::String_::fromString(v0_1))
        }
        pub fn method117() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure64((), v))
        }
        pub fn method125() -> string {
            string("retries")
        }
        pub fn method126() -> string {
            string("working-directory")
        }
        pub fn method128(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure65(v0_1: u8, v1_1: u8, v2: string, v3: i32, unitVar: ()) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v86: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.run / repl error"),
                    v59.l0.get().clone(),
                    Spiral_builder::method128(v3, v2, sprintf!("{}/{}", v1_1, v0_1)),
                );
                let v88: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v86,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method127(v0_1: Spiral_builder::US1, v1_1: u8, v2: string, v3: u8) -> (i32, string) {
            let v0_1: MutCell<Spiral_builder::US1> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<u8> = MutCell::new(v1_1);
            let v2: MutCell<string> = MutCell::new(v2.clone());
            let v3: MutCell<u8> = MutCell::new(v3);
            '_method127: loop {
                break '_method127 ({
                    let patternInput: (i32, string) = Spiral_builder::method61(
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
                            Spiral_builder::US1::US1_0(v0_1_0_0) => {
                                Some(match &v0_1.get().clone() {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
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
                            Spiral_builder::closure65(
                                v1_1.get().clone(),
                                v3.get().clone(),
                                v24,
                                v23,
                                (),
                            );
                            ()
                        };
                        {
                            let v0_1_temp: Spiral_builder::US1 = v0_1.get().clone();
                            let v1_1_temp: u8 = v1_1.get().clone();
                            let v2_temp: string = v2.get().clone();
                            let v3_temp: u8 = v3.get().clone() + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method127;
                        }
                    }
                });
            }
        }
        pub fn method129(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure66(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v84: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.run / dib / jupyter nbconvert"),
                    v57.l0.get().clone(),
                    Spiral_builder::method129(v1_1, length(v0_1)),
                );
                let v86: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method130(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure67(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v84: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.run / dib / html cell ids"),
                    v57.l0.get().clone(),
                    Spiral_builder::method130(v1_1, length(v0_1)),
                );
                let v86: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method131(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure68(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v84: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.run / dib"),
                    v57.l0.get().clone(),
                    Spiral_builder::method131(v1_1, length(v0_1)),
                );
                let v86: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method132() -> string {
            string("cleanup")
        }
        pub fn method133() -> string {
            string("wasm")
        }
        pub fn method134() -> string {
            string("contract")
        }
        pub fn method135(v0_1: string, v1_1: string, v2: Spiral_builder::US33) -> string {
            let v4: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method137() -> string {
            string("")
        }
        pub fn method138() -> string {
            string("")
        }
        pub fn method136(v0_1: string) -> string {
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
                    let v31: usize = v29.unwrap();
                    if v31 == v19 {
                        let v36: bool = true;
                        break;
                        ()
                    }
                    {
                        let v38: usize = v23.len();
                        let v39: u8 = v38 as u8;
                        let v42: usize = v31;
                        let v55: &_ = if v42 == v38 {
                            &v23[v19..]
                        } else {
                            &v23[v19..v42]
                        };
                        sha2::Digest::update(&mut v16, v55);
                        {
                            let v58: bool = true;
                        } // rust.loop;
                        let v60: bool = true;
                    } // rust.loop;
                    let v62: bool = true;
                } // rust.loop;
                let v64: bool = true;
                {
                    // rust.loop;
                    let v66: bool = true;
                    {
                        // rust.loop;
                        let v68: &[u8] = &sha2::Digest::finalize(v16);
                        let v70: Vec<u8> = v68.iter().map(|x| *x).collect::<Vec<_>>();
                        let v72: bool = true;
                        let _vec_map: Vec<_> = v70
                            .into_iter()
                            .map(|x| {
                                //;
                                let v74: u8 = x;
                                let v76: std::string::String = format!("{:02x}", v74);
                                let v78: string = fable_library_rust::String_::fromString(v76);
                                let v80: bool = true;
                                v78
                            })
                            .collect::<Vec<_>>();
                        let v82: Vec<string> = _vec_map;
                        let v84: Array<string> = fable_library_rust::NativeArray_::array_from(v82);
                        let v85: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v84 = v84.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v84 = v84.clone();
                                        move |i: i32| v84[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, count_2(v84.clone()) - 1_i32),
                                )
                            }
                        }));
                        let v91: string = join(Spiral_builder::method137(), toArray_1(v85));
                        Ok::<string, std::io::Error>(v91).unwrap()
                    }
                }
            }
        }
        pub fn closure69(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> Spiral_builder::US35 {
            Spiral_builder::US35::US35_0(v0_1)
        }
        pub fn method140() -> Func1<chrono::DateTime<chrono::Utc>, Spiral_builder::US35> {
            Func1::new(move |v: chrono::DateTime<chrono::Utc>| Spiral_builder::closure69((), v))
        }
        pub fn method141() -> string {
            string("hh:mm")
        }
        pub fn method142() -> string {
            string("yyyyMMdd-HHmm-ssff-ffff-f")
        }
        pub fn method143() -> string {
            string("hhmm")
        }
        pub fn method139(v0_1: Guid, v1_1: DateTime) -> Guid {
            let v7: DateTime = {
                let _arg: DateTime =
                    DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
                _arg.toUniversalTime()
            };
            let v25: i64 = ({
                let _arg_2: DateTime = {
                    let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                    _arg_1.toUniversalTime()
                };
                _arg_2.ticks()
            } - v7.ticks())
                / 10_i64;
            let v27: Option<chrono::DateTime<chrono::Utc>> =
                chrono::DateTime::from_timestamp_micros(v25);
            let v41: Spiral_builder::US35 = defaultValue(
                Spiral_builder::US35::US35_1,
                map(Spiral_builder::method140(), v27),
            );
            let v61: Spiral_builder::US1 = match &v41 {
                Spiral_builder::US35::US35_0(v41_0_0) => {
                    let v47: chrono::NaiveDateTime = match &v41 {
                        Spiral_builder::US35::US35_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .naive_utc();
                    let v49: chrono::DateTime<chrono::Local> =
                        chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v47);
                    let v51: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                    let v52: &str = r#"%Y%m%d-%H%M-%S%f"#;
                    let v54: std::string::String = v49.format(v52).to_string();
                    let v56: string = fable_library_rust::String_::fromString(v54);
                    Spiral_builder::US1::US1_0(sprintf!(
                        "{}-{}-{}",
                        getSlice(v56.clone(), Some(0_i32), Some(17_i32)),
                        getSlice(v56.clone(), Some(18_i32), Some(21_i32)),
                        getCharAt(v56, 22_i32)
                    ))
                }
                _ => Spiral_builder::US1::US1_1,
            };
            let v65: string = match &v61 {
                Spiral_builder::US1::US1_0(v61_0_0) => match &v61 {
                    Spiral_builder::US1::US1_0(x) => x.clone(),
                    _ => unreachable!(),
                },
                _ => string(""),
            };
            let v68: LrcPtr<TimeZoneInfo> = 0i64.into();
            let v143: u8 = if zero.hours() > 0_i32 { 1_u8 } else { 0_u8 };
            let v144: string = Spiral_builder::method141();
            let v152: string = zero.to_string(v144);
            let v155: string = sprintf!(
                "{}{}{}",
                v143,
                getSlice(v152.clone(), Some(0_i32), Some(1_i32)),
                getSlice(v152, Some(3_i32), Some(4_i32))
            );
            parse(sprintf!(
                "{}{}{}",
                v65.clone(),
                v155.clone(),
                getSlice(
                    toString(v0_1),
                    Some(length(v65) + length(v155)),
                    None::<i32>
                )
            ))
        }
        pub fn method144(v0_1: string, v1_1: string) {
            if Spiral_builder::method29(v0_1.clone()) == false {
                let v4: LrcPtr<dyn IDisposable> = Spiral_builder::method41(v0_1.clone());
                ()
            }
            {
                let v5: string = Spiral_builder::method37(v1_1.clone());
                if Spiral_builder::method29(v5.clone()) == false {
                    let v8: LrcPtr<dyn IDisposable> = Spiral_builder::method41(v5);
                    ()
                }
                if if Spiral_builder::method29(v1_1.clone()) {
                    let v12: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v1_1.clone());
                    v12.is_err()
                } else {
                    false
                } {
                    Spiral_builder::method50(true, v1_1.clone());
                }
                if Spiral_builder::method29(v1_1.clone()) == false {
                    let v40: bool = true;
                    #[cfg(windows)]
                    std::os::windows::fs::symlink_dir(&*v0_1.clone(), &*v1_1.clone()).unwrap();
                    let v42: bool = true;
                    #[cfg(unix)]
                    std::os::unix::fs::symlink(&*v0_1, &*v1_1).unwrap();
                    ();
                    ()
                }
            }
        }
        pub fn method146() -> string {
            string("(")
        }
        pub fn method147() -> string {
            string(" ")
        }
        pub fn method148(v0_1: Spiral_builder::US34) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v11: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", sprintf!("{:?}", v0_1)), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method151(v0_1: bool, v1_1: string, v2: i32, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure70(v0_1: u8, v1_1: u8, v2: i32, v3: string, v4: bool, unitVar: ()) {
            fn v6() {
                Spiral_builder::closure2((), ());
            }
            let v7: () = {
                v6();
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
            let v39: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v39,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v46: () = {
                    v6();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v60: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v87: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v60.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("common.retry_fn\' / loop"),
                    v60.l0.get().clone(),
                    Spiral_builder::method151(v4, sprintf!("{}/{}", v1_1, v0_1), v2, v3),
                );
                let v89: () = {
                    v6();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v87,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method150(
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
            '_method150: loop {
                break '_method150 ({
                    let patternInput: (i32, string) = Spiral_builder::method61(
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
                    let v14: Spiral_builder::US36 = if v9 == 0_i32 {
                        Spiral_builder::US36::US36_0(v9, v10.clone())
                    } else {
                        Spiral_builder::US36::US36_1(v9, v10)
                    };
                    let patternInput_1: (bool, i32, string) = match &v14 {
                        Spiral_builder::US36::US36_0(v14_0_0, v14_0_1) => {
                            (false, v14_0_0.clone(), v14_0_1.clone())
                        }
                        Spiral_builder::US36::US36_1(v14_1_0, v14_1_1) => {
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
                            Spiral_builder::closure70(
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
                            continue '_method150;
                        }
                    }
                });
            }
        }
        pub fn method149(
            v0_1: u8,
            v1_1: string,
            v2: Option<CancellationToken>,
            v3: Array<(string, string)>,
            v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v6: bool,
            v7: Option<string>,
        ) -> (i32, string) {
            Spiral_builder::method150(v0_1, v1_1, v2, v3, v4, v5, v6, v7, 1_u8)
        }
        pub fn method145(
            v0_1: Spiral_builder::US33,
            v1_1: string,
            v2: string,
            v3: string,
            v4: Spiral_builder::US12,
        ) -> (i32, string) {
            let v132: string = sprintf!(
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
                    Spiral_builder::US33::US33_0(v0_1_0_0) => {
                        let v38: Spiral_builder::US34 = match &v0_1 {
                            Spiral_builder::US33::US33_0(x) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v78: Spiral_builder::US1 =
                            if if let Spiral_builder::US34::US34_0(v38_0_0) = &v38 {
                                string("")
                                    == match &v38 {
                                        Spiral_builder::US34::US34_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                            } else {
                                false
                            } {
                                Spiral_builder::US1::US1_0(string("Wasm"))
                            } else {
                                let v51: string = Spiral_builder::method146();
                                let v64: Array<string> = split(
                                    Spiral_builder::method148(Spiral_builder::US34::US34_0(
                                        string(""),
                                    )),
                                    v51,
                                    -1_i32,
                                    0_i32,
                                );
                                let v67: string = v64[0_i32].clone();
                                if startsWith(Spiral_builder::method148(v38.clone()), v67, false) {
                                    Spiral_builder::US1::US1_0(string("Wasm"))
                                } else {
                                    Spiral_builder::US1::US1_1
                                }
                            };
                        let v121: Spiral_builder::US1 = match &v78 {
                            Spiral_builder::US1::US1_0(v78_0_0) => {
                                Spiral_builder::US1::US1_0(match &v78 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v114: Spiral_builder::US1 =
                                    if if let Spiral_builder::US34::US34_1(v38_1_0) = &v38 {
                                        string("")
                                            == match &v38 {
                                                Spiral_builder::US34::US34_1(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                    } else {
                                        false
                                    } {
                                        Spiral_builder::US1::US1_0(string("Contract"))
                                    } else {
                                        let v87: string = Spiral_builder::method146();
                                        let v100: Array<string> = split(
                                            Spiral_builder::method148(
                                                Spiral_builder::US34::US34_1(string("")),
                                            ),
                                            v87,
                                            -1_i32,
                                            0_i32,
                                        );
                                        let v103: string = v100[0_i32].clone();
                                        if startsWith(
                                            Spiral_builder::method148(v38.clone()),
                                            v103,
                                            false,
                                        ) {
                                            Spiral_builder::US1::US1_0(string("Contract"))
                                        } else {
                                            Spiral_builder::US1::US1_1
                                        }
                                    };
                                match &v114 {
                                    Spiral_builder::US1::US1_0(v114_0_0) => {
                                        Spiral_builder::US1::US1_0(match &v114 {
                                            Spiral_builder::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => Spiral_builder::US1::US1_1,
                                }
                            }
                        };
                        sprintf!(
                            " --define {}",
                            toUpper(match &v121 {
                                Spiral_builder::US1::US1_0(v121_0_0) => match &v121 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            })
                        )
                    }
                    _ => string(""),
                }
            );
            let v138: Result<string, string> = match &v4 {
                Spiral_builder::US12::US12_0(v4_0_0) => Ok::<string, string>(v4_0_0.clone()),
                Spiral_builder::US12::US12_1(v4_1_0) => Err::<string, string>(v4_1_0.clone()),
            };
            Spiral_builder::method149(
                3_u8,
                v132,
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                v138.ok(),
            )
        }
        pub fn method152(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method153(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_rust / dotnet fable error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure71(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_builder::method153(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v57.l0.get().clone(),
                    Spiral_builder::method152(v1_1, v0_1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure72(unitVar: (), v0_1: std::string::String) -> bool {
            contains(
                fable_library_rust::String_::fromString(v0_1),
                string("near-sdk"),
            )
        }
        pub fn method154() -> Func1<std::string::String, bool> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure72((), v))
        }
        pub fn method155(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method156(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method157(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn closure73(
            unitVar: (),
            v0_1: std::collections::HashMap<string, string>,
        ) -> Spiral_builder::US37 {
            Spiral_builder::US37::US37_0(v0_1)
        }
        pub fn method159() -> Func1<std::collections::HashMap<string, string>, Spiral_builder::US37>
        {
            Func1::new(move |v: std::collections::HashMap<string, string>| {
                Spiral_builder::closure73((), v)
            })
        }
        pub fn method160() -> string {
            string("a")
        }
        pub fn closure74(v0_1: u8, v1_1: i32, v2: string, v3: bool, unitVar: ()) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v86: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("common.retry_fn\' / loop"),
                    v59.l0.get().clone(),
                    Spiral_builder::method151(v3, sprintf!("{}/{}", v0_1, 3_u8), v1_1, v2),
                );
                let v88: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v86,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method158(v0_1: Spiral_builder::US12, v1_1: string, v2: u8) -> (i32, string) {
            let v0_1: MutCell<Spiral_builder::US12> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<u8> = MutCell::new(v2);
            '_method158: loop {
                break '_method158 ({
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
                    let patternInput: (i32, string) = Spiral_builder::method61(
                        v8,
                        None::<CancellationToken>,
                        new_empty::<(string, string)>(),
                        None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                        true,
                        v14.ok(),
                    );
                    let v19: string = patternInput.1.clone();
                    let v18: i32 = patternInput.0.clone();
                    let v179: Spiral_builder::US36 = if contains(
                        v19.clone(),
                        string("failed to load manifest for workspace member"),
                    ) == false
                    {
                        if v18 == 0_i32 {
                            Spiral_builder::US36::US36_0(v18, v19.clone())
                        } else {
                            Spiral_builder::US36::US36_1(v18, v19.clone())
                        }
                    } else {
                        let v31: Result<regex::Regex, regex::Error> =
                            regex::Regex::new(&string("failed to read `(?<a>.*?Cargo.toml)`"));
                        let v33: regex::Regex = v31.unwrap();
                        let v35: &str = &*v19.clone();
                        let v37: std::string::String = String::from(v35);
                        let v39: bool = true;
                        let _capture_move = (move || {
                            //;
                            let v41: Box<std::string::String> = Box::new(v37);
                            let v43: &'static mut std::string::String = Box::leak(v41);
                            let v45: regex::CaptureMatches = v33.captures_iter(v43);
                            let v47: bool = true;
                            let _regex_captures: Vec<_> = v45
                                .map(|x| {
                                    //;
                                    let v49: regex::Captures<'static> = x;
                                    let v51: Box<regex::Captures<'static>> = Box::new(v49);
                                    let v53: &'static mut regex::Captures<'static> = Box::leak(v51);
                                    let v55: regex::CaptureNames = v33.capture_names();
                                    let v57: bool = true;
                                    let _regex_captures: std::collections::HashMap<_, _> = v55
                                        .map(|x| {
                                            //;
                                            let v59: string = x.unwrap_or("").to_string().into();
                                            let v61: string = v59.clone().clone();
                                            let v63: string = v53
                                                .name(&v59)
                                                .map(|x| x.as_str())
                                                .unwrap_or("")
                                                .to_string()
                                                .into();
                                            let v66: bool = true;
                                            LrcPtr::new((v61, v63))
                                        })
                                        .map(|x| {
                                            std::sync::Arc::try_unwrap(x)
                                                .unwrap_or_else(|x| (*x).clone())
                                        })
                                        .collect();
                                    let v68: std::collections::HashMap<string, string> =
                                        _regex_captures;
                                    let v70: bool = true;
                                    v68
                                })
                                .collect::<Vec<_>>();
                            let v72: Vec<std::collections::HashMap<string, string>> =
                                _regex_captures;
                            let v74: bool = true;
                            v72
                        })();
                        let v76: Vec<std::collections::HashMap<string, string>> = _capture_move;
                        let v79: Option<std::collections::HashMap<string, string>> =
                            tryItem(0_i32, fable_library_rust::NativeArray_::array_from(v76));
                        let v93: Spiral_builder::US37 = defaultValue(
                            Spiral_builder::US37::US37_1,
                            map(Spiral_builder::method159(), v79),
                        );
                        let v121: Spiral_builder::US38 = match &v93 {
                            Spiral_builder::US37::US37_0(v93_0_0) => {
                                let v98: string = Spiral_builder::method160();
                                let v100: Option<string> = std::collections::HashMap::get(
                                    &match &v93 {
                                        Spiral_builder::US37::US37_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    &v98,
                                )
                                .map(|x| x)
                                .cloned();
                                Spiral_builder::US38::US38_0(defaultValue(
                                    Spiral_builder::US1::US1_1,
                                    map(Spiral_builder::method5(), v100),
                                ))
                            }
                            _ => Spiral_builder::US38::US38_1,
                        };
                        let v128: Spiral_builder::US1 =
                            if let Spiral_builder::US38::US38_0(v121_0_0) = &v121 {
                                let v122: Spiral_builder::US1 = match &v121 {
                                    Spiral_builder::US38::US38_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Spiral_builder::US1::US1_0(v122_0_0) = &v122 {
                                    Spiral_builder::US1::US1_0(match &v122 {
                                        Spiral_builder::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    Spiral_builder::US1::US1_1
                                }
                            } else {
                                Spiral_builder::US1::US1_1
                            };
                        match &v128 {
                            Spiral_builder::US1::US1_0(v128_0_0) => {
                                let v130: string = match &v128 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if Spiral_builder::method40(v130.clone()) == false {
                                    let v134: LrcPtr<dyn IDisposable> = Spiral_builder::method41(
                                        Spiral_builder::method37(v130.clone()),
                                    );
                                    let v135: DateTime = DateTime::now();
                                    let v144: string =
                                        toString(Spiral_builder::method139(new_guid(), v135));
                                    let v169: string =
                                                     append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                         v144.clone())),
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
                                                                                   v144)),
                                                                   string("\n")),
                                                            string("path = \"spiral_builder.rs\""));
                                    std::fs::write(&*v130, &*v169).unwrap();
                                    ();
                                    ()
                                }
                                if v18 == 0_i32 {
                                    Spiral_builder::US36::US36_0(v18, v19.clone())
                                } else {
                                    Spiral_builder::US36::US36_1(v18, v19.clone())
                                }
                            }
                            _ => Spiral_builder::US36::US36_1(v18, v19.clone()),
                        }
                    };
                    let patternInput_1: (bool, i32, string) = match &v179 {
                        Spiral_builder::US36::US36_0(v179_0_0, v179_0_1) => {
                            (false, v179_0_0.clone(), v179_0_1.clone())
                        }
                        Spiral_builder::US36::US36_1(v179_1_0, v179_1_1) => {
                            (true, v179_1_0.clone(), v179_1_1.clone())
                        }
                    };
                    let v189: string = patternInput_1.2.clone();
                    let v188: i32 = patternInput_1.1.clone();
                    let v187: bool = patternInput_1.0.clone();
                    if if v187 == false {
                        true
                    } else {
                        v2.get().clone() >= 3_u8
                    } {
                        (v188, v189.clone())
                    } else {
                        let v195: () = {
                            Spiral_builder::closure74(v2.get().clone(), v188, v189, v187, ());
                            ()
                        };
                        {
                            let v0_1_temp: Spiral_builder::US12 = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: u8 = v2.get().clone() + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method158;
                        }
                    }
                });
            }
        }
        pub fn method161(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method162(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_rust / cargo fmt error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure75(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v79: string = Spiral_builder::method162(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v57.l0.get().clone(),
                    Spiral_builder::method161(v1_1, v0_1),
                );
                let v81: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v79,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure77(unitVar: (), v0_1: string) -> bool {
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
        pub fn closure76(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(skip(
                    2_i32,
                    skipWhile(
                        Func1::new(move |v: string| Spiral_builder::closure77((), v)),
                        split(v0_1, string("\n"), -1_i32, 0_i32),
                    ),
                ))),
            )
        }
        pub fn method163(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
            let v65: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v35)),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v83: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v91: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v99: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v107: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v116: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", string("external_command")),
                    (),
                );
                ()
            };
            let v124: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v132: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v140: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v149: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("cargo_result")), ());
                ()
            };
            let v157: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v165: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v174: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method164(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_rust / Exception"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure79(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = Spiral_builder::method164(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v59.l0.get().clone(),
                    Spiral_builder::method163(v3, v0_1, v2, v1_1),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure78(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US1 {
            let v6: () = {
                Spiral_builder::closure79(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US1::US1_1
        }
        pub fn method165(v0_1: i32, v1_1: string, v2: string, v3: bool, v4: string) -> string {
            let v6: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method166(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_rust / error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure80(v0_1: bool, v1_1: string, v2: string, v3: i32, v4: string, unitVar: ()) {
            fn v6() {
                Spiral_builder::closure2((), ());
            }
            let v7: () = {
                v6();
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
            let v39: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v39,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v46: () = {
                    v6();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v60: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method166(
                    Spiral_builder::method7(
                        v60.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v60.l0.get().clone(),
                    Spiral_builder::method165(v3, v1_1, v4, v0_1, v2),
                );
                let v84: () = {
                    v6();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method167(v0_1: i32, v1_1: string, v2: string, v3: bool, v4: string) -> string {
            let v6: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method168(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_rust / wasm error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure81(v0_1: bool, v1_1: string, v2: string, v3: string, v4: i32, unitVar: ()) {
            fn v6() {
                Spiral_builder::closure2((), ());
            }
            let v7: () = {
                v6();
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
            let v39: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v39,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v46: () = {
                    v6();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v60: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v83: string = Spiral_builder::method168(
                    Spiral_builder::method7(
                        v60.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v60.l0.get().clone(),
                    Spiral_builder::method167(v4, v1_1, v2, v0_1, sprintf!("\n{}", v3)),
                );
                let v85: () = {
                    v6();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v83,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method169(
            v0_1: i32,
            v1_1: string,
            v2: string,
            v3: string,
            v4: bool,
            v5: string,
        ) -> string {
            let v7: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method170(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_rust / cargo error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure82(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: i32,
            v4: string,
            v5: string,
            unitVar: (),
        ) {
            fn v7() {
                Spiral_builder::closure2((), ());
            }
            let v8: () = {
                v7();
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
            let v40: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v40,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v47: () = {
                    v7();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v61: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v84: string = Spiral_builder::method170(
                    Spiral_builder::method7(
                        v61.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v61.l0.get().clone(),
                    Spiral_builder::method169(v3, v1_1, v4, v5, v0_1, sprintf!("\n{}", v2)),
                );
                let v86: () = {
                    v7();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v84,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method171(v0_1: string, v1_1: LrcPtr<Spiral_builder::UH4>) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn method172(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_rust / cleanup"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure83(
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
            fn v12() {
                Spiral_builder::closure2((), ());
            }
            let v13: () = {
                v12();
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
            let v45: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                0_i32
                    >= find(
                        v45,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v52: () = {
                    v12();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v66: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v94: string = Spiral_builder::method172(
                    Spiral_builder::method7(
                        v66.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method47(),
                    v66.l0.get().clone(),
                    Spiral_builder::method171(
                        v0_1,
                        LrcPtr::new(Spiral_builder::UH4::UH4_1(
                            v1_1,
                            v2,
                            LrcPtr::new(Spiral_builder::UH4::UH4_1(
                                v3,
                                v4,
                                LrcPtr::new(Spiral_builder::UH4::UH4_1(
                                    v5,
                                    v6,
                                    LrcPtr::new(Spiral_builder::UH4::UH4_1(
                                        v7,
                                        v8,
                                        LrcPtr::new(Spiral_builder::UH4::UH4_1(
                                            v9,
                                            v10,
                                            LrcPtr::new(Spiral_builder::UH4::UH4_0),
                                        )),
                                    )),
                                )),
                            )),
                        )),
                    ),
                );
                let v96: () = {
                    v12();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v94,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method173(v0_1: LrcPtr<Spiral_builder::UH4>) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH4>> = MutCell::new(v0_1.clone());
            '_method173: loop {
                break '_method173 (match v0_1.get().clone().as_ref() {
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
                            continue '_method173;
                        }
                    }
                });
            }
        }
        pub fn method174(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure85(unitVar: (), v0_1: std::fs::FileType) -> Spiral_builder::US39 {
            Spiral_builder::US39::US39_0(v0_1)
        }
        pub fn closure86(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US39 {
            Spiral_builder::US39::US39_1(v0_1)
        }
        pub fn method175(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method176(v0_1: Spiral_builder::US40) -> Spiral_builder::US40 {
            v0_1
        }
        pub fn method177(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn closure84(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(async {
                //;
                let v4: bool = true;
                let __future_init = Box::pin(async move {
                    //;
                    let v5: async_walkdir::DirEntry = Spiral_builder::method174(v0_1.clone());
                    let v7: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v5));
                    let v9: Result<std::fs::FileType, std::io::Error> = v7.await;
                    let v10 = Spiral_builder::method43();
                    let v12: Result<std::fs::FileType, std::string::String> =
                        v9.map_err(|x| v10(x));
                    let v15: Spiral_builder::US39 = match &v12 {
                        Err(v12_1_0) => Spiral_builder::closure86((), v12_1_0.clone()),
                        Ok(v12_0_0) => Spiral_builder::closure85((), v12_0_0.clone()),
                    };
                    let v94: Spiral_builder::US40 = Spiral_builder::method176(
                        if let Spiral_builder::US39::US39_0(v15_0_0) = &v15 {
                            let v17: std::fs::FileType = Spiral_builder::method175(match &v15 {
                                Spiral_builder::US39::US39_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v17) == false {
                                Spiral_builder::US40::US40_0
                            } else {
                                let v23: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v0_1.clone());
                                let v25: std::path::Display = v23.display();
                                let v28: std::string::String = format!("{}", v25);
                                if startsWith(
                                    Spiral_builder::method37(
                                        fable_library_rust::String_::fromString(v28),
                                    ),
                                    string("fable-library-ts."),
                                    false,
                                ) {
                                    Spiral_builder::US40::US40_2
                                } else {
                                    Spiral_builder::US40::US40_1
                                }
                            }
                        } else {
                            let v59: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                            let v61: std::path::Display = v59.display();
                            let v64: std::string::String = format!("{}", v61);
                            if startsWith(
                                Spiral_builder::method37(fable_library_rust::String_::fromString(
                                    v64,
                                )),
                                string("fable-library-ts."),
                                false,
                            ) {
                                Spiral_builder::US40::US40_2
                            } else {
                                Spiral_builder::US40::US40_1
                            }
                        },
                    );
                    let v98: string = string("true; v94 });  // rust.fix_closure\'");
                    let v99: bool = true;
                    v94
                }); // rust.fix_closure';
                let v101 = __future_init;
                let v103: std::pin::Pin<
                    Box<dyn std::future::Future<Output = Spiral_builder::US40> + Send>,
                > = v101;
                let v105: Spiral_builder::US40 = v103.await;
                let v115: async_walkdir::Filtering = Spiral_builder::method177(match &v105 {
                    Spiral_builder::US40::US40_0 => async_walkdir::Filtering::Ignore,
                    Spiral_builder::US40::US40_1 => async_walkdir::Filtering::IgnoreDir,
                    _ => async_walkdir::Filtering::Continue,
                });
                let v117: string = string("true; v115 });  // rust.fix_closure\'");
                let v118: bool = true;
                v115
            }); // rust.fix_closure';
            let v120 = __future_init;
            v120
        }
        pub fn closure88(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method179() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Spiral_builder::closure88((), v))
        }
        pub fn closure89(unitVar: (), v0_1: async_walkdir::DirEntry) -> Spiral_builder::US41 {
            Spiral_builder::US41::US41_0(v0_1)
        }
        pub fn closure90(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US41 {
            Spiral_builder::US41::US41_1(v0_1)
        }
        pub fn closure91(v0_1: std::string::String, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    string("spiral_builder.process_typescript / stream_filter_map"),
                    v56.l0.get().clone(),
                    Spiral_builder::method89(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure87(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<(string, string)> {
            let v1_1 = Spiral_builder::method179();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Spiral_builder::US41 = match &v3 {
                Err(v3_1_0) => Spiral_builder::closure90((), v3_1_0.clone()),
                Ok(v3_0_0) => Spiral_builder::closure89((), v3_0_0.clone()),
            };
            let v262: Spiral_builder::US42 = match &v6 {
                Spiral_builder::US41::US41_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    let v11: std::path::Display = v9.display();
                    let v14: std::string::String = format!("{}", v11);
                    let v34: string = fable_library_rust::String_::fromString(v14);
                    let v36: string = sprintf!("fable-library-{}\\.(?<a>[\\d.]+)$", string("ts"));
                    let v38: Result<regex::Regex, regex::Error> = regex::Regex::new(&v36);
                    let v40: regex::Regex = v38.unwrap();
                    let v42: &str = &*v34.clone();
                    let v44: std::string::String = String::from(v42);
                    let v46: bool = true;
                    let _capture_move = (move || {
                        //;
                        let v48: Box<std::string::String> = Box::new(v44);
                        let v50: &'static mut std::string::String = Box::leak(v48);
                        let v52: regex::CaptureMatches = v40.captures_iter(v50);
                        let v54: bool = true;
                        let _regex_captures: Vec<_> = v52
                            .map(|x| {
                                //;
                                let v56: regex::Captures<'static> = x;
                                let v58: Box<regex::Captures<'static>> = Box::new(v56);
                                let v60: &'static mut regex::Captures<'static> = Box::leak(v58);
                                let v62: regex::CaptureNames = v40.capture_names();
                                let v64: bool = true;
                                let _regex_captures: std::collections::HashMap<_, _> = v62
                                    .map(|x| {
                                        //;
                                        let v66: string = x.unwrap_or("").to_string().into();
                                        let v68: string = v66.clone().clone();
                                        let v70: string = v60
                                            .name(&v66)
                                            .map(|x| x.as_str())
                                            .unwrap_or("")
                                            .to_string()
                                            .into();
                                        let v73: bool = true;
                                        LrcPtr::new((v68, v70))
                                    })
                                    .map(|x| {
                                        std::sync::Arc::try_unwrap(x)
                                            .unwrap_or_else(|x| (*x).clone())
                                    })
                                    .collect();
                                let v75: std::collections::HashMap<string, string> =
                                    _regex_captures;
                                let v77: bool = true;
                                v75
                            })
                            .collect::<Vec<_>>();
                        let v79: Vec<std::collections::HashMap<string, string>> = _regex_captures;
                        let v81: bool = true;
                        v79
                    })();
                    let v83: Vec<std::collections::HashMap<string, string>> = _capture_move;
                    let v86: Option<std::collections::HashMap<string, string>> =
                        tryItem(0_i32, fable_library_rust::NativeArray_::array_from(v83));
                    let v100: Spiral_builder::US37 = defaultValue(
                        Spiral_builder::US37::US37_1,
                        map(Spiral_builder::method159(), v86),
                    );
                    let v128: Spiral_builder::US38 = match &v100 {
                        Spiral_builder::US37::US37_0(v100_0_0) => {
                            let v105: string = Spiral_builder::method160();
                            let v107: Option<string> = std::collections::HashMap::get(
                                &match &v100 {
                                    Spiral_builder::US37::US37_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                &v105,
                            )
                            .map(|x| x)
                            .cloned();
                            Spiral_builder::US38::US38_0(defaultValue(
                                Spiral_builder::US1::US1_1,
                                map(Spiral_builder::method5(), v107),
                            ))
                        }
                        _ => Spiral_builder::US38::US38_1,
                    };
                    let v135: Spiral_builder::US1 =
                        if let Spiral_builder::US38::US38_0(v128_0_0) = &v128 {
                            let v129: Spiral_builder::US1 = match &v128 {
                                Spiral_builder::US38::US38_0(x) => x.clone(),
                                _ => unreachable!(),
                            };
                            if let Spiral_builder::US1::US1_0(v129_0_0) = &v129 {
                                Spiral_builder::US1::US1_0(match &v129 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            } else {
                                Spiral_builder::US1::US1_1
                            }
                        } else {
                            Spiral_builder::US1::US1_1
                        };
                    match &v135 {
                        Spiral_builder::US1::US1_0(v135_0_0) => Spiral_builder::US42::US42_0(
                            v34,
                            match &v135 {
                                Spiral_builder::US1::US1_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                        ),
                        _ => Spiral_builder::US42::US42_1,
                    }
                }
                Spiral_builder::US41::US41_1(v6_1_0) => {
                    let v144: () = {
                        Spiral_builder::closure91(v6_1_0.clone(), ());
                        ()
                    };
                    Spiral_builder::US42::US42_1
                }
            };
            match &v262 {
                Spiral_builder::US42::US42_0(v262_0_0, v262_0_1) => Some((
                    match &v262 {
                        Spiral_builder::US42::US42_0(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    match &v262 {
                        Spiral_builder::US42::US42_0(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                )),
                _ => None::<(string, string)>,
            }
        }
        pub fn method178(
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<(string, string)>>
        {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Spiral_builder::closure87((), v)
                },
            )
        }
        pub fn closure92(unitVar: (), _arg: (string, string)) -> (string, string) {
            (_arg.0.clone(), _arg.1.clone())
        }
        pub fn closure93(unitVar: (), _arg: (string, string)) -> Spiral_builder::US42 {
            Spiral_builder::US42::US42_0(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method180() -> Func1<(string, string), Spiral_builder::US42> {
            Func1::new(move |arg10_0040: (string, string)| {
                Spiral_builder::closure93((), arg10_0040)
            })
        }
        pub fn method181(v0_1: Spiral_builder::US42) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure94(v0_1: Spiral_builder::US42, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.process_typescript"),
                    v56.l0.get().clone(),
                    Spiral_builder::method181(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure95(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v83: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    string("spiral_builder.process_typescript"),
                    v57.l0.get().clone(),
                    Spiral_builder::method152(v1_1, v0_1),
                );
                let v85: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v83,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method182(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
        pub fn closure96(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.process_typescript"),
                    v56.l0.get().clone(),
                    Spiral_builder::method182(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method183(
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
                        Spiral_builder::method183(
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
        pub fn method184(
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
                    Spiral_builder::method184(
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(_, _, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure97(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32))),
            )
        }
        pub fn method185(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
            let v65: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v35)),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v83: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("new_code_path")), ());
                ()
            };
            let v91: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v99: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v107: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v116: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    sprintf!("{}", string("external_command")),
                    (),
                );
                ()
            };
            let v124: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v132: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v140: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v149: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string("run_result")), ());
                ()
            };
            let v157: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v165: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v174: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method186(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_typescript / Exception"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure99(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = Spiral_builder::method186(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v59.l0.get().clone(),
                    Spiral_builder::method185(v3, v0_1, v2, v1_1),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure98(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US1 {
            let v6: () = {
                Spiral_builder::closure99(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US1::US1_1
        }
        pub fn method187(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_typescript / error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure100(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = Spiral_builder::method187(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v59.l0.get().clone(),
                    Spiral_builder::method112(v2, v1_1, v0_1, v3),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure101(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v83: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    string("spiral_builder.process_python"),
                    v57.l0.get().clone(),
                    Spiral_builder::method152(v1_1, v0_1),
                );
                let v85: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v83,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure102(v0_1: string, unitVar: ()) {
            fn v2() {
                Spiral_builder::closure2((), ());
            }
            let v3: () = {
                v2();
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
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v35,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v42: () = {
                    v2();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v56: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v82: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v56.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.process_python"),
                    v56.l0.get().clone(),
                    Spiral_builder::method182(v0_1),
                );
                let v84: () = {
                    v2();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v82,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure103(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32))),
            )
        }
        pub fn method188(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_python / Exception"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure105(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = Spiral_builder::method188(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v59.l0.get().clone(),
                    Spiral_builder::method185(v3, v0_1, v2, v1_1),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure104(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US1 {
            let v6: () = {
                Spiral_builder::closure105(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US1::US1_1
        }
        pub fn method189(v0_1: string, v1_1: string, v2: i64, v3: string) -> string {
            trimEndChars(
                trimStartChars(
                    sprintf!(
                        "{} {} #{} {} / {}",
                        v0_1,
                        v1_1,
                        v2,
                        string("spiral_builder.process_python / error"),
                        v3
                    ),
                    toArray(empty::<char>()),
                ),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn closure106(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            fn v5() {
                Spiral_builder::closure2((), ());
            }
            let v6: () = {
                v5();
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
            let v38: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                4_i32
                    >= find(
                        v38,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v45: () = {
                    v5();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v59: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v81: string = Spiral_builder::method189(
                    Spiral_builder::method7(
                        v59.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method44(),
                    v59.l0.get().clone(),
                    Spiral_builder::method112(v2, v1_1, v0_1, v3),
                );
                let v83: () = {
                    v5();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v81,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn method190(v0_1: std::string::String, v1_1: clap::ArgMatches) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
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
            let v63: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v33)),
                    (),
                );
                ()
            };
            let v72: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("; ")), ());
                ()
            };
            let v81: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string("arg_matches")), ());
                ()
            };
            let v89: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" = ")), ());
                ()
            };
            let v94: std::string::String = format!("{:#?}", v1_1);
            let v124: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    sprintf!("{}", fable_library_rust::String_::fromString(v94)),
                    (),
                );
                ()
            };
            let v133: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", string(" }")), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn closure107(v0_1: clap::ArgMatches, v1_1: std::string::String, unitVar: ()) {
            fn v3() {
                Spiral_builder::closure2((), ());
            }
            let v4: () = {
                v3();
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
            let v36: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if if (patternInput.2.clone()).l0.get().clone() == false {
                false
            } else {
                1_i32
                    >= find(
                        v36,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                            LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                        ])))),
                    )
            } {
                let v43: () = {
                    v3();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                let v57: LrcPtr<Spiral_builder::Mut0> = patternInput_1.0.clone();
                let v83: string = Spiral_builder::method15(
                    Spiral_builder::method7(
                        v57.clone(),
                        patternInput_1.1.clone(),
                        patternInput_1.2.clone(),
                        patternInput_1.3.clone(),
                        patternInput_1.4.clone(),
                        patternInput_1.5.clone(),
                    ),
                    Spiral_builder::method11(),
                    string("spiral_builder.run / invalid subcommand"),
                    v57.l0.get().clone(),
                    Spiral_builder::method190(v1_1, v0_1),
                );
                let v85: () = {
                    v3();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Spiral_builder::Mut0>,
                    LrcPtr<Spiral_builder::Mut1>,
                    LrcPtr<Spiral_builder::Mut2>,
                    LrcPtr<Spiral_builder::Mut3>,
                    LrcPtr<Spiral_builder::Mut4>,
                    Option<i64>,
                ) = getValue(Spiral_builder::TraceState::trace_state().get().clone());
                Spiral_builder::method16(
                    v83,
                    patternInput_2.0.clone(),
                    patternInput_2.1.clone(),
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            }
        }
        pub fn closure108(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v3: &str = &*_arg.0.clone();
            let v5: std::string::String = String::from(v3);
            let v7: &str = &*_arg.1.clone();
            LrcPtr::new((v5, String::from(v7)))
        }
        pub fn closure109(unitVar: (), v0_1: serde_json::Error) -> string {
            let v3: std::string::String = format!("{}", v0_1);
            fable_library_rust::String_::fromString(v3)
        }
        pub fn method191() -> Func1<serde_json::Error, string> {
            Func1::new(move |v: serde_json::Error| Spiral_builder::closure109((), v))
        }
        pub fn method192(v0_1: Result<string, string>) -> Result<string, string> {
            v0_1
        }
        pub fn method17(
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
                let v21: Spiral_builder::US4 = defaultValue(
                    Spiral_builder::US4::US4_1,
                    map(Spiral_builder::method18(), v6),
                );
                let v6191: Array<(string, string)> = if let Spiral_builder::US4::US4_0(
                    v21_0_0,
                    v21_0_1,
                ) = &v21
                {
                    let v26: clap::ArgMatches = match &v21 {
                        Spiral_builder::US4::US4_0(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v25: std::string::String = match &v21 {
                        Spiral_builder::US4::US4_0(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if fable_library_rust::String_::fromString(v25.clone()) == string("cuda") {
                        let v30: string = Spiral_builder::method19();
                        let v32: &str = &*v30;
                        let v34: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v26.clone(), v32).cloned();
                        let v48: Spiral_builder::US5 = defaultValue(
                            Spiral_builder::US5::US5_1,
                            map(Spiral_builder::method20(), v34),
                        );
                        let v55: std::string::String = match &v48 {
                            Spiral_builder::US5::US5_0(v48_0_0) => match &v48 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v57: string = fable_library_rust::String_::fromString(v55);
                        let v58: string = Spiral_builder::method21();
                        let v60: &str = &*v58;
                        let v62: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v26.clone(), v60).cloned();
                        let v76: Spiral_builder::US5 = defaultValue(
                            Spiral_builder::US5::US5_1,
                            map(Spiral_builder::method20(), v62),
                        );
                        let v105: Spiral_builder::US6 = match &v76 {
                            Spiral_builder::US5::US5_0(v76_0_0) => {
                                let v82: string =
                                    fable_library_rust::String_::fromString(match &v76 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    });
                                let v87: Spiral_builder::US7 = if string("Pip") == v82.clone() {
                                    Spiral_builder::US7::US7_0(Spiral_builder::US8::US8_0)
                                } else {
                                    Spiral_builder::US7::US7_1
                                };
                                Spiral_builder::US6::US6_0(match &v87 {
                                    Spiral_builder::US7::US7_0(v87_0_0) => {
                                        Spiral_builder::US7::US7_0(match &v87 {
                                            Spiral_builder::US7::US7_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v94: Spiral_builder::US7 = if string("Poetry") == v82 {
                                            Spiral_builder::US7::US7_0(Spiral_builder::US8::US8_1)
                                        } else {
                                            Spiral_builder::US7::US7_1
                                        };
                                        match &v94 {
                                            Spiral_builder::US7::US7_0(v94_0_0) => {
                                                Spiral_builder::US7::US7_0(match &v94 {
                                                    Spiral_builder::US7::US7_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => Spiral_builder::US7::US7_1,
                                        }
                                    }
                                })
                            }
                            _ => Spiral_builder::US6::US6_1,
                        };
                        let v112: Spiral_builder::US7 =
                            if let Spiral_builder::US6::US6_0(v105_0_0) = &v105 {
                                let v106: Spiral_builder::US7 = match &v105 {
                                    Spiral_builder::US6::US6_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                if let Spiral_builder::US7::US7_0(v106_0_0) = &v106 {
                                    Spiral_builder::US7::US7_0(match &v106 {
                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                } else {
                                    Spiral_builder::US7::US7_1
                                }
                            } else {
                                Spiral_builder::US7::US7_1
                            };
                        let v116: Spiral_builder::US8 = match &v112 {
                            Spiral_builder::US7::US7_0(v112_0_0) => match &v112 {
                                Spiral_builder::US7::US7_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => Spiral_builder::US8::US8_0,
                        };
                        let v117: string = Spiral_builder::method22();
                        let v119: &str = &*v117;
                        let v121: Option<Vec<std::string::String>> =
                            clap::ArgMatches::get_many(&v26.clone(), v119)
                                .map(|x| x.cloned().into_iter().collect());
                        let v135: Spiral_builder::US9 = defaultValue(
                            Spiral_builder::US9::US9_1,
                            map(Spiral_builder::method23(), v121),
                        );
                        let v141: Vec<std::string::String> =
                            new_empty::<std::string::String>().to_vec();
                        let v144: Vec<std::string::String> = match &v135 {
                            Spiral_builder::US9::US9_0(v135_0_0) => match &v135 {
                                Spiral_builder::US9::US9_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v141,
                        };
                        let v148: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v57.clone());
                        let v171: Vec<u8> = Spiral_builder::method24(v148.unwrap());
                        let v173: Result<std::string::String, std::string::FromUtf8Error> =
                            std::string::String::from_utf8(v171);
                        let v175: std::string::String = v173.unwrap();
                        let v177: string = fable_library_rust::String_::fromString(v175);
                        let v200: Spiral_builder::US12 = Spiral_builder::method28(
                            Spiral_builder::method25(string("polyglot"), string(".devcontainer")),
                            string(
                                "/home/runner/work/polyglot/polyglot/target/Builder/spiral_builder",
                            ),
                        );
                        let v320: Spiral_builder::US1 = match &v200 {
                            Spiral_builder::US12::US12_0(v200_0_0) => {
                                Spiral_builder::US1::US1_0(v200_0_0.clone())
                            }
                            Spiral_builder::US12::US12_1(v200_1_0) => {
                                let v206: () = {
                                    Spiral_builder::closure16(v200_1_0.clone(), ());
                                    ()
                                };
                                Spiral_builder::US1::US1_1
                            }
                        };
                        let v447: Spiral_builder::US1 = match &v320 {
                            Spiral_builder::US1::US1_0(v320_0_0) => {
                                Spiral_builder::US1::US1_0(match &v320 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v323: string = Spiral_builder::method36();
                                let v325: Spiral_builder::US12 = Spiral_builder::method28(
                                    Spiral_builder::method25(
                                        string("polyglot"),
                                        string(".devcontainer"),
                                    ),
                                    v323,
                                );
                                match &v325 {
                                    Spiral_builder::US12::US12_0(v325_0_0) => {
                                        Spiral_builder::US1::US1_0(v325_0_0.clone())
                                    }
                                    Spiral_builder::US12::US12_1(v325_1_0) => {
                                        let v331: () = {
                                            Spiral_builder::closure16(v325_1_0.clone(), ());
                                            ()
                                        };
                                        Spiral_builder::US1::US1_1
                                    }
                                }
                            }
                        };
                        let v452: string = Spiral_builder::method25(
                            match &v447 {
                                Spiral_builder::US1::US1_0(v447_0_0) => match &v447 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            },
                            string("polyglot"),
                        );
                        let v455: string = toLower(Spiral_builder::method36());
                        let v459: string = toLower(v452);
                        let v467: Spiral_builder::US12 = if startsWith(v455, v459.clone(), false) {
                            Spiral_builder::US12::US12_1(v459.clone())
                        } else {
                            Spiral_builder::US12::US12_0(v459)
                        };
                        let v473: Result<string, string> = match &v467 {
                            Spiral_builder::US12::US12_0(v467_0_0) => {
                                Ok::<string, string>(v467_0_0.clone())
                            }
                            Spiral_builder::US12::US12_1(v467_1_0) => {
                                Err::<string, string>(v467_1_0.clone())
                            }
                        };
                        let v475: bool = true;
                        let _result_unwrap_or_else = v473.unwrap_or_else(|x| {
                            //;
                            let v477: string = x;
                            let v479: bool = true;
                            v477
                        });
                        let v481: string = _result_unwrap_or_else;
                        let v482: string = Spiral_builder::method37(v57.clone());
                        let v488: string = match &v116 {
                            Spiral_builder::US8::US8_1 => {
                                Spiral_builder::method25(v482.clone(), string("pyproject.toml"))
                            }
                            _ => Spiral_builder::method25(v482.clone(), string("requirements.txt")),
                        };
                        let v490: bool = true;
                        let _vec_map: Vec<_> = v144
                            .into_iter()
                            .map(|x| {
                                //;
                                let v492: std::string::String = x;
                                let v494: string = fable_library_rust::String_::fromString(v492);
                                let v507: string = if contains(v494.clone(), string("=")) {
                                    v494.clone()
                                } else {
                                    if endsWith(v494.clone(), string("]"), false) {
                                        sprintf!(
                                            "{}}}",
                                            replace(
                                                v494.clone(),
                                                string("["),
                                                string("={version=\'*\',features=[")
                                            )
                                        )
                                    } else {
                                        sprintf!("{}=\'*\'", v494)
                                    }
                                };
                                let v509: bool = true;
                                v507
                            })
                            .collect::<Vec<_>>();
                        let v511: Vec<string> = _vec_map;
                        let v513: Array<string> =
                            fable_library_rust::NativeArray_::array_from(v511);
                        let v520: string = join(
                            string("\n"),
                            toArray_1(delay(Func0::new({
                                let v513 = v513.clone();
                                move || {
                                    map_1(
                                        Func1::new({
                                            let v513 = v513.clone();
                                            move |i: i32| v513[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v513.clone()) - 1_i32),
                                    )
                                }
                            }))),
                        );
                        let patternInput: (i32, string) = if v520.clone() == string("") {
                            (0_i32, string(""))
                        } else {
                            Spiral_builder::method38(v488,
                                                         match &v116 {
                                                             Spiral_builder::US8::US8_1
                                                             =>
                                                             append(append(append(append(append(append(append(append(append(string("[tool.poetry]\nname = \"test\"\nversion = \"0.0.1\"\ndescription = \"\"\nauthors = []\n\n[tool.poetry.dependencies]\npython=\"~3.12\"\n"),
                                                                                                                            sprintf!("{}",
                                                                                                                                     v520.clone())),
                                                                                                                     string("\n")),
                                                                                                              string("")),
                                                                                                       string("\n")),
                                                                                                string("[build-system]")),
                                                                                         string("\n")),
                                                                                  string("requires = [\"poetry-core\"]")),
                                                                           string("\n")),
                                                                    string("build-backend = \"poetry.core.masonry.api\"")),
                                                             _ =>
                                                             v520.clone(),
                                                         });
                            Spiral_builder::method61(
                                match &v116 {
                                    Spiral_builder::US8::US8_1 => string("poetry install"),
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
                                Some(v482.clone()),
                            )
                        };
                        let v579: i32 = patternInput.0.clone();
                        let patternInput_4: (
                            Spiral_builder::US1,
                            Spiral_builder::US1,
                            Spiral_builder::US1,
                        ) = if v579 != 0_i32 {
                            let v586: () = {
                                Spiral_builder::closure57(
                                    v116.clone(),
                                    v57.clone(),
                                    patternInput.1.clone(),
                                    v579,
                                    (),
                                );
                                ()
                            };
                            (
                                Spiral_builder::US1::US1_0(string("py")),
                                Spiral_builder::US1::US1_1,
                                Spiral_builder::US1::US1_1,
                            )
                        } else {
                            let v705: string = match &v116 {
                                Spiral_builder::US8::US8_1 => {
                                    sprintf!("poetry run python \"{}\"", v57.clone())
                                }
                                _ => sprintf!("python \"{}\"", v57.clone()),
                            };
                            let v708: Array<(string, string)> =
                                new_array(&[(string("TRACE_LEVEL"), string("Verbose"))]);
                            let patternInput_1: (i32, string) = Spiral_builder::method61(
                                v705.clone(),
                                None::<CancellationToken>,
                                v708.clone(),
                                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                                None::<
                                    Func1<
                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                        (),
                                    >,
                                >,
                                true,
                                Some(v482.clone()),
                            );
                            let v719: string = patternInput_1.1.clone();
                            let v718: i32 = patternInput_1.0.clone();
                            let v720: i32 = count_2(v708.clone());
                            let v721: Array<string> = new_init(&string(""), v720);
                            let v722: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method64(v720, v722.clone()) {
                                let v724: i32 = v722.l0.get().clone();
                                let patternInput_2: (string, string) = v708[v724].clone();
                                let v727: string = sprintf!(
                                    "$env:{}=\'\'{}\'\'",
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone()
                                );
                                v721.get_mut()[v724 as usize] = v727;
                                {
                                    let v728: i32 = v724 + 1_i32;
                                    v722.l0.set(v728);
                                    ()
                                }
                            }
                            {
                                let v738: string = sprintf!(
                                    "pwsh -c \'{}; {}\'",
                                    join(string(";"), toArray_1(ofArray_1(v721.clone()))),
                                    v705
                                );
                                let patternInput_3: (
                                    Spiral_builder::US1,
                                    Spiral_builder::US1,
                                    Spiral_builder::US1,
                                ) = if if v718 == 0_i32 {
                                    true
                                } else {
                                    contains(v719.clone(),
                                                        string("cupy_backends.cuda.api.runtime.CUDARuntimeError: cudaErrorInsufficientDriver"))
                                } {
                                    let result: LrcPtr<MutCell<Spiral_builder::US1>> =
                                        refCell(Spiral_builder::US1::US1_1);
                                    try_catch(
                                        || {
                                            result.set(Spiral_builder::closure58(
                                                (),
                                                Spiral_builder::closure59(v719.clone(), ()),
                                            ))
                                        },
                                        |ex: LrcPtr<Exception>| {
                                            result.set(Spiral_builder::closure60(
                                                v57.clone(),
                                                v719.clone(),
                                                v738.clone(),
                                                ex.clone(),
                                            ))
                                        },
                                    );
                                    {
                                        let v749: Spiral_builder::US1 = result.get().clone();
                                        let v759: Option<string> = match &v749 {
                                            Spiral_builder::US1::US1_0(v749_0_0) => {
                                                Some(match &v749 {
                                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => None::<string>,
                                        };
                                        (
                                            Spiral_builder::US1::US1_0(string("py")),
                                            Spiral_builder::US1::US1_0(v177),
                                            Spiral_builder::US1::US1_0(v759.unwrap()),
                                        )
                                    }
                                } else {
                                    let v768: () = {
                                        Spiral_builder::closure62(
                                            v57.clone(),
                                            v719,
                                            v718,
                                            v738,
                                            (),
                                        );
                                        ()
                                    };
                                    (
                                        Spiral_builder::US1::US1_0(string("py")),
                                        Spiral_builder::US1::US1_1,
                                        Spiral_builder::US1::US1_1,
                                    )
                                };
                                (
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                    patternInput_3.2.clone(),
                                )
                            }
                        };
                        let v889: Spiral_builder::US1 = patternInput_4.2.clone();
                        let v888: Spiral_builder::US1 = patternInput_4.1.clone();
                        let v887: Spiral_builder::US1 = patternInput_4.0.clone();
                        let v905: Array<(string, string)> = new_array(&[
                            (
                                string("extension"),
                                match &v887 {
                                    Spiral_builder::US1::US1_0(v887_0_0) => match &v887 {
                                        Spiral_builder::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => string(""),
                                },
                            ),
                            (
                                string("code"),
                                match &v888 {
                                    Spiral_builder::US1::US1_0(v888_0_0) => match &v888 {
                                        Spiral_builder::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => string(""),
                                },
                            ),
                            (
                                string("output"),
                                match &v889 {
                                    Spiral_builder::US1::US1_0(v889_0_0) => match &v889 {
                                        Spiral_builder::US1::US1_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    _ => string(""),
                                },
                            ),
                        ]);
                        let v907: Vec<(string, string)> = v905.to_vec();
                        let v910: Vec<LrcPtr<(std::string::String, std::string::String)>> = v907
                            .into_iter()
                            .map(|x| {
                                Func1::new(move |arg10_0040_5: (string, string)| {
                                    Spiral_builder::closure63((), arg10_0040_5)
                                })(x.clone())
                            })
                            .collect::<Vec<_>>();
                        let v911: string =
                            string("std::collections::BTreeMap::from_iter(v910.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                        let v912: std::collections::BTreeMap<
                            std::string::String,
                            std::string::String,
                        > = std::collections::BTreeMap::from_iter(
                            v910.iter()
                                .map(|x| x.as_ref())
                                .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                        );
                        let v914: Result<std::string::String, serde_json::Error> =
                            serde_json::to_string(&v912);
                        let v916: std::string::String = v914.unwrap();
                        new_array(&[(
                            string("command_result"),
                            fable_library_rust::String_::fromString(v916),
                        )])
                    } else {
                        if fable_library_rust::String_::fromString(v25.clone()) == string("fable") {
                            let v924: string = Spiral_builder::method114();
                            let v926: &str = &*v924;
                            let v928: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v26.clone(), v926).cloned();
                            let v942: Spiral_builder::US5 = defaultValue(
                                Spiral_builder::US5::US5_1,
                                map(Spiral_builder::method20(), v928),
                            );
                            let v949: std::string::String = match &v942 {
                                Spiral_builder::US5::US5_0(v942_0_0) => match &v942 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v951: string = fable_library_rust::String_::fromString(v949);
                            let v952: string = Spiral_builder::method115();
                            let v954: &str = &*v952;
                            let v956: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v26.clone(), v954).cloned();
                            let v970: Spiral_builder::US5 = defaultValue(
                                Spiral_builder::US5::US5_1,
                                map(Spiral_builder::method20(), v956),
                            );
                            let v980: Spiral_builder::US1 = match &v970 {
                                Spiral_builder::US5::US5_0(v970_0_0) => Spiral_builder::US1::US1_0(
                                    fable_library_rust::String_::fromString(match &v970 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
                                ),
                                _ => Spiral_builder::US1::US1_1,
                            };
                            new_array(&[(
                                string("command_result"),
                                match &v980 {
                                    Spiral_builder::US1::US1_0(v980_0_0) => {
                                        let v982: clap::Command = Spiral_builder::method0();
                                        let v984: Spiral_builder::US22 =
                                            Spiral_builder::method75(sprintf!(
                                                "_ {} --fs-path \"{}\"",
                                                match &v980 {
                                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                v951
                                            ));
                                        let v990: Array<string> = match &v984 {
                                            Spiral_builder::US22::US22_0(v984_0_0) => {
                                                v984_0_0.clone()
                                            }
                                            Spiral_builder::US22::US22_1(v984_1_0) => panic!(
                                                "{}",
                                                sprintf!(
                                                    "resultm.get / Result value was Error: {}",
                                                    v984_1_0.clone()
                                                ),
                                            ),
                                        };
                                        let v992: Vec<string> = v990.to_vec();
                                        let v994: bool = true;
                                        let _vec_map: Vec<_> = v992
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v996: string = x;
                                                let v998: &str = &*v996;
                                                let v1000: std::string::String = String::from(v998);
                                                let v1002: bool = true;
                                                v1000
                                            })
                                            .collect::<Vec<_>>();
                                        let v1004: Vec<std::string::String> = _vec_map;
                                        let v1007: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<string, string>,
                                                >,
                                            >,
                                        > = Spiral_builder::method17(
                                            v0_1.clone(),
                                            clap::Command::get_matches_from(v982, v1004),
                                        );
                                        let v1009: Result<string, string> = v1007.await;
                                        v1009.unwrap()
                                    }
                                    _ => string("{}"),
                                },
                            )])
                        } else {
                            if fable_library_rust::String_::fromString(v25.clone()) == string("dib")
                            {
                                let v1020: string = Spiral_builder::method116();
                                let v1022: &str = &*v1020;
                                let v1024: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v26.clone(), v1022).cloned();
                                let v1026: Option<string> = map(Spiral_builder::method117(), v1024);
                                let v1040: string = v1026.unwrap();
                                let v1041: string = Spiral_builder::method125();
                                let v1043: &str = &*v1041;
                                let v1046: u8 = defaultValue(
                                    1_u8,
                                    clap::ArgMatches::get_one(&v26.clone(), v1043).cloned(),
                                );
                                let v1049: string = Spiral_builder::method126();
                                let v1051: &str = &*v1049;
                                let v1053: Option<string> =
                                    clap::ArgMatches::get_one(&v26.clone(), v1051).cloned();
                                let patternInput_5: (i32, string) = Spiral_builder::method127(
                                    defaultValue(
                                        Spiral_builder::US1::US1_1,
                                        map(Spiral_builder::method5(), v1053),
                                    ),
                                    v1046,
                                    v1040.clone(),
                                    1_u8,
                                );
                                let v1073: string = patternInput_5.1.clone();
                                let v1072: i32 = patternInput_5.0.clone();
                                let patternInput_8: (i32, string) = if v1072 != 0_i32 {
                                    (v1072, v1073.clone())
                                } else {
                                    let patternInput_6: (i32, string) =
                                            Spiral_builder::method61(sprintf!("jupyter nbconvert \"{}.ipynb\" --to html --HTMLExporter.theme=dark",
                                                                              v1040.clone()),
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
                                    let v1085: string = patternInput_6.1.clone();
                                    let v1084: i32 = patternInput_6.0.clone();
                                    let v1088: () = {
                                        Spiral_builder::closure66(v1085.clone(), v1084, ());
                                        ()
                                    };
                                    if v1084 != 0_i32 {
                                        (
                                            v1084,
                                            sprintf!(
                                                "repl_result: {}\n\njupyter_result: {}",
                                                v1073.clone(),
                                                v1085.clone()
                                            ),
                                        )
                                    } else {
                                        let patternInput_7:
                                                    (i32, string) =
                                                Spiral_builder::method61(sprintf!("pwsh -c \"$counter = 1; $path = \'{}.html\'; (Get-Content $path -Raw) -replace \'(id=\\\"cell-id=)[a-fA-F0-9]{{8}}\', {{ $_.Groups[1].Value + $counter++ }} | Set-Content $path\"",
                                                                                  replace(v1040.clone(),
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
                                        let v1220: string = patternInput_7.1.clone();
                                        let v1219: i32 = patternInput_7.0.clone();
                                        let v1223: () = {
                                            Spiral_builder::closure67(v1220.clone(), v1219, ());
                                            ()
                                        };
                                        let v1340: string = sprintf!("{}.html", v1040.clone());
                                        let v1344: Result<Vec<u8>, std::io::Error> =
                                            std::fs::read(&*v1340);
                                        let v1367: Vec<u8> =
                                            Spiral_builder::method24(v1344.unwrap());
                                        let v1369: Result<
                                            std::string::String,
                                            std::string::FromUtf8Error,
                                        > = std::string::String::from_utf8(v1367);
                                        let v1371: std::string::String = v1369.unwrap();
                                        let v1394: string = replace(
                                            fable_library_rust::String_::fromString(v1371),
                                            string("\r\n"),
                                            string("\n"),
                                        );
                                        let v1395: string = sprintf!("{}.html", v1040.clone());
                                        std::fs::write(&*v1395, &*v1394).unwrap();
                                        ();
                                        {
                                            let v1399: string = sprintf!("{}.ipynb", v1040.clone());
                                            let v1403: Result<Vec<u8>, std::io::Error> =
                                                std::fs::read(&*v1399);
                                            let v1426: Vec<u8> =
                                                Spiral_builder::method24(v1403.unwrap());
                                            let v1428: Result<
                                                std::string::String,
                                                std::string::FromUtf8Error,
                                            > = std::string::String::from_utf8(v1426);
                                            let v1430: std::string::String = v1428.unwrap();
                                            let v1454: string = replace(
                                                replace(
                                                    fable_library_rust::String_::fromString(v1430),
                                                    string("\r\n"),
                                                    string("\n"),
                                                ),
                                                string("\\r\\n"),
                                                string("\\n"),
                                            );
                                            let v1455: string = sprintf!("{}.ipynb", v1040);
                                            std::fs::write(&*v1455, &*v1454).unwrap();
                                            ();
                                            (v1219,
                                                 sprintf!("repl_result: {}\n\njupyter_result: {}\n\npwsh_replace_html_result: {}",
                                                          v1073, v1085,
                                                          v1220))
                                        }
                                    }
                                };
                                let v1463: string = patternInput_8.1.clone();
                                let v1462: i32 = patternInput_8.0.clone();
                                let v1466: () = {
                                    Spiral_builder::closure68(v1463.clone(), v1462, ());
                                    ()
                                };
                                if v1462 != 0_i32 {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "spiral_builder.run / dib / exit_code: {} / result: {}",
                                            v1462,
                                            v1463.clone()
                                        )
                                    );
                                }
                                new_array(&[(string("stdio"), v1463)])
                            } else {
                                let patternInput_31: (
                                    Spiral_builder::US1,
                                    Spiral_builder::US1,
                                    Spiral_builder::US1,
                                ) = if fable_library_rust::String_::fromString(v25.clone())
                                    == string("rust")
                                {
                                    let v1592: string = Spiral_builder::method114();
                                    let v1594: &str = &*v1592;
                                    let v1596: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1594).cloned();
                                    let v1610: Spiral_builder::US5 = defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        map(Spiral_builder::method20(), v1596),
                                    );
                                    let v1617: std::string::String = match &v1610 {
                                        Spiral_builder::US5::US5_0(v1610_0_0) => match &v1610 {
                                            Spiral_builder::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                    let v1619: string =
                                        fable_library_rust::String_::fromString(v1617);
                                    let v1620: string = Spiral_builder::method22();
                                    let v1622: &str = &*v1620;
                                    let v1624: Option<Vec<std::string::String>> =
                                        clap::ArgMatches::get_many(&v26.clone(), v1622)
                                            .map(|x| x.cloned().into_iter().collect());
                                    let v1638: Spiral_builder::US9 = defaultValue(
                                        Spiral_builder::US9::US9_1,
                                        map(Spiral_builder::method23(), v1624),
                                    );
                                    let v1644: Vec<std::string::String> =
                                        new_empty::<std::string::String>().to_vec();
                                    let v1647: Vec<std::string::String> = match &v1638 {
                                        Spiral_builder::US9::US9_0(v1638_0_0) => match &v1638 {
                                            Spiral_builder::US9::US9_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => v1644,
                                    };
                                    let v1648: string = Spiral_builder::method132();
                                    let v1650: &str = &*v1648;
                                    let v1652: bool = clap::ArgMatches::get_flag(&v26, v1650);
                                    let v1653: string = Spiral_builder::method133();
                                    let v1655: &str = &*v1653;
                                    let v1657: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1655).cloned();
                                    let v1671: Spiral_builder::US5 = defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        map(Spiral_builder::method20(), v1657),
                                    );
                                    let v1681: Spiral_builder::US1 = match &v1671 {
                                        Spiral_builder::US5::US5_0(v1671_0_0) => {
                                            Spiral_builder::US1::US1_0(
                                                fable_library_rust::String_::fromString(
                                                    match &v1671 {
                                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                ),
                                            )
                                        }
                                        _ => Spiral_builder::US1::US1_1,
                                    };
                                    let v1682: string = Spiral_builder::method134();
                                    let v1684: &str = &*v1682;
                                    let v1686: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1684).cloned();
                                    let v1700: Spiral_builder::US5 = defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        map(Spiral_builder::method20(), v1686),
                                    );
                                    let v1710: Spiral_builder::US1 = match &v1700 {
                                        Spiral_builder::US5::US5_0(v1700_0_0) => {
                                            Spiral_builder::US1::US1_0(
                                                fable_library_rust::String_::fromString(
                                                    match &v1700 {
                                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    },
                                                ),
                                            )
                                        }
                                        _ => Spiral_builder::US1::US1_1,
                                    };
                                    let v1719: Spiral_builder::US33 =
                                        if let Spiral_builder::US1::US1_0(v1681_0_0) = &v1681 {
                                            Spiral_builder::US33::US33_0(
                                                Spiral_builder::US34::US34_0(match &v1681 {
                                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }),
                                            )
                                        } else {
                                            if let Spiral_builder::US1::US1_0(v1710_0_0) = &v1710 {
                                                Spiral_builder::US33::US33_0(
                                                    Spiral_builder::US34::US34_1(match &v1710 {
                                                        Spiral_builder::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }),
                                                )
                                            } else {
                                                Spiral_builder::US33::US33_1
                                            }
                                        };
                                    let v1720: bool = if let Spiral_builder::US0::US0_0 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    };
                                    let v1724: Result<Vec<u8>, std::io::Error> =
                                        std::fs::read(&*v1619);
                                    let v1747: Vec<u8> = Spiral_builder::method24(v1724.unwrap());
                                    let v1749: Result<
                                        std::string::String,
                                        std::string::FromUtf8Error,
                                    > = std::string::String::from_utf8(v1747);
                                    let v1751: std::string::String = v1749.unwrap();
                                    let v1767: string =
                                        fable_library_rust::String_::fromString(v1751);
                                    let v1774: string =
                                        Spiral_builder::method136(Spiral_builder::method135(
                                            string("rs"),
                                            v1767.clone(),
                                            v1719.clone(),
                                        ));
                                    let v1779: Spiral_builder::US12 =
                                            Spiral_builder::method28(Spiral_builder::method25(string("polyglot"),
                                                                                              string(".devcontainer")),
                                                                     string("/home/runner/work/polyglot/polyglot/target/Builder/spiral_builder"));
                                    let v1899: Spiral_builder::US1 = match &v1779 {
                                        Spiral_builder::US12::US12_0(v1779_0_0) => {
                                            Spiral_builder::US1::US1_0(v1779_0_0.clone())
                                        }
                                        Spiral_builder::US12::US12_1(v1779_1_0) => {
                                            let v1785: () = {
                                                Spiral_builder::closure16(v1779_1_0.clone(), ());
                                                ()
                                            };
                                            Spiral_builder::US1::US1_1
                                        }
                                    };
                                    let v2026: Spiral_builder::US1 = match &v1899 {
                                        Spiral_builder::US1::US1_0(v1899_0_0) => {
                                            Spiral_builder::US1::US1_0(match &v1899 {
                                                Spiral_builder::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v1902: string = Spiral_builder::method36();
                                            let v1904: Spiral_builder::US12 =
                                                Spiral_builder::method28(
                                                    Spiral_builder::method25(
                                                        string("polyglot"),
                                                        string(".devcontainer"),
                                                    ),
                                                    v1902,
                                                );
                                            match &v1904 {
                                                Spiral_builder::US12::US12_0(v1904_0_0) => {
                                                    Spiral_builder::US1::US1_0(v1904_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v1904_1_0) => {
                                                    let v1910: () = {
                                                        Spiral_builder::closure16(
                                                            v1904_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    Spiral_builder::US1::US1_1
                                                }
                                            }
                                        }
                                    };
                                    let v2031: string = Spiral_builder::method25(
                                        match &v2026 {
                                            Spiral_builder::US1::US1_0(v2026_0_0) => match &v2026 {
                                                Spiral_builder::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        },
                                        string("polyglot"),
                                    );
                                    let v2034: string = toLower(Spiral_builder::method36());
                                    let v2038: string = toLower(v2031);
                                    let v2046: Spiral_builder::US12 =
                                        if startsWith(v2034, v2038.clone(), false) {
                                            Spiral_builder::US12::US12_1(v2038.clone())
                                        } else {
                                            Spiral_builder::US12::US12_0(v2038)
                                        };
                                    let v2052: Result<string, string> = match &v2046 {
                                        Spiral_builder::US12::US12_0(v2046_0_0) => {
                                            Ok::<string, string>(v2046_0_0.clone())
                                        }
                                        Spiral_builder::US12::US12_1(v2046_1_0) => {
                                            Err::<string, string>(v2046_1_0.clone())
                                        }
                                    };
                                    let v2054: bool = true;
                                    let _result_unwrap_or_else = v2052.unwrap_or_else(|x| {
                                        //;
                                        let v2056: string = x;
                                        let v2058: bool = true;
                                        v2056
                                    });
                                    let v2060: string = _result_unwrap_or_else;
                                    let v2069: string = Spiral_builder::method25(
                                        Spiral_builder::method25(
                                            Spiral_builder::method25(
                                                Spiral_builder::method25(
                                                    Spiral_builder::method25(
                                                        v2060.clone(),
                                                        string("target/spiral_builder"),
                                                    ),
                                                    string("spiral_builder"),
                                                ),
                                                string("packages"),
                                            ),
                                            string("Rust"),
                                        ),
                                        v1774.clone(),
                                    );
                                    let v2070: LrcPtr<dyn IDisposable> =
                                        Spiral_builder::method41(v2069.clone());
                                    let v2073: string =
                                        Spiral_builder::method121(Spiral_builder::method25(
                                            v2069.clone(),
                                            sprintf!("{}.fs", string("spiral_builder")),
                                        ));
                                    Spiral_builder::method38(v2073.clone(), v1767);
                                    {
                                        let v2074: List<string> = empty::<string>();
                                        let v2081: string = join(
                                            string("\\n        "),
                                            toArray_1(delay(Func0::new({
                                                let v2074 = v2074.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v2074 = v2074.clone();
                                                            move |i_1: i32| item(i_1, v2074.clone())
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            length_1(v2074.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }))),
                                        );
                                        let v2087: List<string> = singleton(sprintf!(
                                            "<PackageReference Include=\"{}\" Version=\"*\" />",
                                            string("Fable.Core")
                                        ));
                                        let v2095: string = join(
                                            string("\\n        "),
                                            toArray_1(delay(Func0::new({
                                                let v2087 = v2087.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v2087 = v2087.clone();
                                                            move |i_2: i32| item(i_2, v2087.clone())
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            length_1(v2087.clone()) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }))),
                                        );
                                        let v2100: string =
                                            Spiral_builder::method121(Spiral_builder::method25(
                                                v2069.clone(),
                                                sprintf!("{}.fsproj", string("spiral_builder")),
                                            ));
                                        Spiral_builder::method38(v2100.clone(),
                                                                     append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                sprintf!("    {}",
                                                                                                                                                                         v2081)),
                                                                                                                                                         string("\n")),
                                                                                                                                                  sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                           v2073)),
                                                                                                                                           string("\n")),
                                                                                                                                    string("</ItemGroup>")),
                                                                                                                             string("\n")),
                                                                                                                      string("<ItemGroup>")),
                                                                                                               string("\n")),
                                                                                                        sprintf!("    {}",
                                                                                                                 v2095)),
                                                                                                 string("\n")),
                                                                                          string("</ItemGroup>")),
                                                                                   string("\n")),
                                                                            string("</Project>")));
                                        {
                                            let v2200: string = Spiral_builder::method25(
                                                v2069.clone(),
                                                string("../../.."),
                                            );
                                            let v2202: string = Spiral_builder::method25(
                                                v2200.clone(),
                                                string("Cargo.toml"),
                                            );
                                            if Spiral_builder::method40(v2202.clone()) == false {
                                                let v2205: DateTime = DateTime::now();
                                                let v2214: string = toString(
                                                    Spiral_builder::method139(new_guid(), v2205),
                                                );
                                                let v2238: string =
                                                        append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                   sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                            v2214.clone())),
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
                                                                                      v2214)),
                                                                      string("\n")),
                                                               string("path = \"spiral_builder.rs\""));
                                                std::fs::write(&*v2202.clone(), &*v2238).unwrap();
                                                ();
                                                ()
                                            }
                                            {
                                                let v2242: string = Spiral_builder::method25(
                                                    v2069.clone(),
                                                    string("Cargo.toml"),
                                                );
                                                if Spiral_builder::method40(v2242.clone()) == false
                                                {
                                                    let v2245: DateTime = DateTime::now();
                                                    let v2254: string =
                                                        toString(Spiral_builder::method139(
                                                            new_guid(),
                                                            v2245,
                                                        ));
                                                    let v2278: string =
                                                            append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                       sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                v2254.clone())),
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
                                                                                          v2254)),
                                                                          string("\n")),
                                                                   string("path = \"spiral_builder.rs\""));
                                                    std::fs::write(&*v2242.clone(), &*v2278)
                                                        .unwrap();
                                                    ();
                                                    ()
                                                }
                                                {
                                                    let v2283: string =
                                                            Spiral_builder::method25(v2060.clone(),
                                                                                     string("lib/rust/fable/fable_modules/fable-library-rust"));
                                                    let v2285: string = Spiral_builder::method25(
                                                        v2069.clone(),
                                                        string("fable_modules/fable-library-rust"),
                                                    );
                                                    Spiral_builder::method144(v2283, v2285.clone());
                                                    {
                                                        let patternInput_9: (i32, string) =
                                                            Spiral_builder::method145(
                                                                v1719.clone(),
                                                                v2069.clone(),
                                                                string("rs"),
                                                                v2100,
                                                                v2046.clone(),
                                                            );
                                                        let v2287: string =
                                                            patternInput_9.1.clone();
                                                        let v2286: i32 = patternInput_9.0.clone();
                                                        let patternInput_18: (
                                                            Spiral_builder::US1,
                                                            Spiral_builder::US1,
                                                            Spiral_builder::US1,
                                                        ) = if v2286 != 0_i32 {
                                                            let v2293: () = {
                                                                Spiral_builder::closure71(
                                                                    v2287.clone(),
                                                                    v2286,
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            (
                                                                Spiral_builder::US1::US1_0(string(
                                                                    "rs",
                                                                )),
                                                                Spiral_builder::US1::US1_1,
                                                                Spiral_builder::US1::US1_0(v2287),
                                                            )
                                                        } else {
                                                            let v2435:
                                                                            Vec<std::string::String> =
                                                                        if if let Spiral_builder::US33::US33_1
                                                                                  =
                                                                                  &v1719
                                                                              {
                                                                               true
                                                                           } else {
                                                                               false
                                                                           } {
                                                                            v1647.clone()
                                                                        } else {
                                                                            let v2409 =
                                                                                Spiral_builder::method154();
                                                                            let v2410:
                                                                                    Vec<std::string::String> =
                                                                                Spiral_builder::method155(v1647.clone());
                                                                            let v2412:
                                                                                    Vec<std::string::String> =
                                                                                v2410.into_iter().filter(|x| v2409(x.clone().clone())).collect::<Vec<_>>();
                                                                            if v2412.len()
                                                                                   as
                                                                                   i32
                                                                                   >
                                                                                   0_i32
                                                                               {
                                                                                v1647.clone()
                                                                            } else {
                                                                                let v2420:
                                                                                        &str =
                                                                                    &*string("near-sdk");
                                                                                let v2423:
                                                                                        Array<std::string::String> =
                                                                                    new_array(&[String::from(v2420)]);
                                                                                let v2426:
                                                                                        Vec<std::string::String> =
                                                                                    Spiral_builder::method156(v2423.to_vec());
                                                                                let v2427:
                                                                                        Vec<std::string::String> =
                                                                                    Spiral_builder::method157(v1647);
                                                                                let v2429:
                                                                                        bool =
                                                                                    true; let mut v2427 = v2427;
                                                                                let v2431:
                                                                                        bool =
                                                                                    true; v2427.extend(v2426);
                                                                                v2427
                                                                            }
                                                                        };
                                                            let v2437: bool = true;
                                                            let _vec_map : Vec<_> = v2435.into_iter().map(|x| { //;
                                                                    let v2439:
                                                                            std::string::String =
                                                                        x;
                                                                    let v2441:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v2439);
                                                                    let v2454:
                                                                            string =
                                                                        if contains(v2441.clone(),
                                                                                    string("="))
                                                                           {
                                                                            v2441.clone()
                                                                        } else {
                                                                            if endsWith(v2441.clone(),
                                                                                        string("]"),
                                                                                        false)
                                                                               {
                                                                                sprintf!("{}}}",
                                                                                         replace(v2441.clone(),
                                                                                                 string("["),
                                                                                                 string("={version=\'*\',features=[")))
                                                                            } else {
                                                                                sprintf!("{}=\'*\'",
                                                                                         v2441)
                                                                            }
                                                                        };
                                                                    let v2456:
                                                                            bool =
                                                                        true; v2454 }).collect::<Vec<_>>();
                                                            let v2458: Vec<string> = _vec_map;
                                                            let v2460:
                                                                            Array<string> =
                                                                        fable_library_rust::NativeArray_::array_from(v2458);
                                                            let v2514:
                                                                            string =
                                                                        append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                                                                                           sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                                                                                    v1774.clone())),
                                                                                                                                                                                                                    string("\n")),
                                                                                                                                                                                                             string("version = \"0.0.1\"")),
                                                                                                                                                                                                      string("\n")),
                                                                                                                                                                                               string("edition = \"2021\"")),
                                                                                                                                                                                        string("\n")),
                                                                                                                                                                                 string("")),
                                                                                                                                                                          string("\n")),
                                                                                                                                                                   string("[dependencies]")),
                                                                                                                                                            string("\n")),
                                                                                                                                                     (if if let Spiral_builder::US33::US33_1
                                                                                                                                                                =
                                                                                                                                                                &v1719
                                                                                                                                                            {
                                                                                                                                                             true
                                                                                                                                                         } else {
                                                                                                                                                             false
                                                                                                                                                         }
                                                                                                                                                         {
                                                                                                                                                          let v2486:
                                                                                                                                                                  string =
                                                                                                                                                              string("fable_library_rust = { workspace = true, features = [\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"] }");
                                                                                                                                                          v2486
                                                                                                                                                      } else {
                                                                                                                                                          string("fable_library_rust = { workspace = true }")
                                                                                                                                                      })),
                                                                                                                                              string("\n")),
                                                                                                                                       string("inline_colorization = { workspace = true }")),
                                                                                                                                string("\n")),
                                                                                                                         sprintf!("{}",
                                                                                                                                  join(string("\n"),
                                                                                                                                       toArray_1(delay(Func0::new({
                                                                                                                                                                      let v2460
                                                                                                                                                                          =
                                                                                                                                                                          v2460.clone();
                                                                                                                                                                      move
                                                                                                                                                                          ||
                                                                                                                                                                          map_1(Func1::new({
                                                                                                                                                                                               let v2460
                                                                                                                                                                                                   =
                                                                                                                                                                                                   v2460.clone();
                                                                                                                                                                                               move
                                                                                                                                                                                                   |i_3:
                                                                                                                                                                                                        i32|
                                                                                                                                                                                                   v2460[i_3].clone()
                                                                                                                                                                                           }),
                                                                                                                                                                                rangeNumeric(0_i32,
                                                                                                                                                                                             1_i32,
                                                                                                                                                                                             count_2(v2460.clone())
                                                                                                                                                                                                 -
                                                                                                                                                                                                 1_i32))
                                                                                                                                                                  })))))),
                                                                                                                  string("\n")),
                                                                                                           string("")),
                                                                                                    string("\n")),
                                                                                             (if if let Spiral_builder::US33::US33_1
                                                                                                        =
                                                                                                        &v1719
                                                                                                    {
                                                                                                     true
                                                                                                 } else {
                                                                                                     false
                                                                                                 }
                                                                                                 {
                                                                                                  append(string("[[bin]]\n"),
                                                                                                         sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                  v1774.clone()))
                                                                                              } else {
                                                                                                  string("[lib]\ncrate-type = [\"cdylib\"]")
                                                                                              })),
                                                                                      string("\n")),
                                                                               string("path = \"spiral_builder.rs\" "));
                                                            let v2579:
                                                                            string =
                                                                        append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(string("cargo-features = [\"profile-rustflags\"]\n\n[workspace]\nresolver = \"2\"\nmembers = [\"packages/Rust/*\"]\n\n[workspace.dependencies.fable_library_rust]\n"),
                                                                                                                                                                                                                                                                                   sprintf!("path = \"{}/lib/rust/fable/fable_modules/fable-library-rust\"",
                                                                                                                                                                                                                                                                                            Spiral_builder::method121(v2060.clone()))),
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
                                                            Spiral_builder::method38(
                                                                v2242.clone(),
                                                                v2514,
                                                            );
                                                            Spiral_builder::method38(v2202, v2579);
                                                            {
                                                                let v2581: string =
                                                                    Spiral_builder::method25(
                                                                        v2285,
                                                                        string("src/Range.rs"),
                                                                    );
                                                                if Spiral_builder::method40(
                                                                    v2581.clone(),
                                                                ) {
                                                                    let v2586: Result<
                                                                        Vec<u8>,
                                                                        std::io::Error,
                                                                    > = std::fs::read(
                                                                        &*v2581.clone(),
                                                                    );
                                                                    let v2609: Vec<u8> =
                                                                        Spiral_builder::method24(
                                                                            v2586.unwrap(),
                                                                        );
                                                                    let v2611:
                                                                                    Result<std::string::String,
                                                                                           std::string::FromUtf8Error> =
                                                                                std::string::String::from_utf8(v2609);
                                                                    let v2613: std::string::String =
                                                                        v2611.unwrap();
                                                                    Spiral_builder::method38(v2581,
                                                                                                     replace(replace(fable_library_rust::String_::fromString(v2613),
                                                                                                                     string("use crate::String_::fromCharCode;"),
                                                                                                                     string("use crate::String_::fromChar;")),
                                                                                                             string("fromCharCode(c)"),
                                                                                                             string("std::char::from_u32(c).unwrap()")))
                                                                }
                                                                {
                                                                    let patternInput_10: (
                                                                        i32,
                                                                        string,
                                                                    ) = Spiral_builder::method158(
                                                                        v2046.clone(),
                                                                        v2242.clone(),
                                                                        1_u8,
                                                                    );
                                                                    let v2641: i32 =
                                                                        patternInput_10.0.clone();
                                                                    if v2641 != 0_i32 {
                                                                        let v2648: () = {
                                                                            Spiral_builder::closure75(patternInput_10.1.clone(),
                                                                                                                  v2641,
                                                                                                                  ());
                                                                            ()
                                                                        };
                                                                        ()
                                                                    }
                                                                    {
                                                                        let v2761:
                                                                                        string =
                                                                                    Spiral_builder::method25(v2069,
                                                                                                             sprintf!("{}.{}",
                                                                                                                      string("spiral_builder"),
                                                                                                                      string("rs")));
                                                                        let v2765: Result<
                                                                            Vec<u8>,
                                                                            std::io::Error,
                                                                        > = std::fs::read(
                                                                            &*v2761.clone(),
                                                                        );
                                                                        let v2788:
                                                                                        Vec<u8> =
                                                                                    Spiral_builder::method24(v2765.unwrap());
                                                                        let v2790:
                                                                                        Result<std::string::String,
                                                                                               std::string::FromUtf8Error> =
                                                                                    std::string::String::from_utf8(v2788);
                                                                        let v2792:
                                                                                        std::string::String =
                                                                                    v2790.unwrap();
                                                                        let v2808:
                                                                                        string =
                                                                                    fable_library_rust::String_::fromString(v2792);
                                                                        let v2816:
                                                                                        string =
                                                                                    append(string("pub fn main() -> Result<(), String> "),
                                                                                           "{".into());
                                                                        let v2853:
                                                                                        string =
                                                                                    append(append((if if let Spiral_builder::US33::US33_1
                                                                                                             =
                                                                                                             &v1719
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
                                                                                           sprintf!("{} Ok(()) }}",
                                                                                                    v2816.clone()));
                                                                        let v2854: bool = contains(
                                                                            v2808.clone(),
                                                                            v2816,
                                                                        );
                                                                        let v2958: string = if v2854
                                                                        {
                                                                            v2808.clone()
                                                                        } else {
                                                                            let v2868:
                                                                                                string =
                                                                                            replace(replace(v2808,
                                                                                                            append(string("),)"),
                                                                                                                   ";".into()),
                                                                                                            string("));")),
                                                                                                    append(string("},)"),
                                                                                                           ";".into()),
                                                                                                    string("});"));
                                                                            let v2873:
                                                                                                Result<regex::Regex,
                                                                                                       regex::Error> =
                                                                                            regex::Regex::new(&string("\\s\\sdefaultOf\\(\\);"));
                                                                            let v2875:
                                                                                                regex::Regex =
                                                                                            v2873.unwrap();
                                                                            let v2876:
                                                                                                string =
                                                                                            Spiral_builder::method122(v2868);
                                                                            let v2878:
                                                                                                std::borrow::Cow<str> =
                                                                                            v2875.replace_all(&*v2876, &*string(" defaultOf::<()>();"));
                                                                            let v2880:
                                                                                                std::string::String =
                                                                                            String::from(v2878);
                                                                            replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(fable_library_rust::String_::fromString(v2880),
                                                                                                                                                                        string("::Slice\'_"),
                                                                                                                                                                        string("::Slice__")),
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
                                                                                                string("type TaskCanceledException = ();"))
                                                                        };
                                                                        if v2854 == false {
                                                                            Spiral_builder::method38(v2761.clone(),
                                                                                                             sprintf!("{}\n\n{}\n",
                                                                                                                      v2958.clone(),
                                                                                                                      v2853));
                                                                        }
                                                                        {
                                                                            let v2965:
                                                                                            string =
                                                                                        if (if let Spiral_builder::US33::US33_1
                                                                                                   =
                                                                                                   &v1719
                                                                                               {
                                                                                                true
                                                                                            } else {
                                                                                                false
                                                                                            })
                                                                                               !=
                                                                                               true
                                                                                           {
                                                                                            sprintf!("cargo build --release --target wasm32-unknown-unknown --manifest-path \"{}\"",
                                                                                                     v2242.clone())
                                                                                        } else {
                                                                                            sprintf!("cargo run --manifest-path \"{}\"",
                                                                                                     v2242)
                                                                                        };
                                                                            let v2976:
                                                                                            Array<(string,
                                                                                                   string)> =
                                                                                        if (if let Spiral_builder::US33::US33_1
                                                                                                   =
                                                                                                   &v1719
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
                                                                                                        (string("RUSTFLAGS"),
                                                                                                         string("-C prefer-dynamic"))])
                                                                                        };
                                                                            let v2987:
                                                                                            Result<string,
                                                                                                   string> =
                                                                                        match &v2046
                                                                                            {
                                                                                            Spiral_builder::US12::US12_0(v2046_0_0)
                                                                                            =>
                                                                                            Ok::<string,
                                                                                                 string>(v2046_0_0.clone()),
                                                                                            Spiral_builder::US12::US12_1(v2046_1_0)
                                                                                            =>
                                                                                            Err::<string,
                                                                                                  string>(v2046_1_0.clone()),
                                                                                        };
                                                                            let patternInput_11:
                                                                                            (i32,
                                                                                             string) =
                                                                                        Spiral_builder::method61(v2965.clone(),
                                                                                                                 None::<CancellationToken>,
                                                                                                                 v2976.clone(),
                                                                                                                 None::<Func1<(i32,
                                                                                                                               string,
                                                                                                                               bool),
                                                                                                                              Arc<Async<()>>>>,
                                                                                                                 None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                              ()>>,
                                                                                                                 true,
                                                                                                                 v2987.ok());
                                                                            let v2992: string =
                                                                                patternInput_11
                                                                                    .1
                                                                                    .clone();
                                                                            let v2991: i32 =
                                                                                patternInput_11
                                                                                    .0
                                                                                    .clone();
                                                                            let patternInput_17:
                                                                                            (Spiral_builder::US1,
                                                                                             Spiral_builder::US1,
                                                                                             Spiral_builder::US1) =
                                                                                        if if let Spiral_builder::US33::US33_1
                                                                                                  =
                                                                                                  &v1719
                                                                                              {
                                                                                               true
                                                                                           } else {
                                                                                               false
                                                                                           }
                                                                                           {
                                                                                            let v2994:
                                                                                                    i32 =
                                                                                                count_2(v2976.clone());
                                                                                            let v2995:
                                                                                                    Array<string> =
                                                                                                new_init(&string(""),
                                                                                                         v2994);
                                                                                            let v2996:
                                                                                                    LrcPtr<Spiral_builder::Mut5> =
                                                                                                LrcPtr::new(Spiral_builder::Mut5{l0:
                                                                                                                                     MutCell::new(0_i32),});
                                                                                            while Spiral_builder::method64(v2994,
                                                                                                                           v2996.clone())
                                                                                                  {
                                                                                                let v2998:
                                                                                                        i32 =
                                                                                                    v2996.l0.get().clone();
                                                                                                let patternInput_12:
                                                                                                        (string,
                                                                                                         string) =
                                                                                                    v2976[v2998].clone();
                                                                                                let v3001:
                                                                                                        string =
                                                                                                    sprintf!("$env:{}=\'\'{}\'\'",
                                                                                                             patternInput_12.0.clone(),
                                                                                                             patternInput_12.1.clone());
                                                                                                v2995.get_mut()[v2998
                                                                                                                    as
                                                                                                                    usize]
                                                                                                    =
                                                                                                    v3001;
                                                                                                {
                                                                                                    let v3002:
                                                                                                            i32 =
                                                                                                        v2998
                                                                                                            +
                                                                                                            1_i32;
                                                                                                    v2996.l0.set(v3002);
                                                                                                    ()
                                                                                                }
                                                                                            }
                                                                                            {
                                                                                                let v3021:
                                                                                                        string =
                                                                                                    sprintf!("pwsh -c \'{}\'",
                                                                                                             join(string(";"),
                                                                                                                  toArray_1(ofArray_1(new_array(&[join(string(";"),
                                                                                                                                                       toArray_1(ofArray_1(v2995.clone()))),
                                                                                                                                                  v2965])))));
                                                                                                let patternInput_13:
                                                                                                        (Spiral_builder::US1,
                                                                                                         Spiral_builder::US1,
                                                                                                         Spiral_builder::US1) =
                                                                                                    if v2991
                                                                                                           ==
                                                                                                           0_i32
                                                                                                       {
                                                                                                        let result_1:
                                                                                                                LrcPtr<MutCell<Spiral_builder::US1>> =
                                                                                                            refCell(Spiral_builder::US1::US1_1);
                                                                                                        try_catch(||
                                                                                                                      result_1.set(Spiral_builder::closure58((),
                                                                                                                                                             Spiral_builder::closure76(v2992.clone(),
                                                                                                                                                                                       ()))),
                                                                                                                  |ex_1:
                                                                                                                       LrcPtr<Exception>|
                                                                                                                      result_1.set(Spiral_builder::closure78(v2761.clone(),
                                                                                                                                                             v2992.clone(),
                                                                                                                                                             v3021.clone(),
                                                                                                                                                             ex_1.clone())));
                                                                                                        {
                                                                                                            let v3027:
                                                                                                                    Spiral_builder::US1 =
                                                                                                                result_1.get().clone();
                                                                                                            let v3037:
                                                                                                                    Option<string> =
                                                                                                                match &v3027
                                                                                                                    {
                                                                                                                    Spiral_builder::US1::US1_0(v3027_0_0)
                                                                                                                    =>
                                                                                                                    Some(match &v3027
                                                                                                                             {
                                                                                                                             Spiral_builder::US1::US1_0(x)
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
                                                                                                            (Spiral_builder::US1::US1_0(string("rs")),
                                                                                                             Spiral_builder::US1::US1_0(v2958.clone()),
                                                                                                             Spiral_builder::US1::US1_0(v3037.unwrap()))
                                                                                                        }
                                                                                                    } else {
                                                                                                        let v3045:
                                                                                                                () =
                                                                                                            {
                                                                                                                Spiral_builder::closure80(v1652,
                                                                                                                                          v2761.clone(),
                                                                                                                                          v2992.clone(),
                                                                                                                                          v2991,
                                                                                                                                          v3021,
                                                                                                                                          ());
                                                                                                                ()
                                                                                                            };
                                                                                                        (Spiral_builder::US1::US1_0(string("rs")),
                                                                                                         Spiral_builder::US1::US1_1,
                                                                                                         Spiral_builder::US1::US1_1)
                                                                                                    };
                                                                                                (patternInput_13.0.clone(),
                                                                                                 patternInput_13.1.clone(),
                                                                                                 patternInput_13.2.clone())
                                                                                            }
                                                                                        } else {
                                                                                            let v3163:
                                                                                                    string =
                                                                                                sprintf!("target/spiral_builder/{}/target/wasm32-unknown-unknown/release/spiral_builder_{}.wasm",
                                                                                                         string("spiral_builder"),
                                                                                                         v1774.clone());
                                                                                            let v3173:
                                                                                                    string =
                                                                                                sprintf!("pwsh -c \"pwsh {} {} -Linux -EnvironmentVariables NEAR_RPC_TIMEOUT_SECS=100\"",
                                                                                                         string("scripts/invoke-block.ps1"),
                                                                                                         sprintf!("\'workspace/target/release/spiral_wasm -t Debug -w {} {}\'",
                                                                                                                  v3163.clone(),
                                                                                                                  if let Spiral_builder::US33::US33_0(v1719_0_0)
                                                                                                                         =
                                                                                                                         &v1719
                                                                                                                     {
                                                                                                                      let v3164:
                                                                                                                              Spiral_builder::US34 =
                                                                                                                          match &v1719
                                                                                                                              {
                                                                                                                              Spiral_builder::US33::US33_0(x)
                                                                                                                              =>
                                                                                                                              x.clone(),
                                                                                                                              _
                                                                                                                              =>
                                                                                                                              unreachable!(),
                                                                                                                          };
                                                                                                                      match &v3164
                                                                                                                          {
                                                                                                                          Spiral_builder::US34::US34_0(v3164_0_0)
                                                                                                                          =>
                                                                                                                          v3164_0_0.clone(),
                                                                                                                          Spiral_builder::US34::US34_1(v3164_1_0)
                                                                                                                          =>
                                                                                                                          v3164_1_0.clone(),
                                                                                                                      }
                                                                                                                  } else {
                                                                                                                      string("")
                                                                                                                  }));
                                                                                            let patternInput_16:
                                                                                                    (Spiral_builder::US1,
                                                                                                     Spiral_builder::US1,
                                                                                                     Spiral_builder::US1) =
                                                                                                if v2991
                                                                                                       ==
                                                                                                       0_i32
                                                                                                   {
                                                                                                    let patternInput_14:
                                                                                                            (i32,
                                                                                                             string) =
                                                                                                        Spiral_builder::method61(v3173.clone(),
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
                                                                                                                                 Some(v2060));
                                                                                                    let v3185:
                                                                                                            string =
                                                                                                        patternInput_14.1.clone();
                                                                                                    let v3184:
                                                                                                            i32 =
                                                                                                        patternInput_14.0.clone();
                                                                                                    let patternInput_15:
                                                                                                            (Spiral_builder::US1,
                                                                                                             Spiral_builder::US1,
                                                                                                             Spiral_builder::US1) =
                                                                                                        if v3184
                                                                                                               ==
                                                                                                               0_i32
                                                                                                           {
                                                                                                            (Spiral_builder::US1::US1_0(string("rs")),
                                                                                                             Spiral_builder::US1::US1_0(v2958),
                                                                                                             Spiral_builder::US1::US1_0(v3185.clone()))
                                                                                                        } else {
                                                                                                            let v3192:
                                                                                                                    () =
                                                                                                                {
                                                                                                                    Spiral_builder::closure81(v1652,
                                                                                                                                              v2761.clone(),
                                                                                                                                              v2992.clone(),
                                                                                                                                              v3185,
                                                                                                                                              v3184,
                                                                                                                                              ());
                                                                                                                    ()
                                                                                                                };
                                                                                                            (Spiral_builder::US1::US1_0(string("rs")),
                                                                                                             Spiral_builder::US1::US1_1,
                                                                                                             Spiral_builder::US1::US1_1)
                                                                                                        };
                                                                                                    (patternInput_15.0.clone(),
                                                                                                     patternInput_15.1.clone(),
                                                                                                     patternInput_15.2.clone())
                                                                                                } else {
                                                                                                    let v3313:
                                                                                                            () =
                                                                                                        {
                                                                                                            Spiral_builder::closure82(v1652,
                                                                                                                                      v2761.clone(),
                                                                                                                                      v2992,
                                                                                                                                      v2991,
                                                                                                                                      v3163,
                                                                                                                                      v3173,
                                                                                                                                      ());
                                                                                                            ()
                                                                                                        };
                                                                                                    (Spiral_builder::US1::US1_0(string("rs")),
                                                                                                     Spiral_builder::US1::US1_1,
                                                                                                     Spiral_builder::US1::US1_1)
                                                                                                };
                                                                                            (patternInput_16.0.clone(),
                                                                                             patternInput_16.1.clone(),
                                                                                             patternInput_16.2.clone())
                                                                                        };
                                                                            if v1652 {
                                                                                let v3439:
                                                                                                string =
                                                                                            if (if let Spiral_builder::US33::US33_1
                                                                                                       =
                                                                                                       &v1719
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
                                                                                let v3442:
                                                                                                string =
                                                                                            Spiral_builder::method25(v2200.clone(),
                                                                                                                     sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                              v3439.clone(),
                                                                                                                              v1774.clone(),
                                                                                                                              string("")));
                                                                                let v3445:
                                                                                                string =
                                                                                            Spiral_builder::method25(v2200.clone(),
                                                                                                                     sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                              v3439.clone(),
                                                                                                                              v1774.clone(),
                                                                                                                              string(".wasm")));
                                                                                let v3448:
                                                                                                string =
                                                                                            Spiral_builder::method25(v2200.clone(),
                                                                                                                     sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                              v3439.clone(),
                                                                                                                              v1774.clone(),
                                                                                                                              string(".pdb")));
                                                                                let v3451:
                                                                                                string =
                                                                                            Spiral_builder::method25(v2200.clone(),
                                                                                                                     sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                              v3439.clone(),
                                                                                                                              v1774.clone(),
                                                                                                                              string(".exe")));
                                                                                let v3454:
                                                                                                string =
                                                                                            Spiral_builder::method25(v2200,
                                                                                                                     sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                              v3439,
                                                                                                                              v1774,
                                                                                                                              string(".d")));
                                                                                let v3455:
                                                                                                bool =
                                                                                            Spiral_builder::method40(v3442.clone());
                                                                                let v3456:
                                                                                                bool =
                                                                                            Spiral_builder::method40(v3445.clone());
                                                                                let v3457:
                                                                                                bool =
                                                                                            Spiral_builder::method40(v3448.clone());
                                                                                let v3458:
                                                                                                bool =
                                                                                            Spiral_builder::method40(v3451.clone());
                                                                                let v3459:
                                                                                                bool =
                                                                                            Spiral_builder::method40(v3454.clone());
                                                                                let v3462: () = {
                                                                                    Spiral_builder::closure83(v2761,
                                                                                                                          v3454.clone(),
                                                                                                                          v3459,
                                                                                                                          v3451.clone(),
                                                                                                                          v3458,
                                                                                                                          v3448.clone(),
                                                                                                                          v3457,
                                                                                                                          v3445.clone(),
                                                                                                                          v3456,
                                                                                                                          v3442.clone(),
                                                                                                                          v3455,
                                                                                                                          ());
                                                                                    ()
                                                                                };
                                                                                let v3583:
                                                                                                LrcPtr<Spiral_builder::UH4> =
                                                                                            if v3455
                                                                                               {
                                                                                                LrcPtr::new(Spiral_builder::UH4::UH4_1(v3442,
                                                                                                                                       v3455,
                                                                                                                                       LrcPtr::new(Spiral_builder::UH4::UH4_0)))
                                                                                            } else {
                                                                                                LrcPtr::new(Spiral_builder::UH4::UH4_0)
                                                                                            };
                                                                                let v3585:
                                                                                                LrcPtr<Spiral_builder::UH4> =
                                                                                            if v3456
                                                                                               {
                                                                                                LrcPtr::new(Spiral_builder::UH4::UH4_1(v3445,
                                                                                                                                       v3456,
                                                                                                                                       v3583.clone()))
                                                                                            } else {
                                                                                                v3583
                                                                                            };
                                                                                let v3587:
                                                                                                LrcPtr<Spiral_builder::UH4> =
                                                                                            if v3457
                                                                                               {
                                                                                                LrcPtr::new(Spiral_builder::UH4::UH4_1(v3448,
                                                                                                                                       v3457,
                                                                                                                                       v3585.clone()))
                                                                                            } else {
                                                                                                v3585
                                                                                            };
                                                                                let v3589:
                                                                                                LrcPtr<Spiral_builder::UH4> =
                                                                                            if v3458
                                                                                               {
                                                                                                LrcPtr::new(Spiral_builder::UH4::UH4_1(v3451,
                                                                                                                                       v3458,
                                                                                                                                       v3587.clone()))
                                                                                            } else {
                                                                                                v3587
                                                                                            };
                                                                                Spiral_builder::method173(if v3459
                                                                                                                     {
                                                                                                                      LrcPtr::new(Spiral_builder::UH4::UH4_1(v3454,
                                                                                                                                                             v3459,
                                                                                                                                                             v3589.clone()))
                                                                                                                  } else {
                                                                                                                      v3589
                                                                                                                  })
                                                                            }
                                                                            (
                                                                                patternInput_17
                                                                                    .0
                                                                                    .clone(),
                                                                                patternInput_17
                                                                                    .1
                                                                                    .clone(),
                                                                                patternInput_17
                                                                                    .2
                                                                                    .clone(),
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
                                                        )
                                                    }
                                                }
                                            }
                                        }
                                    }
                                } else {
                                    let patternInput_30: (
                                        Spiral_builder::US1,
                                        Spiral_builder::US1,
                                        Spiral_builder::US1,
                                    ) = if fable_library_rust::String_::fromString(v25.clone())
                                        == string("typescript")
                                    {
                                        let v3598: string = Spiral_builder::method114();
                                        let v3600: &str = &*v3598;
                                        let v3602: Option<std::string::String> =
                                            clap::ArgMatches::get_one(&v26.clone(), v3600).cloned();
                                        let v3616: Spiral_builder::US5 = defaultValue(
                                            Spiral_builder::US5::US5_1,
                                            map(Spiral_builder::method20(), v3602),
                                        );
                                        let v3623: std::string::String = match &v3616 {
                                            Spiral_builder::US5::US5_0(v3616_0_0) => match &v3616 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        };
                                        let v3625: string =
                                            fable_library_rust::String_::fromString(v3623);
                                        let v3626: string = Spiral_builder::method22();
                                        let v3628: &str = &*v3626;
                                        let v3630: Option<Vec<std::string::String>> =
                                            clap::ArgMatches::get_many(&v26.clone(), v3628)
                                                .map(|x| x.cloned().into_iter().collect());
                                        let v3644: Spiral_builder::US9 = defaultValue(
                                            Spiral_builder::US9::US9_1,
                                            map(Spiral_builder::method23(), v3630),
                                        );
                                        let v3650: Vec<std::string::String> =
                                            new_empty::<std::string::String>().to_vec();
                                        let v3653: Vec<std::string::String> = match &v3644 {
                                            Spiral_builder::US9::US9_0(v3644_0_0) => match &v3644 {
                                                Spiral_builder::US9::US9_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => v3650,
                                        };
                                        let v3654: bool = if let Spiral_builder::US0::US0_0 = &v0_1
                                        {
                                            true
                                        } else {
                                            false
                                        };
                                        let v3658: Result<Vec<u8>, std::io::Error> =
                                            std::fs::read(&*v3625);
                                        let v3681: Vec<u8> =
                                            Spiral_builder::method24(v3658.unwrap());
                                        let v3683: Result<
                                            std::string::String,
                                            std::string::FromUtf8Error,
                                        > = std::string::String::from_utf8(v3681);
                                        let v3685: std::string::String = v3683.unwrap();
                                        let v3701: string =
                                            fable_library_rust::String_::fromString(v3685);
                                        let v3710: string = Spiral_builder::method136(sprintf!(
                                            "{:?}",
                                            (string("ts"), v3701.clone())
                                        ));
                                        let v3715:
                                                        Spiral_builder::US12 =
                                                    Spiral_builder::method28(Spiral_builder::method25(string("polyglot"),
                                                                                                      string(".devcontainer")),
                                                                             string("/home/runner/work/polyglot/polyglot/target/Builder/spiral_builder"));
                                        let v3835: Spiral_builder::US1 = match &v3715 {
                                            Spiral_builder::US12::US12_0(v3715_0_0) => {
                                                Spiral_builder::US1::US1_0(v3715_0_0.clone())
                                            }
                                            Spiral_builder::US12::US12_1(v3715_1_0) => {
                                                let v3721: () = {
                                                    Spiral_builder::closure16(
                                                        v3715_1_0.clone(),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                Spiral_builder::US1::US1_1
                                            }
                                        };
                                        let v3962: Spiral_builder::US1 = match &v3835 {
                                            Spiral_builder::US1::US1_0(v3835_0_0) => {
                                                Spiral_builder::US1::US1_0(match &v3835 {
                                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v3838: string = Spiral_builder::method36();
                                                let v3840: Spiral_builder::US12 =
                                                    Spiral_builder::method28(
                                                        Spiral_builder::method25(
                                                            string("polyglot"),
                                                            string(".devcontainer"),
                                                        ),
                                                        v3838,
                                                    );
                                                match &v3840 {
                                                    Spiral_builder::US12::US12_0(v3840_0_0) => {
                                                        Spiral_builder::US1::US1_0(
                                                            v3840_0_0.clone(),
                                                        )
                                                    }
                                                    Spiral_builder::US12::US12_1(v3840_1_0) => {
                                                        let v3846: () = {
                                                            Spiral_builder::closure16(
                                                                v3840_1_0.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        Spiral_builder::US1::US1_1
                                                    }
                                                }
                                            }
                                        };
                                        let v3967: string = Spiral_builder::method25(
                                            match &v3962 {
                                                Spiral_builder::US1::US1_0(v3962_0_0) => {
                                                    match &v3962 {
                                                        Spiral_builder::US1::US1_0(x) => x.clone(),
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
                                        let v3970: string = toLower(Spiral_builder::method36());
                                        let v3974: string = toLower(v3967);
                                        let v3982: Spiral_builder::US12 =
                                            if startsWith(v3970, v3974.clone(), false) {
                                                Spiral_builder::US12::US12_1(v3974.clone())
                                            } else {
                                                Spiral_builder::US12::US12_0(v3974)
                                            };
                                        let v3988: Result<string, string> = match &v3982 {
                                            Spiral_builder::US12::US12_0(v3982_0_0) => {
                                                Ok::<string, string>(v3982_0_0.clone())
                                            }
                                            Spiral_builder::US12::US12_1(v3982_1_0) => {
                                                Err::<string, string>(v3982_1_0.clone())
                                            }
                                        };
                                        let v3990: bool = true;
                                        let _result_unwrap_or_else = v3988.unwrap_or_else(|x| {
                                            //;
                                            let v3992: string = x;
                                            let v3994: bool = true;
                                            v3992
                                        });
                                        let v3996: string = _result_unwrap_or_else;
                                        let v4005: string = Spiral_builder::method25(
                                            Spiral_builder::method25(
                                                Spiral_builder::method25(
                                                    Spiral_builder::method25(
                                                        Spiral_builder::method25(
                                                            v3996.clone(),
                                                            string("target/spiral_builder"),
                                                        ),
                                                        string("spiral_builder"),
                                                    ),
                                                    string("packages"),
                                                ),
                                                string("TypeScript"),
                                            ),
                                            v3710.clone(),
                                        );
                                        let v4006: LrcPtr<dyn IDisposable> =
                                            Spiral_builder::method41(v4005.clone());
                                        let v4009: string =
                                            Spiral_builder::method121(Spiral_builder::method25(
                                                v4005.clone(),
                                                sprintf!("{}.fs", string("spiral_builder")),
                                            ));
                                        Spiral_builder::method38(v4009.clone(), v3701);
                                        {
                                            let v4010: List<string> = empty::<string>();
                                            let v4017: string = join(
                                                string("\\n        "),
                                                toArray_1(delay(Func0::new({
                                                    let v4010 = v4010.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v4010 = v4010.clone();
                                                                move |i_4: i32| {
                                                                    item(i_4, v4010.clone())
                                                                }
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                length_1(v4010.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }))),
                                            );
                                            let v4023: List<string> = singleton(sprintf!(
                                                "<PackageReference Include=\"{}\" Version=\"*\" />",
                                                string("Fable.Core")
                                            ));
                                            let v4031: string = join(
                                                string("\\n        "),
                                                toArray_1(delay(Func0::new({
                                                    let v4023 = v4023.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v4023 = v4023.clone();
                                                                move |i_5: i32| {
                                                                    item(i_5, v4023.clone())
                                                                }
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                length_1(v4023.clone()) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }))),
                                            );
                                            let v4036: string = Spiral_builder::method121(
                                                Spiral_builder::method25(
                                                    v4005.clone(),
                                                    sprintf!("{}.fsproj", string("spiral_builder")),
                                                ),
                                            );
                                            Spiral_builder::method38(v4036.clone(),
                                                                             append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                        sprintf!("    {}",
                                                                                                                                                                                 v4017)),
                                                                                                                                                                 string("\n")),
                                                                                                                                                          sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                                   v4009)),
                                                                                                                                                   string("\n")),
                                                                                                                                            string("</ItemGroup>")),
                                                                                                                                     string("\n")),
                                                                                                                              string("<ItemGroup>")),
                                                                                                                       string("\n")),
                                                                                                                sprintf!("    {}",
                                                                                                                         v4031)),
                                                                                                         string("\n")),
                                                                                                  string("</ItemGroup>")),
                                                                                           string("\n")),
                                                                                    string("</Project>")));
                                            {
                                                let v4136: string = Spiral_builder::method25(
                                                    v3996.clone(),
                                                    string("lib/typescript/fable/fable_modules"),
                                                );
                                                let v4138: async_walkdir::WalkDir =
                                                    async_walkdir::WalkDir::new(&*v4136.clone());
                                                let v4141: async_walkdir::WalkDir =
                                                    async_walkdir::WalkDir::filter(v4138, |x| {
                                                        Func1::new(
                                                            move |v_5: async_walkdir::DirEntry| {
                                                                Spiral_builder::closure84((), v_5)
                                                            },
                                                        )(
                                                            x
                                                        )
                                                    });
                                                let v4142 = Spiral_builder::method178();
                                                let v4144 = tokio_stream::StreamExt::filter_map(
                                                    v4141,
                                                    |x| v4142(x),
                                                );
                                                let v4146: std::pin::Pin<
                                                    Box<
                                                        dyn std::future::Future<
                                                            Output = Vec<(string, string)>,
                                                        >,
                                                    >,
                                                > = Box::pin(tokio_stream::StreamExt::collect(
                                                    v4144,
                                                ));
                                                let v4148: Vec<(string, string)> = v4146.await;
                                                let v4150: rayon::vec::IntoIter<(string, string)> =
                                                    rayon::iter::IntoParallelIterator::into_par_iter(
                                                        v4148,
                                                    );
                                                let v4153: rayon::iter::Map<
                                                    rayon::vec::IntoIter<(string, string)>,
                                                    _,
                                                > = rayon::iter::ParallelIterator::map(
                                                    v4150,
                                                    |x| {
                                                        Func1::new(move
                                                                                                                         |arg10_0040_20:
                                                                                                                              (string,
                                                                                                                               string)|
                                                                                                                         Spiral_builder::closure92((),
                                                                                                                                                   arg10_0040_20))(x)
                                                    },
                                                );
                                                let v4155: Vec<(string, string)> =
                                                    rayon::iter::ParallelIterator::collect(v4153);
                                                let v4158: Option<(string, string)> = tryItem(
                                                    0_i32,
                                                    fable_library_rust::NativeArray_::array_from(
                                                        v4155,
                                                    ),
                                                );
                                                let v4173: Spiral_builder::US42 = defaultValue(
                                                    Spiral_builder::US42::US42_1,
                                                    map(Spiral_builder::method180(), v4158),
                                                );
                                                let v4179: () = {
                                                    Spiral_builder::closure94(v4173.clone(), ());
                                                    ()
                                                };
                                                match &v4173 {
                                                    Spiral_builder::US42::US42_0(
                                                        v4173_0_0,
                                                        v4173_0_1,
                                                    ) => {
                                                        let v4296: string = match &v4173 {
                                                            Spiral_builder::US42::US42_0(_, x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        };
                                                        Spiral_builder::method144(Spiral_builder::method25(v4136,
                                                                                                                   sprintf!("fable-library-{}.{}",
                                                                                                                            string("ts"),
                                                                                                                            v4296.clone())),
                                                                                          Spiral_builder::method25(v4005.clone(),
                                                                                                                   sprintf!("fable_modules/fable-library-{}.{}",
                                                                                                                            string("ts"),
                                                                                                                            v4296)))
                                                    }
                                                    _ => (),
                                                }
                                                {
                                                    let patternInput_19: (i32, string) =
                                                        Spiral_builder::method145(
                                                            Spiral_builder::US33::US33_1,
                                                            v4005.clone(),
                                                            string("ts"),
                                                            v4036,
                                                            v3982.clone(),
                                                        );
                                                    let v4303: string = patternInput_19.1.clone();
                                                    let v4302: i32 = patternInput_19.0.clone();
                                                    let patternInput_23: (
                                                        Spiral_builder::US1,
                                                        Spiral_builder::US1,
                                                        Spiral_builder::US1,
                                                    ) = if v4302 != 0_i32 {
                                                        let v4309: () = {
                                                            Spiral_builder::closure95(
                                                                v4303.clone(),
                                                                v4302,
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        (
                                                            Spiral_builder::US1::US1_0(string(
                                                                "ts",
                                                            )),
                                                            Spiral_builder::US1::US1_1,
                                                            Spiral_builder::US1::US1_0(v4303),
                                                        )
                                                    } else {
                                                        let v4429: bool = true;
                                                        let _vec_map : Vec<_> = v3653.into_iter().map(|x| { //;
                                                                    let v4431:
                                                                            std::string::String =
                                                                        x;
                                                                    let v4433:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v4431);
                                                                    let v4439:
                                                                            string =
                                                                        if contains(v4433.clone(),
                                                                                    string("="))
                                                                           {
                                                                            v4433.clone()
                                                                        } else {
                                                                            sprintf!("\"{}\":\"*\"",
                                                                                     v4433)
                                                                        };
                                                                    let v4441:
                                                                            bool =
                                                                        true; v4439 }).collect::<Vec<_>>();
                                                        let v4443: Vec<string> = _vec_map;
                                                        let v4445:
                                                                            Array<string> =
                                                                        fable_library_rust::NativeArray_::array_from(v4443);
                                                        let v4468:
                                                                            string =
                                                                        append(append(append(append(append(append(append(string("{"),
                                                                                                                         sprintf!("  \"name\": \"spiral_builder_{}\",",
                                                                                                                                  v3710)),
                                                                                                                  string("  \"dependencies\": {")),
                                                                                                           join(string(",\n"),
                                                                                                                toArray_1(delay(Func0::new({
                                                                                                                                               let v4445
                                                                                                                                                   =
                                                                                                                                                   v4445.clone();
                                                                                                                                               move
                                                                                                                                                   ||
                                                                                                                                                   map_1(Func1::new({
                                                                                                                                                                        let v4445
                                                                                                                                                                            =
                                                                                                                                                                            v4445.clone();
                                                                                                                                                                        move
                                                                                                                                                                            |i_6:
                                                                                                                                                                                 i32|
                                                                                                                                                                            v4445[i_6].clone()
                                                                                                                                                                    }),
                                                                                                                                                         rangeNumeric(0_i32,
                                                                                                                                                                      1_i32,
                                                                                                                                                                      count_2(v4445.clone())
                                                                                                                                                                          -
                                                                                                                                                                          1_i32))
                                                                                                                                           }))))),
                                                                                                    string("  },")),
                                                                                             string("    \"devDependencies\": {")),
                                                                                      string("  },")),
                                                                               string("}"));
                                                        let v4470: string =
                                                            Spiral_builder::method25(
                                                                v4005.clone(),
                                                                string("package.json"),
                                                            );
                                                        let v4473: string =
                                                            Spiral_builder::method25(
                                                                Spiral_builder::method25(
                                                                    v4005.clone(),
                                                                    string("../.."),
                                                                ),
                                                                string("package.json"),
                                                            );
                                                        Spiral_builder::method38(v4470, v4468);
                                                        Spiral_builder::method38(v4473, string(""));
                                                        {
                                                            let v4476: string =
                                                                Spiral_builder::method25(
                                                                    v4005,
                                                                    sprintf!(
                                                                        "{}.{}",
                                                                        string("spiral_builder"),
                                                                        string("ts")
                                                                    ),
                                                                );
                                                            let v4479: () = {
                                                                Spiral_builder::closure96(
                                                                    v4476.clone(),
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            let v4597: Result<
                                                                Vec<u8>,
                                                                std::io::Error,
                                                            > = std::fs::read(&*v4476.clone());
                                                            let v4620: Vec<u8> =
                                                                Spiral_builder::method24(
                                                                    v4597.unwrap(),
                                                                );
                                                            let v4622: Result<
                                                                std::string::String,
                                                                std::string::FromUtf8Error,
                                                            > = std::string::String::from_utf8(
                                                                v4620,
                                                            );
                                                            let v4624: std::string::String =
                                                                v4622.unwrap();
                                                            let v4640:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v4624);
                                                            let v4646:
                                                                                bool =
                                                                            contains(v4640.clone(),
                                                                                     string("// spiral_builder.process_typescript"));
                                                            let v4684: string = if v4646 {
                                                                v4640.clone()
                                                            } else {
                                                                let v4651:
                                                                                        string =
                                                                                    replace(v4640,
                                                                                            sprintf!("\"./fable_modules/fable-library-ts.{}/",
                                                                                                     v4173.clone()),
                                                                                            sprintf!("\"{}/lib/typescript/fable/fable_modules/fable-library-ts.{}/",
                                                                                                     v3996,
                                                                                                     v4173.clone()));
                                                                let v4656: Result<
                                                                    regex::Regex,
                                                                    regex::Error,
                                                                > = regex::Regex::new(&string(
                                                                    "\\s\\sdefaultOf\\(\\);",
                                                                ));
                                                                let v4658: regex::Regex =
                                                                    v4656.unwrap();
                                                                let v4659: string =
                                                                    Spiral_builder::method122(
                                                                        v4651,
                                                                    );
                                                                let v4661: std::borrow::Cow<str> =
                                                                    v4658.replace_all(
                                                                        &*v4659,
                                                                        &*string(
                                                                            " defaultOf::<()>();",
                                                                        ),
                                                                    );
                                                                let v4663: std::string::String =
                                                                    String::from(v4661);
                                                                fable_library_rust::String_::fromString(v4663)
                                                            };
                                                            if v4646 == false {
                                                                Spiral_builder::method38(v4476.clone(),
                                                                                                     sprintf!("{}\n\n{}\n",
                                                                                                              v4684.clone(),
                                                                                                              string("// spiral_builder.process_typescript")));
                                                            }
                                                            {
                                                                let v4687: string = sprintf!(
                                                                    "bun run \"{}\"",
                                                                    v4476.clone()
                                                                );
                                                                let v4689: string =
                                                                    Spiral_builder::method3(
                                                                        string("PATH"),
                                                                    );
                                                                let v4722: Spiral_builder::US1 =
                                                                    if v4689.clone() == string("") {
                                                                        Spiral_builder::US1::US1_1
                                                                    } else {
                                                                        Spiral_builder::US1::US1_0(
                                                                            sprintf!(
                                                                                "{}{}{}",
                                                                                string(
                                                                                    "~/.bun/bin"
                                                                                ),
                                                                                if cfg!(windows) {
                                                                                    string(";")
                                                                                } else {
                                                                                    string(":")
                                                                                },
                                                                                v4689
                                                                            ),
                                                                        )
                                                                    };
                                                                let v4737:
                                                                                    Array<(string,
                                                                                           string)> =
                                                                                toArray(Spiral_builder::method184(Spiral_builder::method183(match &v4722
                                                                                                                                                {
                                                                                                                                                Spiral_builder::US1::US1_0(v4722_0_0)
                                                                                                                                                =>
                                                                                                                                                LrcPtr::new(Spiral_builder::UH5::UH5_1(string("PATH"),
                                                                                                                                                                                       match &v4722
                                                                                                                                                                                           {
                                                                                                                                                                                           Spiral_builder::US1::US1_0(x)
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
                                                                let v4750:
                                                                                    Result<string,
                                                                                           string> =
                                                                                match &v3982
                                                                                    {
                                                                                    Spiral_builder::US12::US12_0(v3982_0_0)
                                                                                    =>
                                                                                    Ok::<string,
                                                                                         string>(v3982_0_0.clone()),
                                                                                    Spiral_builder::US12::US12_1(v3982_1_0)
                                                                                    =>
                                                                                    Err::<string,
                                                                                          string>(v3982_1_0.clone()),
                                                                                };
                                                                let patternInput_20:
                                                                                    (i32,
                                                                                     string) =
                                                                                Spiral_builder::method61(v4687.clone(),
                                                                                                         None::<CancellationToken>,
                                                                                                         v4737.clone(),
                                                                                                         None::<Func1<(i32,
                                                                                                                       string,
                                                                                                                       bool),
                                                                                                                      Arc<Async<()>>>>,
                                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                      ()>>,
                                                                                                         true,
                                                                                                         v4750.ok());
                                                                let v4755: string =
                                                                    patternInput_20.1.clone();
                                                                let v4754: i32 =
                                                                    patternInput_20.0.clone();
                                                                let v4756: i32 =
                                                                    count_2(v4737.clone());
                                                                let v4757: Array<string> =
                                                                    new_init(&string(""), v4756);
                                                                let v4758: LrcPtr<
                                                                    Spiral_builder::Mut5,
                                                                > = LrcPtr::new(
                                                                    Spiral_builder::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    },
                                                                );
                                                                while Spiral_builder::method64(
                                                                    v4756,
                                                                    v4758.clone(),
                                                                ) {
                                                                    let v4760: i32 =
                                                                        v4758.l0.get().clone();
                                                                    let patternInput_21: (
                                                                        string,
                                                                        string,
                                                                    ) = v4737[v4760].clone();
                                                                    let v4763: string = sprintf!(
                                                                        "$env:{}=\'\'{}\'\'",
                                                                        patternInput_21.0.clone(),
                                                                        patternInput_21.1.clone()
                                                                    );
                                                                    v4757.get_mut()
                                                                        [v4760 as usize] = v4763;
                                                                    {
                                                                        let v4764: i32 =
                                                                            v4760 + 1_i32;
                                                                        v4758.l0.set(v4764);
                                                                        ()
                                                                    }
                                                                }
                                                                {
                                                                    let v4774: string = sprintf!(
                                                                        "pwsh -c \'{}; {}\'",
                                                                        join(
                                                                            string(";"),
                                                                            toArray_1(ofArray_1(
                                                                                v4757.clone()
                                                                            ))
                                                                        ),
                                                                        v4687
                                                                    );
                                                                    let patternInput_22: (
                                                                        Spiral_builder::US1,
                                                                        Spiral_builder::US1,
                                                                        Spiral_builder::US1,
                                                                    ) = if v4754 == 0_i32 {
                                                                        let result_2:
                                                                                                LrcPtr<MutCell<Spiral_builder::US1>> =
                                                                                            refCell(Spiral_builder::US1::US1_1);
                                                                        try_catch(||
                                                                                                      result_2.set(Spiral_builder::closure58((),
                                                                                                                                             Spiral_builder::closure97(v4755.clone(),
                                                                                                                                                                       ()))),
                                                                                                  |ex_2:
                                                                                                       LrcPtr<Exception>|
                                                                                                      result_2.set(Spiral_builder::closure98(v4476.clone(),
                                                                                                                                             v4755.clone(),
                                                                                                                                             v4774.clone(),
                                                                                                                                             ex_2.clone())));
                                                                        {
                                                                            let v4780:
                                                                                                    Spiral_builder::US1 =
                                                                                                result_2.get().clone();
                                                                            let v4790:
                                                                                                    Option<string> =
                                                                                                match &v4780
                                                                                                    {
                                                                                                    Spiral_builder::US1::US1_0(v4780_0_0)
                                                                                                    =>
                                                                                                    Some(match &v4780
                                                                                                             {
                                                                                                             Spiral_builder::US1::US1_0(x)
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
                                                                            (Spiral_builder::US1::US1_0(string("ts")),
                                                                                             Spiral_builder::US1::US1_0(v4684),
                                                                                             Spiral_builder::US1::US1_0(v4790.unwrap()))
                                                                        }
                                                                    } else {
                                                                        let v4798: () = {
                                                                            Spiral_builder::closure100(v4476,
                                                                                                                           v4755,
                                                                                                                           v4754,
                                                                                                                           v4774,
                                                                                                                           ());
                                                                            ()
                                                                        };
                                                                        (Spiral_builder::US1::US1_0(string("ts")),
                                                                                         Spiral_builder::US1::US1_1,
                                                                                         Spiral_builder::US1::US1_1)
                                                                    };
                                                                    (
                                                                        patternInput_22.0.clone(),
                                                                        patternInput_22.1.clone(),
                                                                        patternInput_22.2.clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    };
                                                    (
                                                        patternInput_23.0.clone(),
                                                        patternInput_23.1.clone(),
                                                        patternInput_23.2.clone(),
                                                    )
                                                }
                                            }
                                        }
                                    } else {
                                        let patternInput_29: (
                                            Spiral_builder::US1,
                                            Spiral_builder::US1,
                                            Spiral_builder::US1,
                                        ) = if fable_library_rust::String_::fromString(v25.clone())
                                            == string("python")
                                        {
                                            let v4922: string = Spiral_builder::method114();
                                            let v4924: &str = &*v4922;
                                            let v4926: Option<std::string::String> =
                                                clap::ArgMatches::get_one(&v26.clone(), v4924)
                                                    .cloned();
                                            let v4940: Spiral_builder::US5 = defaultValue(
                                                Spiral_builder::US5::US5_1,
                                                map(Spiral_builder::method20(), v4926),
                                            );
                                            let v4947: std::string::String = match &v4940 {
                                                Spiral_builder::US5::US5_0(v4940_0_0) => {
                                                    match &v4940 {
                                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                _ => panic!(
                                                    "{}",
                                                    string("Option does not have a value."),
                                                ),
                                            };
                                            let v4949: string =
                                                fable_library_rust::String_::fromString(v4947);
                                            let v4950: string = Spiral_builder::method22();
                                            let v4952: &str = &*v4950;
                                            let v4954: Option<Vec<std::string::String>> =
                                                clap::ArgMatches::get_many(&v26.clone(), v4952)
                                                    .map(|x| x.cloned().into_iter().collect());
                                            let v4968: Spiral_builder::US9 = defaultValue(
                                                Spiral_builder::US9::US9_1,
                                                map(Spiral_builder::method23(), v4954),
                                            );
                                            let v4974: Vec<std::string::String> =
                                                new_empty::<std::string::String>().to_vec();
                                            let v4977: Vec<std::string::String> = match &v4968 {
                                                Spiral_builder::US9::US9_0(v4968_0_0) => {
                                                    match &v4968 {
                                                        Spiral_builder::US9::US9_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                _ => v4974,
                                            };
                                            let v4978: bool =
                                                if let Spiral_builder::US0::US0_0 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                };
                                            let v4982: Result<Vec<u8>, std::io::Error> =
                                                std::fs::read(&*v4949);
                                            let v5005: Vec<u8> =
                                                Spiral_builder::method24(v4982.unwrap());
                                            let v5007: Result<
                                                std::string::String,
                                                std::string::FromUtf8Error,
                                            > = std::string::String::from_utf8(v5005);
                                            let v5009: std::string::String = v5007.unwrap();
                                            let v5025: string =
                                                fable_library_rust::String_::fromString(v5009);
                                            let v5034: string = Spiral_builder::method136(
                                                sprintf!("{:?}", (string("py"), v5025.clone())),
                                            );
                                            let v5039:
                                                                Spiral_builder::US12 =
                                                            Spiral_builder::method28(Spiral_builder::method25(string("polyglot"),
                                                                                                              string(".devcontainer")),
                                                                                     string("/home/runner/work/polyglot/polyglot/target/Builder/spiral_builder"));
                                            let v5159: Spiral_builder::US1 = match &v5039 {
                                                Spiral_builder::US12::US12_0(v5039_0_0) => {
                                                    Spiral_builder::US1::US1_0(v5039_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v5039_1_0) => {
                                                    let v5045: () = {
                                                        Spiral_builder::closure16(
                                                            v5039_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    Spiral_builder::US1::US1_1
                                                }
                                            };
                                            let v5286: Spiral_builder::US1 = match &v5159 {
                                                Spiral_builder::US1::US1_0(v5159_0_0) => {
                                                    Spiral_builder::US1::US1_0(match &v5159 {
                                                        Spiral_builder::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                }
                                                _ => {
                                                    let v5162: string = Spiral_builder::method36();
                                                    let v5164: Spiral_builder::US12 =
                                                        Spiral_builder::method28(
                                                            Spiral_builder::method25(
                                                                string("polyglot"),
                                                                string(".devcontainer"),
                                                            ),
                                                            v5162,
                                                        );
                                                    match &v5164 {
                                                        Spiral_builder::US12::US12_0(v5164_0_0) => {
                                                            Spiral_builder::US1::US1_0(
                                                                v5164_0_0.clone(),
                                                            )
                                                        }
                                                        Spiral_builder::US12::US12_1(v5164_1_0) => {
                                                            let v5170: () = {
                                                                Spiral_builder::closure16(
                                                                    v5164_1_0.clone(),
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            Spiral_builder::US1::US1_1
                                                        }
                                                    }
                                                }
                                            };
                                            let v5291: string = Spiral_builder::method25(
                                                match &v5286 {
                                                    Spiral_builder::US1::US1_0(v5286_0_0) => {
                                                        match &v5286 {
                                                            Spiral_builder::US1::US1_0(x) => {
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
                                            let v5294: string = toLower(Spiral_builder::method36());
                                            let v5298: string = toLower(v5291);
                                            let v5306: Spiral_builder::US12 =
                                                if startsWith(v5294, v5298.clone(), false) {
                                                    Spiral_builder::US12::US12_1(v5298.clone())
                                                } else {
                                                    Spiral_builder::US12::US12_0(v5298)
                                                };
                                            let v5312: Result<string, string> = match &v5306 {
                                                Spiral_builder::US12::US12_0(v5306_0_0) => {
                                                    Ok::<string, string>(v5306_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v5306_1_0) => {
                                                    Err::<string, string>(v5306_1_0.clone())
                                                }
                                            };
                                            let v5314: bool = true;
                                            let _result_unwrap_or_else =
                                                v5312.unwrap_or_else(|x| {
                                                    //;
                                                    let v5316: string = x;
                                                    let v5318: bool = true;
                                                    v5316
                                                });
                                            let v5320: string = _result_unwrap_or_else;
                                            let v5329: string = Spiral_builder::method25(
                                                Spiral_builder::method25(
                                                    Spiral_builder::method25(
                                                        Spiral_builder::method25(
                                                            Spiral_builder::method25(
                                                                v5320.clone(),
                                                                string("target/spiral_builder"),
                                                            ),
                                                            string("spiral_builder"),
                                                        ),
                                                        string("packages"),
                                                    ),
                                                    string("Python"),
                                                ),
                                                v5034.clone(),
                                            );
                                            let v5330: LrcPtr<dyn IDisposable> =
                                                Spiral_builder::method41(v5329.clone());
                                            let v5333: string = Spiral_builder::method121(
                                                Spiral_builder::method25(
                                                    v5329.clone(),
                                                    sprintf!("{}.fs", string("spiral_builder")),
                                                ),
                                            );
                                            Spiral_builder::method38(v5333.clone(), v5025);
                                            {
                                                let v5334: List<string> = empty::<string>();
                                                let v5341: string = join(
                                                    string("\\n        "),
                                                    toArray_1(delay(Func0::new({
                                                        let v5334 = v5334.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v5334 = v5334.clone();
                                                                    move |i_7: i32| {
                                                                        item(i_7, v5334.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v5334.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                );
                                                let v5347:
                                                                    List<string> =
                                                                singleton(sprintf!("<PackageReference Include=\"{}\" Version=\"*\" />",
                                                                                   string("Fable.Core")));
                                                let v5355: string = join(
                                                    string("\\n        "),
                                                    toArray_1(delay(Func0::new({
                                                        let v5347 = v5347.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v5347 = v5347.clone();
                                                                    move |i_8: i32| {
                                                                        item(i_8, v5347.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v5347.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                );
                                                let v5360: string = Spiral_builder::method121(
                                                    Spiral_builder::method25(
                                                        v5329.clone(),
                                                        sprintf!(
                                                            "{}.fsproj",
                                                            string("spiral_builder")
                                                        ),
                                                    ),
                                                );
                                                Spiral_builder::method38(v5360.clone(),
                                                                                     append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                                sprintf!("    {}",
                                                                                                                                                                                         v5341)),
                                                                                                                                                                         string("\n")),
                                                                                                                                                                  sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                                           v5333)),
                                                                                                                                                           string("\n")),
                                                                                                                                                    string("</ItemGroup>")),
                                                                                                                                             string("\n")),
                                                                                                                                      string("<ItemGroup>")),
                                                                                                                               string("\n")),
                                                                                                                        sprintf!("    {}",
                                                                                                                                 v5355)),
                                                                                                                 string("\n")),
                                                                                                          string("</ItemGroup>")),
                                                                                                   string("\n")),
                                                                                            string("</Project>")));
                                                Spiral_builder::method144(
                                                    Spiral_builder::method25(
                                                        Spiral_builder::method25(
                                                            v5320,
                                                            string(
                                                                "lib/python/fable/fable_modules",
                                                            ),
                                                        ),
                                                        string("fable_library"),
                                                    ),
                                                    Spiral_builder::method25(
                                                        v5329.clone(),
                                                        string("fable_modules/fable_library"),
                                                    ),
                                                );
                                                {
                                                    let patternInput_24: (i32, string) =
                                                        Spiral_builder::method145(
                                                            Spiral_builder::US33::US33_1,
                                                            v5329.clone(),
                                                            string("py"),
                                                            v5360,
                                                            v5306.clone(),
                                                        );
                                                    let v5467: string = patternInput_24.1.clone();
                                                    let v5466: i32 = patternInput_24.0.clone();
                                                    let patternInput_28: (
                                                        Spiral_builder::US1,
                                                        Spiral_builder::US1,
                                                        Spiral_builder::US1,
                                                    ) = if v5466 != 0_i32 {
                                                        let v5473: () = {
                                                            Spiral_builder::closure101(
                                                                v5467.clone(),
                                                                v5466,
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        (
                                                            Spiral_builder::US1::US1_0(string(
                                                                "py",
                                                            )),
                                                            Spiral_builder::US1::US1_1,
                                                            Spiral_builder::US1::US1_0(v5467),
                                                        )
                                                    } else {
                                                        let v5593: bool = true;
                                                        let _vec_map : Vec<_> = v4977.into_iter().map(|x| { //;
                                                                        let v5595:
                                                                                std::string::String =
                                                                            x;
                                                                        let v5597:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v5595);
                                                                        let v5603:
                                                                                string =
                                                                            if contains(v5597.clone(),
                                                                                        string("="))
                                                                               {
                                                                                v5597.clone()
                                                                            } else {
                                                                                sprintf!("\"{}\":\"*\"",
                                                                                         v5597)
                                                                            };
                                                                        let v5605:
                                                                                bool =
                                                                            true; v5603 }).collect::<Vec<_>>();
                                                        let v5607: Vec<string> = _vec_map;
                                                        let v5609:
                                                                                Array<string> =
                                                                            fable_library_rust::NativeArray_::array_from(v5607);
                                                        let v5632:
                                                                                string =
                                                                            append(append(append(append(append(append(append(string("{"),
                                                                                                                             sprintf!("  \"name\": \"spiral_builder_{}\",",
                                                                                                                                      v5034)),
                                                                                                                      string("  \"dependencies\": {")),
                                                                                                               join(string(",\n"),
                                                                                                                    toArray_1(delay(Func0::new({
                                                                                                                                                   let v5609
                                                                                                                                                       =
                                                                                                                                                       v5609.clone();
                                                                                                                                                   move
                                                                                                                                                       ||
                                                                                                                                                       map_1(Func1::new({
                                                                                                                                                                            let v5609
                                                                                                                                                                                =
                                                                                                                                                                                v5609.clone();
                                                                                                                                                                            move
                                                                                                                                                                                |i_9:
                                                                                                                                                                                     i32|
                                                                                                                                                                                v5609[i_9].clone()
                                                                                                                                                                        }),
                                                                                                                                                             rangeNumeric(0_i32,
                                                                                                                                                                          1_i32,
                                                                                                                                                                          count_2(v5609.clone())
                                                                                                                                                                              -
                                                                                                                                                                              1_i32))
                                                                                                                                               }))))),
                                                                                                        string("  },")),
                                                                                                 string("    \"devDependencies\": {")),
                                                                                          string("  },")),
                                                                                   string("}"));
                                                        let v5634: string =
                                                            Spiral_builder::method25(
                                                                v5329.clone(),
                                                                string("package.json"),
                                                            );
                                                        let v5637: string =
                                                            Spiral_builder::method25(
                                                                Spiral_builder::method25(
                                                                    v5329.clone(),
                                                                    string("../.."),
                                                                ),
                                                                string("package.json"),
                                                            );
                                                        Spiral_builder::method38(v5634, v5632);
                                                        Spiral_builder::method38(v5637, string(""));
                                                        {
                                                            let v5640: string =
                                                                Spiral_builder::method25(
                                                                    v5329,
                                                                    sprintf!(
                                                                        "{}.{}",
                                                                        string("spiral_builder"),
                                                                        string("py")
                                                                    ),
                                                                );
                                                            let v5643: () = {
                                                                Spiral_builder::closure102(
                                                                    v5640.clone(),
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            let v5761: Result<
                                                                Vec<u8>,
                                                                std::io::Error,
                                                            > = std::fs::read(&*v5640.clone());
                                                            let v5784: Vec<u8> =
                                                                Spiral_builder::method24(
                                                                    v5761.unwrap(),
                                                                );
                                                            let v5786: Result<
                                                                std::string::String,
                                                                std::string::FromUtf8Error,
                                                            > = std::string::String::from_utf8(
                                                                v5784,
                                                            );
                                                            let v5788: std::string::String =
                                                                v5786.unwrap();
                                                            let v5804:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v5788);
                                                            let v5810:
                                                                                    bool =
                                                                                contains(v5804.clone(),
                                                                                         string("# spiral_builder.process_python"));
                                                            let v5851: string = if v5810 {
                                                                v5804.clone()
                                                            } else {
                                                                let v5818: string = replace(
                                                                    v5804,
                                                                    append(
                                                                        string("),)"),
                                                                        ";".into(),
                                                                    ),
                                                                    string("));"),
                                                                );
                                                                let v5823: Result<
                                                                    regex::Regex,
                                                                    regex::Error,
                                                                > = regex::Regex::new(&string(
                                                                    "\\s\\sdefaultOf\\(\\);",
                                                                ));
                                                                let v5825: regex::Regex =
                                                                    v5823.unwrap();
                                                                let v5826: string =
                                                                    Spiral_builder::method122(
                                                                        v5818,
                                                                    );
                                                                let v5828: std::borrow::Cow<str> =
                                                                    v5825.replace_all(
                                                                        &*v5826,
                                                                        &*string(
                                                                            " defaultOf::<()>();",
                                                                        ),
                                                                    );
                                                                let v5830: std::string::String =
                                                                    String::from(v5828);
                                                                fable_library_rust::String_::fromString(v5830)
                                                            };
                                                            if v5810 == false {
                                                                Spiral_builder::method38(v5640.clone(),
                                                                                                         sprintf!("{}\n\n{}\n",
                                                                                                                  v5851.clone(),
                                                                                                                  string("# spiral_builder.process_python")));
                                                            }
                                                            {
                                                                let v5854: string = sprintf!(
                                                                    "python \"{}\"",
                                                                    v5640.clone()
                                                                );
                                                                let v5857: Array<(string, string)> =
                                                                    new_array(&[(
                                                                        string("TRACE_LEVEL"),
                                                                        string("Verbose"),
                                                                    )]);
                                                                let v5868:
                                                                                        Result<string,
                                                                                               string> =
                                                                                    match &v5306
                                                                                        {
                                                                                        Spiral_builder::US12::US12_0(v5306_0_0)
                                                                                        =>
                                                                                        Ok::<string,
                                                                                             string>(v5306_0_0.clone()),
                                                                                        Spiral_builder::US12::US12_1(v5306_1_0)
                                                                                        =>
                                                                                        Err::<string,
                                                                                              string>(v5306_1_0.clone()),
                                                                                    };
                                                                let patternInput_25:
                                                                                        (i32,
                                                                                         string) =
                                                                                    Spiral_builder::method61(v5854.clone(),
                                                                                                             None::<CancellationToken>,
                                                                                                             v5857.clone(),
                                                                                                             None::<Func1<(i32,
                                                                                                                           string,
                                                                                                                           bool),
                                                                                                                          Arc<Async<()>>>>,
                                                                                                             None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                          ()>>,
                                                                                                             true,
                                                                                                             v5868.ok());
                                                                let v5873: string =
                                                                    patternInput_25.1.clone();
                                                                let v5872: i32 =
                                                                    patternInput_25.0.clone();
                                                                let v5874: i32 =
                                                                    count_2(v5857.clone());
                                                                let v5875: Array<string> =
                                                                    new_init(&string(""), v5874);
                                                                let v5876: LrcPtr<
                                                                    Spiral_builder::Mut5,
                                                                > = LrcPtr::new(
                                                                    Spiral_builder::Mut5 {
                                                                        l0: MutCell::new(0_i32),
                                                                    },
                                                                );
                                                                while Spiral_builder::method64(
                                                                    v5874,
                                                                    v5876.clone(),
                                                                ) {
                                                                    let v5878: i32 =
                                                                        v5876.l0.get().clone();
                                                                    let patternInput_26: (
                                                                        string,
                                                                        string,
                                                                    ) = v5857[v5878].clone();
                                                                    let v5881: string = sprintf!(
                                                                        "$env:{}=\'\'{}\'\'",
                                                                        patternInput_26.0.clone(),
                                                                        patternInput_26.1.clone()
                                                                    );
                                                                    v5875.get_mut()
                                                                        [v5878 as usize] = v5881;
                                                                    {
                                                                        let v5882: i32 =
                                                                            v5878 + 1_i32;
                                                                        v5876.l0.set(v5882);
                                                                        ()
                                                                    }
                                                                }
                                                                {
                                                                    let v5892: string = sprintf!(
                                                                        "pwsh -c \'{}; {}\'",
                                                                        join(
                                                                            string(";"),
                                                                            toArray_1(ofArray_1(
                                                                                v5875.clone()
                                                                            ))
                                                                        ),
                                                                        v5854
                                                                    );
                                                                    let patternInput_27: (
                                                                        Spiral_builder::US1,
                                                                        Spiral_builder::US1,
                                                                        Spiral_builder::US1,
                                                                    ) = if v5872 == 0_i32 {
                                                                        let result_3:
                                                                                                    LrcPtr<MutCell<Spiral_builder::US1>> =
                                                                                                refCell(Spiral_builder::US1::US1_1);
                                                                        try_catch(||
                                                                                                          result_3.set(Spiral_builder::closure58((),
                                                                                                                                                 Spiral_builder::closure103(v5873.clone(),
                                                                                                                                                                            ()))),
                                                                                                      |ex_3:
                                                                                                           LrcPtr<Exception>|
                                                                                                          result_3.set(Spiral_builder::closure104(v5640.clone(),
                                                                                                                                                  v5873.clone(),
                                                                                                                                                  v5892.clone(),
                                                                                                                                                  ex_3.clone())));
                                                                        {
                                                                            let v5898:
                                                                                                        Spiral_builder::US1 =
                                                                                                    result_3.get().clone();
                                                                            let v5908:
                                                                                                        Option<string> =
                                                                                                    match &v5898
                                                                                                        {
                                                                                                        Spiral_builder::US1::US1_0(v5898_0_0)
                                                                                                        =>
                                                                                                        Some(match &v5898
                                                                                                                 {
                                                                                                                 Spiral_builder::US1::US1_0(x)
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
                                                                            (Spiral_builder::US1::US1_0(string("py")),
                                                                                                 Spiral_builder::US1::US1_0(v5851),
                                                                                                 Spiral_builder::US1::US1_0(v5908.unwrap()))
                                                                        }
                                                                    } else {
                                                                        let v5916: () = {
                                                                            Spiral_builder::closure106(v5640,
                                                                                                                               v5873,
                                                                                                                               v5872,
                                                                                                                               v5892,
                                                                                                                               ());
                                                                            ()
                                                                        };
                                                                        (Spiral_builder::US1::US1_0(string("py")),
                                                                                             Spiral_builder::US1::US1_1,
                                                                                             Spiral_builder::US1::US1_1)
                                                                    };
                                                                    (
                                                                        patternInput_27.0.clone(),
                                                                        patternInput_27.1.clone(),
                                                                        patternInput_27.2.clone(),
                                                                    )
                                                                }
                                                            }
                                                        }
                                                    };
                                                    (
                                                        patternInput_28.0.clone(),
                                                        patternInput_28.1.clone(),
                                                        patternInput_28.2.clone(),
                                                    )
                                                }
                                            }
                                        } else {
                                            let v6039: () = {
                                                Spiral_builder::closure107(v26, v25, ());
                                                ()
                                            };
                                            (
                                                Spiral_builder::US1::US1_1,
                                                Spiral_builder::US1::US1_1,
                                                Spiral_builder::US1::US1_1,
                                            )
                                        };
                                        (
                                            patternInput_29.0.clone(),
                                            patternInput_29.1.clone(),
                                            patternInput_29.2.clone(),
                                        )
                                    };
                                    (
                                        patternInput_30.0.clone(),
                                        patternInput_30.1.clone(),
                                        patternInput_30.2.clone(),
                                    )
                                };
                                let v6166: Spiral_builder::US1 = patternInput_31.2.clone();
                                let v6165: Spiral_builder::US1 = patternInput_31.1.clone();
                                let v6164: Spiral_builder::US1 = patternInput_31.0.clone();
                                new_array(&[
                                    (
                                        string("extension"),
                                        match &v6164 {
                                            Spiral_builder::US1::US1_0(v6164_0_0) => match &v6164 {
                                                Spiral_builder::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => string(""),
                                        },
                                    ),
                                    (
                                        string("code"),
                                        match &v6165 {
                                            Spiral_builder::US1::US1_0(v6165_0_0) => match &v6165 {
                                                Spiral_builder::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => string(""),
                                        },
                                    ),
                                    (
                                        string("output"),
                                        match &v6166 {
                                            Spiral_builder::US1::US1_0(v6166_0_0) => match &v6166 {
                                                Spiral_builder::US1::US1_0(x) => x.clone(),
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
                        (string("output"), string("")),
                    ])
                };
                let v6193: Vec<(string, string)> = v6191.to_vec();
                let v6196: Vec<LrcPtr<(std::string::String, std::string::String)>> = v6193
                    .into_iter()
                    .map(|x| {
                        Func1::new(move |arg10_0040_33: (string, string)| {
                            Spiral_builder::closure108((), arg10_0040_33)
                        })(x.clone())
                    })
                    .collect::<Vec<_>>();
                let v6197: string =
                string("std::collections::BTreeMap::from_iter(v6196.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                let v6198: std::collections::BTreeMap<std::string::String, std::string::String> =
                    std::collections::BTreeMap::from_iter(
                        v6196
                            .iter()
                            .map(|x| x.as_ref())
                            .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                    );
                let v6200: Result<std::string::String, serde_json::Error> =
                    serde_json::to_string(&v6198);
                let v6201 = Spiral_builder::method191();
                let v6203: Result<std::string::String, string> = v6200.map_err(|x| v6201(x));
                let v6205: bool = true;
                let _result_map_ = v6203.map(|x| {
                    //;
                    let v6207: std::string::String = x;
                    let v6209: string = fable_library_rust::String_::fromString(v6207);
                    let v6211: bool = true;
                    v6209
                });
                let v6214: Result<string, string> = Spiral_builder::method192(_result_map_);
                let v6218: string = string("true; v6214 });  // rust.fix_closure\'");
                let v6219: bool = true;
                v6214
            }); // rust.fix_closure';
            let v6221 = __future_init;
            v6221
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
            let v152: clap::Command = Spiral_builder::method0();
            let v154: clap::ArgMatches = clap::Command::get_matches(v152);
            let v156: std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, string>>>> =
                Spiral_builder::method17(v21.l0.get().clone(), v154);
            let v158 = tokio::runtime::Builder::new_multi_thread()
                .enable_all()
                .build()
                .unwrap();
            let v160: Result<string, string> = v158.handle().block_on(v156);
            let v162: string = v160.unwrap();
            if if let Spiral_builder::US0::US0_2 = &v21.l0.get().clone() {
                true
            } else {
                false
            } {
                let v167: () = {
                    Spiral_builder::closure10(v162, ());
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
