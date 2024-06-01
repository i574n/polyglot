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
        use fable_library_rust::Interfaces_::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::Interfaces_::System::IDisposable;
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
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::zero;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        use fable_library_rust::System::Exception;
        use fable_library_rust::System::Text::StringBuilder;
        type CancellationToken = ();
        type TaskCanceledException = ();
        type TimeZoneInfo = i64;
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US2 {
            US2_0(Spiral_builder::US0),
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
        #[derive(Clone, Debug)]
        pub enum US5 {
            US5_0(std::string::String),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US6 {
            US6_0(Array<string>),
            US6_1(string),
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
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(
                LrcPtr<Spiral_builder::UH0>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US7_1(string),
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
        }
        impl core::fmt::Display for Spiral_builder::US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US8 {
            US8_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US8_1(string),
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
        pub enum US9 {
            US9_0(char),
            US9_1,
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
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US10_1(string),
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
        pub enum UH2 {
            UH2_0,
            UH2_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Spiral_builder::US10>,
                LrcPtr<Spiral_builder::UH2>,
            ),
        }
        impl Spiral_builder::UH2 {
            pub fn get_IsUH2_0(this_: LrcPtr<Spiral_builder::UH2>, unitArg: ()) -> bool {
                if let Spiral_builder::UH2::UH2_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH2_1(this_: LrcPtr<Spiral_builder::UH2>, unitArg: ()) -> bool {
                if let Spiral_builder::UH2::UH2_1(this__1_0, this__1_1) = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(string, LrcPtr<StringBuilder>, i32, i32),
            US11_1(string),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US12 {
            US12_0(Array<string>),
            US12_1(string),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US13 {
            US13_0,
            US13_1,
            US13_2,
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
            pub fn get_IsUS13_2(this_: &MutCell<Spiral_builder::US13>, unitArg: ()) -> bool {
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US14 {
            US14_0(Spiral_builder::US13),
            US14_1(Spiral_builder::US13),
            US14_2(Spiral_builder::US13),
            US14_3(Spiral_builder::US13),
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
            pub fn get_IsUS14_2(this_: &MutCell<Spiral_builder::US14>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS14_3(this_: &MutCell<Spiral_builder::US14>, unitArg: ()) -> bool {
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US16 {
            US16_0,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US15 {
            US15_0,
            US15_1(Spiral_builder::US16),
            US15_2,
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
            pub fn get_IsUS15_2(this_: &MutCell<Spiral_builder::US15>, unitArg: ()) -> bool {
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
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US17_1(std::string::String),
        }
        impl Spiral_builder::US17 {
            pub fn get_IsUS17_0(this_: &MutCell<Spiral_builder::US17>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS17_1(this_: &MutCell<Spiral_builder::US17>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US18 {
            US18_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US18_1,
        }
        impl Spiral_builder::US18 {
            pub fn get_IsUS18_0(this_: &MutCell<Spiral_builder::US18>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS18_1(this_: &MutCell<Spiral_builder::US18>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(std::string::String),
            US19_1(std::string::String),
        }
        impl Spiral_builder::US19 {
            pub fn get_IsUS19_0(this_: &MutCell<Spiral_builder::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS19_1(this_: &MutCell<Spiral_builder::US19>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US20_1,
        }
        impl Spiral_builder::US20 {
            pub fn get_IsUS20_0(this_: &MutCell<Spiral_builder::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS20_1(this_: &MutCell<Spiral_builder::US20>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US21_1,
        }
        impl Spiral_builder::US21 {
            pub fn get_IsUS21_0(this_: &MutCell<Spiral_builder::US21>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS21_1(this_: &MutCell<Spiral_builder::US21>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(std::process::Output),
            US22_1(std::string::String),
        }
        impl Spiral_builder::US22 {
            pub fn get_IsUS22_0(this_: &MutCell<Spiral_builder::US22>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS22_1(this_: &MutCell<Spiral_builder::US22>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(Func1<(bool, string, i32), Arc<Async<()>>>),
            US23_1,
        }
        impl Spiral_builder::US23 {
            pub fn get_IsUS23_0(this_: &MutCell<Spiral_builder::US23>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS23_1(this_: &MutCell<Spiral_builder::US23>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US24 {
            US24_0(CancellationToken),
            US24_1,
        }
        impl Spiral_builder::US24 {
            pub fn get_IsUS24_0(this_: &MutCell<Spiral_builder::US24>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS24_1(this_: &MutCell<Spiral_builder::US24>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(Vec<std::string::String>),
            US25_1,
        }
        impl Spiral_builder::US25 {
            pub fn get_IsUS25_0(this_: &MutCell<Spiral_builder::US25>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS25_1(this_: &MutCell<Spiral_builder::US25>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0,
            US26_1(std::string::String),
        }
        impl Spiral_builder::US26 {
            pub fn get_IsUS26_0(this_: &MutCell<Spiral_builder::US26>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS26_1(this_: &MutCell<Spiral_builder::US26>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(chrono::DateTime<chrono::Utc>),
            US27_1,
        }
        impl Spiral_builder::US27 {
            pub fn get_IsUS27_0(this_: &MutCell<Spiral_builder::US27>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS27_1(this_: &MutCell<Spiral_builder::US27>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US28 {
            US28_0(string),
            US28_1(string),
        }
        impl Spiral_builder::US28 {
            pub fn get_IsUS28_0(this_: &MutCell<Spiral_builder::US28>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS28_1(this_: &MutCell<Spiral_builder::US28>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US29 {
            US29_0(i32, string),
            US29_1(i32, string),
        }
        impl Spiral_builder::US29 {
            pub fn get_IsUS29_0(this_: &MutCell<Spiral_builder::US29>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS29_1(this_: &MutCell<Spiral_builder::US29>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US30 {
            US30_0(std::collections::HashMap<string, string>),
            US30_1,
        }
        impl Spiral_builder::US30 {
            pub fn get_IsUS30_0(this_: &MutCell<Spiral_builder::US30>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS30_1(this_: &MutCell<Spiral_builder::US30>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US31 {
            US31_0(Spiral_builder::US3),
            US31_1,
        }
        impl Spiral_builder::US31 {
            pub fn get_IsUS31_0(this_: &MutCell<Spiral_builder::US31>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS31_1(this_: &MutCell<Spiral_builder::US31>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH3 {
            UH3_0,
            UH3_1(string, bool, LrcPtr<Spiral_builder::UH3>),
        }
        impl Spiral_builder::UH3 {
            pub fn get_IsUH3_0(this_: LrcPtr<Spiral_builder::UH3>, unitArg: ()) -> bool {
                if let Spiral_builder::UH3::UH3_0 = this_.as_ref() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUH3_1(this_: LrcPtr<Spiral_builder::UH3>, unitArg: ()) -> bool {
                if let Spiral_builder::UH3::UH3_1(this__1_0, this__1_1, this__1_2) = this_.as_ref()
                {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US32 {
            US32_0,
            US32_1,
            US32_2,
        }
        impl Spiral_builder::US32 {
            pub fn get_IsUS32_0(this_: &MutCell<Spiral_builder::US32>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS32_1(this_: &MutCell<Spiral_builder::US32>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS32_2(this_: &MutCell<Spiral_builder::US32>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0(std::fs::FileType),
            US33_1(std::string::String),
        }
        impl Spiral_builder::US33 {
            pub fn get_IsUS33_0(this_: &MutCell<Spiral_builder::US33>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS33_1(this_: &MutCell<Spiral_builder::US33>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(async_walkdir::DirEntry),
            US34_1(std::string::String),
        }
        impl Spiral_builder::US34 {
            pub fn get_IsUS34_0(this_: &MutCell<Spiral_builder::US34>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS34_1(this_: &MutCell<Spiral_builder::US34>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US35 {
            US35_0(string, string),
            US35_1,
        }
        impl Spiral_builder::US35 {
            pub fn get_IsUS35_0(this_: &MutCell<Spiral_builder::US35>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS35_1(this_: &MutCell<Spiral_builder::US35>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US35 {
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
            let v13: string = string("r#\"fs-path\"#");
            let v14: &'static str = r#"fs-path"#;
            let v16: clap::Arg = clap::Arg::new(v14);
            let v18: clap::Arg = v16.short('f');
            let v19: string = string("r#\"fs-path\"#");
            let v20: &'static str = r#"fs-path"#;
            let v22: clap::Arg = v18.long(v20);
            let v24: clap::Arg = v22.required(true);
            let v26: clap::Command = clap::Command::arg(v11, v24);
            let v27: string = string("r#\"command\"#");
            let v28: &'static str = r#"command"#;
            let v30: clap::Arg = clap::Arg::new(v28);
            let v32: clap::Arg = v30.short('c');
            let v33: string = string("r#\"command\"#");
            let v34: &'static str = r#"command"#;
            let v36: clap::Arg = v32.long(v34);
            let v38: clap::Command = clap::Command::arg(v26, v36);
            let v40: clap::Command = clap::Command::subcommand(v6, v38);
            let v42: string = string("r#\"rust\"#");
            let v43: &'static str = r#"rust"#;
            let v45: clap::Command = clap::Command::new(v43);
            let v46: string = string("r#\"fs-path\"#");
            let v47: &'static str = r#"fs-path"#;
            let v49: clap::Arg = clap::Arg::new(v47);
            let v51: clap::Arg = v49.short('f');
            let v52: string = string("r#\"fs-path\"#");
            let v53: &'static str = r#"fs-path"#;
            let v55: clap::Arg = v51.long(v53);
            let v57: clap::Arg = v55.required(true);
            let v59: clap::Command = clap::Command::arg(v45, v57);
            let v61: string = string("r#\"NAME\"#");
            let v64: string = string("r#\"VERSION\"#");
            let v66: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v67: usize = 1_i32 as usize;
            let v68: usize = 0_i32 as usize;
            let v74: clap::builder::ValueRange = if v68 == v68 {
                clap::builder::ValueRange::new(v67..)
            } else {
                clap::builder::ValueRange::new(v67..v68)
            };
            let v76: string = string("r#\"deps\"#");
            let v77: &'static str = r#"deps"#;
            let v79: clap::Arg = clap::Arg::new(v77);
            let v81: clap::Arg = v79.short('d');
            let v82: string = string("r#\"deps\"#");
            let v83: &'static str = r#"deps"#;
            let v85: clap::Arg = v81.long(v83);
            let v87: Vec<&'static str> = v66.to_vec();
            let v89: clap::Arg = v85.value_names(v87);
            let v91: clap::Arg = v89.num_args(v74);
            let v93: clap::ArgAction = clap::ArgAction::Append;
            let v95: clap::Arg = v91.action(v93);
            let v97: clap::Command = clap::Command::arg(v59, v95);
            let v99: clap::Command = clap::Command::subcommand(v40, v97);
            let v101: string = string("r#\"dib\"#");
            let v102: &'static str = r#"dib"#;
            let v104: clap::Command = clap::Command::new(v102);
            let v106: string = string("r#\"path\"#");
            let v107: &'static str = r#"path"#;
            let v109: clap::Arg = clap::Arg::new(v107);
            let v111: clap::Arg = v109.short('p');
            let v112: string = string("r#\"path\"#");
            let v113: &'static str = r#"path"#;
            let v115: clap::Arg = v111.long(v113);
            let v117: clap::Arg = v115.required(true);
            let v119: clap::Command = clap::Command::arg(v104, v117);
            let v121: string = string("clap::value_parser!(u8).into()");
            let v122: clap::builder::ValueParser = clap::value_parser!(u8).into();
            let v124: string = string("r#\"retries\"#");
            let v125: &'static str = r#"retries"#;
            let v127: clap::Arg = clap::Arg::new(v125);
            let v129: clap::Arg = v127.short('r');
            let v130: string = string("r#\"retries\"#");
            let v131: &'static str = r#"retries"#;
            let v133: clap::Arg = v129.long(v131);
            let v135: clap::Arg = v133.value_parser(v122);
            let v137: clap::Command = clap::Command::arg(v119, v135);
            let v139: string = string("r#\"working-directory\"#");
            let v140: &'static str = r#"working-directory"#;
            let v142: clap::Arg = clap::Arg::new(v140);
            let v144: clap::Arg = v142.short('w');
            let v145: string = string("r#\"working-directory\"#");
            let v146: &'static str = r#"working-directory"#;
            let v148: clap::Arg = v144.long(v146);
            let v150: clap::Command = clap::Command::arg(v137, v148);
            let v152: clap::Command = clap::Command::subcommand(v99, v150);
            let v154: string = string("r#\"typescript\"#");
            let v155: &'static str = r#"typescript"#;
            let v157: clap::Command = clap::Command::new(v155);
            let v158: string = string("r#\"fs-path\"#");
            let v159: &'static str = r#"fs-path"#;
            let v161: clap::Arg = clap::Arg::new(v159);
            let v163: clap::Arg = v161.short('f');
            let v164: string = string("r#\"fs-path\"#");
            let v165: &'static str = r#"fs-path"#;
            let v167: clap::Arg = v163.long(v165);
            let v169: clap::Arg = v167.required(true);
            let v171: clap::Command = clap::Command::arg(v157, v169);
            let v172: string = string("r#\"NAME\"#");
            let v174: string = string("r#\"VERSION\"#");
            let v176: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v177: usize = 1_i32 as usize;
            let v178: usize = 0_i32 as usize;
            let v184: clap::builder::ValueRange = if v178 == v178 {
                clap::builder::ValueRange::new(v177..)
            } else {
                clap::builder::ValueRange::new(v177..v178)
            };
            let v185: string = string("r#\"deps\"#");
            let v186: &'static str = r#"deps"#;
            let v188: clap::Arg = clap::Arg::new(v186);
            let v190: clap::Arg = v188.short('d');
            let v191: string = string("r#\"deps\"#");
            let v192: &'static str = r#"deps"#;
            let v194: clap::Arg = v190.long(v192);
            let v196: Vec<&'static str> = v176.to_vec();
            let v198: clap::Arg = v194.value_names(v196);
            let v200: clap::Arg = v198.num_args(v184);
            let v202: clap::ArgAction = clap::ArgAction::Append;
            let v204: clap::Arg = v200.action(v202);
            let v206: clap::Command = clap::Command::arg(v171, v204);
            let v208: clap::Command = clap::Command::subcommand(v152, v206);
            let v210: string = string("r#\"python\"#");
            let v211: &'static str = r#"python"#;
            let v213: clap::Command = clap::Command::new(v211);
            let v214: string = string("r#\"fs-path\"#");
            let v215: &'static str = r#"fs-path"#;
            let v217: clap::Arg = clap::Arg::new(v215);
            let v219: clap::Arg = v217.short('f');
            let v220: string = string("r#\"fs-path\"#");
            let v221: &'static str = r#"fs-path"#;
            let v223: clap::Arg = v219.long(v221);
            let v225: clap::Arg = v223.required(true);
            let v227: clap::Command = clap::Command::arg(v213, v225);
            let v228: string = string("r#\"NAME\"#");
            let v230: string = string("r#\"VERSION\"#");
            let v232: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v233: usize = 1_i32 as usize;
            let v234: usize = 0_i32 as usize;
            let v240: clap::builder::ValueRange = if v234 == v234 {
                clap::builder::ValueRange::new(v233..)
            } else {
                clap::builder::ValueRange::new(v233..v234)
            };
            let v241: string = string("r#\"deps\"#");
            let v242: &'static str = r#"deps"#;
            let v244: clap::Arg = clap::Arg::new(v242);
            let v246: clap::Arg = v244.short('d');
            let v247: string = string("r#\"deps\"#");
            let v248: &'static str = r#"deps"#;
            let v250: clap::Arg = v246.long(v248);
            let v252: Vec<&'static str> = v232.to_vec();
            let v254: clap::Arg = v250.value_names(v252);
            let v256: clap::Arg = v254.num_args(v240);
            let v258: clap::ArgAction = clap::ArgAction::Append;
            let v260: clap::Arg = v256.action(v258);
            let v262: clap::Command = clap::Command::arg(v227, v260);
            clap::Command::subcommand(v208, v262)
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
        pub fn method1() -> string {
            string("TRACE_LEVEL")
        }
        pub fn method3() -> string {
            string("")
        }
        pub fn method2(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
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
            let v14: string = Spiral_builder::method3();
            {
                let x: string = v13.unwrap_or(v14);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method4() -> string {
            string("AUTOMATION")
        }
        pub fn closure3(unitVar: (), v0_1: string) {
            ();
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
            let _v1: MutCell<Option<(Spiral_builder::US1, Spiral_builder::US2)>> =
                MutCell::new(None::<(Spiral_builder::US1, Spiral_builder::US2)>);
            let v3: string = Spiral_builder::method2(Spiral_builder::method1());
            let v24: Spiral_builder::US2 = if string("Verbose") == v3.clone() {
                Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_0)
            } else {
                if string("Debug") == v3.clone() {
                    Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_1)
                } else {
                    if string("Info") == v3.clone() {
                        Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_2)
                    } else {
                        if string("Warning") == v3.clone() {
                            Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_3)
                        } else {
                            if string("Critical") == v3 {
                                Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_4)
                            } else {
                                Spiral_builder::US2::US2_1
                            }
                        }
                    }
                }
            };
            {
                let x: (Spiral_builder::US1, Spiral_builder::US2) = (
                    if Spiral_builder::method2(Spiral_builder::method4()) == string("True") {
                        Spiral_builder::US1::US1_0({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        })
                    } else {
                        Spiral_builder::US1::US1_1
                    },
                    v24,
                );
                _v1.set(Some(x))
            }
            {
                let patternInput: (Spiral_builder::US1, Spiral_builder::US2) =
                    match &_v1.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1=None"),),
                        Some(_v1_0_0) => _v1_0_0.clone(),
                    };
                let v139: Spiral_builder::US2 = patternInput.1.clone();
                let v138: Spiral_builder::US1 = patternInput.0.clone();
                let v147: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
                    l0: MutCell::new(Func1::new(move |v: string| Spiral_builder::closure3((), v))),
                });
                (
                    LrcPtr::new(Spiral_builder::Mut0 {
                        l0: MutCell::new(0_i64),
                    }),
                    LrcPtr::new(Spiral_builder::Mut1 {
                        l0: MutCell::new(true),
                    }),
                    LrcPtr::new(Spiral_builder::Mut2 {
                        l0: MutCell::new(match &v139 {
                            Spiral_builder::US2::US2_0(v139_0_0) => match &v139 {
                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v0_1,
                        }),
                    }),
                    match &v138 {
                        Spiral_builder::US1::US1_0(v138_0_0) => Some(match &v138 {
                            Spiral_builder::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<i64>,
                    },
                    v147,
                )
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
        pub fn method6() -> string {
            string("hh:mm:ss")
        }
        pub fn method7() -> string {
            string("")
        }
        pub fn method8() -> string {
            string("HH:mm:ss")
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
                    let v35: DateTime = match &v16 {
                        Spiral_builder::US1::US1_0(v16_0_0) => {
                            let v23: TimeSpan = TimeSpan::new_ticks(
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
                                v23.hours(),
                                v23.minutes(),
                                v23.seconds(),
                                v23.milliseconds(),
                            )
                        }
                        _ => DateTime::now(),
                    };
                    let v36: string = Spiral_builder::method6();
                    {
                        let x_3: string = v35.toString(v36);
                        _v10.set(Some(x_3))
                    }
                    {
                        let v147: string = match &_v10.get().clone() {
                            None => panic!("{}", string("base.run_target / _v10=None"),),
                            Some(_v10_0_0) => _v10_0_0.clone(),
                        };
                        let v160: string = padLeft(
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
                        let _v161: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v176: &str = match &v0_1 {
                            Spiral_builder::US0::US0_1 => inline_colorization::color_bright_blue,
                            Spiral_builder::US0::US0_2 => inline_colorization::color_bright_green,
                            Spiral_builder::US0::US0_0 => inline_colorization::color_bright_black,
                            Spiral_builder::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v178: &str = &*v160;
                        let v180: &str = inline_colorization::color_reset;
                        let v182: string = string("format!(\"{v176}{v178}{v180}\")");
                        let v183: std::string::String = format!("{v176}{v178}{v180}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v183);
                            _v161.set(Some(x_5))
                        }
                        trimEndChars(
                            trimStartChars(
                                sprintf!(
                                    "{} {} #{} {} / {}",
                                    v147,
                                    match &_v161.get().clone() {
                                        None =>
                                            panic!("{}", string("base.run_target / _v161=None"),),
                                        Some(_v161_0_0) => _v161_0_0.clone(),
                                    },
                                    (patternInput.0.clone()).l0.get().clone(),
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
        pub fn method9(v0_1: Spiral_builder::US0, v1_1: Func0<string>) {
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
                            match &_v25.get().clone() {
                                None => panic!("{}", string("base.run_target / _v25=None"),),
                                Some(_v25_0_0) => _v25_0_0.clone(),
                            }
                            ((patternInput.4.clone()).l0.get().clone())(v24)
                        }
                    }
                }
            }
        }
        pub fn method5(v0_1: Spiral_builder::US0, v1_1: Func0<string>, v2: Func0<string>) {
            Spiral_builder::method9(
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
        pub fn method11() -> string {
            string("fs-path")
        }
        pub fn method12() -> string {
            string("command")
        }
        pub fn method15(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method15: loop {
                break '_method15 (if v1_1.get().clone() >= 4_i64 {
                    false
                } else {
                    let v19: Spiral_builder::US9 = if v1_1.get().clone() == 0_i64 {
                        Spiral_builder::US9::US9_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Spiral_builder::US9::US9_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Spiral_builder::US9::US9_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                if v11 == 0_i64 {
                                    Spiral_builder::US9::US9_0(' ')
                                } else {
                                    let v14: i64 = v11 - 1_i64;
                                    Spiral_builder::US9::US9_1
                                }
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v19 {
                            Spiral_builder::US9::US9_0(v19_0_0) => match &v19 {
                                Spiral_builder::US9::US9_0(x) => x.clone(),
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
                        continue '_method15;
                    }
                });
            }
        }
        pub fn method16(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut4>) -> bool {
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
        pub fn method17(
        ) -> Func1<char, Func1<LrcPtr<Spiral_builder::UH1>, LrcPtr<Spiral_builder::UH1>>> {
            Func1::new(move |v: char| Spiral_builder::closure9((), v))
        }
        pub fn method18(
            v0_1: LrcPtr<Spiral_builder::UH1>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method18: loop {
                break '_method18 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH1::UH1_0 => {
                        (v1_1.get().clone(), v2.get().clone(), v3.get().clone())
                    }
                    Spiral_builder::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v4: char = match v0_1.get().clone().as_ref() {
                            Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: bool = '\n' == v4;
                        let patternInput: (i32, i32) = if v6 {
                            (1_i32, v3.get().clone() + 1_i32)
                        } else {
                            (v2.get().clone() + 1_i32, v3.get().clone())
                        };
                        {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH1> =
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                            let v1_1_temp: LrcPtr<StringBuilder> = if v6 {
                                let v12: LrcPtr<StringBuilder> = v1_1.get().clone().Clear();
                                v1_1.get().clone()
                            } else {
                                let v16: LrcPtr<StringBuilder> = {
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
                            continue '_method18;
                        }
                    }
                });
            }
        }
        pub fn method19(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US10 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method19: loop {
                break '_method19 ({
                    let v57: Spiral_builder::US8 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US8::US8_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v15: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v22: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method15(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Spiral_builder::Mut4> =
                                LrcPtr::new(Spiral_builder::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method16(v28, v30.clone()) {
                                let v32: i32 = v30.l0.get().clone();
                                let v33: char = getCharAt(v27.clone(), v32);
                                v29.get_mut()[v32 as usize] = v33;
                                {
                                    let v34: i32 = v32 + 1_i32;
                                    v30.l0.set(v34);
                                    ()
                                }
                            }
                            {
                                let v36: List<char> = ofArray(v29.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method18(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                                    (Spiral_builder::method17())(b0)(b1)
                                                },
                                            ),
                                            v36,
                                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US8::US8_0(
                                    v15,
                                    v22,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US8::US8_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v15,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v57 {
                        Spiral_builder::US8::US8_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
                            let v0_1_temp: string =
                                append(v0_1.get().clone(), ofChar(v57_0_0.clone()));
                            let v1_1_temp: string = v57_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v57_0_2.clone();
                            let v3_temp: i32 = v57_0_3.clone();
                            let v4_temp: i32 = v57_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method19;
                        }
                        _ => Spiral_builder::US10::US10_0(
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
        pub fn method21(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method21: loop {
                break '_method21 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Spiral_builder::US9 = if v1_1.get().clone() == 0_i64 {
                        Spiral_builder::US9::US9_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Spiral_builder::US9::US9_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Spiral_builder::US9::US9_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Spiral_builder::US9::US9_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Spiral_builder::US9::US9_0(v15_0_0) => match &v15 {
                                Spiral_builder::US9::US9_0(x) => x.clone(),
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
                        continue '_method21;
                    }
                });
            }
        }
        pub fn closure11(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US10 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v60: Spiral_builder::US8 = if string("") == v0_1.clone() {
                Spiral_builder::US8::US8_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '\\' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Spiral_builder::Mut4> = LrcPtr::new(Spiral_builder::Mut4 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method16(v18, v20.clone()) {
                        let v22: i32 = v20.l0.get().clone();
                        let v23: char = getCharAt(v17.clone(), v22);
                        v19.get_mut()[v22 as usize] = v23;
                        {
                            let v24: i32 = v22 + 1_i32;
                            v20.l0.set(v24);
                            ()
                        }
                    }
                    {
                        let v26: List<char> = ofArray(v19.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method18(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                        (Spiral_builder::method17())(b0)(b1)
                                    }),
                                    v26,
                                    LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US8::US8_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v38: i32 = length(v0_1.clone());
                    let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US8::US8_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v3,
                            v2,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v41 { v38 } else { v41 })
                            )
                        ),
                        append(replicate(v2 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v102: Spiral_builder::US8 = match &v60 {
                Spiral_builder::US8::US8_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                    let v65: i32 = v60_0_4.clone();
                    let v64: i32 = v60_0_3.clone();
                    let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                    let v62: string = v60_0_1.clone();
                    if string("") == v62.clone() {
                        Spiral_builder::US8::US8_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v63.clone(), v64, v65)
                        ))
                    } else {
                        let v69: char = getCharAt(v62.clone(), 0_i32);
                        let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                        let v78: string = ofChar(v69);
                        let v79: i32 = length(v78.clone());
                        let v80: Array<char> = new_init(&'\u{0000}', v79);
                        let v81: LrcPtr<Spiral_builder::Mut4> = LrcPtr::new(Spiral_builder::Mut4 {
                            l0: MutCell::new(0_i32),
                        });
                        while Spiral_builder::method16(v79, v81.clone()) {
                            let v83: i32 = v81.l0.get().clone();
                            let v84: char = getCharAt(v78.clone(), v83);
                            v80.get_mut()[v83 as usize] = v84;
                            {
                                let v85: i32 = v83 + 1_i32;
                                v81.l0.set(v85);
                                ()
                            }
                        }
                        {
                            let v87: List<char> = ofArray(v80.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method18(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                                (Spiral_builder::method17())(b0)(b1)
                                            },
                                        ),
                                        v87,
                                        LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                    ),
                                    v63,
                                    v64,
                                    v65,
                                );
                            Spiral_builder::US8::US8_0(
                                v69,
                                v76,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Spiral_builder::US8::US8_1(v60_1_0) => Spiral_builder::US8::US8_1(v60_1_0.clone()),
            };
            match &v102 {
                Spiral_builder::US8::US8_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                    Spiral_builder::US10::US10_0(
                        sprintf!("{}{}", '\\', v102_0_0.clone()),
                        v102_0_1.clone(),
                        v102_0_2.clone(),
                        v102_0_3.clone(),
                        v102_0_4.clone(),
                    )
                }
                Spiral_builder::US8::US8_1(v102_1_0) => {
                    Spiral_builder::US10::US10_1(v102_1_0.clone())
                }
            }
        }
        pub fn closure12(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US10 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v60: Spiral_builder::US8 = if string("") == v0_1.clone() {
                Spiral_builder::US8::US8_1(sprintf!(
                    "parsing.p_char / unexpected end of input / s: {:?}",
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v7: char = getCharAt(v0_1.clone(), 0_i32);
                if v7 == '`' {
                    let v15: string =
                        getSlice(v0_1.clone(), Some(1_i32), Some(length(v0_1.clone())));
                    let v17: string = ofChar(v7);
                    let v18: i32 = length(v17.clone());
                    let v19: Array<char> = new_init(&'\u{0000}', v18);
                    let v20: LrcPtr<Spiral_builder::Mut4> = LrcPtr::new(Spiral_builder::Mut4 {
                        l0: MutCell::new(0_i32),
                    });
                    while Spiral_builder::method16(v18, v20.clone()) {
                        let v22: i32 = v20.l0.get().clone();
                        let v23: char = getCharAt(v17.clone(), v22);
                        v19.get_mut()[v22 as usize] = v23;
                        {
                            let v24: i32 = v22 + 1_i32;
                            v20.l0.set(v24);
                            ()
                        }
                    }
                    {
                        let v26: List<char> = ofArray(v19.clone());
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                            Spiral_builder::method18(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                        (Spiral_builder::method17())(b0)(b1)
                                    }),
                                    v26,
                                    LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US8::US8_0(
                            v7,
                            v15,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    }
                } else {
                    let v38: i32 = length(v0_1.clone());
                    let v41: i32 = indexOf(v0_1.clone(), string("\n")) - 1_i32;
                    Spiral_builder::US8::US8_1(sprintf!(
                        "{}\n{}\n",
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v3,
                            v2,
                            v1_1,
                            getSlice(
                                v0_1,
                                Some(0_i32),
                                Some(if -2_i32 == v41 { v38 } else { v41 })
                            )
                        ),
                        append(replicate(v2 - 1_i32, string(" ")), string("^"))
                    ))
                }
            };
            let v102: Spiral_builder::US8 = match &v60 {
                Spiral_builder::US8::US8_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                    let v65: i32 = v60_0_4.clone();
                    let v64: i32 = v60_0_3.clone();
                    let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                    let v62: string = v60_0_1.clone();
                    if string("") == v62.clone() {
                        Spiral_builder::US8::US8_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v63.clone(), v64, v65)
                        ))
                    } else {
                        let v69: char = getCharAt(v62.clone(), 0_i32);
                        let v76: string = getSlice(v62.clone(), Some(1_i32), Some(length(v62)));
                        let v78: string = ofChar(v69);
                        let v79: i32 = length(v78.clone());
                        let v80: Array<char> = new_init(&'\u{0000}', v79);
                        let v81: LrcPtr<Spiral_builder::Mut4> = LrcPtr::new(Spiral_builder::Mut4 {
                            l0: MutCell::new(0_i32),
                        });
                        while Spiral_builder::method16(v79, v81.clone()) {
                            let v83: i32 = v81.l0.get().clone();
                            let v84: char = getCharAt(v78.clone(), v83);
                            v80.get_mut()[v83 as usize] = v84;
                            {
                                let v85: i32 = v83 + 1_i32;
                                v81.l0.set(v85);
                                ()
                            }
                        }
                        {
                            let v87: List<char> = ofArray(v80.clone());
                            let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) =
                                Spiral_builder::method18(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                                (Spiral_builder::method17())(b0)(b1)
                                            },
                                        ),
                                        v87,
                                        LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                    ),
                                    v63,
                                    v64,
                                    v65,
                                );
                            Spiral_builder::US8::US8_0(
                                v69,
                                v76,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Spiral_builder::US8::US8_1(v60_1_0) => Spiral_builder::US8::US8_1(v60_1_0.clone()),
            };
            match &v102 {
                Spiral_builder::US8::US8_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                    Spiral_builder::US10::US10_0(
                        sprintf!("{}{}", '`', v102_0_0.clone()),
                        v102_0_1.clone(),
                        v102_0_2.clone(),
                        v102_0_3.clone(),
                        v102_0_4.clone(),
                    )
                }
                Spiral_builder::US8::US8_1(v102_1_0) => {
                    Spiral_builder::US10::US10_1(v102_1_0.clone())
                }
            }
        }
        pub fn method22(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Spiral_builder::UH2>,
        ) -> Spiral_builder::US10 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v4.clone());
            '_method22: loop {
                break '_method22 (match v4.get().clone().as_ref() {
                    Spiral_builder::UH2::UH2_0 => {
                        Spiral_builder::US10::US10_1(string("choice / no parsers succeeded"))
                    }
                    Spiral_builder::UH2::UH2_1(v4_1_0, v4_1_1) => {
                        let v9: Spiral_builder::US10 = (match v4.get().clone().as_ref() {
                            Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Spiral_builder::US10::US10_0(
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
                                let v4_temp: LrcPtr<Spiral_builder::UH2> =
                                    match v4.get().clone().as_ref() {
                                        Spiral_builder::UH2::UH2_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method22;
                            }
                        }
                    }
                });
            }
        }
        pub fn method23(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: LrcPtr<Spiral_builder::UH0>,
        ) -> LrcPtr<Spiral_builder::UH0> {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v1_1.clone());
            '_method23: loop {
                break '_method23 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH0::UH0_0 => v1_1.get().clone(),
                    Spiral_builder::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Spiral_builder::UH0> =
                            match v0_1.get().clone().as_ref() {
                                Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                        let v1_1_temp: LrcPtr<Spiral_builder::UH0> =
                            LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                },
                                v1_1.get().clone(),
                            ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method23;
                    }
                });
            }
        }
        pub fn method20(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US7 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method20: loop {
                break '_method20 ({
                    let v55: Spiral_builder::US8 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US8::US8_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v21: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method21(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Spiral_builder::Mut4> =
                                LrcPtr::new(Spiral_builder::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method16(v27, v29.clone()) {
                                let v31: i32 = v29.l0.get().clone();
                                let v32: char = getCharAt(v26.clone(), v31);
                                v28.get_mut()[v31 as usize] = v32;
                                {
                                    let v33: i32 = v31 + 1_i32;
                                    v29.l0.set(v33);
                                    ()
                                }
                            }
                            {
                                let v35: List<char> = ofArray(v28.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method18(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                                    (Spiral_builder::method17())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US8::US8_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US8::US8_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Spiral_builder::US10 = match &v55 {
                        Spiral_builder::US8::US8_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                            Spiral_builder::US10::US10_0(
                                ofChar(v55_0_0.clone()),
                                v55_0_1.clone(),
                                v55_0_2.clone(),
                                v55_0_3.clone(),
                                v55_0_4.clone(),
                            )
                        }
                        Spiral_builder::US8::US8_1(v55_1_0) => {
                            Spiral_builder::US10::US10_1(v55_1_0.clone())
                        }
                    };
                    let v81: Spiral_builder::US10 = match &v67 {
                        Spiral_builder::US10::US10_0(
                            v67_0_0,
                            v67_0_1,
                            v67_0_2,
                            v67_0_3,
                            v67_0_4,
                        ) => v67.clone(),
                        _ => Spiral_builder::method22(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Spiral_builder::closure11((), arg10_0040)
                                    },
                                ),
                                LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                    Func1::new(
                                        move |arg10_0040_1: (
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        )| {
                                            Spiral_builder::closure12((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                )),
                            )),
                        ),
                    };
                    match &v81 {
                        Spiral_builder::US10::US10_0(
                            v81_0_0,
                            v81_0_1,
                            v81_0_2,
                            v81_0_3,
                            v81_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH0> = LrcPtr::new(
                                Spiral_builder::UH0::UH0_1(v81_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v81_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v81_0_2.clone();
                            let v3_temp: i32 = v81_0_3.clone();
                            let v4_temp: i32 = v81_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method20;
                        }
                        _ => Spiral_builder::US7::US7_0(
                            Spiral_builder::method23(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
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
        pub fn method24(v0_1: LrcPtr<Spiral_builder::UH0>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Spiral_builder::UH0::UH0_0 => v1_1.clone(),
                Spiral_builder::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Spiral_builder::method24(
                        match v0_1.as_ref() {
                            Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method25(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US7 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method25: loop {
                break '_method25 ({
                    let v55: Spiral_builder::US8 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US8::US8_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v14: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v21: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method21(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Spiral_builder::Mut4> =
                                LrcPtr::new(Spiral_builder::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method16(v27, v29.clone()) {
                                let v31: i32 = v29.l0.get().clone();
                                let v32: char = getCharAt(v26.clone(), v31);
                                v28.get_mut()[v31 as usize] = v32;
                                {
                                    let v33: i32 = v31 + 1_i32;
                                    v29.l0.set(v33);
                                    ()
                                }
                            }
                            {
                                let v35: List<char> = ofArray(v28.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method18(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                                    (Spiral_builder::method17())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US8::US8_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US8::US8_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Spiral_builder::US10 = match &v55 {
                        Spiral_builder::US8::US8_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4) => {
                            Spiral_builder::US10::US10_0(
                                ofChar(v55_0_0.clone()),
                                v55_0_1.clone(),
                                v55_0_2.clone(),
                                v55_0_3.clone(),
                                v55_0_4.clone(),
                            )
                        }
                        Spiral_builder::US8::US8_1(v55_1_0) => {
                            Spiral_builder::US10::US10_1(v55_1_0.clone())
                        }
                    };
                    match &v67 {
                        Spiral_builder::US10::US10_0(
                            v67_0_0,
                            v67_0_1,
                            v67_0_2,
                            v67_0_3,
                            v67_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH0> = LrcPtr::new(
                                Spiral_builder::UH0::UH0_1(v67_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v67_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v67_0_2.clone();
                            let v3_temp: i32 = v67_0_3.clone();
                            let v4_temp: i32 = v67_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method25;
                        }
                        _ => Spiral_builder::US7::US7_0(
                            Spiral_builder::method23(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
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
        pub fn method26(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method26: loop {
                break '_method26 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method26;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method14(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US7 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method14: loop {
                break '_method14 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v57: Spiral_builder::US8 = if v5 {
                        Spiral_builder::US8::US8_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v15: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v22: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some(length(v1_1.get().clone())),
                        );
                        if Spiral_builder::method15(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Spiral_builder::Mut4> =
                                LrcPtr::new(Spiral_builder::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method16(v28, v30.clone()) {
                                let v32: i32 = v30.l0.get().clone();
                                let v33: char = getCharAt(v27.clone(), v32);
                                v29.get_mut()[v32 as usize] = v33;
                                {
                                    let v34: i32 = v32 + 1_i32;
                                    v30.l0.set(v34);
                                    ()
                                }
                            }
                            {
                                let v36: List<char> = ofArray(v29.clone());
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Spiral_builder::method18(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                                                    (Spiral_builder::method17())(b0)(b1)
                                                },
                                            ),
                                            v36,
                                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US8::US8_0(
                                    v15,
                                    v22,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US8::US8_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v15,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v69: Spiral_builder::US10 = match &v57 {
                        Spiral_builder::US8::US8_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4) => {
                            Spiral_builder::method19(
                                ofChar(v57_0_0.clone()),
                                v57_0_1.clone(),
                                v57_0_2.clone(),
                                v57_0_3.clone(),
                                v57_0_4.clone(),
                            )
                        }
                        Spiral_builder::US8::US8_1(v57_1_0) => {
                            Spiral_builder::US10::US10_1(v57_1_0.clone())
                        }
                    };
                    let v292: Spiral_builder::US10 = match &v69 {
                        Spiral_builder::US10::US10_0(
                            v69_0_0,
                            v69_0_1,
                            v69_0_2,
                            v69_0_3,
                            v69_0_4,
                        ) => v69.clone(),
                        _ => {
                            let v131: Spiral_builder::US8 = if v5 {
                                Spiral_builder::US8::US8_1(sprintf!(
                                    "parsing.p_char / unexpected end of input / s: {:?}",
                                    (v2.get().clone(), v3.get().clone(), v4.get().clone())
                                ))
                            } else {
                                let v78: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if v78 == '\"' {
                                    let v86: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some(length(v1_1.get().clone())),
                                    );
                                    let v88: string = ofChar(v78);
                                    let v89: i32 = length(v88.clone());
                                    let v90: Array<char> = new_init(&'\u{0000}', v89);
                                    let v91: LrcPtr<Spiral_builder::Mut4> =
                                        LrcPtr::new(Spiral_builder::Mut4 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Spiral_builder::method16(v89, v91.clone()) {
                                        let v93: i32 = v91.l0.get().clone();
                                        let v94: char = getCharAt(v88.clone(), v93);
                                        v90.get_mut()[v93 as usize] = v94;
                                        {
                                            let v95: i32 = v93 + 1_i32;
                                            v91.l0.set(v95);
                                            ()
                                        }
                                    }
                                    {
                                        let v97: List<char> = ofArray(v90.clone());
                                        let patternInput_1:
                                                                 (LrcPtr<StringBuilder>,
                                                                  i32, i32) =
                                                             Spiral_builder::method18(foldBack(Func2::new(move
                                                                                                              |b0:
                                                                                                                   char,
                                                                                                               b1:
                                                                                                                   LrcPtr<Spiral_builder::UH1>|
                                                                                                              (Spiral_builder::method17())(b0)(b1)),
                                                                                               v97,
                                                                                               LrcPtr::new(Spiral_builder::UH1::UH1_0)),
                                                                                      v2.get().clone(),
                                                                                      v3.get().clone(),
                                                                                      v4.get().clone());
                                        Spiral_builder::US8::US8_0(
                                            v78,
                                            v86,
                                            patternInput_1.0.clone(),
                                            patternInput_1.1.clone(),
                                            patternInput_1.2.clone(),
                                        )
                                    }
                                } else {
                                    let v109: i32 = length(v1_1.get().clone());
                                    let v112: i32 =
                                        indexOf(v1_1.get().clone(), string("\n")) - 1_i32;
                                    Spiral_builder::US8::US8_1(sprintf!("{}\n{}\n",
                                                                                         sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                  '\"',
                                                                                                  v4.get().clone(),
                                                                                                  v3.get().clone(),
                                                                                                  v2.get().clone(),
                                                                                                  getSlice(v1_1.get().clone(),
                                                                                                           Some(0_i32),
                                                                                                           Some(if -2_i32
                                                                                                                       ==
                                                                                                                       v112
                                                                                                                   {
                                                                                                                    v109
                                                                                                                } else {
                                                                                                                    v112
                                                                                                                }))),
                                                                                         append(replicate(v3.get().clone()
                                                                                                              -
                                                                                                              1_i32,
                                                                                                          string(" ")),
                                                                                                string("^"))))
                                }
                            };
                            let v237: Spiral_builder::US10 = match &v131 {
                                Spiral_builder::US8::US8_0(
                                    v131_0_0,
                                    v131_0_1,
                                    v131_0_2,
                                    v131_0_3,
                                    v131_0_4,
                                ) => {
                                    let v136: i32 = v131_0_4.clone();
                                    let v135: i32 = v131_0_3.clone();
                                    let v134: LrcPtr<StringBuilder> = v131_0_2.clone();
                                    let v133: string = v131_0_1.clone();
                                    let v138: Spiral_builder::US7 = Spiral_builder::method20(
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        v133.clone(),
                                        v134.clone(),
                                        v135,
                                        v136,
                                    );
                                    let v155: Spiral_builder::US10 = match &v138 {
                                        Spiral_builder::US7::US7_0(
                                            v138_0_0,
                                            v138_0_1,
                                            v138_0_2,
                                            v138_0_3,
                                            v138_0_4,
                                        ) => {
                                            let v145: List<string> = Spiral_builder::method24(
                                                v138_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US10::US10_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v145 = v145.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v145 = v145.clone();
                                                                    move |i: i32| {
                                                                        item(i, v145.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v145.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v138_0_1.clone(),
                                                v138_0_2.clone(),
                                                v138_0_3.clone(),
                                                v138_0_4.clone(),
                                            )
                                        }
                                        Spiral_builder::US7::US7_1(v138_1_0) => {
                                            Spiral_builder::US10::US10_1(v138_1_0.clone())
                                        }
                                    };
                                    match &v155 {
                                        Spiral_builder::US10::US10_0(
                                            v155_0_0,
                                            v155_0_1,
                                            v155_0_2,
                                            v155_0_3,
                                            v155_0_4,
                                        ) => {
                                            let v160: i32 = v155_0_4.clone();
                                            let v159: i32 = v155_0_3.clone();
                                            let v158: LrcPtr<StringBuilder> = v155_0_2.clone();
                                            let v157: string = v155_0_1.clone();
                                            let v217: Spiral_builder::US8 = if string("")
                                                == v157.clone()
                                            {
                                                Spiral_builder::US8::US8_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
                                                                                                         (v158.clone(),
                                                                                                          v159,
                                                                                                          v160)))
                                            } else {
                                                let v164: char = getCharAt(v157.clone(), 0_i32);
                                                if v164 == '\"' {
                                                    let v172: string = getSlice(
                                                        v157.clone(),
                                                        Some(1_i32),
                                                        Some(length(v157.clone())),
                                                    );
                                                    let v174: string = ofChar(v164);
                                                    let v175: i32 = length(v174.clone());
                                                    let v176: Array<char> =
                                                        new_init(&'\u{0000}', v175);
                                                    let v177: LrcPtr<Spiral_builder::Mut4> =
                                                        LrcPtr::new(Spiral_builder::Mut4 {
                                                            l0: MutCell::new(0_i32),
                                                        });
                                                    while Spiral_builder::method16(
                                                        v175,
                                                        v177.clone(),
                                                    ) {
                                                        let v179: i32 = v177.l0.get().clone();
                                                        let v180: char =
                                                            getCharAt(v174.clone(), v179);
                                                        v176.get_mut()[v179 as usize] = v180;
                                                        {
                                                            let v181: i32 = v179 + 1_i32;
                                                            v177.l0.set(v181);
                                                            ()
                                                        }
                                                    }
                                                    {
                                                        let v183: List<char> =
                                                            ofArray(v176.clone());
                                                        let patternInput_2:
                                                                                     (LrcPtr<StringBuilder>,
                                                                                      i32,
                                                                                      i32) =
                                                                                 Spiral_builder::method18(foldBack(Func2::new(move
                                                                                                                                  |b0:
                                                                                                                                       char,
                                                                                                                                   b1:
                                                                                                                                       LrcPtr<Spiral_builder::UH1>|
                                                                                                                                  (Spiral_builder::method17())(b0)(b1)),
                                                                                                                   v183,
                                                                                                                   LrcPtr::new(Spiral_builder::UH1::UH1_0)),
                                                                                                          v158.clone(),
                                                                                                          v159,
                                                                                                          v160);
                                                        Spiral_builder::US8::US8_0(
                                                            v164,
                                                            v172,
                                                            patternInput_2.0.clone(),
                                                            patternInput_2.1.clone(),
                                                            patternInput_2.2.clone(),
                                                        )
                                                    }
                                                } else {
                                                    let v195: i32 = length(v157.clone());
                                                    let v198: i32 =
                                                        indexOf(v157.clone(), string("\n")) - 1_i32;
                                                    Spiral_builder::US8::US8_1(sprintf!("{}\n{}\n",
                                                                                                             sprintf!("parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                                                                                      '\"',
                                                                                                                      v160,
                                                                                                                      v159,
                                                                                                                      v158.clone(),
                                                                                                                      getSlice(v157.clone(),
                                                                                                                               Some(0_i32),
                                                                                                                               Some(if -2_i32
                                                                                                                                           ==
                                                                                                                                           v198
                                                                                                                                       {
                                                                                                                                        v195
                                                                                                                                    } else {
                                                                                                                                        v198
                                                                                                                                    }))),
                                                                                                             append(replicate(v159
                                                                                                                                  -
                                                                                                                                  1_i32,
                                                                                                                              string(" ")),
                                                                                                                    string("^"))))
                                                }
                                            };
                                            match &v217 {
                                                                 Spiral_builder::US8::US8_0(v217_0_0,
                                                                                            v217_0_1,
                                                                                            v217_0_2,
                                                                                            v217_0_3,
                                                                                            v217_0_4)
                                                                 =>
                                                                 Spiral_builder::US10::US10_0(v155_0_0.clone(),
                                                                                              v217_0_1.clone(),
                                                                                              v217_0_2.clone(),
                                                                                              v217_0_3.clone(),
                                                                                              v217_0_4.clone()),
                                                                 Spiral_builder::US8::US8_1(v217_1_0)
                                                                 =>
                                                                 Spiral_builder::US10::US10_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                                                                       v217_1_0.clone(),
                                                                                                       (v1_1.get().clone(),
                                                                                                        v2.get().clone(),
                                                                                                        v3.get().clone(),
                                                                                                        v4.get().clone()),
                                                                                                       (v133,
                                                                                                        v134,
                                                                                                        v135,
                                                                                                        v136),
                                                                                                       (v157,
                                                                                                        v158,
                                                                                                        v159,
                                                                                                        v160))),
                                                             }
                                        }
                                        _ => Spiral_builder::US10::US10_1(string(
                                            "between / expected content",
                                        )),
                                    }
                                }
                                Spiral_builder::US8::US8_1(v131_1_0) => {
                                    Spiral_builder::US10::US10_1(v131_1_0.clone())
                                }
                            };
                            match &v237 {
                                Spiral_builder::US10::US10_0(
                                    v237_0_0,
                                    v237_0_1,
                                    v237_0_2,
                                    v237_0_3,
                                    v237_0_4,
                                ) => v237.clone(),
                                _ => {
                                    let v249:
                                                         Spiral_builder::US10 =
                                                     Spiral_builder::method22(v1_1.get().clone(),
                                                                              v2.get().clone(),
                                                                              v3.get().clone(),
                                                                              v4.get().clone(),
                                                                              LrcPtr::new(Spiral_builder::UH2::UH2_1(Func1::new(move
                                                                                                                                    |arg10_0040:
                                                                                                                                         (string,
                                                                                                                                          LrcPtr<StringBuilder>,
                                                                                                                                          i32,
                                                                                                                                          i32)|
                                                                                                                                    Spiral_builder::closure11((),
                                                                                                                                                              arg10_0040)),
                                                                                                                     LrcPtr::new(Spiral_builder::UH2::UH2_1(Func1::new(move
                                                                                                                                                                           |arg10_0040_1:
                                                                                                                                                                                (string,
                                                                                                                                                                                 LrcPtr<StringBuilder>,
                                                                                                                                                                                 i32,
                                                                                                                                                                                 i32)|
                                                                                                                                                                           Spiral_builder::closure12((),
                                                                                                                                                                                                     arg10_0040_1)),
                                                                                                                                                            LrcPtr::new(Spiral_builder::UH2::UH2_0))))));
                                    let v260: Spiral_builder::US10 = match &v249 {
                                        Spiral_builder::US10::US10_0(
                                            v249_0_0,
                                            v249_0_1,
                                            v249_0_2,
                                            v249_0_3,
                                            v249_0_4,
                                        ) => Spiral_builder::US10::US10_0(
                                            string(""),
                                            v249_0_1.clone(),
                                            v249_0_2.clone(),
                                            v249_0_3.clone(),
                                            v249_0_4.clone(),
                                        ),
                                        Spiral_builder::US10::US10_1(v249_1_0) => {
                                            Spiral_builder::US10::US10_1(v249_1_0.clone())
                                        }
                                    };
                                    let v271: Spiral_builder::US7 = match &v260 {
                                        Spiral_builder::US10::US10_0(
                                            v260_0_0,
                                            v260_0_1,
                                            v260_0_2,
                                            v260_0_3,
                                            v260_0_4,
                                        ) => Spiral_builder::method25(
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                            v260_0_1.clone(),
                                            v260_0_2.clone(),
                                            v260_0_3.clone(),
                                            v260_0_4.clone(),
                                        ),
                                        Spiral_builder::US10::US10_1(v260_1_0) => {
                                            Spiral_builder::US7::US7_1(v260_1_0.clone())
                                        }
                                    };
                                    match &v271 {
                                        Spiral_builder::US7::US7_0(
                                            v271_0_0,
                                            v271_0_1,
                                            v271_0_2,
                                            v271_0_3,
                                            v271_0_4,
                                        ) => {
                                            let v278: List<string> = Spiral_builder::method24(
                                                v271_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US10::US10_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v278 = v278.clone();
                                                        move || {
                                                            map(
                                                                Func1::new({
                                                                    let v278 = v278.clone();
                                                                    move |i_1: i32| {
                                                                        item(i_1, v278.clone())
                                                                    }
                                                                }),
                                                                rangeNumeric(
                                                                    0_i32,
                                                                    1_i32,
                                                                    length_1(v278.clone()) - 1_i32,
                                                                ),
                                                            )
                                                        }
                                                    }))),
                                                ),
                                                v271_0_1.clone(),
                                                v271_0_2.clone(),
                                                v271_0_3.clone(),
                                                v271_0_4.clone(),
                                            )
                                        }
                                        Spiral_builder::US7::US7_1(v271_1_0) => {
                                            Spiral_builder::US10::US10_1(v271_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v292 {
                        Spiral_builder::US10::US10_0(
                            v292_0_0,
                            v292_0_1,
                            v292_0_2,
                            v292_0_3,
                            v292_0_4,
                        ) => {
                            let v301: i32 = v292_0_4.clone();
                            let v300: i32 = v292_0_3.clone();
                            let v299: LrcPtr<StringBuilder> = v292_0_2.clone();
                            let v298: string = v292_0_1.clone();
                            let v297: string = v292_0_0.clone();
                            let v303: i32 = Spiral_builder::method26(v298.clone(), 0_i32);
                            let v315: Spiral_builder::US11 = if 0_i32 == v303 {
                                Spiral_builder::US11::US11_1(string(
                                    "spaces1 / expected at least one space",
                                ))
                            } else {
                                Spiral_builder::US11::US11_0(
                                    getSlice(v298.clone(), Some(v303), Some(length(v298.clone()))),
                                    v299.clone(),
                                    v300,
                                    v301,
                                )
                            };
                            match &v315 {
                                Spiral_builder::US11::US11_0(
                                    v315_0_0,
                                    v315_0_1,
                                    v315_0_2,
                                    v315_0_3,
                                ) => {
                                    let v0_1_temp: LrcPtr<Spiral_builder::UH0> =
                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                            v297.clone(),
                                            v0_1.get().clone(),
                                        ));
                                    let v1_1_temp: string = v315_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v315_0_1.clone();
                                    let v3_temp: i32 = v315_0_2.clone();
                                    let v4_temp: i32 = v315_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method14;
                                }
                                _ => Spiral_builder::US7::US7_0(
                                    Spiral_builder::method23(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Spiral_builder::UH0::UH0_1(
                                            v297.clone(),
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        )),
                                    ),
                                    v298,
                                    v299,
                                    v300,
                                    v301,
                                ),
                            }
                        }
                        _ => Spiral_builder::US7::US7_0(
                            Spiral_builder::method23(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH0::UH0_0),
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
        pub fn method13(v0_1: string) -> Spiral_builder::US6 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v11: Spiral_builder::US7 = Spiral_builder::method14(
                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
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
                let v25: Spiral_builder::US12 = match &v11 {
                    Spiral_builder::US7::US7_0(v11_0_0, v11_0_1, v11_0_2, v11_0_3, v11_0_4) => {
                        Spiral_builder::US12::US12_0(toArray(Spiral_builder::method24(
                            v11_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Spiral_builder::US7::US7_1(v11_1_0) => {
                        Spiral_builder::US12::US12_1(v11_1_0.clone())
                    }
                };
                match &v25 {
                    Spiral_builder::US12::US12_0(v25_0_0) => {
                        Spiral_builder::US6::US6_0(v25_0_0.clone())
                    }
                    Spiral_builder::US12::US12_1(v25_1_0) => {
                        Spiral_builder::US6::US6_1(v25_1_0.clone())
                    }
                }
            }
        }
        pub fn method27() -> string {
            string("path")
        }
        pub fn method29() -> string {
            let _v0: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v4: std::path::PathBuf = v2.unwrap();
            let v6: std::path::Display = v4.display();
            let _v7: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v6);
                _v7.set(Some(x))
            }
            {
                let v17: std::string::String = match &_v7.get().clone() {
                    None => panic!("{}", string("base.run_target / _v7=None"),),
                    Some(_v7_0_0) => _v7_0_0.clone(),
                };
                {
                    let x_2: string = fable_library_rust::String_::fromString(v17);
                    _v0.set(Some(x_2))
                }
                match &_v0.get().clone() {
                    None => panic!("{}", string("base.run_target / _v0=None"),),
                    Some(_v0_0_0) => _v0_0_0.clone(),
                }
            }
        }
        pub fn method32(v0_1: string) -> string {
            v0_1
        }
        pub fn method31(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Spiral_builder::method32(v0_1))
        }
        pub fn method30(v0_1: string, v1_1: string) -> string {
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
                let v27: std::string::String = match &_v17.get().clone() {
                    None => panic!("{}", string("base.run_target / _v17=None"),),
                    Some(_v17_0_0) => _v17_0_0.clone(),
                };
                {
                    let x_2: string = fable_library_rust::String_::fromString(v27);
                    _v2.set(Some(x_2))
                }
                match &_v2.get().clone() {
                    None => panic!("{}", string("base.run_target / _v2=None"),),
                    Some(_v2_0_0) => _v2_0_0.clone(),
                }
            }
        }
        pub fn method35(v0_1: string) -> string {
            v0_1
        }
        pub fn method36() -> string {
            string("")
        }
        pub fn method37(v0_1: string) -> string {
            v0_1
        }
        pub fn method38() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method39(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method40(v0_1: string) -> string {
            v0_1
        }
        pub fn method34(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: string = Spiral_builder::method35(v0_1);
            let v4: &str = &*v2.clone();
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            {
                let x_6: string = if v8.exists() == false {
                    let v12: string = Spiral_builder::method29();
                    let v13: string = Spiral_builder::method30(v12.clone(), v2.clone());
                    let v14: string = Spiral_builder::method36();
                    let _v15: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let v16: string = Spiral_builder::method37(v13);
                    let v19: Result<regex::Regex, regex::Error> =
                        regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                    let v21: regex::Regex = v19.unwrap();
                    let v23: std::borrow::Cow<str> = v21.replace_all(&v16, &*v14);
                    let v25: std::string::String = String::from(v23);
                    {
                        let x: string = fable_library_rust::String_::fromString(v25);
                        _v15.set(Some(x))
                    }
                    {
                        let v34: string = match &_v15.get().clone() {
                            None => panic!("{}", string("base.run_target / _v15=None"),),
                            Some(_v15_0_0) => _v15_0_0.clone(),
                        };
                        let v39: Array<string> = split(
                            replace(
                                sprintf!(
                                    "{}{}",
                                    toLower(ofChar(getCharAt(v34.clone(), 0_i32))),
                                    getSlice(v34, Some(1_i32), None::<i32>)
                                ),
                                string("\\"),
                                string("/"),
                            ),
                            string("/"),
                            -1_i32,
                            0_i32,
                        );
                        let v41: i32 = count_2(v39.clone());
                        let v42: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(0_i32),
                            l2: MutCell::new(new_empty::<string>()),
                        });
                        while Spiral_builder::method39(v41, v42.clone()) {
                            let v44: i32 = v42.l0.get().clone();
                            let v47: i32 = v44.wrapping_neg() + v41 - 1_i32;
                            let matchValue: i32 = v42.l1.get().clone();
                            let v49: Array<string> = v42.l2.get().clone();
                            let v48: i32 = matchValue;
                            let v50: string = v39[v47].clone();
                            let patternInput_1: (i32, Array<string>) =
                                if string("..") == v50.clone() {
                                    (v48 + 1_i32, v49.clone())
                                } else {
                                    if string(".") == v50.clone() {
                                        (v48, v49.clone())
                                    } else {
                                        if 0_i32 == v48 {
                                            if endsWith(v50.clone(), string(":"), false) {
                                                let v58: Array<string> = new_array(&[sprintf!(
                                                    "{}:",
                                                    getCharAt(v12.clone(), 0_i32)
                                                )]);
                                                let v59: i32 = count_2(v58.clone());
                                                let v61: i32 = v59 + count_2(v49.clone());
                                                let v62: Array<string> = new_init(&string(""), v61);
                                                let v63: LrcPtr<Spiral_builder::Mut4> =
                                                    LrcPtr::new(Spiral_builder::Mut4 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Spiral_builder::method16(v61, v63.clone()) {
                                                    let v65: i32 = v63.l0.get().clone();
                                                    let v70: string = if v65 < v59 {
                                                        v58[v65].clone()
                                                    } else {
                                                        let v68: i32 = v65 - v59;
                                                        v49[v68].clone()
                                                    };
                                                    v62.get_mut()[v65 as usize] = v70;
                                                    {
                                                        let v71: i32 = v65 + 1_i32;
                                                        v63.l0.set(v71);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v62.clone())
                                            } else {
                                                let v72: Array<string> = new_array(&[v50]);
                                                let v73: i32 = count_2(v72.clone());
                                                let v75: i32 = v73 + count_2(v49.clone());
                                                let v76: Array<string> = new_init(&string(""), v75);
                                                let v77: LrcPtr<Spiral_builder::Mut4> =
                                                    LrcPtr::new(Spiral_builder::Mut4 {
                                                        l0: MutCell::new(0_i32),
                                                    });
                                                while Spiral_builder::method16(v75, v77.clone()) {
                                                    let v79: i32 = v77.l0.get().clone();
                                                    let v84: string = if v79 < v73 {
                                                        v72[v79].clone()
                                                    } else {
                                                        let v82: i32 = v79 - v73;
                                                        v49[v82].clone()
                                                    };
                                                    v76.get_mut()[v79 as usize] = v84;
                                                    {
                                                        let v85: i32 = v79 + 1_i32;
                                                        v77.l0.set(v85);
                                                        ()
                                                    }
                                                }
                                                (0_i32, v76.clone())
                                            }
                                        } else {
                                            (v48 - 1_i32, v49.clone())
                                        }
                                    }
                                };
                            let v95: i32 = v44 + 1_i32;
                            v42.l0.set(v95);
                            v42.l1.set(patternInput_1.0.clone());
                            v42.l2.set(patternInput_1.1.clone());
                            ()
                        }
                        {
                            let matchValue_2: i32 = v42.l1.get().clone();
                            let v97: Array<string> = v42.l2.get().clone();
                            let v98: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                                let v97 = v97.clone();
                                move || {
                                    map(
                                        Func1::new({
                                            let v97 = v97.clone();
                                            move |i: i32| v97[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v97.clone()) - 1_i32),
                                    )
                                }
                            }));
                            let _v99: MutCell<Option<char>> = MutCell::new(None::<char>);
                            {
                                let x_2: char = std::path::MAIN_SEPARATOR;
                                _v99.set(Some(x_2))
                            }
                            join(
                                ofChar(match &_v99.get().clone() {
                                    None => panic!("{}", string("base.run_target / _v99=None"),),
                                    Some(_v99_0_0) => _v99_0_0.clone(),
                                }),
                                toArray_1(v98),
                            )
                        }
                    }
                } else {
                    let v114: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v2);
                    let v116: std::path::PathBuf = v114.unwrap();
                    let v118: std::path::Display = v116.display();
                    let _v119: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_4: std::string::String = format!("{}", v118);
                        _v119.set(Some(x_4))
                    }
                    {
                        let v129: std::string::String = match &_v119.get().clone() {
                            None => panic!("{}", string("base.run_target / _v119=None"),),
                            Some(_v119_0_0) => _v119_0_0.clone(),
                        };
                        fable_library_rust::String_::fromString(v129)
                    }
                };
                _v1.set(Some(x_6))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method33(v0_1: string) -> string {
            let v1_1: string = Spiral_builder::method34(v0_1);
            let v2: string = Spiral_builder::method36();
            let _v3: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v4: string = Spiral_builder::method37(v1_1);
            let v7: Result<regex::Regex, regex::Error> =
                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
            let v9: regex::Regex = v7.unwrap();
            let v11: std::borrow::Cow<str> = v9.replace_all(&v4, &*v2);
            let v13: std::string::String = String::from(v11);
            {
                let x: string = fable_library_rust::String_::fromString(v13);
                _v3.set(Some(x))
            }
            {
                let v22: string = match &_v3.get().clone() {
                    None => panic!("{}", string("base.run_target / _v3=None"),),
                    Some(_v3_0_0) => _v3_0_0.clone(),
                };
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v22.clone(), 0_i32))),
                        getSlice(v22, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
        pub fn method28(v0_1: string) -> string {
            Spiral_builder::method33(Spiral_builder::method30(Spiral_builder::method29(), v0_1))
        }
        pub fn closure13(unitVar: (), v0_1: std::string::String) -> string {
            Spiral_builder::method28(fable_library_rust::String_::fromString(v0_1))
        }
        pub fn method41() -> string {
            string("retries")
        }
        pub fn method42() -> string {
            string("working-directory")
        }
        pub fn method45(
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
        pub fn method47() -> (string, string) {
            (string(""), string(""))
        }
        pub fn method48(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Spiral_builder::UH1>,
            v3: Spiral_builder::US15,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US15> = MutCell::new(v3.clone());
            '_method48: loop {
                break '_method48 (if let Spiral_builder::UH1::UH1_1(v2_1_0, v2_1_1) =
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
                            let v3_temp: Spiral_builder::US15 =
                                Spiral_builder::US15::US15_1(Spiral_builder::US16::US16_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method48;
                        } else {
                            match &v3.get().clone() {
                                Spiral_builder::US15::US15_1(v3_1_0) => {
                                    if let Spiral_builder::US16::US16_0 = v3_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US15 =
                                            Spiral_builder::US15::US15_1(
                                                Spiral_builder::US16::US16_1,
                                            );
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method48;
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 =
                                                Spiral_builder::US15::US15_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        }
                                    }
                                }
                                Spiral_builder::US15::US15_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US15 =
                                            Spiral_builder::US15::US15_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method48;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US15 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method48;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                    let v3_temp: Spiral_builder::US15 =
                                        Spiral_builder::US15::US15_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method48;
                                }
                            }
                        }
                    } else {
                        if '\'' == v4 {
                            if v1_1.get().clone() == string("") {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                let v3_temp: Spiral_builder::US15 =
                                    Spiral_builder::US15::US15_1(Spiral_builder::US16::US16_0);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                continue '_method48;
                            } else {
                                match &v3.get().clone() {
                                    Spiral_builder::US15::US15_1(v3_1_0) => {
                                        if let Spiral_builder::US16::US16_0 = v3_1_0 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 =
                                                Spiral_builder::US15::US15_1(
                                                    Spiral_builder::US16::US16_1,
                                                );
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        } else {
                                            if ' ' == v4 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string = v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v5.clone();
                                                let v3_temp: Spiral_builder::US15 =
                                                    Spiral_builder::US15::US15_2;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method48;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string =
                                                    sprintf!("{}{}", v1_1.get().clone(), v4);
                                                let v2_temp: LrcPtr<Spiral_builder::UH1> =
                                                    v5.clone();
                                                let v3_temp: Spiral_builder::US15 =
                                                    v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method48;
                                            }
                                        }
                                    }
                                    Spiral_builder::US15::US15_0 => {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 =
                                                Spiral_builder::US15::US15_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        }
                                    }
                                    _ => {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US15 =
                                            Spiral_builder::US15::US15_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method48;
                                    }
                                }
                            }
                        } else {
                            match &v3.get().clone() {
                                Spiral_builder::US15::US15_1(v3_1_0) => {
                                    if let Spiral_builder::US16::US16_0 = v3_1_0 {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{} ", v1_1.get().clone());
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 =
                                                Spiral_builder::US15::US15_1(
                                                    Spiral_builder::US16::US16_0,
                                                );
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        }
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 =
                                                Spiral_builder::US15::US15_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                            let v3_temp: Spiral_builder::US15 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method48;
                                        }
                                    }
                                }
                                Spiral_builder::US15::US15_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                        let v3_temp: Spiral_builder::US15 =
                                            Spiral_builder::US15::US15_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method48;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Spiral_builder::UH1> = v5;
                                        let v3_temp: Spiral_builder::US15 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method48;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH1> = v5.clone();
                                    let v3_temp: Spiral_builder::US15 =
                                        Spiral_builder::US15::US15_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method48;
                                }
                            }
                        }
                    }
                } else {
                    match &v3.get().clone() {
                        Spiral_builder::US15::US15_1(v3_1_0) => {
                            if let Spiral_builder::US16::US16_0 = v3_1_0 {
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
                        Spiral_builder::US15::US15_0 => (
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
        pub fn method46(v0_1: string) -> (string, string) {
            let patternInput: (string, string) = Spiral_builder::method47();
            let v3: i32 = length(v0_1.clone());
            let v4: Array<char> = new_init(&'\u{0000}', v3);
            let v5: LrcPtr<Spiral_builder::Mut4> = LrcPtr::new(Spiral_builder::Mut4 {
                l0: MutCell::new(0_i32),
            });
            while Spiral_builder::method16(v3, v5.clone()) {
                let v7: i32 = v5.l0.get().clone();
                let v8: char = getCharAt(v0_1.clone(), v7);
                v4.get_mut()[v7 as usize] = v8;
                {
                    let v9: i32 = v7 + 1_i32;
                    v5.l0.set(v9);
                    ()
                }
            }
            {
                let v11: List<char> = ofArray(v4.clone());
                Spiral_builder::method48(
                    patternInput.1.clone(),
                    patternInput.0.clone(),
                    foldBack(
                        Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH1>| {
                            (Spiral_builder::method17())(b0)(b1)
                        }),
                        v11,
                        LrcPtr::new(Spiral_builder::UH1::UH1_0),
                    ),
                    Spiral_builder::US15::US15_0,
                )
            }
        }
        pub fn closure14(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options")
        }
        pub fn closure15(
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
            append(
                sprintf!("file_name: {} / arguments: {:?}", v7, v8),
                sprintf!(
                    " / options: {:?} / {}",
                    (v0_1, v1_1, v2, v3, v4, v5, v6),
                    Spiral_builder::closure6((), ())
                ),
            )
        }
        pub fn closure16(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method49() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Spiral_builder::closure16((), v))
        }
        pub fn closure17(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Spiral_builder::US17 {
            Spiral_builder::US17::US17_0(v0_1)
        }
        pub fn method50() -> Func1<
            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
            Spiral_builder::US17,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Spiral_builder::closure17((), v)
                },
            )
        }
        pub fn closure18(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US17 {
            Spiral_builder::US17::US17_1(v0_1)
        }
        pub fn method51() -> Func1<std::string::String, Spiral_builder::US17> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure18((), v))
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure20(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn method52(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn closure21(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US19 {
            Spiral_builder::US19::US19_0(v0_1)
        }
        pub fn method53() -> Func1<std::string::String, Spiral_builder::US19> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure21((), v))
        }
        pub fn closure22(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US19 {
            Spiral_builder::US19::US19_1(v0_1)
        }
        pub fn method54() -> Func1<std::string::String, Spiral_builder::US19> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure22((), v))
        }
        pub fn closure23(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.stdio_line")
        }
        pub fn closure24(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("e: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn closure25(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn method55(
            v0_1: std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>>
        {
            v0_1
        }
        pub fn closure26(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method56(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Spiral_builder::closure26((), v)
            })
        }
        pub fn method57(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn method58(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> {
            v0_1
        }
        pub fn method59(
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method60(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method61(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure27(unitVar: (), v0_1: std::process::Output) -> Spiral_builder::US22 {
            Spiral_builder::US22::US22_0(v0_1)
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US22 {
            Spiral_builder::US22::US22_1(v0_1)
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / output error")
        }
        pub fn closure30(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn method62(
            v0_1: std::sync::Arc<
                std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
            >,
        ) -> std::sync::Arc<
            std::sync::Mutex<std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>>,
        > {
            v0_1
        }
        pub fn closure31(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / result")
        }
        pub fn closure32(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            append(
                sprintf!("exit_code: {}", v0_1),
                sprintf!(
                    " / std_trace.Length: {} / {}",
                    length(v1_1),
                    Spiral_builder::closure6((), ())
                ),
            )
        }
        pub fn closure33(
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
        pub fn method64() -> Func0<string> {
            Func0::new(move || Spiral_builder::closure6((), ()))
        }
        pub fn closure35(v0_1: string, unitVar: ()) -> string {
            v0_1
        }
        pub fn closure34(
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
                let v39: Arc<Async<()>> = match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                };
                let _v40: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v40.set(Some(()));
                match &_v40.get().clone() {
                    None => panic!("{}", string("base.run_target / _v40=None"),),
                    Some(_v40_0_0) => _v40_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure36(
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
                let v40: Arc<Async<()>> = match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                };
                let _v41: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v41.set(Some(()));
                match &_v41.get().clone() {
                    None => panic!("{}", string("base.run_target / _v41=None"),),
                    Some(_v41_0_0) => _v41_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure37(v0_1: (), unitVar: ()) {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x: bool = unbox::<bool>(&defaultOf());
                _v1.set(Some(x))
            }
            if match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            } == false
            {
                let _v10: MutCell<Option<()>> = MutCell::new(None::<()>);
                defaultOf::<()>();
                _v10.set(Some(()));
                match &_v10.get().clone() {
                    None => panic!("{}", string("base.run_target / _v10=None"),),
                    Some(_v10_0_0) => _v10_0_0.clone(),
                }
                ()
            }
        }
        pub fn closure38(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn closure39(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method63(
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
            match &_v7.get().clone() {
                None => panic!("{}", string("base.run_target / _v7=None"),),
                Some(_v7_0_0) => _v7_0_0.clone(),
            }
        }
        pub fn method44(
            v0_1: Option<CancellationToken>,
            v1_1: string,
            v2: Array<(string, string)>,
            v3: Option<Func1<(bool, string, i32), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let _v7: MutCell<Option<(i32, string)>> = MutCell::new(None::<(i32, string)>);
            let patternInput: (string, string) =
                Spiral_builder::method46(Spiral_builder::method45(
                    v0_1.clone(),
                    v1_1.clone(),
                    v2.clone(),
                    v3.clone(),
                    v4.clone(),
                    v5,
                    v6.clone(),
                ));
            let v9: string = patternInput.0.clone();
            let v11: Spiral_builder::US6 = Spiral_builder::method13(patternInput.1.clone());
            let v17: Array<string> = match &v11 {
                Spiral_builder::US6::US6_0(v11_0_0) => v11_0_0.clone(),
                Spiral_builder::US6::US6_1(v11_1_0) => panic!(
                    "{}",
                    sprintf!("resultm.get / Result value was Error: {}", v11_1_0.clone()),
                ),
            };
            let v19: Vec<string> = v17.to_vec();
            let v21: bool = true;
            let _result: Vec<_> = v19
                .into_iter()
                .map(|x| {
                    //;
                    let v23: string = x;
                    let v25: &str = &*v23;
                    let v27: std::string::String = String::from(v25);
                    let v29: bool = true;
                    v27
                })
                .collect::<Vec<_>>();
            let v31: Vec<std::string::String> = _result;
            Spiral_builder::method5(
                Spiral_builder::US0::US0_1,
                Func0::new(move || Spiral_builder::closure14((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v31 = v31.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    let v9 = v9.clone();
                    move || {
                        Spiral_builder::closure15(
                            v0_1.clone(),
                            v1_1.clone(),
                            v2.clone(),
                            v3.clone(),
                            v4.clone(),
                            v5,
                            v6.clone(),
                            v9.clone(),
                            v31.clone(),
                            (),
                        )
                    }
                }),
            );
            {
                let _v35: MutCell<Option<LrcPtr<(i32, string)>>> =
                    MutCell::new(None::<LrcPtr<(i32, string)>>);
                {
                    let x_12: LrcPtr<(i32, string)> = (Func0::new({
                        let v2 = v2.clone();
                        let v31 = v31.clone();
                        let v4 = v4.clone();
                        let v5 = v5.clone();
                        let v6 = v6.clone();
                        let v9 = v9.clone();
                        move || {
                            let v37: std::process::Command =
                                std::process::Command::new(&*v9.clone());
                            let v39: bool = true;
                            let mut v37 = v37;
                            let v41: &mut std::process::Command =
                                std::process::Command::args(&mut v37, &*v31.clone());
                            let v43: std::process::Stdio = std::process::Stdio::piped();
                            let v45: &mut std::process::Command =
                                std::process::Command::stdout(v41, std::process::Stdio::piped());
                            let v47: std::process::Stdio = std::process::Stdio::piped();
                            let v49: &mut std::process::Command =
                                std::process::Command::stderr(v45, std::process::Stdio::piped());
                            let v51: std::process::Stdio = std::process::Stdio::piped();
                            let v53: &mut std::process::Command =
                                std::process::Command::stdin(v49, std::process::Stdio::piped());
                            let _v54: LrcPtr<MutCell<Option<Spiral_builder::US3>>> =
                                refCell(None::<Spiral_builder::US3>);
                            {
                                let x_2: Option<Spiral_builder::US3> = match &v6 {
                                    None => None::<Spiral_builder::US3>,
                                    Some(v6_0_0) => {
                                        let x: string = v6_0_0.clone();
                                        Some((Func0::new({
                                            let x = x.clone();
                                            move || Spiral_builder::US3::US3_0(x.clone())
                                        }))())
                                    }
                                };
                                _v54.set(x_2)
                            }
                            {
                                let v59: Spiral_builder::US3 =
                                    defaultValue(Spiral_builder::US3::US3_1, _v54.get().clone());
                                let v64: &mut std::process::Command = match &v59 {
                                    Spiral_builder::US3::US3_0(v59_0_0) => {
                                        std::process::Command::current_dir(
                                            v53,
                                            &*match &v59 {
                                                Spiral_builder::US3::US3_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                        )
                                    }
                                    _ => v53,
                                };
                                let v82: &mut std::process::Command =
                                    if count_2(v2.clone()) as u64 == 0_u64 {
                                        v64
                                    } else {
                                        let v68: Vec<(string, string)> = v2.clone().to_vec();
                                        let v70: bool = true;
                                        let _result = v68.into_iter().fold(v64, |acc, x| {
                                            //;
                                            let v72: &mut std::process::Command = acc;
                                            let patternInput_1: (string, string) = x;
                                            let v77: &mut std::process::Command =
                                                std::process::Command::env(
                                                    v72,
                                                    &*patternInput_1.0.clone(),
                                                    &*patternInput_1.1.clone(),
                                                );
                                            let v79: bool = true;
                                            v77
                                        });
                                        _result
                                    };
                                let v84: Result<std::process::Child, std::io::Error> =
                                    std::process::Command::spawn(v82);
                                let v85 = Spiral_builder::method49();
                                let v87: Result<std::process::Child, std::string::String> =
                                    v84.map_err(|x| v85(x));
                                let v89: bool = true;
                                let _result = v87.map(|x| {
                                    //;
                                    let v91: std::process::Child = x;
                                    let v94: std::sync::Mutex<Option<std::process::Child>> =
                                        std::sync::Mutex::new(Some(v91));
                                    let v96: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = std::sync::Arc::new(v94);
                                    let v98: bool = true;
                                    v96
                                });
                                let v100: Result<
                                    std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                                    std::string::String,
                                > = _result;
                                let v101 = Spiral_builder::method50();
                                let v102 = Spiral_builder::method51();
                                let v104: Spiral_builder::US17 = match v100 {
                                    Ok(x) => v101(x),
                                    Err(e) => v102(e),
                                };
                                let patternInput_3: (
                                    i32,
                                    Spiral_builder::US5,
                                    Spiral_builder::US18,
                                ) = match &v104 {
                                    Spiral_builder::US17::US17_0(v104_0_0) => {
                                        let v105: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v104_0_0.clone();
                                        let v107: bool = true;
                                        let _result = (|| {
                                            //;
                                            let v108: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = Spiral_builder::method52(v105.clone());
                                            let v110: Result<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                >,
                                            > = v108.lock();
                                            let v112: std::sync::MutexGuard<
                                                Option<std::process::Child>,
                                            > = v110.unwrap();
                                            let v114: bool = true;
                                            let mut v112 = v112;
                                            let v116: &mut Option<std::process::Child> = &mut v112;
                                            let v118: Option<&mut std::process::Child> =
                                                v116.as_mut();
                                            let v120: &mut std::process::Child = v118.unwrap();
                                            let v122: &mut Option<std::process::ChildStdout> =
                                                &mut v120.stdout;
                                            let v124: Option<std::process::ChildStdout> =
                                                Option::take(v122);
                                            let v126: std::process::ChildStdout = v124.unwrap();
                                            let v128: bool = true;
                                            v126
                                        })();
                                        let v130: std::process::ChildStdout = _result;
                                        let v132: bool = true;
                                        let _result = (|| {
                                            //;
                                            let v133: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = Spiral_builder::method52(v105.clone());
                                            let v135: Result<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                >,
                                            > = v133.lock();
                                            let v137: std::sync::MutexGuard<
                                                Option<std::process::Child>,
                                            > = v135.unwrap();
                                            let v139: bool = true;
                                            let mut v137 = v137;
                                            let v141: &mut Option<std::process::Child> = &mut v137;
                                            let v143: Option<&mut std::process::Child> =
                                                v141.as_mut();
                                            let v145: &mut std::process::Child = v143.unwrap();
                                            let v147: &mut Option<std::process::ChildStderr> =
                                                &mut v145.stderr;
                                            let v149: Option<std::process::ChildStderr> =
                                                Option::take(v147);
                                            let v151: std::process::ChildStderr = v149.unwrap();
                                            let v153: bool = true;
                                            v151
                                        })();
                                        let v155: std::process::ChildStderr = _result;
                                        let v157: bool = true;
                                        let _result = (|| {
                                            //;
                                            let v158: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = Spiral_builder::method52(v105.clone());
                                            let v160: Result<
                                                std::sync::MutexGuard<Option<std::process::Child>>,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        Option<std::process::Child>,
                                                    >,
                                                >,
                                            > = v158.lock();
                                            let v162: std::sync::MutexGuard<
                                                Option<std::process::Child>,
                                            > = v160.unwrap();
                                            let v164: bool = true;
                                            let mut v162 = v162;
                                            let v166: &mut Option<std::process::Child> = &mut v162;
                                            let v168: Option<&mut std::process::Child> =
                                                v166.as_mut();
                                            let v170: &mut std::process::Child = v168.unwrap();
                                            let v172: &mut Option<std::process::ChildStdin> =
                                                &mut v170.stdin;
                                            let v174: Option<std::process::ChildStdin> =
                                                Option::take(v172);
                                            let v176: std::process::ChildStdin = v174.unwrap();
                                            let v179: std::sync::Mutex<
                                                Option<std::process::ChildStdin>,
                                            > = std::sync::Mutex::new(Some(v176));
                                            let v181: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::ChildStdin>>,
                                            > = std::sync::Arc::new(v179);
                                            let v183: bool = true;
                                            v181
                                        })();
                                        let v185: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = _result;
                                        let patternInput_2: (
                                            std::sync::mpsc::Sender<std::string::String>,
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        ) = {
                                            let (sender, receiver) = std::sync::mpsc::channel();
                                            (sender, std::sync::Arc::new(receiver))
                                        };
                                        let v187: std::sync::mpsc::Sender<std::string::String> =
                                            patternInput_2.0.clone();
                                        let v190: std::sync::Mutex<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = std::sync::Mutex::new(v187.clone());
                                        let v192: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = std::sync::Arc::new(v190);
                                        let v194: std::sync::Mutex<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = std::sync::Mutex::new(v187);
                                        let v196: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = std::sync::Arc::new(v194);
                                        let v198: std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        > = std::sync::Mutex::new(patternInput_2.1.clone());
                                        let v200: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::Arc<
                                                    std::sync::mpsc::Receiver<std::string::String>,
                                                >,
                                            >,
                                        > = std::sync::Arc::new(v198);
                                        let v202: bool = true;
                                        let __result = std::thread::spawn(move || {
                                            //;
                                            let v204: encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                                .utf8_passthru(true)
                                                .build(v130);
                                            let v206: std::io::BufReader<
                                                encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStdout,
                                                    Vec<u8>,
                                                >,
                                            > = std::io::BufReader::new(v204);
                                            let v208: std::io::Lines<
                                                std::io::BufReader<
                                                    encoding_rs_io::DecodeReaderBytes<
                                                        std::process::ChildStdout,
                                                        Vec<u8>,
                                                    >,
                                                >,
                                            > = std::io::BufRead::lines(v206);
                                            let v210: bool = true;
                                            let mut v208 = v208;
                                            let _result = v208.try_for_each(|x| {
                                                //;
                                                let v212: Result<
                                                    std::string::String,
                                                    std::io::Error,
                                                > = x;
                                                let v214: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                > = v192.clone();
                                                let v215 = Spiral_builder::method49();
                                                let v217: Result<
                                                    std::string::String,
                                                    std::string::String,
                                                > = v212.map_err(|x| v215(x));
                                                let v218 = Spiral_builder::method53();
                                                let v219 = Spiral_builder::method54();
                                                let v221: Spiral_builder::US19 = match v217 {
                                                    Ok(x) => v218(x),
                                                    Err(e) => v219(e),
                                                };
                                                let v254: std::string::String = match &v221 {
                                                    Spiral_builder::US19::US19_0(v221_0_0) => {
                                                        let v224: string =
                                                            fable_library_rust::String_::fromString(
                                                                v221_0_0.clone(),
                                                            );
                                                        let v226: &encoding_rs::Encoding =
                                                            encoding_rs::UTF_8;
                                                        let v228: std::borrow::Cow<[u8]> =
                                                            v226.encode(&*v224).0;
                                                        let v230: &[u8] = v228.as_ref();
                                                        let v232: Result<
                                                            &str,
                                                            std::str::Utf8Error,
                                                        > = std::str::from_utf8(v230);
                                                        let v234: &str = v232.unwrap();
                                                        let v236: std::string::String =
                                                            String::from(v234);
                                                        let v239: string = sprintf!(
                                                            "> {}",
                                                            fable_library_rust::String_::fromString(
                                                                v236.clone()
                                                            )
                                                        );
                                                        if v5 {
                                                            Spiral_builder::method5(
                                                                Spiral_builder::US0::US0_0,
                                                                Func0::new({
                                                                    let v239 = v239.clone();
                                                                    move || {
                                                                        Spiral_builder::closure25(
                                                                            v239.clone(),
                                                                            (),
                                                                        )
                                                                    }
                                                                }),
                                                                Func0::new(move || {
                                                                    Spiral_builder::closure6((), ())
                                                                }),
                                                            )
                                                        } else {
                                                            printfn!("{0}", v239.clone())
                                                        }
                                                        v236
                                                    }
                                                    Spiral_builder::US19::US19_1(v221_1_0) => {
                                                        let v244: std::string::String =
                                                            v221_1_0.clone();
                                                        Spiral_builder::method5(
                                                            Spiral_builder::US0::US0_4,
                                                            Func0::new(move || {
                                                                Spiral_builder::closure23((), ())
                                                            }),
                                                            Func0::new({
                                                                let v244 = v244.clone();
                                                                move || {
                                                                    Spiral_builder::closure24(
                                                                        v244.clone(),
                                                                        (),
                                                                    )
                                                                }
                                                            }),
                                                        );
                                                        {
                                                            let v248: string = sprintf!(
                                                                "\u{001b}[4;7m{}\u{001b}[0m",
                                                                v244.clone()
                                                            );
                                                            let v250: &str = &*v248;
                                                            String::from(v250)
                                                        }
                                                    }
                                                };
                                                let v255: std::sync::Arc<
                                                    std::sync::Mutex<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                > = Spiral_builder::method55(v214);
                                                let v257: Result<
                                                    std::sync::MutexGuard<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                    std::sync::PoisonError<
                                                        std::sync::MutexGuard<
                                                            std::sync::mpsc::Sender<
                                                                std::string::String,
                                                            >,
                                                        >,
                                                    >,
                                                > = v255.lock();
                                                let v259: std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                > = v257.unwrap();
                                                let v261: &std::sync::mpsc::Sender<
                                                    std::string::String,
                                                > = &v259;
                                                let v263: Result<
                                                    (),
                                                    std::sync::mpsc::SendError<std::string::String>,
                                                > = v261.send(v254);
                                                let v264 = Spiral_builder::method56();
                                                let v266: Result<(), std::string::String> =
                                                    v263.map_err(|x| v264(x));
                                                let v268: _ = v266;
                                                let v270: bool = true;
                                                v268
                                            }); //;
                                            let v273: Result<(), string> = Spiral_builder::method57(
                                                _result.map_err(|x| x.into()),
                                            );
                                            let v277: string = string("v273 });  //");
                                            v273
                                        }); //;
                                        {
                                            let v279: std::thread::JoinHandle<Result<(), string>> =
                                                __result;
                                            let v281: bool = true;
                                            let __result = std::thread::spawn(move || {
                                                //;
                                                let v283: encoding_rs_io::DecodeReaderBytes<
                                                    std::process::ChildStderr,
                                                    Vec<u8>,
                                                > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                                    .utf8_passthru(true)
                                                    .build(v155);
                                                let v285: std::io::BufReader<
                                                    encoding_rs_io::DecodeReaderBytes<
                                                        std::process::ChildStderr,
                                                        Vec<u8>,
                                                    >,
                                                > = std::io::BufReader::new(v283);
                                                let v287: std::io::Lines<
                                                    std::io::BufReader<
                                                        encoding_rs_io::DecodeReaderBytes<
                                                            std::process::ChildStderr,
                                                            Vec<u8>,
                                                        >,
                                                    >,
                                                > = std::io::BufRead::lines(v285);
                                                let v289: bool = true;
                                                let mut v287 = v287;
                                                let _result = v287.try_for_each(|x| { //;
                                                                    let v291:
                                                                            Result<std::string::String,
                                                                                   std::io::Error> =
                                                                        x;
                                                                    let v293:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        v196.clone();
                                                                    let v294 =
                                                                        Spiral_builder::method49();
                                                                    let v296:
                                                                            Result<std::string::String,
                                                                                   std::string::String> =
                                                                        v291.map_err(|x| v294(x));
                                                                    let v297 =
                                                                        Spiral_builder::method53();
                                                                    let v298 =
                                                                        Spiral_builder::method54();
                                                                    let v300:
                                                                            Spiral_builder::US19 =
                                                                        match v296 { Ok(x) => v297(x), Err(e) => v298(e) };
                                                                    let v338:
                                                                            std::string::String =
                                                                        match &v300
                                                                            {
                                                                            Spiral_builder::US19::US19_0(v300_0_0)
                                                                            =>
                                                                            {
                                                                                let v303:
                                                                                        string =
                                                                                    fable_library_rust::String_::fromString(v300_0_0.clone());
                                                                                let v305:
                                                                                        &encoding_rs::Encoding =
                                                                                    encoding_rs::UTF_8;
                                                                                let v307:
                                                                                        std::borrow::Cow<[u8]> =
                                                                                    v305.encode(&*v303).0;
                                                                                let v309:
                                                                                        &[u8] =
                                                                                    v307.as_ref();
                                                                                let v311:
                                                                                        Result<&str,
                                                                                               std::str::Utf8Error> =
                                                                                    std::str::from_utf8(v309);
                                                                                let v313:
                                                                                        &str =
                                                                                    v311.unwrap();
                                                                                let v315:
                                                                                        std::string::String =
                                                                                    String::from(v313);
                                                                                let v318:
                                                                                        string =
                                                                                    sprintf!("! {}",
                                                                                             fable_library_rust::String_::fromString(v315.clone()));
                                                                                if v5
                                                                                   {
                                                                                    Spiral_builder::method5(Spiral_builder::US0::US0_0,
                                                                                                            Func0::new({
                                                                                                                           let v318
                                                                                                                               =
                                                                                                                               v318.clone();
                                                                                                                           move
                                                                                                                               ||
                                                                                                                               Spiral_builder::closure25(v318.clone(),
                                                                                                                                                         ())
                                                                                                                       }),
                                                                                                            Func0::new(move
                                                                                                                           ||
                                                                                                                           Spiral_builder::closure6((),
                                                                                                                                                    ())))
                                                                                } else {
                                                                                    printfn!("{0}",
                                                                                             v318.clone())
                                                                                }
                                                                                {
                                                                                    let v323:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v315);
                                                                                    let v325:
                                                                                            &str =
                                                                                        &*v323;
                                                                                    String::from(v325)
                                                                                }
                                                                            }
                                                                            Spiral_builder::US19::US19_1(v300_1_0)
                                                                            =>
                                                                            {
                                                                                let v328:
                                                                                        std::string::String =
                                                                                    v300_1_0.clone();
                                                                                Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                        Func0::new(move
                                                                                                                       ||
                                                                                                                       Spiral_builder::closure23((),
                                                                                                                                                 ())),
                                                                                                        Func0::new({
                                                                                                                       let v328
                                                                                                                           =
                                                                                                                           v328.clone();
                                                                                                                       move
                                                                                                                           ||
                                                                                                                           Spiral_builder::closure24(v328.clone(),
                                                                                                                                                     ())
                                                                                                                   }));
                                                                                {
                                                                                    let v332:
                                                                                            string =
                                                                                        sprintf!("\u{001b}[4;7m{}\u{001b}[0m",
                                                                                                 v328.clone());
                                                                                    let v334:
                                                                                            &str =
                                                                                        &*v332;
                                                                                    String::from(v334)
                                                                                }
                                                                            }
                                                                        };
                                                                    let v339:
                                                                            std::sync::Arc<std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>> =
                                                                        Spiral_builder::method55(v293);
                                                                    let v341:
                                                                            Result<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>,
                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>>>> =
                                                                        v339.lock();
                                                                    let v343:
                                                                            std::sync::MutexGuard<std::sync::mpsc::Sender<std::string::String>> =
                                                                        v341.unwrap();
                                                                    let v345:
                                                                            &std::sync::mpsc::Sender<std::string::String> =
                                                                        &v343;
                                                                    let v347:
                                                                            Result<(),
                                                                                   std::sync::mpsc::SendError<std::string::String>> =
                                                                        v345.send(v338);
                                                                    let v348 =
                                                                        Spiral_builder::method56();
                                                                    let v350:
                                                                            Result<(),
                                                                                   std::string::String> =
                                                                        v347.map_err(|x| v348(x));
                                                                    let v352:
                                                                            _ =
                                                                        v350;
                                                                    let v354:
                                                                            bool =
                                                                        true; v352 }); //;
                                                let v357: Result<(), string> =
                                                    Spiral_builder::method57(
                                                        _result.map_err(|x| x.into()),
                                                    );
                                                let v359: string = string("v357 });  //");
                                                v357
                                            }); //;
                                            {
                                                let v361: std::thread::JoinHandle<
                                                    Result<(), string>,
                                                > = __result;
                                                let _v362: LrcPtr<
                                                    MutCell<Option<Spiral_builder::US20>>,
                                                > = refCell(None::<Spiral_builder::US20>);
                                                {
                                                    let x_5: Option<Spiral_builder::US20> =
                                                        match &v4 {
                                                            None => None::<Spiral_builder::US20>,
                                                            Some(v4_0_0) => {
                                                                let x_3 = v4_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_3 = x_3.clone();
                                                                    move || {
                                                                        Spiral_builder::US20::US20_0(
                                                                            x_3.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                    _v362.set(x_5)
                                                }
                                                {
                                                    let v367: Spiral_builder::US20 = defaultValue(
                                                        Spiral_builder::US20::US20_1,
                                                        _v362.get().clone(),
                                                    );
                                                    match &v367 {
                                                        Spiral_builder::US20::US20_0(v367_0_0) => {
                                                            let v369: std::sync::Arc<
                                                                std::sync::Mutex<
                                                                    Option<
                                                                        std::process::ChildStdin,
                                                                    >,
                                                                >,
                                                            > = Spiral_builder::method58(v185);
                                                            let v371:
                                                                                            Result<std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<Option<std::process::ChildStdin>>>> =
                                                                                        v369.lock();
                                                            let v373: std::sync::MutexGuard<
                                                                Option<std::process::ChildStdin>,
                                                            > = v371.unwrap();
                                                            let v375: bool = true;
                                                            let mut v373 = v373;
                                                            let v377: &mut Option<
                                                                std::process::ChildStdin,
                                                            > = &mut v373;
                                                            let v379: Option<
                                                                std::process::ChildStdin,
                                                            > = Option::take(v377);
                                                            let v381: bool = true;
                                                            let _result = v379.map(|x| {
                                                                //;
                                                                let v383: std::process::ChildStdin =
                                                                    x;
                                                                let v385: std::sync::Mutex<
                                                                    std::process::ChildStdin,
                                                                > = std::sync::Mutex::new(v383);
                                                                let v387: std::sync::Arc<
                                                                    std::sync::Mutex<
                                                                        std::process::ChildStdin,
                                                                    >,
                                                                > = std::sync::Arc::new(v385);
                                                                let v389: bool = true;
                                                                v387
                                                            });
                                                            let v391: Option<
                                                                std::sync::Arc<
                                                                    std::sync::Mutex<
                                                                        std::process::ChildStdin,
                                                                    >,
                                                                >,
                                                            > = _result;
                                                            let _v392: LrcPtr<
                                                                MutCell<
                                                                    Option<Spiral_builder::US21>,
                                                                >,
                                                            > = refCell(
                                                                None::<Spiral_builder::US21>,
                                                            );
                                                            {
                                                                let x_8: Option<
                                                                    Spiral_builder::US21,
                                                                > = match &v391 {
                                                                    None => {
                                                                        None::<Spiral_builder::US21>
                                                                    }
                                                                    Some(v391_0_0) => {
                                                                        let x_6:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        v391_0_0.clone();
                                                                        Some((Func0::new({
                                                                            let x_6 = x_6.clone();
                                                                            move || {
                                                                                Spiral_builder::US21::US21_0(x_6.clone())
                                                                            }
                                                                        }))(
                                                                        ))
                                                                    }
                                                                };
                                                                _v392.set(x_8)
                                                            }
                                                            {
                                                                let v397:
                                                                                                Spiral_builder::US21 =
                                                                                            defaultValue(Spiral_builder::US21::US21_1,
                                                                                                         _v392.get().clone());
                                                                match &v397
                                                                                            {
                                                                                            Spiral_builder::US21::US21_0(v397_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v398:
                                                                                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                    match &v397
                                                                                                        {
                                                                                                        Spiral_builder::US21::US21_0(x)
                                                                                                        =>
                                                                                                        x.clone(),
                                                                                                        _
                                                                                                        =>
                                                                                                        unreachable!(),
                                                                                                    };
                                                                                                (match &v367
                                                                                                     {
                                                                                                     Spiral_builder::US20::US20_0(x)
                                                                                                     =>
                                                                                                     x.clone(),
                                                                                                     _
                                                                                                     =>
                                                                                                     unreachable!(),
                                                                                                 })(v398.clone());
                                                                                                {
                                                                                                    let v399:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        Spiral_builder::method59(v398);
                                                                                                    let v401:
                                                                                                            Result<std::sync::MutexGuard<std::process::ChildStdin>,
                                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> =
                                                                                                        v399.lock();
                                                                                                    let v404:
                                                                                                            std::sync::MutexGuard<std::process::ChildStdin> =
                                                                                                        Spiral_builder::method60(v401.unwrap());
                                                                                                    let v406:
                                                                                                            bool =
                                                                                                        true; let mut v404 = v404;
                                                                                                    let v408:
                                                                                                            bool =
                                                                                                        true; std::io::Write::flush(&mut *v404).unwrap();
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
                                                        let v409: std::sync::Arc<
                                                            std::sync::Mutex<
                                                                Option<std::process::Child>,
                                                            >,
                                                        > = Spiral_builder::method52(v105);
                                                        let v411: Result<
                                                            std::sync::MutexGuard<
                                                                Option<std::process::Child>,
                                                            >,
                                                            std::sync::PoisonError<
                                                                std::sync::MutexGuard<
                                                                    Option<std::process::Child>,
                                                                >,
                                                            >,
                                                        > = v409.lock();
                                                        let v413: std::sync::MutexGuard<
                                                            Option<std::process::Child>,
                                                        > = v411.unwrap();
                                                        let v415: bool = true;
                                                        let mut v413 = v413;
                                                        let v417: &mut Option<std::process::Child> =
                                                            &mut v413;
                                                        let v419: Option<std::process::Child> =
                                                            Option::take(v417);
                                                        let v421: std::process::Child =
                                                            v419.unwrap();
                                                        let v423: Result<
                                                            std::process::Output,
                                                            std::io::Error,
                                                        > = v421.wait_with_output();
                                                        let v424 = Spiral_builder::method49();
                                                        let v426: Result<
                                                            std::process::Output,
                                                            std::string::String,
                                                        > = v423.map_err(|x| v424(x));
                                                        let v427: std::thread::JoinHandle<
                                                            Result<(), string>,
                                                        > = Spiral_builder::method61(v361);
                                                        let v430: string = string("v427");
                                                        let v431: std::thread::JoinHandle<
                                                            Result<(), string>,
                                                        > = Spiral_builder::method61(v279);
                                                        let v436: string = append(
                                                            append(
                                                                string("vec!["),
                                                                append(string("v431, "), v430),
                                                            ),
                                                            string("]"),
                                                        );
                                                        let v437: Vec<
                                                            std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            >,
                                                        > = vec![v431, v427];
                                                        let v439: bool = true;
                                                        v437.into_iter().for_each(|x| {
                                                            //;
                                                            let v441: std::thread::JoinHandle<
                                                                Result<(), string>,
                                                            > = x;
                                                            let v443: Result<
                                                                Result<(), string>,
                                                                Box<
                                                                    dyn core::any::Any
                                                                        + 'static
                                                                        + Send,
                                                                >,
                                                            > = std::thread::JoinHandle::join(v441);
                                                            let v445: Result<(), string> =
                                                                v443.unwrap();
                                                            v445.unwrap();
                                                            {
                                                                let v448: bool = true;
                                                                ()
                                                            }
                                                        });
                                                        {
                                                            //;
                                                            let v451: Spiral_builder::US22 =
                                                                match &v426 {
                                                                    Err(v426_1_0) => {
                                                                        Spiral_builder::closure28(
                                                                            (),
                                                                            v426_1_0.clone(),
                                                                        )
                                                                    }
                                                                    Ok(v426_0_0) => {
                                                                        Spiral_builder::closure27(
                                                                            (),
                                                                            v426_0_0.clone(),
                                                                        )
                                                                    }
                                                                };
                                                            match &v451 {
                                                                Spiral_builder::US22::US22_0(
                                                                    v451_0_0,
                                                                ) => {
                                                                    let v454:
                                                                                                    std::process::ExitStatus =
                                                                                                v451_0_0.clone().status;
                                                                    let v456: Option<i32> =
                                                                        v454.code();
                                                                    (v456.unwrap(),
                                                                                             Spiral_builder::US5::US5_1,
                                                                                             Spiral_builder::US18::US18_0(v200))
                                                                }
                                                                Spiral_builder::US22::US22_1(
                                                                    v451_1_0,
                                                                ) => {
                                                                    let v461: std::string::String =
                                                                        v451_1_0.clone();
                                                                    Spiral_builder::method5(
                                                                        Spiral_builder::US0::US0_4,
                                                                        Func0::new(move || {
                                                                            Spiral_builder::closure29((),
                                                                                                                                                             ())
                                                                        }),
                                                                        Func0::new({
                                                                            let v461 = v461.clone();
                                                                            move || {
                                                                                Spiral_builder::closure30(v461.clone(),
                                                                                                                                                                 ())
                                                                            }
                                                                        }),
                                                                    );
                                                                    (-2_i32,
                                                                                             Spiral_builder::US5::US5_0(v461.clone()),
                                                                                             Spiral_builder::US18::US18_1)
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    Spiral_builder::US17::US17_1(v104_1_0) => {
                                        let v473: std::string::String = v104_1_0.clone();
                                        Spiral_builder::method5(
                                            Spiral_builder::US0::US0_4,
                                            Func0::new(move || Spiral_builder::closure19((), ())),
                                            Func0::new({
                                                let v473 = v473.clone();
                                                move || Spiral_builder::closure20(v473.clone(), ())
                                            }),
                                        );
                                        (
                                            -1_i32,
                                            Spiral_builder::US5::US5_0(v473.clone()),
                                            Spiral_builder::US18::US18_1,
                                        )
                                    }
                                };
                                let v484: Spiral_builder::US18 = patternInput_3.2.clone();
                                let v483: Spiral_builder::US5 = patternInput_3.1.clone();
                                let v482: i32 = patternInput_3.0.clone();
                                let v489: Option<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                > = match &v484 {
                                    Spiral_builder::US18::US18_0(v484_0_0) => Some(match &v484 {
                                        Spiral_builder::US18::US18_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }),
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
                                let v491: bool = true;
                                let _result = v489.map(|x| {
                                    //;
                                    let v494: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = Spiral_builder::method62(x);
                                    let v496: Result<
                                        std::sync::MutexGuard<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<
                                                std::sync::Arc<
                                                    std::sync::mpsc::Receiver<std::string::String>,
                                                >,
                                            >,
                                        >,
                                    > = v494.lock();
                                    let v498: std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = v496.unwrap();
                                    let v500 = v498.iter();
                                    let v502: Vec<std::string::String> = v500.collect::<Vec<_>>();
                                    let v504: bool = true;
                                    let _result: Vec<_> = v502
                                        .into_iter()
                                        .map(|x| {
                                            //;
                                            let v506: std::string::String = x;
                                            let v508: string =
                                                fable_library_rust::String_::fromString(v506);
                                            let v510: bool = true;
                                            v508
                                        })
                                        .collect::<Vec<_>>();
                                    let v512: Vec<string> = _result;
                                    let v520: string = join(
                                        string("\n"),
                                        toArray_1(ofArray_1(
                                            fable_library_rust::NativeArray_::array_from(v512),
                                        )),
                                    );
                                    let v522: bool = true;
                                    v520
                                });
                                let v524: Option<string> = _result;
                                let v531: Spiral_builder::US3 = match &v483 {
                                    Spiral_builder::US5::US5_0(v483_0_0) => {
                                        Spiral_builder::US3::US3_0(
                                            fable_library_rust::String_::fromString(match &v483 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }),
                                        )
                                    }
                                    _ => Spiral_builder::US3::US3_1,
                                };
                                let v536: string = defaultValue(
                                    match &v531 {
                                        Spiral_builder::US3::US3_0(v531_0_0) => match &v531 {
                                            Spiral_builder::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => string(""),
                                    },
                                    v524,
                                );
                                Spiral_builder::method5(
                                    Spiral_builder::US0::US0_0,
                                    Func0::new(move || Spiral_builder::closure31((), ())),
                                    Func0::new({
                                        let v482 = v482.clone();
                                        let v536 = v536.clone();
                                        move || Spiral_builder::closure32(v482, v536.clone(), ())
                                    }),
                                );
                                LrcPtr::new((v482, v536.clone()))
                            }
                        }
                    }))();
                    _v35.set(Some(x_12))
                }
                {
                    let v541: LrcPtr<(i32, string)> = match &_v35.get().clone() {
                        None => panic!("{}", string("base.capture / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    _v7.set(Some((v541.0.clone(), v541.1.clone())));
                    {
                        let patternInput_4: (i32, string) = match &_v7.get().clone() {
                            None => panic!("{}", string("base.run_target / _v7=None"),),
                            Some(_v7_0_0) => _v7_0_0.clone(),
                        };
                        (patternInput_4.0.clone(), patternInput_4.1.clone())
                    }
                }
            }
        }
        pub fn closure40(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / repl error")
        }
        pub fn closure41(v0_1: u8, v1_1: u8, v2: string, v3: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / retry: {}/{} / repl_result: {} / {}",
                v3,
                v1_1,
                v0_1,
                v2,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method43(v0_1: Option<string>, v1_1: u8, v2: string, v3: u8) -> (i32, string) {
            let v0_1: MutCell<Option<string>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<u8> = MutCell::new(v1_1);
            let v2: MutCell<string> = MutCell::new(v2.clone());
            let v3: MutCell<u8> = MutCell::new(v3);
            '_method43: loop {
                break '_method43 ({
                    let patternInput: (i32, string) = Spiral_builder::method44(
                        None::<CancellationToken>,
                        sprintf!(
                            "dotnet repl --exit-after-run --run \"{}\" --output-path \"{}.ipynb\"",
                            v2.get().clone(),
                            v2.get().clone()
                        ),
                        new_array(&[
                            (string("TRACE_LEVEL"), string("Verbose")),
                            (string("AUTOMATION"), string("True")),
                        ]),
                        None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                        false,
                        v0_1.get().clone(),
                    );
                    let v17: string = patternInput.1.clone();
                    let v16: i32 = patternInput.0.clone();
                    if if v16 == 0_i32 {
                        true
                    } else {
                        v3.get().clone() >= v1_1.get().clone()
                    } {
                        (v16, v17.clone())
                    } else {
                        Spiral_builder::method5(
                            Spiral_builder::US0::US0_1,
                            Func0::new(move || Spiral_builder::closure40((), ())),
                            Func0::new({
                                let v16 = v16.clone();
                                let v17 = v17.clone();
                                let v1_1 = v1_1.clone();
                                let v3 = v3.clone();
                                move || {
                                    Spiral_builder::closure41(
                                        v1_1.get().clone(),
                                        v3.get().clone(),
                                        v17.clone(),
                                        v16,
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
                            continue '_method43;
                        }
                    }
                });
            }
        }
        pub fn closure42(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib / jupyter nbconvert")
        }
        pub fn closure43(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / jupyter_result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure44(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib / html cell ids")
        }
        pub fn closure45(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / pwsh_replace_html_result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method65(v0_1: string) -> string {
            v0_1
        }
        pub fn closure46(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib")
        }
        pub fn closure47(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method66() -> string {
            string("deps")
        }
        pub fn method68() -> string {
            string("")
        }
        pub fn method67(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
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
                let v21: _ = [0_u8; 1024];
                let v23: bool = true;
                loop {
                    // rust.loop;
                    let v25: bool = true;
                    let mut v21 = v21;
                    let v27: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v11, &mut v21);
                    let v29: usize = v27.unwrap();
                    if v29 == v19 {
                        let v32: bool = true;
                        break;
                        ()
                    }
                    {
                        let v34: usize = v21.len();
                        let v35: u8 = v34 as u8;
                        let v36: usize = v29;
                        let v43: &_ = if v36 == v34 {
                            &v21[v19..]
                        } else {
                            &v21[v19..v36]
                        };
                        sha2::Digest::update(&mut v16, v43);
                        {
                            let v46: bool = true;
                        } // rust.loop;
                        let v48: bool = true;
                    } // rust.loop;
                    let v50: bool = true;
                } // rust.loop;
                let v52: bool = true;
                {
                    // rust.loop;
                    let v54: bool = true;
                    {
                        // rust.loop;
                        let v56: &[u8] = &sha2::Digest::finalize(v16);
                        let v58: Vec<u8> = v56.iter().map(|x| *x).collect::<Vec<_>>();
                        let v60: bool = true;
                        let _result: Vec<_> = v58
                            .into_iter()
                            .map(|x| {
                                //;
                                let v62: u8 = x;
                                let v64: std::string::String = format!("{:02x}", v62);
                                let v66: string = fable_library_rust::String_::fromString(v64);
                                let v68: bool = true;
                                v66
                            })
                            .collect::<Vec<_>>();
                        let v70: Vec<string> = _result;
                        let v72: Array<string> = fable_library_rust::NativeArray_::array_from(v70);
                        let v77: string = join(
                            string(""),
                            toArray_1(delay(Func0::new({
                                let v72 = v72.clone();
                                move || {
                                    map(
                                        Func1::new({
                                            let v72 = v72.clone();
                                            move |i: i32| v72[i].clone()
                                        }),
                                        rangeNumeric(0_i32, 1_i32, count_2(v72.clone()) - 1_i32),
                                    )
                                }
                            }))),
                        );
                        {
                            let x: string = Ok::<string, std::io::Error>(v77).unwrap();
                            _v1.set(Some(x))
                        }
                        match &_v1.get().clone() {
                            None => panic!("{}", string("base.run_target / _v1=None"),),
                            Some(_v1_0_0) => _v1_0_0.clone(),
                        }
                    }
                }
            }
        }
        pub fn method70(v0_1: string) -> bool {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            {
                let x: bool = if v7.clone().exists() {
                    true
                } else {
                    if v7.clone().is_dir() {
                        true
                    } else {
                        v7.is_symlink()
                    }
                };
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method72(v0_1: string) -> Option<string> {
            let _v1: MutCell<Option<Spiral_builder::US3>> =
                MutCell::new(None::<Spiral_builder::US3>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<std::path::PathBuf> = v7.parent().map(std::path::PathBuf::from);
            let v11: std::path::PathBuf = v9?;
            let v13: std::path::Display = v11.display();
            let _v14: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v13);
                _v14.set(Some(x))
            }
            {
                let v24: std::string::String = match &_v14.get().clone() {
                    None => panic!("{}", string("base.run_target / _v14=None"),),
                    Some(_v14_0_0) => _v14_0_0.clone(),
                };
                {
                    let x_2: Spiral_builder::US3 =
                        Spiral_builder::US3::US3_0(fable_library_rust::String_::fromString(v24));
                    _v1.set(Some(x_2))
                }
                {
                    let v51: Spiral_builder::US3 = match &_v1.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1=None"),),
                        Some(_v1_0_0) => _v1_0_0.clone(),
                    };
                    match &v51 {
                        Spiral_builder::US3::US3_0(v51_0_0) => Some(match &v51 {
                            Spiral_builder::US3::US3_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<string>,
                    }
                }
            }
        }
        pub fn closure48(unitVar: (), v0_1: string) -> Option<string> {
            Spiral_builder::method72(v0_1)
        }
        pub fn method71() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Spiral_builder::closure48((), v))
        }
        pub fn method73(v0_1: string, v1_1: string, v2: string) -> string {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method73: loop {
                break '_method73 (if Spiral_builder::method70(Spiral_builder::method30(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    v2.get().clone()
                } else {
                    let v6: Option<string> = (Spiral_builder::method71())(v2.get().clone());
                    let _v7: LrcPtr<MutCell<Option<Spiral_builder::US3>>> =
                        refCell(None::<Spiral_builder::US3>);
                    {
                        let x_2: Option<Spiral_builder::US3> = match &v6 {
                            None => None::<Spiral_builder::US3>,
                            Some(v6_0_0) => {
                                let x: string = v6_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Spiral_builder::US3::US3_0(x.clone())
                                }))())
                            }
                        };
                        _v7.set(x_2)
                    }
                    {
                        let v12: Spiral_builder::US3 =
                            defaultValue(Spiral_builder::US3::US3_1, _v7.get().clone());
                        match &v12 {
                            Spiral_builder::US3::US3_0(v12_0_0) => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: string = match &v12 {
                                    Spiral_builder::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                };
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method73;
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
                });
            }
        }
        pub fn method69(v0_1: string, v1_1: string) -> string {
            if Spiral_builder::method70(Spiral_builder::method30(v1_1.clone(), v0_1.clone())) {
                v1_1.clone()
            } else {
                let v5: Option<string> = (Spiral_builder::method71())(v1_1.clone());
                let _v6: LrcPtr<MutCell<Option<Spiral_builder::US3>>> =
                    refCell(None::<Spiral_builder::US3>);
                {
                    let x_2: Option<Spiral_builder::US3> = match &v5 {
                        None => None::<Spiral_builder::US3>,
                        Some(v5_0_0) => {
                            let x: string = v5_0_0.clone();
                            Some((Func0::new({
                                let x = x.clone();
                                move || Spiral_builder::US3::US3_0(x.clone())
                            }))())
                        }
                    };
                    _v6.set(x_2)
                }
                {
                    let v11: Spiral_builder::US3 =
                        defaultValue(Spiral_builder::US3::US3_1, _v6.get().clone());
                    match &v11 {
                        Spiral_builder::US3::US3_0(v11_0_0) => Spiral_builder::method73(
                            v0_1.clone(),
                            v1_1.clone(),
                            match &v11 {
                                Spiral_builder::US3::US3_0(x) => x.clone(),
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
        pub fn method75(v0_1: string) -> string {
            v0_1
        }
        pub fn closure49(unitVar: (), unitVar_1: ()) -> Spiral_builder::US26 {
            Spiral_builder::US26::US26_0
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US26 {
            Spiral_builder::US26::US26_1(v0_1)
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.create_dir")
        }
        pub fn closure52(v0_1: string, v1_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "dir: {} / error: {} / {}",
                v0_1,
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.create_dir")
        }
        pub fn closure54(v0_1: string, unitVar: ()) -> string {
            sprintf!("dir: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn method78(v0_1: string) -> string {
            v0_1
        }
        pub fn method77(v0_1: bool, v1_1: string) {
            let _v2: MutCell<Option<()>> = MutCell::new(None::<()>);
            let v3: string = Spiral_builder::method78(v1_1);
            if Spiral_builder::method70(v3.clone()) {
                if v0_1 {
                    std::fs::remove_dir_all(&*v3.clone()).unwrap();
                    ()
                } else {
                    std::fs::remove_dir(&*v3).unwrap();
                    ()
                };
            }
            _v2.set(Some(()));
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
            ()
        }
        pub fn closure55(v0_1: string, unitVar: ()) {
            Spiral_builder::method77(true, v0_1);
        }
        pub fn method76(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure55(v0_1.clone(), ())
            })
        }
        pub fn method79(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure55(v0_1.clone(), ())
            })
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.create_dir")
        }
        pub fn closure57(v0_1: string, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "dir: {} / result: {} {}",
                v0_1,
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.delete_directory_async")
        }
        pub fn method82(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<&std::ffi::OsStr> = v7.file_name();
            let v11: &std::ffi::OsStr = v9.unwrap();
            let v13: std::ffi::OsString = v11.to_os_string();
            let v15: Option<&str> = v13.to_str();
            let v17: &str = v15.unwrap();
            let v19: std::string::String = String::from(v17);
            {
                let x: string = fable_library_rust::String_::fromString(v19);
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn closure61(unitVar: (), v0_1: string) -> string {
            Spiral_builder::method82(v0_1)
        }
        pub fn closure60(v0_1: string, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "path: {} / ex: {} / {}",
                Spiral_builder::closure61((), v0_1),
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method81(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
            let _v2: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
            {
                let x: Arc<Async<i64>> = defaultOf();
                _v2.set(Some(x))
            }
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
        }
        pub fn closure58(v0_1: string, unitVar: ()) {
            let _v1: MutCell<Option<Arc<Async<i64>>>> = MutCell::new(None::<Arc<Async<i64>>>);
            {
                let x: Arc<Async<i64>> = defaultOf();
                _v1.set(Some(x))
            }
            {
                let v9: Arc<Async<i64>> = match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                };
                let _v10: MutCell<Option<Arc<Async<()>>>> = MutCell::new(None::<Arc<Async<()>>>);
                {
                    let x_2: Arc<Async<()>> = defaultOf();
                    _v10.set(Some(x_2))
                }
                {
                    let v18: Arc<Async<()>> = match &_v10.get().clone() {
                        None => panic!("{}", string("base.run_target / _v10=None"),),
                        Some(_v10_0_0) => _v10_0_0.clone(),
                    };
                    let _v19: MutCell<Option<()>> = MutCell::new(None::<()>);
                    defaultOf::<()>();
                    _v19.set(Some(()));
                    match &_v19.get().clone() {
                        None => panic!("{}", string("base.run_target / _v19=None"),),
                        Some(_v19_0_0) => _v19_0_0.clone(),
                    }
                    ()
                }
            }
        }
        pub fn method80(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure58(v0_1.clone(), ())
            })
        }
        pub fn method83(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure58(v0_1.clone(), ())
            })
        }
        pub fn method74(v0_1: string) -> LrcPtr<dyn IDisposable> {
            let _v1: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                MutCell::new(None::<LrcPtr<dyn IDisposable>>);
            let v2: string = Spiral_builder::method75(v0_1);
            let v4: Result<(), std::io::Error> = std::fs::create_dir_all(&*v2.clone());
            let v5 = Spiral_builder::method49();
            let v7: Result<(), std::string::String> = v4.map_err(|x| v5(x));
            let v10: Spiral_builder::US26 = match &v7 {
                Err(v7_1_0) => Spiral_builder::closure50((), v7_1_0.clone()),
                _ => Spiral_builder::closure49((), ()),
            };
            match &v10 {
                Spiral_builder::US26::US26_0 => Spiral_builder::method5(
                    Spiral_builder::US0::US0_0,
                    Func0::new(move || Spiral_builder::closure53((), ())),
                    Func0::new({
                        let v2 = v2.clone();
                        move || Spiral_builder::closure54(v2.clone(), ())
                    }),
                ),
                Spiral_builder::US26::US26_1(v10_1_0) => Spiral_builder::method5(
                    Spiral_builder::US0::US0_4,
                    Func0::new(move || Spiral_builder::closure51((), ())),
                    Func0::new({
                        let v10 = v10.clone();
                        let v2 = v2.clone();
                        move || {
                            Spiral_builder::closure52(
                                v2.clone(),
                                match &v10 {
                                    Spiral_builder::US26::US26_1(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                (),
                            )
                        }
                    }),
                ),
            }
            {
                let _v18: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                    MutCell::new(None::<LrcPtr<dyn IDisposable>>);
                let v19 = Spiral_builder::method76(v2.clone());
                {
                    let x_1: LrcPtr<dyn IDisposable> = interface_cast!(
                        Spiral_builder::Disposable::_ctor__3A5B6456(Func0::new({
                            let v19 = v19.clone();
                            move || v19.clone()()
                        })),
                        Lrc<dyn IDisposable>,
                    );
                    _v18.set(Some(x_1))
                }
                {
                    let x_3: LrcPtr<dyn IDisposable> = match &_v18.get().clone() {
                        None => panic!("{}", string("base.run_target / _v18=None"),),
                        Some(_v18_0_0) => _v18_0_0.clone(),
                    };
                    _v1.set(Some(x_3))
                }
                match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                }
            }
        }
        pub fn method85(v0_1: string) -> bool {
            let _v1: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            {
                let x: bool = if v7.clone().exists() {
                    v7.is_file()
                } else {
                    false
                };
                _v1.set(Some(x))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method84(v0_1: string, v1_1: string) -> bool {
            let _v2: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x_4: bool = if Spiral_builder::method85(v0_1.clone()) == false {
                    false
                } else {
                    let _v5: MutCell<Option<string>> = MutCell::new(None::<string>);
                    let _v6: MutCell<Option<Vec<u8>>> = MutCell::new(None::<Vec<u8>>);
                    {
                        let x: Vec<u8> = std::fs::read(&*v0_1).unwrap();
                        _v6.set(Some(x))
                    }
                    {
                        let v16: Vec<u8> = match &_v6.get().clone() {
                            None => panic!("{}", string("base.run_target / _v6=None"),),
                            Some(_v6_0_0) => _v6_0_0.clone(),
                        };
                        let v18: Result<std::string::String, std::string::FromUtf8Error> =
                            std::string::String::from_utf8(v16);
                        let v20: std::string::String = v18.unwrap();
                        {
                            let x_2: string = fable_library_rust::String_::fromString(v20);
                            _v5.set(Some(x_2))
                        }
                        v1_1 == match &_v5.get().clone() {
                            None => panic!("{}", string("base.run_target / _v5=None"),),
                            Some(_v5_0_0) => _v5_0_0.clone(),
                        }
                    }
                };
                _v2.set(Some(x_4))
            }
            match &_v2.get().clone() {
                None => panic!("{}", string("base.run_target / _v2=None"),),
                Some(_v2_0_0) => _v2_0_0.clone(),
            }
        }
        pub fn method86(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: &str = &*v0_1;
            let v5: std::string::String = String::from(v3);
            let v7: std::path::PathBuf = std::path::PathBuf::from(v5);
            let v9: Option<&std::path::Path> = v7.parent();
            let v11: &std::path::Path = v9.unwrap();
            let v13: std::path::Display = v11.display();
            let _v14: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v13);
                _v14.set(Some(x))
            }
            {
                let v24: std::string::String = match &_v14.get().clone() {
                    None => panic!("{}", string("base.run_target / _v14=None"),),
                    Some(_v14_0_0) => _v14_0_0.clone(),
                };
                {
                    let x_2: string = fable_library_rust::String_::fromString(v24);
                    _v1.set(Some(x_2))
                }
                match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                }
            }
        }
        pub fn method88(v0_1: chrono::DateTime<chrono::Utc>) -> chrono::DateTime<chrono::Utc> {
            v0_1
        }
        pub fn method89(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
            v0_1
        }
        pub fn method90() -> string {
            string("hh:mm")
        }
        pub fn method91() -> string {
            string("yyyyMMdd-HHmm-ssff-ffff-f")
        }
        pub fn method92() -> string {
            string("hhmm")
        }
        pub fn method87(v0_1: Guid, v1_1: DateTime) -> Guid {
            let _v2: MutCell<Option<Guid>> = MutCell::new(None::<Guid>);
            let v5: DateTime = {
                let _arg: DateTime =
                    DateTime::new_ymdhms_kind(1970_i32, 1_i32, 1_i32, 0_i32, 0_i32, 0_i32, 1_i32);
                _arg.toUniversalTime()
            };
            let v15: i64 = ({
                let _arg_2: DateTime = {
                    let _arg_1: DateTime = DateTime::specifyKind(v1_1, 2_i32);
                    _arg_1.toUniversalTime()
                };
                _arg_2.ticks()
            } - v5.ticks())
                / 10_i64;
            let v17: Option<chrono::DateTime<chrono::Utc>> =
                chrono::DateTime::from_timestamp_micros(v15);
            let _v18: LrcPtr<MutCell<Option<Spiral_builder::US27>>> =
                refCell(None::<Spiral_builder::US27>);
            {
                let x_2: Option<Spiral_builder::US27> = match &v17 {
                    None => None::<Spiral_builder::US27>,
                    Some(v17_0_0) => {
                        let x: chrono::DateTime<chrono::Utc> = v17_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Spiral_builder::US27::US27_0(x.clone())
                        }))())
                    }
                };
                _v18.set(x_2)
            }
            {
                let v23: Spiral_builder::US27 =
                    defaultValue(Spiral_builder::US27::US27_1, _v18.get().clone());
                let v42: Spiral_builder::US3 = match &v23 {
                    Spiral_builder::US27::US27_0(v23_0_0) => {
                        let v25: chrono::DateTime<chrono::Utc> =
                            Spiral_builder::method88(match &v23 {
                                Spiral_builder::US27::US27_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                        let v27: chrono::NaiveDateTime = v25.naive_utc();
                        let v29: chrono::DateTime<chrono::Local> =
                            chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27);
                        let v31: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                        let v32: &str = r#"%Y%m%d-%H%M-%S%f"#;
                        let v33: chrono::DateTime<chrono::Local> = Spiral_builder::method89(v29);
                        let v35: std::string::String = v33.format(v32).to_string();
                        let v37: string = fable_library_rust::String_::fromString(v35);
                        Spiral_builder::US3::US3_0(sprintf!(
                            "{}-{}-{}",
                            getSlice(v37.clone(), Some(0_i32), Some(17_i32)),
                            getSlice(v37.clone(), Some(18_i32), Some(21_i32)),
                            getCharAt(v37, 22_i32)
                        ))
                    }
                    _ => Spiral_builder::US3::US3_1,
                };
                let v46: string = match &v42 {
                    Spiral_builder::US3::US3_0(v42_0_0) => match &v42 {
                        Spiral_builder::US3::US3_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => string(""),
                };
                let _v47: MutCell<Option<LrcPtr<TimeZoneInfo>>> =
                    MutCell::new(None::<LrcPtr<TimeZoneInfo>>);
                {
                    let x_3: LrcPtr<TimeZoneInfo> = 0i64.into();
                    _v47.set(Some(x_3))
                }
                {
                    let v55: LrcPtr<TimeZoneInfo> = match &_v47.get().clone() {
                        None => panic!("{}", string("base.run_target / _v47=None"),),
                        Some(_v47_0_0) => _v47_0_0.clone(),
                    };
                    let _v56: MutCell<Option<TimeSpan>> = MutCell::new(None::<TimeSpan>);
                    _v56.set(Some(zero));
                    {
                        let v83: TimeSpan = match &_v56.get().clone() {
                            None => panic!("{}", string("base.run_target / _v56=None"),),
                            Some(_v56_0_0) => _v56_0_0.clone(),
                        };
                        let v87: u8 = if v83.hours() > 0_i32 { 1_u8 } else { 0_u8 };
                        let v88: string = Spiral_builder::method90();
                        let _v89: MutCell<Option<string>> = MutCell::new(None::<string>);
                        {
                            let x_7: string = v83.to_string(v88);
                            _v89.set(Some(x_7))
                        }
                        {
                            let v96: string = match &_v89.get().clone() {
                                None => panic!("{}", string("base.run_target / _v89=None"),),
                                Some(_v89_0_0) => _v89_0_0.clone(),
                            };
                            let v97: string = sprintf!(
                                "{}{}{}",
                                v87,
                                getSlice(v96.clone(), Some(0_i32), Some(1_i32)),
                                getSlice(v96, Some(3_i32), Some(4_i32))
                            );
                            {
                                let x_9: Guid = parse(sprintf!(
                                    "{}{}{}",
                                    v46.clone(),
                                    v97.clone(),
                                    getSlice(
                                        toString(v0_1),
                                        Some(length(v46) + length(v97)),
                                        None::<i32>
                                    )
                                ));
                                _v2.set(Some(x_9))
                            }
                            match &_v2.get().clone() {
                                None => panic!("{}", string("base.run_target / _v2=None"),),
                                Some(_v2_0_0) => _v2_0_0.clone(),
                            }
                        }
                    }
                }
            }
        }
        pub fn closure62(unitVar: (), unitVar_1: ()) -> string {
            string("common.retry_fn\' / loop")
        }
        pub fn closure63(v0_1: u8, v1_1: i32, v2: string, v3: bool, unitVar: ()) -> string {
            sprintf!(
                "is_error: {} / retry: {}/{} / result: {:?} / {}",
                v3,
                v0_1,
                3_u8,
                (v1_1, v2),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method94(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Spiral_builder::US28,
            v4: u8,
        ) -> (i32, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US28> = MutCell::new(v3.clone());
            let v4: MutCell<u8> = MutCell::new(v4);
            '_method94: loop {
                break '_method94 ({
                    let _v5: MutCell<Option<bool>> = MutCell::new(None::<bool>);
                    {
                        let x: bool = cfg!(windows);
                        _v5.set(Some(x))
                    }
                    {
                        let v32: string =
                                     sprintf!("dotnet fable \"{}\" --optimize --lang {} --extension .{} --outDir \"{}\" --define {}",
                                              v2.get().clone(),
                                              v1_1.get().clone(),
                                              v1_1.get().clone(),
                                              v0_1.get().clone(),
                                              if match &_v5.get().clone() {
                                                     None =>
                                                     panic!("{}",
                                                            string("base.run_target / _v5=None"),),
                                                     Some(_v5_0_0) =>
                                                     _v5_0_0.clone(),
                                                 } {
                                                  string("_WINDOWS")
                                              } else { string("_LINUX") });
                        let v38: Result<string, string> = match &v3.get().clone() {
                            Spiral_builder::US28::US28_0(v3_0_0) => {
                                Ok::<string, string>(v3_0_0.clone())
                            }
                            Spiral_builder::US28::US28_1(v3_1_0) => {
                                Err::<string, string>(v3_1_0.clone())
                            }
                        };
                        let patternInput: (i32, string) = Spiral_builder::method44(
                            None::<CancellationToken>,
                            v32,
                            new_empty::<(string, string)>(),
                            None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                            None::<
                                Func1<
                                    std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                    (),
                                >,
                            >,
                            true,
                            v38.ok(),
                        );
                        let v43: string = patternInput.1.clone();
                        let v42: i32 = patternInput.0.clone();
                        let v47: Spiral_builder::US29 = if v42 == 0_i32 {
                            Spiral_builder::US29::US29_0(v42, v43.clone())
                        } else {
                            Spiral_builder::US29::US29_1(v42, v43)
                        };
                        let patternInput_1: (bool, i32, string) = match &v47 {
                            Spiral_builder::US29::US29_0(v47_0_0, v47_0_1) => {
                                (false, v47_0_0.clone(), v47_0_1.clone())
                            }
                            Spiral_builder::US29::US29_1(v47_1_0, v47_1_1) => {
                                (true, v47_1_0.clone(), v47_1_1.clone())
                            }
                        };
                        let v57: string = patternInput_1.2.clone();
                        let v56: i32 = patternInput_1.1.clone();
                        let v55: bool = patternInput_1.0.clone();
                        if if v55 == false {
                            true
                        } else {
                            v4.get().clone() >= 3_u8
                        } {
                            (v56, v57.clone())
                        } else {
                            Spiral_builder::method5(
                                Spiral_builder::US0::US0_1,
                                Func0::new(move || Spiral_builder::closure62((), ())),
                                Func0::new({
                                    let v4 = v4.clone();
                                    let v55 = v55.clone();
                                    let v56 = v56.clone();
                                    let v57 = v57.clone();
                                    move || {
                                        Spiral_builder::closure63(
                                            v4.get().clone(),
                                            v56,
                                            v57.clone(),
                                            v55,
                                            (),
                                        )
                                    }
                                }),
                            );
                            {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: string = v2.get().clone();
                                let v3_temp: Spiral_builder::US28 = v3.get().clone();
                                let v4_temp: u8 = v4.get().clone() + 1_u8;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method94;
                            }
                        }
                    }
                });
            }
        }
        pub fn method93(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Spiral_builder::US28,
        ) -> (i32, string) {
            Spiral_builder::method94(v0_1, v1_1, v2, v3, 1_u8)
        }
        pub fn closure64(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust / dotnet fable error")
        }
        pub fn closure65(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / dotnet_fable_result: {} / {}",
                v1_1,
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method96() -> string {
            string("a")
        }
        pub fn method95(v0_1: string, v1_1: Spiral_builder::US28, v2: u8) -> (i32, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Spiral_builder::US28> = MutCell::new(v1_1.clone());
            let v2: MutCell<u8> = MutCell::new(v2);
            '_method95: loop {
                break '_method95 ({
                    let v8: string =
                        sprintf!("cargo fmt --manifest-path \"{}\" --", v0_1.get().clone());
                    let v14: Result<string, string> = match &v1_1.get().clone() {
                        Spiral_builder::US28::US28_0(v1_1_0_0) => {
                            Ok::<string, string>(v1_1_0_0.clone())
                        }
                        Spiral_builder::US28::US28_1(v1_1_1_0) => {
                            Err::<string, string>(v1_1_1_0.clone())
                        }
                    };
                    let patternInput: (i32, string) = Spiral_builder::method44(
                        None::<CancellationToken>,
                        v8,
                        new_empty::<(string, string)>(),
                        None::<Func1<(bool, string, i32), Arc<Async<()>>>>,
                        None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                        true,
                        v14.ok(),
                    );
                    let v19: string = patternInput.1.clone();
                    let v18: i32 = patternInput.0.clone();
                    let v152: Spiral_builder::US29 = if contains(
                        v19.clone(),
                        string("failed to load manifest for workspace member"),
                    ) == false
                    {
                        if v18 == 0_i32 {
                            Spiral_builder::US29::US29_0(v18, v19.clone())
                        } else {
                            Spiral_builder::US29::US29_1(v18, v19.clone())
                        }
                    } else {
                        let v29: Result<regex::Regex, regex::Error> =
                            regex::Regex::new(&string("failed to read `(?<a>.*?Cargo.toml)`"));
                        let v31: regex::Regex = v29.unwrap();
                        let v33: &str = &*v19.clone();
                        let v35: std::string::String = String::from(v33);
                        let v37: bool = true;
                        let _result = (move || {
                            //;
                            let v39: Box<std::string::String> = Box::new(v35);
                            let v41: &'static mut std::string::String = Box::leak(v39);
                            let v43: regex::CaptureMatches = v31.captures_iter(v41);
                            let v45: bool = true;
                            let _result: Vec<_> = v43
                                .map(|x| {
                                    //;
                                    let v47: regex::Captures<'static> = x;
                                    let v49: Box<regex::Captures<'static>> = Box::new(v47);
                                    let v51: &'static mut regex::Captures<'static> = Box::leak(v49);
                                    let v53: regex::CaptureNames = v31.capture_names();
                                    let v55: bool = true;
                                    let _result: std::collections::HashMap<_, _> = v53
                                        .map(|x| {
                                            //;
                                            let v57: string = x.unwrap_or("").to_string().into();
                                            let v59: string = v57.clone().clone();
                                            let v61: string = v51
                                                .name(&v57)
                                                .map(|x| x.as_str())
                                                .unwrap_or("")
                                                .to_string()
                                                .into();
                                            let v64: bool = true;
                                            LrcPtr::new((v59, v61))
                                        })
                                        .map(|x| {
                                            std::sync::Arc::try_unwrap(x)
                                                .unwrap_or_else(|x| (*x).clone())
                                        })
                                        .collect();
                                    let v66: std::collections::HashMap<string, string> = _result;
                                    let v68: bool = true;
                                    v66
                                })
                                .collect::<Vec<_>>();
                            let v70: Vec<std::collections::HashMap<string, string>> = _result;
                            let v72: bool = true;
                            v70
                        })();
                        let v74: Vec<std::collections::HashMap<string, string>> = _result;
                        let v79: Option<std::collections::HashMap<string, string>> =
                            tryItem(0_i32, fable_library_rust::NativeArray_::array_from(v74));
                        let _v80: LrcPtr<MutCell<Option<Spiral_builder::US30>>> =
                            refCell(None::<Spiral_builder::US30>);
                        {
                            let x_2: Option<Spiral_builder::US30> = match &v79 {
                                None => None::<Spiral_builder::US30>,
                                Some(v79_0_0) => {
                                    let x: std::collections::HashMap<string, string> =
                                        v79_0_0.clone();
                                    Some((Func0::new({
                                        let x = x.clone();
                                        move || Spiral_builder::US30::US30_0(x.clone())
                                    }))())
                                }
                            };
                            _v80.set(x_2)
                        }
                        {
                            let v85: Spiral_builder::US30 =
                                defaultValue(Spiral_builder::US30::US30_1, _v80.get().clone());
                            let v99: Spiral_builder::US31 = match &v85 {
                                Spiral_builder::US30::US30_0(v85_0_0) => {
                                    let v87: string = Spiral_builder::method96();
                                    let v89: Option<string> = std::collections::HashMap::get(
                                        &match &v85 {
                                            Spiral_builder::US30::US30_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        &v87,
                                    )
                                    .map(|x| x)
                                    .cloned();
                                    let _v90: LrcPtr<MutCell<Option<Spiral_builder::US3>>> =
                                        refCell(None::<Spiral_builder::US3>);
                                    {
                                        let x_5: Option<Spiral_builder::US3> = match &v89 {
                                            None => None::<Spiral_builder::US3>,
                                            Some(v89_0_0) => {
                                                let x_3: string = v89_0_0.clone();
                                                Some((Func0::new({
                                                    let x_3 = x_3.clone();
                                                    move || Spiral_builder::US3::US3_0(x_3.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v90.set(x_5)
                                    }
                                    Spiral_builder::US31::US31_0(defaultValue(
                                        Spiral_builder::US3::US3_1,
                                        _v90.get().clone(),
                                    ))
                                }
                                _ => Spiral_builder::US31::US31_1,
                            };
                            let v106: Spiral_builder::US3 =
                                if let Spiral_builder::US31::US31_0(v99_0_0) = &v99 {
                                    let v100: Spiral_builder::US3 = match &v99 {
                                        Spiral_builder::US31::US31_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Spiral_builder::US3::US3_0(v100_0_0) = &v100 {
                                        Spiral_builder::US3::US3_0(match &v100 {
                                            Spiral_builder::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Spiral_builder::US3::US3_1
                                    }
                                } else {
                                    Spiral_builder::US3::US3_1
                                };
                            match &v106 {
                                Spiral_builder::US3::US3_0(v106_0_0) => {
                                    let v108: string = match &v106 {
                                        Spiral_builder::US3::US3_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if Spiral_builder::method85(v108.clone()) == false {
                                        let v112: LrcPtr<dyn IDisposable> =
                                            Spiral_builder::method74(Spiral_builder::method86(
                                                v108.clone(),
                                            ));
                                        let v113: DateTime = DateTime::now();
                                        let v118: string =
                                            toString(Spiral_builder::method87(new_guid(), v113));
                                        let v142: string =
                                                         append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                    sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                             v118.clone())),
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
                                                                                       v118)),
                                                                       string("\n")),
                                                                sprintf!("path = \"spiral_builder.{}\"",
                                                                         string("rs")));
                                        let _v143: MutCell<Option<()>> = MutCell::new(None::<()>);
                                        std::fs::write(&*v108, &*v142).unwrap();
                                        _v143.set(Some(()));
                                        match &_v143.get().clone() {
                                            None => {
                                                panic!("{}", string("base.run_target / _v143=None"),)
                                            }
                                            Some(_v143_0_0) => _v143_0_0.clone(),
                                        }
                                        ()
                                    }
                                    if v18 == 0_i32 {
                                        Spiral_builder::US29::US29_0(v18, v19.clone())
                                    } else {
                                        Spiral_builder::US29::US29_1(v18, v19.clone())
                                    }
                                }
                                _ => Spiral_builder::US29::US29_1(v18, v19.clone()),
                            }
                        }
                    };
                    let patternInput_1: (bool, i32, string) = match &v152 {
                        Spiral_builder::US29::US29_0(v152_0_0, v152_0_1) => {
                            (false, v152_0_0.clone(), v152_0_1.clone())
                        }
                        Spiral_builder::US29::US29_1(v152_1_0, v152_1_1) => {
                            (true, v152_1_0.clone(), v152_1_1.clone())
                        }
                    };
                    let v162: string = patternInput_1.2.clone();
                    let v161: i32 = patternInput_1.1.clone();
                    let v160: bool = patternInput_1.0.clone();
                    if if v160 == false {
                        true
                    } else {
                        v2.get().clone() >= 3_u8
                    } {
                        (v161, v162.clone())
                    } else {
                        Spiral_builder::method5(
                            Spiral_builder::US0::US0_1,
                            Func0::new(move || Spiral_builder::closure62((), ())),
                            Func0::new({
                                let v160 = v160.clone();
                                let v161 = v161.clone();
                                let v162 = v162.clone();
                                let v2 = v2.clone();
                                move || {
                                    Spiral_builder::closure63(
                                        v2.get().clone(),
                                        v161,
                                        v162.clone(),
                                        v160,
                                        (),
                                    )
                                }
                            }),
                        );
                        {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: Spiral_builder::US28 = v1_1.get().clone();
                            let v2_temp: u8 = v2.get().clone() + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method95;
                        }
                    }
                });
            }
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust / cargo fmt error")
        }
        pub fn closure67(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / cargo_fmt_result: {} / {}",
                v1_1,
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method97() -> string {
            string(" defaultOf::<()>();")
        }
        pub fn method98() -> string {
            string("\\s\\sdefaultOf\\(\\);")
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust")
        }
        pub fn closure69(
            v0_1: string,
            v1_1: bool,
            v2: string,
            v3: bool,
            v4: string,
            v5: bool,
            v6: string,
            v7: bool,
            unitVar: (),
        ) -> string {
            sprintf!(
                "cleanup: {:?} / {}",
                LrcPtr::new(Spiral_builder::UH3::UH3_1(
                    v0_1,
                    v1_1,
                    LrcPtr::new(Spiral_builder::UH3::UH3_1(
                        v2,
                        v3,
                        LrcPtr::new(Spiral_builder::UH3::UH3_1(
                            v4,
                            v5,
                            LrcPtr::new(Spiral_builder::UH3::UH3_1(
                                v6,
                                v7,
                                LrcPtr::new(Spiral_builder::UH3::UH3_0)
                            ))
                        ))
                    ))
                )),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method99(v0_1: LrcPtr<Spiral_builder::UH3>) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH3>> = MutCell::new(v0_1.clone());
            '_method99: loop {
                break '_method99 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH3::UH3_0 => (),
                    Spiral_builder::UH3::UH3_1(v0_1_1_0, v0_1_1_1, v0_1_1_2) => {
                        let _v4: MutCell<Option<()>> = MutCell::new(None::<()>);
                        std::fs::remove_file(&*match v0_1.get().clone().as_ref() {
                            Spiral_builder::UH3::UH3_1(x, _, _) => x.clone(),
                            _ => unreachable!(),
                        })
                        .unwrap();
                        _v4.set(Some(()));
                        match &_v4.get().clone() {
                            None => panic!("{}", string("base.run_target / _v4=None"),),
                            Some(_v4_0_0) => _v4_0_0.clone(),
                        }
                        {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH3> =
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH3::UH3_1(_, _, x) => x.clone(),
                                    _ => unreachable!(),
                                };
                            v0_1.set(v0_1_temp);
                            continue '_method99;
                        }
                    }
                });
            }
        }
        pub fn closure71(unitVar: (), v0_1: string) -> bool {
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
        pub fn closure70(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(skip(
                    2_i32,
                    skipWhile(
                        Func1::new(move |v: string| Spiral_builder::closure71((), v)),
                        split(v0_1, string("\n"), -1_i32, 0_i32),
                    ),
                ))),
            )
        }
        pub fn closure72(unitVar: (), v0_1: string) -> Spiral_builder::US3 {
            Spiral_builder::US3::US3_0(v0_1)
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust / Exception")
        }
        pub fn closure75(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "ex: {} / new_code_path: {} / external_command: {} / cargo_run_result: {} / {}",
                v3,
                v0_1,
                v2,
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure73(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US3 {
            Spiral_builder::method5(
                Spiral_builder::US0::US0_4,
                Func0::new(move || Spiral_builder::closure74((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    move || {
                        Spiral_builder::closure75(
                            v0_1.clone(),
                            v1_1.clone(),
                            v2.clone(),
                            v3.clone(),
                            (),
                        )
                    }
                }),
            );
            Spiral_builder::US3::US3_1
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust / error")
        }
        pub fn closure77(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / new_code_path: {} / external_command: {} / cargo_run_result: {}",
                v2,
                v0_1,
                v3,
                v1_1
            )
        }
        pub fn method102(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure79(unitVar: (), v0_1: std::fs::FileType) -> Spiral_builder::US33 {
            Spiral_builder::US33::US33_0(v0_1)
        }
        pub fn closure80(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US33 {
            Spiral_builder::US33::US33_1(v0_1)
        }
        pub fn method103(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method104(v0_1: Spiral_builder::US32) -> Spiral_builder::US32 {
            v0_1
        }
        pub fn method101(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_builder::US32> + Send>>
        {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Spiral_builder::method102(v0_1);
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Spiral_builder::method49();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Spiral_builder::US33 = match &v9 {
                        Err(v9_1_0) => Spiral_builder::closure80((), v9_1_0.clone()),
                        Ok(v9_0_0) => Spiral_builder::closure79((), v9_0_0.clone()),
                    };
                    let v23: Spiral_builder::US32 = Spiral_builder::method104(
                        if let Spiral_builder::US33::US33_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Spiral_builder::method103(match &v12 {
                                Spiral_builder::US33::US33_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v14) == false {
                                Spiral_builder::US32::US32_0
                            } else {
                                Spiral_builder::US32::US32_2
                            }
                        } else {
                            Spiral_builder::US32::US32_2
                        },
                    );
                    let v30: string = string("v23 }}); { //");
                    v23
                }
            });
            {
                //;
                __result
            }
        }
        pub fn method105(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method100(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Spiral_builder::US32> + Send>,
                    > = Spiral_builder::method101(v0_1);
                    let v4: Spiral_builder::US32 = v2.await;
                    let v14: async_walkdir::Filtering = Spiral_builder::method105(match &v4 {
                        Spiral_builder::US32::US32_0 => async_walkdir::Filtering::Ignore,
                        Spiral_builder::US32::US32_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    });
                    let v21: string = string("v14 }}); { //");
                    v14
                }
            });
            {
                //;
                __result
            }
        }
        pub fn closure78(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            Spiral_builder::method100(v0_1)
        }
        pub fn closure82(unitVar: (), v0_1: async_walkdir::DirEntry) -> Spiral_builder::US34 {
            Spiral_builder::US34::US34_0(v0_1)
        }
        pub fn closure83(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US34 {
            Spiral_builder::US34::US34_1(v0_1)
        }
        pub fn closure84(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_typescript / stream_filter_map")
        }
        pub fn closure85(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn closure81(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, std::io::Error>,
        ) -> Option<(string, string)> {
            let v1_1 = Spiral_builder::method49();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Spiral_builder::US34 = match &v3 {
                Err(v3_1_0) => Spiral_builder::closure83((), v3_1_0.clone()),
                Ok(v3_0_0) => Spiral_builder::closure82((), v3_0_0.clone()),
            };
            let v117: Spiral_builder::US35 = match &v6 {
                Spiral_builder::US34::US34_0(v6_0_0) => {
                    let v9: std::path::PathBuf = async_walkdir::DirEntry::path(&v6_0_0.clone());
                    let v11: std::path::Display = v9.display();
                    let _v12: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x_2: std::string::String = format!("{}", v11);
                        _v12.set(Some(x_2))
                    }
                    {
                        let v22: std::string::String = match &_v12.get().clone() {
                            None => panic!("{}", string("base.run_target / _v12=None"),),
                            Some(_v12_0_0) => _v12_0_0.clone(),
                        };
                        let v24: string = fable_library_rust::String_::fromString(v22);
                        let v26: string =
                            sprintf!("fable-library-{}\\.(?<a>[\\d.]+)$", string("ts"));
                        let v28: Result<regex::Regex, regex::Error> = regex::Regex::new(&v26);
                        let v30: regex::Regex = v28.unwrap();
                        let v32: &str = &*v24.clone();
                        let v34: std::string::String = String::from(v32);
                        let v36: bool = true;
                        let _result = (move || {
                            //;
                            let v38: Box<std::string::String> = Box::new(v34);
                            let v40: &'static mut std::string::String = Box::leak(v38);
                            let v42: regex::CaptureMatches = v30.captures_iter(v40);
                            let v44: bool = true;
                            let _result: Vec<_> = v42
                                .map(|x| {
                                    //;
                                    let v46: regex::Captures<'static> = x;
                                    let v48: Box<regex::Captures<'static>> = Box::new(v46);
                                    let v50: &'static mut regex::Captures<'static> = Box::leak(v48);
                                    let v52: regex::CaptureNames = v30.capture_names();
                                    let v54: bool = true;
                                    let _result: std::collections::HashMap<_, _> = v52
                                        .map(|x| {
                                            //;
                                            let v56: string = x.unwrap_or("").to_string().into();
                                            let v58: string = v56.clone().clone();
                                            let v60: string = v50
                                                .name(&v56)
                                                .map(|x| x.as_str())
                                                .unwrap_or("")
                                                .to_string()
                                                .into();
                                            let v63: bool = true;
                                            LrcPtr::new((v58, v60))
                                        })
                                        .map(|x| {
                                            std::sync::Arc::try_unwrap(x)
                                                .unwrap_or_else(|x| (*x).clone())
                                        })
                                        .collect();
                                    let v65: std::collections::HashMap<string, string> = _result;
                                    let v67: bool = true;
                                    v65
                                })
                                .collect::<Vec<_>>();
                            let v69: Vec<std::collections::HashMap<string, string>> = _result;
                            let v71: bool = true;
                            v69
                        })();
                        let v73: Vec<std::collections::HashMap<string, string>> = _result;
                        let v78: Option<std::collections::HashMap<string, string>> =
                            tryItem(0_i32, fable_library_rust::NativeArray_::array_from(v73));
                        let _v79: LrcPtr<MutCell<Option<Spiral_builder::US30>>> =
                            refCell(None::<Spiral_builder::US30>);
                        {
                            let x_6: Option<Spiral_builder::US30> = match &v78 {
                                None => None::<Spiral_builder::US30>,
                                Some(v78_0_0) => {
                                    let x_4: std::collections::HashMap<string, string> =
                                        v78_0_0.clone();
                                    Some((Func0::new({
                                        let x_4 = x_4.clone();
                                        move || Spiral_builder::US30::US30_0(x_4.clone())
                                    }))())
                                }
                            };
                            _v79.set(x_6)
                        }
                        {
                            let v84: Spiral_builder::US30 =
                                defaultValue(Spiral_builder::US30::US30_1, _v79.get().clone());
                            let v98: Spiral_builder::US31 = match &v84 {
                                Spiral_builder::US30::US30_0(v84_0_0) => {
                                    let v86: string = Spiral_builder::method96();
                                    let v88: Option<string> = std::collections::HashMap::get(
                                        &match &v84 {
                                            Spiral_builder::US30::US30_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        &v86,
                                    )
                                    .map(|x| x)
                                    .cloned();
                                    let _v89: LrcPtr<MutCell<Option<Spiral_builder::US3>>> =
                                        refCell(None::<Spiral_builder::US3>);
                                    {
                                        let x_9: Option<Spiral_builder::US3> = match &v88 {
                                            None => None::<Spiral_builder::US3>,
                                            Some(v88_0_0) => {
                                                let x_7: string = v88_0_0.clone();
                                                Some((Func0::new({
                                                    let x_7 = x_7.clone();
                                                    move || Spiral_builder::US3::US3_0(x_7.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v89.set(x_9)
                                    }
                                    Spiral_builder::US31::US31_0(defaultValue(
                                        Spiral_builder::US3::US3_1,
                                        _v89.get().clone(),
                                    ))
                                }
                                _ => Spiral_builder::US31::US31_1,
                            };
                            let v105: Spiral_builder::US3 =
                                if let Spiral_builder::US31::US31_0(v98_0_0) = &v98 {
                                    let v99: Spiral_builder::US3 = match &v98 {
                                        Spiral_builder::US31::US31_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    };
                                    if let Spiral_builder::US3::US3_0(v99_0_0) = &v99 {
                                        Spiral_builder::US3::US3_0(match &v99 {
                                            Spiral_builder::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    } else {
                                        Spiral_builder::US3::US3_1
                                    }
                                } else {
                                    Spiral_builder::US3::US3_1
                                };
                            match &v105 {
                                Spiral_builder::US3::US3_0(v105_0_0) => {
                                    Spiral_builder::US35::US35_0(
                                        v24,
                                        match &v105 {
                                            Spiral_builder::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    )
                                }
                                _ => Spiral_builder::US35::US35_1,
                            }
                        }
                    }
                }
                Spiral_builder::US34::US34_1(v6_1_0) => {
                    Spiral_builder::method5(
                        Spiral_builder::US0::US0_4,
                        Func0::new(move || Spiral_builder::closure84((), ())),
                        Func0::new({
                            let v6 = v6.clone();
                            move || {
                                Spiral_builder::closure85(
                                    match &v6 {
                                        Spiral_builder::US34::US34_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                    );
                    Spiral_builder::US35::US35_1
                }
            };
            match &v117 {
                Spiral_builder::US35::US35_0(v117_0_0, v117_0_1) => Some((
                    match &v117 {
                        Spiral_builder::US35::US35_0(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    match &v117 {
                        Spiral_builder::US35::US35_0(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                )),
                _ => None::<(string, string)>,
            }
        }
        pub fn method106(
        ) -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<(string, string)>>
        {
            Func1::new(move |v: Result<async_walkdir::DirEntry, std::io::Error>| {
                Spiral_builder::closure81((), v)
            })
        }
        pub fn closure86(unitVar: (), _arg: (string, string)) -> (string, string) {
            (_arg.0.clone(), _arg.1.clone())
        }
        pub fn closure87(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_typescript")
        }
        pub fn closure88(v0_1: Spiral_builder::US35, unitVar: ()) -> string {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{:#?}", v0_1);
                _v1.set(Some(x))
            }
            sprintf!(
                "version: {} / {}",
                match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                },
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure89(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "spiral_builder.process_typescript / exit_code: {} / dotnet_fable_result: {}",
                v1_1,
                v0_1
            )
        }
        pub fn method107() -> string {
            string("")
        }
        pub fn closure90(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_typescript")
        }
        pub fn closure91(v0_1: string, unitVar: ()) -> string {
            sprintf!(
                "new_code_path: {} / {}",
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure92(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32))),
            )
        }
        pub fn closure94(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_typescript / Exception")
        }
        pub fn closure95(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "ex: {} / new_code_path: {} / external_command: {} / run_result: {} / {}",
                v3,
                v0_1,
                v2,
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure93(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US3 {
            Spiral_builder::method5(
                Spiral_builder::US0::US0_4,
                Func0::new(move || Spiral_builder::closure94((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    move || {
                        Spiral_builder::closure95(
                            v0_1.clone(),
                            v1_1.clone(),
                            v2.clone(),
                            v3.clone(),
                            (),
                        )
                    }
                }),
            );
            Spiral_builder::US3::US3_1
        }
        pub fn closure96(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_typescript / error")
        }
        pub fn closure97(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / new_code_path: {} / external_command: {} / run_result: {}",
                v2,
                v0_1,
                v3,
                v1_1
            )
        }
        pub fn closure98(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "spiral_builder.process_python / exit_code: {} / dotnet_fable_result: {}",
                v1_1,
                v0_1
            )
        }
        pub fn closure99(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_python")
        }
        pub fn closure100(v0_1: string, unitVar: ()) -> string {
            sprintf!(
                "new_code_path: {} / {}",
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure101(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32))),
            )
        }
        pub fn closure103(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_python / Exception")
        }
        pub fn closure104(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
            unitVar: (),
        ) -> string {
            sprintf!(
                "ex: {} / new_code_path: {} / external_command: {} / run_result: {} / {}",
                v3,
                v0_1,
                v2,
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure102(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US3 {
            Spiral_builder::method5(
                Spiral_builder::US0::US0_4,
                Func0::new(move || Spiral_builder::closure103((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    move || {
                        Spiral_builder::closure104(
                            v0_1.clone(),
                            v1_1.clone(),
                            v2.clone(),
                            v3.clone(),
                            (),
                        )
                    }
                }),
            );
            Spiral_builder::US3::US3_1
        }
        pub fn closure105(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_python / error")
        }
        pub fn closure106(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / new_code_path: {} / external_command: {} / run_result: {}",
                v2,
                v0_1,
                v3,
                v1_1
            )
        }
        pub fn closure107(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / invalid subcommand")
        }
        pub fn closure108(
            v0_1: clap::ArgMatches,
            v1_1: std::string::String,
            unitVar: (),
        ) -> string {
            sprintf!(
                "subcommand: {} / arg_matches: {:?} / {}",
                v1_1,
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure109(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v3: &str = &*_arg.0.clone();
            let v5: std::string::String = String::from(v3);
            let v7: &str = &*_arg.1.clone();
            LrcPtr::new((v5, String::from(v7)))
        }
        pub fn closure110(unitVar: (), v0_1: serde_json::Error) -> string {
            let _v1: MutCell<Option<std::string::String>> =
                MutCell::new(None::<std::string::String>);
            {
                let x: std::string::String = format!("{}", v0_1);
                _v1.set(Some(x))
            }
            {
                let v11: std::string::String = match &_v1.get().clone() {
                    None => panic!("{}", string("base.run_target / _v1=None"),),
                    Some(_v1_0_0) => _v1_0_0.clone(),
                };
                fable_library_rust::String_::fromString(v11)
            }
        }
        pub fn method108() -> Func1<serde_json::Error, string> {
            Func1::new(move |v: serde_json::Error| Spiral_builder::closure110((), v))
        }
        pub fn method109(v0_1: Result<string, string>) -> Result<string, string> {
            v0_1
        }
        pub fn method10(
            v0_1: Spiral_builder::US0,
            v1_1: clap::ArgMatches,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<string, string>>>> {
            let __result = Box::pin(async move {
                //;
                {
                    let v5: Option<(std::string::String, clap::ArgMatches)> =
                        clap::ArgMatches::subcommand(Box::leak(Box::new(v1_1))).map(|(a, b)| {
                            (
                                Func1::new(move |v: &str| Spiral_builder::closure8((), v))(a),
                                b.clone(),
                            )
                        });
                    let _v6: LrcPtr<MutCell<Option<Spiral_builder::US4>>> =
                        refCell(None::<Spiral_builder::US4>);
                    {
                        let x_2: Option<Spiral_builder::US4> = match &v5 {
                            None => None::<Spiral_builder::US4>,
                            Some(v5_0_0) => {
                                let x: (std::string::String, clap::ArgMatches) = v5_0_0.clone();
                                Some((Func0::new({
                                    let x = x.clone();
                                    move || Spiral_builder::US4::US4_0(x.0.clone(), x.1.clone())
                                }))())
                            }
                        };
                        _v6.set(x_2)
                    }
                    {
                        let v12: Spiral_builder::US4 =
                            defaultValue(Spiral_builder::US4::US4_1, _v6.get().clone());
                        let v2067: Array<(string, string)> = if let Spiral_builder::US4::US4_0(
                            v12_0_0,
                            v12_0_1,
                        ) = &v12
                        {
                            let v14: clap::ArgMatches = match &v12 {
                                Spiral_builder::US4::US4_0(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                            let v13: std::string::String = match &v12 {
                                Spiral_builder::US4::US4_0(x, _) => x.clone(),
                                _ => unreachable!(),
                            };
                            if fable_library_rust::String_::fromString(v13.clone())
                                == string("fsharp")
                            {
                                let v19: string = Spiral_builder::method11();
                                let v21: &str = &*v19;
                                let v23: Option<std::string::String> =
                                    clap::ArgMatches::get_one(&v14.clone(), v21).cloned();
                                let _v24: LrcPtr<MutCell<Option<Spiral_builder::US5>>> =
                                    refCell(None::<Spiral_builder::US5>);
                                {
                                    let x_5: Option<Spiral_builder::US5> = match &v23 {
                                        None => None::<Spiral_builder::US5>,
                                        Some(v23_0_0) => {
                                            let x_3: std::string::String = v23_0_0.clone();
                                            Some((Func0::new({
                                                let x_3 = x_3.clone();
                                                move || Spiral_builder::US5::US5_0(x_3.clone())
                                            }))())
                                        }
                                    };
                                    _v24.set(x_5)
                                }
                                {
                                    let v29: Spiral_builder::US5 = defaultValue(
                                        Spiral_builder::US5::US5_1,
                                        _v24.get().clone(),
                                    );
                                    let v33: std::string::String = match &v29 {
                                        Spiral_builder::US5::US5_0(v29_0_0) => match &v29 {
                                            Spiral_builder::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    };
                                    let v35: string = fable_library_rust::String_::fromString(v33);
                                    let v36: string = Spiral_builder::method12();
                                    let v38: &str = &*v36;
                                    let v40: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v14.clone(), v38).cloned();
                                    let _v41: LrcPtr<MutCell<Option<Spiral_builder::US5>>> =
                                        refCell(None::<Spiral_builder::US5>);
                                    {
                                        let x_8: Option<Spiral_builder::US5> = match &v40 {
                                            None => None::<Spiral_builder::US5>,
                                            Some(v40_0_0) => {
                                                let x_6: std::string::String = v40_0_0.clone();
                                                Some((Func0::new({
                                                    let x_6 = x_6.clone();
                                                    move || Spiral_builder::US5::US5_0(x_6.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v41.set(x_8)
                                    }
                                    {
                                        let v46: Spiral_builder::US5 = defaultValue(
                                            Spiral_builder::US5::US5_1,
                                            _v41.get().clone(),
                                        );
                                        let v53: Spiral_builder::US3 = match &v46 {
                                            Spiral_builder::US5::US5_0(v46_0_0) => {
                                                Spiral_builder::US3::US3_0(
                                                    fable_library_rust::String_::fromString(
                                                        match &v46 {
                                                            Spiral_builder::US5::US5_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        },
                                                    ),
                                                )
                                            }
                                            _ => Spiral_builder::US3::US3_1,
                                        };
                                        new_array(&[(
                                            string("command_result"),
                                            match &v53 {
                                                Spiral_builder::US3::US3_0(v53_0_0) => {
                                                    let v55: clap::Command =
                                                        Spiral_builder::method0();
                                                    let v57: Spiral_builder::US6 =
                                                        Spiral_builder::method13(sprintf!(
                                                            "_ {} --fs-path \"{}\"",
                                                            match &v53 {
                                                                Spiral_builder::US3::US3_0(x) =>
                                                                    x.clone(),
                                                                _ => unreachable!(),
                                                            },
                                                            v35
                                                        ));
                                                    let v63:
                                                                     Array<string> =
                                                                 match &v57 {
                                                                     Spiral_builder::US6::US6_0(v57_0_0)
                                                                     =>
                                                                     v57_0_0.clone(),
                                                                     Spiral_builder::US6::US6_1(v57_1_0)
                                                                     =>
                                                                     panic!("{}",
                                                                            sprintf!("resultm.get / Result value was Error: {}", v57_1_0.clone()),),
                                                                 };
                                                    let v65: Vec<string> = v63.to_vec();
                                                    let v67: bool = true;
                                                    let _result: Vec<_> = v65
                                                        .into_iter()
                                                        .map(|x| {
                                                            //;
                                                            let v69: string = x;
                                                            let v71: &str = &*v69;
                                                            let v73: std::string::String =
                                                                String::from(v71);
                                                            let v75: bool = true;
                                                            v73
                                                        })
                                                        .collect::<Vec<_>>();
                                                    let v77: Vec<std::string::String> = _result;
                                                    let v80: std::pin::Pin<
                                                        Box<
                                                            dyn std::future::Future<
                                                                Output = Result<string, string>,
                                                            >,
                                                        >,
                                                    > = Spiral_builder::method10(
                                                        v0_1.clone(),
                                                        clap::Command::get_matches_from(v55, v77),
                                                    );
                                                    let v82: Result<string, string> = v80.await;
                                                    v82.unwrap()
                                                }
                                                _ => string("{}"),
                                            },
                                        )])
                                    }
                                }
                            } else {
                                if fable_library_rust::String_::fromString(v13.clone())
                                    == string("dib")
                                {
                                    let v94: string = Spiral_builder::method27();
                                    let v96: &str = &*v94;
                                    let v100: Option<string> = map_1(
                                        Func1::new(move |v_1: std::string::String| {
                                            Spiral_builder::closure13((), v_1)
                                        }),
                                        clap::ArgMatches::get_one(&v14.clone(), v96).cloned(),
                                    );
                                    let v102: string = v100.unwrap();
                                    let v103: string = Spiral_builder::method41();
                                    let v105: &str = &*v103;
                                    let v108: u8 = defaultValue(
                                        1_u8,
                                        clap::ArgMatches::get_one(&v14.clone(), v105).cloned(),
                                    );
                                    let v109: string = Spiral_builder::method42();
                                    let v111: &str = &*v109;
                                    let patternInput: (i32, string) = Spiral_builder::method43(
                                        clap::ArgMatches::get_one(&v14.clone(), v111).cloned(),
                                        v108,
                                        v102.clone(),
                                        1_u8,
                                    );
                                    let v116: string = patternInput.1.clone();
                                    let v115: i32 = patternInput.0.clone();
                                    let patternInput_3: (i32, string) = if v115 != 0_i32 {
                                        (v115, v116.clone())
                                    } else {
                                        let patternInput_1:
                                                    (i32, string) =
                                                Spiral_builder::method44(None::<CancellationToken>,
                                                                         sprintf!("jupyter nbconvert \"{}.ipynb\" --to html --HTMLExporter.theme=dark",
                                                                                  v102.clone()),
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
                                        let v126: string = patternInput_1.1.clone();
                                        let v125: i32 = patternInput_1.0.clone();
                                        Spiral_builder::method5(
                                            Spiral_builder::US0::US0_1,
                                            Func0::new(move || Spiral_builder::closure42((), ())),
                                            Func0::new({
                                                let v125 = v125.clone();
                                                let v126 = v126.clone();
                                                move || {
                                                    Spiral_builder::closure43(
                                                        v126.clone(),
                                                        v125,
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        if v125 != 0_i32 {
                                            (
                                                v125,
                                                sprintf!(
                                                    "repl_result: {}\n\njupyter_result: {}",
                                                    v116.clone(),
                                                    v126.clone()
                                                ),
                                            )
                                        } else {
                                            let patternInput_2:
                                                        (i32, string) =
                                                    Spiral_builder::method44(None::<CancellationToken>,
                                                                             sprintf!("pwsh -c \"$counter = 1; $path = \'{}.html\'; (Get-Content $path -Raw) -replace \'(id=\\\"cell-id=)[a-fA-F0-9]{{8}}\', {{ $_.Groups[1].Value + $counter++ }} | Set-Content $path\"",
                                                                                      replace(v102.clone(),
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
                                            let v143: string = patternInput_2.1.clone();
                                            let v142: i32 = patternInput_2.0.clone();
                                            Spiral_builder::method5(
                                                Spiral_builder::US0::US0_1,
                                                Func0::new(move || {
                                                    Spiral_builder::closure44((), ())
                                                }),
                                                Func0::new({
                                                    let v142 = v142.clone();
                                                    let v143 = v143.clone();
                                                    move || {
                                                        Spiral_builder::closure45(
                                                            v143.clone(),
                                                            v142,
                                                            (),
                                                        )
                                                    }
                                                }),
                                            );
                                            {
                                                let v147: string =
                                                    sprintf!("{}.html", v102.clone());
                                                let _v148: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let _v149: MutCell<Option<Vec<u8>>> =
                                                    MutCell::new(None::<Vec<u8>>);
                                                {
                                                    let x_9: Vec<u8> =
                                                        std::fs::read(&*v147).unwrap();
                                                    _v149.set(Some(x_9))
                                                }
                                                {
                                                    let v159: Vec<u8> = match &_v149.get().clone() {
                                                        None => panic!(
                                                            "{}",
                                                            string("base.run_target / _v149=None"),
                                                        ),
                                                        Some(_v149_0_0) => _v149_0_0.clone(),
                                                    };
                                                    let v161: Result<
                                                        std::string::String,
                                                        std::string::FromUtf8Error,
                                                    > = std::string::String::from_utf8(v159);
                                                    let v163: std::string::String = v161.unwrap();
                                                    {
                                                        let x_11: string =
                                                            fable_library_rust::String_::fromString(
                                                                v163,
                                                            );
                                                        _v148.set(Some(x_11))
                                                    }
                                                    {
                                                        let v174: string =
                                                                replace(match &_v148.get().clone()
                                                                            {
                                                                            None
                                                                            =>
                                                                            panic!("{}",
                                                                                   string("base.run_target / _v148=None"),),
                                                                            Some(_v148_0_0)
                                                                            =>
                                                                            _v148_0_0.clone(),
                                                                        },
                                                                        string("\r\n"),
                                                                        string("\n"));
                                                        let v175: string =
                                                            sprintf!("{}.html", v102.clone());
                                                        let _v176: MutCell<Option<()>> =
                                                            MutCell::new(None::<()>);
                                                        std::fs::write(&*v175, &*v174).unwrap();
                                                        _v176.set(Some(()));
                                                        match &_v176.get().clone() {
                                                            None => panic!(
                                                                "{}",
                                                                string(
                                                                    "base.run_target / _v176=None"
                                                                ),
                                                            ),
                                                            Some(_v176_0_0) => _v176_0_0.clone(),
                                                        }
                                                        {
                                                            let v179: string =
                                                                sprintf!("{}.ipynb", v102.clone());
                                                            let _v180: MutCell<Option<string>> =
                                                                MutCell::new(None::<string>);
                                                            let _v181: MutCell<Option<Vec<u8>>> =
                                                                MutCell::new(None::<Vec<u8>>);
                                                            {
                                                                let x_15: Vec<u8> =
                                                                    std::fs::read(&*v179).unwrap();
                                                                _v181.set(Some(x_15))
                                                            }
                                                            {
                                                                let v191:
                                                                            Vec<u8> =
                                                                        match &_v181.get().clone()
                                                                            {
                                                                            None
                                                                            =>
                                                                            panic!("{}",
                                                                                   string("base.run_target / _v181=None"),),
                                                                            Some(_v181_0_0)
                                                                            =>
                                                                            _v181_0_0.clone(),
                                                                        };
                                                                let v193: Result<
                                                                    std::string::String,
                                                                    std::string::FromUtf8Error,
                                                                > = std::string::String::from_utf8(
                                                                    v191,
                                                                );
                                                                let v195: std::string::String =
                                                                    v193.unwrap();
                                                                {
                                                                    let x_17:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v195);
                                                                    _v180.set(Some(x_17))
                                                                }
                                                                {
                                                                    let v206:
                                                                                string =
                                                                            replace(match &_v180.get().clone()
                                                                                        {
                                                                                        None
                                                                                        =>
                                                                                        panic!("{}",
                                                                                               string("base.run_target / _v180=None"),),
                                                                                        Some(_v180_0_0)
                                                                                        =>
                                                                                        _v180_0_0.clone(),
                                                                                    },
                                                                                    string("\\r\\n"),
                                                                                    string("\\n"));
                                                                    let v207: string =
                                                                        sprintf!("{}.ipynb", v102);
                                                                    let _v208: MutCell<Option<()>> =
                                                                        MutCell::new(None::<()>);
                                                                    std::fs::write(&*v207, &*v206)
                                                                        .unwrap();
                                                                    _v208.set(Some(()));
                                                                    match &_v208.get().clone()
                                                                            {
                                                                            None
                                                                            =>
                                                                            panic!("{}",
                                                                                   string("base.run_target / _v208=None"),),
                                                                            Some(_v208_0_0)
                                                                            =>
                                                                            _v208_0_0.clone(),
                                                                        }
                                                                    (v142,
                                                                         sprintf!("repl_result: {}\n\njupyter_result: {}\n\npwsh_replace_html_result: {}",
                                                                                  v116,
                                                                                  v126.clone(),
                                                                                  v143.clone()))
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    };
                                    let v215: string = patternInput_3.1.clone();
                                    let v214: i32 = patternInput_3.0.clone();
                                    Spiral_builder::method5(
                                        Spiral_builder::US0::US0_1,
                                        Func0::new(move || Spiral_builder::closure46((), ())),
                                        Func0::new({
                                            let v214 = v214.clone();
                                            let v215 = v215.clone();
                                            move || {
                                                Spiral_builder::closure47(v215.clone(), v214, ())
                                            }
                                        }),
                                    );
                                    if v214 != 0_i32 {
                                        panic!("{}",
                                               sprintf!("spiral_builder.run / dib / exit_code: {} / result: {} / {}", v214,
         v215.clone(), Spiral_builder::closure6((), ())));
                                    }
                                    new_array(&[(string("stdio"), v215.clone())])
                                } else {
                                    let patternInput_14: (
                                        Spiral_builder::US3,
                                        Spiral_builder::US3,
                                        Spiral_builder::US3,
                                    ) = if fable_library_rust::String_::fromString(v13.clone())
                                        == string("rust")
                                    {
                                        let v228: string = Spiral_builder::method11();
                                        let v230: &str = &*v228;
                                        let v232: Option<std::string::String> =
                                            clap::ArgMatches::get_one(&v14.clone(), v230).cloned();
                                        let _v233: LrcPtr<MutCell<Option<Spiral_builder::US5>>> =
                                            refCell(None::<Spiral_builder::US5>);
                                        {
                                            let x_23: Option<Spiral_builder::US5> = match &v232 {
                                                None => None::<Spiral_builder::US5>,
                                                Some(v232_0_0) => {
                                                    let x_21: std::string::String =
                                                        v232_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_21 = x_21.clone();
                                                        move || {
                                                            Spiral_builder::US5::US5_0(x_21.clone())
                                                        }
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v233.set(x_23)
                                        }
                                        {
                                            let v238: Spiral_builder::US5 = defaultValue(
                                                Spiral_builder::US5::US5_1,
                                                _v233.get().clone(),
                                            );
                                            let v242: std::string::String = match &v238 {
                                                Spiral_builder::US5::US5_0(v238_0_0) => match &v238
                                                {
                                                    Spiral_builder::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                _ => panic!(
                                                    "{}",
                                                    string("Option does not have a value."),
                                                ),
                                            };
                                            let v244: string =
                                                fable_library_rust::String_::fromString(v242);
                                            let v245: string = Spiral_builder::method66();
                                            let v247: &str = &*v245;
                                            let v249: Option<Vec<std::string::String>> =
                                                clap::ArgMatches::get_many(&v14.clone(), v247)
                                                    .map(|x| x.cloned().into_iter().collect());
                                            let _v250: LrcPtr<
                                                MutCell<Option<Spiral_builder::US25>>,
                                            > = refCell(None::<Spiral_builder::US25>);
                                            {
                                                let x_26: Option<Spiral_builder::US25> = match &v249
                                                {
                                                    None => None::<Spiral_builder::US25>,
                                                    Some(v249_0_0) => {
                                                        let x_24: Vec<std::string::String> =
                                                            v249_0_0.clone();
                                                        Some((Func0::new({
                                                            let x_24 = x_24.clone();
                                                            move || {
                                                                Spiral_builder::US25::US25_0(
                                                                    x_24.clone(),
                                                                )
                                                            }
                                                        }))(
                                                        ))
                                                    }
                                                };
                                                _v250.set(x_26)
                                            }
                                            {
                                                let v255: Spiral_builder::US25 = defaultValue(
                                                    Spiral_builder::US25::US25_1,
                                                    _v250.get().clone(),
                                                );
                                                let v258: Vec<std::string::String> =
                                                    new_empty::<std::string::String>().to_vec();
                                                let v261: Vec<std::string::String> = match &v255 {
                                                    Spiral_builder::US25::US25_0(v255_0_0) => {
                                                        match &v255 {
                                                            Spiral_builder::US25::US25_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        }
                                                    }
                                                    _ => v258,
                                                };
                                                let v263: bool =
                                                    if let Spiral_builder::US0::US0_0 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    };
                                                let _v264: MutCell<Option<string>> =
                                                    MutCell::new(None::<string>);
                                                let _v265: MutCell<Option<Vec<u8>>> =
                                                    MutCell::new(None::<Vec<u8>>);
                                                {
                                                    let x_27: Vec<u8> =
                                                        std::fs::read(&*v244).unwrap();
                                                    _v265.set(Some(x_27))
                                                }
                                                {
                                                    let v275: Vec<u8> = match &_v265.get().clone() {
                                                        None => panic!(
                                                            "{}",
                                                            string("base.run_target / _v265=None"),
                                                        ),
                                                        Some(_v265_0_0) => _v265_0_0.clone(),
                                                    };
                                                    let v277: Result<
                                                        std::string::String,
                                                        std::string::FromUtf8Error,
                                                    > = std::string::String::from_utf8(v275);
                                                    let v279: std::string::String = v277.unwrap();
                                                    {
                                                        let x_29: string =
                                                            fable_library_rust::String_::fromString(
                                                                v279,
                                                            );
                                                        _v264.set(Some(x_29))
                                                    }
                                                    {
                                                        let v287: string = match &_v264
                                                            .get()
                                                            .clone()
                                                        {
                                                            None => panic!(
                                                                "{}",
                                                                string(
                                                                    "base.run_target / _v264=None"
                                                                ),
                                                            ),
                                                            Some(_v264_0_0) => _v264_0_0.clone(),
                                                        };
                                                        let v290: string =
                                                            Spiral_builder::method67(sprintf!(
                                                                "{:?}",
                                                                (string("rs"), v287.clone())
                                                            ));
                                                        let v303: string =
                                                                Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method69(Spiral_builder::method30(string("polyglot"),
                                                                                                                                                                                                                                               string(".paket")),
                                                                                                                                                                                                                      string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\spiral_builder")),
                                                                                                                                                                                             string("polyglot")),
                                                                                                                                                                    string("target/polyglot/spiral_builder")),
                                                                                                                                           string("spiral_builder")),
                                                                                                                  string("packages")),
                                                                                         v290.clone());
                                                        let v304: LrcPtr<dyn IDisposable> =
                                                            Spiral_builder::method74(v303.clone());
                                                        let v306: string = Spiral_builder::method30(
                                                            v303.clone(),
                                                            sprintf!(
                                                                "{}.fs",
                                                                string("spiral_builder")
                                                            ),
                                                        );
                                                        let v307: string =
                                                            Spiral_builder::method36();
                                                        let _v308: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let v309: string =
                                                            Spiral_builder::method37(v306);
                                                        let v312: Result<
                                                            regex::Regex,
                                                            regex::Error,
                                                        > = regex::Regex::new(&string(
                                                            "^\\\\\\\\\\?\\\\",
                                                        ));
                                                        let v314: regex::Regex = v312.unwrap();
                                                        let v316: std::borrow::Cow<str> =
                                                            v314.replace_all(&v309, &*v307);
                                                        let v318: std::string::String =
                                                            String::from(v316);
                                                        {
                                                            let x_31:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v318);
                                                            _v308.set(Some(x_31))
                                                        }
                                                        {
                                                            let v327:
                                                                        string =
                                                                    match &_v308.get().clone()
                                                                        {
                                                                        None
                                                                        =>
                                                                        panic!("{}",
                                                                               string("base.run_target / _v308=None"),),
                                                                        Some(_v308_0_0)
                                                                        =>
                                                                        _v308_0_0.clone(),
                                                                    };
                                                            let v331: string = replace(
                                                                sprintf!(
                                                                    "{}{}",
                                                                    toLower(ofChar(getCharAt(
                                                                        v327.clone(),
                                                                        0_i32
                                                                    ))),
                                                                    getSlice(
                                                                        v327,
                                                                        Some(1_i32),
                                                                        None::<i32>
                                                                    )
                                                                ),
                                                                string("\\"),
                                                                string("/"),
                                                            );
                                                            if Spiral_builder::method84(
                                                                v331.clone(),
                                                                v287.clone(),
                                                            ) == false
                                                            {
                                                                let _v334: MutCell<Option<()>> =
                                                                    MutCell::new(None::<()>);
                                                                std::fs::write(
                                                                    &*v331.clone(),
                                                                    &*v287,
                                                                )
                                                                .unwrap();
                                                                _v334.set(Some(()));
                                                                match &_v334.get().clone()
                                                                        {
                                                                        None
                                                                        =>
                                                                        panic!("{}",
                                                                               string("base.run_target / _v334=None"),),
                                                                        Some(_v334_0_0)
                                                                        =>
                                                                        _v334_0_0.clone(),
                                                                    }
                                                                ()
                                                            }
                                                            {
                                                                let v337: List<string> =
                                                                    empty::<string>();
                                                                let v342: string = join(
                                                                    string("\\n        "),
                                                                    toArray_1(delay(Func0::new({
                                                                        let v337 = v337.clone();
                                                                        move || {
                                                                            map(
                                                                                Func1::new({
                                                                                    let v337 = v337
                                                                                        .clone();
                                                                                    move |i: i32| {
                                                                                        item(i,
                                                                                                                                            v337.clone())
                                                                                    }
                                                                                }),
                                                                                rangeNumeric(
                                                                                    0_i32,
                                                                                    1_i32,
                                                                                    length_1(
                                                                                        v337.clone(
                                                                                        ),
                                                                                    ) - 1_i32,
                                                                                ),
                                                                            )
                                                                        }
                                                                    }))),
                                                                );
                                                                let v346:
                                                                            List<string> =
                                                                        singleton(sprintf!("<PackageReference Include=\"{}\" Version=\"*\" />",
                                                                                           string("Fable.Core")));
                                                                let v350: string = join(
                                                                    string("\\n        "),
                                                                    toArray_1(delay(Func0::new({
                                                                        let v346 = v346.clone();
                                                                        move || {
                                                                            map(
                                                                                Func1::new({
                                                                                    let v346 = v346
                                                                                        .clone();
                                                                                    move
                                                                                                                                       |i_1:
                                                                                                                                            i32|
                                                                                                                                       item(i_1,
                                                                                                                                            v346.clone())
                                                                                }),
                                                                                rangeNumeric(
                                                                                    0_i32,
                                                                                    1_i32,
                                                                                    length_1(
                                                                                        v346.clone(
                                                                                        ),
                                                                                    ) - 1_i32,
                                                                                ),
                                                                            )
                                                                        }
                                                                    }))),
                                                                );
                                                                let v352: string =
                                                                    Spiral_builder::method30(
                                                                        v303,
                                                                        sprintf!(
                                                                            "{}.fsproj",
                                                                            string(
                                                                                "spiral_builder"
                                                                            )
                                                                        ),
                                                                    );
                                                                let v353: string =
                                                                    Spiral_builder::method36();
                                                                let _v354: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let v355: string =
                                                                    Spiral_builder::method37(v352);
                                                                let v357: Result<
                                                                    regex::Regex,
                                                                    regex::Error,
                                                                > = regex::Regex::new(&string(
                                                                    "^\\\\\\\\\\?\\\\",
                                                                ));
                                                                let v359: regex::Regex =
                                                                    v357.unwrap();
                                                                let v361: std::borrow::Cow<str> =
                                                                    v359.replace_all(&v355, &*v353);
                                                                let v363: std::string::String =
                                                                    String::from(v361);
                                                                {
                                                                    let x_35:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v363);
                                                                    _v354.set(Some(x_35))
                                                                }
                                                                {
                                                                    let v372:
                                                                                string =
                                                                            match &_v354.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v354=None"),),
                                                                                Some(_v354_0_0)
                                                                                =>
                                                                                _v354_0_0.clone(),
                                                                            };
                                                                    let v374: string = replace(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            toLower(ofChar(
                                                                                getCharAt(
                                                                                    v372.clone(),
                                                                                    0_i32
                                                                                )
                                                                            )),
                                                                            getSlice(
                                                                                v372,
                                                                                Some(1_i32),
                                                                                None::<i32>
                                                                            )
                                                                        ),
                                                                        string("\\"),
                                                                        string("/"),
                                                                    );
                                                                    let v472:
                                                                                string =
                                                                            append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                       sprintf!("    {}",
                                                                                                                                                                                v342)),
                                                                                                                                                                string("\n")),
                                                                                                                                                         sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                                  v331)),
                                                                                                                                                  string("\n")),
                                                                                                                                           string("</ItemGroup>")),
                                                                                                                                    string("\n")),
                                                                                                                             string("<ItemGroup>")),
                                                                                                                      string("\n")),
                                                                                                               sprintf!("    {}",
                                                                                                                        v350)),
                                                                                                        string("\n")),
                                                                                                 string("</ItemGroup>")),
                                                                                          string("\n")),
                                                                                   string("</Project>"));
                                                                    if Spiral_builder::method84(
                                                                        v374.clone(),
                                                                        v472.clone(),
                                                                    ) == false
                                                                    {
                                                                        let _v475: MutCell<
                                                                            Option<()>,
                                                                        > = MutCell::new(
                                                                            None::<()>,
                                                                        );
                                                                        std::fs::write(
                                                                            &*v374.clone(),
                                                                            &*v472,
                                                                        )
                                                                        .unwrap();
                                                                        _v475.set(Some(()));
                                                                        match &_v475.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v475=None"),),
                                                                                Some(_v475_0_0)
                                                                                =>
                                                                                _v475_0_0.clone(),
                                                                            }
                                                                        ()
                                                                    }
                                                                    {
                                                                        let v478:
                                                                                    string =
                                                                                Spiral_builder::method86(v374.clone());
                                                                        let v480:
                                                                                    string =
                                                                                Spiral_builder::method30(v478.clone(),
                                                                                                         string("Cargo.toml"));
                                                                        let v482:
                                                                                    string =
                                                                                Spiral_builder::method30(v478.clone(),
                                                                                                         string("../.."));
                                                                        let v483:
                                                                                    string =
                                                                                Spiral_builder::method30(v482.clone(),
                                                                                                         string("Cargo.toml"));
                                                                        if Spiral_builder::method85(
                                                                            v480.clone(),
                                                                        ) == false
                                                                        {
                                                                            let v486: DateTime =
                                                                                DateTime::now();
                                                                            let v491:
                                                                                        string =
                                                                                    toString(Spiral_builder::method87(new_guid(),
                                                                                                                      v486));
                                                                            let v513:
                                                                                        string =
                                                                                    append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                                               sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                                        v491.clone())),
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
                                                                                                                  v491)),
                                                                                                  string("\n")),
                                                                                           sprintf!("path = \"spiral_builder.{}\"",
                                                                                                    string("rs")));
                                                                            if Spiral_builder::method84(v480.clone(),
                                                                                                            v513.clone())
                                                                                       ==
                                                                                       false
                                                                                   {
                                                                                    let _v516:
                                                                                            MutCell<Option<()>> =
                                                                                        MutCell::new(None::<()>);
                                                                                    std::fs::write(&*v480.clone(), &*v513).unwrap();
                                                                                    _v516.set(Some(()));
                                                                                    match &_v516.get().clone()
                                                                                        {
                                                                                        None
                                                                                        =>
                                                                                        panic!("{}",
                                                                                               string("base.run_target / _v516=None"),),
                                                                                        Some(_v516_0_0)
                                                                                        =>
                                                                                        _v516_0_0.clone(),
                                                                                    }
                                                                                    ()
                                                                                }
                                                                        }
                                                                        if Spiral_builder::method85(
                                                                            v483.clone(),
                                                                        ) == false
                                                                        {
                                                                            let v521: DateTime =
                                                                                DateTime::now();
                                                                            let v526:
                                                                                        string =
                                                                                    toString(Spiral_builder::method87(new_guid(),
                                                                                                                      v521));
                                                                            let v548:
                                                                                        string =
                                                                                    append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                                               sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                                        v526.clone())),
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
                                                                                                                  v526)),
                                                                                                  string("\n")),
                                                                                           sprintf!("path = \"spiral_builder.{}\"",
                                                                                                    string("rs")));
                                                                            if Spiral_builder::method84(v483.clone(),
                                                                                                            v548.clone())
                                                                                       ==
                                                                                       false
                                                                                   {
                                                                                    let _v551:
                                                                                            MutCell<Option<()>> =
                                                                                        MutCell::new(None::<()>);
                                                                                    std::fs::write(&*v483.clone(), &*v548).unwrap();
                                                                                    _v551.set(Some(()));
                                                                                    match &_v551.get().clone()
                                                                                        {
                                                                                        None
                                                                                        =>
                                                                                        panic!("{}",
                                                                                               string("base.run_target / _v551=None"),),
                                                                                        Some(_v551_0_0)
                                                                                        =>
                                                                                        _v551_0_0.clone(),
                                                                                    }
                                                                                    ()
                                                                                }
                                                                        }
                                                                        {
                                                                            let v557:
                                                                                        string =
                                                                                    Spiral_builder::method30(Spiral_builder::method69(Spiral_builder::method30(string("polyglot"),
                                                                                                                                                               string(".paket")),
                                                                                                                                      string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\spiral_builder")),
                                                                                                             string("polyglot"));
                                                                            let v560:
                                                                                        string =
                                                                                    toLower(Spiral_builder::method29());
                                                                            let v562: string =
                                                                                toLower(v557);
                                                                            let v566:
                                                                                        Spiral_builder::US28 =
                                                                                    if startsWith(v560,
                                                                                                  v562.clone(),
                                                                                                  false)
                                                                                       {
                                                                                        Spiral_builder::US28::US28_1(v562.clone())
                                                                                    } else {
                                                                                        Spiral_builder::US28::US28_0(v562)
                                                                                    };
                                                                            let v572:
                                                                                        Result<string,
                                                                                               string> =
                                                                                    match &v566
                                                                                        {
                                                                                        Spiral_builder::US28::US28_0(v566_0_0)
                                                                                        =>
                                                                                        Ok::<string,
                                                                                             string>(v566_0_0.clone()),
                                                                                        Spiral_builder::US28::US28_1(v566_1_0)
                                                                                        =>
                                                                                        Err::<string,
                                                                                              string>(v566_1_0.clone()),
                                                                                    };
                                                                            let v574: bool = true;
                                                                            let _result = v572
                                                                                .unwrap_or_else(
                                                                                    |x| {
                                                                                        //;
                                                                                        let v576:
                                                                                        string =
                                                                                    x;
                                                                                        let v578:
                                                                                        bool =
                                                                                    true;
                                                                                        v576
                                                                                    },
                                                                                );
                                                                            let v580: string =
                                                                                _result;
                                                                            let v582:
                                                                                        string =
                                                                                    Spiral_builder::method30(v580.clone(),
                                                                                                             string("lib/rust/fable/fable_modules/fable-library-rust"));
                                                                            let v584:
                                                                                        string =
                                                                                    Spiral_builder::method30(v478.clone(),
                                                                                                             string("fable_modules/fable-library-rust"));
                                                                            if Spiral_builder::method70(v582.clone())
                                                                                       ==
                                                                                       false
                                                                                   {
                                                                                    let v587:
                                                                                            LrcPtr<dyn IDisposable> =
                                                                                        Spiral_builder::method74(v582.clone());
                                                                                    ()
                                                                                }
                                                                            {
                                                                                let v588:
                                                                                            string =
                                                                                        Spiral_builder::method86(v584.clone());
                                                                                if Spiral_builder::method70(v588.clone())
                                                                                           ==
                                                                                           false
                                                                                       {
                                                                                        let v591:
                                                                                                LrcPtr<dyn IDisposable> =
                                                                                            Spiral_builder::method74(v588);
                                                                                        ()
                                                                                    }
                                                                                if if Spiral_builder::method70(v584.clone())
                                                                                          {
                                                                                           let v594:
                                                                                                   Result<std::path::PathBuf,
                                                                                                          std::io::Error> =
                                                                                               std::fs::read_link(&*v584.clone());
                                                                                           v594.is_err()
                                                                                       } else {
                                                                                           false
                                                                                       }
                                                                                       {
                                                                                        Spiral_builder::method77(true,
                                                                                                                 v584.clone());
                                                                                    }
                                                                                if Spiral_builder::method70(v584.clone())
                                                                                           ==
                                                                                           false
                                                                                       {
                                                                                        let _v601:
                                                                                                MutCell<Option<()>> =
                                                                                            MutCell::new(None::<()>);
                                                                                        let _v602:
                                                                                                MutCell<Option<()>> =
                                                                                            MutCell::new(None::<()>);
                                                                                        std::os::windows::fs::symlink_dir(&*v582, &*v584.clone()).unwrap();
                                                                                        _v602.set(Some(()));
                                                                                        match &_v602.get().clone()
                                                                                            {
                                                                                            None
                                                                                            =>
                                                                                            panic!("{}",
                                                                                                   string("runtime.run_platform / _v602=None"),),
                                                                                            Some(_v602_0_0)
                                                                                            =>
                                                                                            _v602_0_0.clone(),
                                                                                        }
                                                                                        _v601.set(Some(()));
                                                                                        match &_v601.get().clone()
                                                                                            {
                                                                                            None
                                                                                            =>
                                                                                            panic!("{}",
                                                                                                   string("base.run_target / _v601=None"),),
                                                                                            Some(_v601_0_0)
                                                                                            =>
                                                                                            _v601_0_0.clone(),
                                                                                        }
                                                                                        ()
                                                                                    }
                                                                                {
                                                                                    let patternInput_4:
                                                                                                (i32,
                                                                                                 string) =
                                                                                            Spiral_builder::method93(v478.clone(),
                                                                                                                     string("rs"),
                                                                                                                     v374,
                                                                                                                     v566.clone());
                                                                                    let v609:
                                                                                                string =
                                                                                            patternInput_4.1.clone();
                                                                                    let v608:
                                                                                                i32 =
                                                                                            patternInput_4.0.clone();
                                                                                    if v608 != 0_i32
                                                                                    {
                                                                                        Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                    Func0::new(move
                                                                                                                                   ||
                                                                                                                                   Spiral_builder::closure64((),
                                                                                                                                                             ())),
                                                                                                                    Func0::new({
                                                                                                                                   let v608
                                                                                                                                       =
                                                                                                                                       v608.clone();
                                                                                                                                   let v609
                                                                                                                                       =
                                                                                                                                       v609.clone();
                                                                                                                                   move
                                                                                                                                       ||
                                                                                                                                       Spiral_builder::closure65(v609.clone(),
                                                                                                                                                                 v608,
                                                                                                                                                                 ())
                                                                                                                               }));
                                                                                        (Spiral_builder::US3::US3_1,
                                                                                             Spiral_builder::US3::US3_0(string("rs")),
                                                                                             Spiral_builder::US3::US3_0(v609.clone()))
                                                                                    } else {
                                                                                        let v618:
                                                                                                    bool =
                                                                                                true;
                                                                                        let _result : Vec<_> = v261.into_iter().map(|x| { //;
                                                                                            let v620:
                                                                                                    std::string::String =
                                                                                                x;
                                                                                            let v622:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromString(v620);
                                                                                            let v633:
                                                                                                    string =
                                                                                                if contains(v622.clone(),
                                                                                                            string("="))
                                                                                                   {
                                                                                                    v622.clone()
                                                                                                } else {
                                                                                                    if endsWith(v622.clone(),
                                                                                                                string("]"),
                                                                                                                false)
                                                                                                       {
                                                                                                        sprintf!("{}}}",
                                                                                                                 replace(v622.clone(),
                                                                                                                         string("["),
                                                                                                                         string("={version=\'*\',features=[")))
                                                                                                    } else {
                                                                                                        sprintf!("{}=\'*\'",
                                                                                                                 v622)
                                                                                                    }
                                                                                                };
                                                                                            let v635:
                                                                                                    bool =
                                                                                                true; v633 }).collect::<Vec<_>>();
                                                                                        let v637:
                                                                                                    Vec<string> =
                                                                                                _result;
                                                                                        let v639:
                                                                                                    Array<string> =
                                                                                                fable_library_rust::NativeArray_::array_from(v637);
                                                                                        let v680:
                                                                                                    string =
                                                                                                append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                                                                                                                                 sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                                                                                                                          v290.clone())),
                                                                                                                                                                                                                                                          string("\n")),
                                                                                                                                                                                                                                                   string("version = \"0.0.1\"")),
                                                                                                                                                                                                                                            string("\n")),
                                                                                                                                                                                                                                     string("edition = \"2021\"")),
                                                                                                                                                                                                                              string("\n")),
                                                                                                                                                                                                                       string("")),
                                                                                                                                                                                                                string("\n")),
                                                                                                                                                                                                         string("[dependencies]")),
                                                                                                                                                                                                  string("\n")),
                                                                                                                                                                                           string("fable_library_rust = { workspace = true }")),
                                                                                                                                                                                    string("\n")),
                                                                                                                                                                             string("inline_colorization = { workspace = true }")),
                                                                                                                                                                      string("\n")),
                                                                                                                                                               sprintf!("{}",
                                                                                                                                                                        join(string("\n"),
                                                                                                                                                                             toArray_1(delay(Func0::new({
                                                                                                                                                                                                            let v639
                                                                                                                                                                                                                =
                                                                                                                                                                                                                v639.clone();
                                                                                                                                                                                                            move
                                                                                                                                                                                                                ||
                                                                                                                                                                                                                map(Func1::new({
                                                                                                                                                                                                                                   let v639
                                                                                                                                                                                                                                       =
                                                                                                                                                                                                                                       v639.clone();
                                                                                                                                                                                                                                   move
                                                                                                                                                                                                                                       |i_2:
                                                                                                                                                                                                                                            i32|
                                                                                                                                                                                                                                       v639[i_2].clone()
                                                                                                                                                                                                                               }),
                                                                                                                                                                                                                    rangeNumeric(0_i32,
                                                                                                                                                                                                                                 1_i32,
                                                                                                                                                                                                                                 count_2(v639.clone())
                                                                                                                                                                                                                                     -
                                                                                                                                                                                                                                     1_i32))
                                                                                                                                                                                                        })))))),
                                                                                                                                                        string("\n")),
                                                                                                                                                 string("")),
                                                                                                                                          string("\n")),
                                                                                                                                   string("[[bin]]")),
                                                                                                                            string("\n")),
                                                                                                                     sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                              v290.clone())),
                                                                                                              string("\n")),
                                                                                                       string("path = \"spiral_builder.rs\" "));
                                                                                        let v681:
                                                                                                    string =
                                                                                                Spiral_builder::method36();
                                                                                        let _v682:
                                                                                                    MutCell<Option<string>> =
                                                                                                MutCell::new(None::<string>);
                                                                                        let v683:
                                                                                                    string =
                                                                                                Spiral_builder::method37(v580);
                                                                                        let v685:
                                                                                                    Result<regex::Regex,
                                                                                                           regex::Error> =
                                                                                                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
                                                                                        let v687:
                                                                                                    regex::Regex =
                                                                                                v685.unwrap();
                                                                                        let v689:
                                                                                                    std::borrow::Cow<str> =
                                                                                                v687.replace_all(&v683, &*v681);
                                                                                        let v691:
                                                                                                    std::string::String =
                                                                                                String::from(v689);
                                                                                        {
                                                                                            let x_47:
                                                                                                        string =
                                                                                                    fable_library_rust::String_::fromString(v691);
                                                                                            _v682.set(Some(x_47))
                                                                                        }
                                                                                        {
                                                                                            let v700:
                                                                                                        string =
                                                                                                    match &_v682.get().clone()
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        panic!("{}",
                                                                                                               string("base.run_target / _v682=None"),),
                                                                                                        Some(_v682_0_0)
                                                                                                        =>
                                                                                                        _v682_0_0.clone(),
                                                                                                    };
                                                                                            let v733:
                                                                                                        string =
                                                                                                    append(append(append(append(append(append(append(append(append(append(append(string("[workspace]\nresolver = \"2\"\nmembers = [\"packages/*\"]\n\n[workspace.dependencies.fable_library_rust]\n"),
                                                                                                                                                                                 sprintf!("path = \"{}/lib/rust/fable/fable_modules/fable-library-rust\"",
                                                                                                                                                                                          replace(sprintf!("{}{}",
                                                                                                                                                                                                           toLower(ofChar(getCharAt(v700.clone(),
                                                                                                                                                                                                                                    0_i32))),
                                                                                                                                                                                                           getSlice(v700,
                                                                                                                                                                                                                    Some(1_i32),
                                                                                                                                                                                                                    None::<i32>)),
                                                                                                                                                                                                  string("\\"),
                                                                                                                                                                                                  string("/")))),
                                                                                                                                                                          string("\n")),
                                                                                                                                                                   string("default-features = false")),
                                                                                                                                                            string("\n")),
                                                                                                                                                     string("features = [\"static_do_bindings\", \"datetime\", \"guid\", \"threaded\"]")),
                                                                                                                                              string("\n")),
                                                                                                                                       string("")),
                                                                                                                                string("\n")),
                                                                                                                         string("[workspace.dependencies]")),
                                                                                                                  string("\n")),
                                                                                                           string("inline_colorization = \"~0.1\""));
                                                                                            if Spiral_builder::method84(v480.clone(),
                                                                                                                            v680.clone())
                                                                                                       ==
                                                                                                       false
                                                                                                   {
                                                                                                    let _v736:
                                                                                                            MutCell<Option<()>> =
                                                                                                        MutCell::new(None::<()>);
                                                                                                    std::fs::write(&*v480.clone(), &*v680).unwrap();
                                                                                                    _v736.set(Some(()));
                                                                                                    match &_v736.get().clone()
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        panic!("{}",
                                                                                                               string("base.run_target / _v736=None"),),
                                                                                                        Some(_v736_0_0)
                                                                                                        =>
                                                                                                        _v736_0_0.clone(),
                                                                                                    }
                                                                                                    ()
                                                                                                }
                                                                                            if Spiral_builder::method84(v483.clone(),
                                                                                                                            v733.clone())
                                                                                                       ==
                                                                                                       false
                                                                                                   {
                                                                                                    let _v741:
                                                                                                            MutCell<Option<()>> =
                                                                                                        MutCell::new(None::<()>);
                                                                                                    std::fs::write(&*v483, &*v733).unwrap();
                                                                                                    _v741.set(Some(()));
                                                                                                    match &_v741.get().clone()
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        panic!("{}",
                                                                                                               string("base.run_target / _v741=None"),),
                                                                                                        Some(_v741_0_0)
                                                                                                        =>
                                                                                                        _v741_0_0.clone(),
                                                                                                    }
                                                                                                    ()
                                                                                                }
                                                                                            {
                                                                                                let v745:
                                                                                                            string =
                                                                                                        Spiral_builder::method30(v584,
                                                                                                                                 string("src/Range.rs"));
                                                                                                if Spiral_builder::method85(v745.clone())
                                                                                                       {
                                                                                                        let _v747:
                                                                                                                MutCell<Option<string>> =
                                                                                                            MutCell::new(None::<string>);
                                                                                                        let _v748:
                                                                                                                MutCell<Option<Vec<u8>>> =
                                                                                                            MutCell::new(None::<Vec<u8>>);
                                                                                                        {
                                                                                                            let x_53:
                                                                                                                    Vec<u8> =
                                                                                                                std::fs::read(&*v745.clone()).unwrap();
                                                                                                            _v748.set(Some(x_53))
                                                                                                        }
                                                                                                        {
                                                                                                            let v758:
                                                                                                                    Vec<u8> =
                                                                                                                match &_v748.get().clone()
                                                                                                                    {
                                                                                                                    None
                                                                                                                    =>
                                                                                                                    panic!("{}",
                                                                                                                           string("base.run_target / _v748=None"),),
                                                                                                                    Some(_v748_0_0)
                                                                                                                    =>
                                                                                                                    _v748_0_0.clone(),
                                                                                                                };
                                                                                                            let v760:
                                                                                                                    Result<std::string::String,
                                                                                                                           std::string::FromUtf8Error> =
                                                                                                                std::string::String::from_utf8(v758);
                                                                                                            let v762:
                                                                                                                    std::string::String =
                                                                                                                v760.unwrap();
                                                                                                            {
                                                                                                                let x_55:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromString(v762);
                                                                                                                _v747.set(Some(x_55))
                                                                                                            }
                                                                                                            {
                                                                                                                let v776:
                                                                                                                        string =
                                                                                                                    replace(replace(match &_v747.get().clone()
                                                                                                                                        {
                                                                                                                                        None
                                                                                                                                        =>
                                                                                                                                        panic!("{}",
                                                                                                                                               string("base.run_target / _v747=None"),),
                                                                                                                                        Some(_v747_0_0)
                                                                                                                                        =>
                                                                                                                                        _v747_0_0.clone(),
                                                                                                                                    },
                                                                                                                                    string("use crate::String_::fromCharCode;"),
                                                                                                                                    string("use crate::String_::fromChar;")),
                                                                                                                            string("fromCharCode(c)"),
                                                                                                                            string("std::char::from_u32(c).unwrap()"));
                                                                                                                if Spiral_builder::method84(v745.clone(),
                                                                                                                                            v776.clone())
                                                                                                                       ==
                                                                                                                       false
                                                                                                                   {
                                                                                                                    let _v779:
                                                                                                                            MutCell<Option<()>> =
                                                                                                                        MutCell::new(None::<()>);
                                                                                                                    std::fs::write(&*v745, &*v776).unwrap();
                                                                                                                    _v779.set(Some(()));
                                                                                                                    match &_v779.get().clone()
                                                                                                                        {
                                                                                                                        None
                                                                                                                        =>
                                                                                                                        panic!("{}",
                                                                                                                               string("base.run_target / _v779=None"),),
                                                                                                                        Some(_v779_0_0)
                                                                                                                        =>
                                                                                                                        _v779_0_0.clone(),
                                                                                                                    }
                                                                                                                    ()
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                {
                                                                                                    let patternInput_5:
                                                                                                                (i32,
                                                                                                                 string) =
                                                                                                            Spiral_builder::method95(v480.clone(),
                                                                                                                                     v566.clone(),
                                                                                                                                     1_u8);
                                                                                                    let v783:
                                                                                                                i32 =
                                                                                                            patternInput_5.0.clone();
                                                                                                    if v783
                                                                                                               !=
                                                                                                               0_i32
                                                                                                           {
                                                                                                            Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                                    Func0::new(move
                                                                                                                                                   ||
                                                                                                                                                   Spiral_builder::closure66((),
                                                                                                                                                                             ())),
                                                                                                                                    Func0::new({
                                                                                                                                                   let patternInput_5
                                                                                                                                                       =
                                                                                                                                                       patternInput_5.clone();
                                                                                                                                                   let v783
                                                                                                                                                       =
                                                                                                                                                       v783.clone();
                                                                                                                                                   move
                                                                                                                                                       ||
                                                                                                                                                       Spiral_builder::closure67(patternInput_5.1.clone(),
                                                                                                                                                                                 v783,
                                                                                                                                                                                 ())
                                                                                                                                               }));
                                                                                                        }
                                                                                                    {
                                                                                                        let v790:
                                                                                                                    string =
                                                                                                                Spiral_builder::method30(v478,
                                                                                                                                         sprintf!("{}.{}",
                                                                                                                                                  string("spiral_builder"),
                                                                                                                                                  string("rs")));
                                                                                                        let _v791:
                                                                                                                    MutCell<Option<string>> =
                                                                                                                MutCell::new(None::<string>);
                                                                                                        let _v792:
                                                                                                                    MutCell<Option<Vec<u8>>> =
                                                                                                                MutCell::new(None::<Vec<u8>>);
                                                                                                        {
                                                                                                            let x_59:
                                                                                                                        Vec<u8> =
                                                                                                                    std::fs::read(&*v790.clone()).unwrap();
                                                                                                            _v792.set(Some(x_59))
                                                                                                        }
                                                                                                        {
                                                                                                            let v802:
                                                                                                                        Vec<u8> =
                                                                                                                    match &_v792.get().clone()
                                                                                                                        {
                                                                                                                        None
                                                                                                                        =>
                                                                                                                        panic!("{}",
                                                                                                                               string("base.run_target / _v792=None"),),
                                                                                                                        Some(_v792_0_0)
                                                                                                                        =>
                                                                                                                        _v792_0_0.clone(),
                                                                                                                    };
                                                                                                            let v804:
                                                                                                                        Result<std::string::String,
                                                                                                                               std::string::FromUtf8Error> =
                                                                                                                    std::string::String::from_utf8(v802);
                                                                                                            let v806:
                                                                                                                        std::string::String =
                                                                                                                    v804.unwrap();
                                                                                                            {
                                                                                                                let x_61:
                                                                                                                            string =
                                                                                                                        fable_library_rust::String_::fromString(v806);
                                                                                                                _v791.set(Some(x_61))
                                                                                                            }
                                                                                                            {
                                                                                                                let v814:
                                                                                                                            string =
                                                                                                                        match &_v791.get().clone()
                                                                                                                            {
                                                                                                                            None
                                                                                                                            =>
                                                                                                                            panic!("{}",
                                                                                                                                   string("base.run_target / _v791=None"),),
                                                                                                                            Some(_v791_0_0)
                                                                                                                            =>
                                                                                                                            _v791_0_0.clone(),
                                                                                                                        };
                                                                                                                let v818:
                                                                                                                            string =
                                                                                                                        append(string("pub fn main() -> Result<(), String> "),
                                                                                                                               "{".into());
                                                                                                                let v819:
                                                                                                                            string =
                                                                                                                        sprintf!("{} Ok(()) }}",
                                                                                                                                 v818.clone());
                                                                                                                let v820:
                                                                                                                            bool =
                                                                                                                        contains(v814.clone(),
                                                                                                                                 v818);
                                                                                                                let v896:
                                                                                                                            string =
                                                                                                                        if v820
                                                                                                                           {
                                                                                                                            v814.clone()
                                                                                                                        } else {
                                                                                                                            let v832:
                                                                                                                                    string =
                                                                                                                                replace(replace(v814,
                                                                                                                                                append(string("),)"),
                                                                                                                                                       ";".into()),
                                                                                                                                                string("));")),
                                                                                                                                        append(string("},)"),
                                                                                                                                               ";".into()),
                                                                                                                                        string("});"));
                                                                                                                            let v833:
                                                                                                                                    string =
                                                                                                                                Spiral_builder::method97();
                                                                                                                            let _v834:
                                                                                                                                    MutCell<Option<string>> =
                                                                                                                                MutCell::new(None::<string>);
                                                                                                                            let v835:
                                                                                                                                    string =
                                                                                                                                Spiral_builder::method37(v832);
                                                                                                                            let v838:
                                                                                                                                    Result<regex::Regex,
                                                                                                                                           regex::Error> =
                                                                                                                                regex::Regex::new(&string("\\s\\sdefaultOf\\(\\);"));
                                                                                                                            let v840:
                                                                                                                                    regex::Regex =
                                                                                                                                v838.unwrap();
                                                                                                                            let v842:
                                                                                                                                    std::borrow::Cow<str> =
                                                                                                                                v840.replace_all(&v835, &*v833);
                                                                                                                            let v844:
                                                                                                                                    std::string::String =
                                                                                                                                String::from(v842);
                                                                                                                            {
                                                                                                                                let x_63:
                                                                                                                                        string =
                                                                                                                                    fable_library_rust::String_::fromString(v844);
                                                                                                                                _v834.set(Some(x_63))
                                                                                                                            }
                                                                                                                            replace(replace(replace(replace(replace(replace(replace(match &_v834.get().clone()
                                                                                                                                                                                        {
                                                                                                                                                                                        None
                                                                                                                                                                                        =>
                                                                                                                                                                                        panic!("{}",
                                                                                                                                                                                               string("base.run_target / _v834=None"),),
                                                                                                                                                                                        Some(_v834_0_0)
                                                                                                                                                                                        =>
                                                                                                                                                                                        _v834_0_0.clone(),
                                                                                                                                                                                    },
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
                                                                                                                if v820
                                                                                                                           ==
                                                                                                                           false
                                                                                                                       {
                                                                                                                        let v898:
                                                                                                                                string =
                                                                                                                            sprintf!("{}\n\n{}\n",
                                                                                                                                     v896.clone(),
                                                                                                                                     v819);
                                                                                                                        if Spiral_builder::method84(v790.clone(),
                                                                                                                                                    v898.clone())
                                                                                                                               ==
                                                                                                                               false
                                                                                                                           {
                                                                                                                            let _v901:
                                                                                                                                    MutCell<Option<()>> =
                                                                                                                                MutCell::new(None::<()>);
                                                                                                                            std::fs::write(&*v790.clone(), &*v898).unwrap();
                                                                                                                            _v901.set(Some(()));
                                                                                                                            match &_v901.get().clone()
                                                                                                                                {
                                                                                                                                None
                                                                                                                                =>
                                                                                                                                panic!("{}",
                                                                                                                                       string("base.run_target / _v901=None"),),
                                                                                                                                Some(_v901_0_0)
                                                                                                                                =>
                                                                                                                                _v901_0_0.clone(),
                                                                                                                            }
                                                                                                                            ()
                                                                                                                        }
                                                                                                                    }
                                                                                                                {
                                                                                                                    let v904:
                                                                                                                                string =
                                                                                                                            sprintf!("cargo +nightly run --manifest-path \"{}\"",
                                                                                                                                     v480);
                                                                                                                    let v911:
                                                                                                                                Array<(string,
                                                                                                                                       string)> =
                                                                                                                            new_array(&[(string("TRACE_LEVEL"),
                                                                                                                                         string("Verbose")),
                                                                                                                                        (string("RUSTC_WRAPPER"),
                                                                                                                                         string("sccache")),
                                                                                                                                        (string("RUSTFLAGS"),
                                                                                                                                         string("-C prefer-dynamic"))]);
                                                                                                                    let v922:
                                                                                                                                Result<string,
                                                                                                                                       string> =
                                                                                                                            match &v566
                                                                                                                                {
                                                                                                                                Spiral_builder::US28::US28_0(v566_0_0)
                                                                                                                                =>
                                                                                                                                Ok::<string,
                                                                                                                                     string>(v566_0_0.clone()),
                                                                                                                                Spiral_builder::US28::US28_1(v566_1_0)
                                                                                                                                =>
                                                                                                                                Err::<string,
                                                                                                                                      string>(v566_1_0.clone()),
                                                                                                                            };
                                                                                                                    let patternInput_6:
                                                                                                                                (i32,
                                                                                                                                 string) =
                                                                                                                            Spiral_builder::method44(None::<CancellationToken>,
                                                                                                                                                     v904.clone(),
                                                                                                                                                     v911.clone(),
                                                                                                                                                     None::<Func1<(bool,
                                                                                                                                                                   string,
                                                                                                                                                                   i32),
                                                                                                                                                                  Arc<Async<()>>>>,
                                                                                                                                                     None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                                                  ()>>,
                                                                                                                                                     true,
                                                                                                                                                     v922.ok());
                                                                                                                    let v927:
                                                                                                                                string =
                                                                                                                            patternInput_6.1.clone();
                                                                                                                    let v926:
                                                                                                                                i32 =
                                                                                                                            patternInput_6.0.clone();
                                                                                                                    let v930:
                                                                                                                                string =
                                                                                                                            Spiral_builder::method30(v482.clone(),
                                                                                                                                                     sprintf!("target/debug/spiral_builder_{}{}",
                                                                                                                                                              v290.clone(),
                                                                                                                                                              string("")));
                                                                                                                    let v933:
                                                                                                                                string =
                                                                                                                            Spiral_builder::method30(v482.clone(),
                                                                                                                                                     sprintf!("target/debug/spiral_builder_{}{}",
                                                                                                                                                              v290.clone(),
                                                                                                                                                              string(".pdb")));
                                                                                                                    let v936:
                                                                                                                                string =
                                                                                                                            Spiral_builder::method30(v482.clone(),
                                                                                                                                                     sprintf!("target/debug/spiral_builder_{}{}",
                                                                                                                                                              v290.clone(),
                                                                                                                                                              string(".exe")));
                                                                                                                    let v939:
                                                                                                                                string =
                                                                                                                            Spiral_builder::method30(v482,
                                                                                                                                                     sprintf!("target/debug/spiral_builder_{}{}",
                                                                                                                                                              v290,
                                                                                                                                                              string(".d")));
                                                                                                                    let v940:
                                                                                                                                bool =
                                                                                                                            Spiral_builder::method85(v930.clone());
                                                                                                                    let v941:
                                                                                                                                bool =
                                                                                                                            Spiral_builder::method85(v933.clone());
                                                                                                                    let v942:
                                                                                                                                bool =
                                                                                                                            Spiral_builder::method85(v936.clone());
                                                                                                                    let v943:
                                                                                                                                bool =
                                                                                                                            Spiral_builder::method85(v939.clone());
                                                                                                                    Spiral_builder::method5(Spiral_builder::US0::US0_0,
                                                                                                                                                Func0::new(move
                                                                                                                                                               ||
                                                                                                                                                               Spiral_builder::closure68((),
                                                                                                                                                                                         ())),
                                                                                                                                                Func0::new({
                                                                                                                                                               let v930
                                                                                                                                                                   =
                                                                                                                                                                   v930.clone();
                                                                                                                                                               let v933
                                                                                                                                                                   =
                                                                                                                                                                   v933.clone();
                                                                                                                                                               let v936
                                                                                                                                                                   =
                                                                                                                                                                   v936.clone();
                                                                                                                                                               let v939
                                                                                                                                                                   =
                                                                                                                                                                   v939.clone();
                                                                                                                                                               let v940
                                                                                                                                                                   =
                                                                                                                                                                   v940.clone();
                                                                                                                                                               let v941
                                                                                                                                                                   =
                                                                                                                                                                   v941.clone();
                                                                                                                                                               let v942
                                                                                                                                                                   =
                                                                                                                                                                   v942.clone();
                                                                                                                                                               let v943
                                                                                                                                                                   =
                                                                                                                                                                   v943.clone();
                                                                                                                                                               move
                                                                                                                                                                   ||
                                                                                                                                                                   Spiral_builder::closure69(v939.clone(),
                                                                                                                                                                                             v943,
                                                                                                                                                                                             v936.clone(),
                                                                                                                                                                                             v942,
                                                                                                                                                                                             v933.clone(),
                                                                                                                                                                                             v941,
                                                                                                                                                                                             v930.clone(),
                                                                                                                                                                                             v940,
                                                                                                                                                                                             ())
                                                                                                                                                           }));
                                                                                                                    {
                                                                                                                        let v950:
                                                                                                                                    LrcPtr<Spiral_builder::UH3> =
                                                                                                                                if v940
                                                                                                                                   {
                                                                                                                                    LrcPtr::new(Spiral_builder::UH3::UH3_1(v930.clone(),
                                                                                                                                                                           v940,
                                                                                                                                                                           LrcPtr::new(Spiral_builder::UH3::UH3_0)))
                                                                                                                                } else {
                                                                                                                                    LrcPtr::new(Spiral_builder::UH3::UH3_0)
                                                                                                                                };
                                                                                                                        let v952:
                                                                                                                                    LrcPtr<Spiral_builder::UH3> =
                                                                                                                                if v941
                                                                                                                                   {
                                                                                                                                    LrcPtr::new(Spiral_builder::UH3::UH3_1(v933.clone(),
                                                                                                                                                                           v941,
                                                                                                                                                                           v950.clone()))
                                                                                                                                } else {
                                                                                                                                    v950
                                                                                                                                };
                                                                                                                        let v954:
                                                                                                                                    LrcPtr<Spiral_builder::UH3> =
                                                                                                                                if v942
                                                                                                                                   {
                                                                                                                                    LrcPtr::new(Spiral_builder::UH3::UH3_1(v936.clone(),
                                                                                                                                                                           v942,
                                                                                                                                                                           v952.clone()))
                                                                                                                                } else {
                                                                                                                                    v952
                                                                                                                                };
                                                                                                                        Spiral_builder::method99(if v943
                                                                                                                                                        {
                                                                                                                                                         LrcPtr::new(Spiral_builder::UH3::UH3_1(v939.clone(),
                                                                                                                                                                                                v943,
                                                                                                                                                                                                v954.clone()))
                                                                                                                                                     } else {
                                                                                                                                                         v954
                                                                                                                                                     });
                                                                                                                        {
                                                                                                                            let v957:
                                                                                                                                        i32 =
                                                                                                                                    count_2(v911.clone());
                                                                                                                            let v958:
                                                                                                                                        Array<string> =
                                                                                                                                    new_init(&string(""),
                                                                                                                                             v957);
                                                                                                                            let v959:
                                                                                                                                        LrcPtr<Spiral_builder::Mut4> =
                                                                                                                                    LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                                                         MutCell::new(0_i32),});
                                                                                                                            while Spiral_builder::method16(v957,
                                                                                                                                                               v959.clone())
                                                                                                                                      {
                                                                                                                                    let v961:
                                                                                                                                            i32 =
                                                                                                                                        v959.l0.get().clone();
                                                                                                                                    let patternInput_7:
                                                                                                                                            (string,
                                                                                                                                             string) =
                                                                                                                                        v911[v961].clone();
                                                                                                                                    let v964:
                                                                                                                                            string =
                                                                                                                                        sprintf!("$env:{}=\'\'{}\'\'",
                                                                                                                                                 patternInput_7.0.clone(),
                                                                                                                                                 patternInput_7.1.clone());
                                                                                                                                    v958.get_mut()[v961
                                                                                                                                                       as
                                                                                                                                                       usize]
                                                                                                                                        =
                                                                                                                                        v964;
                                                                                                                                    {
                                                                                                                                        let v965:
                                                                                                                                                i32 =
                                                                                                                                            v961
                                                                                                                                                +
                                                                                                                                                1_i32;
                                                                                                                                        v959.l0.set(v965);
                                                                                                                                        ()
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            {
                                                                                                                                let v972:
                                                                                                                                            string =
                                                                                                                                        sprintf!("pwsh -c \'{}; {}\'",
                                                                                                                                                 join(string(";"),
                                                                                                                                                      toArray_1(ofArray_1(v958.clone()))),
                                                                                                                                                 v904);
                                                                                                                                if v926
                                                                                                                                           ==
                                                                                                                                           0_i32
                                                                                                                                       {
                                                                                                                                        let v977:
                                                                                                                                                Spiral_builder::US3 =
                                                                                                                                            try_catch(||
                                                                                                                                                          Spiral_builder::closure72((),
                                                                                                                                                                                    Spiral_builder::closure70(v927.clone(),
                                                                                                                                                                                                              ())),
                                                                                                                                                      |ex:
                                                                                                                                                           LrcPtr<Exception>|
                                                                                                                                                          Spiral_builder::closure73(v790.clone(),
                                                                                                                                                                                    v927.clone(),
                                                                                                                                                                                    v972.clone(),
                                                                                                                                                                                    ex.clone()));
                                                                                                                                        let v982:
                                                                                                                                                Option<string> =
                                                                                                                                            match &v977
                                                                                                                                                {
                                                                                                                                                Spiral_builder::US3::US3_0(v977_0_0)
                                                                                                                                                =>
                                                                                                                                                Some(match &v977
                                                                                                                                                         {
                                                                                                                                                         Spiral_builder::US3::US3_0(x)
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
                                                                                                                                        (Spiral_builder::US3::US3_0(v896),
                                                                                                                                         Spiral_builder::US3::US3_0(string("rs")),
                                                                                                                                         Spiral_builder::US3::US3_0(v982.unwrap()))
                                                                                                                                    } else {
                                                                                                                                        Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                                                                Func0::new(move
                                                                                                                                                                               ||
                                                                                                                                                                               Spiral_builder::closure76((),
                                                                                                                                                                                                         ())),
                                                                                                                                                                Func0::new({
                                                                                                                                                                               let v790
                                                                                                                                                                                   =
                                                                                                                                                                                   v790.clone();
                                                                                                                                                                               let v926
                                                                                                                                                                                   =
                                                                                                                                                                                   v926.clone();
                                                                                                                                                                               let v927
                                                                                                                                                                                   =
                                                                                                                                                                                   v927.clone();
                                                                                                                                                                               let v972
                                                                                                                                                                                   =
                                                                                                                                                                                   v972.clone();
                                                                                                                                                                               move
                                                                                                                                                                                   ||
                                                                                                                                                                                   Spiral_builder::closure77(v790.clone(),
                                                                                                                                                                                                             v927.clone(),
                                                                                                                                                                                                             v926,
                                                                                                                                                                                                             v972.clone(),
                                                                                                                                                                                                             ())
                                                                                                                                                                           }));
                                                                                                                                        (Spiral_builder::US3::US3_1,
                                                                                                                                         Spiral_builder::US3::US3_0(string("rs")),
                                                                                                                                         Spiral_builder::US3::US3_1)
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
                                    } else {
                                        if fable_library_rust::String_::fromString(v13.clone())
                                            == string("typescript")
                                        {
                                            let v1004: string = Spiral_builder::method11();
                                            let v1006: &str = &*v1004;
                                            let v1008: Option<std::string::String> =
                                                clap::ArgMatches::get_one(&v14.clone(), v1006)
                                                    .cloned();
                                            let _v1009: LrcPtr<
                                                MutCell<Option<Spiral_builder::US5>>,
                                            > = refCell(None::<Spiral_builder::US5>);
                                            {
                                                let x_69: Option<Spiral_builder::US5> = match &v1008
                                                {
                                                    None => None::<Spiral_builder::US5>,
                                                    Some(v1008_0_0) => {
                                                        let x_67: std::string::String =
                                                            v1008_0_0.clone();
                                                        Some((Func0::new({
                                                            let x_67 = x_67.clone();
                                                            move || {
                                                                Spiral_builder::US5::US5_0(
                                                                    x_67.clone(),
                                                                )
                                                            }
                                                        }))(
                                                        ))
                                                    }
                                                };
                                                _v1009.set(x_69)
                                            }
                                            {
                                                let v1014: Spiral_builder::US5 = defaultValue(
                                                    Spiral_builder::US5::US5_1,
                                                    _v1009.get().clone(),
                                                );
                                                let v1018: std::string::String = match &v1014 {
                                                    Spiral_builder::US5::US5_0(v1014_0_0) => {
                                                        match &v1014 {
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
                                                };
                                                let v1020: string =
                                                    fable_library_rust::String_::fromString(v1018);
                                                let v1021: string = Spiral_builder::method66();
                                                let v1023: &str = &*v1021;
                                                let v1025: Option<Vec<std::string::String>> =
                                                    clap::ArgMatches::get_many(&v14.clone(), v1023)
                                                        .map(|x| x.cloned().into_iter().collect());
                                                let _v1026: LrcPtr<
                                                    MutCell<Option<Spiral_builder::US25>>,
                                                > = refCell(None::<Spiral_builder::US25>);
                                                {
                                                    let x_72: Option<Spiral_builder::US25> =
                                                        match &v1025 {
                                                            None => None::<Spiral_builder::US25>,
                                                            Some(v1025_0_0) => {
                                                                let x_70: Vec<std::string::String> =
                                                                    v1025_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_70 = x_70.clone();
                                                                    move || {
                                                                        Spiral_builder::US25::US25_0(
                                                                            x_70.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                    _v1026.set(x_72)
                                                }
                                                {
                                                    let v1031: Spiral_builder::US25 = defaultValue(
                                                        Spiral_builder::US25::US25_1,
                                                        _v1026.get().clone(),
                                                    );
                                                    let v1034: Vec<std::string::String> =
                                                        new_empty::<std::string::String>().to_vec();
                                                    let v1037: Vec<std::string::String> =
                                                        match &v1031 {
                                                            Spiral_builder::US25::US25_0(
                                                                v1031_0_0,
                                                            ) => match &v1031 {
                                                                Spiral_builder::US25::US25_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            _ => v1034,
                                                        };
                                                    let v1039: bool =
                                                        if let Spiral_builder::US0::US0_0 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        };
                                                    let _v1040: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let _v1041: MutCell<Option<Vec<u8>>> =
                                                        MutCell::new(None::<Vec<u8>>);
                                                    {
                                                        let x_73: Vec<u8> =
                                                            std::fs::read(&*v1020).unwrap();
                                                        _v1041.set(Some(x_73))
                                                    }
                                                    {
                                                        let v1051: Vec<u8> = match &_v1041
                                                            .get()
                                                            .clone()
                                                        {
                                                            None => panic!(
                                                                "{}",
                                                                string(
                                                                    "base.run_target / _v1041=None"
                                                                ),
                                                            ),
                                                            Some(_v1041_0_0) => _v1041_0_0.clone(),
                                                        };
                                                        let v1053: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v1051);
                                                        let v1055: std::string::String =
                                                            v1053.unwrap();
                                                        {
                                                            let x_75:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v1055);
                                                            _v1040.set(Some(x_75))
                                                        }
                                                        {
                                                            let v1063:
                                                                        string =
                                                                    match &_v1040.get().clone()
                                                                        {
                                                                        None
                                                                        =>
                                                                        panic!("{}",
                                                                               string("base.run_target / _v1040=None"),),
                                                                        Some(_v1040_0_0)
                                                                        =>
                                                                        _v1040_0_0.clone(),
                                                                    };
                                                            let v1066: string =
                                                                Spiral_builder::method67(sprintf!(
                                                                    "{:?}",
                                                                    (string("ts"), v1063.clone())
                                                                ));
                                                            let v1079:
                                                                        string =
                                                                    Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method69(Spiral_builder::method30(string("polyglot"),
                                                                                                                                                                                                                                                   string(".paket")),
                                                                                                                                                                                                                          string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\spiral_builder")),
                                                                                                                                                                                                 string("polyglot")),
                                                                                                                                                                        string("target/polyglot/spiral_builder")),
                                                                                                                                               string("spiral_builder")),
                                                                                                                      string("packages")),
                                                                                             v1066.clone());
                                                            let v1080: LrcPtr<dyn IDisposable> =
                                                                Spiral_builder::method74(
                                                                    v1079.clone(),
                                                                );
                                                            let v1082: string =
                                                                Spiral_builder::method30(
                                                                    v1079.clone(),
                                                                    sprintf!(
                                                                        "{}.fs",
                                                                        string("spiral_builder")
                                                                    ),
                                                                );
                                                            let v1083: string =
                                                                Spiral_builder::method36();
                                                            let _v1084: MutCell<Option<string>> =
                                                                MutCell::new(None::<string>);
                                                            let v1085: string =
                                                                Spiral_builder::method37(v1082);
                                                            let v1088: Result<
                                                                regex::Regex,
                                                                regex::Error,
                                                            > = regex::Regex::new(&string(
                                                                "^\\\\\\\\\\?\\\\",
                                                            ));
                                                            let v1090: regex::Regex =
                                                                v1088.unwrap();
                                                            let v1092: std::borrow::Cow<str> =
                                                                v1090.replace_all(&v1085, &*v1083);
                                                            let v1094: std::string::String =
                                                                String::from(v1092);
                                                            {
                                                                let x_77:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v1094);
                                                                _v1084.set(Some(x_77))
                                                            }
                                                            {
                                                                let v1103:
                                                                            string =
                                                                        match &_v1084.get().clone()
                                                                            {
                                                                            None
                                                                            =>
                                                                            panic!("{}",
                                                                                   string("base.run_target / _v1084=None"),),
                                                                            Some(_v1084_0_0)
                                                                            =>
                                                                            _v1084_0_0.clone(),
                                                                        };
                                                                let v1107: string = replace(
                                                                    sprintf!(
                                                                        "{}{}",
                                                                        toLower(ofChar(getCharAt(
                                                                            v1103.clone(),
                                                                            0_i32
                                                                        ))),
                                                                        getSlice(
                                                                            v1103,
                                                                            Some(1_i32),
                                                                            None::<i32>
                                                                        )
                                                                    ),
                                                                    string("\\"),
                                                                    string("/"),
                                                                );
                                                                if Spiral_builder::method84(
                                                                    v1107.clone(),
                                                                    v1063.clone(),
                                                                ) == false
                                                                {
                                                                    let _v1110: MutCell<
                                                                        Option<()>,
                                                                    > = MutCell::new(None::<()>);
                                                                    std::fs::write(
                                                                        &*v1107.clone(),
                                                                        &*v1063,
                                                                    )
                                                                    .unwrap();
                                                                    _v1110.set(Some(()));
                                                                    match &_v1110.get().clone()
                                                                            {
                                                                            None
                                                                            =>
                                                                            panic!("{}",
                                                                                   string("base.run_target / _v1110=None"),),
                                                                            Some(_v1110_0_0)
                                                                            =>
                                                                            _v1110_0_0.clone(),
                                                                        }
                                                                    ()
                                                                }
                                                                {
                                                                    let v1113: List<string> =
                                                                        empty::<string>();
                                                                    let v1118: string = join(
                                                                        string("\\n        "),
                                                                        toArray_1(delay(
                                                                            Func0::new({
                                                                                let v1113 =
                                                                                    v1113.clone();
                                                                                move || {
                                                                                    map(Func1::new({
                                                                                                                                       let v1113
                                                                                                                                           =
                                                                                                                                           v1113.clone();
                                                                                                                                       move
                                                                                                                                           |i_3:
                                                                                                                                                i32|
                                                                                                                                           item(i_3,
                                                                                                                                                v1113.clone())
                                                                                                                                   }),
                                                                                                                        rangeNumeric(0_i32,
                                                                                                                                     1_i32,
                                                                                                                                     length_1(v1113.clone())
                                                                                                                                         -
                                                                                                                                         1_i32))
                                                                                }
                                                                            }),
                                                                        )),
                                                                    );
                                                                    let v1122:
                                                                                List<string> =
                                                                            singleton(sprintf!("<PackageReference Include=\"{}\" Version=\"*\" />",
                                                                                               string("Fable.Core")));
                                                                    let v1126: string = join(
                                                                        string("\\n        "),
                                                                        toArray_1(delay(
                                                                            Func0::new({
                                                                                let v1122 =
                                                                                    v1122.clone();
                                                                                move || {
                                                                                    map(Func1::new({
                                                                                                                                       let v1122
                                                                                                                                           =
                                                                                                                                           v1122.clone();
                                                                                                                                       move
                                                                                                                                           |i_4:
                                                                                                                                                i32|
                                                                                                                                           item(i_4,
                                                                                                                                                v1122.clone())
                                                                                                                                   }),
                                                                                                                        rangeNumeric(0_i32,
                                                                                                                                     1_i32,
                                                                                                                                     length_1(v1122.clone())
                                                                                                                                         -
                                                                                                                                         1_i32))
                                                                                }
                                                                            }),
                                                                        )),
                                                                    );
                                                                    let v1128:
                                                                                string =
                                                                            Spiral_builder::method30(v1079,
                                                                                                     sprintf!("{}.fsproj",
                                                                                                              string("spiral_builder")));
                                                                    let v1129: string =
                                                                        Spiral_builder::method36();
                                                                    let _v1130: MutCell<
                                                                        Option<string>,
                                                                    > = MutCell::new(
                                                                        None::<string>,
                                                                    );
                                                                    let v1131: string =
                                                                        Spiral_builder::method37(
                                                                            v1128,
                                                                        );
                                                                    let v1133: Result<
                                                                        regex::Regex,
                                                                        regex::Error,
                                                                    > = regex::Regex::new(&string(
                                                                        "^\\\\\\\\\\?\\\\",
                                                                    ));
                                                                    let v1135: regex::Regex =
                                                                        v1133.unwrap();
                                                                    let v1137: std::borrow::Cow<
                                                                        str,
                                                                    > = v1135.replace_all(
                                                                        &v1131, &*v1129,
                                                                    );
                                                                    let v1139: std::string::String =
                                                                        String::from(v1137);
                                                                    {
                                                                        let x_81:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v1139);
                                                                        _v1130.set(Some(x_81))
                                                                    }
                                                                    {
                                                                        let v1148:
                                                                                    string =
                                                                                match &_v1130.get().clone()
                                                                                    {
                                                                                    None
                                                                                    =>
                                                                                    panic!("{}",
                                                                                           string("base.run_target / _v1130=None"),),
                                                                                    Some(_v1130_0_0)
                                                                                    =>
                                                                                    _v1130_0_0.clone(),
                                                                                };
                                                                        let v1150: string = replace(
                                                                            sprintf!(
                                                                                "{}{}",
                                                                                toLower(ofChar(
                                                                                    getCharAt(
                                                                                        v1148
                                                                                            .clone(
                                                                                            ),
                                                                                        0_i32
                                                                                    )
                                                                                )),
                                                                                getSlice(
                                                                                    v1148,
                                                                                    Some(1_i32),
                                                                                    None::<i32>
                                                                                )
                                                                            ),
                                                                            string("\\"),
                                                                            string("/"),
                                                                        );
                                                                        let v1248:
                                                                                    string =
                                                                                append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                           sprintf!("    {}",
                                                                                                                                                                                    v1118)),
                                                                                                                                                                    string("\n")),
                                                                                                                                                             sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                                      v1107)),
                                                                                                                                                      string("\n")),
                                                                                                                                               string("</ItemGroup>")),
                                                                                                                                        string("\n")),
                                                                                                                                 string("<ItemGroup>")),
                                                                                                                          string("\n")),
                                                                                                                   sprintf!("    {}",
                                                                                                                            v1126)),
                                                                                                            string("\n")),
                                                                                                     string("</ItemGroup>")),
                                                                                              string("\n")),
                                                                                       string("</Project>"));
                                                                        if Spiral_builder::method84(
                                                                            v1150.clone(),
                                                                            v1248.clone(),
                                                                        ) == false
                                                                        {
                                                                            let _v1251: MutCell<
                                                                                Option<()>,
                                                                            > = MutCell::new(
                                                                                None::<()>,
                                                                            );
                                                                            std::fs::write(
                                                                                &*v1150.clone(),
                                                                                &*v1248,
                                                                            )
                                                                            .unwrap();
                                                                            _v1251.set(Some(()));
                                                                            match &_v1251.get().clone()
                                                                                    {
                                                                                    None
                                                                                    =>
                                                                                    panic!("{}",
                                                                                           string("base.run_target / _v1251=None"),),
                                                                                    Some(_v1251_0_0)
                                                                                    =>
                                                                                    _v1251_0_0.clone(),
                                                                                }
                                                                            ()
                                                                        }
                                                                        {
                                                                            let v1254:
                                                                                        string =
                                                                                    Spiral_builder::method86(v1150.clone());
                                                                            let v1258:
                                                                                        string =
                                                                                    Spiral_builder::method30(Spiral_builder::method69(Spiral_builder::method30(string("polyglot"),
                                                                                                                                                               string(".paket")),
                                                                                                                                      string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\spiral_builder")),
                                                                                                             string("polyglot"));
                                                                            let v1261:
                                                                                        string =
                                                                                    toLower(Spiral_builder::method29());
                                                                            let v1263: string =
                                                                                toLower(v1258);
                                                                            let v1267:
                                                                                        Spiral_builder::US28 =
                                                                                    if startsWith(v1261,
                                                                                                  v1263.clone(),
                                                                                                  false)
                                                                                       {
                                                                                        Spiral_builder::US28::US28_1(v1263.clone())
                                                                                    } else {
                                                                                        Spiral_builder::US28::US28_0(v1263)
                                                                                    };
                                                                            let v1273:
                                                                                        Result<string,
                                                                                               string> =
                                                                                    match &v1267
                                                                                        {
                                                                                        Spiral_builder::US28::US28_0(v1267_0_0)
                                                                                        =>
                                                                                        Ok::<string,
                                                                                             string>(v1267_0_0.clone()),
                                                                                        Spiral_builder::US28::US28_1(v1267_1_0)
                                                                                        =>
                                                                                        Err::<string,
                                                                                              string>(v1267_1_0.clone()),
                                                                                    };
                                                                            let v1275: bool = true;
                                                                            let _result = v1273
                                                                                .unwrap_or_else(
                                                                                    |x| {
                                                                                        //;
                                                                                        let v1277:
                                                                                        string =
                                                                                    x;
                                                                                        let v1279:
                                                                                        bool =
                                                                                    true;
                                                                                        v1277
                                                                                    },
                                                                                );
                                                                            let v1281: string =
                                                                                _result;
                                                                            let v1283:
                                                                                        string =
                                                                                    Spiral_builder::method30(v1281.clone(),
                                                                                                             string("lib/typescript/fable/fable_modules"));
                                                                            let v1285:
                                                                                        async_walkdir::WalkDir =
                                                                                    async_walkdir::WalkDir::new(&*v1283.clone());
                                                                            let v1288:
                                                                                        async_walkdir::WalkDir =
                                                                                    async_walkdir::WalkDir::filter(v1285, |x| Func1::new(move
                                                                                                                                             |v_4:
                                                                                                                                                  async_walkdir::DirEntry|
                                                                                                                                             Spiral_builder::closure78((),
                                                                                                                                                                       v_4))(x));
                                                                            let v1289 =
                                                                                    Spiral_builder::method106();
                                                                            let v1291:
                                                                                        Vec<(string,
                                                                                             string)> =
                                                                                    tokio_stream::StreamExt::collect(tokio_stream::StreamExt::filter_map(v1288, |x| v1289(x))).await;
                                                                            let v1293:
                                                                                        rayon::vec::IntoIter<(string,
                                                                                                              string)> =
                                                                                    rayon::iter::IntoParallelIterator::into_par_iter(v1291);
                                                                            let v1296:
                                                                                        rayon::iter::Map<rayon::vec::IntoIter<(string,
                                                                                                                               string)>, _> =
                                                                                    rayon::iter::ParallelIterator::map(v1293, |x| Func1::new(move
                                                                                                                                                 |arg10_0040_16:
                                                                                                                                                      (string,
                                                                                                                                                       string)|
                                                                                                                                                 Spiral_builder::closure86((),
                                                                                                                                                                           arg10_0040_16))(x));
                                                                            let v1298:
                                                                                        Vec<(string,
                                                                                             string)> =
                                                                                    rayon::iter::ParallelIterator::collect(v1296);
                                                                            let v1303:
                                                                                        Option<(string,
                                                                                                string)> =
                                                                                    tryItem(0_i32,
                                                                                            fable_library_rust::NativeArray_::array_from(v1298));
                                                                            let _v1304:
                                                                                        LrcPtr<MutCell<Option<Spiral_builder::US35>>> =
                                                                                    refCell(None::<Spiral_builder::US35>);
                                                                            {
                                                                                let x_87:
                                                                                            Option<Spiral_builder::US35> =
                                                                                        match &v1303
                                                                                            {
                                                                                            None
                                                                                            =>
                                                                                            None::<Spiral_builder::US35>,
                                                                                            Some(v1303_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let x_85:
                                                                                                        (string,
                                                                                                         string) =
                                                                                                    v1303_0_0.clone();
                                                                                                Some((Func0::new({
                                                                                                                     let x_85
                                                                                                                         =
                                                                                                                         x_85.clone();
                                                                                                                     move
                                                                                                                         ||
                                                                                                                         Spiral_builder::US35::US35_0(x_85.0.clone(),
                                                                                                                                                      x_85.1.clone())
                                                                                                                 }))())
                                                                                            }
                                                                                        };
                                                                                _v1304.set(x_87)
                                                                            }
                                                                            {
                                                                                let v1310:
                                                                                            Spiral_builder::US35 =
                                                                                        defaultValue(Spiral_builder::US35::US35_1,
                                                                                                     _v1304.get().clone());
                                                                                Spiral_builder::method5(Spiral_builder::US0::US0_1,
                                                                                                            Func0::new(move
                                                                                                                           ||
                                                                                                                           Spiral_builder::closure87((),
                                                                                                                                                     ())),
                                                                                                            Func0::new({
                                                                                                                           let v1310
                                                                                                                               =
                                                                                                                               v1310.clone();
                                                                                                                           move
                                                                                                                               ||
                                                                                                                               Spiral_builder::closure88(v1310.clone(),
                                                                                                                                                         ())
                                                                                                                       }));
                                                                                match &v1310
                                                                                        {
                                                                                        Spiral_builder::US35::US35_0(v1310_0_0,
                                                                                                                     v1310_0_1)
                                                                                        =>
                                                                                        {
                                                                                            let v1315:
                                                                                                    string =
                                                                                                match &v1310
                                                                                                    {
                                                                                                    Spiral_builder::US35::US35_0(_,
                                                                                                                                 x)
                                                                                                    =>
                                                                                                    x.clone(),
                                                                                                    _
                                                                                                    =>
                                                                                                    unreachable!(),
                                                                                                };
                                                                                            let v1317:
                                                                                                    string =
                                                                                                Spiral_builder::method30(v1283,
                                                                                                                         sprintf!("fable-library-{}.{}",
                                                                                                                                  string("ts"),
                                                                                                                                  v1315.clone()));
                                                                                            let v1319:
                                                                                                    string =
                                                                                                Spiral_builder::method30(v1254.clone(),
                                                                                                                         sprintf!("fable_modules/fable-library-{}.{}",
                                                                                                                                  string("ts"),
                                                                                                                                  v1315));
                                                                                            if Spiral_builder::method70(v1317.clone())
                                                                                                   ==
                                                                                                   false
                                                                                               {
                                                                                                let v1322:
                                                                                                        LrcPtr<dyn IDisposable> =
                                                                                                    Spiral_builder::method74(v1317.clone());
                                                                                                ()
                                                                                            }
                                                                                            {
                                                                                                let v1323:
                                                                                                        string =
                                                                                                    Spiral_builder::method86(v1319.clone());
                                                                                                if Spiral_builder::method70(v1323.clone())
                                                                                                       ==
                                                                                                       false
                                                                                                   {
                                                                                                    let v1326:
                                                                                                            LrcPtr<dyn IDisposable> =
                                                                                                        Spiral_builder::method74(v1323);
                                                                                                    ()
                                                                                                }
                                                                                                if if Spiral_builder::method70(v1319.clone())
                                                                                                      {
                                                                                                       let v1329:
                                                                                                               Result<std::path::PathBuf,
                                                                                                                      std::io::Error> =
                                                                                                           std::fs::read_link(&*v1319.clone());
                                                                                                       v1329.is_err()
                                                                                                   } else {
                                                                                                       false
                                                                                                   }
                                                                                                   {
                                                                                                    Spiral_builder::method77(true,
                                                                                                                             v1319.clone());
                                                                                                }
                                                                                                if Spiral_builder::method70(v1319.clone())
                                                                                                       ==
                                                                                                       false
                                                                                                   {
                                                                                                    let _v1336:
                                                                                                            MutCell<Option<()>> =
                                                                                                        MutCell::new(None::<()>);
                                                                                                    let _v1337:
                                                                                                            MutCell<Option<()>> =
                                                                                                        MutCell::new(None::<()>);
                                                                                                    std::os::windows::fs::symlink_dir(&*v1317, &*v1319).unwrap();
                                                                                                    _v1337.set(Some(()));
                                                                                                    match &_v1337.get().clone()
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        panic!("{}",
                                                                                                               string("runtime.run_platform / _v1337=None"),),
                                                                                                        Some(_v1337_0_0)
                                                                                                        =>
                                                                                                        _v1337_0_0.clone(),
                                                                                                    }
                                                                                                    _v1336.set(Some(()));
                                                                                                    match &_v1336.get().clone()
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        panic!("{}",
                                                                                                               string("base.run_target / _v1336=None"),),
                                                                                                        Some(_v1336_0_0)
                                                                                                        =>
                                                                                                        _v1336_0_0.clone(),
                                                                                                    }
                                                                                                    ()
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                        _
                                                                                        =>
                                                                                        (),
                                                                                    }
                                                                                {
                                                                                    let patternInput_8:
                                                                                                (i32,
                                                                                                 string) =
                                                                                            Spiral_builder::method93(v1254.clone(),
                                                                                                                     string("ts"),
                                                                                                                     v1150,
                                                                                                                     v1267.clone());
                                                                                    let v1344:
                                                                                                string =
                                                                                            patternInput_8.1.clone();
                                                                                    let v1343:
                                                                                                i32 =
                                                                                            patternInput_8.0.clone();
                                                                                    if v1343
                                                                                        != 0_i32
                                                                                    {
                                                                                        Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                    Func0::new({
                                                                                                                                   let v1343
                                                                                                                                       =
                                                                                                                                       v1343.clone();
                                                                                                                                   let v1344
                                                                                                                                       =
                                                                                                                                       v1344.clone();
                                                                                                                                   move
                                                                                                                                       ||
                                                                                                                                       Spiral_builder::closure89(v1344.clone(),
                                                                                                                                                                 v1343,
                                                                                                                                                                 ())
                                                                                                                               }),
                                                                                                                    Func0::new(move
                                                                                                                                   ||
                                                                                                                                   Spiral_builder::closure6((),
                                                                                                                                                            ())));
                                                                                        (Spiral_builder::US3::US3_1,
                                                                                             Spiral_builder::US3::US3_0(string("ts")),
                                                                                             Spiral_builder::US3::US3_0(v1344.clone()))
                                                                                    } else {
                                                                                        let v1353:
                                                                                                    bool =
                                                                                                true;
                                                                                        let _result : Vec<_> = v1037.into_iter().map(|x| { //;
                                                                                            let v1355:
                                                                                                    std::string::String =
                                                                                                x;
                                                                                            let v1357:
                                                                                                    string =
                                                                                                fable_library_rust::String_::fromString(v1355);
                                                                                            let v1361:
                                                                                                    string =
                                                                                                if contains(v1357.clone(),
                                                                                                            string("="))
                                                                                                   {
                                                                                                    v1357.clone()
                                                                                                } else {
                                                                                                    sprintf!("\"{}\":\"*\"",
                                                                                                             v1357)
                                                                                                };
                                                                                            let v1363:
                                                                                                    bool =
                                                                                                true; v1361 }).collect::<Vec<_>>();
                                                                                        let v1365:
                                                                                                    Vec<string> =
                                                                                                _result;
                                                                                        let v1367:
                                                                                                    Array<string> =
                                                                                                fable_library_rust::NativeArray_::array_from(v1365);
                                                                                        let v1386:
                                                                                                    string =
                                                                                                append(append(append(append(append(append(append(string("{"),
                                                                                                                                                 sprintf!("  \"name\": \"spiral_builder_{}\",",
                                                                                                                                                          v1066)),
                                                                                                                                          string("  \"dependencies\": {")),
                                                                                                                                   join(string(",\n"),
                                                                                                                                        toArray_1(delay(Func0::new({
                                                                                                                                                                       let v1367
                                                                                                                                                                           =
                                                                                                                                                                           v1367.clone();
                                                                                                                                                                       move
                                                                                                                                                                           ||
                                                                                                                                                                           map(Func1::new({
                                                                                                                                                                                              let v1367
                                                                                                                                                                                                  =
                                                                                                                                                                                                  v1367.clone();
                                                                                                                                                                                              move
                                                                                                                                                                                                  |i_5:
                                                                                                                                                                                                       i32|
                                                                                                                                                                                                  v1367[i_5].clone()
                                                                                                                                                                                          }),
                                                                                                                                                                               rangeNumeric(0_i32,
                                                                                                                                                                                            1_i32,
                                                                                                                                                                                            count_2(v1367.clone())
                                                                                                                                                                                                -
                                                                                                                                                                                                1_i32))
                                                                                                                                                                   }))))),
                                                                                                                            string("  },")),
                                                                                                                     string("    \"devDependencies\": {")),
                                                                                                              string("  },")),
                                                                                                       string("}"));
                                                                                        let v1388:
                                                                                                    string =
                                                                                                Spiral_builder::method30(v1254.clone(),
                                                                                                                         string("package.json"));
                                                                                        let v1391:
                                                                                                    string =
                                                                                                Spiral_builder::method30(Spiral_builder::method30(v1254.clone(),
                                                                                                                                                  string("../..")),
                                                                                                                         string("package.json"));
                                                                                        if Spiral_builder::method84(v1388.clone(),
                                                                                                                        v1386.clone())
                                                                                                   ==
                                                                                                   false
                                                                                               {
                                                                                                let _v1394:
                                                                                                        MutCell<Option<()>> =
                                                                                                    MutCell::new(None::<()>);
                                                                                                std::fs::write(&*v1388, &*v1386).unwrap();
                                                                                                _v1394.set(Some(()));
                                                                                                match &_v1394.get().clone()
                                                                                                    {
                                                                                                    None
                                                                                                    =>
                                                                                                    panic!("{}",
                                                                                                           string("base.run_target / _v1394=None"),),
                                                                                                    Some(_v1394_0_0)
                                                                                                    =>
                                                                                                    _v1394_0_0.clone(),
                                                                                                }
                                                                                                ()
                                                                                            }
                                                                                        if Spiral_builder::method84(v1391.clone(),
                                                                                                                        string(""))
                                                                                                   ==
                                                                                                   false
                                                                                               {
                                                                                                let _v1400:
                                                                                                        MutCell<Option<()>> =
                                                                                                    MutCell::new(None::<()>);
                                                                                                std::fs::write(&*v1391, &*string("")).unwrap();
                                                                                                _v1400.set(Some(()));
                                                                                                match &_v1400.get().clone()
                                                                                                    {
                                                                                                    None
                                                                                                    =>
                                                                                                    panic!("{}",
                                                                                                           string("base.run_target / _v1400=None"),),
                                                                                                    Some(_v1400_0_0)
                                                                                                    =>
                                                                                                    _v1400_0_0.clone(),
                                                                                                }
                                                                                                ()
                                                                                            }
                                                                                        {
                                                                                            let v1404:
                                                                                                        string =
                                                                                                    Spiral_builder::method30(v1254,
                                                                                                                             sprintf!("{}.{}",
                                                                                                                                      string("spiral_builder"),
                                                                                                                                      string("ts")));
                                                                                            Spiral_builder::method5(Spiral_builder::US0::US0_1,
                                                                                                                        Func0::new(move
                                                                                                                                       ||
                                                                                                                                       Spiral_builder::closure90((),
                                                                                                                                                                 ())),
                                                                                                                        Func0::new({
                                                                                                                                       let v1404
                                                                                                                                           =
                                                                                                                                           v1404.clone();
                                                                                                                                       move
                                                                                                                                           ||
                                                                                                                                           Spiral_builder::closure91(v1404.clone(),
                                                                                                                                                                     ())
                                                                                                                                   }));
                                                                                            {
                                                                                                let _v1408:
                                                                                                            MutCell<Option<string>> =
                                                                                                        MutCell::new(None::<string>);
                                                                                                let _v1409:
                                                                                                            MutCell<Option<Vec<u8>>> =
                                                                                                        MutCell::new(None::<Vec<u8>>);
                                                                                                {
                                                                                                    let x_96:
                                                                                                                Vec<u8> =
                                                                                                            std::fs::read(&*v1404.clone()).unwrap();
                                                                                                    _v1409.set(Some(x_96))
                                                                                                }
                                                                                                {
                                                                                                    let v1419:
                                                                                                                Vec<u8> =
                                                                                                            match &_v1409.get().clone()
                                                                                                                {
                                                                                                                None
                                                                                                                =>
                                                                                                                panic!("{}",
                                                                                                                       string("base.run_target / _v1409=None"),),
                                                                                                                Some(_v1409_0_0)
                                                                                                                =>
                                                                                                                _v1409_0_0.clone(),
                                                                                                            };
                                                                                                    let v1421:
                                                                                                                Result<std::string::String,
                                                                                                                       std::string::FromUtf8Error> =
                                                                                                            std::string::String::from_utf8(v1419);
                                                                                                    let v1423:
                                                                                                                std::string::String =
                                                                                                            v1421.unwrap();
                                                                                                    {
                                                                                                        let x_98:
                                                                                                                    string =
                                                                                                                fable_library_rust::String_::fromString(v1423);
                                                                                                        _v1408.set(Some(x_98))
                                                                                                    }
                                                                                                    {
                                                                                                        let v1431:
                                                                                                                    string =
                                                                                                                match &_v1408.get().clone()
                                                                                                                    {
                                                                                                                    None
                                                                                                                    =>
                                                                                                                    panic!("{}",
                                                                                                                           string("base.run_target / _v1408=None"),),
                                                                                                                    Some(_v1408_0_0)
                                                                                                                    =>
                                                                                                                    _v1408_0_0.clone(),
                                                                                                                };
                                                                                                        let v1433:
                                                                                                                    bool =
                                                                                                                contains(v1431.clone(),
                                                                                                                         string("// spiral_builder.process_typescript"));
                                                                                                        let v1458:
                                                                                                                    string =
                                                                                                                if v1433
                                                                                                                   {
                                                                                                                    v1431.clone()
                                                                                                                } else {
                                                                                                                    let v1436:
                                                                                                                            string =
                                                                                                                        replace(v1431,
                                                                                                                                sprintf!("\"./fable_modules/fable-library-ts.{}/",
                                                                                                                                         v1310.clone()),
                                                                                                                                sprintf!("\"{}/lib/typescript/fable/fable_modules/fable-library-ts.{}/",
                                                                                                                                         v1281,
                                                                                                                                         v1310.clone()));
                                                                                                                    let v1437:
                                                                                                                            string =
                                                                                                                        Spiral_builder::method97();
                                                                                                                    let _v1438:
                                                                                                                            MutCell<Option<string>> =
                                                                                                                        MutCell::new(None::<string>);
                                                                                                                    let v1439:
                                                                                                                            string =
                                                                                                                        Spiral_builder::method37(v1436);
                                                                                                                    let v1442:
                                                                                                                            Result<regex::Regex,
                                                                                                                                   regex::Error> =
                                                                                                                        regex::Regex::new(&string("\\s\\sdefaultOf\\(\\);"));
                                                                                                                    let v1444:
                                                                                                                            regex::Regex =
                                                                                                                        v1442.unwrap();
                                                                                                                    let v1446:
                                                                                                                            std::borrow::Cow<str> =
                                                                                                                        v1444.replace_all(&v1439, &*v1437);
                                                                                                                    let v1448:
                                                                                                                            std::string::String =
                                                                                                                        String::from(v1446);
                                                                                                                    {
                                                                                                                        let x_100:
                                                                                                                                string =
                                                                                                                            fable_library_rust::String_::fromString(v1448);
                                                                                                                        _v1438.set(Some(x_100))
                                                                                                                    }
                                                                                                                    match &_v1438.get().clone()
                                                                                                                        {
                                                                                                                        None
                                                                                                                        =>
                                                                                                                        panic!("{}",
                                                                                                                               string("base.run_target / _v1438=None"),),
                                                                                                                        Some(_v1438_0_0)
                                                                                                                        =>
                                                                                                                        _v1438_0_0.clone(),
                                                                                                                    }
                                                                                                                };
                                                                                                        if v1433
                                                                                                                   ==
                                                                                                                   false
                                                                                                               {
                                                                                                                let v1460:
                                                                                                                        string =
                                                                                                                    sprintf!("{}\n\n{}\n",
                                                                                                                             v1458.clone(),
                                                                                                                             string("// spiral_builder.process_typescript"));
                                                                                                                if Spiral_builder::method84(v1404.clone(),
                                                                                                                                            v1460.clone())
                                                                                                                       ==
                                                                                                                       false
                                                                                                                   {
                                                                                                                    let _v1463:
                                                                                                                            MutCell<Option<()>> =
                                                                                                                        MutCell::new(None::<()>);
                                                                                                                    std::fs::write(&*v1404.clone(), &*v1460).unwrap();
                                                                                                                    _v1463.set(Some(()));
                                                                                                                    match &_v1463.get().clone()
                                                                                                                        {
                                                                                                                        None
                                                                                                                        =>
                                                                                                                        panic!("{}",
                                                                                                                               string("base.run_target / _v1463=None"),),
                                                                                                                        Some(_v1463_0_0)
                                                                                                                        =>
                                                                                                                        _v1463_0_0.clone(),
                                                                                                                    }
                                                                                                                    ()
                                                                                                                }
                                                                                                            }
                                                                                                        {
                                                                                                            let v1466:
                                                                                                                        string =
                                                                                                                    sprintf!("bun run \"{}\"",
                                                                                                                             v1404.clone());
                                                                                                            let v1469:
                                                                                                                        Array<(string,
                                                                                                                               string)> =
                                                                                                                    new_array(&[(string("TRACE_LEVEL"),
                                                                                                                                 string("Verbose"))]);
                                                                                                            let v1480:
                                                                                                                        Result<string,
                                                                                                                               string> =
                                                                                                                    match &v1267
                                                                                                                        {
                                                                                                                        Spiral_builder::US28::US28_0(v1267_0_0)
                                                                                                                        =>
                                                                                                                        Ok::<string,
                                                                                                                             string>(v1267_0_0.clone()),
                                                                                                                        Spiral_builder::US28::US28_1(v1267_1_0)
                                                                                                                        =>
                                                                                                                        Err::<string,
                                                                                                                              string>(v1267_1_0.clone()),
                                                                                                                    };
                                                                                                            let patternInput_9:
                                                                                                                        (i32,
                                                                                                                         string) =
                                                                                                                    Spiral_builder::method44(None::<CancellationToken>,
                                                                                                                                             v1466.clone(),
                                                                                                                                             v1469.clone(),
                                                                                                                                             None::<Func1<(bool,
                                                                                                                                                           string,
                                                                                                                                                           i32),
                                                                                                                                                          Arc<Async<()>>>>,
                                                                                                                                             None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                                          ()>>,
                                                                                                                                             true,
                                                                                                                                             v1480.ok());
                                                                                                            let v1485:
                                                                                                                        string =
                                                                                                                    patternInput_9.1.clone();
                                                                                                            let v1484:
                                                                                                                        i32 =
                                                                                                                    patternInput_9.0.clone();
                                                                                                            let v1486:
                                                                                                                        i32 =
                                                                                                                    count_2(v1469.clone());
                                                                                                            let v1487:
                                                                                                                        Array<string> =
                                                                                                                    new_init(&string(""),
                                                                                                                             v1486);
                                                                                                            let v1488:
                                                                                                                        LrcPtr<Spiral_builder::Mut4> =
                                                                                                                    LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                                         MutCell::new(0_i32),});
                                                                                                            while Spiral_builder::method16(v1486,
                                                                                                                                               v1488.clone())
                                                                                                                      {
                                                                                                                    let v1490:
                                                                                                                            i32 =
                                                                                                                        v1488.l0.get().clone();
                                                                                                                    let patternInput_10:
                                                                                                                            (string,
                                                                                                                             string) =
                                                                                                                        v1469[v1490].clone();
                                                                                                                    let v1493:
                                                                                                                            string =
                                                                                                                        sprintf!("$env:{}=\'\'{}\'\'",
                                                                                                                                 patternInput_10.0.clone(),
                                                                                                                                 patternInput_10.1.clone());
                                                                                                                    v1487.get_mut()[v1490
                                                                                                                                        as
                                                                                                                                        usize]
                                                                                                                        =
                                                                                                                        v1493;
                                                                                                                    {
                                                                                                                        let v1494:
                                                                                                                                i32 =
                                                                                                                            v1490
                                                                                                                                +
                                                                                                                                1_i32;
                                                                                                                        v1488.l0.set(v1494);
                                                                                                                        ()
                                                                                                                    }
                                                                                                                }
                                                                                                            {
                                                                                                                let v1501:
                                                                                                                            string =
                                                                                                                        sprintf!("pwsh -c \'{}; {}\'",
                                                                                                                                 join(string(";"),
                                                                                                                                      toArray_1(ofArray_1(v1487.clone()))),
                                                                                                                                 v1466);
                                                                                                                if v1484
                                                                                                                           ==
                                                                                                                           0_i32
                                                                                                                       {
                                                                                                                        let v1506:
                                                                                                                                Spiral_builder::US3 =
                                                                                                                            try_catch(||
                                                                                                                                          Spiral_builder::closure72((),
                                                                                                                                                                    Spiral_builder::closure92(v1485.clone(),
                                                                                                                                                                                              ())),
                                                                                                                                      |ex_1:
                                                                                                                                           LrcPtr<Exception>|
                                                                                                                                          Spiral_builder::closure93(v1404.clone(),
                                                                                                                                                                    v1485.clone(),
                                                                                                                                                                    v1501.clone(),
                                                                                                                                                                    ex_1.clone()));
                                                                                                                        let v1511:
                                                                                                                                Option<string> =
                                                                                                                            match &v1506
                                                                                                                                {
                                                                                                                                Spiral_builder::US3::US3_0(v1506_0_0)
                                                                                                                                =>
                                                                                                                                Some(match &v1506
                                                                                                                                         {
                                                                                                                                         Spiral_builder::US3::US3_0(x)
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
                                                                                                                        (Spiral_builder::US3::US3_0(v1458),
                                                                                                                         Spiral_builder::US3::US3_0(string("ts")),
                                                                                                                         Spiral_builder::US3::US3_0(v1511.unwrap()))
                                                                                                                    } else {
                                                                                                                        Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                                                Func0::new(move
                                                                                                                                                               ||
                                                                                                                                                               Spiral_builder::closure96((),
                                                                                                                                                                                         ())),
                                                                                                                                                Func0::new({
                                                                                                                                                               let v1404
                                                                                                                                                                   =
                                                                                                                                                                   v1404.clone();
                                                                                                                                                               let v1484
                                                                                                                                                                   =
                                                                                                                                                                   v1484.clone();
                                                                                                                                                               let v1485
                                                                                                                                                                   =
                                                                                                                                                                   v1485.clone();
                                                                                                                                                               let v1501
                                                                                                                                                                   =
                                                                                                                                                                   v1501.clone();
                                                                                                                                                               move
                                                                                                                                                                   ||
                                                                                                                                                                   Spiral_builder::closure97(v1404.clone(),
                                                                                                                                                                                             v1485.clone(),
                                                                                                                                                                                             v1484,
                                                                                                                                                                                             v1501.clone(),
                                                                                                                                                                                             ())
                                                                                                                                                           }));
                                                                                                                        (Spiral_builder::US3::US3_1,
                                                                                                                         Spiral_builder::US3::US3_0(string("ts")),
                                                                                                                         Spiral_builder::US3::US3_1)
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
                                        } else {
                                            if fable_library_rust::String_::fromString(v13.clone())
                                                == string("python")
                                            {
                                                let v1533: string = Spiral_builder::method11();
                                                let v1535: &str = &*v1533;
                                                let v1537: Option<std::string::String> =
                                                    clap::ArgMatches::get_one(&v14.clone(), v1535)
                                                        .cloned();
                                                let _v1538: LrcPtr<
                                                    MutCell<Option<Spiral_builder::US5>>,
                                                > = refCell(None::<Spiral_builder::US5>);
                                                {
                                                    let x_106: Option<Spiral_builder::US5> =
                                                        match &v1537 {
                                                            None => None::<Spiral_builder::US5>,
                                                            Some(v1537_0_0) => {
                                                                let x_104: std::string::String =
                                                                    v1537_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_104 = x_104.clone();
                                                                    move || {
                                                                        Spiral_builder::US5::US5_0(
                                                                            x_104.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                    _v1538.set(x_106)
                                                }
                                                {
                                                    let v1543: Spiral_builder::US5 = defaultValue(
                                                        Spiral_builder::US5::US5_1,
                                                        _v1538.get().clone(),
                                                    );
                                                    let v1547: std::string::String = match &v1543 {
                                                        Spiral_builder::US5::US5_0(v1543_0_0) => {
                                                            match &v1543 {
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
                                                    };
                                                    let v1549: string =
                                                        fable_library_rust::String_::fromString(
                                                            v1547,
                                                        );
                                                    let v1550: string = Spiral_builder::method66();
                                                    let v1552: &str = &*v1550;
                                                    let v1554: Option<Vec<std::string::String>> =
                                                        clap::ArgMatches::get_many(
                                                            &v14.clone(),
                                                            v1552,
                                                        )
                                                        .map(|x| x.cloned().into_iter().collect());
                                                    let _v1555: LrcPtr<
                                                        MutCell<Option<Spiral_builder::US25>>,
                                                    > = refCell(None::<Spiral_builder::US25>);
                                                    {
                                                        let x_109: Option<Spiral_builder::US25> =
                                                            match &v1554 {
                                                                None => {
                                                                    None::<Spiral_builder::US25>
                                                                }
                                                                Some(v1554_0_0) => {
                                                                    let x_107: Vec<
                                                                        std::string::String,
                                                                    > = v1554_0_0.clone();
                                                                    Some((Func0::new({
                                                                        let x_107 = x_107.clone();
                                                                        move || {
                                                                            Spiral_builder::US25::US25_0(x_107.clone())
                                                                        }
                                                                    }))(
                                                                    ))
                                                                }
                                                            };
                                                        _v1555.set(x_109)
                                                    }
                                                    {
                                                        let v1560: Spiral_builder::US25 =
                                                            defaultValue(
                                                                Spiral_builder::US25::US25_1,
                                                                _v1555.get().clone(),
                                                            );
                                                        let v1563: Vec<std::string::String> =
                                                            new_empty::<std::string::String>()
                                                                .to_vec();
                                                        let v1566:
                                                                    Vec<std::string::String> =
                                                                match &v1560 {
                                                                    Spiral_builder::US25::US25_0(v1560_0_0)
                                                                    =>
                                                                    match &v1560
                                                                        {
                                                                        Spiral_builder::US25::US25_0(x)
                                                                        =>
                                                                        x.clone(),
                                                                        _ =>
                                                                        unreachable!(),
                                                                    },
                                                                    _ =>
                                                                    v1563,
                                                                };
                                                        let v1568: bool =
                                                            if let Spiral_builder::US0::US0_0 =
                                                                &v0_1
                                                            {
                                                                true
                                                            } else {
                                                                false
                                                            };
                                                        let _v1569: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let _v1570: MutCell<Option<Vec<u8>>> =
                                                            MutCell::new(None::<Vec<u8>>);
                                                        {
                                                            let x_110: Vec<u8> =
                                                                std::fs::read(&*v1549).unwrap();
                                                            _v1570.set(Some(x_110))
                                                        }
                                                        {
                                                            let v1580:
                                                                        Vec<u8> =
                                                                    match &_v1570.get().clone()
                                                                        {
                                                                        None
                                                                        =>
                                                                        panic!("{}",
                                                                               string("base.run_target / _v1570=None"),),
                                                                        Some(_v1570_0_0)
                                                                        =>
                                                                        _v1570_0_0.clone(),
                                                                    };
                                                            let v1582: Result<
                                                                std::string::String,
                                                                std::string::FromUtf8Error,
                                                            > = std::string::String::from_utf8(
                                                                v1580,
                                                            );
                                                            let v1584: std::string::String =
                                                                v1582.unwrap();
                                                            {
                                                                let x_112:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v1584);
                                                                _v1569.set(Some(x_112))
                                                            }
                                                            {
                                                                let v1592:
                                                                            string =
                                                                        match &_v1569.get().clone()
                                                                            {
                                                                            None
                                                                            =>
                                                                            panic!("{}",
                                                                                   string("base.run_target / _v1569=None"),),
                                                                            Some(_v1569_0_0)
                                                                            =>
                                                                            _v1569_0_0.clone(),
                                                                        };
                                                                let v1595: string =
                                                                    Spiral_builder::method67(
                                                                        sprintf!(
                                                                            "{:?}",
                                                                            (
                                                                                string("py"),
                                                                                v1592.clone()
                                                                            )
                                                                        ),
                                                                    );
                                                                let v1608:
                                                                            string =
                                                                        Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method30(Spiral_builder::method69(Spiral_builder::method30(string("polyglot"),
                                                                                                                                                                                                                                                       string(".paket")),
                                                                                                                                                                                                                              string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\spiral_builder")),
                                                                                                                                                                                                     string("polyglot")),
                                                                                                                                                                            string("target/polyglot/spiral_builder")),
                                                                                                                                                   string("spiral_builder")),
                                                                                                                          string("packages")),
                                                                                                 v1595.clone());
                                                                let v1609: LrcPtr<dyn IDisposable> =
                                                                    Spiral_builder::method74(
                                                                        v1608.clone(),
                                                                    );
                                                                let v1611: string =
                                                                    Spiral_builder::method30(
                                                                        v1608.clone(),
                                                                        sprintf!(
                                                                            "{}.fs",
                                                                            string(
                                                                                "spiral_builder"
                                                                            )
                                                                        ),
                                                                    );
                                                                let v1612: string =
                                                                    Spiral_builder::method36();
                                                                let _v1613: MutCell<
                                                                    Option<string>,
                                                                > = MutCell::new(None::<string>);
                                                                let v1614: string =
                                                                    Spiral_builder::method37(v1611);
                                                                let v1617: Result<
                                                                    regex::Regex,
                                                                    regex::Error,
                                                                > = regex::Regex::new(&string(
                                                                    "^\\\\\\\\\\?\\\\",
                                                                ));
                                                                let v1619: regex::Regex =
                                                                    v1617.unwrap();
                                                                let v1621: std::borrow::Cow<str> =
                                                                    v1619.replace_all(
                                                                        &v1614, &*v1612,
                                                                    );
                                                                let v1623: std::string::String =
                                                                    String::from(v1621);
                                                                {
                                                                    let x_114:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v1623);
                                                                    _v1613.set(Some(x_114))
                                                                }
                                                                {
                                                                    let v1632:
                                                                                string =
                                                                            match &_v1613.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v1613=None"),),
                                                                                Some(_v1613_0_0)
                                                                                =>
                                                                                _v1613_0_0.clone(),
                                                                            };
                                                                    let v1636: string = replace(
                                                                        sprintf!(
                                                                            "{}{}",
                                                                            toLower(ofChar(
                                                                                getCharAt(
                                                                                    v1632.clone(),
                                                                                    0_i32
                                                                                )
                                                                            )),
                                                                            getSlice(
                                                                                v1632,
                                                                                Some(1_i32),
                                                                                None::<i32>
                                                                            )
                                                                        ),
                                                                        string("\\"),
                                                                        string("/"),
                                                                    );
                                                                    if Spiral_builder::method84(
                                                                        v1636.clone(),
                                                                        v1592.clone(),
                                                                    ) == false
                                                                    {
                                                                        let _v1639: MutCell<
                                                                            Option<()>,
                                                                        > = MutCell::new(
                                                                            None::<()>,
                                                                        );
                                                                        std::fs::write(
                                                                            &*v1636.clone(),
                                                                            &*v1592,
                                                                        )
                                                                        .unwrap();
                                                                        _v1639.set(Some(()));
                                                                        match &_v1639.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v1639=None"),),
                                                                                Some(_v1639_0_0)
                                                                                =>
                                                                                _v1639_0_0.clone(),
                                                                            }
                                                                        ()
                                                                    }
                                                                    {
                                                                        let v1642: List<string> =
                                                                            empty::<string>();
                                                                        let v1647: string = join(
                                                                            string("\\n        "),
                                                                            toArray_1(delay(
                                                                                Func0::new({
                                                                                    let v1642 =
                                                                                        v1642
                                                                                            .clone(
                                                                                            );
                                                                                    move || {
                                                                                        map(Func1::new({
                                                                                                                                           let v1642
                                                                                                                                               =
                                                                                                                                               v1642.clone();
                                                                                                                                           move
                                                                                                                                               |i_6:
                                                                                                                                                    i32|
                                                                                                                                               item(i_6,
                                                                                                                                                    v1642.clone())
                                                                                                                                       }),
                                                                                                                            rangeNumeric(0_i32,
                                                                                                                                         1_i32,
                                                                                                                                         length_1(v1642.clone())
                                                                                                                                             -
                                                                                                                                             1_i32))
                                                                                    }
                                                                                }),
                                                                            )),
                                                                        );
                                                                        let v1651:
                                                                                    List<string> =
                                                                                singleton(sprintf!("<PackageReference Include=\"{}\" Version=\"*\" />",
                                                                                                   string("Fable.Core")));
                                                                        let v1655: string = join(
                                                                            string("\\n        "),
                                                                            toArray_1(delay(
                                                                                Func0::new({
                                                                                    let v1651 =
                                                                                        v1651
                                                                                            .clone(
                                                                                            );
                                                                                    move || {
                                                                                        map(Func1::new({
                                                                                                                                           let v1651
                                                                                                                                               =
                                                                                                                                               v1651.clone();
                                                                                                                                           move
                                                                                                                                               |i_7:
                                                                                                                                                    i32|
                                                                                                                                               item(i_7,
                                                                                                                                                    v1651.clone())
                                                                                                                                       }),
                                                                                                                            rangeNumeric(0_i32,
                                                                                                                                         1_i32,
                                                                                                                                         length_1(v1651.clone())
                                                                                                                                             -
                                                                                                                                             1_i32))
                                                                                    }
                                                                                }),
                                                                            )),
                                                                        );
                                                                        let v1657:
                                                                                    string =
                                                                                Spiral_builder::method30(v1608,
                                                                                                         sprintf!("{}.fsproj",
                                                                                                                  string("spiral_builder")));
                                                                        let v1658:
                                                                                    string =
                                                                                Spiral_builder::method36();
                                                                        let _v1659: MutCell<
                                                                            Option<string>,
                                                                        > = MutCell::new(
                                                                            None::<string>,
                                                                        );
                                                                        let v1660:
                                                                                    string =
                                                                                Spiral_builder::method37(v1657);
                                                                        let v1662: Result<
                                                                            regex::Regex,
                                                                            regex::Error,
                                                                        > = regex::Regex::new(
                                                                            &string(
                                                                                "^\\\\\\\\\\?\\\\",
                                                                            ),
                                                                        );
                                                                        let v1664: regex::Regex =
                                                                            v1662.unwrap();
                                                                        let v1666:
                                                                                    std::borrow::Cow<str> =
                                                                                v1664.replace_all(&v1660, &*v1658);
                                                                        let v1668:
                                                                                    std::string::String =
                                                                                String::from(v1666);
                                                                        {
                                                                            let x_118:
                                                                                        string =
                                                                                    fable_library_rust::String_::fromString(v1668);
                                                                            _v1659.set(Some(x_118))
                                                                        }
                                                                        {
                                                                            let v1677:
                                                                                        string =
                                                                                    match &_v1659.get().clone()
                                                                                        {
                                                                                        None
                                                                                        =>
                                                                                        panic!("{}",
                                                                                               string("base.run_target / _v1659=None"),),
                                                                                        Some(_v1659_0_0)
                                                                                        =>
                                                                                        _v1659_0_0.clone(),
                                                                                    };
                                                                            let v1679:
                                                                                        string =
                                                                                    replace(sprintf!("{}{}",
                                                                                                     toLower(ofChar(getCharAt(v1677.clone(),
                                                                                                                              0_i32))),
                                                                                                     getSlice(v1677,
                                                                                                              Some(1_i32),
                                                                                                              None::<i32>)),
                                                                                            string("\\"),
                                                                                            string("/"));
                                                                            let v1777:
                                                                                        string =
                                                                                    append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                               sprintf!("    {}",
                                                                                                                                                                                        v1647)),
                                                                                                                                                                        string("\n")),
                                                                                                                                                                 sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                                          v1636)),
                                                                                                                                                          string("\n")),
                                                                                                                                                   string("</ItemGroup>")),
                                                                                                                                            string("\n")),
                                                                                                                                     string("<ItemGroup>")),
                                                                                                                              string("\n")),
                                                                                                                       sprintf!("    {}",
                                                                                                                                v1655)),
                                                                                                                string("\n")),
                                                                                                         string("</ItemGroup>")),
                                                                                                  string("\n")),
                                                                                           string("</Project>"));
                                                                            if Spiral_builder::method84(v1679.clone(),
                                                                                                            v1777.clone())
                                                                                       ==
                                                                                       false
                                                                                   {
                                                                                    let _v1780:
                                                                                            MutCell<Option<()>> =
                                                                                        MutCell::new(None::<()>);
                                                                                    std::fs::write(&*v1679.clone(), &*v1777).unwrap();
                                                                                    _v1780.set(Some(()));
                                                                                    match &_v1780.get().clone()
                                                                                        {
                                                                                        None
                                                                                        =>
                                                                                        panic!("{}",
                                                                                               string("base.run_target / _v1780=None"),),
                                                                                        Some(_v1780_0_0)
                                                                                        =>
                                                                                        _v1780_0_0.clone(),
                                                                                    }
                                                                                    ()
                                                                                }
                                                                            {
                                                                                let v1783:
                                                                                            string =
                                                                                        Spiral_builder::method86(v1679.clone());
                                                                                let v1787:
                                                                                            string =
                                                                                        Spiral_builder::method30(Spiral_builder::method69(Spiral_builder::method30(string("polyglot"),
                                                                                                                                                                   string(".paket")),
                                                                                                                                          string("C:\\home\\git\\polyglot\\target\\polyglot\\builder\\spiral_builder")),
                                                                                                                 string("polyglot"));
                                                                                let v1790:
                                                                                            string =
                                                                                        toLower(Spiral_builder::method29());
                                                                                let v1792: string =
                                                                                    toLower(v1787);
                                                                                let v1796:
                                                                                            Spiral_builder::US28 =
                                                                                        if startsWith(v1790,
                                                                                                      v1792.clone(),
                                                                                                      false)
                                                                                           {
                                                                                            Spiral_builder::US28::US28_1(v1792.clone())
                                                                                        } else {
                                                                                            Spiral_builder::US28::US28_0(v1792)
                                                                                        };
                                                                                let v1802:
                                                                                            Result<string,
                                                                                                   string> =
                                                                                        match &v1796
                                                                                            {
                                                                                            Spiral_builder::US28::US28_0(v1796_0_0)
                                                                                            =>
                                                                                            Ok::<string,
                                                                                                 string>(v1796_0_0.clone()),
                                                                                            Spiral_builder::US28::US28_1(v1796_1_0)
                                                                                            =>
                                                                                            Err::<string,
                                                                                                  string>(v1796_1_0.clone()),
                                                                                        };
                                                                                let v1804: bool =
                                                                                    true;
                                                                                let _result = v1802.unwrap_or_else(|x| { //;
                                                                                    let v1806:
                                                                                            string =
                                                                                        x;
                                                                                    let v1808:
                                                                                            bool =
                                                                                        true; v1806 });
                                                                                let v1814:
                                                                                            string =
                                                                                        Spiral_builder::method30(Spiral_builder::method30(_result,
                                                                                                                                          string("lib/python/fable/fable_modules")),
                                                                                                                 sprintf!("fable-library-{}",
                                                                                                                          string("py")));
                                                                                let v1816:
                                                                                            string =
                                                                                        Spiral_builder::method30(v1783.clone(),
                                                                                                                 string("fable_modules/fable-library"));
                                                                                if Spiral_builder::method70(v1814.clone())
                                                                                           ==
                                                                                           false
                                                                                       {
                                                                                        let v1819:
                                                                                                LrcPtr<dyn IDisposable> =
                                                                                            Spiral_builder::method74(v1814.clone());
                                                                                        ()
                                                                                    }
                                                                                {
                                                                                    let v1820:
                                                                                                string =
                                                                                            Spiral_builder::method86(v1816.clone());
                                                                                    if Spiral_builder::method70(v1820.clone())
                                                                                               ==
                                                                                               false
                                                                                           {
                                                                                            let v1823:
                                                                                                    LrcPtr<dyn IDisposable> =
                                                                                                Spiral_builder::method74(v1820);
                                                                                            ()
                                                                                        }
                                                                                    if if Spiral_builder::method70(v1816.clone())
                                                                                              {
                                                                                               let v1826:
                                                                                                       Result<std::path::PathBuf,
                                                                                                              std::io::Error> =
                                                                                                   std::fs::read_link(&*v1816.clone());
                                                                                               v1826.is_err()
                                                                                           } else {
                                                                                               false
                                                                                           }
                                                                                           {
                                                                                            Spiral_builder::method77(true,
                                                                                                                     v1816.clone());
                                                                                        }
                                                                                    if Spiral_builder::method70(v1816.clone())
                                                                                               ==
                                                                                               false
                                                                                           {
                                                                                            let _v1833:
                                                                                                    MutCell<Option<()>> =
                                                                                                MutCell::new(None::<()>);
                                                                                            let _v1834:
                                                                                                    MutCell<Option<()>> =
                                                                                                MutCell::new(None::<()>);
                                                                                            std::os::windows::fs::symlink_dir(&*v1814, &*v1816).unwrap();
                                                                                            _v1834.set(Some(()));
                                                                                            match &_v1834.get().clone()
                                                                                                {
                                                                                                None
                                                                                                =>
                                                                                                panic!("{}",
                                                                                                       string("runtime.run_platform / _v1834=None"),),
                                                                                                Some(_v1834_0_0)
                                                                                                =>
                                                                                                _v1834_0_0.clone(),
                                                                                            }
                                                                                            _v1833.set(Some(()));
                                                                                            match &_v1833.get().clone()
                                                                                                {
                                                                                                None
                                                                                                =>
                                                                                                panic!("{}",
                                                                                                       string("base.run_target / _v1833=None"),),
                                                                                                Some(_v1833_0_0)
                                                                                                =>
                                                                                                _v1833_0_0.clone(),
                                                                                            }
                                                                                            ()
                                                                                        }
                                                                                    {
                                                                                        let patternInput_11:
                                                                                                    (i32,
                                                                                                     string) =
                                                                                                Spiral_builder::method93(v1783.clone(),
                                                                                                                         string("py"),
                                                                                                                         v1679,
                                                                                                                         v1796.clone());
                                                                                        let v1841:
                                                                                                    string =
                                                                                                patternInput_11.1.clone();
                                                                                        let v1840:
                                                                                                    i32 =
                                                                                                patternInput_11.0.clone();
                                                                                        if v1840
                                                                                            != 0_i32
                                                                                        {
                                                                                            Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                        Func0::new({
                                                                                                                                       let v1840
                                                                                                                                           =
                                                                                                                                           v1840.clone();
                                                                                                                                       let v1841
                                                                                                                                           =
                                                                                                                                           v1841.clone();
                                                                                                                                       move
                                                                                                                                           ||
                                                                                                                                           Spiral_builder::closure98(v1841.clone(),
                                                                                                                                                                     v1840,
                                                                                                                                                                     ())
                                                                                                                                   }),
                                                                                                                        Func0::new(move
                                                                                                                                       ||
                                                                                                                                       Spiral_builder::closure6((),
                                                                                                                                                                ())));
                                                                                            (Spiral_builder::US3::US3_1,
                                                                                                 Spiral_builder::US3::US3_0(string("py")),
                                                                                                 Spiral_builder::US3::US3_0(v1841.clone()))
                                                                                        } else {
                                                                                            let v1850:
                                                                                                        bool =
                                                                                                    true;
                                                                                            let _result : Vec<_> = v1566.into_iter().map(|x| { //;
                                                                                                let v1852:
                                                                                                        std::string::String =
                                                                                                    x;
                                                                                                let v1854:
                                                                                                        string =
                                                                                                    fable_library_rust::String_::fromString(v1852);
                                                                                                let v1858:
                                                                                                        string =
                                                                                                    if contains(v1854.clone(),
                                                                                                                string("="))
                                                                                                       {
                                                                                                        v1854.clone()
                                                                                                    } else {
                                                                                                        sprintf!("\"{}\":\"*\"",
                                                                                                                 v1854)
                                                                                                    };
                                                                                                let v1860:
                                                                                                        bool =
                                                                                                    true; v1858 }).collect::<Vec<_>>();
                                                                                            let v1862:
                                                                                                        Vec<string> =
                                                                                                    _result;
                                                                                            let v1864:
                                                                                                        Array<string> =
                                                                                                    fable_library_rust::NativeArray_::array_from(v1862);
                                                                                            let v1883:
                                                                                                        string =
                                                                                                    append(append(append(append(append(append(append(string("{"),
                                                                                                                                                     sprintf!("  \"name\": \"spiral_builder_{}\",",
                                                                                                                                                              v1595)),
                                                                                                                                              string("  \"dependencies\": {")),
                                                                                                                                       join(string(",\n"),
                                                                                                                                            toArray_1(delay(Func0::new({
                                                                                                                                                                           let v1864
                                                                                                                                                                               =
                                                                                                                                                                               v1864.clone();
                                                                                                                                                                           move
                                                                                                                                                                               ||
                                                                                                                                                                               map(Func1::new({
                                                                                                                                                                                                  let v1864
                                                                                                                                                                                                      =
                                                                                                                                                                                                      v1864.clone();
                                                                                                                                                                                                  move
                                                                                                                                                                                                      |i_8:
                                                                                                                                                                                                           i32|
                                                                                                                                                                                                      v1864[i_8].clone()
                                                                                                                                                                                              }),
                                                                                                                                                                                   rangeNumeric(0_i32,
                                                                                                                                                                                                1_i32,
                                                                                                                                                                                                count_2(v1864.clone())
                                                                                                                                                                                                    -
                                                                                                                                                                                                    1_i32))
                                                                                                                                                                       }))))),
                                                                                                                                string("  },")),
                                                                                                                         string("    \"devDependencies\": {")),
                                                                                                                  string("  },")),
                                                                                                           string("}"));
                                                                                            let v1885:
                                                                                                        string =
                                                                                                    Spiral_builder::method30(v1783.clone(),
                                                                                                                             string("package.json"));
                                                                                            let v1888:
                                                                                                        string =
                                                                                                    Spiral_builder::method30(Spiral_builder::method30(v1783.clone(),
                                                                                                                                                      string("../..")),
                                                                                                                             string("package.json"));
                                                                                            if Spiral_builder::method84(v1885.clone(),
                                                                                                                            v1883.clone())
                                                                                                       ==
                                                                                                       false
                                                                                                   {
                                                                                                    let _v1891:
                                                                                                            MutCell<Option<()>> =
                                                                                                        MutCell::new(None::<()>);
                                                                                                    std::fs::write(&*v1885, &*v1883).unwrap();
                                                                                                    _v1891.set(Some(()));
                                                                                                    match &_v1891.get().clone()
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        panic!("{}",
                                                                                                               string("base.run_target / _v1891=None"),),
                                                                                                        Some(_v1891_0_0)
                                                                                                        =>
                                                                                                        _v1891_0_0.clone(),
                                                                                                    }
                                                                                                    ()
                                                                                                }
                                                                                            if Spiral_builder::method84(v1888.clone(),
                                                                                                                            string(""))
                                                                                                       ==
                                                                                                       false
                                                                                                   {
                                                                                                    let _v1897:
                                                                                                            MutCell<Option<()>> =
                                                                                                        MutCell::new(None::<()>);
                                                                                                    std::fs::write(&*v1888, &*string("")).unwrap();
                                                                                                    _v1897.set(Some(()));
                                                                                                    match &_v1897.get().clone()
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        panic!("{}",
                                                                                                               string("base.run_target / _v1897=None"),),
                                                                                                        Some(_v1897_0_0)
                                                                                                        =>
                                                                                                        _v1897_0_0.clone(),
                                                                                                    }
                                                                                                    ()
                                                                                                }
                                                                                            {
                                                                                                let v1901:
                                                                                                            string =
                                                                                                        Spiral_builder::method30(v1783,
                                                                                                                                 sprintf!("{}.{}",
                                                                                                                                          string("spiral_builder"),
                                                                                                                                          string("py")));
                                                                                                Spiral_builder::method5(Spiral_builder::US0::US0_1,
                                                                                                                            Func0::new(move
                                                                                                                                           ||
                                                                                                                                           Spiral_builder::closure99((),
                                                                                                                                                                     ())),
                                                                                                                            Func0::new({
                                                                                                                                           let v1901
                                                                                                                                               =
                                                                                                                                               v1901.clone();
                                                                                                                                           move
                                                                                                                                               ||
                                                                                                                                               Spiral_builder::closure100(v1901.clone(),
                                                                                                                                                                          ())
                                                                                                                                       }));
                                                                                                {
                                                                                                    let _v1905:
                                                                                                                MutCell<Option<string>> =
                                                                                                            MutCell::new(None::<string>);
                                                                                                    let _v1906:
                                                                                                                MutCell<Option<Vec<u8>>> =
                                                                                                            MutCell::new(None::<Vec<u8>>);
                                                                                                    {
                                                                                                        let x_130:
                                                                                                                    Vec<u8> =
                                                                                                                std::fs::read(&*v1901.clone()).unwrap();
                                                                                                        _v1906.set(Some(x_130))
                                                                                                    }
                                                                                                    {
                                                                                                        let v1916:
                                                                                                                    Vec<u8> =
                                                                                                                match &_v1906.get().clone()
                                                                                                                    {
                                                                                                                    None
                                                                                                                    =>
                                                                                                                    panic!("{}",
                                                                                                                           string("base.run_target / _v1906=None"),),
                                                                                                                    Some(_v1906_0_0)
                                                                                                                    =>
                                                                                                                    _v1906_0_0.clone(),
                                                                                                                };
                                                                                                        let v1918:
                                                                                                                    Result<std::string::String,
                                                                                                                           std::string::FromUtf8Error> =
                                                                                                                std::string::String::from_utf8(v1916);
                                                                                                        let v1920:
                                                                                                                    std::string::String =
                                                                                                                v1918.unwrap();
                                                                                                        {
                                                                                                            let x_132:
                                                                                                                        string =
                                                                                                                    fable_library_rust::String_::fromString(v1920);
                                                                                                            _v1905.set(Some(x_132))
                                                                                                        }
                                                                                                        {
                                                                                                            let v1928:
                                                                                                                        string =
                                                                                                                    match &_v1905.get().clone()
                                                                                                                        {
                                                                                                                        None
                                                                                                                        =>
                                                                                                                        panic!("{}",
                                                                                                                               string("base.run_target / _v1905=None"),),
                                                                                                                        Some(_v1905_0_0)
                                                                                                                        =>
                                                                                                                        _v1905_0_0.clone(),
                                                                                                                    };
                                                                                                            let v1930:
                                                                                                                        bool =
                                                                                                                    contains(v1928.clone(),
                                                                                                                             string("# spiral_builder.process_python"));
                                                                                                            let v1958:
                                                                                                                        string =
                                                                                                                    if v1930
                                                                                                                       {
                                                                                                                        v1928.clone()
                                                                                                                    } else {
                                                                                                                        let v1936:
                                                                                                                                string =
                                                                                                                            replace(v1928,
                                                                                                                                    append(string("),)"),
                                                                                                                                           ";".into()),
                                                                                                                                    string("));"));
                                                                                                                        let v1937:
                                                                                                                                string =
                                                                                                                            Spiral_builder::method97();
                                                                                                                        let _v1938:
                                                                                                                                MutCell<Option<string>> =
                                                                                                                            MutCell::new(None::<string>);
                                                                                                                        let v1939:
                                                                                                                                string =
                                                                                                                            Spiral_builder::method37(v1936);
                                                                                                                        let v1942:
                                                                                                                                Result<regex::Regex,
                                                                                                                                       regex::Error> =
                                                                                                                            regex::Regex::new(&string("\\s\\sdefaultOf\\(\\);"));
                                                                                                                        let v1944:
                                                                                                                                regex::Regex =
                                                                                                                            v1942.unwrap();
                                                                                                                        let v1946:
                                                                                                                                std::borrow::Cow<str> =
                                                                                                                            v1944.replace_all(&v1939, &*v1937);
                                                                                                                        let v1948:
                                                                                                                                std::string::String =
                                                                                                                            String::from(v1946);
                                                                                                                        {
                                                                                                                            let x_134:
                                                                                                                                    string =
                                                                                                                                fable_library_rust::String_::fromString(v1948);
                                                                                                                            _v1938.set(Some(x_134))
                                                                                                                        }
                                                                                                                        match &_v1938.get().clone()
                                                                                                                            {
                                                                                                                            None
                                                                                                                            =>
                                                                                                                            panic!("{}",
                                                                                                                                   string("base.run_target / _v1938=None"),),
                                                                                                                            Some(_v1938_0_0)
                                                                                                                            =>
                                                                                                                            _v1938_0_0.clone(),
                                                                                                                        }
                                                                                                                    };
                                                                                                            if v1930
                                                                                                                       ==
                                                                                                                       false
                                                                                                                   {
                                                                                                                    let v1960:
                                                                                                                            string =
                                                                                                                        sprintf!("{}\n\n{}\n",
                                                                                                                                 v1958.clone(),
                                                                                                                                 string("# spiral_builder.process_python"));
                                                                                                                    if Spiral_builder::method84(v1901.clone(),
                                                                                                                                                v1960.clone())
                                                                                                                           ==
                                                                                                                           false
                                                                                                                       {
                                                                                                                        let _v1963:
                                                                                                                                MutCell<Option<()>> =
                                                                                                                            MutCell::new(None::<()>);
                                                                                                                        std::fs::write(&*v1901.clone(), &*v1960).unwrap();
                                                                                                                        _v1963.set(Some(()));
                                                                                                                        match &_v1963.get().clone()
                                                                                                                            {
                                                                                                                            None
                                                                                                                            =>
                                                                                                                            panic!("{}",
                                                                                                                                   string("base.run_target / _v1963=None"),),
                                                                                                                            Some(_v1963_0_0)
                                                                                                                            =>
                                                                                                                            _v1963_0_0.clone(),
                                                                                                                        }
                                                                                                                        ()
                                                                                                                    }
                                                                                                                }
                                                                                                            {
                                                                                                                let v1966:
                                                                                                                            string =
                                                                                                                        sprintf!("python \"{}\"",
                                                                                                                                 v1901.clone());
                                                                                                                let v1969:
                                                                                                                            Array<(string,
                                                                                                                                   string)> =
                                                                                                                        new_array(&[(string("TRACE_LEVEL"),
                                                                                                                                     string("Verbose"))]);
                                                                                                                let v1980:
                                                                                                                            Result<string,
                                                                                                                                   string> =
                                                                                                                        match &v1796
                                                                                                                            {
                                                                                                                            Spiral_builder::US28::US28_0(v1796_0_0)
                                                                                                                            =>
                                                                                                                            Ok::<string,
                                                                                                                                 string>(v1796_0_0.clone()),
                                                                                                                            Spiral_builder::US28::US28_1(v1796_1_0)
                                                                                                                            =>
                                                                                                                            Err::<string,
                                                                                                                                  string>(v1796_1_0.clone()),
                                                                                                                        };
                                                                                                                let patternInput_12:
                                                                                                                            (i32,
                                                                                                                             string) =
                                                                                                                        Spiral_builder::method44(None::<CancellationToken>,
                                                                                                                                                 v1966.clone(),
                                                                                                                                                 v1969.clone(),
                                                                                                                                                 None::<Func1<(bool,
                                                                                                                                                               string,
                                                                                                                                                               i32),
                                                                                                                                                              Arc<Async<()>>>>,
                                                                                                                                                 None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                                              ()>>,
                                                                                                                                                 true,
                                                                                                                                                 v1980.ok());
                                                                                                                let v1985:
                                                                                                                            string =
                                                                                                                        patternInput_12.1.clone();
                                                                                                                let v1984:
                                                                                                                            i32 =
                                                                                                                        patternInput_12.0.clone();
                                                                                                                let v1986:
                                                                                                                            i32 =
                                                                                                                        count_2(v1969.clone());
                                                                                                                let v1987:
                                                                                                                            Array<string> =
                                                                                                                        new_init(&string(""),
                                                                                                                                 v1986);
                                                                                                                let v1988:
                                                                                                                            LrcPtr<Spiral_builder::Mut4> =
                                                                                                                        LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                                             MutCell::new(0_i32),});
                                                                                                                while Spiral_builder::method16(v1986,
                                                                                                                                                   v1988.clone())
                                                                                                                          {
                                                                                                                        let v1990:
                                                                                                                                i32 =
                                                                                                                            v1988.l0.get().clone();
                                                                                                                        let patternInput_13:
                                                                                                                                (string,
                                                                                                                                 string) =
                                                                                                                            v1969[v1990].clone();
                                                                                                                        let v1993:
                                                                                                                                string =
                                                                                                                            sprintf!("$env:{}=\'\'{}\'\'",
                                                                                                                                     patternInput_13.0.clone(),
                                                                                                                                     patternInput_13.1.clone());
                                                                                                                        v1987.get_mut()[v1990
                                                                                                                                            as
                                                                                                                                            usize]
                                                                                                                            =
                                                                                                                            v1993;
                                                                                                                        {
                                                                                                                            let v1994:
                                                                                                                                    i32 =
                                                                                                                                v1990
                                                                                                                                    +
                                                                                                                                    1_i32;
                                                                                                                            v1988.l0.set(v1994);
                                                                                                                            ()
                                                                                                                        }
                                                                                                                    }
                                                                                                                {
                                                                                                                    let v2001:
                                                                                                                                string =
                                                                                                                            sprintf!("pwsh -c \'{}; {}\'",
                                                                                                                                     join(string(";"),
                                                                                                                                          toArray_1(ofArray_1(v1987.clone()))),
                                                                                                                                     v1966);
                                                                                                                    if v1984
                                                                                                                               ==
                                                                                                                               0_i32
                                                                                                                           {
                                                                                                                            let v2006:
                                                                                                                                    Spiral_builder::US3 =
                                                                                                                                try_catch(||
                                                                                                                                              Spiral_builder::closure72((),
                                                                                                                                                                        Spiral_builder::closure101(v1985.clone(),
                                                                                                                                                                                                   ())),
                                                                                                                                          |ex_2:
                                                                                                                                               LrcPtr<Exception>|
                                                                                                                                              Spiral_builder::closure102(v1901.clone(),
                                                                                                                                                                         v1985.clone(),
                                                                                                                                                                         v2001.clone(),
                                                                                                                                                                         ex_2.clone()));
                                                                                                                            let v2011:
                                                                                                                                    Option<string> =
                                                                                                                                match &v2006
                                                                                                                                    {
                                                                                                                                    Spiral_builder::US3::US3_0(v2006_0_0)
                                                                                                                                    =>
                                                                                                                                    Some(match &v2006
                                                                                                                                             {
                                                                                                                                             Spiral_builder::US3::US3_0(x)
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
                                                                                                                            (Spiral_builder::US3::US3_0(v1958),
                                                                                                                             Spiral_builder::US3::US3_0(string("py")),
                                                                                                                             Spiral_builder::US3::US3_0(v2011.unwrap()))
                                                                                                                        } else {
                                                                                                                            Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                                                    Func0::new(move
                                                                                                                                                                   ||
                                                                                                                                                                   Spiral_builder::closure105((),
                                                                                                                                                                                              ())),
                                                                                                                                                    Func0::new({
                                                                                                                                                                   let v1901
                                                                                                                                                                       =
                                                                                                                                                                       v1901.clone();
                                                                                                                                                                   let v1984
                                                                                                                                                                       =
                                                                                                                                                                       v1984.clone();
                                                                                                                                                                   let v1985
                                                                                                                                                                       =
                                                                                                                                                                       v1985.clone();
                                                                                                                                                                   let v2001
                                                                                                                                                                       =
                                                                                                                                                                       v2001.clone();
                                                                                                                                                                   move
                                                                                                                                                                       ||
                                                                                                                                                                       Spiral_builder::closure106(v1901.clone(),
                                                                                                                                                                                                  v1985.clone(),
                                                                                                                                                                                                  v1984,
                                                                                                                                                                                                  v2001.clone(),
                                                                                                                                                                                                  ())
                                                                                                                                                               }));
                                                                                                                            (Spiral_builder::US3::US3_1,
                                                                                                                             Spiral_builder::US3::US3_0(string("py")),
                                                                                                                             Spiral_builder::US3::US3_1)
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
                                            } else {
                                                Spiral_builder::method5(
                                                    Spiral_builder::US0::US0_1,
                                                    Func0::new(move || {
                                                        Spiral_builder::closure107((), ())
                                                    }),
                                                    Func0::new({
                                                        let v13 = v13.clone();
                                                        let v14 = v14.clone();
                                                        move || {
                                                            Spiral_builder::closure108(
                                                                v14.clone(),
                                                                v13.clone(),
                                                                (),
                                                            )
                                                        }
                                                    }),
                                                );
                                                (
                                                    Spiral_builder::US3::US3_1,
                                                    Spiral_builder::US3::US3_1,
                                                    Spiral_builder::US3::US3_1,
                                                )
                                            }
                                        }
                                    };
                                    let v2043: Spiral_builder::US3 = patternInput_14.2.clone();
                                    let v2042: Spiral_builder::US3 = patternInput_14.1.clone();
                                    let v2041: Spiral_builder::US3 = patternInput_14.0.clone();
                                    new_array(&[
                                        (
                                            string("extension"),
                                            match &v2042 {
                                                Spiral_builder::US3::US3_0(v2042_0_0) => {
                                                    match &v2042 {
                                                        Spiral_builder::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                _ => string(""),
                                            },
                                        ),
                                        (
                                            string("code"),
                                            match &v2041 {
                                                Spiral_builder::US3::US3_0(v2041_0_0) => {
                                                    match &v2041 {
                                                        Spiral_builder::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                _ => string(""),
                                            },
                                        ),
                                        (
                                            string("output"),
                                            match &v2043 {
                                                Spiral_builder::US3::US3_0(v2043_0_0) => {
                                                    match &v2043 {
                                                        Spiral_builder::US3::US3_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                _ => string(""),
                                            },
                                        ),
                                    ])
                                }
                            }
                        } else {
                            new_array(&[
                                (string("extension"), string("")),
                                (string("code"), string("")),
                                (string("output"), string("")),
                            ])
                        };
                        let v2069: Vec<(string, string)> = v2067.to_vec();
                        let v2072: Vec<LrcPtr<(std::string::String, std::string::String)>> = v2069
                            .into_iter()
                            .map(|x| {
                                Func1::new(move |arg10_0040_35: (string, string)| {
                                    Spiral_builder::closure109((), arg10_0040_35)
                                })(x.clone())
                            })
                            .collect::<Vec<_>>();
                        let v2073: string =
                        string("std::collections::BTreeMap::from_iter(v2072.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                        let v2074: std::collections::BTreeMap<
                            std::string::String,
                            std::string::String,
                        > = std::collections::BTreeMap::from_iter(
                            v2072
                                .iter()
                                .map(|x| x.as_ref())
                                .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                        );
                        let v2076: Result<std::string::String, serde_json::Error> =
                            serde_json::to_string(&v2074);
                        let v2077 = Spiral_builder::method108();
                        let v2079: Result<std::string::String, string> =
                            v2076.map_err(|x| v2077(x));
                        let v2081: bool = true;
                        let _result = v2079.map(|x| {
                            //;
                            let v2083: std::string::String = x;
                            let v2085: string = fable_library_rust::String_::fromString(v2083);
                            let v2087: bool = true;
                            v2085
                        });
                        let v2090: Result<string, string> = Spiral_builder::method109(_result);
                        let v2099: string = string("v2090 }}}); {{ //");
                        v2090
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
                Spiral_builder::method5(
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
                    let v15: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Result<string, string>>>,
                    > = Spiral_builder::method10(v5.l0.get().clone(), v13);
                    let v17 = tokio::runtime::Builder::new_multi_thread()
                        .enable_all()
                        .build()
                        .unwrap();
                    let v19: Result<string, string> = v17.handle().block_on(v15);
                    let v21: string = v19.unwrap();
                    if if let Spiral_builder::US0::US0_2 = &v5.l0.get().clone() {
                        true
                    } else {
                        false
                    } {
                        printfn!("{0}", v21);
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
