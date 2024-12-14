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
#![allow(unused_assignments)]
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
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::Native_::getZero;
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
        use fable_library_rust::Option_::map;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
        use fable_library_rust::Seq_::ofArray as ofArray_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::concat;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith3;
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
        use fable_library_rust::String_::startsWith3;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::toString;
        use fable_library_rust::String_::toUpper;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Exception;
        use fable_library_rust::System::IDisposable;
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
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        pub trait IPathJoin: core::fmt::Debug + core::fmt::Display {
            fn join(&self, paths: Array<string>) -> string;
        }
        impl<V: IPathJoin + core::fmt::Debug + core::fmt::Display> IPathJoin for LrcPtr<V> {
            #[inline]
            fn join(&self, paths: Array<string>) -> string {
                (**self).join(paths)
            }
        }
        pub trait IFsExistsSync: core::fmt::Debug + core::fmt::Display {
            fn existsSync(&self, path: string) -> bool;
        }
        impl<V: IFsExistsSync + core::fmt::Debug + core::fmt::Display> IFsExistsSync for LrcPtr<V> {
            #[inline]
            fn existsSync(&self, path: string) -> bool {
                (**self).existsSync(path)
            }
        }
        pub trait IPathDirname: core::fmt::Debug + core::fmt::Display {
            fn dirname(&self, path: string) -> string;
        }
        impl<V: IPathDirname + core::fmt::Debug + core::fmt::Display> IPathDirname for LrcPtr<V> {
            #[inline]
            fn dirname(&self, path: string) -> string {
                (**self).dirname(path)
            }
        }
        #[derive(Clone, Debug)]
        pub struct Disposable {
            f: Func0<()>,
        }
        impl Disposable {
            pub fn _ctor__3A5B6456(f: Func0<()>) -> LrcPtr<Spiral_builder::Disposable> {
                let f_1;
                ();
                f_1 = f;
                ();
                LrcPtr::new(Spiral_builder::Disposable { f: f_1 })
            }
        }
        impl core::fmt::Display for Disposable {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        impl IDisposable for Disposable {
            fn Dispose(&self) {
                (self.f)();
            }
        }
        pub trait ICryptoCreateHash: core::fmt::Debug + core::fmt::Display {
            fn createHash(&self, x: string) -> LrcPtr<dyn Any>;
        }
        impl<V: ICryptoCreateHash + core::fmt::Debug + core::fmt::Display> ICryptoCreateHash for LrcPtr<V> {
            #[inline]
            fn createHash(&self, x: string) -> LrcPtr<dyn Any> {
                (**self).createHash(x)
            }
        }
        pub trait IHashlibSha256: core::fmt::Debug + core::fmt::Display {
            fn sha256(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IHashlibSha256 + core::fmt::Debug + core::fmt::Display> IHashlibSha256 for LrcPtr<V> {
            #[inline]
            fn sha256(&self) -> LrcPtr<dyn Any> {
                (**self).sha256()
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut4 {
            pub l0: MutCell<Spiral_builder::US0>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Spiral_builder::US0),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(Spiral_builder::US3),
            US4_1(Spiral_builder::US3),
            US4_2(Spiral_builder::US3),
            US4_3(Spiral_builder::US3),
            US4_4(Spiral_builder::US3),
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0(string),
            US5_1,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(std::string::String, clap::ArgMatches),
            US6_1,
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(std::string::String),
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US10 {
            US10_0,
            US10_1,
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US9 {
            US9_0(Spiral_builder::US10),
            US9_1,
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(Spiral_builder::US9),
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(Vec<std::string::String>),
            US11_1,
        }
        impl core::fmt::Display for US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US12 {
            US12_0(string),
            US12_1(string),
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0,
            US13_1(std::string::String),
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US14 {
            US14_0(string, Spiral_builder::US5),
            US14_1(string),
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US15_1(string),
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(char, LrcPtr<Spiral_builder::UH0>),
        }
        impl core::fmt::Display for UH0 {
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
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US16_1(string),
        }
        impl core::fmt::Display for US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US17 {
            US17_0(char),
            US17_1,
        }
        impl core::fmt::Display for US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0(string, LrcPtr<StringBuilder>, i32, i32),
            US18_1(string),
        }
        impl core::fmt::Display for US18 {
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
        impl core::fmt::Display for US19 {
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
        impl core::fmt::Display for US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(Spiral_builder::US5, string, LrcPtr<StringBuilder>, i32, i32),
            US21_1(string),
        }
        impl core::fmt::Display for US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US22 {
            US22_0(Array<string>),
            US22_1(string),
        }
        impl core::fmt::Display for US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH2 {
            UH2_0,
            UH2_1(string, LrcPtr<Spiral_builder::UH2>),
        }
        impl core::fmt::Display for UH2 {
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
        impl core::fmt::Display for US23 {
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
        impl core::fmt::Display for UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US24_1(std::string::String),
        }
        impl core::fmt::Display for US24 {
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
        impl core::fmt::Display for US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(std::string::String),
            US26_1(std::string::String),
        }
        impl core::fmt::Display for US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US27_1,
        }
        impl core::fmt::Display for US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US28_1,
        }
        impl core::fmt::Display for US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(std::process::Output),
            US29_1(std::string::String),
        }
        impl core::fmt::Display for US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US30 {
            US30_0(i32),
            US30_1,
        }
        impl core::fmt::Display for US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US31_1,
        }
        impl core::fmt::Display for US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US32 {
            US32_0(CancellationToken),
            US32_1,
        }
        impl core::fmt::Display for US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0(std::path::PathBuf),
            US33_1(string),
        }
        impl core::fmt::Display for US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(std::path::PathBuf),
            US34_1,
        }
        impl core::fmt::Display for US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US36 {
            US36_0(string),
            US36_1(string),
        }
        impl core::fmt::Display for US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US35 {
            US35_0(Spiral_builder::US36),
            US35_1,
        }
        impl core::fmt::Display for US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US37 {
            US37_0,
            US37_1,
            US37_2,
        }
        impl core::fmt::Display for US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US38 {
            US38_0(Spiral_builder::US37),
            US38_1,
        }
        impl core::fmt::Display for US38 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US39 {
            US39_0(chrono::DateTime<chrono::Utc>),
            US39_1,
        }
        impl core::fmt::Display for US39 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US40 {
            US40_0(i32, string),
            US40_1(i32, string),
        }
        impl core::fmt::Display for US40 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US41 {
            US41_0(std::collections::HashMap<string, string>),
            US41_1,
        }
        impl core::fmt::Display for US41 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US42 {
            US42_0(Spiral_builder::US5),
            US42_1,
        }
        impl core::fmt::Display for US42 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH4 {
            UH4_0,
            UH4_1(string, bool, LrcPtr<Spiral_builder::UH4>),
        }
        impl core::fmt::Display for UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US43 {
            US43_0(std::fs::FileType),
            US43_1(std::string::String),
        }
        impl core::fmt::Display for US43 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US44 {
            US44_0,
            US44_1,
            US44_2,
        }
        impl core::fmt::Display for US44 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US45 {
            US45_0(async_walkdir::DirEntry),
            US45_1(std::string::String),
        }
        impl core::fmt::Display for US45 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US46 {
            US46_0(string, string),
            US46_1,
        }
        impl core::fmt::Display for US46 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH5 {
            UH5_0,
            UH5_1(string, string, LrcPtr<Spiral_builder::UH5>),
        }
        impl core::fmt::Display for UH5 {
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
            let v167: clap::builder::ValueRange = if (v153) == (0_i32 as usize) {
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
            let v268: clap::builder::ValueRange = if (v254) == (0_i32 as usize) {
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
            let v308: clap::builder::ValueRange = if (v294) == (0_i32 as usize) {
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
            let v348: clap::builder::ValueRange = if (v334) == (0_i32 as usize) {
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
            let v434: clap::builder::ValueRange = if (v421) == (0_i32 as usize) {
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
            let v499: clap::builder::ValueRange = if (v486) == (0_i32 as usize) {
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
        pub fn method4(v0_1: string) -> string {
            v0_1
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Spiral_builder::US5 {
            Spiral_builder::US5::US5_0(v0_1)
        }
        pub fn method6() -> Func1<string, Spiral_builder::US5> {
            Func1::new(move |v: string| Spiral_builder::closure3((), v))
        }
        pub fn method3(v0_1: string) -> string {
            let v2: string = Spiral_builder::method4(v0_1);
            let v4: Result<std::string::String, std::env::VarError> = std::env::var(&*v2);
            let v6: bool = true;
            let _result_map_ = v4.map(|x| {
                //;
                let v8: std::string::String = x;
                let v10: string = fable_library_rust::String_::fromString(v8);
                let v12: bool = true;
                v10
            });
            let v14: Result<string, std::env::VarError> = _result_map_;
            let v15: string = Spiral_builder::method5();
            v14.unwrap_or(v15)
        }
        pub fn method2() -> (Spiral_builder::US1, Spiral_builder::US2) {
            let v1_1: string = Spiral_builder::method3(string("TRACE_LEVEL"));
            let v6: Spiral_builder::US1 = if string("Verbose") == (v1_1.clone()) {
                Spiral_builder::US1::US1_0(Spiral_builder::US0::US0_0)
            } else {
                Spiral_builder::US1::US1_1
            };
            (
                match &v6 {
                    Spiral_builder::US1::US1_0(v6_0_0) => Spiral_builder::US1::US1_0(
                        match &v6 {
                            Spiral_builder::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v13: Spiral_builder::US1 = if string("Debug") == (v1_1.clone()) {
                            Spiral_builder::US1::US1_0(Spiral_builder::US0::US0_1)
                        } else {
                            Spiral_builder::US1::US1_1
                        };
                        match &v13 {
                            Spiral_builder::US1::US1_0(v13_0_0) => Spiral_builder::US1::US1_0(
                                match &v13 {
                                    Spiral_builder::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v20: Spiral_builder::US1 = if string("Info") == (v1_1.clone()) {
                                    Spiral_builder::US1::US1_0(Spiral_builder::US0::US0_2)
                                } else {
                                    Spiral_builder::US1::US1_1
                                };
                                match &v20 {
                                    Spiral_builder::US1::US1_0(v20_0_0) => {
                                        Spiral_builder::US1::US1_0(
                                            match &v20 {
                                                Spiral_builder::US1::US1_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => {
                                        let v27: Spiral_builder::US1 = if string("Warning")
                                            == (v1_1.clone())
                                        {
                                            Spiral_builder::US1::US1_0(Spiral_builder::US0::US0_3)
                                        } else {
                                            Spiral_builder::US1::US1_1
                                        };
                                        match &v27 {
                                            Spiral_builder::US1::US1_0(v27_0_0) => {
                                                Spiral_builder::US1::US1_0(
                                                    match &v27 {
                                                        Spiral_builder::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v34: Spiral_builder::US1 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Spiral_builder::US1::US1_0(
                                                            Spiral_builder::US0::US0_4,
                                                        )
                                                    } else {
                                                        Spiral_builder::US1::US1_1
                                                    };
                                                match &v34 {
                                                    Spiral_builder::US1::US1_0(v34_0_0) => {
                                                        Spiral_builder::US1::US1_0(
                                                            match &v34 {
                                                                Spiral_builder::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
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
                if (Spiral_builder::method3(string("AUTOMATION"))) != string("True") {
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
                        }
                        .clone(),
                        _ => v0_1.clone(),
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
        pub fn method7(v0_1: Spiral_builder::US0) -> bool {
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
            ) = Spiral_builder::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v35: Spiral_builder::US0 = (patternInput.4.clone()).l0.get().clone();
            if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                (find(
                    v0_1,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                    ])))),
                )) >= (find(
                    v35,
                    ofSeq(ofList(ofArray(new_array(&[
                        LrcPtr::new((Spiral_builder::US0::US0_0, 0_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_1, 1_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_2, 2_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_3, 3_i32)),
                        LrcPtr::new((Spiral_builder::US0::US0_4, 4_i32)),
                    ])))),
                ))
            }
        }
        pub fn closure6(unitVar: (), v0_1: i64) -> Spiral_builder::US2 {
            Spiral_builder::US2::US2_0(v0_1)
        }
        pub fn method9() -> Func1<i64, Spiral_builder::US2> {
            Func1::new(move |v: i64| Spiral_builder::closure6((), v))
        }
        pub fn method10() -> string {
            string("hh:mm:ss")
        }
        pub fn method11() -> string {
            string("HH:mm:ss")
        }
        pub fn method8(
            v0_1: LrcPtr<Spiral_builder::Mut0>,
            v1_1: LrcPtr<Spiral_builder::Mut1>,
            v2: LrcPtr<Spiral_builder::Mut2>,
            v3: LrcPtr<Spiral_builder::Mut3>,
            v4: LrcPtr<Spiral_builder::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v20: Spiral_builder::US2 = defaultValue(
                Spiral_builder::US2::US2_1,
                map(Spiral_builder::method9(), v5),
            );
            let v117: DateTime = match &v20 {
                Spiral_builder::US2::US2_0(v20_0_0) => {
                    let v77: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v20 {
                            Spiral_builder::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
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
            let v118: string = Spiral_builder::method10();
            let provider: string = if (v118.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v118
            };
            v117.toString(provider)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn closure7(v0_1: LrcPtr<Spiral_builder::Mut3>, v1_1: string, unitVar: ()) {
            let v3: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v3);
            ()
        }
        pub fn method13(v0_1: char) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v8: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method15() -> string {
            string("\u{001b}[0m")
        }
        pub fn method12() -> string {
            let v6: string = Spiral_builder::method13(getCharAt(toLower(string("Debug")), 0_i32));
            let v9: &str = inline_colorization::color_bright_blue;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method17(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), string("args"), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v47: () = {
                Spiral_builder::closure7(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method18(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method16(
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
            let v9: string = Spiral_builder::method17(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.main"),
                v9
            ))
        }
        pub fn closure8(v0_1: LrcPtr<Spiral_builder::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
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
        pub fn method19(v0_1: string) {
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
            ) = Spiral_builder::TraceState::trace_state()
                .get()
                .clone()
                .unwrap();
            let v37: () = {
                Spiral_builder::closure8(patternInput.0.clone(), ());
                ()
            };
            println!("{}", v0_1.clone());
            ();
            ((patternInput.1.clone()).l0.get().clone())(v0_1)
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method16(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method12(),
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
        pub fn method21() -> Func1<(std::string::String, clap::ArgMatches), Spiral_builder::US6> {
            Func1::new(move |arg10_0040: (std::string::String, clap::ArgMatches)| {
                Spiral_builder::closure12((), arg10_0040)
            })
        }
        pub fn method22() -> string {
            string("py-path")
        }
        pub fn closure13(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US7 {
            Spiral_builder::US7::US7_0(v0_1)
        }
        pub fn method23() -> Func1<std::string::String, Spiral_builder::US7> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure13((), v))
        }
        pub fn method24() -> string {
            string("env")
        }
        pub fn method25() -> string {
            string("deps")
        }
        pub fn closure14(unitVar: (), v0_1: Vec<std::string::String>) -> Spiral_builder::US11 {
            Spiral_builder::US11::US11_0(v0_1)
        }
        pub fn method26() -> Func1<Vec<std::string::String>, Spiral_builder::US11> {
            Func1::new(move |v: Vec<std::string::String>| Spiral_builder::closure14((), v))
        }
        pub fn method27(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method28(v0_1: string, v1_1: string) -> string {
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
        pub fn method30(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v69: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v69.clone().exists() {
                v69.is_dir()
            } else {
                false
            }
        }
        pub fn method31(v0_1: string) -> Option<string> {
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
        pub fn method32(v0_1: string, v1_1: string, v2: string) -> Spiral_builder::US12 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method32: loop {
                break '_method32 (if Spiral_builder::method30(Spiral_builder::method28(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    Spiral_builder::US12::US12_0(v2.get().clone())
                } else {
                    let v6: Option<string> = Spiral_builder::method31(v2.get().clone());
                    let v20: Spiral_builder::US5 = defaultValue(
                        Spiral_builder::US5::US5_1,
                        map(Spiral_builder::method6(), v6),
                    );
                    match &v20 {
                        Spiral_builder::US5::US5_0(v20_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: string = match &v20 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
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
        pub fn method29(v0_1: string, v1_1: string) -> Spiral_builder::US12 {
            if Spiral_builder::method30(Spiral_builder::method28(v1_1.clone(), v0_1.clone())) {
                Spiral_builder::US12::US12_0(v1_1.clone())
            } else {
                let v5: Option<string> = Spiral_builder::method31(v1_1.clone());
                let v19: Spiral_builder::US5 = defaultValue(
                    Spiral_builder::US5::US5_1,
                    map(Spiral_builder::method6(), v5),
                );
                match &v19 {
                    Spiral_builder::US5::US5_0(v19_0_0) => Spiral_builder::method32(
                        v0_1.clone(),
                        v1_1.clone(),
                        match &v19 {
                            Spiral_builder::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
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
            let v6: string = Spiral_builder::method13(getCharAt(toLower(string("Warning")), 0_i32));
            let v9: &str = inline_colorization::color_yellow;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method35(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), string("error"), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v2.clone(), v0_1, ());
                ()
            };
            let v44: () = {
                Spiral_builder::closure7(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method34(
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
            let v9: string = Spiral_builder::method35(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.get_workspace_root"),
                v9
            ))
        }
        pub fn closure15(v0_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_3) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method34(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method33(),
                    v0_1,
                ))
            };
        }
        pub fn method36() -> string {
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v5: std::path::PathBuf = v2.unwrap();
            let v19: std::path::Display = v5.display();
            let v43: std::string::String = format!("{}", v19);
            fable_library_rust::String_::fromString(v43)
        }
        pub fn method37() -> string {
            string("\n")
        }
        pub fn method40(v0_1: string) -> bool {
            let v4: &str = &*v0_1;
            let v28: std::string::String = String::from(v4);
            let v69: std::path::PathBuf = std::path::PathBuf::from(v28);
            if v69.clone().exists() {
                v69.is_file()
            } else {
                false
            }
        }
        pub fn method39(v0_1: string, v1_1: string) -> bool {
            if (Spiral_builder::method40(v0_1.clone())) == false {
                false
            } else {
                let v8: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v0_1);
                let v46: Vec<u8> = Spiral_builder::method27(v8.unwrap());
                let v48: Result<std::string::String, std::string::FromUtf8Error> =
                    std::string::String::from_utf8(v46);
                let v51: std::string::String = v48.unwrap();
                (v1_1) == (fable_library_rust::String_::fromString(v51))
            }
        }
        pub fn closure16(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method42() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Spiral_builder::closure16((), v))
        }
        pub fn closure17(unitVar: (), unitVar_1: ()) -> Spiral_builder::US13 {
            Spiral_builder::US13::US13_0
        }
        pub fn method43() -> Func0<Spiral_builder::US13> {
            Func0::new(move || Spiral_builder::closure17((), ()))
        }
        pub fn closure18(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US13 {
            Spiral_builder::US13::US13_1(v0_1)
        }
        pub fn method44() -> Func1<std::string::String, Spiral_builder::US13> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure18((), v))
        }
        pub fn method45() -> string {
            let v6: string =
                Spiral_builder::method13(getCharAt(toLower(string("Critical")), 0_i32));
            let v9: &str = inline_colorization::color_bright_red;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method47(v0_1: string, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("dir"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), v0_1, ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("error"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v67: std::string::String = format!("{:#?}", v1_1);
            let v100: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v67),
                    (),
                );
                ()
            };
            let v109: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method46(
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
            let v10: string = Spiral_builder::method47(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.create_dir"),
                v10
            ))
        }
        pub fn closure19(v0_1: string, v1_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method46(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method45(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method48() -> string {
            let v6: string = Spiral_builder::method13(getCharAt(toLower(string("Verbose")), 0_i32));
            let v9: &str = inline_colorization::color_bright_black;
            let v12: &str = &*v6;
            let v35: &str = inline_colorization::color_reset;
            let v37: std::string::String = format!("{}{}{}", v9, v12, v35);
            fable_library_rust::String_::fromString(v37)
        }
        pub fn method50(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), string("dir"), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v2.clone(), v0_1, ());
                ()
            };
            let v44: () = {
                Spiral_builder::closure7(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
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
        ) -> string {
            let v9: string = Spiral_builder::method50(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.create_dir"),
                v9
            ))
        }
        pub fn closure20(v0_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_0) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method49(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method48(),
                    v0_1,
                ))
            };
        }
        pub fn method52(v0_1: bool, v1_1: string) {
            if Spiral_builder::method30(v1_1.clone()) {
                if v0_1 {
                    std::fs::remove_dir_all(&*v1_1.clone()).unwrap();
                    ()
                } else {
                    std::fs::remove_dir(&*v1_1).unwrap();
                    ()
                };
            }
            ();
            ()
        }
        pub fn closure21(v0_1: string, unitVar: ()) {
            Spiral_builder::method52(true, v0_1);
        }
        pub fn method51(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure21(v0_1.clone(), ())
            })
        }
        pub fn method53(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure21(v0_1.clone(), ())
            })
        }
        pub fn method54(v0_1: string) {
            getZero::<()>();
        }
        pub fn method56(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("dir"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), v0_1, ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("result"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method55(
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
            let v10: string = Spiral_builder::method56(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.create_dir"),
                v10
            ))
        }
        pub fn closure22(v0_1: string, v1_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method55(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method12(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method61(v0_1: string) -> string {
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
                map(Spiral_builder::method6(), v115),
            );
            match &v129 {
                Spiral_builder::US5::US5_0(v129_0_0) => match &v129 {
                    Spiral_builder::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method63(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("ex"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), v0_1, ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("path"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method62(
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
            let v10: string = Spiral_builder::method63(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("file_system.delete_directory_async"),
                v10
            ))
        }
        pub fn closure24(v0_1: string, v1_1: LrcPtr<Exception>, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method62(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method12(),
                    sprintf!("{:?}", v1_1),
                    Spiral_builder::method61(v0_1),
                ))
            };
        }
        pub fn method60(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
            getZero()
        }
        pub fn method59(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
            Spiral_builder::method60(v0_1, v1_1)
        }
        pub fn method58(v0_1: string) -> Arc<Async<i64>> {
            getZero()
        }
        pub fn closure23(v0_1: string, unitVar: ()) {
            let v1_1: Arc<Async<i64>> = Spiral_builder::method58(v0_1);
            let v3: Arc<Async<()>> = getZero();
            getZero::<()>();
            ();
            ()
        }
        pub fn method57(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure23(v0_1.clone(), ())
            })
        }
        pub fn method64(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure23(v0_1.clone(), ())
            })
        }
        pub fn method41(v0_1: string) -> LrcPtr<dyn IDisposable> {
            let v3: Result<(), std::io::Error> = std::fs::create_dir_all(&*v0_1.clone());
            let v4 = Spiral_builder::method42();
            let v16: Result<(), std::string::String> = v3.map_err(|x| v4(x));
            let v19 = Spiral_builder::method43();
            let v20 = Spiral_builder::method44();
            let v21: Spiral_builder::US13 = match &v16 {
                Err(v16_1_0) => v20(v16_1_0.clone()),
                _ => v19(),
            };
            match &v21 {
                Spiral_builder::US13::US13_0 => {
                    let v24: () = {
                        Spiral_builder::closure20(v0_1.clone(), ());
                        ()
                    };
                    ()
                }
                Spiral_builder::US13::US13_1(v21_1_0) => {
                    let v67: () = {
                        Spiral_builder::closure19(
                            v0_1.clone(),
                            match &v21 {
                                Spiral_builder::US13::US13_1(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            (),
                        );
                        ()
                    };
                    ()
                }
            }
            {
                let v108 = Spiral_builder::method51(v0_1.clone());
                interface_cast!(
                    Spiral_builder::Disposable::_ctor__3A5B6456(Func0::new({
                        let v108 = v108.clone();
                        move || v108.clone()()
                    })),
                    Lrc<dyn IDisposable>,
                )
            }
        }
        pub fn method38(v0_1: string, v1_1: string) {
            if (Spiral_builder::method39(v0_1.clone(), v1_1.clone())) == false {
                let v6: string = defaultValue(string(""), Spiral_builder::method31(v0_1.clone()));
                if (Spiral_builder::method30(v6.clone())) == false {
                    let v11: LrcPtr<dyn IDisposable> = Spiral_builder::method41(v6);
                    ()
                }
                std::fs::write(&*v0_1, &*v1_1).unwrap();
                ();
                ()
            };
        }
        pub fn method66(
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
        pub fn method68() -> string {
            string("")
        }
        pub fn method69(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn closure27(
            v0_1: char,
            v1_1: LrcPtr<Spiral_builder::UH0>,
        ) -> LrcPtr<Spiral_builder::UH0> {
            LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure26(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Spiral_builder::UH0>, LrcPtr<Spiral_builder::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Spiral_builder::UH0>| Spiral_builder::closure27(v0_1, v)
            })
        }
        pub fn method70(
        ) -> Func1<char, Func1<LrcPtr<Spiral_builder::UH0>, LrcPtr<Spiral_builder::UH0>>> {
            Func1::new(move |v: char| Spiral_builder::closure26((), v))
        }
        pub fn method71(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method71: loop {
                break '_method71 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH0::UH0_0 => {
                        (v1_1.get().clone(), v2.get().clone(), v3.get().clone())
                    }
                    Spiral_builder::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v4: char = match v0_1.get().clone().as_ref() {
                            Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: bool = '\n' == (v4);
                        let patternInput: (i32, i32) = if v6 {
                            ((v2.get().clone()) + 1_i32, 1_i32)
                        } else {
                            (v2.get().clone(), (v3.get().clone()) + 1_i32)
                        };
                        {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH0> =
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
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
                            continue '_method71;
                        }
                    }
                });
            }
        }
        pub fn closure25(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\"',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if (v9) == '\"' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method69(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = (v42) + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method71(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method70())(b0)(b1)
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
                    let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Spiral_builder::US15::US15_1(concat(new_array(&[
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
                                    (if -2_i32 == (v83) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v83) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append((replicate((v3) - 1_i32, string(" "))), string("^")),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn closure28(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US15 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\'',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if (v9) == '\'' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method69(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = (v42) + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method71(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method70())(b0)(b1)
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
                    let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Spiral_builder::US15::US15_1(concat(new_array(&[
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
                                    (if -2_i32 == (v83) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v83) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append((replicate((v3) - 1_i32, string(" "))), string("^")),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn method72(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Spiral_builder::UH1>,
        ) -> Spiral_builder::US15 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            '_method72: loop {
                break '_method72 (match v2.get().clone().as_ref() {
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
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method72;
                            }
                        }
                    }
                });
            }
        }
        pub fn method73(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method73: loop {
                break '_method73 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Spiral_builder::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Spiral_builder::US17::US17_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Spiral_builder::US17::US17_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Spiral_builder::US17::US17_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Spiral_builder::US17::US17_0(v11_0_0) => match &v11 {
                                Spiral_builder::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method73;
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
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method74: loop {
                break '_method74 ({
                    let v109: Spiral_builder::US15 = if string("") == (v1_1.get().clone()) {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v21: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Spiral_builder::method73(v21, 0_i64)) == false {
                            let v44: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v49: string = ofChar(v21);
                            let v52: i32 = length(v49.clone());
                            let v53: Array<char> = new_init(&'\u{0000}', v52);
                            let v54: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method69(v52, v54.clone()) {
                                let v56: i32 = v54.l0.get().clone();
                                let v57: char = getCharAt(v49.clone(), v56);
                                v53.get_mut()[v56 as usize] = v57;
                                {
                                    let v58: i32 = (v56) + 1_i32;
                                    v54.l0.set(v58);
                                    ()
                                }
                            }
                            {
                                let v59: List<char> = ofArray(v53.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method71(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method70())(b0)(b1)
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
                                if '\\' == (v110) { '/' } else { v110 },
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
                                append((v0_1.get().clone()), (ofChar(v121_0_0.clone())));
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method74;
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
        pub fn method75(
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
            '_method75: loop {
                break '_method75 (match v4.get().clone().as_ref() {
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
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method75;
                            }
                        }
                    }
                });
            }
        }
        pub fn method76(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method76: loop {
                break '_method76 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Spiral_builder::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Spiral_builder::US17::US17_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Spiral_builder::US17::US17_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Spiral_builder::US17::US17_0(' ')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Spiral_builder::US17::US17_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Spiral_builder::US17::US17_0(v15_0_0) => match &v15 {
                                Spiral_builder::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method76;
                    }
                });
            }
        }
        pub fn method77(
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
            '_method77: loop {
                break '_method77 ({
                    let v115: Spiral_builder::US15 = if string("") == (v1_1.get().clone()) {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Spiral_builder::method76(v24, 0_i64)) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method69(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = (v59) + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method71(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method70())(b0)(b1)
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
                                if '\\' == (v116) { '/' } else { v116 },
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
                                append((v0_1.get().clone()), (ofChar(v127_0_0.clone())));
                            let v1_1_temp: string = v127_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v127_0_2.clone();
                            let v3_temp: i32 = v127_0_3.clone();
                            let v4_temp: i32 = v127_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method77;
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
        pub fn method78(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method78: loop {
                break '_method78 (if (v1_1.get().clone()) >= (length(v0_1.get().clone())) {
                    v1_1.get().clone()
                } else {
                    if ' ' == (getCharAt(v0_1.get().clone(), v1_1.get().clone())) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method78;
                    } else {
                        v1_1.get().clone()
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
                    let v79: Spiral_builder::US15 = if string("") == (v1_1.get().clone()) {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v10: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v30: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v35: string = ofChar(v10);
                        let v38: i32 = length(v35.clone());
                        let v39: Array<char> = new_init(&'\u{0000}', v38);
                        let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                            l0: MutCell::new(0_i32),
                        });
                        while Spiral_builder::method69(v38, v40.clone()) {
                            let v42: i32 = v40.l0.get().clone();
                            let v43: char = getCharAt(v35.clone(), v42);
                            v39.get_mut()[v42 as usize] = v43;
                            {
                                let v44: i32 = (v42) + 1_i32;
                                v40.l0.set(v44);
                                ()
                            }
                        }
                        {
                            let v45: List<char> = ofArray(v39.clone());
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method71(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method70())(b0)(b1)
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
                                append((v0_1.get().clone()), (ofChar(v79_0_0.clone())));
                            let v1_1_temp: string = v79_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v79_0_2.clone();
                            let v3_temp: i32 = v79_0_3.clone();
                            let v4_temp: i32 = v79_0_4.clone();
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
        pub fn method67(v0_1: string) -> Spiral_builder::US14 {
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
                    StringBuilder::_ctor__Z721C83C5(Spiral_builder::method68());
                fn v15(
                    arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32),
                ) -> Spiral_builder::US15 {
                    Spiral_builder::closure25((), arg10_0040)
                }
                fn v16(
                    arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32),
                ) -> Spiral_builder::US15 {
                    Spiral_builder::closure28((), arg10_0040_1)
                }
                let v20: Spiral_builder::US15 = Spiral_builder::method72(
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
                        let v130: Spiral_builder::US15 = if string("") == (v22.clone()) {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v23.clone(), v24, v25)
                            ))
                        } else {
                            let v42: char = getCharAt(v22.clone(), 0_i32);
                            if (Spiral_builder::method73(v42, 0_i64)) == false {
                                let v65: string = getSlice(
                                    v22.clone(),
                                    Some(1_i32),
                                    Some((length(v22.clone())) - 1_i32),
                                );
                                let v70: string = ofChar(v42);
                                let v73: i32 = length(v70.clone());
                                let v74: Array<char> = new_init(&'\u{0000}', v73);
                                let v75: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method69(v73, v75.clone()) {
                                    let v77: i32 = v75.l0.get().clone();
                                    let v78: char = getCharAt(v70.clone(), v77);
                                    v74.get_mut()[v77 as usize] = v78;
                                    {
                                        let v79: i32 = (v77) + 1_i32;
                                        v75.l0.set(v79);
                                        ()
                                    }
                                }
                                {
                                    let v80: List<char> = ofArray(v74.clone());
                                    let patternInput:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method71(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method70())(b0)(b1)),
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
                                    if '\\' == (v131) { '/' } else { v131 },
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
                                ) = Spiral_builder::method74(
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
                                let v180: Spiral_builder::US15 = Spiral_builder::method75(
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
                                                                              (v22.clone(),
                                                                               v23.clone(),
                                                                               v24,
                                                                               v25),
                                                                              (v173.clone(),
                                                                               v174.clone(),
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
                        let v321: Spiral_builder::US15 = if string("") == (v7.clone()) {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v12.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v228: char = getCharAt(v7.clone(), 0_i32);
                            if (Spiral_builder::method76(v228, 0_i64)) == false {
                                let v251: string = getSlice(
                                    v7.clone(),
                                    Some(1_i32),
                                    Some((length(v7.clone())) - 1_i32),
                                );
                                let v256: string = ofChar(v228);
                                let v259: i32 = length(v256.clone());
                                let v260: Array<char> = new_init(&'\u{0000}', v259);
                                let v261: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method69(v259, v261.clone()) {
                                    let v263: i32 = v261.l0.get().clone();
                                    let v264: char = getCharAt(v256.clone(), v263);
                                    v260.get_mut()[v263 as usize] = v264;
                                    {
                                        let v265: i32 = (v263) + 1_i32;
                                        v261.l0.set(v265);
                                        ()
                                    }
                                }
                                {
                                    let v266: List<char> = ofArray(v260.clone());
                                    let patternInput_2:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method71(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method70())(b0)(b1)),
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
                                    if '\\' == (v322) { '/' } else { v322 },
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
                                ) = Spiral_builder::method77(
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
                                let v366: Spiral_builder::US18 = if (length(v7.clone())) == 0_i32 {
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
                                                Some(Spiral_builder::method78(v377.clone(), 0_i32)),
                                                Some((length(v377)) - 1_i32),
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
                        let v544: Spiral_builder::US15 = if string("") == (v416.clone()) {
                            Spiral_builder::US15::US15_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                ' ',
                                (v417.clone(), v418, v419)
                            ))
                        } else {
                            let v425: char = getCharAt(v416.clone(), 0_i32);
                            if (v425) == ' ' {
                                let v446: string = getSlice(
                                    v416.clone(),
                                    Some(1_i32),
                                    Some((length(v416.clone())) - 1_i32),
                                );
                                let v451: string = ofChar(v425);
                                let v454: i32 = length(v451.clone());
                                let v455: Array<char> = new_init(&'\u{0000}', v454);
                                let v456: LrcPtr<Spiral_builder::Mut5> =
                                    LrcPtr::new(Spiral_builder::Mut5 {
                                        l0: MutCell::new(0_i32),
                                    });
                                while Spiral_builder::method69(v454, v456.clone()) {
                                    let v458: i32 = v456.l0.get().clone();
                                    let v459: char = getCharAt(v451.clone(), v458);
                                    v455.get_mut()[v458 as usize] = v459;
                                    {
                                        let v460: i32 = (v458) + 1_i32;
                                        v456.l0.set(v460);
                                        ()
                                    }
                                }
                                {
                                    let v461: List<char> = ofArray(v455.clone());
                                    let patternInput_4:
                                                    (LrcPtr<StringBuilder>,
                                                     i32, i32) =
                                                Spiral_builder::method71(foldBack(Func2::new(move
                                                                                                 |b0:
                                                                                                      char,
                                                                                                  b1:
                                                                                                      LrcPtr<Spiral_builder::UH0>|
                                                                                                 (Spiral_builder::method70())(b0)(b1)),
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
                                let v499: i32 = (indexOf(v416.clone(), string("\n"))) - 1_i32;
                                Spiral_builder::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                 ' ',
                                                                                                 v418,
                                                                                                 v419,
                                                                                                 v417.clone(),
                                                                                                 getSlice(v416.clone(),
                                                                                                          Some(0_i32),
                                                                                                          Some((if -2_i32
                                                                                                                       ==
                                                                                                                       (v499)
                                                                                                                   {
                                                                                                                    (length(v416.clone()))
                                                                                                                        +
                                                                                                                        1_i32
                                                                                                                } else {
                                                                                                                    (v499)
                                                                                                                        +
                                                                                                                        1_i32
                                                                                                                })
                                                                                                                   -
                                                                                                                   1_i32))),
                                                                                        string("\n"),
                                                                                        append((replicate((v419)
                                                                                                              -
                                                                                                              1_i32,
                                                                                                          string(" "))),
                                                                                               string("^")),
                                                                                        string("\n")])))
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
                                let v636: Spiral_builder::US15 = if string("") == (v558.clone()) {
                                    Spiral_builder::US15::US15_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v559.clone(), v560, v561)
                                    ))
                                } else {
                                    let v567: char = getCharAt(v558.clone(), 0_i32);
                                    let v587: string = getSlice(
                                        v558.clone(),
                                        Some(1_i32),
                                        Some((length(v558)) - 1_i32),
                                    );
                                    let v592: string = ofChar(v567);
                                    let v595: i32 = length(v592.clone());
                                    let v596: Array<char> = new_init(&'\u{0000}', v595);
                                    let v597: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method69(v595, v597.clone()) {
                                        let v599: i32 = v597.l0.get().clone();
                                        let v600: char = getCharAt(v592.clone(), v599);
                                        v596.get_mut()[v599 as usize] = v600;
                                        {
                                            let v601: i32 = (v599) + 1_i32;
                                            v597.l0.set(v601);
                                            ()
                                        }
                                    }
                                    {
                                        let v602: List<char> = ofArray(v596.clone());
                                        let patternInput_5:
                                                            (LrcPtr<StringBuilder>,
                                                             i32, i32) =
                                                        Spiral_builder::method71(foldBack(Func2::new(move
                                                                                                         |b0:
                                                                                                              char,
                                                                                                          b1:
                                                                                                              LrcPtr<Spiral_builder::UH0>|
                                                                                                         (Spiral_builder::method70())(b0)(b1)),
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
                                        ) = Spiral_builder::method79(
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
                                v416.clone(),
                                v417.clone(),
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
        pub fn method82(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method82: loop {
                break '_method82 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Spiral_builder::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Spiral_builder::US17::US17_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Spiral_builder::US17::US17_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Spiral_builder::US17::US17_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Spiral_builder::US17::US17_0(' ')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Spiral_builder::US17::US17_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Spiral_builder::US17::US17_0(v19_0_0) => match &v19 {
                                Spiral_builder::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method82;
                    }
                });
            }
        }
        pub fn method83(
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
            '_method83: loop {
                break '_method83 ({
                    let v121: Spiral_builder::US15 = if string("") == (v1_1.get().clone()) {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Spiral_builder::method82(v27, 0_i64)) == false {
                            let v50: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v55: string = ofChar(v27);
                            let v58: i32 = length(v55.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method69(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v55.clone(), v62);
                                v59.get_mut()[v62 as usize] = v63;
                                {
                                    let v64: i32 = (v62) + 1_i32;
                                    v60.l0.set(v64);
                                    ()
                                }
                            }
                            {
                                let v65: List<char> = ofArray(v59.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method71(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method70())(b0)(b1)
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
                                append((v0_1.get().clone()), (ofChar(v121_0_0.clone())));
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method83;
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
        pub fn method85(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method85: loop {
                break '_method85 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Spiral_builder::US17 = if (v1_1.get().clone()) == 0_i64 {
                        Spiral_builder::US17::US17_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Spiral_builder::US17::US17_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Spiral_builder::US17::US17_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Spiral_builder::US17::US17_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Spiral_builder::US17::US17_0(v15_0_0) => match &v15 {
                                Spiral_builder::US17::US17_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method85;
                    }
                });
            }
        }
        pub fn closure29(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v128: Spiral_builder::US15 = if string("") == (v0_1.clone()) {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\\',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if (v9) == '\\' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method69(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = (v42) + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method71(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method70())(b0)(b1)
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
                    let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Spiral_builder::US15::US15_1(concat(new_array(&[
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
                                    (if -2_i32 == (v83) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v83) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append((replicate((v3) - 1_i32, string(" "))), string("^")),
                        string("\n"),
                    ])))
                }
            };
            let v212: Spiral_builder::US15 = match &v128 {
                Spiral_builder::US15::US15_0(v128_0_0, v128_0_1, v128_0_2, v128_0_3, v128_0_4) => {
                    let v133: i32 = v128_0_4.clone();
                    let v132: i32 = v128_0_3.clone();
                    let v131: LrcPtr<StringBuilder> = v128_0_2.clone();
                    let v130: string = v128_0_1.clone();
                    if string("") == (v130.clone()) {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v131.clone(), v132, v133)
                        ))
                    } else {
                        let v139: char = getCharAt(v130.clone(), 0_i32);
                        let v159: string =
                            getSlice(v130.clone(), Some(1_i32), Some((length(v130)) - 1_i32));
                        let v164: string = ofChar(v139);
                        let v167: i32 = length(v164.clone());
                        let v168: Array<char> = new_init(&'\u{0000}', v167);
                        let v169: LrcPtr<Spiral_builder::Mut5> =
                            LrcPtr::new(Spiral_builder::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                        while Spiral_builder::method69(v167, v169.clone()) {
                            let v171: i32 = v169.l0.get().clone();
                            let v172: char = getCharAt(v164.clone(), v171);
                            v168.get_mut()[v171 as usize] = v172;
                            {
                                let v173: i32 = (v171) + 1_i32;
                                v169.l0.set(v173);
                                ()
                            }
                        }
                        {
                            let v174: List<char> = ofArray(v168.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method71(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method70())(b0)(b1)
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
                        append((ofChar('\\')), (ofChar(v212_0_0.clone()))),
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
        pub fn closure30(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v128: Spiral_builder::US15 = if string("") == (v0_1.clone()) {
                Spiral_builder::US15::US15_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '`',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v9: char = getCharAt(v0_1.clone(), 0_i32);
                if (v9) == '`' {
                    let v30: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v35: string = ofChar(v9);
                    let v38: i32 = length(v35.clone());
                    let v39: Array<char> = new_init(&'\u{0000}', v38);
                    let v40: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method69(v38, v40.clone()) {
                        let v42: i32 = v40.l0.get().clone();
                        let v43: char = getCharAt(v35.clone(), v42);
                        v39.get_mut()[v42 as usize] = v43;
                        {
                            let v44: i32 = (v42) + 1_i32;
                            v40.l0.set(v44);
                            ()
                        }
                    }
                    {
                        let v45: List<char> = ofArray(v39.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method71(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method70())(b0)(b1)
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
                    let v83: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Spiral_builder::US15::US15_1(concat(new_array(&[
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
                                    (if -2_i32 == (v83) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v83) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append((replicate((v3) - 1_i32, string(" "))), string("^")),
                        string("\n"),
                    ])))
                }
            };
            let v212: Spiral_builder::US15 = match &v128 {
                Spiral_builder::US15::US15_0(v128_0_0, v128_0_1, v128_0_2, v128_0_3, v128_0_4) => {
                    let v133: i32 = v128_0_4.clone();
                    let v132: i32 = v128_0_3.clone();
                    let v131: LrcPtr<StringBuilder> = v128_0_2.clone();
                    let v130: string = v128_0_1.clone();
                    if string("") == (v130.clone()) {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v131.clone(), v132, v133)
                        ))
                    } else {
                        let v139: char = getCharAt(v130.clone(), 0_i32);
                        let v159: string =
                            getSlice(v130.clone(), Some(1_i32), Some((length(v130)) - 1_i32));
                        let v164: string = ofChar(v139);
                        let v167: i32 = length(v164.clone());
                        let v168: Array<char> = new_init(&'\u{0000}', v167);
                        let v169: LrcPtr<Spiral_builder::Mut5> =
                            LrcPtr::new(Spiral_builder::Mut5 {
                                l0: MutCell::new(0_i32),
                            });
                        while Spiral_builder::method69(v167, v169.clone()) {
                            let v171: i32 = v169.l0.get().clone();
                            let v172: char = getCharAt(v164.clone(), v171);
                            v168.get_mut()[v171 as usize] = v172;
                            {
                                let v173: i32 = (v171) + 1_i32;
                                v169.l0.set(v173);
                                ()
                            }
                        }
                        {
                            let v174: List<char> = ofArray(v168.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method71(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method70())(b0)(b1)
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
                        append((ofChar('`')), (ofChar(v212_0_0.clone()))),
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
        pub fn method86(
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
            '_method86: loop {
                break '_method86 (match v4.get().clone().as_ref() {
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
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method86;
                            }
                        }
                    }
                });
            }
        }
        pub fn method87(
            v0_1: LrcPtr<Spiral_builder::UH2>,
            v1_1: LrcPtr<Spiral_builder::UH2>,
        ) -> LrcPtr<Spiral_builder::UH2> {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v1_1.clone());
            '_method87: loop {
                break '_method87 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH2::UH2_0 => v1_1.get().clone(),
                    Spiral_builder::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Spiral_builder::UH2> =
                            match v0_1.get().clone().as_ref() {
                                Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                        let v1_1_temp: LrcPtr<Spiral_builder::UH2> =
                            LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                v1_1.get().clone(),
                            ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method87;
                    }
                });
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
                    let v115: Spiral_builder::US15 = if string("") == (v1_1.get().clone()) {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Spiral_builder::method85(v24, 0_i64)) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method69(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = (v59) + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method71(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method70())(b0)(b1)
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
                        _ => Spiral_builder::method86(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Spiral_builder::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Spiral_builder::closure29((), arg10_0040)
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
                                            Spiral_builder::closure30((), arg10_0040_1)
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
                            continue '_method84;
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method87(
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
        pub fn method88(v0_1: LrcPtr<Spiral_builder::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Spiral_builder::UH2::UH2_0 => v1_1.clone(),
                Spiral_builder::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Spiral_builder::method88(
                        match v0_1.as_ref() {
                            Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method89(
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
            '_method89: loop {
                break '_method89 ({
                    let v115: Spiral_builder::US15 = if string("") == (v1_1.get().clone()) {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v24: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Spiral_builder::method85(v24, 0_i64)) == false {
                            let v47: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v52: string = ofChar(v24);
                            let v55: i32 = length(v52.clone());
                            let v56: Array<char> = new_init(&'\u{0000}', v55);
                            let v57: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method69(v55, v57.clone()) {
                                let v59: i32 = v57.l0.get().clone();
                                let v60: char = getCharAt(v52.clone(), v59);
                                v56.get_mut()[v59 as usize] = v60;
                                {
                                    let v61: i32 = (v59) + 1_i32;
                                    v57.l0.set(v61);
                                    ()
                                }
                            }
                            {
                                let v62: List<char> = ofArray(v56.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method71(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method70())(b0)(b1)
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
                            continue '_method89;
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method87(
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
        pub fn method81(
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
            '_method81: loop {
                break '_method81 ({
                    let v5: bool = string("") == (v1_1.get().clone());
                    let v121: Spiral_builder::US15 = if v5 {
                        Spiral_builder::US15::US15_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v27: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Spiral_builder::method82(v27, 0_i64)) == false {
                            let v50: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v55: string = ofChar(v27);
                            let v58: i32 = length(v55.clone());
                            let v59: Array<char> = new_init(&'\u{0000}', v58);
                            let v60: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method69(v58, v60.clone()) {
                                let v62: i32 = v60.l0.get().clone();
                                let v63: char = getCharAt(v55.clone(), v62);
                                v59.get_mut()[v62 as usize] = v63;
                                {
                                    let v64: i32 = (v62) + 1_i32;
                                    v60.l0.set(v64);
                                    ()
                                }
                            }
                            {
                                let v65: List<char> = ofArray(v59.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method71(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method70())(b0)(b1)
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
                                Spiral_builder::method83(
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
                    let v521: Spiral_builder::US16 = match &v140 {
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
                                if (v151) == '\"' {
                                    let v172: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some((length(v1_1.get().clone())) - 1_i32),
                                    );
                                    let v177: string = ofChar(v151);
                                    let v180: i32 = length(v177.clone());
                                    let v181: Array<char> = new_init(&'\u{0000}', v180);
                                    let v182: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method69(v180, v182.clone()) {
                                        let v184: i32 = v182.l0.get().clone();
                                        let v185: char = getCharAt(v177.clone(), v184);
                                        v181.get_mut()[v184 as usize] = v185;
                                        {
                                            let v186: i32 = (v184) + 1_i32;
                                            v182.l0.set(v186);
                                            ()
                                        }
                                    }
                                    {
                                        let v187: List<char> = ofArray(v181.clone());
                                        let patternInput_2:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Spiral_builder::method71(foldBack(Func2::new(move
                                                                                                              |b0:
                                                                                                                   char,
                                                                                                               b1:
                                                                                                                   LrcPtr<Spiral_builder::UH0>|
                                                                                                              (Spiral_builder::method70())(b0)(b1)),
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
                                        (indexOf(v1_1.get().clone(), string("\n"))) - 1_i32;
                                    Spiral_builder::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                              '\"',
                                                                                                              v3.get().clone(),
                                                                                                              v4.get().clone(),
                                                                                                              v2.get().clone(),
                                                                                                              getSlice(v1_1.get().clone(),
                                                                                                                       Some(0_i32),
                                                                                                                       Some((if -2_i32
                                                                                                                                    ==
                                                                                                                                    (v225)
                                                                                                                                {
                                                                                                                                 (length(v1_1.get().clone()))
                                                                                                                                     +
                                                                                                                                     1_i32
                                                                                                                             } else {
                                                                                                                                 (v225)
                                                                                                                                     +
                                                                                                                                     1_i32
                                                                                                                             })
                                                                                                                                -
                                                                                                                                1_i32))),
                                                                                                     string("\n"),
                                                                                                     append((replicate((v4.get().clone())
                                                                                                                           -
                                                                                                                           1_i32,
                                                                                                                       string(" "))),
                                                                                                            string("^")),
                                                                                                     string("\n")])))
                                }
                            };
                            let v456: Spiral_builder::US16 = match &v270 {
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
                                    let v277: Spiral_builder::US23 = Spiral_builder::method84(
                                        LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        v272.clone(),
                                        v273.clone(),
                                        v274,
                                        v275,
                                    );
                                    let v304: Spiral_builder::US16 = match &v277 {
                                        Spiral_builder::US23::US23_0(
                                            v277_0_0,
                                            v277_0_1,
                                            v277_0_2,
                                            v277_0_3,
                                            v277_0_4,
                                        ) => {
                                            let v284: List<string> = Spiral_builder::method88(
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
                                                                    (length_1(v284.clone()))
                                                                        - 1_i32,
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
                                    match &v304 {
                                        Spiral_builder::US16::US16_0(
                                            v304_0_0,
                                            v304_0_1,
                                            v304_0_2,
                                            v304_0_3,
                                            v304_0_4,
                                        ) => {
                                            let v309: i32 = v304_0_4.clone();
                                            let v308: i32 = v304_0_3.clone();
                                            let v307: LrcPtr<StringBuilder> = v304_0_2.clone();
                                            let v306: string = v304_0_1.clone();
                                            let v434: Spiral_builder::US15 = if string("")
                                                == (v306.clone())
                                            {
                                                Spiral_builder::US15::US15_1(sprintf!("parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                                                                           '\"',
                                                                                                           (v307.clone(),
                                                                                                            v308,
                                                                                                            v309)))
                                            } else {
                                                let v315: char = getCharAt(v306.clone(), 0_i32);
                                                if (v315) == '\"' {
                                                    let v336: string = getSlice(
                                                        v306.clone(),
                                                        Some(1_i32),
                                                        Some((length(v306.clone())) - 1_i32),
                                                    );
                                                    let v341: string = ofChar(v315);
                                                    let v344: i32 = length(v341.clone());
                                                    let v345: Array<char> =
                                                        new_init(&'\u{0000}', v344);
                                                    let v346: LrcPtr<Spiral_builder::Mut5> =
                                                        LrcPtr::new(Spiral_builder::Mut5 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Spiral_builder::method69(
                                                        v344,
                                                        v346.clone(),
                                                    ) {
                                                        let v348: i32 = v346.l0.get().clone();
                                                        let v349: char =
                                                            getCharAt(v341.clone(), v348);
                                                        v345.get_mut()[v348 as usize] = v349;
                                                        {
                                                            let v350: i32 = (v348) + 1_i32;
                                                            v346.l0.set(v350);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v351: List<char> =
                                                            ofArray(v345.clone());
                                                        let patternInput_3:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Spiral_builder::method71(foldBack(Func2::new(move
                                                                                                                                  |b0:
                                                                                                                                       char,
                                                                                                                                   b1:
                                                                                                                                       LrcPtr<Spiral_builder::UH0>|
                                                                                                                                  (Spiral_builder::method70())(b0)(b1)),
                                                                                                                   v351,
                                                                                                                   LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                                          v307.clone(),
                                                                                                          v308,
                                                                                                          v309);
                                                        Spiral_builder::US15::US15_0(
                                                            v315,
                                                            v336,
                                                            patternInput_3.0.clone(),
                                                            patternInput_3.1.clone(),
                                                            patternInput_3.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v389: i32 =
                                                        (indexOf(v306.clone(), string("\n")))
                                                            - 1_i32;
                                                    Spiral_builder::US15::US15_1(concat(new_array(&[sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                                  '\"',
                                                                                                                                  v308,
                                                                                                                                  v309,
                                                                                                                                  v307.clone(),
                                                                                                                                  getSlice(v306.clone(),
                                                                                                                                           Some(0_i32),
                                                                                                                                           Some((if -2_i32
                                                                                                                                                        ==
                                                                                                                                                        (v389)
                                                                                                                                                    {
                                                                                                                                                     (length(v306.clone()))
                                                                                                                                                         +
                                                                                                                                                         1_i32
                                                                                                                                                 } else {
                                                                                                                                                     (v389)
                                                                                                                                                         +
                                                                                                                                                         1_i32
                                                                                                                                                 })
                                                                                                                                                    -
                                                                                                                                                    1_i32))),
                                                                                                                         string("\n"),
                                                                                                                         append((replicate((v309)
                                                                                                                                               -
                                                                                                                                               1_i32,
                                                                                                                                           string(" "))),
                                                                                                                                string("^")),
                                                                                                                         string("\n")])))
                                                }
                                            };
                                            match &v434 {
                                                                 Spiral_builder::US15::US15_0(v434_0_0,
                                                                                              v434_0_1,
                                                                                              v434_0_2,
                                                                                              v434_0_3,
                                                                                              v434_0_4)
                                                                 =>
                                                                 Spiral_builder::US16::US16_0(v304_0_0.clone(),
                                                                                              v434_0_1.clone(),
                                                                                              v434_0_2.clone(),
                                                                                              v434_0_3.clone(),
                                                                                              v434_0_4.clone()),
                                                                 Spiral_builder::US15::US15_1(v434_1_0)
                                                                 =>
                                                                 Spiral_builder::US16::US16_1(sprintf!("parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                       v434_1_0.clone(),
                                                                                                       (v1_1.get().clone(),
                                                                                                        v2.get().clone(),
                                                                                                        v3.get().clone(),
                                                                                                        v4.get().clone()),
                                                                                                       (v272.clone(),
                                                                                                        v273.clone(),
                                                                                                        v274,
                                                                                                        v275),
                                                                                                       (v306.clone(),
                                                                                                        v307.clone(),
                                                                                                        v308,
                                                                                                        v309))),
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
                            match &v456 {
                                Spiral_builder::US16::US16_0(
                                    v456_0_0,
                                    v456_0_1,
                                    v456_0_2,
                                    v456_0_3,
                                    v456_0_4,
                                ) => v456.clone(),
                                _ => {
                                    let v468:
                                                         Spiral_builder::US16 =
                                                     Spiral_builder::method86(v1_1.get().clone(),
                                                                              v2.get().clone(),
                                                                              v3.get().clone(),
                                                                              v4.get().clone(),
                                                                              LrcPtr::new(Spiral_builder::UH3::UH3_1(Func1::new(move
                                                                                                                                    |arg10_0040:
                                                                                                                                         (string,
                                                                                                                                          LrcPtr<StringBuilder>,
                                                                                                                                          i32,
                                                                                                                                          i32)|
                                                                                                                                    Spiral_builder::closure29((),
                                                                                                                                                              arg10_0040)),
                                                                                                                     LrcPtr::new(Spiral_builder::UH3::UH3_1(Func1::new(move
                                                                                                                                                                           |arg10_0040_1:
                                                                                                                                                                                (string,
                                                                                                                                                                                 LrcPtr<StringBuilder>,
                                                                                                                                                                                 i32,
                                                                                                                                                                                 i32)|
                                                                                                                                                                           Spiral_builder::closure30((),
                                                                                                                                                                                                     arg10_0040_1)),
                                                                                                                                                            LrcPtr::new(Spiral_builder::UH3::UH3_0))))));
                                    let v479: Spiral_builder::US16 = match &v468 {
                                        Spiral_builder::US16::US16_0(
                                            v468_0_0,
                                            v468_0_1,
                                            v468_0_2,
                                            v468_0_3,
                                            v468_0_4,
                                        ) => Spiral_builder::US16::US16_0(
                                            string(""),
                                            v468_0_1.clone(),
                                            v468_0_2.clone(),
                                            v468_0_3.clone(),
                                            v468_0_4.clone(),
                                        ),
                                        Spiral_builder::US16::US16_1(v468_1_0) => {
                                            Spiral_builder::US16::US16_1(v468_1_0.clone())
                                        }
                                    };
                                    let v490: Spiral_builder::US23 = match &v479 {
                                        Spiral_builder::US16::US16_0(
                                            v479_0_0,
                                            v479_0_1,
                                            v479_0_2,
                                            v479_0_3,
                                            v479_0_4,
                                        ) => Spiral_builder::method89(
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                            v479_0_1.clone(),
                                            v479_0_2.clone(),
                                            v479_0_3.clone(),
                                            v479_0_4.clone(),
                                        ),
                                        Spiral_builder::US16::US16_1(v479_1_0) => {
                                            Spiral_builder::US23::US23_1(v479_1_0.clone())
                                        }
                                    };
                                    match &v490 {
                                        Spiral_builder::US23::US23_0(
                                            v490_0_0,
                                            v490_0_1,
                                            v490_0_2,
                                            v490_0_3,
                                            v490_0_4,
                                        ) => {
                                            let v497: List<string> = Spiral_builder::method88(
                                                v490_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US16::US16_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v497 = v497.clone();
                                                        move || {
                                                            map_1(
                                                                Func1::new({
                                                                    let v497 = v497.clone();
                                                                    move |i_1: i32| {
                                                                        item(i_1, v497.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    (length_1(v497.clone()))
                                                                        - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v490_0_1.clone(),
                                                v490_0_2.clone(),
                                                v490_0_3.clone(),
                                                v490_0_4.clone(),
                                            )
                                        }
                                        Spiral_builder::US23::US23_1(v490_1_0) => {
                                            Spiral_builder::US16::US16_1(v490_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v521 {
                        Spiral_builder::US16::US16_0(
                            v521_0_0,
                            v521_0_1,
                            v521_0_2,
                            v521_0_3,
                            v521_0_4,
                        ) => {
                            let v526: i32 = v521_0_4.clone();
                            let v525: i32 = v521_0_3.clone();
                            let v524: LrcPtr<StringBuilder> = v521_0_2.clone();
                            let v523: string = v521_0_1.clone();
                            let v522: string = v521_0_0.clone();
                            let v528: i32 = Spiral_builder::method78(v523.clone(), 0_i32);
                            let v556: Spiral_builder::US18 = if 0_i32 == (v528) {
                                Spiral_builder::US18::US18_1(string(
                                    "parsing.spaces1 / expected at least one space",
                                ))
                            } else {
                                Spiral_builder::US18::US18_0(
                                    getSlice(
                                        v523.clone(),
                                        Some(v528),
                                        Some((length(v523.clone())) - 1_i32),
                                    ),
                                    v524.clone(),
                                    v525,
                                    v526,
                                )
                            };
                            match &v556 {
                                Spiral_builder::US18::US18_0(
                                    v556_0_0,
                                    v556_0_1,
                                    v556_0_2,
                                    v556_0_3,
                                ) => {
                                    let v0_1_temp: LrcPtr<Spiral_builder::UH2> =
                                        LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                            v522.clone(),
                                            v0_1.get().clone(),
                                        ));
                                    let v1_1_temp: string = v556_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v556_0_1.clone();
                                    let v3_temp: i32 = v556_0_2.clone();
                                    let v4_temp: i32 = v556_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method81;
                                }
                                _ => Spiral_builder::US23::US23_0(
                                    Spiral_builder::method87(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                            v522.clone(),
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        )),
                                    ),
                                    v523.clone(),
                                    v524.clone(),
                                    v525,
                                    v526,
                                ),
                            }
                        }
                        _ => Spiral_builder::US23::US23_0(
                            Spiral_builder::method87(
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
        pub fn method80(v0_1: string) -> Spiral_builder::US22 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v18: Spiral_builder::US23 = Spiral_builder::method81(
                    LrcPtr::new(Spiral_builder::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Spiral_builder::method68()),
                    1_i32,
                    1_i32,
                );
                match &v18 {
                    Spiral_builder::US23::US23_0(v18_0_0, v18_0_1, v18_0_2, v18_0_3, v18_0_4) => {
                        Spiral_builder::US22::US22_0(toArray(Spiral_builder::method88(
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
        pub fn method91(
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
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v17: () = {
                Spiral_builder::closure7(v10.clone(), string("{ "), ());
                ()
            };
            let v26: () = {
                Spiral_builder::closure7(v10.clone(), string("file_name"), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Spiral_builder::closure7(v10.clone(), v0_1, ());
                ()
            };
            let v52: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v61: () = {
                Spiral_builder::closure7(v10.clone(), string("arguments"), ());
                ()
            };
            let v69: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v77: () = {
                Spiral_builder::closure7(v10.clone(), v1_1, ());
                ()
            };
            let v85: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v94: () = {
                Spiral_builder::closure7(v10.clone(), string("options"), ());
                ()
            };
            let v102: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v110: () = {
                Spiral_builder::closure7(v10.clone(), string("{ "), ());
                ()
            };
            let v119: () = {
                Spiral_builder::closure7(v10.clone(), string("command"), ());
                ()
            };
            let v127: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v10.clone(), v2, ());
                ()
            };
            let v143: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v160: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v165: std::string::String = format!("{:#?}", v3);
            let v198: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v165),
                    (),
                );
                ()
            };
            let v206: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v215: () = {
                Spiral_builder::closure7(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v223: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v234: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v242: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v251: () = {
                Spiral_builder::closure7(v10.clone(), string("on_line"), ());
                ()
            };
            let v259: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v264: std::string::String = format!("{:#?}", v5);
            let v297: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v264),
                    (),
                );
                ()
            };
            let v305: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v314: () = {
                Spiral_builder::closure7(v10.clone(), string("stdin"), ());
                ()
            };
            let v322: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v327: std::string::String = format!("{:#?}", v6);
            let v360: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v327),
                    (),
                );
                ()
            };
            let v368: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v377: () = {
                Spiral_builder::closure7(v10.clone(), string("trace"), ());
                ()
            };
            let v385: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v396: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v404: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v413: () = {
                Spiral_builder::closure7(v10.clone(), string("working_directory"), ());
                ()
            };
            let v421: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v426: std::string::String = format!("{:#?}", v8);
            let v459: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v426),
                    (),
                );
                ()
            };
            let v468: () = {
                Spiral_builder::closure7(v10.clone(), string(" }"), ());
                ()
            };
            let v476: () = {
                Spiral_builder::closure7(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method90(
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
            let v17: string = Spiral_builder::method91(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options"),
                v17
            ))
        }
        pub fn closure31(
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
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method90(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Spiral_builder::method8(v27, v28, v29, v30, v31, v32),
                    Spiral_builder::method12(),
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
        pub fn closure32(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method92() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Spiral_builder::closure32((), v))
        }
        pub fn closure33(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Spiral_builder::US24 {
            Spiral_builder::US24::US24_0(v0_1)
        }
        pub fn method93() -> Func1<
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
        pub fn method94() -> Func1<std::string::String, Spiral_builder::US24> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure34((), v))
        }
        pub fn method96(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), string("error"), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    fable_library_rust::String_::fromString(v32),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method95(
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
            let v9: string = Spiral_builder::method96(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / child error"),
                v9
            ))
        }
        pub fn closure35(v0_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method95(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method45(),
                    v0_1,
                ))
            };
        }
        pub fn method97(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure36(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method98(
        ) -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Spiral_builder::closure36((), v))
        }
        pub fn closure37(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method99() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Spiral_builder::closure37((), v)
            })
        }
        pub fn method100() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Spiral_builder::closure37((), v)
            })
        }
        pub fn closure38(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method101() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Spiral_builder::closure38((), v)
                },
            )
        }
        pub fn closure39(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US26 {
            Spiral_builder::US26::US26_0(v0_1)
        }
        pub fn method102() -> Func1<std::string::String, Spiral_builder::US26> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure39((), v))
        }
        pub fn closure40(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US26 {
            Spiral_builder::US26::US26_1(v0_1)
        }
        pub fn method103() -> Func1<std::string::String, Spiral_builder::US26> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure40((), v))
        }
        pub fn method105(v0_1: bool, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("trace\'"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v39: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    if v0_1 {
                        string("true")
                    } else {
                        string("false")
                    },
                    (),
                );
                ()
            };
            let v48: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v57: () = {
                Spiral_builder::closure7(v3.clone(), string("e"), ());
                ()
            };
            let v65: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: std::string::String = format!("{:#?}", v1_1);
            let v103: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v70),
                    (),
                );
                ()
            };
            let v112: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method104(
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
            let v10: string = Spiral_builder::method105(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.stdio_line"),
                v10
            ))
        }
        pub fn closure41(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method104(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method45(),
                    v0_1,
                    v1_1,
                ))
            };
        }
        pub fn method107() -> string {
            let v1_1: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            v1_1.l0.get().clone()
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
            v8: string,
        ) -> string {
            let v9: string = Spiral_builder::method107();
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                v8,
                v9
            ))
        }
        pub fn closure42(v0_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_0) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Spiral_builder::method106(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                        Spiral_builder::method48(),
                        v0_1,
                    )
                })
            };
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method108(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Spiral_builder::closure43((), v)
            })
        }
        pub fn method109(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure44(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Spiral_builder::US27 {
            Spiral_builder::US27::US27_0(v0_1)
        }
        pub fn method110() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Spiral_builder::US27,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Spiral_builder::closure44((), v)
                },
            )
        }
        pub fn method111(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure45(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Spiral_builder::US28 {
            Spiral_builder::US28::US28_0(v0_1)
        }
        pub fn method112(
        ) -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Spiral_builder::US28>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Spiral_builder::closure45((), v)
                },
            )
        }
        pub fn method113(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method114(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure46(unitVar: (), v0_1: std::process::Output) -> Spiral_builder::US29 {
            Spiral_builder::US29::US29_0(v0_1)
        }
        pub fn method115() -> Func1<std::process::Output, Spiral_builder::US29> {
            Func1::new(move |v: std::process::Output| Spiral_builder::closure46((), v))
        }
        pub fn closure47(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US29 {
            Spiral_builder::US29::US29_1(v0_1)
        }
        pub fn method116() -> Func1<std::string::String, Spiral_builder::US29> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure47((), v))
        }
        pub fn method117(
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
            let v9: string = Spiral_builder::method96(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / output error"),
                v9
            ))
        }
        pub fn closure48(v0_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method117(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method45(),
                    v0_1,
                ))
            };
        }
        pub fn closure49(unitVar: (), v0_1: i32) -> Spiral_builder::US30 {
            Spiral_builder::US30::US30_0(v0_1)
        }
        pub fn method118() -> Func1<i32, Spiral_builder::US30> {
            Func1::new(move |v: i32| Spiral_builder::closure49((), v))
        }
        pub fn method120(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("std_trace_length"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
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
            v8: i32,
            v9: i32,
        ) -> string {
            let v10: string = Spiral_builder::method120(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options / result"),
                v10
            ))
        }
        pub fn closure50(v0_1: i32, v1_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_0) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method119(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method48(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method124(
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
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v17: () = {
                Spiral_builder::closure7(v10.clone(), string("{ "), ());
                ()
            };
            let v26: () = {
                Spiral_builder::closure7(v10.clone(), string("file_name"), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v43: () = {
                Spiral_builder::closure7(v10.clone(), v0_1, ());
                ()
            };
            let v52: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v61: () = {
                Spiral_builder::closure7(v10.clone(), string("arguments"), ());
                ()
            };
            let v69: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v80: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{:?}", v1_1), ());
                ()
            };
            let v88: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v97: () = {
                Spiral_builder::closure7(v10.clone(), string("options"), ());
                ()
            };
            let v105: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v113: () = {
                Spiral_builder::closure7(v10.clone(), string("{ "), ());
                ()
            };
            let v122: () = {
                Spiral_builder::closure7(v10.clone(), string("command"), ());
                ()
            };
            let v130: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Spiral_builder::closure7(v10.clone(), v2, ());
                ()
            };
            let v146: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v155: () = {
                Spiral_builder::closure7(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v163: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v168: std::string::String = format!("{:#?}", v3);
            let v201: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v168),
                    (),
                );
                ()
            };
            let v209: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v218: () = {
                Spiral_builder::closure7(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v226: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v237: () = {
                Spiral_builder::closure7(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v245: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v254: () = {
                Spiral_builder::closure7(v10.clone(), string("on_line"), ());
                ()
            };
            let v262: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v267: std::string::String = format!("{:#?}", v5);
            let v300: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v267),
                    (),
                );
                ()
            };
            let v308: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v317: () = {
                Spiral_builder::closure7(v10.clone(), string("stdin"), ());
                ()
            };
            let v325: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v330: std::string::String = format!("{:#?}", v6);
            let v363: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v330),
                    (),
                );
                ()
            };
            let v371: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v380: () = {
                Spiral_builder::closure7(v10.clone(), string("trace"), ());
                ()
            };
            let v388: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v399: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v407: () = {
                Spiral_builder::closure7(v10.clone(), string("; "), ());
                ()
            };
            let v416: () = {
                Spiral_builder::closure7(v10.clone(), string("working_directory"), ());
                ()
            };
            let v424: () = {
                Spiral_builder::closure7(v10.clone(), string(" = "), ());
                ()
            };
            let v429: std::string::String = format!("{:#?}", v8);
            let v462: () = {
                Spiral_builder::closure7(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v429),
                    (),
                );
                ()
            };
            let v471: () = {
                Spiral_builder::closure7(v10.clone(), string(" }"), ());
                ()
            };
            let v479: () = {
                Spiral_builder::closure7(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method123(
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
            let v17: string = Spiral_builder::method124(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v17
            ))
        }
        pub fn closure51(
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
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v32: Option<i64> = patternInput.5.clone();
                let v31: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v30: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v29: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v28: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v27: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method123(
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    Spiral_builder::method8(v27, v28, v29, v30, v31, v32),
                    Spiral_builder::method12(),
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
        pub fn method125(
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
        pub fn method128(v0_1: ()) -> string {
            unbox::<string>(&getZero())
        }
        pub fn closure53(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Spiral_builder::US31 {
            Spiral_builder::US31::US31_0(v0_1)
        }
        pub fn method129() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Spiral_builder::US31>
        {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Spiral_builder::closure53((), v)
            })
        }
        pub fn method130(v0_1: ()) -> i32 {
            unbox::<i32>(&getZero())
        }
        pub fn closure54(v0_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_0) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Spiral_builder::method106(
                        v19.clone(),
                        v20.clone(),
                        v21.clone(),
                        v22.clone(),
                        v23.clone(),
                        v24.clone(),
                        Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                        Spiral_builder::method48(),
                        v0_1,
                    )
                })
            };
        }
        pub fn method127(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: (),
        ) -> Arc<Async<()>> {
            getZero()
        }
        pub fn method126(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: (),
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: (),
        ) -> Arc<Async<()>> {
            Spiral_builder::method127(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
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
            v9: bool,
            v10: (),
        ) {
            let v11: Arc<Async<()>> =
                Spiral_builder::method126(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
            getZero::<()>();
            ();
            ()
        }
        pub fn closure55(unitVar: (), v0_1: CancellationToken) -> Spiral_builder::US32 {
            Spiral_builder::US32::US32_0(v0_1)
        }
        pub fn method131() -> Func1<CancellationToken, Spiral_builder::US32> {
            Func1::new(move |v: CancellationToken| Spiral_builder::closure55((), v))
        }
        pub fn method132(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
            getZero()
        }
        pub fn method133(v0_1: ()) -> bool {
            unbox::<bool>(&getZero())
        }
        pub fn method134(v0_1: ()) {
            ();
            ()
        }
        pub fn closure56(v0_1: (), unitVar: ()) {
            if (Spiral_builder::method133(v0_1)) == false {
                Spiral_builder::method134(v0_1);
            };
        }
        pub fn closure57(v0_1: LrcPtr<Exception>, unitVar: ()) -> LrcPtr<Exception> {
            v0_1
        }
        pub fn method137(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), string("ex"), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v32: std::string::String = format!("{:#?}", v0_1);
            let v65: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    fable_library_rust::String_::fromString(v32),
                    (),
                );
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method136(
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
            let v9: string = Spiral_builder::method137(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async / WaitForExitAsync"),
                v9
            ))
        }
        pub fn closure58(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_3) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method136(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method33(),
                    v0_1,
                ))
            };
        }
        pub fn method135(
            v0_1: (),
            v1_1: LrcPtr<ConcurrentStack_1<string>>,
            v2: CancellationToken,
        ) -> Arc<Async<i32>> {
            getZero()
        }
        pub fn method139(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("output_length"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method138(
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
            let v10: string = Spiral_builder::method139(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("runtime.execute_with_options_async"),
                v10
            ))
        }
        pub fn closure59(v0_1: i32, v1_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method138(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method12(),
                    v0_1,
                    length(v1_1),
                ))
            };
        }
        pub fn method122(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            getZero()
        }
        pub fn method121(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            getZero()
        }
        pub fn method65(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v9: Spiral_builder::US14 = Spiral_builder::method67(Spiral_builder::method66(
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
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v9_1_0.clone()
                    ])),
                ),
            };
            let v21: Spiral_builder::US5 = patternInput.1.clone();
            let v20: string = patternInput.0.clone();
            let v26: Spiral_builder::US22 = Spiral_builder::method80(match &v21 {
                Spiral_builder::US5::US5_0(v21_0_0) => match &v21 {
                    Spiral_builder::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            });
            let v34: Array<string> = match &v26 {
                Spiral_builder::US22::US22_0(v26_0_0) => v26_0_0.clone(),
                Spiral_builder::US22::US22_1(v26_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v26_1_0.clone()
                    ])),
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
                Spiral_builder::closure31(
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
                        let v144: bool = true;
                        std::process::Command::args(&mut v140, &*v92.clone());
                        let v146: std::process::Command = v140;
                        let v148: std::process::Stdio = std::process::Stdio::piped();
                        let v150: bool = true;
                        let mut v146 = v146;
                        let v152: bool = true;
                        std::process::Command::stdout(&mut v146, std::process::Stdio::piped());
                        let v154: std::process::Command = v146;
                        let v156: std::process::Stdio = std::process::Stdio::piped();
                        let v158: bool = true;
                        let mut v154 = v154;
                        let v160: bool = true;
                        std::process::Command::stderr(&mut v154, std::process::Stdio::piped());
                        let v162: std::process::Command = v154;
                        let v164: std::process::Stdio = std::process::Stdio::piped();
                        let v166: bool = true;
                        let mut v162 = v162;
                        let v168: bool = true;
                        std::process::Command::stdin(&mut v162, std::process::Stdio::piped());
                        let v170: std::process::Command = v162;
                        let v184: Spiral_builder::US5 = defaultValue(
                            Spiral_builder::US5::US5_1,
                            map(Spiral_builder::method6(), v6.clone()),
                        );
                        let v198: std::process::Command = match &v184 {
                            Spiral_builder::US5::US5_0(v184_0_0) => {
                                let v190: bool = true;
                                let mut v170 = v170;
                                let v192: bool = true;
                                std::process::Command::current_dir(
                                    &mut v170,
                                    &*match &v184 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v170
                            }
                            _ => v170,
                        };
                        let v220: std::process::Command = if (get_Count(v2.clone()) as u64) == 0_u64
                        {
                            v198
                        } else {
                            let v202: Vec<(string, string)> = v2.clone().to_vec();
                            let v204: bool = true;
                            let _vec_fold_ = v202.into_iter().fold(v198, |acc, x| {
                                //;
                                let v206: std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v211: bool = true;
                                let mut v206 = v206;
                                let v213: bool = true;
                                std::process::Command::env(
                                    &mut v206,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v215: std::process::Command = v206;
                                let v217: bool = true;
                                v215
                            });
                            _vec_fold_
                        };
                        let v222: bool = true;
                        let mut v220 = v220;
                        let v224: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v220);
                        let v225 = Spiral_builder::method42();
                        let v228: Result<std::process::Child, std::string::String> =
                            v224.map_err(|x| v225(x));
                        let v240 = Spiral_builder::method92();
                        let v242: bool = true;
                        let _result_map_ = v228.map(|x| {
                            //;
                            let v248: Option<std::process::Child> = v240(Some(x));
                            let v250: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v248);
                            let v252: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v250);
                            let v254: bool = true;
                            v252
                        });
                        let v256: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v257 = Spiral_builder::method93();
                        let v258 = Spiral_builder::method94();
                        let v260: Spiral_builder::US24 = match v256 {
                            Ok(x) => v257(x),
                            Err(e) => v258(e),
                        };
                        let patternInput_3: (i32, Spiral_builder::US7, Spiral_builder::US25) =
                            match &v260 {
                                Spiral_builder::US24::US24_0(v260_0_0) => {
                                    let v261: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v260_0_0.clone();
                                    let v263: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v265: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v261.clone();
                                        let v267: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v265.lock();
                                        let v282: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = Spiral_builder::method97(v267.unwrap());
                                        let v284: bool = true;
                                        let mut v282 = v282;
                                        let v286: &mut Option<std::process::Child> = &mut v282;
                                        let v288: Option<&mut std::process::Child> = v286.as_mut();
                                        let v290: &mut std::process::Child = v288.unwrap();
                                        let v292: &mut Option<std::process::ChildStdout> =
                                            &mut v290.stdout;
                                        let v294: Option<std::process::ChildStdout> =
                                            Option::take(v292);
                                        let v296: std::process::ChildStdout = v294.unwrap();
                                        let v298: bool = true;
                                        v296
                                    })();
                                    let v300: std::process::ChildStdout = _capture;
                                    let v302: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v304: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v261.clone();
                                        let v306: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v304.lock();
                                        let v321: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = Spiral_builder::method97(v306.unwrap());
                                        let v323: bool = true;
                                        let mut v321 = v321;
                                        let v325: &mut Option<std::process::Child> = &mut v321;
                                        let v327: Option<&mut std::process::Child> = v325.as_mut();
                                        let v329: &mut std::process::Child = v327.unwrap();
                                        let v331: &mut Option<std::process::ChildStderr> =
                                            &mut v329.stderr;
                                        let v333: Option<std::process::ChildStderr> =
                                            Option::take(v331);
                                        let v335: std::process::ChildStderr = v333.unwrap();
                                        let v337: bool = true;
                                        v335
                                    })();
                                    let v339: std::process::ChildStderr = _capture;
                                    let v341: bool = true;
                                    let _capture = (|| {
                                        //;
                                        let v343: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v261.clone();
                                        let v345: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v343.lock();
                                        let v360: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = Spiral_builder::method97(v345.unwrap());
                                        let v362: bool = true;
                                        let mut v360 = v360;
                                        let v364: &mut Option<std::process::Child> = &mut v360;
                                        let v366: Option<&mut std::process::Child> = v364.as_mut();
                                        let v368: &mut std::process::Child = v366.unwrap();
                                        let v370: &mut Option<std::process::ChildStdin> =
                                            &mut v368.stdin;
                                        let v372: Option<std::process::ChildStdin> =
                                            Option::take(v370);
                                        let v374: std::process::ChildStdin = v372.unwrap();
                                        let v379: Option<std::process::ChildStdin> =
                                            (Spiral_builder::method98())(Some(v374));
                                        let v381: std::sync::Mutex<
                                            Option<std::process::ChildStdin>,
                                        > = std::sync::Mutex::new(v379);
                                        let v383: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = std::sync::Arc::new(v381);
                                        let v385: bool = true;
                                        v383
                                    })();
                                    let v387: std::sync::Arc<
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
                                    let v389: std::sync::mpsc::Sender<std::string::String> =
                                        patternInput_2.0.clone();
                                    let v392: std::sync::mpsc::Sender<std::string::String> =
                                        (Spiral_builder::method99())(v389.clone());
                                    let v394: std::sync::Mutex<
                                        std::sync::mpsc::Sender<std::string::String>,
                                    > = std::sync::Mutex::new(v392);
                                    let v396: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        >,
                                    > = std::sync::Arc::new(v394);
                                    let v398: std::sync::mpsc::Sender<std::string::String> =
                                        (Spiral_builder::method100())(v389);
                                    let v400: std::sync::Mutex<
                                        std::sync::mpsc::Sender<std::string::String>,
                                    > = std::sync::Mutex::new(v398);
                                    let v402: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        >,
                                    > = std::sync::Arc::new(v400);
                                    let v404: std::sync::Arc<
                                        std::sync::mpsc::Receiver<std::string::String>,
                                    > = (Spiral_builder::method101())(patternInput_2.1.clone());
                                    let v406: std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = std::sync::Mutex::new(v404);
                                    let v408: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = std::sync::Arc::new(v406);
                                    let v410: bool = true;
                                    let __spawn = std::thread::spawn(move || {
                                        //;
                                        let v412: encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                            .utf8_passthru(true)
                                            .build(v300);
                                        let v414: std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        > = std::io::BufReader::new(v412);
                                        let v416: std::io::Lines<
                                            std::io::BufReader<
                                                encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStdout,
                                                    Vec<u8>,
                                                >,
                                            >,
                                        > = std::io::BufRead::lines(v414);
                                        let v418: bool = true;
                                        let mut v416 = v416;
                                        let _iter_try_for_each = v416.try_for_each(|x| {
                                            //;
                                            let v420: Result<std::string::String, std::io::Error> =
                                                x;
                                            let v422: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v396.clone();
                                            let v423 = Spiral_builder::method42();
                                            let v426: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v420.map_err(|x| v423(x));
                                            let v438 = Spiral_builder::method102();
                                            let v439 = Spiral_builder::method103();
                                            let v441: Spiral_builder::US26 = match v426 {
                                                Ok(x) => v438(x),
                                                Err(e) => v439(e),
                                            };
                                            let v636: std::string::String = match &v441 {
                                                Spiral_builder::US26::US26_0(v441_0_0) => {
                                                    let v444: string =
                                                        fable_library_rust::String_::fromString(
                                                            v441_0_0.clone(),
                                                        );
                                                    let v446: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v448: std::borrow::Cow<[u8]> =
                                                        v446.encode(&*v444).0;
                                                    let v450: &[u8] = v448.as_ref();
                                                    let v452: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v450);
                                                    let v455: &str = v452.unwrap();
                                                    let v486: std::string::String =
                                                        String::from(v455);
                                                    let v493: string = concat(new_array(&[
                                                        string("> "),
                                                        fable_library_rust::String_::fromString(
                                                            v486.clone(),
                                                        ),
                                                    ]));
                                                    if v5 {
                                                        let v496: () = {
                                                            Spiral_builder::closure42(
                                                                v493.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v541: () = {
                                                            Spiral_builder::closure10(v493, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    v486
                                                }
                                                Spiral_builder::US26::US26_1(v441_1_0) => {
                                                    let v543: std::string::String =
                                                        v441_1_0.clone();
                                                    let v546: () = {
                                                        Spiral_builder::closure41(
                                                            v5,
                                                            v543.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v586: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v543
                                                    );
                                                    let v589: &str = &*v586;
                                                    String::from(v589)
                                                }
                                            };
                                            let v638: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v422;
                                            let v640: Result<
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
                                            > = v638.lock();
                                            let v643: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v640.unwrap();
                                            let v656: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v643;
                                            let v658: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v656.send(v636);
                                            let v659 = Spiral_builder::method108();
                                            let v662: Result<(), std::string::String> =
                                                v658.map_err(|x| v659(x));
                                            let v675: _ = v662;
                                            let v677: bool = true;
                                            v675
                                        }); //;
                                        let v680: Result<(), string> = Spiral_builder::method109(
                                            _iter_try_for_each.map_err(|x| x.into()),
                                        );
                                        let v683: string = string("}");
                                        let v687: bool = true;
                                        let v684 = v680;
                                        let v699: string = append(
                                            (append(
                                                (append(
                                                    (append(string("true; v684 "), (v683))),
                                                    string("); "),
                                                )),
                                                string(""),
                                            )),
                                            string(" // rust.fix_closure\'"),
                                        );
                                        let v700: bool = true;
                                        v684
                                    }); // rust.fix_closure';
                                    let v702: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                    let v704: bool = true;
                                    let __spawn = std::thread::spawn(move || {
                                        //;
                                        let v706: encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                            .utf8_passthru(true)
                                            .build(v339);
                                        let v708: std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        > = std::io::BufReader::new(v706);
                                        let v710: std::io::Lines<
                                            std::io::BufReader<
                                                encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStderr,
                                                    Vec<u8>,
                                                >,
                                            >,
                                        > = std::io::BufRead::lines(v708);
                                        let v712: bool = true;
                                        let mut v710 = v710;
                                        let _iter_try_for_each = v710.try_for_each(|x| {
                                            //;
                                            let v714: Result<std::string::String, std::io::Error> =
                                                x;
                                            let v716: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v402.clone();
                                            let v717 = Spiral_builder::method42();
                                            let v720: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v714.map_err(|x| v717(x));
                                            let v732 = Spiral_builder::method102();
                                            let v733 = Spiral_builder::method103();
                                            let v735: Spiral_builder::US26 = match v720 {
                                                Ok(x) => v732(x),
                                                Err(e) => v733(e),
                                            };
                                            let v978: std::string::String = match &v735 {
                                                Spiral_builder::US26::US26_0(v735_0_0) => {
                                                    let v738: string =
                                                        fable_library_rust::String_::fromString(
                                                            v735_0_0.clone(),
                                                        );
                                                    let v740: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v742: std::borrow::Cow<[u8]> =
                                                        v740.encode(&*v738).0;
                                                    let v744: &[u8] = v742.as_ref();
                                                    let v746: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v744);
                                                    let v749: &str = v746.unwrap();
                                                    let v780: std::string::String =
                                                        String::from(v749);
                                                    let v787: string = concat(new_array(&[
                                                        string("! "),
                                                        fable_library_rust::String_::fromString(
                                                            v780.clone(),
                                                        ),
                                                    ]));
                                                    if v5 {
                                                        let v790: () = {
                                                            Spiral_builder::closure42(
                                                                v787.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v834: () = {
                                                            Spiral_builder::closure10(v787, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    {
                                                        let v836: string = sprintf!(
                                                            "\u{001b}[4;7m{}\u{001b}[0m",
                                                            v780
                                                        );
                                                        let v839: &str = &*v836;
                                                        String::from(v839)
                                                    }
                                                }
                                                Spiral_builder::US26::US26_1(v735_1_0) => {
                                                    let v885: std::string::String =
                                                        v735_1_0.clone();
                                                    let v888: () = {
                                                        Spiral_builder::closure41(
                                                            v5,
                                                            v885.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v928: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v885
                                                    );
                                                    let v931: &str = &*v928;
                                                    String::from(v931)
                                                }
                                            };
                                            let v980: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v716;
                                            let v982: Result<
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
                                            > = v980.lock();
                                            let v985: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v982.unwrap();
                                            let v998: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v985;
                                            let v1000: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v998.send(v978);
                                            let v1001 = Spiral_builder::method108();
                                            let v1004: Result<(), std::string::String> =
                                                v1000.map_err(|x| v1001(x));
                                            let v1017: _ = v1004;
                                            let v1019: bool = true;
                                            v1017
                                        }); //;
                                        let v1022: Result<(), string> = Spiral_builder::method109(
                                            _iter_try_for_each.map_err(|x| x.into()),
                                        );
                                        let v1023: string = string("}");
                                        let v1027: bool = true;
                                        let v1024 = v1022;
                                        let v1039: string = append(
                                            (append(
                                                (append(
                                                    (append(string("true; v1024 "), (v1023))),
                                                    string("); "),
                                                )),
                                                string(""),
                                            )),
                                            string(" // rust.fix_closure\'"),
                                        );
                                        let v1040: bool = true;
                                        v1024
                                    }); // rust.fix_closure';
                                    let v1042: std::thread::JoinHandle<Result<(), string>> =
                                        __spawn;
                                    let v1056: Spiral_builder::US27 = defaultValue(
                                        Spiral_builder::US27::US27_1,
                                        map(Spiral_builder::method110(), v4.clone()),
                                    );
                                    match &v1056 {
                                        Spiral_builder::US27::US27_0(v1056_0_0) => {
                                            let v1062: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::ChildStdin>>,
                                            > = v387.clone();
                                            let v1064: Result<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::ChildStdin>,
                                                    >,
                                                >,
                                            > = v1062.lock();
                                            let v1079: std::sync::MutexGuard<
                                                Option<std::process::ChildStdin>,
                                            > = Spiral_builder::method111(v1064.unwrap());
                                            let v1081: bool = true;
                                            let mut v1079 = v1079;
                                            let v1083: &mut Option<std::process::ChildStdin> =
                                                &mut v1079;
                                            let v1085: Option<std::process::ChildStdin> =
                                                Option::take(v1083);
                                            let v1087: bool = true;
                                            let _optionm_map_ = v1085.map(|x| {
                                                //;
                                                let v1089: std::process::ChildStdin = x;
                                                let v1091: std::sync::Mutex<
                                                    std::process::ChildStdin,
                                                > = std::sync::Mutex::new(v1089);
                                                let v1093: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = std::sync::Arc::new(v1091);
                                                let v1095: bool = true;
                                                v1093
                                            });
                                            let v1097: Option<
                                                std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                >,
                                            > = _optionm_map_;
                                            let v1111: Spiral_builder::US28 = defaultValue(
                                                Spiral_builder::US28::US28_1,
                                                map(Spiral_builder::method112(), v1097),
                                            );
                                            match &v1111 {
                                                Spiral_builder::US28::US28_0(v1111_0_0) => {
                                                    let v1115: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = match &v1111 {
                                                        Spiral_builder::US28::US28_0(x) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    }
                                                    .clone();
                                                    (match &v1056 {
                                                        Spiral_builder::US27::US27_0(x) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    })(
                                                        v1115.clone()
                                                    );
                                                    {
                                                        let v1117: std::sync::Arc<
                                                            std::sync::Mutex<
                                                                std::process::ChildStdin,
                                                            >,
                                                        > = v1115;
                                                        let v1119: Result<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                            std::sync::PoisonError<
                                                                std::sync::MutexGuard<
                                                                    std::process::ChildStdin,
                                                                >,
                                                            >,
                                                        > = v1117.lock();
                                                        let v1134: std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        > = Spiral_builder::method113(
                                                            v1119.unwrap(),
                                                        );
                                                        let v1136: bool = true;
                                                        let mut v1134 = v1134;
                                                        let v1138: bool = true;
                                                        std::io::Write::flush(&mut *v1134).unwrap();
                                                        ()
                                                    }
                                                }
                                                _ => (),
                                            }
                                        }
                                        _ => (),
                                    }
                                    {
                                        let v1140: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v261;
                                        let v1142: Result<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                            >,
                                        > = v1140.lock();
                                        let v1157: std::sync::MutexGuard<
                                            Option<std::process::Child>,
                                        > = Spiral_builder::method97(v1142.unwrap());
                                        let v1159: bool = true;
                                        let mut v1157 = v1157;
                                        let v1161: &mut Option<std::process::Child> = &mut v1157;
                                        let v1163: Option<std::process::Child> =
                                            Option::take(v1161);
                                        let v1165: std::process::Child = v1163.unwrap();
                                        let v1167: Result<std::process::Output, std::io::Error> =
                                            v1165.wait_with_output();
                                        let v1168 = Spiral_builder::method42();
                                        let v1180: Result<
                                            std::process::Output,
                                            std::string::String,
                                        > = v1167.map_err(|x| v1168(x));
                                        let v1183: std::thread::JoinHandle<Result<(), string>> =
                                            Spiral_builder::method114(v1042);
                                        let v1186: string = string("v1183");
                                        let v1187: std::thread::JoinHandle<Result<(), string>> =
                                            Spiral_builder::method114(v702);
                                        let v1192: string = append(
                                            (append(
                                                string("vec!["),
                                                (append(string("v1187, "), (v1186))),
                                            )),
                                            string("]"),
                                        );
                                        let v1193: Vec<
                                            std::thread::JoinHandle<Result<(), string>>,
                                        > = vec![v1187, v1183];
                                        let v1195: bool = true;
                                        v1193.into_iter().for_each(|x| {
                                            //;
                                            let v1197: std::thread::JoinHandle<Result<(), string>> =
                                                x;
                                            let v1199: Result<
                                                Result<(), string>,
                                                Box<dyn core::any::Any + 'static + Send>,
                                            > = std::thread::JoinHandle::join(v1197);
                                            let v1202: Result<(), string> = v1199.unwrap();
                                            v1202.unwrap();
                                            ();
                                            {
                                                let v1219: bool = true;
                                                let v1221: bool = true;
                                            }
                                        });
                                        {
                                            //;
                                            let v1222 = Spiral_builder::method115();
                                            let v1223 = Spiral_builder::method116();
                                            let v1224: Spiral_builder::US29 = match &v1180 {
                                                Err(v1180_1_0) => v1223(v1180_1_0.clone()),
                                                Ok(v1180_0_0) => v1222(v1180_0_0.clone()),
                                            };
                                            match &v1224 {
                                                Spiral_builder::US29::US29_0(v1224_0_0) => {
                                                    let v1227: std::process::ExitStatus =
                                                        v1224_0_0.clone().status;
                                                    let v1229: Option<i32> = v1227.code();
                                                    let v1243: Spiral_builder::US30 = defaultValue(
                                                        Spiral_builder::US30::US30_1,
                                                        map(Spiral_builder::method118(), v1229),
                                                    );
                                                    match &v1243 {
                                                        Spiral_builder::US30::US30_0(v1243_0_0) => (
                                                            match &v1243 {
                                                                Spiral_builder::US30::US30_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            Spiral_builder::US7::US7_1,
                                                            Spiral_builder::US25::US25_0(
                                                                v408.clone(),
                                                            ),
                                                        ),
                                                        _ => {
                                                            let v1253:
                                                                                        &str =
                                                                                    &*string("runtime.execute_with_options / exit_code=None");
                                                            (
                                                                -1_i32,
                                                                Spiral_builder::US7::US7_0(
                                                                    String::from(v1253),
                                                                ),
                                                                Spiral_builder::US25::US25_0(
                                                                    v408.clone(),
                                                                ),
                                                            )
                                                        }
                                                    }
                                                }
                                                Spiral_builder::US29::US29_1(v1224_1_0) => {
                                                    let v1307: std::string::String =
                                                        v1224_1_0.clone();
                                                    let v1310: () = {
                                                        Spiral_builder::closure48(
                                                            v1307.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    (
                                                        -2_i32,
                                                        Spiral_builder::US7::US7_0(v1307),
                                                        Spiral_builder::US25::US25_1,
                                                    )
                                                }
                                            }
                                        }
                                    }
                                }
                                Spiral_builder::US24::US24_1(v260_1_0) => {
                                    let v1358: std::string::String = v260_1_0.clone();
                                    let v1361: () = {
                                        Spiral_builder::closure35(v1358.clone(), ());
                                        ()
                                    };
                                    (
                                        -1_i32,
                                        Spiral_builder::US7::US7_0(v1358),
                                        Spiral_builder::US25::US25_1,
                                    )
                                }
                            };
                        let v1408: Spiral_builder::US25 = patternInput_3.2.clone();
                        let v1407: Spiral_builder::US7 = patternInput_3.1.clone();
                        let v1406: i32 = patternInput_3.0.clone();
                        let v1415: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v1408 {
                            Spiral_builder::US25::US25_0(v1408_0_0) => Some(
                                match &v1408 {
                                    Spiral_builder::US25::US25_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
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
                        let v1417: bool = true;
                        let _optionm_map_ = v1415.map(|x| {
                            //;
                            let v1419: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v1421: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v1419;
                            let v1423: Result<
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
                            > = v1421.lock();
                            let v1426: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v1423.unwrap();
                            let v1439 = v1426.iter();
                            let v1441: Vec<std::string::String> = v1439.collect::<Vec<_>>();
                            let v1443: bool = true;
                            let _vec_map: Vec<_> = v1441
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v1445: std::string::String = x;
                                    let v1447: string =
                                        fable_library_rust::String_::fromString(v1445);
                                    let v1449: bool = true;
                                    v1447
                                })
                                .collect::<Vec<_>>();
                            let v1451: Vec<string> = _vec_map;
                            let v1454: LrcPtr<dyn IEnumerable_1<string>> =
                                ofArray_1(fable_library_rust::NativeArray_::array_from(v1451));
                            let v1460: string = join(Spiral_builder::method37(), toArray_1(v1454));
                            let v1465: bool = true;
                            v1460
                        });
                        let v1467: Option<string> = _optionm_map_;
                        let v1474: Spiral_builder::US5 = match &v1407 {
                            Spiral_builder::US7::US7_0(v1407_0_0) => {
                                Spiral_builder::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v1407 {
                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Spiral_builder::US5::US5_1,
                        };
                        let v1479: string = defaultValue(
                            match &v1474 {
                                Spiral_builder::US5::US5_0(v1474_0_0) => match &v1474 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => string(""),
                            },
                            v1467,
                        );
                        let v1484: () = {
                            Spiral_builder::closure50(v1406, v1479.clone(), ());
                            ()
                        };
                        LrcPtr::new((v1406, v1479))
                    }
                }))();
                _v138.set(Some(x_3))
            }
            {
                let v1526: LrcPtr<(i32, string)> = match &_v138.get().clone() {
                    None => panic!("{}", string("base.capture / _v138=None"),),
                    Some(_v138_0_0) => _v138_0_0.clone(),
                };
                let _v7: (i32, string) = (v1526.0.clone(), v1526.1.clone());
                (_v7.0.clone(), _v7.1.clone())
            }
        }
        pub fn method141(v0_1: Spiral_builder::US10, v1_1: i32, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), string("env"), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v41: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v50: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v59: () = {
                Spiral_builder::closure7(v5.clone(), string("exit_code"), ());
                ()
            };
            let v67: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v83: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v92: () = {
                Spiral_builder::closure7(v5.clone(), string("run_result"), ());
                ()
            };
            let v100: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v108: () = {
                Spiral_builder::closure7(v5.clone(), v2, ());
                ()
            };
            let v116: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v125: () = {
                Spiral_builder::closure7(v5.clone(), string("new_code_path"), ());
                ()
            };
            let v133: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v141: () = {
                Spiral_builder::closure7(v5.clone(), v3, ());
                ()
            };
            let v150: () = {
                Spiral_builder::closure7(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method140(
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
            let v12: string = Spiral_builder::method141(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_cuda / env install error"),
                v12
            ))
        }
        pub fn closure60(
            v0_1: Spiral_builder::US10,
            v1_1: string,
            v2: string,
            v3: i32,
            unitVar: (),
        ) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method140(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method45(),
                    v0_1,
                    v3,
                    v2,
                    v1_1,
                ))
            };
        }
        pub fn closure61(unitVar: (), v0_1: string) -> Spiral_builder::US5 {
            Spiral_builder::US5::US5_0(v0_1)
        }
        pub fn closure62(v0_1: string, unitVar: ()) -> string {
            let v5: LrcPtr<dyn IEnumerable_1<string>> =
                ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32));
            join(Spiral_builder::method37(), toArray_1(v5))
        }
        pub fn method143(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), string("ex"), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v35: std::string::String = format!("{:#?}", v0_1);
            let v68: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v35),
                    (),
                );
                ()
            };
            let v77: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v86: () = {
                Spiral_builder::closure7(v5.clone(), string("run_result"), ());
                ()
            };
            let v94: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v102: () = {
                Spiral_builder::closure7(v5.clone(), v1_1, ());
                ()
            };
            let v110: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v119: () = {
                Spiral_builder::closure7(v5.clone(), string("new_code_path"), ());
                ()
            };
            let v127: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v5.clone(), v2, ());
                ()
            };
            let v143: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(v5.clone(), string("external_command"), ());
                ()
            };
            let v160: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v168: () = {
                Spiral_builder::closure7(v5.clone(), v3, ());
                ()
            };
            let v177: () = {
                Spiral_builder::closure7(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method142(
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
            let v12: string = Spiral_builder::method143(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_cuda / Exception"),
                v12
            ))
        }
        pub fn closure64(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method142(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method45(),
                    v3,
                    v1_1,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn closure63(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US5 {
            let v6: () = {
                Spiral_builder::closure64(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US5::US5_1
        }
        pub fn method145(v0_1: i32, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), string("exit_code"), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v47: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v56: () = {
                Spiral_builder::closure7(v5.clone(), string("run_result"), ());
                ()
            };
            let v64: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Spiral_builder::closure7(v5.clone(), v1_1, ());
                ()
            };
            let v80: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v89: () = {
                Spiral_builder::closure7(v5.clone(), string("new_code_path"), ());
                ()
            };
            let v97: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v105: () = {
                Spiral_builder::closure7(v5.clone(), v2, ());
                ()
            };
            let v113: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v122: () = {
                Spiral_builder::closure7(v5.clone(), string("external_command"), ());
                ()
            };
            let v130: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v138: () = {
                Spiral_builder::closure7(v5.clone(), v3, ());
                ()
            };
            let v147: () = {
                Spiral_builder::closure7(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method144(
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
            let v12: string = Spiral_builder::method145(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_cuda / error"),
                v12
            ))
        }
        pub fn closure65(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method144(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method45(),
                    v2,
                    v1_1,
                    v0_1,
                    v3,
                ))
            };
        }
        pub fn closure66(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v4: &str = &*_arg.0.clone();
            let v28: std::string::String = String::from(v4);
            let v52: &str = &*_arg.1.clone();
            LrcPtr::new((v28, String::from(v52)))
        }
        pub fn method146() -> string {
            string("fs-path")
        }
        pub fn method147() -> string {
            string("command")
        }
        pub fn method148() -> string {
            string("path")
        }
        pub fn method157(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v5: std::string::String = format!("{:#?}", v0_1);
            let v38: () = {
                Spiral_builder::closure7(
                    v2.clone(),
                    fable_library_rust::String_::fromString(v5),
                    (),
                );
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure68(unitVar: (), v0_1: std::io::Error) -> string {
            Spiral_builder::method157(v0_1)
        }
        pub fn method156() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Spiral_builder::closure68((), v))
        }
        pub fn closure69(unitVar: (), v0_1: std::path::PathBuf) -> Spiral_builder::US33 {
            Spiral_builder::US33::US33_0(v0_1)
        }
        pub fn method158() -> Func1<std::path::PathBuf, Spiral_builder::US33> {
            Func1::new(move |v: std::path::PathBuf| Spiral_builder::closure69((), v))
        }
        pub fn closure70(unitVar: (), v0_1: string) -> Spiral_builder::US33 {
            Spiral_builder::US33::US33_1(v0_1)
        }
        pub fn method159() -> Func1<string, Spiral_builder::US33> {
            Func1::new(move |v: string| Spiral_builder::closure70((), v))
        }
        pub fn method162(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v8: () = {
                Spiral_builder::closure7(v2.clone(), v0_1, ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method161(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Spiral_builder::method61(v4.clone());
            let v6: Option<string> = Spiral_builder::method31(v4.clone());
            let v20: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method6(), v6),
            );
            let v24: string = Spiral_builder::method162(v3);
            if (v2) >= 11_u8 {
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
                    if (v4.clone()) != string("") {
                        let v72: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v20_0_0.clone());
                        let v73 = Spiral_builder::method156();
                        let v85: Result<std::path::PathBuf, string> = v72.map_err(|x| v73(x));
                        let v88 = Spiral_builder::method158();
                        let v89 = Spiral_builder::method159();
                        let v90: Spiral_builder::US33 = match &v85 {
                            Err(v85_1_0) => v89(v85_1_0.clone()),
                            Ok(v85_0_0) => v88(v85_0_0.clone()),
                        };
                        match &v90 {
                            Spiral_builder::US33::US33_0(v90_0_0) => {
                                let v119: string = Spiral_builder::method28(
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
                                 v0_1, v24.clone(), v4, v5.clone());
                    let v291: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v288);
                    Err(v291)
                }
            }
        }
        pub fn method160(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v6 = Spiral_builder::method156();
            let v18: Result<std::path::PathBuf, string> = v5.map_err(|x| v6(x));
            let v21 = Spiral_builder::method158();
            let v22 = Spiral_builder::method159();
            let v23: Spiral_builder::US33 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v23 {
                Spiral_builder::US33::US33_0(v23_0_0) => Ok(v23_0_0.clone()),
                Spiral_builder::US33::US33_1(v23_1_0) => Spiral_builder::method161(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Spiral_builder::closure71(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v23_1_0.clone(),
                    v2.clone(),
                ),
            }
        }
        pub fn closure72(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Spiral_builder::method160(v0_1, v1_1, v2)
        }
        pub fn closure71(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Spiral_builder::closure72(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method163(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Spiral_builder::method61(v0_1.clone());
            let v5: Option<string> = Spiral_builder::method31(v0_1.clone());
            let v19: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method6(), v5),
            );
            let v23: string = Spiral_builder::method162(v3);
            if (v2) >= 11_u8 {
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
                    if (v0_1.clone()) != string("") {
                        let v71: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v19_0_0.clone());
                        let v72 = Spiral_builder::method156();
                        let v84: Result<std::path::PathBuf, string> = v71.map_err(|x| v72(x));
                        let v87 = Spiral_builder::method158();
                        let v88 = Spiral_builder::method159();
                        let v89: Spiral_builder::US33 = match &v84 {
                            Err(v84_1_0) => v88(v84_1_0.clone()),
                            Ok(v84_0_0) => v87(v84_0_0.clone()),
                        };
                        match &v89 {
                            Spiral_builder::US33::US33_0(v89_0_0) => {
                                let v118: string = Spiral_builder::method28(
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
                                 v0_1.clone(), v23.clone(), v0_1, v4.clone());
                    let v290: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v287);
                    Err(v290)
                }
            }
        }
        pub fn method155(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v5 = Spiral_builder::method156();
            let v17: Result<std::path::PathBuf, string> = v4.map_err(|x| v5(x));
            let v20 = Spiral_builder::method158();
            let v21 = Spiral_builder::method159();
            let v22: Spiral_builder::US33 = match &v17 {
                Err(v17_1_0) => v21(v17_1_0.clone()),
                Ok(v17_0_0) => v20(v17_0_0.clone()),
            };
            match &v22 {
                Spiral_builder::US33::US33_0(v22_0_0) => Ok(v22_0_0.clone()),
                Spiral_builder::US33::US33_1(v22_1_0) => Spiral_builder::method163(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Spiral_builder::closure71(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v22_1_0.clone(),
                ),
            }
        }
        pub fn method165(v0_1: ()) -> i32 {
            unbox::<i32>(&getZero())
        }
        pub fn method166() -> i32 {
            unbox::<i32>(&getZero())
        }
        pub fn method167(v0_1: i32, v1_1: i32) -> bool {
            unbox::<bool>(&getZero())
        }
        pub fn method169(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Spiral_builder::method61(v4.clone());
            let v6: Option<string> = Spiral_builder::method31(v4.clone());
            let v20: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method6(), v6),
            );
            let v24: string = Spiral_builder::method157(v3);
            if (v2) >= 11_u8 {
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
                    if (v4.clone()) != string("") {
                        let v72: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v20_0_0.clone());
                        let v73 = Spiral_builder::method156();
                        let v85: Result<std::path::PathBuf, string> = v72.map_err(|x| v73(x));
                        let v88 = Spiral_builder::method158();
                        let v89 = Spiral_builder::method159();
                        let v90: Spiral_builder::US33 = match &v85 {
                            Err(v85_1_0) => v89(v85_1_0.clone()),
                            Ok(v85_0_0) => v88(v85_0_0.clone()),
                        };
                        match &v90 {
                            Spiral_builder::US33::US33_0(v90_0_0) => {
                                let v119: string = Spiral_builder::method28(
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
                                 v0_1, v24.clone(), v4, v5.clone());
                    let v291: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v288);
                    Err(v291)
                }
            }
        }
        pub fn method168(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v30: i32 = Spiral_builder::method165(getZero());
            let v32: bool = Spiral_builder::method167(Spiral_builder::method166(), v30);
            if v32 {
                let v34: () = getZero();
                let v86: std::path::PathBuf = getZero();
                Ok(v86)
            } else {
                let v103: string =
                    sprintf!("file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {} / result: {} / path\': {} / n: {}",
                             v0_1.clone(), v32, v2.clone(), v1_1);
                Spiral_builder::method169(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Spiral_builder::closure73(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v103),
                    v2,
                )
            }
        }
        pub fn closure74(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Spiral_builder::method168(v0_1, v1_1, v2)
        }
        pub fn closure73(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Spiral_builder::closure74(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method170(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Spiral_builder::method61(v0_1.clone());
            let v5: Option<string> = Spiral_builder::method31(v0_1.clone());
            let v19: Spiral_builder::US5 = defaultValue(
                Spiral_builder::US5::US5_1,
                map(Spiral_builder::method6(), v5),
            );
            let v23: string = Spiral_builder::method157(v3);
            if (v2) >= 11_u8 {
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
                    if (v0_1.clone()) != string("") {
                        let v71: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v19_0_0.clone());
                        let v72 = Spiral_builder::method156();
                        let v84: Result<std::path::PathBuf, string> = v71.map_err(|x| v72(x));
                        let v87 = Spiral_builder::method158();
                        let v88 = Spiral_builder::method159();
                        let v89: Spiral_builder::US33 = match &v84 {
                            Err(v84_1_0) => v88(v84_1_0.clone()),
                            Ok(v84_0_0) => v87(v84_0_0.clone()),
                        };
                        match &v89 {
                            Spiral_builder::US33::US33_0(v89_0_0) => {
                                let v118: string = Spiral_builder::method28(
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
                                 v0_1.clone(), v23.clone(), v0_1, v4.clone());
                    let v290: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v287);
                    Err(v290)
                }
            }
        }
        pub fn method164(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v29: i32 = Spiral_builder::method165(getZero());
            let v31: bool = Spiral_builder::method167(Spiral_builder::method166(), v29);
            if v31 {
                let v33: () = getZero();
                let v85: std::path::PathBuf = getZero();
                Ok(v85)
            } else {
                let v102: string =
                    sprintf!("file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: {} / result: {} / path\': {} / n: {}",
                             v0_1.clone(), v31, v0_1.clone(), v1_1);
                Spiral_builder::method170(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Spiral_builder::closure73(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v102),
                )
            }
        }
        pub fn method154(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Spiral_builder::method30(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Spiral_builder::method155(v0_1, 0_u8)
            }
        }
        pub fn closure75(unitVar: (), v0_1: std::path::PathBuf) -> Spiral_builder::US34 {
            Spiral_builder::US34::US34_0(v0_1)
        }
        pub fn method171() -> Func1<std::path::PathBuf, Spiral_builder::US34> {
            Func1::new(move |v: std::path::PathBuf| Spiral_builder::closure75((), v))
        }
        pub fn method173(v0_1: string) -> string {
            v0_1
        }
        pub fn method172(v0_1: string, v1_1: string, v2: string) -> string {
            let v5: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v8: regex::Regex = v5.unwrap();
            let v20: string = Spiral_builder::method173(v2);
            let v22: std::borrow::Cow<str> = v8.replace_all(&*v20, &*v1_1);
            let v24: std::string::String = String::from(v22);
            fable_library_rust::String_::fromString(v24)
        }
        pub fn method153(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Spiral_builder::method154(v0_1.clone());
                let v6: Option<std::path::PathBuf> = v3.ok();
                let v31: Spiral_builder::US34 = defaultValue(
                    Spiral_builder::US34::US34_1,
                    map(Spiral_builder::method171(), v6),
                );
                let v66: string = match &v31 {
                    Spiral_builder::US34::US34_0(v31_0_0) => {
                        let v60: string = toString(
                            match &v31 {
                                Spiral_builder::US34::US34_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone()
                            .display(),
                        );
                        if (v60.clone()) == string("") {
                            v0_1.clone()
                        } else {
                            v60
                        }
                    }
                    _ => v0_1.clone(),
                };
                if (v66.clone()) == string("") {
                    string("")
                } else {
                    let v71: string =
                        Spiral_builder::method172(string("^\\\\\\\\\\?\\\\"), string(""), v66);
                    replace(
                        concat(new_array(&[
                            toLower(ofChar(getCharAt(v71.clone(), 0_i32))),
                            getSlice(v71, Some(1_i32), None::<i32>),
                        ])),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method174(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut6>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method175() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method176(v0_1: string) -> string {
            v0_1
        }
        pub fn method152(v0_1: string) -> string {
            let v4: &str = &*v0_1.clone();
            let v28: std::string::String = String::from(v4);
            let v52: std::path::PathBuf = std::path::PathBuf::from(v28);
            if (v52.exists()) == false {
                let v77: string = Spiral_builder::method36();
                let v81: Array<string> = split(
                    Spiral_builder::method153(Spiral_builder::method28(v77.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v85: i32 = get_Count(v81.clone());
                let v86: LrcPtr<Spiral_builder::Mut6> = LrcPtr::new(Spiral_builder::Mut6 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Spiral_builder::method174(v85, v86.clone()) {
                    let v88: i32 = v86.l0.get().clone();
                    let v91: i32 = ((v88.wrapping_neg()) + (v85)) - 1_i32;
                    let matchValue: i32 = v86.l1.get().clone();
                    let v93: Array<string> = v86.l2.get().clone();
                    let v92: i32 = matchValue;
                    let v94: string = v81[v91].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == (v94.clone()) {
                        ((v92) + 1_i32, v93.clone())
                    } else {
                        if string(".") == (v94.clone()) {
                            (v92, v93.clone())
                        } else {
                            if 0_i32 == (v92) {
                                if endsWith3(v94.clone(), string(":"), false) {
                                    let v104: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v77.clone(), 0_i32)
                                    )]);
                                    let v105: i32 = get_Count(v104.clone());
                                    let v107: i32 = (v105) + (get_Count(v93.clone()));
                                    let v108: Array<string> = new_init(&string(""), v107);
                                    let v109: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method69(v107, v109.clone()) {
                                        let v111: i32 = v109.l0.get().clone();
                                        let v116: string = if (v111) < (v105) {
                                            v104[v111].clone()
                                        } else {
                                            let v114: i32 = (v111) - (v105);
                                            v93[v114].clone()
                                        };
                                        v108.get_mut()[v111 as usize] = v116;
                                        {
                                            let v117: i32 = (v111) + 1_i32;
                                            v109.l0.set(v117);
                                            ()
                                        }
                                    }
                                    (0_i32, v108.clone())
                                } else {
                                    let v118: Array<string> = new_array(&[v94]);
                                    let v119: i32 = get_Count(v118.clone());
                                    let v121: i32 = (v119) + (get_Count(v93.clone()));
                                    let v122: Array<string> = new_init(&string(""), v121);
                                    let v123: LrcPtr<Spiral_builder::Mut5> =
                                        LrcPtr::new(Spiral_builder::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method69(v121, v123.clone()) {
                                        let v125: i32 = v123.l0.get().clone();
                                        let v130: string = if (v125) < (v119) {
                                            v118[v125].clone()
                                        } else {
                                            let v128: i32 = (v125) - (v119);
                                            v93[v128].clone()
                                        };
                                        v122.get_mut()[v125 as usize] = v130;
                                        {
                                            let v131: i32 = (v125) + 1_i32;
                                            v123.l0.set(v131);
                                            ()
                                        }
                                    }
                                    (0_i32, v122.clone())
                                }
                            } else {
                                ((v92) - 1_i32, v93.clone())
                            }
                        }
                    };
                    let v141: i32 = (v88) + 1_i32;
                    v86.l0.set(v141);
                    v86.l1.set(patternInput_1.0.clone());
                    v86.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v86.l1.get().clone();
                    let v143: Array<string> = v86.l2.get().clone();
                    let _v144: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v143 = v143.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v143 = v143.clone();
                                    move |i: i32| v143[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, (get_Count(v143.clone())) - 1_i32),
                            )
                        }
                    }));
                    let v155: string = ofChar(Spiral_builder::method175());
                    join(
                        if (v155.clone()) == string("\n") {
                            Spiral_builder::method176(v155.clone())
                        } else {
                            v155
                        },
                        toArray_1(_v144),
                    )
                }
            } else {
                let v167: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v170: std::path::PathBuf = v167.unwrap();
                let v184: std::path::Display = v170.display();
                let v208: std::string::String = format!("{}", v184);
                fable_library_rust::String_::fromString(v208)
            }
        }
        pub fn method151(v0_1: string) -> string {
            Spiral_builder::method153(Spiral_builder::method152(v0_1))
        }
        pub fn method150(v0_1: string) -> string {
            Spiral_builder::method151(Spiral_builder::method28(Spiral_builder::method36(), v0_1))
        }
        pub fn closure67(unitVar: (), v0_1: std::string::String) -> string {
            Spiral_builder::method150(fable_library_rust::String_::fromString(v0_1))
        }
        pub fn method149() -> Func1<std::string::String, string> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure67((), v))
        }
        pub fn method177() -> string {
            string("retries")
        }
        pub fn method178() -> string {
            string("working-directory")
        }
        pub fn method181(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v11: () = {
                Spiral_builder::closure7(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Spiral_builder::closure7(v4.clone(), string("exit_code"), ());
                ()
            };
            let v29: () = {
                Spiral_builder::closure7(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v46: () = {
                Spiral_builder::closure7(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Spiral_builder::closure7(v4.clone(), string("repl_result"), ());
                ()
            };
            let v63: () = {
                Spiral_builder::closure7(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Spiral_builder::closure7(v4.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Spiral_builder::closure7(v4.clone(), string("retry"), ());
                ()
            };
            let v96: () = {
                Spiral_builder::closure7(v4.clone(), string(" = "), ());
                ()
            };
            let v104: () = {
                Spiral_builder::closure7(v4.clone(), v2, ());
                ()
            };
            let v113: () = {
                Spiral_builder::closure7(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method180(
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
            let v11: string = Spiral_builder::method181(v8, v9, v10);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / repl error"),
                v11
            ))
        }
        pub fn closure76(v0_1: u8, v1_1: u8, v2: string, v3: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method180(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method12(),
                    v3,
                    v2,
                    sprintf!("{}/{}", v1_1, v0_1),
                ))
            };
        }
        pub fn method179(v0_1: Spiral_builder::US5, v1_1: u8, v2: string, v3: u8) -> (i32, string) {
            let v0_1: MutCell<Spiral_builder::US5> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<u8> = MutCell::new(v1_1);
            let v2: MutCell<string> = MutCell::new(v2.clone());
            let v3: MutCell<u8> = MutCell::new(v3);
            '_method179: loop {
                break '_method179 ({
                    let patternInput: (i32, string) = Spiral_builder::method65(
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
                            Spiral_builder::US5::US5_0(v0_1_0_0) => Some(
                                match &v0_1.get().clone() {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => None::<string>,
                        },
                    );
                    let v24: string = patternInput.1.clone();
                    let v23: i32 = patternInput.0.clone();
                    if if (v23) == 0_i32 {
                        true
                    } else {
                        (v3.get().clone()) >= (v1_1.get().clone())
                    } {
                        (v23, v24.clone())
                    } else {
                        let v30: () = {
                            Spiral_builder::closure76(
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
                            let v3_temp: u8 = (v3.get().clone()) + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method179;
                        }
                    }
                });
            }
        }
        pub fn method183(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("jupyter_result_length"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method182(
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
            let v10: string = Spiral_builder::method183(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / dib / jupyter nbconvert"),
                v10
            ))
        }
        pub fn closure77(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method182(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method12(),
                    v1_1,
                    length(v0_1),
                ))
            };
        }
        pub fn method185(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("pwsh_replace_html_result_length"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method184(
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
            let v10: string = Spiral_builder::method185(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / dib / html cell ids"),
                v10
            ))
        }
        pub fn closure78(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method184(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method12(),
                    v1_1,
                    length(v0_1),
                ))
            };
        }
        pub fn method187(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("result_length"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method186(
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
            let v10: string = Spiral_builder::method187(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / dib"),
                v10
            ))
        }
        pub fn closure79(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method186(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method12(),
                    v1_1,
                    length(v0_1),
                ))
            };
        }
        pub fn method188() -> string {
            string("cleanup")
        }
        pub fn method189() -> string {
            string("wasm")
        }
        pub fn method190() -> string {
            string("contract")
        }
        pub fn method191(v0_1: string, v1_1: string, v2: Spiral_builder::US35) -> string {
            let v4: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v11: () = {
                Spiral_builder::closure7(v4.clone(), string("{ "), ());
                ()
            };
            let v20: () = {
                Spiral_builder::closure7(v4.clone(), string("extension"), ());
                ()
            };
            let v29: () = {
                Spiral_builder::closure7(v4.clone(), string(" = "), ());
                ()
            };
            let v37: () = {
                Spiral_builder::closure7(v4.clone(), v0_1, ());
                ()
            };
            let v46: () = {
                Spiral_builder::closure7(v4.clone(), string("; "), ());
                ()
            };
            let v55: () = {
                Spiral_builder::closure7(v4.clone(), string("code"), ());
                ()
            };
            let v63: () = {
                Spiral_builder::closure7(v4.clone(), string(" = "), ());
                ()
            };
            let v71: () = {
                Spiral_builder::closure7(v4.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v4.clone(), string("; "), ());
                ()
            };
            let v88: () = {
                Spiral_builder::closure7(v4.clone(), string("runtime"), ());
                ()
            };
            let v96: () = {
                Spiral_builder::closure7(v4.clone(), string(" = "), ());
                ()
            };
            let v107: () = {
                Spiral_builder::closure7(v4.clone(), sprintf!("{:?}", v2), ());
                ()
            };
            let v116: () = {
                Spiral_builder::closure7(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method193() -> string {
            string("")
        }
        pub fn method194() -> string {
            string("")
        }
        pub fn method192(v0_1: string) -> string {
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
                    if (v41) == (v19) {
                        let v48: bool = true;
                        break;
                        ()
                    }
                    {
                        let v49: usize = v41;
                        let v64: &_ = if (v49) == (v23.len()) {
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
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v93.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v103: string = Spiral_builder::method193();
                        let v109: string = join(
                            if (v103.clone()) == string("\n") {
                                Spiral_builder::method176(v103.clone())
                            } else {
                                v103
                            },
                            toArray_1(_v94),
                        );
                        Ok::<string, std::io::Error>(v109).unwrap()
                    }
                }
            }
        }
        pub fn method195(
            v0_1: Spiral_builder::US5,
            v1_1: string,
            v2: Spiral_builder::US38,
            v3: string,
        ) -> string {
            let v6: string = Spiral_builder::method28(
                Spiral_builder::method28(v3, string("target/spiral_builder")),
                v1_1,
            );
            if let Spiral_builder::US5::US5_0(v0_1_0_0) = &v0_1 {
                if let Spiral_builder::US38::US38_0(v2_0_0) = &v2 {
                    let v8: Spiral_builder::US37 = v2_0_0.clone();
                    let v10: string = Spiral_builder::method28(v6.clone(), string("packages"));
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
                        Spiral_builder::US5::US5_0(v15_0_0) => Spiral_builder::US5::US5_0(
                            match &v15 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        ),
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
                                Spiral_builder::US5::US5_0(v22_0_0) => Spiral_builder::US5::US5_0(
                                    match &v22 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ),
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
                                            Spiral_builder::US5::US5_0(
                                                match &v29 {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            )
                                        }
                                        _ => Spiral_builder::US5::US5_1,
                                    }
                                }
                            }
                        }
                    };
                    Spiral_builder::method28(
                        Spiral_builder::method28(
                            v10,
                            match &v38 {
                                Spiral_builder::US5::US5_0(v38_0_0) => match &v38 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => panic!("{}", string("Option does not have a value."),),
                            },
                        ),
                        v0_1_0_0.clone(),
                    )
                } else {
                    v6.clone()
                }
            } else {
                v6
            }
        }
        pub fn method197(
            v0_1: string,
            v1_1: LrcPtr<Spiral_builder::UH2>,
            v2: LrcPtr<Spiral_builder::UH2>,
        ) -> LrcPtr<Spiral_builder::UH2> {
            match v1_1.as_ref() {
                Spiral_builder::UH2::UH2_0 => v2.clone(),
                Spiral_builder::UH2::UH2_1(v1_1_1_0, v1_1_1_1) => {
                    let v5: LrcPtr<Spiral_builder::UH2> = Spiral_builder::method197(
                        v0_1.clone(),
                        match v1_1.as_ref() {
                            Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v2.clone(),
                    );
                    LrcPtr::new(Spiral_builder::UH2::UH2_1(
                        concat(new_array(&[
                            string("<Compile Include=\""),
                            Spiral_builder::method28(
                                v0_1.clone(),
                                match v1_1.as_ref() {
                                    Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            string("\" />"),
                        ])),
                        v5,
                    ))
                }
            }
        }
        pub fn method198(
            v0_1: LrcPtr<Spiral_builder::UH2>,
            v1_1: LrcPtr<Spiral_builder::UH2>,
        ) -> LrcPtr<Spiral_builder::UH2> {
            match v0_1.as_ref() {
                Spiral_builder::UH2::UH2_0 => v1_1.clone(),
                Spiral_builder::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                    let v4: LrcPtr<Spiral_builder::UH2> = Spiral_builder::method198(
                        match v0_1.as_ref() {
                            Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    );
                    LrcPtr::new(Spiral_builder::UH2::UH2_1(
                        concat(new_array(&[
                            string("<PackageReference Include=\""),
                            match v0_1.as_ref() {
                                Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            string("\" Version=\"*\" />"),
                        ])),
                        v4,
                    ))
                }
            }
        }
        pub fn method196(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Spiral_builder::UH2>,
            v3: LrcPtr<Spiral_builder::UH2>,
            v4: string,
            v5: string,
        ) -> string {
            let v6: LrcPtr<dyn IDisposable> = Spiral_builder::method41(v4.clone());
            let v9: string = Spiral_builder::method153(Spiral_builder::method28(
                v4.clone(),
                concat(new_array(&[v1_1.clone(), string(".fs")])),
            ));
            Spiral_builder::method38(v9.clone(), v0_1);
            {
                let v13: List<string> = Spiral_builder::method88(
                    Spiral_builder::method197(v5, v2, LrcPtr::new(Spiral_builder::UH2::UH2_0)),
                    empty::<string>(),
                );
                let v26: string = join(
                    string("\\n        "),
                    toArray_1(delay(Func0::new({
                        let v13 = v13.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v13 = v13.clone();
                                    move |i: i32| item(i, v13.clone())
                                }),
                                rangeNumeric(0_i32, 1_i32, (length_1(v13.clone())) - 1_i32),
                            )
                        }
                    }))),
                );
                let v32: List<string> = Spiral_builder::method88(
                    Spiral_builder::method198(v3, LrcPtr::new(Spiral_builder::UH2::UH2_0)),
                    empty::<string>(),
                );
                let v44: string = join(
                    string("\\n        "),
                    toArray_1(delay(Func0::new({
                        let v32 = v32.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v32 = v32.clone();
                                    move |i_1: i32| item(i_1, v32.clone())
                                }),
                                rangeNumeric(0_i32, 1_i32, (length_1(v32.clone())) - 1_i32),
                            )
                        }
                    }))),
                );
                let v49: string = Spiral_builder::method153(Spiral_builder::method28(
                    v4,
                    concat(new_array(&[v1_1, string(".fsproj")])),
                ));
                Spiral_builder::method38(v49.clone(),
                                         append((append((append((append((append((append((append((append((append((append((append((append((append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                (concat(new_array(&[string("    "),
                                                                                                                                                                    v26]))))),
                                                                                                                                        string("\n"))),
                                                                                                                                (concat(new_array(&[string("    <Compile Include=\""),
                                                                                                                                                    v9,
                                                                                                                                                    string("\" />")]))))),
                                                                                                                        string("\n"))),
                                                                                                                string("</ItemGroup>"))),
                                                                                                        string("\n"))),
                                                                                                string("<ItemGroup>"))),
                                                                                        string("\n"))),
                                                                                (concat(new_array(&[string("    "),
                                                                                                    v44]))))),
                                                                        string("\n"))),
                                                                string("</ItemGroup>"))),
                                                        string("\n"))),
                                                string("</Project>")));
                v49
            }
        }
        pub fn closure80(unitVar: (), v0_1: chrono::DateTime<chrono::Utc>) -> Spiral_builder::US39 {
            Spiral_builder::US39::US39_0(v0_1)
        }
        pub fn method200() -> Func1<chrono::DateTime<chrono::Utc>, Spiral_builder::US39> {
            Func1::new(move |v: chrono::DateTime<chrono::Utc>| Spiral_builder::closure80((), v))
        }
        pub fn method201() -> string {
            string("hh:mm")
        }
        pub fn method202() -> string {
            string("yyyyMMdd-HHmm-ssff-ffff-f")
        }
        pub fn method203() -> string {
            string("hhmm")
        }
        pub fn method199(v0_1: Guid, v1_1: DateTime) -> Guid {
            let v7: DateTime = {
                let _arg: DateTime = DateTime::unixEpoch();
                _arg.toUniversalTime()
            };
            let v15: DateTime = {
                let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                _arg_1.toUniversalTime()
            };
            let v91: i64 = ((v15.ticks()) - (v7.ticks())) / 10_i64;
            let v93: Option<chrono::DateTime<chrono::Utc>> =
                chrono::DateTime::from_timestamp_micros(v91);
            let v107: Spiral_builder::US39 = defaultValue(
                Spiral_builder::US39::US39_1,
                map(Spiral_builder::method200(), v93),
            );
            let v127: Spiral_builder::US5 = match &v107 {
                Spiral_builder::US39::US39_0(v107_0_0) => {
                    let v113: chrono::NaiveDateTime = match &v107 {
                        Spiral_builder::US39::US39_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone()
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
                }
                .clone(),
                _ => string(""),
            };
            let v134: LrcPtr<TimeZoneInfo> = std::sync::Arc::new(
                chrono::FixedOffset::local_minus_utc(chrono::Local::now().offset()) as i64,
            );
            let v157: i64 = v15.ticks();
            let v188: string =
                string("chrono::FixedOffset::local_minus_utc(&chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(&chrono::DateTime::from_timestamp_nanos($1))))");
            let v299: TimeSpan = TimeSpan::new_ticks(chrono::FixedOffset::local_minus_utc(
                &chrono::DateTime::timezone(&chrono::DateTime::fixed_offset(
                    &chrono::DateTime::from_timestamp_nanos(v157),
                )),
            ) as i64);
            let v312: u8 = if (v299.hours()) > 0_i32 { 1_u8 } else { 0_u8 };
            let v313: string = Spiral_builder::method201();
            let v332: string = v299.to_string(v313);
            let v337: string = sprintf!(
                "{}{}{}",
                v312,
                getSlice(v332.clone(), Some(0_i32), Some(1_i32)),
                getSlice(v332, Some(3_i32), Some(4_i32))
            );
            let v339: string = toString(v0_1);
            parse(concat(new_array(&[
                v131.clone(),
                v337.clone(),
                getSlice(
                    v339.clone(),
                    Some((length(v131)) + (length(v337))),
                    Some((length(v339)) - 1_i32),
                ),
            ])))
        }
        pub fn method204(v0_1: string, v1_1: string) {
            if (Spiral_builder::method30(v0_1.clone())) == false {
                let v4: LrcPtr<dyn IDisposable> = Spiral_builder::method41(v0_1.clone());
                ()
            }
            {
                let v7: string = defaultValue(string(""), Spiral_builder::method31(v1_1.clone()));
                if (Spiral_builder::method30(v7.clone())) == false {
                    let v12: LrcPtr<dyn IDisposable> = Spiral_builder::method41(v7);
                    ()
                }
                if if Spiral_builder::method30(v1_1.clone()) {
                    let v14: Result<std::path::PathBuf, std::io::Error> =
                        Spiral_builder::method154(v1_1.clone());
                    v14.is_err()
                } else {
                    false
                } {
                    Spiral_builder::method52(true, v1_1.clone());
                }
                if (Spiral_builder::method30(v1_1.clone())) == false {
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
        pub fn method206() -> string {
            string("(")
        }
        pub fn method207() -> string {
            string(" ")
        }
        pub fn method208(v0_1: Spiral_builder::US36) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v11: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method212(v0_1: bool, v1_1: string, v2: i32, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), string("is_error"), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v41: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    if v0_1 {
                        string("true")
                    } else {
                        string("false")
                    },
                    (),
                );
                ()
            };
            let v50: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v59: () = {
                Spiral_builder::closure7(v5.clone(), string("retry"), ());
                ()
            };
            let v67: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
                Spiral_builder::closure7(v5.clone(), v1_1, ());
                ()
            };
            let v83: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v92: () = {
                Spiral_builder::closure7(v5.clone(), string("result"), ());
                ()
            };
            let v100: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v108: () = {
                Spiral_builder::closure7(v5.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v117: () = {
                Spiral_builder::closure7(v5.clone(), string(", "), ());
                ()
            };
            let v125: () = {
                Spiral_builder::closure7(v5.clone(), v3, ());
                ()
            };
            let v134: () = {
                Spiral_builder::closure7(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method211(
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
            let v12: string = Spiral_builder::method212(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("common.retry_fn\' / loop"),
                v12
            ))
        }
        pub fn closure81(v0_1: u8, v1_1: u8, v2: i32, v3: string, v4: bool, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v28: Option<i64> = patternInput.5.clone();
                let v27: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v26: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v25: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v24: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v23: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method211(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_builder::method8(v23, v24, v25, v26, v27, v28),
                    Spiral_builder::method12(),
                    v4,
                    sprintf!("{}/{}", v1_1, v0_1),
                    v2,
                    v3,
                ))
            };
        }
        pub fn method210(
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
            '_method210: loop {
                break '_method210 ({
                    let patternInput: (i32, string) = Spiral_builder::method65(
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
                    let v14: Spiral_builder::US40 = if (v9) == 0_i32 {
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
                    if if (v22) == false {
                        true
                    } else {
                        (v8.get().clone()) >= (v0_1.get().clone())
                    } {
                        (v23, v24.clone())
                    } else {
                        let v30: () = {
                            Spiral_builder::closure81(
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
                            let v8_temp: u8 = (v8.get().clone()) + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            v5.set(v5_temp);
                            v6.set(v6_temp);
                            v7.set(v7_temp);
                            v8.set(v8_temp);
                            continue '_method210;
                        }
                    }
                });
            }
        }
        pub fn method209(
            v0_1: u8,
            v1_1: string,
            v2: Option<CancellationToken>,
            v3: Array<(string, string)>,
            v4: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v5: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v6: bool,
            v7: Option<string>,
        ) -> (i32, string) {
            Spiral_builder::method210(v0_1, v1_1, v2, v3, v4, v5, v6, v7, 1_u8)
        }
        pub fn method205(
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
                concat(new_array(&[
                    string(" --define "),
                    if cfg!(windows) {
                        string("_WINDOWS")
                    } else {
                        string("_LINUX")
                    }
                ])),
                match &v0_1 {
                    Spiral_builder::US35::US35_0(v0_1_0_0) => {
                        let v41: Spiral_builder::US36 = match &v0_1 {
                            Spiral_builder::US35::US35_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v82: Spiral_builder::US5 =
                            if if let Spiral_builder::US36::US36_0(v41_0_0) = &v41 {
                                string("") == (v41_0_0.clone())
                            } else {
                                false
                            } {
                                Spiral_builder::US5::US5_0(string("Wasm"))
                            } else {
                                let v54: string = Spiral_builder::method206();
                                let v68: Array<string> = split(
                                    Spiral_builder::method208(Spiral_builder::US36::US36_0(
                                        string(""),
                                    )),
                                    v54,
                                    -1_i32,
                                    0_i32,
                                );
                                let v71: string = v68[0_i32].clone();
                                if startsWith3(Spiral_builder::method208(v41.clone()), v71, false) {
                                    Spiral_builder::US5::US5_0(string("Wasm"))
                                } else {
                                    Spiral_builder::US5::US5_1
                                }
                            };
                        let v126: Spiral_builder::US5 = match &v82 {
                            Spiral_builder::US5::US5_0(v82_0_0) => Spiral_builder::US5::US5_0(
                                match &v82 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v119: Spiral_builder::US5 =
                                    if if let Spiral_builder::US36::US36_1(v41_1_0) = &v41 {
                                        string("") == (v41_1_0.clone())
                                    } else {
                                        false
                                    } {
                                        Spiral_builder::US5::US5_0(string("Contract"))
                                    } else {
                                        let v91: string = Spiral_builder::method206();
                                        let v105: Array<string> = split(
                                            Spiral_builder::method208(
                                                Spiral_builder::US36::US36_1(string("")),
                                            ),
                                            v91,
                                            -1_i32,
                                            0_i32,
                                        );
                                        let v108: string = v105[0_i32].clone();
                                        if startsWith3(
                                            Spiral_builder::method208(v41.clone()),
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
                                        Spiral_builder::US5::US5_0(
                                            match &v119 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => Spiral_builder::US5::US5_1,
                                }
                            }
                        };
                        concat(new_array(&[
                            string(" --define "),
                            toUpper(match &v126 {
                                Spiral_builder::US5::US5_0(v126_0_0) => match &v126 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                        ]))
                    }
                    _ => string(""),
                }
            );
            let v143: Result<string, string> = match &v4 {
                Spiral_builder::US12::US12_0(v4_0_0) => Ok::<string, string>(v4_0_0.clone()),
                Spiral_builder::US12::US12_1(v4_1_0) => Err::<string, string>(v4_1_0.clone()),
            };
            Spiral_builder::method209(
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
        pub fn method214(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("dotnet_fable_result"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method213(
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
            let v10: string = Spiral_builder::method214(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / dotnet fable error"),
                v10
            ))
        }
        pub fn closure82(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method213(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method45(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn closure83(unitVar: (), v0_1: std::string::String) -> bool {
            contains(
                fable_library_rust::String_::fromString(v0_1),
                string("near-sdk"),
            )
        }
        pub fn method215() -> Func1<std::string::String, bool> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure83((), v))
        }
        pub fn method216(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method217(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method218(v0_1: Vec<std::string::String>) -> Vec<std::string::String> {
            v0_1
        }
        pub fn method219() -> string {
            string("(")
        }
        pub fn method220() -> string {
            string("(")
        }
        pub fn method222(
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
        pub fn closure84(
            unitVar: (),
            v0_1: std::collections::HashMap<string, string>,
        ) -> Spiral_builder::US41 {
            Spiral_builder::US41::US41_0(v0_1)
        }
        pub fn method223() -> Func1<std::collections::HashMap<string, string>, Spiral_builder::US41>
        {
            Func1::new(move |v: std::collections::HashMap<string, string>| {
                Spiral_builder::closure84((), v)
            })
        }
        pub fn method224() -> string {
            string("a")
        }
        pub fn closure85(v0_1: u8, v1_1: i32, v2: string, v3: bool, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method211(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method12(),
                    v3,
                    sprintf!("{}/{}", v0_1, 3_u8),
                    v1_1,
                    v2,
                ))
            };
        }
        pub fn method221(v0_1: Spiral_builder::US12, v1_1: string, v2: u8) -> (i32, string) {
            let v0_1: MutCell<Spiral_builder::US12> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<u8> = MutCell::new(v2);
            '_method221: loop {
                break '_method221 ({
                    let v8: string = concat(new_array(&[
                        string("cargo fmt --manifest-path \""),
                        v1_1.get().clone(),
                        string("\" --"),
                    ]));
                    let v14: Result<string, string> = match &v0_1.get().clone() {
                        Spiral_builder::US12::US12_0(v0_1_0_0) => {
                            Ok::<string, string>(v0_1_0_0.clone())
                        }
                        Spiral_builder::US12::US12_1(v0_1_1_0) => {
                            Err::<string, string>(v0_1_1_0.clone())
                        }
                    };
                    let patternInput: (i32, string) = Spiral_builder::method65(
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
                    let v176: Spiral_builder::US40 = if (contains(
                        v31.clone(),
                        string("failed to load manifest for workspace member"),
                    )) == false
                    {
                        if (v30) == 0_i32 {
                            Spiral_builder::US40::US40_0(v30, v31.clone())
                        } else {
                            Spiral_builder::US40::US40_1(v30, v31.clone())
                        }
                    } else {
                        let v43: Result<regex::Regex, regex::Error> =
                            regex::Regex::new(&string("failed to read `(?<a>.*?Cargo.toml)`"));
                        let v58: Vec<std::collections::HashMap<string, string>> =
                            Spiral_builder::method222(v31.clone(), v43.unwrap());
                        let v61: Option<std::collections::HashMap<string, string>> =
                            tryItem(0_i32, fable_library_rust::NativeArray_::array_from(v58));
                        let v75: Spiral_builder::US41 = defaultValue(
                            Spiral_builder::US41::US41_1,
                            map(Spiral_builder::method223(), v61),
                        );
                        let v103: Spiral_builder::US42 = match &v75 {
                            Spiral_builder::US41::US41_0(v75_0_0) => {
                                let v80: string = Spiral_builder::method224();
                                let v82: Option<string> = std::collections::HashMap::get(
                                    &match &v75 {
                                        Spiral_builder::US41::US41_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    &v80,
                                )
                                .map(|x| x)
                                .cloned();
                                Spiral_builder::US42::US42_0(defaultValue(
                                    Spiral_builder::US5::US5_1,
                                    map(Spiral_builder::method6(), v82),
                                ))
                            }
                            _ => Spiral_builder::US42::US42_1,
                        };
                        let v110: Spiral_builder::US5 =
                            if let Spiral_builder::US42::US42_0(v103_0_0) = &v103 {
                                let v104: Spiral_builder::US5 = v103_0_0.clone();
                                if let Spiral_builder::US5::US5_0(v104_0_0) = &v104 {
                                    Spiral_builder::US5::US5_0(v104_0_0.clone())
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
                                }
                                .clone();
                                if (Spiral_builder::method40(v112.clone())) == false {
                                    let v120: LrcPtr<dyn IDisposable> =
                                        Spiral_builder::method41(defaultValue(
                                            string(""),
                                            Spiral_builder::method31(v112.clone()),
                                        ));
                                    let v122: DateTime = DateTime::now();
                                    let v142: string =
                                        toString(Spiral_builder::method199(new_guid(), v122));
                                    let v167: string =
                                                     append((append((append((append((append((append((append((append((append((append((append((append((append(string("[package]\n"),
                                                                                                                                                            (concat(new_array(&[string("name = \"spiral_builder_"),
                                                                                                                                                                                v142.clone(),
                                                                                                                                                                                string("\"")]))))),
                                                                                                                                                    string("\n"))),
                                                                                                                                            string("version = \"0.0.1\""))),
                                                                                                                                    string("\n"))),
                                                                                                                            string("edition = \"2021\""))),
                                                                                                                    string("\n"))),
                                                                                                            string(""))),
                                                                                                    string("\n"))),
                                                                                            string("[[bin]]"))),
                                                                                    string("\n"))),
                                                                            (concat(new_array(&[string("name = \"spiral_builder_"),
                                                                                                v142,
                                                                                                string("\"")]))))),
                                                                    string("\n"))),
                                                            string("path = \"spiral_builder.rs\""));
                                    std::fs::write(&*v112, &*v167).unwrap();
                                    ();
                                    ()
                                }
                                if (v30) == 0_i32 {
                                    Spiral_builder::US40::US40_0(v30, v31.clone())
                                } else {
                                    Spiral_builder::US40::US40_1(v30, v31.clone())
                                }
                            }
                            _ => Spiral_builder::US40::US40_1(v30, v31.clone()),
                        }
                    };
                    let patternInput_1: (bool, i32, string) = match &v176 {
                        Spiral_builder::US40::US40_0(v176_0_0, v176_0_1) => {
                            (false, v176_0_0.clone(), v176_0_1.clone())
                        }
                        Spiral_builder::US40::US40_1(v176_1_0, v176_1_1) => {
                            (true, v176_1_0.clone(), v176_1_1.clone())
                        }
                    };
                    let v186: string = patternInput_1.2.clone();
                    let v185: i32 = patternInput_1.1.clone();
                    let v184: bool = patternInput_1.0.clone();
                    if if (v184) == false {
                        true
                    } else {
                        (v2.get().clone()) >= 3_u8
                    } {
                        (v185, v186.clone())
                    } else {
                        let v192: () = {
                            Spiral_builder::closure85(v2.get().clone(), v185, v186, v184, ());
                            ()
                        };
                        {
                            let v0_1_temp: Spiral_builder::US12 = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: u8 = (v2.get().clone()) + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method221;
                        }
                    }
                });
            }
        }
        pub fn method226(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("exit_code"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("cargo_fmt_result"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v70: () = {
                Spiral_builder::closure7(v3.clone(), v1_1, ());
                ()
            };
            let v79: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method225(
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
            let v10: string = Spiral_builder::method226(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / cargo fmt error"),
                v10
            ))
        }
        pub fn closure86(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method225(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method45(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method227() -> string {
            string("{")
        }
        pub fn closure87(unitVar: (), v0_1: string) -> string {
            v0_1
        }
        pub fn closure88(v0_1: string, v1_1: string, v2: string) -> string {
            replace(v2, v0_1, v1_1)
        }
        pub fn closure89(v0_1: string, v1_1: string) -> string {
            replace(v1_1, v0_1, string("type DateTime = ();"))
        }
        pub fn method229(v0_1: i32, v1_1: string, v2: string, v3: bool, v4: string) -> string {
            let v6: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v13: () = {
                Spiral_builder::closure7(v6.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Spiral_builder::closure7(v6.clone(), string("exit_code"), ());
                ()
            };
            let v31: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v39: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v48: () = {
                Spiral_builder::closure7(v6.clone(), string("; "), ());
                ()
            };
            let v57: () = {
                Spiral_builder::closure7(v6.clone(), string("new_code_path"), ());
                ()
            };
            let v65: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v73: () = {
                Spiral_builder::closure7(v6.clone(), v1_1, ());
                ()
            };
            let v81: () = {
                Spiral_builder::closure7(v6.clone(), string("; "), ());
                ()
            };
            let v90: () = {
                Spiral_builder::closure7(v6.clone(), string("external_command"), ());
                ()
            };
            let v98: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v106: () = {
                Spiral_builder::closure7(v6.clone(), v2, ());
                ()
            };
            let v114: () = {
                Spiral_builder::closure7(v6.clone(), string("; "), ());
                ()
            };
            let v123: () = {
                Spiral_builder::closure7(v6.clone(), string("cleanup"), ());
                ()
            };
            let v131: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v142: () = {
                Spiral_builder::closure7(
                    v6.clone(),
                    if v3 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v150: () = {
                Spiral_builder::closure7(v6.clone(), string("; "), ());
                ()
            };
            let v159: () = {
                Spiral_builder::closure7(v6.clone(), string("cargo_result"), ());
                ()
            };
            let v167: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v175: () = {
                Spiral_builder::closure7(v6.clone(), v4, ());
                ()
            };
            let v184: () = {
                Spiral_builder::closure7(v6.clone(), string(" }"), ());
                ()
            };
            v6.l0.get().clone()
        }
        pub fn method228(
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
            let v13: string = Spiral_builder::method229(v8, v9, v10, v11, v12);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / error"),
                v13
            ))
        }
        pub fn closure90(v0_1: bool, v1_1: string, v2: string, v3: i32, v4: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v28: Option<i64> = patternInput.5.clone();
                let v27: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v26: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v25: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v24: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v23: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method228(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_builder::method8(v23, v24, v25, v26, v27, v28),
                    Spiral_builder::method45(),
                    v3,
                    v1_1,
                    v4,
                    v0_1,
                    v2,
                ))
            };
        }
        pub fn closure92(unitVar: (), v0_1: string) -> bool {
            if (contains(v0_1.clone(), string("profile [optimized] target"))) == false {
                if (contains(v0_1.clone(), string("profile [unoptimized] target"))) == false {
                    (contains(v0_1, string("profile [unoptimized + debuginfo] target"))) == false
                } else {
                    false
                }
            } else {
                false
            }
        }
        pub fn closure91(v0_1: string, unitVar: ()) -> string {
            let v8: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(skip(
                2_i32,
                skipWhile(
                    Func1::new(move |v: string| Spiral_builder::closure92((), v)),
                    split(v0_1, string("\n"), -1_i32, 0_i32),
                ),
            ));
            join(Spiral_builder::method37(), toArray_1(v8))
        }
        pub fn method231(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), string("ex"), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v35: std::string::String = format!("{:#?}", v0_1);
            let v68: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v35),
                    (),
                );
                ()
            };
            let v77: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v86: () = {
                Spiral_builder::closure7(v5.clone(), string("new_code_path"), ());
                ()
            };
            let v94: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v102: () = {
                Spiral_builder::closure7(v5.clone(), v1_1, ());
                ()
            };
            let v110: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v119: () = {
                Spiral_builder::closure7(v5.clone(), string("external_command"), ());
                ()
            };
            let v127: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v5.clone(), v2, ());
                ()
            };
            let v143: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(v5.clone(), string("cargo_result"), ());
                ()
            };
            let v160: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v168: () = {
                Spiral_builder::closure7(v5.clone(), v3, ());
                ()
            };
            let v177: () = {
                Spiral_builder::closure7(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method230(
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
            let v12: string = Spiral_builder::method231(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / Exception"),
                v12
            ))
        }
        pub fn closure94(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method230(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method45(),
                    v3,
                    v0_1,
                    v2,
                    v1_1,
                ))
            };
        }
        pub fn closure93(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US5 {
            let v6: () = {
                Spiral_builder::closure94(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US5::US5_1
        }
        pub fn method233(v0_1: i32, v1_1: string, v2: string, v3: bool, v4: string) -> string {
            let v6: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v13: () = {
                Spiral_builder::closure7(v6.clone(), string("{ "), ());
                ()
            };
            let v22: () = {
                Spiral_builder::closure7(v6.clone(), string("exit_code"), ());
                ()
            };
            let v31: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v39: () = {
                Spiral_builder::closure7(v6.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v48: () = {
                Spiral_builder::closure7(v6.clone(), string("; "), ());
                ()
            };
            let v57: () = {
                Spiral_builder::closure7(v6.clone(), string("new_code_path"), ());
                ()
            };
            let v65: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v73: () = {
                Spiral_builder::closure7(v6.clone(), v1_1, ());
                ()
            };
            let v81: () = {
                Spiral_builder::closure7(v6.clone(), string("; "), ());
                ()
            };
            let v90: () = {
                Spiral_builder::closure7(v6.clone(), string("cargo_result"), ());
                ()
            };
            let v98: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v106: () = {
                Spiral_builder::closure7(v6.clone(), v2, ());
                ()
            };
            let v114: () = {
                Spiral_builder::closure7(v6.clone(), string("; "), ());
                ()
            };
            let v123: () = {
                Spiral_builder::closure7(v6.clone(), string("cleanup"), ());
                ()
            };
            let v131: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v142: () = {
                Spiral_builder::closure7(
                    v6.clone(),
                    if v3 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v150: () = {
                Spiral_builder::closure7(v6.clone(), string("; "), ());
                ()
            };
            let v159: () = {
                Spiral_builder::closure7(v6.clone(), string("spiral_wasm_result"), ());
                ()
            };
            let v167: () = {
                Spiral_builder::closure7(v6.clone(), string(" = "), ());
                ()
            };
            let v175: () = {
                Spiral_builder::closure7(v6.clone(), v4, ());
                ()
            };
            let v184: () = {
                Spiral_builder::closure7(v6.clone(), string(" }"), ());
                ()
            };
            v6.l0.get().clone()
        }
        pub fn method232(
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
            let v13: string = Spiral_builder::method233(v8, v9, v10, v11, v12);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / wasm error"),
                v13
            ))
        }
        pub fn closure95(v0_1: bool, v1_1: string, v2: string, v3: string, v4: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v28: Option<i64> = patternInput.5.clone();
                let v27: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v26: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v25: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v24: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v23: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method232(
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    Spiral_builder::method8(v23, v24, v25, v26, v27, v28),
                    Spiral_builder::method45(),
                    v4,
                    v1_1,
                    v2,
                    v0_1,
                    concat(new_array(&[string("\n"), v3])),
                ))
            };
        }
        pub fn method235(
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
                Spiral_builder::closure7(v7.clone(), string("{ "), ());
                ()
            };
            let v23: () = {
                Spiral_builder::closure7(v7.clone(), string("exit_code"), ());
                ()
            };
            let v32: () = {
                Spiral_builder::closure7(v7.clone(), string(" = "), ());
                ()
            };
            let v40: () = {
                Spiral_builder::closure7(v7.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v49: () = {
                Spiral_builder::closure7(v7.clone(), string("; "), ());
                ()
            };
            let v58: () = {
                Spiral_builder::closure7(v7.clone(), string("new_code_path"), ());
                ()
            };
            let v66: () = {
                Spiral_builder::closure7(v7.clone(), string(" = "), ());
                ()
            };
            let v74: () = {
                Spiral_builder::closure7(v7.clone(), v1_1, ());
                ()
            };
            let v82: () = {
                Spiral_builder::closure7(v7.clone(), string("; "), ());
                ()
            };
            let v91: () = {
                Spiral_builder::closure7(v7.clone(), string("wasm_path"), ());
                ()
            };
            let v99: () = {
                Spiral_builder::closure7(v7.clone(), string(" = "), ());
                ()
            };
            let v107: () = {
                Spiral_builder::closure7(v7.clone(), v2, ());
                ()
            };
            let v115: () = {
                Spiral_builder::closure7(v7.clone(), string("; "), ());
                ()
            };
            let v124: () = {
                Spiral_builder::closure7(v7.clone(), string("command"), ());
                ()
            };
            let v132: () = {
                Spiral_builder::closure7(v7.clone(), string(" = "), ());
                ()
            };
            let v140: () = {
                Spiral_builder::closure7(v7.clone(), v3, ());
                ()
            };
            let v148: () = {
                Spiral_builder::closure7(v7.clone(), string("; "), ());
                ()
            };
            let v157: () = {
                Spiral_builder::closure7(v7.clone(), string("cleanup"), ());
                ()
            };
            let v165: () = {
                Spiral_builder::closure7(v7.clone(), string(" = "), ());
                ()
            };
            let v176: () = {
                Spiral_builder::closure7(
                    v7.clone(),
                    if v4 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v184: () = {
                Spiral_builder::closure7(v7.clone(), string("; "), ());
                ()
            };
            let v193: () = {
                Spiral_builder::closure7(v7.clone(), string("cargo_result"), ());
                ()
            };
            let v201: () = {
                Spiral_builder::closure7(v7.clone(), string(" = "), ());
                ()
            };
            let v209: () = {
                Spiral_builder::closure7(v7.clone(), v5, ());
                ()
            };
            let v218: () = {
                Spiral_builder::closure7(v7.clone(), string(" }"), ());
                ()
            };
            v7.l0.get().clone()
        }
        pub fn method234(
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
            let v14: string = Spiral_builder::method235(v8, v9, v10, v11, v12, v13);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / cargo error"),
                v14
            ))
        }
        pub fn closure96(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: i32,
            v4: string,
            v5: string,
            unitVar: (),
        ) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v29: Option<i64> = patternInput.5.clone();
                let v28: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v27: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v26: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v25: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v24: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method234(
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    v28.clone(),
                    v29.clone(),
                    Spiral_builder::method8(v24, v25, v26, v27, v28, v29),
                    Spiral_builder::method45(),
                    v3,
                    v1_1,
                    v4,
                    v5,
                    v0_1,
                    concat(new_array(&[string("\n"), v2])),
                ))
            };
        }
        pub fn method237(v0_1: string, v1_1: LrcPtr<Spiral_builder::UH4>) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("new_code_path"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v36: () = {
                Spiral_builder::closure7(v3.clone(), v0_1, ());
                ()
            };
            let v45: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v54: () = {
                Spiral_builder::closure7(v3.clone(), string("cleanup"), ());
                ()
            };
            let v62: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v73: () = {
                Spiral_builder::closure7(v3.clone(), sprintf!("{:?}", v1_1), ());
                ()
            };
            let v82: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method236(
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
            let v25: string = Spiral_builder::method237(
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
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_rust / cleanup"),
                v25
            ))
        }
        pub fn closure97(
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
            if Spiral_builder::method7(Spiral_builder::US0::US0_0) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v34: Option<i64> = patternInput.5.clone();
                let v33: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v32: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v31: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v30: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v29: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method236(
                    v29.clone(),
                    v30.clone(),
                    v31.clone(),
                    v32.clone(),
                    v33.clone(),
                    v34.clone(),
                    Spiral_builder::method8(v29, v30, v31, v32, v33, v34),
                    Spiral_builder::method48(),
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
        pub fn method238(v0_1: LrcPtr<Spiral_builder::UH4>) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH4>> = MutCell::new(v0_1.clone());
            '_method238: loop {
                break '_method238 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH4::UH4_0 => (),
                    Spiral_builder::UH4::UH4_1(v0_1_1_0, v0_1_1_1, v0_1_1_2) => {
                        std::fs::remove_file(
                            &*match v0_1.get().clone().as_ref() {
                                Spiral_builder::UH4::UH4_1(x, _, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        )
                        .unwrap();
                        ();
                        {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH4> =
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH4::UH4_1(_, _, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            v0_1.set(v0_1_temp);
                            continue '_method238;
                        }
                    }
                });
            }
        }
        pub fn method239(v0_1: string) -> string {
            v0_1
        }
        pub fn closure99(unitVar: (), v0_1: std::fs::FileType) -> Spiral_builder::US43 {
            Spiral_builder::US43::US43_0(v0_1)
        }
        pub fn method240() -> Func1<std::fs::FileType, Spiral_builder::US43> {
            Func1::new(move |v: std::fs::FileType| Spiral_builder::closure99((), v))
        }
        pub fn closure100(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US43 {
            Spiral_builder::US43::US43_1(v0_1)
        }
        pub fn method241() -> Func1<std::string::String, Spiral_builder::US43> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure100((), v))
        }
        pub fn method242(v0_1: string) -> string {
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
                map(Spiral_builder::method6(), v115),
            );
            match &v129 {
                Spiral_builder::US5::US5_0(v129_0_0) => match &v129 {
                    Spiral_builder::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method243(v0_1: Spiral_builder::US44) -> Spiral_builder::US44 {
            v0_1
        }
        pub fn method244(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn closure98(
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
                    let v7: async_walkdir::DirEntry = v1_1.clone();
                    let v9: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v7));
                    let v11: Result<std::fs::FileType, std::io::Error> = v9.await;
                    let v12 = Spiral_builder::method42();
                    let v24: Result<std::fs::FileType, std::string::String> =
                        v11.map_err(|x| v12(x));
                    let v27 = Spiral_builder::method240();
                    let v28 = Spiral_builder::method241();
                    let v29: Spiral_builder::US43 = match &v24 {
                        Err(v24_1_0) => v28(v24_1_0.clone()),
                        Ok(v24_0_0) => v27(v24_0_0.clone()),
                    };
                    let v211: Spiral_builder::US44 = Spiral_builder::method243(
                        if let Spiral_builder::US43::US43_0(v29_0_0) = &v29 {
                            if (std::fs::FileType::is_dir(&v29_0_0.clone())) == false {
                                Spiral_builder::US44::US44_0
                            } else {
                                let v36: std::path::PathBuf =
                                    async_walkdir::DirEntry::path(&v1_1.clone());
                                let v39: std::path::Display = v36.display();
                                let v63: std::string::String = format!("{}", v39);
                                let v86: string = fable_library_rust::String_::fromString(v63);
                                if (startsWith3(
                                    Spiral_builder::method242(v86.clone()),
                                    v0_1.clone(),
                                    false,
                                )) == false
                                {
                                    Spiral_builder::US44::US44_1
                                } else {
                                    let v93: Option<string> = Spiral_builder::method31(v86);
                                    let v107: Spiral_builder::US5 = defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        map(Spiral_builder::method6(), v93),
                                    );
                                    if let Spiral_builder::US5::US5_0(v107_0_0) = &v107 {
                                        if (contains(v107_0_0.clone(), v0_1.clone())) == false {
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
                            if (startsWith3(
                                Spiral_builder::method242(v174.clone()),
                                v0_1.clone(),
                                false,
                            )) == false
                            {
                                Spiral_builder::US44::US44_1
                            } else {
                                let v181: Option<string> = Spiral_builder::method31(v174);
                                let v195: Spiral_builder::US5 = defaultValue(
                                    Spiral_builder::US5::US5_1,
                                    map(Spiral_builder::method6(), v181),
                                );
                                if let Spiral_builder::US5::US5_0(v195_0_0) = &v195 {
                                    if (contains(v195_0_0.clone(), v0_1)) == false {
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
                        (append(
                            (append((append(string("true; v215 "), (v214))), string("); "))),
                            string(""),
                        )),
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
                let v247: async_walkdir::Filtering = Spiral_builder::method244(match &v237 {
                    Spiral_builder::US44::US44_0 => async_walkdir::Filtering::Ignore,
                    Spiral_builder::US44::US44_1 => async_walkdir::Filtering::IgnoreDir,
                    _ => async_walkdir::Filtering::Continue,
                });
                let v248: string = string("}");
                let v252: bool = true;
                let v249 = v247;
                let v264: string = append(
                    (append(
                        (append((append(string("true; v249 "), (v248))), string("); "))),
                        string(""),
                    )),
                    string(" // rust.fix_closure\'"),
                );
                let v265: bool = true;
                v249
            }); // rust.fix_closure';
            let v267 = __future_init;
            v267
        }
        pub fn closure102(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method246() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Spiral_builder::closure102((), v))
        }
        pub fn closure103(unitVar: (), v0_1: async_walkdir::DirEntry) -> Spiral_builder::US45 {
            Spiral_builder::US45::US45_0(v0_1)
        }
        pub fn method247() -> Func1<async_walkdir::DirEntry, Spiral_builder::US45> {
            Func1::new(move |v: async_walkdir::DirEntry| Spiral_builder::closure103((), v))
        }
        pub fn closure104(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US45 {
            Spiral_builder::US45::US45_1(v0_1)
        }
        pub fn method248() -> Func1<std::string::String, Spiral_builder::US45> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure104((), v))
        }
        pub fn method249(
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
            let v9: string = Spiral_builder::method96(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript / stream_filter_map"),
                v9
            ))
        }
        pub fn closure105(v0_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method249(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method45(),
                    v0_1,
                ))
            };
        }
        pub fn closure101(
            v0_1: string,
            v1_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<(string, string)> {
            let v2 = Spiral_builder::method246();
            let v14: Result<async_walkdir::DirEntry, std::string::String> = v1_1.map_err(|x| v2(x));
            let v17 = Spiral_builder::method247();
            let v18 = Spiral_builder::method248();
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
                    let v73: string =
                        concat(new_array(&[v0_1.clone(), string("\\.(?<a>[-\\d\\w.]+)$")]));
                    let v75: Result<regex::Regex, regex::Error> = regex::Regex::new(&v73);
                    let v90: Vec<std::collections::HashMap<string, string>> =
                        Spiral_builder::method222(v72.clone(), v75.unwrap());
                    let v93: Option<std::collections::HashMap<string, string>> =
                        tryItem(0_i32, fable_library_rust::NativeArray_::array_from(v90));
                    let v107: Spiral_builder::US41 = defaultValue(
                        Spiral_builder::US41::US41_1,
                        map(Spiral_builder::method223(), v93),
                    );
                    let v135: Spiral_builder::US42 = match &v107 {
                        Spiral_builder::US41::US41_0(v107_0_0) => {
                            let v112: string = Spiral_builder::method224();
                            let v114: Option<string> = std::collections::HashMap::get(
                                &match &v107 {
                                    Spiral_builder::US41::US41_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                &v112,
                            )
                            .map(|x| x)
                            .cloned();
                            Spiral_builder::US42::US42_0(defaultValue(
                                Spiral_builder::US5::US5_1,
                                map(Spiral_builder::method6(), v114),
                            ))
                        }
                        _ => Spiral_builder::US42::US42_1,
                    };
                    let v142: Spiral_builder::US5 =
                        if let Spiral_builder::US42::US42_0(v135_0_0) = &v135 {
                            let v136: Spiral_builder::US5 = v135_0_0.clone();
                            if let Spiral_builder::US5::US5_0(v136_0_0) = &v136 {
                                Spiral_builder::US5::US5_0(v136_0_0.clone())
                            } else {
                                Spiral_builder::US5::US5_1
                            }
                        } else {
                            Spiral_builder::US5::US5_1
                        };
                    match &v142 {
                        Spiral_builder::US5::US5_0(v142_0_0) => Spiral_builder::US46::US46_0(
                            v72.clone(),
                            match &v142 {
                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        ),
                        _ => Spiral_builder::US46::US46_1,
                    }
                }
                Spiral_builder::US45::US45_1(v19_1_0) => {
                    let v151: () = {
                        Spiral_builder::closure105(v19_1_0.clone(), ());
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
                    }
                    .clone(),
                    match &v193 {
                        Spiral_builder::US46::US46_0(_, x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                )),
                _ => None::<(string, string)>,
            }
        }
        pub fn method245(
            v0_1: string,
        ) -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<(string, string)>>
        {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Spiral_builder::closure101(v0_1.clone(), v)
                }
            })
        }
        pub fn closure106(unitVar: (), _arg: (string, string)) -> (string, string) {
            (_arg.0.clone(), _arg.1.clone())
        }
        pub fn closure107(unitVar: (), _arg: (string, string)) -> Spiral_builder::US46 {
            Spiral_builder::US46::US46_0(_arg.0.clone(), _arg.1.clone())
        }
        pub fn method250() -> Func1<(string, string), Spiral_builder::US46> {
            Func1::new(move |arg10_0040: (string, string)| {
                Spiral_builder::closure107((), arg10_0040)
            })
        }
        pub fn method252(v0_1: Spiral_builder::US46) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), string("version"), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v38: () = {
                Spiral_builder::closure7(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v47: () = {
                Spiral_builder::closure7(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
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
            v8: Spiral_builder::US46,
        ) -> string {
            let v9: string = Spiral_builder::method252(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript"),
                v9
            ))
        }
        pub fn closure108(v0_1: Spiral_builder::US46, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method251(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method12(),
                    v0_1,
                ))
            };
        }
        pub fn method253(v0_1: string, v1_1: string, v2: Spiral_builder::US46) {
            match &v2 {
                Spiral_builder::US46::US46_0(v2_0_0, v2_0_1) => {
                    let v4: string =
                        match &v2 {
                            Spiral_builder::US46::US46_0(_, x) => x.clone(),
                            _ => unreachable!(),
                        }.clone();
                    Spiral_builder::method204(Spiral_builder::method28(v1_1.clone(),
                                                                       concat(new_array(&[string("fable-library-"),
                                                                                          string("ts"),
                                                                                          string("."),
                                                                                          v4.clone()]))),
                                              Spiral_builder::method28(v0_1.clone(),
                                                                       concat(new_array(&[string("fable_modules/fable-library-"),
                                                                                          string("ts"),
                                                                                          string("."),
                                                                                          v4]))))
                }
                _ =>
                panic!("{}",
                       concat(new_array(&[string("spiral_builder.process_typescript / fable library not found / lib_path: "),
                   v1_1.clone()])),),
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
            let v10: string = Spiral_builder::method214(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript"),
                v10
            ))
        }
        pub fn closure109(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method254(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method45(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method256(v0_1: string) -> string {
            let v2: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v9: () = {
                Spiral_builder::closure7(v2.clone(), string("{ "), ());
                ()
            };
            let v18: () = {
                Spiral_builder::closure7(v2.clone(), string("new_code_path"), ());
                ()
            };
            let v27: () = {
                Spiral_builder::closure7(v2.clone(), string(" = "), ());
                ()
            };
            let v35: () = {
                Spiral_builder::closure7(v2.clone(), v0_1, ());
                ()
            };
            let v44: () = {
                Spiral_builder::closure7(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
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
            let v9: string = Spiral_builder::method256(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript"),
                v9
            ))
        }
        pub fn closure110(v0_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method255(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method12(),
                    v0_1,
                ))
            };
        }
        pub fn method257(
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
                        }
                        .clone(),
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(_, x, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        Spiral_builder::method257(
                            match v0_1.as_ref() {
                                Spiral_builder::UH5::UH5_1(_, _, x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            v1_1.clone(),
                        ),
                    ))
                }
            }
        }
        pub fn method258(
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
                        }
                        .clone(),
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(_, x, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    Spiral_builder::method258(
                        match v0_1.as_ref() {
                            Spiral_builder::UH5::UH5_1(_, _, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure111(v0_1: string, unitVar: ()) -> string {
            let v5: LrcPtr<dyn IEnumerable_1<string>> =
                ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32));
            join(Spiral_builder::method37(), toArray_1(v5))
        }
        pub fn method260(v0_1: LrcPtr<Exception>, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v12: () = {
                Spiral_builder::closure7(v5.clone(), string("{ "), ());
                ()
            };
            let v21: () = {
                Spiral_builder::closure7(v5.clone(), string("ex"), ());
                ()
            };
            let v30: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v35: std::string::String = format!("{:#?}", v0_1);
            let v68: () = {
                Spiral_builder::closure7(
                    v5.clone(),
                    fable_library_rust::String_::fromString(v35),
                    (),
                );
                ()
            };
            let v77: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v86: () = {
                Spiral_builder::closure7(v5.clone(), string("new_code_path"), ());
                ()
            };
            let v94: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v102: () = {
                Spiral_builder::closure7(v5.clone(), v1_1, ());
                ()
            };
            let v110: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v119: () = {
                Spiral_builder::closure7(v5.clone(), string("external_command"), ());
                ()
            };
            let v127: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v135: () = {
                Spiral_builder::closure7(v5.clone(), v2, ());
                ()
            };
            let v143: () = {
                Spiral_builder::closure7(v5.clone(), string("; "), ());
                ()
            };
            let v152: () = {
                Spiral_builder::closure7(v5.clone(), string("run_result"), ());
                ()
            };
            let v160: () = {
                Spiral_builder::closure7(v5.clone(), string(" = "), ());
                ()
            };
            let v168: () = {
                Spiral_builder::closure7(v5.clone(), v3, ());
                ()
            };
            let v177: () = {
                Spiral_builder::closure7(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method259(
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
            let v12: string = Spiral_builder::method260(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript / Exception"),
                v12
            ))
        }
        pub fn closure113(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method259(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method45(),
                    v3,
                    v0_1,
                    v2,
                    v1_1,
                ))
            };
        }
        pub fn closure112(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US5 {
            let v6: () = {
                Spiral_builder::closure113(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US5::US5_1
        }
        pub fn method261(
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
            let v12: string = Spiral_builder::method145(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_typescript / error"),
                v12
            ))
        }
        pub fn closure114(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method261(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method45(),
                    v2,
                    v1_1,
                    v0_1,
                    v3,
                ))
            };
        }
        pub fn method262(
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
            let v10: string = Spiral_builder::method214(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_python"),
                v10
            ))
        }
        pub fn closure115(v0_1: string, v1_1: i32, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method262(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method45(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn method263(
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
            let v9: string = Spiral_builder::method256(v8);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_python"),
                v9
            ))
        }
        pub fn closure116(v0_1: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v24: Option<i64> = patternInput.5.clone();
                let v23: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v22: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v21: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v20: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v19: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method263(
                    v19.clone(),
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    Spiral_builder::method8(v19, v20, v21, v22, v23, v24),
                    Spiral_builder::method12(),
                    v0_1,
                ))
            };
        }
        pub fn closure117(v0_1: string, unitVar: ()) -> string {
            let v5: LrcPtr<dyn IEnumerable_1<string>> =
                ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32));
            join(Spiral_builder::method37(), toArray_1(v5))
        }
        pub fn method264(
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
            let v12: string = Spiral_builder::method260(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_python / Exception"),
                v12
            ))
        }
        pub fn closure119(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method264(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method45(),
                    v3,
                    v0_1,
                    v2,
                    v1_1,
                ))
            };
        }
        pub fn closure118(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US5 {
            let v6: () = {
                Spiral_builder::closure119(v0_1, v1_1, v2, v3, ());
                ()
            };
            Spiral_builder::US5::US5_1
        }
        pub fn method265(
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
            let v12: string = Spiral_builder::method145(v8, v9, v10, v11);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.process_python / error"),
                v12
            ))
        }
        pub fn closure120(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_4) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v27: Option<i64> = patternInput.5.clone();
                let v26: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v25: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v24: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v23: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v22: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method265(
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    v26.clone(),
                    v27.clone(),
                    Spiral_builder::method8(v22, v23, v24, v25, v26, v27),
                    Spiral_builder::method45(),
                    v2,
                    v1_1,
                    v0_1,
                    v3,
                ))
            };
        }
        pub fn method267(v0_1: std::string::String, v1_1: clap::ArgMatches) -> string {
            let v3: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                l0: MutCell::new(Spiral_builder::method14()),
            });
            let v10: () = {
                Spiral_builder::closure7(v3.clone(), string("{ "), ());
                ()
            };
            let v19: () = {
                Spiral_builder::closure7(v3.clone(), string("subcommand"), ());
                ()
            };
            let v28: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v33: std::string::String = format!("{:#?}", v0_1);
            let v66: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v33),
                    (),
                );
                ()
            };
            let v75: () = {
                Spiral_builder::closure7(v3.clone(), string("; "), ());
                ()
            };
            let v84: () = {
                Spiral_builder::closure7(v3.clone(), string("arg_matches"), ());
                ()
            };
            let v92: () = {
                Spiral_builder::closure7(v3.clone(), string(" = "), ());
                ()
            };
            let v97: std::string::String = format!("{:#?}", v1_1);
            let v130: () = {
                Spiral_builder::closure7(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v97),
                    (),
                );
                ()
            };
            let v139: () = {
                Spiral_builder::closure7(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method266(
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
            let v10: string = Spiral_builder::method267(v8, v9);
            Spiral_builder::method18(sprintf!(
                "{} {} #{} {} / {}",
                v6,
                v7,
                v0_1.l0.get().clone(),
                string("spiral_builder.run / invalid subcommand"),
                v10
            ))
        }
        pub fn closure121(v0_1: clap::ArgMatches, v1_1: std::string::String, unitVar: ()) {
            if Spiral_builder::method7(Spiral_builder::US0::US0_1) {
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
                ) = Spiral_builder::TraceState::trace_state()
                    .get()
                    .clone()
                    .unwrap();
                let v25: Option<i64> = patternInput.5.clone();
                let v24: LrcPtr<Spiral_builder::Mut4> = patternInput.4.clone();
                let v23: LrcPtr<Spiral_builder::Mut3> = patternInput.3.clone();
                let v22: LrcPtr<Spiral_builder::Mut2> = patternInput.2.clone();
                let v21: LrcPtr<Spiral_builder::Mut1> = patternInput.1.clone();
                let v20: LrcPtr<Spiral_builder::Mut0> = patternInput.0.clone();
                Spiral_builder::method19(Spiral_builder::method266(
                    v20.clone(),
                    v21.clone(),
                    v22.clone(),
                    v23.clone(),
                    v24.clone(),
                    v25.clone(),
                    Spiral_builder::method8(v20, v21, v22, v23, v24, v25),
                    Spiral_builder::method12(),
                    v1_1,
                    v0_1,
                ))
            };
        }
        pub fn closure122(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v4: &str = &*_arg.0.clone();
            let v28: std::string::String = String::from(v4);
            let v52: &str = &*_arg.1.clone();
            LrcPtr::new((v28, String::from(v52)))
        }
        pub fn closure123(unitVar: (), v0_1: serde_json::Error) -> string {
            let v3: std::string::String = format!("{}", v0_1);
            fable_library_rust::String_::fromString(v3)
        }
        pub fn method268() -> Func1<serde_json::Error, string> {
            Func1::new(move |v: serde_json::Error| Spiral_builder::closure123((), v))
        }
        pub fn method269(v0_1: Result<string, string>) -> Result<string, string> {
            v0_1
        }
        pub fn method20(
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
                    map(Spiral_builder::method21(), v6),
                );
                let v4795: Array<(string, string)> = if let Spiral_builder::US6::US6_0(
                    v21_0_0,
                    v21_0_1,
                ) = &v21
                {
                    let v26: clap::ArgMatches = v21_0_1.clone();
                    let v25: std::string::String = v21_0_0.clone();
                    if (fable_library_rust::String_::fromString(v25.clone())) == string("cuda") {
                        let v30: string = Spiral_builder::method22();
                        let v33: &str = &*v30;
                        let v56: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v26.clone(), v33).cloned();
                        let v70: Spiral_builder::US7 = defaultValue(
                            Spiral_builder::US7::US7_1,
                            map(Spiral_builder::method23(), v56),
                        );
                        let v77: std::string::String = match &v70 {
                            Spiral_builder::US7::US7_0(v70_0_0) => match &v70 {
                                Spiral_builder::US7::US7_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v79: string = fable_library_rust::String_::fromString(v77);
                        let v80: string = Spiral_builder::method24();
                        let v83: &str = &*v80;
                        let v106: Option<std::string::String> =
                            clap::ArgMatches::get_one(&v26.clone(), v83).cloned();
                        let v120: Spiral_builder::US7 = defaultValue(
                            Spiral_builder::US7::US7_1,
                            map(Spiral_builder::method23(), v106),
                        );
                        let v149: Spiral_builder::US8 = match &v120 {
                            Spiral_builder::US7::US7_0(v120_0_0) => {
                                let v126: string = fable_library_rust::String_::fromString(
                                    match &v120 {
                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                let v131: Spiral_builder::US9 = if string("Pip") == (v126.clone()) {
                                    Spiral_builder::US9::US9_0(Spiral_builder::US10::US10_0)
                                } else {
                                    Spiral_builder::US9::US9_1
                                };
                                Spiral_builder::US8::US8_0(match &v131 {
                                    Spiral_builder::US9::US9_0(v131_0_0) => {
                                        Spiral_builder::US9::US9_0(
                                            match &v131 {
                                                Spiral_builder::US9::US9_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                        )
                                    }
                                    _ => {
                                        let v138: Spiral_builder::US9 = if string("Poetry")
                                            == (v126.clone())
                                        {
                                            Spiral_builder::US9::US9_0(Spiral_builder::US10::US10_1)
                                        } else {
                                            Spiral_builder::US9::US9_1
                                        };
                                        match &v138 {
                                            Spiral_builder::US9::US9_0(v138_0_0) => {
                                                Spiral_builder::US9::US9_0(
                                                    match &v138 {
                                                        Spiral_builder::US9::US9_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
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
                                let v150: Spiral_builder::US9 = v149_0_0.clone();
                                if let Spiral_builder::US9::US9_0(v150_0_0) = &v150 {
                                    Spiral_builder::US9::US9_0(v150_0_0.clone())
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
                            }
                            .clone(),
                            _ => Spiral_builder::US10::US10_0,
                        };
                        let v161: string = Spiral_builder::method25();
                        let v164: &str = &*v161;
                        let v187: Option<Vec<std::string::String>> =
                            clap::ArgMatches::get_many(&v26.clone(), v164)
                                .map(|x| x.cloned().into_iter().collect());
                        let v201: Spiral_builder::US11 = defaultValue(
                            Spiral_builder::US11::US11_1,
                            map(Spiral_builder::method26(), v187),
                        );
                        let v207: Vec<std::string::String> =
                            new_empty::<std::string::String>().to_vec();
                        let v210: Vec<std::string::String> = match &v201 {
                            Spiral_builder::US11::US11_0(v201_0_0) => match &v201 {
                                Spiral_builder::US11::US11_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v207.clone(),
                        };
                        let v214: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v79.clone());
                        let v252: Vec<u8> = Spiral_builder::method27(v214.unwrap());
                        let v254: Result<std::string::String, std::string::FromUtf8Error> =
                            std::string::String::from_utf8(v252);
                        let v257: std::string::String = v254.unwrap();
                        let v270: string = fable_library_rust::String_::fromString(v257);
                        let v296: Spiral_builder::US12 = Spiral_builder::method29(
                            Spiral_builder::method28(string("polyglot"), string(".devcontainer")),
                            string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder"),
                        );
                        let v344: Spiral_builder::US5 = match &v296 {
                            Spiral_builder::US12::US12_0(v296_0_0) => {
                                Spiral_builder::US5::US5_0(v296_0_0.clone())
                            }
                            Spiral_builder::US12::US12_1(v296_1_0) => {
                                let v302: () = {
                                    Spiral_builder::closure15(v296_1_0.clone(), ());
                                    ()
                                };
                                Spiral_builder::US5::US5_1
                            }
                        };
                        let v399: Spiral_builder::US5 = match &v344 {
                            Spiral_builder::US5::US5_0(v344_0_0) => Spiral_builder::US5::US5_0(
                                match &v344 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v347: string = Spiral_builder::method36();
                                let v349: Spiral_builder::US12 = Spiral_builder::method29(
                                    Spiral_builder::method28(
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
                                            Spiral_builder::closure15(v349_1_0.clone(), ());
                                            ()
                                        };
                                        Spiral_builder::US5::US5_1
                                    }
                                }
                            }
                        };
                        let v404: string = Spiral_builder::method28(
                            match &v399 {
                                Spiral_builder::US5::US5_0(v399_0_0) => match &v399 {
                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => panic!("{}", string("Option does not have a value."),),
                            },
                            string("polyglot"),
                        );
                        let v407: string = toLower(Spiral_builder::method36());
                        let v411: string = toLower(v404);
                        let v419: Spiral_builder::US12 = if startsWith3(v407, v411.clone(), false) {
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
                            defaultValue(string(""), Spiral_builder::method31(v79.clone()));
                        let v444: string = match &v160 {
                            Spiral_builder::US10::US10_1 => {
                                Spiral_builder::method28(v436.clone(), string("pyproject.toml"))
                            }
                            _ => Spiral_builder::method28(v436.clone(), string("requirements.txt")),
                        };
                        let v446: bool = true;
                        let _vec_map: Vec<_> = v210
                            .into_iter()
                            .map(|x| {
                                //;
                                let v448: std::string::String = x;
                                let v450: string = fable_library_rust::String_::fromString(v448);
                                let v465: string = if contains(v450.clone(), string("=")) {
                                    v450.clone()
                                } else {
                                    if endsWith3(v450.clone(), string("]"), false) {
                                        concat(new_array(&[
                                            replace(
                                                v450.clone(),
                                                string("["),
                                                string("={version=\'*\',features=["),
                                            ),
                                            string("}"),
                                        ]))
                                    } else {
                                        concat(new_array(&[v450, string("=\'*\'")]))
                                    }
                                };
                                let v467: bool = true;
                                v465
                            })
                            .collect::<Vec<_>>();
                        let v469: Vec<string> = _vec_map;
                        let v471: Array<string> =
                            fable_library_rust::NativeArray_::array_from(v469);
                        let _v472: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v471 = v471.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v471 = v471.clone();
                                        move |i: i32| v471[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v471.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v484: string = join(Spiral_builder::method37(), toArray_1(_v472));
                        let patternInput: (i32, string) = if (v484.clone()) == string("") {
                            (0_i32, string(""))
                        } else {
                            Spiral_builder::method38(v444,
                                                         match &v160 {
                                                             Spiral_builder::US10::US10_1
                                                             =>
                                                             append((append((append((append((append((append((append((append((append(string("[tool.poetry]\nname = \"test\"\nversion = \"0.0.1\"\ndescription = \"\"\nauthors = []\n\n[tool.poetry.dependencies]\npython=\"~3.12\"\n"),
                                                                                                                                    (v484.clone()))),
                                                                                                                            string("\n"))),
                                                                                                                    string(""))),
                                                                                                            string("\n"))),
                                                                                                    string("[build-system]"))),
                                                                                            string("\n"))),
                                                                                    string("requires = [\"poetry-core\"]"))),
                                                                            string("\n"))),
                                                                    string("build-backend = \"poetry.core.masonry.api\"")),
                                                             _ =>
                                                             v484.clone(),
                                                         });
                            Spiral_builder::method65(
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
                        let v544: i32 = patternInput.0.clone();
                        let patternInput_4: (
                            Spiral_builder::US5,
                            Spiral_builder::US5,
                            Spiral_builder::US5,
                            Spiral_builder::US5,
                        ) = if (v544) != 0_i32 {
                            let v551: () = {
                                Spiral_builder::closure60(
                                    v160.clone(),
                                    v79.clone(),
                                    patternInput.1.clone(),
                                    v544,
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
                            let v599: string = match &v160 {
                                Spiral_builder::US10::US10_1 => concat(new_array(&[
                                    string("poetry run python \""),
                                    v79.clone(),
                                    string("\""),
                                ])),
                                _ => concat(new_array(&[
                                    string("python \""),
                                    v79.clone(),
                                    string("\""),
                                ])),
                            };
                            let v602: Array<(string, string)> =
                                new_array(&[(string("TRACE_LEVEL"), string("Verbose"))]);
                            let patternInput_1: (i32, string) = Spiral_builder::method65(
                                v599.clone(),
                                None::<CancellationToken>,
                                v602.clone(),
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
                            let v613: string = patternInput_1.1.clone();
                            let v612: i32 = patternInput_1.0.clone();
                            let v614: i32 = get_Count(v602.clone());
                            let v615: Array<string> = new_init(&string(""), v614);
                            let v616: LrcPtr<Spiral_builder::Mut5> =
                                LrcPtr::new(Spiral_builder::Mut5 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method69(v614, v616.clone()) {
                                let v618: i32 = v616.l0.get().clone();
                                let patternInput_2: (string, string) = v602[v618].clone();
                                let v621: string = sprintf!(
                                    "$env:{}=\'\'{}\'\'",
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone()
                                );
                                v615.get_mut()[v618 as usize] = v621;
                                {
                                    let v622: i32 = (v618) + 1_i32;
                                    v616.l0.set(v622);
                                    ()
                                }
                            }
                            {
                                let v632: string = sprintf!(
                                    "pwsh -c \'{}; {}\'",
                                    join(string(";"), toArray_1(ofArray_1(v615.clone()))),
                                    v599
                                );
                                let patternInput_3: (
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                ) = if if (v612) == 0_i32 {
                                    true
                                } else {
                                    contains(v613.clone(),
                                                        string("cupy_backends.cuda.api.runtime.CUDARuntimeError: cudaErrorInsufficientDriver"))
                                } {
                                    let result: LrcPtr<MutCell<Spiral_builder::US5>> =
                                        refCell(Spiral_builder::US5::US5_1);
                                    try_catch(
                                        || {
                                            result.set(Spiral_builder::closure61(
                                                (),
                                                Spiral_builder::closure62(v613.clone(), ()),
                                            ))
                                        },
                                        |ex: LrcPtr<Exception>| {
                                            result.set(Spiral_builder::closure63(
                                                v79.clone(),
                                                v613.clone(),
                                                v632.clone(),
                                                ex.clone(),
                                            ))
                                        },
                                    );
                                    {
                                        let v643: Spiral_builder::US5 = result.get().clone();
                                        let v653: Option<string> = match &v643 {
                                            Spiral_builder::US5::US5_0(v643_0_0) => Some(
                                                match &v643 {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            ),
                                            _ => None::<string>,
                                        };
                                        (
                                            Spiral_builder::US5::US5_0(string("py")),
                                            Spiral_builder::US5::US5_0(v270),
                                            Spiral_builder::US5::US5_0(v79.clone()),
                                            Spiral_builder::US5::US5_0(v653.unwrap()),
                                        )
                                    }
                                } else {
                                    let v663: () = {
                                        Spiral_builder::closure65(
                                            v79.clone(),
                                            v613,
                                            v612,
                                            v632,
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
                        let v715: Spiral_builder::US5 = patternInput_4.3.clone();
                        let v713: Spiral_builder::US5 = patternInput_4.1.clone();
                        let v712: Spiral_builder::US5 = patternInput_4.0.clone();
                        let v728: Array<(string, string)> = new_array(&[
                            (
                                string("extension"),
                                match &v712 {
                                    Spiral_builder::US5::US5_0(v712_0_0) => match &v712 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => string(""),
                                },
                            ),
                            (
                                string("code"),
                                match &v713 {
                                    Spiral_builder::US5::US5_0(v713_0_0) => match &v713 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => string(""),
                                },
                            ),
                            (
                                string("output"),
                                match &v715 {
                                    Spiral_builder::US5::US5_0(v715_0_0) => match &v715 {
                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    _ => string(""),
                                },
                            ),
                        ]);
                        let v730: Vec<(string, string)> = v728.to_vec();
                        let v733: Vec<LrcPtr<(std::string::String, std::string::String)>> = v730
                            .into_iter()
                            .map(|x| {
                                Func1::new(move |arg10_0040_5: (string, string)| {
                                    Spiral_builder::closure66((), arg10_0040_5)
                                })(x.clone())
                            })
                            .collect::<Vec<_>>();
                        let v734: string =
                            string("std::collections::BTreeMap::from_iter(v733.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                        let v735: std::collections::BTreeMap<
                            std::string::String,
                            std::string::String,
                        > = std::collections::BTreeMap::from_iter(
                            v733.iter()
                                .map(|x| x.as_ref())
                                .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                        );
                        let v737: Result<std::string::String, serde_json::Error> =
                            serde_json::to_string(&v735);
                        let v740: std::string::String = v737.unwrap();
                        new_array(&[(
                            string("command_result"),
                            fable_library_rust::String_::fromString(v740),
                        )])
                    } else {
                        if (fable_library_rust::String_::fromString(v25.clone())) == string("fable")
                        {
                            let v759: string = Spiral_builder::method146();
                            let v762: &str = &*v759;
                            let v785: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v26.clone(), v762).cloned();
                            let v799: Spiral_builder::US7 = defaultValue(
                                Spiral_builder::US7::US7_1,
                                map(Spiral_builder::method23(), v785),
                            );
                            let v806: std::string::String = match &v799 {
                                Spiral_builder::US7::US7_0(v799_0_0) => match &v799 {
                                    Spiral_builder::US7::US7_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => panic!("{}", string("Option does not have a value."),),
                            };
                            let v808: string = fable_library_rust::String_::fromString(v806);
                            let v809: string = Spiral_builder::method147();
                            let v812: &str = &*v809;
                            let v835: Option<std::string::String> =
                                clap::ArgMatches::get_one(&v26.clone(), v812).cloned();
                            let v849: Spiral_builder::US7 = defaultValue(
                                Spiral_builder::US7::US7_1,
                                map(Spiral_builder::method23(), v835),
                            );
                            let v859: Spiral_builder::US5 = match &v849 {
                                Spiral_builder::US7::US7_0(v849_0_0) => Spiral_builder::US5::US5_0(
                                    fable_library_rust::String_::fromString(
                                        match &v849 {
                                            Spiral_builder::US7::US7_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                ),
                                _ => Spiral_builder::US5::US5_1,
                            };
                            new_array(&[(
                                string("command_result"),
                                match &v859 {
                                    Spiral_builder::US5::US5_0(v859_0_0) => {
                                        let v861: clap::Command = Spiral_builder::method0();
                                        let v863: Spiral_builder::US22 =
                                            Spiral_builder::method80(sprintf!(
                                                "_ {} --fs-path \"{}\"",
                                                match &v859 {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                                v808.clone()
                                            ));
                                        let v871: Array<string> = match &v863 {
                                            Spiral_builder::US22::US22_0(v863_0_0) => {
                                                v863_0_0.clone()
                                            }
                                            Spiral_builder::US22::US22_1(v863_1_0) => panic!(
                                                "{}",
                                                concat(new_array(&[
                                                    string(
                                                        "resultm.get / Result value was Error: "
                                                    ),
                                                    v863_1_0.clone()
                                                ])),
                                            ),
                                        };
                                        let v873: Vec<string> = v871.to_vec();
                                        let v875: bool = true;
                                        let _vec_map: Vec<_> = v873
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v877: string = x;
                                                let v880: &str = &*v877;
                                                let v904: std::string::String = String::from(v880);
                                                let v927: bool = true;
                                                v904
                                            })
                                            .collect::<Vec<_>>();
                                        let v929: Vec<std::string::String> = _vec_map;
                                        let v932: std::pin::Pin<
                                            Box<
                                                dyn std::future::Future<
                                                    Output = Result<string, string>,
                                                >,
                                            >,
                                        > = Spiral_builder::method20(
                                            v0_1.clone(),
                                            clap::Command::get_matches_from(v861, v929),
                                        );
                                        let v934: Result<string, string> = v932.await;
                                        v934.unwrap()
                                    }
                                    _ => string("{}"),
                                },
                            )])
                        } else {
                            if (fable_library_rust::String_::fromString(v25.clone()))
                                == string("dib")
                            {
                                let v957: string = Spiral_builder::method148();
                                let v960: &str = &*v957;
                                let v983: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v26.clone(), v960).cloned();
                                let v985: Option<string> = map(Spiral_builder::method149(), v983);
                                let v999: string = v985.unwrap();
                                let v1000: string = Spiral_builder::method177();
                                let v1003: &str = &*v1000;
                                let v1027: u8 = defaultValue(
                                    1_u8,
                                    clap::ArgMatches::get_one(&v26.clone(), v1003).cloned(),
                                );
                                let v1030: string = Spiral_builder::method178();
                                let v1033: &str = &*v1030;
                                let v1056: Option<string> =
                                    clap::ArgMatches::get_one(&v26.clone(), v1033).cloned();
                                let patternInput_5: (i32, string) = Spiral_builder::method179(
                                    defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        map(Spiral_builder::method6(), v1056),
                                    ),
                                    v1027,
                                    v999.clone(),
                                    1_u8,
                                );
                                let v1076: string = patternInput_5.1.clone();
                                let v1075: i32 = patternInput_5.0.clone();
                                let patternInput_8: (i32, string) = if (v1075) != 0_i32 {
                                    (v1075, v1076.clone())
                                } else {
                                    let patternInput_6: (i32, string) = Spiral_builder::method65(
                                        concat(new_array(&[
                                            string("jupyter nbconvert \""),
                                            v999.clone(),
                                            string(".ipynb\" --to html --HTMLExporter.theme=dark"),
                                        ])),
                                        None::<CancellationToken>,
                                        new_empty::<(string, string)>(),
                                        None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                                        None::<
                                            Func1<
                                                std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                >,
                                                (),
                                            >,
                                        >,
                                        true,
                                        None::<string>,
                                    );
                                    let v1088: string = patternInput_6.1.clone();
                                    let v1087: i32 = patternInput_6.0.clone();
                                    let v1091: () = {
                                        Spiral_builder::closure77(v1088.clone(), v1087, ());
                                        ()
                                    };
                                    if (v1087) != 0_i32 {
                                        (
                                            v1087,
                                            concat(new_array(&[
                                                string("repl_result: "),
                                                v1076.clone(),
                                                string("\n\njupyter_result: "),
                                                v1088.clone(),
                                            ])),
                                        )
                                    } else {
                                        let patternInput_7:
                                                    (i32, string) =
                                                Spiral_builder::method65(concat(new_array(&[string("pwsh -c \"$counter = 1; $path = \'"),
                                                                                            replace(v999.clone(),
                                                                                                    string("\'"),
                                                                                                    string("\'\'")),
                                                                                            string(".html\'; (Get-Content $path -Raw) -replace \'(id=\\\"cell-id=)[a-fA-F0-9]{8}\', { $_.Groups[1].Value + $counter++ } | Set-Content $path\"")])),
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
                                        let v1147: string = patternInput_7.1.clone();
                                        let v1146: i32 = patternInput_7.0.clone();
                                        let v1150: () = {
                                            Spiral_builder::closure78(v1147.clone(), v1146, ());
                                            ()
                                        };
                                        let v1191: string =
                                            concat(new_array(&[v999.clone(), string(".html")]));
                                        let v1195: Result<Vec<u8>, std::io::Error> =
                                            std::fs::read(&*v1191);
                                        let v1233: Vec<u8> =
                                            Spiral_builder::method27(v1195.unwrap());
                                        let v1235: Result<
                                            std::string::String,
                                            std::string::FromUtf8Error,
                                        > = std::string::String::from_utf8(v1233);
                                        let v1238: std::string::String = v1235.unwrap();
                                        let v1275: string = replace(
                                            fable_library_rust::String_::fromString(v1238),
                                            string("\r\n"),
                                            string("\n"),
                                        );
                                        let v1276: string =
                                            concat(new_array(&[v999.clone(), string(".html")]));
                                        std::fs::write(&*v1276, &*v1275).unwrap();
                                        ();
                                        {
                                            let v1279: string = concat(new_array(&[
                                                v999.clone(),
                                                string(".ipynb"),
                                            ]));
                                            let v1283: Result<Vec<u8>, std::io::Error> =
                                                std::fs::read(&*v1279);
                                            let v1321: Vec<u8> =
                                                Spiral_builder::method27(v1283.unwrap());
                                            let v1323: Result<
                                                std::string::String,
                                                std::string::FromUtf8Error,
                                            > = std::string::String::from_utf8(v1321);
                                            let v1326: std::string::String = v1323.unwrap();
                                            let v1364: string = replace(
                                                replace(
                                                    fable_library_rust::String_::fromString(v1326),
                                                    string("\r\n"),
                                                    string("\n"),
                                                ),
                                                string("\\r\\n"),
                                                string("\\n"),
                                            );
                                            let v1365: string =
                                                concat(new_array(&[v999, string(".ipynb")]));
                                            std::fs::write(&*v1365, &*v1364).unwrap();
                                            ();
                                            (v1146,
                                                 sprintf!("repl_result: {}\n\njupyter_result: {}\n\npwsh_replace_html_result: {}",
                                                          v1076, v1088,
                                                          v1147))
                                        }
                                    }
                                };
                                let v1372: string = patternInput_8.1.clone();
                                let v1371: i32 = patternInput_8.0.clone();
                                let v1375: () = {
                                    Spiral_builder::closure79(v1372.clone(), v1371, ());
                                    ()
                                };
                                if (v1371) != 0_i32 {
                                    panic!(
                                        "{}",
                                        sprintf!(
                                            "spiral_builder.run / dib / exit_code: {} / result: {}",
                                            v1371,
                                            v1372.clone()
                                        )
                                    );
                                }
                                new_array(&[(string("stdio"), v1372)])
                            } else {
                                let patternInput_31: (
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                    Spiral_builder::US5,
                                ) = if (fable_library_rust::String_::fromString(v25.clone()))
                                    == string("rust")
                                {
                                    let v1425: string = Spiral_builder::method146();
                                    let v1428: &str = &*v1425;
                                    let v1451: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1428).cloned();
                                    let v1465: Spiral_builder::US7 = defaultValue(
                                        Spiral_builder::US7::US7_1,
                                        map(Spiral_builder::method23(), v1451),
                                    );
                                    let v1472: std::string::String = match &v1465 {
                                        Spiral_builder::US7::US7_0(v1465_0_0) => match &v1465 {
                                            Spiral_builder::US7::US7_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                    let v1474: string =
                                        fable_library_rust::String_::fromString(v1472);
                                    let v1475: string = Spiral_builder::method25();
                                    let v1478: &str = &*v1475;
                                    let v1501: Option<Vec<std::string::String>> =
                                        clap::ArgMatches::get_many(&v26.clone(), v1478)
                                            .map(|x| x.cloned().into_iter().collect());
                                    let v1515: Spiral_builder::US11 = defaultValue(
                                        Spiral_builder::US11::US11_1,
                                        map(Spiral_builder::method26(), v1501),
                                    );
                                    let v1521: Vec<std::string::String> =
                                        new_empty::<std::string::String>().to_vec();
                                    let v1524: Vec<std::string::String> = match &v1515 {
                                        Spiral_builder::US11::US11_0(v1515_0_0) => match &v1515 {
                                            Spiral_builder::US11::US11_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => v1521.clone(),
                                    };
                                    let v1525: string = Spiral_builder::method188();
                                    let v1528: &str = &*v1525;
                                    let v1551: bool =
                                        clap::ArgMatches::get_flag(&v26.clone(), v1528);
                                    let v1552: string = Spiral_builder::method189();
                                    let v1555: &str = &*v1552;
                                    let v1578: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1555).cloned();
                                    let v1592: Spiral_builder::US7 = defaultValue(
                                        Spiral_builder::US7::US7_1,
                                        map(Spiral_builder::method23(), v1578),
                                    );
                                    let v1602: Spiral_builder::US5 = match &v1592 {
                                        Spiral_builder::US7::US7_0(v1592_0_0) => {
                                            Spiral_builder::US5::US5_0(
                                                fable_library_rust::String_::fromString(
                                                    match &v1592 {
                                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                ),
                                            )
                                        }
                                        _ => Spiral_builder::US5::US5_1,
                                    };
                                    let v1603: string = Spiral_builder::method190();
                                    let v1606: &str = &*v1603;
                                    let v1629: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v26.clone(), v1606).cloned();
                                    let v1643: Spiral_builder::US7 = defaultValue(
                                        Spiral_builder::US7::US7_1,
                                        map(Spiral_builder::method23(), v1629),
                                    );
                                    let v1653: Spiral_builder::US5 = match &v1643 {
                                        Spiral_builder::US7::US7_0(v1643_0_0) => {
                                            Spiral_builder::US5::US5_0(
                                                fable_library_rust::String_::fromString(
                                                    match &v1643 {
                                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                ),
                                            )
                                        }
                                        _ => Spiral_builder::US5::US5_1,
                                    };
                                    let v1662: Spiral_builder::US35 =
                                        if let Spiral_builder::US5::US5_0(v1602_0_0) = &v1602 {
                                            Spiral_builder::US35::US35_0(
                                                Spiral_builder::US36::US36_0(v1602_0_0.clone()),
                                            )
                                        } else {
                                            if let Spiral_builder::US5::US5_0(v1653_0_0) = &v1653 {
                                                Spiral_builder::US35::US35_0(
                                                    Spiral_builder::US36::US36_1(v1653_0_0.clone()),
                                                )
                                            } else {
                                                Spiral_builder::US35::US35_1
                                            }
                                        };
                                    let v1666: Result<Vec<u8>, std::io::Error> =
                                        std::fs::read(&*v1474);
                                    let v1704: Vec<u8> = Spiral_builder::method27(v1666.unwrap());
                                    let v1706: Result<
                                        std::string::String,
                                        std::string::FromUtf8Error,
                                    > = std::string::String::from_utf8(v1704);
                                    let v1709: std::string::String = v1706.unwrap();
                                    let v1739: string =
                                        fable_library_rust::String_::fromString(v1709);
                                    let v1746: string =
                                        Spiral_builder::method192(Spiral_builder::method191(
                                            string("rs"),
                                            v1739.clone(),
                                            v1662.clone(),
                                        ));
                                    let v1751: Spiral_builder::US12 =
                                            Spiral_builder::method29(Spiral_builder::method28(string("polyglot"),
                                                                                              string(".devcontainer")),
                                                                     string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder"));
                                    let v1799: Spiral_builder::US5 = match &v1751 {
                                        Spiral_builder::US12::US12_0(v1751_0_0) => {
                                            Spiral_builder::US5::US5_0(v1751_0_0.clone())
                                        }
                                        Spiral_builder::US12::US12_1(v1751_1_0) => {
                                            let v1757: () = {
                                                Spiral_builder::closure15(v1751_1_0.clone(), ());
                                                ()
                                            };
                                            Spiral_builder::US5::US5_1
                                        }
                                    };
                                    let v1854: Spiral_builder::US5 = match &v1799 {
                                        Spiral_builder::US5::US5_0(v1799_0_0) => {
                                            Spiral_builder::US5::US5_0(
                                                match &v1799 {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            )
                                        }
                                        _ => {
                                            let v1802: string = Spiral_builder::method36();
                                            let v1804: Spiral_builder::US12 =
                                                Spiral_builder::method29(
                                                    Spiral_builder::method28(
                                                        string("polyglot"),
                                                        string(".devcontainer"),
                                                    ),
                                                    v1802,
                                                );
                                            match &v1804 {
                                                Spiral_builder::US12::US12_0(v1804_0_0) => {
                                                    Spiral_builder::US5::US5_0(v1804_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v1804_1_0) => {
                                                    let v1810: () = {
                                                        Spiral_builder::closure15(
                                                            v1804_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    Spiral_builder::US5::US5_1
                                                }
                                            }
                                        }
                                    };
                                    let v1859: string = Spiral_builder::method28(
                                        match &v1854 {
                                            Spiral_builder::US5::US5_0(v1854_0_0) => match &v1854 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        },
                                        string("polyglot"),
                                    );
                                    let v1862: string = toLower(Spiral_builder::method36());
                                    let v1866: string = toLower(v1859);
                                    let v1874: Spiral_builder::US12 =
                                        if startsWith3(v1862, v1866.clone(), false) {
                                            Spiral_builder::US12::US12_1(v1866.clone())
                                        } else {
                                            Spiral_builder::US12::US12_0(v1866)
                                        };
                                    let v1880: Result<string, string> = match &v1874 {
                                        Spiral_builder::US12::US12_0(v1874_0_0) => {
                                            Ok::<string, string>(v1874_0_0.clone())
                                        }
                                        Spiral_builder::US12::US12_1(v1874_1_0) => {
                                            Err::<string, string>(v1874_1_0.clone())
                                        }
                                    };
                                    let v1882: bool = true;
                                    let _result_unwrap_or_else = v1880.unwrap_or_else(|x| {
                                        //;
                                        let v1884: string = x;
                                        let v1886: bool = true;
                                        v1884
                                    });
                                    let v1888: string = _result_unwrap_or_else;
                                    let v1893: string = Spiral_builder::method195(
                                        Spiral_builder::US5::US5_0(v1746.clone()),
                                        string("spiral_builder"),
                                        Spiral_builder::US38::US38_0(Spiral_builder::US37::US37_0),
                                        v1888.clone(),
                                    );
                                    let v1898: string = Spiral_builder::method196(
                                        v1739,
                                        string("spiral_builder"),
                                        LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                            string("Fable.Core"),
                                            LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                        )),
                                        v1893.clone(),
                                        v1888.clone(),
                                    );
                                    let v1900: string =
                                        Spiral_builder::method28(v1893.clone(), string("../../.."));
                                    let v1902: string = Spiral_builder::method28(
                                        v1900.clone(),
                                        string("Cargo.toml"),
                                    );
                                    if (Spiral_builder::method40(v1902.clone())) == false {
                                        let v1906: DateTime = DateTime::now();
                                        let v1926: string =
                                            toString(Spiral_builder::method199(new_guid(), v1906));
                                        let v1951: string =
                                                append((append((append((append((append((append((append((append((append((append((append((append((append(string("[package]\n"),
                                                                                                                                                       (concat(new_array(&[string("name = \"spiral_builder_"),
                                                                                                                                                                           v1926.clone(),
                                                                                                                                                                           string("\"")]))))),
                                                                                                                                               string("\n"))),
                                                                                                                                       string("version = \"0.0.1\""))),
                                                                                                                               string("\n"))),
                                                                                                                       string("edition = \"2021\""))),
                                                                                                               string("\n"))),
                                                                                                       string(""))),
                                                                                               string("\n"))),
                                                                                       string("[[bin]]"))),
                                                                               string("\n"))),
                                                                       (concat(new_array(&[string("name = \"spiral_builder_"),
                                                                                           v1926,
                                                                                           string("\"")]))))),
                                                               string("\n"))),
                                                       string("path = \"spiral_builder.rs\""));
                                        std::fs::write(&*v1902.clone(), &*v1951).unwrap();
                                        ();
                                        ()
                                    }
                                    {
                                        let v1954: string = Spiral_builder::method28(
                                            v1893.clone(),
                                            string("Cargo.toml"),
                                        );
                                        if (Spiral_builder::method40(v1954.clone())) == false {
                                            let v1958: DateTime = DateTime::now();
                                            let v1978: string = toString(
                                                Spiral_builder::method199(new_guid(), v1958),
                                            );
                                            let v2003: string =
                                                    append((append((append((append((append((append((append((append((append((append((append((append((append(string("[package]\n"),
                                                                                                                                                           (concat(new_array(&[string("name = \"spiral_builder_"),
                                                                                                                                                                               v1978.clone(),
                                                                                                                                                                               string("\"")]))))),
                                                                                                                                                   string("\n"))),
                                                                                                                                           string("version = \"0.0.1\""))),
                                                                                                                                   string("\n"))),
                                                                                                                           string("edition = \"2021\""))),
                                                                                                                   string("\n"))),
                                                                                                           string(""))),
                                                                                                   string("\n"))),
                                                                                           string("[[bin]]"))),
                                                                                   string("\n"))),
                                                                           (concat(new_array(&[string("name = \"spiral_builder_"),
                                                                                               v1978,
                                                                                               string("\"")]))))),
                                                                   string("\n"))),
                                                           string("path = \"spiral_builder.rs\""));
                                            std::fs::write(&*v1954.clone(), &*v2003).unwrap();
                                            ();
                                            ()
                                        }
                                        {
                                            let v2007: string =
                                                    Spiral_builder::method28(v1888.clone(),
                                                                             string("lib/rust/fable/fable_modules/fable-library-rust"));
                                            let v2009: string = Spiral_builder::method28(
                                                v1893.clone(),
                                                string("fable_modules/fable-library-rust"),
                                            );
                                            Spiral_builder::method204(v2007, v2009.clone());
                                            {
                                                let patternInput_9: (i32, string) =
                                                    Spiral_builder::method205(
                                                        v1662.clone(),
                                                        v1893.clone(),
                                                        string("rs"),
                                                        v1898,
                                                        v1874.clone(),
                                                    );
                                                let v2011: string = patternInput_9.1.clone();
                                                let v2010: i32 = patternInput_9.0.clone();
                                                let patternInput_18: (
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                ) = if (v2010) != 0_i32 {
                                                    let v2017: () = {
                                                        Spiral_builder::closure82(
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
                                                            &v1662
                                                        {
                                                            true
                                                        } else {
                                                            false
                                                        } {
                                                            v1524.clone()
                                                        } else {
                                                            let v2062 = Spiral_builder::method215();
                                                            let v2063: Vec<std::string::String> =
                                                                Spiral_builder::method216(
                                                                    v1524.clone(),
                                                                );
                                                            let v2065: Vec<std::string::String> =
                                                                v2063
                                                                    .into_iter()
                                                                    .filter(|x| {
                                                                        v2062(x.clone().clone())
                                                                    })
                                                                    .collect::<Vec<_>>();
                                                            if (v2065.len() as i32) > 0_i32 {
                                                                v1524.clone()
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
                                                                > = Spiral_builder::method217(
                                                                    v2125.to_vec(),
                                                                );
                                                                let v2129: Vec<
                                                                    std::string::String,
                                                                > = Spiral_builder::method218(
                                                                    v1524,
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
                                                            let v2158:
                                                                    string =
                                                                if contains(v2143.clone(),
                                                                            string("="))
                                                                   {
                                                                    v2143.clone()
                                                                } else {
                                                                    if endsWith3(v2143.clone(),
                                                                                 string("]"),
                                                                                 false)
                                                                       {
                                                                        concat(new_array(&[replace(v2143.clone(),
                                                                                                   string("["),
                                                                                                   string("={version=\'*\',features=[")),
                                                                                           string("}")]))
                                                                    } else {
                                                                        concat(new_array(&[v2143,
                                                                                           string("=\'*\'")]))
                                                                    }
                                                                };
                                                            let v2160: bool =
                                                                true; v2158 }).collect::<Vec<_>>();
                                                    let v2162: Vec<string> = _vec_map;
                                                    let v2164:
                                                                    Array<string> =
                                                                fable_library_rust::NativeArray_::array_from(v2162);
                                                    let _v2165: LrcPtr<dyn IEnumerable_1<string>> =
                                                        delay(Func0::new({
                                                            let v2164 = v2164.clone();
                                                            move || {
                                                                map_1(
                                                                    Func1::new({
                                                                        let v2164 = v2164.clone();
                                                                        move |i_1: i32| {
                                                                            v2164[i_1].clone()
                                                                        }
                                                                    }),
                                                                    rangeNumeric(
                                                                        0_i32,
                                                                        1_i32,
                                                                        (get_Count(v2164.clone()))
                                                                            - 1_i32,
                                                                    ),
                                                                )
                                                            }
                                                        }));
                                                    let v2177: string = join(
                                                        Spiral_builder::method37(),
                                                        toArray_1(_v2165),
                                                    );
                                                    let v2182: string = Spiral_builder::method28(
                                                        v1893,
                                                        concat(new_array(&[
                                                            string("spiral_builder"),
                                                            string("."),
                                                            string("rs"),
                                                        ])),
                                                    );
                                                    let v2186: Result<Vec<u8>, std::io::Error> =
                                                        std::fs::read(&*v2182.clone());
                                                    let v2224: Vec<u8> =
                                                        Spiral_builder::method27(v2186.unwrap());
                                                    let v2226: Result<
                                                        std::string::String,
                                                        std::string::FromUtf8Error,
                                                    > = std::string::String::from_utf8(v2224);
                                                    let v2229: std::string::String = v2226.unwrap();
                                                    let v2259: string =
                                                        fable_library_rust::String_::fromString(
                                                            v2229,
                                                        );
                                                    let v2266: string = append(
                                                        string("on_startup!"),
                                                        (Spiral_builder::method219()),
                                                    );
                                                    let v2269: string = append(
                                                        string(" method0"),
                                                        (Spiral_builder::method220()),
                                                    );
                                                    let v2277: bool =
                                                        if contains(v2259.clone(), v2266.clone()) {
                                                            (contains(v2259, v2269)) == false
                                                        } else {
                                                            false
                                                        };
                                                    let v2340:
                                                                    string =
                                                                append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append(string("[package]\n"),
                                                                                                                                                                                                                                       (concat(new_array(&[string("name = \"spiral_builder_"),
                                                                                                                                                                                                                                                           v1746.clone(),
                                                                                                                                                                                                                                                           string("\"")]))))),
                                                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                                                       string("version = \"0.0.1\""))),
                                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                                       string("edition = \"2021\""))),
                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                       string(""))),
                                                                                                                                                                               string("\n"))),
                                                                                                                                                                       string("[dependencies]"))),
                                                                                                                                                               string("\n"))),
                                                                                                                                                       (if !((v1662.clone())
                                                                                                                                                                 ==
                                                                                                                                                                 Spiral_builder::US35::US35_1)
                                                                                                                                                           {
                                                                                                                                                            string("fable_library_rust = { workspace = true }")
                                                                                                                                                        } else {
                                                                                                                                                            append((append((append(string("fable_library_rust = { workspace = true, features = ["),
                                                                                                                                                                                   (if v2277
                                                                                                                                                                                       {
                                                                                                                                                                                        string("\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"")
                                                                                                                                                                                    } else {
                                                                                                                                                                                        string("\"datetime\", \"guid\", \"threaded\"")
                                                                                                                                                                                    }))),
                                                                                                                                                                           string("]"))),
                                                                                                                                                                   string("}"))
                                                                                                                                                        }))),
                                                                                                                                               string("\n"))),
                                                                                                                                       string("inline_colorization = { workspace = true }"))),
                                                                                                                               string("\n"))),
                                                                                                                       (v2177))),
                                                                                                               string("\n"))),
                                                                                                       string(""))),
                                                                                               string("\n"))),
                                                                                       (if if let Spiral_builder::US35::US35_1
                                                                                                  =
                                                                                                  &v1662
                                                                                              {
                                                                                               true
                                                                                           } else {
                                                                                               false
                                                                                           }
                                                                                           {
                                                                                            append(string("[[bin]]\n"),
                                                                                                   (concat(new_array(&[string("name = \"spiral_builder_"),
                                                                                                                       v1746.clone(),
                                                                                                                       string("\"")]))))
                                                                                        } else {
                                                                                            string("[lib]\ncrate-type = [\"cdylib\"]")
                                                                                        }))),
                                                                               string("\n"))),
                                                                       string("path = \"spiral_builder.rs\""));
                                                    let v2405:
                                                                    string =
                                                                append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append((append(string("cargo-features = [\"profile-rustflags\"]\n\n[workspace]\nresolver = \"2\"\nmembers = [\"packages/Rust/*\"]\n\n[workspace.dependencies.fable_library_rust]\n"),
                                                                                                                                                                                                                                                                                                       (concat(new_array(&[string("path = \""),
                                                                                                                                                                                                                                                                                                                           Spiral_builder::method153(v1888.clone()),
                                                                                                                                                                                                                                                                                                                           string("/lib/rust/fable/fable_modules/fable-library-rust\"")]))))),
                                                                                                                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                                                                                                                       string("default-features = false"))),
                                                                                                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                                                                                                       string("features = []"))),
                                                                                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                                                                                       string(""))),
                                                                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                                                                       string("[workspace.dependencies]"))),
                                                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                                                       string("inline_colorization = \"~0.1\""))),
                                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                                       string(""))),
                                                                                                                                                                                               string("\n"))),
                                                                                                                                                                                       string("[profile.release]"))),
                                                                                                                                                                               string("\n"))),
                                                                                                                                                                       string("codegen-units = 1"))),
                                                                                                                                                               string("\n"))),
                                                                                                                                                       string("opt-level = \"z\""))),
                                                                                                                                               string("\n"))),
                                                                                                                                       string("lto = true"))),
                                                                                                                               string("\n"))),
                                                                                                                       string("debug = false"))),
                                                                                                               string("\n"))),
                                                                                                       string("panic = \"abort\""))),
                                                                                               string("\n"))),
                                                                                       string("overflow-checks = true"))),
                                                                               string("\n"))),
                                                                       string("rustflags = [\"-C\", \"link-arg=-s\"]"));
                                                    Spiral_builder::method38(v1954.clone(), v2340);
                                                    Spiral_builder::method38(v1902, v2405);
                                                    {
                                                        let v2407: string =
                                                            Spiral_builder::method28(
                                                                v2009,
                                                                string("src/Range.rs"),
                                                            );
                                                        if Spiral_builder::method40(v2407.clone()) {
                                                            let v2412: Result<
                                                                Vec<u8>,
                                                                std::io::Error,
                                                            > = std::fs::read(&*v2407.clone());
                                                            let v2450: Vec<u8> =
                                                                Spiral_builder::method27(
                                                                    v2412.unwrap(),
                                                                );
                                                            let v2452: Result<
                                                                std::string::String,
                                                                std::string::FromUtf8Error,
                                                            > = std::string::String::from_utf8(
                                                                v2450,
                                                            );
                                                            let v2455: std::string::String =
                                                                v2452.unwrap();
                                                            Spiral_builder::method38(v2407,
                                                                                             replace(replace(fable_library_rust::String_::fromString(v2455),
                                                                                                             string("use crate::String_::fromCharCode;"),
                                                                                                             string("use crate::String_::fromChar;")),
                                                                                                     string("fromCharCode(c)"),
                                                                                                     string("std::char::from_u32(c).unwrap()")))
                                                        }
                                                        {
                                                            let patternInput_10: (i32, string) =
                                                                Spiral_builder::method221(
                                                                    v1874.clone(),
                                                                    v1954.clone(),
                                                                    1_u8,
                                                                );
                                                            let v2497: i32 =
                                                                patternInput_10.0.clone();
                                                            if (v2497) != 0_i32 {
                                                                let v2504: () = {
                                                                    Spiral_builder::closure86(
                                                                        patternInput_10.1.clone(),
                                                                        v2497,
                                                                        (),
                                                                    );
                                                                    ()
                                                                };
                                                                ()
                                                            }
                                                            {
                                                                let v2547: Result<
                                                                    Vec<u8>,
                                                                    std::io::Error,
                                                                > = std::fs::read(&*v2182.clone());
                                                                let v2585: Vec<u8> =
                                                                    Spiral_builder::method27(
                                                                        v2547.unwrap(),
                                                                    );
                                                                let v2587: Result<
                                                                    std::string::String,
                                                                    std::string::FromUtf8Error,
                                                                > = std::string::String::from_utf8(
                                                                    v2585,
                                                                );
                                                                let v2590: std::string::String =
                                                                    v2587.unwrap();
                                                                let v2620:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v2590);
                                                                let v2627:
                                                                                string =
                                                                            append(string("pub fn main() -> Result<(), String> "),
                                                                                   (Spiral_builder::method227()));
                                                                let v2673:
                                                                                string =
                                                                            append((append((if if let Spiral_builder::US35::US35_1
                                                                                                      =
                                                                                                      &v1662
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
                                                                                           string("\n"))),
                                                                                   (if if if let Spiral_builder::US35::US35_1
                                                                                                 =
                                                                                                 &v1662
                                                                                             {
                                                                                              true
                                                                                          } else {
                                                                                              false
                                                                                          }
                                                                                          {
                                                                                           contains(v2620.clone(),
                                                                                                    append((v2266.clone()),
                                                                                                           string("Spiral_builder::method0()")))
                                                                                       } else {
                                                                                           false
                                                                                       }
                                                                                       {
                                                                                        concat(new_array(&[v2627.clone(),
                                                                                                           string(" Ok(Spiral_builder::method0()) }")]))
                                                                                    } else {
                                                                                        concat(new_array(&[v2627.clone(),
                                                                                                           string(" Ok(()) }")]))
                                                                                    }));
                                                                let v2674: bool =
                                                                    contains(v2620.clone(), v2627);
                                                                let v2767: string = if v2674 {
                                                                    v2620.clone()
                                                                } else {
                                                                    (if (if let Spiral_builder::US35::US35_0(v1662_0_0)
                                                                                            =
                                                                                            &v1662
                                                                                        {
                                                                                         if let Spiral_builder::US36::US36_1(v1662_1_0)
                                                                                                =
                                                                                                &v1662_0_0
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
                                                                                                    Spiral_builder::closure87((),
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
                                                                                                        Spiral_builder::closure89(v2763.clone(),
                                                                                                                                  v_6)
                                                                                                })
                                                                                 })((if v2277
                                                                                        {
                                                                                         Func1::new(move
                                                                                                        |v_3:
                                                                                                             string|
                                                                                                        Spiral_builder::closure87((),
                                                                                                                                  v_3))
                                                                                     } else {
                                                                                         let v2755:
                                                                                                 string =
                                                                                             append(string("// "),
                                                                                                    (v2266.clone()));
                                                                                         Func1::new({
                                                                                                        let v2266
                                                                                                            =
                                                                                                            v2266.clone();
                                                                                                        let v2755
                                                                                                            =
                                                                                                            v2755.clone();
                                                                                                        move
                                                                                                            |v_4:
                                                                                                                 string|
                                                                                                            Spiral_builder::closure88(v2266.clone(),
                                                                                                                                      v2755.clone(),
                                                                                                                                      v_4)
                                                                                                    })
                                                                                     })(replace(replace(replace(replace(replace(replace(replace(replace(replace(replace(Spiral_builder::method172(string("\\s\\sgetZero\\(\\);"),
                                                                                                                                                                                                  string(" getZero::<()>();"),
                                                                                                                                                                                                  Spiral_builder::method172(string("\\s\\sdefaultOf\\(\\);"),
                                                                                                                                                                                                                            string(" defaultOf::<()>();"),
                                                                                                                                                                                                                            replace(replace(concat(new_array(&[v2620,
                                                                                                                                                                                                                                                               string("\n\n"),
                                                                                                                                                                                                                                                               v2673,
                                                                                                                                                                                                                                                               string("\n")])),
                                                                                                                                                                                                                                            append(string("),)"),
                                                                                                                                                                                                                                                   (";".into())),
                                                                                                                                                                                                                                            string("));")),
                                                                                                                                                                                                                                    append(string("},)"),
                                                                                                                                                                                                                                           (";".into())),
                                                                                                                                                                                                                                    string("});")))),
                                                                                                                                                                        string("::Slice\'_"),
                                                                                                                                                                        string("::Slice__")),
                                                                                                                                                                string(" Slice\'_"),
                                                                                                                                                                string(" Slice__")),
                                                                                                                                                        append(string("defaultOf()"),
                                                                                                                                                               (",".into())),
                                                                                                                                                        string("defaultOf::<std::sync::Arc<dyn IDisposable>>(),")),
                                                                                                                                                append(string("__self"),
                                                                                                                                                       ("__.".into())),
                                                                                                                                                string("self.")),
                                                                                                                                        append(string("_self"),
                                                                                                                                               ("_.".into())),
                                                                                                                                        string("self.")),
                                                                                                                                append(string("get_or_insert_wit"),
                                                                                                                                       ("h".into())),
                                                                                                                                string("get_or_init")),
                                                                                                                        append(string("use fable_library_rust::System::Collections::Concurrent::ConcurrentStack_1"),
                                                                                                                               (";".into())),
                                                                                                                        string("type ConcurrentStack_1<T> = T;")),
                                                                                                                append(string("use fable_library_rust::System::Threading::CancellationToken"),
                                                                                                                       (";".into())),
                                                                                                                string("type CancellationToken = ();")),
                                                                                                        append(string("use fable_library_rust::System::TimeZoneInfo"),
                                                                                                               (";".into())),
                                                                                                        string("type TimeZoneInfo = i64;")),
                                                                                                append(string("use fable_library_rust::System::Threading::Tasks::TaskCanceledException"),
                                                                                                       (";".into())),
                                                                                                string("type TaskCanceledException = ();"))))
                                                                };
                                                                if (v2674) == false {
                                                                    Spiral_builder::method38(
                                                                        v2182.clone(),
                                                                        v2767.clone(),
                                                                    );
                                                                }
                                                                {
                                                                    let v2773:
                                                                                    string =
                                                                                if (if let Spiral_builder::US35::US35_1
                                                                                           =
                                                                                           &v1662
                                                                                       {
                                                                                        true
                                                                                    } else {
                                                                                        false
                                                                                    })
                                                                                       !=
                                                                                       true
                                                                                   {
                                                                                    concat(new_array(&[string("cargo +nightly-2024-07-14 build --release --target wasm32-unknown-unknown --manifest-path \""),
                                                                                                       v1954.clone(),
                                                                                                       string("\"")]))
                                                                                } else {
                                                                                    concat(new_array(&[string("cargo run --manifest-path \""),
                                                                                                       v1954,
                                                                                                       string("\"")]))
                                                                                };
                                                                    let v2786:
                                                                                    Array<(string,
                                                                                           string)> =
                                                                                if (if let Spiral_builder::US35::US35_1
                                                                                           =
                                                                                           &v1662
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
                                                                                match &v1874
                                                                                    {
                                                                                    Spiral_builder::US12::US12_0(v1874_0_0)
                                                                                    =>
                                                                                    Ok::<string,
                                                                                         string>(v1874_0_0.clone()),
                                                                                    Spiral_builder::US12::US12_1(v1874_1_0)
                                                                                    =>
                                                                                    Err::<string,
                                                                                          string>(v1874_1_0.clone()),
                                                                                };
                                                                    let patternInput_11:
                                                                                    (i32,
                                                                                     string) =
                                                                                Spiral_builder::method65(v2773.clone(),
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
                                                                                          &v1662
                                                                                      {
                                                                                       true
                                                                                   } else {
                                                                                       false
                                                                                   }
                                                                                   {
                                                                                    let v2816:
                                                                                            i32 =
                                                                                        get_Count(v2786.clone());
                                                                                    let v2817:
                                                                                            Array<string> =
                                                                                        new_init(&string(""),
                                                                                                 v2816);
                                                                                    let v2818:
                                                                                            LrcPtr<Spiral_builder::Mut5> =
                                                                                        LrcPtr::new(Spiral_builder::Mut5{l0:
                                                                                                                             MutCell::new(0_i32),});
                                                                                    while Spiral_builder::method69(v2816,
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
                                                                                                (v2820)
                                                                                                    +
                                                                                                    1_i32;
                                                                                            v2818.l0.set(v2824);
                                                                                            ()
                                                                                        }
                                                                                    }
                                                                                    {
                                                                                        let v2843:
                                                                                                string =
                                                                                            concat(new_array(&[string("pwsh -c \'"),
                                                                                                               join(string(";"),
                                                                                                                    toArray_1(ofArray_1(new_array(&[join(string(";"),
                                                                                                                                                         toArray_1(ofArray_1(v2817.clone()))),
                                                                                                                                                    v2773])))),
                                                                                                               string("\'")]));
                                                                                        let patternInput_13:
                                                                                                (Spiral_builder::US5,
                                                                                                 Spiral_builder::US5,
                                                                                                 Spiral_builder::US5,
                                                                                                 Spiral_builder::US5) =
                                                                                            if (v2813)
                                                                                                   !=
                                                                                                   0_i32
                                                                                               {
                                                                                                let v2849:
                                                                                                        () =
                                                                                                    {
                                                                                                        Spiral_builder::closure90(v1551,
                                                                                                                                  v2182.clone(),
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
                                                                                                              result_1.set(Spiral_builder::closure61((),
                                                                                                                                                     Spiral_builder::closure91(v2814.clone(),
                                                                                                                                                                               ()))),
                                                                                                          |ex_1:
                                                                                                               LrcPtr<Exception>|
                                                                                                              result_1.set(Spiral_builder::closure93(v2182.clone(),
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
                                                                                                                 }.clone()),
                                                                                                            _
                                                                                                            =>
                                                                                                            None::<string>,
                                                                                                        };
                                                                                                    (Spiral_builder::US5::US5_0(string("rs")),
                                                                                                     Spiral_builder::US5::US5_0(v2767.clone()),
                                                                                                     Spiral_builder::US5::US5_0(v2182.clone()),
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
                                                                                                 v1746.clone());
                                                                                    let v2930:
                                                                                            string =
                                                                                        sprintf!("pwsh -c \"pwsh {} {} -Linux -EnvironmentVariables AUTOMATION={}`nNEAR_RPC_TIMEOUT_SECS=100\"",
                                                                                                 string("scripts/invoke-block.ps1"),
                                                                                                 sprintf!("\'workspace/target/release/spiral_wasm -w {} -t Debug {}\'",
                                                                                                          v2918.clone(),
                                                                                                          if let Spiral_builder::US35::US35_0(v1662_0_0)
                                                                                                                 =
                                                                                                                 &v1662
                                                                                                             {
                                                                                                              let v2919:
                                                                                                                      Spiral_builder::US36 =
                                                                                                                  v1662_0_0.clone();
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
                                                                                        if (v2813)
                                                                                               ==
                                                                                               0_i32
                                                                                           {
                                                                                            let patternInput_14:
                                                                                                    (i32,
                                                                                                     string) =
                                                                                                Spiral_builder::method65(v2930.clone(),
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
                                                                                                                         Some(v1888));
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
                                                                                                if (v2941)
                                                                                                       ==
                                                                                                       0_i32
                                                                                                   {
                                                                                                    (Spiral_builder::US5::US5_0(string("rs")),
                                                                                                     Spiral_builder::US5::US5_0(v2767),
                                                                                                     Spiral_builder::US5::US5_0(v2182.clone()),
                                                                                                     Spiral_builder::US5::US5_0(v2942.clone()))
                                                                                                } else {
                                                                                                    let v2950:
                                                                                                            () =
                                                                                                        {
                                                                                                            Spiral_builder::closure95(v1551,
                                                                                                                                      v2182.clone(),
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
                                                                                                    Spiral_builder::closure96(v1551,
                                                                                                                              v2182.clone(),
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
                                                                    if v1551 {
                                                                        let v3058:
                                                                                        string =
                                                                                    if (if let Spiral_builder::US35::US35_1
                                                                                               =
                                                                                               &v1662
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
                                                                                    Spiral_builder::method28(v1900.clone(),
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058.clone(),
                                                                                                                      v1746.clone(),
                                                                                                                      string("")));
                                                                        let v3064:
                                                                                        string =
                                                                                    Spiral_builder::method28(v1900.clone(),
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058.clone(),
                                                                                                                      v1746.clone(),
                                                                                                                      string(".wasm")));
                                                                        let v3067:
                                                                                        string =
                                                                                    Spiral_builder::method28(v1900.clone(),
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058.clone(),
                                                                                                                      v1746.clone(),
                                                                                                                      string(".pdb")));
                                                                        let v3070:
                                                                                        string =
                                                                                    Spiral_builder::method28(v1900.clone(),
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058.clone(),
                                                                                                                      v1746.clone(),
                                                                                                                      string(".exe")));
                                                                        let v3073:
                                                                                        string =
                                                                                    Spiral_builder::method28(v1900,
                                                                                                             sprintf!("target/{}/spiral_builder_{}{}",
                                                                                                                      v3058,
                                                                                                                      v1746,
                                                                                                                      string(".d")));
                                                                        let v3074:
                                                                                        bool =
                                                                                    Spiral_builder::method40(v3061.clone());
                                                                        let v3075:
                                                                                        bool =
                                                                                    Spiral_builder::method40(v3064.clone());
                                                                        let v3076:
                                                                                        bool =
                                                                                    Spiral_builder::method40(v3067.clone());
                                                                        let v3077:
                                                                                        bool =
                                                                                    Spiral_builder::method40(v3070.clone());
                                                                        let v3078:
                                                                                        bool =
                                                                                    Spiral_builder::method40(v3073.clone());
                                                                        let v3081: () = {
                                                                            Spiral_builder::closure97(v2182,
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
                                                                        Spiral_builder::method238(
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
                                    ) = if (fable_library_rust::String_::fromString(v25.clone()))
                                        == string("typescript")
                                    {
                                        let v3140: string = Spiral_builder::method146();
                                        let v3143: &str = &*v3140;
                                        let v3166: Option<std::string::String> =
                                            clap::ArgMatches::get_one(&v26.clone(), v3143).cloned();
                                        let v3180: Spiral_builder::US7 = defaultValue(
                                            Spiral_builder::US7::US7_1,
                                            map(Spiral_builder::method23(), v3166),
                                        );
                                        let v3187: std::string::String = match &v3180 {
                                            Spiral_builder::US7::US7_0(v3180_0_0) => match &v3180 {
                                                Spiral_builder::US7::US7_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        };
                                        let v3189: string =
                                            fable_library_rust::String_::fromString(v3187);
                                        let v3190: string = Spiral_builder::method25();
                                        let v3193: &str = &*v3190;
                                        let v3216: Option<Vec<std::string::String>> =
                                            clap::ArgMatches::get_many(&v26.clone(), v3193)
                                                .map(|x| x.cloned().into_iter().collect());
                                        let v3230: Spiral_builder::US11 = defaultValue(
                                            Spiral_builder::US11::US11_1,
                                            map(Spiral_builder::method26(), v3216),
                                        );
                                        let v3236: Vec<std::string::String> =
                                            new_empty::<std::string::String>().to_vec();
                                        let v3239: Vec<std::string::String> = match &v3230 {
                                            Spiral_builder::US11::US11_0(v3230_0_0) => match &v3230
                                            {
                                                Spiral_builder::US11::US11_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => v3236.clone(),
                                        };
                                        let v3243: Result<Vec<u8>, std::io::Error> =
                                            std::fs::read(&*v3189);
                                        let v3281: Vec<u8> =
                                            Spiral_builder::method27(v3243.unwrap());
                                        let v3283: Result<
                                            std::string::String,
                                            std::string::FromUtf8Error,
                                        > = std::string::String::from_utf8(v3281);
                                        let v3286: std::string::String = v3283.unwrap();
                                        let v3316: string =
                                            fable_library_rust::String_::fromString(v3286);
                                        let v3325: string = Spiral_builder::method192(sprintf!(
                                            "{:?}",
                                            (string("ts"), v3316.clone())
                                        ));
                                        let v3330:
                                                        Spiral_builder::US12 =
                                                    Spiral_builder::method29(Spiral_builder::method28(string("polyglot"),
                                                                                                      string(".devcontainer")),
                                                                             string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder"));
                                        let v3378: Spiral_builder::US5 = match &v3330 {
                                            Spiral_builder::US12::US12_0(v3330_0_0) => {
                                                Spiral_builder::US5::US5_0(v3330_0_0.clone())
                                            }
                                            Spiral_builder::US12::US12_1(v3330_1_0) => {
                                                let v3336: () = {
                                                    Spiral_builder::closure15(
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
                                                Spiral_builder::US5::US5_0(
                                                    match &v3378 {
                                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v3381: string = Spiral_builder::method36();
                                                let v3383: Spiral_builder::US12 =
                                                    Spiral_builder::method29(
                                                        Spiral_builder::method28(
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
                                                            Spiral_builder::closure15(
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
                                        let v3438: string = Spiral_builder::method28(
                                            match &v3433 {
                                                Spiral_builder::US5::US5_0(v3433_0_0) => {
                                                    match &v3433 {
                                                        Spiral_builder::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone()
                                                }
                                                _ => panic!(
                                                    "{}",
                                                    string("Option does not have a value."),
                                                ),
                                            },
                                            string("polyglot"),
                                        );
                                        let v3441: string = toLower(Spiral_builder::method36());
                                        let v3445: string = toLower(v3438);
                                        let v3453: Spiral_builder::US12 =
                                            if startsWith3(v3441, v3445.clone(), false) {
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
                                        let v3472: string = Spiral_builder::method195(
                                            Spiral_builder::US5::US5_0(v3325.clone()),
                                            string("spiral_builder"),
                                            Spiral_builder::US38::US38_0(
                                                Spiral_builder::US37::US37_1,
                                            ),
                                            v3467.clone(),
                                        );
                                        let v3477: string = Spiral_builder::method196(
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
                                        let v3479: string = Spiral_builder::method28(
                                            v3467.clone(),
                                            string("lib/typescript/fable/fable_modules"),
                                        );
                                        let v3480: string = concat(new_array(&[
                                            string("fable-library-"),
                                            string("ts"),
                                        ]));
                                        let v3481: string =
                                            Spiral_builder::method239(v3480.clone());
                                        let v3483: async_walkdir::WalkDir =
                                            async_walkdir::WalkDir::new(&*v3479.clone());
                                        let v3486: async_walkdir::WalkDir =
                                            async_walkdir::WalkDir::filter(v3483, move |x| {
                                                Func1::new({
                                                    let v3480 = v3480.clone();
                                                    move |v_9: async_walkdir::DirEntry| {
                                                        Spiral_builder::closure98(
                                                            v3480.clone(),
                                                            v_9,
                                                        )
                                                    }
                                                })(x)
                                            });
                                        let v3487 = Spiral_builder::method245(v3481);
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
                                                Spiral_builder::closure106((), arg10_0040_20)
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
                                            map(Spiral_builder::method250(), v3503),
                                        );
                                        let v3524: () = {
                                            Spiral_builder::closure108(v3518.clone(), ());
                                            ()
                                        };
                                        Spiral_builder::method253(
                                            v3472.clone(),
                                            v3479.clone(),
                                            v3518.clone(),
                                        );
                                        {
                                            let patternInput_19: (i32, string) =
                                                Spiral_builder::method205(
                                                    Spiral_builder::US35::US35_1,
                                                    v3472.clone(),
                                                    string("ts"),
                                                    v3477,
                                                    v3453.clone(),
                                                );
                                            let v3566: string = patternInput_19.1.clone();
                                            let v3565: i32 = patternInput_19.0.clone();
                                            Spiral_builder::method253(
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
                                                ) = if (v3565) != 0_i32 {
                                                    let v3572: () = {
                                                        Spiral_builder::closure109(
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
                                                                        concat(new_array(&[string("\""),
                                                                                           v3621,
                                                                                           string("\":\"*\"")]))
                                                                    };
                                                                let v3629:
                                                                        bool =
                                                                    true; v3627 }).collect::<Vec<_>>();
                                                    let v3631: Vec<string> = _vec_map;
                                                    let v3633:
                                                                        Array<string> =
                                                                    fable_library_rust::NativeArray_::array_from(v3631);
                                                    let v3646: string = join(
                                                        string(",\n"),
                                                        toArray_1(delay(Func0::new({
                                                            let v3633 = v3633.clone();
                                                            move || {
                                                                map_1(
                                                                    Func1::new({
                                                                        let v3633 = v3633.clone();
                                                                        move |i_2: i32| {
                                                                            v3633[i_2].clone()
                                                                        }
                                                                    }),
                                                                    rangeNumeric(
                                                                        0_i32,
                                                                        1_i32,
                                                                        (get_Count(v3633.clone()))
                                                                            - 1_i32,
                                                                    ),
                                                                )
                                                            }
                                                        }))),
                                                    );
                                                    let v3662:
                                                                        string =
                                                                    append((append((append((append((append((append((append(string("{"),
                                                                                                                           (concat(new_array(&[string("  \"name\": \"spiral_builder_"),
                                                                                                                                               v3325,
                                                                                                                                               string("\",")]))))),
                                                                                                                   string("  \"dependencies\": {"))),
                                                                                                           (v3646))),
                                                                                                   string("  },"))),
                                                                                           string("    \"devDependencies\": {"))),
                                                                                   string("  },"))),
                                                                           string("}"));
                                                    let v3664: string = Spiral_builder::method28(
                                                        v3472.clone(),
                                                        string("package.json"),
                                                    );
                                                    let v3667: string = Spiral_builder::method28(
                                                        Spiral_builder::method28(
                                                            v3472.clone(),
                                                            string("../.."),
                                                        ),
                                                        string("package.json"),
                                                    );
                                                    Spiral_builder::method38(v3664, v3662);
                                                    Spiral_builder::method38(v3667, string(""));
                                                    {
                                                        let v3670: string =
                                                            Spiral_builder::method28(
                                                                v3472,
                                                                concat(new_array(&[
                                                                    string("spiral_builder"),
                                                                    string("."),
                                                                    string("ts"),
                                                                ])),
                                                            );
                                                        let v3673: () = {
                                                            Spiral_builder::closure110(
                                                                v3670.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        let v3716: Result<Vec<u8>, std::io::Error> =
                                                            std::fs::read(&*v3670.clone());
                                                        let v3754: Vec<u8> =
                                                            Spiral_builder::method27(
                                                                v3716.unwrap(),
                                                            );
                                                        let v3756: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v3754);
                                                        let v3759: std::string::String =
                                                            v3756.unwrap();
                                                        let v3789: string =
                                                            fable_library_rust::String_::fromString(
                                                                v3759,
                                                            );
                                                        let v3795:
                                                                            bool =
                                                                        contains(v3789.clone(),
                                                                                 string("// spiral_builder.process_typescript"));
                                                        let v3804: string = if v3795 {
                                                            v3789.clone()
                                                        } else {
                                                            Spiral_builder::method172(string("\\s\\sdefaultOf\\(\\);"),
                                                                                                      string(" defaultOf::<()>();"),
                                                                                                      replace(v3789,
                                                                                                              sprintf!("\"./fable_modules/fable-library-ts.{}/",
                                                                                                                       v3518.clone()),
                                                                                                              sprintf!("\"{}/lib/typescript/fable/fable_modules/fable-library-ts.{}/",
                                                                                                                       v3467,
                                                                                                                       v3518)))
                                                        };
                                                        if (v3795) == false {
                                                            Spiral_builder::method38(v3670.clone(),
                                                                                                 concat(new_array(&[v3804.clone(),
                                                                                                                    string("\n\n"),
                                                                                                                    string("// spiral_builder.process_typescript"),
                                                                                                                    string("\n")])));
                                                        }
                                                        {
                                                            let v3807: string =
                                                                concat(new_array(&[
                                                                    string("bun run \""),
                                                                    v3670.clone(),
                                                                    string("\""),
                                                                ]));
                                                            let v3809: string =
                                                                Spiral_builder::method3(string(
                                                                    "PATH",
                                                                ));
                                                            let v3845: Spiral_builder::US5 =
                                                                if (v3809.clone()) == string("") {
                                                                    Spiral_builder::US5::US5_1
                                                                } else {
                                                                    Spiral_builder::US5::US5_0(
                                                                        concat(new_array(&[
                                                                            string("~/.bun/bin"),
                                                                            if cfg!(windows) {
                                                                                string(";")
                                                                            } else {
                                                                                string(":")
                                                                            },
                                                                            v3809,
                                                                        ])),
                                                                    )
                                                                };
                                                            let v3860:
                                                                                Array<(string,
                                                                                       string)> =
                                                                            toArray(Spiral_builder::method258(Spiral_builder::method257(match &v3845
                                                                                                                                            {
                                                                                                                                            Spiral_builder::US5::US5_0(v3845_0_0)
                                                                                                                                            =>
                                                                                                                                            LrcPtr::new(Spiral_builder::UH5::UH5_1(string("PATH"),
                                                                                                                                                                                   match &v3845
                                                                                                                                                                                       {
                                                                                                                                                                                       Spiral_builder::US5::US5_0(x)
                                                                                                                                                                                       =>
                                                                                                                                                                                       x.clone(),
                                                                                                                                                                                       _
                                                                                                                                                                                       =>
                                                                                                                                                                                       unreachable!(),
                                                                                                                                                                                   }.clone(),
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
                                                            let v3873:
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
                                                                            Spiral_builder::method65(v3807.clone(),
                                                                                                     None::<CancellationToken>,
                                                                                                     v3860.clone(),
                                                                                                     None::<Func1<(i32,
                                                                                                                   string,
                                                                                                                   bool),
                                                                                                                  Arc<Async<()>>>>,
                                                                                                     None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                  ()>>,
                                                                                                     true,
                                                                                                     v3873.ok());
                                                            let v3890: string =
                                                                patternInput_20.1.clone();
                                                            let v3889: i32 =
                                                                patternInput_20.0.clone();
                                                            let v3891: i32 =
                                                                get_Count(v3860.clone());
                                                            let v3892: Array<string> =
                                                                new_init(&string(""), v3891);
                                                            let v3893: LrcPtr<
                                                                Spiral_builder::Mut5,
                                                            > = LrcPtr::new(Spiral_builder::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                            while Spiral_builder::method69(
                                                                v3891,
                                                                v3893.clone(),
                                                            ) {
                                                                let v3895: i32 =
                                                                    v3893.l0.get().clone();
                                                                let patternInput_21: (
                                                                    string,
                                                                    string,
                                                                ) = v3860[v3895].clone();
                                                                let v3898: string = sprintf!(
                                                                    "$env:{}=\'\'{}\'\'",
                                                                    patternInput_21.0.clone(),
                                                                    patternInput_21.1.clone()
                                                                );
                                                                v3892.get_mut()[v3895 as usize] =
                                                                    v3898;
                                                                {
                                                                    let v3899: i32 =
                                                                        (v3895) + 1_i32;
                                                                    v3893.l0.set(v3899);
                                                                    ()
                                                                }
                                                            }
                                                            {
                                                                let v3909: string = sprintf!(
                                                                    "pwsh -c \'{}; {}\'",
                                                                    join(
                                                                        string(";"),
                                                                        toArray_1(ofArray_1(
                                                                            v3892.clone()
                                                                        ))
                                                                    ),
                                                                    v3807
                                                                );
                                                                let patternInput_22: (
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                ) = if (v3889) == 0_i32 {
                                                                    let result_2: LrcPtr<
                                                                        MutCell<
                                                                            Spiral_builder::US5,
                                                                        >,
                                                                    > = refCell(
                                                                        Spiral_builder::US5::US5_1,
                                                                    );
                                                                    try_catch(||
                                                                                                  result_2.set(Spiral_builder::closure61((),
                                                                                                                                         Spiral_builder::closure111(v3890.clone(),
                                                                                                                                                                    ()))),
                                                                                              |ex_2:
                                                                                                   LrcPtr<Exception>|
                                                                                                  result_2.set(Spiral_builder::closure112(v3670.clone(),
                                                                                                                                          v3890.clone(),
                                                                                                                                          v3909.clone(),
                                                                                                                                          ex_2.clone())));
                                                                    {
                                                                        let v3915:
                                                                                                Spiral_builder::US5 =
                                                                                            result_2.get().clone();
                                                                        let v3925:
                                                                                                Option<string> =
                                                                                            match &v3915
                                                                                                {
                                                                                                Spiral_builder::US5::US5_0(v3915_0_0)
                                                                                                =>
                                                                                                Some(match &v3915
                                                                                                         {
                                                                                                         Spiral_builder::US5::US5_0(x)
                                                                                                         =>
                                                                                                         x.clone(),
                                                                                                         _
                                                                                                         =>
                                                                                                         unreachable!(),
                                                                                                     }.clone()),
                                                                                                _
                                                                                                =>
                                                                                                None::<string>,
                                                                                            };
                                                                        (Spiral_builder::US5::US5_0(string("ts")),
                                                                                         Spiral_builder::US5::US5_0(v3804),
                                                                                         Spiral_builder::US5::US5_0(v3670.clone()),
                                                                                         Spiral_builder::US5::US5_0(v3925.unwrap()))
                                                                    }
                                                                } else {
                                                                    let v3934: () = {
                                                                        Spiral_builder::closure114(
                                                                            v3670,
                                                                            v3890,
                                                                            v3889,
                                                                            v3909,
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
                                        ) = if (fable_library_rust::String_::fromString(
                                            v25.clone(),
                                        )) == string("python")
                                        {
                                            let v3989: string = Spiral_builder::method146();
                                            let v3992: &str = &*v3989;
                                            let v4015: Option<std::string::String> =
                                                clap::ArgMatches::get_one(&v26.clone(), v3992)
                                                    .cloned();
                                            let v4029: Spiral_builder::US7 = defaultValue(
                                                Spiral_builder::US7::US7_1,
                                                map(Spiral_builder::method23(), v4015),
                                            );
                                            let v4036: std::string::String = match &v4029 {
                                                Spiral_builder::US7::US7_0(v4029_0_0) => {
                                                    match &v4029 {
                                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone()
                                                }
                                                _ => panic!(
                                                    "{}",
                                                    string("Option does not have a value."),
                                                ),
                                            };
                                            let v4038: string =
                                                fable_library_rust::String_::fromString(v4036);
                                            let v4039: string = Spiral_builder::method25();
                                            let v4042: &str = &*v4039;
                                            let v4065: Option<Vec<std::string::String>> =
                                                clap::ArgMatches::get_many(&v26.clone(), v4042)
                                                    .map(|x| x.cloned().into_iter().collect());
                                            let v4079: Spiral_builder::US11 = defaultValue(
                                                Spiral_builder::US11::US11_1,
                                                map(Spiral_builder::method26(), v4065),
                                            );
                                            let v4085: Vec<std::string::String> =
                                                new_empty::<std::string::String>().to_vec();
                                            let v4088: Vec<std::string::String> = match &v4079 {
                                                Spiral_builder::US11::US11_0(v4079_0_0) => {
                                                    match &v4079 {
                                                        Spiral_builder::US11::US11_0(x) => {
                                                            x.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    }
                                                    .clone()
                                                }
                                                _ => v4085.clone(),
                                            };
                                            let v4089: bool =
                                                if let Spiral_builder::US0::US0_0 = &v0_1 {
                                                    true
                                                } else {
                                                    false
                                                };
                                            let v4093: Result<Vec<u8>, std::io::Error> =
                                                std::fs::read(&*v4038);
                                            let v4131: Vec<u8> =
                                                Spiral_builder::method27(v4093.unwrap());
                                            let v4133: Result<
                                                std::string::String,
                                                std::string::FromUtf8Error,
                                            > = std::string::String::from_utf8(v4131);
                                            let v4136: std::string::String = v4133.unwrap();
                                            let v4166: string =
                                                fable_library_rust::String_::fromString(v4136);
                                            let v4175: string = Spiral_builder::method192(
                                                sprintf!("{:?}", (string("py"), v4166.clone())),
                                            );
                                            let v4180:
                                                                Spiral_builder::US12 =
                                                            Spiral_builder::method29(Spiral_builder::method28(string("polyglot"),
                                                                                                              string(".devcontainer")),
                                                                                     string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder"));
                                            let v4228: Spiral_builder::US5 = match &v4180 {
                                                Spiral_builder::US12::US12_0(v4180_0_0) => {
                                                    Spiral_builder::US5::US5_0(v4180_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v4180_1_0) => {
                                                    let v4186: () = {
                                                        Spiral_builder::closure15(
                                                            v4180_1_0.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    Spiral_builder::US5::US5_1
                                                }
                                            };
                                            let v4283: Spiral_builder::US5 = match &v4228 {
                                                Spiral_builder::US5::US5_0(v4228_0_0) => {
                                                    Spiral_builder::US5::US5_0(
                                                        match &v4228 {
                                                            Spiral_builder::US5::US5_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                    )
                                                }
                                                _ => {
                                                    let v4231: string = Spiral_builder::method36();
                                                    let v4233: Spiral_builder::US12 =
                                                        Spiral_builder::method29(
                                                            Spiral_builder::method28(
                                                                string("polyglot"),
                                                                string(".devcontainer"),
                                                            ),
                                                            v4231,
                                                        );
                                                    match &v4233 {
                                                        Spiral_builder::US12::US12_0(v4233_0_0) => {
                                                            Spiral_builder::US5::US5_0(
                                                                v4233_0_0.clone(),
                                                            )
                                                        }
                                                        Spiral_builder::US12::US12_1(v4233_1_0) => {
                                                            let v4239: () = {
                                                                Spiral_builder::closure15(
                                                                    v4233_1_0.clone(),
                                                                    (),
                                                                );
                                                                ()
                                                            };
                                                            Spiral_builder::US5::US5_1
                                                        }
                                                    }
                                                }
                                            };
                                            let v4288: string = Spiral_builder::method28(
                                                match &v4283 {
                                                    Spiral_builder::US5::US5_0(v4283_0_0) => {
                                                        match &v4283 {
                                                            Spiral_builder::US5::US5_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        }
                                                        .clone()
                                                    }
                                                    _ => panic!(
                                                        "{}",
                                                        string("Option does not have a value."),
                                                    ),
                                                },
                                                string("polyglot"),
                                            );
                                            let v4291: string = toLower(Spiral_builder::method36());
                                            let v4295: string = toLower(v4288);
                                            let v4303: Spiral_builder::US12 =
                                                if startsWith3(v4291, v4295.clone(), false) {
                                                    Spiral_builder::US12::US12_1(v4295.clone())
                                                } else {
                                                    Spiral_builder::US12::US12_0(v4295)
                                                };
                                            let v4309: Result<string, string> = match &v4303 {
                                                Spiral_builder::US12::US12_0(v4303_0_0) => {
                                                    Ok::<string, string>(v4303_0_0.clone())
                                                }
                                                Spiral_builder::US12::US12_1(v4303_1_0) => {
                                                    Err::<string, string>(v4303_1_0.clone())
                                                }
                                            };
                                            let v4311: bool = true;
                                            let _result_unwrap_or_else =
                                                v4309.unwrap_or_else(|x| {
                                                    //;
                                                    let v4313: string = x;
                                                    let v4315: bool = true;
                                                    v4313
                                                });
                                            let v4317: string = _result_unwrap_or_else;
                                            let v4322: string = Spiral_builder::method195(
                                                Spiral_builder::US5::US5_0(v4175.clone()),
                                                string("spiral_builder"),
                                                Spiral_builder::US38::US38_0(
                                                    Spiral_builder::US37::US37_2,
                                                ),
                                                v4317.clone(),
                                            );
                                            let v4327: string = Spiral_builder::method196(
                                                v4166,
                                                string("spiral_builder"),
                                                LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                                LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                                    string("Fable.Core"),
                                                    LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                                )),
                                                v4322.clone(),
                                                v4317.clone(),
                                            );
                                            Spiral_builder::method204(
                                                Spiral_builder::method28(
                                                    Spiral_builder::method28(
                                                        v4317,
                                                        string("lib/python/fable/fable_modules"),
                                                    ),
                                                    string("fable_library"),
                                                ),
                                                Spiral_builder::method28(
                                                    v4322.clone(),
                                                    string("fable_modules/fable_library"),
                                                ),
                                            );
                                            {
                                                let patternInput_24: (i32, string) =
                                                    Spiral_builder::method205(
                                                        Spiral_builder::US35::US35_1,
                                                        v4322.clone(),
                                                        string("py"),
                                                        v4327,
                                                        v4303.clone(),
                                                    );
                                                let v4336: string = patternInput_24.1.clone();
                                                let v4335: i32 = patternInput_24.0.clone();
                                                let patternInput_28: (
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                    Spiral_builder::US5,
                                                ) = if (v4335) != 0_i32 {
                                                    let v4342: () = {
                                                        Spiral_builder::closure115(
                                                            v4336.clone(),
                                                            v4335,
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    (
                                                        Spiral_builder::US5::US5_0(string("py")),
                                                        Spiral_builder::US5::US5_1,
                                                        Spiral_builder::US5::US5_1,
                                                        Spiral_builder::US5::US5_0(v4336),
                                                    )
                                                } else {
                                                    let v4387: bool = true;
                                                    let _vec_map : Vec<_> = v4088.into_iter().map(|x| { //;
                                                                    let v4389:
                                                                            std::string::String =
                                                                        x;
                                                                    let v4391:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v4389);
                                                                    let v4397:
                                                                            string =
                                                                        if contains(v4391.clone(),
                                                                                    string("="))
                                                                           {
                                                                            v4391.clone()
                                                                        } else {
                                                                            concat(new_array(&[string("\""),
                                                                                               v4391,
                                                                                               string("\":\"*\"")]))
                                                                        };
                                                                    let v4399:
                                                                            bool =
                                                                        true; v4397 }).collect::<Vec<_>>();
                                                    let v4401: Vec<string> = _vec_map;
                                                    let v4403:
                                                                            Array<string> =
                                                                        fable_library_rust::NativeArray_::array_from(v4401);
                                                    let v4416: string = join(
                                                        string(",\n"),
                                                        toArray_1(delay(Func0::new({
                                                            let v4403 = v4403.clone();
                                                            move || {
                                                                map_1(
                                                                    Func1::new({
                                                                        let v4403 = v4403.clone();
                                                                        move |i_3: i32| {
                                                                            v4403[i_3].clone()
                                                                        }
                                                                    }),
                                                                    rangeNumeric(
                                                                        0_i32,
                                                                        1_i32,
                                                                        (get_Count(v4403.clone()))
                                                                            - 1_i32,
                                                                    ),
                                                                )
                                                            }
                                                        }))),
                                                    );
                                                    let v4432:
                                                                            string =
                                                                        append((append((append((append((append((append((append(string("{"),
                                                                                                                               (concat(new_array(&[string("  \"name\": \"spiral_builder_"),
                                                                                                                                                   v4175,
                                                                                                                                                   string("\",")]))))),
                                                                                                                       string("  \"dependencies\": {"))),
                                                                                                               (v4416))),
                                                                                                       string("  },"))),
                                                                                               string("    \"devDependencies\": {"))),
                                                                                       string("  },"))),
                                                                               string("}"));
                                                    let v4434: string = Spiral_builder::method28(
                                                        v4322.clone(),
                                                        string("package.json"),
                                                    );
                                                    let v4437: string = Spiral_builder::method28(
                                                        Spiral_builder::method28(
                                                            v4322.clone(),
                                                            string("../.."),
                                                        ),
                                                        string("package.json"),
                                                    );
                                                    Spiral_builder::method38(v4434, v4432);
                                                    Spiral_builder::method38(v4437, string(""));
                                                    {
                                                        let v4440: string =
                                                            Spiral_builder::method28(
                                                                v4322,
                                                                concat(new_array(&[
                                                                    string("spiral_builder"),
                                                                    string("."),
                                                                    string("py"),
                                                                ])),
                                                            );
                                                        let v4443: () = {
                                                            Spiral_builder::closure116(
                                                                v4440.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        let v4486: Result<Vec<u8>, std::io::Error> =
                                                            std::fs::read(&*v4440.clone());
                                                        let v4524: Vec<u8> =
                                                            Spiral_builder::method27(
                                                                v4486.unwrap(),
                                                            );
                                                        let v4526: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v4524);
                                                        let v4529: std::string::String =
                                                            v4526.unwrap();
                                                        let v4559: string =
                                                            fable_library_rust::String_::fromString(
                                                                v4529,
                                                            );
                                                        let v4565: bool = contains(
                                                            v4559.clone(),
                                                            string(
                                                                "# spiral_builder.process_python",
                                                            ),
                                                        );
                                                        let v4577: string = if v4565 {
                                                            v4559.clone()
                                                        } else {
                                                            Spiral_builder::method172(
                                                                string("\\s\\sdefaultOf\\(\\);"),
                                                                string(" defaultOf::<()>();"),
                                                                replace(
                                                                    v4559,
                                                                    append(
                                                                        string("),)"),
                                                                        (";".into()),
                                                                    ),
                                                                    string("));"),
                                                                ),
                                                            )
                                                        };
                                                        if (v4565) == false {
                                                            Spiral_builder::method38(v4440.clone(),
                                                                                                     concat(new_array(&[v4577.clone(),
                                                                                                                        string("\n\n"),
                                                                                                                        string("# spiral_builder.process_python"),
                                                                                                                        string("\n")])));
                                                        }
                                                        {
                                                            let v4580: string =
                                                                concat(new_array(&[
                                                                    string("python \""),
                                                                    v4440.clone(),
                                                                    string("\""),
                                                                ]));
                                                            let v4583: Array<(string, string)> =
                                                                new_array(&[(
                                                                    string("TRACE_LEVEL"),
                                                                    string("Verbose"),
                                                                )]);
                                                            let v4594:
                                                                                    Result<string,
                                                                                           string> =
                                                                                match &v4303
                                                                                    {
                                                                                    Spiral_builder::US12::US12_0(v4303_0_0)
                                                                                    =>
                                                                                    Ok::<string,
                                                                                         string>(v4303_0_0.clone()),
                                                                                    Spiral_builder::US12::US12_1(v4303_1_0)
                                                                                    =>
                                                                                    Err::<string,
                                                                                          string>(v4303_1_0.clone()),
                                                                                };
                                                            let patternInput_25:
                                                                                    (i32,
                                                                                     string) =
                                                                                Spiral_builder::method65(v4580.clone(),
                                                                                                         None::<CancellationToken>,
                                                                                                         v4583.clone(),
                                                                                                         None::<Func1<(i32,
                                                                                                                       string,
                                                                                                                       bool),
                                                                                                                      Arc<Async<()>>>>,
                                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                      ()>>,
                                                                                                         true,
                                                                                                         v4594.ok());
                                                            let v4611: string =
                                                                patternInput_25.1.clone();
                                                            let v4610: i32 =
                                                                patternInput_25.0.clone();
                                                            let v4612: i32 =
                                                                get_Count(v4583.clone());
                                                            let v4613: Array<string> =
                                                                new_init(&string(""), v4612);
                                                            let v4614: LrcPtr<
                                                                Spiral_builder::Mut5,
                                                            > = LrcPtr::new(Spiral_builder::Mut5 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                            while Spiral_builder::method69(
                                                                v4612,
                                                                v4614.clone(),
                                                            ) {
                                                                let v4616: i32 =
                                                                    v4614.l0.get().clone();
                                                                let patternInput_26: (
                                                                    string,
                                                                    string,
                                                                ) = v4583[v4616].clone();
                                                                let v4619: string = sprintf!(
                                                                    "$env:{}=\'\'{}\'\'",
                                                                    patternInput_26.0.clone(),
                                                                    patternInput_26.1.clone()
                                                                );
                                                                v4613.get_mut()[v4616 as usize] =
                                                                    v4619;
                                                                {
                                                                    let v4620: i32 =
                                                                        (v4616) + 1_i32;
                                                                    v4614.l0.set(v4620);
                                                                    ()
                                                                }
                                                            }
                                                            {
                                                                let v4630: string = sprintf!(
                                                                    "pwsh -c \'{}; {}\'",
                                                                    join(
                                                                        string(";"),
                                                                        toArray_1(ofArray_1(
                                                                            v4613.clone()
                                                                        ))
                                                                    ),
                                                                    v4580
                                                                );
                                                                let patternInput_27: (
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                    Spiral_builder::US5,
                                                                ) = if (v4610) == 0_i32 {
                                                                    let result_3: LrcPtr<
                                                                        MutCell<
                                                                            Spiral_builder::US5,
                                                                        >,
                                                                    > = refCell(
                                                                        Spiral_builder::US5::US5_1,
                                                                    );
                                                                    try_catch(||
                                                                                                      result_3.set(Spiral_builder::closure61((),
                                                                                                                                             Spiral_builder::closure117(v4611.clone(),
                                                                                                                                                                        ()))),
                                                                                                  |ex_3:
                                                                                                       LrcPtr<Exception>|
                                                                                                      result_3.set(Spiral_builder::closure118(v4440.clone(),
                                                                                                                                              v4611.clone(),
                                                                                                                                              v4630.clone(),
                                                                                                                                              ex_3.clone())));
                                                                    {
                                                                        let v4636:
                                                                                                    Spiral_builder::US5 =
                                                                                                result_3.get().clone();
                                                                        let v4646:
                                                                                                    Option<string> =
                                                                                                match &v4636
                                                                                                    {
                                                                                                    Spiral_builder::US5::US5_0(v4636_0_0)
                                                                                                    =>
                                                                                                    Some(match &v4636
                                                                                                             {
                                                                                                             Spiral_builder::US5::US5_0(x)
                                                                                                             =>
                                                                                                             x.clone(),
                                                                                                             _
                                                                                                             =>
                                                                                                             unreachable!(),
                                                                                                         }.clone()),
                                                                                                    _
                                                                                                    =>
                                                                                                    None::<string>,
                                                                                                };
                                                                        (Spiral_builder::US5::US5_0(string("py")),
                                                                                             Spiral_builder::US5::US5_0(v4577),
                                                                                             Spiral_builder::US5::US5_0(v4440.clone()),
                                                                                             Spiral_builder::US5::US5_0(v4646.unwrap()))
                                                                    }
                                                                } else {
                                                                    let v4655: () = {
                                                                        Spiral_builder::closure120(
                                                                            v4440,
                                                                            v4611,
                                                                            v4610,
                                                                            v4630,
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
                                            let v4709: () = {
                                                Spiral_builder::closure121(v26, v25, ());
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
                                let v4764: Spiral_builder::US5 = patternInput_31.3.clone();
                                let v4763: Spiral_builder::US5 = patternInput_31.2.clone();
                                let v4762: Spiral_builder::US5 = patternInput_31.1.clone();
                                let v4761: Spiral_builder::US5 = patternInput_31.0.clone();
                                new_array(&[
                                    (
                                        string("extension"),
                                        match &v4761 {
                                            Spiral_builder::US5::US5_0(v4761_0_0) => match &v4761 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => string(""),
                                        },
                                    ),
                                    (
                                        string("code"),
                                        match &v4762 {
                                            Spiral_builder::US5::US5_0(v4762_0_0) => match &v4762 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => string(""),
                                        },
                                    ),
                                    (
                                        string("code_path"),
                                        match &v4763 {
                                            Spiral_builder::US5::US5_0(v4763_0_0) => match &v4763 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
                                            _ => string(""),
                                        },
                                    ),
                                    (
                                        string("output"),
                                        match &v4764 {
                                            Spiral_builder::US5::US5_0(v4764_0_0) => match &v4764 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }
                                            .clone(),
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
                let v4797: Vec<(string, string)> = v4795.to_vec();
                let v4800: Vec<LrcPtr<(std::string::String, std::string::String)>> = v4797
                    .into_iter()
                    .map(|x| {
                        Func1::new(move |arg10_0040_33: (string, string)| {
                            Spiral_builder::closure122((), arg10_0040_33)
                        })(x.clone())
                    })
                    .collect::<Vec<_>>();
                let v4801: string =
                string("std::collections::BTreeMap::from_iter(v4800.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                let v4802: std::collections::BTreeMap<std::string::String, std::string::String> =
                    std::collections::BTreeMap::from_iter(
                        v4800
                            .iter()
                            .map(|x| x.as_ref())
                            .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                    );
                let v4804: Result<std::string::String, serde_json::Error> =
                    serde_json::to_string(&v4802);
                let v4805 = Spiral_builder::method268();
                let v4808: Result<std::string::String, string> = v4804.map_err(|x| v4805(x));
                let v4821: bool = true;
                let _result_map_ = v4808.map(|x| {
                    //;
                    let v4823: std::string::String = x;
                    let v4825: string = fable_library_rust::String_::fromString(v4823);
                    let v4827: bool = true;
                    v4825
                });
                let v4830: Result<string, string> = Spiral_builder::method269(_result_map_);
                let v4833: string = string("}");
                let v4837: bool = true;
                let v4834 = v4830;
                let v4849: string = append(
                    (append(
                        (append((append(string("true; v4834 "), (v4833))), string("); "))),
                        string(""),
                    )),
                    string(" // rust.fix_closure\'"),
                );
                let v4850: bool = true;
                v4834
            }); // rust.fix_closure';
            let v4852 = __future_init;
            v4852
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v3: () = {
                Spiral_builder::closure2((), ());
                ()
            };
            let v21: LrcPtr<Spiral_builder::Mut4> = (Spiral_builder::TraceState::trace_state()
                .get()
                .clone()
                .unwrap())
            .4
            .clone();
            let v37: () = {
                Spiral_builder::closure5(v0_1, ());
                ()
            };
            let v76: clap::Command = Spiral_builder::method0();
            let v78: clap::ArgMatches = clap::Command::get_matches(v76);
            let v80: std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, string>>>> =
                Spiral_builder::method20(v21.l0.get().clone(), v78);
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
