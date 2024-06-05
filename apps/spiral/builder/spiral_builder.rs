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
            US7_0(Spiral_builder::US8),
            US7_1,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US6 {
            US6_0(Spiral_builder::US7),
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
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(Vec<std::string::String>),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US10 {
            US10_0,
            US10_1,
            US10_2,
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
            pub fn get_IsUS10_2(this_: &MutCell<Spiral_builder::US10>, unitArg: ()) -> bool {
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US11 {
            US11_0(Spiral_builder::US10),
            US11_1(Spiral_builder::US10),
            US11_2(Spiral_builder::US10),
            US11_3(Spiral_builder::US10),
            US11_4(Spiral_builder::US10),
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
            pub fn get_IsUS11_2(this_: &MutCell<Spiral_builder::US11>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS11_3(this_: &MutCell<Spiral_builder::US11>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS11_4(this_: &MutCell<Spiral_builder::US11>, unitArg: ()) -> bool {
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
            US12_0(string),
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
        pub enum UH0 {
            UH0_0,
            UH0_1(char, LrcPtr<Spiral_builder::UH0>),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US14 {
            US14_0,
            US14_1,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US13 {
            US13_0,
            US13_1(Spiral_builder::US14),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US15 {
            US15_0(Array<string>),
            US15_1(string),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum UH1 {
            UH1_0,
            UH1_1(string, LrcPtr<Spiral_builder::UH1>),
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
        pub enum US16 {
            US16_0(
                LrcPtr<Spiral_builder::UH1>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US16_1(string),
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
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US17_1(string),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US18 {
            US18_0(char),
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
            US19_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US19_1(string),
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
        pub enum UH2 {
            UH2_0,
            UH2_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Spiral_builder::US19>,
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
        pub enum US20 {
            US20_0(string, LrcPtr<StringBuilder>, i32, i32),
            US20_1(string),
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
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US21 {
            US21_0(Array<string>),
            US21_1(string),
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
            US22_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
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
            US23_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
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
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(std::string::String),
            US24_1(std::string::String),
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
            US25_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
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
            US26_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US26_1,
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
            US27_0(std::process::Output),
            US27_1(std::string::String),
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US28 {
            US28_0(i32),
            US28_1,
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
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(Func1<(bool, string, i32), Arc<Async<()>>>),
            US29_1,
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
        #[derive(Clone, Copy, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US30 {
            US30_0(CancellationToken),
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
        pub enum US31 {
            US31_0,
            US31_1(std::string::String),
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
        #[derive(Clone, Debug)]
        pub enum US32 {
            US32_0(chrono::DateTime<chrono::Utc>),
            US32_1,
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
        }
        impl core::fmt::Display for Spiral_builder::US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US33 {
            US33_0(i32, string),
            US33_1(i32, string),
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
            US34_0(std::collections::HashMap<string, string>),
            US34_1,
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
            US35_0(Spiral_builder::US3),
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
        pub enum US36 {
            US36_0,
            US36_1,
            US36_2,
        }
        impl Spiral_builder::US36 {
            pub fn get_IsUS36_0(this_: &MutCell<Spiral_builder::US36>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS36_1(this_: &MutCell<Spiral_builder::US36>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS36_2(this_: &MutCell<Spiral_builder::US36>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0(std::fs::FileType),
            US37_1(std::string::String),
        }
        impl Spiral_builder::US37 {
            pub fn get_IsUS37_0(this_: &MutCell<Spiral_builder::US37>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS37_1(this_: &MutCell<Spiral_builder::US37>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US38 {
            US38_0(async_walkdir::DirEntry),
            US38_1(std::string::String),
        }
        impl Spiral_builder::US38 {
            pub fn get_IsUS38_0(this_: &MutCell<Spiral_builder::US38>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS38_1(this_: &MutCell<Spiral_builder::US38>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US38 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, PartialEq, PartialOrd, Hash, Eq)]
        pub enum US39 {
            US39_0(string, string),
            US39_1,
        }
        impl Spiral_builder::US39 {
            pub fn get_IsUS39_0(this_: &MutCell<Spiral_builder::US39>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
            pub fn get_IsUS39_1(this_: &MutCell<Spiral_builder::US39>, unitArg: ()) -> bool {
                if unreachable!() {
                    true
                } else {
                    false
                }
            }
        }
        impl core::fmt::Display for Spiral_builder::US39 {
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
            let v66: Array<string> =
                toArray(ofArray(new_array(&[string("Pip"), string("Poetry")])));
            let v68: Vec<string> = v66.to_vec();
            let v70: bool = true;
            let _result: Vec<_> = v68
                .into_iter()
                .map(|x| {
                    //;
                    let v72: string = x;
                    let v74: &str = &*v72;
                    let v76: std::string::String = String::from(v74);
                    let v78: Box<std::string::String> = Box::new(v76);
                    let v80: &'static mut std::string::String = Box::leak(v78);
                    let v82: clap::builder::PossibleValue =
                        clap::builder::PossibleValue::new(&**v80);
                    let v84: bool = true;
                    v82
                })
                .collect::<Vec<_>>();
            let v86: Vec<clap::builder::PossibleValue> = _result;
            let v88: clap::builder::ValueParser = Into::<clap::builder::ValueParser>::into(
                clap::builder::PossibleValuesParser::new(v86),
            );
            let v90: clap::Arg = v59.value_parser(v88);
            let v92: clap::Command = clap::Command::arg(v48, v90);
            let v94: string = string("r#\"NAME\"#");
            let v97: string = string("r#\"VERSION\"#");
            let v99: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v100: usize = 1_i32 as usize;
            let v101: usize = 0_i32 as usize;
            let v107: clap::builder::ValueRange = if v101 == v101 {
                clap::builder::ValueRange::new(v100..)
            } else {
                clap::builder::ValueRange::new(v100..v101)
            };
            let v109: string = string("r#\"deps\"#");
            let v110: &'static str = r#"deps"#;
            let v112: clap::Arg = clap::Arg::new(v110);
            let v114: clap::Arg = v112.short('d');
            let v115: string = string("r#\"deps\"#");
            let v116: &'static str = r#"deps"#;
            let v118: clap::Arg = v114.long(v116);
            let v120: Vec<&'static str> = v99.to_vec();
            let v122: clap::Arg = v118.value_names(v120);
            let v124: clap::Arg = v122.num_args(v107);
            let v126: clap::ArgAction = clap::ArgAction::Append;
            let v128: clap::Arg = v124.action(v126);
            let v130: clap::Command = clap::Command::arg(v92, v128);
            let v132: clap::Command = clap::Command::subcommand(v28, v130);
            let v134: string = string("r#\"fable\"#");
            let v135: &'static str = r#"fable"#;
            let v137: clap::Command = clap::Command::new(v135);
            let v139: string = string("r#\"fs-path\"#");
            let v140: &'static str = r#"fs-path"#;
            let v142: clap::Arg = clap::Arg::new(v140);
            let v144: clap::Arg = v142.short('f');
            let v145: string = string("r#\"fs-path\"#");
            let v146: &'static str = r#"fs-path"#;
            let v148: clap::Arg = v144.long(v146);
            let v150: clap::Arg = v148.required(true);
            let v152: clap::Command = clap::Command::arg(v137, v150);
            let v153: string = string("r#\"command\"#");
            let v154: &'static str = r#"command"#;
            let v156: clap::Arg = clap::Arg::new(v154);
            let v158: clap::Arg = v156.short('c');
            let v159: string = string("r#\"command\"#");
            let v160: &'static str = r#"command"#;
            let v162: clap::Arg = v158.long(v160);
            let v164: clap::Command = clap::Command::arg(v152, v162);
            let v166: clap::Command = clap::Command::subcommand(v132, v164);
            let v168: string = string("r#\"rust\"#");
            let v169: &'static str = r#"rust"#;
            let v171: clap::Command = clap::Command::new(v169);
            let v172: string = string("r#\"fs-path\"#");
            let v173: &'static str = r#"fs-path"#;
            let v175: clap::Arg = clap::Arg::new(v173);
            let v177: clap::Arg = v175.short('f');
            let v178: string = string("r#\"fs-path\"#");
            let v179: &'static str = r#"fs-path"#;
            let v181: clap::Arg = v177.long(v179);
            let v183: clap::Arg = v181.required(true);
            let v185: clap::Command = clap::Command::arg(v171, v183);
            let v186: string = string("r#\"NAME\"#");
            let v188: string = string("r#\"VERSION\"#");
            let v190: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v191: usize = 1_i32 as usize;
            let v192: usize = 0_i32 as usize;
            let v198: clap::builder::ValueRange = if v192 == v192 {
                clap::builder::ValueRange::new(v191..)
            } else {
                clap::builder::ValueRange::new(v191..v192)
            };
            let v199: string = string("r#\"deps\"#");
            let v200: &'static str = r#"deps"#;
            let v202: clap::Arg = clap::Arg::new(v200);
            let v204: clap::Arg = v202.short('d');
            let v205: string = string("r#\"deps\"#");
            let v206: &'static str = r#"deps"#;
            let v208: clap::Arg = v204.long(v206);
            let v210: Vec<&'static str> = v190.to_vec();
            let v212: clap::Arg = v208.value_names(v210);
            let v214: clap::Arg = v212.num_args(v198);
            let v216: clap::ArgAction = clap::ArgAction::Append;
            let v218: clap::Arg = v214.action(v216);
            let v220: clap::Command = clap::Command::arg(v185, v218);
            let v222: clap::Command = clap::Command::subcommand(v166, v220);
            let v224: string = string("r#\"typescript\"#");
            let v225: &'static str = r#"typescript"#;
            let v227: clap::Command = clap::Command::new(v225);
            let v228: string = string("r#\"fs-path\"#");
            let v229: &'static str = r#"fs-path"#;
            let v231: clap::Arg = clap::Arg::new(v229);
            let v233: clap::Arg = v231.short('f');
            let v234: string = string("r#\"fs-path\"#");
            let v235: &'static str = r#"fs-path"#;
            let v237: clap::Arg = v233.long(v235);
            let v239: clap::Arg = v237.required(true);
            let v241: clap::Command = clap::Command::arg(v227, v239);
            let v242: string = string("r#\"NAME\"#");
            let v244: string = string("r#\"VERSION\"#");
            let v246: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v247: usize = 1_i32 as usize;
            let v248: usize = 0_i32 as usize;
            let v254: clap::builder::ValueRange = if v248 == v248 {
                clap::builder::ValueRange::new(v247..)
            } else {
                clap::builder::ValueRange::new(v247..v248)
            };
            let v255: string = string("r#\"deps\"#");
            let v256: &'static str = r#"deps"#;
            let v258: clap::Arg = clap::Arg::new(v256);
            let v260: clap::Arg = v258.short('d');
            let v261: string = string("r#\"deps\"#");
            let v262: &'static str = r#"deps"#;
            let v264: clap::Arg = v260.long(v262);
            let v266: Vec<&'static str> = v246.to_vec();
            let v268: clap::Arg = v264.value_names(v266);
            let v270: clap::Arg = v268.num_args(v254);
            let v272: clap::ArgAction = clap::ArgAction::Append;
            let v274: clap::Arg = v270.action(v272);
            let v276: clap::Command = clap::Command::arg(v241, v274);
            let v278: clap::Command = clap::Command::subcommand(v222, v276);
            let v280: string = string("r#\"python\"#");
            let v281: &'static str = r#"python"#;
            let v283: clap::Command = clap::Command::new(v281);
            let v284: string = string("r#\"fs-path\"#");
            let v285: &'static str = r#"fs-path"#;
            let v287: clap::Arg = clap::Arg::new(v285);
            let v289: clap::Arg = v287.short('f');
            let v290: string = string("r#\"fs-path\"#");
            let v291: &'static str = r#"fs-path"#;
            let v293: clap::Arg = v289.long(v291);
            let v295: clap::Arg = v293.required(true);
            let v297: clap::Command = clap::Command::arg(v283, v295);
            let v298: string = string("r#\"NAME\"#");
            let v300: string = string("r#\"VERSION\"#");
            let v302: Array<&'static str> = new_array(&[r#"NAME"#, r#"VERSION"#]);
            let v303: usize = 1_i32 as usize;
            let v304: usize = 0_i32 as usize;
            let v310: clap::builder::ValueRange = if v304 == v304 {
                clap::builder::ValueRange::new(v303..)
            } else {
                clap::builder::ValueRange::new(v303..v304)
            };
            let v311: string = string("r#\"deps\"#");
            let v312: &'static str = r#"deps"#;
            let v314: clap::Arg = clap::Arg::new(v312);
            let v316: clap::Arg = v314.short('d');
            let v317: string = string("r#\"deps\"#");
            let v318: &'static str = r#"deps"#;
            let v320: clap::Arg = v316.long(v318);
            let v322: Vec<&'static str> = v302.to_vec();
            let v324: clap::Arg = v320.value_names(v322);
            let v326: clap::Arg = v324.num_args(v310);
            let v328: clap::ArgAction = clap::ArgAction::Append;
            let v330: clap::Arg = v326.action(v328);
            let v332: clap::Command = clap::Command::arg(v297, v330);
            let v334: clap::Command = clap::Command::subcommand(v278, v332);
            let v336: string = string("r#\"dib\"#");
            let v337: &'static str = r#"dib"#;
            let v339: clap::Command = clap::Command::new(v337);
            let v341: string = string("r#\"path\"#");
            let v342: &'static str = r#"path"#;
            let v344: clap::Arg = clap::Arg::new(v342);
            let v346: clap::Arg = v344.short('p');
            let v347: string = string("r#\"path\"#");
            let v348: &'static str = r#"path"#;
            let v350: clap::Arg = v346.long(v348);
            let v352: clap::Arg = v350.required(true);
            let v354: clap::Command = clap::Command::arg(v339, v352);
            let v356: string = string("clap::value_parser!(u8).into()");
            let v357: clap::builder::ValueParser = clap::value_parser!(u8).into();
            let v359: string = string("r#\"retries\"#");
            let v360: &'static str = r#"retries"#;
            let v362: clap::Arg = clap::Arg::new(v360);
            let v364: clap::Arg = v362.short('r');
            let v365: string = string("r#\"retries\"#");
            let v366: &'static str = r#"retries"#;
            let v368: clap::Arg = v364.long(v366);
            let v370: clap::Arg = v368.value_parser(v357);
            let v372: clap::Command = clap::Command::arg(v354, v370);
            let v374: string = string("r#\"working-directory\"#");
            let v375: &'static str = r#"working-directory"#;
            let v377: clap::Arg = clap::Arg::new(v375);
            let v379: clap::Arg = v377.short('w');
            let v380: string = string("r#\"working-directory\"#");
            let v381: &'static str = r#"working-directory"#;
            let v383: clap::Arg = v379.long(v381);
            let v385: clap::Command = clap::Command::arg(v372, v383);
            clap::Command::subcommand(v334, v385)
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
            let v9: Spiral_builder::US2 = if string("Verbose") == v3.clone() {
                Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_0)
            } else {
                Spiral_builder::US2::US2_1
            };
            let v54: Spiral_builder::US2 = match &v9 {
                Spiral_builder::US2::US2_0(v9_0_0) => Spiral_builder::US2::US2_0(match &v9 {
                    Spiral_builder::US2::US2_0(x) => x.clone(),
                    _ => unreachable!(),
                }),
                _ => {
                    let v17: Spiral_builder::US2 = if string("Debug") == v3.clone() {
                        Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_1)
                    } else {
                        Spiral_builder::US2::US2_1
                    };
                    match &v17 {
                        Spiral_builder::US2::US2_0(v17_0_0) => {
                            Spiral_builder::US2::US2_0(match &v17 {
                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            })
                        }
                        _ => {
                            let v25: Spiral_builder::US2 = if string("Info") == v3.clone() {
                                Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_2)
                            } else {
                                Spiral_builder::US2::US2_1
                            };
                            match &v25 {
                                Spiral_builder::US2::US2_0(v25_0_0) => {
                                    Spiral_builder::US2::US2_0(match &v25 {
                                        Spiral_builder::US2::US2_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    })
                                }
                                _ => {
                                    let v33: Spiral_builder::US2 =
                                        if string("Warning") == v3.clone() {
                                            Spiral_builder::US2::US2_0(Spiral_builder::US0::US0_3)
                                        } else {
                                            Spiral_builder::US2::US2_1
                                        };
                                    match &v33 {
                                        Spiral_builder::US2::US2_0(v33_0_0) => {
                                            Spiral_builder::US2::US2_0(match &v33 {
                                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            })
                                        }
                                        _ => {
                                            let v41: Spiral_builder::US2 =
                                                if string("Critical") == v3.clone() {
                                                    Spiral_builder::US2::US2_0(
                                                        Spiral_builder::US0::US0_4,
                                                    )
                                                } else {
                                                    Spiral_builder::US2::US2_1
                                                };
                                            match &v41 {
                                                Spiral_builder::US2::US2_0(v41_0_0) => {
                                                    Spiral_builder::US2::US2_0(match &v41 {
                                                        Spiral_builder::US2::US2_0(x) => x.clone(),
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
                    v54,
                );
                _v1.set(Some(x))
            }
            {
                let patternInput: (Spiral_builder::US1, Spiral_builder::US2) =
                    match &_v1.get().clone() {
                        None => panic!("{}", string("base.run_target / _v1=None"),),
                        Some(_v1_0_0) => _v1_0_0.clone(),
                    };
                let v259: Spiral_builder::US2 = patternInput.1.clone();
                let v258: Spiral_builder::US1 = patternInput.0.clone();
                let v267: LrcPtr<Spiral_builder::Mut3> = LrcPtr::new(Spiral_builder::Mut3 {
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
                        l0: MutCell::new(match &v259 {
                            Spiral_builder::US2::US2_0(v259_0_0) => match &v259 {
                                Spiral_builder::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => v0_1,
                        }),
                    }),
                    match &v258 {
                        Spiral_builder::US1::US1_0(v258_0_0) => Some(match &v258 {
                            Spiral_builder::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                        _ => None::<i64>,
                    },
                    v267,
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
                        let v154: Spiral_builder::US3 = if if let Spiral_builder::US0::US0_0 = &v0_1
                        {
                            true
                        } else {
                            false
                        } {
                            Spiral_builder::US3::US3_0(string("Verbose"))
                        } else {
                            Spiral_builder::US3::US3_1
                        };
                        let v203: Spiral_builder::US3 = match &v154 {
                            Spiral_builder::US3::US3_0(v154_0_0) => {
                                Spiral_builder::US3::US3_0(match &v154 {
                                    Spiral_builder::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })
                            }
                            _ => {
                                let v163: Spiral_builder::US3 =
                                    if if let Spiral_builder::US0::US0_1 = &v0_1 {
                                        true
                                    } else {
                                        false
                                    } {
                                        Spiral_builder::US3::US3_0(string("Debug"))
                                    } else {
                                        Spiral_builder::US3::US3_1
                                    };
                                match &v163 {
                                    Spiral_builder::US3::US3_0(v163_0_0) => {
                                        Spiral_builder::US3::US3_0(match &v163 {
                                            Spiral_builder::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        })
                                    }
                                    _ => {
                                        let v172: Spiral_builder::US3 =
                                            if if let Spiral_builder::US0::US0_2 = &v0_1 {
                                                true
                                            } else {
                                                false
                                            } {
                                                Spiral_builder::US3::US3_0(string("Info"))
                                            } else {
                                                Spiral_builder::US3::US3_1
                                            };
                                        match &v172 {
                                            Spiral_builder::US3::US3_0(v172_0_0) => {
                                                Spiral_builder::US3::US3_0(match &v172 {
                                                    Spiral_builder::US3::US3_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })
                                            }
                                            _ => {
                                                let v181: Spiral_builder::US3 =
                                                    if if let Spiral_builder::US0::US0_3 = &v0_1 {
                                                        true
                                                    } else {
                                                        false
                                                    } {
                                                        Spiral_builder::US3::US3_0(string(
                                                            "Warning",
                                                        ))
                                                    } else {
                                                        Spiral_builder::US3::US3_1
                                                    };
                                                match &v181 {
                                                    Spiral_builder::US3::US3_0(v181_0_0) => {
                                                        Spiral_builder::US3::US3_0(match &v181 {
                                                            Spiral_builder::US3::US3_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v190: Spiral_builder::US3 =
                                                            if if let Spiral_builder::US0::US0_4 =
                                                                &v0_1
                                                            {
                                                                true
                                                            } else {
                                                                false
                                                            } {
                                                                Spiral_builder::US3::US3_0(string(
                                                                    "Critical",
                                                                ))
                                                            } else {
                                                                Spiral_builder::US3::US3_1
                                                            };
                                                        match &v190 {
                                                            Spiral_builder::US3::US3_0(
                                                                v190_0_0,
                                                            ) => Spiral_builder::US3::US3_0(
                                                                match &v190 {
                                                                    Spiral_builder::US3::US3_0(
                                                                        x,
                                                                    ) => x.clone(),
                                                                    _ => unreachable!(),
                                                                },
                                                            ),
                                                            _ => Spiral_builder::US3::US3_1,
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        };
                        let v210: string = padLeft(
                            toLower(match &v203 {
                                Spiral_builder::US3::US3_0(v203_0_0) => match &v203 {
                                    Spiral_builder::US3::US3_0(x) => x.clone(),
                                    _ => unreachable!(),
                                },
                                _ => panic!("{}", string("Option does not have a value."),),
                            }),
                            7_i32,
                            ' ',
                        );
                        let _v211: MutCell<Option<string>> = MutCell::new(None::<string>);
                        let v226: &str = match &v0_1 {
                            Spiral_builder::US0::US0_1 => inline_colorization::color_bright_blue,
                            Spiral_builder::US0::US0_2 => inline_colorization::color_bright_green,
                            Spiral_builder::US0::US0_0 => inline_colorization::color_bright_black,
                            Spiral_builder::US0::US0_3 => inline_colorization::color_yellow,
                            _ => inline_colorization::color_bright_red,
                        };
                        let v228: &str = &*v210;
                        let v230: &str = inline_colorization::color_reset;
                        let v232: string = string("format!(\"{v226}{v228}{v230}\")");
                        let v233: std::string::String = format!("{v226}{v228}{v230}");
                        {
                            let x_5: string = fable_library_rust::String_::fromString(v233);
                            _v211.set(Some(x_5))
                        }
                        trimEndChars(
                            trimStartChars(
                                sprintf!(
                                    "{} {} #{} {} / {}",
                                    v147,
                                    match &_v211.get().clone() {
                                        None =>
                                            panic!("{}", string("base.run_target / _v211=None"),),
                                        Some(_v211_0_0) => _v211_0_0.clone(),
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
            string("py-path")
        }
        pub fn method12() -> string {
            string("env")
        }
        pub fn method13() -> string {
            string("deps")
        }
        pub fn method16(v0_1: string) -> string {
            v0_1
        }
        pub fn method15(v0_1: string, v1_1: string) -> (string, string) {
            (v1_1, Spiral_builder::method16(v0_1))
        }
        pub fn method14(v0_1: string, v1_1: string) -> string {
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
        pub fn method18(v0_1: string) -> bool {
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
        pub fn method20(v0_1: string) -> Option<string> {
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
        pub fn closure9(unitVar: (), v0_1: string) -> Option<string> {
            Spiral_builder::method20(v0_1)
        }
        pub fn method19() -> Func1<string, Option<string>> {
            Func1::new(move |v: string| Spiral_builder::closure9((), v))
        }
        pub fn method21(v0_1: string, v1_1: string, v2: string) -> string {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            '_method21: loop {
                break '_method21 (if Spiral_builder::method18(Spiral_builder::method14(
                    v2.get().clone(),
                    v0_1.get().clone(),
                )) {
                    v2.get().clone()
                } else {
                    let v6: Option<string> = (Spiral_builder::method19())(v2.get().clone());
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
                                continue '_method21;
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
        pub fn method17(v0_1: string, v1_1: string) -> string {
            if Spiral_builder::method18(Spiral_builder::method14(v1_1.clone(), v0_1.clone())) {
                v1_1.clone()
            } else {
                let v5: Option<string> = (Spiral_builder::method19())(v1_1.clone());
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
                        Spiral_builder::US3::US3_0(v11_0_0) => Spiral_builder::method21(
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
        pub fn method22() -> string {
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
        pub fn method23(v0_1: string) -> string {
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
        pub fn method26(v0_1: string) -> bool {
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
        pub fn method25(v0_1: string, v1_1: string) -> bool {
            let _v2: MutCell<Option<bool>> = MutCell::new(None::<bool>);
            {
                let x_4: bool = if Spiral_builder::method26(v0_1.clone()) == false {
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
        pub fn method27(v0_1: string) -> string {
            v0_1
        }
        pub fn method24(v0_1: string, v1_1: string) {
            if Spiral_builder::method25(v0_1.clone(), v1_1.clone()) == false {
                let _v4: MutCell<Option<()>> = MutCell::new(None::<()>);
                std::fs::write(&*v0_1, &*v1_1).unwrap();
                _v4.set(Some(()));
                match &_v4.get().clone() {
                    None => panic!("{}", string("base.run_target / _v4=None"),),
                    Some(_v4_0_0) => _v4_0_0.clone(),
                }
                ()
            };
        }
        pub fn method29(
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
        pub fn method31() -> (string, string) {
            (string(""), string(""))
        }
        pub fn method32(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut4>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn closure11(
            v0_1: char,
            v1_1: LrcPtr<Spiral_builder::UH0>,
        ) -> LrcPtr<Spiral_builder::UH0> {
            LrcPtr::new(Spiral_builder::UH0::UH0_1(v0_1, v1_1))
        }
        pub fn closure10(
            unitVar: (),
            v0_1: char,
        ) -> Func1<LrcPtr<Spiral_builder::UH0>, LrcPtr<Spiral_builder::UH0>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Spiral_builder::UH0>| Spiral_builder::closure11(v0_1, v)
            })
        }
        pub fn method33(
        ) -> Func1<char, Func1<LrcPtr<Spiral_builder::UH0>, LrcPtr<Spiral_builder::UH0>>> {
            Func1::new(move |v: char| Spiral_builder::closure10((), v))
        }
        pub fn method34(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<Spiral_builder::UH0>,
            v3: Spiral_builder::US13,
        ) -> (string, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US13> = MutCell::new(v3.clone());
            '_method34: loop {
                break '_method34 (if let Spiral_builder::UH0::UH0_1(v2_1_0, v2_1_1) =
                    v2.get().clone().as_ref()
                {
                    let v5: LrcPtr<Spiral_builder::UH0> = match v2.get().clone().as_ref() {
                        Spiral_builder::UH0::UH0_1(_, x) => x.clone(),
                        _ => unreachable!(),
                    };
                    let v4: char = match v2.get().clone().as_ref() {
                        Spiral_builder::UH0::UH0_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    };
                    if '\"' == v4 {
                        if v1_1.get().clone() == string("") {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                            let v3_temp: Spiral_builder::US13 =
                                Spiral_builder::US13::US13_1(Spiral_builder::US14::US14_0);
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method34;
                        } else {
                            match &v3.get().clone() {
                                Spiral_builder::US13::US13_1(v3_1_0) => {
                                    if let Spiral_builder::US14::US14_0 = v3_1_0 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                        let v3_temp: Spiral_builder::US13 =
                                            Spiral_builder::US13::US13_1(
                                                Spiral_builder::US14::US14_1,
                                            );
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 =
                                                Spiral_builder::US13::US13_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        }
                                    }
                                }
                                Spiral_builder::US13::US13_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                        let v3_temp: Spiral_builder::US13 =
                                            Spiral_builder::US13::US13_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                        let v3_temp: Spiral_builder::US13 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                    let v3_temp: Spiral_builder::US13 =
                                        Spiral_builder::US13::US13_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method34;
                                }
                            }
                        }
                    } else {
                        if '\'' == v4 {
                            if v1_1.get().clone() == string("") {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                let v3_temp: Spiral_builder::US13 =
                                    Spiral_builder::US13::US13_1(Spiral_builder::US14::US14_0);
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                continue '_method34;
                            } else {
                                match &v3.get().clone() {
                                    Spiral_builder::US13::US13_1(v3_1_0) => {
                                        if let Spiral_builder::US14::US14_0 = v3_1_0 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 =
                                                Spiral_builder::US13::US13_1(
                                                    Spiral_builder::US14::US14_1,
                                                );
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            if ' ' == v4 {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string = v1_1.get().clone();
                                                let v2_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v5.clone();
                                                let v3_temp: Spiral_builder::US13 =
                                                    Spiral_builder::US13::US13_2;
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method34;
                                            } else {
                                                let v0_1_temp: string = v0_1.get().clone();
                                                let v1_1_temp: string =
                                                    sprintf!("{}{}", v1_1.get().clone(), v4);
                                                let v2_temp: LrcPtr<Spiral_builder::UH0> =
                                                    v5.clone();
                                                let v3_temp: Spiral_builder::US13 =
                                                    v3.get().clone();
                                                v0_1.set(v0_1_temp);
                                                v1_1.set(v1_1_temp);
                                                v2.set(v2_temp);
                                                v3.set(v3_temp);
                                                continue '_method34;
                                            }
                                        }
                                    }
                                    Spiral_builder::US13::US13_0 => {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 =
                                                Spiral_builder::US13::US13_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        }
                                    }
                                    _ => {
                                        let v0_1_temp: string =
                                            sprintf!("{}{}", v0_1.get().clone(), v4);
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                        let v3_temp: Spiral_builder::US13 =
                                            Spiral_builder::US13::US13_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    }
                                }
                            }
                        } else {
                            match &v3.get().clone() {
                                Spiral_builder::US13::US13_1(v3_1_0) => {
                                    if let Spiral_builder::US14::US14_0 = v3_1_0 {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{} ", v1_1.get().clone());
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 =
                                                Spiral_builder::US13::US13_1(
                                                    Spiral_builder::US14::US14_0,
                                                );
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        }
                                    } else {
                                        if ' ' == v4 {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string = v1_1.get().clone();
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 =
                                                Spiral_builder::US13::US13_2;
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        } else {
                                            let v0_1_temp: string = v0_1.get().clone();
                                            let v1_1_temp: string =
                                                sprintf!("{}{}", v1_1.get().clone(), v4);
                                            let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                            let v3_temp: Spiral_builder::US13 = v3.get().clone();
                                            v0_1.set(v0_1_temp);
                                            v1_1.set(v1_1_temp);
                                            v2.set(v2_temp);
                                            v3.set(v3_temp);
                                            continue '_method34;
                                        }
                                    }
                                }
                                Spiral_builder::US13::US13_0 => {
                                    if ' ' == v4 {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string = v1_1.get().clone();
                                        let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                        let v3_temp: Spiral_builder::US13 =
                                            Spiral_builder::US13::US13_2;
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    } else {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: string =
                                            sprintf!("{}{}", v1_1.get().clone(), v4);
                                        let v2_temp: LrcPtr<Spiral_builder::UH0> = v5;
                                        let v3_temp: Spiral_builder::US13 = v3.get().clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        continue '_method34;
                                    }
                                }
                                _ => {
                                    let v0_1_temp: string =
                                        sprintf!("{}{}", v0_1.get().clone(), v4);
                                    let v1_1_temp: string = v1_1.get().clone();
                                    let v2_temp: LrcPtr<Spiral_builder::UH0> = v5.clone();
                                    let v3_temp: Spiral_builder::US13 =
                                        Spiral_builder::US13::US13_2;
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    continue '_method34;
                                }
                            }
                        }
                    }
                } else {
                    match &v3.get().clone() {
                        Spiral_builder::US13::US13_1(v3_1_0) => {
                            if let Spiral_builder::US14::US14_0 = v3_1_0 {
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
                        Spiral_builder::US13::US13_0 => (
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
        pub fn method30(v0_1: string) -> (string, string) {
            let patternInput: (string, string) = Spiral_builder::method31();
            let v3: i32 = length(v0_1.clone());
            let v4: Array<char> = new_init(&'\u{0000}', v3);
            let v5: LrcPtr<Spiral_builder::Mut4> = LrcPtr::new(Spiral_builder::Mut4 {
                l0: MutCell::new(0_i32),
            });
            while Spiral_builder::method32(v3, v5.clone()) {
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
                Spiral_builder::method34(
                    patternInput.1.clone(),
                    patternInput.0.clone(),
                    foldBack(
                        Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                            (Spiral_builder::method33())(b0)(b1)
                        }),
                        v11,
                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                    ),
                    Spiral_builder::US13::US13_0,
                )
            }
        }
        pub fn method37(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method37: loop {
                break '_method37 (if v1_1.get().clone() >= 4_i64 {
                    false
                } else {
                    let v19: Spiral_builder::US18 = if v1_1.get().clone() == 0_i64 {
                        Spiral_builder::US18::US18_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Spiral_builder::US18::US18_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Spiral_builder::US18::US18_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                if v11 == 0_i64 {
                                    Spiral_builder::US18::US18_0(' ')
                                } else {
                                    let v14: i64 = v11 - 1_i64;
                                    Spiral_builder::US18::US18_1
                                }
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v19 {
                            Spiral_builder::US18::US18_0(v19_0_0) => match &v19 {
                                Spiral_builder::US18::US18_0(x) => x.clone(),
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
                        continue '_method37;
                    }
                });
            }
        }
        pub fn method38(
            v0_1: LrcPtr<Spiral_builder::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method38: loop {
                break '_method38 (match v0_1.get().clone().as_ref() {
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
                            (1_i32, v3.get().clone() + 1_i32)
                        } else {
                            (v2.get().clone() + 1_i32, v3.get().clone())
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
                            continue '_method38;
                        }
                    }
                });
            }
        }
        pub fn method39(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US19 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method39: loop {
                break '_method39 ({
                    let v57: Spiral_builder::US17 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US17::US17_1(sprintf!(
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
                        if Spiral_builder::method37(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Spiral_builder::Mut4> =
                                LrcPtr::new(Spiral_builder::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method32(v28, v30.clone()) {
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
                                    Spiral_builder::method38(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method33())(b0)(b1)
                                                },
                                            ),
                                            v36,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US17::US17_0(
                                    v15,
                                    v22,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US17::US17_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v15,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v57 {
                        Spiral_builder::US17::US17_0(
                            v57_0_0,
                            v57_0_1,
                            v57_0_2,
                            v57_0_3,
                            v57_0_4,
                        ) => {
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
                            continue '_method39;
                        }
                        _ => Spiral_builder::US19::US19_0(
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
        pub fn method41(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method41: loop {
                break '_method41 (if v1_1.get().clone() >= 3_i64 {
                    false
                } else {
                    let v15: Spiral_builder::US18 = if v1_1.get().clone() == 0_i64 {
                        Spiral_builder::US18::US18_0('\\')
                    } else {
                        let v5: i64 = v1_1.get().clone() - 1_i64;
                        if v5 == 0_i64 {
                            Spiral_builder::US18::US18_0('`')
                        } else {
                            let v8: i64 = v5 - 1_i64;
                            if v8 == 0_i64 {
                                Spiral_builder::US18::US18_0('\"')
                            } else {
                                let v11: i64 = v8 - 1_i64;
                                Spiral_builder::US18::US18_1
                            }
                        }
                    };
                    if v0_1.get().clone()
                        == match &v15 {
                            Spiral_builder::US18::US18_0(v15_0_0) => match &v15 {
                                Spiral_builder::US18::US18_0(x) => x.clone(),
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
                        continue '_method41;
                    }
                });
            }
        }
        pub fn closure12(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US19 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v60: Spiral_builder::US17 = if string("") == v0_1.clone() {
                Spiral_builder::US17::US17_1(sprintf!(
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
                    while Spiral_builder::method32(v18, v20.clone()) {
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
                            Spiral_builder::method38(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method33())(b0)(b1)
                                    }),
                                    v26,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US17::US17_0(
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
                    Spiral_builder::US17::US17_1(sprintf!(
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
            let v102: Spiral_builder::US17 = match &v60 {
                Spiral_builder::US17::US17_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                    let v65: i32 = v60_0_4.clone();
                    let v64: i32 = v60_0_3.clone();
                    let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                    let v62: string = v60_0_1.clone();
                    if string("") == v62.clone() {
                        Spiral_builder::US17::US17_1(sprintf!(
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
                        while Spiral_builder::method32(v79, v81.clone()) {
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
                                Spiral_builder::method38(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method33())(b0)(b1)
                                            },
                                        ),
                                        v87,
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                    ),
                                    v63,
                                    v64,
                                    v65,
                                );
                            Spiral_builder::US17::US17_0(
                                v69,
                                v76,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Spiral_builder::US17::US17_1(v60_1_0) => {
                    Spiral_builder::US17::US17_1(v60_1_0.clone())
                }
            };
            match &v102 {
                Spiral_builder::US17::US17_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                    Spiral_builder::US19::US19_0(
                        sprintf!("{}{}", '\\', v102_0_0.clone()),
                        v102_0_1.clone(),
                        v102_0_2.clone(),
                        v102_0_3.clone(),
                        v102_0_4.clone(),
                    )
                }
                Spiral_builder::US17::US17_1(v102_1_0) => {
                    Spiral_builder::US19::US19_1(v102_1_0.clone())
                }
            }
        }
        pub fn closure13(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Spiral_builder::US19 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v60: Spiral_builder::US17 = if string("") == v0_1.clone() {
                Spiral_builder::US17::US17_1(sprintf!(
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
                    while Spiral_builder::method32(v18, v20.clone()) {
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
                            Spiral_builder::method38(
                                foldBack(
                                    Func2::new(move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                        (Spiral_builder::method33())(b0)(b1)
                                    }),
                                    v26,
                                    LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                ),
                                v1_1.clone(),
                                v2,
                                v3,
                            );
                        Spiral_builder::US17::US17_0(
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
                    Spiral_builder::US17::US17_1(sprintf!(
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
            let v102: Spiral_builder::US17 = match &v60 {
                Spiral_builder::US17::US17_0(v60_0_0, v60_0_1, v60_0_2, v60_0_3, v60_0_4) => {
                    let v65: i32 = v60_0_4.clone();
                    let v64: i32 = v60_0_3.clone();
                    let v63: LrcPtr<StringBuilder> = v60_0_2.clone();
                    let v62: string = v60_0_1.clone();
                    if string("") == v62.clone() {
                        Spiral_builder::US17::US17_1(sprintf!(
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
                        while Spiral_builder::method32(v79, v81.clone()) {
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
                                Spiral_builder::method38(
                                    foldBack(
                                        Func2::new(
                                            move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                (Spiral_builder::method33())(b0)(b1)
                                            },
                                        ),
                                        v87,
                                        LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                    ),
                                    v63,
                                    v64,
                                    v65,
                                );
                            Spiral_builder::US17::US17_0(
                                v69,
                                v76,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                            )
                        }
                    }
                }
                Spiral_builder::US17::US17_1(v60_1_0) => {
                    Spiral_builder::US17::US17_1(v60_1_0.clone())
                }
            };
            match &v102 {
                Spiral_builder::US17::US17_0(v102_0_0, v102_0_1, v102_0_2, v102_0_3, v102_0_4) => {
                    Spiral_builder::US19::US19_0(
                        sprintf!("{}{}", '`', v102_0_0.clone()),
                        v102_0_1.clone(),
                        v102_0_2.clone(),
                        v102_0_3.clone(),
                        v102_0_4.clone(),
                    )
                }
                Spiral_builder::US17::US17_1(v102_1_0) => {
                    Spiral_builder::US19::US19_1(v102_1_0.clone())
                }
            }
        }
        pub fn method42(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Spiral_builder::UH2>,
        ) -> Spiral_builder::US19 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Spiral_builder::UH2>> = MutCell::new(v4.clone());
            '_method42: loop {
                break '_method42 (match v4.get().clone().as_ref() {
                    Spiral_builder::UH2::UH2_0 => {
                        Spiral_builder::US19::US19_1(string("choice / no parsers succeeded"))
                    }
                    Spiral_builder::UH2::UH2_1(v4_1_0, v4_1_1) => {
                        let v9: Spiral_builder::US19 = (match v4.get().clone().as_ref() {
                            Spiral_builder::UH2::UH2_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Spiral_builder::US19::US19_0(
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
                                continue '_method42;
                            }
                        }
                    }
                });
            }
        }
        pub fn method43(
            v0_1: LrcPtr<Spiral_builder::UH1>,
            v1_1: LrcPtr<Spiral_builder::UH1>,
        ) -> LrcPtr<Spiral_builder::UH1> {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v1_1.clone());
            '_method43: loop {
                break '_method43 (match v0_1.get().clone().as_ref() {
                    Spiral_builder::UH1::UH1_0 => v1_1.get().clone(),
                    Spiral_builder::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Spiral_builder::UH1> =
                            match v0_1.get().clone().as_ref() {
                                Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                                _ => unreachable!(),
                            };
                        let v1_1_temp: LrcPtr<Spiral_builder::UH1> =
                            LrcPtr::new(Spiral_builder::UH1::UH1_1(
                                match v0_1.get().clone().as_ref() {
                                    Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                                    _ => unreachable!(),
                                },
                                v1_1.get().clone(),
                            ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method43;
                    }
                });
            }
        }
        pub fn method40(
            v0_1: LrcPtr<Spiral_builder::UH1>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US16 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method40: loop {
                break '_method40 ({
                    let v55: Spiral_builder::US17 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US17::US17_1(sprintf!(
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
                        if Spiral_builder::method41(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Spiral_builder::Mut4> =
                                LrcPtr::new(Spiral_builder::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method32(v27, v29.clone()) {
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
                                    Spiral_builder::method38(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method33())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US17::US17_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US17::US17_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Spiral_builder::US19 = match &v55 {
                        Spiral_builder::US17::US17_0(
                            v55_0_0,
                            v55_0_1,
                            v55_0_2,
                            v55_0_3,
                            v55_0_4,
                        ) => Spiral_builder::US19::US19_0(
                            ofChar(v55_0_0.clone()),
                            v55_0_1.clone(),
                            v55_0_2.clone(),
                            v55_0_3.clone(),
                            v55_0_4.clone(),
                        ),
                        Spiral_builder::US17::US17_1(v55_1_0) => {
                            Spiral_builder::US19::US19_1(v55_1_0.clone())
                        }
                    };
                    let v81: Spiral_builder::US19 = match &v67 {
                        Spiral_builder::US19::US19_0(
                            v67_0_0,
                            v67_0_1,
                            v67_0_2,
                            v67_0_3,
                            v67_0_4,
                        ) => v67.clone(),
                        _ => Spiral_builder::method42(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Spiral_builder::UH2::UH2_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Spiral_builder::closure12((), arg10_0040)
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
                                            Spiral_builder::closure13((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Spiral_builder::UH2::UH2_0),
                                )),
                            )),
                        ),
                    };
                    match &v81 {
                        Spiral_builder::US19::US19_0(
                            v81_0_0,
                            v81_0_1,
                            v81_0_2,
                            v81_0_3,
                            v81_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH1> = LrcPtr::new(
                                Spiral_builder::UH1::UH1_1(v81_0_0.clone(), v0_1.get().clone()),
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
                            continue '_method40;
                        }
                        _ => Spiral_builder::US16::US16_0(
                            Spiral_builder::method43(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH1::UH1_0),
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
        pub fn method44(v0_1: LrcPtr<Spiral_builder::UH1>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Spiral_builder::UH1::UH1_0 => v1_1.clone(),
                Spiral_builder::UH1::UH1_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Spiral_builder::UH1::UH1_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    Spiral_builder::method44(
                        match v0_1.as_ref() {
                            Spiral_builder::UH1::UH1_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        },
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method45(
            v0_1: LrcPtr<Spiral_builder::UH1>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US16 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method45: loop {
                break '_method45 ({
                    let v55: Spiral_builder::US17 = if string("") == v1_1.get().clone() {
                        Spiral_builder::US17::US17_1(sprintf!(
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
                        if Spiral_builder::method41(v14, 0_i64) == false {
                            let v26: string = ofChar(v14);
                            let v27: i32 = length(v26.clone());
                            let v28: Array<char> = new_init(&'\u{0000}', v27);
                            let v29: LrcPtr<Spiral_builder::Mut4> =
                                LrcPtr::new(Spiral_builder::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method32(v27, v29.clone()) {
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
                                    Spiral_builder::method38(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method33())(b0)(b1)
                                                },
                                            ),
                                            v35,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US17::US17_0(
                                    v14,
                                    v21,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US17::US17_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v14,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v67: Spiral_builder::US19 = match &v55 {
                        Spiral_builder::US17::US17_0(
                            v55_0_0,
                            v55_0_1,
                            v55_0_2,
                            v55_0_3,
                            v55_0_4,
                        ) => Spiral_builder::US19::US19_0(
                            ofChar(v55_0_0.clone()),
                            v55_0_1.clone(),
                            v55_0_2.clone(),
                            v55_0_3.clone(),
                            v55_0_4.clone(),
                        ),
                        Spiral_builder::US17::US17_1(v55_1_0) => {
                            Spiral_builder::US19::US19_1(v55_1_0.clone())
                        }
                    };
                    match &v67 {
                        Spiral_builder::US19::US19_0(
                            v67_0_0,
                            v67_0_1,
                            v67_0_2,
                            v67_0_3,
                            v67_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Spiral_builder::UH1> = LrcPtr::new(
                                Spiral_builder::UH1::UH1_1(v67_0_0.clone(), v0_1.get().clone()),
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
                            continue '_method45;
                        }
                        _ => Spiral_builder::US16::US16_0(
                            Spiral_builder::method43(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH1::UH1_0),
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
        pub fn method46(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method46: loop {
                break '_method46 (if v1_1.get().clone() >= length(v0_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if getCharAt(v0_1.get().clone(), v1_1.get().clone()) == ' ' {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone() + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method46;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method36(
            v0_1: LrcPtr<Spiral_builder::UH1>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Spiral_builder::US16 {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH1>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method36: loop {
                break '_method36 ({
                    let v5: bool = string("") == v1_1.get().clone();
                    let v57: Spiral_builder::US17 = if v5 {
                        Spiral_builder::US17::US17_1(sprintf!(
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
                        if Spiral_builder::method37(v15, 0_i64) == false {
                            let v27: string = ofChar(v15);
                            let v28: i32 = length(v27.clone());
                            let v29: Array<char> = new_init(&'\u{0000}', v28);
                            let v30: LrcPtr<Spiral_builder::Mut4> =
                                LrcPtr::new(Spiral_builder::Mut4 {
                                    l0: MutCell::new(0_i32),
                                });
                            while Spiral_builder::method32(v28, v30.clone()) {
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
                                    Spiral_builder::method38(
                                        foldBack(
                                            Func2::new(
                                                move |b0: char, b1: LrcPtr<Spiral_builder::UH0>| {
                                                    (Spiral_builder::method33())(b0)(b1)
                                                },
                                            ),
                                            v36,
                                            LrcPtr::new(Spiral_builder::UH0::UH0_0),
                                        ),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                    );
                                Spiral_builder::US17::US17_0(
                                    v15,
                                    v22,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            }
                        } else {
                            Spiral_builder::US17::US17_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v15,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v69: Spiral_builder::US19 = match &v57 {
                        Spiral_builder::US17::US17_0(
                            v57_0_0,
                            v57_0_1,
                            v57_0_2,
                            v57_0_3,
                            v57_0_4,
                        ) => Spiral_builder::method39(
                            ofChar(v57_0_0.clone()),
                            v57_0_1.clone(),
                            v57_0_2.clone(),
                            v57_0_3.clone(),
                            v57_0_4.clone(),
                        ),
                        Spiral_builder::US17::US17_1(v57_1_0) => {
                            Spiral_builder::US19::US19_1(v57_1_0.clone())
                        }
                    };
                    let v292: Spiral_builder::US19 = match &v69 {
                        Spiral_builder::US19::US19_0(
                            v69_0_0,
                            v69_0_1,
                            v69_0_2,
                            v69_0_3,
                            v69_0_4,
                        ) => v69.clone(),
                        _ => {
                            let v131: Spiral_builder::US17 = if v5 {
                                Spiral_builder::US17::US17_1(sprintf!(
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
                                    while Spiral_builder::method32(v89, v91.clone()) {
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
                                                             Spiral_builder::method38(foldBack(Func2::new(move
                                                                                                              |b0:
                                                                                                                   char,
                                                                                                               b1:
                                                                                                                   LrcPtr<Spiral_builder::UH0>|
                                                                                                              (Spiral_builder::method33())(b0)(b1)),
                                                                                               v97,
                                                                                               LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                      v2.get().clone(),
                                                                                      v3.get().clone(),
                                                                                      v4.get().clone());
                                        Spiral_builder::US17::US17_0(
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
                                    Spiral_builder::US17::US17_1(sprintf!("{}\n{}\n",
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
                            let v237: Spiral_builder::US19 = match &v131 {
                                Spiral_builder::US17::US17_0(
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
                                    let v138: Spiral_builder::US16 = Spiral_builder::method40(
                                        LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                        v133.clone(),
                                        v134.clone(),
                                        v135,
                                        v136,
                                    );
                                    let v155: Spiral_builder::US19 = match &v138 {
                                        Spiral_builder::US16::US16_0(
                                            v138_0_0,
                                            v138_0_1,
                                            v138_0_2,
                                            v138_0_3,
                                            v138_0_4,
                                        ) => {
                                            let v145: List<string> = Spiral_builder::method44(
                                                v138_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US19::US19_0(
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
                                        Spiral_builder::US16::US16_1(v138_1_0) => {
                                            Spiral_builder::US19::US19_1(v138_1_0.clone())
                                        }
                                    };
                                    match &v155 {
                                        Spiral_builder::US19::US19_0(
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
                                            let v217: Spiral_builder::US17 = if string("")
                                                == v157.clone()
                                            {
                                                Spiral_builder::US17::US17_1(sprintf!("parsing.p_char / unexpected end of input / s: {:?}",
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
                                                    while Spiral_builder::method32(
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
                                                                                 Spiral_builder::method38(foldBack(Func2::new(move
                                                                                                                                  |b0:
                                                                                                                                       char,
                                                                                                                                   b1:
                                                                                                                                       LrcPtr<Spiral_builder::UH0>|
                                                                                                                                  (Spiral_builder::method33())(b0)(b1)),
                                                                                                                   v183,
                                                                                                                   LrcPtr::new(Spiral_builder::UH0::UH0_0)),
                                                                                                          v158.clone(),
                                                                                                          v159,
                                                                                                          v160);
                                                        Spiral_builder::US17::US17_0(
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
                                                    Spiral_builder::US17::US17_1(sprintf!("{}\n{}\n",
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
                                                                 Spiral_builder::US17::US17_0(v217_0_0,
                                                                                              v217_0_1,
                                                                                              v217_0_2,
                                                                                              v217_0_3,
                                                                                              v217_0_4)
                                                                 =>
                                                                 Spiral_builder::US19::US19_0(v155_0_0.clone(),
                                                                                              v217_0_1.clone(),
                                                                                              v217_0_2.clone(),
                                                                                              v217_0_3.clone(),
                                                                                              v217_0_4.clone()),
                                                                 Spiral_builder::US17::US17_1(v217_1_0)
                                                                 =>
                                                                 Spiral_builder::US19::US19_1(sprintf!("between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
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
                                        _ => Spiral_builder::US19::US19_1(string(
                                            "between / expected content",
                                        )),
                                    }
                                }
                                Spiral_builder::US17::US17_1(v131_1_0) => {
                                    Spiral_builder::US19::US19_1(v131_1_0.clone())
                                }
                            };
                            match &v237 {
                                Spiral_builder::US19::US19_0(
                                    v237_0_0,
                                    v237_0_1,
                                    v237_0_2,
                                    v237_0_3,
                                    v237_0_4,
                                ) => v237.clone(),
                                _ => {
                                    let v249:
                                                         Spiral_builder::US19 =
                                                     Spiral_builder::method42(v1_1.get().clone(),
                                                                              v2.get().clone(),
                                                                              v3.get().clone(),
                                                                              v4.get().clone(),
                                                                              LrcPtr::new(Spiral_builder::UH2::UH2_1(Func1::new(move
                                                                                                                                    |arg10_0040:
                                                                                                                                         (string,
                                                                                                                                          LrcPtr<StringBuilder>,
                                                                                                                                          i32,
                                                                                                                                          i32)|
                                                                                                                                    Spiral_builder::closure12((),
                                                                                                                                                              arg10_0040)),
                                                                                                                     LrcPtr::new(Spiral_builder::UH2::UH2_1(Func1::new(move
                                                                                                                                                                           |arg10_0040_1:
                                                                                                                                                                                (string,
                                                                                                                                                                                 LrcPtr<StringBuilder>,
                                                                                                                                                                                 i32,
                                                                                                                                                                                 i32)|
                                                                                                                                                                           Spiral_builder::closure13((),
                                                                                                                                                                                                     arg10_0040_1)),
                                                                                                                                                            LrcPtr::new(Spiral_builder::UH2::UH2_0))))));
                                    let v260: Spiral_builder::US19 = match &v249 {
                                        Spiral_builder::US19::US19_0(
                                            v249_0_0,
                                            v249_0_1,
                                            v249_0_2,
                                            v249_0_3,
                                            v249_0_4,
                                        ) => Spiral_builder::US19::US19_0(
                                            string(""),
                                            v249_0_1.clone(),
                                            v249_0_2.clone(),
                                            v249_0_3.clone(),
                                            v249_0_4.clone(),
                                        ),
                                        Spiral_builder::US19::US19_1(v249_1_0) => {
                                            Spiral_builder::US19::US19_1(v249_1_0.clone())
                                        }
                                    };
                                    let v271: Spiral_builder::US16 = match &v260 {
                                        Spiral_builder::US19::US19_0(
                                            v260_0_0,
                                            v260_0_1,
                                            v260_0_2,
                                            v260_0_3,
                                            v260_0_4,
                                        ) => Spiral_builder::method45(
                                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                            v260_0_1.clone(),
                                            v260_0_2.clone(),
                                            v260_0_3.clone(),
                                            v260_0_4.clone(),
                                        ),
                                        Spiral_builder::US19::US19_1(v260_1_0) => {
                                            Spiral_builder::US16::US16_1(v260_1_0.clone())
                                        }
                                    };
                                    match &v271 {
                                        Spiral_builder::US16::US16_0(
                                            v271_0_0,
                                            v271_0_1,
                                            v271_0_2,
                                            v271_0_3,
                                            v271_0_4,
                                        ) => {
                                            let v278: List<string> = Spiral_builder::method44(
                                                v271_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Spiral_builder::US19::US19_0(
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
                                        Spiral_builder::US16::US16_1(v271_1_0) => {
                                            Spiral_builder::US19::US19_1(v271_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v292 {
                        Spiral_builder::US19::US19_0(
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
                            let v303: i32 = Spiral_builder::method46(v298.clone(), 0_i32);
                            let v315: Spiral_builder::US20 = if 0_i32 == v303 {
                                Spiral_builder::US20::US20_1(string(
                                    "spaces1 / expected at least one space",
                                ))
                            } else {
                                Spiral_builder::US20::US20_0(
                                    getSlice(v298.clone(), Some(v303), Some(length(v298.clone()))),
                                    v299.clone(),
                                    v300,
                                    v301,
                                )
                            };
                            match &v315 {
                                Spiral_builder::US20::US20_0(
                                    v315_0_0,
                                    v315_0_1,
                                    v315_0_2,
                                    v315_0_3,
                                ) => {
                                    let v0_1_temp: LrcPtr<Spiral_builder::UH1> =
                                        LrcPtr::new(Spiral_builder::UH1::UH1_1(
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
                                    continue '_method36;
                                }
                                _ => Spiral_builder::US16::US16_0(
                                    Spiral_builder::method43(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Spiral_builder::UH1::UH1_1(
                                            v297.clone(),
                                            LrcPtr::new(Spiral_builder::UH1::UH1_0),
                                        )),
                                    ),
                                    v298,
                                    v299,
                                    v300,
                                    v301,
                                ),
                            }
                        }
                        _ => Spiral_builder::US16::US16_0(
                            Spiral_builder::method43(
                                v0_1.get().clone(),
                                LrcPtr::new(Spiral_builder::UH1::UH1_0),
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
        pub fn method35(v0_1: string) -> Spiral_builder::US15 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v11: Spiral_builder::US16 = Spiral_builder::method36(
                    LrcPtr::new(Spiral_builder::UH1::UH1_0),
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
                let v25: Spiral_builder::US21 = match &v11 {
                    Spiral_builder::US16::US16_0(v11_0_0, v11_0_1, v11_0_2, v11_0_3, v11_0_4) => {
                        Spiral_builder::US21::US21_0(toArray(Spiral_builder::method44(
                            v11_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Spiral_builder::US16::US16_1(v11_1_0) => {
                        Spiral_builder::US21::US21_1(v11_1_0.clone())
                    }
                };
                match &v25 {
                    Spiral_builder::US21::US21_0(v25_0_0) => {
                        Spiral_builder::US15::US15_0(v25_0_0.clone())
                    }
                    Spiral_builder::US21::US21_1(v25_1_0) => {
                        Spiral_builder::US15::US15_1(v25_1_0.clone())
                    }
                }
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
        pub fn method47() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Spiral_builder::closure16((), v))
        }
        pub fn closure17(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Spiral_builder::US22 {
            Spiral_builder::US22::US22_0(v0_1)
        }
        pub fn method48() -> Func1<
            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
            Spiral_builder::US22,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Spiral_builder::closure17((), v)
                },
            )
        }
        pub fn closure18(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US22 {
            Spiral_builder::US22::US22_1(v0_1)
        }
        pub fn method49() -> Func1<std::string::String, Spiral_builder::US22> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure18((), v))
        }
        pub fn closure19(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / child error")
        }
        pub fn closure20(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn method50(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>> {
            v0_1
        }
        pub fn closure21(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US24 {
            Spiral_builder::US24::US24_0(v0_1)
        }
        pub fn method51() -> Func1<std::string::String, Spiral_builder::US24> {
            Func1::new(move |v: std::string::String| Spiral_builder::closure21((), v))
        }
        pub fn closure22(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US24 {
            Spiral_builder::US24::US24_1(v0_1)
        }
        pub fn method52() -> Func1<std::string::String, Spiral_builder::US24> {
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
        pub fn method53(
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
        pub fn method54(
        ) -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Spiral_builder::closure26((), v)
            })
        }
        pub fn method55(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn method56(
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>>,
        ) -> std::sync::Arc<std::sync::Mutex<Option<std::process::ChildStdin>>> {
            v0_1
        }
        pub fn method57(
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> {
            v0_1
        }
        pub fn method58(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn method59(
            v0_1: std::thread::JoinHandle<Result<(), string>>,
        ) -> std::thread::JoinHandle<Result<(), string>> {
            v0_1
        }
        pub fn closure27(unitVar: (), v0_1: std::process::Output) -> Spiral_builder::US27 {
            Spiral_builder::US27::US27_0(v0_1)
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US27 {
            Spiral_builder::US27::US27_1(v0_1)
        }
        pub fn closure29(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.execute_with_options / output error")
        }
        pub fn closure30(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn method60(
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
                "runtime.execute_with_options_async / options: {:?}",
                (v0_1, v1_1, v2, v3, v4, v5, v6)
            )
        }
        pub fn method62() -> Func0<string> {
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
                "runtime.execute_with_options_async / WaitForExitAsync / ex: {:?}",
                v0_1
            )
        }
        pub fn closure39(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "runtime.execute_with_options_async / exit_code: {} / output.Length: {}",
                v0_1,
                length(v1_1)
            )
        }
        pub fn method61(
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
        pub fn method28(
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
                Spiral_builder::method30(Spiral_builder::method29(
                    v0_1.clone(),
                    v1_1.clone(),
                    v2.clone(),
                    v3.clone(),
                    v4.clone(),
                    v5,
                    v6.clone(),
                ));
            let v9: string = patternInput.0.clone();
            let v11: Spiral_builder::US15 = Spiral_builder::method35(patternInput.1.clone());
            let v17: Array<string> = match &v11 {
                Spiral_builder::US15::US15_0(v11_0_0) => v11_0_0.clone(),
                Spiral_builder::US15::US15_1(v11_1_0) => panic!(
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
                    let x_15: LrcPtr<(i32, string)> = (Func0::new({
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
                                let v85 = Spiral_builder::method47();
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
                                let v101 = Spiral_builder::method48();
                                let v102 = Spiral_builder::method49();
                                let v104: Spiral_builder::US22 = match v100 {
                                    Ok(x) => v101(x),
                                    Err(e) => v102(e),
                                };
                                let patternInput_3: (
                                    i32,
                                    Spiral_builder::US5,
                                    Spiral_builder::US23,
                                ) = match &v104 {
                                    Spiral_builder::US22::US22_0(v104_0_0) => {
                                        let v105: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::Child>>,
                                        > = v104_0_0.clone();
                                        let v107: bool = true;
                                        let _result = (|| {
                                            //;
                                            let v108: std::sync::Arc<
                                                std::sync::Mutex<Option<std::process::Child>>,
                                            > = Spiral_builder::method50(v105.clone());
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
                                            > = Spiral_builder::method50(v105.clone());
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
                                            > = Spiral_builder::method50(v105.clone());
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
                                                let v215 = Spiral_builder::method47();
                                                let v217: Result<
                                                    std::string::String,
                                                    std::string::String,
                                                > = v212.map_err(|x| v215(x));
                                                let v218 = Spiral_builder::method51();
                                                let v219 = Spiral_builder::method52();
                                                let v221: Spiral_builder::US24 = match v217 {
                                                    Ok(x) => v218(x),
                                                    Err(e) => v219(e),
                                                };
                                                let v254: std::string::String = match &v221 {
                                                    Spiral_builder::US24::US24_0(v221_0_0) => {
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
                                                    Spiral_builder::US24::US24_1(v221_1_0) => {
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
                                                > = Spiral_builder::method53(v214);
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
                                                let v264 = Spiral_builder::method54();
                                                let v266: Result<(), std::string::String> =
                                                    v263.map_err(|x| v264(x));
                                                let v268: _ = v266;
                                                let v270: bool = true;
                                                v268
                                            }); //;
                                            let v273: Result<(), string> = Spiral_builder::method55(
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
                                                                        Spiral_builder::method47();
                                                                    let v296:
                                                                            Result<std::string::String,
                                                                                   std::string::String> =
                                                                        v291.map_err(|x| v294(x));
                                                                    let v297 =
                                                                        Spiral_builder::method51();
                                                                    let v298 =
                                                                        Spiral_builder::method52();
                                                                    let v300:
                                                                            Spiral_builder::US24 =
                                                                        match v296 { Ok(x) => v297(x), Err(e) => v298(e) };
                                                                    let v338:
                                                                            std::string::String =
                                                                        match &v300
                                                                            {
                                                                            Spiral_builder::US24::US24_0(v300_0_0)
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
                                                                            Spiral_builder::US24::US24_1(v300_1_0)
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
                                                                        Spiral_builder::method53(v293);
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
                                                                        Spiral_builder::method54();
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
                                                    Spiral_builder::method55(
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
                                                    MutCell<Option<Spiral_builder::US25>>,
                                                > = refCell(None::<Spiral_builder::US25>);
                                                {
                                                    let x_5: Option<Spiral_builder::US25> =
                                                        match &v4 {
                                                            None => None::<Spiral_builder::US25>,
                                                            Some(v4_0_0) => {
                                                                let x_3 = v4_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_3 = x_3.clone();
                                                                    move || {
                                                                        Spiral_builder::US25::US25_0(
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
                                                    let v367: Spiral_builder::US25 = defaultValue(
                                                        Spiral_builder::US25::US25_1,
                                                        _v362.get().clone(),
                                                    );
                                                    match &v367 {
                                                        Spiral_builder::US25::US25_0(v367_0_0) => {
                                                            let v369: std::sync::Arc<
                                                                std::sync::Mutex<
                                                                    Option<
                                                                        std::process::ChildStdin,
                                                                    >,
                                                                >,
                                                            > = Spiral_builder::method56(v185);
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
                                                                    Option<Spiral_builder::US26>,
                                                                >,
                                                            > = refCell(
                                                                None::<Spiral_builder::US26>,
                                                            );
                                                            {
                                                                let x_8: Option<
                                                                    Spiral_builder::US26,
                                                                > = match &v391 {
                                                                    None => {
                                                                        None::<Spiral_builder::US26>
                                                                    }
                                                                    Some(v391_0_0) => {
                                                                        let x_6:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        v391_0_0.clone();
                                                                        Some((Func0::new({
                                                                            let x_6 = x_6.clone();
                                                                            move || {
                                                                                Spiral_builder::US26::US26_0(x_6.clone())
                                                                            }
                                                                        }))(
                                                                        ))
                                                                    }
                                                                };
                                                                _v392.set(x_8)
                                                            }
                                                            {
                                                                let v397:
                                                                                                Spiral_builder::US26 =
                                                                                            defaultValue(Spiral_builder::US26::US26_1,
                                                                                                         _v392.get().clone());
                                                                match &v397
                                                                                            {
                                                                                            Spiral_builder::US26::US26_0(v397_0_0)
                                                                                            =>
                                                                                            {
                                                                                                let v398:
                                                                                                        std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                    match &v397
                                                                                                        {
                                                                                                        Spiral_builder::US26::US26_0(x)
                                                                                                        =>
                                                                                                        x.clone(),
                                                                                                        _
                                                                                                        =>
                                                                                                        unreachable!(),
                                                                                                    };
                                                                                                (match &v367
                                                                                                     {
                                                                                                     Spiral_builder::US25::US25_0(x)
                                                                                                     =>
                                                                                                     x.clone(),
                                                                                                     _
                                                                                                     =>
                                                                                                     unreachable!(),
                                                                                                 })(v398.clone());
                                                                                                {
                                                                                                    let v399:
                                                                                                            std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> =
                                                                                                        Spiral_builder::method57(v398);
                                                                                                    let v401:
                                                                                                            Result<std::sync::MutexGuard<std::process::ChildStdin>,
                                                                                                                   std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> =
                                                                                                        v399.lock();
                                                                                                    let v404:
                                                                                                            std::sync::MutexGuard<std::process::ChildStdin> =
                                                                                                        Spiral_builder::method58(v401.unwrap());
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
                                                        > = Spiral_builder::method50(v105);
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
                                                        let v424 = Spiral_builder::method47();
                                                        let v426: Result<
                                                            std::process::Output,
                                                            std::string::String,
                                                        > = v423.map_err(|x| v424(x));
                                                        let v427: std::thread::JoinHandle<
                                                            Result<(), string>,
                                                        > = Spiral_builder::method59(v361);
                                                        let v430: string = string("v427");
                                                        let v431: std::thread::JoinHandle<
                                                            Result<(), string>,
                                                        > = Spiral_builder::method59(v279);
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
                                                            let v451: Spiral_builder::US27 =
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
                                                                Spiral_builder::US27::US27_0(
                                                                    v451_0_0,
                                                                ) => {
                                                                    let v454:
                                                                                                    std::process::ExitStatus =
                                                                                                v451_0_0.clone().status;
                                                                    let v456: Option<i32> =
                                                                        v454.code();
                                                                    let _v457:
                                                                                                    LrcPtr<MutCell<Option<Spiral_builder::US28>>> =
                                                                                                refCell(None::<Spiral_builder::US28>);
                                                                    {
                                                                        let x_13:
                                                                                                        Option<Spiral_builder::US28> =
                                                                                                    match &v456
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        None::<Spiral_builder::US28>,
                                                                                                        Some(v456_0_0)
                                                                                                        =>
                                                                                                        {
                                                                                                            let x_11:
                                                                                                                    i32 =
                                                                                                                v456_0_0.clone();
                                                                                                            Some((Func0::new({
                                                                                                                                 let x_11
                                                                                                                                     =
                                                                                                                                     x_11.clone();
                                                                                                                                 move
                                                                                                                                     ||
                                                                                                                                     Spiral_builder::US28::US28_0(x_11)
                                                                                                                             }))())
                                                                                                        }
                                                                                                    };
                                                                        _v457.set(x_13)
                                                                    }
                                                                    {
                                                                        let v462:
                                                                                                        Spiral_builder::US28 =
                                                                                                    defaultValue(Spiral_builder::US28::US28_1,
                                                                                                                 _v457.get().clone());
                                                                        match &v462
                                                                                                    {
                                                                                                    Spiral_builder::US28::US28_0(v462_0_0)
                                                                                                    =>
                                                                                                    (match &v462
                                                                                                         {
                                                                                                         Spiral_builder::US28::US28_0(x)
                                                                                                         =>
                                                                                                         x.clone(),
                                                                                                         _
                                                                                                         =>
                                                                                                         unreachable!(),
                                                                                                     },
                                                                                                     Spiral_builder::US5::US5_1,
                                                                                                     Spiral_builder::US23::US23_0(v200.clone())),
                                                                                                    _
                                                                                                    =>
                                                                                                    {
                                                                                                        let v468:
                                                                                                                &str =
                                                                                                            &*string("runtime.execute_with_options / exit_code=None");
                                                                                                        (-1_i32,
                                                                                                         Spiral_builder::US5::US5_0(String::from(v468)),
                                                                                                         Spiral_builder::US23::US23_0(v200.clone()))
                                                                                                    }
                                                                                                }
                                                                    }
                                                                }
                                                                Spiral_builder::US27::US27_1(
                                                                    v451_1_0,
                                                                ) => {
                                                                    let v479: std::string::String =
                                                                        v451_1_0.clone();
                                                                    Spiral_builder::method5(
                                                                        Spiral_builder::US0::US0_4,
                                                                        Func0::new(move || {
                                                                            Spiral_builder::closure29((),
                                                                                                                                                             ())
                                                                        }),
                                                                        Func0::new({
                                                                            let v479 = v479.clone();
                                                                            move || {
                                                                                Spiral_builder::closure30(v479.clone(),
                                                                                                                                                                 ())
                                                                            }
                                                                        }),
                                                                    );
                                                                    (-2_i32,
                                                                                             Spiral_builder::US5::US5_0(v479.clone()),
                                                                                             Spiral_builder::US23::US23_1)
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    Spiral_builder::US22::US22_1(v104_1_0) => {
                                        let v491: std::string::String = v104_1_0.clone();
                                        Spiral_builder::method5(
                                            Spiral_builder::US0::US0_4,
                                            Func0::new(move || Spiral_builder::closure19((), ())),
                                            Func0::new({
                                                let v491 = v491.clone();
                                                move || Spiral_builder::closure20(v491.clone(), ())
                                            }),
                                        );
                                        (
                                            -1_i32,
                                            Spiral_builder::US5::US5_0(v491.clone()),
                                            Spiral_builder::US23::US23_1,
                                        )
                                    }
                                };
                                let v502: Spiral_builder::US23 = patternInput_3.2.clone();
                                let v501: Spiral_builder::US5 = patternInput_3.1.clone();
                                let v500: i32 = patternInput_3.0.clone();
                                let v507: Option<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                > = match &v502 {
                                    Spiral_builder::US23::US23_0(v502_0_0) => Some(match &v502 {
                                        Spiral_builder::US23::US23_0(x) => x.clone(),
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
                                let v509: bool = true;
                                let _result = v507.map(|x| {
                                    //;
                                    let v512: std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    > = Spiral_builder::method60(x);
                                    let v514: Result<
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
                                    > = v512.lock();
                                    let v516: std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    > = v514.unwrap();
                                    let v518 = v516.iter();
                                    let v520: Vec<std::string::String> = v518.collect::<Vec<_>>();
                                    let v522: bool = true;
                                    let _result: Vec<_> = v520
                                        .into_iter()
                                        .map(|x| {
                                            //;
                                            let v524: std::string::String = x;
                                            let v526: string =
                                                fable_library_rust::String_::fromString(v524);
                                            let v528: bool = true;
                                            v526
                                        })
                                        .collect::<Vec<_>>();
                                    let v530: Vec<string> = _result;
                                    let v538: string = join(
                                        string("\n"),
                                        toArray_1(ofArray_1(
                                            fable_library_rust::NativeArray_::array_from(v530),
                                        )),
                                    );
                                    let v540: bool = true;
                                    v538
                                });
                                let v542: Option<string> = _result;
                                let v549: Spiral_builder::US3 = match &v501 {
                                    Spiral_builder::US5::US5_0(v501_0_0) => {
                                        Spiral_builder::US3::US3_0(
                                            fable_library_rust::String_::fromString(match &v501 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            }),
                                        )
                                    }
                                    _ => Spiral_builder::US3::US3_1,
                                };
                                let v554: string = defaultValue(
                                    match &v549 {
                                        Spiral_builder::US3::US3_0(v549_0_0) => match &v549 {
                                            Spiral_builder::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                        _ => string(""),
                                    },
                                    v542,
                                );
                                Spiral_builder::method5(
                                    Spiral_builder::US0::US0_0,
                                    Func0::new(move || Spiral_builder::closure31((), ())),
                                    Func0::new({
                                        let v500 = v500.clone();
                                        let v554 = v554.clone();
                                        move || Spiral_builder::closure32(v500, v554.clone(), ())
                                    }),
                                );
                                LrcPtr::new((v500, v554.clone()))
                            }
                        }
                    }))();
                    _v35.set(Some(x_15))
                }
                {
                    let v559: LrcPtr<(i32, string)> = match &_v35.get().clone() {
                        None => panic!("{}", string("base.capture / _v35=None"),),
                        Some(_v35_0_0) => _v35_0_0.clone(),
                    };
                    _v7.set(Some((v559.0.clone(), v559.1.clone())));
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
            string("spiral_builder.process_cuda / env install error")
        }
        pub fn closure41(
            v0_1: Spiral_builder::US8,
            v1_1: string,
            v2: string,
            v3: i32,
            unitVar: (),
        ) -> string {
            sprintf!(
                "env: {} / exit_code: {} / new_code_path: {} / run_result: {}",
                v0_1,
                v3,
                v1_1,
                v2
            )
        }
        pub fn closure42(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32))),
            )
        }
        pub fn closure43(unitVar: (), v0_1: string) -> Spiral_builder::US3 {
            Spiral_builder::US3::US3_0(v0_1)
        }
        pub fn closure45(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_cuda / Exception")
        }
        pub fn closure46(
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
        pub fn closure44(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US3 {
            Spiral_builder::method5(
                Spiral_builder::US0::US0_4,
                Func0::new(move || Spiral_builder::closure45((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    move || {
                        Spiral_builder::closure46(
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
        pub fn closure47(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_cuda / error")
        }
        pub fn closure48(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / new_code_path: {} / external_command: {} / run_result: {}",
                v2,
                v0_1,
                v3,
                v1_1
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
        pub fn method63() -> string {
            string("fs-path")
        }
        pub fn method64() -> string {
            string("command")
        }
        pub fn method65() -> string {
            string("path")
        }
        pub fn method69(v0_1: string) -> string {
            v0_1
        }
        pub fn method71() -> string {
            string("")
        }
        pub fn method72(v0_1: string) -> string {
            v0_1
        }
        pub fn method73() -> string {
            string("^\\\\\\\\\\?\\\\")
        }
        pub fn method70(v0_1: string) -> string {
            let v1_1: string = Spiral_builder::method71();
            let _v2: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v3: string = Spiral_builder::method72(v0_1);
            let v6: Result<regex::Regex, regex::Error> =
                regex::Regex::new(&string("^\\\\\\\\\\?\\\\"));
            let v8: regex::Regex = v6.unwrap();
            let v10: std::borrow::Cow<str> = v8.replace_all(&v3, &*v1_1);
            let v12: std::string::String = String::from(v10);
            {
                let x: string = fable_library_rust::String_::fromString(v12);
                _v2.set(Some(x))
            }
            {
                let v21: string = match &_v2.get().clone() {
                    None => panic!("{}", string("base.run_target / _v2=None"),),
                    Some(_v2_0_0) => _v2_0_0.clone(),
                };
                replace(
                    sprintf!(
                        "{}{}",
                        toLower(ofChar(getCharAt(v21.clone(), 0_i32))),
                        getSlice(v21, Some(1_i32), None::<i32>)
                    ),
                    string("\\"),
                    string("/"),
                )
            }
        }
        pub fn method74(v0_1: i32, v1_1: LrcPtr<Spiral_builder::Mut5>) -> bool {
            v1_1.l0.get().clone() < v0_1
        }
        pub fn method75() -> char {
            let _v0: MutCell<Option<char>> = MutCell::new(None::<char>);
            {
                let x: char = std::path::MAIN_SEPARATOR;
                _v0.set(Some(x))
            }
            match &_v0.get().clone() {
                None => panic!("{}", string("base.run_target / _v0=None"),),
                Some(_v0_0_0) => _v0_0_0.clone(),
            }
        }
        pub fn method76(v0_1: string) -> string {
            v0_1
        }
        pub fn method68(v0_1: string) -> string {
            let _v1: MutCell<Option<string>> = MutCell::new(None::<string>);
            let v2: string = Spiral_builder::method69(v0_1);
            let v4: &str = &*v2.clone();
            let v6: std::string::String = String::from(v4);
            let v8: std::path::PathBuf = std::path::PathBuf::from(v6);
            {
                let x_2: string = if v8.exists() == false {
                    let v12: string = Spiral_builder::method22();
                    let v16: Array<string> = split(
                        Spiral_builder::method70(Spiral_builder::method14(v12.clone(), v2.clone())),
                        string("/"),
                        -1_i32,
                        0_i32,
                    );
                    let v18: i32 = count_2(v16.clone());
                    let v19: LrcPtr<Spiral_builder::Mut5> = LrcPtr::new(Spiral_builder::Mut5 {
                        l0: MutCell::new(0_i32),
                        l1: MutCell::new(0_i32),
                        l2: MutCell::new(new_empty::<string>()),
                    });
                    while Spiral_builder::method74(v18, v19.clone()) {
                        let v21: i32 = v19.l0.get().clone();
                        let v24: i32 = v21.wrapping_neg() + v18 - 1_i32;
                        let matchValue: i32 = v19.l1.get().clone();
                        let v26: Array<string> = v19.l2.get().clone();
                        let v25: i32 = matchValue;
                        let v27: string = v16[v24].clone();
                        let patternInput_1: (i32, Array<string>) = if string("..") == v27.clone() {
                            (v25 + 1_i32, v26.clone())
                        } else {
                            if string(".") == v27.clone() {
                                (v25, v26.clone())
                            } else {
                                if 0_i32 == v25 {
                                    if endsWith(v27.clone(), string(":"), false) {
                                        let v35: Array<string> = new_array(&[sprintf!(
                                            "{}:",
                                            getCharAt(v12.clone(), 0_i32)
                                        )]);
                                        let v36: i32 = count_2(v35.clone());
                                        let v38: i32 = v36 + count_2(v26.clone());
                                        let v39: Array<string> = new_init(&string(""), v38);
                                        let v40: LrcPtr<Spiral_builder::Mut4> =
                                            LrcPtr::new(Spiral_builder::Mut4 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Spiral_builder::method32(v38, v40.clone()) {
                                            let v42: i32 = v40.l0.get().clone();
                                            let v47: string = if v42 < v36 {
                                                v35[v42].clone()
                                            } else {
                                                let v45: i32 = v42 - v36;
                                                v26[v45].clone()
                                            };
                                            v39.get_mut()[v42 as usize] = v47;
                                            {
                                                let v48: i32 = v42 + 1_i32;
                                                v40.l0.set(v48);
                                                ()
                                            }
                                        }
                                        (0_i32, v39.clone())
                                    } else {
                                        let v49: Array<string> = new_array(&[v27]);
                                        let v50: i32 = count_2(v49.clone());
                                        let v52: i32 = v50 + count_2(v26.clone());
                                        let v53: Array<string> = new_init(&string(""), v52);
                                        let v54: LrcPtr<Spiral_builder::Mut4> =
                                            LrcPtr::new(Spiral_builder::Mut4 {
                                                l0: MutCell::new(0_i32),
                                            });
                                        while Spiral_builder::method32(v52, v54.clone()) {
                                            let v56: i32 = v54.l0.get().clone();
                                            let v61: string = if v56 < v50 {
                                                v49[v56].clone()
                                            } else {
                                                let v59: i32 = v56 - v50;
                                                v26[v59].clone()
                                            };
                                            v53.get_mut()[v56 as usize] = v61;
                                            {
                                                let v62: i32 = v56 + 1_i32;
                                                v54.l0.set(v62);
                                                ()
                                            }
                                        }
                                        (0_i32, v53.clone())
                                    }
                                } else {
                                    (v25 - 1_i32, v26.clone())
                                }
                            }
                        };
                        let v72: i32 = v21 + 1_i32;
                        v19.l0.set(v72);
                        v19.l1.set(patternInput_1.0.clone());
                        v19.l2.set(patternInput_1.1.clone());
                        ()
                    }
                    {
                        let matchValue_2: i32 = v19.l1.get().clone();
                        let v74: Array<string> = v19.l2.get().clone();
                        let v75: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v74 = v74.clone();
                            move || {
                                map(
                                    Func1::new({
                                        let v74 = v74.clone();
                                        move |i: i32| v74[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, count_2(v74.clone()) - 1_i32),
                                )
                            }
                        }));
                        join(ofChar(Spiral_builder::method75()), toArray_1(v75))
                    }
                } else {
                    let v83: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::canonicalize(&*v2);
                    let v85: std::path::PathBuf = v83.unwrap();
                    let v87: std::path::Display = v85.display();
                    let _v88: MutCell<Option<std::string::String>> =
                        MutCell::new(None::<std::string::String>);
                    {
                        let x: std::string::String = format!("{}", v87);
                        _v88.set(Some(x))
                    }
                    {
                        let v98: std::string::String = match &_v88.get().clone() {
                            None => panic!("{}", string("base.run_target / _v88=None"),),
                            Some(_v88_0_0) => _v88_0_0.clone(),
                        };
                        fable_library_rust::String_::fromString(v98)
                    }
                };
                _v1.set(Some(x_2))
            }
            match &_v1.get().clone() {
                None => panic!("{}", string("base.run_target / _v1=None"),),
                Some(_v1_0_0) => _v1_0_0.clone(),
            }
        }
        pub fn method67(v0_1: string) -> string {
            Spiral_builder::method70(Spiral_builder::method68(v0_1))
        }
        pub fn method66(v0_1: string) -> string {
            Spiral_builder::method67(Spiral_builder::method14(Spiral_builder::method22(), v0_1))
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> string {
            Spiral_builder::method66(fable_library_rust::String_::fromString(v0_1))
        }
        pub fn method77() -> string {
            string("retries")
        }
        pub fn method78() -> string {
            string("working-directory")
        }
        pub fn closure51(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / repl error")
        }
        pub fn closure52(v0_1: u8, v1_1: u8, v2: string, v3: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / retry: {}/{} / repl_result: {} / {}",
                v3,
                v1_1,
                v0_1,
                v2,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method79(v0_1: Option<string>, v1_1: u8, v2: string, v3: u8) -> (i32, string) {
            let v0_1: MutCell<Option<string>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<u8> = MutCell::new(v1_1);
            let v2: MutCell<string> = MutCell::new(v2.clone());
            let v3: MutCell<u8> = MutCell::new(v3);
            '_method79: loop {
                break '_method79 ({
                    let patternInput: (i32, string) = Spiral_builder::method28(
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
                            Func0::new(move || Spiral_builder::closure51((), ())),
                            Func0::new({
                                let v16 = v16.clone();
                                let v17 = v17.clone();
                                let v1_1 = v1_1.clone();
                                let v3 = v3.clone();
                                move || {
                                    Spiral_builder::closure52(
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
                            continue '_method79;
                        }
                    }
                });
            }
        }
        pub fn closure53(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib / jupyter nbconvert")
        }
        pub fn closure54(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / jupyter_result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib / html cell ids")
        }
        pub fn closure56(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / pwsh_replace_html_result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure57(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / dib")
        }
        pub fn closure58(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / result.Length: {} / {}",
                v1_1,
                length(v0_1),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method81() -> string {
            string("")
        }
        pub fn method80(v0_1: string) -> string {
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
        pub fn method83(v0_1: string) -> string {
            v0_1
        }
        pub fn closure59(unitVar: (), unitVar_1: ()) -> Spiral_builder::US31 {
            Spiral_builder::US31::US31_0
        }
        pub fn closure60(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US31 {
            Spiral_builder::US31::US31_1(v0_1)
        }
        pub fn closure61(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.create_dir")
        }
        pub fn closure62(v0_1: string, v1_1: std::string::String, unitVar: ()) -> string {
            sprintf!(
                "dir: {} / error: {} / {}",
                v0_1,
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure63(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.create_dir")
        }
        pub fn closure64(v0_1: string, unitVar: ()) -> string {
            sprintf!("dir: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn method86(v0_1: string) -> string {
            v0_1
        }
        pub fn method85(v0_1: bool, v1_1: string) {
            let _v2: MutCell<Option<()>> = MutCell::new(None::<()>);
            let v3: string = Spiral_builder::method86(v1_1);
            if Spiral_builder::method18(v3.clone()) {
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
        pub fn closure65(v0_1: string, unitVar: ()) {
            Spiral_builder::method85(true, v0_1);
        }
        pub fn method84(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure65(v0_1.clone(), ())
            })
        }
        pub fn method87(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure65(v0_1.clone(), ())
            })
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.create_dir")
        }
        pub fn closure67(v0_1: string, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "dir: {} / result: {} {}",
                v0_1,
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure69(unitVar: (), unitVar_1: ()) -> string {
            string("file_system.delete_directory_async")
        }
        pub fn method90(v0_1: string) -> string {
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
        pub fn closure71(unitVar: (), v0_1: string) -> string {
            Spiral_builder::method90(v0_1)
        }
        pub fn closure70(v0_1: string, v1_1: string, unitVar: ()) -> string {
            sprintf!(
                "path: {} / ex: {} / {}",
                Spiral_builder::closure71((), v0_1),
                v1_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method89(v0_1: string, v1_1: i64) -> Arc<Async<i64>> {
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
        pub fn closure68(v0_1: string, unitVar: ()) {
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
        pub fn method88(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure68(v0_1.clone(), ())
            })
        }
        pub fn method91(v0_1: string) -> Func0<()> {
            Func0::new({
                let v0_1 = v0_1.clone();
                move || Spiral_builder::closure68(v0_1.clone(), ())
            })
        }
        pub fn method82(v0_1: string) -> LrcPtr<dyn IDisposable> {
            let _v1: MutCell<Option<LrcPtr<dyn IDisposable>>> =
                MutCell::new(None::<LrcPtr<dyn IDisposable>>);
            let v2: string = Spiral_builder::method83(v0_1);
            let v4: Result<(), std::io::Error> = std::fs::create_dir_all(&*v2.clone());
            let v5 = Spiral_builder::method47();
            let v7: Result<(), std::string::String> = v4.map_err(|x| v5(x));
            let v10: Spiral_builder::US31 = match &v7 {
                Err(v7_1_0) => Spiral_builder::closure60((), v7_1_0.clone()),
                _ => Spiral_builder::closure59((), ()),
            };
            match &v10 {
                Spiral_builder::US31::US31_0 => Spiral_builder::method5(
                    Spiral_builder::US0::US0_0,
                    Func0::new(move || Spiral_builder::closure63((), ())),
                    Func0::new({
                        let v2 = v2.clone();
                        move || Spiral_builder::closure64(v2.clone(), ())
                    }),
                ),
                Spiral_builder::US31::US31_1(v10_1_0) => Spiral_builder::method5(
                    Spiral_builder::US0::US0_4,
                    Func0::new(move || Spiral_builder::closure61((), ())),
                    Func0::new({
                        let v10 = v10.clone();
                        let v2 = v2.clone();
                        move || {
                            Spiral_builder::closure62(
                                v2.clone(),
                                match &v10 {
                                    Spiral_builder::US31::US31_1(x) => x.clone(),
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
                let v19 = Spiral_builder::method84(v2.clone());
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
        pub fn method93(v0_1: chrono::DateTime<chrono::Utc>) -> chrono::DateTime<chrono::Utc> {
            v0_1
        }
        pub fn method94(v0_1: chrono::DateTime<chrono::Local>) -> chrono::DateTime<chrono::Local> {
            v0_1
        }
        pub fn method95() -> string {
            string("hh:mm")
        }
        pub fn method96() -> string {
            string("yyyyMMdd-HHmm-ssff-ffff-f")
        }
        pub fn method97() -> string {
            string("hhmm")
        }
        pub fn method92(v0_1: Guid, v1_1: DateTime) -> Guid {
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
            let _v18: LrcPtr<MutCell<Option<Spiral_builder::US32>>> =
                refCell(None::<Spiral_builder::US32>);
            {
                let x_2: Option<Spiral_builder::US32> = match &v17 {
                    None => None::<Spiral_builder::US32>,
                    Some(v17_0_0) => {
                        let x: chrono::DateTime<chrono::Utc> = v17_0_0.clone();
                        Some((Func0::new({
                            let x = x.clone();
                            move || Spiral_builder::US32::US32_0(x.clone())
                        }))())
                    }
                };
                _v18.set(x_2)
            }
            {
                let v23: Spiral_builder::US32 =
                    defaultValue(Spiral_builder::US32::US32_1, _v18.get().clone());
                let v42: Spiral_builder::US3 = match &v23 {
                    Spiral_builder::US32::US32_0(v23_0_0) => {
                        let v25: chrono::DateTime<chrono::Utc> =
                            Spiral_builder::method93(match &v23 {
                                Spiral_builder::US32::US32_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                        let v27: chrono::NaiveDateTime = v25.naive_utc();
                        let v29: chrono::DateTime<chrono::Local> =
                            chrono::offset::TimeZone::from_utc_datetime(&chrono::Local, &v27);
                        let v31: string = string("r#\"%Y%m%d-%H%M-%S%f\"#");
                        let v32: &str = r#"%Y%m%d-%H%M-%S%f"#;
                        let v33: chrono::DateTime<chrono::Local> = Spiral_builder::method94(v29);
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
                        let v88: string = Spiral_builder::method95();
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
        pub fn method98(v0_1: string, v1_1: string) {
            if Spiral_builder::method18(v0_1.clone()) == false {
                let v4: LrcPtr<dyn IDisposable> = Spiral_builder::method82(v0_1.clone());
                ()
            }
            {
                let v5: string = Spiral_builder::method23(v1_1.clone());
                if Spiral_builder::method18(v5.clone()) == false {
                    let v8: LrcPtr<dyn IDisposable> = Spiral_builder::method82(v5);
                    ()
                }
                if if Spiral_builder::method18(v1_1.clone()) {
                    let v11: Result<std::path::PathBuf, std::io::Error> =
                        std::fs::read_link(&*v1_1.clone());
                    v11.is_err()
                } else {
                    false
                } {
                    Spiral_builder::method85(true, v1_1.clone());
                }
                if Spiral_builder::method18(v1_1.clone()) == false {
                    let _v18: MutCell<Option<()>> = MutCell::new(None::<()>);
                    let _v19: MutCell<Option<()>> = MutCell::new(None::<()>);
                    std::os::windows::fs::symlink_dir(&*v0_1, &*v1_1).unwrap();
                    _v19.set(Some(()));
                    match &_v19.get().clone() {
                        None => panic!("{}", string("runtime.run_platform / _v19=None"),),
                        Some(_v19_0_0) => _v19_0_0.clone(),
                    }
                    _v18.set(Some(()));
                    match &_v18.get().clone() {
                        None => panic!("{}", string("base.run_target / _v18=None"),),
                        Some(_v18_0_0) => _v18_0_0.clone(),
                    }
                    ()
                }
            }
        }
        pub fn closure72(unitVar: (), unitVar_1: ()) -> string {
            string("common.retry_fn\' / loop")
        }
        pub fn closure73(v0_1: u8, v1_1: i32, v2: string, v3: bool, unitVar: ()) -> string {
            sprintf!(
                "is_error: {} / retry: {}/{} / result: {:?} / {}",
                v3,
                v0_1,
                3_u8,
                (v1_1, v2),
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method100(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Spiral_builder::US12,
            v4: u8,
        ) -> (i32, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<string> = MutCell::new(v2.clone());
            let v3: MutCell<Spiral_builder::US12> = MutCell::new(v3.clone());
            let v4: MutCell<u8> = MutCell::new(v4);
            '_method100: loop {
                break '_method100 ({
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
                            Spiral_builder::US12::US12_0(v3_0_0) => {
                                Ok::<string, string>(v3_0_0.clone())
                            }
                            Spiral_builder::US12::US12_1(v3_1_0) => {
                                Err::<string, string>(v3_1_0.clone())
                            }
                        };
                        let patternInput: (i32, string) = Spiral_builder::method28(
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
                        let v47: Spiral_builder::US33 = if v42 == 0_i32 {
                            Spiral_builder::US33::US33_0(v42, v43.clone())
                        } else {
                            Spiral_builder::US33::US33_1(v42, v43)
                        };
                        let patternInput_1: (bool, i32, string) = match &v47 {
                            Spiral_builder::US33::US33_0(v47_0_0, v47_0_1) => {
                                (false, v47_0_0.clone(), v47_0_1.clone())
                            }
                            Spiral_builder::US33::US33_1(v47_1_0, v47_1_1) => {
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
                                Func0::new(move || Spiral_builder::closure72((), ())),
                                Func0::new({
                                    let v4 = v4.clone();
                                    let v55 = v55.clone();
                                    let v56 = v56.clone();
                                    let v57 = v57.clone();
                                    move || {
                                        Spiral_builder::closure73(
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
                                let v3_temp: Spiral_builder::US12 = v3.get().clone();
                                let v4_temp: u8 = v4.get().clone() + 1_u8;
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method100;
                            }
                        }
                    }
                });
            }
        }
        pub fn method99(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Spiral_builder::US12,
        ) -> (i32, string) {
            Spiral_builder::method100(v0_1, v1_1, v2, v3, 1_u8)
        }
        pub fn closure74(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust / dotnet fable error")
        }
        pub fn closure75(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / dotnet_fable_result: {} / {}",
                v1_1,
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method102() -> string {
            string("a")
        }
        pub fn method101(v0_1: string, v1_1: Spiral_builder::US12, v2: u8) -> (i32, string) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Spiral_builder::US12> = MutCell::new(v1_1.clone());
            let v2: MutCell<u8> = MutCell::new(v2);
            '_method101: loop {
                break '_method101 ({
                    let v8: string =
                        sprintf!("cargo fmt --manifest-path \"{}\" --", v0_1.get().clone());
                    let v14: Result<string, string> = match &v1_1.get().clone() {
                        Spiral_builder::US12::US12_0(v1_1_0_0) => {
                            Ok::<string, string>(v1_1_0_0.clone())
                        }
                        Spiral_builder::US12::US12_1(v1_1_1_0) => {
                            Err::<string, string>(v1_1_1_0.clone())
                        }
                    };
                    let patternInput: (i32, string) = Spiral_builder::method28(
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
                    let v152: Spiral_builder::US33 = if contains(
                        v19.clone(),
                        string("failed to load manifest for workspace member"),
                    ) == false
                    {
                        if v18 == 0_i32 {
                            Spiral_builder::US33::US33_0(v18, v19.clone())
                        } else {
                            Spiral_builder::US33::US33_1(v18, v19.clone())
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
                        let _v80: LrcPtr<MutCell<Option<Spiral_builder::US34>>> =
                            refCell(None::<Spiral_builder::US34>);
                        {
                            let x_2: Option<Spiral_builder::US34> = match &v79 {
                                None => None::<Spiral_builder::US34>,
                                Some(v79_0_0) => {
                                    let x: std::collections::HashMap<string, string> =
                                        v79_0_0.clone();
                                    Some((Func0::new({
                                        let x = x.clone();
                                        move || Spiral_builder::US34::US34_0(x.clone())
                                    }))())
                                }
                            };
                            _v80.set(x_2)
                        }
                        {
                            let v85: Spiral_builder::US34 =
                                defaultValue(Spiral_builder::US34::US34_1, _v80.get().clone());
                            let v99: Spiral_builder::US35 = match &v85 {
                                Spiral_builder::US34::US34_0(v85_0_0) => {
                                    let v87: string = Spiral_builder::method102();
                                    let v89: Option<string> = std::collections::HashMap::get(
                                        &match &v85 {
                                            Spiral_builder::US34::US34_0(x) => x.clone(),
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
                                    Spiral_builder::US35::US35_0(defaultValue(
                                        Spiral_builder::US3::US3_1,
                                        _v90.get().clone(),
                                    ))
                                }
                                _ => Spiral_builder::US35::US35_1,
                            };
                            let v106: Spiral_builder::US3 =
                                if let Spiral_builder::US35::US35_0(v99_0_0) = &v99 {
                                    let v100: Spiral_builder::US3 = match &v99 {
                                        Spiral_builder::US35::US35_0(x) => x.clone(),
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
                                    if Spiral_builder::method26(v108.clone()) == false {
                                        let v112: LrcPtr<dyn IDisposable> =
                                            Spiral_builder::method82(Spiral_builder::method23(
                                                v108.clone(),
                                            ));
                                        let v113: DateTime = DateTime::now();
                                        let v118: string =
                                            toString(Spiral_builder::method92(new_guid(), v113));
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
                                        Spiral_builder::US33::US33_0(v18, v19.clone())
                                    } else {
                                        Spiral_builder::US33::US33_1(v18, v19.clone())
                                    }
                                }
                                _ => Spiral_builder::US33::US33_1(v18, v19.clone()),
                            }
                        }
                    };
                    let patternInput_1: (bool, i32, string) = match &v152 {
                        Spiral_builder::US33::US33_0(v152_0_0, v152_0_1) => {
                            (false, v152_0_0.clone(), v152_0_1.clone())
                        }
                        Spiral_builder::US33::US33_1(v152_1_0, v152_1_1) => {
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
                            Func0::new(move || Spiral_builder::closure72((), ())),
                            Func0::new({
                                let v160 = v160.clone();
                                let v161 = v161.clone();
                                let v162 = v162.clone();
                                let v2 = v2.clone();
                                move || {
                                    Spiral_builder::closure73(
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
                            let v1_1_temp: Spiral_builder::US12 = v1_1.get().clone();
                            let v2_temp: u8 = v2.get().clone() + 1_u8;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            continue '_method101;
                        }
                    }
                });
            }
        }
        pub fn closure76(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust / cargo fmt error")
        }
        pub fn closure77(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / cargo_fmt_result: {} / {}",
                v1_1,
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn method103() -> string {
            string(" defaultOf::<()>();")
        }
        pub fn method104() -> string {
            string("\\s\\sdefaultOf\\(\\);")
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust")
        }
        pub fn closure79(
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
        pub fn method105(v0_1: LrcPtr<Spiral_builder::UH3>) {
            let v0_1: MutCell<LrcPtr<Spiral_builder::UH3>> = MutCell::new(v0_1.clone());
            '_method105: loop {
                break '_method105 (match v0_1.get().clone().as_ref() {
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
                            continue '_method105;
                        }
                    }
                });
            }
        }
        pub fn closure81(unitVar: (), v0_1: string) -> bool {
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
        pub fn closure80(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(skip(
                    2_i32,
                    skipWhile(
                        Func1::new(move |v: string| Spiral_builder::closure81((), v)),
                        split(v0_1, string("\n"), -1_i32, 0_i32),
                    ),
                ))),
            )
        }
        pub fn closure83(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust / Exception")
        }
        pub fn closure84(
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
        pub fn closure82(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US3 {
            Spiral_builder::method5(
                Spiral_builder::US0::US0_4,
                Func0::new(move || Spiral_builder::closure83((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    move || {
                        Spiral_builder::closure84(
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
        pub fn closure85(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_rust / error")
        }
        pub fn closure86(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / new_code_path: {} / external_command: {} / cargo_run_result: {}",
                v2,
                v0_1,
                v3,
                v1_1
            )
        }
        pub fn method108(v0_1: async_walkdir::DirEntry) -> async_walkdir::DirEntry {
            v0_1
        }
        pub fn closure88(unitVar: (), v0_1: std::fs::FileType) -> Spiral_builder::US37 {
            Spiral_builder::US37::US37_0(v0_1)
        }
        pub fn closure89(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US37 {
            Spiral_builder::US37::US37_1(v0_1)
        }
        pub fn method109(v0_1: std::fs::FileType) -> std::fs::FileType {
            v0_1
        }
        pub fn method110(v0_1: Spiral_builder::US36) -> Spiral_builder::US36 {
            v0_1
        }
        pub fn method107(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = Spiral_builder::US36> + Send>>
        {
            let __result = Box::pin(async move {
                //;
                {
                    let v2: async_walkdir::DirEntry = Spiral_builder::method108(v0_1);
                    let v4: std::pin::Pin<
                        Box<
                            dyn std::future::Future<
                                    Output = Result<std::fs::FileType, std::io::Error>,
                                > + Send,
                        >,
                    > = Box::pin(async_walkdir::DirEntry::file_type(&v2));
                    let v6: Result<std::fs::FileType, std::io::Error> = v4.await;
                    let v7 = Spiral_builder::method47();
                    let v9: Result<std::fs::FileType, std::string::String> = v6.map_err(|x| v7(x));
                    let v12: Spiral_builder::US37 = match &v9 {
                        Err(v9_1_0) => Spiral_builder::closure89((), v9_1_0.clone()),
                        Ok(v9_0_0) => Spiral_builder::closure88((), v9_0_0.clone()),
                    };
                    let v23: Spiral_builder::US36 = Spiral_builder::method110(
                        if let Spiral_builder::US37::US37_0(v12_0_0) = &v12 {
                            let v14: std::fs::FileType = Spiral_builder::method109(match &v12 {
                                Spiral_builder::US37::US37_0(x) => x.clone(),
                                _ => unreachable!(),
                            });
                            if std::fs::FileType::is_dir(&v14) == false {
                                Spiral_builder::US36::US36_0
                            } else {
                                Spiral_builder::US36::US36_2
                            }
                        } else {
                            Spiral_builder::US36::US36_2
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
        pub fn method111(v0_1: async_walkdir::Filtering) -> async_walkdir::Filtering {
            v0_1
        }
        pub fn method106(
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let __result = Box::pin(async {
                //;
                {
                    let v2: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Spiral_builder::US36> + Send>,
                    > = Spiral_builder::method107(v0_1);
                    let v4: Spiral_builder::US36 = v2.await;
                    let v14: async_walkdir::Filtering = Spiral_builder::method111(match &v4 {
                        Spiral_builder::US36::US36_0 => async_walkdir::Filtering::Ignore,
                        Spiral_builder::US36::US36_1 => async_walkdir::Filtering::IgnoreDir,
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
        pub fn closure87(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            Spiral_builder::method106(v0_1)
        }
        pub fn closure91(unitVar: (), v0_1: async_walkdir::DirEntry) -> Spiral_builder::US38 {
            Spiral_builder::US38::US38_0(v0_1)
        }
        pub fn closure92(unitVar: (), v0_1: std::string::String) -> Spiral_builder::US38 {
            Spiral_builder::US38::US38_1(v0_1)
        }
        pub fn closure93(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_typescript / stream_filter_map")
        }
        pub fn closure94(v0_1: std::string::String, unitVar: ()) -> string {
            sprintf!("error: {} / {}", v0_1, Spiral_builder::closure6((), ()))
        }
        pub fn closure90(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, std::io::Error>,
        ) -> Option<(string, string)> {
            let v1_1 = Spiral_builder::method47();
            let v3: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v6: Spiral_builder::US38 = match &v3 {
                Err(v3_1_0) => Spiral_builder::closure92((), v3_1_0.clone()),
                Ok(v3_0_0) => Spiral_builder::closure91((), v3_0_0.clone()),
            };
            let v117: Spiral_builder::US39 = match &v6 {
                Spiral_builder::US38::US38_0(v6_0_0) => {
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
                        let _v79: LrcPtr<MutCell<Option<Spiral_builder::US34>>> =
                            refCell(None::<Spiral_builder::US34>);
                        {
                            let x_6: Option<Spiral_builder::US34> = match &v78 {
                                None => None::<Spiral_builder::US34>,
                                Some(v78_0_0) => {
                                    let x_4: std::collections::HashMap<string, string> =
                                        v78_0_0.clone();
                                    Some((Func0::new({
                                        let x_4 = x_4.clone();
                                        move || Spiral_builder::US34::US34_0(x_4.clone())
                                    }))())
                                }
                            };
                            _v79.set(x_6)
                        }
                        {
                            let v84: Spiral_builder::US34 =
                                defaultValue(Spiral_builder::US34::US34_1, _v79.get().clone());
                            let v98: Spiral_builder::US35 = match &v84 {
                                Spiral_builder::US34::US34_0(v84_0_0) => {
                                    let v86: string = Spiral_builder::method102();
                                    let v88: Option<string> = std::collections::HashMap::get(
                                        &match &v84 {
                                            Spiral_builder::US34::US34_0(x) => x.clone(),
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
                                    Spiral_builder::US35::US35_0(defaultValue(
                                        Spiral_builder::US3::US3_1,
                                        _v89.get().clone(),
                                    ))
                                }
                                _ => Spiral_builder::US35::US35_1,
                            };
                            let v105: Spiral_builder::US3 =
                                if let Spiral_builder::US35::US35_0(v98_0_0) = &v98 {
                                    let v99: Spiral_builder::US3 = match &v98 {
                                        Spiral_builder::US35::US35_0(x) => x.clone(),
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
                                    Spiral_builder::US39::US39_0(
                                        v24,
                                        match &v105 {
                                            Spiral_builder::US3::US3_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        },
                                    )
                                }
                                _ => Spiral_builder::US39::US39_1,
                            }
                        }
                    }
                }
                Spiral_builder::US38::US38_1(v6_1_0) => {
                    Spiral_builder::method5(
                        Spiral_builder::US0::US0_4,
                        Func0::new(move || Spiral_builder::closure93((), ())),
                        Func0::new({
                            let v6 = v6.clone();
                            move || {
                                Spiral_builder::closure94(
                                    match &v6 {
                                        Spiral_builder::US38::US38_1(x) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                    );
                    Spiral_builder::US39::US39_1
                }
            };
            match &v117 {
                Spiral_builder::US39::US39_0(v117_0_0, v117_0_1) => Some((
                    match &v117 {
                        Spiral_builder::US39::US39_0(x, _) => x.clone(),
                        _ => unreachable!(),
                    },
                    match &v117 {
                        Spiral_builder::US39::US39_0(_, x) => x.clone(),
                        _ => unreachable!(),
                    },
                )),
                _ => None::<(string, string)>,
            }
        }
        pub fn method112(
        ) -> Func1<Result<async_walkdir::DirEntry, std::io::Error>, Option<(string, string)>>
        {
            Func1::new(move |v: Result<async_walkdir::DirEntry, std::io::Error>| {
                Spiral_builder::closure90((), v)
            })
        }
        pub fn closure95(unitVar: (), _arg: (string, string)) -> (string, string) {
            (_arg.0.clone(), _arg.1.clone())
        }
        pub fn closure96(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_typescript")
        }
        pub fn closure97(v0_1: Spiral_builder::US39, unitVar: ()) -> string {
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
        pub fn closure98(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "spiral_builder.process_typescript / exit_code: {} / dotnet_fable_result: {}",
                v1_1,
                v0_1
            )
        }
        pub fn closure99(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_typescript")
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
            string("spiral_builder.process_typescript / Exception")
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
            string("spiral_builder.process_typescript / error")
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
        pub fn closure107(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            sprintf!(
                "spiral_builder.process_python / exit_code: {} / dotnet_fable_result: {}",
                v1_1,
                v0_1
            )
        }
        pub fn closure108(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_python")
        }
        pub fn closure109(v0_1: string, unitVar: ()) -> string {
            sprintf!(
                "new_code_path: {} / {}",
                v0_1,
                Spiral_builder::closure6((), ())
            )
        }
        pub fn closure110(v0_1: string, unitVar: ()) -> string {
            join(
                string("\n"),
                toArray_1(ofArray_1(split(v0_1, string("\n"), -1_i32, 0_i32))),
            )
        }
        pub fn closure112(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_python / Exception")
        }
        pub fn closure113(
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
        pub fn closure111(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: LrcPtr<Exception>,
        ) -> Spiral_builder::US3 {
            Spiral_builder::method5(
                Spiral_builder::US0::US0_4,
                Func0::new(move || Spiral_builder::closure112((), ())),
                Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    move || {
                        Spiral_builder::closure113(
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
        pub fn closure114(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.process_python / error")
        }
        pub fn closure115(v0_1: string, v1_1: string, v2: i32, v3: string, unitVar: ()) -> string {
            sprintf!(
                "exit_code: {} / new_code_path: {} / external_command: {} / run_result: {}",
                v2,
                v0_1,
                v3,
                v1_1
            )
        }
        pub fn closure116(unitVar: (), unitVar_1: ()) -> string {
            string("spiral_builder.run / invalid subcommand")
        }
        pub fn closure117(
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
        pub fn closure118(
            unitVar: (),
            _arg: (string, string),
        ) -> LrcPtr<(std::string::String, std::string::String)> {
            let v3: &str = &*_arg.0.clone();
            let v5: std::string::String = String::from(v3);
            let v7: &str = &*_arg.1.clone();
            LrcPtr::new((v5, String::from(v7)))
        }
        pub fn closure119(unitVar: (), v0_1: serde_json::Error) -> string {
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
        pub fn method113() -> Func1<serde_json::Error, string> {
            Func1::new(move |v: serde_json::Error| Spiral_builder::closure119((), v))
        }
        pub fn method114(v0_1: Result<string, string>) -> Result<string, string> {
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
                        let v2092: Array<(string, string)> = if let Spiral_builder::US4::US4_0(
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
                                == string("cuda")
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
                                        let v74: Spiral_builder::US6 = match &v46 {
                                            Spiral_builder::US5::US5_0(v46_0_0) => {
                                                let v49: string =
                                                    fable_library_rust::String_::fromString(
                                                        match &v46 {
                                                            Spiral_builder::US5::US5_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        },
                                                    );
                                                let v55: Spiral_builder::US7 =
                                                    if string("Pip") == v49.clone() {
                                                        Spiral_builder::US7::US7_0(
                                                            Spiral_builder::US8::US8_0,
                                                        )
                                                    } else {
                                                        Spiral_builder::US7::US7_1
                                                    };
                                                Spiral_builder::US6::US6_0(match &v55 {
                                                    Spiral_builder::US7::US7_0(v55_0_0) => {
                                                        Spiral_builder::US7::US7_0(match &v55 {
                                                            Spiral_builder::US7::US7_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        })
                                                    }
                                                    _ => {
                                                        let v63: Spiral_builder::US7 =
                                                            if string("Poetry") == v49 {
                                                                Spiral_builder::US7::US7_0(
                                                                    Spiral_builder::US8::US8_1,
                                                                )
                                                            } else {
                                                                Spiral_builder::US7::US7_1
                                                            };
                                                        match &v63
                                                                                           {
                                                                                           Spiral_builder::US7::US7_0(v63_0_0)
                                                                                           =>
                                                                                           Spiral_builder::US7::US7_0(match &v63
                                                                                                                          {
                                                                                                                          Spiral_builder::US7::US7_0(x)
                                                                                                                          =>
                                                                                                                          x.clone(),
                                                                                                                          _
                                                                                                                          =>
                                                                                                                          unreachable!(),
                                                                                                                      }),
                                                                                           _
                                                                                           =>
                                                                                           Spiral_builder::US7::US7_1,
                                                                                       }
                                                    }
                                                })
                                            }
                                            _ => Spiral_builder::US6::US6_1,
                                        };
                                        let v81: Spiral_builder::US7 =
                                            if let Spiral_builder::US6::US6_0(v74_0_0) = &v74 {
                                                let v75: Spiral_builder::US7 = match &v74 {
                                                    Spiral_builder::US6::US6_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                };
                                                if let Spiral_builder::US7::US7_0(v75_0_0) = &v75 {
                                                    Spiral_builder::US7::US7_0(match &v75 {
                                                        Spiral_builder::US7::US7_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    })
                                                } else {
                                                    Spiral_builder::US7::US7_1
                                                }
                                            } else {
                                                Spiral_builder::US7::US7_1
                                            };
                                        let v85: Spiral_builder::US8 = match &v81 {
                                            Spiral_builder::US7::US7_0(v81_0_0) => match &v81 {
                                                Spiral_builder::US7::US7_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => Spiral_builder::US8::US8_0,
                                        };
                                        let v86: string = Spiral_builder::method13();
                                        let v88: &str = &*v86;
                                        let v90: Option<Vec<std::string::String>> =
                                            clap::ArgMatches::get_many(&v14.clone(), v88)
                                                .map(|x| x.cloned().into_iter().collect());
                                        let _v91: LrcPtr<MutCell<Option<Spiral_builder::US9>>> =
                                            refCell(None::<Spiral_builder::US9>);
                                        {
                                            let x_11: Option<Spiral_builder::US9> = match &v90 {
                                                None => None::<Spiral_builder::US9>,
                                                Some(v90_0_0) => {
                                                    let x_9: Vec<std::string::String> =
                                                        v90_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_9 = x_9.clone();
                                                        move || {
                                                            Spiral_builder::US9::US9_0(x_9.clone())
                                                        }
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v91.set(x_11)
                                        }
                                        {
                                            let v96: Spiral_builder::US9 = defaultValue(
                                                Spiral_builder::US9::US9_1,
                                                _v91.get().clone(),
                                            );
                                            let v99: Vec<std::string::String> =
                                                new_empty::<std::string::String>().to_vec();
                                            let v102: Vec<std::string::String> = match &v96 {
                                                Spiral_builder::US9::US9_0(v96_0_0) => match &v96 {
                                                    Spiral_builder::US9::US9_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                },
                                                _ => v99,
                                            };
                                            let _v103: MutCell<Option<string>> =
                                                MutCell::new(None::<string>);
                                            let _v104: MutCell<Option<Vec<u8>>> =
                                                MutCell::new(None::<Vec<u8>>);
                                            {
                                                let x_12: Vec<u8> =
                                                    std::fs::read(&*v35.clone()).unwrap();
                                                _v104.set(Some(x_12))
                                            }
                                            {
                                                let v114: Vec<u8> = match &_v104.get().clone() {
                                                    None => panic!(
                                                        "{}",
                                                        string("base.run_target / _v104=None"),
                                                    ),
                                                    Some(_v104_0_0) => _v104_0_0.clone(),
                                                };
                                                let v116: Result<
                                                    std::string::String,
                                                    std::string::FromUtf8Error,
                                                > = std::string::String::from_utf8(v114);
                                                let v118: std::string::String = v116.unwrap();
                                                {
                                                    let x_14: string =
                                                        fable_library_rust::String_::fromString(
                                                            v118,
                                                        );
                                                    _v103.set(Some(x_14))
                                                }
                                                {
                                                    let v126: string = match &_v103.get().clone() {
                                                        None => panic!(
                                                            "{}",
                                                            string("base.run_target / _v103=None"),
                                                        ),
                                                        Some(_v103_0_0) => _v103_0_0.clone(),
                                                    };
                                                    let v132: string =
                                                        Spiral_builder::method14(Spiral_builder::method17(Spiral_builder::method14(string("polyglot"),
                                                                                                                                   string(".paket")),
                                                                                                          string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder")),
                                                                                 string("polyglot"));
                                                    let v135: string =
                                                        toLower(Spiral_builder::method22());
                                                    let v137: string = toLower(v132);
                                                    let v141: Spiral_builder::US12 =
                                                        if startsWith(v135, v137.clone(), false) {
                                                            Spiral_builder::US12::US12_1(
                                                                v137.clone(),
                                                            )
                                                        } else {
                                                            Spiral_builder::US12::US12_0(v137)
                                                        };
                                                    let v147: Result<string, string> = match &v141 {
                                                        Spiral_builder::US12::US12_0(v141_0_0) => {
                                                            Ok::<string, string>(v141_0_0.clone())
                                                        }
                                                        Spiral_builder::US12::US12_1(v141_1_0) => {
                                                            Err::<string, string>(v141_1_0.clone())
                                                        }
                                                    };
                                                    let v149: bool = true;
                                                    let _result = v147.unwrap_or_else(|x| {
                                                        //;
                                                        let v151: string = x;
                                                        let v153: bool = true;
                                                        v151
                                                    });
                                                    let v155: string = _result;
                                                    let v156: string =
                                                        Spiral_builder::method23(v35.clone());
                                                    let v162: string = match &v85 {
                                                        Spiral_builder::US8::US8_1 => {
                                                            Spiral_builder::method14(
                                                                v156.clone(),
                                                                string("pyproject.toml"),
                                                            )
                                                        }
                                                        _ => Spiral_builder::method14(
                                                            v156.clone(),
                                                            string("requirements.txt"),
                                                        ),
                                                    };
                                                    let v164: bool = true;
                                                    let _result : Vec<_> = v102.into_iter().map(|x| { //;
                                                    let v166:
                                                            std::string::String =
                                                        x;
                                                    let v168: string =
                                                        fable_library_rust::String_::fromString(v166);
                                                    let v179: string =
                                                        if contains(v168.clone(),
                                                                    string("="))
                                                           {
                                                            v168.clone()
                                                        } else {
                                                            if endsWith(v168.clone(),
                                                                        string("]"),
                                                                        false)
                                                               {
                                                                sprintf!("{}}}",
                                                                         replace(v168.clone(),
                                                                                 string("["),
                                                                                 string("={version=\'*\',features=[")))
                                                            } else {
                                                                sprintf!("{}=\'*\'",
                                                                         v168)
                                                            }
                                                        };
                                                    let v181: bool =
                                                        true; v179 }).collect::<Vec<_>>();
                                                    let v183: Vec<string> = _result;
                                                    let v185: Array<string> =
                                                        fable_library_rust::NativeArray_::array_from(v183);
                                                    let v190: string = join(
                                                        string("\n"),
                                                        toArray_1(delay(Func0::new({
                                                            let v185 = v185.clone();
                                                            move || {
                                                                map(
                                                                    Func1::new({
                                                                        let v185 = v185.clone();
                                                                        move |i: i32| {
                                                                            v185[i].clone()
                                                                        }
                                                                    }),
                                                                    rangeNumeric(
                                                                        0_i32,
                                                                        1_i32,
                                                                        count_2(v185.clone())
                                                                            - 1_i32,
                                                                    ),
                                                                )
                                                            }
                                                        }))),
                                                    );
                                                    let patternInput: (i32, string) = if v190
                                                        .clone()
                                                        == string("")
                                                    {
                                                        (0_i32, string(""))
                                                    } else {
                                                        Spiral_builder::method24(v162,
                                                                                     match &v85
                                                                                         {
                                                                                         Spiral_builder::US8::US8_1
                                                                                         =>
                                                                                         append(append(append(append(append(append(append(append(append(string("[tool.poetry]\nname = \"test\"\nversion = \"0.0.1\"\ndescription = \"\"\nauthors = []\n\n[tool.poetry.dependencies]\npython=\"~3.12\"\n"),
                                                                                                                                                        sprintf!("{}",
                                                                                                                                                                 v190.clone())),
                                                                                                                                                 string("\n")),
                                                                                                                                          string("")),
                                                                                                                                   string("\n")),
                                                                                                                            string("[build-system]")),
                                                                                                                     string("\n")),
                                                                                                              string("requires = [\"poetry-core\"]")),
                                                                                                       string("\n")),
                                                                                                string("build-backend = \"poetry.core.masonry.api\"")),
                                                                                         _
                                                                                         =>
                                                                                         v190.clone(),
                                                                                     });
                                                        Spiral_builder::method28(None::<CancellationToken>,
                                                                                     match &v85
                                                                                         {
                                                                                         Spiral_builder::US8::US8_1
                                                                                         =>
                                                                                         string("poetry install"),
                                                                                         _
                                                                                         =>
                                                                                         string("pip install -r requirements.txt"),
                                                                                     },
                                                                                     new_empty::<(string,
                                                                                                  string)>(),
                                                                                     None::<Func1<(bool,
                                                                                                   string,
                                                                                                   i32),
                                                                                                  Arc<Async<()>>>>,
                                                                                     None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                  ()>>,
                                                                                     true,
                                                                                     Some(v156.clone()))
                                                    };
                                                    let v246: i32 = patternInput.0.clone();
                                                    let patternInput_3: (
                                                        Spiral_builder::US3,
                                                        Spiral_builder::US3,
                                                        Spiral_builder::US3,
                                                    ) = if v246 != 0_i32 {
                                                        Spiral_builder::method5(
                                                            Spiral_builder::US0::US0_4,
                                                            Func0::new(move || {
                                                                Spiral_builder::closure40((), ())
                                                            }),
                                                            Func0::new({
                                                                let patternInput =
                                                                    patternInput.clone();
                                                                let v246 = v246.clone();
                                                                let v35 = v35.clone();
                                                                let v85 = v85.clone();
                                                                move || {
                                                                    Spiral_builder::closure41(
                                                                        v85.clone(),
                                                                        v35.clone(),
                                                                        patternInput.1.clone(),
                                                                        v246,
                                                                        (),
                                                                    )
                                                                }
                                                            }),
                                                        );
                                                        (
                                                            Spiral_builder::US3::US3_1,
                                                            Spiral_builder::US3::US3_0(string(
                                                                "py",
                                                            )),
                                                            Spiral_builder::US3::US3_1,
                                                        )
                                                    } else {
                                                        let v259: string = match &v85 {
                                                            Spiral_builder::US8::US8_1 => sprintf!(
                                                                "poetry run python \"{}\"",
                                                                v35.clone()
                                                            ),
                                                            _ => sprintf!(
                                                                "python \"{}\"",
                                                                v35.clone()
                                                            ),
                                                        };
                                                        let v262: Array<(string, string)> =
                                                            new_array(&[(
                                                                string("TRACE_LEVEL"),
                                                                string("Verbose"),
                                                            )]);
                                                        let patternInput_1:
                                                                    (i32,
                                                                     string) =
                                                                Spiral_builder::method28(None::<CancellationToken>,
                                                                                         v259.clone(),
                                                                                         v262.clone(),
                                                                                         None::<Func1<(bool,
                                                                                                       string,
                                                                                                       i32),
                                                                                                      Arc<Async<()>>>>,
                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                      ()>>,
                                                                                         true,
                                                                                         Some(v156.clone()));
                                                        let v271: string = patternInput_1.1.clone();
                                                        let v270: i32 = patternInput_1.0.clone();
                                                        let v272: i32 = count_2(v262.clone());
                                                        let v273: Array<string> =
                                                            new_init(&string(""), v272);
                                                        let v274: LrcPtr<Spiral_builder::Mut4> =
                                                            LrcPtr::new(Spiral_builder::Mut4 {
                                                                l0: MutCell::new(0_i32),
                                                            });
                                                        while Spiral_builder::method32(
                                                            v272,
                                                            v274.clone(),
                                                        ) {
                                                            let v276: i32 = v274.l0.get().clone();
                                                            let patternInput_2: (string, string) =
                                                                v262[v276].clone();
                                                            let v279: string = sprintf!(
                                                                "$env:{}=\'\'{}\'\'",
                                                                patternInput_2.0.clone(),
                                                                patternInput_2.1.clone()
                                                            );
                                                            v273.get_mut()[v276 as usize] = v279;
                                                            {
                                                                let v280: i32 = v276 + 1_i32;
                                                                v274.l0.set(v280);
                                                                ()
                                                            }
                                                        }
                                                        {
                                                            let v287: string = sprintf!(
                                                                "pwsh -c \'{}; {}\'",
                                                                join(
                                                                    string(";"),
                                                                    toArray_1(ofArray_1(
                                                                        v273.clone()
                                                                    ))
                                                                ),
                                                                v259
                                                            );
                                                            if v270 == 0_i32 {
                                                                let v292: Spiral_builder::US3 =
                                                                    try_catch(
                                                                        || {
                                                                            Spiral_builder::closure43((),
                                                                                                                Spiral_builder::closure42(v271.clone(),
                                                                                                                                          ()))
                                                                        },
                                                                        |ex: LrcPtr<Exception>| {
                                                                            Spiral_builder::closure44(v35.clone(),
                                                                                                                v271.clone(),
                                                                                                                v287.clone(),
                                                                                                                ex.clone())
                                                                        },
                                                                    );
                                                                let v297:
                                                                            Option<string> =
                                                                        match &v292
                                                                            {
                                                                            Spiral_builder::US3::US3_0(v292_0_0)
                                                                            =>
                                                                            Some(match &v292
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
                                                                (
                                                                    Spiral_builder::US3::US3_0(
                                                                        v126,
                                                                    ),
                                                                    Spiral_builder::US3::US3_0(
                                                                        string("py"),
                                                                    ),
                                                                    Spiral_builder::US3::US3_0(
                                                                        v297.unwrap(),
                                                                    ),
                                                                )
                                                            } else {
                                                                Spiral_builder::method5(
                                                                    Spiral_builder::US0::US0_4,
                                                                    Func0::new(move || {
                                                                        Spiral_builder::closure47(
                                                                            (),
                                                                            (),
                                                                        )
                                                                    }),
                                                                    Func0::new({
                                                                        let v270 = v270.clone();
                                                                        let v271 = v271.clone();
                                                                        let v287 = v287.clone();
                                                                        let v35 = v35.clone();
                                                                        move || {
                                                                            Spiral_builder::closure48(v35.clone(),
                                                                                                                                         v271.clone(),
                                                                                                                                         v270,
                                                                                                                                         v287.clone(),
                                                                                                                                         ())
                                                                        }
                                                                    }),
                                                                );
                                                                (
                                                                    Spiral_builder::US3::US3_1,
                                                                    Spiral_builder::US3::US3_0(
                                                                        string("py"),
                                                                    ),
                                                                    Spiral_builder::US3::US3_1,
                                                                )
                                                            }
                                                        }
                                                    };
                                                    let v316: Spiral_builder::US3 =
                                                        patternInput_3.2.clone();
                                                    let v315: Spiral_builder::US3 =
                                                        patternInput_3.1.clone();
                                                    let v314: Spiral_builder::US3 =
                                                        patternInput_3.0.clone();
                                                    let v332:
                                                            Array<(string,
                                                                   string)> =
                                                        new_array(&[(string("extension"),
                                                                     match &v315
                                                                         {
                                                                         Spiral_builder::US3::US3_0(v315_0_0)
                                                                         =>
                                                                         match &v315
                                                                             {
                                                                             Spiral_builder::US3::US3_0(x)
                                                                             =>
                                                                             x.clone(),
                                                                             _
                                                                             =>
                                                                             unreachable!(),
                                                                         },
                                                                         _ =>
                                                                         string(""),
                                                                     }),
                                                                    (string("code"),
                                                                     match &v314
                                                                         {
                                                                         Spiral_builder::US3::US3_0(v314_0_0)
                                                                         =>
                                                                         match &v314
                                                                             {
                                                                             Spiral_builder::US3::US3_0(x)
                                                                             =>
                                                                             x.clone(),
                                                                             _
                                                                             =>
                                                                             unreachable!(),
                                                                         },
                                                                         _ =>
                                                                         string(""),
                                                                     }),
                                                                    (string("output"),
                                                                     match &v316
                                                                         {
                                                                         Spiral_builder::US3::US3_0(v316_0_0)
                                                                         =>
                                                                         match &v316
                                                                             {
                                                                             Spiral_builder::US3::US3_0(x)
                                                                             =>
                                                                             x.clone(),
                                                                             _
                                                                             =>
                                                                             unreachable!(),
                                                                         },
                                                                         _ =>
                                                                         string(""),
                                                                     })]);
                                                    let v334: Vec<(string, string)> = v332.to_vec();
                                                    let v337:
                                                            Vec<LrcPtr<(std::string::String,
                                                                        std::string::String)>> =
                                                        v334.into_iter().map(|x| Func1::new(move
                                                                                                |arg10_0040_5:
                                                                                                     (string,
                                                                                                      string)|
                                                                                                Spiral_builder::closure49((),
                                                                                                                          arg10_0040_5))(x.clone())).collect::<Vec<_>>();
                                                    let v338: string =
                                                        string("std::collections::BTreeMap::from_iter(v337.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                                                    let v339: std::collections::BTreeMap<
                                                        std::string::String,
                                                        std::string::String,
                                                    > = std::collections::BTreeMap::from_iter(
                                                        v337.iter().map(|x| x.as_ref()).map(
                                                            |&(ref k, ref v)| {
                                                                (k.clone(), v.clone())
                                                            },
                                                        ),
                                                    );
                                                    let v341: Result<
                                                        std::string::String,
                                                        serde_json::Error,
                                                    > = serde_json::to_string(&v339);
                                                    let v343: std::string::String = v341.unwrap();
                                                    new_array(&[(
                                                        string("command_result"),
                                                        fable_library_rust::String_::fromString(
                                                            v343,
                                                        ),
                                                    )])
                                                }
                                            }
                                        }
                                    }
                                }
                            } else {
                                if fable_library_rust::String_::fromString(v13.clone())
                                    == string("fable")
                                {
                                    let v352: string = Spiral_builder::method63();
                                    let v354: &str = &*v352;
                                    let v356: Option<std::string::String> =
                                        clap::ArgMatches::get_one(&v14.clone(), v354).cloned();
                                    let _v357: LrcPtr<MutCell<Option<Spiral_builder::US5>>> =
                                        refCell(None::<Spiral_builder::US5>);
                                    {
                                        let x_18: Option<Spiral_builder::US5> = match &v356 {
                                            None => None::<Spiral_builder::US5>,
                                            Some(v356_0_0) => {
                                                let x_16: std::string::String = v356_0_0.clone();
                                                Some((Func0::new({
                                                    let x_16 = x_16.clone();
                                                    move || Spiral_builder::US5::US5_0(x_16.clone())
                                                }))(
                                                ))
                                            }
                                        };
                                        _v357.set(x_18)
                                    }
                                    {
                                        let v362: Spiral_builder::US5 = defaultValue(
                                            Spiral_builder::US5::US5_1,
                                            _v357.get().clone(),
                                        );
                                        let v366: std::string::String = match &v362 {
                                            Spiral_builder::US5::US5_0(v362_0_0) => match &v362 {
                                                Spiral_builder::US5::US5_0(x) => x.clone(),
                                                _ => unreachable!(),
                                            },
                                            _ => panic!(
                                                "{}",
                                                string("Option does not have a value."),
                                            ),
                                        };
                                        let v368: string =
                                            fable_library_rust::String_::fromString(v366);
                                        let v369: string = Spiral_builder::method64();
                                        let v371: &str = &*v369;
                                        let v373: Option<std::string::String> =
                                            clap::ArgMatches::get_one(&v14.clone(), v371).cloned();
                                        let _v374: LrcPtr<MutCell<Option<Spiral_builder::US5>>> =
                                            refCell(None::<Spiral_builder::US5>);
                                        {
                                            let x_21: Option<Spiral_builder::US5> = match &v373 {
                                                None => None::<Spiral_builder::US5>,
                                                Some(v373_0_0) => {
                                                    let x_19: std::string::String =
                                                        v373_0_0.clone();
                                                    Some((Func0::new({
                                                        let x_19 = x_19.clone();
                                                        move || {
                                                            Spiral_builder::US5::US5_0(x_19.clone())
                                                        }
                                                    }))(
                                                    ))
                                                }
                                            };
                                            _v374.set(x_21)
                                        }
                                        {
                                            let v379: Spiral_builder::US5 = defaultValue(
                                                Spiral_builder::US5::US5_1,
                                                _v374.get().clone(),
                                            );
                                            let v386: Spiral_builder::US3 = match &v379 {
                                                Spiral_builder::US5::US5_0(v379_0_0) => {
                                                    Spiral_builder::US3::US3_0(
                                                        fable_library_rust::String_::fromString(
                                                            match &v379 {
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
                                                match &v386 {
                                                    Spiral_builder::US3::US3_0(v386_0_0) => {
                                                        let v388: clap::Command =
                                                            Spiral_builder::method0();
                                                        let v390: Spiral_builder::US15 =
                                                            Spiral_builder::method35(sprintf!(
                                                                "_ {} --fs-path \"{}\"",
                                                                match &v386 {
                                                                    Spiral_builder::US3::US3_0(
                                                                        x,
                                                                    ) => x.clone(),
                                                                    _ => unreachable!(),
                                                                },
                                                                v368
                                                            ));
                                                        let v396:
                                                                         Array<string> =
                                                                     match &v390
                                                                         {
                                                                         Spiral_builder::US15::US15_0(v390_0_0)
                                                                         =>
                                                                         v390_0_0.clone(),
                                                                         Spiral_builder::US15::US15_1(v390_1_0)
                                                                         =>
                                                                         panic!("{}",
                                                                                sprintf!("resultm.get / Result value was Error: {}", v390_1_0.clone()),),
                                                                     };
                                                        let v398: Vec<string> = v396.to_vec();
                                                        let v400: bool = true;
                                                        let _result: Vec<_> = v398
                                                            .into_iter()
                                                            .map(|x| {
                                                                //;
                                                                let v402: string = x;
                                                                let v404: &str = &*v402;
                                                                let v406: std::string::String =
                                                                    String::from(v404);
                                                                let v408: bool = true;
                                                                v406
                                                            })
                                                            .collect::<Vec<_>>();
                                                        let v410: Vec<std::string::String> =
                                                            _result;
                                                        let v413: std::pin::Pin<
                                                            Box<
                                                                dyn std::future::Future<
                                                                    Output = Result<string, string>,
                                                                >,
                                                            >,
                                                        > = Spiral_builder::method10(
                                                            v0_1.clone(),
                                                            clap::Command::get_matches_from(
                                                                v388, v410,
                                                            ),
                                                        );
                                                        let v415: Result<string, string> =
                                                            v413.await;
                                                        v415.unwrap()
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
                                        let v427: string = Spiral_builder::method65();
                                        let v429: &str = &*v427;
                                        let v433: Option<string> = map_1(
                                            Func1::new(move |v_3: std::string::String| {
                                                Spiral_builder::closure50((), v_3)
                                            }),
                                            clap::ArgMatches::get_one(&v14.clone(), v429).cloned(),
                                        );
                                        let v435: string = v433.unwrap();
                                        let v436: string = Spiral_builder::method77();
                                        let v438: &str = &*v436;
                                        let v441: u8 = defaultValue(
                                            1_u8,
                                            clap::ArgMatches::get_one(&v14.clone(), v438).cloned(),
                                        );
                                        let v442: string = Spiral_builder::method78();
                                        let v444: &str = &*v442;
                                        let patternInput_4: (i32, string) =
                                            Spiral_builder::method79(
                                                clap::ArgMatches::get_one(&v14.clone(), v444)
                                                    .cloned(),
                                                v441,
                                                v435.clone(),
                                                1_u8,
                                            );
                                        let v449: string = patternInput_4.1.clone();
                                        let v448: i32 = patternInput_4.0.clone();
                                        let patternInput_7: (i32, string) = if v448 != 0_i32 {
                                            (v448, v449.clone())
                                        } else {
                                            let patternInput_5:
                                                        (i32, string) =
                                                    Spiral_builder::method28(None::<CancellationToken>,
                                                                             sprintf!("jupyter nbconvert \"{}.ipynb\" --to html --HTMLExporter.theme=dark",
                                                                                      v435.clone()),
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
                                            let v459: string = patternInput_5.1.clone();
                                            let v458: i32 = patternInput_5.0.clone();
                                            Spiral_builder::method5(
                                                Spiral_builder::US0::US0_1,
                                                Func0::new(move || {
                                                    Spiral_builder::closure53((), ())
                                                }),
                                                Func0::new({
                                                    let v458 = v458.clone();
                                                    let v459 = v459.clone();
                                                    move || {
                                                        Spiral_builder::closure54(
                                                            v459.clone(),
                                                            v458,
                                                            (),
                                                        )
                                                    }
                                                }),
                                            );
                                            if v458 != 0_i32 {
                                                (
                                                    v458,
                                                    sprintf!(
                                                        "repl_result: {}\n\njupyter_result: {}",
                                                        v449.clone(),
                                                        v459.clone()
                                                    ),
                                                )
                                            } else {
                                                let patternInput_6:
                                                            (i32, string) =
                                                        Spiral_builder::method28(None::<CancellationToken>,
                                                                                 sprintf!("pwsh -c \"$counter = 1; $path = \'{}.html\'; (Get-Content $path -Raw) -replace \'(id=\\\"cell-id=)[a-fA-F0-9]{{8}}\', {{ $_.Groups[1].Value + $counter++ }} | Set-Content $path\"",
                                                                                          replace(v435.clone(),
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
                                                let v476: string = patternInput_6.1.clone();
                                                let v475: i32 = patternInput_6.0.clone();
                                                Spiral_builder::method5(
                                                    Spiral_builder::US0::US0_1,
                                                    Func0::new(move || {
                                                        Spiral_builder::closure55((), ())
                                                    }),
                                                    Func0::new({
                                                        let v475 = v475.clone();
                                                        let v476 = v476.clone();
                                                        move || {
                                                            Spiral_builder::closure56(
                                                                v476.clone(),
                                                                v475,
                                                                (),
                                                            )
                                                        }
                                                    }),
                                                );
                                                {
                                                    let v480: string =
                                                        sprintf!("{}.html", v435.clone());
                                                    let _v481: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let _v482: MutCell<Option<Vec<u8>>> =
                                                        MutCell::new(None::<Vec<u8>>);
                                                    {
                                                        let x_22: Vec<u8> =
                                                            std::fs::read(&*v480).unwrap();
                                                        _v482.set(Some(x_22))
                                                    }
                                                    {
                                                        let v492: Vec<u8> = match &_v482
                                                            .get()
                                                            .clone()
                                                        {
                                                            None => panic!(
                                                                "{}",
                                                                string(
                                                                    "base.run_target / _v482=None"
                                                                ),
                                                            ),
                                                            Some(_v482_0_0) => _v482_0_0.clone(),
                                                        };
                                                        let v494: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v492);
                                                        let v496: std::string::String =
                                                            v494.unwrap();
                                                        {
                                                            let x_24:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v496);
                                                            _v481.set(Some(x_24))
                                                        }
                                                        {
                                                            let v507:
                                                                        string =
                                                                    replace(match &_v481.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v481=None"),),
                                                                                Some(_v481_0_0)
                                                                                =>
                                                                                _v481_0_0.clone(),
                                                                            },
                                                                            string("\r\n"),
                                                                            string("\n"));
                                                            let v508: string =
                                                                sprintf!("{}.html", v435.clone());
                                                            let _v509: MutCell<Option<()>> =
                                                                MutCell::new(None::<()>);
                                                            std::fs::write(&*v508, &*v507).unwrap();
                                                            _v509.set(Some(()));
                                                            match &_v509.get().clone()
                                                                    {
                                                                    None =>
                                                                    panic!("{}",
                                                                           string("base.run_target / _v509=None"),),
                                                                    Some(_v509_0_0)
                                                                    =>
                                                                    _v509_0_0.clone(),
                                                                }
                                                            {
                                                                let v512: string = sprintf!(
                                                                    "{}.ipynb",
                                                                    v435.clone()
                                                                );
                                                                let _v513: MutCell<Option<string>> =
                                                                    MutCell::new(None::<string>);
                                                                let _v514: MutCell<
                                                                    Option<Vec<u8>>,
                                                                > = MutCell::new(None::<Vec<u8>>);
                                                                {
                                                                    let x_28: Vec<u8> =
                                                                        std::fs::read(&*v512)
                                                                            .unwrap();
                                                                    _v514.set(Some(x_28))
                                                                }
                                                                {
                                                                    let v524:
                                                                                Vec<u8> =
                                                                            match &_v514.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v514=None"),),
                                                                                Some(_v514_0_0)
                                                                                =>
                                                                                _v514_0_0.clone(),
                                                                            };
                                                                    let v526:
                                                                                Result<std::string::String,
                                                                                       std::string::FromUtf8Error> =
                                                                            std::string::String::from_utf8(v524);
                                                                    let v528: std::string::String =
                                                                        v526.unwrap();
                                                                    {
                                                                        let x_30:
                                                                                    string =
                                                                                fable_library_rust::String_::fromString(v528);
                                                                        _v513.set(Some(x_30))
                                                                    }
                                                                    {
                                                                        let v539:
                                                                                    string =
                                                                                replace(match &_v513.get().clone()
                                                                                            {
                                                                                            None
                                                                                            =>
                                                                                            panic!("{}",
                                                                                                   string("base.run_target / _v513=None"),),
                                                                                            Some(_v513_0_0)
                                                                                            =>
                                                                                            _v513_0_0.clone(),
                                                                                        },
                                                                                        string("\\r\\n"),
                                                                                        string("\\n"));
                                                                        let v540: string = sprintf!(
                                                                            "{}.ipynb", v435
                                                                        );
                                                                        let _v541: MutCell<
                                                                            Option<()>,
                                                                        > = MutCell::new(
                                                                            None::<()>,
                                                                        );
                                                                        std::fs::write(
                                                                            &*v540, &*v539,
                                                                        )
                                                                        .unwrap();
                                                                        _v541.set(Some(()));
                                                                        match &_v541.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v541=None"),),
                                                                                Some(_v541_0_0)
                                                                                =>
                                                                                _v541_0_0.clone(),
                                                                            }
                                                                        (v475,
                                                                             sprintf!("repl_result: {}\n\njupyter_result: {}\n\npwsh_replace_html_result: {}",
                                                                                      v449,
                                                                                      v459.clone(),
                                                                                      v476.clone()))
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        };
                                        let v548: string = patternInput_7.1.clone();
                                        let v547: i32 = patternInput_7.0.clone();
                                        Spiral_builder::method5(
                                            Spiral_builder::US0::US0_1,
                                            Func0::new(move || Spiral_builder::closure57((), ())),
                                            Func0::new({
                                                let v547 = v547.clone();
                                                let v548 = v548.clone();
                                                move || {
                                                    Spiral_builder::closure58(
                                                        v548.clone(),
                                                        v547,
                                                        (),
                                                    )
                                                }
                                            }),
                                        );
                                        if v547 != 0_i32 {
                                            panic!("{}",
                                                   sprintf!("spiral_builder.run / dib / exit_code: {} / result: {} / {}", v547,
         v548.clone(), Spiral_builder::closure6((), ())));
                                        }
                                        new_array(&[(string("stdio"), v548.clone())])
                                    } else {
                                        let patternInput_18: (
                                            Spiral_builder::US3,
                                            Spiral_builder::US3,
                                            Spiral_builder::US3,
                                        ) = if fable_library_rust::String_::fromString(v13.clone())
                                            == string("rust")
                                        {
                                            let v561: string = Spiral_builder::method63();
                                            let v563: &str = &*v561;
                                            let v565: Option<std::string::String> =
                                                clap::ArgMatches::get_one(&v14.clone(), v563)
                                                    .cloned();
                                            let _v566: LrcPtr<
                                                MutCell<Option<Spiral_builder::US5>>,
                                            > = refCell(None::<Spiral_builder::US5>);
                                            {
                                                let x_36: Option<Spiral_builder::US5> = match &v565
                                                {
                                                    None => None::<Spiral_builder::US5>,
                                                    Some(v565_0_0) => {
                                                        let x_34: std::string::String =
                                                            v565_0_0.clone();
                                                        Some((Func0::new({
                                                            let x_34 = x_34.clone();
                                                            move || {
                                                                Spiral_builder::US5::US5_0(
                                                                    x_34.clone(),
                                                                )
                                                            }
                                                        }))(
                                                        ))
                                                    }
                                                };
                                                _v566.set(x_36)
                                            }
                                            {
                                                let v571: Spiral_builder::US5 = defaultValue(
                                                    Spiral_builder::US5::US5_1,
                                                    _v566.get().clone(),
                                                );
                                                let v575: std::string::String = match &v571 {
                                                    Spiral_builder::US5::US5_0(v571_0_0) => {
                                                        match &v571 {
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
                                                let v577: string =
                                                    fable_library_rust::String_::fromString(v575);
                                                let v578: string = Spiral_builder::method13();
                                                let v580: &str = &*v578;
                                                let v582: Option<Vec<std::string::String>> =
                                                    clap::ArgMatches::get_many(&v14.clone(), v580)
                                                        .map(|x| x.cloned().into_iter().collect());
                                                let _v583: LrcPtr<
                                                    MutCell<Option<Spiral_builder::US9>>,
                                                > = refCell(None::<Spiral_builder::US9>);
                                                {
                                                    let x_39: Option<Spiral_builder::US9> =
                                                        match &v582 {
                                                            None => None::<Spiral_builder::US9>,
                                                            Some(v582_0_0) => {
                                                                let x_37: Vec<std::string::String> =
                                                                    v582_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_37 = x_37.clone();
                                                                    move || {
                                                                        Spiral_builder::US9::US9_0(
                                                                            x_37.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                    _v583.set(x_39)
                                                }
                                                {
                                                    let v588: Spiral_builder::US9 = defaultValue(
                                                        Spiral_builder::US9::US9_1,
                                                        _v583.get().clone(),
                                                    );
                                                    let v591: Vec<std::string::String> =
                                                        new_empty::<std::string::String>().to_vec();
                                                    let v594: Vec<std::string::String> = match &v588
                                                    {
                                                        Spiral_builder::US9::US9_0(v588_0_0) => {
                                                            match &v588 {
                                                                Spiral_builder::US9::US9_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                        }
                                                        _ => v591,
                                                    };
                                                    let v596: bool =
                                                        if let Spiral_builder::US0::US0_0 = &v0_1 {
                                                            true
                                                        } else {
                                                            false
                                                        };
                                                    let _v597: MutCell<Option<string>> =
                                                        MutCell::new(None::<string>);
                                                    let _v598: MutCell<Option<Vec<u8>>> =
                                                        MutCell::new(None::<Vec<u8>>);
                                                    {
                                                        let x_40: Vec<u8> =
                                                            std::fs::read(&*v577).unwrap();
                                                        _v598.set(Some(x_40))
                                                    }
                                                    {
                                                        let v608: Vec<u8> = match &_v598
                                                            .get()
                                                            .clone()
                                                        {
                                                            None => panic!(
                                                                "{}",
                                                                string(
                                                                    "base.run_target / _v598=None"
                                                                ),
                                                            ),
                                                            Some(_v598_0_0) => _v598_0_0.clone(),
                                                        };
                                                        let v610: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v608);
                                                        let v612: std::string::String =
                                                            v610.unwrap();
                                                        {
                                                            let x_42:
                                                                        string =
                                                                    fable_library_rust::String_::fromString(v612);
                                                            _v597.set(Some(x_42))
                                                        }
                                                        {
                                                            let v620:
                                                                        string =
                                                                    match &_v597.get().clone()
                                                                        {
                                                                        None
                                                                        =>
                                                                        panic!("{}",
                                                                               string("base.run_target / _v597=None"),),
                                                                        Some(_v597_0_0)
                                                                        =>
                                                                        _v597_0_0.clone(),
                                                                    };
                                                            let v623: string =
                                                                Spiral_builder::method80(sprintf!(
                                                                    "{:?}",
                                                                    (string("rs"), v620.clone())
                                                                ));
                                                            let v636:
                                                                        string =
                                                                    Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method17(Spiral_builder::method14(string("polyglot"),
                                                                                                                                                                                                                                                   string(".paket")),
                                                                                                                                                                                                                          string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder")),
                                                                                                                                                                                                 string("polyglot")),
                                                                                                                                                                        string("target/spiral_builder")),
                                                                                                                                               string("spiral_builder")),
                                                                                                                      string("packages")),
                                                                                             v623.clone());
                                                            let v637: LrcPtr<dyn IDisposable> =
                                                                Spiral_builder::method82(
                                                                    v636.clone(),
                                                                );
                                                            let v640: string =
                                                                Spiral_builder::method70(
                                                                    Spiral_builder::method14(
                                                                        v636.clone(),
                                                                        sprintf!(
                                                                            "{}.fs",
                                                                            string(
                                                                                "spiral_builder"
                                                                            )
                                                                        ),
                                                                    ),
                                                                );
                                                            Spiral_builder::method24(
                                                                v640.clone(),
                                                                v620,
                                                            );
                                                            {
                                                                let v641: List<string> =
                                                                    empty::<string>();
                                                                let v646: string = join(
                                                                    string("\\n        "),
                                                                    toArray_1(delay(Func0::new({
                                                                        let v641 = v641.clone();
                                                                        move || {
                                                                            map(
                                                                                Func1::new({
                                                                                    let v641 = v641
                                                                                        .clone();
                                                                                    move
                                                                                                                                       |i_1:
                                                                                                                                            i32|
                                                                                                                                       item(i_1,
                                                                                                                                            v641.clone())
                                                                                }),
                                                                                rangeNumeric(
                                                                                    0_i32,
                                                                                    1_i32,
                                                                                    length_1(
                                                                                        v641.clone(
                                                                                        ),
                                                                                    ) - 1_i32,
                                                                                ),
                                                                            )
                                                                        }
                                                                    }))),
                                                                );
                                                                let v650:
                                                                            List<string> =
                                                                        singleton(sprintf!("<PackageReference Include=\"{}\" Version=\"*\" />",
                                                                                           string("Fable.Core")));
                                                                let v654: string = join(
                                                                    string("\\n        "),
                                                                    toArray_1(delay(Func0::new({
                                                                        let v650 = v650.clone();
                                                                        move || {
                                                                            map(
                                                                                Func1::new({
                                                                                    let v650 = v650
                                                                                        .clone();
                                                                                    move
                                                                                                                                       |i_2:
                                                                                                                                            i32|
                                                                                                                                       item(i_2,
                                                                                                                                            v650.clone())
                                                                                }),
                                                                                rangeNumeric(
                                                                                    0_i32,
                                                                                    1_i32,
                                                                                    length_1(
                                                                                        v650.clone(
                                                                                        ),
                                                                                    ) - 1_i32,
                                                                                ),
                                                                            )
                                                                        }
                                                                    }))),
                                                                );
                                                                let v657:
                                                                            string =
                                                                        Spiral_builder::method70(Spiral_builder::method14(v636,
                                                                                                                          sprintf!("{}.fsproj",
                                                                                                                                   string("spiral_builder"))));
                                                                Spiral_builder::method24(v657.clone(),
                                                                                             append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                                        sprintf!("    {}",
                                                                                                                                                                                                 v646)),
                                                                                                                                                                                 string("\n")),
                                                                                                                                                                          sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                                                   v640)),
                                                                                                                                                                   string("\n")),
                                                                                                                                                            string("</ItemGroup>")),
                                                                                                                                                     string("\n")),
                                                                                                                                              string("<ItemGroup>")),
                                                                                                                                       string("\n")),
                                                                                                                                sprintf!("    {}",
                                                                                                                                         v654)),
                                                                                                                         string("\n")),
                                                                                                                  string("</ItemGroup>")),
                                                                                                           string("\n")),
                                                                                                    string("</Project>")));
                                                                {
                                                                    let v756: string =
                                                                        Spiral_builder::method23(
                                                                            v657.clone(),
                                                                        );
                                                                    let v758: string =
                                                                        Spiral_builder::method14(
                                                                            v756.clone(),
                                                                            string("Cargo.toml"),
                                                                        );
                                                                    let v760: string =
                                                                        Spiral_builder::method14(
                                                                            v756.clone(),
                                                                            string("../.."),
                                                                        );
                                                                    let v761: string =
                                                                        Spiral_builder::method14(
                                                                            v760.clone(),
                                                                            string("Cargo.toml"),
                                                                        );
                                                                    if Spiral_builder::method26(
                                                                        v758.clone(),
                                                                    ) == false
                                                                    {
                                                                        let v764: DateTime =
                                                                            DateTime::now();
                                                                        let v769:
                                                                                    string =
                                                                                toString(Spiral_builder::method92(new_guid(),
                                                                                                                  v764));
                                                                        let v791:
                                                                                    string =
                                                                                append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                                           sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                                    v769.clone())),
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
                                                                                                              v769)),
                                                                                              string("\n")),
                                                                                       sprintf!("path = \"spiral_builder.{}\"",
                                                                                                string("rs")));
                                                                        let _v792: MutCell<
                                                                            Option<()>,
                                                                        > = MutCell::new(
                                                                            None::<()>,
                                                                        );
                                                                        std::fs::write(
                                                                            &*v758.clone(),
                                                                            &*v791,
                                                                        )
                                                                        .unwrap();
                                                                        _v792.set(Some(()));
                                                                        match &_v792.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v792=None"),),
                                                                                Some(_v792_0_0)
                                                                                =>
                                                                                _v792_0_0.clone(),
                                                                            }
                                                                        ()
                                                                    }
                                                                    if Spiral_builder::method26(
                                                                        v761.clone(),
                                                                    ) == false
                                                                    {
                                                                        let v797: DateTime =
                                                                            DateTime::now();
                                                                        let v802:
                                                                                    string =
                                                                                toString(Spiral_builder::method92(new_guid(),
                                                                                                                  v797));
                                                                        let v824:
                                                                                    string =
                                                                                append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                                           sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                                    v802.clone())),
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
                                                                                                              v802)),
                                                                                              string("\n")),
                                                                                       sprintf!("path = \"spiral_builder.{}\"",
                                                                                                string("rs")));
                                                                        let _v825: MutCell<
                                                                            Option<()>,
                                                                        > = MutCell::new(
                                                                            None::<()>,
                                                                        );
                                                                        std::fs::write(
                                                                            &*v761.clone(),
                                                                            &*v824,
                                                                        )
                                                                        .unwrap();
                                                                        _v825.set(Some(()));
                                                                        match &_v825.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v825=None"),),
                                                                                Some(_v825_0_0)
                                                                                =>
                                                                                _v825_0_0.clone(),
                                                                            }
                                                                        ()
                                                                    }
                                                                    {
                                                                        let v831:
                                                                                    string =
                                                                                Spiral_builder::method14(Spiral_builder::method17(Spiral_builder::method14(string("polyglot"),
                                                                                                                                                           string(".paket")),
                                                                                                                                  string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder")),
                                                                                                         string("polyglot"));
                                                                        let v834:
                                                                                    string =
                                                                                toLower(Spiral_builder::method22());
                                                                        let v836: string =
                                                                            toLower(v831);
                                                                        let v840:
                                                                                    Spiral_builder::US12 =
                                                                                if startsWith(v834,
                                                                                              v836.clone(),
                                                                                              false)
                                                                                   {
                                                                                    Spiral_builder::US12::US12_1(v836.clone())
                                                                                } else {
                                                                                    Spiral_builder::US12::US12_0(v836)
                                                                                };
                                                                        let v846:
                                                                                    Result<string,
                                                                                           string> =
                                                                                match &v840
                                                                                    {
                                                                                    Spiral_builder::US12::US12_0(v840_0_0)
                                                                                    =>
                                                                                    Ok::<string,
                                                                                         string>(v840_0_0.clone()),
                                                                                    Spiral_builder::US12::US12_1(v840_1_0)
                                                                                    =>
                                                                                    Err::<string,
                                                                                          string>(v840_1_0.clone()),
                                                                                };
                                                                        let v848: bool = true;
                                                                        let _result = v846
                                                                            .unwrap_or_else(|x| {
                                                                                //;
                                                                                let v850: string =
                                                                                    x;
                                                                                let v852: bool =
                                                                                    true;
                                                                                v850
                                                                            });
                                                                        let v854: string = _result;
                                                                        let v856:
                                                                                    string =
                                                                                Spiral_builder::method14(v854.clone(),
                                                                                                         string("lib/rust/fable/fable_modules/fable-library-rust"));
                                                                        let v858:
                                                                                    string =
                                                                                Spiral_builder::method14(v756.clone(),
                                                                                                         string("fable_modules/fable-library-rust"));
                                                                        Spiral_builder::method98(
                                                                            v856,
                                                                            v858.clone(),
                                                                        );
                                                                        {
                                                                            let patternInput_8:
                                                                                        (i32,
                                                                                         string) =
                                                                                    Spiral_builder::method99(v756.clone(),
                                                                                                             string("rs"),
                                                                                                             v657,
                                                                                                             v840.clone());
                                                                            let v860: string =
                                                                                patternInput_8
                                                                                    .1
                                                                                    .clone();
                                                                            let v859: i32 =
                                                                                patternInput_8
                                                                                    .0
                                                                                    .clone();
                                                                            if v859 != 0_i32 {
                                                                                Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                            Func0::new(move
                                                                                                                           ||
                                                                                                                           Spiral_builder::closure74((),
                                                                                                                                                     ())),
                                                                                                            Func0::new({
                                                                                                                           let v859
                                                                                                                               =
                                                                                                                               v859.clone();
                                                                                                                           let v860
                                                                                                                               =
                                                                                                                               v860.clone();
                                                                                                                           move
                                                                                                                               ||
                                                                                                                               Spiral_builder::closure75(v860.clone(),
                                                                                                                                                         v859,
                                                                                                                                                         ())
                                                                                                                       }));
                                                                                (Spiral_builder::US3::US3_1,
                                                                                     Spiral_builder::US3::US3_0(string("rs")),
                                                                                     Spiral_builder::US3::US3_0(v860.clone()))
                                                                            } else {
                                                                                let v869: bool =
                                                                                    true;
                                                                                let _result : Vec<_> = v594.into_iter().map(|x| { //;
                                                                                    let v871:
                                                                                            std::string::String =
                                                                                        x;
                                                                                    let v873:
                                                                                            string =
                                                                                        fable_library_rust::String_::fromString(v871);
                                                                                    let v884:
                                                                                            string =
                                                                                        if contains(v873.clone(),
                                                                                                    string("="))
                                                                                           {
                                                                                            v873.clone()
                                                                                        } else {
                                                                                            if endsWith(v873.clone(),
                                                                                                        string("]"),
                                                                                                        false)
                                                                                               {
                                                                                                sprintf!("{}}}",
                                                                                                         replace(v873.clone(),
                                                                                                                 string("["),
                                                                                                                 string("={version=\'*\',features=[")))
                                                                                            } else {
                                                                                                sprintf!("{}=\'*\'",
                                                                                                         v873)
                                                                                            }
                                                                                        };
                                                                                    let v886:
                                                                                            bool =
                                                                                        true; v884 }).collect::<Vec<_>>();
                                                                                let v888: Vec<
                                                                                    string,
                                                                                > = _result;
                                                                                let v890:
                                                                                            Array<string> =
                                                                                        fable_library_rust::NativeArray_::array_from(v888);
                                                                                let v931:
                                                                                            string =
                                                                                        append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(append(string("[package]\n"),
                                                                                                                                                                                                                                                         sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                                                                                                                                                                  v623.clone())),
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
                                                                                                                                                                                                    let v890
                                                                                                                                                                                                        =
                                                                                                                                                                                                        v890.clone();
                                                                                                                                                                                                    move
                                                                                                                                                                                                        ||
                                                                                                                                                                                                        map(Func1::new({
                                                                                                                                                                                                                           let v890
                                                                                                                                                                                                                               =
                                                                                                                                                                                                                               v890.clone();
                                                                                                                                                                                                                           move
                                                                                                                                                                                                                               |i_3:
                                                                                                                                                                                                                                    i32|
                                                                                                                                                                                                                               v890[i_3].clone()
                                                                                                                                                                                                                       }),
                                                                                                                                                                                                            rangeNumeric(0_i32,
                                                                                                                                                                                                                         1_i32,
                                                                                                                                                                                                                         count_2(v890.clone())
                                                                                                                                                                                                                             -
                                                                                                                                                                                                                             1_i32))
                                                                                                                                                                                                })))))),
                                                                                                                                                string("\n")),
                                                                                                                                         string("")),
                                                                                                                                  string("\n")),
                                                                                                                           string("[[bin]]")),
                                                                                                                    string("\n")),
                                                                                                             sprintf!("name = \"spiral_builder_{}\"",
                                                                                                                      v623.clone())),
                                                                                                      string("\n")),
                                                                                               string("path = \"spiral_builder.rs\" "));
                                                                                let v963:
                                                                                            string =
                                                                                        append(append(append(append(append(append(append(append(append(append(append(string("[workspace]\nresolver = \"2\"\nmembers = [\"packages/*\"]\n\n[workspace.dependencies.fable_library_rust]\n"),
                                                                                                                                                                     sprintf!("path = \"{}/lib/rust/fable/fable_modules/fable-library-rust\"",
                                                                                                                                                                              Spiral_builder::method70(v854))),
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
                                                                                Spiral_builder::method24(v758.clone(),
                                                                                                             v931);
                                                                                Spiral_builder::method24(v761,
                                                                                                             v963);
                                                                                {
                                                                                    let v965:
                                                                                                string =
                                                                                            Spiral_builder::method14(v858,
                                                                                                                     string("src/Range.rs"));
                                                                                    if Spiral_builder::method26(v965.clone())
                                                                                           {
                                                                                            let _v967:
                                                                                                    MutCell<Option<string>> =
                                                                                                MutCell::new(None::<string>);
                                                                                            let _v968:
                                                                                                    MutCell<Option<Vec<u8>>> =
                                                                                                MutCell::new(None::<Vec<u8>>);
                                                                                            {
                                                                                                let x_48:
                                                                                                        Vec<u8> =
                                                                                                    std::fs::read(&*v965.clone()).unwrap();
                                                                                                _v968.set(Some(x_48))
                                                                                            }
                                                                                            {
                                                                                                let v978:
                                                                                                        Vec<u8> =
                                                                                                    match &_v968.get().clone()
                                                                                                        {
                                                                                                        None
                                                                                                        =>
                                                                                                        panic!("{}",
                                                                                                               string("base.run_target / _v968=None"),),
                                                                                                        Some(_v968_0_0)
                                                                                                        =>
                                                                                                        _v968_0_0.clone(),
                                                                                                    };
                                                                                                let v980:
                                                                                                        Result<std::string::String,
                                                                                                               std::string::FromUtf8Error> =
                                                                                                    std::string::String::from_utf8(v978);
                                                                                                let v982:
                                                                                                        std::string::String =
                                                                                                    v980.unwrap();
                                                                                                {
                                                                                                    let x_50:
                                                                                                            string =
                                                                                                        fable_library_rust::String_::fromString(v982);
                                                                                                    _v967.set(Some(x_50))
                                                                                                }
                                                                                                Spiral_builder::method24(v965,
                                                                                                                         replace(replace(match &_v967.get().clone()
                                                                                                                                             {
                                                                                                                                             None
                                                                                                                                             =>
                                                                                                                                             panic!("{}",
                                                                                                                                                    string("base.run_target / _v967=None"),),
                                                                                                                                             Some(_v967_0_0)
                                                                                                                                             =>
                                                                                                                                             _v967_0_0.clone(),
                                                                                                                                         },
                                                                                                                                         string("use crate::String_::fromCharCode;"),
                                                                                                                                         string("use crate::String_::fromChar;")),
                                                                                                                                 string("fromCharCode(c)"),
                                                                                                                                 string("std::char::from_u32(c).unwrap()")))
                                                                                            }
                                                                                        }
                                                                                    {
                                                                                        let patternInput_9:
                                                                                                    (i32,
                                                                                                     string) =
                                                                                                Spiral_builder::method101(v758.clone(),
                                                                                                                          v840.clone(),
                                                                                                                          1_u8);
                                                                                        let v998:
                                                                                                    i32 =
                                                                                                patternInput_9.0.clone();
                                                                                        if v998
                                                                                            != 0_i32
                                                                                        {
                                                                                            Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                        Func0::new(move
                                                                                                                                       ||
                                                                                                                                       Spiral_builder::closure76((),
                                                                                                                                                                 ())),
                                                                                                                        Func0::new({
                                                                                                                                       let patternInput_9
                                                                                                                                           =
                                                                                                                                           patternInput_9.clone();
                                                                                                                                       let v998
                                                                                                                                           =
                                                                                                                                           v998.clone();
                                                                                                                                       move
                                                                                                                                           ||
                                                                                                                                           Spiral_builder::closure77(patternInput_9.1.clone(),
                                                                                                                                                                     v998,
                                                                                                                                                                     ())
                                                                                                                                   }));
                                                                                        }
                                                                                        {
                                                                                            let v1005:
                                                                                                        string =
                                                                                                    Spiral_builder::method14(v756,
                                                                                                                             sprintf!("{}.{}",
                                                                                                                                      string("spiral_builder"),
                                                                                                                                      string("rs")));
                                                                                            let _v1006:
                                                                                                        MutCell<Option<string>> =
                                                                                                    MutCell::new(None::<string>);
                                                                                            let _v1007:
                                                                                                        MutCell<Option<Vec<u8>>> =
                                                                                                    MutCell::new(None::<Vec<u8>>);
                                                                                            {
                                                                                                let x_52:
                                                                                                            Vec<u8> =
                                                                                                        std::fs::read(&*v1005.clone()).unwrap();
                                                                                                _v1007.set(Some(x_52))
                                                                                            }
                                                                                            {
                                                                                                let v1017:
                                                                                                            Vec<u8> =
                                                                                                        match &_v1007.get().clone()
                                                                                                            {
                                                                                                            None
                                                                                                            =>
                                                                                                            panic!("{}",
                                                                                                                   string("base.run_target / _v1007=None"),),
                                                                                                            Some(_v1007_0_0)
                                                                                                            =>
                                                                                                            _v1007_0_0.clone(),
                                                                                                        };
                                                                                                let v1019:
                                                                                                            Result<std::string::String,
                                                                                                                   std::string::FromUtf8Error> =
                                                                                                        std::string::String::from_utf8(v1017);
                                                                                                let v1021:
                                                                                                            std::string::String =
                                                                                                        v1019.unwrap();
                                                                                                {
                                                                                                    let x_54:
                                                                                                                string =
                                                                                                            fable_library_rust::String_::fromString(v1021);
                                                                                                    _v1006.set(Some(x_54))
                                                                                                }
                                                                                                {
                                                                                                    let v1029:
                                                                                                                string =
                                                                                                            match &_v1006.get().clone()
                                                                                                                {
                                                                                                                None
                                                                                                                =>
                                                                                                                panic!("{}",
                                                                                                                       string("base.run_target / _v1006=None"),),
                                                                                                                Some(_v1006_0_0)
                                                                                                                =>
                                                                                                                _v1006_0_0.clone(),
                                                                                                            };
                                                                                                    let v1033:
                                                                                                                string =
                                                                                                            append(string("pub fn main() -> Result<(), String> "),
                                                                                                                   "{".into());
                                                                                                    let v1034:
                                                                                                                string =
                                                                                                            sprintf!("{} Ok(()) }}",
                                                                                                                     v1033.clone());
                                                                                                    let v1035:
                                                                                                                bool =
                                                                                                            contains(v1029.clone(),
                                                                                                                     v1033);
                                                                                                    let v1111:
                                                                                                                string =
                                                                                                            if v1035
                                                                                                               {
                                                                                                                v1029.clone()
                                                                                                            } else {
                                                                                                                let v1047:
                                                                                                                        string =
                                                                                                                    replace(replace(v1029,
                                                                                                                                    append(string("),)"),
                                                                                                                                           ";".into()),
                                                                                                                                    string("));")),
                                                                                                                            append(string("},)"),
                                                                                                                                   ";".into()),
                                                                                                                            string("});"));
                                                                                                                let v1048:
                                                                                                                        string =
                                                                                                                    Spiral_builder::method103();
                                                                                                                let _v1049:
                                                                                                                        MutCell<Option<string>> =
                                                                                                                    MutCell::new(None::<string>);
                                                                                                                let v1050:
                                                                                                                        string =
                                                                                                                    Spiral_builder::method72(v1047);
                                                                                                                let v1053:
                                                                                                                        Result<regex::Regex,
                                                                                                                               regex::Error> =
                                                                                                                    regex::Regex::new(&string("\\s\\sdefaultOf\\(\\);"));
                                                                                                                let v1055:
                                                                                                                        regex::Regex =
                                                                                                                    v1053.unwrap();
                                                                                                                let v1057:
                                                                                                                        std::borrow::Cow<str> =
                                                                                                                    v1055.replace_all(&v1050, &*v1048);
                                                                                                                let v1059:
                                                                                                                        std::string::String =
                                                                                                                    String::from(v1057);
                                                                                                                {
                                                                                                                    let x_56:
                                                                                                                            string =
                                                                                                                        fable_library_rust::String_::fromString(v1059);
                                                                                                                    _v1049.set(Some(x_56))
                                                                                                                }
                                                                                                                replace(replace(replace(replace(replace(replace(replace(match &_v1049.get().clone()
                                                                                                                                                                            {
                                                                                                                                                                            None
                                                                                                                                                                            =>
                                                                                                                                                                            panic!("{}",
                                                                                                                                                                                   string("base.run_target / _v1049=None"),),
                                                                                                                                                                            Some(_v1049_0_0)
                                                                                                                                                                            =>
                                                                                                                                                                            _v1049_0_0.clone(),
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
                                                                                                    if v1035
                                                                                                               ==
                                                                                                               false
                                                                                                           {
                                                                                                            Spiral_builder::method24(v1005.clone(),
                                                                                                                                     sprintf!("{}\n\n{}\n",
                                                                                                                                              v1111.clone(),
                                                                                                                                              v1034));
                                                                                                        }
                                                                                                    {
                                                                                                        let v1114:
                                                                                                                    string =
                                                                                                                sprintf!("cargo +nightly run --manifest-path \"{}\"",
                                                                                                                         v758);
                                                                                                        let v1121:
                                                                                                                    Array<(string,
                                                                                                                           string)> =
                                                                                                                new_array(&[(string("TRACE_LEVEL"),
                                                                                                                             string("Verbose")),
                                                                                                                            (string("RUSTC_WRAPPER"),
                                                                                                                             string("sccache")),
                                                                                                                            (string("RUSTFLAGS"),
                                                                                                                             string("-C prefer-dynamic"))]);
                                                                                                        let v1132:
                                                                                                                    Result<string,
                                                                                                                           string> =
                                                                                                                match &v840
                                                                                                                    {
                                                                                                                    Spiral_builder::US12::US12_0(v840_0_0)
                                                                                                                    =>
                                                                                                                    Ok::<string,
                                                                                                                         string>(v840_0_0.clone()),
                                                                                                                    Spiral_builder::US12::US12_1(v840_1_0)
                                                                                                                    =>
                                                                                                                    Err::<string,
                                                                                                                          string>(v840_1_0.clone()),
                                                                                                                };
                                                                                                        let patternInput_10:
                                                                                                                    (i32,
                                                                                                                     string) =
                                                                                                                Spiral_builder::method28(None::<CancellationToken>,
                                                                                                                                         v1114.clone(),
                                                                                                                                         v1121.clone(),
                                                                                                                                         None::<Func1<(bool,
                                                                                                                                                       string,
                                                                                                                                                       i32),
                                                                                                                                                      Arc<Async<()>>>>,
                                                                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                                      ()>>,
                                                                                                                                         true,
                                                                                                                                         v1132.ok());
                                                                                                        let v1137:
                                                                                                                    string =
                                                                                                                patternInput_10.1.clone();
                                                                                                        let v1136:
                                                                                                                    i32 =
                                                                                                                patternInput_10.0.clone();
                                                                                                        let v1140:
                                                                                                                    string =
                                                                                                                Spiral_builder::method14(v760.clone(),
                                                                                                                                         sprintf!("target/debug/spiral_builder_{}{}",
                                                                                                                                                  v623.clone(),
                                                                                                                                                  string("")));
                                                                                                        let v1143:
                                                                                                                    string =
                                                                                                                Spiral_builder::method14(v760.clone(),
                                                                                                                                         sprintf!("target/debug/spiral_builder_{}{}",
                                                                                                                                                  v623.clone(),
                                                                                                                                                  string(".pdb")));
                                                                                                        let v1146:
                                                                                                                    string =
                                                                                                                Spiral_builder::method14(v760.clone(),
                                                                                                                                         sprintf!("target/debug/spiral_builder_{}{}",
                                                                                                                                                  v623.clone(),
                                                                                                                                                  string(".exe")));
                                                                                                        let v1149:
                                                                                                                    string =
                                                                                                                Spiral_builder::method14(v760,
                                                                                                                                         sprintf!("target/debug/spiral_builder_{}{}",
                                                                                                                                                  v623,
                                                                                                                                                  string(".d")));
                                                                                                        let v1150:
                                                                                                                    bool =
                                                                                                                Spiral_builder::method26(v1140.clone());
                                                                                                        let v1151:
                                                                                                                    bool =
                                                                                                                Spiral_builder::method26(v1143.clone());
                                                                                                        let v1152:
                                                                                                                    bool =
                                                                                                                Spiral_builder::method26(v1146.clone());
                                                                                                        let v1153:
                                                                                                                    bool =
                                                                                                                Spiral_builder::method26(v1149.clone());
                                                                                                        Spiral_builder::method5(Spiral_builder::US0::US0_0,
                                                                                                                                    Func0::new(move
                                                                                                                                                   ||
                                                                                                                                                   Spiral_builder::closure78((),
                                                                                                                                                                             ())),
                                                                                                                                    Func0::new({
                                                                                                                                                   let v1140
                                                                                                                                                       =
                                                                                                                                                       v1140.clone();
                                                                                                                                                   let v1143
                                                                                                                                                       =
                                                                                                                                                       v1143.clone();
                                                                                                                                                   let v1146
                                                                                                                                                       =
                                                                                                                                                       v1146.clone();
                                                                                                                                                   let v1149
                                                                                                                                                       =
                                                                                                                                                       v1149.clone();
                                                                                                                                                   let v1150
                                                                                                                                                       =
                                                                                                                                                       v1150.clone();
                                                                                                                                                   let v1151
                                                                                                                                                       =
                                                                                                                                                       v1151.clone();
                                                                                                                                                   let v1152
                                                                                                                                                       =
                                                                                                                                                       v1152.clone();
                                                                                                                                                   let v1153
                                                                                                                                                       =
                                                                                                                                                       v1153.clone();
                                                                                                                                                   move
                                                                                                                                                       ||
                                                                                                                                                       Spiral_builder::closure79(v1149.clone(),
                                                                                                                                                                                 v1153,
                                                                                                                                                                                 v1146.clone(),
                                                                                                                                                                                 v1152,
                                                                                                                                                                                 v1143.clone(),
                                                                                                                                                                                 v1151,
                                                                                                                                                                                 v1140.clone(),
                                                                                                                                                                                 v1150,
                                                                                                                                                                                 ())
                                                                                                                                               }));
                                                                                                        {
                                                                                                            let v1160:
                                                                                                                        LrcPtr<Spiral_builder::UH3> =
                                                                                                                    if v1150
                                                                                                                       {
                                                                                                                        LrcPtr::new(Spiral_builder::UH3::UH3_1(v1140.clone(),
                                                                                                                                                               v1150,
                                                                                                                                                               LrcPtr::new(Spiral_builder::UH3::UH3_0)))
                                                                                                                    } else {
                                                                                                                        LrcPtr::new(Spiral_builder::UH3::UH3_0)
                                                                                                                    };
                                                                                                            let v1162:
                                                                                                                        LrcPtr<Spiral_builder::UH3> =
                                                                                                                    if v1151
                                                                                                                       {
                                                                                                                        LrcPtr::new(Spiral_builder::UH3::UH3_1(v1143.clone(),
                                                                                                                                                               v1151,
                                                                                                                                                               v1160.clone()))
                                                                                                                    } else {
                                                                                                                        v1160
                                                                                                                    };
                                                                                                            let v1164:
                                                                                                                        LrcPtr<Spiral_builder::UH3> =
                                                                                                                    if v1152
                                                                                                                       {
                                                                                                                        LrcPtr::new(Spiral_builder::UH3::UH3_1(v1146.clone(),
                                                                                                                                                               v1152,
                                                                                                                                                               v1162.clone()))
                                                                                                                    } else {
                                                                                                                        v1162
                                                                                                                    };
                                                                                                            Spiral_builder::method105(if v1153
                                                                                                                                             {
                                                                                                                                              LrcPtr::new(Spiral_builder::UH3::UH3_1(v1149.clone(),
                                                                                                                                                                                     v1153,
                                                                                                                                                                                     v1164.clone()))
                                                                                                                                          } else {
                                                                                                                                              v1164
                                                                                                                                          });
                                                                                                            {
                                                                                                                let v1167:
                                                                                                                            i32 =
                                                                                                                        count_2(v1121.clone());
                                                                                                                let v1168:
                                                                                                                            Array<string> =
                                                                                                                        new_init(&string(""),
                                                                                                                                 v1167);
                                                                                                                let v1169:
                                                                                                                            LrcPtr<Spiral_builder::Mut4> =
                                                                                                                        LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                                             MutCell::new(0_i32),});
                                                                                                                while Spiral_builder::method32(v1167,
                                                                                                                                                   v1169.clone())
                                                                                                                          {
                                                                                                                        let v1171:
                                                                                                                                i32 =
                                                                                                                            v1169.l0.get().clone();
                                                                                                                        let patternInput_11:
                                                                                                                                (string,
                                                                                                                                 string) =
                                                                                                                            v1121[v1171].clone();
                                                                                                                        let v1174:
                                                                                                                                string =
                                                                                                                            sprintf!("$env:{}=\'\'{}\'\'",
                                                                                                                                     patternInput_11.0.clone(),
                                                                                                                                     patternInput_11.1.clone());
                                                                                                                        v1168.get_mut()[v1171
                                                                                                                                            as
                                                                                                                                            usize]
                                                                                                                            =
                                                                                                                            v1174;
                                                                                                                        {
                                                                                                                            let v1175:
                                                                                                                                    i32 =
                                                                                                                                v1171
                                                                                                                                    +
                                                                                                                                    1_i32;
                                                                                                                            v1169.l0.set(v1175);
                                                                                                                            ()
                                                                                                                        }
                                                                                                                    }
                                                                                                                {
                                                                                                                    let v1182:
                                                                                                                                string =
                                                                                                                            sprintf!("pwsh -c \'{}; {}\'",
                                                                                                                                     join(string(";"),
                                                                                                                                          toArray_1(ofArray_1(v1168.clone()))),
                                                                                                                                     v1114);
                                                                                                                    if v1136
                                                                                                                               ==
                                                                                                                               0_i32
                                                                                                                           {
                                                                                                                            let v1187:
                                                                                                                                    Spiral_builder::US3 =
                                                                                                                                try_catch(||
                                                                                                                                              Spiral_builder::closure43((),
                                                                                                                                                                        Spiral_builder::closure80(v1137.clone(),
                                                                                                                                                                                                  ())),
                                                                                                                                          |ex_1:
                                                                                                                                               LrcPtr<Exception>|
                                                                                                                                              Spiral_builder::closure82(v1005.clone(),
                                                                                                                                                                        v1137.clone(),
                                                                                                                                                                        v1182.clone(),
                                                                                                                                                                        ex_1.clone()));
                                                                                                                            let v1192:
                                                                                                                                    Option<string> =
                                                                                                                                match &v1187
                                                                                                                                    {
                                                                                                                                    Spiral_builder::US3::US3_0(v1187_0_0)
                                                                                                                                    =>
                                                                                                                                    Some(match &v1187
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
                                                                                                                            (Spiral_builder::US3::US3_0(v1111),
                                                                                                                             Spiral_builder::US3::US3_0(string("rs")),
                                                                                                                             Spiral_builder::US3::US3_0(v1192.unwrap()))
                                                                                                                        } else {
                                                                                                                            Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                                                    Func0::new(move
                                                                                                                                                                   ||
                                                                                                                                                                   Spiral_builder::closure85((),
                                                                                                                                                                                             ())),
                                                                                                                                                    Func0::new({
                                                                                                                                                                   let v1005
                                                                                                                                                                       =
                                                                                                                                                                       v1005.clone();
                                                                                                                                                                   let v1136
                                                                                                                                                                       =
                                                                                                                                                                       v1136.clone();
                                                                                                                                                                   let v1137
                                                                                                                                                                       =
                                                                                                                                                                       v1137.clone();
                                                                                                                                                                   let v1182
                                                                                                                                                                       =
                                                                                                                                                                       v1182.clone();
                                                                                                                                                                   move
                                                                                                                                                                       ||
                                                                                                                                                                       Spiral_builder::closure86(v1005.clone(),
                                                                                                                                                                                                 v1137.clone(),
                                                                                                                                                                                                 v1136,
                                                                                                                                                                                                 v1182.clone(),
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
                                        } else {
                                            if fable_library_rust::String_::fromString(v13.clone())
                                                == string("typescript")
                                            {
                                                let v1214: string = Spiral_builder::method63();
                                                let v1216: &str = &*v1214;
                                                let v1218: Option<std::string::String> =
                                                    clap::ArgMatches::get_one(&v14.clone(), v1216)
                                                        .cloned();
                                                let _v1219: LrcPtr<
                                                    MutCell<Option<Spiral_builder::US5>>,
                                                > = refCell(None::<Spiral_builder::US5>);
                                                {
                                                    let x_60: Option<Spiral_builder::US5> =
                                                        match &v1218 {
                                                            None => None::<Spiral_builder::US5>,
                                                            Some(v1218_0_0) => {
                                                                let x_58: std::string::String =
                                                                    v1218_0_0.clone();
                                                                Some((Func0::new({
                                                                    let x_58 = x_58.clone();
                                                                    move || {
                                                                        Spiral_builder::US5::US5_0(
                                                                            x_58.clone(),
                                                                        )
                                                                    }
                                                                }))(
                                                                ))
                                                            }
                                                        };
                                                    _v1219.set(x_60)
                                                }
                                                {
                                                    let v1224: Spiral_builder::US5 = defaultValue(
                                                        Spiral_builder::US5::US5_1,
                                                        _v1219.get().clone(),
                                                    );
                                                    let v1228: std::string::String = match &v1224 {
                                                        Spiral_builder::US5::US5_0(v1224_0_0) => {
                                                            match &v1224 {
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
                                                    let v1230: string =
                                                        fable_library_rust::String_::fromString(
                                                            v1228,
                                                        );
                                                    let v1231: string = Spiral_builder::method13();
                                                    let v1233: &str = &*v1231;
                                                    let v1235: Option<Vec<std::string::String>> =
                                                        clap::ArgMatches::get_many(
                                                            &v14.clone(),
                                                            v1233,
                                                        )
                                                        .map(|x| x.cloned().into_iter().collect());
                                                    let _v1236: LrcPtr<
                                                        MutCell<Option<Spiral_builder::US9>>,
                                                    > = refCell(None::<Spiral_builder::US9>);
                                                    {
                                                        let x_63: Option<Spiral_builder::US9> =
                                                            match &v1235 {
                                                                None => None::<Spiral_builder::US9>,
                                                                Some(v1235_0_0) => {
                                                                    let x_61: Vec<
                                                                        std::string::String,
                                                                    > = v1235_0_0.clone();
                                                                    Some((Func0::new({
                                                                        let x_61 = x_61.clone();
                                                                        move || {
                                                                            Spiral_builder::US9::US9_0(x_61.clone())
                                                                        }
                                                                    }))(
                                                                    ))
                                                                }
                                                            };
                                                        _v1236.set(x_63)
                                                    }
                                                    {
                                                        let v1241: Spiral_builder::US9 =
                                                            defaultValue(
                                                                Spiral_builder::US9::US9_1,
                                                                _v1236.get().clone(),
                                                            );
                                                        let v1244: Vec<std::string::String> =
                                                            new_empty::<std::string::String>()
                                                                .to_vec();
                                                        let v1247: Vec<std::string::String> =
                                                            match &v1241 {
                                                                Spiral_builder::US9::US9_0(
                                                                    v1241_0_0,
                                                                ) => match &v1241 {
                                                                    Spiral_builder::US9::US9_0(
                                                                        x,
                                                                    ) => x.clone(),
                                                                    _ => unreachable!(),
                                                                },
                                                                _ => v1244,
                                                            };
                                                        let v1249: bool =
                                                            if let Spiral_builder::US0::US0_0 =
                                                                &v0_1
                                                            {
                                                                true
                                                            } else {
                                                                false
                                                            };
                                                        let _v1250: MutCell<Option<string>> =
                                                            MutCell::new(None::<string>);
                                                        let _v1251: MutCell<Option<Vec<u8>>> =
                                                            MutCell::new(None::<Vec<u8>>);
                                                        {
                                                            let x_64: Vec<u8> =
                                                                std::fs::read(&*v1230).unwrap();
                                                            _v1251.set(Some(x_64))
                                                        }
                                                        {
                                                            let v1261:
                                                                        Vec<u8> =
                                                                    match &_v1251.get().clone()
                                                                        {
                                                                        None
                                                                        =>
                                                                        panic!("{}",
                                                                               string("base.run_target / _v1251=None"),),
                                                                        Some(_v1251_0_0)
                                                                        =>
                                                                        _v1251_0_0.clone(),
                                                                    };
                                                            let v1263: Result<
                                                                std::string::String,
                                                                std::string::FromUtf8Error,
                                                            > = std::string::String::from_utf8(
                                                                v1261,
                                                            );
                                                            let v1265: std::string::String =
                                                                v1263.unwrap();
                                                            {
                                                                let x_66:
                                                                            string =
                                                                        fable_library_rust::String_::fromString(v1265);
                                                                _v1250.set(Some(x_66))
                                                            }
                                                            {
                                                                let v1273:
                                                                            string =
                                                                        match &_v1250.get().clone()
                                                                            {
                                                                            None
                                                                            =>
                                                                            panic!("{}",
                                                                                   string("base.run_target / _v1250=None"),),
                                                                            Some(_v1250_0_0)
                                                                            =>
                                                                            _v1250_0_0.clone(),
                                                                        };
                                                                let v1276: string =
                                                                    Spiral_builder::method80(
                                                                        sprintf!(
                                                                            "{:?}",
                                                                            (
                                                                                string("ts"),
                                                                                v1273.clone()
                                                                            )
                                                                        ),
                                                                    );
                                                                let v1289:
                                                                            string =
                                                                        Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method17(Spiral_builder::method14(string("polyglot"),
                                                                                                                                                                                                                                                       string(".paket")),
                                                                                                                                                                                                                              string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder")),
                                                                                                                                                                                                     string("polyglot")),
                                                                                                                                                                            string("target/spiral_builder")),
                                                                                                                                                   string("spiral_builder")),
                                                                                                                          string("packages")),
                                                                                                 v1276.clone());
                                                                let v1290: LrcPtr<dyn IDisposable> =
                                                                    Spiral_builder::method82(
                                                                        v1289.clone(),
                                                                    );
                                                                let v1293:
                                                                            string =
                                                                        Spiral_builder::method70(Spiral_builder::method14(v1289.clone(),
                                                                                                                          sprintf!("{}.fs",
                                                                                                                                   string("spiral_builder"))));
                                                                Spiral_builder::method24(
                                                                    v1293.clone(),
                                                                    v1273,
                                                                );
                                                                {
                                                                    let v1294: List<string> =
                                                                        empty::<string>();
                                                                    let v1299: string = join(
                                                                        string("\\n        "),
                                                                        toArray_1(delay(
                                                                            Func0::new({
                                                                                let v1294 =
                                                                                    v1294.clone();
                                                                                move || {
                                                                                    map(Func1::new({
                                                                                                                                       let v1294
                                                                                                                                           =
                                                                                                                                           v1294.clone();
                                                                                                                                       move
                                                                                                                                           |i_4:
                                                                                                                                                i32|
                                                                                                                                           item(i_4,
                                                                                                                                                v1294.clone())
                                                                                                                                   }),
                                                                                                                        rangeNumeric(0_i32,
                                                                                                                                     1_i32,
                                                                                                                                     length_1(v1294.clone())
                                                                                                                                         -
                                                                                                                                         1_i32))
                                                                                }
                                                                            }),
                                                                        )),
                                                                    );
                                                                    let v1303:
                                                                                List<string> =
                                                                            singleton(sprintf!("<PackageReference Include=\"{}\" Version=\"*\" />",
                                                                                               string("Fable.Core")));
                                                                    let v1307: string = join(
                                                                        string("\\n        "),
                                                                        toArray_1(delay(
                                                                            Func0::new({
                                                                                let v1303 =
                                                                                    v1303.clone();
                                                                                move || {
                                                                                    map(Func1::new({
                                                                                                                                       let v1303
                                                                                                                                           =
                                                                                                                                           v1303.clone();
                                                                                                                                       move
                                                                                                                                           |i_5:
                                                                                                                                                i32|
                                                                                                                                           item(i_5,
                                                                                                                                                v1303.clone())
                                                                                                                                   }),
                                                                                                                        rangeNumeric(0_i32,
                                                                                                                                     1_i32,
                                                                                                                                     length_1(v1303.clone())
                                                                                                                                         -
                                                                                                                                         1_i32))
                                                                                }
                                                                            }),
                                                                        )),
                                                                    );
                                                                    let v1310:
                                                                                string =
                                                                            Spiral_builder::method70(Spiral_builder::method14(v1289,
                                                                                                                              sprintf!("{}.fsproj",
                                                                                                                                       string("spiral_builder"))));
                                                                    Spiral_builder::method24(v1310.clone(),
                                                                                                 append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                                            sprintf!("    {}",
                                                                                                                                                                                                     v1299)),
                                                                                                                                                                                     string("\n")),
                                                                                                                                                                              sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                                                       v1293)),
                                                                                                                                                                       string("\n")),
                                                                                                                                                                string("</ItemGroup>")),
                                                                                                                                                         string("\n")),
                                                                                                                                                  string("<ItemGroup>")),
                                                                                                                                           string("\n")),
                                                                                                                                    sprintf!("    {}",
                                                                                                                                             v1307)),
                                                                                                                             string("\n")),
                                                                                                                      string("</ItemGroup>")),
                                                                                                               string("\n")),
                                                                                                        string("</Project>")));
                                                                    {
                                                                        let v1409:
                                                                                    string =
                                                                                Spiral_builder::method23(v1310.clone());
                                                                        let v1413:
                                                                                    string =
                                                                                Spiral_builder::method14(Spiral_builder::method17(Spiral_builder::method14(string("polyglot"),
                                                                                                                                                           string(".paket")),
                                                                                                                                  string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder")),
                                                                                                         string("polyglot"));
                                                                        let v1416:
                                                                                    string =
                                                                                toLower(Spiral_builder::method22());
                                                                        let v1418: string =
                                                                            toLower(v1413);
                                                                        let v1422:
                                                                                    Spiral_builder::US12 =
                                                                                if startsWith(v1416,
                                                                                              v1418.clone(),
                                                                                              false)
                                                                                   {
                                                                                    Spiral_builder::US12::US12_1(v1418.clone())
                                                                                } else {
                                                                                    Spiral_builder::US12::US12_0(v1418)
                                                                                };
                                                                        let v1428:
                                                                                    Result<string,
                                                                                           string> =
                                                                                match &v1422
                                                                                    {
                                                                                    Spiral_builder::US12::US12_0(v1422_0_0)
                                                                                    =>
                                                                                    Ok::<string,
                                                                                         string>(v1422_0_0.clone()),
                                                                                    Spiral_builder::US12::US12_1(v1422_1_0)
                                                                                    =>
                                                                                    Err::<string,
                                                                                          string>(v1422_1_0.clone()),
                                                                                };
                                                                        let v1430: bool = true;
                                                                        let _result = v1428
                                                                            .unwrap_or_else(|x| {
                                                                                //;
                                                                                let v1432: string =
                                                                                    x;
                                                                                let v1434: bool =
                                                                                    true;
                                                                                v1432
                                                                            });
                                                                        let v1436: string = _result;
                                                                        let v1438:
                                                                                    string =
                                                                                Spiral_builder::method14(v1436.clone(),
                                                                                                         string("lib/typescript/fable/fable_modules"));
                                                                        let v1440:
                                                                                    async_walkdir::WalkDir =
                                                                                async_walkdir::WalkDir::new(&*v1438.clone());
                                                                        let v1443:
                                                                                    async_walkdir::WalkDir =
                                                                                async_walkdir::WalkDir::filter(v1440, |x| Func1::new(move
                                                                                                                                         |v_6:
                                                                                                                                              async_walkdir::DirEntry|
                                                                                                                                         Spiral_builder::closure87((),
                                                                                                                                                                   v_6))(x));
                                                                        let v1444 =
                                                                                Spiral_builder::method112();
                                                                        let v1446:
                                                                                    Vec<(string,
                                                                                         string)> =
                                                                                tokio_stream::StreamExt::collect(tokio_stream::StreamExt::filter_map(v1443, |x| v1444(x))).await;
                                                                        let v1448:
                                                                                    rayon::vec::IntoIter<(string,
                                                                                                          string)> =
                                                                                rayon::iter::IntoParallelIterator::into_par_iter(v1446);
                                                                        let v1451:
                                                                                    rayon::iter::Map<rayon::vec::IntoIter<(string,
                                                                                                                           string)>, _> =
                                                                                rayon::iter::ParallelIterator::map(v1448, |x| Func1::new(move
                                                                                                                                             |arg10_0040_22:
                                                                                                                                                  (string,
                                                                                                                                                   string)|
                                                                                                                                             Spiral_builder::closure95((),
                                                                                                                                                                       arg10_0040_22))(x));
                                                                        let v1453:
                                                                                    Vec<(string,
                                                                                         string)> =
                                                                                rayon::iter::ParallelIterator::collect(v1451);
                                                                        let v1458:
                                                                                    Option<(string,
                                                                                            string)> =
                                                                                tryItem(0_i32,
                                                                                        fable_library_rust::NativeArray_::array_from(v1453));
                                                                        let _v1459:
                                                                                    LrcPtr<MutCell<Option<Spiral_builder::US39>>> =
                                                                                refCell(None::<Spiral_builder::US39>);
                                                                        {
                                                                            let x_70:
                                                                                        Option<Spiral_builder::US39> =
                                                                                    match &v1458
                                                                                        {
                                                                                        None
                                                                                        =>
                                                                                        None::<Spiral_builder::US39>,
                                                                                        Some(v1458_0_0)
                                                                                        =>
                                                                                        {
                                                                                            let x_68:
                                                                                                    (string,
                                                                                                     string) =
                                                                                                v1458_0_0.clone();
                                                                                            Some((Func0::new({
                                                                                                                 let x_68
                                                                                                                     =
                                                                                                                     x_68.clone();
                                                                                                                 move
                                                                                                                     ||
                                                                                                                     Spiral_builder::US39::US39_0(x_68.0.clone(),
                                                                                                                                                  x_68.1.clone())
                                                                                                             }))())
                                                                                        }
                                                                                    };
                                                                            _v1459.set(x_70)
                                                                        }
                                                                        {
                                                                            let v1465:
                                                                                        Spiral_builder::US39 =
                                                                                    defaultValue(Spiral_builder::US39::US39_1,
                                                                                                 _v1459.get().clone());
                                                                            Spiral_builder::method5(Spiral_builder::US0::US0_1,
                                                                                                        Func0::new(move
                                                                                                                       ||
                                                                                                                       Spiral_builder::closure96((),
                                                                                                                                                 ())),
                                                                                                        Func0::new({
                                                                                                                       let v1465
                                                                                                                           =
                                                                                                                           v1465.clone();
                                                                                                                       move
                                                                                                                           ||
                                                                                                                           Spiral_builder::closure97(v1465.clone(),
                                                                                                                                                     ())
                                                                                                                   }));
                                                                            match &v1465
                                                                                    {
                                                                                    Spiral_builder::US39::US39_0(v1465_0_0,
                                                                                                                 v1465_0_1)
                                                                                    =>
                                                                                    {
                                                                                        let v1470:
                                                                                                string =
                                                                                            match &v1465
                                                                                                {
                                                                                                Spiral_builder::US39::US39_0(_,
                                                                                                                             x)
                                                                                                =>
                                                                                                x.clone(),
                                                                                                _
                                                                                                =>
                                                                                                unreachable!(),
                                                                                            };
                                                                                        Spiral_builder::method98(Spiral_builder::method14(v1438,
                                                                                                                                          sprintf!("fable-library-{}.{}",
                                                                                                                                                   string("ts"),
                                                                                                                                                   v1470.clone())),
                                                                                                                 Spiral_builder::method14(v1409.clone(),
                                                                                                                                          sprintf!("fable_modules/fable-library-{}.{}",
                                                                                                                                                   string("ts"),
                                                                                                                                                   v1470)))
                                                                                    }
                                                                                    _
                                                                                    =>
                                                                                    (),
                                                                                }
                                                                            {
                                                                                let patternInput_12:
                                                                                            (i32,
                                                                                             string) =
                                                                                        Spiral_builder::method99(v1409.clone(),
                                                                                                                 string("ts"),
                                                                                                                 v1310,
                                                                                                                 v1422.clone());
                                                                                let v1476: string =
                                                                                    patternInput_12
                                                                                        .1
                                                                                        .clone();
                                                                                let v1475: i32 =
                                                                                    patternInput_12
                                                                                        .0
                                                                                        .clone();
                                                                                if v1475 != 0_i32 {
                                                                                    Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                Func0::new({
                                                                                                                               let v1475
                                                                                                                                   =
                                                                                                                                   v1475.clone();
                                                                                                                               let v1476
                                                                                                                                   =
                                                                                                                                   v1476.clone();
                                                                                                                               move
                                                                                                                                   ||
                                                                                                                                   Spiral_builder::closure98(v1476.clone(),
                                                                                                                                                             v1475,
                                                                                                                                                             ())
                                                                                                                           }),
                                                                                                                Func0::new(move
                                                                                                                               ||
                                                                                                                               Spiral_builder::closure6((),
                                                                                                                                                        ())));
                                                                                    (Spiral_builder::US3::US3_1,
                                                                                         Spiral_builder::US3::US3_0(string("ts")),
                                                                                         Spiral_builder::US3::US3_0(v1476.clone()))
                                                                                } else {
                                                                                    let v1485:
                                                                                                bool =
                                                                                            true;
                                                                                    let _result : Vec<_> = v1247.into_iter().map(|x| { //;
                                                                                        let v1487:
                                                                                                std::string::String =
                                                                                            x;
                                                                                        let v1489:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromString(v1487);
                                                                                        let v1493:
                                                                                                string =
                                                                                            if contains(v1489.clone(),
                                                                                                        string("="))
                                                                                               {
                                                                                                v1489.clone()
                                                                                            } else {
                                                                                                sprintf!("\"{}\":\"*\"",
                                                                                                         v1489)
                                                                                            };
                                                                                        let v1495:
                                                                                                bool =
                                                                                            true; v1493 }).collect::<Vec<_>>();
                                                                                    let v1497: Vec<
                                                                                        string,
                                                                                    > = _result;
                                                                                    let v1499:
                                                                                                Array<string> =
                                                                                            fable_library_rust::NativeArray_::array_from(v1497);
                                                                                    let v1518:
                                                                                                string =
                                                                                            append(append(append(append(append(append(append(string("{"),
                                                                                                                                             sprintf!("  \"name\": \"spiral_builder_{}\",",
                                                                                                                                                      v1276)),
                                                                                                                                      string("  \"dependencies\": {")),
                                                                                                                               join(string(",\n"),
                                                                                                                                    toArray_1(delay(Func0::new({
                                                                                                                                                                   let v1499
                                                                                                                                                                       =
                                                                                                                                                                       v1499.clone();
                                                                                                                                                                   move
                                                                                                                                                                       ||
                                                                                                                                                                       map(Func1::new({
                                                                                                                                                                                          let v1499
                                                                                                                                                                                              =
                                                                                                                                                                                              v1499.clone();
                                                                                                                                                                                          move
                                                                                                                                                                                              |i_6:
                                                                                                                                                                                                   i32|
                                                                                                                                                                                              v1499[i_6].clone()
                                                                                                                                                                                      }),
                                                                                                                                                                           rangeNumeric(0_i32,
                                                                                                                                                                                        1_i32,
                                                                                                                                                                                        count_2(v1499.clone())
                                                                                                                                                                                            -
                                                                                                                                                                                            1_i32))
                                                                                                                                                               }))))),
                                                                                                                        string("  },")),
                                                                                                                 string("    \"devDependencies\": {")),
                                                                                                          string("  },")),
                                                                                                   string("}"));
                                                                                    let v1520:
                                                                                                string =
                                                                                            Spiral_builder::method14(v1409.clone(),
                                                                                                                     string("package.json"));
                                                                                    let v1523:
                                                                                                string =
                                                                                            Spiral_builder::method14(Spiral_builder::method14(v1409.clone(),
                                                                                                                                              string("../..")),
                                                                                                                     string("package.json"));
                                                                                    Spiral_builder::method24(v1520,
                                                                                                                 v1518);
                                                                                    Spiral_builder::method24(v1523,
                                                                                                                 string(""));
                                                                                    {
                                                                                        let v1526:
                                                                                                    string =
                                                                                                Spiral_builder::method14(v1409,
                                                                                                                         sprintf!("{}.{}",
                                                                                                                                  string("spiral_builder"),
                                                                                                                                  string("ts")));
                                                                                        Spiral_builder::method5(Spiral_builder::US0::US0_1,
                                                                                                                    Func0::new(move
                                                                                                                                   ||
                                                                                                                                   Spiral_builder::closure99((),
                                                                                                                                                             ())),
                                                                                                                    Func0::new({
                                                                                                                                   let v1526
                                                                                                                                       =
                                                                                                                                       v1526.clone();
                                                                                                                                   move
                                                                                                                                       ||
                                                                                                                                       Spiral_builder::closure100(v1526.clone(),
                                                                                                                                                                  ())
                                                                                                                               }));
                                                                                        {
                                                                                            let _v1530:
                                                                                                        MutCell<Option<string>> =
                                                                                                    MutCell::new(None::<string>);
                                                                                            let _v1531:
                                                                                                        MutCell<Option<Vec<u8>>> =
                                                                                                    MutCell::new(None::<Vec<u8>>);
                                                                                            {
                                                                                                let x_71:
                                                                                                            Vec<u8> =
                                                                                                        std::fs::read(&*v1526.clone()).unwrap();
                                                                                                _v1531.set(Some(x_71))
                                                                                            }
                                                                                            {
                                                                                                let v1541:
                                                                                                            Vec<u8> =
                                                                                                        match &_v1531.get().clone()
                                                                                                            {
                                                                                                            None
                                                                                                            =>
                                                                                                            panic!("{}",
                                                                                                                   string("base.run_target / _v1531=None"),),
                                                                                                            Some(_v1531_0_0)
                                                                                                            =>
                                                                                                            _v1531_0_0.clone(),
                                                                                                        };
                                                                                                let v1543:
                                                                                                            Result<std::string::String,
                                                                                                                   std::string::FromUtf8Error> =
                                                                                                        std::string::String::from_utf8(v1541);
                                                                                                let v1545:
                                                                                                            std::string::String =
                                                                                                        v1543.unwrap();
                                                                                                {
                                                                                                    let x_73:
                                                                                                                string =
                                                                                                            fable_library_rust::String_::fromString(v1545);
                                                                                                    _v1530.set(Some(x_73))
                                                                                                }
                                                                                                {
                                                                                                    let v1553:
                                                                                                                string =
                                                                                                            match &_v1530.get().clone()
                                                                                                                {
                                                                                                                None
                                                                                                                =>
                                                                                                                panic!("{}",
                                                                                                                       string("base.run_target / _v1530=None"),),
                                                                                                                Some(_v1530_0_0)
                                                                                                                =>
                                                                                                                _v1530_0_0.clone(),
                                                                                                            };
                                                                                                    let v1555:
                                                                                                                bool =
                                                                                                            contains(v1553.clone(),
                                                                                                                     string("// spiral_builder.process_typescript"));
                                                                                                    let v1580:
                                                                                                                string =
                                                                                                            if v1555
                                                                                                               {
                                                                                                                v1553.clone()
                                                                                                            } else {
                                                                                                                let v1558:
                                                                                                                        string =
                                                                                                                    replace(v1553,
                                                                                                                            sprintf!("\"./fable_modules/fable-library-ts.{}/",
                                                                                                                                     v1465.clone()),
                                                                                                                            sprintf!("\"{}/lib/typescript/fable/fable_modules/fable-library-ts.{}/",
                                                                                                                                     v1436,
                                                                                                                                     v1465.clone()));
                                                                                                                let v1559:
                                                                                                                        string =
                                                                                                                    Spiral_builder::method103();
                                                                                                                let _v1560:
                                                                                                                        MutCell<Option<string>> =
                                                                                                                    MutCell::new(None::<string>);
                                                                                                                let v1561:
                                                                                                                        string =
                                                                                                                    Spiral_builder::method72(v1558);
                                                                                                                let v1564:
                                                                                                                        Result<regex::Regex,
                                                                                                                               regex::Error> =
                                                                                                                    regex::Regex::new(&string("\\s\\sdefaultOf\\(\\);"));
                                                                                                                let v1566:
                                                                                                                        regex::Regex =
                                                                                                                    v1564.unwrap();
                                                                                                                let v1568:
                                                                                                                        std::borrow::Cow<str> =
                                                                                                                    v1566.replace_all(&v1561, &*v1559);
                                                                                                                let v1570:
                                                                                                                        std::string::String =
                                                                                                                    String::from(v1568);
                                                                                                                {
                                                                                                                    let x_75:
                                                                                                                            string =
                                                                                                                        fable_library_rust::String_::fromString(v1570);
                                                                                                                    _v1560.set(Some(x_75))
                                                                                                                }
                                                                                                                match &_v1560.get().clone()
                                                                                                                    {
                                                                                                                    None
                                                                                                                    =>
                                                                                                                    panic!("{}",
                                                                                                                           string("base.run_target / _v1560=None"),),
                                                                                                                    Some(_v1560_0_0)
                                                                                                                    =>
                                                                                                                    _v1560_0_0.clone(),
                                                                                                                }
                                                                                                            };
                                                                                                    if v1555
                                                                                                               ==
                                                                                                               false
                                                                                                           {
                                                                                                            Spiral_builder::method24(v1526.clone(),
                                                                                                                                     sprintf!("{}\n\n{}\n",
                                                                                                                                              v1580.clone(),
                                                                                                                                              string("// spiral_builder.process_typescript")));
                                                                                                        }
                                                                                                    {
                                                                                                        let v1583:
                                                                                                                    string =
                                                                                                                sprintf!("bun run \"{}\"",
                                                                                                                         v1526.clone());
                                                                                                        let v1586:
                                                                                                                    Array<(string,
                                                                                                                           string)> =
                                                                                                                new_array(&[(string("TRACE_LEVEL"),
                                                                                                                             string("Verbose"))]);
                                                                                                        let v1597:
                                                                                                                    Result<string,
                                                                                                                           string> =
                                                                                                                match &v1422
                                                                                                                    {
                                                                                                                    Spiral_builder::US12::US12_0(v1422_0_0)
                                                                                                                    =>
                                                                                                                    Ok::<string,
                                                                                                                         string>(v1422_0_0.clone()),
                                                                                                                    Spiral_builder::US12::US12_1(v1422_1_0)
                                                                                                                    =>
                                                                                                                    Err::<string,
                                                                                                                          string>(v1422_1_0.clone()),
                                                                                                                };
                                                                                                        let patternInput_13:
                                                                                                                    (i32,
                                                                                                                     string) =
                                                                                                                Spiral_builder::method28(None::<CancellationToken>,
                                                                                                                                         v1583.clone(),
                                                                                                                                         v1586.clone(),
                                                                                                                                         None::<Func1<(bool,
                                                                                                                                                       string,
                                                                                                                                                       i32),
                                                                                                                                                      Arc<Async<()>>>>,
                                                                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                                      ()>>,
                                                                                                                                         true,
                                                                                                                                         v1597.ok());
                                                                                                        let v1602:
                                                                                                                    string =
                                                                                                                patternInput_13.1.clone();
                                                                                                        let v1601:
                                                                                                                    i32 =
                                                                                                                patternInput_13.0.clone();
                                                                                                        let v1603:
                                                                                                                    i32 =
                                                                                                                count_2(v1586.clone());
                                                                                                        let v1604:
                                                                                                                    Array<string> =
                                                                                                                new_init(&string(""),
                                                                                                                         v1603);
                                                                                                        let v1605:
                                                                                                                    LrcPtr<Spiral_builder::Mut4> =
                                                                                                                LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                                     MutCell::new(0_i32),});
                                                                                                        while Spiral_builder::method32(v1603,
                                                                                                                                           v1605.clone())
                                                                                                                  {
                                                                                                                let v1607:
                                                                                                                        i32 =
                                                                                                                    v1605.l0.get().clone();
                                                                                                                let patternInput_14:
                                                                                                                        (string,
                                                                                                                         string) =
                                                                                                                    v1586[v1607].clone();
                                                                                                                let v1610:
                                                                                                                        string =
                                                                                                                    sprintf!("$env:{}=\'\'{}\'\'",
                                                                                                                             patternInput_14.0.clone(),
                                                                                                                             patternInput_14.1.clone());
                                                                                                                v1604.get_mut()[v1607
                                                                                                                                    as
                                                                                                                                    usize]
                                                                                                                    =
                                                                                                                    v1610;
                                                                                                                {
                                                                                                                    let v1611:
                                                                                                                            i32 =
                                                                                                                        v1607
                                                                                                                            +
                                                                                                                            1_i32;
                                                                                                                    v1605.l0.set(v1611);
                                                                                                                    ()
                                                                                                                }
                                                                                                            }
                                                                                                        {
                                                                                                            let v1618:
                                                                                                                        string =
                                                                                                                    sprintf!("pwsh -c \'{}; {}\'",
                                                                                                                             join(string(";"),
                                                                                                                                  toArray_1(ofArray_1(v1604.clone()))),
                                                                                                                             v1583);
                                                                                                            if v1601
                                                                                                                       ==
                                                                                                                       0_i32
                                                                                                                   {
                                                                                                                    let v1623:
                                                                                                                            Spiral_builder::US3 =
                                                                                                                        try_catch(||
                                                                                                                                      Spiral_builder::closure43((),
                                                                                                                                                                Spiral_builder::closure101(v1602.clone(),
                                                                                                                                                                                           ())),
                                                                                                                                  |ex_2:
                                                                                                                                       LrcPtr<Exception>|
                                                                                                                                      Spiral_builder::closure102(v1526.clone(),
                                                                                                                                                                 v1602.clone(),
                                                                                                                                                                 v1618.clone(),
                                                                                                                                                                 ex_2.clone()));
                                                                                                                    let v1628:
                                                                                                                            Option<string> =
                                                                                                                        match &v1623
                                                                                                                            {
                                                                                                                            Spiral_builder::US3::US3_0(v1623_0_0)
                                                                                                                            =>
                                                                                                                            Some(match &v1623
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
                                                                                                                    (Spiral_builder::US3::US3_0(v1580),
                                                                                                                     Spiral_builder::US3::US3_0(string("ts")),
                                                                                                                     Spiral_builder::US3::US3_0(v1628.unwrap()))
                                                                                                                } else {
                                                                                                                    Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                                            Func0::new(move
                                                                                                                                                           ||
                                                                                                                                                           Spiral_builder::closure105((),
                                                                                                                                                                                      ())),
                                                                                                                                            Func0::new({
                                                                                                                                                           let v1526
                                                                                                                                                               =
                                                                                                                                                               v1526.clone();
                                                                                                                                                           let v1601
                                                                                                                                                               =
                                                                                                                                                               v1601.clone();
                                                                                                                                                           let v1602
                                                                                                                                                               =
                                                                                                                                                               v1602.clone();
                                                                                                                                                           let v1618
                                                                                                                                                               =
                                                                                                                                                               v1618.clone();
                                                                                                                                                           move
                                                                                                                                                               ||
                                                                                                                                                               Spiral_builder::closure106(v1526.clone(),
                                                                                                                                                                                          v1602.clone(),
                                                                                                                                                                                          v1601,
                                                                                                                                                                                          v1618.clone(),
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
                                            } else {
                                                if fable_library_rust::String_::fromString(
                                                    v13.clone(),
                                                ) == string("python")
                                                {
                                                    let v1650: string = Spiral_builder::method63();
                                                    let v1652: &str = &*v1650;
                                                    let v1654: Option<std::string::String> =
                                                        clap::ArgMatches::get_one(
                                                            &v14.clone(),
                                                            v1652,
                                                        )
                                                        .cloned();
                                                    let _v1655: LrcPtr<
                                                        MutCell<Option<Spiral_builder::US5>>,
                                                    > = refCell(None::<Spiral_builder::US5>);
                                                    {
                                                        let x_79: Option<Spiral_builder::US5> =
                                                            match &v1654 {
                                                                None => None::<Spiral_builder::US5>,
                                                                Some(v1654_0_0) => {
                                                                    let x_77: std::string::String =
                                                                        v1654_0_0.clone();
                                                                    Some((Func0::new({
                                                                        let x_77 = x_77.clone();
                                                                        move || {
                                                                            Spiral_builder::US5::US5_0(x_77.clone())
                                                                        }
                                                                    }))(
                                                                    ))
                                                                }
                                                            };
                                                        _v1655.set(x_79)
                                                    }
                                                    {
                                                        let v1660: Spiral_builder::US5 =
                                                            defaultValue(
                                                                Spiral_builder::US5::US5_1,
                                                                _v1655.get().clone(),
                                                            );
                                                        let v1664:
                                                                    std::string::String =
                                                                match &v1660 {
                                                                    Spiral_builder::US5::US5_0(v1660_0_0)
                                                                    =>
                                                                    match &v1660
                                                                        {
                                                                        Spiral_builder::US5::US5_0(x)
                                                                        =>
                                                                        x.clone(),
                                                                        _ =>
                                                                        unreachable!(),
                                                                    },
                                                                    _ =>
                                                                    panic!("{}",
                                                                           string("Option does not have a value."),),
                                                                };
                                                        let v1666: string =
                                                            fable_library_rust::String_::fromString(
                                                                v1664,
                                                            );
                                                        let v1667: string =
                                                            Spiral_builder::method13();
                                                        let v1669: &str = &*v1667;
                                                        let v1671: Option<
                                                            Vec<std::string::String>,
                                                        > = clap::ArgMatches::get_many(
                                                            &v14.clone(),
                                                            v1669,
                                                        )
                                                        .map(|x| x.cloned().into_iter().collect());
                                                        let _v1672: LrcPtr<
                                                            MutCell<Option<Spiral_builder::US9>>,
                                                        > = refCell(None::<Spiral_builder::US9>);
                                                        {
                                                            let x_82: Option<Spiral_builder::US9> =
                                                                match &v1671 {
                                                                    None => {
                                                                        None::<Spiral_builder::US9>
                                                                    }
                                                                    Some(v1671_0_0) => {
                                                                        let x_80: Vec<
                                                                            std::string::String,
                                                                        > = v1671_0_0.clone();
                                                                        Some((Func0::new({
                                                                            let x_80 = x_80.clone();
                                                                            move || {
                                                                                Spiral_builder::US9::US9_0(x_80.clone())
                                                                            }
                                                                        }))(
                                                                        ))
                                                                    }
                                                                };
                                                            _v1672.set(x_82)
                                                        }
                                                        {
                                                            let v1677: Spiral_builder::US9 =
                                                                defaultValue(
                                                                    Spiral_builder::US9::US9_1,
                                                                    _v1672.get().clone(),
                                                                );
                                                            let v1680: Vec<std::string::String> =
                                                                new_empty::<std::string::String>()
                                                                    .to_vec();
                                                            let v1683:
                                                                        Vec<std::string::String> =
                                                                    match &v1677
                                                                        {
                                                                        Spiral_builder::US9::US9_0(v1677_0_0)
                                                                        =>
                                                                        match &v1677
                                                                            {
                                                                            Spiral_builder::US9::US9_0(x)
                                                                            =>
                                                                            x.clone(),
                                                                            _
                                                                            =>
                                                                            unreachable!(),
                                                                        },
                                                                        _ =>
                                                                        v1680,
                                                                    };
                                                            let v1685: bool =
                                                                if let Spiral_builder::US0::US0_0 =
                                                                    &v0_1
                                                                {
                                                                    true
                                                                } else {
                                                                    false
                                                                };
                                                            let _v1686: MutCell<Option<string>> =
                                                                MutCell::new(None::<string>);
                                                            let _v1687: MutCell<Option<Vec<u8>>> =
                                                                MutCell::new(None::<Vec<u8>>);
                                                            {
                                                                let x_83: Vec<u8> =
                                                                    std::fs::read(&*v1666).unwrap();
                                                                _v1687.set(Some(x_83))
                                                            }
                                                            {
                                                                let v1697:
                                                                            Vec<u8> =
                                                                        match &_v1687.get().clone()
                                                                            {
                                                                            None
                                                                            =>
                                                                            panic!("{}",
                                                                                   string("base.run_target / _v1687=None"),),
                                                                            Some(_v1687_0_0)
                                                                            =>
                                                                            _v1687_0_0.clone(),
                                                                        };
                                                                let v1699: Result<
                                                                    std::string::String,
                                                                    std::string::FromUtf8Error,
                                                                > = std::string::String::from_utf8(
                                                                    v1697,
                                                                );
                                                                let v1701: std::string::String =
                                                                    v1699.unwrap();
                                                                {
                                                                    let x_85:
                                                                                string =
                                                                            fable_library_rust::String_::fromString(v1701);
                                                                    _v1686.set(Some(x_85))
                                                                }
                                                                {
                                                                    let v1709:
                                                                                string =
                                                                            match &_v1686.get().clone()
                                                                                {
                                                                                None
                                                                                =>
                                                                                panic!("{}",
                                                                                       string("base.run_target / _v1686=None"),),
                                                                                Some(_v1686_0_0)
                                                                                =>
                                                                                _v1686_0_0.clone(),
                                                                            };
                                                                    let v1712: string =
                                                                        Spiral_builder::method80(
                                                                            sprintf!(
                                                                                "{:?}",
                                                                                (
                                                                                    string("py"),
                                                                                    v1709.clone()
                                                                                )
                                                                            ),
                                                                        );
                                                                    let v1725:
                                                                                string =
                                                                            Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method14(Spiral_builder::method17(Spiral_builder::method14(string("polyglot"),
                                                                                                                                                                                                                                                           string(".paket")),
                                                                                                                                                                                                                                  string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder")),
                                                                                                                                                                                                         string("polyglot")),
                                                                                                                                                                                string("target/spiral_builder")),
                                                                                                                                                       string("spiral_builder")),
                                                                                                                              string("packages")),
                                                                                                     v1712.clone());
                                                                    let v1726: LrcPtr<
                                                                        dyn IDisposable,
                                                                    > = Spiral_builder::method82(
                                                                        v1725.clone(),
                                                                    );
                                                                    let v1729:
                                                                                string =
                                                                            Spiral_builder::method70(Spiral_builder::method14(v1725.clone(),
                                                                                                                              sprintf!("{}.fs",
                                                                                                                                       string("spiral_builder"))));
                                                                    Spiral_builder::method24(
                                                                        v1729.clone(),
                                                                        v1709,
                                                                    );
                                                                    {
                                                                        let v1730: List<string> =
                                                                            empty::<string>();
                                                                        let v1735: string = join(
                                                                            string("\\n        "),
                                                                            toArray_1(delay(
                                                                                Func0::new({
                                                                                    let v1730 =
                                                                                        v1730
                                                                                            .clone(
                                                                                            );
                                                                                    move || {
                                                                                        map(Func1::new({
                                                                                                                                           let v1730
                                                                                                                                               =
                                                                                                                                               v1730.clone();
                                                                                                                                           move
                                                                                                                                               |i_7:
                                                                                                                                                    i32|
                                                                                                                                               item(i_7,
                                                                                                                                                    v1730.clone())
                                                                                                                                       }),
                                                                                                                            rangeNumeric(0_i32,
                                                                                                                                         1_i32,
                                                                                                                                         length_1(v1730.clone())
                                                                                                                                             -
                                                                                                                                             1_i32))
                                                                                    }
                                                                                }),
                                                                            )),
                                                                        );
                                                                        let v1739:
                                                                                    List<string> =
                                                                                singleton(sprintf!("<PackageReference Include=\"{}\" Version=\"*\" />",
                                                                                                   string("Fable.Core")));
                                                                        let v1743: string = join(
                                                                            string("\\n        "),
                                                                            toArray_1(delay(
                                                                                Func0::new({
                                                                                    let v1739 =
                                                                                        v1739
                                                                                            .clone(
                                                                                            );
                                                                                    move || {
                                                                                        map(Func1::new({
                                                                                                                                           let v1739
                                                                                                                                               =
                                                                                                                                               v1739.clone();
                                                                                                                                           move
                                                                                                                                               |i_8:
                                                                                                                                                    i32|
                                                                                                                                               item(i_8,
                                                                                                                                                    v1739.clone())
                                                                                                                                       }),
                                                                                                                            rangeNumeric(0_i32,
                                                                                                                                         1_i32,
                                                                                                                                         length_1(v1739.clone())
                                                                                                                                             -
                                                                                                                                             1_i32))
                                                                                    }
                                                                                }),
                                                                            )),
                                                                        );
                                                                        let v1746:
                                                                                    string =
                                                                                Spiral_builder::method70(Spiral_builder::method14(v1725,
                                                                                                                                  sprintf!("{}.fsproj",
                                                                                                                                           string("spiral_builder"))));
                                                                        Spiral_builder::method24(v1746.clone(),
                                                                                                     append(append(append(append(append(append(append(append(append(append(append(append(append(string("<Project Sdk=\"Microsoft.NET.Sdk\">\n<PropertyGroup>\n    <TargetFramework>net9.0</TargetFramework>\n    <LangVersion>preview</LangVersion>\n    <RollForward>Major</RollForward>\n    <TargetLatestRuntimePatch>true</TargetLatestRuntimePatch>\n    <PublishAot>false</PublishAot>\n    <PublishTrimmed>false</PublishTrimmed>\n    <PublishSingleFile>true</PublishSingleFile>\n    <SelfContained>true</SelfContained>\n    <Version>0.0.1-alpha.1</Version>\n    <OutputType>Exe</OutputType>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'FreeBSD\'))\">\n    <DefineConstants>_FREEBSD</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Linux\'))\">\n    <DefineConstants>_LINUX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'OSX\'))\">\n    <DefineConstants>_OSX</DefineConstants>\n</PropertyGroup>\n<PropertyGroup Condition=\"$([MSBuild]::IsOSPlatform(\'Windows\'))\">\n    <DefineConstants>_WINDOWS</DefineConstants>\n</PropertyGroup>\n<ItemGroup>\n"),
                                                                                                                                                                                                sprintf!("    {}",
                                                                                                                                                                                                         v1735)),
                                                                                                                                                                                         string("\n")),
                                                                                                                                                                                  sprintf!("    <Compile Include=\"{}\" />",
                                                                                                                                                                                           v1729)),
                                                                                                                                                                           string("\n")),
                                                                                                                                                                    string("</ItemGroup>")),
                                                                                                                                                             string("\n")),
                                                                                                                                                      string("<ItemGroup>")),
                                                                                                                                               string("\n")),
                                                                                                                                        sprintf!("    {}",
                                                                                                                                                 v1743)),
                                                                                                                                 string("\n")),
                                                                                                                          string("</ItemGroup>")),
                                                                                                                   string("\n")),
                                                                                                            string("</Project>")));
                                                                        {
                                                                            let v1845:
                                                                                        string =
                                                                                    Spiral_builder::method23(v1746.clone());
                                                                            let v1849:
                                                                                        string =
                                                                                    Spiral_builder::method14(Spiral_builder::method17(Spiral_builder::method14(string("polyglot"),
                                                                                                                                                               string(".paket")),
                                                                                                                                      string("C:\\home\\git\\polyglot\\target\\Builder\\spiral_builder")),
                                                                                                             string("polyglot"));
                                                                            let v1852:
                                                                                        string =
                                                                                    toLower(Spiral_builder::method22());
                                                                            let v1854: string =
                                                                                toLower(v1849);
                                                                            let v1858:
                                                                                        Spiral_builder::US12 =
                                                                                    if startsWith(v1852,
                                                                                                  v1854.clone(),
                                                                                                  false)
                                                                                       {
                                                                                        Spiral_builder::US12::US12_1(v1854.clone())
                                                                                    } else {
                                                                                        Spiral_builder::US12::US12_0(v1854)
                                                                                    };
                                                                            let v1864:
                                                                                        Result<string,
                                                                                               string> =
                                                                                    match &v1858
                                                                                        {
                                                                                        Spiral_builder::US12::US12_0(v1858_0_0)
                                                                                        =>
                                                                                        Ok::<string,
                                                                                             string>(v1858_0_0.clone()),
                                                                                        Spiral_builder::US12::US12_1(v1858_1_0)
                                                                                        =>
                                                                                        Err::<string,
                                                                                              string>(v1858_1_0.clone()),
                                                                                    };
                                                                            let v1866: bool = true;
                                                                            let _result = v1864
                                                                                .unwrap_or_else(
                                                                                    |x| {
                                                                                        //;
                                                                                        let v1868:
                                                                                        string =
                                                                                    x;
                                                                                        let v1870:
                                                                                        bool =
                                                                                    true;
                                                                                        v1868
                                                                                    },
                                                                                );
                                                                            Spiral_builder::method98(Spiral_builder::method14(Spiral_builder::method14(_result,
                                                                                                                                                           string("lib/python/fable/fable_modules")),
                                                                                                                                  sprintf!("fable-library-{}",
                                                                                                                                           string("py"))),
                                                                                                         Spiral_builder::method14(v1845.clone(),
                                                                                                                                  string("fable_modules/fable-library")));
                                                                            {
                                                                                let patternInput_15:
                                                                                            (i32,
                                                                                             string) =
                                                                                        Spiral_builder::method99(v1845.clone(),
                                                                                                                 string("py"),
                                                                                                                 v1746,
                                                                                                                 v1858.clone());
                                                                                let v1880: string =
                                                                                    patternInput_15
                                                                                        .1
                                                                                        .clone();
                                                                                let v1879: i32 =
                                                                                    patternInput_15
                                                                                        .0
                                                                                        .clone();
                                                                                if v1879 != 0_i32 {
                                                                                    Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                Func0::new({
                                                                                                                               let v1879
                                                                                                                                   =
                                                                                                                                   v1879.clone();
                                                                                                                               let v1880
                                                                                                                                   =
                                                                                                                                   v1880.clone();
                                                                                                                               move
                                                                                                                                   ||
                                                                                                                                   Spiral_builder::closure107(v1880.clone(),
                                                                                                                                                              v1879,
                                                                                                                                                              ())
                                                                                                                           }),
                                                                                                                Func0::new(move
                                                                                                                               ||
                                                                                                                               Spiral_builder::closure6((),
                                                                                                                                                        ())));
                                                                                    (Spiral_builder::US3::US3_1,
                                                                                         Spiral_builder::US3::US3_0(string("py")),
                                                                                         Spiral_builder::US3::US3_0(v1880.clone()))
                                                                                } else {
                                                                                    let v1889:
                                                                                                bool =
                                                                                            true;
                                                                                    let _result : Vec<_> = v1683.into_iter().map(|x| { //;
                                                                                        let v1891:
                                                                                                std::string::String =
                                                                                            x;
                                                                                        let v1893:
                                                                                                string =
                                                                                            fable_library_rust::String_::fromString(v1891);
                                                                                        let v1897:
                                                                                                string =
                                                                                            if contains(v1893.clone(),
                                                                                                        string("="))
                                                                                               {
                                                                                                v1893.clone()
                                                                                            } else {
                                                                                                sprintf!("\"{}\":\"*\"",
                                                                                                         v1893)
                                                                                            };
                                                                                        let v1899:
                                                                                                bool =
                                                                                            true; v1897 }).collect::<Vec<_>>();
                                                                                    let v1901: Vec<
                                                                                        string,
                                                                                    > = _result;
                                                                                    let v1903:
                                                                                                Array<string> =
                                                                                            fable_library_rust::NativeArray_::array_from(v1901);
                                                                                    let v1922:
                                                                                                string =
                                                                                            append(append(append(append(append(append(append(string("{"),
                                                                                                                                             sprintf!("  \"name\": \"spiral_builder_{}\",",
                                                                                                                                                      v1712)),
                                                                                                                                      string("  \"dependencies\": {")),
                                                                                                                               join(string(",\n"),
                                                                                                                                    toArray_1(delay(Func0::new({
                                                                                                                                                                   let v1903
                                                                                                                                                                       =
                                                                                                                                                                       v1903.clone();
                                                                                                                                                                   move
                                                                                                                                                                       ||
                                                                                                                                                                       map(Func1::new({
                                                                                                                                                                                          let v1903
                                                                                                                                                                                              =
                                                                                                                                                                                              v1903.clone();
                                                                                                                                                                                          move
                                                                                                                                                                                              |i_9:
                                                                                                                                                                                                   i32|
                                                                                                                                                                                              v1903[i_9].clone()
                                                                                                                                                                                      }),
                                                                                                                                                                           rangeNumeric(0_i32,
                                                                                                                                                                                        1_i32,
                                                                                                                                                                                        count_2(v1903.clone())
                                                                                                                                                                                            -
                                                                                                                                                                                            1_i32))
                                                                                                                                                               }))))),
                                                                                                                        string("  },")),
                                                                                                                 string("    \"devDependencies\": {")),
                                                                                                          string("  },")),
                                                                                                   string("}"));
                                                                                    let v1924:
                                                                                                string =
                                                                                            Spiral_builder::method14(v1845.clone(),
                                                                                                                     string("package.json"));
                                                                                    let v1927:
                                                                                                string =
                                                                                            Spiral_builder::method14(Spiral_builder::method14(v1845.clone(),
                                                                                                                                              string("../..")),
                                                                                                                     string("package.json"));
                                                                                    Spiral_builder::method24(v1924,
                                                                                                                 v1922);
                                                                                    Spiral_builder::method24(v1927,
                                                                                                                 string(""));
                                                                                    {
                                                                                        let v1930:
                                                                                                    string =
                                                                                                Spiral_builder::method14(v1845,
                                                                                                                         sprintf!("{}.{}",
                                                                                                                                  string("spiral_builder"),
                                                                                                                                  string("py")));
                                                                                        Spiral_builder::method5(Spiral_builder::US0::US0_1,
                                                                                                                    Func0::new(move
                                                                                                                                   ||
                                                                                                                                   Spiral_builder::closure108((),
                                                                                                                                                              ())),
                                                                                                                    Func0::new({
                                                                                                                                   let v1930
                                                                                                                                       =
                                                                                                                                       v1930.clone();
                                                                                                                                   move
                                                                                                                                       ||
                                                                                                                                       Spiral_builder::closure109(v1930.clone(),
                                                                                                                                                                  ())
                                                                                                                               }));
                                                                                        {
                                                                                            let _v1934:
                                                                                                        MutCell<Option<string>> =
                                                                                                    MutCell::new(None::<string>);
                                                                                            let _v1935:
                                                                                                        MutCell<Option<Vec<u8>>> =
                                                                                                    MutCell::new(None::<Vec<u8>>);
                                                                                            {
                                                                                                let x_87:
                                                                                                            Vec<u8> =
                                                                                                        std::fs::read(&*v1930.clone()).unwrap();
                                                                                                _v1935.set(Some(x_87))
                                                                                            }
                                                                                            {
                                                                                                let v1945:
                                                                                                            Vec<u8> =
                                                                                                        match &_v1935.get().clone()
                                                                                                            {
                                                                                                            None
                                                                                                            =>
                                                                                                            panic!("{}",
                                                                                                                   string("base.run_target / _v1935=None"),),
                                                                                                            Some(_v1935_0_0)
                                                                                                            =>
                                                                                                            _v1935_0_0.clone(),
                                                                                                        };
                                                                                                let v1947:
                                                                                                            Result<std::string::String,
                                                                                                                   std::string::FromUtf8Error> =
                                                                                                        std::string::String::from_utf8(v1945);
                                                                                                let v1949:
                                                                                                            std::string::String =
                                                                                                        v1947.unwrap();
                                                                                                {
                                                                                                    let x_89:
                                                                                                                string =
                                                                                                            fable_library_rust::String_::fromString(v1949);
                                                                                                    _v1934.set(Some(x_89))
                                                                                                }
                                                                                                {
                                                                                                    let v1957:
                                                                                                                string =
                                                                                                            match &_v1934.get().clone()
                                                                                                                {
                                                                                                                None
                                                                                                                =>
                                                                                                                panic!("{}",
                                                                                                                       string("base.run_target / _v1934=None"),),
                                                                                                                Some(_v1934_0_0)
                                                                                                                =>
                                                                                                                _v1934_0_0.clone(),
                                                                                                            };
                                                                                                    let v1959:
                                                                                                                bool =
                                                                                                            contains(v1957.clone(),
                                                                                                                     string("# spiral_builder.process_python"));
                                                                                                    let v1987:
                                                                                                                string =
                                                                                                            if v1959
                                                                                                               {
                                                                                                                v1957.clone()
                                                                                                            } else {
                                                                                                                let v1965:
                                                                                                                        string =
                                                                                                                    replace(v1957,
                                                                                                                            append(string("),)"),
                                                                                                                                   ";".into()),
                                                                                                                            string("));"));
                                                                                                                let v1966:
                                                                                                                        string =
                                                                                                                    Spiral_builder::method103();
                                                                                                                let _v1967:
                                                                                                                        MutCell<Option<string>> =
                                                                                                                    MutCell::new(None::<string>);
                                                                                                                let v1968:
                                                                                                                        string =
                                                                                                                    Spiral_builder::method72(v1965);
                                                                                                                let v1971:
                                                                                                                        Result<regex::Regex,
                                                                                                                               regex::Error> =
                                                                                                                    regex::Regex::new(&string("\\s\\sdefaultOf\\(\\);"));
                                                                                                                let v1973:
                                                                                                                        regex::Regex =
                                                                                                                    v1971.unwrap();
                                                                                                                let v1975:
                                                                                                                        std::borrow::Cow<str> =
                                                                                                                    v1973.replace_all(&v1968, &*v1966);
                                                                                                                let v1977:
                                                                                                                        std::string::String =
                                                                                                                    String::from(v1975);
                                                                                                                {
                                                                                                                    let x_91:
                                                                                                                            string =
                                                                                                                        fable_library_rust::String_::fromString(v1977);
                                                                                                                    _v1967.set(Some(x_91))
                                                                                                                }
                                                                                                                match &_v1967.get().clone()
                                                                                                                    {
                                                                                                                    None
                                                                                                                    =>
                                                                                                                    panic!("{}",
                                                                                                                           string("base.run_target / _v1967=None"),),
                                                                                                                    Some(_v1967_0_0)
                                                                                                                    =>
                                                                                                                    _v1967_0_0.clone(),
                                                                                                                }
                                                                                                            };
                                                                                                    if v1959
                                                                                                               ==
                                                                                                               false
                                                                                                           {
                                                                                                            Spiral_builder::method24(v1930.clone(),
                                                                                                                                     sprintf!("{}\n\n{}\n",
                                                                                                                                              v1987.clone(),
                                                                                                                                              string("# spiral_builder.process_python")));
                                                                                                        }
                                                                                                    {
                                                                                                        let v1990:
                                                                                                                    string =
                                                                                                                sprintf!("python \"{}\"",
                                                                                                                         v1930.clone());
                                                                                                        let v1993:
                                                                                                                    Array<(string,
                                                                                                                           string)> =
                                                                                                                new_array(&[(string("TRACE_LEVEL"),
                                                                                                                             string("Verbose"))]);
                                                                                                        let v2004:
                                                                                                                    Result<string,
                                                                                                                           string> =
                                                                                                                match &v1858
                                                                                                                    {
                                                                                                                    Spiral_builder::US12::US12_0(v1858_0_0)
                                                                                                                    =>
                                                                                                                    Ok::<string,
                                                                                                                         string>(v1858_0_0.clone()),
                                                                                                                    Spiral_builder::US12::US12_1(v1858_1_0)
                                                                                                                    =>
                                                                                                                    Err::<string,
                                                                                                                          string>(v1858_1_0.clone()),
                                                                                                                };
                                                                                                        let patternInput_16:
                                                                                                                    (i32,
                                                                                                                     string) =
                                                                                                                Spiral_builder::method28(None::<CancellationToken>,
                                                                                                                                         v1990.clone(),
                                                                                                                                         v1993.clone(),
                                                                                                                                         None::<Func1<(bool,
                                                                                                                                                       string,
                                                                                                                                                       i32),
                                                                                                                                                      Arc<Async<()>>>>,
                                                                                                                                         None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
                                                                                                                                                      ()>>,
                                                                                                                                         true,
                                                                                                                                         v2004.ok());
                                                                                                        let v2009:
                                                                                                                    string =
                                                                                                                patternInput_16.1.clone();
                                                                                                        let v2008:
                                                                                                                    i32 =
                                                                                                                patternInput_16.0.clone();
                                                                                                        let v2010:
                                                                                                                    i32 =
                                                                                                                count_2(v1993.clone());
                                                                                                        let v2011:
                                                                                                                    Array<string> =
                                                                                                                new_init(&string(""),
                                                                                                                         v2010);
                                                                                                        let v2012:
                                                                                                                    LrcPtr<Spiral_builder::Mut4> =
                                                                                                                LrcPtr::new(Spiral_builder::Mut4{l0:
                                                                                                                                                     MutCell::new(0_i32),});
                                                                                                        while Spiral_builder::method32(v2010,
                                                                                                                                           v2012.clone())
                                                                                                                  {
                                                                                                                let v2014:
                                                                                                                        i32 =
                                                                                                                    v2012.l0.get().clone();
                                                                                                                let patternInput_17:
                                                                                                                        (string,
                                                                                                                         string) =
                                                                                                                    v1993[v2014].clone();
                                                                                                                let v2017:
                                                                                                                        string =
                                                                                                                    sprintf!("$env:{}=\'\'{}\'\'",
                                                                                                                             patternInput_17.0.clone(),
                                                                                                                             patternInput_17.1.clone());
                                                                                                                v2011.get_mut()[v2014
                                                                                                                                    as
                                                                                                                                    usize]
                                                                                                                    =
                                                                                                                    v2017;
                                                                                                                {
                                                                                                                    let v2018:
                                                                                                                            i32 =
                                                                                                                        v2014
                                                                                                                            +
                                                                                                                            1_i32;
                                                                                                                    v2012.l0.set(v2018);
                                                                                                                    ()
                                                                                                                }
                                                                                                            }
                                                                                                        {
                                                                                                            let v2025:
                                                                                                                        string =
                                                                                                                    sprintf!("pwsh -c \'{}; {}\'",
                                                                                                                             join(string(";"),
                                                                                                                                  toArray_1(ofArray_1(v2011.clone()))),
                                                                                                                             v1990);
                                                                                                            if v2008
                                                                                                                       ==
                                                                                                                       0_i32
                                                                                                                   {
                                                                                                                    let v2030:
                                                                                                                            Spiral_builder::US3 =
                                                                                                                        try_catch(||
                                                                                                                                      Spiral_builder::closure43((),
                                                                                                                                                                Spiral_builder::closure110(v2009.clone(),
                                                                                                                                                                                           ())),
                                                                                                                                  |ex_3:
                                                                                                                                       LrcPtr<Exception>|
                                                                                                                                      Spiral_builder::closure111(v1930.clone(),
                                                                                                                                                                 v2009.clone(),
                                                                                                                                                                 v2025.clone(),
                                                                                                                                                                 ex_3.clone()));
                                                                                                                    let v2035:
                                                                                                                            Option<string> =
                                                                                                                        match &v2030
                                                                                                                            {
                                                                                                                            Spiral_builder::US3::US3_0(v2030_0_0)
                                                                                                                            =>
                                                                                                                            Some(match &v2030
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
                                                                                                                    (Spiral_builder::US3::US3_0(v1987),
                                                                                                                     Spiral_builder::US3::US3_0(string("py")),
                                                                                                                     Spiral_builder::US3::US3_0(v2035.unwrap()))
                                                                                                                } else {
                                                                                                                    Spiral_builder::method5(Spiral_builder::US0::US0_4,
                                                                                                                                            Func0::new(move
                                                                                                                                                           ||
                                                                                                                                                           Spiral_builder::closure114((),
                                                                                                                                                                                      ())),
                                                                                                                                            Func0::new({
                                                                                                                                                           let v1930
                                                                                                                                                               =
                                                                                                                                                               v1930.clone();
                                                                                                                                                           let v2008
                                                                                                                                                               =
                                                                                                                                                               v2008.clone();
                                                                                                                                                           let v2009
                                                                                                                                                               =
                                                                                                                                                               v2009.clone();
                                                                                                                                                           let v2025
                                                                                                                                                               =
                                                                                                                                                               v2025.clone();
                                                                                                                                                           move
                                                                                                                                                               ||
                                                                                                                                                               Spiral_builder::closure115(v1930.clone(),
                                                                                                                                                                                          v2009.clone(),
                                                                                                                                                                                          v2008,
                                                                                                                                                                                          v2025.clone(),
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
                                                } else {
                                                    Spiral_builder::method5(
                                                        Spiral_builder::US0::US0_1,
                                                        Func0::new(move || {
                                                            Spiral_builder::closure116((), ())
                                                        }),
                                                        Func0::new({
                                                            let v13 = v13.clone();
                                                            let v14 = v14.clone();
                                                            move || {
                                                                Spiral_builder::closure117(
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
                                        let v2067: Spiral_builder::US3 = patternInput_18.2.clone();
                                        let v2066: Spiral_builder::US3 = patternInput_18.1.clone();
                                        let v2065: Spiral_builder::US3 = patternInput_18.0.clone();
                                        new_array(&[
                                            (
                                                string("extension"),
                                                match &v2066 {
                                                    Spiral_builder::US3::US3_0(v2066_0_0) => {
                                                        match &v2066 {
                                                            Spiral_builder::US3::US3_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        }
                                                    }
                                                    _ => string(""),
                                                },
                                            ),
                                            (
                                                string("code"),
                                                match &v2065 {
                                                    Spiral_builder::US3::US3_0(v2065_0_0) => {
                                                        match &v2065 {
                                                            Spiral_builder::US3::US3_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        }
                                                    }
                                                    _ => string(""),
                                                },
                                            ),
                                            (
                                                string("output"),
                                                match &v2067 {
                                                    Spiral_builder::US3::US3_0(v2067_0_0) => {
                                                        match &v2067 {
                                                            Spiral_builder::US3::US3_0(x) => {
                                                                x.clone()
                                                            }
                                                            _ => unreachable!(),
                                                        }
                                                    }
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
                        let v2094: Vec<(string, string)> = v2092.to_vec();
                        let v2097: Vec<LrcPtr<(std::string::String, std::string::String)>> = v2094
                            .into_iter()
                            .map(|x| {
                                Func1::new(move |arg10_0040_41: (string, string)| {
                                    Spiral_builder::closure118((), arg10_0040_41)
                                })(x.clone())
                            })
                            .collect::<Vec<_>>();
                        let v2098: string =
                        string("std::collections::BTreeMap::from_iter(v2097.iter().map(|x| x.as_ref()).map(|&(ref k, ref v)| (k.clone(), v.clone())))");
                        let v2099: std::collections::BTreeMap<
                            std::string::String,
                            std::string::String,
                        > = std::collections::BTreeMap::from_iter(
                            v2097
                                .iter()
                                .map(|x| x.as_ref())
                                .map(|&(ref k, ref v)| (k.clone(), v.clone())),
                        );
                        let v2101: Result<std::string::String, serde_json::Error> =
                            serde_json::to_string(&v2099);
                        let v2102 = Spiral_builder::method113();
                        let v2104: Result<std::string::String, string> =
                            v2101.map_err(|x| v2102(x));
                        let v2106: bool = true;
                        let _result = v2104.map(|x| {
                            //;
                            let v2108: std::string::String = x;
                            let v2110: string = fable_library_rust::String_::fromString(v2108);
                            let v2112: bool = true;
                            v2110
                        });
                        let v2115: Result<string, string> = Spiral_builder::method114(_result);
                        let v2124: string = string("v2115 }}}); {{ //");
                        v2115
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
